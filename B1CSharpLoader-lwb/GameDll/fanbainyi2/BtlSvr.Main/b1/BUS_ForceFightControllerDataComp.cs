using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_ForceFightControllerDataComp")]
public class BUS_ForceFightControllerDataComp : BUS_AreaBaseDataContainer
{
	protected override void InitOnNewInCSImpl()
	{
		base.InitOnNewInCSImpl();
		CreateDataClass<b1.BUC_ForceFightControllerLogicData>();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUS_ForceFightControllerDataComp");
	}

	static BUS_ForceFightControllerDataComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_ForceFightControllerDataComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_ForceFightControllerDataComp));
	}
}
