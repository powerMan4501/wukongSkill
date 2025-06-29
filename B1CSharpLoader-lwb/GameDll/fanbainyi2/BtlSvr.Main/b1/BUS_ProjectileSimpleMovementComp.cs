using b1.EventDelDefine;
using UnrealEngine.Runtime;

namespace b1;

public class BUS_ProjectileSimpleMovementComp : UActorCompBaseCS
{
	private BUC_ProjectileSimpleMoveData ProjectileSimpleMoveData;

	public override void OnAttach()
	{
		ProjectileSimpleMoveData = RequireWritableData<BUC_ProjectileSimpleMoveData>();
		base.BUSEventCollection.Evt_ProjectilePendingVelocity += new Del_Void_Vector(PendingLaunch);
		base.BUSEventCollection.Evt_OnProjectileDead += new Del_OnBulletDead(OnProjectileDead);
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		MoveUpdate(DeltaTime);
	}

	private void MoveUpdate(float DeltaTime)
	{
		if (!ProjectileSimpleMoveData.Velocity.IsNearlyZero())
		{
			FVector newLocation = BGUFuncLibActorTransformCS.BGUGetActorLocation(Owner) + ProjectileSimpleMoveData.Velocity * DeltaTime;
			BGUFuncLibActorTransformCS.BGUSetActorLocation(Owner, newLocation, bSweep: false, bTeleport: false);
		}
	}

	private void PendingLaunch(FVector NewVelocity)
	{
		ProjectileSimpleMoveData.Velocity = NewVelocity;
	}

	private void OnProjectileDead(EBGUBulletDestroyReason DestroyReason)
	{
		ProjectileSimpleMoveData.bEnableMove = false;
		SetCanTick(Val: false);
	}
}
