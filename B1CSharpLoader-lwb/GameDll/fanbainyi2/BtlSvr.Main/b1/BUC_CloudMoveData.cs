using System;
using System.Collections.Generic;
using b1.BGW;
using b1.Plugins.AkAudio;
using BtlB1;
using GUR.Runtime;
using UnrealEngine.Runtime;

namespace b1;

public class BUC_CloudMoveData : IBUC_CloudMoveData
{
	public BGW_PreloadAssetMgr PreloadAssetMgr;

	private List<int> _CloudSkillList_Ride;

	private List<int> _CloudSkillList_GetOff;

	public bool CloudMoveSkillCasted;

	public int ForbidEnableCloudMoveCount;

	public int ForbidDisableCloudMoveCount;

	public bool IsGettingOffCloud;

	public uint MovementModeHandleID;

	public uint CapsuleCollisionProfileHandleID;

	public BGULandscapeReaderActor HeightLimitLandscapeReaderActor;

	public bool RushEffectEnabled;

	public int RequestIdCloudEffectDBC = -1;

	public Dictionary<string, int> CloudMoveCVarHandles = new Dictionary<string, int>();

	public float CloudSkillCooldownTime = -1f;

	public float AutoMoveAcceptRadius;

	private TStrongObjectPtr<UAkComponent> mCloudAkComp = new TStrongObjectPtr<UAkComponent>();

	public bool bIsPlayingCloudAudio;

	public float NewEffectIntervalTime;

	public int LineTraceReqID = -1;

	public int CurrentGroundEffectReqID = -1;

	public ESceneItemSurfaceType CurrentSurfaceType;

	public uint EnableIKHandleID;

	private bool __IsCloudMoveEnabled_Raw;

	public BGWDataAsset_CloudMoveConfig CloudMoveConfig => PreloadAssetMgr.CloudMoveConfig;

	public List<int> CloudSkillList_Ride
	{
		get
		{
			if (_CloudSkillList_Ride == null)
			{
				_CloudSkillList_Ride = CloudMoveConfig.GetRideSkills();
			}
			return _CloudSkillList_Ride;
		}
	}

	public List<int> CloudSkillList_GetOff
	{
		get
		{
			if (_CloudSkillList_GetOff == null)
			{
				_CloudSkillList_GetOff = CloudMoveConfig.GetGetOffSkills();
			}
			return _CloudSkillList_GetOff;
		}
	}

	public bool DisableHeightLimitIfNoInput => CloudMoveConfig.DisableHeightLimitIfNoInput;

	public int CloudMoveItemId => CloudMoveConfig.CloudMoveItemId;

	public bool ForbidEnableCloudMove { get; set; }

	public bool ForbidDisableCloudMove { get; set; }

	[NeedToUI]
	public bool IsCloudMoveEnabled
	{
		get
		{
			return __IsCloudMoveEnabled_Raw;
		}
		set
		{
			bool _IsCloudMoveEnabled_Raw = __IsCloudMoveEnabled_Raw;
			__IsCloudMoveEnabled_Raw = value;
			OnIsCloudMoveEnabledChg_Invoke(_IsCloudMoveEnabled_Raw, value);
		}
	}

	public float CurrentPositionHeightLimit { get; set; }

	public bool bCloudFall { get; set; }

	public bool bIsCloudFallInLowAirArea { get; set; }

	public int CloudBreakAnimId { get; set; }

	public bool bIsAutoCloudMoveEnabled { get; set; }

	public FVector AutoMoveTargetLocation { get; set; }

	public UAkComponent CloudAkComp
	{
		get
		{
			return mCloudAkComp.Get();
		}
		set
		{
			mCloudAkComp.Set(value);
		}
	}

	public event Action<bool, bool> OnIsCloudMoveEnabledChg;

	private void OnIsCloudMoveEnabledChg_Invoke(bool OldValue, bool NewValue)
	{
		if (!NewValue.Equals(OldValue))
		{
			this.OnIsCloudMoveEnabledChg?.Invoke(OldValue, NewValue);
		}
	}
}
