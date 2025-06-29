using b1.EventDelDefine;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUS_GroupAIAreaLogicComp : UActorCompBaseCS
{
	private b1.BUC_GroupAIAreaLogicData GroupAIAreaLogicData;

	public override void OnAttach()
	{
		GroupAIAreaLogicData = RequireWritableData<b1.BUC_GroupAIAreaLogicData>();
		base.BUSEventCollection.Evt_OnActorEnterArea += new Del_Void_Actor(OverlapBegin);
		base.BUSEventCollection.Evt_OnActorLeaveArea += new Del_Void_Actor(OverlapEnd);
	}

	public override void OnBeginPlay()
	{
	}

	public override int GetTickGroupMask()
	{
		return 8;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		UpdateForDebug();
	}

	private void UpdateForDebug()
	{
		AActor owner = GetOwner();
		if (owner == null || GSGameplayCVar.CVar_GroupAIDebugInfoEnableGroupAIAreaDebug.GetValueInGameThread() == 0)
		{
			return;
		}
		foreach (UActorComponent item in Owner.GetComponentsByClass(UClass.GetClass<UBoxComponent>()))
		{
			UBoxComponent uBoxComponent = item as UBoxComponent;
			if (uBoxComponent != null)
			{
				USystemLibrary.DrawDebugBox(Owner, owner.GetActorLocation(), uBoxComponent.GetScaledBoxExtent(), FLinearColor.Yellow, owner.GetActorRotation());
			}
		}
	}

	private void OverlapBegin(AActor OtherActor)
	{
		if (!(OtherActor != null))
		{
			return;
		}
		BGUCharacterCS bGUCharacterCS = OtherActor as BGUCharacterCS;
		if (bGUCharacterCS != null)
		{
			IBUC_AIData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_AIData, BUC_AIData>(bGUCharacterCS);
			if (unPersistentReadOnlyData != null && !unPersistentReadOnlyData.IsAI)
			{
				base.BGSEventCollection.Evt_BGS_SetNewConfigDataAsset.Invoke(GetOwner(), GroupAIAreaLogicData.GroupAIMgrConfigDA, GroupAIAreaLogicData.GroupAIBattleHotZoneConfigDA);
			}
		}
	}

	private void OverlapEnd(AActor OtherActor)
	{
		if (!(OtherActor != null))
		{
			return;
		}
		BGUCharacterCS bGUCharacterCS = OtherActor as BGUCharacterCS;
		if (bGUCharacterCS != null)
		{
			IBUC_AIData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_AIData, BUC_AIData>(bGUCharacterCS);
			if (unPersistentReadOnlyData != null && !unPersistentReadOnlyData.IsAI)
			{
				base.BGSEventCollection.Evt_BGS_Try2RecoverDefaultConfigDataAsset.Invoke(GetOwner());
			}
		}
	}
}
