using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_TortoiseLevelStreamingMgrDataComp")]
public class BUS_TortoiseLevelStreamingMgrDataComp : BUS_ActorBaseDataComp
{
	private b1.BUC_TortoiseLevelStreamingMgrData MgrData;

	protected override void InitOnNewInCSImpl()
	{
		base.InitOnNewInCSImpl();
		MgrData = CreateDataClass<b1.BUC_TortoiseLevelStreamingMgrData>();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUS_TortoiseLevelStreamingMgrDataComp");
	}

	static BUS_TortoiseLevelStreamingMgrDataComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_TortoiseLevelStreamingMgrDataComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_TortoiseLevelStreamingMgrDataComp));
	}
}
