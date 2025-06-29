using System;
using b1;
using UnrealEngine.Runtime;

namespace GSDispLib;

[UClass]
[BlueprintSpawnableComponent]
[USharpPath("/Script/b1-Managed.BGU_DispLibUComponentBase")]
public class BGU_DispLibUComponentBase : UBaseActorComp
{
	protected virtual void DebugTick(float DeltaTime)
	{
	}

	protected virtual void Reset()
	{
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGU_DispLibUComponentBase");
	}

	static BGU_DispLibUComponentBase()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGU_DispLibUComponentBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGU_DispLibUComponentBase));
	}
}
