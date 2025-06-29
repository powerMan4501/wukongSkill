using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_ZBBCreatorDataComp")]
internal class BUS_ZBBCreatorDataComp : BUS_ActorBaseDataComp
{
	protected override void InitOnNewInCSImpl()
	{
		base.InitOnNewInCSImpl();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUS_ZBBCreatorDataComp");
	}

	static BUS_ZBBCreatorDataComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BUS_ZBBCreatorDataComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BUS_ZBBCreatorDataComp));
	}
}
