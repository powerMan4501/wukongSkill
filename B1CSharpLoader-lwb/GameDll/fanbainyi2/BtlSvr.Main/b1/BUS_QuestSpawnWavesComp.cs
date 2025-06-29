using System.Collections.Generic;
using b1.EventDelDefine;
using BtlB1;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;

namespace b1;

public class BUS_QuestSpawnWavesComp : BUS_StateMachineCompBase
{
	public class SpawnWaveTemplate_Base
	{
		protected BUS_QuestSpawnWavesComp ParentComp;

		protected AActor Owner;

		protected BUC_QuestSpawnWaveData SpawnWaveData;

		protected IBGC_SummonData SummonManagerData;

		public void Init(BUS_QuestSpawnWavesComp _ParentComp, BUC_QuestSpawnWaveData _SpawnWaveData, IBGC_SummonData _SummonManagerData)
		{
			ParentComp = _ParentComp;
			Owner = _ParentComp.Owner;
			SpawnWaveData = _SpawnWaveData;
			SummonManagerData = _SummonManagerData;
		}

		public virtual void ActiveCurrentWaveUnits()
		{
		}

		public virtual void TriggerCurrentWave()
		{
		}

		public virtual void UpdateNextWaveCondition(float DeltaTime)
		{
		}

		public virtual void UpdateCurWave(float DeltaTime)
		{
		}

		public virtual void OnUnitDead(string InUnitGuid, EDeadReason InDeadReason)
		{
		}

		public virtual void OnUnitSpawnFinished(FServantReq ServantReq)
		{
		}

		protected void SpawnWaveUpdate(FSpawnWave_OneWaveTemplate OneWaveTemplate, float DeltaTime)
		{
			OneWaveTemplate.UnitSpawnTimer += DeltaTime;
			if (OneWaveTemplate.UnitSpawnTimer < OneWaveTemplate.SpawnInterval)
			{
				return;
			}
			BGUCharacterCS bGUCharacterCS = UBGUFunctionLibrary.GetPlayerCharacter(Owner) as BGUCharacterCS;
			if (bGUCharacterCS == null)
			{
				return;
			}
			for (int i = OneWaveTemplate.CurSpawnIndex; i < OneWaveTemplate.SpawnWaveUnits.Count; i++)
			{
				FSpawnWaveUnitConfigForData unitConfig = OneWaveTemplate.SpawnWaveUnits[i];
				SpawnOneUnit_ByUnitConfig(OneWaveTemplate, unitConfig, bGUCharacterCS);
				if (OneWaveTemplate.SpawnInterval > 1E-08f)
				{
					break;
				}
			}
		}

		protected void Fill_SpawnWaveUpdate(FSpawnWave_OneWaveTemplate OneWaveTemplate, float DeltaTime)
		{
			OneWaveTemplate.UnitSpawnTimer += DeltaTime;
			if (OneWaveTemplate.UnitSpawnTimer < OneWaveTemplate.SpawnInterval)
			{
				return;
			}
			BGUCharacterCS bGUCharacterCS = UBGUFunctionLibrary.GetPlayerCharacter(Owner) as BGUCharacterCS;
			if (bGUCharacterCS == null)
			{
				return;
			}
			for (int i = OneWaveTemplate.CurSpawnIndex - OneWaveTemplate.SpawnWaveUnits.Count; i < OneWaveTemplate.SpawnWaveUnits_Fill.Count; i++)
			{
				FSpawnWaveUnitConfigForData unitConfig = OneWaveTemplate.SpawnWaveUnits_Fill[i];
				SpawnOneUnit_ByUnitConfig(OneWaveTemplate, unitConfig, bGUCharacterCS);
				if (OneWaveTemplate.SpawnInterval > 1E-08f)
				{
					break;
				}
			}
		}

		protected void OnSpawnUnitFinished(FSpawnWave_OneWaveTemplate WaveConfig, string SpawnedUnitGuid)
		{
			if (!string.IsNullOrEmpty(SpawnedUnitGuid))
			{
				WaveConfig.SpawnedUnits.Add(SpawnedUnitGuid);
				if (!SpawnWaveData.bSpawnUnitAnyActive)
				{
					SpawnWaveData.WatchActiveUnits.Add(SpawnedUnitGuid);
				}
			}
		}

		protected void SpawnOneUnit_ByUnitConfig(FSpawnWave_OneWaveTemplate OneWaveTemplate, FSpawnWaveUnitConfigForData UnitConfig, BGUCharacterCS Player)
		{
			switch (UnitConfig.SpawnPointType)
			{
			case ESpawnPointType.UseSpawnPoints:
				foreach (TSoftObject<BGUBattlePaceSpawnPointActor> spawnPoint in UnitConfig.SpawnPoints)
				{
					if (spawnPoint.IsValid)
					{
						FVector actorLocation = spawnPoint.Value.GetActorLocation();
						FRotator actorRotation2 = spawnPoint.Value.GetActorRotation();
						SpawnOneUnit(OneWaveTemplate, UnitConfig, actorLocation, actorRotation2, Player);
					}
				}
				break;
			case ESpawnPointType.UseEQS:
			{
				List<FVector> Locations;
				List<float> Scores;
				if (UnitConfig.QueryConfig.Count > 0)
				{
					ParentComp.BGSEventCollection.Evt_BGS_EQSObjRunInstantWithCustomParams.Invoke(UnitConfig.EQSTemplate, Owner, UnitConfig.QueryConfig, out Locations, out Scores);
				}
				else
				{
					ParentComp.BGSEventCollection.Evt_BGS_EQSObjRunInstant.Invoke(UnitConfig.EQSTemplate, Owner, out Locations, out Scores);
				}
				foreach (FVector item in Locations)
				{
					FRotator zeroRotator2 = FRotator.ZeroRotator;
					SpawnOneUnit(OneWaveTemplate, UnitConfig, item, zeroRotator2, Player);
				}
				break;
			}
			case ESpawnPointType.UseLocalSpaceOffset:
			{
				FTransform t = FTransform.Default;
				switch (UnitConfig.LocalSpaceType)
				{
				case ESpawnWaveLocalSpaceType.LocalPlayer:
				{
					APlayerController firstLocalPlayerController2 = UGSE_EngineFuncLib.GetFirstLocalPlayerController(Owner);
					if (firstLocalPlayerController2.IsNullOrDestroyed())
					{
						return;
					}
					APawn controlledPawn2 = firstLocalPlayerController2.GetControlledPawn();
					if (controlledPawn2.IsNullOrDestroyed())
					{
						return;
					}
					t = controlledPawn2.GetActorTransform();
					break;
				}
				case ESpawnWaveLocalSpaceType.LocalController:
				{
					APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(Owner);
					if (firstLocalPlayerController.IsNullOrDestroyed())
					{
						return;
					}
					APawn controlledPawn = firstLocalPlayerController.GetControlledPawn();
					if (controlledPawn.IsNullOrDestroyed())
					{
						return;
					}
					FRotator actorRotation = firstLocalPlayerController.GetActorRotation();
					actorRotation.Roll = 0f;
					actorRotation.Pitch = 0f;
					t = new FTransform(actorRotation, controlledPawn.GetActorLocation());
					break;
				}
				}
				FVector inLocation = t.TransformLocation(UnitConfig.LocalSpaceOffset);
				FRotator zeroRotator = FRotator.ZeroRotator;
				SpawnOneUnit(OneWaveTemplate, UnitConfig, inLocation, zeroRotator, Player);
				break;
			}
			}
			OneWaveTemplate.CurSpawnIndex++;
			OneWaveTemplate.SpawnInterval = FMath.FRandRange(OneWaveTemplate.SpawnIntervalRange.X, OneWaveTemplate.SpawnIntervalRange.Y);
			OneWaveTemplate.UnitSpawnTimer = 0f;
		}

		private void SpawnOneUnit(FSpawnWave_OneWaveTemplate OneWave, FSpawnWaveUnitConfigForData UnitConfig, FVector InLocation, FRotator InRotation, AActor Player)
		{
			AActor value = UnitConfig.SpawnMaster.Value;
			FSummonSpawnConfigWrap spawnConfigWrap = default(FSummonSpawnConfigWrap);
			if (!value.IsNullOrDestroyed())
			{
				spawnConfigWrap.IsSummonerAsMaster = true;
			}
			spawnConfigWrap.SummonAliveTime = -1f;
			spawnConfigWrap.TamerTemplate = UnitConfig.UnitClass.Value;
			spawnConfigWrap.SummonUnitLocationType = ESummonUnitLocationType.UseEffectPos;
			spawnConfigWrap.SummonUnitRotationType = (UnitConfig.bIsFacePlayer ? ESummonUnitRotationType.FacingLocalPlayer : ESummonUnitRotationType.UseSpawnPointRot);
			spawnConfigWrap.SafeClampToLand = true;
			spawnConfigWrap.EnsureBornPosCanNavToPlayer = ParentComp.SpawnWaveData.EnsureBornPosCanNavToPlayer;
			spawnConfigWrap.SearchTargetType = EServantSearchTargetType.ByPerception;
			if (UnitConfig.bIsCatchPlayer)
			{
				spawnConfigWrap.SearchTargetType = EServantSearchTargetType.CatchPlayer;
			}
			spawnConfigWrap.BornMontages = new List<UAnimMontage>();
			if (UnitConfig.SpawnMontage != null)
			{
				spawnConfigWrap.BornMontages.Add(UnitConfig.SpawnMontage);
			}
			spawnConfigWrap.SpawnBirthBuff = new List<int>();
			if (UnitConfig.BirthBuff != null && UnitConfig.BirthBuff.Count > 0)
			{
				spawnConfigWrap.SpawnBirthBuff.AddRange(UnitConfig.BirthBuff);
			}
			FSummonReq inSummonReq = new FSummonReq
			{
				SummonType = ESummonType.MonsterSpawn,
				SummonGuid = OneWave.SummonGuid,
				SpawnConfigWrap = spawnConfigWrap,
				Summoner = ((value == null) ? Owner : value),
				HitLocation = InLocation,
				SpawnPointRot = InRotation
			};
			BPS_EventCollectionCS.GetLocal(Owner).Evt_RequestSummon.Invoke(inSummonReq);
			string spawnedUnitGuid = string.Empty;
			string finalGuid = ParentComp.GuidData.GetFinalGuid();
			SummonManagerData.GetSummonInstancesBySummoner(finalGuid, out var OutSummonInstances);
			if (OutSummonInstances.Count > 0)
			{
				int count = OutSummonInstances[OutSummonInstances.Count - 1].ServantReqList.Count;
				if (count > 0)
				{
					spawnedUnitGuid = OutSummonInstances[OutSummonInstances.Count - 1].ServantReqList[count - 1].ServantTamerGuid;
				}
			}
			OnSpawnUnitFinished(OneWave, spawnedUnitGuid);
		}

		protected void OnCurWaveBeCleared()
		{
			if (SpawnWaveData.SpawnWaveGroupID > 0 && SpawnWaveData.SpawnWaveGlobleGroupCD > 0f)
			{
				ParentComp.BGSEventCollection?.Evt_BGS_HandleSpawnWaveGroupCD.Invoke(SpawnWaveData.SpawnWaveGroupID, SpawnWaveData.SpawnWaveGlobleGroupCD);
			}
		}
	}

	public class SpawnWaveTemplate_Sequence : SpawnWaveTemplate_Base
	{
		public override void ActiveCurrentWaveUnits()
		{
			FSpawnWaveConfigForData currentWave = SpawnWaveData.GetCurrentWave();
			if (currentWave == null)
			{
				return;
			}
			BGUCharacterCS bGUCharacterCS = BGU_UnrealWorldUtil.GetNearestPlayerActor(Owner) as BGUCharacterCS;
			if (bGUCharacterCS == null)
			{
				return;
			}
			foreach (string spawnedUnit in currentWave.WaveTemplate.SpawnedUnits)
			{
				BUS_EventCollectionCS.Get(BGU_DataUtil.GetActorByGuid(Owner, spawnedUnit))?.Evt_AICatchTarget.Invoke(bGUCharacterCS, ETargetSourceType.Target_CQGAssignTarget);
			}
		}

		public override void TriggerCurrentWave()
		{
			FSpawnWaveConfigForData currentWave = SpawnWaveData.GetCurrentWave();
			if (currentWave != null)
			{
				currentWave.WaveTemplate.OnWaveStarted();
				currentWave.NextWaveStartCondition.OnWaveStarted();
				SpawnWaveUpdate(currentWave.WaveTemplate, 0f);
			}
			else
			{
				ParentComp.OnEvent(BGW_FlowUtils.SpawnerTag.Event_Clear);
				ParentComp.BGSEventCollection?.Evt_BGS_WaveSpawnEventClear.Invoke(Owner);
			}
		}

		public override void UpdateCurWave(float DeltaTime)
		{
			FSpawnWaveConfigForData currentWave = SpawnWaveData.GetCurrentWave();
			if (currentWave != null)
			{
				currentWave.WaveTemplate.WaveTime += DeltaTime;
				if (currentWave.WaveTemplate.bUnitAllDead)
				{
					currentWave.WaveTemplate.TimerAfterPreviousClear += DeltaTime;
				}
				if (!currentWave.WaveTemplate.bIsCurWaveFinished())
				{
					SpawnWaveUpdate(currentWave.WaveTemplate, DeltaTime);
				}
				if (ParentComp.UpdateNextWaveCondition(currentWave.NextWaveStartCondition, currentWave.WaveTemplate))
				{
					SpawnWaveData.CurrentWaveIndex++;
					TriggerCurrentWave();
				}
			}
		}

		public override void OnUnitDead(string InUnitGuid, EDeadReason InDeadReason)
		{
			FSpawnWaveConfigForData currentWave = SpawnWaveData.GetCurrentWave();
			if (currentWave != null && currentWave.WaveTemplate.SpawnedUnits.Remove(InUnitGuid) && currentWave.WaveTemplate.SpawnedUnits.Count == 0)
			{
				currentWave.WaveTemplate.bUnitAllDead = true;
				OnCurWaveBeCleared();
			}
		}
	}

	public class SpawnWaveTemplate_Infinite : SpawnWaveTemplate_Base
	{
		public override void ActiveCurrentWaveUnits()
		{
			FSpawnWaveConfigForData currentWave = SpawnWaveData.GetCurrentWave();
			if (currentWave == null)
			{
				return;
			}
			BGUCharacterCS bGUCharacterCS = BGU_UnrealWorldUtil.GetNearestPlayerActor(Owner) as BGUCharacterCS;
			if (bGUCharacterCS == null)
			{
				return;
			}
			foreach (string spawnedUnit in currentWave.WaveTemplate.SpawnedUnits)
			{
				BUS_EventCollectionCS.Get(BGU_DataUtil.GetActorByGuid(Owner, spawnedUnit))?.Evt_AICatchTarget.Invoke(bGUCharacterCS, ETargetSourceType.Target_CQGAssignTarget);
			}
		}

		public override void TriggerCurrentWave()
		{
			SpawnWaveData.SpawnWaveConfig_Infinite.StartNewWave();
			FSpawnWave_OneWaveTemplate currentWave = SpawnWaveData.SpawnWaveConfig_Infinite.GetCurrentWave();
			if (currentWave != null)
			{
				currentWave.OnWaveStarted();
				SpawnWaveData.SpawnWaveConfig_Infinite.NextWaveStartCondition.OnWaveStarted();
				SpawnWaveUpdate(currentWave, 0f);
			}
			else
			{
				ParentComp.OnEvent(BGW_FlowUtils.SpawnerTag.Event_Clear);
				ParentComp.BGSEventCollection?.Evt_BGS_WaveSpawnEventClear.Invoke(Owner);
			}
		}

		public void TriggerFillSpawn()
		{
			FSpawnWave_OneWaveTemplate currentWave = SpawnWaveData.SpawnWaveConfig_Infinite.GetCurrentWave();
			if (currentWave != null)
			{
				currentWave.bFlag_FillEventAlreadyTriggered = true;
				currentWave.UnitSpawnTimer = 0f;
				Fill_SpawnWaveUpdate(currentWave, 0f);
			}
		}

		public override void UpdateCurWave(float DeltaTime)
		{
			FSpawnWave_OneWaveTemplate currentWave = SpawnWaveData.SpawnWaveConfig_Infinite.GetCurrentWave();
			if (currentWave != null)
			{
				currentWave.WaveTime += DeltaTime;
				if (currentWave.bUnitAllDead)
				{
					currentWave.TimerAfterPreviousClear += DeltaTime;
				}
				if (!currentWave.bIsCurWaveFinished())
				{
					SpawnWaveUpdate(currentWave, DeltaTime);
				}
				else if (currentWave.bIsInFillWaveSpawn())
				{
					Fill_SpawnWaveUpdate(currentWave, DeltaTime);
				}
				if (ParentComp.UpdateNextWaveCondition(SpawnWaveData.SpawnWaveConfig_Infinite.NextWaveStartCondition, currentWave))
				{
					SpawnWaveData.CurrentWaveIndex++;
					TriggerCurrentWave();
				}
			}
		}

		public override void OnUnitDead(string InUnitGuid, EDeadReason InDeadReason)
		{
			FSpawnWave_OneWaveTemplate currentWave = SpawnWaveData.SpawnWaveConfig_Infinite.GetCurrentWave();
			if (currentWave != null && currentWave.SpawnedUnits.Remove(InUnitGuid))
			{
				if (currentWave.bIsCurWaveFinished() && InDeadReason == EDeadReason.SkillDamage && currentWave.SpawnedUnits.Count < currentWave.RemainUnitNumToTriggerFill)
				{
					TriggerFillSpawn();
				}
				if (currentWave.SpawnedUnits.Count == 0)
				{
					currentWave.bUnitAllDead = true;
					OnCurWaveBeCleared();
				}
			}
		}
	}

	public class State_Disabled : GSStateBase
	{
		public override FGameplayTag StateTag => BGW_FlowUtils.SpawnerTag.State_Disabled;

		public override void OnInitialize()
		{
			base.OnInitialize();
			base.EventTransitDictionary.Add(BGW_FlowUtils.SpawnerTag.Event_Enable, BGW_FlowUtils.SpawnerTag.State_Idled);
		}
	}

	public class State_Idled : GSStateBase
	{
		public override FGameplayTag StateTag => BGW_FlowUtils.SpawnerTag.State_Idled;

		public override void OnInitialize()
		{
			base.OnInitialize();
			base.EventTransitDictionary.Add(BGW_FlowUtils.SpawnerTag.Event_Spawn, BGW_FlowUtils.SpawnerTag.State_Spawned);
		}
	}

	public class State_Spawned : GSStateBase
	{
		public override FGameplayTag StateTag => BGW_FlowUtils.SpawnerTag.State_Spawned;

		public override void OnInitialize()
		{
			base.OnInitialize();
			base.EventTransitDictionary.Add(BGW_FlowUtils.SpawnerTag.Event_Clear, BGW_FlowUtils.SpawnerTag.State_Cleared);
			base.EventTransitDictionary.Add(BGW_FlowUtils.SpawnerTag.Event_RecoveryToIdle, BGW_FlowUtils.SpawnerTag.State_Idled);
			base.ReactionDictionary.Add(BGW_FlowUtils.SpawnerTag.Event_Active, delegate(BUS_StateMachineCompBase InOwner)
			{
				if (InOwner is BUS_QuestSpawnWavesComp bUS_QuestSpawnWavesComp)
				{
					bUS_QuestSpawnWavesComp.ActiveCurrentWaveUnits();
				}
			});
		}

		public override void OnEnterAction(BUS_StateMachineCompBase InOwner)
		{
			if (InOwner is BUS_QuestSpawnWavesComp bUS_QuestSpawnWavesComp)
			{
				bUS_QuestSpawnWavesComp.StartWaves();
			}
		}

		public override void OnExitAction(BUS_StateMachineCompBase InOwner)
		{
			if (InOwner is BUS_QuestSpawnWavesComp bUS_QuestSpawnWavesComp)
			{
				bUS_QuestSpawnWavesComp.StopWaves();
			}
		}

		public override void OnTickAction(BUS_StateMachineCompBase InOwner, float DeltaTime)
		{
			if (InOwner is BUS_QuestSpawnWavesComp bUS_QuestSpawnWavesComp)
			{
				bUS_QuestSpawnWavesComp.UpdateNextWaveCondition(DeltaTime);
			}
		}

		public override void OnRecoverAction(BUS_StateMachineCompBase InOwner)
		{
			if (InOwner is BUS_QuestSpawnWavesComp bUS_QuestSpawnWavesComp)
			{
				if (bUS_QuestSpawnWavesComp.SpawnWaveData.bRecoverToNoSpawn)
				{
					bUS_QuestSpawnWavesComp.OnEvent(BGW_FlowUtils.SpawnerTag.Event_RecoveryToIdle);
					return;
				}
				bUS_QuestSpawnWavesComp.StopWaves();
				bUS_QuestSpawnWavesComp.StartWaves();
			}
		}
	}

	public class State_Cleared : GSStateBase
	{
		public override FGameplayTag StateTag => BGW_FlowUtils.SpawnerTag.State_Cleared;

		public override void OnInitialize()
		{
			base.OnInitialize();
			base.EventTransitDictionary.Add(BGW_FlowUtils.SpawnerTag.Event_Disable, BGW_FlowUtils.SpawnerTag.State_Disabled);
		}

		public override void OnEnterAction(BUS_StateMachineCompBase InOwner)
		{
			NotifyGraph(InOwner, BGW_FlowUtils.CommonTag.SpawnUnitAllDead);
		}
	}

	private IBGC_SummonData SummonManagerData;

	private IBGC_SpawnWaveGroupMgrData SpawnWaveGroupMgrData;

	private SpawnWaveTemplate_Base SpawnTemlate;

	private bool HasTriggerStart;

	private BUC_QuestSpawnWaveData SpawnWaveData { get; set; }

	protected T CreateSpawnWaveTemplate<T>(BUS_QuestSpawnWavesComp _ParentComp, BUC_QuestSpawnWaveData _SpawnWaveData, IBGC_SummonData SummonManagerData) where T : SpawnWaveTemplate_Base, new()
	{
		T val = new T();
		val.Init(_ParentComp, _SpawnWaveData, SummonManagerData);
		return val;
	}

	public override void OnAttach()
	{
		base.OnAttach();
		SpawnWaveData = RequireWritableData<BUC_QuestSpawnWaveData>();
		SummonManagerData = RequireReadOnlyGameStateData<IBGC_SummonData, BGC_SummonData>();
		SpawnWaveGroupMgrData = RequireReadOnlyGameStateData<IBGC_SpawnWaveGroupMgrData, BGC_SpawnWaveGroupMgrData>();
		base.SceneObjTag = BGW_FlowUtils.SceneObjTag.Spawner;
		GSStateBase initialState = AddState(typeof(State_Disabled), 0);
		AddState(typeof(State_Idled), 1);
		AddState(typeof(State_Spawned), 2);
		AddState(typeof(State_Cleared), 3);
		base.InitialState = initialState;
		base.BGSEventCollection.Evt_BGS_UnitInBattle += new Del_UnitInBattle(OnUnitInBattle);
		base.BGSEventCollection.Evt_NotifyReceiveServantReq += new Del_Void_ServantReq(OnNotifyReceiveServantReq);
		switch (SpawnWaveData.SpawnWaveType)
		{
		case ESpawnWaveType.SpawnSequence:
			SpawnTemlate = CreateSpawnWaveTemplate<SpawnWaveTemplate_Sequence>(this, SpawnWaveData, SummonManagerData);
			break;
		case ESpawnWaveType.SpawnInfinite:
			SpawnTemlate = CreateSpawnWaveTemplate<SpawnWaveTemplate_Infinite>(this, SpawnWaveData, SummonManagerData);
			break;
		}
	}

	public override void PreBeginPlay()
	{
		HasTriggerStart = false;
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		base.OnEndPlay(EndPlayReason);
		base.BGSEventCollection.Evt_BGS_UnitInBattle -= new Del_UnitInBattle(OnUnitInBattle);
		base.BGSEventCollection.Evt_NotifyReceiveServantReq -= new Del_Void_ServantReq(OnNotifyReceiveServantReq);
	}

	private void OnUnitInBattle(BGUCharacterCS BGUChr, string UnitGuid, int BattleInfoExtendID, bool CanForceLeaveBattle)
	{
		if (SpawnWaveData.WatchActiveUnits.Contains(UnitGuid))
		{
			SpawnWaveData.WatchActiveUnits.Clear();
			SpawnWaveData.bSpawnUnitAnyActive = true;
			NotifyGraph(BGW_FlowUtils.CommonTag.WakeUp);
		}
	}

	private void OnNotifyReceiveServantReq(FServantReq ServantReq)
	{
		SpawnTemlate.OnUnitSpawnFinished(ServantReq);
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (HasTriggerStart)
		{
			if (SpawnWaveData.CurrentWaveIndex == -1)
			{
				if (UpdateNextWaveCondition(SpawnWaveData.FirstWaveStartCondition, null))
				{
					TriggerFirstWave();
				}
			}
			else
			{
				SpawnTemlate.UpdateCurWave(DeltaTime);
			}
		}
		UpdateDebugInfo();
	}

	private void StartWaves()
	{
		if (!HasTriggerStart)
		{
			HasTriggerStart = true;
			SpawnWaveData.CurrentWaveIndex = -1;
			SpawnWaveData.FirstWaveStartCondition.OnWaveStarted();
			if (UpdateNextWaveCondition(SpawnWaveData.FirstWaveStartCondition, null))
			{
				TriggerFirstWave();
			}
		}
	}

	private void TriggerFirstWave()
	{
		SpawnWaveData.CurrentWaveIndex = 0;
		base.BGSEventCollection.Evt_BGS_UnitDead += new Del_Void_StringDeadReason(OnUnitDead);
		base.BGSEventCollection.Evt_BGS_ResetActorDestroy += new Del_Void_String(OnResetActorDestroy);
		SpawnWaveData.bSpawnUnitAnyActive = false;
		SpawnWaveData.WatchActiveUnits.Clear();
		TriggerCurrentWave();
	}

	public bool UpdateNextWaveCondition(FCompositeCondition_SpawnWaveStartForData NextWaveCondition, FSpawnWave_OneWaveTemplate WaveTemplate)
	{
		bool flag = false;
		if (NextWaveCondition.bUseCompositeCondition)
		{
			foreach (FSpawnWaveStartConditionForData condition in NextWaveCondition.Conditions)
			{
				switch (condition.ConditionType)
				{
				case ESpawnWaveStartConditionType.Auto:
					condition.bConditionSuccess = true;
					break;
				case ESpawnWaveStartConditionType.PreviousClear:
					if (WaveTemplate != null)
					{
						condition.bConditionSuccess = WaveTemplate.bUnitAllDead;
					}
					else
					{
						condition.bConditionSuccess = true;
					}
					break;
				case ESpawnWaveStartConditionType.TimeAfterPrevious:
					if (WaveTemplate != null)
					{
						condition.bConditionSuccess = WaveTemplate.WaveTime >= condition.Time;
					}
					else
					{
						condition.bConditionSuccess = true;
					}
					break;
				case ESpawnWaveStartConditionType.TimeAfterPreviousClear:
					if (WaveTemplate != null)
					{
						condition.bConditionSuccess = WaveTemplate.TimerAfterPreviousClear >= condition.Time;
					}
					else
					{
						condition.bConditionSuccess = true;
					}
					break;
				case ESpawnWaveStartConditionType.GlobleCDFinished:
					if (SpawnWaveGroupMgrData != null)
					{
						condition.bConditionSuccess = !SpawnWaveGroupMgrData.IsInCD(SpawnWaveData.SpawnWaveGroupID);
					}
					break;
				}
			}
			if (NextWaveCondition.ConditionalRelation == EConditionalRelation.And)
			{
				flag = true;
				foreach (FSpawnWaveStartConditionForData condition2 in NextWaveCondition.Conditions)
				{
					if (!condition2.bConditionSuccess)
					{
						flag = false;
						break;
					}
				}
			}
			else
			{
				flag = false;
				foreach (FSpawnWaveStartConditionForData condition3 in NextWaveCondition.Conditions)
				{
					if (condition3.bConditionSuccess)
					{
						flag = true;
						break;
					}
				}
			}
		}
		else
		{
			FSpawnWaveStartConditionForData single = NextWaveCondition.Single;
			switch (single.ConditionType)
			{
			case ESpawnWaveStartConditionType.Auto:
				single.bConditionSuccess = true;
				break;
			case ESpawnWaveStartConditionType.PreviousClear:
				if (WaveTemplate != null)
				{
					single.bConditionSuccess = WaveTemplate.bUnitAllDead;
				}
				else
				{
					single.bConditionSuccess = true;
				}
				break;
			case ESpawnWaveStartConditionType.TimeAfterPrevious:
				if (WaveTemplate != null)
				{
					single.bConditionSuccess = WaveTemplate.WaveTime >= single.Time;
				}
				else
				{
					single.bConditionSuccess = true;
				}
				break;
			case ESpawnWaveStartConditionType.TimeAfterPreviousClear:
				if (WaveTemplate != null)
				{
					single.bConditionSuccess = WaveTemplate.TimerAfterPreviousClear >= single.Time;
				}
				else
				{
					single.bConditionSuccess = true;
				}
				break;
			case ESpawnWaveStartConditionType.GlobleCDFinished:
				if (SpawnWaveGroupMgrData != null)
				{
					single.bConditionSuccess = !SpawnWaveGroupMgrData.IsInCD(SpawnWaveData.SpawnWaveGroupID);
				}
				else
				{
					single.bConditionSuccess = true;
				}
				break;
			}
			flag = single.bConditionSuccess;
		}
		return flag;
	}

	private void StopWaves()
	{
		HasTriggerStart = false;
		if (SpawnWaveData.GetCurWaveTemplate() == null)
		{
			return;
		}
		base.BGSEventCollection.Evt_BGS_UnitDead -= new Del_Void_StringDeadReason(OnUnitDead);
		base.BGSEventCollection.Evt_BGS_ResetActorDestroy -= new Del_Void_String(OnResetActorDestroy);
		if (SpawnWaveData.SpawnWaveType == ESpawnWaveType.SpawnSequence)
		{
			foreach (FSpawnWaveConfigForData wave in SpawnWaveData.Waves)
			{
				foreach (string spawnedUnit in wave.WaveTemplate.SpawnedUnits)
				{
					HandleWaveStopAction(spawnedUnit);
				}
				wave.WaveTemplate.SpawnedUnits.Clear();
			}
		}
		else if (SpawnWaveData.SpawnWaveType == ESpawnWaveType.SpawnInfinite)
		{
			foreach (FSpawnWave_OneWaveTemplate item in SpawnWaveData.SpawnWaveConfig_Infinite.WaveTemplateArray)
			{
				foreach (string spawnedUnit2 in item.SpawnedUnits)
				{
					HandleWaveStopAction(spawnedUnit2);
				}
				item.SpawnedUnits.Clear();
			}
		}
		SpawnWaveData.WatchActiveUnits.Clear();
		SpawnWaveData.CurrentWaveIndex = -1;
	}

	private void HandleWaveStopAction(string SpawnedUnitGuid)
	{
		switch (SpawnWaveData.WaveStopActionType)
		{
		case EWaveStopActionType.DestroyAllSpawnedUnits:
			BGU_UnrealWorldUtil.RequestDestroyUnit(base.Owner, SpawnedUnitGuid);
			break;
		case EWaveStopActionType.SpawnedUnitsReturnHome:
		{
			AActor actorByGuid = BGU_DataUtil.GetActorByGuid(base.Owner, SpawnedUnitGuid);
			if (!actorByGuid.IsNullOrDestroyed())
			{
				BUS_EventCollectionCS.Get(actorByGuid)?.Evt_NotifyUnitReturnHome.Invoke(P1: false);
			}
			break;
		}
		}
	}

	private void OnUnitDead(string InUnitGuid, EDeadReason InDeadReason)
	{
		SpawnTemlate.OnUnitDead(InUnitGuid, InDeadReason);
	}

	private void OnResetActorDestroy(string TamerGuid)
	{
		SpawnTemlate.OnUnitDead(TamerGuid, EDeadReason.OnlyDestroyUnit);
	}

	private void ActiveCurrentWaveUnits()
	{
		SpawnTemlate.ActiveCurrentWaveUnits();
	}

	private void TriggerCurrentWave()
	{
		SpawnTemlate.TriggerCurrentWave();
	}

	private void UpdateNextWaveCondition(float DeltaTime)
	{
		SpawnTemlate.UpdateNextWaveCondition(DeltaTime);
	}

	private void UpdateDebugInfo()
	{
		if (!DebugConfig.SpawnWaveDebug)
		{
			return;
		}
		if (HasTriggerStart)
		{
			FSlateColor green = B1GlobalFSlateColor.Green;
			base.BUSEventCollection.Evt_UpdateDebugUILamp.Invoke("SpawnWaveDebug", green);
			base.BUSEventCollection.Evt_UpdateDebugUIInfo.Invoke("SpawnWaveDebug", "SpawnWave已触发");
			base.BUSEventCollection.Evt_UpdateDebugUIKeyValuePair.Invoke("SpawnWaveDebug", $"组{SpawnWaveData.SpawnWaveGroupID} 冷却时间", SpawnWaveGroupMgrData.GetGroupGlobleCD(SpawnWaveData.SpawnWaveGroupID).ToString());
			base.BUSEventCollection.Evt_UpdateDebugUIKeyValuePair.Invoke("SpawnWaveDebug", "当前波持续时间", "0");
			base.BUSEventCollection.Evt_UpdateDebugUIKeyValuePair.Invoke("SpawnWaveDebug", "上波清完后的持续时间", "0");
			base.BUSEventCollection.Evt_UpdateDebugUIKeyValuePair.Invoke("SpawnWaveDebug", "当前波剩余单位列表: 数量 ", "0");
			FSpawnWave_OneWaveTemplate curWaveTemplate = SpawnWaveData.GetCurWaveTemplate();
			if (curWaveTemplate != null)
			{
				base.BUSEventCollection.Evt_UpdateDebugUIKeyValuePair.Invoke("SpawnWaveDebug", "当前波持续时间", curWaveTemplate.WaveTime.ToString());
				base.BUSEventCollection.Evt_UpdateDebugUIKeyValuePair.Invoke("SpawnWaveDebug", "上波清完后的持续时间", curWaveTemplate.TimerAfterPreviousClear.ToString());
				base.BUSEventCollection.Evt_UpdateDebugUIKeyValuePair.Invoke("SpawnWaveDebug", "当前波剩余单位列表: 数量 ", curWaveTemplate.SpawnedUnits.Count.ToString());
			}
		}
		else
		{
			FSlateColor red = B1GlobalFSlateColor.Red;
			base.BUSEventCollection.Evt_UpdateDebugUILamp.Invoke("SpawnWaveDebug", red);
			base.BUSEventCollection.Evt_UpdateDebugUIInfo.Invoke("SpawnWaveDebug", "SpawnWave未触发");
			base.BUSEventCollection.Evt_UpdateDebugUIKeyValuePair.Invoke("SpawnWaveDebug", $"组{SpawnWaveData.SpawnWaveGroupID} 冷却时间", SpawnWaveGroupMgrData.GetGroupGlobleCD(SpawnWaveData.SpawnWaveGroupID).ToString());
			base.BUSEventCollection.Evt_UpdateDebugUIKeyValuePair.Invoke("SpawnWaveDebug", "当前波持续时间", "0");
			base.BUSEventCollection.Evt_UpdateDebugUIKeyValuePair.Invoke("SpawnWaveDebug", "上波清完后的持续时间", "0");
			base.BUSEventCollection.Evt_UpdateDebugUIKeyValuePair.Invoke("SpawnWaveDebug", "当前波剩余单位列表: 数量 ", "0");
		}
	}
}
