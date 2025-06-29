using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_GroupAIDataComp")]
public class BUS_GroupAIDataComp : BUS_AreaBaseDataContainer
{
	protected override void InitOnNewInCSImpl()
	{
		base.InitOnNewInCSImpl();
		CreateDataClass<b1.BUC_GroupAIAreaLogicData>();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUS_GroupAIDataComp");
	}

	static BUS_GroupAIDataComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_GroupAIDataComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_GroupAIDataComp));
	}
}
