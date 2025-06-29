using b1.BGW;
using b1.EventDelDefine;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
internal class BUS_StateLibComp : UActorCompBaseCS
{
	public enum StateType
	{
		None = 0,
		TurnSkill = 1,
		ArmorSetting = 2,
		Speed = 4,
		ABPSetting = 8,
		BeAttackedInfo = 0x10,
		DeadInfoID = 0x40,
		MovementMode = 0x80,
		PartRule = 0x100,
		DodgeSkill = 0x200,
		AMScaleMaxRate = 0x400,
		SpecialBoneSetting = 0x800,
		PortionPACollisionEnable = 0x1000,
		DisableHitMoveCollision = 0x2000
	}

	private uint MovementModeHandleID;

	private IBUC_PropMgrData PropMgrData;

	private BUC_StateLibData StateLibData;

	public override void OnAttach()
	{
		PropMgrData = RequireReadOnlyData<IBUC_PropMgrData, BUC_PropMgrData>();
		StateLibData = RequireWritableData<BUC_StateLibData>();
		base.BUSEventCollection.Evt_SwitchStateLib += new Del_SwitchStateLib(OnSwitchStateLib);
		base.BUSEventCollection.Evt_ResetStateLib += new Del_ResetStateLib(OnResetStateLib);
		base.BUSEventCollection.Evt_ResetActorStatusAfterAll += new Del_Void_ResetActorReason(OnResetActorStatusAfterAll);
		base.BUSEventCollection.Evt_ResetStateLibAll += new Del_Void(OnResetStateLibAll);
	}

	public override void OnBeginPlay()
	{
	}

	private void OnSwitchStateLib(string DataAssetPath, int TypesToApply, StateLibSwitchType SwitchType)
	{
		AActor owner = GetOwner();
		if (owner == null)
		{
			return;
		}
		BGWDataAsset_StateLib bGWDataAsset_StateLib = BGW_PreloadAssetMgr.Get(owner).TryGetCachedResourceObj<BGWDataAsset_StateLib>(DataAssetPath, ELoadResourceType.SyncLoadAndCache);
		if (!(bGWDataAsset_StateLib == null))
		{
			switch (SwitchType)
			{
			case StateLibSwitchType.Mod:
			{
				StateLibData data2 = StateLibData.UpdateMod(bGWDataAsset_StateLib, TypesToApply);
				ApplyStateTypes(data2);
				break;
			}
			case StateLibSwitchType.Base:
			{
				StateLibData data = StateLibData.UpdateBase(bGWDataAsset_StateLib, TypesToApply);
				ApplyStateTypes(data);
				break;
			}
			}
		}
	}

	private void OnResetStateLib(int TypesToReset, StateLibSwitchType SwitchType)
	{
		if (!(base.BUSEventCollection == null) && SwitchType != StateLibSwitchType.Base)
		{
			StateLibData.ClearMod();
			StateLibData data = StateLibData.GetBase();
			if (data.bIsValid)
			{
				ApplyStateTypes(data, TypesToReset);
			}
			else
			{
				OnResetStateTypes(TypesToReset);
			}
		}
	}

	private void ApplyStateTypes(StateLibData Data, int TypesToApply = -1)
	{
		if (base.BUSEventCollection == null)
		{
			return;
		}
		BGWDataAsset_StateLib stateLibDA = Data.StateLibDA;
		if (TypesToApply == -1)
		{
			TypesToApply = Data.TypesToApply;
		}
		int num = TypesToApply;
		if ((num & 1) > 0)
		{
			base.BUSEventCollection.Evt_SetNewTurnSkillID.Invoke(TurnSkillType.LeftSmall, stateLibDA.LeftSmallTurnSkillID);
			base.BUSEventCollection.Evt_SetNewTurnSkillID.Invoke(TurnSkillType.RightSmall, stateLibDA.RightSmallTurnSkillID);
			base.BUSEventCollection.Evt_SetNewTurnSkillID.Invoke(TurnSkillType.LeftBig, stateLibDA.LeftBigTurnSkillID);
			base.BUSEventCollection.Evt_SetNewTurnSkillID.Invoke(TurnSkillType.RightBig, stateLibDA.RightBigTurnSkillID);
		}
		if ((num & 2) > 0)
		{
			base.BUSEventCollection.Evt_OverrideArmorSetting.Invoke(stateLibDA.ArmorSetting);
		}
		if ((num & 4) > 0)
		{
			base.BUSEventCollection.Evt_UpdateSpeedCtrlInfoBaseBySpdInfo.Invoke(stateLibDA.MoveSpeedFast, stateLibDA.MoveSpeedNormal, stateLibDA.MoveSpeedSlow);
		}
		if ((num & 8) > 0 && stateLibDA.ABPSetting != null)
		{
			base.BUSEventCollection.Evt_ChangeABPSetting.Invoke(stateLibDA.ABPSetting);
		}
		if ((num & 0x10) > 0)
		{
			base.BUSEventCollection.Evt_SetNewBeAttackedInfoID.Invoke(stateLibDA.BeAttackedInfoID);
		}
		if ((num & 0x40) > 0)
		{
			base.BUSEventCollection.Evt_SetDeadInfoID.Invoke(stateLibDA.DeadInfoID);
		}
		if ((num & 0x80) > 0)
		{
			if (MovementModeHandleID == 0)
			{
				base.BUSEventCollection.Evt_SetEnumProperty.Invoke(EPropType.Movement_MovementMode, (int)stateLibDA.MovementMode, 0u, 0u, bSetDefaultProperty: false, "StateLibComp");
				MovementModeHandleID = PropMgrData.GetLastHandleID();
			}
			else
			{
				base.BUSEventCollection.Evt_SetEnumProperty.Invoke(EPropType.Movement_MovementMode, (int)stateLibDA.MovementMode, MovementModeHandleID, 0u, bSetDefaultProperty: false, "StateLibComp");
			}
		}
		if ((num & 0x100) > 0)
		{
			base.BUSEventCollection.Evt_SetPartRuleID.Invoke(stateLibDA.PartRuleID, P2: false);
		}
		if ((num & 0x200) > 0)
		{
			base.BUSEventCollection.Evt_ChangeDodgeSkill.Invoke(stateLibDA.DodgeSkillID, stateLibDA.PreciseDodgeSkillID);
		}
		if ((num & 0x400) > 0)
		{
			base.BUSEventCollection.Evt_SetAMScaleMaxRate.Invoke(stateLibDA.AMScaleMaxRate);
		}
		if ((num & 0x800) > 0)
		{
			base.BUSEventCollection.Evt_SetSpecialBoneList.Invoke(stateLibDA.SpecialBoneConfig);
		}
		if ((num & 0x1000) > 0)
		{
			base.BUSEventCollection.Evt_OnSetBodiesCollisionEnable.Invoke(stateLibDA.BodiesNameList_BodiesCollisionEnable.ToList(), stateLibDA.bEnable_BodiesCollisionEnable);
		}
		if ((num & 0x2000) > 0)
		{
			base.BUSEventCollection.Evt_ResetHitMoveCollisionInfo.Invoke(stateLibDA.DefaultDisabledHitMoveCollisions.ToList());
		}
	}

	private void OnResetStateTypes(int TypesToReset)
	{
		if (!(base.BUSEventCollection == null))
		{
			if ((TypesToReset & 1) > 0)
			{
				base.BUSEventCollection.Evt_ResetAllTurnSkillIDs.Invoke();
			}
			if ((TypesToReset & 2) > 0)
			{
				base.BUSEventCollection.Evt_ResetArmorSetting.Invoke();
			}
			if ((TypesToReset & 4) > 0)
			{
				base.BUSEventCollection.Evt_ResetSpeedCtrlInfo.Invoke();
			}
			if ((TypesToReset & 8) > 0)
			{
				base.BUSEventCollection.Evt_ResetABPSetting.Invoke();
			}
			if ((TypesToReset & 0x10) > 0)
			{
				base.BUSEventCollection.Evt_ResetBeAttackedInfoID.Invoke();
			}
			if ((TypesToReset & 0x40) > 0)
			{
				base.BUSEventCollection.Evt_ResetDeadInfoID.Invoke();
			}
			if ((TypesToReset & 0x80) > 0)
			{
				base.BUSEventCollection.Evt_ResetProperty.Invoke(MovementModeHandleID);
				MovementModeHandleID = 0u;
			}
			if ((TypesToReset & 0x100) > 0)
			{
				base.BUSEventCollection.Evt_ResetPartRuleID.Invoke();
			}
			if ((TypesToReset & 0x200) > 0)
			{
				base.BUSEventCollection.Evt_ResetDodgeSkill.Invoke();
			}
			if ((TypesToReset & 0x400) > 0)
			{
				base.BUSEventCollection.Evt_SetAMScaleMaxRate.Invoke(0f);
			}
			if ((TypesToReset & 0x800) > 0)
			{
				base.BUSEventCollection.Evt_ResetSpecialBoneList.Invoke();
			}
			if ((TypesToReset & 0x1000) > 0)
			{
				base.BUSEventCollection.Evt_ResetBodiesCollisionEnable.Invoke();
			}
		}
	}

	private void OnResetStateLibAll()
	{
		if (!(base.BUSEventCollection == null))
		{
			base.BUSEventCollection.Evt_ResetAllTurnSkillIDs.Invoke();
			base.BUSEventCollection.Evt_ResetArmorSetting.Invoke();
			base.BUSEventCollection.Evt_ResetSpeedCtrlInfo.Invoke();
			base.BUSEventCollection.Evt_ResetABPSetting.Invoke();
			base.BUSEventCollection.Evt_ResetBeAttackedInfoID.Invoke();
			base.BUSEventCollection.Evt_ResetUnitCameraID.Invoke();
			base.BUSEventCollection.Evt_ResetDeadInfoID.Invoke();
			base.BUSEventCollection.Evt_ResetProperty.Invoke(MovementModeHandleID);
			MovementModeHandleID = 0u;
			base.BUSEventCollection.Evt_ResetPartRuleID.Invoke();
			base.BUSEventCollection.Evt_ResetDodgeSkill.Invoke();
			base.BUSEventCollection.Evt_SetAMScaleMaxRate.Invoke(0f);
			base.BUSEventCollection.Evt_ResetSpecialBoneList.Invoke();
			base.BUSEventCollection.Evt_ResetBodiesCollisionEnable.Invoke();
		}
	}

	private void OnResetActorStatusAfterAll(EResetActorReason ResetReason)
	{
		OnResetStateLibAll();
	}
}
