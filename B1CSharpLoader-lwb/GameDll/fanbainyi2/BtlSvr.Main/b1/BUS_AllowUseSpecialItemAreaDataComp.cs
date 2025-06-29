using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_AllowUseSpecialItemAreaDataComp")]
public class BUS_AllowUseSpecialItemAreaDataComp : BUS_AreaBaseDataContainer
{
	protected override void InitOnNewInCSImpl()
	{
		base.InitOnNewInCSImpl();
		CreateDataClass<b1.BUC_AllowUseSpecialItemAreaData>();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUS_AllowUseSpecialItemAreaDataComp");
	}

	static BUS_AllowUseSpecialItemAreaDataComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_AllowUseSpecialItemAreaDataComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_AllowUseSpecialItemAreaDataComp));
	}
}
