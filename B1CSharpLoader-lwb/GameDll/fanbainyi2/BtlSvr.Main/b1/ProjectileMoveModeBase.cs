using System.Collections.Generic;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class ProjectileMoveModeBase
{
	private BUS_ObjActorMovementComp MoveComp;

	public IBUC_ObjActorMovementData i_ObjActorMovementData;

	public IBUC_MasterData MasterData;

	public BUS_GSEventCollection BE_Owner;

	public bool bIsActive;

	protected float ObjNowSpd;

	public TStrongObjectPtr<AActor> BulletItSelf = new TStrongObjectPtr<AActor>();

	public TStrongObjectPtr<AActor> BulletMaster = new TStrongObjectPtr<AActor>();

	public AActor Owner => BulletItSelf.Get();

	public void Init(BUS_ObjActorMovementComp _MoveComp, AActor _Owner)
	{
		MoveComp = _MoveComp;
		BulletItSelf.Set(_Owner);
		bIsActive = false;
		i_ObjActorMovementData = BGU_DataUtil.GetReadOnlyData<IBUC_ObjActorMovementData, BUC_ObjActorMovementData>(_Owner);
		MasterData = BGU_DataUtil.GetReadOnlyData<IBUC_MasterData, BUC_MasterData>(_Owner);
		BE_Owner = BUS_EventCollectionCS.Get(_Owner);
	}

	public virtual void OnUpdate(float DeltaTime)
	{
	}

	public virtual void BeforeSwitch()
	{
	}

	public virtual EBulletOrMagicFieldMoveModeType GetMoveMode()
	{
		return EBulletOrMagicFieldMoveModeType.None;
	}

	public void Reset()
	{
		MoveComp.Reset();
	}

	public AActor GetOwner()
	{
		return BulletItSelf.Get();
	}

	public UProjectileMovementComponent GetOwnerProjectileMovement()
	{
		return MoveComp.GetOwnerProjectleMovement();
	}

	public void PreBeginMove()
	{
		BGUFuncLibActorTransformCS.BGUDetachFromActor(GetOwner() as BGUProjectileBaseActor);
	}

	public virtual void BeginMove()
	{
		bIsActive = true;
		BE_Owner.Evt_SetBulletSweepCheckMode.Invoke(BulletSweepCheckMode.Normal);
		InitSpdByType();
	}

	public void StopMove()
	{
		if (bIsActive)
		{
			bIsActive = false;
			MoveComp.StopMove();
		}
	}

	public virtual void OnEnd()
	{
		ResetAllStatus();
	}

	public virtual void ResetAllStatus()
	{
		GetOwnerProjectileMovement().Velocity = FVector.ZeroVector;
	}

	public void InitSpdByType()
	{
		AActor owner = GetOwner();
		if (i_ObjActorMovementData == null)
		{
			return;
		}
		EProjectileObjSpdType speedType = i_ObjActorMovementData.SpeedType;
		FVector TargetPos = default(FVector);
		switch (speedType)
		{
		case EProjectileObjSpdType.None:
			return;
		case EProjectileObjSpdType.Normal:
			if (i_ObjActorMovementData.BulletFlySpd.SpdCurve != null)
			{
				ObjNowSpd = i_ObjActorMovementData.BulletFlySpd.SpdCurve.GetFloatValue(i_ObjActorMovementData.ProjectileFlySpdCurveTimer);
			}
			else
			{
				ObjNowSpd = i_ObjActorMovementData.BulletFlySpd.Spd.LeftValue;
			}
			break;
		case EProjectileObjSpdType.ByTime:
			if (GetTargetPos(out TargetPos))
			{
				if (i_ObjActorMovementData.FlyTime > 0f)
				{
					float num = FVector.Dist(BGUFuncLibActorTransformCS.BGUGetActorLocation(owner), TargetPos);
					ObjNowSpd = num / i_ObjActorMovementData.FlyTime;
				}
				else if (i_ObjActorMovementData.FlyTime == 0f)
				{
					BGUFuncLibActorTransformCS.BGUSetActorLocation(owner, TargetPos, bSweep: false, bTeleport: false);
				}
			}
			break;
		case EProjectileObjSpdType.CurveByTime:
			if (i_ObjActorMovementData.BulletFlySpd.SpdCurve != null)
			{
				ObjNowSpd = i_ObjActorMovementData.BulletFlySpd.SpdCurve.GetFloatValue(i_ObjActorMovementData.ProjectileFlySpdCurveTimer);
			}
			break;
		case EProjectileObjSpdType.CurveByDist:
			if (i_ObjActorMovementData.BulletFlySpd.SpdCurve != null)
			{
				FVector v = BGUFuncLibActorTransformCS.BGUGetActorLocation(owner);
				if (GetTargetPos(out TargetPos))
				{
					float inTime = FVector.Dist(v, TargetPos);
					ObjNowSpd = i_ObjActorMovementData.BulletFlySpd.SpdCurve.GetFloatValue(inTime);
				}
			}
			break;
		}
		CheckTraceOver(0f, TargetPos);
	}

	public void PendingSpdByType(float DeltaTime, FVector TargetPos = default(FVector))
	{
		AActor owner = GetOwner();
		if (i_ObjActorMovementData == null)
		{
			return;
		}
		switch (i_ObjActorMovementData.SpeedType)
		{
		case EProjectileObjSpdType.None:
			return;
		case EProjectileObjSpdType.Normal:
			if (i_ObjActorMovementData.BulletFlySpd.SpdCurve != null)
			{
				ObjNowSpd = i_ObjActorMovementData.BulletFlySpd.SpdCurve.GetFloatValue(i_ObjActorMovementData.ProjectileFlySpdCurveTimer);
			}
			else if (i_ObjActorMovementData.BulletFlySpd.AccelerationTime > 0f)
			{
				float num2 = i_ObjActorMovementData.BulletFlySpd.Spd.RightValue - i_ObjActorMovementData.BulletFlySpd.Spd.LeftValue;
				ObjNowSpd += num2 / i_ObjActorMovementData.BulletFlySpd.AccelerationTime * DeltaTime;
				if (num2 >= 0f)
				{
					ObjNowSpd = MathLib.Clamp(ObjNowSpd, i_ObjActorMovementData.BulletFlySpd.Spd.LeftValue, i_ObjActorMovementData.BulletFlySpd.Spd.RightValue);
				}
				else
				{
					ObjNowSpd = MathLib.Clamp(ObjNowSpd, i_ObjActorMovementData.BulletFlySpd.Spd.RightValue, i_ObjActorMovementData.BulletFlySpd.Spd.LeftValue);
				}
			}
			else if (i_ObjActorMovementData.BulletFlySpd.AccelerationTime == 0f)
			{
				ObjNowSpd = ((i_ObjActorMovementData.BulletFlySpd.Spd.RightValue > i_ObjActorMovementData.BulletFlySpd.Spd.LeftValue) ? i_ObjActorMovementData.BulletFlySpd.Spd.RightValue : i_ObjActorMovementData.BulletFlySpd.Spd.LeftValue);
			}
			break;
		case EProjectileObjSpdType.ByTime:
			if (i_ObjActorMovementData.FlyTime > 0f)
			{
				float num = FVector.Dist(BGUFuncLibActorTransformCS.BGUGetActorLocation(owner), TargetPos);
				ObjNowSpd = num / i_ObjActorMovementData.FlyTime;
			}
			else if (i_ObjActorMovementData.FlyTime == 0f)
			{
				BGUFuncLibActorTransformCS.BGUSetActorLocation(owner, TargetPos, bSweep: false, bTeleport: false);
			}
			break;
		case EProjectileObjSpdType.CurveByTime:
			if (i_ObjActorMovementData.BulletFlySpd.SpdCurve != null)
			{
				ObjNowSpd = i_ObjActorMovementData.BulletFlySpd.SpdCurve.GetFloatValue(i_ObjActorMovementData.ProjectileFlySpdCurveTimer);
			}
			break;
		case EProjectileObjSpdType.CurveByDist:
			if (i_ObjActorMovementData.BulletFlySpd.SpdCurve != null)
			{
				float inTime = FVector.Dist(BGUFuncLibActorTransformCS.BGUGetActorLocation(owner), TargetPos);
				ObjNowSpd = i_ObjActorMovementData.BulletFlySpd.SpdCurve.GetFloatValue(inTime);
			}
			break;
		}
		CheckTraceOver(DeltaTime, TargetPos);
	}

	protected void CheckTraceOver(float DeltaTime, FVector TargetPos)
	{
		if (i_ObjActorMovementData.MoveMode != EBulletOrMagicFieldMoveModeType.TraceMode && i_ObjActorMovementData.MoveMode != EBulletOrMagicFieldMoveModeType.InertialSimulatingMoveMode)
		{
			return;
		}
		AActor owner = GetOwner();
		if (BE_Owner == null || i_ObjActorMovementData == null)
		{
			return;
		}
		FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorLocation(owner);
		float num = FVector.Dist(fVector, TargetPos);
		bool flag = false;
		if (i_ObjActorMovementData.SpeedType == EProjectileObjSpdType.ByTime)
		{
			if (num <= DeltaTime * ObjNowSpd || i_ObjActorMovementData.FlyTime <= 0f)
			{
				flag = true;
			}
		}
		else if (i_ObjActorMovementData.InertialState == EInertialState.AdjustTrans)
		{
			USceneComponent SocketOwnerComp;
			FRotator fRotator = BGU_ObjActorUtil.GetSocketOrCompTransform(i_ObjActorMovementData.bUseSocket_Target, i_ObjActorMovementData.TargetActor, new FName(i_ObjActorMovementData.TargetSocketName), out SocketOwnerComp).GetRotation().Rotator();
			FRotator normalized = (owner.GetActorRotation() - fRotator).GetNormalized();
			if ((num <= DeltaTime * ObjNowSpd && (double)FMath.Max(FMath.Abs(normalized.Pitch), FMath.Abs(normalized.Roll), FMath.Abs(normalized.Yaw)) < 0.1) || i_ObjActorMovementData.InertialAdjustTransTime <= 0f)
			{
				flag = true;
				BGUFuncLibActorTransformCS.BGUSetActorRotation(owner, fRotator, bTeleportPhysics: false);
			}
		}
		else if (num <= DeltaTime * ObjNowSpd)
		{
			flag = true;
		}
		if (!flag)
		{
			return;
		}
		if (i_ObjActorMovementData.TraceType == EBGUBulletTraceType.BackNest)
		{
			BE_Owner.Evt_OnBackNestOver.Invoke();
			ObjNowSpd = 0f;
		}
		else if (i_ObjActorMovementData.TraceType == EBGUBulletTraceType.ToActor)
		{
			if (BE_Owner.Evt_AttachToTargetWhenTraceOver.Invoke())
			{
				ObjNowSpd = 0f;
			}
		}
		else if (i_ObjActorMovementData.TraceType == EBGUBulletTraceType.ToTargetPos)
		{
			ObjNowSpd = 0f;
		}
		if (i_ObjActorMovementData.InertialState == EInertialState.TraceTarget)
		{
			BE_Owner.Evt_SetInertialState.Invoke(2);
		}
		else if (i_ObjActorMovementData.InertialState == EInertialState.DecreaseVel)
		{
			BE_Owner.Evt_SetInertialState.Invoke(3);
		}
		else if (i_ObjActorMovementData.InertialState == EInertialState.AdjustTrans)
		{
			BE_Owner.Evt_SetInertialState.Invoke(4);
			ObjNowSpd = 0f;
		}
		if (i_ObjActorMovementData.TraceOverTriggerLifeOverEffect)
		{
			FEffectInstReq EffectInstReq = new FEffectInstReq
			{
				HitLocation = fVector,
				HitPointNormalDir = BGUFuncLibActorTransformCS.BGUGetActorRotation(owner)
			};
			BE_Owner.Evt_BulletTriggerEffectsByReson.Invoke(EBGUBulletTriggerEffectReason.LifeOver, ref EffectInstReq);
		}
		if (i_ObjActorMovementData.TraceOverSwitchToStraightMode)
		{
			BE_Owner.Evt_OnTraceEndToStraight.Invoke();
		}
	}

	public bool GetTargetPos(out FVector TargetPos)
	{
		bool result = false;
		AActor owner = GetOwner();
		TargetPos = FVector.ZeroVector;
		if (i_ObjActorMovementData.MoveMode == EBulletOrMagicFieldMoveModeType.ParabolaMoveMode || ((i_ObjActorMovementData.MoveMode == EBulletOrMagicFieldMoveModeType.TraceMode || i_ObjActorMovementData.MoveMode == EBulletOrMagicFieldMoveModeType.InertialSimulatingMoveMode) && i_ObjActorMovementData.TraceType == EBGUBulletTraceType.ToTargetPos) || (i_ObjActorMovementData.MoveMode == EBulletOrMagicFieldMoveModeType.CircleSurroundMoveMode && i_ObjActorMovementData.CenterType == ECircleSurround_CenterType.TargetPos) || i_ObjActorMovementData.MoveMode == EBulletOrMagicFieldMoveModeType.FbmMoveMode || i_ObjActorMovementData.MoveMode == EBulletOrMagicFieldMoveModeType.FbmBymjMoveMode)
		{
			TargetPos = i_ObjActorMovementData.TargetPos;
			result = true;
		}
		else if (((i_ObjActorMovementData.MoveMode == EBulletOrMagicFieldMoveModeType.TraceMode || i_ObjActorMovementData.MoveMode == EBulletOrMagicFieldMoveModeType.InertialSimulatingMoveMode) && i_ObjActorMovementData.TraceType == EBGUBulletTraceType.ToActor) || (i_ObjActorMovementData.MoveMode == EBulletOrMagicFieldMoveModeType.CircleSurroundMoveMode && i_ObjActorMovementData.CenterType == ECircleSurround_CenterType.TargetBaseActor))
		{
			AActor targetActor = i_ObjActorMovementData.TargetActor;
			if ((targetActor.IsNullOrDestroyed() || BGUFunctionLibraryCS.BGUHasUnitState(targetActor, EBGUUnitState.Dead) || BGUFunctionLibraryCS.BGUHasUnitSimpleState(targetActor, EBGUSimpleState.PendingDeathInAnimationSyncing)) && MasterData != null)
			{
				BGUCharacterCS bGUCharacterCS = MasterData.GetMasterActor() as BGUCharacterCS;
				if (!bGUCharacterCS.IsNullOrDestroyed())
				{
					BUS_EventCollectionCS.Get(bGUCharacterCS).Evt_BulletMissTarget.Invoke(owner);
				}
			}
			if (targetActor != null)
			{
				BGUCharacterCS bGUCharacterCS2 = targetActor as BGUCharacterCS;
				if (bGUCharacterCS2 != null && i_ObjActorMovementData.TargetSocketName != null)
				{
					TargetPos = BGU_ObjActorUtil.GetSocketOrCompTransform(i_ObjActorMovementData.bUseSocket_Target, bGUCharacterCS2, new FName(i_ObjActorMovementData.TargetSocketName), out var _).GetLocation();
				}
				else
				{
					TargetPos = BGUFuncLibActorTransformCS.BGUGetActorTransform(targetActor).GetLocation();
				}
				List<FVector> RangeOffsetList = null;
				TargetPos += BGUFuncLibProjectile.GetOffset(i_ObjActorMovementData.TargetOffsetInfo, ref RangeOffsetList);
				result = true;
			}
		}
		else if (i_ObjActorMovementData.MoveMode == EBulletOrMagicFieldMoveModeType.TraceMode && i_ObjActorMovementData.TraceType == EBGUBulletTraceType.BackNest)
		{
			if (MasterData != null)
			{
				BGUCharacterCS bGUCharacterCS3 = MasterData.GetMasterActor() as BGUCharacterCS;
				if (bGUCharacterCS3 != null && !bGUCharacterCS3.IsPendingKill)
				{
					TargetPos = BGU_ObjActorUtil.GetSocketOrCompTransform(UseSocket: true, bGUCharacterCS3, i_ObjActorMovementData.NestName, out var _).GetLocation();
					List<FVector> RangeOffsetList2 = null;
					TargetPos += BGUFuncLibProjectile.GetOffset(i_ObjActorMovementData.TargetOffsetInfo, ref RangeOffsetList2);
					result = true;
				}
			}
		}
		else if ((i_ObjActorMovementData.MoveMode == EBulletOrMagicFieldMoveModeType.TraceMode || i_ObjActorMovementData.MoveMode == EBulletOrMagicFieldMoveModeType.InertialSimulatingMoveMode) && i_ObjActorMovementData.TraceType == EBGUBulletTraceType.ToSceneItem && MasterData != null)
		{
			BUC_SceneItemData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_SceneItemData>(MasterData.GetMasterActor() as BGUCharacterCS);
			if (readOnlyData != null && readOnlyData.SceneItemCatch != null)
			{
				TargetPos = BGUFuncLibActorTransformCS.BGUGetActorLocation(readOnlyData.SceneItemCatch);
				List<FVector> RangeOffsetList3 = null;
				TargetPos += BGUFuncLibProjectile.GetOffset(i_ObjActorMovementData.TargetOffsetInfo, ref RangeOffsetList3);
				result = true;
			}
		}
		return result;
	}

	public float GetScaledSpdValue()
	{
		if (i_ObjActorMovementData.SpeedType == EProjectileObjSpdType.Normal)
		{
			return ObjNowSpd * i_ObjActorMovementData.SpdScaleValue;
		}
		return ObjNowSpd;
	}

	public void LaunchVelocity(bool bForceSet = false, float ForceSetValue = 0f)
	{
		FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorForwardVector(GetOwner());
		if (bForceSet)
		{
			BE_Owner.Evt_ObjectActorSetVelocity.Invoke(fVector * ForceSetValue);
			return;
		}
		float scaledSpdValue = GetScaledSpdValue();
		FVector fVector2 = fVector * scaledSpdValue;
		if (i_ObjActorMovementData.CurVelocity != fVector2)
		{
			BE_Owner.Evt_ObjectActorSetVelocity.Invoke(fVector2);
		}
	}
}
