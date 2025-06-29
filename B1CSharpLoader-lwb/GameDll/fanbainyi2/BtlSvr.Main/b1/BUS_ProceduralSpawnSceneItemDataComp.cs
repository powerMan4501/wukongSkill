using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_ProceduralSpawnSceneItemDataComp")]
public class BUS_ProceduralSpawnSceneItemDataComp : BUS_ActorBaseDataComp
{
	protected override void InitOnNewInCSImpl()
	{
		base.InitOnNewInCSImpl();
		CreateDataClass<BUC_ProceduralSpawnSceneItemData>();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUS_ProceduralSpawnSceneItemDataComp");
	}

	static BUS_ProceduralSpawnSceneItemDataComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_ProceduralSpawnSceneItemDataComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_ProceduralSpawnSceneItemDataComp));
	}
}
