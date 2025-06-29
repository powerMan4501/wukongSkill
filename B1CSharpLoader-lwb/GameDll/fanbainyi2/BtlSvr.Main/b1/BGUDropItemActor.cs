using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUDropItemActor")]
public class BGUDropItemActor : BGUInteractiveActorBase
{
	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
	}

	public override void InitAllComp()
	{
		base.InitAllComp();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGUDropItemActor");
	}

	static BGUDropItemActor()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUDropItemActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGUDropItemActor));
	}
}
