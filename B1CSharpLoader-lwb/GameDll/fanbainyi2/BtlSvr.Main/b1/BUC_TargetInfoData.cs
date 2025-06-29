using System;
using System.Collections.Generic;
using b1.ECS;
using Google.Protobuf.Collections;
using GUR.Runtime;
using GurGsReplicate;
using GurGsStruct;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUC_TargetInfoData : IBUC_TargetInfoData, IPersistentECSData
{
	private int __LocalRepVersion = -1;

	private int __LocalOldRepVersion = -1;

	private bool _RepActive;

	protected int[] __GlobalRepVersionMap = new int[64];

	protected int[] __LocalRepVersionMap = new int[64];

	public TargetInfoData[] _RepData = new TargetInfoData[64];

	private UnitLockTargetInfo __TargetInfo_Raw;

	private int BeTargetedCount;

	private bool bCanSetTarget;

	private List<UnitLockTargetInfo> MultiTargetInfoList { get; set; }

	private UnitLockTargetInfo SkillBaseTargetInfo { get; set; }

	private UnitLockTargetInfo ComboTargetInfo { get; set; }

	private UnitLockTargetInfo AOTargetInfo { get; set; }

	private UnitLockTargetInfo MoveToTargetInfo { get; set; }

	[GSReplicated]
	public UnitLockTargetInfo TargetInfo
	{
		get
		{
			return __TargetInfo_Raw;
		}
		set
		{
			UnitLockTargetInfo _TargetInfo_Raw = __TargetInfo_Raw;
			__TargetInfo_Raw = value;
			OnTargetInfoChg_Invoke(_TargetInfo_Raw, value);
		}
	}

	public List<string> CachedLockSkeletonSocket { get; set; }

	public HashSet<string> DisabledLockSkeletonSocket { get; set; }

	public HashSet<string> DisabledAutoLockSceneComp { get; set; }

	public event Action<UnitLockTargetInfo, UnitLockTargetInfo> OnTargetInfoChg;

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
			TargetInfo?.RegGetDeltaDataFunc(AllocRepDataForTargetInfo);
		}
		else
		{
			TargetInfo?.RegGetDeltaDataFunc(null);
		}
		TargetInfo?.RefreshGetDeltaDataFunc(IsActive);
	}

	private RepeatedField<ClassDeltaMsgUnitLockTargetInfo> AllocRepDataForTargetInfo()
	{
		if (_RepActive)
		{
			return GetOrAllocRepData().TargetInfo;
		}
		return null;
	}

	public TargetInfoData GetOrAllocRepData()
	{
		bool flag = false;
		if (__LocalRepVersion < 0 || (__LocalOldRepVersion >= __LocalRepVersion && __LocalOldRepVersion >= 0))
		{
			__LocalRepVersion = __LocalOldRepVersion + 1;
			__GlobalRepVersionMap[__LocalRepVersion % 64] = BGWGameInstanceCS.AllocGlobalReplicateVersion();
			flag = true;
		}
		TargetInfoData targetInfoData = _RepData[__LocalRepVersion % 64];
		if (targetInfoData == null)
		{
			targetInfoData = new TargetInfoData();
			TargetInfo?.ClearDeltaData();
			_RepData[__LocalRepVersion % 64] = targetInfoData;
		}
		else if (flag)
		{
			targetInfoData.TargetInfo.Clear();
			TargetInfo?.ClearDeltaData();
		}
		return targetInfoData;
	}

	public TargetInfoData GetRepDataForNetRep(IntPtr ConnectionPtr, int OldGlobalVersion)
	{
		if (__LocalOldRepVersion < __LocalRepVersion)
		{
			__LocalOldRepVersion = __LocalRepVersion;
			TargetInfo?.ClearDeltaData();
		}
		if (__LocalRepVersion < 0 || OldGlobalVersion > __GlobalRepVersionMap[__LocalRepVersion % 64])
		{
			return null;
		}
		TargetInfoData targetInfoData = new TargetInfoData();
		int num = Math.Max(__LocalRepVersion - 64 + 1, 0);
		if (__GlobalRepVersionMap[num % 64] > OldGlobalVersion)
		{
			if (OldGlobalVersion > 0)
			{
				BGW_LogUtil.LogError($"TargetInfoData Cache OverFlow On Replicate Full Data {OldGlobalVersion}");
			}
			if (TargetInfo == null)
			{
				targetInfoData.TargetInfo.Add(new ClassDeltaMsgUnitLockTargetInfo
				{
					Op = OPType.SetNull,
					Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion()
				});
			}
			else
			{
				TargetInfo.DumpFull(targetInfoData.TargetInfo);
			}
		}
		else
		{
			for (int i = num; i <= __LocalRepVersion; i++)
			{
				if (__GlobalRepVersionMap[i % 64] > OldGlobalVersion)
				{
					TargetInfoData other = _RepData[i % 64];
					targetInfoData.MergeFrom(other);
				}
			}
		}
		return targetInfoData;
	}

	private void OnTargetInfoChg_Invoke(UnitLockTargetInfo OldValue, UnitLockTargetInfo NewValue)
	{
		if ((NewValue == null && OldValue == null) || ((NewValue != null || OldValue == null) && NewValue.Equals(OldValue)))
		{
			return;
		}
		if (_RepActive)
		{
			TargetInfoData orAllocRepData = GetOrAllocRepData();
			OldValue?.ClearDeltaData();
			orAllocRepData.TargetInfo.Clear();
			if (NewValue == null)
			{
				orAllocRepData.TargetInfo.Add(new ClassDeltaMsgUnitLockTargetInfo
				{
					Op = OPType.SetNull,
					Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion()
				});
			}
			else
			{
				NewValue.ClearDeltaData();
				NewValue.DumpFull(orAllocRepData.TargetInfo);
			}
		}
		OldValue?.RegGetDeltaDataFunc(null);
		NewValue?.RegGetDeltaDataFunc(AllocRepDataForTargetInfo);
		this.OnTargetInfoChg?.Invoke(OldValue, NewValue);
	}

	public BUC_TargetInfoData()
	{
		MultiTargetInfoList = new List<UnitLockTargetInfo>();
		TargetInfo = new UnitLockTargetInfo();
		SkillBaseTargetInfo = null;
		CachedLockSkeletonSocket = new List<string>();
		DisabledLockSkeletonSocket = new HashSet<string>();
		DisabledAutoLockSceneComp = new HashSet<string>();
		BeTargetedCount = 0;
		bCanSetTarget = true;
	}

	public void SetSkillBaseTarget(AActor SkillBaseTarget, UnrealEngine.Runtime.FVector Location, ETargetSourceType SourceType, string SceneCompName)
	{
		SkillBaseTargetInfo = new UnitLockTargetInfo(SkillBaseTarget, Location, SourceType, ELockTargetWayType.Skill, SceneCompName);
	}

	public void ClearSkillBaseTarget()
	{
		SkillBaseTargetInfo = null;
	}

	public void SetComboTarget(AActor ComboTarget, ETargetSourceType SourceType, bool bPlayer = false)
	{
		if (bPlayer)
		{
			ComboTargetInfo = new UnitLockTargetInfo(ComboTarget, SourceType, ELockTargetWayType.Combo);
		}
		else
		{
			SetAIAutoLockComboTarget(ComboTarget, SourceType);
		}
	}

	private void SetAIAutoLockComboTarget(AActor ComboTarget, ETargetSourceType SourceType)
	{
		UnitLockTargetInfo unitLockTargetInfo = BGUFuncLibAICS.BGUAIGetAutoLockTargetInfo(ComboTarget, SourceType, ELockTargetWayType.Combo);
		if (unitLockTargetInfo != null)
		{
			ComboTargetInfo = unitLockTargetInfo;
		}
	}

	public void ClearComboTarget()
	{
		ComboTargetInfo = null;
	}

	public void SetAOTarget(AActor AOTarget, ETargetSourceType SourceType, bool bPlayer = false, float NonCombatantAOTargetDegreeLimit = -1f)
	{
		if (bPlayer)
		{
			AOTargetInfo = new UnitLockTargetInfo(AOTarget, SourceType, ELockTargetWayType.AimOffset);
			if (AOTargetInfo != null)
			{
				AOTargetInfo.NonCombatantAOTargetDegreeLimit = NonCombatantAOTargetDegreeLimit;
			}
		}
		else
		{
			SetAIAutoLockAOTarget(AOTarget, SourceType);
			if (AOTargetInfo != null)
			{
				AOTargetInfo.NonCombatantAOTargetDegreeLimit = NonCombatantAOTargetDegreeLimit;
			}
		}
	}

	public void ClearAOTarget_NonCombatantAOTargetDegreeLimit()
	{
		if (AOTargetInfo != null)
		{
			AOTargetInfo.NonCombatantAOTargetDegreeLimit = -1f;
		}
	}

	private void SetAIAutoLockAOTarget(AActor AOTarget, ETargetSourceType SourceType)
	{
		UnitLockTargetInfo unitLockTargetInfo = BGUFuncLibAICS.BGUAIGetAutoLockTargetInfo(AOTarget, SourceType, ELockTargetWayType.AimOffset);
		if (unitLockTargetInfo != null)
		{
			AOTargetInfo = unitLockTargetInfo;
		}
	}

	public void ClearAOTarget()
	{
		AOTargetInfo = null;
	}

	public void SetMoveToTarget(AActor MoveToTarget, UnrealEngine.Runtime.FVector PointLocation, ETargetSourceType SourceType = ETargetSourceType.None, string SceneCompName = "", string SocketName = "", bool bPlayer = false)
	{
		if (bPlayer)
		{
			MoveToTargetInfo = ((MoveToTarget != null) ? new UnitLockTargetInfo(MoveToTarget, SourceType, ELockTargetWayType.MoveTo, SceneCompName, SocketName) : new UnitLockTargetInfo(null, PointLocation, SourceType, ELockTargetWayType.MoveTo));
		}
		else
		{
			SetAIAutoLockMoveToTarget(MoveToTarget, PointLocation, SourceType, SceneCompName, SocketName);
		}
	}

	public void SetComboTargetInfo(UnitLockTargetInfo ComboTarget)
	{
		if (ComboTarget != null)
		{
			ComboTargetInfo = ComboTarget;
		}
	}

	private void SetAIAutoLockMoveToTarget(AActor MoveToTarget, UnrealEngine.Runtime.FVector PointLocation, ETargetSourceType SourceType = ETargetSourceType.None, string SceneCompName = "", string SocketName = "")
	{
		UnitLockTargetInfo unitLockTargetInfo = null;
		if (MoveToTarget != null)
		{
			unitLockTargetInfo = new UnitLockTargetInfo(MoveToTarget, SourceType, ELockTargetWayType.MoveTo, SceneCompName, SocketName);
			if (SourceType == ETargetSourceType.Target_AutoMoveTo)
			{
				unitLockTargetInfo = BGUFuncLibAICS.BGUAIGetAutoLockTargetInfo(MoveToTarget, SourceType, ELockTargetWayType.MoveTo);
			}
		}
		else
		{
			unitLockTargetInfo = new UnitLockTargetInfo(null, PointLocation, SourceType, ELockTargetWayType.MoveTo);
		}
		if (unitLockTargetInfo != null)
		{
			MoveToTargetInfo = unitLockTargetInfo;
		}
	}

	public void ClearMoveToTarget()
	{
		MoveToTargetInfo = null;
	}

	public void DoFreshMultiTarget(List<UnitLockTargetInfo> MTIList)
	{
		MultiTargetInfoList.Clear();
		MultiTargetInfoList = MTIList;
	}

	public void ClearMultiTarget()
	{
		MultiTargetInfoList.Clear();
	}

	public void SetTargetInfo(UnitLockTargetInfo _TargetInfo)
	{
		TargetInfo = _TargetInfo;
	}

	public void IncrementTargetedCount()
	{
		BeTargetedCount++;
	}

	public void DecrementTargetedCount()
	{
		BeTargetedCount--;
	}

	public void SetCanSetTarget(bool bEnable)
	{
		bCanSetTarget = bEnable;
	}

	public int GetTargetedCount()
	{
		return BeTargetedCount;
	}

	public UnitLockTargetInfo GetTargetInfo()
	{
		return TargetInfo;
	}

	public bool IsSupportMultiLockTarget()
	{
		return CachedLockSkeletonSocket.Count > 1;
	}

	public List<UnitLockTargetInfo> GetMultiTargetInfoList()
	{
		return MultiTargetInfoList;
	}

	public UnitLockTargetInfo GetSkillBaseTarget()
	{
		return SkillBaseTargetInfo ?? new UnitLockTargetInfo();
	}

	public UnitLockTargetInfo GetComboTarget()
	{
		return ComboTargetInfo ?? new UnitLockTargetInfo();
	}

	public UnitLockTargetInfo GetAOTarget()
	{
		return AOTargetInfo ?? new UnitLockTargetInfo();
	}

	public UnitLockTargetInfo GetMoveToTarget()
	{
		return MoveToTargetInfo ?? new UnitLockTargetInfo();
	}

	public bool GetCanSetTarget()
	{
		return bCanSetTarget;
	}

	public UnrealEngine.Runtime.FVector GetLockPointPosition()
	{
		bool FoundComp;
		return BGU_SelectTargetUtil.GetTargetPositionByTargetInfo(TargetInfo, out FoundComp);
	}
}
