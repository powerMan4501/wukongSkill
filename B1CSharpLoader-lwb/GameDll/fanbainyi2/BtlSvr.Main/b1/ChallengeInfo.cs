using System;
using System.Collections.Generic;
using Google.Protobuf.Collections;
using GUR.Runtime;
using GurGsStruct;
using UnrealEngine.Engine;

namespace b1;

[ReplicateData]
public class ChallengeInfo
{
	public delegate RepeatedField<ClassDeltaMsgChallengeInfo> Del_GetRepData();

	private Del_GetRepData GetDeltaDataFunc;

	private RepeatedField<ClassDeltaMsgChallengeInfo> DeltaDataCache;

	private int __ChallengeId_Raw;

	private int __ChallengeLevel_Raw;

	private BindListEntity __ChallengingPlayerList_Raw;

	private BindListEntity __FallDyingPlayerList_Raw;

	private bool __ChallengeFailed_Raw;

	private float __LimitTime_Raw;

	public List<APlayerController> RecordPlayerList;

	public AActor ChallengeSpawner;

	protected RepeatedField<ClassDeltaMsgChallengeInfo> DeltaData
	{
		get
		{
			if (GetDeltaDataFunc != null && DeltaDataCache == null)
			{
				DeltaDataCache = GetDeltaDataFunc();
			}
			return DeltaDataCache;
		}
	}

	[GSReplicated]
	public int ChallengeId
	{
		get
		{
			return __ChallengeId_Raw;
		}
		set
		{
			int _ChallengeId_Raw = __ChallengeId_Raw;
			__ChallengeId_Raw = value;
			OnChallengeIdChg_Invoke(_ChallengeId_Raw, value);
		}
	}

	[GSReplicated]
	public int ChallengeLevel
	{
		get
		{
			return __ChallengeLevel_Raw;
		}
		set
		{
			int _ChallengeLevel_Raw = __ChallengeLevel_Raw;
			__ChallengeLevel_Raw = value;
			OnChallengeLevelChg_Invoke(_ChallengeLevel_Raw, value);
		}
	}

	[GSReplicated]
	public BindListEntity ChallengingPlayerList
	{
		get
		{
			return __ChallengingPlayerList_Raw;
		}
		set
		{
			BindListEntity _ChallengingPlayerList_Raw = __ChallengingPlayerList_Raw;
			__ChallengingPlayerList_Raw = value;
			OnChallengingPlayerListChg_Invoke(_ChallengingPlayerList_Raw, value);
		}
	}

	[GSReplicated]
	public BindListEntity FallDyingPlayerList
	{
		get
		{
			return __FallDyingPlayerList_Raw;
		}
		set
		{
			BindListEntity _FallDyingPlayerList_Raw = __FallDyingPlayerList_Raw;
			__FallDyingPlayerList_Raw = value;
			OnFallDyingPlayerListChg_Invoke(_FallDyingPlayerList_Raw, value);
		}
	}

	[GSReplicated]
	public bool ChallengeFailed
	{
		get
		{
			return __ChallengeFailed_Raw;
		}
		set
		{
			bool _ChallengeFailed_Raw = __ChallengeFailed_Raw;
			__ChallengeFailed_Raw = value;
			OnChallengeFailedChg_Invoke(_ChallengeFailed_Raw, value);
		}
	}

	public bool ChallengeSuccess { get; set; }

	public float RewardDelayTime { get; set; }

	[GSReplicated]
	public float LimitTime
	{
		get
		{
			return __LimitTime_Raw;
		}
		set
		{
			float _LimitTime_Raw = __LimitTime_Raw;
			__LimitTime_Raw = value;
			OnLimitTimeChg_Invoke(_LimitTime_Raw, value);
		}
	}

	public int ChallengeStage { get; set; }

	public ulong BeginTime { get; set; }

	public event Action<int, int> OnChallengeIdChg;

	public event Action<int, int> OnChallengeLevelChg;

	public event Action<BindListEntity, BindListEntity> OnChallengingPlayerListChg;

	public event Action<BindListEntity, BindListEntity> OnFallDyingPlayerListChg;

	public event Action<bool, bool> OnChallengeFailedChg;

	public event Action<float, float> OnLimitTimeChg;

	public virtual void RefreshGetDeltaDataFunc(bool IsActive)
	{
		if (IsActive)
		{
			ChallengingPlayerList?.RegGetDeltaDataFunc(AllocRepDataForChallengingPlayerList);
			FallDyingPlayerList?.RegGetDeltaDataFunc(AllocRepDataForFallDyingPlayerList);
		}
		else
		{
			ChallengingPlayerList?.RegGetDeltaDataFunc(null);
			FallDyingPlayerList?.RegGetDeltaDataFunc(null);
		}
		ChallengingPlayerList?.RefreshGetDeltaDataFunc(IsActive);
		FallDyingPlayerList?.RefreshGetDeltaDataFunc(IsActive);
	}

	private RepeatedField<ListDeltaMsgEntity> AllocRepDataForChallengingPlayerList()
	{
		if (DeltaData != null)
		{
			ClassDeltaMsgChallengeInfo classDeltaMsgChallengeInfo = new ClassDeltaMsgChallengeInfo();
			classDeltaMsgChallengeInfo.Value = new GurGsStruct.ChallengeInfo();
			classDeltaMsgChallengeInfo.Op = OPType.Modify;
			classDeltaMsgChallengeInfo.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
			DeltaData.Add(classDeltaMsgChallengeInfo);
			return classDeltaMsgChallengeInfo.Value.ChallengingPlayerList;
		}
		return null;
	}

	private RepeatedField<ListDeltaMsgEntity> AllocRepDataForFallDyingPlayerList()
	{
		if (DeltaData != null)
		{
			ClassDeltaMsgChallengeInfo classDeltaMsgChallengeInfo = new ClassDeltaMsgChallengeInfo();
			classDeltaMsgChallengeInfo.Value = new GurGsStruct.ChallengeInfo();
			classDeltaMsgChallengeInfo.Op = OPType.Modify;
			classDeltaMsgChallengeInfo.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
			DeltaData.Add(classDeltaMsgChallengeInfo);
			return classDeltaMsgChallengeInfo.Value.FallDyingPlayerList;
		}
		return null;
	}

	public void RegGetDeltaDataFunc(Del_GetRepData Func)
	{
		GetDeltaDataFunc = Func;
	}

	public virtual int GetGSRepSubClassIdx()
	{
		return -1;
	}

	public virtual void DumpFull(RepeatedField<ClassDeltaMsgChallengeInfo> Data)
	{
		Data.Clear();
		uint version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		Data.Add(new ClassDeltaMsgChallengeInfo
		{
			Op = OPType.ChangeRef,
			Version = version
		});
		ClassDeltaMsgChallengeInfo classDeltaMsgChallengeInfo = new ClassDeltaMsgChallengeInfo();
		classDeltaMsgChallengeInfo.Op = OPType.Modify;
		classDeltaMsgChallengeInfo.Version = version;
		classDeltaMsgChallengeInfo.Value = new GurGsStruct.ChallengeInfo();
		classDeltaMsgChallengeInfo.Value.ChallengeId = ChallengeId;
		classDeltaMsgChallengeInfo.Value.ChallengeLevel = ChallengeLevel;
		if (ChallengingPlayerList == null)
		{
			classDeltaMsgChallengeInfo.Value.ChallengingPlayerList.Add(new ListDeltaMsgEntity
			{
				Op = OPType.SetNull,
				Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion()
			});
		}
		else
		{
			ChallengingPlayerList.DumpFull(classDeltaMsgChallengeInfo.Value.ChallengingPlayerList);
		}
		if (FallDyingPlayerList == null)
		{
			classDeltaMsgChallengeInfo.Value.FallDyingPlayerList.Add(new ListDeltaMsgEntity
			{
				Op = OPType.SetNull,
				Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion()
			});
		}
		else
		{
			FallDyingPlayerList.DumpFull(classDeltaMsgChallengeInfo.Value.FallDyingPlayerList);
		}
		classDeltaMsgChallengeInfo.Value.ChallengeFailed = ChallengeFailed;
		classDeltaMsgChallengeInfo.Value.LimitTime = LimitTime;
		Data.Add(classDeltaMsgChallengeInfo);
	}

	public void ClearDeltaData()
	{
		DeltaDataCache = null;
		ChallengingPlayerList?.ClearDeltaData();
		FallDyingPlayerList?.ClearDeltaData();
	}

	private void OnChallengeIdChg_Invoke(int OldValue, int NewValue)
	{
		if (!NewValue.Equals(OldValue))
		{
			if (DeltaData != null)
			{
				ClassDeltaMsgChallengeInfo classDeltaMsgChallengeInfo = new ClassDeltaMsgChallengeInfo();
				classDeltaMsgChallengeInfo.Value = new GurGsStruct.ChallengeInfo();
				classDeltaMsgChallengeInfo.Op = OPType.Modify;
				classDeltaMsgChallengeInfo.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
				DeltaData.Add(classDeltaMsgChallengeInfo);
				classDeltaMsgChallengeInfo.Value.ChallengeId = NewValue;
			}
			this.OnChallengeIdChg?.Invoke(OldValue, NewValue);
		}
	}

	private void OnChallengeLevelChg_Invoke(int OldValue, int NewValue)
	{
		if (!NewValue.Equals(OldValue))
		{
			if (DeltaData != null)
			{
				ClassDeltaMsgChallengeInfo classDeltaMsgChallengeInfo = new ClassDeltaMsgChallengeInfo();
				classDeltaMsgChallengeInfo.Value = new GurGsStruct.ChallengeInfo();
				classDeltaMsgChallengeInfo.Op = OPType.Modify;
				classDeltaMsgChallengeInfo.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
				DeltaData.Add(classDeltaMsgChallengeInfo);
				classDeltaMsgChallengeInfo.Value.ChallengeLevel = NewValue;
			}
			this.OnChallengeLevelChg?.Invoke(OldValue, NewValue);
		}
	}

	private void OnChallengingPlayerListChg_Invoke(BindListEntity OldValue, BindListEntity NewValue)
	{
		if ((NewValue == null && OldValue == null) || ((NewValue != null || OldValue == null) && NewValue.Equals(OldValue)))
		{
			return;
		}
		if (DeltaData != null)
		{
			OldValue?.ClearDeltaData();
			ClassDeltaMsgChallengeInfo classDeltaMsgChallengeInfo = new ClassDeltaMsgChallengeInfo();
			classDeltaMsgChallengeInfo.Value = new GurGsStruct.ChallengeInfo();
			classDeltaMsgChallengeInfo.Op = OPType.Modify;
			classDeltaMsgChallengeInfo.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
			DeltaData.Add(classDeltaMsgChallengeInfo);
			if (NewValue == null)
			{
				classDeltaMsgChallengeInfo.Value.ChallengingPlayerList.Add(new ListDeltaMsgEntity
				{
					Op = OPType.SetNull,
					Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion()
				});
			}
			else
			{
				NewValue.ClearDeltaData();
				NewValue.RegGetDeltaDataFunc(AllocRepDataForChallengingPlayerList);
				NewValue.DumpFull(classDeltaMsgChallengeInfo.Value.ChallengingPlayerList);
			}
		}
		this.OnChallengingPlayerListChg?.Invoke(OldValue, NewValue);
	}

	private void OnFallDyingPlayerListChg_Invoke(BindListEntity OldValue, BindListEntity NewValue)
	{
		if ((NewValue == null && OldValue == null) || ((NewValue != null || OldValue == null) && NewValue.Equals(OldValue)))
		{
			return;
		}
		if (DeltaData != null)
		{
			OldValue?.ClearDeltaData();
			ClassDeltaMsgChallengeInfo classDeltaMsgChallengeInfo = new ClassDeltaMsgChallengeInfo();
			classDeltaMsgChallengeInfo.Value = new GurGsStruct.ChallengeInfo();
			classDeltaMsgChallengeInfo.Op = OPType.Modify;
			classDeltaMsgChallengeInfo.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
			DeltaData.Add(classDeltaMsgChallengeInfo);
			if (NewValue == null)
			{
				classDeltaMsgChallengeInfo.Value.FallDyingPlayerList.Add(new ListDeltaMsgEntity
				{
					Op = OPType.SetNull,
					Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion()
				});
			}
			else
			{
				NewValue.ClearDeltaData();
				NewValue.RegGetDeltaDataFunc(AllocRepDataForFallDyingPlayerList);
				NewValue.DumpFull(classDeltaMsgChallengeInfo.Value.FallDyingPlayerList);
			}
		}
		this.OnFallDyingPlayerListChg?.Invoke(OldValue, NewValue);
	}

	private void OnChallengeFailedChg_Invoke(bool OldValue, bool NewValue)
	{
		if (!NewValue.Equals(OldValue))
		{
			if (DeltaData != null)
			{
				ClassDeltaMsgChallengeInfo classDeltaMsgChallengeInfo = new ClassDeltaMsgChallengeInfo();
				classDeltaMsgChallengeInfo.Value = new GurGsStruct.ChallengeInfo();
				classDeltaMsgChallengeInfo.Op = OPType.Modify;
				classDeltaMsgChallengeInfo.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
				DeltaData.Add(classDeltaMsgChallengeInfo);
				classDeltaMsgChallengeInfo.Value.ChallengeFailed = NewValue;
			}
			this.OnChallengeFailedChg?.Invoke(OldValue, NewValue);
		}
	}

	private void OnLimitTimeChg_Invoke(float OldValue, float NewValue)
	{
		if (!NewValue.Equals(OldValue))
		{
			if (DeltaData != null)
			{
				ClassDeltaMsgChallengeInfo classDeltaMsgChallengeInfo = new ClassDeltaMsgChallengeInfo();
				classDeltaMsgChallengeInfo.Value = new GurGsStruct.ChallengeInfo();
				classDeltaMsgChallengeInfo.Op = OPType.Modify;
				classDeltaMsgChallengeInfo.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
				DeltaData.Add(classDeltaMsgChallengeInfo);
				classDeltaMsgChallengeInfo.Value.LimitTime = NewValue;
			}
			this.OnLimitTimeChg?.Invoke(OldValue, NewValue);
		}
	}
}
