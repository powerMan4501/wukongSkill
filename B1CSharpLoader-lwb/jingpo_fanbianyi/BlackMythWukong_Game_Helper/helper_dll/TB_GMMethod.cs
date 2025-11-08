using System.Collections.Generic;
using BlackMythWukong_Game_Helper;

public class TB_GMMethod : TB
{
	public List<GMMethod> List { get; set; }

	public TB_GMMethod()
	{
		List = new List<GMMethod>();
		Init();
	}

	public void Init()
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
				Key = "AllAchievements",
				Value = "全成就"
			},
			new Name
			{
				Key = " ClearItem",
				Value = "清理背包Item"
			},
			new Name
			{
				Key = "AllSoulSkill",
				Value = "获得所有精魄战技"
			},
			new Name
			{
				Key = "RefreshAllShop",
				Value = "解锁所有商店"
			},
			new Name
			{
				Key = "GMClearLegacy",
				Value = "清除大圣遗物和大圣天赋"
			},
			new Name
			{
				Key = "ClearRoleBag",
				Value = "角色等级设置为0，清除角色背包 天赋 法术"
			},
			new Name
			{
				Key = "AllArmorToTop",
				Value = "所有防具升到最高级"
			},
			new Name
			{
				Key = "AllCard",
				Value = "全图鉴"
			},
			new Name
			{
				Key = "AllRecipe",
				Value = "获得所有单方"
			},
			new Name
			{
				Key = "AllAttrItem",
				Value = "获得所有属性道具"
			},
			new Name
			{
				Key = "AllSpell",
				Value = "全法术"
			},
			new Name
			{
				Key = "AllWeapon",
				Value = "全武器"
			},
			new Name
			{
				Key = "AllHulu",
				Value = "全葫芦"
			},
			new Name
			{
				Key = "AllSeeds",
				Value = "获取所有种子"
			},
			new Name
			{
				Key = "OnActiveAllRebirthPoint",
				Value = "解锁所有土地庙"
			}
		});
	}
}
