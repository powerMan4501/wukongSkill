using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_AutoCloudMoveAreaDataComp")]
public class BUS_AutoCloudMoveAreaDataComp : BUS_AreaBaseDataContainer
{
	protected override void InitOnNewInCSImpl()
	{
		base.InitOnNewInCSImpl();
		CreateDataClass<b1.BUC_AutoCloudMoveAreaData>();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUS_AutoCloudMoveAreaDataComp");
	}

	static BUS_AutoCloudMoveAreaDataComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_AutoCloudMoveAreaDataComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_AutoCloudMoveAreaDataComp));
	}
}
