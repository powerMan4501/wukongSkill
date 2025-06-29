using System.Collections.Generic;
using b1.EventDelDefine;
using BtlB1;
using CommB1;
using ResB1;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.Niagara;
using UnrealEngine.Runtime;

namespace b1;

internal class BUS_CollectiontInteractComp : UActorCompBaseCS
{
	private BUC_CollectionData CollectionData;

	private IBUC_GuidData GuidData;

	private IBUC_InteractData InteractData;

	private IBGC_TamerData BGCTamerData;

	private IBGC_UnrealGameplayData UnrealGameplayData;

	private IBIC_GlobalActorData GlobalActorData;

	private IBIC_CollectionGroupData CollectionGroupData { get; set; }

	public override void OnAttach()
	{
		CollectionData = RequireWritableData<BUC_CollectionData>();
		GuidData = RequireReadOnlyData<IBUC_GuidData, BUC_GuidData>();
		CollectionGroupData = RequireReadonlyGameInstanceData<IBIC_CollectionGroupData, BIC_CollectionGroupData>();
		InteractData = RequireReadOnlyData<IBUC_InteractData, BUC_InteractData>();
		UnrealGameplayData = RequireReadOnlyGameStateData<IBGC_UnrealGameplayData, BGC_UnrealGameplayData>();
		BGCTamerData = RequireReadOnlyGameStateData<IBGC_TamerData, BGC_TamerData>();
		GlobalActorData = RequireReadonlyGameInstanceData<IBIC_GlobalActorData, BIC_GlobalActorData>();
		BUS_EventCollectionCS.Get(this).Evt_InteractCollection += new Del_Void_Actor(OnInteractCollection);
	}

	public override void PreBeginPlay()
	{
		base.PreBeginPlay();
		string finalGuid = RequireReadOnlyData<IBUC_GuidData, BUC_GuidData>().GetFinalGuid();
		if (RequireReadonlyGameInstanceData<IBIC_PersistentECSData, BIC_PersistentECSData>().FindOrAllocBUCDataByGuid(finalGuid, out var Ret) && Ret.BUCCollectionData != null)
		{
			ECSPersistentDataSerializeFuncLib.DeSerializeBUC_CollectionData(CollectionData, Ret.BUCCollectionData);
		}
		if (DebugConfig.CollectionForceType > 0)
		{
			CollectionData.GroupId = 0;
		}
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
	}

	public override void OnBeginPlay()
	{
		if (CollectionData != null)
		{
			GuidData.GetFinalGuid();
			ShowStaticMeshByCollectionQuality();
			SpawnTamerActor();
			ItemCollectionReInit();
		}
	}

	private void ShowStaticMeshByCollectionQuality()
	{
		foreach (UStaticMeshComponent item in Owner.GetComponentsByClass(UClass.GetClass<UStaticMeshComponent>()))
		{
			if (item.GetFName().ToString() == "StaticMeshNormal")
			{
				item.SetHiddenInGame(CollectionData.CollectionQuality != ECollectionQualityType.Normal);
			}
			else if (item.GetFName().ToString() == "StaticMeshPlus")
			{
				item.SetHiddenInGame(CollectionData.CollectionQuality != ECollectionQualityType.Plus);
			}
			else if (item.GetFName().ToString() == "StaticMeshChief")
			{
				item.SetHiddenInGame(CollectionData.CollectionQuality != ECollectionQualityType.Chief);
			}
		}
	}

	private void SpawnTamerActor()
	{
		ACharacter playerCharacter = UGameplayStatics.GetPlayerCharacter(GetOwner().World, 0);
		if (DebugConfig.CollectionForceType > 0)
		{
			CollectionData.CollectiontType = (ECollectionInteractType)DebugConfig.CollectionForceType;
		}
		if (CollectionData.IsRandomed && playerCharacter != null)
		{
			switch (CollectionData.CollectiontType)
			{
			case ECollectionInteractType.Normal:
				SpawnTamer(playerCharacter, CollectionData.UnitClass.Value);
				BGU_UnrealWorldUtil.DestroyActor(Owner);
				break;
			case ECollectionInteractType.Plus:
				SpawnTamer(playerCharacter, CollectionData.PlusUnitClass.Value);
				BGU_UnrealWorldUtil.DestroyActor(Owner);
				break;
			case ECollectionInteractType.Chief:
				SpawnTamer(playerCharacter, CollectionData.ChiefUnitClass.Value);
				BGU_UnrealWorldUtil.DestroyActor(Owner);
				break;
			}
		}
	}

	private void ItemCollectionReInit()
	{
		if (CollectionData.CollectiontType != ECollectionInteractType.Item)
		{
			return;
		}
		bool flag = GetOwner().ActorHasTag(B1GlobalFNames.DontDestorty);
		if (CollectionData.BeCollected || !CollectionData.IsRandomed)
		{
			if (flag)
			{
				List<UActorComponent> componentsByTag = GetOwner().GetComponentsByTag(UClass.GetClass<UNiagaraComponent>(), B1GlobalFNames.NeedDestorty);
				if (componentsByTag.Count > 0)
				{
					UNiagaraComponent obj = componentsByTag[0] as UNiagaraComponent;
					obj.SetHiddenInGame(NewHidden: true);
					obj.ReinitializeSystem();
				}
				BUS_EventCollectionCS.Get(this).Evt_SwitchNoInteraction.Invoke(P1: false);
				BUS_EventCollectionCS.Get(Owner).Evt_RequestSpawnFXByDispConfig.Invoke(GSCSResPathUtil.GetCollectionDontDestortyFXPath(), out var RequestID);
				CollectionData.DestroyFXID = RequestID;
			}
			else if (CollectionData.CollectiontType == ECollectionInteractType.Item)
			{
				BGU_UnrealWorldUtil.DestroyActor(Owner);
			}
		}
		else
		{
			BUS_EventCollectionCS.Get(this).Evt_SwitchNoInteraction.Invoke(P1: true);
		}
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (CollectionData.DelayDestroy > 0f)
		{
			CollectionData.DelayDestroy -= DeltaTime;
		}
		else
		{
			SpawnMgrRandomHidden();
		}
	}

	private void OnInteractCollection(AActor UserActor)
	{
		CollectionDeDestroyFX();
		DoInteractEvent(UserActor);
	}

	private void CollectionDeDestroyFX()
	{
		if (CollectionData.CollectiontType != ECollectionInteractType.Item)
		{
			return;
		}
		List<UActorComponent> componentsByClass = GetOwner().GetComponentsByClass(UClass.GetClass<UNiagaraComponent>());
		if (componentsByClass != null)
		{
			foreach (UActorComponent item in componentsByClass)
			{
				UNiagaraComponent uNiagaraComponent = item as UNiagaraComponent;
				if (!(uNiagaraComponent == null) && !uNiagaraComponent.ComponentHasTag(B1GlobalFNames.DBCNG))
				{
					uNiagaraComponent.SetVariableBool(B1GlobalFNames.User_GS_EfxStop, InValue: true);
					uNiagaraComponent.Deactivate();
				}
			}
		}
		CollectionDropDesc collectionDropDesc = GameDBRuntime.GetCollectionDropDesc(CollectionData.CollectionDropId);
		if (collectionDropDesc != null)
		{
			BUS_EventCollectionCS.Get(Owner).Evt_RequestSpawnFXByDispConfig.Invoke(collectionDropDesc.DropEfx, out var RequestID);
			CollectionData.DestroyFXID = RequestID;
		}
		else
		{
			BUS_EventCollectionCS.Get(Owner).Evt_RequestSpawnFXByDispConfig.Invoke(GSCSResPathUtil.GetCollectionDealutDestroyFXPath(), out var RequestID2);
			CollectionData.DestroyFXID = RequestID2;
		}
	}

	private void TriggerSaveAndDestoryCollection()
	{
		string finalGuid = GuidData.GetFinalGuid();
		BGW_EventCollection.Get(Owner).Evt_SaveCollectionGroupInfo(CollectionData.GroupId, finalGuid);
		CollectionData.BeCollected = true;
		CollectionData.DelayDestroy = 2f;
		CollectionData.NeedDestroy = true;
	}

	private void DoInteractEvent(AActor Player)
	{
		if (DebugConfig.CollectionForceType > 0)
		{
			CollectionData.CollectiontType = (ECollectionInteractType)DebugConfig.CollectionForceType;
		}
		if (CollectionData.CollectiontType == ECollectionInteractType.Item)
		{
			if (Player != null)
			{
				BUS_EventCollectionCS.Get(Player).Evt_DropCollectionItem.Invoke(Player, CollectionData.CollectionDropId, (int)(CollectionData.CollectionQuality + 1));
				BUS_EventCollectionCS.Get(Player).Evt_PlayerCollectedV2.Invoke(Owner);
			}
			BUS_EventCollectionCS.Get(this).Evt_TriggerBeInteract.Invoke(Player, IsAiTrigger: false);
			TriggerSaveAndDestoryCollection();
		}
	}

	private void SpawnTamer(AActor Player, UClass UnitClass)
	{
		string text = GuidData.GetFinalGuid() + "_Monster";
		if ((BGCTamerData == null || !BGCTamerData.TryGetTamerEntityRef(text, out var _)) && (CollectionData.NeedReBirthMonster || GlobalActorData.GetActorAliveState(text)))
		{
			FTransform InTransform = GetOwner().GetActorTransform();
			InTransform.SetLocation(InTransform.GetLocation() + new FVector(0.0, 0.0, 200.0));
			FUnitSpawnInfo fUnitSpawnInfo = new FUnitSpawnInfo();
			fUnitSpawnInfo.SpawnMasterGuid = GuidData.GetFinalGuid();
			BGU_UnrealWorldUtil.RequestSpawnCollectionUnitByGuid(Owner.World, UnitClass, in InTransform, GetOwner(), fUnitSpawnInfo, text);
			CollectionSpawnTamer(text);
			BUS_EventCollectionCS.Get(this).Evt_SwitchNoInteraction.Invoke(P1: false);
			if (CollectionData.NeedReBirthMonster)
			{
				base.BGWEventCollection?.Evt_SetActorAliveState(text, P2: true);
				CollectionData.NeedReBirthMonster = false;
			}
		}
	}

	private void CollectionSpawnTamer(string ActorGuid)
	{
		BUS_EventCollectionCS.Get(Owner).Evt_RequestDestroyByFXRequestID.Invoke(CollectionData.CollectionFXId);
		CollectionData.CollectionFXId = 0;
		CollectionData.ActorGuid = ActorGuid;
	}

	private void SpawnMgrRandomHidden()
	{
		string finalGuid = GuidData.GetFinalGuid();
		if (CollectionData.GroupId == 0 && !CollectionData.NeedDestroy)
		{
			return;
		}
		if (!CollectionData.NeedHidden && !HasFinshPreTask(finalGuid))
		{
			SpawnFreshTypeCollection(IsHidden: true);
		}
		if (!CollectionData.BeCollected && CollectionData.IsRandomed)
		{
			return;
		}
		if (!GetOwner().ActorHasTag(B1GlobalFNames.DontDestorty))
		{
			BUS_EventCollectionCS.Get(Owner)?.Evt_RequestDestroyByFXRequestID.Invoke(CollectionData.DestroyFXID);
			BGU_UnrealWorldUtil.DestroyActor(Owner);
			return;
		}
		List<UActorComponent> componentsByTag = GetOwner().GetComponentsByTag(UClass.GetClass<UNiagaraComponent>(), B1GlobalFNames.NeedDestorty);
		if (componentsByTag.Count > 0)
		{
			UNiagaraComponent obj = componentsByTag[0] as UNiagaraComponent;
			obj.SetHiddenInGame(NewHidden: true);
			obj.ReinitializeSystem();
		}
		BUS_EventCollectionCS.Get(this).Evt_SwitchNoInteraction.Invoke(P1: false);
	}

	private bool HasFinshPreTask(string Guid)
	{
		List<FUStCollectionSpawnInfoDesc> allCollectionSpawnInfoDesc = BGW_GameDB.GetAllCollectionSpawnInfoDesc();
		int num = 0;
		if (allCollectionSpawnInfoDesc != null)
		{
			foreach (FUStCollectionSpawnInfoDesc item in allCollectionSpawnInfoDesc)
			{
				if (item.Guid == Guid)
				{
					num = item.TaskId;
					break;
				}
			}
		}
		if (num > 0)
		{
			BPC_PlayerRoleData readOnlyData = BGU_DataUtil.GetReadOnlyData<BPC_PlayerRoleData>(UnrealGameplayData.GetFirstLocalPlayerController() as BGP_PlayerControllerCS);
			bool flag = false;
			ReadOnlyQuestStageOneList questList = readOnlyData.RoleData.RoleCs.Task.QuestList;
			if (questList != null)
			{
				foreach (ReadOnlyQuestStageOne item2 in questList)
				{
					if (item2.Id == num && item2.Stage == QuestStage.Finished)
					{
						flag = true;
					}
				}
			}
			if (flag && CollectionGroupData.ReMoveFormBlackList(Guid))
			{
				SpawnFreshTypeCollection(IsHidden: false);
			}
		}
		return !CollectionGroupData.CheckInBlackList(Guid);
	}

	private void SpawnFreshTypeCollection(bool IsHidden)
	{
		UStaticMeshComponent componentByClass = Owner.GetComponentByClass<UStaticMeshComponent>();
		ECollisionResponseType newResponse = ((!IsHidden) ? ECollisionResponseType.ECR_Block : ECollisionResponseType.ECR_Ignore);
		for (int i = 0; i < 32; i++)
		{
			componentByClass.SetCollisionResponseToChannel((ECollisionChannel)i, newResponse);
		}
		if (IsHidden)
		{
			BUS_EventCollectionCS.Get(this).Evt_SwitchNoInteraction.Invoke(P1: false);
		}
		else
		{
			BUS_EventCollectionCS.Get(this).Evt_SwitchNoInteraction.Invoke(P1: true);
		}
		Owner.SetActorHiddenInGame(IsHidden);
		CollectionData.NeedHidden = IsHidden;
		if (CollectionData.CollectionFXId > 0)
		{
			BUS_EventCollectionCS.Get(Owner).Evt_RequestDestroyByFXRequestID.Invoke(CollectionData.CollectionFXId);
		}
	}
}
