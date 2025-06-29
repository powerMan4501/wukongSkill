using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_EnvironmentItemStateMachineDataComp")]
public class BUS_EnvironmentItemStateMachineDataComp : BUS_ActorBaseDataComp
{
	protected override void InitOnNewInCSImpl()
	{
		base.InitOnNewInCSImpl();
		CreateDataClass<BUC_QuestOverlapData>();
		CreateDataClass<b1.BUC_EnvironmentItemStateMachineData>();
		CreateDataClass<BUC_AKMgrData>();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUS_EnvironmentItemStateMachineDataComp");
	}

	static BUS_EnvironmentItemStateMachineDataComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_EnvironmentItemStateMachineDataComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_EnvironmentItemStateMachineDataComp));
	}
}
