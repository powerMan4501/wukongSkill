using b1.EventDelDefine;
using BtlShare;
using UnrealEngine.Engine;

namespace b1;

public class BUS_IntervalTriggerLogicComp : UActorCompBaseCS
{
	private BUC_IntervalTriggerLogicData IntervalTriggerLogicData;

	public override void OnAttach()
	{
		IntervalTriggerLogicData = RequireWritableData<BUC_IntervalTriggerLogicData>();
		base.BUSEventCollection.Evt_OnActorEnterArea += new Del_Void_Actor(OnActorEnter);
		base.BUSEventCollection.Evt_OnActorLeaveArea += new Del_Void_Actor(OnActorLeave);
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		EventActiveTick(DeltaTime);
	}

	private void OnSystemActive()
	{
	}

	private void OnSystemDective()
	{
	}

	private void ResetTimer()
	{
		IntervalTriggerLogicData.RemainInterval = IntervalTriggerLogicData.TriggerInterval;
		IntervalTriggerLogicData.DuringTime = IntervalTriggerLogicData.RemainDuringTime;
	}

	private void EventActiveTick(float DeltaTime)
	{
		if (IntervalTriggerLogicData.bEventActive)
		{
			IntervalTriggerLogicData.RemainDuringTime -= DeltaTime;
			if (IntervalTriggerLogicData.RemainDuringTime < 0f)
			{
				OnIntervalEventEnd();
				ResetTimer();
				IntervalTriggerLogicData.bEventActive = false;
			}
		}
		else
		{
			IntervalTriggerLogicData.RemainInterval -= DeltaTime;
			if (IntervalTriggerLogicData.RemainInterval < 0f)
			{
				OnIntervalEventBegin();
				ResetTimer();
				IntervalTriggerLogicData.bEventActive = true;
			}
		}
	}

	private void OnIntervalEventBegin()
	{
		foreach (AActor innerActor in IntervalTriggerLogicData.InnerActors)
		{
			TriggerEventToUnit(innerActor);
		}
	}

	private void OnIntervalEventEnd()
	{
		foreach (AActor innerActor in IntervalTriggerLogicData.InnerActors)
		{
			EndEventToUnit(innerActor);
		}
	}

	private void TriggerEventToUnit(AActor Unit)
	{
		BUC_SimpleStateData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_SimpleStateData>(Unit);
		BUC_ActorBasicData unPersistentReadOnlyData2 = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_ActorBasicData>(Unit);
		if (unPersistentReadOnlyData == null || unPersistentReadOnlyData2 == null || unPersistentReadOnlyData.HasSimpleState(EBGUSimpleState.Berserk))
		{
			return;
		}
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Unit);
		bUS_GSEventCollection.Evt_UnitSetSimpleState.Invoke(EBGUSimpleState.Berserk);
		(Unit as BGUCharacterCS).GetActorGuid(out var outActorGuid);
		if (IntervalTriggerLogicData.AIPerceptionConfig != null && IntervalTriggerLogicData.IgnoredPerceptionSettingGuidList.Find((string Str) => Str == outActorGuid) == null)
		{
			bUS_GSEventCollection.Evt_SetAIPerceptionConfig.Invoke(IntervalTriggerLogicData.AIPerceptionConfig);
		}
		if (unPersistentReadOnlyData2.ActorType == BGU_ActorType.CharacterPlayer)
		{
			foreach (int playerAddBuff in IntervalTriggerLogicData.PlayerAddBuffList)
			{
				bUS_GSEventCollection.Evt_BuffAdd.Invoke(playerAddBuff, Owner, Owner, -1f, EBuffSourceType.IntervalTrigger);
			}
			if (Unit != null && Unit is APawn aPawn && aPawn.IsLocallyControlled())
			{
				BPS_EventCollectionCS.GetLocal(aPawn)?.Evt_AddPostProcessMat.Invoke(EPostProcessSource.IntervalTrigger, (int)Owner.GetUniqueID(), Owner, IntervalTriggerLogicData.PostProcessMatConfig);
			}
			if (IntervalTriggerLogicData.AkEventBegin != null && IntervalTriggerLogicData.AkEventStop != null && IntervalTriggerLogicData.VolumeBGMConfigDA != null && IntervalTriggerLogicData.VolumeGroupConfig != null)
			{
				BGMVolumeInfo volumeInfo = new BGMVolumeInfo(IntervalTriggerLogicData.AkEventBegin, IntervalTriggerLogicData.AkEventStop, IntervalTriggerLogicData.VolumeBGMConfigDA, IntervalTriggerLogicData.VolumeGroupConfig);
				base.BGSEventCollection?.Evt_BGS_PlayerEnterBgmVolume.Invoke(Owner, volumeInfo);
			}
			return;
		}
		foreach (int addBuff in IntervalTriggerLogicData.AddBuffList)
		{
			bUS_GSEventCollection.Evt_BuffAdd.Invoke(addBuff, Owner, Owner, -1f, EBuffSourceType.IntervalTrigger);
		}
	}

	private void EndEventToUnit(AActor Unit)
	{
		BUC_SimpleStateData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_SimpleStateData>(Unit);
		BUC_ActorBasicData unPersistentReadOnlyData2 = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_ActorBasicData>(Unit);
		if (unPersistentReadOnlyData == null || unPersistentReadOnlyData2 == null || !unPersistentReadOnlyData.HasSimpleState(EBGUSimpleState.Berserk))
		{
			return;
		}
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Unit);
		bUS_GSEventCollection.Evt_UnitSetSimpleState.Invoke(EBGUSimpleState.Berserk, IsRemove: true);
		bUS_GSEventCollection.Evt_UpdatePerceptionConfig.Invoke();
		if (unPersistentReadOnlyData2.ActorType == BGU_ActorType.CharacterPlayer)
		{
			foreach (int playerAddBuff in IntervalTriggerLogicData.PlayerAddBuffList)
			{
				bUS_GSEventCollection.Evt_BuffRemove.Invoke(playerAddBuff, EBuffEffectTriggerType.Remove, 1);
			}
			if (Unit != null && Unit is APawn aPawn && aPawn.IsLocallyControlled())
			{
				BPS_EventCollectionCS.GetLocal(Unit)?.Evt_RemovePostProcessMat.Invoke(EPostProcessSource.IntervalTrigger, (int)Owner.GetUniqueID());
			}
			base.BGSEventCollection.Evt_BGS_PlayerLeaveBgmVolume.Invoke(Owner);
			return;
		}
		foreach (int addBuff in IntervalTriggerLogicData.AddBuffList)
		{
			bUS_GSEventCollection.Evt_BuffRemove.Invoke(addBuff, EBuffEffectTriggerType.Remove, 1);
		}
	}

	private void OnActorEnter(AActor OtherActor)
	{
		if (IntervalTriggerLogicData.bEventActive)
		{
			TriggerEventToUnit(OtherActor);
		}
		IntervalTriggerLogicData.InnerActors.Add(OtherActor);
	}

	private void OnActorLeave(AActor OtherActor)
	{
		if (IntervalTriggerLogicData.bEventActive)
		{
			EndEventToUnit(OtherActor);
		}
		IntervalTriggerLogicData.InnerActors.Remove(OtherActor);
	}
}
