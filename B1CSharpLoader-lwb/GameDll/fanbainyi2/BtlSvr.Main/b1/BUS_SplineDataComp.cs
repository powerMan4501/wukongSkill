using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_SplineDataComp")]
internal class BUS_SplineDataComp : BUS_ActorBaseDataComp
{
	protected override void InitOnNewInCSImpl()
	{
		base.InitOnNewInCSImpl();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUS_SplineDataComp");
	}

	static BUS_SplineDataComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BUS_SplineDataComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BUS_SplineDataComp));
	}
}
