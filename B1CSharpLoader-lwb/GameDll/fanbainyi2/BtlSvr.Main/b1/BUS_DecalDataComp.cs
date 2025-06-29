using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_DecalDataComp")]
public class BUS_DecalDataComp : BUS_FXDataComp
{
	protected override void InitOnNewInCSImpl()
	{
		base.InitOnNewInCSImpl();
		CreateDataClass<b1.BUC_DecalConfigData>();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUS_DecalDataComp");
	}

	static BUS_DecalDataComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_DecalDataComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_DecalDataComp));
	}
}
