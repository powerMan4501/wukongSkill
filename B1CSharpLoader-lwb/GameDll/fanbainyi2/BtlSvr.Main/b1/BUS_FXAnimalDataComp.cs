using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_FXAnimalDataComp")]
public class BUS_FXAnimalDataComp : BUS_ActorBaseDataComp
{
	protected override void InitOnNewInCSImpl()
	{
		base.InitOnNewInCSImpl();
		CreateDataClass<BUC_FXAnimalCommData>();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUS_FXAnimalDataComp");
	}

	static BUS_FXAnimalDataComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_FXAnimalDataComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_FXAnimalDataComp));
	}
}
