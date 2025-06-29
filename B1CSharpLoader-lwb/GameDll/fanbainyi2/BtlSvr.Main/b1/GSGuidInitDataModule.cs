namespace b1;

internal class GSGuidInitDataModule : GSInitDataModuleBase
{
	public BUC_GuidData GuidData { get; set; }

	public override void Init()
	{
		base.Init();
		base.ModuleType = EInitDataModuleType.Guid;
	}
}
