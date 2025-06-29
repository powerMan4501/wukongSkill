using System.Collections.Generic;
using b1.BGW;
using b1.EventDelDefine;
using CommB1;
using GSDispLib;
using ResB1;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.Niagara;
using UnrealEngine.Runtime;

namespace b1;

internal class BUS_TaskCollectiontStateComp : UActorCompBaseCS
{
	private BUC_TaskCollectionData TaskCollectionData;

	private AActor CollectPlayer;

	private UNiagaraComponent CollectionIdleFX;

	private float DestoryDelayTime = 3f;

	private bool IsNeedDestory;

	private float DestoryAccTime;

	private bool IsNeedResetFailedCollectFxParam;

	private float ResetFailedCollectFxParamDelayTime = 1.5f;

	protected IBUC_GuidData GuidData { get; set; }

	public override void OnAttach()
	{
		TaskCollectionData = RequireWritableData<BUC_TaskCollectionData>();
		GuidData = RequireReadOnlyData<IBUC_GuidData, BUC_GuidData>();
		base.BUSEventCollection.Evt_InteractTaskCollection += new Del_Void_Actor(OnInteractTaskCollection);
		base.BUSEventCollection.Evt_TaskCollectiontSpawnerDestory += new Del_Void(OnTaskCollectiontSpawnerDestory);
		base.BUSEventCollection.Evt_SetTaskCollectiontSpawner += new Del_Void_Actor(OnSetTaskCollectiontSpawner);
		base.BUSEventCollection.Evt_StopInteractTargetIdleFX += new Del_Void_Actor(OnTriggerStopInteractTargetIdleFX);
		IsNeedDestory = false;
		IsNeedResetFailedCollectFxParam = false;
		if (TaskCollectionData.DestoryDelayTime > 0f)
		{
			DestoryDelayTime = TaskCollectionData.DestoryDelayTime;
		}
	}

	private void OnInteractTaskCollection(AActor Player)
	{
		bool IsTaskFinish;
		int interactCD = GetInteractCD(Player as APawn, out IsTaskFinish);
		if (interactCD == -1)
		{
			return;
		}
		CollectPlayer = Player;
		DropItem(Player, IsTaskFinish);
		BUS_EventCollectionCS.Get(this).Evt_SwitchNoInteraction.Invoke(P1: false);
		int p = interactCD;
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(TaskCollectionData.SpawnerActor);
		if (IsTaskFinish && TaskCollectionData.CanDestoryTaskFinish)
		{
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_TaskCollectiontDestoryForever.Invoke();
			}
		}
		else if (bUS_GSEventCollection != null)
		{
			bUS_GSEventCollection.Evt_TaskCollectionInteracted.Invoke(p);
		}
		CollectionDeDestroyFX();
		IsNeedDestory = true;
	}

	private void OnSetTaskCollectiontSpawner(AActor SpawnerActor)
	{
		TaskCollectionData.SpawnerActor = SpawnerActor;
	}

	private void OnTaskCollectiontSpawnerDestory()
	{
		BGU_UnrealWorldUtil.DestroyActor(Owner);
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		base.BGSEventCollection.Evt_BGS_UnRegisterTaskCollectiont.Invoke(GuidData.UnitRandomGuid);
	}

	private void DropItem(AActor Player, bool IsTaskFinish)
	{
		BGS_GSEventCollection bGS_GSEventCollection = BGS_GSEventCollection.Get(Player);
		if (bGS_GSEventCollection != null)
		{
			OverrideDropTempleteInfoClass overrideDropTempleteInfoClass = new OverrideDropTempleteInfoClass();
			if (IsTaskFinish)
			{
				overrideDropTempleteInfoClass.AddOverrideDropTemplete(1002, TaskCollectionData.CollectionDropTemplete_TaskFinish);
			}
			else
			{
				overrideDropTempleteInfoClass.AddOverrideDropTemplete(1002, TaskCollectionData.CollectionDropTemplete);
			}
			List<UActorComponent> componentsByTag = GetOwner().GetComponentsByTag(UClass.GetClass<USceneComponent>(), TaskCollectionData.CollectionFXSpawnCompTag);
			if (componentsByTag != null && componentsByTag.Count > 0)
			{
				FTransform worldTransform = (componentsByTag[0] as USceneComponent).GetWorldTransform();
				overrideDropTempleteInfoClass.AddOverrideSpawnPos(1002, worldTransform);
			}
			else
			{
				FTransform actorTransform = Owner.GetActorTransform();
				overrideDropTempleteInfoClass.AddOverrideSpawnPos(1002, actorTransform);
			}
			bGS_GSEventCollection.Evt_BGS_PlayerCollected.Invoke(Player, TaskCollectionData.DropID, 1, Owner, overrideDropTempleteInfoClass);
		}
	}

	private int GetInteractCD(APawn Player, out bool IsTaskFinish)
	{
		IsTaskFinish = false;
		if (Player == null)
		{
			return 0;
		}
		if (TaskCollectionData.TaskStageId > 0)
		{
			AController controller = Player.GetController();
			if (Player != null && Player.PlayerState != null)
			{
				IBPC_PlayerRoleData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBPC_PlayerRoleData, BPC_PlayerRoleData>(controller);
				if (readOnlyData != null && readOnlyData.RoleData != null && readOnlyData.RoleData.RoleCs != null && readOnlyData.RoleData.RoleCs.Task != null)
				{
					foreach (ReadOnlyQuestStageOne quest in readOnlyData.RoleData.RoleCs.Task.QuestList)
					{
						int id = quest.Id;
						QuestStage stage = quest.Stage;
						if (TaskCollectionData.TaskStageId == id && TaskCollectionData.TaskStageStage == (int)stage)
						{
							IsTaskFinish = true;
							return TaskCollectionData.FinishCD;
						}
					}
				}
			}
		}
		return TaskCollectionData.CD;
	}

	private void DestoryFx(bool IsTaskFinish)
	{
		if (CollectionIdleFX != null)
		{
			CollectionIdleFX.SetVariableBool(B1GlobalFNames.User_GS_SoulBottle, IsTaskFinish);
			CollectionIdleFX.SetVariableBool(B1GlobalFNames.User_GS_EfxStop, InValue: true);
		}
	}

	private void CollectionFx(AActor Player, bool IsTaskFinish)
	{
		if (!IsTaskFinish)
		{
			IsNeedResetFailedCollectFxParam = true;
		}
		if (Player.IsNullOrDestroyed())
		{
			return;
		}
		BUC_DispLibDispBaseConfigDataAsset bUC_DispLibDispBaseConfigDataAsset = null;
		if (bUC_DispLibDispBaseConfigDataAsset != null)
		{
			USkeletalMeshComponent emitterDispOwnerComp = Player.GetComponentByClass(UClass.GetClass<USkeletalMeshComponent>()) as USkeletalMeshComponent;
			List<UActorComponent> componentsByTag = GetOwner().GetComponentsByTag(UClass.GetClass<USceneComponent>(), TaskCollectionData.CollectionFXSpawnCompTag);
			int RequestID;
			if (componentsByTag != null && componentsByTag.Count > 0)
			{
				FTransform worldTransform = (componentsByTag[0] as USceneComponent).GetWorldTransform();
				BUS_EventCollectionCS.Get(Player).Evt_RequestSpawnFXByDispConfigDA.Invoke(bUC_DispLibDispBaseConfigDataAsset, out RequestID, emitterDispOwnerComp, NeedSetSpawnTransform: true, worldTransform);
			}
			else
			{
				FTransform actorTransform = Owner.GetActorTransform();
				BUS_EventCollectionCS.Get(Player).Evt_RequestSpawnFXByDispConfigDA.Invoke(bUC_DispLibDispBaseConfigDataAsset, out RequestID, emitterDispOwnerComp, NeedSetSpawnTransform: true, actorTransform);
			}
		}
	}

	public override void OnBeginPlay()
	{
		UActorComponent componentByClass = GetOwner().GetComponentByClass(UClass.GetClass<UNiagaraComponent>());
		CollectionIdleFX = componentByClass as UNiagaraComponent;
		IsNeedDestory = false;
		DestoryAccTime = 0f;
		if (TaskCollectionData.CacheDBC != null)
		{
			BGW_PreloadAssetMgr.Get(this).TryGetCachedResourceObj<BGWDataAsset_B1DBC>(TaskCollectionData.CacheDBC.PathName, ELoadResourceType.AsyncLoadAndCache);
		}
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (IsNeedDestory)
		{
			DestoryAccTime += DeltaTime;
			if (DestoryAccTime >= DestoryDelayTime)
			{
				DestoryAccTime = 0f;
				IsNeedDestory = false;
				CollectPlayer = null;
				BUS_EventCollectionCS.Get(Owner)?.Evt_RequestDestroyByFXRequestID.Invoke(TaskCollectionData.DestroyFXID);
				BGU_UnrealWorldUtil.DestroyActor(Owner);
			}
		}
	}

	private void OnTriggerStopInteractTargetIdleFX(AActor Player)
	{
		List<UActorComponent> componentsByClass = GetOwner().GetComponentsByClass(UClass.GetClass<UNiagaraComponent>());
		if (componentsByClass == null)
		{
			return;
		}
		foreach (UActorComponent item in componentsByClass)
		{
			UNiagaraComponent uNiagaraComponent = item as UNiagaraComponent;
			if (!(uNiagaraComponent == null) && !uNiagaraComponent.ComponentHasTag(B1GlobalFNames.DBCNG))
			{
				GetInteractCD(Player as APawn, out var IsTaskFinish);
				uNiagaraComponent.SetVariableBool(B1GlobalFNames.User_GS_SoulBottle, IsTaskFinish);
				uNiagaraComponent.SetVariableBool(B1GlobalFNames.User_GS_EfxStop, InValue: true);
				uNiagaraComponent.Deactivate();
			}
		}
	}

	private void CollectionDeDestroyFX()
	{
		CollectionDropDesc collectionDropDesc = GameDBRuntime.GetCollectionDropDesc(TaskCollectionData.DropID);
		if (collectionDropDesc != null)
		{
			BUS_EventCollectionCS.Get(Owner).Evt_RequestSpawnFXByDispConfig.Invoke(collectionDropDesc.DropEfx, out var RequestID);
			TaskCollectionData.DestroyFXID = RequestID;
		}
	}
}
