using System;
using System.Collections.Generic;
using System.IO;
using b1;
using CSharpModBase;
using UnrealEngine.AssetRegistry;
using UnrealEngine.Runtime;

namespace ActionsMod
{
    /// <summary>
    /// 音效资产索引（ProbeSoundAssets 动作）：运行时用 AssetRegistry 枚举 UAkAudioEvent 资产，
    /// 把 /Game/... 路径打印到日志并落盘到 Mod 目录 AkDump\*.txt，供 JSON 的 "path" 字段直接填。
    ///
    /// 为什么需要它：PlaySound / SayLine 用 path 指 UAkAudioEvent 时最稳（不用管 bank），
    /// 但路径没法猜。AssetRegistry 里登记了全部磁盘资产（含未加载的），一次性枚举即可。
    /// </summary>
    internal static class SoundAssetIndex
    {
        /// <summary>
        /// 枚举音效资产。Params：
        /// Class（默认 AkAudioEvent）/ Keyword（路径子串过滤）/ Path（限定根路径，默认全 /Game）
        /// MaxPrint（日志打印条数，默认 40）/ NoFile（为 true 时不写文件，默认写）
        /// </summary>
        public static void Dump(BGUPlayerCharacterCS character, ActionConfig action)
        {
            string className = Param(action, "Class") ?? "AkAudioEvent";
            string? keyword = Param(action, "Keyword");
            string? rootPath = Param(action, "Path");
            int maxPrint = IntParam(action, "MaxPrint", 40);
            bool writeFile = !BoolParam(action, "NoFile");

            IAssetRegistry? registry = null;
            try
            {
                registry = UAssetRegistryHelpers.GetAssetRegistry();
            }
            catch (Exception e)
            {
                Log.Warn($"[ActionsMod] 取 AssetRegistry 失败: {e.Message}");
                return;
            }

            if (registry == null)
            {
                Log.Warn("[ActionsMod] AssetRegistry 为空（该模块不可用时无法枚举资产，改用 AkEventName + Bank 播放）");
                return;
            }

            bool usePath = !string.IsNullOrEmpty(rootPath) && rootPath != "/Game" && rootPath != "/";
            List<FAssetData> assets = new List<FAssetData>();
            try
            {
                if (usePath)
                {
                    registry.GetAssetsByPath(new FName(rootPath!), out assets, true, true);
                }
                else
                {
                    registry.GetAssetsByClass(new FName(className), out assets, true);
                }
            }
            catch (Exception e)
            {
                Log.Warn($"[ActionsMod] AssetRegistry 查询失败 Class={className} Path={rootPath}: {e.Message}");
                return;
            }

            if (assets == null || assets.Count == 0)
            {
                Log.Warn($"[ActionsMod] AssetRegistry 没有查到任何资产（Class={className} Path={rootPath ?? "/Game"}）");
                return;
            }

            List<string> hits = new List<string>();
            HashSet<string> seen = new HashSet<string>();
            string kw = keyword ?? "";
            foreach (FAssetData data in assets)
            {
                if (usePath)
                {
                    string assetClass = SafeName(data.AssetClass);
                    if (!string.Equals(assetClass, className, StringComparison.OrdinalIgnoreCase)) continue;
                }

                string assetPath = SafeName(data.PackageName);
                if (assetPath.Length == 0 || !assetPath.StartsWith("/Game")) continue;
                if (kw.Length > 0 && assetPath.IndexOf(kw, StringComparison.OrdinalIgnoreCase) < 0) continue;
                if (seen.Add(assetPath)) hits.Add(assetPath);
            }

            hits.Sort(StringComparer.OrdinalIgnoreCase);

            Log.Info($"[ActionsMod] AssetRegistry 命中 {hits.Count} 条 {className}（总 {assets.Count} 条资产，keyword={kw} path={rootPath ?? "/Game"}）");

            string file = "";
            if (writeFile && hits.Count > 0)
            {
                try
                {
                    string dir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, Common.ModDir, "ActionsMod", "AkDump");
                    Directory.CreateDirectory(dir);
                    string stamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
                    string tag = kw.Length > 0 ? Sanitize(kw) : (usePath ? Sanitize(rootPath!) : "all");
                    file = Path.Combine(dir, $"{className}_{tag}_{stamp}.txt");
                    File.WriteAllLines(file, hits, new System.Text.UTF8Encoding(false));
                    Log.Info($"[ActionsMod] 已写出 {hits.Count} 条路径: {file}");
                }
                catch (Exception e)
                {
                    Log.Warn($"[ActionsMod] 写 AkDump 文件失败: {e.Message}");
                }
            }

            int n = Math.Min(maxPrint, hits.Count);
            for (int i = 0; i < n; i++)
            {
                Log.Info($"[ActionsMod]   {hits[i]}");
            }
            if (hits.Count > n)
            {
                Log.Info($"[ActionsMod]   ...还有 {hits.Count - n} 条（MaxPrint={maxPrint}）");
            }
            if (hits.Count > 0)
            {
                Log.Info("[ActionsMod] 把上面任意一条填进 PlaySound / SayLine 的 \"path\" 即可（不用配 Bank）");
            }
            else
            {
                Log.Info("[ActionsMod] 没命中：换个更短的 Keyword（如 xiez / yecha / dialogue），或 Path 填 /Game/00Main/Audio/SFX 再试");
            }
        }

        private static string SafeName(FName name)
        {
            try
            {
                return name.ToString() ?? "";
            }
            catch
            {
                return "";
            }
        }

        private static string? Param(ActionConfig action, string key)
        {
            if (action.Params == null) return null;
            if (!action.Params.TryGetValue(key, out object? v)) return null;
            string? s = v?.ToString();
            return string.IsNullOrWhiteSpace(s) ? null : s!.Trim();
        }

        private static int IntParam(ActionConfig action, string key, int def)
        {
            string? s = Param(action, key);
            return s != null && int.TryParse(s, out int v) ? v : def;
        }

        private static bool BoolParam(ActionConfig action, string key)
        {
            string? s = Param(action, key);
            if (s == null) return false;
            return s.Equals("true", StringComparison.OrdinalIgnoreCase) || s == "1";
        }

        private static string Sanitize(string s)
        {
            char[] bad = Path.GetInvalidFileNameChars();
            string r = s;
            foreach (char c in bad) r = r.Replace(c.ToString(), "_");
            return r.Length > 40 ? r.Substring(0, 40) : r;
        }
    }
}
