using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_TriggerBoxDataComp")]
internal class BUS_TriggerBoxDataComp : BUS_ActorBaseDataComp
{
	protected override void InitOnNewInCSImpl()
	{
		base.InitOnNewInCSImpl();
		CreateDataClass<BUC_TriggerBoxData>();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUS_TriggerBoxDataComp");
	}

	static BUS_TriggerBoxDataComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BUS_TriggerBoxDataComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BUS_TriggerBoxDataComp));
	}
}
