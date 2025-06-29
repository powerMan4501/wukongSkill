namespace b1;

internal class GSWakeUpInitDataModule : GSInitDataModuleBase
{
	public BUC_WakeUpData WakeUpData { get; set; }

	public override void Init()
	{
		base.Init();
		base.ModuleType = EInitDataModuleType.WakeUp;
	}
}
