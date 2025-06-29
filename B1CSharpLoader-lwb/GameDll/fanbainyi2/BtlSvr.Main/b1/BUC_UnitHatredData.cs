using System;
using System.Collections.Generic;
using b1.ECS;
using Google.Protobuf.Collections;
using GUR.Runtime;
using GurGsReplicate;
using GurGsStruct;
using UnrealEngine.Engine;

namespace b1;

public class BUC_UnitHatredData : IBUC_UnitHatredData, IPersistentECSData
{
	private int __LocalRepVersion = -1;

	private int __LocalOldRepVersion = -1;

	private bool _RepActive;

	protected int[] __GlobalRepVersionMap = new int[64];

	protected int[] __LocalRepVersionMap = new int[64];

	public UnitHatredData[] _RepData = new UnitHatredData[64];

	private BindListEntity __PlayerHatredEntityList_Raw;

	public float ForceUpdateHatredTargetTimer;

	public float HatredReFreshTick;

	public List<Entity> TaunterList;

	private bool bEnableUpdateHatred;

	private bool bCanSetTargetByHatred;

	public BindListUnitHatredTargetInfo HatredTargetInfoList { get; set; }

	[GSReplicated]
	public BindListEntity PlayerHatredEntityList
	{
		get
		{
			return __PlayerHatredEntityList_Raw;
		}
		set
		{
			BindListEntity _PlayerHatredEntityList_Raw = __PlayerHatredEntityList_Raw;
			__PlayerHatredEntityList_Raw = value;
			OnPlayerHatredEntityListChg_Invoke(_PlayerHatredEntityList_Raw, value);
		}
	}

	public bool IsHatredTargetInfoListEmpty
	{
		get
		{
			if (HatredTargetInfoList != null)
			{
				return HatredTargetInfoList.Count == 0;
			}
			return true;
		}
	}

	public event Action<BindListEntity, BindListEntity> OnPlayerHatredEntityListChg;

	public void _SetRepActive(bool IsActive)
	{
		if (_RepActive != IsActive)
		{
			_RepActive = IsActive;
			RefreshGetDeltaDataFunc(IsActive);
		}
	}

	private void RefreshGetDeltaDataFunc(bool IsActive)
	{
		if (IsActive)
		{
			PlayerHatredEntityList?.RegGetDeltaDataFunc(AllocRepDataForPlayerHatredEntityList);
		}
		else
		{
			PlayerHatredEntityList?.RegGetDeltaDataFunc(null);
		}
		PlayerHatredEntityList?.RefreshGetDeltaDataFunc(IsActive);
	}

	private RepeatedField<ListDeltaMsgEntity> AllocRepDataForPlayerHatredEntityList()
	{
		if (_RepActive)
		{
			return GetOrAllocRepData().PlayerHatredEntityList;
		}
		return null;
	}

	public UnitHatredData GetOrAllocRepData()
	{
		bool flag = false;
		if (__LocalRepVersion < 0 || (__LocalOldRepVersion >= __LocalRepVersion && __LocalOldRepVersion >= 0))
		{
			__LocalRepVersion = __LocalOldRepVersion + 1;
			__GlobalRepVersionMap[__LocalRepVersion % 64] = BGWGameInstanceCS.AllocGlobalReplicateVersion();
			flag = true;
		}
		UnitHatredData unitHatredData = _RepData[__LocalRepVersion % 64];
		if (unitHatredData == null)
		{
			unitHatredData = new UnitHatredData();
			PlayerHatredEntityList?.ClearDeltaData();
			_RepData[__LocalRepVersion % 64] = unitHatredData;
		}
		else if (flag)
		{
			unitHatredData.PlayerHatredEntityList.Clear();
			PlayerHatredEntityList?.ClearDeltaData();
		}
		return unitHatredData;
	}

	public UnitHatredData GetRepDataForNetRep(IntPtr ConnectionPtr, int OldGlobalVersion)
	{
		if (__LocalOldRepVersion < __LocalRepVersion)
		{
			__LocalOldRepVersion = __LocalRepVersion;
			PlayerHatredEntityList?.ClearDeltaData();
		}
		if (__LocalRepVersion < 0 || OldGlobalVersion > __GlobalRepVersionMap[__LocalRepVersion % 64])
		{
			return null;
		}
		UnitHatredData unitHatredData = new UnitHatredData();
		int num = Math.Max(__LocalRepVersion - 64 + 1, 0);
		if (__GlobalRepVersionMap[num % 64] > OldGlobalVersion)
		{
			if (OldGlobalVersion > 0)
			{
				BGW_LogUtil.LogError($"UnitHatredData Cache OverFlow On Replicate Full Data {OldGlobalVersion}");
			}
			if (PlayerHatredEntityList == null)
			{
				unitHatredData.PlayerHatredEntityList.Add(new ListDeltaMsgEntity
				{
					Op = OPType.SetNull,
					Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion()
				});
			}
			else
			{
				PlayerHatredEntityList.DumpFull(unitHatredData.PlayerHatredEntityList);
			}
		}
		else
		{
			for (int i = num; i <= __LocalRepVersion; i++)
			{
				if (__GlobalRepVersionMap[i % 64] > OldGlobalVersion)
				{
					UnitHatredData other = _RepData[i % 64];
					unitHatredData.MergeFrom(other);
				}
			}
		}
		return unitHatredData;
	}

	private void OnPlayerHatredEntityListChg_Invoke(BindListEntity OldValue, BindListEntity NewValue)
	{
		if ((NewValue == null && OldValue == null) || ((NewValue != null || OldValue == null) && NewValue.Equals(OldValue)))
		{
			return;
		}
		if (_RepActive)
		{
			UnitHatredData orAllocRepData = GetOrAllocRepData();
			OldValue?.ClearDeltaData();
			orAllocRepData.PlayerHatredEntityList.Clear();
			if (NewValue == null)
			{
				orAllocRepData.PlayerHatredEntityList.Add(new ListDeltaMsgEntity
				{
					Op = OPType.SetNull,
					Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion()
				});
			}
			else
			{
				NewValue.ClearDeltaData();
				NewValue.DumpFull(orAllocRepData.PlayerHatredEntityList);
			}
		}
		OldValue?.RegGetDeltaDataFunc(null);
		NewValue?.RegGetDeltaDataFunc(AllocRepDataForPlayerHatredEntityList);
		this.OnPlayerHatredEntityListChg?.Invoke(OldValue, NewValue);
	}

	public BUC_UnitHatredData()
	{
		bEnableUpdateHatred = true;
		bCanSetTargetByHatred = true;
		ForceUpdateHatredTargetTimer = 0f;
		HatredReFreshTick = 0f;
		HatredTargetInfoList = new BindListUnitHatredTargetInfo();
		PlayerHatredEntityList = new BindListEntity();
		TaunterList = new List<Entity>();
	}

	public GSBindList<UnitHatredTargetInfo> GetHatredTargetInfoList()
	{
		return HatredTargetInfoList;
	}

	public GSBindList<Entity> GetPlayerHatredEntityList()
	{
		return PlayerHatredEntityList;
	}

	public List<Entity> GetTaunterList()
	{
		return TaunterList;
	}

	public UnitHatredTargetInfo GetHatredTargetInfo(AActor TargetID)
	{
		foreach (UnitHatredTargetInfo hatredTargetInfo in HatredTargetInfoList)
		{
			if (hatredTargetInfo.HatredTargetActor == TargetID)
			{
				return hatredTargetInfo;
			}
		}
		return new UnitHatredTargetInfo();
	}

	public UnitHatredTargetInfo GetHatredTargetInfoByID(AActor TargetID, out int Idx)
	{
		Idx = -1;
		for (int num = HatredTargetInfoList.Count - 1; num >= 0; num--)
		{
			UnitHatredTargetInfo unitHatredTargetInfo = HatredTargetInfoList[num];
			if (unitHatredTargetInfo.HatredTargetActor == TargetID)
			{
				Idx = num;
				return unitHatredTargetInfo;
			}
		}
		return new UnitHatredTargetInfo();
	}

	public void AddTaunter(Entity Taunter)
	{
		TaunterList.Add(Taunter);
	}

	public void ReMoveTaunter(Entity Taunter)
	{
		TaunterList.Remove(Taunter);
	}

	public void ClearHatredTargetInfoList()
	{
		HatredTargetInfoList.Clear();
	}

	public void ClearPlayerHatredEntityList()
	{
		PlayerHatredEntityList.Clear();
	}

	public void SetEnableUpdateHatred(bool bEnable)
	{
		bEnableUpdateHatred = bEnable;
	}

	public bool GetEnableUpdateHatred()
	{
		return bEnableUpdateHatred;
	}

	public void SetCanSetTargetByHatred(bool bEnable)
	{
		bCanSetTargetByHatred = bEnable;
	}

	public bool GetCanSetTargetByHatred()
	{
		return bCanSetTargetByHatred;
	}

	public bool CheckHasHatredTarget(out int TargetNum)
	{
		TargetNum = HatredTargetInfoList.Count;
		return HatredTargetInfoList.Count > 0;
	}
}
