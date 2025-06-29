using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_SDFMakerDataComp")]
public class BUS_SDFMakerDataComp : BUS_ActorBaseDataComp
{
	protected override void InitOnNewInCSImpl()
	{
		base.InitOnNewInCSImpl();
		CreateDataClass<BUC_TickRateData>();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUS_SDFMakerDataComp");
	}

	static BUS_SDFMakerDataComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_SDFMakerDataComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_SDFMakerDataComp));
	}
}
