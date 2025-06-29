using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_CollectiontDataComp")]
internal class BUS_CollectiontDataComp : BUS_InteractiveActorDataComp
{
	protected override void InitOnNewInCSImpl()
	{
		base.InitOnNewInCSImpl();
		CreateDataClass<BUC_CollectionData>();
		if (BasicData != null)
		{
			BasicData.ActorType = BGU_ActorType.Collection;
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUS_CollectiontDataComp");
	}

	static BUS_CollectiontDataComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BUS_CollectiontDataComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BUS_CollectiontDataComp));
	}
}
