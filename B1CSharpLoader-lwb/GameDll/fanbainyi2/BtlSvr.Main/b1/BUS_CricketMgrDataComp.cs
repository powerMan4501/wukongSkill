using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_CricketMgrDataComp")]
internal class BUS_CricketMgrDataComp : BUS_ActorBaseDataComp
{
	protected override void InitOnNewInCSImpl()
	{
		base.InitOnNewInCSImpl();
		CreateDataClass<b1.BUC_CricketMgrData>();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUS_CricketMgrDataComp");
	}

	static BUS_CricketMgrDataComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BUS_CricketMgrDataComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BUS_CricketMgrDataComp));
	}
}
