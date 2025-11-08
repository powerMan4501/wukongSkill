using System.Collections.Generic;

namespace BlackMythWukong_Game_Helper;

internal class Class1
{
	private void Init()
	{
		GlobalObjectMgr.Get<NameCN>().Add(new List<Name>
		{
			new Name
			{
				Key = "AddItem",
				Value = "添加物品"
			},
			new Name
			{
				Key = "AllTaskItem",
				Value = "获取所有任务道具"
			},
			new Name
			{
				Key = "AddExp",
				Value = "获取经验"
			},
			new Name
			{
				Key = "AddSpell",
				Value = "获取法术"
			},
			new Name
			{
				Key = "AddTalent",
				Value = "获取天赋"
			},
			new Name
			{
				Key = "CostItem",
				Value = "消耗道具"
			},
			new Name
			{
				Key = "AllTalent",
				Value = "全天赋"
			},
			new Name
			{
				Key = "AllItem",
				Value = "全道具(只会获得材料和消耗物，不包括酒)"
			},
			new Name
			{
				Key = "AllBossRush",
				Value = "解锁所有BossRush"
			},
			new Name
			{
				Key = "AllWine",
				Value = "所有酒"
			},
			new Name
			{
				Key = "AllEquip",
				Value = "全装备"
			},
			new Name
			{
				Key = "AllLegacy",
				Value = "获取大圣所有根器"
			},
			new Name
			{
				Key = "",
				Value = ""
			},
			new Name
			{
				Key = "OnActiveAllRebirthPoint",
				Value = "解锁所有土地庙"
			},
			new Name
			{
				Key = "",
				Value = ""
			}
		});
	}
}
