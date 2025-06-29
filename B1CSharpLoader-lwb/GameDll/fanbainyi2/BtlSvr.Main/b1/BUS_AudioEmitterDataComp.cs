using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_AudioEmitterDataComp")]
public class BUS_AudioEmitterDataComp : BUS_ActorBaseDataComp
{
	protected override void InitOnNewInCSImpl()
	{
		base.InitOnNewInCSImpl();
		CreateDataClass<BUC_AudioEmitterData>();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUS_AudioEmitterDataComp");
	}

	static BUS_AudioEmitterDataComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_AudioEmitterDataComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_AudioEmitterDataComp));
	}
}
