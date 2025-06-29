using System;
using System.Collections.Generic;
using BtlB1;
using GurGsPersistent;

namespace b1;

public class BICCollectionGroupDataOperation
{
	public Dictionary<string, string> CollectionBlackList = new Dictionary<string, string>();

	public Dictionary<int, CollectionGroupData> CollectionGroupMap { get; } = new Dictionary<int, CollectionGroupData>();

	public Dictionary<int, CollectionGroupData> GetCollectionGroupData()
	{
		return CollectionGroupMap;
	}

	public void Init()
	{
		List<FUStCollectionSpawnInfoDesc> allCollectionSpawnInfoDesc = BGW_GameDB.GetAllCollectionSpawnInfoDesc();
		if (allCollectionSpawnInfoDesc == null)
		{
			return;
		}
		foreach (FUStCollectionSpawnInfoDesc item in allCollectionSpawnInfoDesc)
		{
			if (item.TaskId > 0 && !CollectionBlackList.TryGetValue(item.Guid, out var _))
			{
				CollectionBlackList.Add(item.Guid, item.Guid);
			}
		}
	}

	public void RecoverCollectionGroupData(int GroupId, GurGsPersistent.CollectionGroupDataInfo GroupData, BIC_PersistentECSData PersistentECSData)
	{
		CollectionGroupMap[GroupId] = AllocCollectionGroupData(GroupData, GroupId);
		foreach (FUStCollectionSpawnInfoDesc item in BGW_GameDB.GetAllCollectionSpawnInfoDesc())
		{
			if (item.GroupId == GroupId)
			{
				GurGsPersistent.BUC_CollectionData persistentBUC_CollectionData = GetPersistentBUC_CollectionData(item.Guid, GroupId, PersistentECSData);
				if (persistentBUC_CollectionData != null)
				{
					CollectionGroupMap[GroupId].CollectionDataGuidDict[item.Guid] = persistentBUC_CollectionData;
				}
			}
		}
	}

	public void SaveCollectionGroupInfo(int GroupId, string Guid = "")
	{
		CollectionGroupMap.TryGetValue(GroupId, out var value);
		if (value == null)
		{
			value = new CollectionGroupData();
		}
		foreach (KeyValuePair<string, GurGsPersistent.BUC_CollectionData> item in value.CollectionDataGuidDict)
		{
			if (!(item.Key == Guid))
			{
				continue;
			}
			if (value.CollectionGroupDataInfo.FreshTime == 0)
			{
				double num = (DateTime.Now - new DateTime(1970, 1, 1, 0, 0, 0)).TotalSeconds;
				if (num > 2147483647.0)
				{
					num = 2147483647.0;
				}
				if (num < -2147483648.0)
				{
					num = -2147483648.0;
				}
				value.CollectionGroupDataInfo.FreshTime = Convert.ToInt32(num);
			}
			item.Value.BeCollected = true;
			break;
		}
	}

	public void OnReSetGameData()
	{
		CollectionGroupMap.Clear();
	}

	public bool CheckActorIsRandom(string Guid)
	{
		Dictionary<int, CollectionGroupData> collectionGroupData = GetCollectionGroupData();
		foreach (KeyValuePair<int, CollectionGroupData> item in collectionGroupData)
		{
			if (!collectionGroupData.TryGetValue(item.Value.GroupId, out var value))
			{
				continue;
			}
			foreach (KeyValuePair<string, GurGsPersistent.BUC_CollectionData> item2 in value.CollectionDataGuidDict)
			{
				if (item2.Key == Guid)
				{
					return item2.Value.IsRandomed;
				}
			}
		}
		return false;
	}

	public ECollectionInteractType GetCollectiontType(string Guid)
	{
		Dictionary<int, CollectionGroupData> collectionGroupData = GetCollectionGroupData();
		foreach (KeyValuePair<int, CollectionGroupData> item in collectionGroupData)
		{
			if (!collectionGroupData.TryGetValue(item.Value.GroupId, out var value))
			{
				continue;
			}
			foreach (KeyValuePair<string, GurGsPersistent.BUC_CollectionData> item2 in value.CollectionDataGuidDict)
			{
				if (item2.Key == Guid)
				{
					return (ECollectionInteractType)item2.Value.CollectiontType;
				}
			}
		}
		return ECollectionInteractType.Item;
	}

	public ECollectionQualityType CheckCollectionQuality(string Guid)
	{
		Dictionary<int, CollectionGroupData> collectionGroupData = GetCollectionGroupData();
		foreach (KeyValuePair<int, CollectionGroupData> item in collectionGroupData)
		{
			if (!collectionGroupData.TryGetValue(item.Value.GroupId, out var value))
			{
				continue;
			}
			foreach (KeyValuePair<string, GurGsPersistent.BUC_CollectionData> item2 in value.CollectionDataGuidDict)
			{
				if (item2.Key == Guid)
				{
					return (ECollectionQualityType)item2.Value.CollectionQuality;
				}
			}
		}
		return ECollectionQualityType.Normal;
	}

	public bool CheckActorIsBeCollected(string Guid)
	{
		Dictionary<int, CollectionGroupData> collectionGroupData = GetCollectionGroupData();
		foreach (KeyValuePair<int, CollectionGroupData> item in collectionGroupData)
		{
			if (!collectionGroupData.TryGetValue(item.Value.GroupId, out var value))
			{
				continue;
			}
			foreach (KeyValuePair<string, GurGsPersistent.BUC_CollectionData> item2 in value.CollectionDataGuidDict)
			{
				if (item2.Key == Guid)
				{
					return item2.Value.BeCollected;
				}
			}
		}
		return false;
	}

	public void InitSpawnActorState(string CurrentLevelName, BIC_PersistentECSData PersistentECSData)
	{
		GurGsPersistent.BGC_CollectionGroupData bGCCollectionGroupData = PersistentECSData.GetPersistentBGCData().BGCCollectionGroupData;
		if (bGCCollectionGroupData == null)
		{
			bGCCollectionGroupData = new GurGsPersistent.BGC_CollectionGroupData();
			PersistentECSData.GetPersistentBGCData().BGCCollectionGroupData = bGCCollectionGroupData;
		}
		Dictionary<int, CollectionGroupData> collectionGroupData = GetCollectionGroupData();
		FGSSpawnProbabilityGroup fGSSpawnProbabilityGroup = BGU_CollectionActorUtil.InitProbabilityGroupByDesc(CurrentLevelName);
		if (fGSSpawnProbabilityGroup.SpawnProbabilityGroup == null)
		{
			return;
		}
		int levelIdByLevelName = UBGWFunctionLibraryCS.GetLevelIdByLevelName(CurrentLevelName);
		foreach (KeyValuePair<int, FGSSpawnProbabilityConfig> item in fGSSpawnProbabilityGroup.SpawnProbabilityGroup)
		{
			int key = item.Key;
			if (collectionGroupData.TryGetValue(item.Key, out var value))
			{
				if (Convert.ToInt64((DateTime.Now - new DateTime(1970, 1, 1, 0, 0, 0)).TotalSeconds) - value.CollectionGroupDataInfo.FreshTime <= item.Value.FreshDelta || value.CollectionGroupDataInfo.FreshTime <= 0)
				{
					continue;
				}
				_ = DebugConfig.DebugCollection;
				FUStCollectionSpawnGroupDesc collectionSpawnGroupDescByID = BGW_GameDB.GetCollectionSpawnGroupDescByID(key);
				if (collectionSpawnGroupDescByID != null)
				{
					CollectionGroupMap.TryGetValue(key, out var value2);
					if (collectionSpawnGroupDescByID.FreshNumMax == 0 || collectionSpawnGroupDescByID.FreshNumMax > value2.CollectionGroupDataInfo.FreshCount)
					{
						ReSetCollectionGroupInfo(item.Key, RreshSpawnCollection(item.Value, PersistentECSData, item.Key, levelIdByLevelName, value2.CollectionGroupDataInfo.FreshCount));
					}
				}
			}
			else
			{
				CollectionGroupData value3 = RreshSpawnCollection(item.Value, PersistentECSData, item.Key, levelIdByLevelName, 1);
				collectionGroupData.Add(item.Key, value3);
			}
		}
		if (!DebugConfig.DebugCollection)
		{
			return;
		}
		Dictionary<int, Dictionary<string, GurGsPersistent.BUC_CollectionData>> dictionary = new Dictionary<int, Dictionary<string, GurGsPersistent.BUC_CollectionData>>();
		foreach (KeyValuePair<int, CollectionGroupData> item2 in collectionGroupData)
		{
			foreach (KeyValuePair<string, GurGsPersistent.BUC_CollectionData> item3 in item2.Value.CollectionDataGuidDict)
			{
				if (!dictionary.ContainsKey(item3.Value.GroupId))
				{
					Dictionary<string, GurGsPersistent.BUC_CollectionData> dictionary2 = new Dictionary<string, GurGsPersistent.BUC_CollectionData>();
					dictionary2.Add(item3.Key, item3.Value);
					dictionary.Add(item3.Value.GroupId, dictionary2);
				}
				else
				{
					dictionary[item3.Value.GroupId].Add(item3.Key, item3.Value);
				}
			}
		}
		foreach (KeyValuePair<int, Dictionary<string, GurGsPersistent.BUC_CollectionData>> item4 in dictionary)
		{
			foreach (KeyValuePair<string, GurGsPersistent.BUC_CollectionData> item5 in item4.Value)
			{
				_ = item5;
			}
		}
	}

	public GurGsPersistent.BUC_CollectionData GetOrAllocPersistentBUC_CollectionData(string Guid, int GroupId, BIC_PersistentECSData PersistentECSData)
	{
		PersistentECSData.FindOrAllocBUCDataByGuid(Guid, out var Ret);
		if (Ret.BUCCollectionData == null)
		{
			Ret.BUCCollectionData = new GurGsPersistent.BUC_CollectionData();
		}
		Ret.BUCCollectionData.GroupId = GroupId;
		return Ret.BUCCollectionData;
	}

	public GurGsPersistent.BUC_CollectionData GetPersistentBUC_CollectionData(string Guid, int GroupId, BIC_PersistentECSData PersistentECSData)
	{
		PersistentECSData.FindOrAllocBUCDataByGuid(Guid, out var Ret);
		return Ret.BUCCollectionData;
	}

	public CollectionGroupData AllocCollectionGroupData(GurGsPersistent.CollectionGroupDataInfo CollectionGroupDataInfo, int GroupId)
	{
		return new CollectionGroupData
		{
			GroupId = GroupId,
			CollectionGroupDataInfo = CollectionGroupDataInfo
		};
	}

	public CollectionGroupData RreshSpawnCollection(FGSSpawnProbabilityConfig ProbabilityConfig, BIC_PersistentECSData PersistentECSData, int GroupId, int LevelId, int FreshCount)
	{
		bool debugCollection = DebugConfig.DebugCollection;
		GurGsPersistent.BGC_CollectionGroupData bGCCollectionGroupData = PersistentECSData.GetPersistentBGCData().BGCCollectionGroupData;
		GurGsPersistent.CollectionGroupDataInfo collectionGroupDataInfo = null;
		foreach (DictDeltaMsgInt_CollectionGroupDataInfo item in bGCCollectionGroupData.CollectionGroupDataInfo)
		{
			if (item.Key == GroupId)
			{
				collectionGroupDataInfo = item.Value;
				break;
			}
		}
		if (collectionGroupDataInfo == null)
		{
			collectionGroupDataInfo = new GurGsPersistent.CollectionGroupDataInfo();
			bGCCollectionGroupData.CollectionGroupDataInfo.Add(new DictDeltaMsgInt_CollectionGroupDataInfo
			{
				Key = GroupId,
				Value = collectionGroupDataInfo
			});
		}
		CollectionGroupData collectionGroupData = AllocCollectionGroupData(collectionGroupDataInfo, GroupId);
		collectionGroupData.CollectionGroupDataInfo.FreshTime = 0;
		collectionGroupData.CollectionGroupDataInfo.FreshCount = FreshCount;
		foreach (KeyValuePair<int, string> item2 in ProbabilityConfig.ActorDict)
		{
			GurGsPersistent.BUC_CollectionData orAllocPersistentBUC_CollectionData = GetOrAllocPersistentBUC_CollectionData(item2.Value, GroupId, PersistentECSData);
			collectionGroupData.CollectionDataGuidDict[item2.Value] = orAllocPersistentBUC_CollectionData;
		}
		if (collectionGroupData != null)
		{
			foreach (KeyValuePair<string, GurGsPersistent.BUC_CollectionData> item3 in collectionGroupData.CollectionDataGuidDict)
			{
				item3.Value.IsRandomed = false;
				item3.Value.BeCollected = false;
				item3.Value.NeedReBirthMonster = true;
				item3.Value.CollectiontType = 0;
				item3.Value.CollectionQuality = 0;
				item3.Value.GroupId = GroupId;
			}
		}
		int count = ProbabilityConfig.ActorDict.Count;
		int num = 0;
		if (count > ProbabilityConfig.MinNum)
		{
			int randomNumberInt = UB1Util.GetRandomNumberInt(ProbabilityConfig.MinNum, ProbabilityConfig.MaxNum);
			int num2 = ProbabilityConfig.ActorDict.Count;
			foreach (KeyValuePair<int, string> item4 in ProbabilityConfig.ActorDict)
			{
				bool num3 = UB1Util.GetRandomNumberInt(0, 1) > 0;
				string value = item4.Value;
				num2--;
				if ((num3 || num + num2 == ProbabilityConfig.MinNum) && num < randomNumberInt)
				{
					collectionGroupData.CollectionDataGuidDict[value].IsRandomed = true;
					num++;
				}
			}
		}
		else
		{
			foreach (KeyValuePair<string, GurGsPersistent.BUC_CollectionData> item5 in collectionGroupData.CollectionDataGuidDict)
			{
				item5.Value.IsRandomed = true;
				num++;
			}
		}
		int num4 = 0;
		int num5 = 0;
		foreach (KeyValuePair<string, GurGsPersistent.BUC_CollectionData> item6 in collectionGroupData.CollectionDataGuidDict)
		{
			if (item6.Value.IsRandomed)
			{
				if (UB1Util.GetRandomNumberInt(0, 9999) < ProbabilityConfig.PlusRate)
				{
					num4++;
					item6.Value.CollectionQuality = 1;
				}
				else if (UB1Util.GetRandomNumberInt(0, 9999) < ProbabilityConfig.ChiefRate)
				{
					num5++;
					item6.Value.CollectionQuality = 2;
				}
			}
		}
		foreach (KeyValuePair<string, GurGsPersistent.BUC_CollectionData> item7 in collectionGroupData.CollectionDataGuidDict)
		{
			if (!item7.Value.IsRandomed)
			{
				continue;
			}
			FUStCollectionSpawnGroupDesc collectionSpawnGroupDescByID = BGW_GameDB.GetCollectionSpawnGroupDescByID(GroupId);
			FUStCollectionSpawnInfoDesc collectionSpawnInfoDesc = BGW_GameDB.GetCollectionSpawnInfoDesc(item7.Key);
			if (collectionSpawnGroupDescByID == null || collectionSpawnInfoDesc == null)
			{
				continue;
			}
			int iD = ((collectionSpawnInfoDesc.EventId > 0) ? collectionSpawnInfoDesc.EventId : collectionSpawnGroupDescByID.EventId);
			if (item7.Value.CollectionQuality == 1)
			{
				iD = ((collectionSpawnInfoDesc.PlusEventId > 0) ? collectionSpawnInfoDesc.PlusEventId : collectionSpawnGroupDescByID.PlusEventId);
			}
			if (item7.Value.CollectionQuality == 2)
			{
				iD = ((collectionSpawnInfoDesc.ChiefEventId > 0) ? collectionSpawnInfoDesc.ChiefEventId : collectionSpawnGroupDescByID.ChiefEventId);
			}
			FUStCollectionEventProbabilityDesc collectionEventProbabilityDescByID = BGW_GameDB.GetCollectionEventProbabilityDescByID(iD);
			if (collectionEventProbabilityDescByID == null)
			{
				continue;
			}
			int num6 = 10000;
			int randomNumberInt2 = UB1Util.GetRandomNumberInt(0, num6 - 1);
			if (randomNumberInt2 < num6 - collectionEventProbabilityDescByID.MonsterRate - collectionEventProbabilityDescByID.PlusMonsterRate - collectionEventProbabilityDescByID.ChiefRate)
			{
				item7.Value.CollectiontType = 0;
			}
			else if (randomNumberInt2 < num6 - collectionEventProbabilityDescByID.PlusMonsterRate - collectionEventProbabilityDescByID.ChiefRate)
			{
				item7.Value.CollectiontType = 1;
			}
			else if (randomNumberInt2 < num6 - collectionEventProbabilityDescByID.ChiefRate)
			{
				item7.Value.CollectiontType = 2;
			}
			else
			{
				item7.Value.CollectiontType = 3;
			}
			if (item7.Value.CollectiontType != 0 && collectionGroupData.CollectionGroupDataInfo.FreshTime == 0)
			{
				double num7 = (DateTime.Now - new DateTime(1970, 1, 1, 0, 0, 0)).TotalSeconds;
				if (num7 > 2147483647.0)
				{
					num7 = 2147483647.0;
				}
				if (num7 < -2147483648.0)
				{
					num7 = -2147483648.0;
				}
				collectionGroupData.CollectionGroupDataInfo.FreshTime = Convert.ToInt32(num7);
			}
		}
		return collectionGroupData;
	}

	public void ReSetCollectionGroupInfo(int GroupId, CollectionGroupData NewGroupData)
	{
		CollectionGroupMap.TryGetValue(GroupId, out var value);
		if (value != null)
		{
			CollectionGroupMap.Remove(GroupId);
			NewGroupData.CollectionGroupDataInfo.FreshCount = value.CollectionGroupDataInfo.FreshCount + 1;
			CollectionGroupMap.Add(GroupId, NewGroupData);
		}
	}

	public bool CheckInBlackList(string Guid)
	{
		if (CollectionBlackList != null && CollectionBlackList.TryGetValue(Guid, out var _))
		{
			return true;
		}
		return false;
	}

	public bool ReMoveFormBlackList(string Guid)
	{
		if (CollectionBlackList != null && CollectionBlackList.TryGetValue(Guid, out var _))
		{
			CollectionBlackList.Remove(Guid);
			return true;
		}
		return false;
	}
}
