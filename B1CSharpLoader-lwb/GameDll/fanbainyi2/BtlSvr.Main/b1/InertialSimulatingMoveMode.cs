using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class InertialSimulatingMoveMode : ProjectileMoveModeBase
{
	private float BulletNowRotSpd;

	public override void BeginMove()
	{
		base.BeginMove();
		LaunchVelocity();
	}

	public override void OnUpdate(float DeltaTime)
	{
		if (!bIsActive)
		{
			return;
		}
		AActor owner = GetOwner();
		if (owner == null || i_ObjActorMovementData.TraceType == EBGUBulletTraceType.None)
		{
			return;
		}
		bool flag = false;
		FVector TargetPos = default(FVector);
		flag = GetTargetPos(out TargetPos);
		_ = i_ObjActorMovementData.SpeedType;
		FVector ownLoc = BGUFuncLibActorTransformCS.BGUGetActorLocation(owner);
		BGUFuncLibActorTransformCS.BGUGetActorRotation(owner);
		CheckState(ownLoc, TargetPos);
		switch (i_ObjActorMovementData.InertialState)
		{
		case EInertialState.TraceTarget:
		{
			if ((i_ObjActorMovementData.TraceTime > 0f || i_ObjActorMovementData.TraceTime == -1f) && flag)
			{
				FVector start = BGUFuncLibActorTransformCS.BGUGetActorLocation(owner);
				FRotator current = BGUFuncLibActorTransformCS.BGUGetActorRotation(owner);
				FRotator target = MathLib.FindLookAtRotation(start, TargetPos);
				if (i_ObjActorMovementData.BulletRotSpd.SpdCurve == null)
				{
					if (i_ObjActorMovementData.BulletRotSpd.AccelerationTime > 0f)
					{
						float num2 = i_ObjActorMovementData.BulletRotSpd.Spd.RightValue - i_ObjActorMovementData.BulletRotSpd.Spd.LeftValue;
						BulletNowRotSpd += num2 / i_ObjActorMovementData.BulletRotSpd.AccelerationTime * DeltaTime;
						if (num2 > 0f)
						{
							BulletNowRotSpd = MathLib.Clamp(BulletNowRotSpd, i_ObjActorMovementData.BulletRotSpd.Spd.LeftValue, i_ObjActorMovementData.BulletRotSpd.Spd.RightValue);
						}
						else
						{
							BulletNowRotSpd = MathLib.Clamp(BulletNowRotSpd, i_ObjActorMovementData.BulletRotSpd.Spd.RightValue, i_ObjActorMovementData.BulletRotSpd.Spd.LeftValue);
						}
					}
					else if (i_ObjActorMovementData.BulletRotSpd.AccelerationTime == 0f)
					{
						BulletNowRotSpd = ((i_ObjActorMovementData.BulletRotSpd.Spd.RightValue > i_ObjActorMovementData.BulletRotSpd.Spd.LeftValue) ? i_ObjActorMovementData.BulletRotSpd.Spd.RightValue : i_ObjActorMovementData.BulletRotSpd.Spd.LeftValue);
					}
				}
				else
				{
					BulletNowRotSpd = i_ObjActorMovementData.BulletRotSpd.SpdCurve.GetFloatValue(i_ObjActorMovementData.ProjectileRotSpdCurveTimer);
				}
				if (BulletNowRotSpd > 0f)
				{
					target = MathLib.RInterpTo_Constant(current, target, DeltaTime, BulletNowRotSpd);
					if (i_ObjActorMovementData.CloseZTrace)
					{
						target.Pitch = BGUFuncLibActorTransformCS.BGUGetActorRotation(owner).Pitch;
						target.Roll = BGUFuncLibActorTransformCS.BGUGetActorRotation(owner).Roll;
					}
					BGUFuncLibActorTransformCS.BGUSetActorRotation(owner, target, bTeleportPhysics: false);
				}
			}
			float inTime = FVector.Dist(BGUFuncLibActorTransformCS.BGUGetActorLocation(owner), TargetPos);
			ObjNowSpd = i_ObjActorMovementData.InertialTraceSpdCurve.GetFloatValue(inTime);
			CheckTraceOver(DeltaTime, TargetPos);
			float scaledSpdValue3 = GetScaledSpdValue();
			FVector fVector3 = BGUFuncLibActorTransformCS.BGUGetActorForwardVector(GetOwner());
			BE_Owner.Evt_ObjectActorSetVelocity.Invoke(fVector3 * scaledSpdValue3);
			break;
		}
		case EInertialState.DecreaseVel:
			if (i_ObjActorMovementData.InertialDecreaseTime > 0f)
			{
				ObjNowSpd -= ObjNowSpd / i_ObjActorMovementData.InertialDecreaseTime * DeltaTime;
				if (ObjNowSpd <= 0f)
				{
					BE_Owner.Evt_SetInertialState.Invoke(3);
				}
				float scaledSpdValue2 = GetScaledSpdValue();
				FVector fVector2 = BGUFuncLibActorTransformCS.BGUGetActorForwardVector(GetOwner());
				if (scaledSpdValue2 > 0f)
				{
					BE_Owner.Evt_ObjectActorSetVelocity.Invoke(fVector2 * scaledSpdValue2);
				}
			}
			else
			{
				BE_Owner.Evt_SetInertialState.Invoke(3);
			}
			break;
		case EInertialState.AdjustTrans:
		{
			if (!((i_ObjActorMovementData.TraceTime > 0f || i_ObjActorMovementData.TraceTime == -1f) && flag))
			{
				break;
			}
			FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorLocation(owner);
			FRotator fRotator = BGUFuncLibActorTransformCS.BGUGetActorRotation(owner);
			FRotator fRotator2 = BGU_ObjActorUtil.GetSocketOrCompTransform(i_ObjActorMovementData.bUseSocket_Target, i_ObjActorMovementData.TargetActor, new FName(i_ObjActorMovementData.TargetSocketName), out var _).GetRotation().Rotator();
			FRotator normalized = (fRotator - fRotator2).GetNormalized();
			if (i_ObjActorMovementData.InertialRotSpdCurve == null)
			{
				if (i_ObjActorMovementData.InertialAdjustTransTime > 0f)
				{
					BulletNowRotSpd = FMath.Max(normalized.Pitch, normalized.Roll, normalized.Yaw) / i_ObjActorMovementData.InertialAdjustTransTime;
				}
			}
			else
			{
				BulletNowRotSpd = i_ObjActorMovementData.InertialRotSpdCurve.GetFloatValue(i_ObjActorMovementData.ProjectileRotSpdCurveTimer);
			}
			if (BulletNowRotSpd > 0f)
			{
				fRotator2 = MathLib.RInterpTo_Constant(fRotator, fRotator2, DeltaTime, BulletNowRotSpd);
				if (i_ObjActorMovementData.CloseZTrace)
				{
					fRotator2.Pitch = BGUFuncLibActorTransformCS.BGUGetActorRotation(owner).Pitch;
					fRotator2.Roll = BGUFuncLibActorTransformCS.BGUGetActorRotation(owner).Roll;
				}
				BGUFuncLibActorTransformCS.BGUSetActorRotation(owner, fRotator2, bTeleportPhysics: false);
			}
			if (i_ObjActorMovementData.InertialAdjustTransTime > 0f)
			{
				float num = FVector.Dist(fVector, TargetPos);
				ObjNowSpd = num / i_ObjActorMovementData.InertialAdjustTransTime;
			}
			CheckTraceOver(DeltaTime, TargetPos);
			float scaledSpdValue = GetScaledSpdValue();
			BGUFuncLibActorTransformCS.BGUGetActorForwardVector(GetOwner());
			BE_Owner.Evt_ObjectActorSetVelocity.Invoke(MathLib.FindLookAtRotation(fVector, TargetPos).Vector() * scaledSpdValue);
			break;
		}
		default:
			_ = 4;
			break;
		}
	}

	public override void ResetAllStatus()
	{
		base.ResetAllStatus();
		BE_Owner.Evt_SetInertialState.Invoke(0);
	}

	public override EBulletOrMagicFieldMoveModeType GetMoveMode()
	{
		return EBulletOrMagicFieldMoveModeType.InertialSimulatingMoveMode;
	}

	private void CheckState(FVector OwnLoc, FVector TargetPos)
	{
		if ((i_ObjActorMovementData.InertialState == EInertialState.Stay || i_ObjActorMovementData.InertialState == EInertialState.None) && FVector.Dist(TargetPos, OwnLoc) > i_ObjActorMovementData.InertialTraceRadius)
		{
			BE_Owner.Evt_SetInertialState.Invoke(1);
		}
	}
}
