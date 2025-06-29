using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_FixCameraTriggerDataComp")]
internal class BUS_FixCameraTriggerDataComp : b1.BUS_TriggerBoxDataComp
{
	protected override void InitOnNewInCSImpl()
	{
		base.InitOnNewInCSImpl();
		CreateDataClass<b1.BUC_FixCameraTriggerData>();
		CreateDataClass<b1.BUC_FixCameraTriggerConfigData>();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUS_FixCameraTriggerDataComp");
	}

	static BUS_FixCameraTriggerDataComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BUS_FixCameraTriggerDataComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BUS_FixCameraTriggerDataComp));
	}
}
