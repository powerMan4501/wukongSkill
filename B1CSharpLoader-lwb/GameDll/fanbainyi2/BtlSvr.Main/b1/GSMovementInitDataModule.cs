namespace b1;

internal class GSMovementInitDataModule : GSInitDataModuleBase
{
	public float OptimizeDistanceLevel1 { get; set; }

	public float OptimizeDistanceLevel2 { get; set; }

	public override void Init()
	{
		base.Init();
		base.ModuleType = EInitDataModuleType.Movement;
	}
}
