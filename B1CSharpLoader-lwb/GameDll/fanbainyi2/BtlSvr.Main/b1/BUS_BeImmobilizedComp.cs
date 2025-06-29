using System.Collections.Generic;
using b1.BGW;
using b1.EventDelDefine;
using b1.Plugins.TressFX;
using BtlB1;
using BtlShare;
using GSDispLib;
using UnrealEngine.AIModule;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.Niagara;
using UnrealEngine.Runtime;

namespace b1;

public class BUS_BeImmobilizedComp : UActorCompBaseCS
{
	private List<USkeletalMeshComponent> AllowRBANSkMeshList = new List<USkeletalMeshComponent>();

	private const float INV10000 = 0.0001f;

	private BUC_BeImmobilizedData BeImmobilizedData { get; set; }

	private IBUC_SimpleStateData SimpleStateData { get; set; }

	private IBUC_UnitStateData UnitStateData { get; set; }

	private IBUC_BeAttackData BeAttackData { get; set; }

	private IBUC_AttrContainer AttrContainer { get; set; }

	private IBUC_GuidData GuidData { get; set; }

	private void ClearRBANSkMeshCache()
	{
		if (AllowRBANSkMeshList != null && AllowRBANSkMeshList.Count > 0)
		{
			AllowRBANSkMeshList.Clear();
		}
	}

	public override void OnAttach()
	{
		BeImmobilizedData = RequireWritableData<BUC_BeImmobilizedData>();
		SimpleStateData = RequireReadOnlyData<IBUC_SimpleStateData, BUC_SimpleStateData>();
		UnitStateData = RequireReadOnlyData<IBUC_UnitStateData, BUC_UnitStateData>();
		BeAttackData = RequireReadOnlyData<IBUC_BeAttackData, BUC_BeAttackData>();
		AttrContainer = RequireReadOnlyData<IBUC_AttrContainer, BUC_AttrContainer>();
		GuidData = RequireReadOnlyData<IBUC_GuidData, BUC_GuidData>();
		base.BUSEventCollection.Evt_TriggerImmobilize += new Del_TriggerTargetImmobilize(OnTriggerImmobilize);
		base.BUSEventCollection.Evt_RelieveImmobilized += new Del_Void(RelieveImmobilized);
		base.BUSEventCollection.Evt_HitWhenInImmobilized += new Del_HitWhenInImmobilized(OnHitWhenInImmobilized);
		base.BUSEventCollection.Evt_TriggerImmobilizedBreak += new Del_TriggerImmobilizedBreak(OnTriggerImmobilizedBreak);
		base.BUSEventCollection.Evt_TriggerAttackStiffForBeImmobilized += new Del_Void_Int(OnTriggerAttackStiffForBeImmobilized);
		base.BUSEventCollection.Evt_DeadWhenInImmobilized += new Del_DeadWhenInImmobilized(OnDeadWhenInImmobilized);
		base.BUSEventCollection.Evt_RelieveImmobilizedClient += new Del_Void(OnRelieveImmobilizedClient);
		base.BGSEventCollection.Evt_ReliveAllImmobilized += new Del_Void(RelieveImmobilized);
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		base.OnEndPlay(EndPlayReason);
		ClearRBANSkMeshCache();
		base.BGSEventCollection.Evt_ReliveAllImmobilized -= new Del_Void(RelieveImmobilized);
	}

	public override void OnBeginPlay()
	{
		BeImmobilizedData.ResId = GetActorResID();
		InitImmobilizedInfo();
		FUStUnitCommDesc unitCommDesc = BGW_GameDB.GetUnitCommDesc(BeImmobilizedData.ResId);
		if (unitCommDesc != null)
		{
			BeImmobilizedData.ImmobilizedBaseDefense = unitCommDesc.DingShenDef;
		}
		FUStUnitBattleInfoExtendDesc unitBattleInfoExtendDesc = BGW_GameDB.GetUnitBattleInfoExtendDesc(GetFinalBattleInfoExtendID());
		int num = 0;
		if (unitBattleInfoExtendDesc != null)
		{
			num = unitBattleInfoExtendDesc.BeImmoblizedConfigIndex;
		}
		BGWDataAsset_GlobalBeImmobilizedConfig bGWDataAsset_GlobalBeImmobilizedConfig = null;
		BGW_GameDB.GetGlobalConfigByAlias(B1GlobalConfigFNames.GlobalBeImmobilizedConfig, out var ConfigInfo);
		if (ConfigInfo != null)
		{
			bGWDataAsset_GlobalBeImmobilizedConfig = PreloadAssetMgr.TryGetCachedResourceObj<BGWDataAsset_GlobalBeImmobilizedConfig>(ConfigInfo.StringValue, ELoadResourceType.SyncLoadAndCache);
		}
		if (!(bGWDataAsset_GlobalBeImmobilizedConfig == null) && bGWDataAsset_GlobalBeImmobilizedConfig.BeImmobilizedConfigs.Count != 0 && num < bGWDataAsset_GlobalBeImmobilizedConfig.BeImmobilizedConfigs.Count)
		{
			BeImmobilizedData.BeImmobilizedConfig = bGWDataAsset_GlobalBeImmobilizedConfig.BeImmobilizedConfigs[num];
		}
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (!UnitStateData.HasState(EBGUUnitState.Beatback))
		{
			BeImmobilizedData.CurrentAttackStiffLevel = -1;
		}
		if (BeImmobilizedData.ImmobilizedRemainTime > 0f)
		{
			BeImmobilizedData.ImmobilizedRemainTime -= DeltaTime;
			if (BeImmobilizedData.ImmobilizedRemainTime <= 0f || !SimpleStateData.HasSimpleState(EBGUSimpleState.Immobilizing))
			{
				RelieveImmobilized();
			}
			else if (BeImmobilizedData.AlmostFXPlayTime > 0f && BeImmobilizedData.ImmobilizedRemainTime <= BeImmobilizedData.AlmostFXPlayTime)
			{
				DoAlmostRelieveImmobilized();
			}
		}
		else if (SimpleStateData.HasSimpleState(EBGUSimpleState.Immobilizing))
		{
			base.BUSEventCollection.Evt_UnitSetSimpleState.Invoke(EBGUSimpleState.Immobilizing, IsRemove: true);
		}
		if (SimpleStateData.HasSimpleState(EBGUSimpleState.BreakImmobilize2Weak) && BeImmobilizedData.RemoveBreakImmobilizedStateTimer > 0f)
		{
			BeImmobilizedData.RemoveBreakImmobilizedStateTimer -= DeltaTime;
			if (BeImmobilizedData.RemoveBreakImmobilizedStateTimer <= 0f)
			{
				BeImmobilizedData.RemoveBreakImmobilizedStateTimer = 0f;
				base.BUSEventCollection.Evt_UnitSetSimpleState.Invoke(EBGUSimpleState.BreakImmobilize2Weak, IsRemove: true);
			}
		}
	}

	private void OnTriggerAttackStiffForBeImmobilized(int InStiffLevel)
	{
		if (!(BeImmobilizedData.BeImmobilizedConfig == null))
		{
			BeImmobilizedData.CurrentAttackStiffLevel = InStiffLevel;
		}
	}

	private void OnTriggerImmobilize(ImmobilizeConfigInstance ConfigInstance)
	{
		BGUCharacterCS bGUCharacterCS = GetOwner() as BGUCharacterCS;
		if (bGUCharacterCS == null)
		{
			return;
		}
		if (BeImmobilizedData.BeImmobilizedRepeatedCount > 0)
		{
			StopAlmostEndFX();
			StopBeginFX();
			StopBreakingFX();
			RemoveBeginBuffs();
		}
		float num = 1f;
		BGWDataAsset_BeImmobilizedConfig beImmobilizedConfig = BeImmobilizedData.BeImmobilizedConfig;
		if (beImmobilizedConfig != null)
		{
			if (SimpleStateData.HasSimpleState(EBGUSimpleState.BreakPart2Weak))
			{
				num = ((!ConfigInstance.bEnableGreatSageTalent) ? beImmobilizedConfig.ImmobilizeTimeFactorForBreakPart2Weak : beImmobilizedConfig.SpecialImmobilizeTimeFactorForBreakPart2Weak);
			}
			else if (BeImmobilizedData.CurrentAttackStiffLevel > 0)
			{
				int currentAttackStiffLevel = BeImmobilizedData.CurrentAttackStiffLevel;
				num = beImmobilizedConfig.DefaultImmobilizeTimeFactorForBeAttacked;
				float value2;
				if (ConfigInstance.bEnableGreatSageTalent)
				{
					if (beImmobilizedConfig.SpecialImmobilizeTimeFactorForBeAttacked.TryGetValue(currentAttackStiffLevel, out var value))
					{
						num = value;
					}
				}
				else if (beImmobilizedConfig.ImmobilizeTimeFactorForBeAttacked.TryGetValue(currentAttackStiffLevel, out value2))
				{
					num = value2;
				}
			}
		}
		GSGameplayCVar.CVar_ShowImmobilizedDebug.GetValueInGameThread();
		_ = 1;
		ConfigInstance.DurationSecond *= (BeImmobilizedData.ImmobilizedBaseDefense * num * (1f - ConfigInstance.RepeatedImmobilizedDef * (float)BeImmobilizedData.BeImmobilizedRepeatedCount) + AttrContainer.GetFloatValue(EBGUAttrFloat.DingshenDefAddition)) / 100f;
		GSGameplayCVar.CVar_ShowImmobilizedDebug.GetValueInGameThread();
		_ = 1;
		ConfigInstance.DurationSecond = FMath.Max(ConfigInstance.DurationSecond, ConfigInstance.MinDurationSecond);
		GSGameplayCVar.CVar_ShowImmobilizedDebug.GetValueInGameThread();
		_ = 1;
		BeImmobilizedData.ConfigInstance = ConfigInstance;
		BeImmobilizedData.ImmobilizedRemainTime = ConfigInstance.DurationSecond;
		BeImmobilizedData.AlmostFXPlayTime = ConfigInstance.AlmostEndAheadTimeSecond;
		BeImmobilizedData.BeImmobilizedRepeatedCount++;
		if (BeImmobilizedData.AlmostFXPlayTime > 0f && ConfigInstance.DurationSecond <= BeImmobilizedData.AlmostFXPlayTime)
		{
			DoQuickRelieveImmobilized();
		}
		else if (ConfigInstance.BeginFX != null)
		{
			base.BUSEventCollection.Evt_RequestSpawnFXByDispConfigDA.Invoke(ConfigInstance.BeginFX, out var RequestID);
			BeImmobilizedData.BeginFXRequestID = RequestID;
		}
		else
		{
			BeImmobilizedData.BeginFXRequestID = -1;
		}
		TriggerSpellEffects(ConfigInstance.BeginEffects, ConfigInstance.CasterActor, ConfigInstance.CasterActor, bBeginEffect: true);
		if (SimpleStateData.HasSimpleState(EBGUSimpleState.Immobilizing))
		{
			return;
		}
		base.BUSEventCollection.Evt_UnitSetSimpleState.Invoke(EBGUSimpleState.Immobilizing);
		if (SimpleStateData.HasSimpleState(EBGUSimpleState.Frozen))
		{
			base.BUSEventCollection.Evt_ClearAbnormalState.Invoke(new HashSet<EAbnormalStateType> { EAbnormalStateType.Abnormal_Freeze });
		}
		base.BUSEventCollection.Evt_MarkSummonCantLifeOver.Invoke(P1: true);
		BGUFuncLibAnim.BGUSetCharacterMontagePlaying(bGUCharacterCS, IsPlaying: false);
		BGUFuncLibAnim.BGUSetUseSnapshotPose(bGUCharacterCS, bUseSnapshot: true, 0f);
		base.BUSEventCollection.Evt_SetAllSweepCheckPaused.Invoke(P1: true);
		base.BUSEventCollection.Evt_SetAllAttackWarningPaused.Invoke(P1: true);
		List<UActorComponent> componentsByClass = OwnerAsCharacterCS.GetComponentsByClass(UClass.GetClass<UActorComponent>());
		if (componentsByClass != null && componentsByClass.Count > 0)
		{
			ClearRBANSkMeshCache();
			foreach (UActorComponent item in componentsByClass)
			{
				if (item is USkeletalMeshComponent uSkeletalMeshComponent)
				{
					uSkeletalMeshComponent.SuspendClothingSimulation();
					if (uSkeletalMeshComponent.GetAllowRigidBodyAnimNode())
					{
						uSkeletalMeshComponent.SetAllowRigidBodyAnimNode(bInAllow: false, bReinitAnim: false);
						AllowRBANSkMeshList.Add(uSkeletalMeshComponent);
					}
					uSkeletalMeshComponent.SetAllBodiesPhysicsBlendWeight(0f);
				}
				else if (item is UTressFXComponent uTressFXComponent)
				{
					uTressFXComponent.SetSimulatePhysics(bSimulate: false);
				}
			}
		}
		bGUCharacterCS.CharacterMovement.Velocity = FVector.ZeroVector;
		bGUCharacterCS.CharacterMovement.Deactivate();
		BUS_DispLibEventCollection.Get(Owner)?.Evt_RequestSetDBCEffectsPause?.Invoke(0, Pause: true, -1, "BeImmobilized");
		UBGUCrowdFollowingComponent uBGUCrowdFollowingComponent = (bGUCharacterCS.GetController() as AIController)?.GetPathFollowingComponent() as UBGUCrowdFollowingComponent;
		if (uBGUCrowdFollowingComponent != null)
		{
			uBGUCrowdFollowingComponent.Pause = true;
		}
		base.BUSEventCollection.Evt_AIPauseBT.Invoke(P1: true);
		base.BUSEventCollection.Evt_AIPauseFsm.Invoke(P1: true);
		base.BUSEventCollection.Evt_AIPerceptionSetting.Invoke(P1: false);
		base.BUSEventCollection.Evt_EnableCanUpdateHatred.Invoke(P1: false);
	}

	private void DoAlmostRelieveImmobilized()
	{
		if (BeImmobilizedData.ConfigInstance.AlmostEndFX != null)
		{
			StopBeginFX();
			base.BUSEventCollection.Evt_RequestSpawnFXByDispConfigDA.Invoke(BeImmobilizedData.ConfigInstance.AlmostEndFX, out var RequestID);
			BeImmobilizedData.AlmostEndFXRequestID = RequestID;
		}
		else
		{
			BeImmobilizedData.AlmostEndFXRequestID = -1;
		}
		BeImmobilizedData.AlmostFXPlayTime = -1f;
	}

	private void DoQuickRelieveImmobilized()
	{
		if (BeImmobilizedData.ConfigInstance.QuickFX != null)
		{
			StopBeginFX();
			base.BUSEventCollection.Evt_RequestSpawnFXByDispConfigDA.Invoke(BeImmobilizedData.ConfigInstance.QuickFX, out var RequestID);
			BeImmobilizedData.AlmostEndFXRequestID = RequestID;
		}
		else
		{
			BeImmobilizedData.AlmostEndFXRequestID = -1;
		}
		BeImmobilizedData.AlmostFXPlayTime = -1f;
	}

	private void RelieveImmobilized()
	{
		if (GetOwner() as BGUCharacterCS != null && SimpleStateData.HasSimpleState(EBGUSimpleState.Immobilizing))
		{
			base.BUSEventCollection.Evt_UnitSetSimpleState.Invoke(EBGUSimpleState.Immobilizing, IsRemove: true);
			base.BUSEventCollection.Evt_RelieveImmobilizedClient.Invoke();
		}
	}

	private void OnRelieveImmobilizedClient()
	{
		BGUCharacterCS bGUCharacterCS = GetOwner() as BGUCharacterCS;
		if (bGUCharacterCS == null)
		{
			return;
		}
		ImmobilizeConfigInstance configInstance = BeImmobilizedData.ConfigInstance;
		if (configInstance == null)
		{
			return;
		}
		StopAlmostEndFX();
		StopBeginFX();
		StopBreakingFX();
		RemoveBeginBuffs();
		BGUFuncLibAnim.BGUSetCharacterMontagePlaying(bGUCharacterCS, IsPlaying: true);
		BGUFuncLibAnim.BGUSetUseSnapshotPose(bGUCharacterCS, bUseSnapshot: false, 0.3f);
		base.BUSEventCollection.Evt_SetAllSweepCheckPaused.Invoke(P1: false);
		base.BUSEventCollection.Evt_SetAllAttackWarningPaused.Invoke(P1: false);
		List<UActorComponent> componentsByClass = OwnerAsCharacterCS.GetComponentsByClass(UClass.GetClass<UActorComponent>());
		if (componentsByClass != null && componentsByClass.Count > 0)
		{
			foreach (UActorComponent item in componentsByClass)
			{
				if (item is USkeletalMeshComponent uSkeletalMeshComponent)
				{
					uSkeletalMeshComponent.ResumeClothingSimulation();
					uSkeletalMeshComponent.SetAllBodiesPhysicsBlendWeight(1f);
					if (AllowRBANSkMeshList.Contains(uSkeletalMeshComponent))
					{
						uSkeletalMeshComponent.SetAllowRigidBodyAnimNode(bInAllow: true, bReinitAnim: false);
						AllowRBANSkMeshList.Remove(uSkeletalMeshComponent);
					}
				}
				else if (item is UTressFXComponent uTressFXComponent)
				{
					uTressFXComponent.SetSimulatePhysics(bSimulate: true);
				}
			}
		}
		ClearRBANSkMeshCache();
		bGUCharacterCS.CharacterMovement.Activate();
		UBGUCrowdFollowingComponent uBGUCrowdFollowingComponent = (bGUCharacterCS.GetController() as AIController)?.GetPathFollowingComponent() as UBGUCrowdFollowingComponent;
		if (uBGUCrowdFollowingComponent != null)
		{
			uBGUCrowdFollowingComponent.Pause = false;
		}
		base.BUSEventCollection.Evt_MarkSummonCantLifeOver.Invoke(P1: false);
		base.BUSEventCollection.Evt_AIPauseBT.Invoke(P1: false);
		base.BUSEventCollection.Evt_AIPauseFsm.Invoke(P1: false);
		base.BUSEventCollection.Evt_AIPerceptionSetting.Invoke(P1: true);
		base.BUSEventCollection.Evt_EnableCanUpdateHatred.Invoke(P1: true);
		BUS_DispLibEventCollection.Get(Owner)?.Evt_RequestSetDBCEffectsPause?.Invoke(0, Pause: false, -1, "BeImmobilized");
		if (configInstance.EndFX != null)
		{
			base.BUSEventCollection.Evt_RequestSpawnFXByDispConfigDA.Invoke(configInstance.EndFX, out var _);
		}
		TriggerSpellEffects(configInstance.EndEffects, configInstance.CasterActor, configInstance.CasterActor);
		InitImmobilizedInfo();
	}

	private void StopBeginFX()
	{
		if (BeImmobilizedData.BeginFXRequestID >= 0)
		{
			base.BUSEventCollection.Evt_RequestDestroyByFXRequestID.Invoke(BeImmobilizedData.BeginFXRequestID);
			BeImmobilizedData.BeginFXRequestID = -1;
		}
	}

	private void StopAlmostEndFX()
	{
		if (BeImmobilizedData.AlmostEndFXRequestID >= 0)
		{
			base.BUSEventCollection.Evt_RequestDestroyByFXRequestID.Invoke(BeImmobilizedData.AlmostEndFXRequestID);
			BeImmobilizedData.AlmostEndFXRequestID = -1;
		}
	}

	private void StopBreakingFX()
	{
		if (BeImmobilizedData.BreakingFXRequestID >= 0)
		{
			base.BUSEventCollection.Evt_RequestDestroyByFXRequestID.Invoke(BeImmobilizedData.BreakingFXRequestID);
			BeImmobilizedData.BreakingFXRequestID = -1;
		}
	}

	private void OnHitWhenInImmobilized(float ImmobilizeHitHP)
	{
		if (BeImmobilizedData.ImmobilizedRemainTime > 0f)
		{
			BeImmobilizedData.CurrentImmobilizeHP -= ImmobilizeHitHP;
			if (BeImmobilizedData.BreakingFXRequestID == -1 && BeImmobilizedData.CurrentImmobilizeHP > 0f && BeImmobilizedData.CurrentImmobilizeHP / BeImmobilizedData.MaxImmobilizeHP < BeImmobilizedData.ConfigInstance.BreakingFXsTriggerRatio && BeImmobilizedData.ConfigInstance.BreakingFX != null)
			{
				base.BUSEventCollection.Evt_RequestSpawnFXByDispConfigDA.Invoke(BeImmobilizedData.ConfigInstance.BreakingFX, out var RequestID);
				BeImmobilizedData.BreakingFXRequestID = RequestID;
			}
		}
	}

	private void OnTriggerImmobilizedBreak(AActor Attacker, int StiffLevel, in FEffectInstReq EffectInstReq, UAnimMontage BreakImmobilizeAM, bool bIsNormalStiff)
	{
		ACharacter aCharacter = GetOwner() as ACharacter;
		if (aCharacter == null || BeImmobilizedData == null || BeImmobilizedData.ConfigInstance == null)
		{
			return;
		}
		List<FSpellEffectForData> breakEffects = BeImmobilizedData.ConfigInstance.BreakEffects;
		AActor casterActor = BeImmobilizedData.ConfigInstance.CasterActor;
		RelieveImmobilized();
		base.BUSEventCollection.Evt_SetAllSweepCheckPaused.Invoke(P1: true);
		base.BUSEventCollection.Evt_SetAllAttackWarningPaused.Invoke(P1: true);
		TriggerSpellEffects(breakEffects, casterActor, Attacker);
		if (BreakImmobilizeAM != null)
		{
			float num = UBGUFunctionLibrary.BGUGetMontageSectionLengthByIndex(aCharacter, BreakImmobilizeAM, 0);
			BeImmobilizedData.RemoveBreakImmobilizedStateTimer = num;
			base.BUSEventCollection.Evt_OnMagicallyChangeBreak.Invoke();
			base.BUSEventCollection.Evt_UnitTryBreakSkill.Invoke("定身破碎");
			base.BUSEventCollection.Evt_UnitStateTrigger.Invoke(EBUStateTrigger.Beatback, num, NeedForceUpdate: true);
			base.BUSEventCollection.Evt_UnitSetSimpleState.Invoke(EBGUSimpleState.BreakImmobilize2Weak);
			if (!bIsNormalStiff)
			{
				BGUFuncLibAnim.BGUActorTryPlayMontage(Owner, BreakImmobilizeAM, FName.None);
			}
		}
		BGWDataAsset_UnitBeAttackedConfig uBAConfig = BGW_PreloadAssetMgr.Get(Owner).GetUBAConfig(BeImmobilizedData.ResId, GetFinalBattleInfoExtendID(), GuidData.GetFinalGuid(), BeAttackData.UnitBeAttackedConfigPath);
		if (!(uBAConfig != null))
		{
			return;
		}
		FTransform Transform = new FTransform(EffectInstReq.HitPointNormalDir, EffectInstReq.HitLocation);
		string text = uBAConfig.ImmobilizeBreakFXPath.ToString();
		UObject uObject = BGW_PreloadAssetMgr.Get(aCharacter).TryGetCachedResourceObj<UObject>(text, ELoadResourceType.AsyncLoadAndCache, EAssetPriority.Low);
		UParticleSystem uParticleSystem = null;
		UNiagaraSystem uNiagaraSystem = null;
		if (uObject != null)
		{
			uParticleSystem = uObject as UParticleSystem;
			if (uParticleSystem == null)
			{
				uNiagaraSystem = uObject as UNiagaraSystem;
			}
		}
		if (uParticleSystem != null || uNiagaraSystem != null)
		{
			if (uParticleSystem != null)
			{
				UBGUFunctionLibraryForCS.BGUSetParticleSysSortPriority(UGameplayStaticsEx.SpawnEmitterAtLocation(aCharacter, uParticleSystem, ref Transform), -1);
			}
			else
			{
				UNiagaraFunctionLibrary.SpawnSystemAtLocation(aCharacter, uNiagaraSystem, Transform.GetLocation(), Transform.Rotator(), Transform.GetScale3D(), bAutoDestroy: true, bAutoActivate: true, ENCPoolMethod.AutoRelease, bPreCullCheck: false);
			}
		}
		else
		{
			base.BUSEventCollection.Evt_RequestSpawnFXByDispConfig.Invoke(text, out var _, null, NeedSetSpawnTransform: true, Transform);
		}
	}

	private void OnDeadWhenInImmobilized(AActor Attacker, EDeadReason DeadReason)
	{
		if (DeadReason != EDeadReason.SummonDead && DeadReason != EDeadReason.OnlyDestroyUnit && SimpleStateData.HasSimpleState(EBGUSimpleState.Immobilizing) && !(GetOwner() as ACharacter == null))
		{
			ImmobilizeConfigInstance configInstance = BeImmobilizedData.ConfigInstance;
			if (configInstance != null)
			{
				TriggerSpellEffects(configInstance.DeadEffects, configInstance.CasterActor, Attacker);
			}
			RelieveImmobilized();
		}
	}

	private void InitImmobilizedInfo()
	{
		BeImmobilizedData.ConfigInstance = null;
		BeImmobilizedData.CurrentImmobilizeHP = 0f;
		BeImmobilizedData.ImmobilizedRemainTime = -1f;
		BeImmobilizedData.AlmostFXPlayTime = -1f;
		BeImmobilizedData.BeImmobilizedRepeatedCount = 0;
		FUStUnitBattleInfoExtendDesc unitBattleInfoExtendDesc = BGW_GameDB.GetUnitBattleInfoExtendDesc(OwnerAsCharacterCS.GetFinalBattleInfoExtendID());
		if (unitBattleInfoExtendDesc != null)
		{
			float floatValue = AttrContainer.GetFloatValue(EBGUAttrFloat.HpMax);
			BUC_BeImmobilizedData beImmobilizedData = BeImmobilizedData;
			float currentImmobilizeHP = (BeImmobilizedData.MaxImmobilizeHP = floatValue * unitBattleInfoExtendDesc.ImmobilityHPRadio * 0.0001f);
			beImmobilizedData.CurrentImmobilizeHP = currentImmobilizeHP;
		}
	}

	private void TriggerSpellEffects(List<FSpellEffectForData> Effects, AActor Caster, AActor Attacker, bool bBeginEffect = false)
	{
		foreach (FSpellEffectForData Effect in Effects)
		{
			if (Effect.Value <= 0)
			{
				continue;
			}
			AActor aActor = null;
			float duration = 0f;
			switch (Effect.TargetBaseType)
			{
			case ESpellTargetBaseType.Victim:
				if (bBeginEffect)
				{
					duration = -1f;
				}
				aActor = GetOwner();
				break;
			case ESpellTargetBaseType.Caster:
				aActor = Caster;
				break;
			case ESpellTargetBaseType.Attacker:
				aActor = Attacker;
				break;
			default:
				continue;
			}
			if (!aActor.IsNullOrDestroyed())
			{
				FEffectInstReq effectInstReq = default(FEffectInstReq);
				switch (Effect.TriggerEffectType)
				{
				case ESpellTriggerEffectType.SkillEffect:
					BUS_EventCollectionCS.Get(Caster)?.Evt_TriggerSkillEffect.Invoke(Effect.Value, effectInstReq, aActor);
					break;
				case ESpellTriggerEffectType.AddBuff:
					BUS_EventCollectionCS.Get(aActor)?.Evt_BuffAdd.Invoke(Effect.Value, Caster, Caster, duration, EBuffSourceType.BeImmobilized);
					break;
				case ESpellTriggerEffectType.RemoveBuff:
					BUS_EventCollectionCS.Get(aActor)?.Evt_BuffRemoveImmediately.Invoke(Effect.Value, EBuffEffectTriggerType.None);
					break;
				}
			}
		}
	}

	private void RemoveBeginBuffs()
	{
		if (BeImmobilizedData.ConfigInstance == null)
		{
			return;
		}
		foreach (FSpellEffectForData beginEffect in BeImmobilizedData.ConfigInstance.BeginEffects)
		{
			if (beginEffect.TriggerEffectType == ESpellTriggerEffectType.AddBuff && beginEffect.TargetBaseType == ESpellTargetBaseType.Victim && beginEffect.Value > 0)
			{
				base.BUSEventCollection.Evt_BuffRemove.Invoke(beginEffect.Value, EBuffEffectTriggerType.None, -1, WithTriggerRemmoveEffect: false);
			}
		}
	}
}
