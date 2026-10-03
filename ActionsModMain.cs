using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using b1;
using CSharpModBase;
using CSharpModBase.Input;
using Newtonsoft.Json;

namespace ActionsMod
{
    /// <summary>
    /// ActionsMod 入口：基于 CSharpLoader 的独立 Mod。
    /// 功能：读取 actions 配置（actions.json + actions 文件夹）→ 注册按键 → 按下时按骨骼分发执行动作。
    /// 另有一条可选的事件驱动路径：SweepCheck/Projectile/BuffActions/EffectActions 目录里的配置，
    /// 需要执行 RegEvents 动作订阅游戏事件后才会生效（UnRegEvents 解绑）。
    /// </summary>
    public class ActionsModMain : ICSharpMod
    {
        public string Name => "ActionsMod";
        public string Version => "0.1.0";

        private MagicModConfig? _config;
        private readonly List<HotKeyItem> _registeredHotKeys = new List<HotKeyItem>();

        // 按键名称到 Key 枚举的映射
        private static readonly Dictionary<string, Key> KeyMap = BuildKeyMap();

        private static Dictionary<string, Key> BuildKeyMap()
        {
            var map = new Dictionary<string, Key>(StringComparer.OrdinalIgnoreCase)
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
            };

            // 全字母 + 数字 + F1~F12 一并支持，避免"未知的按键名称"（只注册用到的，不影响游戏本身的键位）
            foreach (string name in Enum.GetNames(typeof(Key)))
            {
                if (map.ContainsKey(name)) continue;

                bool isLetter = name.Length == 1 && char.IsLetter(name[0]);
                bool isDigit = name.Length == 1 && char.IsDigit(name[0]);
                bool isFuncKey = name.Length >= 2 && name[0] == 'F'
                    && name.Skip(1).All(char.IsDigit) && int.TryParse(name.Substring(1), out _);
                if (!isLetter && !isDigit && !isFuncKey) continue;

                if (Enum.TryParse<Key>(name, true, out var k)) map[name] = k;
            }
            return map;
        }

        public void Init()
        {
            // 预加载音效/台词反查表（2MB 的 AkMarker 外部表后台解析），避免首次 SpeakDialogue 主线程卡顿
            try { SoundActions.Preload(); }
            catch (Exception e) { Log.Warn($"[ActionsMod] 预加载台词反查表失败: {e.Message}"); }

            // 加载配置
            _config = LoadConfig();
            if (_config == null)
            {
                _config = CreateDefaultConfig();
            }

            ModLog.Verbose = _config!.Verbose;

            // 合并 actions 文件夹里的多文件按键绑定（按骨骼分发）
            var actionFolderBindings = LoadActionFolderBindings();
            if (_config != null && actionFolderBindings.Count > 0)
            {
                _config.Bindings.AddRange(actionFolderBindings);
            }

            // 加载 soulBossConfig 幻化变身外观配置（可选目录；用于 Magic 动作自定义 Boss 外观）
            string actionsModDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, Common.ModDir, "ActionsMod");
            string soulDir = Path.Combine(actionsModDir, "soulBossConfig");
            var soulConfigList = SoulBossLogic.LoadSoulBossConfigs(soulDir);
            SoulBossLogic.InitSoulConfigs(soulConfigList);

            // 加载事件驱动绑定配置（SweepCheck/Projectile/BuffActions/EffectActions 可选目录）
            // 这些表格只有在执行了 RegEvents 动作后才会真正生效
            EventBindings.LoadAll(actionsModDir);

            // 读取跨 Mod 公共按键台账，用它生成本 Mod 的"开关类"按键绑定（RegEvents / TransBack / …）
            // 键位统一在 CSharpLoader\Mods\Common\hotkeys.json 里维护，改那里即可，不用动这里的 json
            HotKeyRegistry.Load();
            int switchCount = AppendHotKeyRegistryBindings();
            HotKeyRegistry.DumpTable();

            // 注册按键绑定
            RegisterBindings();

            // 子弹生成音效屏蔽/替换（运行期，读取 ProjectileAudioPatch.json）
            ProjectileAudioPatch.Init();

            // 开启跨地图自动重挂载：订阅全局关卡切换事件，进新图自动重新订阅玩家事件，
            // 从此不必每次进新地图都按 F1（World 未就绪时内部会重试订阅）
            ModEvents.EnableAutoRemount();

            Log.Info($"[ActionsMod] 初始化完成，共 {_config!.Bindings.Count} 个按键绑定（其中 actions 文件夹 {actionFolderBindings.Count} 个）");
        }

        public void DeInit()
        {
            int count = _registeredHotKeys.Count;
            // 解绑已订阅的游戏事件（RegEvents 注册的回调），避免热重载后残留重复订阅
            try
            {
                ModEvents.UnRegPlayerTransEvent();
                ModEvents.UnSweepCheckBeginEvent();
            }
            catch (Exception e)
            {
                Log.Error($"[ActionsMod] 解绑游戏事件失败: {e.Message}");
            }

            // 停掉镜头的维持定时器（避免热重载后定时器还在往已销毁的角色上写镜头参数）
            try
            {
                CameraActions.Shutdown();
            }
            catch (Exception e)
            {
                Log.Error($"[ActionsMod] 清理镜头覆盖失败: {e.Message}");
            }

            // 停掉子弹生成音效屏蔽/替换的扫描定时器
            try
            {
                ProjectileAudioPatch.Shutdown();
            }
            catch (Exception e)
            {
                Log.Error($"[ActionsMod] 清理音效屏蔽失败: {e.Message}");
            }

            // 关闭跨地图自动重挂载并退订全局关卡事件（避免热重载后残留重复订阅）
            try { ModEvents.DisableAutoRemount(); }
            catch (Exception e) { Log.Error($"[ActionsMod] 关闭自动重挂载失败: {e.Message}"); }

            Log.Info($"[ActionsMod] {Name} DeInit，清理 {count} 个快捷键绑定");
            _registeredHotKeys.Clear();
        }

        /// <summary>
        /// 按公共按键台账（Common/hotkeys.json）生成本 Mod 的"开关类"绑定，追加到 Bindings 里。
        /// 返回追加的条数。入口的按键只来自该 json（源码不写死默认值）；未登记的入口保持未绑定。
        /// </summary>
        private int AppendHotKeyRegistryBindings()
        {
            if (_config == null) return 0;

            int count = 0;
            foreach (var entry in HotKeyRegistry.GetSelfEntries())
            {
                if (!HotKeyRegistry.Entries.TryGetValue(entry.Key, out var actions) || actions.Length == 0) continue;

                _config.Bindings.Add(new KeyBindingConfig
                {
                    Key = entry.Value,
                    SourceFile = "Common/hotkeys.json",
                    Actions = actions.Select(t => new ActionConfig { Type = t }).ToList()
                });
                count++;
                Log.Info($"[ActionsMod] 公共台账入口 {entry.Key} -> {entry.Value}");
            }
            return count;
        }

        /// <summary>注册所有按键绑定（同名按键只注册一次，按下时按骨骼分发）</summary>
        private void RegisterBindings()
        {
            if (_config == null) return;

            foreach (var group in _config.Bindings
                .Where(b => b != null && !string.IsNullOrEmpty(b.Key))
                .GroupBy(b => b.Key, StringComparer.OrdinalIgnoreCase))
            {
                if (KeyMap.TryGetValue(group.Key, out var key))
                {
                    string keyName = group.Key;
                    var hotKey = Utils.RegisterKeyBind(key, () => OnKeyPressed(keyName));
                    _registeredHotKeys.Add(hotKey);
                    Log.Info($"[ActionsMod] 注册按键绑定: {keyName} -> {group.Count()} 个配置（按当前骨骼分发）");
                }
                else
                {
                    Log.Warn($"[ActionsMod] 未知的按键名称: {group.Key}");
                }
            }
        }

        /// <summary>
        /// 按键按下回调：按当前角色骨骼筛选命中的绑定后执行。
        /// 规则：存在骨骼精确命中的绑定时只执行命中的；没有任何精确命中才回退执行通用绑定（SKMesh 为空）。
        /// </summary>
        private void OnKeyPressed(string key)
        {
            Utils.TryRun(() =>
            {
                var character = ModHelper.GetCharacter();
                if (character == null)
                {
                    Log.Warn("[ActionsMod] 未找到玩家角色");
                    return;
                }
                if (_config == null) return;

                Log.Info($"[ActionsMod] 按键 {key} 按下，当前骨骼: {ModHelper.GetCurrentSKMeshName(character)}");

                var matched = _config.Bindings
                    .Where(b => b != null && !string.IsNullOrEmpty(b.Key)
                                && b.Key.Equals(key, StringComparison.OrdinalIgnoreCase))
                    .ToList();
                if (matched.Count == 0) return;

                // 作用域匹配：SKMesh（骨骼名子串）或 UnitName（单位类名子串）任一指定则必须满足；
                // 两者都未指定视为通用绑定。优先执行有作用域且命中的绑定，否则回退通用绑定。
                var scoped = matched
                    .Where(b => HasScope(b) && InScope(b, character))
                    .ToList();
                var toRun = scoped.Count > 0
                    ? scoped
                    : matched.Where(b => !HasScope(b)).ToList();

                foreach (var binding in toRun)
                {
                    string scope = string.IsNullOrEmpty(binding.SKMesh) ? "通用" : binding.SKMesh!;
                    Log.Info($"[ActionsMod] 按键 {key} 触发 [{binding.SourceFile ?? "actions.json"}] 骨骼={scope}，执行 {binding.Actions.Count} 个动作");
                    ActionExecutor.DoActions(character, binding.Actions);
                }
            });
        }

        /// <summary>绑定是否带作用域（骨骼名或单位名任一指定即为有作用域）</summary>
        private static bool HasScope(KeyBindingConfig b)
            => !string.IsNullOrEmpty(b.SKMesh) || !string.IsNullOrEmpty(b.UnitName);

        /// <summary>绑定作用域是否命中当前角色：SKMesh / UnitName 任一指定则必须满足，二者都未指定视为通用（恒真）</summary>
        private static bool InScope(KeyBindingConfig b, BGUPlayerCharacterCS character)
        {
            if (!string.IsNullOrEmpty(b.SKMesh) && !ModHelper.MatchSKMesh(character, b.SKMesh))
                return false;
            if (!string.IsNullOrEmpty(b.UnitName) && !ModHelper.MatchUnitName(character, b.UnitName))
                return false;
            return true;
        }

        /// <summary>从 actions 文件夹加载多文件按键绑定配置（支持按骨骼分文件）</summary>
        private List<KeyBindingConfig> LoadActionFolderBindings()
        {
            var result = new List<KeyBindingConfig>();

            string baseDir = AppDomain.CurrentDomain.BaseDirectory;
            string dir = Path.Combine(baseDir, Common.ModDir, "ActionsMod", "actions");

            if (!Directory.Exists(dir))
            {
                Log.Info($"[ActionsMod] actions 目录不存在（可选）: {dir}");
                return result;
            }

            string[] jsonFiles = Directory.GetFiles(dir, "*.json");
            Log.Info($"[ActionsMod] 扫描 actions 目录，找到 {jsonFiles.Length} 个配置文件");

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
                    if (cfg == null || ((cfg.Bindings == null || cfg.Bindings.Count == 0)))
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

                    Log.Info($"[ActionsMod]   加载 {fileName}: {cfg.Bindings?.Count ?? 0} 个按键绑定, SKMesh={(fileSKMesh ?? "通用")}");
                }
                catch (Exception e)
                {
                    Log.Error($"[ActionsMod] 加载 actions 配置失败 {filePath}: {e.Message}");
                }
            }

            return result;
        }

        /// <summary>从 actions.json 加载配置</summary>
        private MagicModConfig? LoadConfig()
        {
            string baseDir = AppDomain.CurrentDomain.BaseDirectory;
            string configPath = Path.Combine(baseDir, Common.ModDir, "ActionsMod", "actions.json");

            if (!File.Exists(configPath))
            {
                Log.Warn($"[ActionsMod] 配置文件不存在: {configPath}");
                return null;
            }

            try
            {
                string json = File.ReadAllText(configPath);
                return JsonConvert.DeserializeObject<MagicModConfig>(json);
            }
            catch (Exception e)
            {
                Log.Error($"[ActionsMod] 加载配置失败: {e.Message}");
                return null;
            }
        }

        /// <summary>创建默认配置（XBUTTON1 = Buff, XBUTTON2 = Skill 示例）</summary>
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
