using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_SceneRotateTriggerDataComp")]
public class BUS_SceneRotateTriggerDataComp : BUS_AreaBaseDataContainer
{
	protected override void InitOnNewInCSImpl()
	{
		base.InitOnNewInCSImpl();
		CreateDataClass<b1.BUC_SceneRotateTriggerData>();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUS_SceneRotateTriggerDataComp");
	}

	static BUS_SceneRotateTriggerDataComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_SceneRotateTriggerDataComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_SceneRotateTriggerDataComp));
	}
}
