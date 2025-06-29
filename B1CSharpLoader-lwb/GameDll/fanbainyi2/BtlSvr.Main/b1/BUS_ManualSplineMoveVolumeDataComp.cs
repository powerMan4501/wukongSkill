using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_ManualSplineMoveVolumeDataComp")]
internal class BUS_ManualSplineMoveVolumeDataComp : BUS_ActorBaseDataComp
{
	protected override void InitOnNewInCSImpl()
	{
		base.InitOnNewInCSImpl();
		CreateDataClass<BUC_ManualSplineMoveVolumeData>();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUS_ManualSplineMoveVolumeDataComp");
	}

	static BUS_ManualSplineMoveVolumeDataComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BUS_ManualSplineMoveVolumeDataComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BUS_ManualSplineMoveVolumeDataComp));
	}
}
