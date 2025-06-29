using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_DeadAreaDataComp")]
public class BUS_DeadAreaDataComp : BUS_AreaBaseDataContainer
{
	protected override void InitOnNewInCSImpl()
	{
		base.InitOnNewInCSImpl();
		CreateDataClass<BUC_DeadAreaLogicData>();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUS_DeadAreaDataComp");
	}

	static BUS_DeadAreaDataComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_DeadAreaDataComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_DeadAreaDataComp));
	}
}
