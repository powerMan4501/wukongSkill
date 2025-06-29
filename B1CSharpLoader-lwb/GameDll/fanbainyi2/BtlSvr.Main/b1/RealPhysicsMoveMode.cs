using BtlShare;
using UnrealEngine.Runtime;

namespace b1;

public class RealPhysicsMoveMode : ProjectileMoveModeBase
{
	public override void BeginMove()
	{
		base.BeginMove();
		BGUProjectileBaseActor bGUProjectileBaseActor = GetOwner() as BGUProjectileBaseActor;
		if (!(bGUProjectileBaseActor == null))
		{
			LaunchVelocity(bForceSet: true);
			BUC_ProjectilePhysicData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_ProjectilePhysicData>(bGUProjectileBaseActor);
			if (readOnlyData != null)
			{
				BE_Owner.Evt_SetObjectActorPhysics.Invoke(readOnlyData.OriGravityScale, RotationFollowsVelocity: false, ShouldBounce: false, bSimulate: true);
				bGUProjectileBaseActor.GetStaticMesh().AddImpulse(BGUFuncLibActorTransformCS.BGUGetActorForwardVector(bGUProjectileBaseActor) * GetScaledSpdValue(), FName.None, bVelChange: true);
			}
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
