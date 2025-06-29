using System;
using b1.EventDelDefine;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

internal class BUS_RootMotionFollowComp : UActorCompBaseCS
{
	private b1.BUC_RootMotionFollowData FollowData;

	private IBUC_UnitStateData UnitStateData;

	private IBUC_SimpleStateData SimpleStateData;

	private IBUC_PatrolData PatrolData;

	private IBUC_PropMgrData PropMgrData;

	private IBUC_ABPCommonSettingData CommonData;

	private bool bSimulatedProxy;

	public override void OnAttach()
	{
		FollowData = RequireWritableData<b1.BUC_RootMotionFollowData>();
		UnitStateData = RequireReadOnlyData<IBUC_UnitStateData, BUC_UnitStateData>();
		SimpleStateData = RequireReadOnlyData<IBUC_SimpleStateData, BUC_SimpleStateData>();
		PatrolData = RequireReadOnlyData<IBUC_PatrolData, BUC_PatrolData>();
		PropMgrData = RequireReadOnlyData<IBUC_PropMgrData, BUC_PropMgrData>();
		CommonData = RequireReadOnlyData<IBUC_ABPCommonSettingData, BUC_ABPCommonSettingData>();
		base.BUSEventCollection.Evt_SetRootMotionFollowState += new Del_Void_Bool(SetRootMotionFollowState);
	}

	public override void OnBeginPlay()
	{
		b1.BGU_Timeline interpTransformTL = FollowData.InterpTransformTL;
		interpTransformTL.TimelineInterpFunc = (b1.BGU_Timeline.Del_Void_Float)Delegate.Combine(interpTransformTL.TimelineInterpFunc, new b1.BGU_Timeline.Del_Void_Float(InterpCapsuleToAnimTransform));
		b1.BGU_Timeline interpTransformTL2 = FollowData.InterpTransformTL;
		interpTransformTL2.TimelineFinishedFunc = (b1.BGU_Timeline.Del_Void)Delegate.Combine(interpTransformTL2.TimelineFinishedFunc, new b1.BGU_Timeline.Del_Void(FinishedInterpCapsuleToAnim));
		FollowData.DefaultTransform = (GetOwner() as ACharacter).Mesh.GetRelativeTransform();
		if (!UGSE_EngineFuncLib.IsStandAlone(GetOwner().World) && GetOwner().GetLocalRole() == ENetRole.ROLE_SimulatedProxy)
		{
			bSimulatedProxy = true;
		}
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		UpdateRootMotionFollowState();
		FollowData.InterpTransformTL.TickTimeline(DeltaTime);
	}

	private void UpdateRootMotionFollowState()
	{
		bool flag = false;
		if (bSimulatedProxy)
		{
			flag = true;
		}
		if (PatrolData.bIsPatroling)
		{
			flag = true;
		}
		if (!flag)
		{
			SetRootMotionFollowState(bEnable: false);
			return;
		}
		bool flag2 = false;
		if (UnitStateData.HasState(EBGUUnitState.Attacking) && !UnitStateData.HasState(EBGUUnitState.AttackMoving))
		{
			flag2 = true;
		}
		if (UnitStateData.HasState(EBGUUnitState.Beatback))
		{
			flag2 = true;
		}
		if (SimpleStateData.HasSimpleState(EBGUSimpleState.Immobilizing))
		{
			flag2 = true;
		}
		bool rootMotionFollowState = CommonData.FinalABPMoveMode == EABPMoveMode.MotionMatching && !flag2;
		SetRootMotionFollowState(rootMotionFollowState);
	}

	public void SetRootMotionFollowState(bool bEnable)
	{
		BGUCharacterCS bGUCharacterCS = GetOwner() as BGUCharacterCS;
		if (bGUCharacterCS == null)
		{
			return;
		}
		UBGUCharacterMovementComponent uBGUCharacterMovementComponent = bGUCharacterCS.CharacterMovement as UBGUCharacterMovementComponent;
		if (uBGUCharacterMovementComponent == null || uBGUCharacterMovementComponent.IsInFollowState == bEnable || bGUCharacterCS.AnimMoveComp.IsNullOrDestroyed() || bGUCharacterCS.AnimCapsule.IsNullOrDestroyed())
		{
			return;
		}
		bGUCharacterCS.AnimMoveComp.SetActive(bEnable);
		ECollisionEnabled collisionEnabled = (bEnable ? ECollisionEnabled.QueryAndPhysics : ECollisionEnabled.NoCollision);
		bGUCharacterCS.AnimCapsule.SetCollisionEnabled(collisionEnabled);
		uBGUCharacterMovementComponent.IsInFollowState = bEnable;
		UCapsuleComponent uCapsuleComponent = (bEnable ? bGUCharacterCS.AnimCapsule : bGUCharacterCS.CapsuleComponent);
		if (bEnable)
		{
			UGSE_AnimFuncLib.SetRootMotionFromEverythingSwitch(bGUCharacterCS, IsOpen: false);
			if (bGUCharacterCS.Mesh.GetAttachParent() != uCapsuleComponent)
			{
				bGUCharacterCS.Mesh.AttachToComponent(uCapsuleComponent, FName.None, EAttachmentRule.KeepWorld, EAttachmentRule.KeepWorld, EAttachmentRule.KeepWorld, bWeldSimulatedBodies: true);
			}
			bGUCharacterCS.AnimCapsule.DetachFromComponent(EDetachmentRule.KeepWorld, EDetachmentRule.KeepWorld, EDetachmentRule.KeepWorld);
			FollowData.InterpTransformTL.Stop();
			UBGUFuncLibMove.BGUMovementForceSaveBaseLocation(bGUCharacterCS.AnimMoveComp);
			FRotator Value = new FRotator(0.0, FollowData.FollowStateRotationRate, 0.0);
			if ((float)FollowData.MovingRotationRateHandleID == 0f)
			{
				base.BUSEventCollection.Evt_SetRotatorProperty.Invoke(EPropType.Movement_RotationRate, in Value);
				FollowData.MovingRotationRateHandleID = PropMgrData.GetLastHandleID();
			}
			else
			{
				base.BUSEventCollection.Evt_SetRotatorProperty.Invoke(EPropType.Movement_RotationRate, in Value, FollowData.MovingRotationRateHandleID);
			}
		}
		else
		{
			FollowData.InterpTransformTL.PlayFromStart();
			base.BUSEventCollection.Evt_ResetProperty.Invoke(FollowData.MovingRotationRateHandleID);
			FollowData.MovingRotationRateHandleID = 0u;
		}
	}

	protected void InterpCapsuleToAnimTransform(float Delta)
	{
		float interpSpeed = 1f / FollowData.InterpTime;
		BGUCharacterCS bGUCharacterCS = GetOwner() as BGUCharacterCS;
		if (bGUCharacterCS != null && bGUCharacterCS.AnimCapsule != null)
		{
			FTransform worldTransform = bGUCharacterCS.CapsuleComponent.GetWorldTransform();
			FTransform worldTransform2 = bGUCharacterCS.AnimCapsule.GetWorldTransform();
			FVector translation = FMath.VInterpTo(worldTransform2.GetLocation(), worldTransform.GetLocation(), Delta, interpSpeed);
			FQuat rotation = FMath.QInterpTo(worldTransform2.GetRotation(), worldTransform.GetRotation(), Delta, interpSpeed);
			FTransform newTransform = new FTransform(rotation, translation, worldTransform.GetScale3D());
			bGUCharacterCS.AnimCapsule.SetWorldTransform(newTransform, bSweep: true, out var _, bTeleport: true);
		}
	}

	protected void FinishedInterpCapsuleToAnim()
	{
		BGUCharacterCS bGUCharacterCS = GetOwner() as BGUCharacterCS;
		if (bGUCharacterCS != null && bGUCharacterCS.AnimCapsule != null)
		{
			bGUCharacterCS.Mesh.AttachToComponent(bGUCharacterCS.CapsuleComponent, FName.None, EAttachmentRule.KeepWorld, EAttachmentRule.KeepWorld, EAttachmentRule.KeepWorld, bWeldSimulatedBodies: false);
			bGUCharacterCS.Mesh.SetRelativeTransform(FollowData.DefaultTransform, bSweep: false, out var _, bTeleport: false);
			bGUCharacterCS.AnimCapsule.AttachToComponent(bGUCharacterCS.CapsuleComponent, FName.None, EAttachmentRule.SnapToTarget, EAttachmentRule.SnapToTarget, EAttachmentRule.SnapToTarget, bWeldSimulatedBodies: true);
		}
	}
}
