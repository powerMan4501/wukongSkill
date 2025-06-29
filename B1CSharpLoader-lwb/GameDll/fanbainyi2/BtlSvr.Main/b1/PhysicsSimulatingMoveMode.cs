using BtlB1;
using BtlShare;

namespace b1;

public class PhysicsSimulatingMoveMode : ProjectileMoveModeBase
{
	public override void BeginMove()
	{
		base.BeginMove();
		LaunchVelocity();
		BGUProjectileBaseActor bGUProjectileBaseActor = GetOwner() as BGUProjectileBaseActor;
		if (bGUProjectileBaseActor == null)
		{
			return;
		}
		BUC_ProjectilePhysicData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_ProjectilePhysicData>(bGUProjectileBaseActor);
		if (readOnlyData == null)
		{
			return;
		}
		BE_Owner.Evt_SetObjectActorPhysics.Invoke(readOnlyData.OriGravityScale, RotationFollowsVelocity: true, ShouldBounce: true);
		FUStProjectileMoveDesc projectileMoveDesc = BGW_GameDB.GetProjectileMoveDesc(bGUProjectileBaseActor.GetProjectileID());
		if (projectileMoveDesc != null)
		{
			if (projectileMoveDesc.ProjectileMoveModeYoNParam.Count > 0 && projectileMoveDesc.ProjectileMoveModeYoNParam[0] == EGSYesNo.Yes)
			{
				BE_Owner.Evt_SetBulletSweepCheckMode.Invoke(BulletSweepCheckMode.Normal);
			}
			else
			{
				BE_Owner.Evt_SetBulletSweepCheckMode.Invoke(BulletSweepCheckMode.Bounce);
			}
		}
		else
		{
			BE_Owner.Evt_SetBulletSweepCheckMode.Invoke(BulletSweepCheckMode.Bounce);
		}
	}

	public override void OnUpdate(float DeltaTime)
	{
		_ = bIsActive;
	}

	public override EBulletOrMagicFieldMoveModeType GetMoveMode()
	{
		return EBulletOrMagicFieldMoveModeType.PhysicsSimulatingMode;
	}
}
