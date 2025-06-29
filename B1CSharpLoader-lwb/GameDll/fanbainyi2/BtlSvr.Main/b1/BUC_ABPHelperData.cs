using System;
using System.Collections.Generic;
using b1.BGU.BUAnim;
using GUR.Runtime;
using GurGsReplicate;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUC_ABPHelperData : IBUC_ABPHelperData
{
	private int __LocalRepVersion = -1;

	private int __LocalOldRepVersion = -1;

	private bool _RepActive;

	protected int[] __GlobalRepVersionMap = new int[64];

	protected int[] __LocalRepVersionMap = new int[64];

	public ABPHelperData[] _RepData = new ABPHelperData[64];

	private string __ABPSettingPath_Raw;

	private TStrongObjectPtr<UAnimInstance> mAnimInst = new TStrongObjectPtr<UAnimInstance>();

	private TStrongObjectPtr<UBGURootMotionSourceObject_ConstantForce> mCurveMoveRMS = new TStrongObjectPtr<UBGURootMotionSourceObject_ConstantForce>();

	public UAnimInstance AnimInst
	{
		get
		{
			return mAnimInst.Get();
		}
		set
		{
			mAnimInst.Set(value);
		}
	}

	public BUABPSettingData ABPSettingData
	{
		get
		{
			if (AnimInst != null && AnimInst is BUAnimInstanceBase bUAnimInstanceBase)
			{
				return bUAnimInstanceBase.ABPSettingData;
			}
			return null;
		}
	}

	[GSReplicated]
	public string ABPSettingPath
	{
		get
		{
			return __ABPSettingPath_Raw;
		}
		set
		{
			string _ABPSettingPath_Raw = __ABPSettingPath_Raw;
			__ABPSettingPath_Raw = value;
			OnABPSettingPathChg_Invoke(_ABPSettingPath_Raw, value);
		}
	}

	public bool bShouldRemoveCurveMoveRMS { get; set; }

	public bool bHasCurveMoveRMS { get; set; }

	public FVector CurveMovementVelocity { get; set; }

	public UBGURootMotionSourceObject_ConstantForce CurveMoveRMS
	{
		get
		{
			return mCurveMoveRMS.Get();
		}
		set
		{
			mCurveMoveRMS.Set(value);
		}
	}

	public Dictionary<FName, float> FloatCurveValues { get; } = new Dictionary<FName, float>();

	public Dictionary<FName, Dictionary<FName, float>> StateMachineWeights { get; } = new Dictionary<FName, Dictionary<FName, float>>();

	public uint RotationRateHandleID { get; set; }

	public uint BrakingDecelerationWalkingHandleID { get; set; }

	public uint MaxAccelerationHandleID { get; set; }

	public uint GroundFrictionHandleID { get; set; }

	public uint BrakingFrictionHandleID { get; set; }

	public uint PauseAnimsHandleID { get; set; }

	public bool bDataFirstUpdate { get; set; }

	public bool bReplicateRootMotionMove { get; set; }

	public float ScreenSize { get; set; }

	public float ScreenSizeThresholdNear { get; set; }

	public float ScreenSizeThresholdFar { get; set; }

	public bool bCanTickForAnimData { get; set; }

	public float AccumulatedDeltaTimeForAnimData { get; set; }

	public bool bABPDataInited { get; set; }

	public int IntDefaultAnimTickOption { get; set; }

	public event Action<string, string> OnABPSettingPathChg;

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
	}

	public ABPHelperData GetOrAllocRepData()
	{
		bool flag = false;
		if (__LocalRepVersion < 0 || (__LocalOldRepVersion >= __LocalRepVersion && __LocalOldRepVersion >= 0))
		{
			__LocalRepVersion = __LocalOldRepVersion + 1;
			__GlobalRepVersionMap[__LocalRepVersion % 64] = BGWGameInstanceCS.AllocGlobalReplicateVersion();
			flag = true;
		}
		ABPHelperData aBPHelperData = _RepData[__LocalRepVersion % 64];
		if (aBPHelperData == null)
		{
			aBPHelperData = new ABPHelperData();
			_RepData[__LocalRepVersion % 64] = aBPHelperData;
		}
		else if (flag)
		{
			aBPHelperData.ClearABPSettingPath();
		}
		return aBPHelperData;
	}

	public ABPHelperData GetRepDataForNetRep(IntPtr ConnectionPtr, int OldGlobalVersion)
	{
		if (__LocalOldRepVersion < __LocalRepVersion)
		{
			__LocalOldRepVersion = __LocalRepVersion;
		}
		if (__LocalRepVersion < 0 || OldGlobalVersion > __GlobalRepVersionMap[__LocalRepVersion % 64])
		{
			return null;
		}
		ABPHelperData aBPHelperData = new ABPHelperData();
		int num = Math.Max(__LocalRepVersion - 64 + 1, 0);
		if (__GlobalRepVersionMap[num % 64] > OldGlobalVersion)
		{
			if (OldGlobalVersion > 0)
			{
				BGW_LogUtil.LogError($"ABPHelperData Cache OverFlow On Replicate Full Data {OldGlobalVersion}");
			}
			aBPHelperData.ABPSettingPath = ((ABPSettingPath == null) ? string.Empty : ABPSettingPath);
		}
		else
		{
			for (int i = num; i <= __LocalRepVersion; i++)
			{
				if (__GlobalRepVersionMap[i % 64] > OldGlobalVersion)
				{
					ABPHelperData other = _RepData[i % 64];
					aBPHelperData.MergeFrom(other);
				}
			}
		}
		return aBPHelperData;
	}

	private void OnABPSettingPathChg_Invoke(string OldValue, string NewValue)
	{
		if ((NewValue != null || OldValue != null) && ((NewValue == null && OldValue != null) || !NewValue.Equals(OldValue)))
		{
			if (_RepActive)
			{
				GetOrAllocRepData().ABPSettingPath = ((NewValue == null) ? string.Empty : NewValue);
			}
			this.OnABPSettingPathChg?.Invoke(OldValue, NewValue);
		}
	}

	public bool GetFloatAnimCurveValue(in FName CurveName, out float OutCurveValue)
	{
		return FloatCurveValues.TryGetValue(CurveName, out OutCurveValue);
	}

	public float GetStateMachineWeight(in FName StateMachineName, in FName StateName)
	{
		if (!StateMachineWeights.TryGetValue(StateMachineName, out var value))
		{
			return 0f;
		}
		value.TryGetValue(StateName, out var value2);
		return value2;
	}

	public bool HasValidMoveAnimConfig(EMoveSpeedLevel SpeedLevel, bool bLockMove)
	{
		bool flag = false;
		if (ABPSettingData == null)
		{
			return false;
		}
		EABPMoveMode eABPMoveMode = ABPSettingData.CommonSetting.ABPMoveMode;
		if (eABPMoveMode == EABPMoveMode.MotionMatching)
		{
			flag = HasValidMoveAnimConfig_MotionMatching(bLockMove);
			if (flag)
			{
				return true;
			}
			eABPMoveMode = ABPSettingData.MotionMatchingSetting.SpareMoveMode;
		}
		switch (eABPMoveMode)
		{
		case EABPMoveMode.Locomotion_Simple4Dir:
			flag = HasValidMoveAnimConfig_Simple4Dir(SpeedLevel, bLockMove);
			break;
		case EABPMoveMode.MonsterLocomotion:
			flag = HasValidMoveAnimConfig_MonsterLocomotion(bLockMove);
			break;
		case EABPMoveMode.AdvancedMonsterLocomotion:
			flag = HasValidMoveAnimConfig_AdvancedMonsterLocomotion(SpeedLevel, bLockMove);
			break;
		}
		return flag;
	}

	private bool HasValidMoveAnimConfig_MotionMatching(bool bLockMove)
	{
		return ABPSettingData.MotionMatchingSetting.MMState2AACS.ContainsKey(bLockMove ? EState_MM.Lock : EState_MM.Free);
	}

	private bool HasValidMoveAnimConfig_Simple4Dir(EMoveSpeedLevel SpeedLevel, bool bLockMove)
	{
		switch (SpeedLevel)
		{
		case EMoveSpeedLevel.Sprint:
			return ABPSettingData.Simple4DirSetting.BSSprint != null;
		case EMoveSpeedLevel.Walk:
			if (bLockMove)
			{
				if (ABPSettingData.Simple4DirSetting.BSWalkFwd != null && ABPSettingData.Simple4DirSetting.BSWalkBwd != null && ABPSettingData.Simple4DirSetting.BSWalkLeft != null)
				{
					return ABPSettingData.Simple4DirSetting.BSWalkRight != null;
				}
				return false;
			}
			return ABPSettingData.Simple4DirSetting.BSWalkFwd != null;
		default:
			if (bLockMove)
			{
				if (ABPSettingData.Simple4DirSetting.BSRunFwd != null && ABPSettingData.Simple4DirSetting.BSRunBwd != null && ABPSettingData.Simple4DirSetting.BSRunLeft != null)
				{
					return ABPSettingData.Simple4DirSetting.BSRunRight != null;
				}
				return false;
			}
			return ABPSettingData.Simple4DirSetting.BSRunFwd != null;
		}
	}

	private bool HasValidMoveAnimConfig_MonsterLocomotion(bool bLockMove)
	{
		if (bLockMove)
		{
			if (ABPSettingData.MonsterLocomotionSetting.Lock.ASLockWalkFwd != null && ABPSettingData.MonsterLocomotionSetting.Lock.ASLockWalkBwd != null && ABPSettingData.MonsterLocomotionSetting.Lock.ASLockWalkFL != null && ABPSettingData.MonsterLocomotionSetting.Lock.ASLockWalkFR != null && ABPSettingData.MonsterLocomotionSetting.Lock.ASLockWalkBL != null)
			{
				return ABPSettingData.MonsterLocomotionSetting.Lock.ASLockWalkBR != null;
			}
			return false;
		}
		return ABPSettingData.MonsterLocomotionSetting.Free.ASFreeRunFwd != null;
	}

	private bool HasValidMoveAnimConfig_AdvancedMonsterLocomotion(EMoveSpeedLevel SpeedLevel, bool bLockMove)
	{
		bool flag = false;
		switch (SpeedLevel)
		{
		case EMoveSpeedLevel.Walk:
			flag = ABPSettingData.AdvancedMonsterLocomotionSetting.ASWalkStartFwd != null && ABPSettingData.AdvancedMonsterLocomotionSetting.ASWalkLoopFwd != null && ABPSettingData.AdvancedMonsterLocomotionSetting.ASWalkStopFwd != null;
			if (bLockMove)
			{
				flag = flag && ABPSettingData.AdvancedMonsterLocomotionSetting.ASWalkStartBwd != null && ABPSettingData.AdvancedMonsterLocomotionSetting.ASWalkLoopBwd != null && ABPSettingData.AdvancedMonsterLocomotionSetting.ASWalkStopBwd != null;
			}
			break;
		case EMoveSpeedLevel.Run:
			flag = ABPSettingData.AdvancedMonsterLocomotionSetting.ASRunStartFwd != null && ABPSettingData.AdvancedMonsterLocomotionSetting.ASRunLoopFwd != null && ABPSettingData.AdvancedMonsterLocomotionSetting.ASRunStopFwd != null;
			if (bLockMove)
			{
				flag = flag && ABPSettingData.AdvancedMonsterLocomotionSetting.ASRunStartBwd != null && ABPSettingData.AdvancedMonsterLocomotionSetting.ASRunLoopBwd != null && ABPSettingData.AdvancedMonsterLocomotionSetting.ASRunStopBwd != null;
			}
			break;
		case EMoveSpeedLevel.Sprint:
			flag = ABPSettingData.AdvancedMonsterLocomotionSetting.ASRushStartFwd != null && ABPSettingData.AdvancedMonsterLocomotionSetting.ASRushLoopFwd != null && ABPSettingData.AdvancedMonsterLocomotionSetting.ASRushStopFwd != null;
			if (bLockMove)
			{
				flag = false;
			}
			break;
		}
		return flag;
	}

	bool IBUC_ABPHelperData.GetFloatAnimCurveValue(in FName CurveName, out float OutCurveValue)
	{
		return GetFloatAnimCurveValue(in CurveName, out OutCurveValue);
	}

	float IBUC_ABPHelperData.GetStateMachineWeight(in FName StateMachineName, in FName StateName)
	{
		return GetStateMachineWeight(in StateMachineName, in StateName);
	}
}
