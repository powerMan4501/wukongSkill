using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_ForceOriginalFormDataComp")]
public class BUS_ForceOriginalFormDataComp : BUS_ActorBaseDataComp
{
	protected override void InitOnNewInCSImpl()
	{
		base.InitOnNewInCSImpl();
		CreateDataClass<BUC_QuestOverlapData>();
		CreateDataClass<BUC_ForceOriginalFormData>();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUS_ForceOriginalFormDataComp");
	}

	static BUS_ForceOriginalFormDataComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_ForceOriginalFormDataComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_ForceOriginalFormDataComp));
	}
}
