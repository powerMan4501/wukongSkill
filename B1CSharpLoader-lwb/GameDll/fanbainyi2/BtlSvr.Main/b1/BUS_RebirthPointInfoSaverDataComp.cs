using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_RebirthPointInfoSaverDataComp")]
internal class BUS_RebirthPointInfoSaverDataComp : BUS_ActorBaseDataComp
{
	protected override void InitOnNewInCSImpl()
	{
		base.InitOnNewInCSImpl();
		CreateDataClass<b1.BUC_RebirthPointInfoSaveData>();
		CreateDataClass<BUC_FlowGeneralData>();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUS_RebirthPointInfoSaverDataComp");
	}

	static BUS_RebirthPointInfoSaverDataComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BUS_RebirthPointInfoSaverDataComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BUS_RebirthPointInfoSaverDataComp));
	}
}
