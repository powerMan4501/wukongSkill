using System;
using System.Collections.Generic;
using b1.ECS;
using BtlShare;
using Google.Protobuf.Collections;
using GUR.Runtime;
using GurGsReplicate;
using GurGsStruct;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BGC_OnlineChallengeData : IBGC_OnlineChallengeData, IPersistentECSData
{
	private int __LocalRepVersion = -1;

	private int __LocalOldRepVersion = -1;

	private bool _RepActive;

	protected int[] __GlobalRepVersionMap = new int[64];

	protected int[] __LocalRepVersionMap = new int[64];

	public OnlineChallengeData[] _RepData = new OnlineChallengeData[64];

	private BindDictInt_ChallengeInfo __OnlineChallengeList_Raw;

	private BindDictInt_EChallengeState __OnlineChallengeStageDict_Raw;

	[GSReplicated]
	public BindDictInt_ChallengeInfo OnlineChallengeList
	{
		get
		{
			return __OnlineChallengeList_Raw;
		}
		set
		{
			BindDictInt_ChallengeInfo _OnlineChallengeList_Raw = __OnlineChallengeList_Raw;
			__OnlineChallengeList_Raw = value;
			OnOnlineChallengeListChg_Invoke(_OnlineChallengeList_Raw, value);
		}
	}

	[GSReplicated]
	public BindDictInt_EChallengeState OnlineChallengeStageDict
	{
		get
		{
			return __OnlineChallengeStageDict_Raw;
		}
		set
		{
			BindDictInt_EChallengeState _OnlineChallengeStageDict_Raw = __OnlineChallengeStageDict_Raw;
			__OnlineChallengeStageDict_Raw = value;
			OnOnlineChallengeStageDictChg_Invoke(_OnlineChallengeStageDict_Raw, value);
		}
	}

	public event Action<BindDictInt_ChallengeInfo, BindDictInt_ChallengeInfo> OnOnlineChallengeListChg;

	public event Action<BindDictInt_EChallengeState, BindDictInt_EChallengeState> OnOnlineChallengeStageDictChg;

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
			OnlineChallengeList?.RegGetDeltaDataFunc(AllocRepDataForOnlineChallengeList);
			OnlineChallengeStageDict?.RegGetDeltaDataFunc(AllocRepDataForOnlineChallengeStageDict);
		}
		else
		{
			OnlineChallengeList?.RegGetDeltaDataFunc(null);
			OnlineChallengeStageDict?.RegGetDeltaDataFunc(null);
		}
		OnlineChallengeList?.RefreshGetDeltaDataFunc(IsActive);
		OnlineChallengeStageDict?.RefreshGetDeltaDataFunc(IsActive);
	}

	private RepeatedField<DictDeltaMsgInt_ChallengeInfo> AllocRepDataForOnlineChallengeList()
	{
		if (_RepActive)
		{
			return GetOrAllocRepData().OnlineChallengeList;
		}
		return null;
	}

	private RepeatedField<DictDeltaMsgInt_EChallengeState> AllocRepDataForOnlineChallengeStageDict()
	{
		if (_RepActive)
		{
			return GetOrAllocRepData().OnlineChallengeStageDict;
		}
		return null;
	}

	public OnlineChallengeData GetOrAllocRepData()
	{
		bool flag = false;
		if (__LocalRepVersion < 0 || (__LocalOldRepVersion >= __LocalRepVersion && __LocalOldRepVersion >= 0))
		{
			__LocalRepVersion = __LocalOldRepVersion + 1;
			__GlobalRepVersionMap[__LocalRepVersion % 64] = BGWGameInstanceCS.AllocGlobalReplicateVersion();
			flag = true;
		}
		OnlineChallengeData onlineChallengeData = _RepData[__LocalRepVersion % 64];
		if (onlineChallengeData == null)
		{
			onlineChallengeData = new OnlineChallengeData();
			OnlineChallengeList?.ClearDeltaData();
			OnlineChallengeStageDict?.ClearDeltaData();
			_RepData[__LocalRepVersion % 64] = onlineChallengeData;
		}
		else if (flag)
		{
			onlineChallengeData.OnlineChallengeList.Clear();
			OnlineChallengeList?.ClearDeltaData();
			onlineChallengeData.OnlineChallengeStageDict.Clear();
			OnlineChallengeStageDict?.ClearDeltaData();
		}
		return onlineChallengeData;
	}

	public OnlineChallengeData GetRepDataForNetRep(IntPtr ConnectionPtr, int OldGlobalVersion)
	{
		if (__LocalOldRepVersion < __LocalRepVersion)
		{
			__LocalOldRepVersion = __LocalRepVersion;
			OnlineChallengeList?.ClearDeltaData();
			OnlineChallengeStageDict?.ClearDeltaData();
		}
		if (__LocalRepVersion < 0 || OldGlobalVersion > __GlobalRepVersionMap[__LocalRepVersion % 64])
		{
			return null;
		}
		OnlineChallengeData onlineChallengeData = new OnlineChallengeData();
		int num = Math.Max(__LocalRepVersion - 64 + 1, 0);
		if (__GlobalRepVersionMap[num % 64] > OldGlobalVersion)
		{
			if (OldGlobalVersion > 0)
			{
				BGW_LogUtil.LogError($"OnlineChallengeData Cache OverFlow On Replicate Full Data {OldGlobalVersion}");
			}
			if (OnlineChallengeList == null)
			{
				onlineChallengeData.OnlineChallengeList.Add(new DictDeltaMsgInt_ChallengeInfo
				{
					Op = OPType.SetNull,
					Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion()
				});
			}
			else
			{
				OnlineChallengeList.DumpFull(onlineChallengeData.OnlineChallengeList);
			}
			if (OnlineChallengeStageDict == null)
			{
				onlineChallengeData.OnlineChallengeStageDict.Add(new DictDeltaMsgInt_EChallengeState
				{
					Op = OPType.SetNull,
					Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion()
				});
			}
			else
			{
				OnlineChallengeStageDict.DumpFull(onlineChallengeData.OnlineChallengeStageDict);
			}
		}
		else
		{
			for (int i = num; i <= __LocalRepVersion; i++)
			{
				if (__GlobalRepVersionMap[i % 64] > OldGlobalVersion)
				{
					OnlineChallengeData other = _RepData[i % 64];
					onlineChallengeData.MergeFrom(other);
				}
			}
		}
		return onlineChallengeData;
	}

	private void OnOnlineChallengeListChg_Invoke(BindDictInt_ChallengeInfo OldValue, BindDictInt_ChallengeInfo NewValue)
	{
		if ((NewValue == null && OldValue == null) || ((NewValue != null || OldValue == null) && NewValue.Equals(OldValue)))
		{
			return;
		}
		if (_RepActive)
		{
			OnlineChallengeData orAllocRepData = GetOrAllocRepData();
			OldValue?.ClearDeltaData();
			orAllocRepData.OnlineChallengeList.Clear();
			if (NewValue == null)
			{
				orAllocRepData.OnlineChallengeList.Add(new DictDeltaMsgInt_ChallengeInfo
				{
					Op = OPType.SetNull,
					Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion()
				});
			}
			else
			{
				NewValue.ClearDeltaData();
				NewValue.DumpFull(orAllocRepData.OnlineChallengeList);
			}
		}
		OldValue?.RegGetDeltaDataFunc(null);
		NewValue?.RegGetDeltaDataFunc(AllocRepDataForOnlineChallengeList);
		this.OnOnlineChallengeListChg?.Invoke(OldValue, NewValue);
	}

	private void OnOnlineChallengeStageDictChg_Invoke(BindDictInt_EChallengeState OldValue, BindDictInt_EChallengeState NewValue)
	{
		if ((NewValue == null && OldValue == null) || ((NewValue != null || OldValue == null) && NewValue.Equals(OldValue)))
		{
			return;
		}
		if (_RepActive)
		{
			OnlineChallengeData orAllocRepData = GetOrAllocRepData();
			OldValue?.ClearDeltaData();
			orAllocRepData.OnlineChallengeStageDict.Clear();
			if (NewValue == null)
			{
				orAllocRepData.OnlineChallengeStageDict.Add(new DictDeltaMsgInt_EChallengeState
				{
					Op = OPType.SetNull,
					Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion()
				});
			}
			else
			{
				NewValue.ClearDeltaData();
				NewValue.DumpFull(orAllocRepData.OnlineChallengeStageDict);
			}
		}
		OldValue?.RegGetDeltaDataFunc(null);
		NewValue?.RegGetDeltaDataFunc(AllocRepDataForOnlineChallengeStageDict);
		this.OnOnlineChallengeStageDictChg?.Invoke(OldValue, NewValue);
	}

	public BGC_OnlineChallengeData()
	{
		OnlineChallengeList = new BindDictInt_ChallengeInfo();
		OnlineChallengeStageDict = new BindDictInt_EChallengeState();
	}

	public void ChallengeBegin(int ChallengeId, ChallengeInfo ChallengeInfo)
	{
		if (!OnlineChallengeList.ContainsKey(ChallengeId))
		{
			OnlineChallengeList.Add(ChallengeId, ChallengeInfo);
		}
		else
		{
			OnlineChallengeList[ChallengeId] = ChallengeInfo;
		}
	}

	public void ChallengeEnd(int ChallengeId)
	{
	}

	public void ChallengeFailed(int ChallengeId)
	{
		foreach (KeyValuePair<int, ChallengeInfo> onlineChallenge in OnlineChallengeList)
		{
			if (ChallengeId == onlineChallenge.Key)
			{
				ChallengeInfo challengeInfo = OnlineChallengeList[onlineChallenge.Key];
				challengeInfo.ChallengeFailed = true;
				OnlineChallengeList[onlineChallenge.Key] = challengeInfo;
				break;
			}
		}
	}

	public int GetDropIdByGuid(int ChallengeId, int CurLevel = 0)
	{
		int result = 0;
		FUStChallengeDesc challengeDesc = BGW_GameDB.GetChallengeDesc(ChallengeId);
		if (challengeDesc == null)
		{
			return result;
		}
		if (CurLevel == 0 && OnlineChallengeList.TryGetValue(ChallengeId, out var OutValue))
		{
			CurLevel = OutValue.ChallengeLevel;
		}
		switch (CurLevel)
		{
		case 1:
			result = challengeDesc.EasyDropId;
			break;
		case 2:
			result = challengeDesc.NormalDropId;
			break;
		case 3:
			result = challengeDesc.HardDropId;
			break;
		}
		return result;
	}

	public bool ChallengeIsBegin(int ChallengeId, int ChallengeLevel = 0)
	{
		if (ChallengeLevel != 0 && OnlineChallengeStageDict.TryGetValue(ChallengeId, out var OutValue))
		{
			return OutValue == EChallengeState.Begin;
		}
		return false;
	}

	public bool PlayerInChallenge(APlayerController PlayerController, out int ChallengeId)
	{
		ChallengeId = 0;
		if (PlayerController.IsNullOrDestroyed())
		{
			return false;
		}
		foreach (KeyValuePair<int, ChallengeInfo> onlineChallenge in OnlineChallengeList)
		{
			foreach (Entity fallDyingPlayer in onlineChallenge.Value.FallDyingPlayerList)
			{
				if (PlayerController.GetControlledPawn() == ECSExtension.ToActor(fallDyingPlayer))
				{
					ChallengeId = onlineChallenge.Key;
					return true;
				}
			}
			foreach (Entity challengingPlayer in onlineChallenge.Value.ChallengingPlayerList)
			{
				if (PlayerController.GetControlledPawn() == ECSExtension.ToActor(challengingPlayer))
				{
					ChallengeId = onlineChallenge.Key;
					return true;
				}
			}
		}
		return false;
	}

	public bool CheckPlayerInChallengeAndRemove(APlayerController PlayerController, out int ChallengeId)
	{
		ChallengeId = 0;
		if (PlayerController.IsNullOrDestroyed())
		{
			return false;
		}
		foreach (KeyValuePair<int, ChallengeInfo> onlineChallenge in OnlineChallengeList)
		{
			BindListEntity fallDyingPlayerList = onlineChallenge.Value.FallDyingPlayerList;
			foreach (Entity item in fallDyingPlayerList)
			{
				if (PlayerController.GetControlledPawn() == ECSExtension.ToActor(item))
				{
					ChallengeId = onlineChallenge.Key;
					fallDyingPlayerList.Remove(item);
					return true;
				}
			}
		}
		return false;
	}

	public int GetChallengeLevel(int ChallenegeId)
	{
		int result = 0;
		if (OnlineChallengeList.TryGetValue(ChallenegeId, out var OutValue))
		{
			result = OutValue.ChallengeLevel;
		}
		return result;
	}

	public float GetLimitTime(int ChallenegeId)
	{
		float result = 0f;
		if (OnlineChallengeList.TryGetValue(ChallenegeId, out var OutValue))
		{
			result = OutValue.LimitTime;
		}
		return result;
	}

	public bool CheckCanChallengeStageCanBegin(int ChallenegeId)
	{
		if (OnlineChallengeStageDict.TryGetValue(ChallenegeId, out var OutValue) && OutValue != EChallengeState.Begin && OutValue != EChallengeState.Success)
		{
			return true;
		}
		return false;
	}
}
