using System;
using System.Collections.Generic;
using b1.BGW;
using b1.EventDelDefine;
using BtlB1;
using BtlShare;
using UnrealEngine.AIModule;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

internal class BUS_SummonCtrlComp : UActorCompBaseCS
{
	private static readonly FName BG_LOG_CATEGORY = B1GlobalFNames.SummonCtrlComp;

	private IBGC_SummonData SummonManagerData;

	private IBUC_TargetInfoData TargetInfoData;

	private IBUC_SkillInstsData SkillInstsData;

	private IBUC_BuffData BuffData;

	private IBUC_GuidData GuidData;

	private const int CopySkillTalentBuff = 279;

	private const string CopySkillTransEQSPath = "EnvQuery'/Game/00Main/Design/AI/BTs/Player/SummonMokey_FS/EQ_SummonMonkey_FS_Copy_Spawn.EQ_SummonMonkey_FS_Copy_Spawn'";

	public override void OnAttach()
	{
		TargetInfoData = RequireReadOnlyData<IBUC_TargetInfoData, BUC_TargetInfoData>();
		GuidData = RequireReadOnlyData<IBUC_GuidData, BUC_GuidData>();
		SkillInstsData = RequireReadOnlyData<IBUC_SkillInstsData, BUC_SkillInstsData>();
		BuffData = RequireReadOnlyData<IBUC_BuffData, BUC_BuffData>();
		SummonManagerData = RequireReadOnlyGameStateData<IBGC_SummonData, BGC_SummonData>();
		base.BUSEventCollection.Evt_SummonSkillCast += new Del_SummonSkillCast(RequestSummon);
		base.BUSEventCollection.Evt_SummonSkillCastByPhantomRush += new Del_SummonSkillCastByPhantomRush(RequestPhantomRushSummon);
		base.BUSEventCollection.Evt_SummonSkillCastByHatch += new Del_Void(RequestHatchSummon);
		base.BUSEventCollection.Evt_SummonRecall += new Del_Void_Actor(OnSummonRecall);
		base.BUSEventCollection.Evt_SummonUseSkill += new Del_Void_Int(OnSummonUseSkill);
		base.BUSEventCollection.Evt_DestroyAllSummons += new Del_Void(OnDestroyAllSummons);
		base.BUSEventCollection.Evt_DestroySummonsByID += new Del_Void_Int(OnDestroySummonsByID);
		base.BUSEventCollection.Evt_AddAllSummonLifeTime += new Del_AddAllSummonLifeTime(OnAddAllSummonLifeTime);
		base.BUSEventCollection.Evt_ResetActorStatusAfterAll += new Del_Void_ResetActorReason(OnResetActorStatusAfterAll);
		base.BUSEventCollection.Evt_UnitCastSkillSuccess += new Del_UnitCastSkillSuccess(OnUnitCastSkillSuccess);
		base.BUSEventCollection.Evt_UnitTriggerDead += new Del_UnitTriggerDead(OnUnitTriggerDead);
		base.BGSEventCollection.Evt_BGS_OnEnterLevelSequenceClearBattleItem += new Del_Void(OnEnterLevelSequence_DestroyAllSummons);
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		base.OnEndPlay(EndPlayReason);
		base.BGSEventCollection.Evt_BGS_OnEnterLevelSequenceClearBattleItem -= new Del_Void(OnEnterLevelSequence_DestroyAllSummons);
	}

	private void OnUnitTriggerDead(AActor Attacker, EDeadReason DeadReason, int DmgId)
	{
		if (DeadReason == EDeadReason.PlayerTrans)
		{
			return;
		}
		bool flag = DeadReason != EDeadReason.OnlyDestroyUnit;
		SummonManagerData.GetSummonInstancesBySummoner(GuidData.GetFinalGuid(), out var OutSummonInstances);
		foreach (FSummonInstance item in OutSummonInstances)
		{
			if (!flag || item.IsDestroyWhenSummonerDead)
			{
				item.TriggerAllServantLifeOver();
			}
		}
	}

	private void OnSummonUseSkill(int SkillID)
	{
		SummonManagerData.GetSummonInstancesBySummoner(GuidData.GetFinalGuid(), out var OutSummonInstances);
		foreach (FSummonInstance item in OutSummonInstances)
		{
			foreach (FServantInstanceBase servantInstance in item.ServantInstances)
			{
				servantInstance.CatSkill(SkillID);
			}
		}
	}

	private void TriggerSummonCopySkill(List<FVector> TargetPosition)
	{
		if (TargetPosition.Count == 0)
		{
			return;
		}
		ACharacter aCharacter = GetOwner() as ACharacter;
		if (BGW_LogUtil.LogIfNull(aCharacter, "Cast ACharacter Failed"))
		{
			return;
		}
		UAnimMontage uAnimMontage = null;
		FUStSummonCopySkillDesc summonCopySkillDesc = BGW_GameDB.GetSummonCopySkillDesc(SkillInstsData.CurrentCastingSkillID);
		if (summonCopySkillDesc != null)
		{
			uAnimMontage = BGW_PreloadAssetMgr.Get(aCharacter).TryGetCachedResourceObj<UAnimMontage>(summonCopySkillDesc.SummonUnitMontagePath, ELoadResourceType.SyncLoadAndCache);
		}
		if (uAnimMontage == null)
		{
			return;
		}
		AActor lockTargetActor = TargetInfoData.GetTargetInfo().LockTargetActor;
		FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorLocation(lockTargetActor);
		int num = 0;
		SummonManagerData.GetSummonInstancesBySummoner(GuidData.GetFinalGuid(), out var OutSummonInstances);
		foreach (FSummonInstance item in OutSummonInstances)
		{
			if (num >= TargetPosition.Count)
			{
				break;
			}
			FVector fVector2 = TargetPosition[num++];
			FRotator rotation = BGUFuncLibActorTransformCS.BGUGetActorRotation(aCharacter);
			if (lockTargetActor != null)
			{
				rotation.Yaw = (fVector - fVector2).Rotation().Yaw;
			}
			foreach (FServantInstanceBase servantInstance in item.ServantInstances)
			{
				servantInstance.CastCopySkill(uAnimMontage, new FTransform(rotation, fVector2));
			}
		}
	}

	private void OnSummonRecall(AActor SummonActor)
	{
		SummonManagerData.GetSummonInstancesBySummoner(GuidData.GetFinalGuid(), out var OutSummonInstances);
		foreach (FSummonInstance item in OutSummonInstances)
		{
			foreach (FServantInstanceBase servantInstance in item.ServantInstances)
			{
				TWeakObject<BGUCharacterCS> monsterInstancePtr = servantInstance.ServantTamerRef.MonsterInstancePtr;
				if (monsterInstancePtr.IsValid() && monsterInstancePtr.Get() == SummonActor)
				{
					servantInstance.Recall();
					return;
				}
			}
		}
	}

	private void OnResetActorStatusAfterAll(EResetActorReason Reason)
	{
		if (Reason == EResetActorReason.ReturnHome)
		{
			OnDestroyAllSummons();
		}
	}

	private void OnDestroySummonsByID(int SummonID)
	{
		SummonManagerData.GetSummonInstancesBySummoner(GuidData.GetFinalGuid(), out var OutSummonInstances);
		foreach (FSummonInstance item in OutSummonInstances)
		{
			if (item.SummonReq.SummonID != SummonID)
			{
				continue;
			}
			foreach (FServantInstanceBase servantInstance in item.ServantInstances)
			{
				servantInstance.Destroy();
			}
		}
	}

	private void OnAddAllSummonLifeTime(float IncreaseLifeTime, List<int> ResIDs = null)
	{
		SummonManagerData.GetSummonInstancesBySummoner(GuidData.GetFinalGuid(), out var OutSummonInstances);
		foreach (FSummonInstance item in OutSummonInstances)
		{
			_ = item.SummonReq;
			foreach (FServantInstanceBase servantInstance in item.ServantInstances)
			{
				if (ResIDs == null || ResIDs.Contains(servantInstance.ServantResId))
				{
					servantInstance.AddLifeTime(IncreaseLifeTime);
				}
			}
		}
	}

	private void OnCopySkillEQSFinish(List<FVector> Result, List<float> Scores, FGSEQSExParam ExParam, int QueryID)
	{
		if (ExParam.RunEQSObjReason == EBGURunEQSObjReason.Summon)
		{
			TriggerSummonCopySkill(Result);
		}
	}

	private void OnUnitCastSkillSuccess(int MappingSkillID, int OriSkillID, ECastSkillSourceType SourceType)
	{
		if (BuffData.HasBuff(279) && BGW_GameDB.GetSummonCopySkillDesc(MappingSkillID) != null)
		{
			UEnvQuery uEnvQuery = PreloadAssetMgr.TryGetCachedResourceObj<UEnvQuery>("EnvQuery'/Game/00Main/Design/AI/BTs/Player/SummonMokey_FS/EQ_SummonMonkey_FS_Copy_Spawn.EQ_SummonMonkey_FS_Copy_Spawn'", ELoadResourceType.SyncLoadAndCache);
			if (uEnvQuery != null)
			{
				base.BGSEventCollection.Evt_BGS_EQSObjRun.Invoke(uEnvQuery, GetOwner(), EBGURunEQSObjReason.Summon, default(FGSEQSExParam), OnCopySkillEQSFinish);
			}
		}
	}

	private void RequestSummon(int SummonID, int SummonPointIndex, AActor EffectCaster = null, in FEffectInstReq EffectInstReq = default(FEffectInstReq), bool TeleportSelf = false, AActor BuffOwner = null)
	{
		if (Owner.GetLocalRole() != ENetRole.ROLE_SimulatedProxy)
		{
			FSummonReq inSummonReq = new FSummonReq
			{
				SummonType = ESummonType.Normal,
				SummonGuid = GameplayTagExtension.ConvertToCalliopeGuid(Guid.NewGuid()),
				SummonID = SummonID,
				SpawnConfigWrap = FSummonSpawnConfigWrap.WrapSpawnConfig_BySummonCommDesc(SummonID, Owner),
				SummonCount = SummonPointIndex,
				Summoner = Owner,
				bTeleportSelf = TeleportSelf,
				EffectCaster = EffectCaster,
				BuffOwner = BuffOwner,
				HitLocation = EffectInstReq.HitLocation
			};
			BPS_EventCollectionCS.GetLocal(Owner).Evt_RequestSummon.Invoke(inSummonReq);
		}
	}

	private void RequestPhantomRushSummon(int SummonID, FContinueBehaviorInfo CBI)
	{
		if (Owner.GetLocalRole() != ENetRole.ROLE_SimulatedProxy)
		{
			FSummonReq inSummonReq = new FSummonReq
			{
				SummonType = ESummonType.PhantomRush,
				SummonID = SummonID,
				SpawnConfigWrap = FSummonSpawnConfigWrap.WrapSpawnConfig_BySummonCommDesc(SummonID, Owner),
				Summoner = Owner,
				ContinueBehaviorInfo = CBI
			};
			BPS_EventCollectionCS.GetLocal(Owner).Evt_RequestSummon.Invoke(inSummonReq);
		}
	}

	private void RequestHatchSummon()
	{
		if (Owner.GetLocalRole() == ENetRole.ROLE_SimulatedProxy)
		{
			return;
		}
		b1.IBUC_HatchData readOnlyData = BGU_DataUtil.GetReadOnlyData<b1.IBUC_HatchData, b1.BUC_HatchData>(Owner);
		if (readOnlyData != null)
		{
			FHatchConfigInfo hatchConfig = readOnlyData.GetHatchConfig();
			if (hatchConfig.IsValid())
			{
				FSummonReq inSummonReq = new FSummonReq
				{
					SummonType = ESummonType.Hatch,
					SummonGuid = GameplayTagExtension.ConvertToCalliopeGuid(Guid.NewGuid()),
					SpawnConfigWrap = FSummonSpawnConfigWrap.WrapSpawnConfig_ByHatchConfig(hatchConfig),
					Summoner = Owner
				};
				BPS_EventCollectionCS.GetLocal(Owner).Evt_RequestSummon.Invoke(inSummonReq);
			}
		}
	}

	private void OnDestroyAllSummons()
	{
		SummonManagerData.GetSummonInstancesBySummoner(GuidData.GetFinalGuid(), out var OutSummonInstances);
		foreach (FSummonInstance item in OutSummonInstances)
		{
			item.TriggerAllServantLifeOver();
		}
	}

	private void OnEnterLevelSequence_DestroyAllSummons()
	{
		SummonManagerData.GetSummonInstancesBySummoner(GuidData.GetFinalGuid(), out var OutSummonInstances);
		foreach (FSummonInstance item in OutSummonInstances)
		{
			if (BGW_GameDB.IsSummonNeedDestroyOnEnterLevelSequence(item.SummonReq.SummonID))
			{
				item.TriggerAllServantLifeOver();
			}
		}
	}
}
