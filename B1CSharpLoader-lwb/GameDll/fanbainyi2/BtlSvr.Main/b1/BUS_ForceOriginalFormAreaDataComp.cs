using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_ForceOriginalFormAreaDataComp")]
public class BUS_ForceOriginalFormAreaDataComp : BUS_AreaBaseDataContainer
{
	protected override void InitOnNewInCSImpl()
	{
		base.InitOnNewInCSImpl();
		CreateDataClass<BUC_ForceOriginalFormAreaLogicData>();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUS_ForceOriginalFormAreaDataComp");
	}

	static BUS_ForceOriginalFormAreaDataComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_ForceOriginalFormAreaDataComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_ForceOriginalFormAreaDataComp));
	}
}
