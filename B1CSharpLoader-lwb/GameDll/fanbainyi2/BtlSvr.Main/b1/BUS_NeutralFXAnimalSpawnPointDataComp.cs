using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_NeutralFXAnimalSpawnPointDataComp")]
public class BUS_NeutralFXAnimalSpawnPointDataComp : BUS_ActorBaseDataComp
{
	protected override void InitOnNewInCSImpl()
	{
		base.InitOnNewInCSImpl();
		CreateDataClass<b1.BUC_NeutralFXAnimalSpawnData>();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUS_NeutralFXAnimalSpawnPointDataComp");
	}

	static BUS_NeutralFXAnimalSpawnPointDataComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_NeutralFXAnimalSpawnPointDataComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_NeutralFXAnimalSpawnPointDataComp));
	}
}
