using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_SpiderNavigationDataComp")]
internal class BUS_SpiderNavigationDataComp : BUS_ActorBaseDataComp
{
	protected override void InitOnNewInCSImpl()
	{
		base.InitOnNewInCSImpl();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUS_SpiderNavigationDataComp");
	}

	static BUS_SpiderNavigationDataComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BUS_SpiderNavigationDataComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BUS_SpiderNavigationDataComp));
	}
}
