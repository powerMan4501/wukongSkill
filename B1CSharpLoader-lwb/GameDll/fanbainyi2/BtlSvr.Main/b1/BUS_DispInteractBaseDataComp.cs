using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_DispInteractBaseDataComp")]
public class BUS_DispInteractBaseDataComp : BUS_ActorBaseDataComp
{
	protected override void InitOnNewInCSImpl()
	{
		base.InitOnNewInCSImpl();
		CreateDataClass<BUC_InteractDrawData>();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUS_DispInteractBaseDataComp");
	}

	static BUS_DispInteractBaseDataComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_DispInteractBaseDataComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_DispInteractBaseDataComp));
	}
}
