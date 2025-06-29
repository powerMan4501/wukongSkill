using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_SpawnMultiPointDataComp")]
internal class BUS_SpawnMultiPointDataComp : BUS_FlowDataComp
{
	protected override void InitOnNewInCSImpl()
	{
		base.InitOnNewInCSImpl();
		CreateDataClass<BUC_SpawnMultiPointData>();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUS_SpawnMultiPointDataComp");
	}

	static BUS_SpawnMultiPointDataComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BUS_SpawnMultiPointDataComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BUS_SpawnMultiPointDataComp));
	}
}
