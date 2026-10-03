using System.Collections.Generic;

namespace PanelActionsMod;

/// <summary>
/// 游戏内置变身表：ResID -> 显示名（画板“变身”分类的数据来源）
/// </summary>
public static class ItemData
{
    public static Dictionary<int, string> trans_list = new Dictionary<int, string>
    {
        {19, "小黄龙"},
        {17, "马猴"},
        {24, "巨猿"},
        {12, "广智"},
        {13, "石头人"},
        {14, "寅虎"},
        {15, "双头鼠"},
        {16, "海上僧"},
        {18, "虫"},
        {23, "马哥"},
        {11, "蝉"},
        {10, "变回悟空"},
    };
}
