using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGURideControlTriggerActor")]
public class BGURideControlTriggerActor : BGUActorBaseCS
{
	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
	}

	public override void InitAllComp()
	{
		base.InitAllComp();
		base.ActorCompContainerCS.AddComp(new BUS_RideControlTriggerComp());
	}

	protected override void CreateDataContainer(FObjectInitializer initializer)
	{
		base.DataComp = initializer.CreateDefaultSubobject<BUS_RideControlTriggerDataComp>(this, B1GlobalFNames.RideControlTriggerDataComp);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGURideControlTriggerActor");
	}

	static BGURideControlTriggerActor()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGURideControlTriggerActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGURideControlTriggerActor));
	}
}
