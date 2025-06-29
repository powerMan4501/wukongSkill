using BtlShare;
using UnrealEngine.Runtime;

namespace b1;

public class TraceMoveMode : ProjectileMoveModeBase
{
	public override void BeginMove()
	{
		base.BeginMove();
		LaunchVelocity();
		i_ObjActorMovementData.InitBulletNowRotSpd();
	}

	public override void OnUpdate(float DeltaTime)
	{
		if (!bIsActive)
		{
			return;
		}
		BGUProjectileBaseActor bGUProjectileBaseActor = GetOwner() as BGUProjectileBaseActor;
		if (bGUProjectileBaseActor == null || i_ObjActorMovementData.TraceType == EBGUBulletTraceType.None)
		{
			return;
		}
		FVector TargetPos;
		bool targetPos = GetTargetPos(out TargetPos);
		if (bGUProjectileBaseActor.bInDebugMode())
		{
			UBGUFunctionLibraryForCS.BGUDrawLineArrow(bGUProjectileBaseActor.World, BGUFuncLibActorTransformCS.BGUGetActorLocation(bGUProjectileBaseActor), TargetPos, 100f);
		}
		if ((i_ObjActorMovementData.TraceTime > 0f || i_ObjActorMovementData.TraceTime == -1f) && targetPos)
		{
			i_ObjActorMovementData.UpdateRotSpd(DeltaTime);
			if (i_ObjActorMovementData.BulletNowRotSpd > 0f)
			{
				FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorLocation(bGUProjectileBaseActor);
				FVector vector = TargetPos - fVector;
				FVector fVector2 = BGUFuncLibActorTransformCS.BGUGetActorForwardVector(bGUProjectileBaseActor);
				float num = MathLib.DegAcos(FVector.DotProduct(vector.GetSafeNormal(), fVector2));
				float slerp = MathLib.Clamp(i_ObjActorMovementData.BulletNowRotSpd * DeltaTime / num, 0f, 1f);
				FQuat fQuat = FQuat.FindBetweenVectors(fVector2, vector);
				FQuat fQuat2 = BGUFuncLibActorTransformCS.BGUGetActorRotation(bGUProjectileBaseActor).Quaternion();
				FQuat quat = FQuat.Slerp(fQuat2, fQuat * fQuat2, slerp);
				FRotator newRotation = new FRotator(quat);
				if (i_ObjActorMovementData.CloseZTrace)
				{
					newRotation.Pitch = BGUFuncLibActorTransformCS.BGUGetActorRotation(bGUProjectileBaseActor).Pitch;
					newRotation.Roll = BGUFuncLibActorTransformCS.BGUGetActorRotation(bGUProjectileBaseActor).Roll;
				}
				BGUFuncLibActorTransformCS.BGUSetActorRotation(bGUProjectileBaseActor, newRotation, bTeleportPhysics: false);
			}
		}
		PendingSpdByType(DeltaTime, TargetPos);
		LaunchVelocity();
	}

	public override EBulletOrMagicFieldMoveModeType GetMoveMode()
	{
		return EBulletOrMagicFieldMoveModeType.TraceMode;
	}
}
