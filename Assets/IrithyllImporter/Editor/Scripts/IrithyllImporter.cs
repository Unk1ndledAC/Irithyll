using UnityEngine;
using UnityEditor;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace IrithyllImporter
{
    /// <summary>
    /// Main importer tool for Irithyll (Dark Souls 3) assets to Unity 2022.3.52f1c1
    /// Handles: Models, Textures, Materials, Particles, Scene Building
    /// </summary>
    public class IrithyllImporter : EditorWindow
    {
        // ==================== Path Configuration ====================
        private string[] sourcePaths = new string[]
        {
            @"D:\Unity Projects\map\model",
            @"D:\Unity Projects\map\texture\dds",
            @"D:\Unity Projects\map\texture\png",
            @"D:\Unity Projects\sfx\resource\model",
            @"D:\Unity Projects\sfx\resource\texture",
            @"D:\Unity Projects\sfx\effect"
        };

        private string unityProjectRoot = @"D:\Unity Projects\Irithyll";

        // ==================== Import Settings ====================
        private float modelScaleFactor = 100.0f;
        private int textureMaxSize = 2048;
        private bool generateMipmaps = true;
        private bool generateColliders = true;

        // ==================== Progress Tracking ====================
        private string currentOperation = "";
        private float progress = 0f;

        // ==================== GUI ====================
        private Vector2 scrollPosition;

        [MenuItem("Tools/Irithyll/Import Manager")]
        public static void ShowWindow()
        {
            var window = GetWindow<IrithyllImporter>("Irithyll导入管理器");
            window.minSize = new Vector2(600, 500);
        }

        void OnGUI()
        {
            scrollPosition = EditorGUILayout.BeginScrollView(scrollPosition);

            // Header
            EditorGUILayout.Space(10);
            EditorGUILayout.LabelField("🎮 Irithyll 资源导入管理器", EditorStyles.boldLabel);
            EditorGUILayout.LabelField("Dark Souls 3 → Unity 2022.3.52f1c1", EditorStyles.miniLabel);
            EditorGUILayout.Space(10);

            // ==================== Section 1: Path Configuration ====================
            DrawSectionHeader("📁 路径配置", 1);

            EditorGUI.indentLevel++;
            unityProjectRoot = EditorGUILayout.TextField("Unity项目根目录", unityProjectRoot);

            EditorGUILayout.BeginHorizontal();
            if (GUILayout.Button("浏览Unity项目", GUILayout.Width(150)))
            {
                string selected = EditorUtility.OpenFolderPanel("选择Unity项目", @"D:\Unity Projects", "Irithyll");
                if (!string.IsNullOrEmpty(selected)) unityProjectRoot = selected;
            }
            EditorGUILayout.EndHorizontal();
            EditorGUI.indentLevel--;

            EditorGUILayout.Space(15);

            // ==================== Section 2: Import Settings ====================
            DrawSectionHeader("⚙️ 导入设置", 2);

            EditorGUI.indentLevel++;
            modelScaleFactor = EditorGUILayout.FloatField("模型缩放倍数", modelScaleFactor);
            textureMaxSize = EditorGUILayout.IntPopup("贴图最大尺寸", textureMaxSize,
                new string[] { "256", "512", "1024", "2048", "4096" },
                new int[] { 256, 512, 1024, 2048, 4096 });
            generateMipmaps = EditorGUILayout.Toggle("生成Mipmap", generateMipmaps);
            generateColliders = EditorGUILayout.Toggle("生成碰撞体", generateColliders);
            EditorGUI.indentLevel--;

            EditorGUILayout.Space(15);

            // ==================== Section 3: Import Operations ====================
            DrawSectionHeader("🔄 导入操作", 3);

            EditorGUILayout.BeginVertical(EditorStyles.helpBox);
            
            // 步骤1
            EditorGUILayout.BeginHorizontal();
            EditorGUILayout.LabelField("1️⃣ 步骤1: 导入贴图资源", GUILayout.Width(220));
            if (GUILayout.Button("执行", GUILayout.Width(80)))
            {
                ImportTextures();
            }
            EditorGUILayout.EndHorizontal();
            EditorGUILayout.HelpBox("复制并转换DDS贴图到Unity项目", MessageType.None);
            EditorGUILayout.Space(5);

            // 步骤2
            EditorGUILayout.BeginHorizontal();
            EditorGUILayout.LabelField("2️⃣ 步骤2: 导入模型资源", GUILayout.Width(220));
            if (GUILayout.Button("执行", GUILayout.Width(80)))
            {
                ImportModels();
            }
            EditorGUILayout.EndHorizontal();
            EditorGUILayout.HelpBox("复制FBX白模到Unity项目", MessageType.None);
            EditorGUILayout.Space(5);

            // 步骤3
            EditorGUILayout.BeginHorizontal();
            EditorGUILayout.LabelField("3️⃣ 步骤3: 创建材质", GUILayout.Width(220));
            if (GUILayout.Button("执行", GUILayout.Width(80)))
            {
                CreateMaterials();
            }
            EditorGUILayout.EndHorizontal();
            EditorGUILayout.HelpBox("根据贴图自动生成材质", MessageType.None);
            EditorGUILayout.Space(5);

            // 步骤4
            EditorGUILayout.BeginHorizontal();
            EditorGUILayout.LabelField("4️⃣ 步骤4: 解析粒子特效", GUILayout.Width(220));
            if (GUILayout.Button("执行", GUILayout.Width(80)))
            {
                ParseParticles();
            }
            EditorGUILayout.EndHorizontal();
            EditorGUILayout.HelpBox("解析FXR XML并生成Unity粒子配置", MessageType.None);
            EditorGUILayout.Space(5);

            // 步骤5
            EditorGUILayout.BeginHorizontal();
            EditorGUILayout.LabelField("5️⃣ 步骤5: 构建场景", GUILayout.Width(220));
            if (GUILayout.Button("执行", GUILayout.Width(80)))
            {
                BuildScene();
            }
            EditorGUILayout.EndHorizontal();
            EditorGUILayout.HelpBox("组装场景层级结构", MessageType.None);
            EditorGUILayout.Space(5);

            // 完整导入
            GUI.backgroundColor = new Color(0.8f, 1f, 0.8f);
            if (GUILayout.Button("🚀 6️⃣ 步骤6: 完整导入 (一键执行所有步骤)", GUILayout.Height(35)))
            {
                RunFullImport();
            }
            GUI.backgroundColor = Color.white;
            
            EditorGUILayout.EndVertical();

            EditorGUILayout.Space(15);

            // ==================== Section 4: Progress ====================
            DrawSectionHeader("📊 当前进度", 4);

            if (!string.IsNullOrEmpty(currentOperation))
            {
                EditorGUILayout.LabelField("当前操作:", currentOperation);
                Rect progressRect = GUILayoutUtility.GetRect(500, 20);
                progressRect.width = Mathf.Min(500, EditorGUIUtility.currentViewWidth - 40);
                EditorGUI.ProgressBar(progressRect, progress, $"{progress * 100:F1}%");
            }
            else
            {
                EditorGUILayout.HelpBox("点击上方按钮开始导入流程", MessageType.Info);
            }

            EditorGUILayout.Space(15);

            // ==================== Section 5: Utility Tools ====================
            DrawSectionHeader("🛠️ 工具", 5);

            EditorGUILayout.BeginHorizontal();
            if (GUILayout.Button("刷新资源"))
            {
                RefreshAssets();
            }
            if (GUILayout.Button("打开Unity项目"))
            {
                OpenUnityProject();
            }
            if (GUILayout.Button("打开Irithyll目录"))
            {
                OpenOutputDirectory();
            }
            EditorGUILayout.EndHorizontal();

            EditorGUILayout.EndScrollView();
        }

        // ==================== Helper Methods ====================

        private void DrawSectionHeader(string title, int stepNumber)
        {
            EditorGUILayout.BeginHorizontal();
            EditorGUILayout.LabelField(title, EditorStyles.boldLabel);
            GUILayout.FlexibleSpace();
            EditorGUILayout.LabelField($"Step {stepNumber}/6", EditorStyles.miniLabel);
            EditorGUILayout.EndHorizontal();
            EditorGUILayout.LabelField("", GUI.skin.horizontalSlider);
        }

        // ==================== Import Steps ====================

        private void ImportTextures()
        {
            currentOperation = "正在导入贴图资源...";
            progress = 0f;

            try
            {
                string targetDir = Path.Combine(unityProjectRoot, "Assets", "Irithyll", "Textures", "Map");
                EnsureDirectoryExists(targetDir);

                // 直接复制PNG源文件
                string pngSource = @"D:\Unity Projects\map\texture\png";
                if (Directory.Exists(pngSource))
                {
                    UnityEngine.Debug.Log("使用PNG源文件导入...");
                    progress = 0.3f;
                    CopyPNGTextures();
                }
                else
                {
                    throw new Exception($"PNG源目录不存在: {pngSource}");
                }

                progress = 0.8f;
                ConfigureTextures();
                progress = 1f;
                currentOperation = "✅ 贴图导入完成!";
                UnityEngine.Debug.Log("贴图导入完成！共 " + Directory.GetFiles(targetDir, "*.png").Length + " 个文件");
            }
            catch (Exception e)
            {
                progress = 0f;
                UnityEngine.Debug.LogError($"贴图导入失败: {e.Message}\n{e.StackTrace}");
                currentOperation = "❌ 贴图导入失败!";
            }
        }

        private void CopyPNGTextures()
        {
            string pngSource = @"D:\Unity Projects\map\texture\png";
            string pngTarget = Path.Combine(unityProjectRoot, "Assets", "Irithyll", "Textures", "Map");

            EnsureDirectoryExists(pngTarget);

            if (!Directory.Exists(pngSource))
            {
                throw new Exception($"PNG源目录不存在: {pngSource}");
            }

            string[] pngFiles = Directory.GetFiles(pngSource, "*.png");
            int total = pngFiles.Length;
            int copied = 0;

            foreach (string pngFile in pngFiles)
            {
                string fileName = Path.GetFileName(pngFile);
                // Remove _lout and out suffixes
                fileName = fileName.Replace("_lout", "").Replace("out", "");

                string destPath = Path.Combine(pngTarget, fileName);

                if (!File.Exists(destPath))
                {
                    File.Copy(pngFile, destPath, true);
                }

                copied++;
                progress = 0.3f + (0.5f * copied / total);
                currentOperation = $"复制PNG: {fileName} ({copied}/{total})";
                EditorUtility.DisplayProgressBar("复制PNG", fileName, (float)copied / total);
            }

            EditorUtility.ClearProgressBar();
            UnityEngine.Debug.Log($"PNG复制完成: {copied}/{total}");
        }

        private void ConfigureTextures()
        {
            string textureDir = Path.Combine(unityProjectRoot, "Assets", "Irithyll", "Textures");
            if (!Directory.Exists(textureDir)) return;

            string assetPath = "Assets/Irithyll/Textures";
            string[] textures = Directory.GetFiles(textureDir, "*.png", SearchOption.AllDirectories);
            int total = textures.Length;
            int configured = 0;

            foreach (string texPath in textures)
            {
                string relativePath = texPath.Replace(unityProjectRoot + Path.DirectorySeparatorChar, "");
                relativePath = relativePath.Replace("\\", "/");
                
                TextureImporter importer = AssetImporter.GetAtPath(relativePath) as TextureImporter;
                if (importer != null)
                {
                    importer.maxTextureSize = textureMaxSize;
                    importer.mipmapEnabled = generateMipmaps;
                    importer.textureType = TextureImporterType.Default;
                    importer.sRGBTexture = true;

                    // Auto-detect texture type based on filename
                    string fileName = Path.GetFileNameWithoutExtension(texPath);
                    if (fileName.Contains("_l") || (fileName.Contains("atlas") && fileName.Contains("l")))
                    {
                        importer.sRGBTexture = false;
                    }

                    importer.SaveAndReimport();
                }

                configured++;
                EditorUtility.DisplayProgressBar("配置贴图", Path.GetFileName(texPath), (float)configured / total);
            }

            EditorUtility.ClearProgressBar();
            AssetDatabase.Refresh();
        }

        private void ImportModels()
        {
            currentOperation = "正在导入模型资源...";
            progress = 0f;

            try
            {
                string[] modelSources = new string[]
                {
                    @"D:\Unity Projects\map\model",
                    @"D:\Unity Projects\sfx\resource\model"
                };

                int totalFiles = 0;
                int processedFiles = 0;

                // First pass: count files
                foreach (string source in modelSources)
                {
                    if (Directory.Exists(source))
                    {
                        totalFiles += Directory.GetFiles(source, "*.fbx").Length;
                    }
                }

                foreach (string source in modelSources)
                {
                    if (!Directory.Exists(source)) continue;

                    string targetSubDir = source.Contains("sfx") ? "SFX" : "Map";
                    string targetDir = Path.Combine(unityProjectRoot, "Assets", "Irithyll", "Models", targetSubDir);
                    EnsureDirectoryExists(targetDir);

                    string[] fbxFiles = Directory.GetFiles(source, "*.fbx");
                    int copied = 0;

                    foreach (string fbxFile in fbxFiles)
                    {
                        string fileName = Path.GetFileName(fbxFile);
                        string destPath = Path.Combine(targetDir, fileName);

                        if (!File.Exists(destPath))
                        {
                            File.Copy(fbxFile, destPath, true);
                        }

                        // Configure FBX import settings
                        ConfigureModelImport(destPath);

                        copied++;
                        processedFiles++;
                        progress = (float)processedFiles / totalFiles;
                        currentOperation = $"导入模型: {fileName} ({processedFiles}/{totalFiles})";
                        EditorUtility.DisplayProgressBar($"导入{targetSubDir}模型", fileName, (float)processedFiles / totalFiles);
                    }

                    UnityEngine.Debug.Log($"{targetSubDir}模型导入完成: {copied}");
                }

                EditorUtility.ClearProgressBar();
                AssetDatabase.Refresh();
                progress = 1f;
                currentOperation = "✅ 模型导入完成!";
            }
            catch (Exception e)
            {
                EditorUtility.ClearProgressBar();
                progress = 0f;
                UnityEngine.Debug.LogError($"模型导入失败: {e.Message}\n{e.StackTrace}");
                currentOperation = "❌ 模型导入失败!";
            }
        }

        private void ConfigureModelImport(string modelPath)
        {
            string assetPath = modelPath.Replace(unityProjectRoot + Path.DirectorySeparatorChar, "");
            assetPath = assetPath.Replace("\\", "/");
            
            ModelImporter importer = AssetImporter.GetAtPath(assetPath) as ModelImporter;

            if (importer != null)
            {
                importer.globalScale = modelScaleFactor;
                importer.useFileUnits = true;
                importer.addCollider = generateColliders;
                importer.importAnimation = false;
                importer.materialImportMode = ModelImporterMaterialImportMode.None;
                importer.SaveAndReimport();
            }
        }

        private void CreateMaterials()
        {
            currentOperation = "正在创建材质...";
            progress = 0f;

            try
            {
                string materialDir = Path.Combine(unityProjectRoot, "Assets", "Irithyll", "Materials");
                string textureDir = Path.Combine(unityProjectRoot, "Assets", "Irithyll", "Textures");
                string modelDir = Path.Combine(unityProjectRoot, "Assets", "Irithyll", "Models");

                EnsureDirectoryExists(materialDir);

                CreateMaterialFromMapping(modelDir, textureDir, materialDir);

                AssetDatabase.Refresh();
                progress = 1f;
                currentOperation = "✅ 材质创建完成!";
                UnityEngine.Debug.Log("材质创建完成！");
            }
            catch (Exception e)
            {
                progress = 0f;
                UnityEngine.Debug.LogError($"材质创建失败: {e.Message}\n{e.StackTrace}");
                currentOperation = "❌ 材质创建失败!";
            }
        }

        private void CreateMaterialFromMapping(string modelDir, string textureDir, string materialDir)
        {
            if (!Directory.Exists(modelDir) || !Directory.Exists(textureDir))
            {
                UnityEngine.Debug.LogWarning("模型目录或贴图目录不存在，跳过材质创建");
                return;
            }

            string[] fbxFiles = Directory.GetFiles(modelDir, "*.fbx", SearchOption.AllDirectories);
            string[] textures = Directory.GetFiles(textureDir, "*.png", SearchOption.AllDirectories);
            
            int total = fbxFiles.Length;
            int processed = 0;
            int created = 0;

            foreach (string fbxPath in fbxFiles)
            {
                string fbxName = Path.GetFileNameWithoutExtension(fbxPath);
                string modelId = ExtractModelId(fbxName);

                // Find matching texture
                string matchingTex = textures.FirstOrDefault(t =>
                {
                    string texName = Path.GetFileNameWithoutExtension(t);
                    return texName.Contains($"m{modelId}") && !texName.Contains("_l");
                });

                if (matchingTex != null)
                {
                    CreateMaterialForModel(fbxName, matchingTex, materialDir);
                    created++;
                }

                processed++;
                progress = (float)processed / total;
                currentOperation = $"创建材质: {fbxName} ({processed}/{total})";
                EditorUtility.DisplayProgressBar("创建材质", fbxName, (float)processed / total);
            }

            EditorUtility.ClearProgressBar();
            UnityEngine.Debug.Log($"材质创建完成: {created}/{total}");
        }

        private string ExtractModelId(string fbxName)
        {
            // Extract ID from filename like "m37_00_00_00_000040out" -> "000040"
            var parts = fbxName.Replace("m37_00_00_00_", "").Replace("out", "").Split('_');
            return parts.Length > 0 ? parts[0] : "";
        }

        private void CreateMaterialForModel(string modelName, string texturePath, string materialDir)
        {
            string matName = modelName + "_Mat";
            string matPath = Path.Combine(materialDir, matName + ".mat");

            string assetMatPath = matPath.Replace(unityProjectRoot + Path.DirectorySeparatorChar, "");
            assetMatPath = assetMatPath.Replace("\\", "/");

            Material mat;
            if (File.Exists(matPath))
            {
                mat = AssetDatabase.LoadAssetAtPath<Material>(assetMatPath);
            }
            else
            {
                mat = new Material(Shader.Find("Standard"));
                AssetDatabase.CreateAsset(mat, assetMatPath);
            }

            // Assign main texture
            string assetTexPath = texturePath.Replace(unityProjectRoot + Path.DirectorySeparatorChar, "");
            assetTexPath = assetTexPath.Replace("\\", "/");
            
            Texture tex = AssetDatabase.LoadAssetAtPath<Texture>(assetTexPath);
            if (tex != null)
            {
                mat.SetTexture("_MainTex", tex);
            }

            EditorUtility.SetDirty(mat);
            AssetDatabase.SaveAssets();
        }

        private void ParseParticles()
        {
            currentOperation = "正在解析粒子特效...";
            progress = 0f;

            try
            {
                string fxrSource = @"D:\Unity Projects\sfx\effect";
                string outputDir = Path.Combine(unityProjectRoot, "Assets", "Irithyll", "Particles");
                EnsureDirectoryExists(outputDir);

                if (!Directory.Exists(fxrSource))
                {
                    throw new Exception($"粒子特效目录不存在: {fxrSource}");
                }

                FXRParticleParser parser = new FXRParticleParser();
                parser.ParseDirectory(fxrSource, outputDir);

                AssetDatabase.Refresh();
                progress = 1f;
                currentOperation = "✅ 粒子特效解析完成!";
                UnityEngine.Debug.Log("粒子特效解析完成！");
            }
            catch (Exception e)
            {
                progress = 0f;
                UnityEngine.Debug.LogError($"粒子解析失败: {e.Message}\n{e.StackTrace}");
                currentOperation = "❌ 粒子解析失败!";
            }
        }

        private void BuildScene()
        {
            currentOperation = "正在构建场景...";
            progress = 0f;

            try
            {
                string modelDir = Path.Combine(unityProjectRoot, "Assets", "Irithyll", "Models");
                string materialDir = Path.Combine(unityProjectRoot, "Assets", "Irithyll", "Materials");

                BuildSceneHierarchy(modelDir, materialDir);

                progress = 1f;
                currentOperation = "✅ 场景构建完成!";
                UnityEngine.Debug.Log("场景构建完成！");
            }
            catch (Exception e)
            {
                progress = 0f;
                UnityEngine.Debug.LogError($"场景构建失败: {e.Message}\n{e.StackTrace}");
                currentOperation = "❌ 场景构建失败!";
            }
        }

        private void BuildSceneHierarchy(string modelDir, string materialDir)
        {
            if (!Directory.Exists(modelDir))
            {
                UnityEngine.Debug.LogWarning("模型目录不存在，跳过场景构建");
                return;
            }

            // 获取场景中现有的GameObject（Camera, Light等）
            UnityEngine.SceneManagement.Scene currentScene = 
                UnityEngine.SceneManagement.SceneManager.GetActiveScene();
            
            // 创建地图根目录
            GameObject mapRoot = new GameObject("Map_Root");
            UnityEngine.SceneManagement.SceneManager.MoveGameObjectToScene(mapRoot, currentScene);

            string[] fbxFiles = Directory.GetFiles(modelDir, "*.fbx", SearchOption.AllDirectories);
            int total = fbxFiles.Length;
            int processed = 0;
            int loaded = 0;

            foreach (string fbxPath in fbxFiles)
            {
                string assetPath = fbxPath.Replace(unityProjectRoot + Path.DirectorySeparatorChar, "");
                assetPath = assetPath.Replace("\\", "/");

                // 加载FBX预制体
                UnityEngine.GameObject prefab = UnityEditor.AssetDatabase.LoadAssetAtPath<GameObject>(assetPath);
                if (prefab == null)
                {
                    processed++;
                    progress = (float)processed / total;
                    continue;
                }

                // 实例化到场景
                GameObject instance = UnityEditor.PrefabUtility.InstantiatePrefab(prefab, currentScene) as GameObject;
                if (instance != null)
                {
                    instance.transform.SetParent(mapRoot.transform);
                    // FBX文件已包含位置信息，保持原位
                    loaded++;

                    // 尝试自动应用同名材质
                    ApplyMaterialToMesh(instance, materialDir);
                }

                processed++;
                currentOperation = $"构建场景: {Path.GetFileName(fbxPath)} ({processed}/{total})";
                progress = (float)processed / total;
                EditorUtility.DisplayProgressBar("构建场景", Path.GetFileName(fbxPath), (float)processed / total);
            }

            EditorUtility.ClearProgressBar();
            UnityEngine.Debug.Log($"场景构建完成！共加载 {loaded}/{total} 个模型到场景");
        }

        private void ApplyMaterialToMesh(GameObject obj, string materialDir)
        {
            // 获取模型ID
            string modelName = obj.name;
            string modelId = ExtractModelId(modelName);

            // 查找匹配的材质
            string[] matFiles = Directory.GetFiles(materialDir, "*.mat", SearchOption.AllDirectories);
            foreach (string matPath in matFiles)
            {
                string matName = Path.GetFileNameWithoutExtension(matPath);
                // 材质命名格式: m37_00_00_00_000040out_Mat
                if (matName.Contains($"m{modelId}") || matName.Contains(modelId))
                {
                    string assetPath = matPath.Replace(unityProjectRoot + Path.DirectorySeparatorChar, "");
                    assetPath = assetPath.Replace("\\", "/");

                    Material mat = UnityEditor.AssetDatabase.LoadAssetAtPath<Material>(assetPath);
                    if (mat != null)
                    {
                        // 应用到所有MeshRenderer
                        MeshRenderer[] renderers = obj.GetComponentsInChildren<MeshRenderer>();
                        foreach (var renderer in renderers)
                        {
                            renderer.material = mat;
                        }
                    }
                    break;
                }
            }
        }

        private void RunFullImport()
        {
            currentOperation = "正在执行完整导入...";
            progress = 0f;

            try
            {
                // Step 1: Import Textures
                currentOperation = "步骤1/5: 导入贴图...";
                ImportTextures();
                
                if (progress < 0.5f)
                {
                    currentOperation = "❌ 贴图导入失败，终止后续步骤";
                    return;
                }

                // Step 2: Import Models
                currentOperation = "步骤2/5: 导入模型...";
                ImportModels();

                // Step 3: Create Materials
                currentOperation = "步骤3/5: 创建材质...";
                CreateMaterials();

                // Step 4: Parse Particles
                currentOperation = "步骤4/5: 解析粒子...";
                ParseParticles();

                // Step 5: Build Scene
                currentOperation = "步骤5/5: 构建场景...";
                BuildScene();

                progress = 1f;
                currentOperation = "✅ 完整导入完成!";
                UnityEngine.Debug.Log("🎉 Irithyll资源导入全部完成!");
            }
            catch (Exception e)
            {
                UnityEngine.Debug.LogError($"完整导入失败: {e.Message}\n{e.StackTrace}");
                currentOperation = "❌ 导入失败!";
            }
        }

        private void EnsureDirectoryExists(string path)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
        }

        private void RefreshAssets()
        {
            AssetDatabase.Refresh();
            UnityEngine.Debug.Log("资源刷新完成");
        }

        private void OpenUnityProject()
        {
            EditorUtility.RevealInFinder(unityProjectRoot);
        }

        private void OpenOutputDirectory()
        {
            // 始终打开 Irithyll 目录
            string irithyllDir = Path.Combine(unityProjectRoot, "Assets", "Irithyll");
            
            // 如果目录不存在，先创建它
            if (!Directory.Exists(irithyllDir))
            {
                Directory.CreateDirectory(irithyllDir);
            }
            
            EditorUtility.RevealInFinder(irithyllDir);
        }
    }
}
