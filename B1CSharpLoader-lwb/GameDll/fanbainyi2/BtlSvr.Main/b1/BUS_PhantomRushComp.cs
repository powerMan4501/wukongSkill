using System;
using System.Collections.Generic;
using System.Text;
using b1.BGW;
using b1.EventDelDefine;
using BtlB1;
using BtlShare;
using UnrealEngine.Engine;

namespace b1;

public class BUS_PhantomRushComp : UActorCompBaseCS
{
	private static long PHANTOM_RUSH_CAST_BLACK_FLAG = 69670L;

	public static int PhantomRushDefaultConfigID = 10001;

	private BUC_PhantomRushData PhantomRushData;

	private IBUC_SimpleStateData SimpleStateData;

	private IBUC_UnitStateData UnitStateData;

	private IBUC_SkillInstsData SkillInstsData;

	private IBUC_AttrContainer AttrContainer;

	public override void OnAttach()
	{
		PhantomRushData = RequireWritableData<BUC_PhantomRushData>();
		SimpleStateData = RequireReadOnlyData<IBUC_SimpleStateData, BUC_SimpleStateData>();
		UnitStateData = RequireReadOnlyData<IBUC_UnitStateData, BUC_UnitStateData>();
		SkillInstsData = RequireReadOnlyData<IBUC_SkillInstsData, BUC_SkillInstsData>();
		AttrContainer = RequireReadOnlyData<IBUC_AttrContainer, BUC_AttrContainer>();
		if (base.BUSEventCollection != null)
		{
			base.BUSEventCollection.Evt_TriggerPhantomRush += new Del_InputPhantomRush(OnTriggerPhantomRush);
			base.BUSEventCollection.Evt_UnitCastSkillSuccess += new Del_UnitCastSkillSuccess(OnUnitCastSkillSuccess);
			base.BUSEventCollection.Evt_SetPhantomRushConfigID += new Del_Void_Int(OnSetPhantomRushConfigID);
			base.BUSEventCollection.Evt_RelievePhantomRush += new Del_Void(OnRelievePhantomRush);
			base.BUSEventCollection.Evt_UnitTriggerDead += new Del_UnitTriggerDead(OnUnitTriggerDead);
			base.BUSEventCollection.Evt_SetPhantomRushImperceptible += new Del_Void_Bool(OnSetPhantomRushImperceptible);
		}
	}

	public override void PreBeginPlay()
	{
		OnSetPhantomRushConfigID(PhantomRushDefaultConfigID);
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		AActor owner = GetOwner();
		if (!(owner == null))
		{
			TickForInvisibleSimpleState(owner, DeltaTime);
		}
	}

	private void TickForInvisibleSimpleState(AActor OwnerActor, float DeltaTime)
	{
		if (!SimpleStateData.HasSimpleState(EBGUSimpleState.PhantomRush))
		{
			return;
		}
		PhantomRushData.PhantomRushTimer -= DeltaTime;
		if (PhantomRushData.PhantomRushTimer <= 0f)
		{
			ExitPhantomRush(OwnerActor);
		}
		else if (AttrContainer.GetFloatValue(EBGUAttrFloat.Mp) <= 0f)
		{
			PhantomRushData.PhantomRushNoMagicProtectTimer -= DeltaTime;
			if (PhantomRushData.PhantomRushNoMagicProtectTimer <= 0f)
			{
				ExitPhantomRush(OwnerActor);
			}
		}
	}

	private void OnTriggerPhantomRush(ESkillDirection PhantomRushDir)
	{
		AActor owner = GetOwner();
		if (owner == null)
		{
			return;
		}
		ACharacter aCharacter = owner as ACharacter;
		if (aCharacter == null || SimpleStateData.HasSimpleState(EBGUSimpleState.PhantomRush))
		{
			return;
		}
		FUStPhantomRushSkillConfigDesc phantomRushSkillConfigDesc = BGW_GameDB.GetPhantomRushSkillConfigDesc(GetActualUseConfigID(), Owner);
		if (phantomRushSkillConfigDesc == null)
		{
			return;
		}
		long skillCanCastResults = BGU_CommonUtil.GetSkillCanCastResults(owner, phantomRushSkillConfigDesc.PhantomRushSkillID, phantomRushSkillConfigDesc.PhantomRushSkillID);
		if (DebugConfig.EnablePrintJXSQCheckerResult)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("JXSQ释放检查，Checker结果有：");
			foreach (ECanCastSkillResult value in Enum.GetValues(typeof(ECanCastSkillResult)))
			{
				if (((ulong)skillCanCastResults & (ulong)value) == (ulong)value)
				{
					stringBuilder.Append($"{value}; ");
				}
			}
		}
		if ((skillCanCastResults & 1) != 1 && (skillCanCastResults & PHANTOM_RUSH_CAST_BLACK_FLAG) != 0L)
		{
			return;
		}
		PreloadAssetMgr.TryGetCachedResourceObj<BGWDataAsset_PhantomRushRelatedeSkillConfig>(phantomRushSkillConfigDesc.PhantomRushRelatedSkillConfigPath, ELoadResourceType.AsyncLoadAndCache, EAssetPriority.Medium);
		FPoseSnapshot Snapshot = default(FPoseSnapshot);
		aCharacter.Mesh.SnapshotPose(ref Snapshot);
		PhantomRushData.PoseSnapshot = Snapshot;
		UAnimInstance animInstance = aCharacter.Mesh.GetAnimInstance();
		FContinueBehaviorInfo cBI = default(FContinueBehaviorInfo);
		if (animInstance != null)
		{
			UAnimMontage currentActiveMontage = animInstance.GetCurrentActiveMontage();
			if (currentActiveMontage != null)
			{
				if (SimpleStateData.HasSimpleState(EBGUSimpleState.InAnimationSyncing))
				{
					cBI.CBT = EContinueBehaviorType.AnimationSyncing;
					cBI.MontagePos = animInstance.Montage_GetPosition(currentActiveMontage);
					cBI.BeatbackMontage = currentActiveMontage;
				}
				else if (UnitStateData.HasState(EBGUUnitState.Attacking))
				{
					cBI.MontagePos = animInstance.Montage_GetPosition(currentActiveMontage);
					cBI.CBT = EContinueBehaviorType.Skill;
					cBI.SkillID = SkillInstsData.CurrentCastingSkillID;
				}
				else if (UnitStateData.HasState(EBGUUnitState.Beatback))
				{
					cBI.CBT = EContinueBehaviorType.Beatback;
					cBI.MontagePos = animInstance.Montage_GetPosition(currentActiveMontage);
					cBI.BeatbackMontage = currentActiveMontage;
				}
			}
		}
		base.BUSEventCollection.Evt_UnitSetSimpleState.Invoke(EBGUSimpleState.ForceSkill);
		base.BUSEventCollection.Evt_UnitCastSkillTry.Invoke(new FCastSkillInfo(phantomRushSkillConfigDesc.PhantomRushSkillID, ECastSkillSourceType.PhantomRush, _HasSetSkillBaseTarget: false, PhantomRushDir)
		{
			NeedCheckSkillCanCast = true
		});
		base.BUSEventCollection.Evt_UnitSetSimpleState.Invoke(EBGUSimpleState.ForceSkill, IsRemove: true);
		if (SkillInstsData.GetLastSkillCastResult() != ECastSkillResult.CSR_OK)
		{
			return;
		}
		base.BUSEventCollection.Evt_ClearAbnormalState.Invoke(new HashSet<EAbnormalStateType>
		{
			EAbnormalStateType.Abnormal_Burn,
			EAbnormalStateType.Abnormal_Freeze,
			EAbnormalStateType.Abnormal_Poison,
			EAbnormalStateType.Abnormal_Thunder
		});
		int phantomRushSummonID = phantomRushSkillConfigDesc.PhantomRushSummonID;
		base.BUSEventCollection.Evt_SummonSkillCastByPhantomRush.Invoke(phantomRushSummonID, cBI);
		base.BUSEventCollection.Evt_UnitSetSimpleState.Invoke(EBGUSimpleState.PhantomRush);
		foreach (int phantomRushBeginAddBuffID in phantomRushSkillConfigDesc.PhantomRushBeginAddBuffIDList)
		{
			base.BUSEventCollection.Evt_BuffAdd.Invoke(phantomRushBeginAddBuffID, Owner, Owner, -1f, EBuffSourceType.PhantomRush);
		}
		PhantomRushData.PhantomRushTimer = phantomRushSkillConfigDesc.PhantomRushDuration;
		PhantomRushData.PhantomRushNoMagicProtectTimer = 1f;
		base.BGSEventCollection?.Evt_BGS_ClearAttachedProjectiles_OnUnit.Invoke(Owner);
	}

	private void OnUnitCastSkillSuccess(int MappingSkillID, int OriSkillID, ECastSkillSourceType SourceType)
	{
		AActor owner = GetOwner();
		if (owner == null || !SimpleStateData.HasSimpleState(EBGUSimpleState.PhantomRush))
		{
			return;
		}
		FUStPhantomRushSkillConfigDesc phantomRushSkillConfigDesc = BGW_GameDB.GetPhantomRushSkillConfigDesc(GetActualUseConfigID(), Owner);
		if (phantomRushSkillConfigDesc != null)
		{
			BGWDataAsset_PhantomRushRelatedeSkillConfig bGWDataAsset_PhantomRushRelatedeSkillConfig = PreloadAssetMgr.TryGetCachedResourceObj<BGWDataAsset_PhantomRushRelatedeSkillConfig>(phantomRushSkillConfigDesc.PhantomRushRelatedSkillConfigPath, ELoadResourceType.SyncLoadAndCache);
			if (!(bGWDataAsset_PhantomRushRelatedeSkillConfig == null) && bGWDataAsset_PhantomRushRelatedeSkillConfig.PhantomRushAtkSkill.Contains(MappingSkillID))
			{
				ExitPhantomRushByAttack(owner);
			}
		}
	}

	private void OnSetPhantomRushConfigID(int ConfigID)
	{
		if (!(GetOwner() == null))
		{
			if (SimpleStateData.HasSimpleState(EBGUSimpleState.PhantomRush))
			{
				PhantomRushData.CacheConfigID = ConfigID;
			}
			else
			{
				PhantomRushData.NowConfigID = ConfigID;
				PhantomRushData.CacheConfigID = -1;
			}
			FUStPhantomRushSkillConfigDesc phantomRushSkillConfigDesc = BGW_GameDB.GetPhantomRushSkillConfigDesc(ConfigID, Owner);
			if (phantomRushSkillConfigDesc != null)
			{
				PreloadAssetMgr.TryGetCachedResourceObj<BGWDataAsset_PhantomRushRelatedeSkillConfig>(phantomRushSkillConfigDesc.PhantomRushRelatedSkillConfigPath, ELoadResourceType.AsyncLoadAndCache, EAssetPriority.Medium);
			}
		}
	}

	private void OnRelievePhantomRush()
	{
		AActor owner = GetOwner();
		if (!(owner == null) && SimpleStateData.HasSimpleState(EBGUSimpleState.PhantomRush))
		{
			ExitPhantomRush(owner);
		}
	}

	private void OnUnitTriggerDead(AActor Attacker, EDeadReason DeadReason, int DmgID)
	{
		OnRelievePhantomRush();
	}

	private void OnSetPhantomRushImperceptible(bool Enable)
	{
		if (Enable)
		{
			if (SimpleStateData.HasSimpleState(EBGUSimpleState.PhantomRush))
			{
				PhantomRushData.Imperceptible = true;
			}
		}
		else
		{
			PhantomRushData.Imperceptible = false;
		}
	}

	private int GetActualUseConfigID()
	{
		if (!SimpleStateData.HasSimpleState(EBGUSimpleState.PhantomRush) && PhantomRushData.CacheConfigID > 0)
		{
			PhantomRushData.NowConfigID = PhantomRushData.CacheConfigID;
			PhantomRushData.CacheConfigID = -1;
		}
		return PhantomRushData.NowConfigID;
	}

	private void ExitPhantomRushByAttack(AActor OwnerActor)
	{
		if (!(OwnerActor == null))
		{
			ExitPhantomRush(OwnerActor);
		}
	}

	private void ExitPhantomRush(AActor OwnerActor)
	{
		if (OwnerActor == null || base.BUSEventCollection == null)
		{
			return;
		}
		FUStPhantomRushSkillConfigDesc phantomRushSkillConfigDesc = BGW_GameDB.GetPhantomRushSkillConfigDesc(GetActualUseConfigID(), Owner);
		if (phantomRushSkillConfigDesc == null)
		{
			return;
		}
		base.BUSEventCollection.Evt_UnitSetSimpleState.Invoke(EBGUSimpleState.PhantomRush, IsRemove: true);
		OnSetPhantomRushImperceptible(Enable: false);
		foreach (int phantomRushBeginAddBuffID in phantomRushSkillConfigDesc.PhantomRushBeginAddBuffIDList)
		{
			base.BUSEventCollection.Evt_BuffRemove.Invoke(phantomRushBeginAddBuffID, EBuffEffectTriggerType.None, 1);
		}
		FEffectInstReq effectInstReq = new FEffectInstReq(null);
		foreach (int phantomRushEndTriggerEffectID in phantomRushSkillConfigDesc.PhantomRushEndTriggerEffectIDList)
		{
			base.BUSEventCollection.Evt_TriggerSkillEffect.Invoke(phantomRushEndTriggerEffectID, effectInstReq);
		}
		OwnerAsCharacterCS.PawnMakeNoise(1f, BGUFuncLibActorTransformCS.BGUGetActorLocation(Owner), bUseNoiseMakerLocation: false, OwnerAsCharacterCS);
	}
}
