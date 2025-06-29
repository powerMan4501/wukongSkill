using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_GroupAIAreaDataComp")]
internal class BUS_GroupAIAreaDataComp : BUS_ActorBaseDataComp
{
	protected override void InitOnNewInCSImpl()
	{
		base.InitOnNewInCSImpl();
		CreateDataClass<b1.BUC_GroupAIAreaData>();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUS_GroupAIAreaDataComp");
	}

	static BUS_GroupAIAreaDataComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BUS_GroupAIAreaDataComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BUS_GroupAIAreaDataComp));
	}
}
