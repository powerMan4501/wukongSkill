using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_DamageCastDataComp")]
public class BUS_DamageCastDataComp : BUS_ActorBaseDataComp
{
	protected override void InitOnNewInCSImpl()
	{
		base.InitOnNewInCSImpl();
		CreateDataClass<b1.BUC_TriggerEffectData>();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUS_DamageCastDataComp");
	}

	static BUS_DamageCastDataComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_DamageCastDataComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_DamageCastDataComp));
	}
}
