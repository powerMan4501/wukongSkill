using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace HelloUSharp;

[BlueprintSpawnableComponent]
[BlueprintType]
[Blueprintable]
[UClass]
[USharpPath("/Script/b1-Managed.HelloUTestComp")]
public class HelloUTestComp : UActorComponent
{
	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.HelloUTestComp");
	}

	static HelloUTestComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(HelloUTestComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(HelloUTestComp));
	}
}
