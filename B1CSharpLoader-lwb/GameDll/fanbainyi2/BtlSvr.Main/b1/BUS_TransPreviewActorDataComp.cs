using System;
using GSDispLib;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_TransPreviewActorDataComp")]
internal class BUS_TransPreviewActorDataComp : BUS_ActorBaseDataComp
{
	protected override void InitOnNewInCSImpl()
	{
		base.InitOnNewInCSImpl();
		CreateDataClass<BUC_CharacterModularData>();
		CreateDataClass<BUC_DispLibUnitRendererBaseData>();
		CreateDataClass<BUC_DispLibSetUnitMaterialsParamsRequestsQueueData>();
		CreateDataClass<BUC_DispLibDBCBaseData>();
		CreateDataClass<BUC_DispLibDBCQueueData>();
		CreateDataClass<BUC_TickRateData>();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUS_TransPreviewActorDataComp");
	}

	static BUS_TransPreviewActorDataComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BUS_TransPreviewActorDataComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BUS_TransPreviewActorDataComp));
	}
}
