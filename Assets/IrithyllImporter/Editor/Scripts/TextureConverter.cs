using UnityEngine;
using UnityEditor;
using System;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace IrithyllImporter
{
    /// <summary>
    /// Texture conversion utility using NVIDIA Texture Tools
    /// Handles DDS to PNG/TGA conversion for Unity import
    /// </summary>
    public class TextureConverter : EditorWindow
    {
        // ==================== Configuration ====================

        private string nvttPath = @"D:\Program Files (x86)\NVIDIA Texture Tools\nvtt_export.exe";
        private string sourceDDSDir = @"D:\Unity Projects\map\texture\dds";
        private string sourcePNGDir = @"D:\Unity Projects\map\texture\png";
        private string outputDir = "";

        private bool convertLightmaps = true;
        private bool generateMipmaps = true;
        private bool preserveOriginals = true;

        private Vector2 scrollPos;
        private bool isConverting = false;
        private float progress = 0f;
        private string statusMessage = "";

        // ==================== GUI ====================

        [MenuItem("Tools/Irithyll/Texture Converter")]
        public static void ShowWindow()
        {
            var window = GetWindow<TextureConverter>("纹理转换器");
            window.minSize = new Vector2(500, 600);
        }

        void OnEnable()
        {
            outputDir = Path.Combine(Application.dataPath, "..", "Assets", "Irithyll", "Textures", "Converted");
        }

        void OnGUI()
        {
            scrollPos = EditorGUILayout.BeginScrollView(scrollPos);

            // Header
            GUILayout.Label("🎨 NVIDIA Texture Tools 批量转换器", EditorStyles.boldLabel);
            GUILayout.Label("DDS → PNG 格式转换 (NVTT)", EditorStyles.miniLabel);
            EditorGUILayout.Space(10);

            // ==================== NVTT Configuration ====================
            GUILayout.Label("NVIDIA Texture Tools 配置", EditorStyles.boldLabel);
            EditorGUILayout.BeginVertical(EditorStyles.helpBox);

            nvttPath = EditorGUILayout.TextField("NVTT 路径", nvttPath);

            EditorGUILayout.BeginHorizontal();
            if (GUILayout.Button("浏览..."))
            {
                string path = EditorUtility.OpenFilePanel("选择NVTT导出工具", @"D:\Program Files (x86)\NVIDIA Texture Tools", "exe");
                if (!string.IsNullOrEmpty(path)) nvttPath = path;
            }
            if (GUILayout.Button("测试连接"))
            {
                TestNVTTConnection();
            }
            EditorGUILayout.EndHorizontal();

            if (!File.Exists(nvttPath))
            {
                EditorGUILayout.HelpBox("⚠️ NVTT工具未找到！将使用备选方案（直接复制PNG）", MessageType.Warning);
            }

            EditorGUILayout.EndVertical();
            EditorGUILayout.Space(10);

            // ==================== Directories ====================
            GUILayout.Label("目录配置", EditorStyles.boldLabel);
            EditorGUILayout.BeginVertical(EditorStyles.helpBox);

            sourceDDSDir = EditorGUILayout.TextField("DDS 源目录", sourceDDSDir);
            sourcePNGDir = EditorGUILayout.TextField("PNG 源目录", sourcePNGDir);
            outputDir = EditorGUILayout.TextField("输出目录", outputDir);

            EditorGUILayout.BeginHorizontal();
            if (GUILayout.Button("选择DDS目录"))
            {
                string path = EditorUtility.OpenFolderPanel("选择DDS目录", @"D:\Unity Projects\map\texture", "dds");
                if (!string.IsNullOrEmpty(path)) sourceDDSDir = path;
            }
            if (GUILayout.Button("选择PNG目录"))
            {
                string path = EditorUtility.OpenFolderPanel("选择PNG目录", @"D:\Unity Projects\map\texture", "png");
                if (!string.IsNullOrEmpty(path)) sourcePNGDir = path;
            }
            EditorGUILayout.EndHorizontal();

            if (GUILayout.Button("选择输出目录"))
            {
                string path = EditorUtility.OpenFolderPanel("选择输出目录", Application.dataPath, "");
                if (!string.IsNullOrEmpty(path)) outputDir = path;
            }

            EditorGUILayout.EndVertical();
            EditorGUILayout.Space(10);

            // ==================== Conversion Options ====================
            GUILayout.Label("转换选项", EditorStyles.boldLabel);
            EditorGUILayout.BeginVertical(EditorStyles.helpBox);

            convertLightmaps = EditorGUILayout.Toggle("处理光照贴图(_l后缀)", convertLightmaps);
            generateMipmaps = EditorGUILayout.Toggle("生成Mipmap", generateMipmaps);
            preserveOriginals = EditorGUILayout.Toggle("保留原始DDS", preserveOriginals);

            EditorGUILayout.EndVertical();
            EditorGUILayout.Space(10);

            // ==================== Statistics ====================
            GUILayout.Label("资源统计", EditorStyles.boldLabel);
            EditorGUILayout.BeginVertical(EditorStyles.helpBox);

            int ddsCount = Directory.Exists(sourceDDSDir) ? Directory.GetFiles(sourceDDSDir, "*.dds").Length : 0;
            int pngCount = Directory.Exists(sourcePNGDir) ? Directory.GetFiles(sourcePNGDir, "*.png").Length : 0;

            EditorGUILayout.LabelField($"DDS 文件数量: {ddsCount}");
            EditorGUILayout.LabelField($"PNG 源文件数量: {pngCount}");
            EditorGUILayout.LabelField($"预计输出文件: {Math.Max(ddsCount, pngCount)}");

            EditorGUILayout.EndVertical();
            EditorGUILayout.Space(10);

            // ==================== Actions ====================
            GUILayout.Label("操作", EditorStyles.boldLabel);
            EditorGUILayout.BeginVertical(EditorStyles.helpBox);

            GUI.enabled = !isConverting && File.Exists(nvttPath) && Directory.Exists(sourceDDSDir);
            if (GUILayout.Button("🚀 使用NVTT转换DDS → PNG", GUILayout.Height(40)))
            {
                ConvertWithNVTT();
            }
            GUI.enabled = !isConverting;

            GUI.enabled = !isConverting && Directory.Exists(sourcePNGDir);
            if (GUILayout.Button("📁 复制PNG文件（备选方案）", GUILayout.Height(40)))
            {
                CopyPNGFiles();
            }
            GUI.enabled = !isConverting;

            GUI.enabled = !isConverting;
            if (GUILayout.Button("🔄 完整导入流程（自动选择最佳方案）", GUILayout.Height(50)))
            {
                RunFullConversion();
            }
            GUI.enabled = true;

            EditorGUILayout.EndVertical();

            // ==================== Progress ====================
            if (isConverting || !string.IsNullOrEmpty(statusMessage))
            {
                GUILayout.Space(10);
                GUILayout.Label("进度", EditorStyles.boldLabel);
                EditorGUILayout.BeginVertical(EditorStyles.helpBox);

                EditorGUILayout.LabelField(statusMessage);
                if (isConverting)
                {
                    Rect progressRect = GUILayoutUtility.GetRect(450, 20);
                    progressRect.width = Mathf.Min(450, EditorGUIUtility.currentViewWidth - 40);
                    EditorGUI.ProgressBar(progressRect, progress, $"{progress * 100:F1}%");
                }

                EditorGUILayout.EndVertical();
            }

            EditorGUILayout.EndScrollView();
        }

        // ==================== Conversion Methods ====================

        private void TestNVTTConnection()
        {
            if (File.Exists(nvttPath))
            {
                try
                {
                    ProcessStartInfo psi = new ProcessStartInfo
                    {
                        FileName = nvttPath,
                        Arguments = "--help",
                        UseShellExecute = false,
                        RedirectStandardOutput = true,
                        RedirectStandardError = true,
                        CreateNoWindow = true
                    };

                    using (Process process = Process.Start(psi))
                    {
                        string output = process.StandardOutput.ReadToEnd();
                        process.WaitForExit(5000);

                        if (process.ExitCode == 0 || output.Contains("Usage") || output.Contains("Options"))
                        {
                            UnityEngine.Debug.Log("✅ NVTT连接测试成功!");
                            EditorUtility.DisplayDialog("测试成功", "NVIDIA Texture Tools 连接正常!\n\n" + output.Substring(0, Math.Min(300, output.Length)), "确定");
                        }
                        else
                        {
                            UnityEngine.Debug.LogWarning($"⚠️ NVTT可能存在问题，退出码: {process.ExitCode}\n{output}");
                            EditorUtility.DisplayDialog("警告", "NVTT可能存在问题，请检查安装。", "确定");
                        }
                    }
                }
                catch (Exception e)
                {
                    UnityEngine.Debug.LogError($"❌ NVTT测试失败: {e.Message}");
                    EditorUtility.DisplayDialog("错误", $"NVTT测试失败:\n{e.Message}", "确定");
                }
            }
            else
            {
                UnityEngine.Debug.LogError("❌ NVTT工具不存在!");
                EditorUtility.DisplayDialog("错误", $"NVTT工具不存在:\n{nvttPath}", "确定");
            }
        }

        private void ConvertWithNVTT()
        {
            if (!Directory.Exists(sourceDDSDir))
            {
                UnityEngine.Debug.LogError($"DDS源目录不存在: {sourceDDSDir}");
                EditorUtility.DisplayDialog("错误", $"DDS源目录不存在:\n{sourceDDSDir}", "确定");
                return;
            }

            if (string.IsNullOrEmpty(outputDir))
            {
                outputDir = Path.Combine(Application.dataPath, "..", "Assets", "Irithyll", "Textures", "NVTT_Output");
            }

            EnsureDirectoryExists(outputDir);

            string[] ddsFiles = Directory.GetFiles(sourceDDSDir, "*.dds");
            if (ddsFiles.Length == 0)
            {
                UnityEngine.Debug.LogWarning("未找到DDS文件");
                EditorUtility.DisplayDialog("提示", "未找到DDS文件", "确定");
                return;
            }

            isConverting = true;
            statusMessage = "正在转换DDS文件...";
            progress = 0f;

            int total = ddsFiles.Length;
            int success = 0;
            int failed = 0;
            int skipped = 0;

            try
            {
                for (int i = 0; i < ddsFiles.Length; i++)
                {
                    string ddsFile = ddsFiles[i];
                    string fileName = Path.GetFileName(ddsFile);

                    // Skip lightmaps if option is disabled
                    if (!convertLightmaps && fileName.Contains("_l"))
                    {
                        skipped++;
                        progress = (float)(i + 1) / total;
                        statusMessage = $"跳过光照贴图: {fileName} ({i + 1}/{total})";
                        continue;
                    }

                    string baseName = Path.GetFileNameWithoutExtension(ddsFile);
                    // Remove _l suffix from lightmaps
                    if (baseName.EndsWith("_l"))
                    {
                        baseName = baseName.Substring(0, baseName.Length - 2);
                    }
                    string outputPath = Path.Combine(outputDir, baseName + ".png");

                    // Skip if already converted
                    if (File.Exists(outputPath))
                    {
                        skipped++;
                    }
                    else
                    {
                        try
                        {
                            // NVTT 命令格式: nvtt_export.exe input.dds output.png
                            // 注意：NVTT使用位置参数（输入输出文件作为前两个参数），不是 --input/--output
                            string args = $"\"{ddsFile}\" \"{outputPath}\"";
                            ExecuteNVTT(args);

                            if (File.Exists(outputPath))
                            {
                                success++;
                            }
                            else
                            {
                                failed++;
                                UnityEngine.Debug.LogWarning($"转换后文件未生成: {baseName}");
                            }
                        }
                        catch (Exception ex)
                        {
                            failed++;
                            UnityEngine.Debug.LogWarning($"转换失败 {fileName}: {ex.Message}");
                        }
                    }

                    int current = i + 1;
                    progress = (float)current / total;
                    statusMessage = $"转换中: {fileName} ({current}/{total}) - 成功:{success} 失败:{failed} 跳过:{skipped}";
                    EditorUtility.DisplayProgressBar("转换DDS", fileName, (float)current / total);
                }
            }
            finally
            {
                EditorUtility.ClearProgressBar();
                isConverting = false;
                statusMessage = $"✅ 转换完成! 成功: {success}, 失败: {failed}, 跳过: {skipped}";

                UnityEngine.Debug.Log($"NVTT转换完成: 成功={success}, 失败={failed}, 跳过={skipped}");
                EditorUtility.DisplayDialog("转换完成", $"成功: {success}\n失败: {failed}\n跳过: {skipped}\n\n输出目录: {outputDir}", "确定");
            }
        }

        private void ExecuteNVTT(string arguments)
        {
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = nvttPath,
                Arguments = arguments,
                UseShellExecute = false,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                CreateNoWindow = true
            };

            using (Process process = Process.Start(psi))
            {
                // Wait for completion with timeout
                bool completed = process.WaitForExit(30000);

                if (!completed)
                {
                    process.Kill();
                    throw new Exception("NVTT执行超时(30秒)");
                }

                if (process.ExitCode != 0)
                {
                    string error = process.StandardError.ReadToEnd();
                    if (!string.IsNullOrEmpty(error))
                    {
                        throw new Exception(error.Trim());
                    }
                }
            }
        }

        private void CopyPNGFiles()
        {
            if (!Directory.Exists(sourcePNGDir))
            {
                UnityEngine.Debug.LogError($"PNG源目录不存在: {sourcePNGDir}");
                EditorUtility.DisplayDialog("错误", $"PNG源目录不存在:\n{sourcePNGDir}", "确定");
                return;
            }

            if (string.IsNullOrEmpty(outputDir))
            {
                outputDir = Path.Combine(Application.dataPath, "..", "Assets", "Irithyll", "Textures", "PNG_Copy");
            }

            EnsureDirectoryExists(outputDir);

            string[] pngFiles = Directory.GetFiles(sourcePNGDir, "*.png");
            if (pngFiles.Length == 0)
            {
                UnityEngine.Debug.LogWarning("未找到PNG文件");
                EditorUtility.DisplayDialog("提示", "未找到PNG文件", "确定");
                return;
            }

            isConverting = true;
            statusMessage = "正在复制PNG文件...";
            progress = 0f;

            int total = pngFiles.Length;
            int success = 0;
            int skipped = 0;

            try
            {
                for (int i = 0; i < pngFiles.Length; i++)
                {
                    string pngFile = pngFiles[i];
                    string fileName = Path.GetFileName(pngFile);

                    // Skip lightmaps if option is disabled
                    if (!convertLightmaps && fileName.Contains("_lout"))
                    {
                        skipped++;
                        continue;
                    }

                    // Clean filename: remove _lout, out suffixes
                    string cleanName = fileName.Replace("_lout", "").Replace("out", "");

                    string destPath = Path.Combine(outputDir, cleanName);

                    if (!File.Exists(destPath))
                    {
                        File.Copy(pngFile, destPath, true);
                        success++;
                    }
                    else
                    {
                        skipped++;
                    }

                    int current = i + 1;
                    progress = (float)current / total;
                    statusMessage = $"复制中: {fileName} ({current}/{total})";
                    EditorUtility.DisplayProgressBar("复制PNG", fileName, (float)current / total);
                }
            }
            finally
            {
                EditorUtility.ClearProgressBar();
                isConverting = false;
                statusMessage = $"✅ 复制完成! 成功: {success}, 跳过: {skipped}";

                UnityEngine.Debug.Log($"PNG复制完成: 成功={success}, 跳过={skipped}");
                EditorUtility.DisplayDialog("复制完成", $"成功复制: {success}\n跳过: {skipped}\n\n输出目录: {outputDir}", "确定");
            }
        }

        private void RunFullConversion()
        {
            if (File.Exists(nvttPath) && Directory.Exists(sourceDDSDir))
            {
                ConvertWithNVTT();
            }
            else if (Directory.Exists(sourcePNGDir))
            {
                CopyPNGFiles();
            }
            else
            {
                EditorUtility.DisplayDialog("错误", "无法找到任何可用的纹理源!\n\n请检查:\n1. NVTT工具路径\n2. DDS源目录\n3. PNG备选目录", "确定");
            }
        }

        // ==================== Helper Methods ====================

        private void EnsureDirectoryExists(string path)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
        }
    }
}
