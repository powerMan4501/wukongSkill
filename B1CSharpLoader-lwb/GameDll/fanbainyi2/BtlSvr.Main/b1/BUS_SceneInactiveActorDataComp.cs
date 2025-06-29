using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_SceneInactiveActorDataComp")]
internal class BUS_SceneInactiveActorDataComp : BUS_FXDataComp
{
	protected override void InitOnNewInCSImpl()
	{
		base.InitOnNewInCSImpl();
		CreateDataClass<BUC_SceneInactiveActorData>();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUS_SceneInactiveActorDataComp");
	}

	static BUS_SceneInactiveActorDataComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BUS_SceneInactiveActorDataComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BUS_SceneInactiveActorDataComp));
	}
}
