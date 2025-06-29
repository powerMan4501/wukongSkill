namespace b1;

internal class BUS_ActorTransformInfoCompNoMove : b1.BUS_ActorTransformInfoComp
{
	protected override bool IsNoMoveComp => true;

	public override bool AllowTRO()
	{
		return true;
	}

	public override int GetTickGroupMask()
	{
		return 0;
	}
}
