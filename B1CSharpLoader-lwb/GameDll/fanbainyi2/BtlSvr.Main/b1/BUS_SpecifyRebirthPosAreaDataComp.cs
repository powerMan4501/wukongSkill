using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_SpecifyRebirthPosAreaDataComp")]
public class BUS_SpecifyRebirthPosAreaDataComp : BUS_AreaBaseDataContainer
{
	protected override void InitOnNewInCSImpl()
	{
		base.InitOnNewInCSImpl();
		CreateDataClass<BUC_SpecifyRebirthPosAreaData>();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUS_SpecifyRebirthPosAreaDataComp");
	}

	static BUS_SpecifyRebirthPosAreaDataComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_SpecifyRebirthPosAreaDataComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_SpecifyRebirthPosAreaDataComp));
	}
}
