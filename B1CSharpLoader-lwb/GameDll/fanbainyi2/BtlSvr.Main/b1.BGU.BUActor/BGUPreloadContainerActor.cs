using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.BGU.BUActor;

[Blueprintable]
[UClass]
[BlueprintType]
[USharpPath("/Script/b1-Managed.BGUPreloadContainerActor")]
public class BGUPreloadContainerActor : AActor
{
	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGUPreloadContainerActor");
	}

	static BGUPreloadContainerActor()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUPreloadContainerActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGUPreloadContainerActor));
	}
}
