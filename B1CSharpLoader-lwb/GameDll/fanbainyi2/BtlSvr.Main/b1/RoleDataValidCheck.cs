using System.Collections.Generic;
using System.Linq;
using ArchiveB1;
using ResB1;

namespace b1;

public class RoleDataValidCheck
{
	public static void NotifyArchiveDataVerifyInvalid(string ArchiveName, List<string> errMsgs)
	{
		foreach (string errMsg in errMsgs)
		{
			string logMessage = ArchiveName + " Data Check Error, " + errMsg;
			GSEUtil.IsDebugEnv();
			SysLogUtil.ARCHIVE.LogError(logMessage);
		}
	}

	public static bool CheckRoleMeseumValid(RoleMuseum MuseumData, out List<string> errMsgs)
	{
		errMsgs = new List<string>();
		return GameDBRuntime.CheckMuseumMVListAutoGen(LastCheckValue: true, MuseumData.MvIdList, errMsgs);
	}

	public static bool CheckRoleDataValid(RoleDataCS roleDataCS, out List<string> errMsgs)
	{
		errMsgs = new List<string>();
		bool flag = true;
		if (roleDataCS.Bag != null)
		{
			flag = GameDBRuntime.CheckItemListAutoGen(flag, roleDataCS.Bag.ItemList.Select((RoleItem ItemOne) => ItemOne.ItemId), errMsgs);
			flag = GameDBRuntime.CheckEquipListAutoGen(flag, roleDataCS.Bag.EquipList.Select((RoleEquip RoleEquip) => RoleEquip.EquipId), errMsgs);
			flag = GameDBRuntime.CheckAttrItemListAutoGen(flag, roleDataCS.Bag.AttrList.Select((AttrItem AttrItem) => AttrItem.Id), errMsgs);
			flag = GameDBRuntime.CheckWineListAutoGen(flag, roleDataCS.Bag.WineList.Select((RoleWine RoleWine) => RoleWine.WineId), errMsgs);
			if (roleDataCS.Bag.Info != null)
			{
				flag = GameDBRuntime.CheckEquipListAutoGen(flag, roleDataCS.Bag.Info.ActivatedWeaponIdList, errMsgs);
			}
			flag = GameDBRuntime.CheckSoulSkillListAutoGen(flag, roleDataCS.Bag.SoulSkillList.Select((RoleSoulSkill SoulSkill) => SoulSkill.SoulSkillId), errMsgs);
		}
		if (roleDataCS.Actor != null)
		{
			if (roleDataCS.Actor.Wear != null)
			{
				flag = GameDBRuntime.CheckEquipListAutoGen(flag, roleDataCS.Actor.Wear.EquipList.Select((WearEquip WearEquip) => WearEquip.Id), errMsgs);
				flag = GameDBRuntime.CheckItemListAutoGen(flag, roleDataCS.Actor.Wear.ShortcutsList.Select((ShortcutItem Shortcut) => Shortcut.ItemId), errMsgs);
				flag = GameDBRuntime.CheckSpellListAutoGen(flag, roleDataCS.Actor.Wear.SpellList.Select((SpellItem Spell) => Spell.SpellId), errMsgs);
				flag = GameDBRuntime.CheckWineListAutoGen(flag, new List<int> { roleDataCS.Actor.Wear.WineId }, errMsgs);
				flag = GameDBRuntime.CheckSoulSkillListAutoGen(flag, new List<int> { roleDataCS.Actor.Wear.WearSoulSkill.SoulSkillId }, errMsgs);
				flag = GameDBRuntime.CheckEquipListAutoGen(flag, roleDataCS.Actor.Wear.WearAccessory.Accessorylist.Select((AccessoryProp Accessory) => Accessory.Id), errMsgs);
			}
			if (roleDataCS.Actor.Progress != null)
			{
				flag = GameDBRuntime.CheckSpellListAutoGen(flag, roleDataCS.Actor.Progress.SpellList, errMsgs);
				flag = GameDBRuntime.CheckTalentSListAutoGen(flag, roleDataCS.Actor.Progress.TalenList.Select((TalentOne TalentOne) => TalentOne.Id), errMsgs);
				flag = GameDBRuntime.CheckMeditationPointListAutoGen(flag, roleDataCS.Actor.Progress.MeditationsList.Select((MeditationOne Meditation) => Meditation.Id), errMsgs);
				flag = GameDBRuntime.CheckItemListAutoGen(flag, roleDataCS.Actor.Progress.LegacyList.Select((LegacyAbility Legacy) => Legacy.LegacyId), errMsgs);
				foreach (LegacyAbility legacy in roleDataCS.Actor.Progress.LegacyList)
				{
					flag = GameDBRuntime.CheckTalentSListAutoGen(flag, legacy.TalentList.Select((LegacyTalent Talent) => Talent.TalentId), errMsgs);
				}
				flag = GameDBRuntime.CheckMeditationPointListAutoGen(flag, roleDataCS.Actor.Progress.AwardMeditationList, errMsgs);
				flag = GameDBRuntime.CheckMeditationPointListAutoGen(flag, roleDataCS.Actor.Progress.AwardTalentPointMeditationList, errMsgs);
			}
		}
		if (roleDataCS.Shop != null)
		{
			foreach (ShopOne shop in roleDataCS.Shop.ShopList)
			{
				TBShopRefreshDesc tBShopRefreshDesc = GameDBRuntime.GetTBShopRefreshDesc();
				bool flag2 = false;
				foreach (ShopRefreshDesc item3 in tBShopRefreshDesc.List)
				{
					if (shop.ShopId == item3.ShopId)
					{
						flag2 = true;
					}
				}
				if (!flag2)
				{
					flag = false;
					string item = $"shop id : {shop.ShopId} does not exist in ShopRefreshDesc";
					errMsgs.Add(item);
				}
				flag = GameDBRuntime.CheckShopItemListAutoGen(flag, shop.ItemList.Select((ShopItem Item) => Item.Id), errMsgs);
				flag = GameDBRuntime.CheckShopItemListAutoGen(flag, shop.HideItemList.Select((ShopItem Item) => Item.Id), errMsgs);
			}
			flag = GameDBRuntime.CheckShopItemListAutoGen(flag, roleDataCS.Shop.BuyRecords.Select((ShopBuyRecord Item) => Item.Id), errMsgs);
		}
		if (roleDataCS.Task != null)
		{
			foreach (QuestStageOne quest in roleDataCS.Task.QuestList)
			{
				if (BGW_GameDB.GetTaskStageDesc(quest.Id) == null)
				{
					flag = false;
					string item2 = $"task id : {quest.Id} does not exist in TaskStageDesc";
					errMsgs.Add(item2);
				}
			}
		}
		if (roleDataCS.Collection != null)
		{
			flag = GameDBRuntime.CheckCardListAutoGen(flag, roleDataCS.Collection.MonsterCollectionList.Select((MonsterCollection Card) => Card.Id), errMsgs);
		}
		if (roleDataCS.Interaction != null)
		{
			flag = GameDBRuntime.CheckInteractionFuncListAutoGen(flag, roleDataCS.Interaction.InteractionFuncList, errMsgs);
		}
		if (roleDataCS.Achievement != null && roleDataCS.Achievement.Achievements != null)
		{
			flag = GameDBRuntime.CheckAchievementListAutoGen(flag, roleDataCS.Achievement.Achievements.Select((AchievementOne Achievement) => Achievement.Config.AchievementId), errMsgs);
		}
		if (roleDataCS.Chapter != null)
		{
			flag = GameDBRuntime.CheckChapterListAutoGen(flag, new List<int> { roleDataCS.Chapter.CurChapter }, errMsgs);
			flag = GameDBRuntime.CheckChapterListAutoGen(flag, roleDataCS.Chapter.ChapterList.Select((ChapterData Chapter) => Chapter.Id), errMsgs);
			foreach (ChapterData chapter in roleDataCS.Chapter.ChapterList)
			{
				flag = GameDBRuntime.CheckSurpriseListAutoGen(flag, chapter.SurpriseList, errMsgs);
			}
			flag = GameDBRuntime.CheckItemListAutoGen(flag, roleDataCS.Chapter.StashChapterAwardList.Select((AwardItem Item) => Item.Id), errMsgs);
		}
		if (roleDataCS.Garden != null)
		{
			flag = GameDBRuntime.CheckSeedListAutoGen(flag, roleDataCS.Garden.CropList.Select((Crop Crop) => Crop.SeedId), errMsgs);
			foreach (Crop crop in roleDataCS.Garden.CropList)
			{
				flag = GameDBRuntime.CheckItemListAutoGen(flag, crop.OutputList.Select((CropOutput Output) => Output.OutputConfig.OutputItemId), errMsgs);
			}
		}
		if (BGW_OnlineSubsystem.OnlineSubsystemType == EBGWSubsystemType.PS5 && roleDataCS.Activities != null)
		{
			flag = GameDBRuntime.CheckPS5ActivityListAutoGen(flag, roleDataCS.Activities.ActivityList.Select((PS5Activity Activity) => Activity.Id), errMsgs);
			foreach (PS5Activity activity in roleDataCS.Activities.ActivityList)
			{
				flag = GameDBRuntime.CheckPS5ActivityTaskListAutoGen(flag, activity.TaskIdList, errMsgs);
			}
		}
		return flag;
	}
}
