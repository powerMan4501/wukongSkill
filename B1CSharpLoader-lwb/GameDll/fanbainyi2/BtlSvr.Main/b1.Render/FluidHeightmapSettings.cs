using System;
using UnrealEngine.Runtime;

namespace b1.Render;

[UClass]
[USharpPath("/Script/b1-Managed.FluidHeightmapSettings")]
internal class FluidHeightmapSettings : UObject
{
	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.FluidHeightmapSettings");
	}

	static FluidHeightmapSettings()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.Render.FluidHeightmapSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.Render.FluidHeightmapSettings));
	}
}
