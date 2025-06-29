using System.Collections.Generic;
using System.Linq;
using ArchiveB1;
using b1.ECS;
using BtlShare;
using UnrealEngine.Engine;

namespace b1;

public class BIC_GlobalActorData : IBIC_GlobalActorData
{
	public Dictionary<string, BUC_ActorInitData> ActorInitDataDict { get; } = new Dictionary<string, BUC_ActorInitData>();

	public Dictionary<string, bool> ActorAliveState { get; } = new Dictionary<string, bool>();

	public HashSet<string> SpawnActors { get; } = new HashSet<string>();

	public Dictionary<string, EBGUResetType> ActorResetType { get; } = new Dictionary<string, EBGUResetType>();

	public Dictionary<string, List<AActor>> ActorGuid2Entity { get; } = new Dictionary<string, List<AActor>>();

	public Dictionary<int, List<AActor>> ActorResID2Entity { get; } = new Dictionary<int, List<AActor>>();

	public Dictionary<string, EBGUResetType> ActorResetTypeOverride { get; } = new Dictionary<string, EBGUResetType>();

	public Dictionary<string, EBGUResetType> GroupResetTypeOverride { get; } = new Dictionary<string, EBGUResetType>();

	public Dictionary<string, HashSet<string>> StreamingLevelActors { get; } = new Dictionary<string, HashSet<string>>();

	public Dictionary<string, Dictionary<int, int>> ActorCastSkillCount { get; } = new Dictionary<string, Dictionary<int, int>>();

	public HashSet<string> InteractorSet { get; } = new HashSet<string>();

	public List<string> GetActorDataKeys()
	{
		return ActorInitDataDict.Keys.ToList();
	}

	public GSInitDataModuleBase GetActorInitData(string UnitGuid, EInitDataModuleType Type)
	{
		if (!ActorInitDataDict.ContainsKey(UnitGuid))
		{
			return null;
		}
		return ActorInitDataDict[UnitGuid].GetInitDataModule(Type);
	}

	public bool GetActorOverrideResetType(string UnitGuid, out EBGUResetType ResetType)
	{
		return ActorResetTypeOverride.TryGetValue(UnitGuid, out ResetType);
	}

	public bool GetGroupOverrideResetType(string GroupGuid, out EBGUResetType ResetType)
	{
		return GroupResetTypeOverride.TryGetValue(GroupGuid, out ResetType);
	}

	public bool GetActorResetType(string UnitGuid, out EBGUResetType ResetType)
	{
		ResetType = EBGUResetType.None;
		if (ActorResetTypeOverride.TryGetValue(UnitGuid, out ResetType))
		{
			return true;
		}
		if (GetActorEntity(UnitGuid, out var Entity))
		{
			IBUC_GuidData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_GuidData, BUC_GuidData>(ECSExtension.ToActor(Entity));
			if (unPersistentReadOnlyData != null && GroupResetTypeOverride.TryGetValue(unPersistentReadOnlyData.UnitFixedGuidForGroup.ToString(), out ResetType))
			{
				return true;
			}
		}
		if (ActorResetType.TryGetValue(UnitGuid, out ResetType))
		{
			return true;
		}
		return false;
	}

	public bool GetActorEntity(string UnitGuid, out Entity Entity)
	{
		Entity = Entity.Null;
		if (string.IsNullOrEmpty(UnitGuid))
		{
			return false;
		}
		if (ActorGuid2Entity.TryGetValue(UnitGuid, out var value))
		{
			int count = value.Count;
			if (count > 0)
			{
				for (int num = count - 1; num >= 0; num--)
				{
					Entity = ECSExtension.ToEntity(value[num]);
					if (Entity != Entity.Null)
					{
						return true;
					}
				}
			}
		}
		return false;
	}

	public bool GetActorsByResID(int UnitResID, out List<AActor> OutActors)
	{
		return ActorResID2Entity.TryGetValue(UnitResID, out OutActors);
	}

	public bool IsActorInitDataInitialized(string UnitGuid)
	{
		if (!ActorInitDataDict.ContainsKey(UnitGuid))
		{
			return false;
		}
		return ActorInitDataDict[UnitGuid].HasInitialized;
	}

	public List<DeadUnitData> GetDeadUnitsDataToArchive()
	{
		List<DeadUnitData> list = new List<DeadUnitData>();
		foreach (KeyValuePair<string, bool> item2 in ActorAliveState)
		{
			if (!item2.Value)
			{
				GetActorResetType(item2.Key, out var ResetType);
				DeadUnitData item = new DeadUnitData
				{
					Uid = item2.Key,
					ResetType = ResetType
				};
				list.Add(item);
			}
		}
		return list;
	}

	public bool HasActorAliveState(string UnitGuid)
	{
		return ActorAliveState.ContainsKey(UnitGuid);
	}

	public bool GetActorAliveState(string UnitGuid)
	{
		if (!ActorAliveState.ContainsKey(UnitGuid))
		{
			return true;
		}
		return ActorAliveState[UnitGuid];
	}

	public bool GetActorSetByWorldPackageName(string WorldPackageName, out HashSet<string> ActorSet)
	{
		if (StreamingLevelActors.TryGetValue(WorldPackageName, out ActorSet))
		{
			return true;
		}
		return false;
	}

	public HashSet<string> GetResetAllActorList()
	{
		HashSet<string> hashSet = new HashSet<string>();
		foreach (KeyValuePair<string, BUC_ActorInitData> item in ActorInitDataDict)
		{
			hashSet.Add(item.Key);
		}
		foreach (KeyValuePair<string, bool> item2 in ActorAliveState)
		{
			hashSet.Add(item2.Key);
		}
		return hashSet;
	}

	public int GetActorCastSkillCount(string UnitGuid, int SkillID)
	{
		if (!ActorCastSkillCount.TryGetValue(UnitGuid, out var value))
		{
			return 0;
		}
		if (!value.TryGetValue(SkillID, out var value2))
		{
			return 0;
		}
		return value2;
	}

	public void GMSetActorCastSkillCount(string UnitGuid, int SkillID, int TargetCount)
	{
		if (ActorCastSkillCount.TryGetValue(UnitGuid, out var value))
		{
			if (value.TryGetValue(SkillID, out var _))
			{
				value[SkillID] = TargetCount;
			}
			else
			{
				value.Add(SkillID, TargetCount);
			}
		}
		else
		{
			ActorCastSkillCount.Add(UnitGuid, new Dictionary<int, int> { { SkillID, TargetCount } });
		}
	}

	public int GetAllInteractorSet(out HashSet<string> OutInteractorSet)
	{
		OutInteractorSet = InteractorSet;
		return OutInteractorSet.Count;
	}
}
