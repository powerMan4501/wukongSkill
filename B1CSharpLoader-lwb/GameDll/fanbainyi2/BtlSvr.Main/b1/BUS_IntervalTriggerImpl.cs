using b1.EventDelDefine;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUS_IntervalTriggerImpl : BUS_StateMachineCompBase
{
	public class IntervalTriggerEnableState : GSStateBase
	{
		public float CachedIntervalTriggerTime;

		public float CachedIntervalTriggerDuringTime;

		public override FGameplayTag StateTag => BGW_FlowUtils.OverlapTag.State_Enabled;

		public override void OnInitialize()
		{
			base.OnInitialize();
			base.EventTransitDictionary.Add(BGW_FlowUtils.SceneObjCommonEventTag.Next, BGW_FlowUtils.OverlapTag.State_Disabled);
		}

		public override void OnEnterAction(BUS_StateMachineCompBase InOwner)
		{
			if (InOwner is BUS_IntervalTriggerImpl bUS_IntervalTriggerImpl)
			{
				BUC_IntervalTriggerData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_IntervalTriggerData>(bUS_IntervalTriggerImpl.Owner);
				bUS_IntervalTriggerImpl.SetIsActive(readOnlyData.OverlapEnabled);
			}
		}

		public override void OnTickAction(BUS_StateMachineCompBase InOwner, float DeltaTime)
		{
			base.OnTickAction(InOwner, DeltaTime);
			BUS_IntervalTriggerImpl bUS_IntervalTriggerImpl = InOwner as BUS_IntervalTriggerImpl;
			BUC_IntervalTriggerData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_IntervalTriggerData>(bUS_IntervalTriggerImpl.Owner);
			if (bUS_IntervalTriggerImpl == null)
			{
				return;
			}
			if (readOnlyData.OverlapEnabled)
			{
				bUS_IntervalTriggerImpl.ResetNotiedWarning();
				readOnlyData.DuringTimer -= DeltaTime;
				GSGameplayCVar.CVar_DebugIntervalTrigger.GetValueInGameThread();
				if (readOnlyData.DuringTimer < 0f)
				{
					readOnlyData.DuringTimer = readOnlyData.CachedIntervalTriggerDuringTime;
					readOnlyData.OverlapEnabled = false;
					bUS_IntervalTriggerImpl.SetIsActive(IsActive: false);
				}
			}
			else
			{
				readOnlyData.Timer -= DeltaTime;
				GSGameplayCVar.CVar_DebugIntervalTrigger.GetValueInGameThread();
				bUS_IntervalTriggerImpl.CheckIsWarning(readOnlyData.Timer);
				if (readOnlyData.Timer < 0f)
				{
					readOnlyData.Timer = readOnlyData.CachedIntervalTriggerTime;
					readOnlyData.OverlapEnabled = true;
					bUS_IntervalTriggerImpl.SetIsActive(IsActive: true);
				}
			}
		}
	}

	public class IntervalTriggerDisableState : GSStateBase
	{
		public override FGameplayTag StateTag => BGW_FlowUtils.OverlapTag.State_Disabled;

		public override void OnInitialize()
		{
			base.OnInitialize();
			base.EventTransitDictionary.Add(BGW_FlowUtils.SceneObjCommonEventTag.Next, BGW_FlowUtils.OverlapTag.State_Enabled);
		}

		public override void OnEnterAction(BUS_StateMachineCompBase InOwner)
		{
			if (InOwner is BUS_IntervalTriggerImpl bUS_IntervalTriggerImpl)
			{
				bUS_IntervalTriggerImpl.SetIsActive(IsActive: false);
				bUS_IntervalTriggerImpl.CleanInVolumeActors();
			}
		}
	}

	private const float TriggerAddBuffTime = 1f;

	private float Timer;

	private BUC_IntervalTriggerData IntervalTriggerData { get; set; }

	private IBGC_UnrealGameplayData UnrealGameplayData { get; set; }

	private BPS_GSEventCollection BPSEventEventCollection { get; set; }

	public override void OnAttach()
	{
		base.OnAttach();
		IntervalTriggerData = RequireWritableData<BUC_IntervalTriggerData>();
		UnrealGameplayData = RequireReadOnlyGameStateData<IBGC_UnrealGameplayData, BGC_UnrealGameplayData>();
		AddState(typeof(IntervalTriggerEnableState), 0);
		GSStateBase initialState = AddState(typeof(IntervalTriggerDisableState), 1);
		base.InitialState = initialState;
		base.BUSEventCollection.Evt_OnActorEnterArea += new Del_Void_Actor(OnActorEnter);
		base.BUSEventCollection.Evt_OnActorLeaveArea += new Del_Void_Actor(OnActorLeave);
		base.BUSEventCollection.Evt_ResetActorStatusAfterAll += new Del_Void_ResetActorReason(OnResetActorStatusAfterAll);
		Timer = 1f;
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		base.OnEndPlay(EndPlayReason);
		SetIsActive(IsActive: false);
		CleanInVolumeActors();
	}

	private void OnResetActorStatusAfterAll(EResetActorReason Resetreason)
	{
		if (!IntervalTriggerData.bIsActive)
		{
			return;
		}
		foreach (string inVolumeActor in IntervalTriggerData.InVolumeActors)
		{
			BGUCharacterCS bGUCharacterCS = BGU_DataUtil.GetActorByGuid(base.Owner, inVolumeActor) as BGUCharacterCS;
			if (!bGUCharacterCS.IsNullOrDestroyed())
			{
				OnCollisionEndOverlapImpl(bGUCharacterCS, inVolumeActor);
			}
			if (!bGUCharacterCS.IsNullOrDestroyed())
			{
				OnCollisionBeginOverlapImpl(bGUCharacterCS, inVolumeActor);
			}
		}
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		base.OnTickWithGroup(DeltaTime, TickGroup);
		if (!IntervalTriggerData.bIsActive)
		{
			return;
		}
		if (Timer > 0f)
		{
			Timer -= DeltaTime;
			return;
		}
		Timer = 1f;
		if (IntervalTriggerData.InVolumePlayer.IsNullOrDestroyed())
		{
			return;
		}
		IBUC_BuffData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_BuffData, BUC_BuffData>(IntervalTriggerData.InVolumePlayer);
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(IntervalTriggerData.InVolumePlayer);
		foreach (int playerAddBuff in IntervalTriggerData.PlayerAddBuffList)
		{
			if ((readOnlyData == null || !readOnlyData.HasBuff(playerAddBuff)) && bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection?.Evt_BuffAdd.Invoke(playerAddBuff, base.Owner, base.Owner, -1f, EBuffSourceType.IntervalTrigger);
			}
		}
	}

	protected virtual void OnCollisionBeginOverlapImpl(BGUCharacterCS OtherActor, string Guid, bool CanAddInDead = false)
	{
		if (OtherActor == null)
		{
			return;
		}
		BUC_SimpleStateData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_SimpleStateData>(OtherActor);
		BUC_ActorBasicData unPersistentReadOnlyData2 = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_ActorBasicData>(OtherActor);
		if (unPersistentReadOnlyData == null || unPersistentReadOnlyData2 == null || unPersistentReadOnlyData.HasSimpleState(EBGUSimpleState.Berserk))
		{
			return;
		}
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(OtherActor);
		bUS_GSEventCollection.Evt_UnitSetSimpleState.Invoke(EBGUSimpleState.Berserk);
		OtherActor.GetActorGuid(out var outActorGuid);
		if (IntervalTriggerData.AIPerceptionConfig != null && IntervalTriggerData.IgnoredPerceptionSettingGuidList.Find((string Str) => Str == outActorGuid) == null)
		{
			bUS_GSEventCollection.Evt_SetAIPerceptionConfig.Invoke(IntervalTriggerData.AIPerceptionConfig);
		}
		if (unPersistentReadOnlyData2.ActorType == BGU_ActorType.CharacterPlayer)
		{
			foreach (int playerAddBuff in IntervalTriggerData.PlayerAddBuffList)
			{
				bUS_GSEventCollection.Evt_BuffAdd.Invoke(playerAddBuff, base.Owner, base.Owner, -1f, EBuffSourceType.IntervalTrigger);
			}
			if (OtherActor != null)
			{
				if ((object)OtherActor != null && OtherActor.IsLocallyControlled())
				{
					BPS_EventCollectionCS.GetLocal(OtherActor)?.Evt_AddPostProcessMat.Invoke(EPostProcessSource.IntervalTrigger, (int)base.Owner.GetUniqueID(), base.Owner, IntervalTriggerData.PostProcessMatConfig);
				}
			}
			return;
		}
		foreach (int addBuff in IntervalTriggerData.AddBuffList)
		{
			bUS_GSEventCollection.Evt_BuffAdd.Invoke(addBuff, base.Owner, base.Owner, -1f, EBuffSourceType.IntervalTrigger);
		}
		if (IntervalTriggerData.SpGuidList.Find((string s) => s.Contains(Guid)) != null)
		{
			bUS_GSEventCollection.Evt_BuffAdd.Invoke(IntervalTriggerData.SpBuffID, base.Owner, base.Owner, -1f, EBuffSourceType.IntervalTrigger);
		}
	}

	protected virtual void OnCollisionEndOverlapImpl(BGUCharacterCS OtherActor, string Guid)
	{
		if (OtherActor == null)
		{
			return;
		}
		BUC_SimpleStateData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_SimpleStateData>(OtherActor);
		BUC_ActorBasicData unPersistentReadOnlyData2 = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_ActorBasicData>(OtherActor);
		if (unPersistentReadOnlyData == null || unPersistentReadOnlyData2 == null || !unPersistentReadOnlyData.HasSimpleState(EBGUSimpleState.Berserk))
		{
			return;
		}
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(OtherActor);
		bUS_GSEventCollection.Evt_UnitSetSimpleState.Invoke(EBGUSimpleState.Berserk, IsRemove: true);
		bUS_GSEventCollection.Evt_UpdatePerceptionConfig.Invoke();
		if (unPersistentReadOnlyData2.ActorType == BGU_ActorType.CharacterPlayer)
		{
			foreach (int playerAddBuff in IntervalTriggerData.PlayerAddBuffList)
			{
				bUS_GSEventCollection.Evt_BuffRemove.Invoke(playerAddBuff, EBuffEffectTriggerType.Remove, 1);
			}
			if (OtherActor != null)
			{
				if ((object)OtherActor != null && OtherActor.IsLocallyControlled())
				{
					BPS_EventCollectionCS.GetLocal(OtherActor)?.Evt_RemovePostProcessMat.Invoke(EPostProcessSource.IntervalTrigger, (int)base.Owner.GetUniqueID());
				}
			}
			return;
		}
		foreach (int addBuff in IntervalTriggerData.AddBuffList)
		{
			bUS_GSEventCollection.Evt_BuffRemove.Invoke(addBuff, EBuffEffectTriggerType.Remove, 1);
		}
		if (IntervalTriggerData.SpGuidList.Find((string s) => s.Contains(Guid)) != null)
		{
			bUS_GSEventCollection.Evt_BuffRemove.Invoke(IntervalTriggerData.SpBuffID, EBuffEffectTriggerType.Remove, 1);
		}
	}

	protected virtual void OnActorEnter(AActor OtherActor)
	{
		if (OtherActor as BGUPlayerCharacterCS != null)
		{
			IntervalTriggerData.InVolumePlayer = OtherActor;
		}
		string outActorGuid = "";
		BGUCharacterCS bGUCharacterCS = OtherActor as BGUCharacterCS;
		if (!bGUCharacterCS.IsNullOrDestroyed())
		{
			bGUCharacterCS.GetActorGuid(out outActorGuid);
			if (!IntervalTriggerData.InVolumeActors.Contains(outActorGuid))
			{
				IntervalTriggerData.InVolumeActors.Add(outActorGuid);
			}
			if (IntervalTriggerData.IgnoredGuidList.Find((string Str) => Str == outActorGuid) == null && IntervalTriggerData.bIsActive)
			{
				OnCollisionBeginOverlapImpl(bGUCharacterCS, outActorGuid);
			}
		}
	}

	protected virtual void OnActorLeave(AActor OtherActor)
	{
		if (OtherActor as BGUPlayerCharacterCS != null && IntervalTriggerData.InVolumePlayer == OtherActor)
		{
			IntervalTriggerData.InVolumePlayer = null;
		}
		string outActorGuid = "";
		BGUCharacterCS bGUCharacterCS = OtherActor as BGUCharacterCS;
		if (!bGUCharacterCS.IsNullOrDestroyed())
		{
			bGUCharacterCS.GetActorGuid(out outActorGuid);
			IntervalTriggerData.InVolumeActors.Remove(outActorGuid);
			if (IntervalTriggerData.IgnoredGuidList.Find((string Str) => Str == outActorGuid) == null)
			{
				OnCollisionEndOverlapImpl(bGUCharacterCS, outActorGuid);
			}
		}
	}

	protected void SetIsActive(bool IsActive)
	{
		bool bIsActive = IntervalTriggerData.bIsActive;
		IntervalTriggerData.bIsActive = IsActive;
		Timer = 1f;
		if (IsActive && bIsActive != IsActive)
		{
			foreach (string inVolumeActor in IntervalTriggerData.InVolumeActors)
			{
				AActor actorByGuid = BGU_DataUtil.GetActorByGuid(base.Owner, inVolumeActor);
				if (!actorByGuid.IsNullOrDestroyed())
				{
					OnCollisionBeginOverlapImpl(actorByGuid as BGUCharacterCS, inVolumeActor);
				}
			}
		}
		if (IsActive || bIsActive == IsActive)
		{
			return;
		}
		foreach (string inVolumeActor2 in IntervalTriggerData.InVolumeActors)
		{
			AActor actorByGuid2 = BGU_DataUtil.GetActorByGuid(base.Owner, inVolumeActor2);
			if (!actorByGuid2.IsNullOrDestroyed())
			{
				OnCollisionEndOverlapImpl(actorByGuid2 as BGUCharacterCS, inVolumeActor2);
			}
		}
	}

	protected void CleanInVolumeActors()
	{
		IntervalTriggerData.InVolumeActors.Clear();
	}

	protected void CheckIsWarning(float Timer)
	{
		if (IntervalTriggerData.IsNotifiedWarning || !(Timer - IntervalTriggerData.WarningTime < 0f))
		{
			return;
		}
		IntervalTriggerData.IsNotifiedWarning = true;
		if (!IntervalTriggerData.InVolumePlayer.IsNullOrDestroyed())
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(IntervalTriggerData.InVolumePlayer);
			if (bUS_GSEventCollection != null && bUS_GSEventCollection.HasBeginPlay)
			{
				bUS_GSEventCollection.Evt_BuffAdd.Invoke(IntervalTriggerData.WarningBuffID, IntervalTriggerData.InVolumePlayer, IntervalTriggerData.InVolumePlayer, 0f);
			}
			GSGameplayCVar.CVar_DebugIntervalTrigger.GetValueInGameThread();
		}
	}

	private void ResetNotiedWarning()
	{
		IntervalTriggerData.IsNotifiedWarning = false;
	}
}
