using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_MeditationPointDataComp")]
internal class BUS_MeditationPointDataComp : BUS_InteractiveActorDataComp
{
	protected override void InitOnNewInCSImpl()
	{
		base.InitOnNewInCSImpl();
		CreateDataClass<BUC_MeditationPointData>();
		CreateDataClass<BUC_FlowGeneralData>();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUS_MeditationPointDataComp");
	}

	static BUS_MeditationPointDataComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BUS_MeditationPointDataComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BUS_MeditationPointDataComp));
	}
}
