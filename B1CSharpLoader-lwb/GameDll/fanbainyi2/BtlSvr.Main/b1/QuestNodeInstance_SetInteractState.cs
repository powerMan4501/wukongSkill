using System.Collections.Generic;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class QuestNodeInstance_SetInteractState : QuestNodeInstance
{
	private bool CanInteract;

	private string NotifyActorGuid;

	private bool ByChallengeLevel;

	private List<string> NotifyActorGuidList = new List<string>();

	private int ChallengeId;

	private bool IngoreHideLogic;

	private QuestCustom_SetInteractState CustomData { get; set; }

	protected override void PostCreate()
	{
		CustomData = new QuestCustom_SetInteractState();
		CustomData.MergeFrom(base.Node.NodeData);
		CanInteract = CustomData.InteractState;
		NotifyActorGuid = CustomData.NotifyActorGuid;
		ByChallengeLevel = CustomData.ByChallengeLevel;
		foreach (string notifyActorGuid in CustomData.NotifyActorGuidList)
		{
			NotifyActorGuidList.Add(notifyActorGuid);
		}
		IngoreHideLogic = CustomData.IngoreHideLogic;
		ChallengeId = CustomData.ChallengeId;
	}

	public override void TriggerInput(string InputPin)
	{
		base.TriggerInput(InputPin);
		AGameStateBase gameState = UGameplayStatics.GetGameState(base.Owner);
		AActor actorByGuid = BGU_DataUtil.GetActorByGuid(base.Owner, NotifyActorGuid);
		if (ByChallengeLevel)
		{
			IBGC_OnlineChallengeData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBGC_OnlineChallengeData, BGC_OnlineChallengeData>(gameState);
			if (readOnlyData != null)
			{
				int challengeLevel = readOnlyData.GetChallengeLevel(ChallengeId);
				if (challengeLevel - 1 >= 0)
				{
					actorByGuid = BGU_DataUtil.GetActorByGuid(base.Owner, NotifyActorGuidList[challengeLevel - 1]);
				}
				int dropIdByGuid = readOnlyData.GetDropIdByGuid(ChallengeId, challengeLevel);
				if (CanInteract)
				{
					if (CheckOnePlayHasReward(UGameplayStatics.GetPlayerController(base.Owner, 0), dropIdByGuid))
					{
						return;
					}
				}
				else
				{
					foreach (string notifyActorGuid in NotifyActorGuidList)
					{
						AActor actorByGuid2 = BGU_DataUtil.GetActorByGuid(base.Owner, notifyActorGuid);
						DoShowHideLogic(actorByGuid2);
					}
				}
			}
		}
		if (!(actorByGuid == null))
		{
			DoShowHideLogic(actorByGuid);
			TriggerFirstOutput(bFinish: true);
		}
	}

	private void DoShowHideLogic(AActor InteractActor)
	{
		BUS_EventCollectionCS.Get(InteractActor)?.Evt_SwitchNoInteraction_Local.Invoke(CanInteract);
		if (IngoreHideLogic)
		{
			return;
		}
		ECollisionEnabled collisionEnabled = ECollisionEnabled.NoCollision;
		if (CanInteract)
		{
			collisionEnabled = ECollisionEnabled.QueryAndPhysics;
		}
		InteractActor.SetActorHiddenInGame(!CanInteract);
		foreach (UActorComponent item in InteractActor.GetComponentsByClass(UClass.GetClass<UMeshComponent>()))
		{
			UMeshComponent uMeshComponent = item as UMeshComponent;
			if (!uMeshComponent.IsNullOrDestroyed() && uMeshComponent.IsVisible())
			{
				uMeshComponent.SetCollisionEnabled(collisionEnabled);
			}
		}
	}

	private bool CheckOnePlayHasReward(APlayerController PlayerController, int DropId)
	{
		BPC_PlayerRoleData readOnlyData = BGU_DataUtil.GetReadOnlyData<BPC_PlayerRoleData>(PlayerController);
		bool result = false;
		foreach (ReadOnlyDropRecord dropRecord in readOnlyData.RoleData.RoleCs.Drop.DropRecordList)
		{
			if (DropId == dropRecord.DropId && dropRecord.DropCount != 0)
			{
				result = true;
				break;
			}
		}
		return result;
	}

	public override byte[] GetNodeCustomData()
	{
		return null;
	}

	public override void SetNodeCustomData(byte[] CustomData)
	{
	}

	public override void RecoverActiveState()
	{
		TriggerFirstOutput(bFinish: true);
	}
}
