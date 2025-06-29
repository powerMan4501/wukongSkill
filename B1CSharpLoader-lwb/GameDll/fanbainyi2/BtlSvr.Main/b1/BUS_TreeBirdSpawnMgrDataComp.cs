using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_TreeBirdSpawnMgrDataComp")]
public class BUS_TreeBirdSpawnMgrDataComp : BUS_ActorBaseDataComp
{
	protected override void InitOnNewInCSImpl()
	{
		base.InitOnNewInCSImpl();
		CreateDataClass<b1.BUC_TreeBirdSpawnMgrData>();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUS_TreeBirdSpawnMgrDataComp");
	}

	static BUS_TreeBirdSpawnMgrDataComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_TreeBirdSpawnMgrDataComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_TreeBirdSpawnMgrDataComp));
	}
}
