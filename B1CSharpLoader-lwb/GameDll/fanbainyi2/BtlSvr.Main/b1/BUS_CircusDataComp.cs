using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_CircusDataComp")]
internal class BUS_CircusDataComp : BUS_ActorBaseDataComp
{
	protected override void InitOnNewInCSImpl()
	{
		base.InitOnNewInCSImpl();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUS_CircusDataComp");
	}

	static BUS_CircusDataComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BUS_CircusDataComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BUS_CircusDataComp));
	}
}
