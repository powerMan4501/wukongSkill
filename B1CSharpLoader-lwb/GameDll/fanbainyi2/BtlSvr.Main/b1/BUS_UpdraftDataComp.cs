using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_UpdraftDataComp")]
public class BUS_UpdraftDataComp : BUS_ActorBaseDataComp
{
	protected override void InitOnNewInCSImpl()
	{
		base.InitOnNewInCSImpl();
		CreateDataClass<BUC_UpdraftVolumeData>();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUS_UpdraftDataComp");
	}

	static BUS_UpdraftDataComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_UpdraftDataComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_UpdraftDataComp));
	}
}
