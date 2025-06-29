using System;
using System.Collections.Generic;
using GSDispLib;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_ProceduralEnvInteractionDataComp")]
public class BUS_ProceduralEnvInteractionDataComp : BUS_ActorBaseDataComp
{
	protected override void InitOnNewInCSImpl()
	{
		base.InitOnNewInCSImpl();
		CreateDataClass<BUC_TickRateData>();
		CreateDataClass<b1.BUC_MatMgrData>();
		CreateDataClass<b1.BUC_ProceduralEnvInteractionData>();
		BUC_DispLibDBCBaseData bUC_DispLibDBCBaseData = CreateDataClass<BUC_DispLibDBCBaseData>();
		CreateDataClass<BUC_DispLibDBCQueueData>();
		BUC_DispLibUnitRendererBaseData bUC_DispLibUnitRendererBaseData = CreateDataClass<BUC_DispLibUnitRendererBaseData>();
		List<UActorComponent> componentsByClass = Owner.GetComponentsByClass(UClass.GetClass<UPrimitiveComponent>());
		if (componentsByClass != null && componentsByClass.Count > 0)
		{
			bUC_DispLibUnitRendererBaseData.Init(0f, 0, componentsByClass[0] as UPrimitiveComponent);
			bUC_DispLibDBCBaseData.Init(componentsByClass[0] as USceneComponent, DispLibDBCActorGroup.Interact, GetOwner());
		}
		CreateDataClass<BUC_DispLibSetUnitMaterialsParamsRequestsQueueData>();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUS_ProceduralEnvInteractionDataComp");
	}

	static BUS_ProceduralEnvInteractionDataComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_ProceduralEnvInteractionDataComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_ProceduralEnvInteractionDataComp));
	}
}
