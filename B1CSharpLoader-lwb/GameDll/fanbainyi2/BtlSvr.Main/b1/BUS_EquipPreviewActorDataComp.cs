using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_EquipPreviewActorDataComp")]
internal class BUS_EquipPreviewActorDataComp : BUS_ActorBaseDataComp
{
	protected override void InitOnNewInCSImpl()
	{
		base.InitOnNewInCSImpl();
		CreateDataClass<BUC_CharacterModularData>();
		CreateDataClass<BUC_EquipData>();
		CreateDataClass<BUC_TickRateData>();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUS_EquipPreviewActorDataComp");
	}

	static BUS_EquipPreviewActorDataComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BUS_EquipPreviewActorDataComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BUS_EquipPreviewActorDataComp));
	}
}
