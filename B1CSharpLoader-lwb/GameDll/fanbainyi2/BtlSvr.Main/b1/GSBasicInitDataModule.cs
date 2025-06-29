using UnrealEngine.Runtime;

namespace b1;

internal class GSBasicInitDataModule : GSInitDataModuleBase
{
	public FSoftObjectPath ActorClsPath;

	public int ResID { get; set; }

	public FTransform ActorTrans { get; set; }

	public string WorldPackageName { get; set; }

	public override void Init()
	{
		base.Init();
		base.ModuleType = EInitDataModuleType.Basic;
	}
}
