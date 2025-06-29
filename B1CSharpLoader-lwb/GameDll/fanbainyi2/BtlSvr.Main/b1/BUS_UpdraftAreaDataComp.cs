using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_UpdraftAreaDataComp")]
public class BUS_UpdraftAreaDataComp : BUS_AreaBaseDataContainer
{
	protected override void InitOnNewInCSImpl()
	{
		base.InitOnNewInCSImpl();
		CreateDataClass<BUC_UpdraftLogicData>();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUS_UpdraftAreaDataComp");
	}

	static BUS_UpdraftAreaDataComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_UpdraftAreaDataComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_UpdraftAreaDataComp));
	}
}
