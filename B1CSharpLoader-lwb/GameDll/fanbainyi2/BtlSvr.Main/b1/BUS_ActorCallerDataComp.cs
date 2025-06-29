using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_ActorCallerDataComp")]
internal class BUS_ActorCallerDataComp : BUS_ActorBaseDataComp
{
	protected override void InitOnNewInCSImpl()
	{
		base.InitOnNewInCSImpl();
		CreateDataClass<b1.BUC_ActorCallData>();
		CreateDataClass<BUC_FlowGeneralData>();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUS_ActorCallerDataComp");
	}

	static BUS_ActorCallerDataComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BUS_ActorCallerDataComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BUS_ActorCallerDataComp));
	}
}
