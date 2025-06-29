using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUEnvironmentControllerBase")]
internal class BGUEnvironmentControllerBase : BGUActorBaseCS
{
	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		base.Tags.Add(B1GlobalFNames.EnvironmentCtrlMgr);
	}

	public override void InitAllComp()
	{
		base.InitAllComp();
		base.ActorCompContainerCS.AddComp(new b1.BUS_EnvCtrlComp());
	}

	protected override void CreateDataContainer(FObjectInitializer initializer)
	{
		base.DataComp = initializer.CreateDefaultSubobject<BUS_EnvCtrlActorDataComp>(this, B1GlobalFNames.EnvCtrlActorDataComp);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGUEnvironmentControllerBase");
	}

	static BGUEnvironmentControllerBase()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BGUEnvironmentControllerBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BGUEnvironmentControllerBase));
	}
}
