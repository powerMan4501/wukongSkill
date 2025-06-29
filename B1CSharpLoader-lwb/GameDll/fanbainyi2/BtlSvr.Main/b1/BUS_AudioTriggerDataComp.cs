using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_AudioTriggerDataComp")]
internal class BUS_AudioTriggerDataComp : b1.BUS_TriggerBoxDataComp
{
	protected override void InitOnNewInCSImpl()
	{
		base.InitOnNewInCSImpl();
		CreateDataClass<b1.BUC_AudioTriggerData>();
		CreateDataClass<b1.BUC_AudioTriggerConfigData>();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUS_AudioTriggerDataComp");
	}

	static BUS_AudioTriggerDataComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BUS_AudioTriggerDataComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BUS_AudioTriggerDataComp));
	}
}
