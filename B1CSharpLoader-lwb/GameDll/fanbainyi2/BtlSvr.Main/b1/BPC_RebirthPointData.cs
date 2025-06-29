using System;
using System.Collections.Generic;
using b1.ECS;
using BtlB1;
using BtlShare;
using GUR.Runtime;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BPC_RebirthPointData : IBPC_RebirthPointData, IPersistentECSData
{
	private FBirthPointInfo __CurrentBirthPoint_Raw;

	private BindListInt __ActivedRebirthPointList_Raw;

	private BindListInt __BlockedRebirthPointList_Raw;

	private BindDictInt_Int __CurrentRebirthPointIDMap_Raw;

	private int __LastRebirthPointTime_Raw;

	public Dictionary<AActor, int> RegisteredRebirthPointActorIDMap { get; } = new Dictionary<AActor, int>();

	public Dictionary<int, AActor> RegisteredRebirthPointIDActorMap { get; } = new Dictionary<int, AActor>();

	public Dictionary<int, TWeakObject<AActor>> RegisteredBirthPointIDActorMap { get; } = new Dictionary<int, TWeakObject<AActor>>();

	[GSPersistent(MarkDelaySaveArchiveSource = "SafePointChanged")]
	public FBirthPointInfo CurrentBirthPoint
	{
		get
		{
			return __CurrentBirthPoint_Raw;
		}
		set
		{
			FBirthPointInfo _CurrentBirthPoint_Raw = __CurrentBirthPoint_Raw;
			__CurrentBirthPoint_Raw = value;
			OnCurrentBirthPointChg_Invoke(_CurrentBirthPoint_Raw, value);
		}
	}

	[GSPersistent]
	public BindListInt ActivedRebirthPointList
	{
		get
		{
			return __ActivedRebirthPointList_Raw;
		}
		set
		{
			BindListInt _ActivedRebirthPointList_Raw = __ActivedRebirthPointList_Raw;
			__ActivedRebirthPointList_Raw = value;
			OnActivedRebirthPointListChg_Invoke(_ActivedRebirthPointList_Raw, value);
		}
	}

	[GSPersistent]
	public BindListInt BlockedRebirthPointList
	{
		get
		{
			return __BlockedRebirthPointList_Raw;
		}
		set
		{
			BindListInt _BlockedRebirthPointList_Raw = __BlockedRebirthPointList_Raw;
			__BlockedRebirthPointList_Raw = value;
			OnBlockedRebirthPointListChg_Invoke(_BlockedRebirthPointList_Raw, value);
		}
	}

	[GSPersistent(MarkDelaySaveArchiveSource = "SafePointChanged")]
	public BindDictInt_Int CurrentRebirthPointIDMap
	{
		get
		{
			return __CurrentRebirthPointIDMap_Raw;
		}
		set
		{
			BindDictInt_Int _CurrentRebirthPointIDMap_Raw = __CurrentRebirthPointIDMap_Raw;
			__CurrentRebirthPointIDMap_Raw = value;
			OnCurrentRebirthPointIDMapChg_Invoke(_CurrentRebirthPointIDMap_Raw, value);
		}
	}

	public List<int> HighPrioritySpecialRebithPointID { get; set; }

	[GSPersistent]
	public int LastRebirthPointTime
	{
		get
		{
			return __LastRebirthPointTime_Raw;
		}
		set
		{
			int _LastRebirthPointTime_Raw = __LastRebirthPointTime_Raw;
			__LastRebirthPointTime_Raw = value;
			OnLastRebirthPointTimeChg_Invoke(_LastRebirthPointTime_Raw, value);
		}
	}

	public event Action<FBirthPointInfo, FBirthPointInfo> OnCurrentBirthPointChg;

	public event Action<BindListInt, BindListInt> OnActivedRebirthPointListChg;

	public event Action<BindListInt, BindListInt> OnBlockedRebirthPointListChg;

	public event Action<BindDictInt_Int, BindDictInt_Int> OnCurrentRebirthPointIDMapChg;

	public event Action<int, int> OnLastRebirthPointTimeChg;

	private void OnCurrentBirthPointChg_Invoke(FBirthPointInfo OldValue, FBirthPointInfo NewValue)
	{
		if ((NewValue != null || OldValue != null) && ((NewValue == null && OldValue != null) || !NewValue.Equals(OldValue)))
		{
			this.OnCurrentBirthPointChg?.Invoke(OldValue, NewValue);
		}
	}

	private void OnActivedRebirthPointListChg_Invoke(BindListInt OldValue, BindListInt NewValue)
	{
		if ((NewValue != null || OldValue != null) && ((NewValue == null && OldValue != null) || !NewValue.Equals(OldValue)))
		{
			this.OnActivedRebirthPointListChg?.Invoke(OldValue, NewValue);
		}
	}

	private void OnBlockedRebirthPointListChg_Invoke(BindListInt OldValue, BindListInt NewValue)
	{
		if ((NewValue != null || OldValue != null) && ((NewValue == null && OldValue != null) || !NewValue.Equals(OldValue)))
		{
			this.OnBlockedRebirthPointListChg?.Invoke(OldValue, NewValue);
		}
	}

	private void OnCurrentRebirthPointIDMapChg_Invoke(BindDictInt_Int OldValue, BindDictInt_Int NewValue)
	{
		if ((NewValue != null || OldValue != null) && ((NewValue == null && OldValue != null) || !NewValue.Equals(OldValue)))
		{
			this.OnCurrentRebirthPointIDMapChg?.Invoke(OldValue, NewValue);
		}
	}

	private void OnLastRebirthPointTimeChg_Invoke(int OldValue, int NewValue)
	{
		if (!NewValue.Equals(OldValue))
		{
			this.OnLastRebirthPointTimeChg?.Invoke(OldValue, NewValue);
		}
	}

	public void InitRebirthAndBirthPointMap(UObject WorldCtx)
	{
		BGURebirthPointBase[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass<BGURebirthPointBase>(WorldCtx);
		b1.BUBirthPoint[] allActorsOfClass2 = UGameplayStatics.GetAllActorsOfClass<b1.BUBirthPoint>(WorldCtx);
		BGURebirthPointBase[] array = allActorsOfClass;
		foreach (BGURebirthPointBase bGURebirthPointBase in array)
		{
			int rebirthPointID = bGURebirthPointBase.GetComponentByClass<BUS_RebirthPointConfigComp>().RebirthPointConfig.RebirthPointID;
			if (GSEUtil.Ensure(!RegisteredRebirthPointIDActorMap.TryGetValue(rebirthPointID, out var value), "RebirthPoint Duplicated " + bGURebirthPointBase.GetPathName() + " " + value?.GetPathName()))
			{
				RegisteredRebirthPointIDActorMap.Add(rebirthPointID, bGURebirthPointBase);
				RegisteredRebirthPointActorIDMap.Add(bGURebirthPointBase, rebirthPointID);
			}
		}
		b1.BUBirthPoint[] array2 = allActorsOfClass2;
		foreach (b1.BUBirthPoint bUBirthPoint in array2)
		{
			int birthPointID = bUBirthPoint.BirthPointID;
			if (GSEUtil.Ensure(!RegisteredBirthPointIDActorMap.TryGetValue(birthPointID, out var value2), "RebirthPoint Duplicated " + bUBirthPoint.GetPathName() + " " + value2.Value?.GetPathName()))
			{
				RegisteredBirthPointIDActorMap.Add(birthPointID, new TWeakObject<AActor>(bUBirthPoint));
			}
		}
	}

	public BPC_RebirthPointData()
	{
		ActivedRebirthPointList = new BindListInt();
		BlockedRebirthPointList = new BindListInt();
		CurrentBirthPoint = new FBirthPointInfo();
		CurrentRebirthPointIDMap = new BindDictInt_Int();
		HighPrioritySpecialRebithPointID = new List<int>();
	}

	public bool IsRebirthPointRegistered(int RebirthPointID)
	{
		return RegisteredRebirthPointIDActorMap.ContainsKey(RebirthPointID);
	}

	public bool IsRebirthPointActived(int RebirthPointID)
	{
		return ActivedRebirthPointList.Contains(RebirthPointID);
	}

	public int GetActivedRebirthPoints(out List<int> ActivedRebirthPointIdList)
	{
		ActivedRebirthPointIdList = new List<int>();
		ActivedRebirthPointIdList.AddRange(ActivedRebirthPointList);
		return ActivedRebirthPointIdList.Count;
	}

	public int GetBlockedRebirthPoints(out List<int> BlockedRebirthPointIdList)
	{
		BlockedRebirthPointIdList = new List<int>();
		BlockedRebirthPointIdList.AddRange(BlockedRebirthPointList);
		return BlockedRebirthPointIdList.Count;
	}

	public int GetCurrentRebirthPointID(UObject WorldContext)
	{
		if (WorldContext == null || CurrentRebirthPointIDMap == null)
		{
			BGW_LogUtil.LogError("GetCurrentRebirthPointID 无法获取当前复活点数据！");
			return 0;
		}
		int curLevelId = BGUFuncLibMap.GetCurLevelId(WorldContext);
		int num = 0;
		foreach (int item in HighPrioritySpecialRebithPointID)
		{
			FUStRebirthPointDesc rebirthPointDesc = BGW_GameDB.GetRebirthPointDesc(item);
			if (rebirthPointDesc != null && IsRebirthPointActived(item))
			{
				if (rebirthPointDesc.IsZhaoHunFan == EGSYesNo.Yes && num == 0 && rebirthPointDesc.MapID == curLevelId)
				{
					num = item;
				}
				else if (rebirthPointDesc.IsZhaoHunFan == EGSYesNo.No && rebirthPointDesc.MapID == curLevelId)
				{
					num = item;
				}
			}
		}
		if (num != 0)
		{
			return num;
		}
		if (CurrentRebirthPointIDMap.ContainsKey(curLevelId))
		{
			return CurrentRebirthPointIDMap[curLevelId];
		}
		BGW_LogUtil.LogError($"GetCurrentRebirthPointID CurrentRebirthPointIDMap里没有CurrentLevelId对应的复活点ID，CurrentLevelId: {curLevelId}");
		return 0;
	}
}
