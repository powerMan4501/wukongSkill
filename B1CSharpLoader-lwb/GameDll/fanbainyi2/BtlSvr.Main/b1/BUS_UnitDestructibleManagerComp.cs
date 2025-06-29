using System.Collections.Generic;
using b1.EventDelDefine;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

internal class BUS_UnitDestructibleManagerComp : UActorCompBaseCS
{
	private BUC_UnitDestructibleManagerData DestructibleMgrData;

	public override void OnAttach()
	{
		DestructibleMgrData = RequireWritableData<BUC_UnitDestructibleManagerData>();
		base.BUSEventCollection.Evt_ResetActorStatus += new Del_Void_ResetActorReason(OnResetActorStatus);
	}

	public override void PreBeginPlay()
	{
		base.PreBeginPlay();
		foreach (UActorComponent item in Owner.GetComponentsByClass(UClass.GetClass<UChildActorComponent>()))
		{
			UChildActorComponent uChildActorComponent = item as UChildActorComponent;
			if (uChildActorComponent != null && uChildActorComponent.ChildActor != null && uChildActorComponent.ChildActor as BGUFXActorBase != null)
			{
				b1.IBUC_FXActorBaseData readOnlyData = BGU_DataUtil.GetReadOnlyData<b1.IBUC_FXActorBaseData, b1.BUC_FXActorBaseData>(uChildActorComponent.ChildActor);
				if (readOnlyData != null && (readOnlyData.FXActorType == EFXActorType.DestructibleObject || readOnlyData.FXActorType == EFXActorType.NonPreTracingDestructibleObject))
				{
					DestructibleMgrData.DestructibleTypeInfos.Add(new TSoftObject<UChildActorComponent>(uChildActorComponent), uChildActorComponent.ChildActorClass);
				}
			}
		}
	}

	public override void OnBeginPlay()
	{
		base.OnBeginPlay();
		SetCanTick(Val: false);
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		base.OnEndPlay(EndPlayReason);
	}

	private void OnResetActorStatus(EResetActorReason ResetReason)
	{
		foreach (KeyValuePair<TSoftObject<UChildActorComponent>, TSubclassOf<AActor>> destructibleTypeInfo in DestructibleMgrData.DestructibleTypeInfos)
		{
			if (destructibleTypeInfo.Key.Value.ChildActor == null || destructibleTypeInfo.Key.Value.ChildActor.IsPendingKill)
			{
				destructibleTypeInfo.Key.Value.SetChildActorClass(destructibleTypeInfo.Value);
				continue;
			}
			b1.IBUC_DestructibleData readOnlyData = BGU_DataUtil.GetReadOnlyData<b1.IBUC_DestructibleData, b1.BUC_DestructibleData>(destructibleTypeInfo.Key.Value.ChildActor);
			if (readOnlyData != null && readOnlyData.IsDestroyed)
			{
				destructibleTypeInfo.Key.Value.SetChildActorClass(destructibleTypeInfo.Value);
			}
		}
	}
}
