using BtlShare;

namespace b1;

public class StraightMoveMode : ProjectileMoveModeBase
{
	public override void BeginMove()
	{
		base.BeginMove();
		LaunchVelocity();
	}

	public override void OnUpdate(float DeltaTime)
	{
		if (bIsActive)
		{
			PendingSpdByType(DeltaTime);
			LaunchVelocity();
		}
	}

	public override EBulletOrMagicFieldMoveModeType GetMoveMode()
	{
		return EBulletOrMagicFieldMoveModeType.StraightMode;
	}
}
