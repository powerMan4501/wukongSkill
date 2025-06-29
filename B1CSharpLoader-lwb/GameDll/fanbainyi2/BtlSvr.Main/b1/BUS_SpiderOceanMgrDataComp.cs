using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_SpiderOceanMgrDataComp")]
public class BUS_SpiderOceanMgrDataComp : BUS_ActorBaseDataComp
{
	protected override void InitOnNewInCSImpl()
	{
		base.InitOnNewInCSImpl();
		CreateDataClass<BUC_QuestOverlapData>();
		CreateDataClass<BUC_SpiderOceanMgrData>();
		CreateDataClass<BUC_GuidData>();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUS_SpiderOceanMgrDataComp");
	}

	static BUS_SpiderOceanMgrDataComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_SpiderOceanMgrDataComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_SpiderOceanMgrDataComp));
	}
}
