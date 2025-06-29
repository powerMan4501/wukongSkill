using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_SelectAreaDataComp")]
internal class BUS_SelectAreaDataComp : BUS_ActorBaseDataComp
{
	protected override void InitOnNewInCSImpl()
	{
		base.InitOnNewInCSImpl();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUS_SelectAreaDataComp");
	}

	static BUS_SelectAreaDataComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BUS_SelectAreaDataComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BUS_SelectAreaDataComp));
	}
}
