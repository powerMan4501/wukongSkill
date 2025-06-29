using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace GSDispLib;

[UClass]
[BlueprintSpawnableComponent]
[USharpPath("/Script/b1-Managed.DispLib_DBCDecalComponent")]
public class DispLib_DBCDecalComponent : UDecalComponent
{
	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.DispLib_DBCDecalComponent");
	}

	static DispLib_DBCDecalComponent()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(DispLib_DBCDecalComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(DispLib_DBCDecalComponent));
	}
}
