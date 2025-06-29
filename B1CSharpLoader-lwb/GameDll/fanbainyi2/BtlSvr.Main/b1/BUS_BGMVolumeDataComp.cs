using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_BGMVolumeDataComp")]
public class BUS_BGMVolumeDataComp : BUS_ActorBaseDataComp
{
	protected override void InitOnNewInCSImpl()
	{
		base.InitOnNewInCSImpl();
		CreateDataClass<b1.BUC_BGMVolumeData>();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUS_BGMVolumeDataComp");
	}

	static BUS_BGMVolumeDataComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_BGMVolumeDataComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_BGMVolumeDataComp));
	}
}
