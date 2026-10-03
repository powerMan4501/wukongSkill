using System.Collections.Generic;

namespace PanelActionsMod
{
    /// <summary>
    /// 画板支持的动作类型。
    /// 本 Mod 只做「面板展示 + 点一下执行动作」，因此只保留画板真正需要的三类：
    /// 加物品（材料/丹药/装备）、变身、召唤 Boss。
    /// </summary>
    public enum ActionType
    {
        /// <summary>添加物品：Value=物品ID，Count=数量（默认1）</summary>
        AddItem,

        /// <summary>批量添加一段连续 ID 的物品：Values=[起始ID, 结束ID]，Count=每个给几个</summary>
        AddItemRange,

        /// <summary>变身：Value=变身 ResID（游戏内置变身表里的 ID，见 ItemData.trans_list）</summary>
        Trans,

        /// <summary>按蓝图路径生成角色/Boss：path=资源路径，Value&gt;0 表示用 GM 方式生成 Boss（Tamer）</summary>
        SpawnActor,

        /// <summary>
        /// 手动错开同屏多条 Boss/精英怪血条：以第 1 条的槽位位置为基准，把第 2/3 条向下逐条错开
        /// （步长 = 第 1 条实际高度 + Value（间距，默认 10））。
        /// 仅作一次性触发、不做持续检测；召唤 Boss（SpawnActor 且 Value&gt;0）后会自动调度本动作。
        /// </summary>
        BossBarOffset,
    }

    /// <summary>单个动作配置（画板条目点击后执行的动作）</summary>
    public class ActionConfig
    {
        public ActionType Type { get; set; }

        /// <summary>动作值（物品ID / 变身ResID / SpawnActor 时 &gt;0 表示按 Boss 生成）</summary>
        public int? Value { get; set; }

        public List<int>? Values { get; set; }

        /// <summary>物品数量（AddItem / AddItemRange，默认1）</summary>
        public int? Count { get; set; }

        /// <summary>资源/蓝图路径（SpawnActor）</summary>
        public string? path { get; set; }

        /// <summary>延迟执行（毫秒）</summary>
        public int? Delay { get; set; }
    }

    /// <summary>画板配置里的连续 ID 区间：Start 起共 Count 个</summary>
    public class PanelIdRange
    {
        public int Start { get; set; }
        public int Count { get; set; } = 1;
    }

    /// <summary>
    /// 画板单个手工条目：显示名 + 数据（物品ID / 变身ID）+ 点击后执行的一组动作。
    /// 未配 name 且配了 id 时，自动用物品表里的名称填充。
    /// </summary>
    public class PanelItemConfig
    {
        public string? name { get; set; }
        public int id { get; set; }
        public string? path { get; set; }
        public List<ActionConfig>? actions { get; set; }
    }

    /// <summary>
    /// 画板一个分类（Tab）配置。
    /// 数据来源两种方式，可同时存在：
    ///   1) Items：手工罗列条目
    ///   2) Source：批量数据源（items / boss / trans），条目的点击动作由 ItemActions 模板生成，
    ///      模板里没写死的 Value / path 会自动用当前条目的数据填充。
    /// </summary>
    public class PanelTabConfig
    {
        /// <summary>Tab 标题</summary>
        public string Name { get; set; } = "";

        /// <summary>游戏内置 Tab 枚举名（EnGMTab，如 MONSTER/TRANS/ROLE）；为空则按序号自动分配</summary>
        public string? Tab { get; set; }

        /// <summary>批量数据来源：items=按物品ID生成 / boss=boss.json / trans=内置变身表；空表示只用 Items</summary>
        public string? Source { get; set; }

        /// <summary>
        /// 可选：本分类单独使用的数据文件（放在 Mod 目录下）。
        /// 不填时用默认文件：boss=boss.json / items=items.json / trans=trans.json。
        /// 想让不同分类用不同列表（比如“丹药”和“材料”分开）就各自指定一个。
        /// </summary>
        public string? DataFile { get; set; }

        /// <summary>Source=items 时的显式 ID 列表</summary>
        public List<int>? Ids { get; set; }

        /// <summary>Source=items 时的 ID 区间</summary>
        public List<PanelIdRange>? Ranges { get; set; }

        /// <summary>批量条目的点击动作模板（Value/path 留空时自动填当前条目数据）</summary>
        public List<ActionConfig>? ItemActions { get; set; }

        /// <summary>手工条目列表</summary>
        public List<PanelItemConfig>? Items { get; set; }
    }
}
