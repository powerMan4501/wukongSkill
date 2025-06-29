using b1.EventDelDefine;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
internal class BUS_DroppedItemManagerComp : BUS_StateMachineCompBase
{
	public class ItemNotDroppedState : GSStateBase
	{
		public override FGameplayTag StateTag => BGW_FlowUtils.DroppedItemEventTag.State_ItemNotDropped;

		public override void OnInitialize()
		{
			base.OnInitialize();
			base.EventTransitDictionary.Add(BGW_FlowUtils.DroppedItemEventTag.Event_ItemDropped, BGW_FlowUtils.DroppedItemEventTag.State_ItemDropped);
		}

		public override void OnEnterAction(BUS_StateMachineCompBase InOwner)
		{
			(InOwner as b1.BUS_DroppedItemManagerComp).SetNotDroppable();
		}
	}

	public class ItemDroppedState : GSStateBase
	{
		public override FGameplayTag StateTag => BGW_FlowUtils.DroppedItemEventTag.State_ItemDropped;

		public override void OnInitialize()
		{
			base.OnInitialize();
			base.EventTransitDictionary.Add(BGW_FlowUtils.DroppedItemEventTag.Event_ItemPickedUp, BGW_FlowUtils.DroppedItemEventTag.State_ItemPickedUp);
		}

		public override void OnEnterAction(BUS_StateMachineCompBase InOwner)
		{
			(InOwner as b1.BUS_DroppedItemManagerComp).RequestSpawnDropItem();
		}
	}

	public class ItemPickedUpState : GSStateBase
	{
		public override FGameplayTag StateTag => BGW_FlowUtils.DroppedItemEventTag.State_ItemPickedUp;

		public override void OnInitialize()
		{
			base.OnInitialize();
		}

		public override void OnEnterAction(BUS_StateMachineCompBase InOwner)
		{
			(InOwner as b1.BUS_DroppedItemManagerComp).SetNotDroppable();
		}
	}

	private b1.BUC_DroppedItemManagerData DroppedItemManagerData;

	public override void OnAttach()
	{
		base.OnAttach();
		DroppedItemManagerData = RequireWritableData<b1.BUC_DroppedItemManagerData>();
		base.SceneObjTag = BGW_FlowUtils.SceneObjTag.Trigger;
		GSStateBase initialState = AddState(typeof(ItemNotDroppedState), 0);
		AddState(typeof(ItemDroppedState), 1);
		AddState(typeof(ItemPickedUpState), 2);
		base.InitialState = initialState;
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (DroppedItemManagerData.NeedSpawn)
		{
			if (DroppedItemManagerData.DelayTime >= DroppedItemManagerData.SpawnDelayTime)
			{
				DroppedItemManagerData.DelayTime = 0f;
				DroppedItemManagerData.NeedSpawn = !SpawnDropItem();
				SetCanTick(DroppedItemManagerData.NeedSpawn);
			}
			else
			{
				DroppedItemManagerData.DelayTime += DeltaTime * 1000f;
			}
		}
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		if (DroppedItemManagerData != null && DroppedItemManagerData.SpawnedDroppedItem != null)
		{
			BGU_UnrealWorldUtil.DestroyActor(DroppedItemManagerData.SpawnedDroppedItem);
		}
	}

	public void SetNotDroppable()
	{
		DroppedItemManagerData.NeedSpawn = false;
		SetCanTick(DroppedItemManagerData.NeedSpawn);
	}

	public void RequestSpawnDropItem()
	{
		DroppedItemManagerData.DelayTime = 0f;
		DroppedItemManagerData.NeedSpawn = true;
		SetCanTick(DroppedItemManagerData.NeedSpawn);
	}

	public bool SpawnDropItem()
	{
		FActorSpawnParameters fActorSpawnParameters = new FActorSpawnParameters
		{
			SpawnCollisionHandlingOverride = ESpawnActorCollisionHandlingMethod.AlwaysSpawn
		};
		FTransform transform = default(FTransform);
		BGUCharacterCS bGUCharacterCS = BGU_DataUtil.GetActorByGuid(base.Owner, DroppedItemManagerData.DropUnitGuid) as BGUCharacterCS;
		BGU_EQSPointRecorderActor value = DroppedItemManagerData.PointRecorder.Value;
		if (bGUCharacterCS == null || value == null || value.EQSPoints.Count + value.CustomPoints.Count == 0)
		{
			transform = DroppedItemManagerData.DropTransform;
		}
		else
		{
			FTransform socketTransform = bGUCharacterCS.Mesh.GetSocketTransform(DroppedItemManagerData.DropSocket);
			FVector location = socketTransform.GetLocation();
			FQuat rotation;
			if (DroppedItemManagerData.bUseSocketRotation)
			{
				FRotator fRotator = socketTransform.Rotator();
				if (!DroppedItemManagerData.bUseSocketRotationAxisX)
				{
					fRotator.Roll = 0f;
				}
				if (!DroppedItemManagerData.bUseSocketRotationAxisY)
				{
					fRotator.Pitch = 0f;
				}
				if (!DroppedItemManagerData.bUseSocketRotationAxisZ)
				{
					fRotator.Yaw = 0f;
				}
				rotation = fRotator.Quaternion() * DroppedItemManagerData.DropOffset.GetRotation();
			}
			else
			{
				rotation = DroppedItemManagerData.DropOffset.GetRotation();
			}
			FVector fVector = ((value.EQSPoints.Count <= 0) ? value.CustomPoints[0] : value.EQSPoints[0]);
			foreach (FVector eQSPoint in value.EQSPoints)
			{
				if ((location - fVector).Size() > (location - eQSPoint).Size())
				{
					fVector = eQSPoint;
				}
			}
			foreach (FVector customPoint in value.CustomPoints)
			{
				if ((location - fVector).Size() > (location - customPoint).Size())
				{
					fVector = customPoint;
				}
			}
			transform.SetLocation(fVector + DroppedItemManagerData.DropOffset.GetLocation());
			transform.SetRotation(rotation);
		}
		BPS_GSEventCollection bPS_GSEventCollection = BPS_GSEventCollection.Get(UGSE_EngineFuncLib.GetFirstLocalPlayerController(GetOwner()));
		if (bPS_GSEventCollection != null)
		{
			AActor DropItem = null;
			bPS_GSEventCollection.Evt_SpawnDropItemOnLoad?.Invoke(DroppedItemManagerData.DropItemID, transform, ref DropItem);
			if (DropItem != null)
			{
				DroppedItemManagerData.SpawnedDroppedItem = DropItem;
				BUS_EventCollectionCS.Get(DropItem).Evt_OnPickDropItem += new Del_Void(OnPick);
				if (bGUCharacterCS != null && DropItem is BGUDropItemActorCS bGUDropItemActorCS)
				{
					bGUDropItemActorCS.OnPlayDropEffect();
				}
				return true;
			}
		}
		return false;
	}

	private void OnPick()
	{
		OnEvent(BGW_FlowUtils.DroppedItemEventTag.Event_ItemPickedUp);
	}
}
