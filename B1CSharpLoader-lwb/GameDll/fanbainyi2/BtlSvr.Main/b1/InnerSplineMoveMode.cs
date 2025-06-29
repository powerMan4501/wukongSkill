using BtlShare;

namespace b1;

public class InnerSplineMoveMode : SplineMoveMode
{
	public override EBulletOrMagicFieldMoveModeType GetMoveMode()
	{
		return EBulletOrMagicFieldMoveModeType.InnerSplineMoveMode;
	}
}
