namespace b1;

internal class GSPatrolInitDataModule : GSInitDataModuleBase
{
	public BUC_PatrolData PatrolData { get; set; }

	public override void Init()
	{
		base.Init();
		base.ModuleType = EInitDataModuleType.Patrol;
	}
}
