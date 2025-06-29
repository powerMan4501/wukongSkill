using System.Collections.Generic;
using b1.EventDelDefine;
using UnrealEngine.Engine;

namespace b1;

public class BUS_UnitStateSystem : UActorCompBaseCS
{
	protected BUC_UnitStateData UnitStateComp;

	protected BUC_SimpleStateData UnitSimpleStateComp;

	protected IBUC_PlayerCameraData CameraData;

	protected IBUC_MovementData MovementData;

	protected IBUC_TargetInfoData TargetInfoData;

	private static List<int> sLastTimeOutUnitStates = new List<int>();

	public override void OnAttach()
	{
		UnitStateComp = RequireWritableData<BUC_UnitStateData>();
		UnitSimpleStateComp = RequireWritableData<BUC_SimpleStateData>();
		CameraData = RequireReadOnlyData<IBUC_PlayerCameraData, BUC_PlayerCameraData>();
		MovementData = RequireReadOnlyData<IBUC_MovementData, BUC_MovementData>();
		TargetInfoData = RequireReadOnlyData<IBUC_TargetInfoData, BUC_TargetInfoData>();
		base.BUSEventCollection.Evt_UnitStateTrigger += new Del_UnitStateTrigger(OnUnitStateTrigger);
		base.BUSEventCollection.Evt_UnitStateTriggerCMultiCast += new Del_UnitStateTrigger(OnUnitStateTrigger);
		base.BUSEventCollection.Evt_UnitSetSimpleState += new Del_UnitSetSimpleState(OnUnitSimpleStateSet);
		base.BUSEventCollection.Evt_PauseUpdate += new Del_Void_Bool(OnPauseUpdate);
		base.BUSEventCollection.Evt_DoCheckUpdateSideWalkingState += new Del_Void(DoCheckUpdateSideWalkingState);
	}

	public override void OnBeginPlay()
	{
		if (DebugConfig.CancelSkillCD)
		{
			OnUnitSimpleStateSet(EBGUSimpleState.CancelSkillCD);
		}
	}

	public override bool AllowTRO()
	{
		return false;
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (UnitStateComp.bShouldUpdateStateTime && !UnitSimpleStateComp.HasSimpleState(EBGUSimpleState.Immobilizing) && !UnitSimpleStateComp.HasSimpleState(EBGUSimpleState.Frozen))
		{
			UnitStateComp.UpdateStateTime(DeltaTime);
			GCFriendlyListCopyHelper.DoCopy(UnitStateComp.GetLastTimeOutUnitStates().ValueList, sLastTimeOutUnitStates);
			for (int i = 0; i < sLastTimeOutUnitStates.Count; i++)
			{
				int num = sLastTimeOutUnitStates[i];
				OnUnitStateTimeOutRemoved((EBGUUnitState)num);
			}
		}
	}

	private void OnPauseUpdate(bool bShouldPause)
	{
		UnitStateComp.bShouldUpdateStateTime = !bShouldPause;
	}

	private void OnUnitSimpleStateSet(EBGUSimpleState SimpleState, bool IsRemove = false)
	{
		if (SimpleState == EBGUSimpleState.Normal || SimpleState == EBGUSimpleState.EnumMax)
		{
			return;
		}
		if (DebugConfig.CricketBattleMode)
		{
			_ = 1;
			if (CheckIsInCricketBlackList(SimpleState))
			{
				return;
			}
			BGWCricketMgrLogic.AddSimpleStateSetStr(SimpleState, IsRemove, GetOwner(), GetOwner().World.GetTimeSeconds());
		}
		if (IsRemove)
		{
			UnitSimpleStateComp.RemoveSimpleState(SimpleState);
		}
		else
		{
			UnitSimpleStateComp.SetSimpleState(SimpleState);
		}
		base.BUSEventCollection.Evt_UnitSimpleStateUpdated.Invoke(SimpleState, IsRemove);
	}

	private void OnUnitStateTimeOutRemoved(EBGUUnitState State)
	{
		if (State - 16 <= EBGUUnitState.Attacking)
		{
			DoCheckUpdateSideWalkingState();
		}
	}

	private void OnUnitStateTrigger(EBUStateTrigger Trigger, float Time, bool NeedForceUpdate = false)
	{
		switch (Trigger)
		{
		case EBUStateTrigger.AttackStateBegin:
			NetSetState(EBGUUnitState.Attacking, NeedForceUpdate, Time);
			RemoveNetState(EBGUUnitState.Beatback);
			RemoveNetState(EBGUUnitState.FloatingHit);
			break;
		case EBUStateTrigger.AttackRotationBegin:
			NetSetState(EBGUUnitState.AttackRotation, NeedForceUpdate, Time);
			break;
		case EBUStateTrigger.Die:
			NetSetState(EBGUUnitState.Dead, NeedForceUpdate);
			RemoveNetState(EBGUUnitState.Beatback);
			RemoveNetState(EBGUUnitState.BlockBeatBack);
			RemoveNetState(EBGUUnitState.PerfectBlockBeatBack);
			RemoveNetState(EBGUUnitState.BlockBounced);
			RemoveNetState(EBGUUnitState.FloatingHit);
			SolveLeaveSkillMontage();
			break;
		case EBUStateTrigger.CastSkillSuccess:
			RemoveNetState(EBGUUnitState.InComboWindow);
			RemoveNetState(EBGUUnitState.InDodgeWindow);
			RemoveNetState(EBGUUnitState.InMagicWindow);
			RemoveNetState(EBGUUnitState.InVigorWindow);
			RemoveNetState(EBGUUnitState.InMoveWindow);
			RemoveNetState(EBGUUnitState.InCloudWindow);
			RemoveNetState(EBGUUnitState.InItemSkillWindow);
			RemoveNetState(EBGUUnitState.AtkComboKeyCache);
			RemoveNetState(EBGUUnitState.DodgeComboKeyCache);
			RemoveNetState(EBGUUnitState.MagicKeyCache);
			RemoveNetState(EBGUUnitState.VigorKeyCache);
			RemoveNetState(EBGUUnitState.ItemSkillKeyCache);
			break;
		case EBUStateTrigger.Rebirth:
			RemoveNetState(EBGUUnitState.Dead);
			RemoveNetState(EBGUUnitState.Beatback);
			RemoveNetState(EBGUUnitState.BlockBeatBack);
			RemoveNetState(EBGUUnitState.PerfectBlockBeatBack);
			RemoveNetState(EBGUUnitState.BlockBounced);
			RemoveNetState(EBGUUnitState.FloatingHit);
			SolveLeaveSkillMontage();
			break;
		case EBUStateTrigger.SkillBreak:
			SolveLeaveSkillMontage();
			break;
		case EBUStateTrigger.Beatback:
			NetSetState(EBGUUnitState.Beatback, NeedForceUpdate, Time);
			SolveLeaveSkillMontage();
			break;
		case EBUStateTrigger.EnterBlockBeatBack:
			NetSetState(EBGUUnitState.BlockBeatBack, NeedForceUpdate, Time);
			SolveLeaveSkillMontage();
			break;
		case EBUStateTrigger.EnterPerfectBlockBeatBack:
			NetSetState(EBGUUnitState.PerfectBlockBeatBack, NeedForceUpdate, Time);
			SolveLeaveSkillMontage();
			break;
		case EBUStateTrigger.EnterBlockBounced:
			NetSetState(EBGUUnitState.BlockBounced, NeedForceUpdate, Time);
			SolveLeaveSkillMontage();
			break;
		case EBUStateTrigger.LeaveAllBlockState:
			SolveLeaveBlockState();
			break;
		case EBUStateTrigger.AtkRebounding:
			SolveLeaveSkillMontage();
			break;
		case EBUStateTrigger.EnableMoveInSkill:
			NetSetState(EBGUUnitState.AttackMoving, NeedForceUpdate, Time);
			break;
		case EBUStateTrigger.EnterAtkComboKeyCache:
			NetSetState(EBGUUnitState.AtkComboKeyCache, NeedForceUpdate, Time);
			break;
		case EBUStateTrigger.EnterDodgeComboKeyCache:
			NetSetState(EBGUUnitState.DodgeComboKeyCache, NeedForceUpdate, Time);
			break;
		case EBUStateTrigger.EnterMagicKeyCache:
			NetSetState(EBGUUnitState.MagicKeyCache, NeedForceUpdate, Time);
			break;
		case EBUStateTrigger.EnterComboWindow:
			NetSetState(EBGUUnitState.InComboWindow, NeedForceUpdate, Time);
			break;
		case EBUStateTrigger.EnterAbortWindow:
			NetSetState(EBGUUnitState.InAbortWindow, NeedForceUpdate, Time);
			break;
		case EBUStateTrigger.EnterDodgeWindow:
			NetSetState(EBGUUnitState.InDodgeWindow, NeedForceUpdate, Time);
			RemoveNetState(EBGUUnitState.DodgeComboKeyCache);
			break;
		case EBUStateTrigger.EnterMagicWindow:
			NetSetState(EBGUUnitState.InMagicWindow, NeedForceUpdate, Time);
			RemoveNetState(EBGUUnitState.MagicKeyCache);
			break;
		case EBUStateTrigger.EnterMoveWindow:
			NetSetState(EBGUUnitState.InMoveWindow, NeedForceUpdate, Time);
			break;
		case EBUStateTrigger.EnterVigorKeyCache:
			NetSetState(EBGUUnitState.VigorKeyCache, NeedForceUpdate, Time);
			break;
		case EBUStateTrigger.EnterVigorWindow:
			NetSetState(EBGUUnitState.InVigorWindow, NeedForceUpdate, Time);
			RemoveNetState(EBGUUnitState.VigorKeyCache);
			break;
		case EBUStateTrigger.EnterItemSkillKeyCache:
			NetSetState(EBGUUnitState.ItemSkillKeyCache, NeedForceUpdate, Time);
			break;
		case EBUStateTrigger.EnterItemSkillWindow:
			NetSetState(EBGUUnitState.InItemSkillWindow, NeedForceUpdate, Time);
			RemoveNetState(EBGUUnitState.ItemSkillKeyCache);
			break;
		case EBUStateTrigger.HRCounterattackBegin:
			NetSetState(EBGUUnitState.HRCounterattacking, NeedForceUpdate, Time);
			break;
		case EBUStateTrigger.BMMoveAttackTrigger:
			NetSetState(EBGUUnitState.BMMoveAttack, NeedForceUpdate, Time);
			break;
		case EBUStateTrigger.BMMoveAttackClear:
			RemoveNetState(EBGUUnitState.BMMoveAttack);
			break;
		case EBUStateTrigger.AttackAlignUpperBodyToSlopeBegin:
			NetSetState(EBGUUnitState.AttackAlignUpperBodyToSlope, NeedForceUpdate, Time);
			break;
		case EBUStateTrigger.AttackAlignWholeBodyToSlopeBegin:
			NetSetState(EBGUUnitState.AttackAlignWholeBodyToSlope, NeedForceUpdate, Time);
			break;
		case EBUStateTrigger.JumpMovingStart:
			NetSetState(EBGUUnitState.JumpMoving, NeedForceUpdate, Time);
			break;
		case EBUStateTrigger.JumpMovingStop:
			RemoveNetState(EBGUUnitState.JumpMoving);
			break;
		case EBUStateTrigger.BeginFloatingHit:
			NetSetState(EBGUUnitState.FloatingHit, NeedForceUpdate, Time);
			break;
		case EBUStateTrigger.EndFloatingHit:
			RemoveNetState(EBGUUnitState.FloatingHit);
			break;
		case EBUStateTrigger.EnterGlideMove:
			NetSetState(EBGUUnitState.GlideMoving, NeedForceUpdate);
			break;
		case EBUStateTrigger.EndGlideMove:
			RemoveNetState(EBGUUnitState.GlideMoving);
			break;
		case EBUStateTrigger.FreezeAccProtectBegin:
			NetSetState(EBGUUnitState.FreezeAccProtect, NeedForceUpdate, Time);
			break;
		case EBUStateTrigger.EnableImpactAction:
			NetSetState(EBGUUnitState.ImpactActionPlaying, NeedForceUpdate, Time);
			break;
		case EBUStateTrigger.EnterBlindStiff:
			NetSetState(EBGUUnitState.BlindStiff, NeedForceUpdate, Time);
			break;
		case EBUStateTrigger.EnterAnimationSyncDeathWindow:
			NetSetState(EBGUUnitState.InAnimationSyncDeathWindow, NeedForceUpdate, Time);
			break;
		case EBUStateTrigger.StartJump:
			SolveLeaveSkillMontage();
			break;
		case EBUStateTrigger.StartMoveInMoveWindow:
			RemoveNetState(EBGUUnitState.Beatback);
			SolveLeaveSkillMontage();
			break;
		case EBUStateTrigger.EnterPhasePerformance:
			NetSetState(EBGUUnitState.PhasePerformance, NeedForceUpdate, Time);
			break;
		case EBUStateTrigger.ExitPhasePerformance:
			RemoveNetState(EBGUUnitState.PhasePerformance);
			break;
		case EBUStateTrigger.Enter_LifeSavingHair_FakeDead:
			NetSetState(EBGUUnitState.LifeSavingHair_FakeDead, NeedForceUpdate, Time);
			SolveLeaveSkillMontage();
			break;
		case EBUStateTrigger.Enter_LifeSavingHair_Rebirth:
			RemoveNetState(EBGUUnitState.LifeSavingHair_FakeDead);
			NetSetState(EBGUUnitState.LifeSavingHair_Rebirth, NeedForceUpdate, Time);
			break;
		case EBUStateTrigger.Exit_LifeSavingHair:
			RemoveNetState(EBGUUnitState.LifeSavingHair_FakeDead);
			RemoveNetState(EBGUUnitState.LifeSavingHair_Rebirth);
			break;
		case EBUStateTrigger.EnterLifeSavingHairBlocking:
			NetSetState(EBGUUnitState.LifeSavingHairBlocking, NeedForceUpdate, Time);
			break;
		case EBUStateTrigger.ExitLifeSavingHairBlocking:
			RemoveNetState(EBGUUnitState.LifeSavingHairBlocking);
			break;
		case EBUStateTrigger.EnterInteractWindow:
			NetSetState(EBGUUnitState.InInteractWindow, NeedForceUpdate, Time);
			break;
		case EBUStateTrigger.EnterCloudWindow:
			NetSetState(EBGUUnitState.InCloudWindow, NeedForceUpdate, Time);
			break;
		case EBUStateTrigger.EnterChapterClearWorkFlow:
			NetSetState(EBGUUnitState.InChapterClearWorkFlow, NeedForceUpdate, Time);
			break;
		case EBUStateTrigger.ExitChapterClearWorkFlow:
			RemoveNetState(EBGUUnitState.InChapterClearWorkFlow);
			break;
		}
		HandleUnitInputStates(Trigger, NeedForceUpdate, Time);
		base.BUSEventCollection.Evt_UnitStateUpdated.Invoke(Trigger);
	}

	private void HandleUnitInputStates(EBUStateTrigger Trigger, bool NeedForceUpdate, float Time)
	{
		switch (Trigger)
		{
		case EBUStateTrigger.BreakSprint:
			RemoveNetState(EBGUUnitState.Sprinting);
			break;
		case EBUStateTrigger.UnitInputWalkPressed:
			if (MovementData.bEnableWalk)
			{
				NetSetState(EBGUUnitState.Walking, NeedForceUpdate);
			}
			break;
		case EBUStateTrigger.UnitInputWalkRelease:
			RemoveNetState(EBGUUnitState.Walking);
			break;
		case EBUStateTrigger.UnitInputSprintPressed:
			NetSetState(EBGUUnitState.Sprinting, NeedForceUpdate);
			break;
		case EBUStateTrigger.UnitInputSprintRelease:
			RemoveNetState(EBGUUnitState.Sprinting);
			break;
		case EBUStateTrigger.ShooterModeTrigger:
			NetSetState(EBGUUnitState.ShooterMode, NeedForceUpdate, Time);
			break;
		case EBUStateTrigger.ShooterModeClear:
			RemoveNetState(EBGUUnitState.ShooterMode);
			break;
		case EBUStateTrigger.AIInputSprint:
			NetSetState(EBGUUnitState.Sprinting, NeedForceUpdate);
			RemoveNetState(EBGUUnitState.Walking);
			break;
		case EBUStateTrigger.AIInputRun:
			RemoveNetState(EBGUUnitState.Sprinting);
			RemoveNetState(EBGUUnitState.Walking);
			break;
		case EBUStateTrigger.AIInputWalk:
			if (MovementData.bEnableWalk)
			{
				NetSetState(EBGUUnitState.Walking, NeedForceUpdate);
			}
			RemoveNetState(EBGUUnitState.Sprinting);
			break;
		case EBUStateTrigger.TeleportBegin:
			NetSetState(EBGUUnitState.Teleporting, NeedForceUpdate);
			break;
		case EBUStateTrigger.TeleportEnd:
			RemoveNetState(EBGUUnitState.Teleporting);
			break;
		case EBUStateTrigger.EnterJumpWindow:
			NetSetState(EBGUUnitState.JumpWindow, NeedForceUpdate);
			break;
		case EBUStateTrigger.ExitJumpWindow:
			RemoveNetState(EBGUUnitState.JumpWindow);
			break;
		}
		DoCheckUpdateSideWalkingState();
	}

	private void DoCheckUpdateSideWalkingState()
	{
		bool flag = false;
		UnitLockTargetInfo targetInfo = TargetInfoData.GetTargetInfo();
		if (targetInfo != null && targetInfo.LockTargetActor != null && targetInfo.LockTargetWayType == ELockTargetWayType.Manual)
		{
			flag = true;
		}
		if (flag || UnitStateComp.HasState(EBGUUnitState.ShooterMode) || UnitStateComp.HasState(EBGUUnitState.BMMoveAttack) || (CameraData != null && CameraData.IsInG4Mode()))
		{
			if (UnitStateComp.HasState(EBGUUnitState.Sprinting))
			{
				RemoveNetState(EBGUUnitState.SideWalking);
			}
			else
			{
				NetSetState(EBGUUnitState.SideWalking, NeedForceUpdate: false);
			}
		}
		else
		{
			RemoveNetState(EBGUUnitState.SideWalking);
		}
	}

	private void SolveLeaveSkillMontage()
	{
		RemoveNetState(EBGUUnitState.Attacking);
		RemoveNetState(EBGUUnitState.AttackMoving);
		RemoveNetState(EBGUUnitState.AttackRotation);
		RemoveNetState(EBGUUnitState.InComboWindow);
		RemoveNetState(EBGUUnitState.InDodgeWindow);
		RemoveNetState(EBGUUnitState.InMagicWindow);
		RemoveNetState(EBGUUnitState.InVigorWindow);
		RemoveNetState(EBGUUnitState.InItemSkillWindow);
		RemoveNetState(EBGUUnitState.InMoveWindow);
		RemoveNetState(EBGUUnitState.InCloudWindow);
		RemoveNetState(EBGUUnitState.AtkComboKeyCache);
		RemoveNetState(EBGUUnitState.DodgeComboKeyCache);
		RemoveNetState(EBGUUnitState.MagicKeyCache);
		RemoveNetState(EBGUUnitState.VigorKeyCache);
		RemoveNetState(EBGUUnitState.ItemSkillKeyCache);
		RemoveNetState(EBGUUnitState.HRCounterattacking);
		RemoveNetState(EBGUUnitState.AttackAlignUpperBodyToSlope);
		RemoveNetState(EBGUUnitState.AttackAlignWholeBodyToSlope);
		RemoveNetState(EBGUUnitState.JumpWindow);
		RemoveNetState(EBGUUnitState.InInteractWindow);
	}

	private void SolveLeaveBlockState()
	{
		RemoveNetState(EBGUUnitState.BlockBeatBack);
		RemoveNetState(EBGUUnitState.PerfectBlockBeatBack);
		RemoveNetState(EBGUUnitState.BlockBounced);
		RemoveNetState(EBGUUnitState.Beatback);
	}

	private void NetSetState(EBGUUnitState UnitState, bool NeedForceUpdate, float Time = -1f)
	{
		UnitStateComp.SetState(UnitState, NeedForceUpdate, Time);
	}

	private void RemoveNetState(EBGUUnitState UnitState)
	{
		UnitStateComp.RemoveState(UnitState);
	}

	private bool CheckIsInCricketBlackList(EBGUSimpleState SimpleState)
	{
		BGUCharacterCS bGUCharacterCS = GetOwner() as BGUCharacterCS;
		if (bGUCharacterCS != null && bGUCharacterCS.IsPlayerCharacterCS())
		{
			return false;
		}
		if (SimpleState == EBGUSimpleState.CantBeDead || SimpleState == EBGUSimpleState.CantBeDead1HP || SimpleState == EBGUSimpleState.CantBeBaseTarget)
		{
			return true;
		}
		return false;
	}
}
