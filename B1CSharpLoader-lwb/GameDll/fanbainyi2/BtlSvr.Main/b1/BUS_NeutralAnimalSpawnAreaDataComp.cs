using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_NeutralAnimalSpawnAreaDataComp")]
public class BUS_NeutralAnimalSpawnAreaDataComp : BUS_AreaBaseDataContainer
{
	protected override void InitOnNewInCSImpl()
	{
		base.InitOnNewInCSImpl();
		CreateDataClass<BUC_NeutralAnimalAreaLogicData>();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUS_NeutralAnimalSpawnAreaDataComp");
	}

	static BUS_NeutralAnimalSpawnAreaDataComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_NeutralAnimalSpawnAreaDataComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_NeutralAnimalSpawnAreaDataComp));
	}
}
