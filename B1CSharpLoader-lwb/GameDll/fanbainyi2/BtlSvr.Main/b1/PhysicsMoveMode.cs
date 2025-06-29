using BtlShare;

namespace b1;

public class PhysicsMoveMode : ProjectileMoveModeBase
{
	public override void BeginMove()
	{
		base.BeginMove();
		LaunchVelocity(bForceSet: true);
	}

	public override void OnUpdate(float DeltaTime)
	{
		_ = bIsActive;
	}

	public override EBulletOrMagicFieldMoveModeType GetMoveMode()
	{
		return EBulletOrMagicFieldMoveModeType.PhysicsMode;
	}
}
