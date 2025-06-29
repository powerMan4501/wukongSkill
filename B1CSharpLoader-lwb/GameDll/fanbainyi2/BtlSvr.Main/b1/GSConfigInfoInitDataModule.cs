namespace b1;

internal class GSConfigInfoInitDataModule : GSInitDataModuleBase
{
	public FUnitAIDesc UnitAIDesc { get; set; }

	public override void Init()
	{
		base.Init();
		base.ModuleType = EInitDataModuleType.ConfigInfo;
	}
}
