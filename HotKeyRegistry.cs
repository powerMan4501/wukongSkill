using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using CSharpModBase;
using Newtonsoft.Json;

namespace ActionsMod
{
    /// <summary>
    /// 跨 Mod 按键台账（公共入口）。
    ///
    /// 背景：Mod 一多就记不住"哪个 Mod 该按什么键开启"，而且很容易撞键
    /// （例如 PanelActionsMod 的 OpenKey=F1 与本 Mod 的 RegEvents 默认键 F1 冲突）。
    ///
    /// 方案：所有 Mod 的**入口级**按键（开启 / 总开关 / 重载 / 重置这类）统一登记在
    ///     CSharpLoader\Mods\Common\hotkeys.json
    /// 每个 Mod 内部的游戏玩法键（连招、Buff、法术等）仍由各自 Mod 的 json 维护，
    /// 不混进来 —— 否则台账会和真实绑定不同步，越滚越大。
    /// 每张表按「Mod 名 → 入口名 → 按键」组织：
    /// {
    ///   "Mods": {
    ///     "ActionsMod": { "Note": "说明", "RegEvents": "F1", "UnRegEvents": "F5" },
    ///     "PlayerInfo":  { "Open": "F2" }
    ///   }
    /// }
    ///
    /// 本 Mod 的行为：
    ///   1) 启动时读取台账里属于 ActionsMod 的那一段，用它决定"开关类按键"（未配置的入口用代码里的默认值）
    ///   2) 打印整张台账（含所有 Mod），并对「同一按键被多个 Mod 使用」发出 WARN
    /// 台账只登记、本 Mod 不认识的入口会被忽略（用于纯备忘，例如别人 Mod 的键）。
    /// 其它 Mod 仍各自读自己的 json —— 这里只是把"用什么键"这件事集中到一处便于查阅与排查。
    /// </summary>
    public static class HotKeyRegistry
    {
        /// <summary>本 Mod 在台账里的名字</summary>
        public const string SelfModName = "ActionsMod";

        /// <summary>台账里的说明字段（不是按键入口）</summary>
        private const string NoteField = "Note";

        /// <summary>
        /// 本 Mod 的开关类入口（入口名 → 该入口要执行的动作）。
        /// 入口的「按键」一律来自 CSharpLoader\Mods\Common\hotkeys.json 的 ActionsMod 段，
        /// 源码里不再写死任何默认键（避免配置散落在代码里）。某个入口若没在 json 里登记，就保持未绑定。
        /// 入口名与推荐键位的权威清单见技能 gamedll-fanbyi/references/hotkey-registry.md。
        /// </summary>
        public static readonly Dictionary<string, ActionType[]> Entries =
            new Dictionary<string, ActionType[]>(StringComparer.OrdinalIgnoreCase)
            {
                { "RegEvents", new[] { ActionType.RegEvents } },
                { "TransBack", new[] { ActionType.trans_back, ActionType.out_magic } },
                { "UnRegEvents", new[] { ActionType.UnRegEvents } },
                { "LaserTest", new[] { ActionType.CastImmobilize } },
                { "ShowHotKeys", new[] { ActionType.ShowHotKeys } },
            };

        // Mod 名 → (入口名 → 按键)
        private static readonly Dictionary<string, Dictionary<string, string>> _table =
            new Dictionary<string, Dictionary<string, string>>(StringComparer.OrdinalIgnoreCase);

        private static bool _loaded;

        private class HotKeyTable
        {
            public Dictionary<string, Dictionary<string, string>>? Mods { get; set; }
        }

        /// <summary>台账文件路径：CSharpLoader\Mods\Common\hotkeys.json</summary>
        public static string FilePath =>
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, Common.ModDir, "Common", "hotkeys.json");

        /// <summary>加载台账（不存在就只保留本 Mod 的默认值）</summary>
        public static void Load()
        {
            _table.Clear();
            _loaded = true;

            string path = FilePath;
            if (!File.Exists(path))
            {
                Log.Warn($"[ActionsMod] 未找到公共按键台账 {path}（各 Mod 的开关按键仍按自身 json 生效）");
                return;
            }

            try
            {
                var table = JsonConvert.DeserializeObject<HotKeyTable>(File.ReadAllText(path));
                if (table?.Mods != null)
                {
                    foreach (var kv in table.Mods)
                    {
                        if (kv.Key == null || kv.Value == null) continue;
                        _table[kv.Key] = kv.Value;
                    }
                }
                int total = _table.Values.Sum(m => m.Count(k => !IsNoteField(k.Key)));
                Log.Info($"[ActionsMod] 已加载公共按键台账 {path}：{_table.Count} 个 Mod，共 {total} 条入口");
            }
            catch (Exception e)
            {
                Log.Error($"[ActionsMod] 加载公共按键台账失败 {path}: {e.Message}");
            }
        }

        private static bool IsNoteField(string name)
            => string.Equals(name, NoteField, StringComparison.OrdinalIgnoreCase) || name.StartsWith("_");

        /// <summary>取某个 Mod 某个入口登记的按键（没有返回 null）</summary>
        public static string? GetKey(string modName, string entryName)
        {
            if (!_loaded) Load();
            if (_table.TryGetValue(modName, out var entries) && entries.TryGetValue(entryName, out var key))
            {
                return key;
            }
            return null;
        }

        /// <summary>本 Mod 的开关入口解析结果（入口名 → 按键），只取 Common/hotkeys.json 里登记的值；未登记的入口不出现在此列表（即不绑定）</summary>
        public static List<KeyValuePair<string, string>> GetSelfEntries()
        {
            var result = new List<KeyValuePair<string, string>>();
            foreach (var kv in Entries)
            {
                string key = GetKey(SelfModName, kv.Key) ?? "";
                if (string.IsNullOrEmpty(key)) continue;
                result.Add(new KeyValuePair<string, string>(kv.Key, key));
            }
            return result;
        }

        /// <summary>
        /// 打印整张按键台账（所有 Mod）+ 撞键检查。
        /// 启动时自动调用一次；也可以绑 ShowHotKeys 动作随时再看。
        /// </summary>
        public static void DumpTable()
        {
            if (!_loaded) Load();

            if (_table.Count == 0)
            {
                Log.Info("[ActionsMod] === 按键台账 ===  Common/hotkeys.json 为空或未找到，本 Mod 以下入口均未绑定按键（需在 json 的 ActionsMod 段登记才会生效）:");
                foreach (var kv in Entries)
                {
                    Log.Info($"[ActionsMod]   {SelfModName,-16} {kv.Key,-14} = (未配置)");
                }
                return;
            }

            Log.Info("[ActionsMod] === 按键台账（Common/hotkeys.json）===");
            foreach (var mod in _table.OrderBy(m => m.Key, StringComparer.OrdinalIgnoreCase))
            {
                string note = mod.Value.TryGetValue(NoteField, out var n) ? $"  // {n}" : "";
                Log.Info($"[ActionsMod] [{mod.Key}]{note}");
                foreach (var entry in mod.Value.OrderBy(e => e.Key, StringComparer.OrdinalIgnoreCase))
                {
                    if (IsNoteField(entry.Key)) continue;
                    Log.Info($"[ActionsMod]     {entry.Key,-20} = {entry.Value}");
                }
            }

            DumpConflicts();
        }

        /// <summary>检查「同一个按键被多个 Mod 占用」，有则 WARN</summary>
        private static void DumpConflicts()
        {
            var byKey = new Dictionary<string, List<string>>(StringComparer.OrdinalIgnoreCase);
            foreach (var mod in _table)
            {
                foreach (var entry in mod.Value)
                {
                    if (IsNoteField(entry.Key) || string.IsNullOrEmpty(entry.Value)) continue;
                    if (!byKey.TryGetValue(entry.Value, out var owners)) byKey[entry.Value] = owners = new List<string>();
                    string owner = $"{mod.Key}.{entry.Key}";
                    if (!owners.Contains(owner)) owners.Add(owner);
                }
            }

            bool any = false;
            foreach (var kv in byKey.Where(k => k.Value.Count > 1).OrderBy(k => k.Key))
            {
                any = true;
                Log.Warn($"[ActionsMod] 按键冲突：{kv.Key} 被 {kv.Value.Count} 个入口同时使用 -> {string.Join(", ", kv.Value)}");
            }
            if (!any) Log.Info("[ActionsMod] 按键台账检查通过：未发现跨入口撞键");
        }
    }
}
