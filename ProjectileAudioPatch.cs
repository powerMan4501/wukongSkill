using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using b1;
using b1.Plugins.AkAudio;
using CSharpModBase;
using Newtonsoft.Json;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace ActionsMod
{
    /// <summary>
    /// 子弹/弹体生成音效的屏蔽与替换（运行期，无需改 pak、无需 Harmony）。
    ///
    /// 排查结论（已确认）：
    /// 子弹（如三尖两刃枪「万剑归宗」的 BP_Player_Wukong_SanJianLiangRen_02，对应 FUStProjectileCommDesc ID 147）
    /// 在 BUS_ProjectileConfigInfoComp.LoopEvent.AkEvent 上挂了生成音效
    /// EVT_player_wk_bang_SanJianLiangRen_wjgz。该声音硬编码进蓝图资产，配表改不了。
    /// 每次生成子弹时，BUS_ProjectileConfigInfoComp.OnDataConvert 会把 LoopEvent / DeadEvent 从
    /// 「类默认对象(CDO/原型)的组件实例」拷进新子弹的 BUC_ProjectileAudioData，再由
    /// BUS_ProjectileAudioCompl.OnBeginPlay 播放。
    ///
    /// 关键难点（都已排除的错误路线）：
    /// - 声音在 OnBeginPlay 已经用 PostEventAtLocation 播出去了，且 UAkEventConfig 是值类型、
    ///   DoPlayAudio 按值传参、PlayingId 写到副本被丢弃 —— 「事后按 PlayingId 停」是死路。
    /// - BUS_ProjectileConfigInfoComp 是黑神话自定义的 BUS 组件（挂在 ActorCompContainerCS 里），
    ///   不是标准 UActorComponent，编译器也不把它当 UObject（GetComponentByClass/GetObjectsOfClass&lt;T&gt; 均因
    ///   泛型约束编译不过）。所以用「非泛型 GetObjectsOfClass(UClass) + as 强转」来绕过。
    ///
    /// 本模块做法（可靠、零时序竞争）：
    /// 周期性枚举世界里所有 BUS_ProjectileConfigInfoComp 实例（默认会排除 CDO，故显式把
    /// additionalExcludeFlags 设为 None 以包含 CDO 实例），对其 owner 类名含 ClassKeyword 的，
    /// 直接把 LoopEvent / DeadEvent 的 AkEvent 置空（或替换）。对 CDO 实例的写入会让之后所有
    /// 新生成的该类子弹静音/替换；同一类的配置组件只写一次。
    ///
    /// 配置：Mod 目录下的 ProjectileAudioPatch.json（首次运行自动生成默认配置）。
    /// </summary>
    internal static class ProjectileAudioPatch
    {
        private sealed class PatchEntry
        {
            /// <summary>子弹类名包含此串即命中（忽略大小写）。如 SanJianLiangRen 同时命中 _01 与 _02</summary>
            public string ClassKeyword = "SanJianLiangRen";

            /// <summary>可选：直接指定子弹蓝图类完整路径（含 ._C 后缀），用于初始化立即生效；留空则靠自动发现</summary>
            public string ClassPath = "";

            /// <summary>mute = 静音（置空）；replace = 替换为 AkEventPath 指定的音效</summary>
            public string Mode = "mute";

            /// <summary>replace 模式下填写 UAkAudioEvent 资产路径，如 /Game/.../EVT_xxx.EVT_xxx</summary>
            public string AkEventPath = "";

            [JsonIgnore] public UAkAudioEvent? CachedAkEvent;
            [JsonIgnore] public bool LoadAttempted;
            [JsonIgnore] internal bool _satisfied;
        }

        private sealed class PatchConfig
        {
            public bool Enabled = true;
            public List<PatchEntry> Entries = new List<PatchEntry>();
        }

        private const string ConfigFileName = "ProjectileAudioPatch.json";
        private const string ConfigCompClassName = "/Script/b1-Managed.BUS_ProjectileConfigInfoComp";

        private static PatchConfig? _config;
        private static Timer? _timer;
        private static UClass? _configCompClass;
        private static int _scanCount;
        private static bool _classResolvedLogged;

        // ============================== 对外入口 ==============================

        public static void Init()
        {
            string dir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, Common.ModDir, "ActionsMod");
            string path = Path.Combine(dir, ConfigFileName);

            if (!File.Exists(path))
            {
                try
                {
                    Directory.CreateDirectory(dir);
                    File.WriteAllText(path, DefaultConfigJson());
                    Log.Info($"[ProjectileAudioPatch] 已生成默认配置: {path}");
                }
                catch (Exception e)
                {
                    Log.Warn($"[ProjectileAudioPatch] 写入默认配置失败: {e.Message}");
                }
            }

            try
            {
                _config = JsonConvert.DeserializeObject<PatchConfig>(File.ReadAllText(path));
            }
            catch (Exception e)
            {
                Log.Warn($"[ProjectileAudioPatch] 配置解析失败，使用内置默认: {e.Message}");
                _config = null;
            }
            if (_config == null) _config = JsonConvert.DeserializeObject<PatchConfig>(DefaultConfigJson())!;
            if (_config.Entries == null) _config.Entries = new List<PatchEntry>();

            if (!_config.Enabled || _config.Entries.Count == 0)
            {
                Log.Info("[ProjectileAudioPatch] 未启用或没有规则，跳过");
                return;
            }

            Log.Info($"[ProjectileAudioPatch] 初始化：{_config.Entries.Count} 条规则，启动自动发现扫描（按类名关键字改写 CDO 配置组件的 LoopEvent/DeadEvent）");
            _timer = new Timer(_ => ScanTick(), null, 0, 250);
        }

        public static void Shutdown()
        {
            _timer?.Dispose();
            _timer = null;
        }

        // ============================== 扫描与改写 ==============================

        private static void ScanTick()
        {
            Utils.TryRunOnGameThread(() =>
            {
                try { DoScan(); }
                catch (Exception e) { Log.Warn($"[ProjectileAudioPatch] 扫描异常: {e.Message}"); }
            });
        }

        private static void DoScan()
        {
            if (_config == null) return;
            if (_config.Entries.TrueForAll(e => e._satisfied))
            {
                _timer?.Dispose();
                _timer = null;
                Log.Info("[ProjectileAudioPatch] 所有规则均已命中并改写，停止自动发现扫描");
                return;
            }

            _scanCount++;
            if (_configCompClass == null)
                _configCompClass = UClass.GetClass(ConfigCompClassName);
            if (_configCompClass == null)
            {
                if (_scanCount % 20 == 0)
                    Log.Warn($"[ProjectileAudioPatch] 仍未解析到配置组件类 {ConfigCompClassName}（可能尚未注册，或类名不对）");
                return; // 类可能尚未注册，下一轮再试
            }
            if (!_classResolvedLogged)
            {
                _classResolvedLogged = true;
                Log.Info($"[ProjectileAudioPatch] 配置组件类已就绪：{ConfigCompClassName}");
            }

            // 包含 CDO 实例（默认会排除 ClassDefaultObject，这里显式设为 0 以包含）
            UObject[] comps = UObjectHash.GetObjectsOfClass(_configCompClass, true, (EObjectFlags)0);
            if (comps == null) return;

            int scanned = 0;
            bool anyMatch = false;
            foreach (UObject o in comps)
            {
                BUS_ProjectileConfigInfoComp? comp = o as BUS_ProjectileConfigInfoComp;
                if (comp == null) continue;

                AActor? owner = comp.GetOuter() as AActor;
                if (owner == null || owner.IsNullOrDestroyed()) continue;
                scanned++;

                UClass? cls = owner.GetClass();
                if (cls == null) continue;
                string clsName = cls.GetName() ?? "";

                foreach (PatchEntry e in _config.Entries)
                {
                    if (e._satisfied || string.IsNullOrEmpty(e.ClassKeyword)) continue;
                    if (clsName.IndexOf(e.ClassKeyword, StringComparison.OrdinalIgnoreCase) < 0) continue;

                    if (TryPatchComp(comp, e, clsName))
                        e._satisfied = true;
                    anyMatch = true;
                }
            }

            // 诊断：已解析到类，但长时间未命中任何子弹类，提示检查 ClassKeyword
            if (!anyMatch && _scanCount % 20 == 0 && scanned > 0)
                Log.Warn($"[ProjectileAudioPatch] 已扫描 {scanned} 个配置组件，但无一类名匹配关键字（请检查 Entries[].ClassKeyword，当前类名示例见上方已应用日志）");
        }

        private static bool TryPatchComp(BUS_ProjectileConfigInfoComp comp, PatchEntry entry, string clsName)
        {
            bool mute = !"replace".Equals(entry.Mode, StringComparison.OrdinalIgnoreCase);
            UAkAudioEvent? replacement = null;
            if (!mute)
            {
                replacement = ResolveReplacement(entry);
                if (replacement == null) mute = true; // 替换资源加载失败，退化为静音
            }

            UAkEventConfig cfg = mute
                ? new UAkEventConfig { AkEvent = null, StopMode = EAkEventStopMode.Auto }
                : new UAkEventConfig { AkEvent = replacement!, StopMode = EAkEventStopMode.Auto, bFollowAttachPoint = false };

            // 对 CDO 实例的写入会让之后所有新生成的该类子弹拷贝到空/替换值；对存活实例的写入无害
            comp.LoopEvent = cfg;
            comp.DeadEvent = cfg; // 同时静音死亡音

            string summary = mute ? "静音(置空)" : $"替换为 {entry.AkEventPath}";
            Log.Info($"[ProjectileAudioPatch] 已对类 [{clsName}] 的配置组件应用{summary}（AkEvent={(cfg.AkEvent == null ? "null" : cfg.AkEvent.GetName())}）");
            return true;
        }

        private static UAkAudioEvent? ResolveReplacement(PatchEntry entry)
        {
            if (entry.LoadAttempted) return entry.CachedAkEvent;
            entry.LoadAttempted = true;
            if (string.IsNullOrEmpty(entry.AkEventPath)) return null;
            try
            {
                var ev = UObject.LoadObject<UAkAudioEvent>(null, entry.AkEventPath);
                entry.CachedAkEvent = ev;
                if (ev == null) Log.Warn($"[ProjectileAudioPatch] 替换音效加载为空: {entry.AkEventPath}");
                return ev;
            }
            catch (Exception e)
            {
                Log.Warn($"[ProjectileAudioPatch] 替换音效加载异常 {entry.AkEventPath}: {e.Message}");
                return null;
            }
        }

        private static string DefaultConfigJson() => @"{
  ""Enabled"": true,
  ""Entries"": [
    {
      ""ClassKeyword"": ""SanJianLiangRen"",
      ""ClassPath"": """",
      ""Mode"": ""mute"",
      ""AkEventPath"": """"
    }
  ]
}";
    }
}
