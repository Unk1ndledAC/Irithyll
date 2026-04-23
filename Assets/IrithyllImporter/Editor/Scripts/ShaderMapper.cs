using UnityEngine;
using UnityEditor;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace IrithyllImporter
{
    /// <summary>
    /// Shader mapping utility for converting Dark Souls 3 shader naming conventions
    /// to Unity-compatible shader equivalents
    /// </summary>
    public class ShaderMapper : EditorWindow
    {
        // ==================== Shader Mapping Tables ====================

        // Primary mapping: Dark Souls shader prefix -> Unity shader and properties
        private static Dictionary<string, ShaderMapping> primaryMappings = new Dictionary<string, ShaderMapping>
        {
            // Standard opaque materials (forward rendering)
            {
                "GXFlver_Col_Fwd", new ShaderMapping
                {
                    DisplayName = "Standard (Opaque)",
                    UnityShader = "Standard",
                    RenderQueue = 2000,
                    RenderType = "Opaque",
                    Properties = new List<string> { "_MainTex", "_Metallic", "_Glossiness", "_BumpScale", "_EmissionColor" }
                }
            },

            // Depth-only / shadow casting
            {
                "GXFlver_Col_Dpt", new ShaderMapping
                {
                    DisplayName = "Standard (Depth)",
                    UnityShader = "Standard",
                    RenderQueue = 2000,
                    RenderType = "Opaque",
                    Properties = new List<string> { "_MainTex" },
                    Notes = "Use for depth pre-pass optimization"
                }
            },

            // GBuffer / Deferred rendering
            {
                "GXFlver_Col_GBuf", new ShaderMapping
                {
                    DisplayName = "Standard (GBuffer)",
                    UnityShader = "Standard",
                    RenderQueue = 2000,
                    RenderType = "Opaque",
                    Properties = new List<string> { "_MainTex", "_Metallic", "_Glossiness", "_BumpMap", "_EmissionMap" },
                    Notes = "Designed for deferred rendering path"
                }
            },

            // Transparent variants (alpha blending)
            {
                "DptA", new ShaderMapping
                {
                    DisplayName = "Standard (Transparent)",
                    UnityShader = "Standard",
                    RenderQueue = 3000,
                    RenderType = "Transparent",
                    Properties = new List<string> { "_MainTex", "_Color" },
                    MaterialOverrides = new Dictionary<string, string>
                    {
                        { "_Mode", "Transparent" },
                        { "SrcBlend", "srcAlpha" },
                        { "DstBlend", "OneMinusSrcAlpha" },
                        { "ZWrite", "0" }
                    }
                }
            },

            // Skin / character materials
            {
                "Skin", new ShaderMapping
                {
                    DisplayName = "Standard (Skin/Character)",
                    UnityShader = "Standard (Specular setup)",
                    RenderQueue = 2000,
                    RenderType = "Opaque",
                    Properties = new List<string> { "_MainTex", "_BumpMap", "_Specular" },
                    Notes = "Uses specular workflow for skin shading"
                }
            },

            // Bloody / wet materials
            {
                "Bloody", new ShaderMapping
                {
                    DisplayName = "Standard (Bloody/Wet)",
                    UnityShader = "Standard",
                    RenderQueue = 2500,
                    RenderType = "TransparentCutout",
                    Properties = new List<string> { "_MainTex", "_BumpMap", "_Metallic", "_Glossiness" },
                    Notes = "Wet/specular appearance"
                }
            },

            // Cloth materials
            {
                "Cloth", new ShaderMapping
                {
                    DisplayName = "Standard (Cloth)",
                    UnityShader = "Standard",
                    RenderQueue = 2000,
                    RenderType = "Opaque",
                    Properties = new List<string> { "_MainTex", "_BumpMap", "_Metallic", "_Glossiness", "_Emission" },
                    Notes = "Fabric material properties"
                }
            },

            // Phantom / ghost materials
            {
                "Phantom", new ShaderMapping
                {
                    DisplayName = "Standard (Phantom/Ghost)",
                    UnityShader = "Particles/Standard Unlit",
                    RenderQueue = 3000,
                    RenderType = "Transparent",
                    Properties = new List<string> { "_MainTex", "_Color" },
                    MaterialOverrides = new Dictionary<string, string>
                    {
                        { "renderQueue", "3000" },
                        { "Instancing", "Disable" }
                    }
                }
            },

            // Velocity (motion blur)
            {
                "Velo", new ShaderMapping
                {
                    DisplayName = "Debug/MotionBlur",
                    UnityShader = "Sprites/Default",
                    RenderQueue = 2000,
                    RenderType = "Opaque",
                    Properties = new List<string> { "_MainTex" },
                    Notes = "Velocity buffer visualization"
                }
            }
        };

        // Instance variants (instancing support)
        private static string[] instancingSuffixes = new string[]
        {
            "_Ins",
            "_Ins@[cl]",
            "@[cl]"
        };

        // Skinning variants
        private static string[] skinningSuffixes = new string[]
        {
            "_Skin",
            "_Skin_Ins",
            "_Skin_Ins@[cl]"
        };

        // Lighting model variants
        private static string[] lightingVariants = new string[]
        {
            "Col_",        // Base color only
            "ColDif_",     // Color + Diffuse
            "ColSpc_",     // Color + Specular
            "ColDifSpc_",  // Color + Diffuse + Specular
            "ColDifSpcBump_"  // Full PBR
        };

        // Texture type detection patterns
        private static Dictionary<string, TextureType> texturePatterns = new Dictionary<string, TextureType>
        {
            { "_albedo", TextureType.Albedo },
            { "_diffuse", TextureType.Albedo },
            { "_color", TextureType.Albedo },
            { "_d", TextureType.Albedo },
            { "_nrm", TextureType.Normal },
            { "_normal", TextureType.Normal },
            { "_n", TextureType.Normal },
            { "_bump", TextureType.Normal },
            { "_spec", TextureType.Specular },
            { "_specular", TextureType.Specular },
            { "_spc", TextureType.Specular },
            { "_metal", TextureType.Metallic },
            { "_metallic", TextureType.Metallic },
            { "_mtl", TextureType.Metallic },
            { "_ao", TextureType.AmbientOcclusion },
            { "_ambient", TextureType.AmbientOcclusion },
            { "_emissive", TextureType.Emission },
            { "_emit", TextureType.Emission },
            { "_glow", TextureType.Emission },
            { "_gi", TextureType.Lightmap },  // Global Illumination
            { "_l", TextureType.Lightmap },    // Lighting map suffix
            { "_lightmap", TextureType.Lightmap }
        };

        // ==================== Data Structures ====================

        public class ShaderMapping
        {
            public string DisplayName { get; set; }
            public string UnityShader { get; set; }
            public int RenderQueue { get; set; }
            public string RenderType { get; set; }
            public List<string> Properties { get; set; } = new List<string>();
            public Dictionary<string, string> MaterialOverrides { get; set; }
            public string Notes { get; set; }
        }

        public enum TextureType
        {
            Albedo,
            Normal,
            Specular,
            Metallic,
            AmbientOcclusion,
            Emission,
            Lightmap,
            Height,
            Detail
        }

        public class TextureMapping
        {
            public string FileName { get; set; }
            public TextureType Type { get; set; }
            public bool IsLightmap { get; set; }
            public int AtlasIndex { get; set; }
            public string SourceShader { get; set; }
        }

        public class MaterialInfo
        {
            public string Name { get; set; }
            public string ShaderMapping { get; set; }
            public List<TextureMapping> Textures { get; set; } = new List<TextureMapping>();
            public bool HasNormalMap { get; set; }
            public bool HasSpecular { get; set; }
            public bool HasMetallic { get; set; }
            public bool IsTransparent { get; set; }
            public bool IsSkinned { get; set; }
        }

        // ==================== Main Mapping Methods ====================

        /// <summary>
        /// Maps a Dark Souls shader filename to Unity shader
        /// </summary>
        public static string MapShader(string shaderFileName)
        {
            if (string.IsNullOrEmpty(shaderFileName))
                return "Standard";

            string baseName = Path.GetFileNameWithoutExtension(shaderFileName);

            // Check for primary mappings
            foreach (var mapping in primaryMappings)
            {
                if (baseName.StartsWith(mapping.Key))
                {
                    return mapping.Value.UnityShader;
                }
            }

            // Analyze composite name
            return AnalyzeShaderComposition(baseName);
        }

        /// <summary>
        /// Analyzes complex shader names with multiple components
        /// </summary>
        private static string AnalyzeShaderComposition(string shaderName)
        {
            bool isTransparent = shaderName.Contains("DptA") || shaderName.Contains("Phantom");
            bool isSkinned = shaderName.Contains("Skin");
            bool isInstanced = shaderName.Contains("_Ins") || shaderName.Contains("@[cl]");
            bool hasSpecular = shaderName.Contains("Spc") || shaderName.Contains("Spec");
            bool hasNormal = shaderName.Contains("Bump") || shaderName.Contains("PN");

            // Determine shader based on properties
            if (isTransparent)
            {
                return "Particles/Standard Unlit";
            }
            else if (isSkinned)
            {
                return hasSpecular ? "Standard (Specular setup)" : "Standard";
            }
            else if (hasSpecular && hasNormal)
            {
                return "Standard (Specular setup)";
            }
            else if (hasSpecular || hasNormal)
            {
                return "Standard";
            }

            return "Standard";
        }

        /// <summary>
        /// Gets full material configuration for a shader
        /// </summary>
        public static ShaderMapping GetShaderMapping(string shaderFileName)
        {
            if (string.IsNullOrEmpty(shaderFileName))
                return primaryMappings["GXFlver_Col_Fwd"];

            string baseName = Path.GetFileNameWithoutExtension(shaderFileName);

            foreach (var mapping in primaryMappings)
            {
                if (baseName.StartsWith(mapping.Key))
                {
                    return mapping.Value;
                }
            }

            // Return default mapping
            return new ShaderMapping
            {
                DisplayName = "Standard",
                UnityShader = "Standard",
                RenderQueue = 2000,
                RenderType = "Opaque"
            };
        }

        /// <summary>
        /// Maps texture filename to its type
        /// </summary>
        public static TextureType MapTextureType(string textureFileName)
        {
            if (string.IsNullOrEmpty(textureFileName))
                return TextureType.Albedo;

            string lowerName = textureFileName.ToLower();

            foreach (var pattern in texturePatterns)
            {
                if (lowerName.Contains(pattern.Key))
                {
                    return pattern.Value;
                }
            }

            // Default to albedo if no pattern matches
            return TextureType.Albedo;
        }

        /// <summary>
        /// Parses Dark Souls texture naming convention
        /// Pattern: 37000000_m000040_gi_0000_00_dol_00_atlas000.dds
        /// </summary>
        public static TextureMapping ParseTextureFileName(string fileName)
        {
            var mapping = new TextureMapping
            {
                FileName = fileName
            };

            string lowerName = fileName.ToLower();

            // Extract model ID: m000040
            var match = Regex.Match(lowerName, @"m(\d+)");
            if (match.Success)
            {
                // Store model ID for matching with FBX files
            }

            // Check if it's a lightmap (contains _l or _gi)
            mapping.IsLightmap = lowerName.Contains("_l") || lowerName.Contains("_gi");

            // Determine texture type
            if (mapping.IsLightmap)
            {
                mapping.Type = TextureType.Lightmap;
            }
            else
            {
                mapping.Type = MapTextureType(fileName);
            }

            // Extract atlas index
            var atlasMatch = Regex.Match(lowerName, @"atlas(\d+)");
            if (atlasMatch.Success)
            {
                mapping.AtlasIndex = int.Parse(atlasMatch.Groups[1].Value);
            }

            return mapping;
        }

        /// <summary>
        /// Creates a Unity material based on Dark Souls shader info
        /// </summary>
        public static Material CreateMaterial(ShaderMapping mapping, Texture2D mainTexture)
        {
            Shader shader = Shader.Find(mapping.UnityShader);
            if (shader == null)
            {
                Debug.LogWarning($"Shader not found: {mapping.UnityShader}, using Standard");
                shader = Shader.Find("Standard");
            }

            Material mat = new Material(shader);

            // Set render settings
            mat.renderQueue = mapping.RenderQueue;

            // Apply material overrides
            if (mapping.MaterialOverrides != null)
            {
                foreach (var kvp in mapping.MaterialOverrides)
                {
                    // Handle special rendering modes
                    if (kvp.Key == "_Mode" && kvp.Value == "Transparent")
                    {
                        SetMaterialTransparent(mat);
                    }
                }
            }

            // Assign main texture
            if (mainTexture != null)
            {
                mat.SetTexture("_MainTex", mainTexture);
            }

            return mat;
        }

        /// <summary>
        /// Sets material to transparent rendering mode
        /// </summary>
        public static void SetMaterialTransparent(Material material)
        {
            material.SetFloat("_Mode", 3); // Transparent mode
            material.SetInt("SrcBlend", (int)UnityEngine.Rendering.BlendMode.SrcAlpha);
            material.SetInt("DstBlend", (int)UnityEngine.Rendering.BlendMode.OneMinusSrcAlpha);
            material.SetInt("ZWrite", 0);
            material.DisableKeyword("_ALPHATEST_ON");
            material.EnableKeyword("_ALPHABLEND_ON");
            material.DisableKeyword("_ALPHAPREMULTIPLY_ON");
            material.renderQueue = 3000;
        }

        /// <summary>
        /// Gets the shader mapping statistics
        /// </summary>
        public static void PrintMappingStats()
        {
            Debug.Log("=== Shader Mapping Statistics ===");
            foreach (var mapping in primaryMappings)
            {
                Debug.Log($"  {mapping.Key}: {mapping.Value.DisplayName} -> {mapping.Value.UnityShader}");
            }
            Debug.Log("================================");
        }

        // ==================== GUI Window ====================

        [MenuItem("Tools/Irithyll/Shader Mapper")]
        public static void ShowShaderMapperWindow()
        {
            var window = GetWindow<ShaderMapper>("Shader映射器");
            window.minSize = new Vector2(500, 400);
        }

        void OnGUI()
        {
            GUILayout.Label("Dark Souls 3 → Unity Shader 映射表", EditorStyles.boldLabel);
            GUILayout.Space(10);

            scrollPos = EditorGUILayout.BeginScrollView(scrollPos);

            EditorGUILayout.BeginVertical(EditorStyles.helpBox);
            foreach (var mapping in primaryMappings)
            {
                EditorGUILayout.LabelField($"📛 {mapping.Key}", EditorStyles.boldLabel);
                EditorGUI.indentLevel++;
                EditorGUILayout.LabelField($"   Unity Shader: {mapping.Value.UnityShader}");
                EditorGUILayout.LabelField($"   显示名称: {mapping.Value.DisplayName}");
                EditorGUILayout.LabelField($"   渲染队列: {mapping.Value.RenderQueue}");
                EditorGUILayout.LabelField($"   渲染类型: {mapping.Value.RenderType}");
                if (!string.IsNullOrEmpty(mapping.Value.Notes))
                {
                    EditorGUILayout.HelpBox(mapping.Value.Notes, MessageType.None);
                }
                EditorGUI.indentLevel--;
                GUILayout.Space(5);
            }
            EditorGUILayout.EndVertical();

            EditorGUILayout.EndScrollView();

            GUILayout.Space(10);
            if (GUILayout.Button("打印映射表到控制台"))
            {
                PrintMappingStats();
            }

            GUILayout.Space(5);
            if (GUILayout.Button("测试纹理类型检测"))
            {
                TestTextureDetection();
            }
        }

        private Vector2 scrollPos;

        private void TestTextureDetection()
        {
            string[] testNames = new string[]
            {
                "37000000_m000040_gi_0000_00_dol_00_atlas000_l.dds",
                "37000000_m000040_gi_0000_00_dol_00_atlas000.dds",
                "diffuse_texture.png",
                "normal_map.png",
                "specular.png"
            };

            foreach (var name in testNames)
            {
                var mapping = ParseTextureFileName(name);
                Debug.Log($"{name} -> Type: {mapping.Type}, IsLightmap: {mapping.IsLightmap}");
            }
        }
    }
}
