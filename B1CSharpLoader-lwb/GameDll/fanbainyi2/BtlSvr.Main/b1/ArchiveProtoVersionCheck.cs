using System;
using System.Collections.Generic;
using System.Linq;
using ArchiveB1;
using b1.AutoQA;
using CommB1;
using ResB1;

namespace b1;

public class ArchiveProtoVersionCheck
{
	private static bool WineNotExist(int wineId, RoleBag roleBag)
	{
		if (roleBag.WineList != null)
		{
			foreach (RoleWine wine in roleBag.WineList)
			{
				if (wine.WineId == wineId)
				{
					return false;
				}
			}
		}
		return true;
	}

	private static void FixCe02Wine(RoleDataCS roleDataCS)
	{
	}

	private static void FixCe01Hulu(RoleDataCS roleDataCS)
	{
	}

	private static void FixWineUid(RoleDataCS roleDataCS)
	{
		RoleBag bag = roleDataCS.Bag;
		foreach (RoleWine wine in bag.WineList)
		{
			if (wine.Uid == 0L)
			{
				if (bag.Info == null)
				{
					bag.Info = new RoleBagInfo();
				}
				wine.Uid = ++bag.Info.WineUidSeq;
			}
		}
	}

	private static void FixCe06ShopItemListSort(RoleDataCS roleDataCS)
	{
		RoleShop shop = roleDataCS.Shop;
		foreach (ShopOne shop2 in shop.ShopList)
		{
			IOrderedEnumerable<ShopItem> values = from shopItem in shop2.ItemList.ToList()
				orderby shopItem.Id
				select shopItem;
			shop2.ItemList.Clear();
			shop2.ItemList.AddRange(values);
		}
		foreach (ShopOne shop3 in shop.ShopList)
		{
			IOrderedEnumerable<ShopItem> values2 = from shopItem in shop3.HideItemList.ToList()
				orderby shopItem.Id
				select shopItem;
			shop3.HideItemList.Clear();
			shop3.HideItemList.AddRange(values2);
		}
	}

	private static bool IsArchiveNeedFix(ProtocolTag checkVersionTag, ProtocolTag curProtocolTag)
	{
		if (curProtocolTag <= checkVersionTag)
		{
			return true;
		}
		return false;
	}

	private static void CheckFixRoleData(ProtocolTag protocolTag, RoleDataCS roleDataCS)
	{
		if (IsArchiveNeedFix(ProtocolTag.Ce01FixHuluTag, protocolTag))
		{
			FixCe01Hulu(roleDataCS);
		}
		if (IsArchiveNeedFix(ProtocolTag.Ce02FixWineTag, protocolTag))
		{
			FixCe02Wine(roleDataCS);
		}
		if (IsArchiveNeedFix(ProtocolTag.CollectionRestructureTag, protocolTag))
		{
			FixCollectionData(roleDataCS);
		}
		if (IsArchiveNeedFix(ProtocolTag.WineAddUidTag, protocolTag))
		{
			FixWineUid(roleDataCS);
		}
		if (IsArchiveNeedFix(ProtocolTag.Ce06FixShopItemListSort, protocolTag))
		{
			try
			{
				FixCe06ShopItemListSort(roleDataCS);
			}
			catch (Exception ex)
			{
				GSEUtil.Ensure(Condition: false, "Fix Ce06 Shop Item List Sort Fail:" + ex.Message);
			}
		}
	}

	private static void FixTangLangData(FUStBEDArchivesData ArchivesData)
	{
		IList<DeadUnitData> list = null;
		try
		{
			int mapId = ArchivesData.PersistentECSData.BPCData.BPCPlayerRoleData.MapId;
			foreach (LevelArchiveBaseData levelBaseDatum in ArchivesData.LevelArchiveData.LevelBaseData)
			{
				if (levelBaseDatum.MapId == mapId)
				{
					list = levelBaseDatum.DeadUnitData;
				}
			}
		}
		catch (Exception)
		{
		}
		foreach (QuestStageOne quest in ArchivesData.RoleData.RoleCs.Task.QuestList)
		{
			if (quest.Id == 9810006 && quest.Stage == QuestStage.Finished)
			{
				return;
			}
		}
		string text = "UGuid.BYS.Xiniu";
		bool flag = false;
		if (list != null)
		{
			foreach (DeadUnitData item in list)
			{
				if (item.Uid == text)
				{
					flag = true;
					break;
				}
			}
		}
		string text2 = "UGuid.BYS.Xuelu";
		bool flag2 = false;
		if (list != null)
		{
			foreach (DeadUnitData item2 in list)
			{
				if (item2.Uid == text2)
				{
					flag2 = true;
					break;
				}
			}
		}
		bool flag3 = false;
		bool flag4 = false;
		bool flag5 = false;
		bool flag6 = false;
		if (ArchivesData.NeverPlaySequences != null)
		{
			foreach (int neverPlaySequence in ArchivesData.NeverPlaySequences)
			{
				if (neverPlaySequence == 90005015)
				{
					flag3 = true;
				}
				if (neverPlaySequence == 90005016)
				{
					flag4 = true;
				}
				if (neverPlaySequence == 90005017)
				{
					flag5 = true;
				}
				if (neverPlaySequence == 90005018)
				{
					flag6 = true;
				}
			}
		}
		LevelArchiveQuestData levelArchiveQuestData = null;
		if (ArchivesData.TaskArchiveData.TaskGraphDataInfoList != null)
		{
			foreach (TaskGraphDataInfo taskGraphDataInfo in ArchivesData.TaskArchiveData.TaskGraphDataInfoList)
			{
				if (taskGraphDataInfo.TaskLineId == 9810)
				{
					levelArchiveQuestData = taskGraphDataInfo.TaskGraphData;
				}
			}
		}
		if (levelArchiveQuestData == null)
		{
			return;
		}
		string text3 = "7f5a93bc-e5e4-4594-abfe-641843066004";
		string text4 = "a7ffb7a2-54a7-439b-a945-7470aa9bd84c";
		string text5 = "e478515d-d5c4-420a-83bd-1d78c6dd86a4";
		string text6 = "a7d0e4f2-e522-4bcd-8557-8a0bf6c9ed4a";
		string text7 = "96e19ff0-b22f-4fa8-80ad-b0c488ee7775";
		string text8 = "e3fed482-4ea6-4e93-aeef-df1af266a981";
		string text9 = "e2fb7e6b-20a3-41f4-a9d6-17c4c5ea4dd0";
		string text10 = "c89fe6c1-5d17-4631-a896-dfc45650abd6";
		string text11 = "51268d86-430d-475d-8078-570a60a12bd7";
		string text12 = "a7c784f0-1727-4749-aafe-b6cc34ea1eb3";
		string text13 = "df25ea91-f0d3-4fbf-9f77-19f4c3c9bc25";
		string text14 = "ce0a2840-db6f-4e53-b34c-107cf1ca44c1";
		string text15 = "4b2a016c-4563-4a1e-b08b-5bbcd654f1ce";
		string text16 = "3ba66434-f22d-43ad-a459-991e04ce4613";
		string text17 = "41576b01-477c-40f1-a0c5-a67133df86a5";
		string text18 = "5babda63-8223-4829-b877-bee2cb043f25";
		string text19 = "4cc3368a-721f-45c2-ae68-61fab7d14fd8";
		string text20 = "ac5aa6cd-02ce-4b1d-803f-66090da55685";
		string text21 = "6d11af4e-f894-43ba-ac7c-7cb361190dda";
		string text22 = "c0e4a082-a859-4443-a72d-676f72921adf";
		string text23 = "56aa50e1-9f65-448a-889a-9a86c3c630fc";
		string text24 = "d1a0f1fc-a658-43b2-b9fc-8fec60261017";
		string text25 = "3669f06b-f56b-4722-88d2-b2e0bb740ecc";
		string text26 = "6846309b-c544-460d-b1bb-94500a581aec";
		string text27 = "8c2a48cb-0954-40af-884c-ee4f018dc9e7";
		LevelArchiveQuestNodeData levelArchiveQuestNodeData = null;
		LevelArchiveQuestNodeData levelArchiveQuestNodeData2 = null;
		LevelArchiveQuestNodeData levelArchiveQuestNodeData3 = null;
		LevelArchiveQuestNodeData levelArchiveQuestNodeData4 = null;
		LevelArchiveQuestNodeData levelArchiveQuestNodeData5 = null;
		LevelArchiveQuestNodeData levelArchiveQuestNodeData6 = null;
		LevelArchiveQuestNodeData levelArchiveQuestNodeData7 = null;
		LevelArchiveQuestNodeData levelArchiveQuestNodeData8 = null;
		LevelArchiveQuestNodeData levelArchiveQuestNodeData9 = null;
		LevelArchiveQuestNodeData levelArchiveQuestNodeData10 = null;
		LevelArchiveQuestNodeData levelArchiveQuestNodeData11 = null;
		LevelArchiveQuestNodeData levelArchiveQuestNodeData12 = null;
		LevelArchiveQuestNodeData levelArchiveQuestNodeData13 = null;
		LevelArchiveQuestNodeData levelArchiveQuestNodeData14 = null;
		LevelArchiveQuestNodeData levelArchiveQuestNodeData15 = null;
		LevelArchiveQuestNodeData levelArchiveQuestNodeData16 = null;
		foreach (LevelArchiveQuestNodeData node in levelArchiveQuestData.Nodes)
		{
			if (node.UniqueId == text3)
			{
				levelArchiveQuestNodeData = node;
			}
			else if (node.UniqueId == text4 || node.UniqueId == text7)
			{
				node.UniqueId = text4;
				levelArchiveQuestNodeData2 = node;
			}
			else if (node.UniqueId == text5 || node.UniqueId == text8)
			{
				node.UniqueId = text5;
				levelArchiveQuestNodeData3 = node;
			}
			else if (node.UniqueId == text6 || node.UniqueId == text9)
			{
				node.UniqueId = text6;
				levelArchiveQuestNodeData4 = node;
			}
			if (node.UniqueId == text10)
			{
				levelArchiveQuestNodeData5 = node;
			}
			else if (node.UniqueId == text11 || node.UniqueId == text14)
			{
				node.UniqueId = text11;
				levelArchiveQuestNodeData6 = node;
			}
			else if (node.UniqueId == text12 || node.UniqueId == text15)
			{
				node.UniqueId = text12;
				levelArchiveQuestNodeData7 = node;
			}
			else if (node.UniqueId == text13 || node.UniqueId == text16)
			{
				node.UniqueId = text13;
				levelArchiveQuestNodeData8 = node;
			}
			if (node.UniqueId == text17)
			{
				levelArchiveQuestNodeData9 = node;
			}
			else if (node.UniqueId == text18 || node.UniqueId == text21)
			{
				node.UniqueId = text18;
				levelArchiveQuestNodeData10 = node;
			}
			else if (node.UniqueId == text19 || node.UniqueId == text22)
			{
				node.UniqueId = text19;
				levelArchiveQuestNodeData11 = node;
			}
			else if (node.UniqueId == text20 || node.UniqueId == text23)
			{
				node.UniqueId = text20;
				levelArchiveQuestNodeData12 = node;
			}
			if (node.UniqueId == text24)
			{
				levelArchiveQuestNodeData13 = node;
			}
			else if (node.UniqueId == text25)
			{
				levelArchiveQuestNodeData14 = node;
			}
			else if (node.UniqueId == text26)
			{
				levelArchiveQuestNodeData15 = node;
			}
			else if (node.UniqueId == text27)
			{
				levelArchiveQuestNodeData16 = node;
			}
		}
		if (flag)
		{
			levelArchiveQuestNodeData.ActivationState = ActivationState.WasActive;
			levelArchiveQuestNodeData.ObserveActorGuid.Clear();
			levelArchiveQuestNodeData2.ActivationState = ActivationState.WasActive;
			levelArchiveQuestNodeData2.ObserveActorGuid.Clear();
			levelArchiveQuestNodeData3.ActivationState = ActivationState.WasActive;
			levelArchiveQuestNodeData3.ObserveActorGuid.Clear();
			levelArchiveQuestNodeData4.ActivationState = ActivationState.WasActive;
			levelArchiveQuestNodeData4.ObserveActorGuid.Clear();
			QuestNodeInstance_LogicalAnd.AddInputPin2CustomData(levelArchiveQuestNodeData9, "0");
			levelArchiveQuestNodeData9.ActivationState = ActivationState.Active;
			QuestNodeInstance_LogicalAnd.AddInputPin2CustomData(levelArchiveQuestNodeData10, "0");
			levelArchiveQuestNodeData10.ActivationState = ActivationState.Active;
			QuestNodeInstance_LogicalAnd.AddInputPin2CustomData(levelArchiveQuestNodeData11, "0");
			levelArchiveQuestNodeData11.ActivationState = ActivationState.Active;
			QuestNodeInstance_LogicalAnd.AddInputPin2CustomData(levelArchiveQuestNodeData12, "0");
			levelArchiveQuestNodeData12.ActivationState = ActivationState.Active;
		}
		else
		{
			levelArchiveQuestNodeData.ActivationState = ActivationState.Active;
			ListExtensions.AddUnique(levelArchiveQuestNodeData.ObserveActorGuid, text);
			levelArchiveQuestNodeData2.ActivationState = ActivationState.Active;
			ListExtensions.AddUnique(levelArchiveQuestNodeData2.ObserveActorGuid, text);
			levelArchiveQuestNodeData3.ActivationState = ActivationState.Active;
			ListExtensions.AddUnique(levelArchiveQuestNodeData3.ObserveActorGuid, text);
			levelArchiveQuestNodeData4.ActivationState = ActivationState.Active;
			ListExtensions.AddUnique(levelArchiveQuestNodeData4.ObserveActorGuid, text);
		}
		if (flag2)
		{
			levelArchiveQuestNodeData5.ActivationState = ActivationState.WasActive;
			levelArchiveQuestNodeData5.ObserveActorGuid.Clear();
			levelArchiveQuestNodeData6.ActivationState = ActivationState.WasActive;
			levelArchiveQuestNodeData6.ObserveActorGuid.Clear();
			levelArchiveQuestNodeData7.ActivationState = ActivationState.WasActive;
			levelArchiveQuestNodeData7.ObserveActorGuid.Clear();
			levelArchiveQuestNodeData8.ActivationState = ActivationState.WasActive;
			levelArchiveQuestNodeData8.ObserveActorGuid.Clear();
			QuestNodeInstance_LogicalAnd.AddInputPin2CustomData(levelArchiveQuestNodeData9, "1");
			levelArchiveQuestNodeData9.ActivationState = ActivationState.Active;
			QuestNodeInstance_LogicalAnd.AddInputPin2CustomData(levelArchiveQuestNodeData10, "1");
			levelArchiveQuestNodeData10.ActivationState = ActivationState.Active;
			QuestNodeInstance_LogicalAnd.AddInputPin2CustomData(levelArchiveQuestNodeData11, "1");
			levelArchiveQuestNodeData11.ActivationState = ActivationState.Active;
			QuestNodeInstance_LogicalAnd.AddInputPin2CustomData(levelArchiveQuestNodeData12, "1");
			levelArchiveQuestNodeData12.ActivationState = ActivationState.Active;
		}
		else
		{
			levelArchiveQuestNodeData5.ActivationState = ActivationState.Active;
			ListExtensions.AddUnique(levelArchiveQuestNodeData5.ObserveActorGuid, text2);
			levelArchiveQuestNodeData6.ActivationState = ActivationState.Active;
			ListExtensions.AddUnique(levelArchiveQuestNodeData6.ObserveActorGuid, text2);
			levelArchiveQuestNodeData7.ActivationState = ActivationState.Active;
			ListExtensions.AddUnique(levelArchiveQuestNodeData7.ObserveActorGuid, text2);
			levelArchiveQuestNodeData8.ActivationState = ActivationState.Active;
			ListExtensions.AddUnique(levelArchiveQuestNodeData8.ObserveActorGuid, text2);
		}
		if (flag3)
		{
			levelArchiveQuestNodeData13.ActivationState = ActivationState.WasActive;
			QuestNodeInstance_LogicalAnd.AddInputPin2CustomData(levelArchiveQuestNodeData9, "2");
			levelArchiveQuestNodeData9.ActivationState = ActivationState.Active;
		}
		else
		{
			levelArchiveQuestNodeData13.ActivationState = ActivationState.Active;
		}
		if (flag4)
		{
			levelArchiveQuestNodeData14.ActivationState = ActivationState.WasActive;
			QuestNodeInstance_LogicalAnd.AddInputPin2CustomData(levelArchiveQuestNodeData10, "2");
			levelArchiveQuestNodeData10.ActivationState = ActivationState.Active;
		}
		else
		{
			levelArchiveQuestNodeData14.ActivationState = ActivationState.Active;
		}
		if (flag5)
		{
			levelArchiveQuestNodeData15.ActivationState = ActivationState.WasActive;
			QuestNodeInstance_LogicalAnd.AddInputPin2CustomData(levelArchiveQuestNodeData11, "2");
			levelArchiveQuestNodeData11.ActivationState = ActivationState.Active;
		}
		else
		{
			levelArchiveQuestNodeData15.ActivationState = ActivationState.Active;
		}
		if (flag6)
		{
			levelArchiveQuestNodeData16.ActivationState = ActivationState.WasActive;
			QuestNodeInstance_LogicalAnd.AddInputPin2CustomData(levelArchiveQuestNodeData12, "2");
			levelArchiveQuestNodeData12.ActivationState = ActivationState.Active;
		}
		else
		{
			levelArchiveQuestNodeData16.ActivationState = ActivationState.Active;
		}
	}

	private static void CheckFixTaskGraphData(ProtocolTag protocolTag, FUStBEDArchivesData ArchivesData)
	{
		if (IsArchiveNeedFix(ProtocolTag.Ce05FixTanglangTag, protocolTag))
		{
			try
			{
				FixTangLangData(ArchivesData);
			}
			catch (Exception)
			{
			}
		}
	}

	public static bool CheckFixSnapShotData(ProtocolTag protocolTag, ArchiveSnapshootOne archiveSnapshootOne)
	{
		if (protocolTag >= ProtocolTag.LatestVersionTag)
		{
			return false;
		}
		CheckFixRoleData(protocolTag, archiveSnapshootOne.RoleData);
		return true;
	}

	public static bool CheckFixArchiveData(ProtocolTag protocolTag, FUStBEDArchivesData GameArchivesData)
	{
		if (protocolTag >= ProtocolTag.LatestVersionTag)
		{
			return false;
		}
		CheckFixRoleData(protocolTag, GameArchivesData.RoleData.RoleCs);
		CheckFixTaskGraphData(protocolTag, GameArchivesData);
		return true;
	}

	public static bool FixCollectionData(RoleDataCS roleDataCS)
	{
		return false;
	}
}
