using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_DynamicSDFDataProcessBaseDataComp")]
public class BUS_DynamicSDFDataProcessBaseDataComp : BUS_ActorBaseDataComp
{
	protected override void InitOnNewInCSImpl()
	{
		base.InitOnNewInCSImpl();
		CreateDataClass<BUC_DynamicSDFData>();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUS_DynamicSDFDataProcessBaseDataComp");
	}

	static BUS_DynamicSDFDataProcessBaseDataComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_DynamicSDFDataProcessBaseDataComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_DynamicSDFDataProcessBaseDataComp));
	}
}
