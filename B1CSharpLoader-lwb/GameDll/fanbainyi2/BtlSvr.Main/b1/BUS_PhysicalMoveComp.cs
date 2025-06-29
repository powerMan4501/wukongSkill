using System.Collections.Generic;
using b1.EventDelDefine;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

internal class BUS_PhysicalMoveComp : UActorCompBaseCS
{
	private IBUC_SimpleStateData SimpleStateData;

	private IBUC_UnitStateData UnitStateData;

	private b1.IBUC_PhysAnimData PhysAnimData;

	private IBUC_PropMgrData PropMgrData;

	private b1.BUC_PhysicalMoveData PhysicalMoveData;

	private FName PhysicalMovePawnPreset = B1GlobalFNames.PhysicalMovePawn;

	public override void OnAttach()
	{
		SimpleStateData = RequireReadOnlyData<IBUC_SimpleStateData, BUC_SimpleStateData>();
		UnitStateData = RequireReadOnlyData<IBUC_UnitStateData, BUC_UnitStateData>();
		PhysAnimData = RequireReadOnlyData<b1.IBUC_PhysAnimData, b1.BUC_PhysAnimData>();
		PropMgrData = RequireReadOnlyData<IBUC_PropMgrData, BUC_PropMgrData>();
		PhysicalMoveData = RequireWritableData<b1.BUC_PhysicalMoveData>();
		base.BUSEventCollection.Evt_UnitCastSkillSuccess += new Del_UnitCastSkillSuccess(OnCastSkillSuccess);
		base.BUSEventCollection.Evt_DisablePhysicalMove += new Del_Void_Bool(OnDisablePhysicalMove);
	}

	public override void OnBeginPlay()
	{
		if (PhysicalMoveData.bConfigEnablePhysicalMove && !PhysicalMoveData.bTempDisablePhysicalMove)
		{
			base.BUSEventCollection.Evt_UnitSetSimpleState.Invoke(EBGUSimpleState.PhysicsSimulationMoveMode);
		}
	}

	private void OnCastSkillSuccess(int MappingSkillID, int OriSkillID, ECastSkillSourceType SourceType)
	{
		bool flag = PhysicalMoveData.bSimulatePhysicsWhenAttacking || !UnitStateData.HasState(EBGUUnitState.Attacking);
		if (PhysAnimData.CurrentType == EPhysAnimType.PhysicsSimulationMove && (!SimpleStateData.HasSimpleState(EBGUSimpleState.PhysicsSimulationMoveMode) || !flag))
		{
			base.BUSEventCollection.Evt_ResetPhysicalAnim.Invoke();
			OnEndPhysisSimulationMove();
		}
	}

	public override int GetTickGroupMask()
	{
		return 8;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		bool bLoadThisTime;
		if (SimpleStateData.HasSimpleState(EBGUSimpleState.Immobilizing))
		{
			if (PhysAnimData.CurrentType == EPhysAnimType.PhysicsSimulationMove)
			{
				PhysicalMoveData.bPauseByImmobilize = true;
				PhysicalMoveData.PhysicalMoveVelocity = FVector.ZeroVector;
				if (OwnerAsCharacterCS != null && OwnerAsCharacterCS.Mesh != null)
				{
					b1.PhysMoveAnimSetting physMoveAnimSetting = PhysAnimData.TryGetSetting(EPhysAnimType.PhysicsSimulationMove, Owner, out bLoadThisTime) as b1.PhysMoveAnimSetting;
					PhysicalMoveData.LinearVelocityWhenImmobilize = OwnerAsCharacterCS.Mesh.GetPhysicsLinearVelocity(physMoveAnimSetting.BoneNameToSimulatePhysics);
					PhysicalMoveData.AngularVelocityWhenImmobilize = OwnerAsCharacterCS.Mesh.GetPhysicsAngularVelocityInRadians(physMoveAnimSetting.BoneNameToSimulatePhysics);
				}
				base.BUSEventCollection.Evt_SetLockPhysicalMoveSnapshot.Invoke(P1: true);
				base.BUSEventCollection.Evt_ResetPhysicalAnim.Invoke();
			}
			return;
		}
		bool flag = PhysicalMoveData.bSimulatePhysicsWhenAttacking || !UnitStateData.HasState(EBGUUnitState.Attacking);
		if (SimpleStateData.HasSimpleState(EBGUSimpleState.PhysicsSimulationMoveMode) && PhysAnimData.CurrentType != EPhysAnimType.PhysicsSimulationMove && flag)
		{
			base.BUSEventCollection.Evt_SetPhysAnimSetting.Invoke(EPhysAnimType.PhysicsSimulationMove);
			if (PhysicalMoveData.bPauseByImmobilize)
			{
				base.BUSEventCollection.Evt_SetLockPhysicalMoveSnapshot.Invoke(P1: false);
				PhysicalMoveData.bPauseByImmobilize = false;
				if (OwnerAsCharacterCS != null && OwnerAsCharacterCS.Mesh != null)
				{
					b1.PhysMoveAnimSetting physMoveAnimSetting2 = PhysAnimData.TryGetSetting(EPhysAnimType.PhysicsSimulationMove, Owner, out bLoadThisTime) as b1.PhysMoveAnimSetting;
					OwnerAsCharacterCS.Mesh.SetPhysicsLinearVelocity(PhysicalMoveData.LinearVelocityWhenImmobilize, bAddToCurrent: false, physMoveAnimSetting2.BoneNameToSimulatePhysics);
					OwnerAsCharacterCS.Mesh.SetPhysicsAngularVelocityInRadians(PhysicalMoveData.AngularVelocityWhenImmobilize, bAddToCurrent: false, physMoveAnimSetting2.BoneNameToSimulatePhysics);
				}
			}
			else
			{
				OnBeginPhysisSimulationMove();
			}
		}
		else if (PhysAnimData.CurrentType == EPhysAnimType.PhysicsSimulationMove && (!SimpleStateData.HasSimpleState(EBGUSimpleState.PhysicsSimulationMoveMode) || !flag))
		{
			base.BUSEventCollection.Evt_ResetPhysicalAnim.Invoke();
			OnEndPhysisSimulationMove();
		}
		TickPhysicalMove(DeltaTime);
	}

	private void OnBeginPhysisSimulationMove()
	{
		ACharacter aCharacter = GetOwner() as ACharacter;
		if (aCharacter == null)
		{
			return;
		}
		PhysicalMoveData.DefaultGravityZ = aCharacter.CharacterMovement.GetGravityZ();
		if (PhysicalMoveData.GravityScaleHandleID == 0)
		{
			base.BUSEventCollection.Evt_SetFloatProperty.Invoke(EPropType.Movement_GravityScale, 0f);
			PhysicalMoveData.GravityScaleHandleID = PropMgrData.GetLastHandleID();
		}
		else
		{
			base.BUSEventCollection.Evt_SetFloatProperty.Invoke(EPropType.Movement_GravityScale, 0f, PhysicalMoveData.GravityScaleHandleID);
		}
		if (PhysicalMoveData.MovementModeHandleID == 0)
		{
			base.BUSEventCollection.Evt_SetEnumProperty.Invoke(EPropType.Movement_MovementMode, 0, 0u, 0u, bSetDefaultProperty: false, "PhysicalMoveComp");
			PhysicalMoveData.MovementModeHandleID = PropMgrData.GetLastHandleID();
		}
		else
		{
			base.BUSEventCollection.Evt_SetEnumProperty.Invoke(EPropType.Movement_MovementMode, 0, PhysicalMoveData.MovementModeHandleID, 0u, bSetDefaultProperty: false, "PhysicalMoveComp");
		}
		PhysicalMoveData.bNeedDelayTickPhysicalMove = true;
		if (!(PhysicalMoveData.PhysicalMoveBuffNeedSpeed <= 0f))
		{
			return;
		}
		foreach (int item in PhysicalMoveData.PhysicalMoveBuff)
		{
			base.BUSEventCollection.Evt_BuffAdd.Invoke(item, Owner, Owner, -1f, EBuffSourceType.PhysicalMove);
		}
	}

	private void OnEndPhysisSimulationMove()
	{
		base.BUSEventCollection.Evt_ResetProperty.Invoke(PhysicalMoveData.GravityScaleHandleID);
		base.BUSEventCollection.Evt_ResetProperty.Invoke(PhysicalMoveData.MovementModeHandleID);
		PhysicalMoveData.GravityScaleHandleID = 0u;
		PhysicalMoveData.PhysicalMoveVelocity = FVector.ZeroVector;
		PhysicalMoveData.bNeedDelayTickPhysicalMove = false;
		PhysicalMoveData.bPauseByImmobilize = false;
		PhysicalMoveData.LinearVelocityWhenImmobilize = FVector.ZeroVector;
		PhysicalMoveData.AngularVelocityWhenImmobilize = FVector.ZeroVector;
		if (!(PhysicalMoveData.PhysicalMoveBuffNeedSpeed > 0f))
		{
			return;
		}
		foreach (int item in PhysicalMoveData.PhysicalMoveBuff)
		{
			base.BUSEventCollection.Evt_BuffRemoveImmediately.Invoke(item, EBuffEffectTriggerType.None);
		}
	}

	private void TickPhysicalMove(float DeltaTime)
	{
		if (PhysAnimData.CurrentType != EPhysAnimType.PhysicsSimulationMove)
		{
			return;
		}
		if (PhysicalMoveData.bNeedDelayTickPhysicalMove)
		{
			PhysicalMoveData.bNeedDelayTickPhysicalMove = false;
			return;
		}
		ACharacter aCharacter = GetOwner() as ACharacter;
		if (aCharacter == null || aCharacter.Mesh == null)
		{
			return;
		}
		bool bLoadThisTime;
		b1.PhysMoveAnimSetting physMoveAnimSetting = PhysAnimData.TryGetSetting(EPhysAnimType.PhysicsSimulationMove, aCharacter, out bLoadThisTime) as b1.PhysMoveAnimSetting;
		FTransform t = BGUFuncLibComponentCS.BGUGetSocketTransform(aCharacter.Mesh, ref physMoveAnimSetting.BoneNameToSimulatePhysics);
		FVector fVector = t.GetLocation() + MathLib.TransformDirection(t, physMoveAnimSetting.LocalSpaceCollisionOffset.GetSafeNormal()) * physMoveAnimSetting.LocalSpaceCollisionOffset.Size();
		FVector fVector2 = fVector;
		FVector end = fVector2;
		fVector2.Z += aCharacter.CapsuleComponent.GetScaledCapsuleHalfHeight();
		end.Z -= aCharacter.CapsuleComponent.GetScaledCapsuleHalfHeight();
		if (USystemLibrary.LineTraceSingleForObjects(aCharacter, fVector2, end, new List<EObjectTypeQuery> { EObjectTypeQuery.ObjectTypeQuery1 }, bTraceComplex: false, null, EDrawDebugTrace.None, out var OutHit, bIgnoreSelf: true, FLinearColor.Red, FLinearColor.Blue, 0f))
		{
			fVector.Z = (float)OutHit.ImpactPoint.Z + aCharacter.CapsuleComponent.GetScaledCapsuleHalfHeight();
		}
		FTransform newTransform = BGUFuncLibActorTransformCS.BGUGetActorTransform(aCharacter);
		fVector = FMath.VInterpTo(BGUFuncLibActorTransformCS.BGUGetActorLocation(aCharacter), fVector, DeltaTime, 16f);
		newTransform.SetLocation(fVector);
		if (PhysicalMoveData.bUseSocketDirection && aCharacter.Mesh.DoesSocketExist(PhysicalMoveData.DirectionBaseSocekt) && aCharacter.Mesh.DoesSocketExist(PhysicalMoveData.ForwardSocket))
		{
			FName SocketName = PhysicalMoveData.DirectionBaseSocekt;
			FName SocketName2 = PhysicalMoveData.ForwardSocket;
			FVector fVector3 = BGUFuncLibComponentCS.BGUGetSocketLocation(aCharacter.Mesh, ref SocketName);
			FVector fVector4 = BGUFuncLibComponentCS.BGUGetSocketLocation(aCharacter.Mesh, ref SocketName2) - fVector3;
			FRotator fRotator = fVector4.Rotation();
			fRotator.Roll = 0f;
			fRotator.Pitch = 0f;
			if (!fVector4.IsZero())
			{
				newTransform.SetRotation(fRotator.Quaternion());
			}
		}
		aCharacter.CapsuleComponent?.SetWorldTransform(newTransform, bSweep: false, out var _, bTeleport: false);
		PhysicalMoveData.PhysicalMoveVelocity = OwnerAsCharacterCS.Mesh.GetPhysicsLinearVelocity(physMoveAnimSetting.BoneNameToSimulatePhysics);
		TickPhysicalMoveBuff(DeltaTime);
	}

	private void TickPhysicalMoveBuff(float DeltaTime)
	{
		if (PhysicalMoveData.PhysicalMoveBuffNeedSpeed <= 0f)
		{
			return;
		}
		if (PhysicalMoveData.bShouldAddPhysicalMoveBuff)
		{
			PhysicalMoveData.PhysicalMoveBuffTimer += DeltaTime;
		}
		float num = PhysicalMoveData.PhysicalMoveVelocity.Size();
		if (num >= PhysicalMoveData.PhysicalMoveBuffNeedSpeed && !PhysicalMoveData.bShouldAddPhysicalMoveBuff)
		{
			foreach (int item in PhysicalMoveData.PhysicalMoveBuff)
			{
				base.BUSEventCollection.Evt_BuffAdd.Invoke(item, Owner, Owner, -1f, EBuffSourceType.PhysicalMove);
			}
			PhysicalMoveData.bShouldAddPhysicalMoveBuff = true;
			PhysicalMoveData.PhysicalMoveBuffTimer = 0f;
		}
		if (!(num < PhysicalMoveData.PhysicalMoveBuffNeedSpeed) || !PhysicalMoveData.bShouldAddPhysicalMoveBuff || !(PhysicalMoveData.PhysicalMoveBuffTimer >= PhysicalMoveData.PhysicalMoveBuffProtectTime))
		{
			return;
		}
		foreach (int item2 in PhysicalMoveData.PhysicalMoveBuff)
		{
			base.BUSEventCollection.Evt_BuffRemoveImmediately.Invoke(item2, EBuffEffectTriggerType.None);
		}
		PhysicalMoveData.bShouldAddPhysicalMoveBuff = false;
		PhysicalMoveData.PhysicalMoveBuffTimer = 0f;
	}

	private void OnDisablePhysicalMove(bool bDisable)
	{
		PhysicalMoveData.bTempDisablePhysicalMove = bDisable;
		if (SimpleStateData.HasSimpleState(EBGUSimpleState.PhysicsSimulationMoveMode) && PhysicalMoveData.bTempDisablePhysicalMove)
		{
			base.BUSEventCollection.Evt_UnitSetSimpleState.Invoke(EBGUSimpleState.PhysicsSimulationMoveMode, IsRemove: true);
		}
		if (!SimpleStateData.HasSimpleState(EBGUSimpleState.PhysicsSimulationMoveMode) && PhysicalMoveData.bConfigEnablePhysicalMove && !PhysicalMoveData.bTempDisablePhysicalMove)
		{
			base.BUSEventCollection.Evt_UnitSetSimpleState.Invoke(EBGUSimpleState.PhysicsSimulationMoveMode);
		}
	}
}
