using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_DropItemDataComp")]
internal class BUS_DropItemDataComp : BUS_InteractiveActorDataComp
{
	protected override void InitOnNewInCSImpl()
	{
		base.InitOnNewInCSImpl();
		CreateDataClass<BUC_DropItemData>();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUS_DropItemDataComp");
	}

	static BUS_DropItemDataComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BUS_DropItemDataComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BUS_DropItemDataComp));
	}
}
