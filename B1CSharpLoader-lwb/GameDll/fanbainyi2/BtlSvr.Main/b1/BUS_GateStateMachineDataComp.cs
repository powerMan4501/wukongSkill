using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_GateStateMachineDataComp")]
internal class BUS_GateStateMachineDataComp : BUS_ActorBaseDataComp
{
	protected override void InitOnNewInCSImpl()
	{
		base.InitOnNewInCSImpl();
		CreateDataClass<b1.BUC_GateStateMachineData>();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUS_GateStateMachineDataComp");
	}

	static BUS_GateStateMachineDataComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BUS_GateStateMachineDataComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BUS_GateStateMachineDataComp));
	}
}
