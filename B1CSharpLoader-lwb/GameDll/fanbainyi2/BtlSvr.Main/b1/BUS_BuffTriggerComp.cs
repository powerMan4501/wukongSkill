using System.Collections.Generic;
using b1.EventDelDefine;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
internal class BUS_BuffTriggerComp : BUS_QuestOverlapComponent
{
	private b1.BUC_BuffTriggerData BuffTriggerData;

	private float ObservedTimer;

	public override void OnAttach()
	{
		base.OnAttach();
		ObservedTimer = 0f;
		BuffTriggerData = RequireWritableData<b1.BUC_BuffTriggerData>();
		base.BUSEventCollection.Evt_NotifyBuffTrigger += new Del_Void(OnNotifyBuffTrigger);
	}

	public override void OnBeginPlay()
	{
		base.OnBeginPlay();
	}

	protected void OnNotifyBuffTrigger()
	{
		OnNotifyStartObserve();
	}

	public override int GetTickGroupMask()
	{
		return 8;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		base.OnTickWithGroup(DeltaTime, TickGroup);
		ObservedTimer += DeltaTime;
		if (ObservedTimer <= 3f)
		{
			return;
		}
		ObservedTimer = 0f;
		if (!base.OverlapData.bOverlapEnabled)
		{
			return;
		}
		foreach (UActorComponent item in base.Owner.GetComponentsByClass(UClass.GetClass<UShapeComponent>()))
		{
			UShapeComponent uShapeComponent = item as UShapeComponent;
			if (uShapeComponent == null)
			{
				continue;
			}
			if (uShapeComponent.GetGenerateOverlapEvents())
			{
				base.CollisionComponents.Add(new TWeakObject<UPrimitiveComponent>(uShapeComponent));
				UBGUFunctionLibraryForCS.BGUBindOnComponentBeginOverlapEvent(uShapeComponent, base.FunctionBinder, B1GlobalFNames.OnCollisionBeginOverlap);
				UBGUFunctionLibraryForCS.BGUBindOnComponentEndOverlapEvent(uShapeComponent, base.FunctionBinder, B1GlobalFNames.OnCollisionEndOverlap);
			}
			uShapeComponent.GetOverlappingActors(out var OverlappingActors, UClass.GetClass<ABGUCharacter>());
			foreach (AActor item2 in OverlappingActors)
			{
				OnCollisionStayOverlap(uShapeComponent, item2, null, 0, bFromSweep: false, default(FHitResult));
			}
		}
	}

	protected override void OnNotifyStartObserve()
	{
		if (!base.OverlapData.bOverlapEnabled)
		{
			return;
		}
		foreach (UActorComponent item in base.Owner.GetComponentsByClass(UClass.GetClass<UPrimitiveComponent>()))
		{
			UShapeComponent uShapeComponent = item as UBoxComponent;
			if (uShapeComponent == null || !uShapeComponent.GetGenerateOverlapEvents())
			{
				continue;
			}
			uShapeComponent.GetOverlappingComponents(out var OutOverlappingComponents);
			foreach (UPrimitiveComponent item2 in OutOverlappingComponents)
			{
				OnCollisionBeginOverlap(uShapeComponent, item2.GetOwner(), item2, 0, bFromSweep: false, default(FHitResult));
			}
		}
	}

	protected override void OnEnableOverlap()
	{
		foreach (UActorComponent item in base.Owner.GetComponentsByClass(UClass.GetClass<UShapeComponent>()))
		{
			UShapeComponent uShapeComponent = item as UShapeComponent;
			if (uShapeComponent == null)
			{
				continue;
			}
			if (uShapeComponent.GetGenerateOverlapEvents())
			{
				base.CollisionComponents.Add(new TWeakObject<UPrimitiveComponent>(uShapeComponent));
				UBGUFunctionLibraryForCS.BGUBindOnComponentBeginOverlapEvent(uShapeComponent, base.FunctionBinder, B1GlobalFNames.OnCollisionBeginOverlap);
				UBGUFunctionLibraryForCS.BGUBindOnComponentEndOverlapEvent(uShapeComponent, base.FunctionBinder, B1GlobalFNames.OnCollisionEndOverlap);
			}
			uShapeComponent.GetOverlappingActors(out var OverlappingActors, UClass.GetClass<ABGUCharacter>());
			foreach (AActor item2 in OverlappingActors)
			{
				OnCollisionBeginOverlap(uShapeComponent, item2, null, 0, bFromSweep: false, default(FHitResult));
			}
		}
	}

	protected override void OnDisableOverlap()
	{
		if (BuffTriggerData.bTriggerEndOverlapWhenDisable)
		{
			foreach (UActorComponent item in base.Owner.GetComponentsByClass(UClass.GetClass<UShapeComponent>()))
			{
				UShapeComponent uShapeComponent = item as UShapeComponent;
				if (uShapeComponent == null)
				{
					continue;
				}
				uShapeComponent.GetOverlappingActors(out var OverlappingActors, UClass.GetClass<ABGUCharacter>());
				foreach (AActor item2 in OverlappingActors)
				{
					OnCollisionEndOverlap(uShapeComponent, item2, null, -1);
				}
			}
		}
		foreach (TWeakObject<UPrimitiveComponent> collisionComponent in base.CollisionComponents)
		{
			if (collisionComponent.IsValid())
			{
				UBGUFunctionLibraryForCS.BGUUnBindOnComponentBeginOverlapEvent(collisionComponent.Get(), base.FunctionBinder, B1GlobalFNames.OnCollisionBeginOverlap);
				UBGUFunctionLibraryForCS.BGUUnBindOnComponentEndOverlapEvent(collisionComponent.Get(), base.FunctionBinder, B1GlobalFNames.OnCollisionEndOverlap);
			}
		}
	}

	private void ObserveUnitsConditions(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, FHitResult SweepResult, EBuffControlCondition BuffControlCondition)
	{
		BGUCharacterCS bGUCharacterCS = OtherActor as BGUCharacterCS;
		string OtherCharacterGuid = BGU_DataUtil.GetActorGuid(bGUCharacterCS);
		foreach (FBuffTriggerUnitCondition buffTriggerUnitCondition in BuffTriggerData.BuffTriggerUnitConditions)
		{
			switch (buffTriggerUnitCondition.ConditionsTarget)
			{
			case EConditionsTarget.Player:
				buffTriggerUnitCondition.ObservedUnitGuidList.Clear();
				foreach (BGUCharacterCS allPlayerActor in BGU_UnrealWorldUtil.GetAllPlayerActors(base.Owner))
				{
					buffTriggerUnitCondition.ObservedUnitGuidList.Add(BGU_DataUtil.GetActorGuid(allPlayerActor));
				}
				break;
			case EConditionsTarget.FindByTag:
			{
				buffTriggerUnitCondition.ObservedUnitGuidList.Clear();
				List<AActor> allActorsOfClassList = UGameplayStatics.GetAllActorsOfClassList(base.Owner.World, UClass.GetClass<BGUCharacterCS>());
				List<AActor> allActorsOfClassList2 = UGameplayStatics.GetAllActorsOfClassList(base.Owner.World, UClass.GetClass<BGUBulletBaseCS>());
				foreach (AActor item in allActorsOfClassList)
				{
					bool flag = true;
					foreach (FName tag in buffTriggerUnitCondition.Tags)
					{
						if (!item.ActorHasTag(tag))
						{
							flag = false;
						}
					}
					if (flag)
					{
						buffTriggerUnitCondition.ObservedUnitGuidList.Add(BGU_DataUtil.GetActorGuid(item));
					}
				}
				foreach (AActor item2 in allActorsOfClassList2)
				{
					bool flag2 = true;
					foreach (FName tag2 in buffTriggerUnitCondition.Tags)
					{
						if (!item2.ActorHasTag(tag2))
						{
							flag2 = false;
						}
					}
					if (flag2)
					{
						buffTriggerUnitCondition.ObserveBullets.Add(item2 as BGUBulletBaseCS);
					}
				}
				break;
			}
			}
			if (buffTriggerUnitCondition.ObserveIsActivedUnit)
			{
				bool flag3 = true;
				foreach (string observeActivedUnitGuid in buffTriggerUnitCondition.ObserveActivedUnitGuidList)
				{
					IBUC_UnitStateData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_UnitStateData, BUC_UnitStateData>(BGU_DataUtil.GetActorByGuid(base.Owner, observeActivedUnitGuid));
					if (readOnlyData == null || readOnlyData.HasState(EBGUUnitState.Dead))
					{
						flag3 = false;
					}
				}
				if (!flag3)
				{
					continue;
				}
			}
			if (buffTriggerUnitCondition.ObserveIsDeadUnit)
			{
				bool flag4 = true;
				foreach (string observeDeadUnitGuid in buffTriggerUnitCondition.ObserveDeadUnitGuidList)
				{
					IBUC_UnitStateData readOnlyData2 = BGU_DataUtil.GetReadOnlyData<IBUC_UnitStateData, BUC_UnitStateData>(BGU_DataUtil.GetActorByGuid(base.Owner, observeDeadUnitGuid));
					if (readOnlyData2 != null && !readOnlyData2.HasState(EBGUUnitState.Dead))
					{
						flag4 = false;
					}
				}
				if (!flag4)
				{
					continue;
				}
			}
			if (buffTriggerUnitCondition.ObserveBullets.Contains(OtherActor as BGUBulletBaseCS))
			{
				if (buffTriggerUnitCondition.BuffTriggerConfig.AddBuffCondition == BuffControlCondition)
				{
					switch (buffTriggerUnitCondition.BuffTriggerConfig.AddBuffTarget)
					{
					case EBuffTarget.Player:
					{
						APawn controlledPawn = UGSE_EngineFuncLib.GetFirstLocalPlayerController(base.Owner).GetControlledPawn();
						if (controlledPawn == null)
						{
							continue;
						}
						BUS_GSEventCollection bUS_GSEventCollection3 = BUS_EventCollectionCS.Get(controlledPawn);
						if (bUS_GSEventCollection3 == null)
						{
							continue;
						}
						foreach (int addBuffID in buffTriggerUnitCondition.BuffTriggerConfig.AddBuffIDList)
						{
							bUS_GSEventCollection3.Evt_BuffAdd.Invoke(addBuffID, controlledPawn, controlledPawn, 0f, EBuffSourceType.BuffTrigger);
						}
						break;
					}
					case EBuffTarget.OtherUnit:
					{
						if (OtherActor as BGUBulletBaseCS == null)
						{
							continue;
						}
						BUS_GSEventCollection bUS_GSEventCollection2 = BUS_EventCollectionCS.Get(OtherActor);
						if (bUS_GSEventCollection2 == null)
						{
							continue;
						}
						foreach (int addBuffID2 in buffTriggerUnitCondition.BuffTriggerConfig.AddBuffIDList)
						{
							bUS_GSEventCollection2.Evt_BuffAdd.Invoke(addBuffID2, OtherActor, OtherActor, 0f, EBuffSourceType.BuffTrigger);
						}
						break;
					}
					case EBuffTarget.SceneUnit:
						foreach (string addSceneUnitGuid in buffTriggerUnitCondition.BuffTriggerConfig.AddSceneUnitGuidList)
						{
							if (string.IsNullOrEmpty(addSceneUnitGuid))
							{
								continue;
							}
							AActor actorByGuid = BGU_DataUtil.GetActorByGuid(base.Owner, addSceneUnitGuid);
							BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(actorByGuid);
							if (bUS_GSEventCollection == null)
							{
								continue;
							}
							foreach (int addBuffID3 in buffTriggerUnitCondition.BuffTriggerConfig.AddBuffIDList)
							{
								bUS_GSEventCollection.Evt_BuffAdd.Invoke(addBuffID3, actorByGuid, actorByGuid, 0f, EBuffSourceType.BuffTrigger);
							}
						}
						break;
					}
				}
				if (buffTriggerUnitCondition.BuffTriggerConfig.RemoveBuffCondition == BuffControlCondition)
				{
					switch (buffTriggerUnitCondition.BuffTriggerConfig.RemoveBuffTarget)
					{
					case EBuffTarget.Player:
					{
						APawn controlledPawn2 = UGSE_EngineFuncLib.GetFirstLocalPlayerController(base.Owner).GetControlledPawn();
						if (controlledPawn2 == null)
						{
							continue;
						}
						BUS_GSEventCollection bUS_GSEventCollection6 = BUS_EventCollectionCS.Get(controlledPawn2);
						if (bUS_GSEventCollection6 == null)
						{
							continue;
						}
						foreach (int removeBuffID in buffTriggerUnitCondition.BuffTriggerConfig.RemoveBuffIDList)
						{
							bUS_GSEventCollection6.Evt_BuffRemove.Invoke(removeBuffID, EBuffEffectTriggerType.None, 1);
						}
						break;
					}
					case EBuffTarget.OtherUnit:
					{
						if (bGUCharacterCS == null)
						{
							continue;
						}
						BUS_GSEventCollection bUS_GSEventCollection5 = BUS_EventCollectionCS.Get(bGUCharacterCS);
						if (bUS_GSEventCollection5 == null)
						{
							continue;
						}
						foreach (int removeBuffID2 in buffTriggerUnitCondition.BuffTriggerConfig.RemoveBuffIDList)
						{
							bUS_GSEventCollection5.Evt_BuffRemove.Invoke(removeBuffID2, EBuffEffectTriggerType.None, 1);
						}
						break;
					}
					case EBuffTarget.SceneUnit:
						foreach (string removeSceneUnitGuid in buffTriggerUnitCondition.BuffTriggerConfig.RemoveSceneUnitGuidList)
						{
							if (string.IsNullOrEmpty(removeSceneUnitGuid))
							{
								continue;
							}
							BUS_GSEventCollection bUS_GSEventCollection4 = BUS_EventCollectionCS.Get(BGU_DataUtil.GetActorByGuid(base.Owner, removeSceneUnitGuid));
							if (bUS_GSEventCollection4 == null)
							{
								continue;
							}
							foreach (int removeBuffID3 in buffTriggerUnitCondition.BuffTriggerConfig.RemoveBuffIDList)
							{
								bUS_GSEventCollection4.Evt_BuffRemove.Invoke(removeBuffID3, EBuffEffectTriggerType.None, 1);
							}
						}
						break;
					}
				}
			}
			if (!buffTriggerUnitCondition.ObservedUnitGuidList.Contains(OtherCharacterGuid))
			{
				continue;
			}
			string unitGuid = buffTriggerUnitCondition.ObservedUnitGuidList.Find((string cs) => cs == OtherCharacterGuid);
			AActor actorByGuid2 = BGU_DataUtil.GetActorByGuid(base.Owner, unitGuid);
			BUS_EventCollectionCS.Get(bGUCharacterCS);
			IBUC_UnitStateData readOnlyData3 = BGU_DataUtil.GetReadOnlyData<IBUC_UnitStateData, BUC_UnitStateData>(actorByGuid2);
			IBUC_SimpleStateData readOnlyData4 = BGU_DataUtil.GetReadOnlyData<IBUC_SimpleStateData, BUC_SimpleStateData>(actorByGuid2);
			IBUC_BuffData readOnlyData5 = BGU_DataUtil.GetReadOnlyData<IBUC_BuffData, BUC_BuffData>(actorByGuid2);
			IBUC_CheckData readOnlyData6 = BGU_DataUtil.GetReadOnlyData<BUC_CheckData>(actorByGuid2);
			bool flag5 = true;
			if (buffTriggerUnitCondition.ObserveHasUnitState)
			{
				if (buffTriggerUnitCondition == null)
				{
					continue;
				}
				foreach (EBGUUnitState observeUnitState in buffTriggerUnitCondition.ObserveUnitStates)
				{
					if (!readOnlyData3.HasState(observeUnitState))
					{
						flag5 = false;
					}
				}
			}
			if (buffTriggerUnitCondition.ObserveHasSimpleState)
			{
				if (readOnlyData4 == null)
				{
					continue;
				}
				foreach (EBGUSimpleState observeSimpleState in buffTriggerUnitCondition.ObserveSimpleStates)
				{
					if (!readOnlyData4.HasSimpleState(observeSimpleState))
					{
						flag5 = false;
					}
				}
			}
			if (buffTriggerUnitCondition.ObserveHasBuff)
			{
				if (readOnlyData5 == null)
				{
					continue;
				}
				foreach (int observeBuffID in buffTriggerUnitCondition.ObserveBuffIDs)
				{
					if (!readOnlyData5.HasBuff(observeBuffID))
					{
						flag5 = false;
					}
				}
			}
			if (buffTriggerUnitCondition.ObserveHasUnitAttr)
			{
				FlowObserveCondition flowObserveCondition = new FlowObserveCondition();
				flowObserveCondition.ConditionType = EObserveConditionType.UnitAttr;
				foreach (FUnitAttrCondition observeUnitAttr in buffTriggerUnitCondition.ObserveUnitAttrs)
				{
					flowObserveCondition.AttrFloatType = observeUnitAttr.AttrFloatType;
					flowObserveCondition.CompareOperation = observeUnitAttr.CompareOperation;
					flowObserveCondition.CompareValue = observeUnitAttr.CompareValue;
					if (!readOnlyData6.CheckObserveCondition(flowObserveCondition))
					{
						flag5 = false;
					}
				}
			}
			if (!flag5)
			{
				continue;
			}
			if (buffTriggerUnitCondition.BuffTriggerConfig.AddBuffCondition == BuffControlCondition)
			{
				switch (buffTriggerUnitCondition.BuffTriggerConfig.AddBuffTarget)
				{
				case EBuffTarget.Player:
				{
					APawn controlledPawn3 = UGSE_EngineFuncLib.GetFirstLocalPlayerController(base.Owner).GetControlledPawn();
					if (controlledPawn3 == null)
					{
						continue;
					}
					BUS_GSEventCollection bUS_GSEventCollection9 = BUS_EventCollectionCS.Get(controlledPawn3);
					if (bUS_GSEventCollection9 == null)
					{
						continue;
					}
					foreach (int addBuffID4 in buffTriggerUnitCondition.BuffTriggerConfig.AddBuffIDList)
					{
						bUS_GSEventCollection9.Evt_BuffAdd.Invoke(addBuffID4, controlledPawn3, controlledPawn3, 0f, EBuffSourceType.BuffTrigger);
					}
					break;
				}
				case EBuffTarget.OtherUnit:
				{
					if (bGUCharacterCS == null)
					{
						continue;
					}
					BUS_GSEventCollection bUS_GSEventCollection8 = BUS_EventCollectionCS.Get(bGUCharacterCS);
					if (bUS_GSEventCollection8 == null)
					{
						continue;
					}
					foreach (int addBuffID5 in buffTriggerUnitCondition.BuffTriggerConfig.AddBuffIDList)
					{
						bUS_GSEventCollection8.Evt_BuffAdd.Invoke(addBuffID5, bGUCharacterCS, bGUCharacterCS, 0f, EBuffSourceType.BuffTrigger);
					}
					break;
				}
				case EBuffTarget.SceneUnit:
					foreach (string addSceneUnitGuid2 in buffTriggerUnitCondition.BuffTriggerConfig.AddSceneUnitGuidList)
					{
						if (string.IsNullOrEmpty(addSceneUnitGuid2))
						{
							continue;
						}
						AActor actorByGuid3 = BGU_DataUtil.GetActorByGuid(base.Owner, addSceneUnitGuid2);
						BUS_GSEventCollection bUS_GSEventCollection7 = BUS_EventCollectionCS.Get(actorByGuid3);
						if (bUS_GSEventCollection7 == null)
						{
							continue;
						}
						foreach (int addBuffID6 in buffTriggerUnitCondition.BuffTriggerConfig.AddBuffIDList)
						{
							bUS_GSEventCollection7.Evt_BuffAdd.Invoke(addBuffID6, actorByGuid3, actorByGuid3, 0f, EBuffSourceType.BuffTrigger);
						}
					}
					break;
				}
			}
			if (buffTriggerUnitCondition.BuffTriggerConfig.RemoveBuffCondition != BuffControlCondition)
			{
				continue;
			}
			switch (buffTriggerUnitCondition.BuffTriggerConfig.RemoveBuffTarget)
			{
			case EBuffTarget.Player:
			{
				APawn controlledPawn4 = UGSE_EngineFuncLib.GetFirstLocalPlayerController(base.Owner).GetControlledPawn();
				if (controlledPawn4 == null)
				{
					break;
				}
				BUS_GSEventCollection bUS_GSEventCollection12 = BUS_EventCollectionCS.Get(controlledPawn4);
				if (bUS_GSEventCollection12 == null)
				{
					break;
				}
				foreach (int removeBuffID4 in buffTriggerUnitCondition.BuffTriggerConfig.RemoveBuffIDList)
				{
					bUS_GSEventCollection12.Evt_BuffRemove.Invoke(removeBuffID4, EBuffEffectTriggerType.None, 1);
				}
				break;
			}
			case EBuffTarget.OtherUnit:
			{
				if (bGUCharacterCS == null)
				{
					break;
				}
				BUS_GSEventCollection bUS_GSEventCollection11 = BUS_EventCollectionCS.Get(bGUCharacterCS);
				if (bUS_GSEventCollection11 == null)
				{
					break;
				}
				foreach (int removeBuffID5 in buffTriggerUnitCondition.BuffTriggerConfig.RemoveBuffIDList)
				{
					bUS_GSEventCollection11.Evt_BuffRemove.Invoke(removeBuffID5, EBuffEffectTriggerType.None, 1);
				}
				break;
			}
			case EBuffTarget.SceneUnit:
				foreach (string removeSceneUnitGuid2 in buffTriggerUnitCondition.BuffTriggerConfig.RemoveSceneUnitGuidList)
				{
					if (string.IsNullOrEmpty(removeSceneUnitGuid2))
					{
						continue;
					}
					BUS_GSEventCollection bUS_GSEventCollection10 = BUS_EventCollectionCS.Get(BGU_DataUtil.GetActorByGuid(base.Owner, removeSceneUnitGuid2));
					if (bUS_GSEventCollection10 == null)
					{
						continue;
					}
					foreach (int removeBuffID6 in buffTriggerUnitCondition.BuffTriggerConfig.RemoveBuffIDList)
					{
						bUS_GSEventCollection10.Evt_BuffRemove.Invoke(removeBuffID6, EBuffEffectTriggerType.None, 1);
					}
				}
				break;
			}
		}
	}

	protected void OnCollisionStayOverlap(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, FHitResult SweepResult)
	{
		ObserveUnitsConditions(OverlappedComponent, OtherActor, OtherComp, OtherBodyIndex, bFromSweep, SweepResult, EBuffControlCondition.StayCollisionArea);
	}

	protected override void OnCollisionBeginOverlap(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, FHitResult SweepResult)
	{
		ObserveUnitsConditions(OverlappedComponent, OtherActor, OtherComp, OtherBodyIndex, bFromSweep, SweepResult, EBuffControlCondition.StayCollisionArea);
		ObserveUnitsConditions(OverlappedComponent, OtherActor, OtherComp, OtherBodyIndex, bFromSweep, SweepResult, EBuffControlCondition.EnterCollisionArea);
	}

	protected override void OnCollisionEndOverlap(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex)
	{
		ObserveUnitsConditions(OverlappedComponent, OtherActor, OtherComp, OtherBodyIndex, bFromSweep: false, default(FHitResult), EBuffControlCondition.LeaveCollisionArea);
	}
}
