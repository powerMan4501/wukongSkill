using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using b1;
using CSharpModBase;
using CSharpModBase.Input;
using HarmonyLib;
using Newtonsoft.Json;

namespace MagicMod
{
    /// <summary>
    /// MagicMod 入口：基于 CSharpLoader 的 Mod
    /// 绑定 XBUTTON1/XBUTTON2 按键，触发自定义动作
    /// </summary>
    public class MagicModMain : ICSharpMod
    {
        public string Name => "MagicMod";
        public string Version => "0.1.0";

        private MagicModConfig? _config;
        private readonly List<HotKeyItem> _registeredHotKeys = new List<HotKeyItem>();

        // 傀儡附身移动驱动用的 Harmony 实例（Init 中 PatchAll，DeInit 中 UnpatchAll）
        private const string HarmonyId = "magicmod.customtrans";
        private static Harmony? _harmony;

        // 按键名称到 Key 枚举的映射
        private static readonly Dictionary<string, Key> KeyMap = new Dictionary<string, Key>(StringComparer.OrdinalIgnoreCase)
        {
            { "XBUTTON1", Key.XBUTTON1 },
            { "XBUTTON2", Key.XBUTTON2 },
            { "LBUTTON", Key.LBUTTON },
            { "RBUTTON", Key.RBUTTON },
            { "MBUTTON", Key.MBUTTON },
            { "SPACE", Key.SPACE },
            { "ENTER", Key.ENTER },
            { "TAB", Key.TAB },
            { "SHIFT", Key.LSHIFT },
            { "CONTROL", Key.LCONTROL },
            { "ALT", Key.LMENU },
            { "Q", Key.Q },
            { "E", Key.E },
            { "R", Key.R },
            { "F", Key.F },
            { "G", Key.G },
            { "A", Key.A },
            { "D", Key.D },
            { "S", Key.S },

            { "J", Key.J },
            { "K", Key.K },
            
            
            { "Z", Key.Z },
            { "X", Key.X },
            { "C", Key.C },
            { "V", Key.V },
            { "F1", Key.F1 },
            { "F2", Key.F2 },
            { "F3", Key.F3 },
            { "F4", Key.F4 },
            { "F5", Key.F5 },
        };
        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool SetConsoleOutputCP(uint wCodePageID);

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool SetConsoleCP(uint wCodePageID);

        public static void EnableCNInConsole()
        {
            SetConsoleCP(65001u);
            SetConsoleOutputCP(65001u);
            Log.Info("EnableCNInConsole 开启中文输出");
        }
        public void Init()
        {
            EnableCNInConsole();
            Log.Info($"[MagicMod] {Name} v{Version} Init");

            // 加载配置
            _config = LoadConfig();
            if (_config == null)
            {
                Log.Warn("[MagicMod] 配置加载失败，使用默认配置");
                _config = CreateDefaultConfig();
            }

            // 高频日志开关（actions.json 根级 "verbose": true）。默认关闭：
            // 这些回调每秒触发几十次，无条件打日志会持续占用游戏线程
            ModLog.Verbose = _config.Verbose;
            Log.Info($"[MagicMod] 高频日志(verbose): {(ModLog.Verbose ? "开" : "关")}");

            // 合并 actions 文件夹里的多文件按键绑定（按骨骼分发）
            var actionFolderBindings = LoadActionFolderBindings();
            if (_config != null && actionFolderBindings.Count > 0)
            {
                _config.Bindings.AddRange(actionFolderBindings);
            }

            // 注册按键绑定
            RegisterBindings();

            // 初始化骨骼绑定
            ActionExecutor.InitMeshBindings(_config.MeshBindings);

            // 初始化 SweepCheck 动画绑定（从 SweepCheck 文件夹加载所有 JSON 配置）
            var sweepCheckBindings = LoadSweepCheckBindings();
            ActionExecutor.InitSweepCheckBindings(sweepCheckBindings);

            // 初始化 Projectile 生成绑定（从 Projectile 文件夹加载所有 JSON 配置）
            var projectileBindings = LoadProjectileBindings();
            ActionExecutor.InitProjectileBindings(projectileBindings);

            // 初始化 Buff 动作绑定（从 BuffActions 文件夹加载所有 JSON 配置，BuffBegin 时按 BuffID 触发）
            var buffActionBindings = LoadIdActionBindings("BuffActions");
            ActionExecutor.InitBuffActionBindings(buffActionBindings);

            // 初始化 Effect 动作绑定（从 EffectActions 文件夹加载所有 JSON 配置，OnTriggerSkillEffect 时按 EffectID 触发）
            var effectActionBindings = LoadIdActionBindings("EffectActions");
            ActionExecutor.InitEffectActionBindings(effectActionBindings);

            // 初始化幻化变身 Boss 外观配置（从 soulBossConfig 文件夹加载所有 JSON 配置，汇总为 soulConfigList）
            var soulConfigList = LoadSoulBossConfigs();
            ActionExecutor.InitSoulConfigs(soulConfigList);

            // 初始化变身（Player Trans）自定义配置（从 transConfig 文件夹加载所有 JSON 配置，汇总为 transConfigList）
            var transConfigList = LoadTransConfigs();
            ActionExecutor.InitTransConfigs(transConfigList);

            // 抓投目标形态自动替换：让非玩家单位也能播针对玩家的抓投同步动画
            GrabSyncGuestFix.Init();

            // 应用 Harmony 补丁：傀儡附身状态下用 TickInputForMoving Postfix 驱动 boss 移动
            try
            {
                if (_harmony == null)
                {
                    _harmony = new Harmony(HarmonyId);
                    // 傀儡附身（CustomTransSystem）已停用：不再安装逐帧 Harmony 补丁
                    // （TickInputForMovingPatch / InputActionTriggerPatch 两个补丁仅服务于傀儡附身）
                    // _harmony.PatchAll();
                    Log.Info($"[MagicMod] Harmony 补丁已跳过：傀儡附身(CustomTransSystem)停用 ({HarmonyId})");
                }
            }
            catch (Exception e)
            {
                Log.Error($"[MagicMod] Harmony 补丁应用失败: {e.Message}");
            }


            Log.Info($"[MagicMod] 初始化完成，共 {_config.Bindings.Count} 个按键绑定（其中 actions 文件夹 {actionFolderBindings.Count} 个），{_config.MeshBindings.Count} 个骨骼绑定，{sweepCheckBindings.Count} 个 SweepCheck 绑定，{projectileBindings.Count} 个 Projectile 绑定，{buffActionBindings.Count} 个 BuffActions 绑定，{effectActionBindings.Count} 个 EffectActions 绑定，{soulConfigList.Count} 个 SoulBossConfig 配置，{transConfigList.Count} 个 TransConfig 变身配置");
        }

        public void DeInit()
        {
            int count = _registeredHotKeys.Count;
            Log.Info($"[MagicMod] {Name} DeInit");
            // 清空已注册的快捷键引用
            // 注意：CSharpManager 在重载 Mod 时会调用 InputManager.Clear() 清空所有快捷键
            // 这里清空引用列表以保持状态一致
            _registeredHotKeys.Clear();
            // 角色缓存里可能还持有旧的 Pawn 引用，重载后必须失效
            ModHelper.InvalidateCharacterCache();
            ModHelper.UnRegPlayerTransEvent();
            ModHelper.UnSweepCheckBeginEvent();
            // 停掉动画播放位置监听，避免重载后定时器残留
            MontagePositionWatcher.Stop();
            // 顺带清掉 路径→规则 缓存，避免重载后沿用旧配置
            MontagePositionWatcher.InvalidateCache();
            // 停掉两阵营互殴 tick，避免重载后定时器残留
            ModHelper.StopTeamBattleTick();

            // 补：清理其余常驻定时器与 UI。
            // 之前热重载只会停上面两个，剩下的 500ms 面板刷新 / 300ms 棍光重应用 / 骨骼发光延时定时器
            // 会随每次重载各残留一份，越堆越多 → 卡顿、卡死。这些都要动 UObject，统一投递到游戏线程执行。
            try
            {
                UnrealEngine.Runtime.FThreading.RunOnGameThreadAsync(() =>
                {
                    // 1) 玩家信息面板：500ms 刷新定时器 + 面板 UI
                    try { ShowPlayerInfo.ClearAllUI(); }
                    catch (Exception e) { Log.Error($"[MagicMod] 清理玩家信息面板失败: {e.Message}"); }

                    // 2) 棍光：300ms 持续重应用定时器 + 还原材质
                    try { MaterialGlow.Stop(); }
                    catch (Exception e) { Log.Error($"[MagicMod] 清理棍光失败: {e.Message}"); }

                    // 3) 骨骼发光：延时关闭 / 扫描定时器 + 销毁特效组件
                    try { BoneGlow.ClearTimers(); BoneGlow.StopAll(); }
                    catch (Exception e) { Log.Error($"[MagicMod] 清理骨骼发光失败: {e.Message}"); }

                    // 4) 角色整体缩放（原"武器拉长"）：还原 Actor 缩放，避免重载后角色一直保持放大
                    try { WeaponScale.ResetAll(); }
                    catch (Exception e) { Log.Error($"[MagicMod] 还原角色缩放失败: {e.Message}"); }

                    // 5) 原生变身：兜底停掉 40ms 守护轮询并收尾（入口当前已停用，这里只为防残留）
                    try { if (NativeTransSystem.IsActive) NativeTransSystem.DeInit(); }
                    catch (Exception e) { Log.Error($"[MagicMod] 清理原生变身失败: {e.Message}"); }

                    // 6) 动画绑定表现（BindMontageFX）：解绑回调 + 结束表现
                    try { MontageFxBinder.UnbindAll(); }
                    catch (Exception e) { Log.Error($"[MagicMod] 解绑动画表现失败: {e.Message}"); }

                    // 7) 棍影（StaffTrail）：解绑 Montage 回调 + 销毁残留组件
                    try { StaffTrailHelper.UnbindAll(); }
                    catch (Exception e) { Log.Error($"[MagicMod] 解绑棍影失败: {e.Message}"); }

                    // 8) DispFX 会话：Session 直接持有 AActor，不清理会永久 root 住
                    try { BuffDispLite.StopAll(); }
                    catch (Exception e) { Log.Error($"[MagicMod] 清理 DispFX 表现失败: {e.Message}"); }

                    // 9) DBC 表现：销毁当前角色身上的残留 DBC
                    try
                    {
                        var chr = ModHelper.GetCharacter(true) ?? ModUtils.GetControlledPawn() as BGUCharacterCS;
                        if (chr != null) DbcFx.Stop(chr); // Stop 内部会自己判断已销毁
                    }
                    catch (Exception e) { Log.Error($"[MagicMod] 清理 DBC 表现失败: {e.Message}"); }

                    // 10) 最后统一停掉 TimerPool 里所有在跑的定时器（一次性 / 周期性）
                    try { TimerPool.ClearAll(); }
                    catch (Exception e) { Log.Error($"[MagicMod] 清理定时器池失败: {e.Message}"); }
                });
            }
            catch (Exception e) { Log.Error($"[MagicMod] 投递常驻定时器清理失败: {e.Message}"); }
            // 傀儡附身已停用：不再调用 CustomTransSystem.EndTrans（代码保留，仅停用调用）
            // try { if (CustomTransSystem.IsActive) CustomTransSystem.EndTrans(); }
            // catch (Exception e) { Log.Error($"[MagicMod] 结束傀儡附身失败: {e.Message}"); }
            // 原生变身已停用：不再调用 NativeTransSystem.DeInit（代码保留，仅停用调用）
            // try { NativeTransSystem.DeInit(); }
            // catch (Exception e) { Log.Error($"[MagicMod] 结束原生变身失败: {e.Message}"); }
            // 停止抓投形态替换并还原被投者，避免重载后被投单位残留替换后的模型
            try { GrabSyncGuestFix.DeInit(); }
            catch (Exception e) { Log.Error($"[MagicMod] 停止抓投形态替换失败: {e.Message}"); }
            // 卸载 Harmony 补丁，避免重载后重复 patch
            try
            {
                if (_harmony != null) { _harmony.UnpatchAll(HarmonyId); _harmony = null; Log.Info($"[MagicMod] Harmony 补丁已卸载 ({HarmonyId})"); }
            }
            catch (Exception e) { Log.Error($"[MagicMod] Harmony 卸载失败: {e.Message}"); }
            Log.Info($"[MagicMod] 已清理 {count} 个快捷键绑定");
        }

        /// <summary>
        /// 注册所有按键绑定
        /// </summary>
        private void RegisterBindings()
        {
            if (_config == null) return;

            // 同名按键只注册一次，按下时按骨骼分发到具体绑定
            foreach (var group in _config.Bindings
                .Where(b => b != null && !string.IsNullOrEmpty(b.Key))
                .GroupBy(b => b.Key, StringComparer.OrdinalIgnoreCase))
            {
                if (KeyMap.TryGetValue(group.Key, out var key))
                {
                    string keyName = group.Key;
                    var hotKey = Utils.RegisterKeyBind(key, () => OnKeyPressed(keyName));
                    _registeredHotKeys.Add(hotKey);
                    Log.Info($"[MagicMod] 注册按键绑定: {keyName} -> {group.Count()} 个配置（按当前骨骼分发）");
                }
                else
                {
                    Log.Warn($"[MagicMod] 未知的按键名称: {group.Key}");
                }
            }
        }

        /// <summary>
        /// 按键按下回调：按当前角色骨骼筛选命中的绑定后执行
        /// 规则：存在骨骼精确命中的绑定时只执行命中的；没有任何精确命中才回退执行通用绑定（SKMesh 为空）
        /// </summary>
        private void OnKeyPressed(string key)
        {
            Utils.TryRun(() =>
            {
                // 变身期间受控 Pawn 是 Boss（非 BGUPlayerCharacterCS），GetCharacter() 会返回 null，
                // 需用受控 Pawn 兜底，否则 trans_back 等动作被拦截在 OnKeyPressed 早期 return，导致无法变回。
                // 按键路径强制刷新：变身期间受控 Pawn 是 Boss（非 BGUPlayerCharacterCS），
                // 必须拿到最新的受控单位，不能用缓存（缓存会命中变身前的玩家本体）
                var character = ModHelper.GetCharacter(forceRefresh: true) ?? ModUtils.GetControlledPawn() as BGUCharacterCS;
                if (character == null)
                {
                    Log.Warn("[MagicMod] 未找到玩家角色");
                    return;
                }
                if (_config == null) return;

                Log.Info($"[MagicMod] 按键 {key} 按下，当前骨骼: {ModHelper.GetCurrentSKMeshName(character as BGUPlayerCharacterCS)}");

                var matched = _config.Bindings
                    .Where(b => b != null && !string.IsNullOrEmpty(b.Key)
                                && b.Key.Equals(key, StringComparison.OrdinalIgnoreCase))
                    .ToList();
                if (matched.Count == 0) return;

                var scoped = matched
                    .Where(b => !string.IsNullOrEmpty(b.SKMesh) && ModHelper.MatchSKMesh(character as BGUPlayerCharacterCS, b.SKMesh))
                    .ToList();
                var toRun = scoped.Count > 0
                    ? scoped
                    : matched.Where(b => string.IsNullOrEmpty(b.SKMesh)).ToList();

                // 原生变身已停用：不再走 NativeTransSystem 变回（代码保留，仅停用调用）。
                // 傀儡附身期间受控 Pawn 仍是玩家本人，trans_back 由下方 DoActions → ModHelper.TransBack → CustomTransSystem.EndTrans 处理。
                // if (NativeTransSystem.IsActive && toRun.Any(b => b.Actions != null && b.Actions.Any(a => a.Type == ActionType.trans_back)))
                // {
                //     Log.Info("[MagicMod] 变身中触发 trans_back，直接变回");
                //     NativeTransSystem.EndTrans();
                //     return;
                // }

                foreach (var binding in toRun)
                {
                    string scope = string.IsNullOrEmpty(binding.SKMesh) ? "通用" : binding.SKMesh;
                    Log.Info($"[MagicMod] 按键 {key} 触发 [{binding.SourceFile ?? "actions.json"}] 骨骼={scope}，执行 {binding.Actions.Count} 个动作");
                    ActionExecutor.DoActions(character as BGUPlayerCharacterCS, binding.Actions);
                }
            });
        }

        /// <summary>
        /// 从 actions 文件夹加载多文件按键绑定配置（支持按骨骼分文件）。
        /// 文件格式（完整对象）：
        /// {
        ///   "SKMesh": "/Game/.../SK_Wukong_Simple.SK_Wukong_Simple",
        ///   "Bindings": [ { "Key": "F1", "Actions": [...] } ],
        ///   "MeshBindings": [ ... ]        // 可选
        /// }
        /// 也兼容直接写成 Bindings 数组（此时 SKMesh 为空 = 通用）。
        /// 文件级 SKMesh 会下发给本文件内所有未单独指定 SKMesh 的按键绑定。
        /// </summary>
        private List<KeyBindingConfig> LoadActionFolderBindings()
        {
            var result = new List<KeyBindingConfig>();
            var meshBindings = new List<MeshActionConfig>();

            string baseDir = AppDomain.CurrentDomain.BaseDirectory;
            string dir = Path.Combine(baseDir, Common.ModDir, "MagicMod", "actions");

            if (!Directory.Exists(dir))
            {
                Log.Info($"[MagicMod] actions 目录不存在（可选）: {dir}");
                return result;
            }

            string[] jsonFiles = Directory.GetFiles(dir, "*.json");
            Log.Info($"[MagicMod] 扫描 actions 目录，找到 {jsonFiles.Length} 个配置文件");

            foreach (string filePath in jsonFiles)
            {
                try
                {
                    string json = File.ReadAllText(filePath);
                    MagicModConfig? cfg = null;
                    try
                    {
                        cfg = JsonConvert.DeserializeObject<MagicModConfig>(json);
                    }
                    catch
                    {
                        cfg = null;
                    }

                    // 兼容简写：文件直接写成 Bindings 数组
                    if (cfg == null || ((cfg.Bindings == null || cfg.Bindings.Count == 0) && (cfg.MeshBindings == null || cfg.MeshBindings.Count == 0)))
                    {
                        var list = JsonConvert.DeserializeObject<List<KeyBindingConfig>>(json);
                        if (list != null && list.Count > 0) cfg = new MagicModConfig { Bindings = list };
                    }
                    if (cfg == null) continue;

                    string? fileSKMesh = string.IsNullOrEmpty(cfg.SKMesh) ? null : cfg.SKMesh;
                    string fileName = Path.GetFileName(filePath);

                    if (cfg.Bindings != null)
                    {
                        foreach (var b in cfg.Bindings)
                        {
                            if (b == null || string.IsNullOrEmpty(b.Key)) continue;
                            if (string.IsNullOrEmpty(b.SKMesh)) b.SKMesh = fileSKMesh;
                            b.SourceFile = fileName;
                            result.Add(b);
                        }
                    }
                    if (cfg.MeshBindings != null) meshBindings.AddRange(cfg.MeshBindings);

                    Log.Info($"[MagicMod]   加载 {fileName}: {cfg.Bindings?.Count ?? 0} 个按键绑定, {cfg.MeshBindings?.Count ?? 0} 个骨骼绑定, SKMesh={(fileSKMesh ?? "通用")}");
                }
                catch (Exception e)
                {
                    Log.Error($"[MagicMod] 加载 actions 配置失败 {filePath}: {e.Message}");
                }
            }

            // 文件夹里也可以配 MeshBindings（UseVigorSkill 触发），合并进主配置
            if (meshBindings.Count > 0 && _config != null)
            {
                _config.MeshBindings.AddRange(meshBindings);
            }

            return result;
        }

        /// <summary>
        /// 从 JSON 文件加载配置
        /// </summary>
        private MagicModConfig? LoadConfig()
        {
            string baseDir = AppDomain.CurrentDomain.BaseDirectory;
            string configPath = Path.Combine(baseDir, Common.ModDir, "MagicMod", "actions.json");

            if (!File.Exists(configPath))
            {
                Log.Warn($"[MagicMod] 配置文件不存在: {configPath}");
                return null;
            }

            try
            {
                string json = File.ReadAllText(configPath);
                return JsonConvert.DeserializeObject<MagicModConfig>(json);
            }
            catch (Exception e)
            {
                Log.Error($"[MagicMod] 加载配置失败: {e.Message}");
                return null;
            }
        }

 
        /// <summary>
        /// 从 SweepCheck 文件夹加载所有碰撞检查绑定配置
        /// </summary>
        private List<SweepCheckBindingConfig> LoadSweepCheckBindings()
        {
            string baseDir = AppDomain.CurrentDomain.BaseDirectory;
            string sweepCheckDir = Path.Combine(baseDir, Common.ModDir, "MagicMod", "SweepCheck");
            var allBindings = new List<SweepCheckBindingConfig>();

            if (!Directory.Exists(sweepCheckDir))
            {
                Log.Warn($"[MagicMod] SweepCheck 配置目录不存在: {sweepCheckDir}");
                return allBindings;
            }

            string[] jsonFiles = Directory.GetFiles(sweepCheckDir, "*.json");
            Log.Info($"[MagicMod] 扫描 SweepCheck 目录，找到 {jsonFiles.Length} 个配置文件");

            foreach (string filePath in jsonFiles)
            {
                try
                {
                    string json = File.ReadAllText(filePath);
                    var bindings = JsonConvert.DeserializeObject<List<SweepCheckBindingConfig>>(json);
                    if (bindings != null)
                    {
                        allBindings.AddRange(bindings);
                        Log.Info($"[MagicMod]   加载 {Path.GetFileName(filePath)}: {bindings.Count} 条规则");
                    }
                }
                catch (Exception e)
                {
                    Log.Error($"[MagicMod] 加载 SweepCheck 配置失败 {filePath}: {e.Message}");
                }
            }

            return allBindings;
        }

        /// <summary>
        /// 从 Projectile 文件夹加载所有子弹/法术场生成绑定配置
        /// </summary>
        private List<ProjectileBindingConfig> LoadProjectileBindings()
        {
            string baseDir = AppDomain.CurrentDomain.BaseDirectory;
            string projectileDir = Path.Combine(baseDir, Common.ModDir, "MagicMod", "Projectile");
            var allBindings = new List<ProjectileBindingConfig>();

            if (!Directory.Exists(projectileDir))
            {
                Log.Warn($"[MagicMod] Projectile 配置目录不存在: {projectileDir}");
                return allBindings;
            }

            string[] jsonFiles = Directory.GetFiles(projectileDir, "*.json");
            Log.Info($"[MagicMod] 扫描 Projectile 目录，找到 {jsonFiles.Length} 个配置文件");

            foreach (string filePath in jsonFiles)
            {
                try
                {
                    string json = File.ReadAllText(filePath);
                    var bindings = JsonConvert.DeserializeObject<List<ProjectileBindingConfig>>(json);
                    if (bindings != null)
                    {
                        allBindings.AddRange(bindings);
                        Log.Info($"[MagicMod]   加载 {Path.GetFileName(filePath)}: {bindings.Count} 条规则");
                    }
                }
                catch (Exception e)
                {
                    Log.Error($"[MagicMod] 加载 Projectile 配置失败 {filePath}: {e.Message}");
                }
            }

            return allBindings;
        }

        /// <summary>
        /// 从指定文件夹加载所有 ID 动作绑定配置（BuffActions / EffectActions）
        /// JSON 格式：[{ "id": 11447, "actions": [...] }]
        /// </summary>
        private List<IdActionBindingConfig> LoadIdActionBindings(string folderName)
        {
            string baseDir = AppDomain.CurrentDomain.BaseDirectory;
            string bindingDir = Path.Combine(baseDir, Common.ModDir, "MagicMod", folderName);
            var allBindings = new List<IdActionBindingConfig>();

            if (!Directory.Exists(bindingDir))
            {
                Log.Warn($"[MagicMod] {folderName} 配置目录不存在: {bindingDir}");
                return allBindings;
            }

            string[] jsonFiles = Directory.GetFiles(bindingDir, "*.json");
            Log.Info($"[MagicMod] 扫描 {folderName} 目录，找到 {jsonFiles.Length} 个配置文件");

            foreach (string filePath in jsonFiles)
            {
                try
                {
                    string json = File.ReadAllText(filePath);
                    var bindings = JsonConvert.DeserializeObject<List<IdActionBindingConfig>>(json);
                    if (bindings != null)
                    {
                        allBindings.AddRange(bindings);
                        Log.Info($"[MagicMod]   加载 {Path.GetFileName(filePath)}: {bindings.Count} 条规则");
                    }
                }
                catch (Exception e)
                {
                    Log.Error($"[MagicMod] 加载 {folderName} 配置失败 {filePath}: {e.Message}");
                }
            }

            return allBindings;
        }

        /// <summary>
        /// 从 soulBossConfig 文件夹加载所有幻化变身 Boss 外观配置，汇总为 soulConfigList
        /// JSON 格式：[{ "ID": 1111101, "BuffId": 289, "BossConf": { ... }, "TamerPath": "..." }]
        /// </summary>
        private List<SoulBossConfig> LoadSoulBossConfigs()
        {
            string baseDir = AppDomain.CurrentDomain.BaseDirectory;
            string soulConfigDir = Path.Combine(baseDir, Common.ModDir, "MagicMod", "soulBossConfig");
            var soulConfigList = new List<SoulBossConfig>();

            if (!Directory.Exists(soulConfigDir))
            {
                Log.Warn($"[MagicMod] soulBossConfig 配置目录不存在: {soulConfigDir}");
                return soulConfigList;
            }

            string[] jsonFiles = Directory.GetFiles(soulConfigDir, "*.json");
            Log.Info($"[MagicMod] 扫描 soulBossConfig 目录，找到 {jsonFiles.Length} 个配置文件");

            foreach (string filePath in jsonFiles)
            {
                try
                {
                    string json = File.ReadAllText(filePath);
                    var configs = JsonConvert.DeserializeObject<List<SoulBossConfig>>(json);
                    if (configs != null)
                    {
                        soulConfigList.AddRange(configs);
                        Log.Info($"[MagicMod]   加载 {Path.GetFileName(filePath)}: {configs.Count} 条配置");
                    }
                }
                catch (Exception e)
                {
                    Log.Error($"[MagicMod] 加载 soulBossConfig 配置失败 {filePath}: {e.Message}");
                }
            }

            return soulConfigList;
        }

        /// <summary>
        /// 从 transConfig 文件夹加载所有变身（Player Trans）自定义配置，汇总为 transConfigList
        /// JSON 格式：[{ "ID": 2111101, "name": "夜叉王", "BPPath": "...Unit_XXX_C", ... }]
        /// </summary>
        private List<TransConfig> LoadTransConfigs()
        {
            string baseDir = AppDomain.CurrentDomain.BaseDirectory;
            string transConfigDir = Path.Combine(baseDir, Common.ModDir, "MagicMod", "transConfig");
            var transConfigList = new List<TransConfig>();

            if (!Directory.Exists(transConfigDir))
            {
                Log.Warn($"[MagicMod] transConfig 配置目录不存在: {transConfigDir}");
                return transConfigList;
            }

            string[] jsonFiles = Directory.GetFiles(transConfigDir, "*.json");
            Log.Info($"[MagicMod] 扫描 transConfig 目录，找到 {jsonFiles.Length} 个配置文件");

            foreach (string filePath in jsonFiles)
            {
                try
                {
                    string json = File.ReadAllText(filePath);
                    var configs = JsonConvert.DeserializeObject<List<TransConfig>>(json);
                    if (configs != null)
                    {
                        transConfigList.AddRange(configs);
                        Log.Info($"[MagicMod]   加载 {Path.GetFileName(filePath)}: {configs.Count} 条变身配置");
                    }
                }
                catch (Exception e)
                {
                    Log.Error($"[MagicMod] 加载 transConfig 配置失败 {filePath}: {e.Message}");
                }
            }

            return transConfigList;
        }

        /// <summary>
        /// 创建默认配置（XBUTTON1 = Buff, XBUTTON2 = Skill 示例）
        /// </summary>
        private MagicModConfig CreateDefaultConfig()
        {
            return new MagicModConfig
            {
                Bindings = new List<KeyBindingConfig>
                {
                    new KeyBindingConfig
                    {
                        Key = "XBUTTON1",
                        Actions = new List<ActionConfig>
                        {
                            new ActionConfig { Type = ActionType.Buff, Value = 287, Duration = 3000 }
                        }
                    },
                    new KeyBindingConfig
                    {
                        Key = "XBUTTON2",
                        Actions = new List<ActionConfig>
                        {
                            new ActionConfig { Type = ActionType.Skill, Value = 10705 }
                        }
                    }
                }
            };
        }
    }
}
