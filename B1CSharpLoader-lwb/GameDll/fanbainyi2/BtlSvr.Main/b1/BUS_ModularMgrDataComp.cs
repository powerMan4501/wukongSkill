using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_ModularMgrDataComp")]
public class BUS_ModularMgrDataComp : BUS_ActorBaseDataComp
{
	protected override void InitOnNewInCSImpl()
	{
		base.InitOnNewInCSImpl();
		CreateDataClass<b1.BUC_ModularMgrData>();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUS_ModularMgrDataComp");
	}

	static BUS_ModularMgrDataComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_ModularMgrDataComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_ModularMgrDataComp));
	}
}
