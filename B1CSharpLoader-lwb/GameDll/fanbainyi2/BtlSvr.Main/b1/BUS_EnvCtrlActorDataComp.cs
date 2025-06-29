using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_EnvCtrlActorDataComp")]
public class BUS_EnvCtrlActorDataComp : BUS_ActorBaseDataComp
{
	protected override void InitOnNewInCSImpl()
	{
		base.InitOnNewInCSImpl();
		CreateDataClass<b1.BUC_EnvCtrlData>();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUS_EnvCtrlActorDataComp");
	}

	static BUS_EnvCtrlActorDataComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_EnvCtrlActorDataComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_EnvCtrlActorDataComp));
	}
}
