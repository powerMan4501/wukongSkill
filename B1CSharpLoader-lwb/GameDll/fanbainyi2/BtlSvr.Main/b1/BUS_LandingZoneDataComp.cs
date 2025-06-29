using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_LandingZoneDataComp")]
public class BUS_LandingZoneDataComp : BUS_ActorBaseDataComp
{
	protected override void InitOnNewInCSImpl()
	{
		base.InitOnNewInCSImpl();
		CreateDataClass<BUC_LandingZoneData>();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUS_LandingZoneDataComp");
	}

	static BUS_LandingZoneDataComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_LandingZoneDataComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_LandingZoneDataComp));
	}
}
