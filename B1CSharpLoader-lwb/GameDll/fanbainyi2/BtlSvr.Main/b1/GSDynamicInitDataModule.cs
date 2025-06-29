namespace b1;

internal class GSDynamicInitDataModule : GSInitDataModuleBase
{
	public override void Init()
	{
		base.Init();
		base.ModuleType = EInitDataModuleType.Dynamic;
	}
}
