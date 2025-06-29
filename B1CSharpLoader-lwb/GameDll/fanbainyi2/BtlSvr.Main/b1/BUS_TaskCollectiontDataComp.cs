using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_TaskCollectiontDataComp")]
internal class BUS_TaskCollectiontDataComp : BUS_InteractiveActorDataComp
{
	protected override void InitOnNewInCSImpl()
	{
		base.InitOnNewInCSImpl();
		CreateDataClass<BUC_TaskCollectionData>();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUS_TaskCollectiontDataComp");
	}

	static BUS_TaskCollectiontDataComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BUS_TaskCollectiontDataComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BUS_TaskCollectiontDataComp));
	}
}
