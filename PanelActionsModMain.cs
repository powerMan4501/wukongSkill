using System;
using System.Collections.Generic;
using System.IO;
using CSharpModBase;
using CSharpModBase.Input;
using Newtonsoft.Json;

namespace PanelActionsMod
{
    /// <summary>
    /// PanelActionsMod 入口：基于 CSharpLoader 的独立 Mod。
    /// 功能：按一个键打开画板（MiniGM 网格面板），画板按 panel.json 的分类展示
    ///      Boss / 变身 / 物品（装备·丹药·材料·道具），点击条目执行对应动作。
    /// 只做面板展示 + 三类动作，不含 MagicMod 的按键绑定 / 事件驱动 / 抓投 / 信息面板等子系统。
    /// 配置目录：CSharpLoader\Mods\PanelActionsMod\
    /// </summary>
    public class PanelActionsModMain : ICSharpMod
    {
        public string Name => "PanelActionsMod";
        public string Version => "0.1.0";

        private readonly List<HotKeyItem> _registeredHotKeys = new List<HotKeyItem>();

        // 按键名称到 Key 枚举的映射
        private static readonly Dictionary<string, Key> KeyMap = new Dictionary<string, Key>(StringComparer.OrdinalIgnoreCase)
        {
            { "XBUTTON1", Key.XBUTTON1 },
            { "XBUTTON2", Key.XBUTTON2 },
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
            { "Z", Key.Z },
            { "X", Key.X },
            { "C", Key.C },
            { "V", Key.V },
            { "F1", Key.F1 },
            { "F2", Key.F2 },
            { "F3", Key.F3 },
            { "F4", Key.F4 },
            { "F5", Key.F5 },
            { "F6", Key.F6 },
            { "F7", Key.F7 },
            { "F8", Key.F8 },
            { "F9", Key.F9 },
            { "F10", Key.F10 },
        };

        public void Init()
        {
            PanelActionsConfig config = LoadConfig() ?? new PanelActionsConfig();
            RegisterOpenKey(config.OpenKey);

            Log.Info($"[PanelActionsMod] 初始化完成：开画板按键={config.OpenKey}");
        }

        public void DeInit()
        {
            int count = _registeredHotKeys.Count;
            Log.Info($"[PanelActionsMod] {Name} DeInit，清理 {count} 个快捷键绑定");
            _registeredHotKeys.Clear();
        }

        /// <summary>注册“打开画板”按键</summary>
        private void RegisterOpenKey(string? openKey)
        {
            string keyName = string.IsNullOrEmpty(openKey) ? "F8" : openKey!;
            if (!KeyMap.TryGetValue(keyName, out var key))
            {
                Log.Warn($"[PanelActionsMod] 未知的按键名称: {keyName}，回退为 F8");
                keyName = "F8";
                key = Key.F8;
            }

            var hotKey = Utils.RegisterKeyBind(key, () =>
            {
                Utils.TryRun(() => BossPanel.OpenPanel());
            });
            _registeredHotKeys.Add(hotKey);
            Log.Info($"[PanelActionsMod] 已注册开画板按键: {keyName}");
        }

        /// <summary>从 PanelActionsMod.json 加载本 Mod 配置（可选，缺失时用默认按键 F8）</summary>
        private PanelActionsConfig? LoadConfig()
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, Common.ModDir, "PanelActionsMod", "PanelActionsMod.json");
            if (!File.Exists(path))
            {
                Log.Info($"[PanelActionsMod] 配置文件不存在（使用默认按键 F8）: {path}");
                return null;
            }

            try
            {
                return JsonConvert.DeserializeObject<PanelActionsConfig>(File.ReadAllText(path));
            }
            catch (Exception e)
            {
                Log.Error($"[PanelActionsMod] 加载配置失败: {e.Message}");
                return null;
            }
        }

        /// <summary>本 Mod 的根配置</summary>
        private class PanelActionsConfig
        {
            /// <summary>打开画板的按键名（默认 F8）</summary>
            public string OpenKey { get; set; } = "F8";
        }
    }
}
