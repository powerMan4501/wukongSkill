using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

internal class BUS_FlyCtrlCompImpl : UActorCompBaseCS
{
	private BUC_FlyCtrlData FlyCtrlData;

	public override void OnAttach()
	{
		FlyCtrlData = RequireWritableData<BUC_FlyCtrlData>();
	}

	public override void OnBeginPlay()
	{
		FlyCtrlData.MovementComp = Owner.GetComponentByClass<UBGUCharacterMovementComponent>();
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (!FlyCtrlData.bEnable)
		{
			return;
		}
		FlyCtrlData.CheckTimer += DeltaTime;
		if (!(FlyCtrlData.CheckTimer > FlyCtrlData.CheckInterval))
		{
			return;
		}
		FlyCtrlData.CheckTimer = 0f;
		FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorLocation(Owner);
		FVector endTrace = fVector + FVector.UpVector * (0f - FlyCtrlData.LineTraceLength);
		List<EObjectTypeQuery> list = new List<EObjectTypeQuery>();
		list.Add(EObjectTypeQuery.ObjectTypeQuery1);
		List<FHitResultSimple> HitResultList;
		int num = UBGUSelectUtil.LineTraceMultiByObjType(Owner, fVector, endTrace, list, FlyCtrlData.bPrintHitActor, out HitResultList);
		AActor hitActor = null;
		float num2 = float.MinValue;
		foreach (FHitResultSimple item in HitResultList)
		{
			bool flag = false;
			foreach (FName traceIgnoreActorTag in FlyCtrlData.TraceIgnoreActorTags)
			{
				if (item.HitActor.ActorHasTag(traceIgnoreActorTag))
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				float z = item.HitLocation.Z;
				if (z > num2)
				{
					num2 = z;
					hitActor = item.HitActor;
				}
			}
		}
		if (num > 0)
		{
			CheckHeight(fVector.Z - num2, fVector.Z, hitActor, num2);
		}
	}

	private void CheckHeight(float DeltaHeight, float RealZ, AActor HitActor, float HitResultLocationZ)
	{
		if (DeltaHeight < FlyCtrlData.FlyHeightMin)
		{
			if (FlyCtrlData.bLockZ)
			{
				FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorLocation(Owner);
				BGUFuncLibActorTransformCS.BGUSetActorLocation(Owner, new FVector(fVector.X, fVector.Y, HitResultLocationZ + FlyCtrlData.FlyHeightMin), bSweep: false, bTeleport: false);
			}
			else
			{
				FlyCtrlData.MovementComp.AddImpulse(FVector.UpVector * FlyCtrlData.PushUpImpulse, bVelocityChange: true);
			}
			_ = FlyCtrlData.bPrintHitActor;
		}
		else if (DeltaHeight > FlyCtrlData.FlyHeightMax || RealZ > FlyCtrlData.FlyHeightMaxAbs)
		{
			FlyCtrlData.MovementComp.AddImpulse(-FVector.UpVector * FlyCtrlData.PushDownImpulse, bVelocityChange: true);
		}
	}
}
