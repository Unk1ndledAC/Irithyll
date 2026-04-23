using UnityEngine;
using UnityEditor;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;
using System.Linq;

namespace IrithyllImporter
{
    /// <summary>
    /// Parser for Dark Souls 3 FXR particle effect XML files
    /// Extracts particle parameters and generates Unity ParticleSystem configurations
    /// </summary>
    public class FXRParticleParser
    {
        // ==================== Data Structures ====================

        public class FXREffect
        {
            public string FileName { get; set; }
            public string EffectId { get; set; }
            public List<ParticleEmitter> Emitters { get; set; } = new List<ParticleEmitter>();
        }

        public class ParticleEmitter
        {
            public int ContainerId { get; set; }
            public string Name { get; set; }
            public EmitterShape Shape { get; set; } = EmitterShape.Point;
            public float Duration { get; set; } = 2.0f;
            public float Lifetime { get; set; } = 2.0f;
            public float StartSpeed { get; set; } = 1.0f;
            public float StartSize { get; set; } = 0.1f;
            public int EmissionRate { get; set; } = 50;
            public Color StartColor { get; set; } = Color.white;
            public Vector3 Gravity { get; set; } = Vector3.zero;
            public Vector3 Velocity { get; set; } = Vector3.zero;
            public List<ColorKey> ColorOverLifetime { get; set; } = new List<ColorKey>();
            public List<float> SizeOverLifetime { get; set; } = new List<float>();
        }

        public enum EmitterShape
        {
            Point,
            Sphere,
            Hemisphere,
            Cone,
            Box,
            Mesh,
            Circle,
            Edge
        }

        public class ColorKey
        {
            public float Time { get; set; }
            public Color Color { get; set; }
        }

        // ==================== Parsing Methods ====================

        public void ParseDirectory(string sourceDir, string outputDir)
        {
            if (!Directory.Exists(sourceDir))
            {
                UnityEngine.Debug.LogError($"[FXR解析] FXR目录不存在: {sourceDir}");
                UnityEngine.Debug.LogError($"[FXR解析] 请检查以下路径是否存在，或在编辑器中配置正确的源目录");
                UnityEngine.Debug.LogError($"[FXR解析] 预期路径: {sourceDir}");
                
                // 尝试列出父目录内容以帮助诊断
                string parentDir = Path.GetDirectoryName(sourceDir);
                if (Directory.Exists(parentDir))
                {
                    UnityEngine.Debug.LogWarning($"[FXR解析] 父目录 '{parentDir}' 存在，内容如下:");
                    var entries = Directory.GetFileSystemEntries(parentDir);
                    foreach (var entry in entries)
                    {
                        UnityEngine.Debug.LogWarning($"  - {entry}");
                    }
                }
                else
                {
                    UnityEngine.Debug.LogWarning($"[FXR解析] 父目录也不存在: {parentDir}");
                }
                return;
            }

            EnsureDirectoryExists(outputDir);

            string[] xmlFiles = Directory.GetFiles(sourceDir, "*.fxr.xml");
            int total = xmlFiles.Length;
            int processed = 0;

            if (total == 0)
            {
                UnityEngine.Debug.LogWarning($"[FXR解析] 在 '{sourceDir}' 中未找到 .fxr.xml 文件");
                UnityEngine.Debug.LogWarning($"[FXR解析] 请确保FXR文件已转换为XML格式");
            }

            foreach (string xmlFile in xmlFiles)
            {
                try
                {
                    ParseFile(xmlFile, outputDir);
                }
                catch (Exception e)
                {
                    UnityEngine.Debug.LogWarning($"解析失败 {Path.GetFileName(xmlFile)}: {e.Message}");
                }

                processed++;
                EditorUtility.DisplayProgressBar("解析粒子特效", $"处理中: {Path.GetFileName(xmlFile)}", (float)processed / total);
            }

            EditorUtility.ClearProgressBar();
            UnityEngine.Debug.Log($"粒子特效解析完成: {processed}/{total}");
        }

        public void ParseFile(string xmlPath, string outputDir)
        {
            XDocument doc = XDocument.Load(xmlPath);
            XElement root = doc.Root;

            if (root == null || root.Name.LocalName != "FXR3")
            {
                UnityEngine.Debug.LogWarning($"无效的FXR格式: {xmlPath}");
                return;
            }

            string effectId = root.Element("Id")?.Value ?? "Unknown";
            string fileName = root.Element("filename")?.Value ?? Path.GetFileNameWithoutExtension(xmlPath);

            FXREffect effect = new FXREffect
            {
                FileName = fileName,
                EffectId = effectId
            };

            // Parse containers and effects
            ParseContainers(root, effect);

            // Generate Unity ParticleSystem prefab or script
            GenerateParticleScript(effect, outputDir);
        }

        private void ParseContainers(XElement root, FXREffect effect)
        {
            var containers = root.Descendants("Container");
            foreach (var container in containers)
            {
                ParseContainer(container, effect);
            }
        }

        private void ParseContainer(XElement container, FXREffect effect)
        {
            int containerId = int.Parse(container.Attribute("Id")?.Value ?? "0");

            // Parse effects within container
            var effects = container.Descendants("Effect");
            foreach (var effectElement in effects)
            {
                ParticleEmitter emitter = ParseEffect(effectElement, containerId);
                if (emitter != null)
                {
                    effect.Emitters.Add(emitter);
                }
            }

            // Parse nested containers
            var nestedContainers = container.Elements("Containers");
            foreach (var nested in nestedContainers.Elements("Container"))
            {
                ParseContainer(nested, effect);
            }
        }

        private ParticleEmitter ParseEffect(XElement effectElement, int containerId)
        {
            ParticleEmitter emitter = new ParticleEmitter
            {
                ContainerId = containerId,
                Name = $"Emitter_{effectElement.Attribute("Id")?.Value ?? "0"}"
            };

            var actions = effectElement.Elements("Actions").Elements("Action");

            foreach (var action in actions)
            {
                int actionId = int.Parse(action.Attribute("Id")?.Value ?? "0");
                ParseAction(action, actionId, emitter);
            }

            // Only add if we found meaningful particle data
            if (emitter.EmissionRate > 0 || emitter.Duration > 0)
            {
                return emitter;
            }

            return null;
        }

        private void ParseAction(XElement action, int actionId, ParticleEmitter emitter)
        {
            XElement fields1 = action.Element("Fields1");
            XElement properties1 = action.Element("Properties1");

            switch (actionId)
            {
                case 605: // Main particle emitter settings
                    ParseEmitterSettings(fields1, properties1, emitter);
                    break;
                case 128: // Duration/Lifetime
                    ParseLifetimeSettings(fields1, properties1, emitter);
                    break;
                case 129: // Emission rate
                    ParseEmissionSettings(fields1, properties1, emitter);
                    break;
                case 130: // Shape/Size
                    ParseShapeSettings(fields1, properties1, emitter);
                    break;
                case 131: // Color
                    ParseColorSettings(fields1, properties1, emitter);
                    break;
                case 35: // Gravity
                    ParseGravitySettings(fields1, emitter);
                    break;
                case 132: // Velocity
                    ParseVelocitySettings(fields1, emitter);
                    break;
                default:
                    break;
            }
        }

        private void ParseEmitterSettings(XElement fields1, XElement properties1, ParticleEmitter emitter)
        {
            if (fields1 == null) return;

            var ints = fields1.Elements("Int").ToList();
            var floats = fields1.Elements("Float").ToList();

            // Field indices based on FXR format analysis
            // Field[1] = Shape type
            if (ints.Count > 1)
            {
                int shapeType = int.Parse(ints[1].Attribute("Value")?.Value ?? "0");
                emitter.Shape = (EmitterShape)Math.Min(shapeType, (int)EmitterShape.Box);
            }

            // Velocity from Fields
            if (floats.Count >= 3)
            {
                emitter.Velocity = new Vector3(
                    float.Parse(floats[0].Attribute("Value")?.Value ?? "0"),
                    float.Parse(floats[1].Attribute("Value")?.Value ?? "0"),
                    float.Parse(floats[2].Attribute("Value")?.Value ?? "0")
                );
            }
        }

        private void ParseLifetimeSettings(XElement fields1, XElement properties1, ParticleEmitter emitter)
        {
            if (properties1 == null) return;

            var props = properties1.Elements("Property").ToList();
            if (props.Count > 0)
            {
                var fields = props[0].Element("Fields");
                if (fields != null)
                {
                    var floatVal = fields.Element("Float");
                    if (floatVal != null)
                    {
                        float value = float.Parse(floatVal.Attribute("Value")?.Value ?? "0");
                        // Value is typically in seconds (negative means follow time scale)
                        emitter.Duration = Math.Abs(value) > 0.01f ? Math.Abs(value) : 2.0f;
                        emitter.Lifetime = emitter.Duration;
                    }
                }
            }
        }

        private void ParseEmissionSettings(XElement fields1, XElement properties1, ParticleEmitter emitter)
        {
            if (fields1 == null) return;

            var ints = fields1.Elements("Int").ToList();
            if (ints.Count > 0)
            {
                int rate = int.Parse(ints[0].Attribute("Value")?.Value ?? "50");
                emitter.EmissionRate = Math.Max(rate, 1);
            }

            if (properties1 == null) return;

            var props = properties1.Elements("Property").ToList();
            if (props.Count > 0)
            {
                var fields = props[0].Element("Fields");
                if (fields != null)
                {
                    var floatVal = fields.Element("Float");
                    if (floatVal != null)
                    {
                        float value = float.Parse(floatVal.Attribute("Value")?.Value ?? "0");
                        emitter.EmissionRate = (int)(Math.Abs(value) * 100);
                    }
                }
            }
        }

        private void ParseShapeSettings(XElement fields1, XElement properties1, ParticleEmitter emitter)
        {
            if (fields1 == null) return;

            var floats = fields1.Elements("Float").ToList();
            // Size values are usually in the first few floats
            if (floats.Count >= 1)
            {
                emitter.StartSize = float.Parse(floats[0].Attribute("Value")?.Value ?? "0.1f");
                if (emitter.StartSize < 0.001f) emitter.StartSize = 0.1f;
            }
        }

        private void ParseColorSettings(XElement fields1, XElement properties1, ParticleEmitter emitter)
        {
            if (properties1 == null) return;

            var props = properties1.Elements("Property").ToList();
            foreach (var prop in props)
            {
                string propType = prop.Attribute("PropertyType")?.Value ?? "";
                if (propType == "Color")
                {
                    var fields = prop.Element("Fields");
                    if (fields != null)
                    {
                        var floats = fields.Elements("Float").ToList();
                        if (floats.Count >= 4)
                        {
                            // RGBA format
                            emitter.StartColor = new Color(
                                float.Parse(floats[0].Attribute("Value")?.Value ?? "1"),
                                float.Parse(floats[1].Attribute("Value")?.Value ?? "1"),
                                float.Parse(floats[2].Attribute("Value")?.Value ?? "1"),
                                floats.Count > 3 ? float.Parse(floats[3].Attribute("Value")?.Value ?? "1") : 1f
                            );

                            // Parse color over lifetime
                            emitter.ColorOverLifetime.Add(new ColorKey { Time = 0f, Color = emitter.StartColor });
                            emitter.ColorOverLifetime.Add(new ColorKey { Time = 1f, Color = emitter.StartColor });
                        }
                    }
                }
            }
        }

        private void ParseGravitySettings(XElement fields1, ParticleEmitter emitter)
        {
            if (fields1 == null) return;

            var ints = fields1.Elements("Int").ToList();
            // Gravity is typically derived from specific field indices
            if (ints.Count >= 3)
            {
                emitter.Gravity = new Vector3(0, -9.8f, 0); // Default gravity
            }
        }

        private void ParseVelocitySettings(XElement fields1, ParticleEmitter emitter)
        {
            if (fields1 == null) return;

            var ints = fields1.Elements("Int").ToList();
            if (ints.Count > 0)
            {
                // Velocity scale value
                int velocityId = int.Parse(ints[0].Attribute("Value")?.Value ?? "0");
                emitter.StartSpeed = Math.Abs(velocityId) * 0.1f;
                if (emitter.StartSpeed < 0.1f) emitter.StartSpeed = 1.0f;
            }
        }

        // ==================== Unity Generation ====================

        private void GenerateParticleScript(FXREffect effect, string outputDir)
        {
            if (effect.Emitters.Count == 0)
            {
                // Still create a script for the effect even with no emitters
                effect.Emitters.Add(new ParticleEmitter());
            }

            string scriptContent = GenerateCSharpScript(effect);
            string scriptName = SanitizeFileName(effect.FileName);
            string scriptPath = Path.Combine(outputDir, $"{scriptName}.cs");

            File.WriteAllText(scriptPath, scriptContent);
        }

        private string GenerateCSharpScript(FXREffect effect)
        {
            var sb = new System.Text.StringBuilder();

            sb.AppendLine("using UnityEngine;");
            sb.AppendLine();
            sb.AppendLine("namespace IrithyllParticles");
            sb.AppendLine("{");
            sb.AppendLine($"    /// <summary>");
            sb.AppendLine($"    /// Auto-generated particle effect script");
            sb.AppendLine($"    /// Source: {effect.FileName}");
            sb.AppendLine($"    /// Effect ID: {effect.EffectId}");
            sb.AppendLine($"    /// Generated emitters: {effect.Emitters.Count}");
            sb.AppendLine($"    /// </summary>");
            sb.AppendLine($"    public class {SanitizeFileName(effect.FileName)} : MonoBehaviour");
            sb.AppendLine("    {");

            // Generate setup method
            sb.AppendLine("        void Start()");
            sb.AppendLine("        {");
            sb.AppendLine("            SetupParticles();");
            sb.AppendLine("        }");
            sb.AppendLine();

            // Generate particle setup
            sb.AppendLine("        void SetupParticles()");
            sb.AppendLine("        {");

            for (int i = 0; i < effect.Emitters.Count; i++)
            {
                var emitter = effect.Emitters[i];
                int idx = i + 1;
                string idxStr = idx.ToString();
                
                sb.AppendLine($"            // Emitter {idxStr}: {emitter.Name}");
                sb.AppendLine($"            GameObject emitter{idxStr} = new GameObject(\"Emitter_{idxStr}\");");
                sb.AppendLine($"            emitter{idxStr}.transform.SetParent(transform);");
                sb.AppendLine($"            emitter{idxStr}.transform.localPosition = Vector3.zero;");
                sb.AppendLine();
                sb.AppendLine($"            ParticleSystem ps{idxStr} = emitter{idxStr}.AddComponent<ParticleSystem>();");
                sb.AppendLine($"            var main{idxStr} = ps{idxStr}.main;");
                sb.AppendLine($"            main{idxStr}.duration = {emitter.Duration:F2}f;");
                sb.AppendLine($"            main{idxStr}.startLifetime = {emitter.Lifetime:F2}f;");
                sb.AppendLine($"            main{idxStr}.startSpeed = {emitter.StartSpeed:F2}f;");
                sb.AppendLine($"            main{idxStr}.startSize = {emitter.StartSize:F3}f;");
                sb.AppendLine($"            main{idxStr}.simulationSpace = ParticleSystemSimulationSpace.World;");
                sb.AppendLine();
                sb.AppendLine($"            // Emission");
                sb.AppendLine($"            var emission{idxStr} = ps{idxStr}.emission;");
                sb.AppendLine($"            emission{idxStr}.rateOverTime = {emitter.EmissionRate};");
                sb.AppendLine();

                // Shape configuration
                sb.AppendLine($"            // Shape");
                sb.AppendLine($"            var shape{idxStr} = ps{idxStr}.shape;");
                sb.AppendLine($"            shape{idxStr}.shapeType = ParticleSystemShapeType.{GetShapeType(emitter.Shape)};");
                sb.AppendLine($"            shape{idxStr}.radius = 0.5f;");
                sb.AppendLine();

                // Color
                if (emitter.ColorOverLifetime.Count >= 2)
                {
                    sb.AppendLine($"            // Color over lifetime");
                    sb.AppendLine($"            var color{idxStr} = ps{idxStr}.colorOverLifetime;");
                    sb.AppendLine($"            color{idxStr}.enabled = true;");
                    sb.AppendLine($"            Gradient gradient{idxStr} = new Gradient();");
                    sb.AppendLine($"            gradient{idxStr}.SetKeys(");
                    sb.AppendLine($"                new GradientColorKey[] {{");
                    for (int c = 0; c < emitter.ColorOverLifetime.Count; c++)
                    {
                        var ck = emitter.ColorOverLifetime[c];
                        string comma = c < emitter.ColorOverLifetime.Count - 1 ? "," : "";
                        sb.AppendLine($"                    new GradientColorKey(new Color({ck.Color.r:F2}f, {ck.Color.g:F2}f, {ck.Color.b:F2}f), {ck.Time:F2}f){comma}");
                    }
                    sb.AppendLine($"                }},");
                    sb.AppendLine($"                new GradientAlphaKey[] {{");
                    sb.AppendLine($"                    new GradientAlphaKey({emitter.StartColor.a:F2}f, 0f),");
                    sb.AppendLine($"                    new GradientAlphaKey({emitter.StartColor.a:F2}f, 1f)");
                    sb.AppendLine($"                }}");
                    sb.AppendLine($"            );");
                    sb.AppendLine($"            color{idxStr}.color = gradient{idxStr};");
                    sb.AppendLine();
                }

                // Size over lifetime
                if (emitter.SizeOverLifetime.Count > 0)
                {
                    sb.AppendLine($"            // Size over lifetime");
                    sb.AppendLine($"            var size{idxStr} = ps{idxStr}.sizeOverLifetime;");
                    sb.AppendLine($"            size{idxStr}.enabled = true;");
                    sb.AppendLine($"            AnimationCurve sizeCurve{idxStr} = new AnimationCurve();");
                    foreach (var size in emitter.SizeOverLifetime)
                    {
                        sb.AppendLine($"            sizeCurve{idxStr}.AddKey(0.5f, {size:F3}f);");
                    }
                    if (emitter.SizeOverLifetime.Count == 0)
                    {
                        sb.AppendLine($"            sizeCurve{idxStr}.AddKey(0f, 1f);");
                        sb.AppendLine($"            sizeCurve{idxStr}.AddKey(1f, 1f);");
                    }
                    sb.AppendLine($"            size{idxStr}.size = new ParticleSystem.MinMaxCurve(1f, sizeCurve{idxStr});");
                    sb.AppendLine();
                }

                // Renderer settings
                sb.AppendLine($"            // Renderer");
                sb.AppendLine($"            ParticleSystemRenderer renderer{idxStr} = emitter{idxStr}.GetComponent<ParticleSystemRenderer>();");
                sb.AppendLine($"            renderer{idxStr}.renderMode = ParticleSystemRenderMode.Billboard;");
                sb.AppendLine($"            // Note: Assign particle material for visual output");
                sb.AppendLine();
            }

            sb.AppendLine("        }");
            sb.AppendLine("    }");
            sb.AppendLine("}");

            return sb.ToString();
        }

        private string GetShapeType(EmitterShape shape)
        {
            // Unity ParticleSystemShapeType 有效值：None, Box, Circle, Cone, ConeShell, ConeVolume, 
            // Cubemap, Cylinder, Hemisphere, Mesh, MeshRenderer, SkinnedMeshRenderer, Sphere, Sprite, SpriteRenderer
            // 注意：Unity没有 "Point" 类型！
            switch (shape)
            {
                case EmitterShape.Point:
                case EmitterShape.Sphere:
                    return "Sphere";
                case EmitterShape.Hemisphere:
                    return "Hemisphere";
                case EmitterShape.Cone:
                    return "Cone";
                case EmitterShape.Box:
                default:
                    return "Box";
                case EmitterShape.Mesh:
                    return "Mesh";
                case EmitterShape.Circle:
                    return "Circle";
                case EmitterShape.Edge:
                    return "None"; // 使用 None 作为 Edge 的替代
            }
        }

        private string SanitizeFileName(string name)
        {
            // Remove invalid chars and ensure valid class name
            string sanitized = System.Text.RegularExpressions.Regex.Replace(name, @"[^a-zA-Z0-9_]", "_");
            if (char.IsDigit(sanitized[0]))
            {
                sanitized = "FX_" + sanitized;
            }
            return sanitized;
        }

        private void EnsureDirectoryExists(string path)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
        }
    }
}
