using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_LightningFXActorDataComp")]
public class BUS_LightningFXActorDataComp : BUS_FXDataComp
{
	protected override void InitOnNewInCSImpl()
	{
		base.InitOnNewInCSImpl();
		CreateDataClass<b1.BUC_LightningFXData>();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUS_LightningFXActorDataComp");
	}

	static BUS_LightningFXActorDataComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_LightningFXActorDataComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_LightningFXActorDataComp));
	}
}
