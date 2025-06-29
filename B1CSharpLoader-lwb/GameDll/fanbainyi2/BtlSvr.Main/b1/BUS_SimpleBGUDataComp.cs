using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_SimpleBGUDataComp")]
public class BUS_SimpleBGUDataComp : BUS_BGUDataComp
{
	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUS_SimpleBGUDataComp");
	}

	static BUS_SimpleBGUDataComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_SimpleBGUDataComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_SimpleBGUDataComp));
	}
}
