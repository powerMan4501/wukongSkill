using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_SceneItemDataComp")]
public class BUS_SceneItemDataComp : BUS_ActorBaseDataComp
{
	protected override void InitOnNewInCSImpl()
	{
		base.InitOnNewInCSImpl();
		CreateDataClass<BUC_SceneItemCommData>();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUS_SceneItemDataComp");
	}

	static BUS_SceneItemDataComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_SceneItemDataComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_SceneItemDataComp));
	}
}
