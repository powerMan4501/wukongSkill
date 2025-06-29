using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_PlaceholderActorDataComp")]
internal class BUS_PlaceholderActorDataComp : BUS_InteractiveActorDataComp
{
	protected override void InitOnNewInCSImpl()
	{
		base.InitOnNewInCSImpl();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUS_PlaceholderActorDataComp");
	}

	static BUS_PlaceholderActorDataComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BUS_PlaceholderActorDataComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BUS_PlaceholderActorDataComp));
	}
}
