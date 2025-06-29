using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_TrainDummyMgrDataComp")]
public class BUS_TrainDummyMgrDataComp : BUS_ActorBaseDataComp
{
	protected override void InitOnNewInCSImpl()
	{
		base.InitOnNewInCSImpl();
		CreateDataClass<BUC_TrainDummyMgrConfigData>();
		CreateDataClass<BUC_TrainDummyMgrData>();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUS_TrainDummyMgrDataComp");
	}

	static BUS_TrainDummyMgrDataComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_TrainDummyMgrDataComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_TrainDummyMgrDataComp));
	}
}
