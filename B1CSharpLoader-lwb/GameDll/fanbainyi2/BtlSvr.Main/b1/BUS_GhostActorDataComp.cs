using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_GhostActorDataComp")]
public class BUS_GhostActorDataComp : BUS_ActorBaseDataComp
{
	protected override void InitOnNewInCSImpl()
	{
		base.InitOnNewInCSImpl();
		CreateDataClass<b1.BUC_GhostPoseableData>();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUS_GhostActorDataComp");
	}

	static BUS_GhostActorDataComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_GhostActorDataComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_GhostActorDataComp));
	}
}
