using System.Collections.Generic;
using System.Linq;
using b1.BGW;
using b1.EventDelDefine;
using b1.Prediction;
using BtlB1;
using BtlShare;
using Diana.Common;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUS_SkillInstsCompSvr : UActorCompBaseCS
{
	private enum ESkillCastResultCheck : byte
	{
		None,
		Pending,
		Success,
		Fail
	}

	private BUC_ActionRequestData ActionRequestData;

	private BUC_SkillInstsData SkillInstsData;

	private BUC_AnimNotifyAndStateData AnimNotifyAndStateData;

	private BUC_ChargeSkillData ChargeSkillData;

	private const int SkillSuperArmorUniqueID = -999;

	private List<int> CachedOpBuffList = new List<int>();

	private static readonly string CAST_NEW_SKILL = "Cast new skill";

	private static readonly string NO_ATTACK_STATE = "UpdateForEndStageEnd NoAttackState";

	private static readonly string INVALID_CHARGESKILL_CASTING = "当前放的技能不是蓄力技能 & 当前还在【正在释放蓄力技能】标识";

	private static readonly string END_SKILL_BLENDOUT = "OnPlayMontageCallback EndSkill OnBlendOut";

	private IBUC_ActorBasicData BasicData;

	private IBUC_SceneItemData SceneItemData;

	private IBUC_UnitStateData UnitStateData;

	private IBUC_SkillMappingData SkillMappingData;

	private IBUC_TickRateData TickRateData;

	private IBUC_SimpleStateData SimpleStateData;

	private IBUC_AttrContainer AttrContainer;

	private IBUC_SkillInputAssistData SkillInputAssistData;

	private IBUC_AIData AIData;

	private IBUC_TargetInfoData TargetInfoData;

	private IBUC_GuidData GuidData;

	private IBGC_UnrealGameplayData UnrealGameplayData;

	private BPC_TransData _TransData;

	private ESkillCastResultCheck SkillCastResultCheck;

	private BPC_TransData TransData => _TransData ?? (_TransData = RequireWritableLocalPlayerStateData<BPC_TransData>());

	public override void OnAttach()
	{
		ActionRequestData = RequireWritableData<BUC_ActionRequestData>();
		AnimNotifyAndStateData = RequireWritableData<BUC_AnimNotifyAndStateData>();
		SkillInstsData = RequireWritableData<BUC_SkillInstsData>();
		ChargeSkillData = RequireWritableData<BUC_ChargeSkillData>();
		BasicData = RequireReadOnlyData<IBUC_ActorBasicData, BUC_ActorBasicData>();
		SceneItemData = RequireReadOnlyData<IBUC_SceneItemData, BUC_SceneItemData>();
		UnitStateData = RequireReadOnlyData<IBUC_UnitStateData, BUC_UnitStateData>();
		SkillMappingData = RequireReadOnlyData<IBUC_SkillMappingData, BUC_SkillMappingData>();
		TickRateData = RequireReadOnlyData<IBUC_TickRateData, BUC_TickRateData>();
		SimpleStateData = RequireReadOnlyData<IBUC_SimpleStateData, BUC_SimpleStateData>();
		AttrContainer = RequireReadOnlyData<IBUC_AttrContainer, BUC_AttrContainer>();
		SkillInputAssistData = RequireReadOnlyData<IBUC_SkillInputAssistData, BUC_SkillInputAssistData>();
		AIData = RequireReadOnlyData<IBUC_AIData, BUC_AIData>();
		TargetInfoData = RequireReadOnlyData<IBUC_TargetInfoData, BUC_TargetInfoData>();
		GuidData = RequireReadOnlyData<IBUC_GuidData, BUC_GuidData>();
		UnrealGameplayData = RequireReadOnlyGameStateData<IBGC_UnrealGameplayData, BGC_UnrealGameplayData>();
		base.BUSEventCollection.Evt_UnitCastSkillTryCMultiCast.Predict += new GSDel_UnitCastSkillTry_IPK_Del.Del_Predict(OnUnitCastSkillTry_Predict);
		base.BUSEventCollection.Evt_UnitCastSkillTryCMultiCast.Cue += new GSDel_UnitCastSkillTry_IPK_Del.Del_Predict(OnUnitCastSkillTry);
		base.BUSEventCollection.Evt_UnitCastSkillTry += new Del_UnitCastSkillTry(OnUnitCastSkillTry);
		base.BUSEventCollection.Evt_BeginPhaseTransitionBySkill += new Del_SkillID(OnBeginPhaseTransitionBySkill);
		base.BUSEventCollection.Evt_UnitTryBreakSkill += new Del_UnitTryBreakSkill(OnUnitTryBreakSkill);
		base.BUSEventCollection.Evt_ResetSkillCD += new Del_Void(OnResetSkillCD);
		base.BUSEventCollection.Evt_StartSkillCD += new Del_StartSkillCD(OnStartSkillCooldown);
		base.BUSEventCollection.Evt_ModifyCD += new Del_ModifyCD(OnModifyCD);
		base.BUSEventCollection.Evt_SetNewTurnSkillID += new Del_SetNewTurnSkillID(OnSetNewTurnSkillID);
		base.BUSEventCollection.Evt_SetNewMoveSkillID += new Del_SetNewMoveSkillID(OnSetNewMoveSkillID);
		base.BUSEventCollection.Evt_AttackFeedback += new Del_AttackFeedback(OnAttackFeedback);
		base.BUSEventCollection.Evt_SetSpAtkReboundingAM += new Del_SetSpAtkReboundingAM(OnSetSpAtkReboundingAM);
		base.BUSEventCollection.Evt_RemoveSpAtkReboundingAM += new Del_RemoveSpAtkReboundingAM(OnRemoveSpAtkReboundingAM);
		base.BUSEventCollection.Evt_SetLastSkillKeyActionMapping += new Del_Void_String(OnSetLastSkillKeyActionMapping);
		base.BUSEventCollection.Evt_SetMagicWindowSkillList += new Del_Void_IntListIntList(OnSetMagicWindowSkillList);
		base.BUSEventCollection.Evt_NotifyBattleStateChange += new Del_NotifyBattleStateChange(OnNotifyBattleStateChange);
		base.BUSEventCollection.Evt_OnSkillCostDmg += new Del_OnSkillCostDmg(OnSkillCostDmg);
		base.BUSEventCollection.Evt_OnSkillValidAttackEnded += new Del_Void(OnSkillValidAttackEnded);
		base.BUSEventCollection.Evt_ResetActorStatusPre += new Del_Void_ResetActorReason(OnResetActorStatusPre);
		base.BUSEventCollection.Evt_ResetActorStatusAfterAll += new Del_Void_ResetActorReason(OnResetActorStatusAfterAll);
		base.BUSEventCollection.Evt_ReCoverLastSkillCastTime += new Del_Void_IntFloat(OnReCoverLastSkillCastTime);
		base.BUSEventCollection.Evt_PlayMontageCallback += new Del_PlayMontageCallback(OnPlayMontageCallback);
		base.BUSEventCollection.Evt_UnitCastSkillFail += new Del_UnitCastSkillFail(OnUnitSkillFail);
		base.BUSEventCollection.Evt_TriggerNextChargeSkillStage += new Del_Void_Bool(TriggerNextChargeSkillStage);
		base.BUSEventCollection.Evt_TriggerCancelChargeSkill += new Del_Void(OnTriggerCancelChargeSkill);
		base.BUSEventCollection.Evt_OnIncreaseChargeLevel += new Del_Void_Int(OnIncreaseChargeLevel);
		base.BUSEventCollection.Evt_OnDecreaseChargeLevel += new Del_Void_Int(OnDecreaseChargeLevel);
		base.BUSEventCollection.Evt_OnLanded += new Del_Void(OnLanded);
		base.BUSEventCollection.Evt_OnJumpOff += new Del_Void(OnJumpOff);
	}

	public override void PreBeginPlay()
	{
		ResetChargeSkillData();
	}

	public override void OnBeginPlay()
	{
		if (BGUFuncLibActorTransformCS.BGUGetActorHasAuthority(GetOwner()) || TransData == null)
		{
			return;
		}
		FUStUnitTransCommDesc unitTransCommDesc = BGW_GameDB.GetUnitTransCommDesc(BGU_DataUtil.GetActorResID(GetOwner()));
		FUStUnitTransCommDesc unitTransCommDesc2 = BGW_GameDB.GetUnitTransCommDesc(TransData.LastControlUnitResID);
		TransData.LastControlUnitResID = BGU_DataUtil.GetActorResID(GetOwner());
		if (unitTransCommDesc != null && unitTransCommDesc2 != null)
		{
			int num = ((unitTransCommDesc.UnitBornSkillID > 0) ? unitTransCommDesc.UnitBornSkillID : unitTransCommDesc2.NewUnitBornSkillID);
			if (num > 0)
			{
				OnUnitCastSkillTry(new FCastSkillInfo(num, ECastSkillSourceType.BornSkill));
			}
		}
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		TickForCastingSkill();
		TickForSkillCD(DeltaTime);
		UpdateForCancelChargeSkill();
		UpdateForStaminaNotEnough();
		UpdateForChargeSkillOverTime(DeltaTime);
		UpdateForBeginStageEnd(DeltaTime);
		UpdateForChargeSkillBuff(DeltaTime);
		UpdateForChargeSkillSuperArmor(DeltaTime);
		UpdateIntoNextChargeLevelTimer(DeltaTime);
		ChargeLevelLoopBuffTick();
		UpdateForEndStageEnd(DeltaTime);
	}

	private void UpdateForCancelChargeSkill()
	{
		if (ChargeSkillData.IsCastingChargeSkill && ChargeSkillData.NeedCancel && ChargeSkillData.ChargeSkillStage == EChargeSkillStage.Loop)
		{
			OnTriggerCancelChargeSkill();
		}
	}

	private void UpdateForStaminaNotEnough()
	{
		if (ChargeSkillData.IsCastingChargeSkill && ChargeSkillData.ChargeSkillStage != EChargeSkillStage.End && AttrContainer.GetFloatValue(EBGUAttrFloat.StaminaMax) != 0f && AttrContainer.GetFloatValue(EBGUAttrFloat.Stamina) <= 0f)
		{
			if (ChargeSkillData.ChargeSkillStage == EChargeSkillStage.Loop)
			{
				TriggerNextChargeSkillStage_StaminaOver();
			}
			else if (ChargeSkillData.ChargeSkillStage == EChargeSkillStage.Begin)
			{
				ChargeSkillData.NeedTriggerNextStage = true;
			}
		}
	}

	private void UpdateForChargeSkillOverTime(float DeltaTime)
	{
		if (!ChargeSkillData.IsCastingChargeSkill || ChargeSkillData.ChargeSkillStage == EChargeSkillStage.End || SimpleStateData.HasSimpleState(EBGUSimpleState.Immobilizing) || SimpleStateData.HasSimpleState(EBGUSimpleState.Frozen))
		{
			return;
		}
		if (ChargeSkillData.NeedTriggerNextStage)
		{
			if (UnitStateData.HasState(EBGUUnitState.InComboWindow) || ChargeSkillData.ChargeSkillStage == EChargeSkillStage.Loop)
			{
				TriggerNextChargeSkillStage(IsOverTime: true);
			}
		}
		else
		{
			if (!(ChargeSkillData.ChargeTimer >= 0f))
			{
				return;
			}
			ChargeSkillData.ChargeTimer -= DeltaTime;
			if (!(ChargeSkillData.ChargeTimer <= 0f))
			{
				return;
			}
			if (ChargeSkillData.ChargeSkillStage == EChargeSkillStage.Loop)
			{
				TriggerNextChargeSkillStage(IsOverTime: true);
			}
			else if (ChargeSkillData.ChargeSkillStage == EChargeSkillStage.Begin)
			{
				if (UnitStateData.HasState(EBGUUnitState.InComboWindow))
				{
					TriggerNextChargeSkillStage(IsOverTime: true);
				}
				else
				{
					ChargeSkillData.NeedTriggerNextStage = true;
				}
			}
		}
	}

	private void UpdateForBeginStageEnd(float DeltaTime)
	{
		if (ChargeSkillData.IsCastingChargeSkill && ChargeSkillData.ChargeSkillStage == EChargeSkillStage.Begin && (!UnitStateData.HasState(EBGUUnitState.Attacking) || UnitStateData.HasState(EBGUUnitState.InComboWindow)))
		{
			BeginStageSwitchToLoop();
		}
	}

	private void UpdateForChargeSkillBuff(float DeltaTime)
	{
		AActor owner = GetOwner();
		if (owner == null || !ChargeSkillData.IsCastingChargeSkill || ChargeSkillData.BuffInfoList == null || ChargeSkillData.BuffInfoList.Count <= 0)
		{
			return;
		}
		if (ChargeSkillData.ChargeSkillStage == EChargeSkillStage.Begin)
		{
			CachedOpBuffList.Clear();
			for (int i = 0; i < ChargeSkillData.BuffInfoList.Count; i++)
			{
				ChargeSkillBuffInfo chargeSkillBuffInfo = ChargeSkillData.BuffInfoList[i];
				if (!chargeSkillBuffInfo.HasTrigger && chargeSkillBuffInfo.DelayTriggerBuffTimer >= 0f)
				{
					chargeSkillBuffInfo.DelayTriggerBuffTimer -= DeltaTime;
					if (chargeSkillBuffInfo.DelayTriggerBuffTimer <= 0f)
					{
						chargeSkillBuffInfo.HasTrigger = true;
						CachedOpBuffList.Add(chargeSkillBuffInfo.BuffID);
					}
				}
			}
			for (int j = 0; j < CachedOpBuffList.Count; j++)
			{
				base.BUSEventCollection?.Evt_BuffAdd.Invoke(CachedOpBuffList[j], owner, owner, -1f, EBuffSourceType.ChargeSkill);
			}
		}
		else if (ChargeSkillData.ChargeSkillStage == EChargeSkillStage.Loop)
		{
			CachedOpBuffList.Clear();
			for (int k = 0; k < ChargeSkillData.BuffInfoList.Count; k++)
			{
				ChargeSkillBuffInfo chargeSkillBuffInfo2 = ChargeSkillData.BuffInfoList[k];
				if (!chargeSkillBuffInfo2.HasTrigger)
				{
					chargeSkillBuffInfo2.HasTrigger = true;
					CachedOpBuffList.Add(chargeSkillBuffInfo2.BuffID);
				}
			}
			for (int l = 0; l < CachedOpBuffList.Count; l++)
			{
				base.BUSEventCollection?.Evt_BuffAdd.Invoke(CachedOpBuffList[l], owner, owner, -1f, EBuffSourceType.ChargeSkill);
			}
		}
		else
		{
			if (ChargeSkillData.ChargeSkillStage != EChargeSkillStage.End)
			{
				return;
			}
			CachedOpBuffList.Clear();
			for (int m = 0; m < ChargeSkillData.BuffInfoList.Count; m++)
			{
				ChargeSkillBuffInfo chargeSkillBuffInfo3 = ChargeSkillData.BuffInfoList[m];
				if (chargeSkillBuffInfo3.HasTrigger && chargeSkillBuffInfo3.DelayRemoveBuffTimer >= 0f)
				{
					chargeSkillBuffInfo3.DelayRemoveBuffTimer -= DeltaTime;
					if (chargeSkillBuffInfo3.DelayRemoveBuffTimer <= 0f)
					{
						chargeSkillBuffInfo3.HasTrigger = false;
						CachedOpBuffList.Add(chargeSkillBuffInfo3.BuffID);
					}
				}
			}
			for (int n = 0; n < CachedOpBuffList.Count; n++)
			{
				base.BUSEventCollection?.Evt_BuffRemove.Invoke(CachedOpBuffList[n], EBuffEffectTriggerType.None, 1);
			}
		}
	}

	private void UpdateForChargeSkillSuperArmor(float DeltaTime)
	{
		AActor owner = GetOwner();
		if (owner == null || !ChargeSkillData.IsCastingChargeSkill)
		{
			return;
		}
		ChargeSkillSuperArmorInfo superArmorInfo = ChargeSkillData.SuperArmorInfo;
		if (superArmorInfo == null)
		{
			return;
		}
		if (ChargeSkillData.ChargeSkillStage == EChargeSkillStage.Begin)
		{
			if (!superArmorInfo.HasSuperArmor || superArmorInfo.HasTrigger)
			{
				return;
			}
			superArmorInfo.DelayTriggerSuperArmorTimer -= DeltaTime;
			if (!(superArmorInfo.DelayTriggerSuperArmorTimer <= 0f))
			{
				return;
			}
			superArmorInfo.HasTrigger = true;
			if (!(base.BUSEventCollection != null))
			{
				return;
			}
			FUStUnitCommDesc unitCommDesc = BGW_GameDB.GetUnitCommDesc(BGU_DataUtil.GetActorResID(owner));
			if (unitCommDesc != null && superArmorInfo.SSABreakAssignedAnim != null)
			{
				float setArmorValue = unitCommDesc.MaxSkillSuperArmorValue;
				if (superArmorInfo.SkillSuperArmorValue >= 0f)
				{
					setArmorValue = superArmorInfo.SkillSuperArmorValue;
				}
				UObject uObject = BGW_PreloadAssetMgr.Get(owner).TryGetCachedResourceObj<UObject>(superArmorInfo.SSABreakAssignedAnim, ELoadResourceType.SyncLoadAndCache);
				if (uObject != null)
				{
					base.BUSEventCollection.Evt_TriggerSkillSuperArmor.Invoke(uObject as UAnimMontage, setArmorValue, -999);
				}
			}
		}
		else if (ChargeSkillData.ChargeSkillStage == EChargeSkillStage.Loop)
		{
			if (!superArmorInfo.HasSuperArmor || superArmorInfo.HasTrigger)
			{
				return;
			}
			superArmorInfo.HasTrigger = true;
			if (!(base.BUSEventCollection != null))
			{
				return;
			}
			FUStUnitCommDesc unitCommDesc2 = BGW_GameDB.GetUnitCommDesc(BGU_DataUtil.GetActorResID(owner));
			if (unitCommDesc2 != null && superArmorInfo.SSABreakAssignedAnim != null)
			{
				float setArmorValue2 = unitCommDesc2.MaxSkillSuperArmorValue;
				if (superArmorInfo.SkillSuperArmorValue >= 0f)
				{
					setArmorValue2 = superArmorInfo.SkillSuperArmorValue;
				}
				UObject uObject2 = BGW_PreloadAssetMgr.Get(owner).TryGetCachedResourceObj<UObject>(superArmorInfo.SSABreakAssignedAnim, ELoadResourceType.SyncLoadAndCache);
				if (uObject2 != null)
				{
					base.BUSEventCollection.Evt_TriggerSkillSuperArmor.Invoke(uObject2 as UAnimMontage, setArmorValue2, -999);
				}
			}
		}
		else
		{
			if (ChargeSkillData.ChargeSkillStage != EChargeSkillStage.End || !superArmorInfo.HasSuperArmor || !superArmorInfo.HasTrigger)
			{
				return;
			}
			superArmorInfo.DelayRemoveSuperArmorTimer -= DeltaTime;
			if (superArmorInfo.DelayRemoveSuperArmorTimer <= 0f)
			{
				superArmorInfo.HasTrigger = false;
				if (owner != null && owner as BGUCharacterCS != null && base.BUSEventCollection != null)
				{
					base.BUSEventCollection.Evt_RemoveSkillSuperArmor.Invoke(-999);
				}
			}
		}
	}

	private void UpdateIntoNextChargeLevelTimer(float DeltaTime)
	{
		if (!(ChargeSkillData.IntoNextCLevelRemaining < 0f) && ChargeSkillData.ChargeSkillStage == EChargeSkillStage.Loop)
		{
			ChargeSkillData.IntoNextCLevelRemaining -= DeltaTime;
			if (ChargeSkillData.IntoNextCLevelRemaining <= 0f)
			{
				OnIncreaseChargeLevel();
			}
		}
	}

	private void ChargeLevelLoopBuffTick()
	{
		if (ChargeSkillData.CurChargeLevelConfig.InfoList == null)
		{
			return;
		}
		if (ChargeSkillData.ChargeSkillStage != EChargeSkillStage.Loop)
		{
			if (ChargeSkillData.HasChargeLevelBuffWithinLoop)
			{
				HandleChargeLevelWithinLoop(IsAdd: false);
				ChargeSkillData.HasChargeLevelBuffWithinLoop = false;
			}
		}
		else if (ChargeSkillData.NeedAddChargeLevelBuffWithinLoop)
		{
			HandleChargeLevelWithinLoop(IsAdd: true);
		}
	}

	private void UpdateForEndStageEnd(float DeltaTime)
	{
		if (ChargeSkillData.IsCastingChargeSkill && ChargeSkillData.ChargeSkillStage == EChargeSkillStage.End && !UnitStateData.HasState(EBGUUnitState.Attacking))
		{
			ResetChargeSkillInfo(NO_ATTACK_STATE);
		}
	}

	private void ResetChargeSkillData()
	{
		ChargeSkillData.ChargeTimer = -1f;
		ChargeSkillData.CurrentBeginChargeSkillID = 0;
		ChargeSkillData.CurrentBeginChargeSkillOriginSkillID = 0;
		ChargeSkillData.CurrentChargeSkillID = 0;
		ChargeSkillData.ChargeSkillStage = EChargeSkillStage.None;
		ChargeSkillData.IsCastingChargeSkill = false;
		ChargeSkillData.NeedTriggerNextStage = false;
		ChargeSkillData.NeedCancel = false;
		ChargeSkillData.BeAttackedTriggerForceAttackCnt = 0;
	}

	private void OnChargeSkillSuccess(int SkillID, int OriginSkillID)
	{
		SetChargeSkillInfo(SkillID, OriginSkillID);
		SetChargeLevelInfo(SkillID);
		FUStChargeSkillSDesc chargeSkillSDesc = BGW_GameDB.GetChargeSkillSDesc(SkillID, GetOwner());
		if (chargeSkillSDesc != null && chargeSkillSDesc.AutoEndWhenLockTarget == EGSYesNo.Yes && SkillInputAssistData.TargetInfoBeforeInputSkill.LockTargetActor != null && SkillInputAssistData.TargetInfoBeforeInputSkill.LockTargetWayType == ELockTargetWayType.Manual)
		{
			base.BUSEventCollection?.Evt_TriggerInputSkillRelease.Invoke(SkillID);
		}
		if (SkillID == ChargeSkillData.CurrentChargeSkillID && ChargeSkillData.ChargeSkillStage == EChargeSkillStage.End)
		{
			base.BUSEventCollection?.Evt_ForceCancelSkillSelect.Invoke(bCancelBySkillBreak: true);
		}
	}

	private void ResetCanForceAttackInChargeSkillState()
	{
		if (SimpleStateData.GetSimpleStateLayer(EBGUSimpleState.CanForceAttackInChargeSkill, out var LayerNum))
		{
			for (int i = 1; i <= LayerNum; i++)
			{
				base.BUSEventCollection?.Evt_UnitSetSimpleState.Invoke(EBGUSimpleState.CanForceAttackInChargeSkill, IsRemove: true);
			}
		}
	}

	private void ResetChargeSkillInfo(string ResetReason, bool bNeedTriggerResetCanForceAttackInChargeSkillState = true)
	{
		AActor owner = GetOwner();
		if (owner == null || !ChargeSkillData.IsCastingChargeSkill)
		{
			return;
		}
		if (DebugConfig.IsOpenBattleInfoTool)
		{
			BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.ChargeSkill, "<character>" + Owner.GetName() + "</><action>蓄力技中，触发重置蓄力技，重置原因是：</><effectnum>" + ResetReason + "</>");
		}
		if (ChargeSkillData.BuffInfoList != null && ChargeSkillData.BuffInfoList.Count > 0)
		{
			ChargeSkillData.BuffInfoList.ForEach(delegate(ChargeSkillBuffInfo BuffInfo)
			{
				if (BuffInfo.HasTrigger)
				{
					BuffInfo.HasTrigger = false;
					base.BUSEventCollection?.Evt_BuffRemove.Invoke(BuffInfo.BuffID, EBuffEffectTriggerType.None, 1);
				}
			});
			ChargeSkillData.BuffInfoList.Clear();
		}
		if (ChargeSkillData.SuperArmorInfo != null && ChargeSkillData.SuperArmorInfo.HasTrigger)
		{
			ChargeSkillData.SuperArmorInfo.HasSuperArmor = false;
			ChargeSkillData.SuperArmorInfo.HasTrigger = false;
			if (owner as BGUCharacterCS != null && base.BUSEventCollection != null)
			{
				base.BUSEventCollection.Evt_RemoveSkillSuperArmor.Invoke(-999);
			}
		}
		if (bNeedTriggerResetCanForceAttackInChargeSkillState)
		{
			ResetCanForceAttackInChargeSkillState();
		}
		base.BUSEventCollection?.Evt_OnRemoveIronBodyStartBuff.Invoke();
		ResetChargeSkillData();
		ClearChargeLevelInfo();
	}

	private void TriggerNextChargeSkillStage_StaminaOver()
	{
		AActor owner = GetOwner();
		if (owner == null || owner.IsPendingKill)
		{
			return;
		}
		FUStChargeSkillSDesc chargeSkillSDesc = BGW_GameDB.GetChargeSkillSDesc(ChargeSkillData.CurrentChargeSkillID, owner);
		if (chargeSkillSDesc != null)
		{
			if (AIData.IsAI || chargeSkillSDesc.TriggerNextStageUseFSM != EGSYesNo.Yes)
			{
				return;
			}
			if (base.BUSEventCollection != null)
			{
				base.BUSEventCollection.Evt_TriggerChargeSkillNextStageEvent.Invoke(EChargeSkillEndEventType.StaminaOver);
			}
		}
		ChargeSkillData.NeedTriggerNextStage = false;
	}

	private void BeginStageSwitchToLoop()
	{
		AActor owner = GetOwner();
		if (owner == null || owner.IsPendingKill)
		{
			return;
		}
		bool flag = false;
		FUStChargeSkillSDesc chargeSkillSDesc = BGW_GameDB.GetChargeSkillSDesc(ChargeSkillData.CurrentChargeSkillID, owner);
		if (chargeSkillSDesc != null)
		{
			string loopTemplatePath = chargeSkillSDesc.LoopTemplatePath;
			UAnimMontage uAnimMontage = BGW_PreloadAssetMgr.Get(owner).TryGetCachedResourceObj<UAnimMontage>(loopTemplatePath, ELoadResourceType.SyncLoadAndCache);
			if (uAnimMontage != null)
			{
				flag = true;
				if (DebugConfig.IsOpenBattleInfoTool)
				{
					BGUFunctionLibraryCS.LogBattleInfo(owner, EBattleInfoType.ChargeSkill, $"<character>{GetOwner().GetName()}</><action>释放蓄力技</><effectnum>{ChargeSkillData.CurrentChargeSkillID}</><action>，进入Loop阶段，播放动画</><assetpath>{loopTemplatePath}</>");
				}
				base.BUSEventCollection.Evt_CastSkillWithAnimMontage.Invoke(uAnimMontage, 1f, 0f, FName.None);
				base.BUSEventCollection?.Evt_UnitStateTrigger.Invoke(EBUStateTrigger.AttackStateBegin, -1f, NeedForceUpdate: true);
				if (chargeSkillSDesc.LoopCanRotate == EGSYesNo.Yes)
				{
					base.BUSEventCollection?.Evt_UnitStateTrigger.Invoke(EBUStateTrigger.AttackRotationBegin, -1f, NeedForceUpdate: true);
				}
				if (chargeSkillSDesc.LoopCanMove == EGSYesNo.Yes)
				{
					base.BUSEventCollection?.Evt_UnitStateTrigger.Invoke(EBUStateTrigger.EnableMoveInSkill, -1f, NeedForceUpdate: true);
				}
			}
			if (!flag)
			{
				TriggerNextChargeSkillStage(IsOverTime: false);
			}
			else
			{
				SetChargeSkillInfo(ChargeSkillData.CurrentChargeSkillID, ChargeSkillData.CurrentBeginChargeSkillOriginSkillID);
			}
		}
		else
		{
			ResetChargeSkillInfo($"Not Found ChargeSkill Info In ChargeSkillSDesc, ID = {ChargeSkillData.CurrentChargeSkillID}");
		}
	}

	private void SetChargeSkillInfo(int SkillID, int OriginSkillID)
	{
		FUStSkillSDesc skillSDesc = BGW_GameDB.GetSkillSDesc(SkillID, GetOwner());
		FUStChargeSkillSDesc chargeSkillSDesc = BGW_GameDB.GetChargeSkillSDesc(SkillID, GetOwner());
		if (skillSDesc == null)
		{
			return;
		}
		if (skillSDesc.SkillType == ESkillType.ChargeSkillBegin || skillSDesc.SkillType == ESkillType.ChargeSkillEnd)
		{
			ChargeSkillData.CurrentChargeSkillID = SkillID;
			if (chargeSkillSDesc != null)
			{
				if (ChargeSkillData.IsCastingChargeSkill && ChargeSkillData.ChargeSkillStage == EChargeSkillStage.Begin && ChargeSkillData.CurrentChargeSkillID == SkillID)
				{
					ChargeSkillData.ChargeSkillStage = EChargeSkillStage.Loop;
				}
				else
				{
					ChargeSkillData.CurrentBeginChargeSkillID = SkillID;
					ChargeSkillData.CurrentBeginChargeSkillOriginSkillID = OriginSkillID;
					TriggerBuffLogicInChargeBeginStage();
					TriggerSuperArmorLogicInChargeBeginStage();
					ChargeSkillData.ChargeTimer = chargeSkillSDesc.MaxChargeTime;
					ChargeSkillData.ChargeSkillStage = EChargeSkillStage.Begin;
					ChargeSkillData.NeedTriggerNextStage = false;
				}
			}
			else
			{
				if (base.BUSEventCollection != null)
				{
					base.BUSEventCollection.Evt_NotifyTriggerBuffWhenConditionMet.Invoke(EBuffEffectTriggerType.IntoChargeEnd, default(FEffectInstReq));
				}
				ChargeSkillData.ChargeSkillStage = EChargeSkillStage.End;
			}
			ChargeSkillData.IsCastingChargeSkill = true;
			if (DebugConfig.IsOpenBattleInfoTool)
			{
				BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.ChargeSkill, $"<character>{Owner.GetName().ConvertLongGuid2DisplayGuid()}</><effect>蓄力技进入</><action>{ChargeSkillData.ChargeSkillStage}</><effect>阶段</>");
			}
		}
		else if (ChargeSkillData.IsCastingChargeSkill)
		{
			ResetChargeSkillInfo(INVALID_CHARGESKILL_CASTING);
		}
	}

	private void TriggerBuffLogicInChargeBeginStage()
	{
		AActor owner = GetOwner();
		if (owner == null)
		{
			return;
		}
		FUStChargeSkillSDesc chargeSkillSDesc = BGW_GameDB.GetChargeSkillSDesc(ChargeSkillData.CurrentBeginChargeSkillID, owner);
		if (chargeSkillSDesc == null)
		{
			return;
		}
		if (ChargeSkillData.BuffInfoList != null && ChargeSkillData.BuffInfoList.Count > 0)
		{
			ChargeSkillData.BuffInfoList.ForEach(delegate(ChargeSkillBuffInfo BuffInfo)
			{
				if (BuffInfo.HasTrigger)
				{
					BuffInfo.HasTrigger = false;
					base.BUSEventCollection?.Evt_BuffRemove.Invoke(BuffInfo.BuffID, EBuffEffectTriggerType.None, 1);
				}
			});
			ChargeSkillData.BuffInfoList.Clear();
		}
		else
		{
			ChargeSkillData.BuffInfoList = new List<ChargeSkillBuffInfo>();
		}
		foreach (FUStChargeSkillBuffInfo chargeSkillBuffInfo2 in chargeSkillSDesc.ChargeSkillBuffInfoList)
		{
			ChargeSkillBuffInfo chargeSkillBuffInfo = new ChargeSkillBuffInfo();
			chargeSkillBuffInfo.BuffID = chargeSkillBuffInfo2.BuffID;
			chargeSkillBuffInfo.DelayTriggerBuffTimer = chargeSkillBuffInfo2.BeginTimeInBeginStage;
			chargeSkillBuffInfo.DelayRemoveBuffTimer = chargeSkillBuffInfo2.EndTimeInEndStage;
			chargeSkillBuffInfo.HasTrigger = false;
			ChargeSkillData.BuffInfoList.Add(chargeSkillBuffInfo);
		}
		UpdateForChargeSkillBuff(0f);
	}

	private void TriggerSuperArmorLogicInChargeBeginStage()
	{
		AActor owner = GetOwner();
		if (owner == null)
		{
			return;
		}
		FUStChargeSkillSDesc chargeSkillSDesc = BGW_GameDB.GetChargeSkillSDesc(ChargeSkillData.CurrentBeginChargeSkillID, owner);
		if (chargeSkillSDesc != null)
		{
			if (ChargeSkillData.SuperArmorInfo != null)
			{
				ChargeSkillData.SuperArmorInfo.HasSuperArmor = false;
			}
			else
			{
				ChargeSkillData.SuperArmorInfo = new ChargeSkillSuperArmorInfo();
			}
			if (chargeSkillSDesc.ChargeSkillSuperArmorInfo.HasSuperArmor == EGSYesNo.Yes)
			{
				ChargeSkillData.SuperArmorInfo.HasSuperArmor = true;
				ChargeSkillData.SuperArmorInfo.HasTrigger = false;
				ChargeSkillData.SuperArmorInfo.DelayTriggerSuperArmorTimer = chargeSkillSDesc.ChargeSkillSuperArmorInfo.BeginTimeInBeginStage;
				ChargeSkillData.SuperArmorInfo.DelayRemoveSuperArmorTimer = chargeSkillSDesc.ChargeSkillSuperArmorInfo.EndTimeInEndStage;
				ChargeSkillData.SuperArmorInfo.SkillSuperArmorValue = chargeSkillSDesc.ChargeSkillSuperArmorInfo.SkillSuperArmorValue;
				ChargeSkillData.SuperArmorInfo.SSABreakAssignedAnim = chargeSkillSDesc.ChargeSkillSuperArmorInfo.SSABreakAssignedAnim;
			}
		}
	}

	private void SetChargeLevelInfo(int ChargeSkillID)
	{
		if (ChargeSkillData.ChargeSkillStage != EChargeSkillStage.Begin)
		{
			return;
		}
		FUStChargeSkillSDesc chargeSkillSDesc = BGW_GameDB.GetChargeSkillSDesc(ChargeSkillID, GetOwner());
		if (chargeSkillSDesc == null)
		{
			return;
		}
		string chargeLevelConfigPath = chargeSkillSDesc.ChargeLevelConfigPath;
		if (!string.IsNullOrEmpty(chargeLevelConfigPath))
		{
			BGWDataAsset_ChargeLevelConfig bGWDataAsset_ChargeLevelConfig = BGW_PreloadAssetMgr.Get(GetOwner()).TryGetCachedResourceObj<BGWDataAsset_ChargeLevelConfig>(chargeLevelConfigPath, ELoadResourceType.SyncLoadAndCache);
			if (!(bGWDataAsset_ChargeLevelConfig == null) && bGWDataAsset_ChargeLevelConfig.ChargeLevelConfigs.Count > chargeSkillSDesc.ChargeLevelConfigIndex)
			{
				ChargeSkillData.CurChargeLevelConfig = bGWDataAsset_ChargeLevelConfig.ChargeLevelConfigs[chargeSkillSDesc.ChargeLevelConfigIndex];
				ChargeSkillData.CurMaxLevel = ChargeSkillData.CurChargeLevelConfig.InfoList.Count;
				OnIncreaseChargeLevel();
			}
		}
	}

	private void OnTriggerEventWithChargeLevel(int ChargeLevel, bool bIsEnter)
	{
		if (ChargeSkillData.CurChargeLevelConfig.InfoList == null || ChargeLevel < 0 || ChargeLevel > ChargeSkillData.CurMaxLevel)
		{
			return;
		}
		AActor owner = GetOwner();
		if (owner.IsNullOrDestroyed() || base.BUSEventCollection == null || ChargeSkillData.CurChargeLevelConfig.InfoList.Count < 1 || ChargeLevel >= ChargeSkillData.CurChargeLevelConfig.InfoList.Count)
		{
			return;
		}
		foreach (int buff in ChargeSkillData.CurChargeLevelConfig.InfoList[ChargeLevel].BuffList)
		{
			if (bIsEnter)
			{
				base.BUSEventCollection.Evt_BuffAdd.Invoke(buff, owner, owner, -1f, EBuffSourceType.ChargeSkill);
			}
			else
			{
				base.BUSEventCollection.Evt_BuffRemove.Invoke(buff, EBuffEffectTriggerType.None, 1);
			}
		}
		if (bIsEnter)
		{
			if (ChargeSkillData.CurChargeLevel == ChargeSkillData.CurMaxLevel)
			{
				ChargeSkillData.IntoNextCLevelRemaining = -1f;
				return;
			}
			if (ChargeSkillData.CurChargeLevelConfig.InfoList.Count < 1 || ChargeLevel >= ChargeSkillData.CurChargeLevelConfig.InfoList.Count)
			{
				return;
			}
			float duration = ChargeSkillData.CurChargeLevelConfig.InfoList[ChargeLevel].Duration;
			ChargeSkillData.IntoNextCLevelRemaining = ((duration <= 0f) ? (-1f) : duration);
		}
		if (bIsEnter)
		{
			if (ChargeSkillData.ChargeSkillStage == EChargeSkillStage.Loop)
			{
				HandleChargeLevelWithinLoop(IsAdd: true);
			}
			else if (ChargeSkillData.ChargeSkillStage == EChargeSkillStage.Begin)
			{
				ChargeSkillData.NeedAddChargeLevelBuffWithinLoop = true;
			}
		}
		if (!bIsEnter && ChargeSkillData.HasChargeLevelBuffWithinLoop)
		{
			HandleChargeLevelWithinLoop(IsAdd: false);
		}
	}

	private void ClearChargeLevelInfo()
	{
		OnDecreaseChargeLevel(ChargeSkillData.CurChargeLevel + 1);
		ChargeSkillData.CurChargeLevel = -1;
		ChargeSkillData.CurChargeLevelConfig.Clear();
		ChargeSkillData.CurMaxLevel = 0;
		ChargeSkillData.IntoNextCLevelRemaining = -1f;
		ChargeSkillData.NeedAddChargeLevelBuffWithinLoop = false;
		ChargeSkillData.HasChargeLevelBuffWithinLoop = false;
	}

	private void HandleChargeLevelWithinLoop(bool IsAdd)
	{
		AActor owner = GetOwner();
		if (owner.IsNullOrDestroyed() || ChargeSkillData.CurChargeLevelConfig.InfoList == null || base.BUSEventCollection == null || ChargeSkillData.CurChargeLevelConfig.InfoList.Count < 1 || ChargeSkillData.CurChargeLevel >= ChargeSkillData.CurChargeLevelConfig.InfoList.Count || ChargeSkillData.CurChargeLevel < 0)
		{
			return;
		}
		List<int> loopBuffList = ChargeSkillData.CurChargeLevelConfig.InfoList[ChargeSkillData.CurChargeLevel].LoopBuffList;
		if (IsAdd)
		{
			foreach (int item in loopBuffList)
			{
				base.BUSEventCollection.Evt_BuffAdd.Invoke(item, owner, owner, -1f, EBuffSourceType.ChargeSkill);
			}
			ChargeSkillData.NeedAddChargeLevelBuffWithinLoop = false;
			ChargeSkillData.HasChargeLevelBuffWithinLoop = true;
			return;
		}
		foreach (int item2 in loopBuffList)
		{
			base.BUSEventCollection.Evt_BuffRemove.Invoke(item2, EBuffEffectTriggerType.None, 1);
		}
	}

	private void TickForCastingSkill()
	{
		if (SkillInstsData.CurrentCastingSkillID != -1 && !UnitStateData.HasState(EBGUUnitState.Attacking))
		{
			OnSkillEnded(SkillInstsData.CurrentCastingSkillID);
			ResetCastingSkillInfo();
		}
	}

	private void TickForSkillCD(float DeltaTime)
	{
		if (SkillInstsData.SkillCanCastCooldownRemainingTime.Count == 0)
		{
			return;
		}
		foreach (int item in SkillInstsData.SkillCanCastCooldownRemainingTime.Keys.ToList())
		{
			if (SkillInstsData.SkillCanCastCooldownRemainingTime[item] > 0f)
			{
				SkillInstsData.SkillCanCastCooldownRemainingTime[item] -= DeltaTime;
			}
		}
	}

	private void OnSkillEnded(int SkillID)
	{
		SkillInstsData.CurSkillCostDmgCounter = 0;
		base.BUSEventCollection.Evt_OnSkillEnd.Invoke(SkillID);
	}

	private void OnSkillCostDmg(AActor Victim, int SkillID, int FinalDmg, bool bIsCrit)
	{
		if (SkillID == SkillInstsData.CurrentCastingSkillID)
		{
			SkillInstsData.CurSkillCostDmgCounter++;
		}
		if (Owner is BGUPlayerCharacterCS && Owner != Victim)
		{
			base.BGSEventCollection.Evt_BGS_OnLocalPlayerCostDmg.Invoke();
		}
	}

	private void OnSkillValidAttackEnded()
	{
		base.BGWEventCollection.Evt_BGW_OnSkillValidAttackFrameEnded(Owner, SkillInstsData.CurrentCastingSkillID);
	}

	private void PretreatBeforeCastSkill()
	{
		base.BUSEventCollection.Evt_UnitStateTrigger.Invoke(EBUStateTrigger.SkillBreak, 0f);
	}

	private void SolveMappingSkillID(FCastSkillInfo CSI, out int NewSkillID, out string MontagePath, out float BeginPos, out FName BeginSectionName)
	{
		NewSkillID = CSI.SkillID;
		MontagePath = "";
		BeginPos = CSI.SkillMontageBeginPos;
		BeginSectionName = CSI.MontageStartSectionName;
		base.BUSEventCollection.Evt_OnSkillMappingStart.Invoke(CSI.SkillID, CSI.SkillDirection);
		if (SkillMappingData != null)
		{
			NewSkillID = SkillMappingData.GetCurResultSkillID(CSI.SkillID);
			MontagePath = SkillMappingData.GetCurResultMontagePath(CSI.SkillID);
			BeginPos = 0f;
			BeginSectionName = SkillMappingData.GetCurResultSectionName(CSI.SkillID, CSI.MontageStartSectionName);
		}
	}

	private void SolveSceneItemInSkillBreak()
	{
		if (SceneItemData != null && SceneItemData.HasSceneItem())
		{
			base.BUSEventCollection.Evt_RemoveSceneItemAndDetach.Invoke();
		}
	}

	private void CastSkillOKAddBuff(int SkillID)
	{
		FUStSkillSDesc skillSDesc = BGW_GameDB.GetSkillSDesc(SkillID, GetOwner());
		if (skillSDesc != null && skillSDesc.DoneAddBuffID != 0)
		{
			base.BUSEventCollection.Evt_BuffAdd.Invoke(skillSDesc.DoneAddBuffID, Owner, Owner, 0f, EBuffSourceType.SkillInsts);
		}
	}

	private void SetSkillBaseTarget(int SkillID)
	{
		AActor owner = GetOwner();
		if (owner == null)
		{
			return;
		}
		FUStSkillSDesc skillSDesc = BGW_GameDB.GetSkillSDesc(SkillID, owner);
		if (skillSDesc != null)
		{
			int param = ((skillSDesc.SkillBaseTargetIntParams.Count >= 1) ? skillSDesc.SkillBaseTargetIntParams[0] : 0);
			int param2 = ((skillSDesc.SkillBaseTargetIntParams.Count >= 2) ? skillSDesc.SkillBaseTargetIntParams[1] : 0);
			string skillBaseTargetStringParam = skillSDesc.SkillBaseTargetStringParam;
			FVector OutTargetPos;
			FVector OutAim2TargetDir;
			bool ValidTarget;
			AActor skillBaseTarget = BGU_B1TargetFuncs.SkillBaseTargetFuncs[(uint)skillSDesc.SkillBaseTarget](owner, out OutTargetPos, out OutAim2TargetDir, param, param2, skillBaseTargetStringParam, out ValidTarget);
			if (ValidTarget)
			{
				ETargetSourceType sourceType = ((skillSDesc.SkillBaseTarget == ESkillBaseTarget.NoneOrCurrenttarget) ? ETargetSourceType.SkillBase_SetByAI : ETargetSourceType.SkillBase_NormalUse);
				base.BUSEventCollection.Evt_SetSkillBaseTarget.Invoke(skillBaseTarget, OutTargetPos, sourceType, "");
			}
		}
	}

	private ECastSkillResult CastSkillFromMontage(int SkillID, in string MappingMontagePath, FName MontageStartSectionName, float MontagePosOffset, out UAnimMontage SkillMontage, EMontageBindReason Reason)
	{
		SkillMontage = null;
		BGUCharacterCS bGUCharacterCS = GetOwner() as BGUCharacterCS;
		if (BGW_LogUtil.LogIfNull(bGUCharacterCS, "Cast ABGUCharacter Failed"))
		{
			return ECastSkillResult.CSR_CAST_CHR_FAILED;
		}
		FUStSkillSDesc skillSDesc = BGW_GameDB.GetSkillSDesc(SkillID, GetOwner());
		if (BGW_LogUtil.LogIfNull(skillSDesc, "Can't Find FUStSkillSDesc Failed, SkillID:{0}", SkillID))
		{
			return ECastSkillResult.CSR_FIND_NO_SKILLDESC;
		}
		int resID = bGUCharacterCS.GetResID();
		if (BGW_LogUtil.LogIfNull(BGW_GameDB.GetUnitCommDesc(resID), "Can't Find FUStUnitCommDesc Failed, ResID:{0}", resID))
		{
			return ECastSkillResult.CSR_FIND_NO_UNITDESC;
		}
		if (skillSDesc.SkillType != ESkillType.NoMontageSkill)
		{
			string text = MappingMontagePath;
			if (text.Equals(string.Empty))
			{
				text = skillSDesc.TemplatePath;
			}
			SkillMontage = BGW_PreloadAssetMgr.Get(bGUCharacterCS).TryGetCachedResourceObj<UAnimMontage>(text, ELoadResourceType.SyncLoadAndCache);
			if (BGW_LogUtil.LogIfNull(SkillMontage, "Not Found WillPlayMontage!!!"))
			{
				return ECastSkillResult.CSR_FIND_NO_SKILLMONTAGE;
			}
			UAnimInstance uAnimInstance = bGUCharacterCS.Mesh?.GetAnimInstance();
			if (BGW_LogUtil.LogIfNull(uAnimInstance, "Can't Find AnimInstance Failed"))
			{
				return ECastSkillResult.CSR_FIND_NO_ANIMINST;
			}
			SkillCastResultCheck = ESkillCastResultCheck.Pending;
			base.BUSEventCollection.Evt_CastSkillWithAnimMontage.Invoke(SkillMontage, 1f, MontagePosOffset, MontageStartSectionName, Reason);
			ESkillCastResultCheck skillCastResultCheck = SkillCastResultCheck;
			SkillCastResultCheck = ESkillCastResultCheck.None;
			if (skillCastResultCheck == ESkillCastResultCheck.Success)
			{
				int num = UBGUFunctionLibraryForCS.BGUGetCurActiveMontageInstID(uAnimInstance);
				if (num != -1)
				{
					PretreatBeforeCastSkill();
					float leftTime = MontagePosOffset;
					if (MontageStartSectionName != FName.None)
					{
						leftTime = 0f;
						if (UBGUFunctionLibrary.BGUGetMontageSectionStartAndEndTime(SkillMontage, MontageStartSectionName, out var OutStartTime, out var _))
						{
							leftTime = OutStartTime;
						}
					}
					float time = UBGUFuncLibSkill.BGUCalcMontageSpecificRangeTime(Owner, num, leftTime, SkillMontage.GetPlayLength(), SkillMontage);
					base.BUSEventCollection.Evt_UnitStateTrigger.Invoke(EBUStateTrigger.AttackStateBegin, time, NeedForceUpdate: true);
					if (skillSDesc.IsCanMoveAttack == EGSYesNo.Yes)
					{
						base.BUSEventCollection.Evt_UnitStateTrigger.Invoke(EBUStateTrigger.EnableMoveInSkill, time, NeedForceUpdate: true);
					}
					AnimNotifyAndStateData.RebindSkillID(SkillID, num);
					return ECastSkillResult.CSR_OK;
				}
			}
			return ECastSkillResult.CSR_OTHER;
		}
		return ECastSkillResult.CSR_OK;
	}

	private void OnUnitCastSkillTry(FCastSkillInfo CSI)
	{
		if (DebugConfig.IsOpenBattleInfoTool)
		{
			BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.SkillCast, "<character>" + Owner.GetName() + "</><action>============================================释放技能流程开始============================================</>");
		}
		SolveMappingSkillID(CSI, out var NewSkillID, out var MontagePath, out var BeginPos, out var BeginSectionName);
		FUStSkillSDesc skillSDesc = BGW_GameDB.GetSkillSDesc(CSI.SkillID, Owner);
		if (skillSDesc != null)
		{
			if (!CSI.HasSetSkillBaseTarget)
			{
				SetSkillBaseTarget(NewSkillID);
			}
			ECanCastSkillResult eCanCastSkillResult = (CSI.NeedCheckSkillCanCast ? BGU_CommonUtil.CheckSkillCanCast(Owner, CSI.SkillID, NewSkillID) : ECanCastSkillResult.CCSR_OK);
			ECastSkillResult eCastSkillResult = ECastSkillResult.CSR_OK;
			if (eCanCastSkillResult == ECanCastSkillResult.CCSR_OK)
			{
				base.BUSEventCollection.Evt_UnitCastSkillBeforePlayMontage.Invoke(NewSkillID);
				eCastSkillResult = CastSkillFromMontage(NewSkillID, in MontagePath, BeginSectionName, BeginPos, out var SkillMontage, CSI.Reason);
				if (eCastSkillResult == ECastSkillResult.CSR_OK)
				{
					if (SkillInstsData.CurrentCastingSkillID != -1)
					{
						if (ChargeSkillData.IsCastingChargeSkill)
						{
							bool flag = false;
							bool flag2 = false;
							bool flag3 = false;
							switch (skillSDesc.SkillType)
							{
							case ESkillType.ChargeSkillBegin:
								flag = true;
								break;
							case ESkillType.ChargeSkillEnd:
								flag2 = true;
								flag3 = true;
								break;
							default:
								flag = true;
								flag2 = true;
								flag3 = true;
								break;
							}
							if (flag)
							{
								ResetChargeSkillInfo(CAST_NEW_SKILL, bNeedTriggerResetCanForceAttackInChargeSkillState: false);
							}
							if (flag2)
							{
								ResetCanForceAttackInChargeSkillState();
							}
							if (flag3)
							{
								OnSkillEnded(SkillInstsData.CurrentCastingSkillID);
							}
						}
						else
						{
							ResetCanForceAttackInChargeSkillState();
							OnSkillEnded(SkillInstsData.CurrentCastingSkillID);
						}
						ResetCastingSkillInfo();
					}
					SkillInstsData.SetCurrentCastingSkillInfo(NewSkillID, SkillMontage);
					ActionRequestData.RequestSkillIdx(NewSkillID);
					if (AIData.IsAI)
					{
						base.BGSEventCollection.Evt_BGS_MarkGroupCastSkill.Invoke(GetActorResID(), GuidData.GetFinalGuid(), NewSkillID, UnrealGameplayData.GetTimeSeconds());
					}
					CastSkillOKAddBuff(NewSkillID);
					if (DebugConfig.IsOpenBattleInfoTool)
					{
						string pathName = SkillMontage.GetPathName();
						if (skillSDesc.SkillType == ESkillType.ChargeSkillBegin)
						{
							BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.ChargeSkill, $"<character>{Owner.GetName()}</><action>释放蓄力技</><effectnum>{NewSkillID}</><action>，进入Begin阶段，播放动画</><assetpath>{pathName}</><action>，来源</><effect>{CSI.SourceType}</>");
						}
						else if (skillSDesc.SkillType == ESkillType.ChargeSkillEnd)
						{
							BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.ChargeSkill, $"<character>{Owner.GetName()}</><action>释放蓄力技</><effectnum>{NewSkillID}</><action>，进入End阶段，播放动画</><assetpath>{pathName}</><action>，来源</><effect>{CSI.SourceType}</>");
						}
						else if (DebugConfig.IsOpenBattleInfoTool)
						{
							BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.SkillCast, $"<character>{Owner.GetName().ConvertLongGuid2DisplayGuid()}</><action>释放技能</><effectnum>{NewSkillID}</><action>，播放动画</><assetpath>{pathName}</><action>，来源</><effect>{CSI.SourceType}</>");
						}
					}
					OnChargeSkillSuccess(NewSkillID, CSI.SkillID);
					base.BUSEventCollection.Evt_UnitCastSkillSuccess.Invoke(NewSkillID, CSI.SkillID, CSI.SourceType);
					base.BUSEventCollection.Evt_ClearLastSkillHit.Invoke();
					base.BGWEventCollection.Evt_BGW_UnitCastSkillSuccess(Owner, NewSkillID);
					if (skillSDesc.CooldownType == ESkillCooldownType.TryToCast)
					{
						OnStartSkillCooldown(NewSkillID);
					}
					SkillInstsData.SetLastSkillCastTime(NewSkillID, UnrealGameplayData.GetTimeSeconds());
					if (skillSDesc.NoiseLoudness > 0f)
					{
						APawn noiseInstigator = Owner as APawn;
						Owner.MakeNoise(skillSDesc.NoiseLoudness, noiseInstigator, BGUFuncLibActorTransformCS.BGUGetActorLocation(Owner), 0f, FName.None);
					}
					if (skillSDesc.IsComboSkill == EGSYesNo.No)
					{
						base.BUSEventCollection.Evt_ComboGraphReset.Invoke();
					}
					if (skillSDesc.SkillType != ESkillType.RollSkill)
					{
						base.BUSEventCollection.Evt_ReStartDodgeCombo.Invoke();
					}
				}
			}
			else
			{
				eCastSkillResult = ECastSkillResult.CSR_CAN_CAST_SKILL_CHECK_FAILED;
			}
			if (eCanCastSkillResult != ECanCastSkillResult.CCSR_OK || eCastSkillResult != ECastSkillResult.CSR_OK)
			{
				base.BUSEventCollection.Evt_UnitCastSkillFail.Invoke(NewSkillID, eCanCastSkillResult);
			}
			SkillInstsData.SetLastCanCastSkillResult(eCanCastSkillResult);
			SkillInstsData.SetLastSkillCastResult(eCastSkillResult);
			if (DebugConfig.IsOpenBattleInfoTool)
			{
				string text = ((BasicData.ActorType != BGU_ActorType.CharacterPlayer) ? $"<action>怪物释放技能, SkillID = </><effect>{NewSkillID}</><action>, CastSkillResult = </><effect>{eCastSkillResult}</><action>, CanCastSkillResult = </><effect>{eCanCastSkillResult}</>" : $"<action>玩家释放技能, SkillID = </><effect>{NewSkillID}</><action>, CastSkillResult = </><effect>{eCastSkillResult}</><action>, CanCastSkillResult = </><effect>{eCanCastSkillResult}</>");
				BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.SkillCast, "<character>" + Owner.GetName().ConvertLongGuid2DisplayGuid() + "</>" + text);
			}
		}
		if (DebugConfig.IsOpenBattleInfoTool)
		{
			BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.SkillCast, "<character>" + Owner.GetName() + "</><action>============================================释放技能流程结束============================================</>");
		}
	}

	private void ResetCastingSkillInfo()
	{
		SkillInstsData.ResetCastingSkillInfo();
	}

	private void OnUnitCastSkillTry_Predict(FCastSkillInfo CSI, GSPredictionKey PredictionKey)
	{
		OnUnitCastSkillTry(CSI, null);
	}

	private void OnUnitCastSkillTry(FCastSkillInfo CSI, GSPredictionKey PredictionKey)
	{
		if (PredictionKey == null)
		{
			OnUnitCastSkillTry(CSI);
		}
	}

	private void OnUnitTryBreakSkill(string Reason)
	{
		if (DebugConfig.IsOpenBattleInfoTool)
		{
			BGUFunctionLibraryCS.LogBattleInfo(GetOwner(), EBattleInfoType.SkillBreak, "<character>" + GetOwner().GetName() + "</><action>尝试触发技能中断，中断原因是</><effect>" + Reason + "</>");
		}
		int currentCastingSkillID = SkillInstsData.CurrentCastingSkillID;
		if (currentCastingSkillID != 0)
		{
			ResetChargeSkillInfo("OnUnitSkillBreak Reason = " + Reason);
			ResetCastingSkillInfo();
			SolveSceneItemInSkillBreak();
			base.BUSEventCollection.Evt_UnitStateTrigger.Invoke(EBUStateTrigger.SkillBreak, 0f);
			base.BUSEventCollection.Evt_NotifyTriggerBuffWhenConditionMet.Invoke(EBuffEffectTriggerType.OnSkillBreak, new FEffectInstReq(Owner));
			OnSkillEnded(currentCastingSkillID);
			base.BUSEventCollection.Evt_UnitSkillBreak.Invoke(currentCastingSkillID, Reason);
			if (DebugConfig.IsOpenBattleInfoTool)
			{
				BGUFunctionLibraryCS.LogBattleInfo(GetOwner(), EBattleInfoType.SkillBreak, $"<character>{GetOwner().GetName()}</><action>释放中的技能</><effectnum>{currentCastingSkillID}</><action>被中断！！！</>");
			}
		}
		else if (DebugConfig.IsOpenBattleInfoTool)
		{
			BGUFunctionLibraryCS.LogBattleInfo(GetOwner(), EBattleInfoType.SkillBreak, "<character>" + GetOwner().GetName() + "</><action>中断无效！！！当前没有任何技能可以被中断！！！</>");
		}
	}

	private void OnUnitSkillFail(int SkillID, ECanCastSkillResult FailReason)
	{
		FUStSkillSDesc skillSDesc = BGW_GameDB.GetSkillSDesc(SkillID, GetOwner());
		if (skillSDesc != null && skillSDesc.SkillType == ESkillType.ChargeSkillBegin && BGW_GameDB.GetChargeSkillSDesc(SkillID, GetOwner()) != null)
		{
			ResetChargeSkillInfo("OnUnitSkillFail FailReason = " + FailReason);
		}
	}

	private void TriggerNextChargeSkillStage(bool IsOverTime)
	{
		AActor owner = GetOwner();
		if (owner == null || owner.IsPendingKill)
		{
			return;
		}
		FUStChargeSkillSDesc chargeSkillSDesc = BGW_GameDB.GetChargeSkillSDesc(ChargeSkillData.CurrentChargeSkillID, owner);
		if (chargeSkillSDesc != null && base.BUSEventCollection != null)
		{
			if (AIData.IsAI || chargeSkillSDesc.TriggerNextStageUseFSM != EGSYesNo.Yes)
			{
				if (BasicData.ActorType == BGU_ActorType.CharacterPlayer)
				{
					if (!IsOverTime)
					{
						base.BUSEventCollection.Evt_RequestSmartCastSkill.Invoke(chargeSkillSDesc.EndSkillID, null, EMontageBindReason.ChargeSkill);
					}
					else
					{
						base.BUSEventCollection.Evt_RequestSmartCastSkill.Invoke(chargeSkillSDesc.NextStageSkillID, null);
					}
				}
				else
				{
					bool hasSetSkillBaseTarget = true;
					if (TargetInfoData.GetSkillBaseTarget().LockTargetActor == null)
					{
						hasSetSkillBaseTarget = false;
					}
					if (!IsOverTime)
					{
						base.BUSEventCollection.Evt_UnitCastSkillTry.Invoke(new FCastSkillInfo(chargeSkillSDesc.EndSkillID, ECastSkillSourceType.ChargeSkill)
						{
							HasSetSkillBaseTarget = hasSetSkillBaseTarget
						});
					}
					else
					{
						base.BUSEventCollection.Evt_UnitCastSkillTry.Invoke(new FCastSkillInfo(chargeSkillSDesc.NextStageSkillID, ECastSkillSourceType.ChargeSkill)
						{
							HasSetSkillBaseTarget = hasSetSkillBaseTarget
						});
					}
				}
			}
			else
			{
				EChargeSkillEndEventType chargeSkillEndEventType = (IsOverTime ? EChargeSkillEndEventType.TimeOut : EChargeSkillEndEventType.ChargeEnd);
				base.BUSEventCollection.Evt_TriggerChargeSkillNextStageEvent.Invoke(chargeSkillEndEventType);
			}
		}
		ChargeSkillData.NeedTriggerNextStage = false;
	}

	private void OnTriggerCancelChargeSkill()
	{
		if (!ChargeSkillData.IsCastingChargeSkill || ChargeSkillData.ChargeSkillStage == EChargeSkillStage.End)
		{
			return;
		}
		if (ChargeSkillData.ChargeSkillStage == EChargeSkillStage.Begin)
		{
			ChargeSkillData.NeedCancel = true;
			return;
		}
		ACharacter aCharacter = GetOwner() as ACharacter;
		if (aCharacter != null)
		{
			aCharacter.StopAnimMontage(null);
		}
		OnUnitTryBreakSkill("蓄力技");
	}

	private void OnStartSkillCooldown(int SkillID)
	{
		float timeSeconds = UnrealGameplayData.GetTimeSeconds();
		FUStSkillSDesc skillSDesc = BGW_GameDB.GetSkillSDesc(SkillID, GetOwner());
		if (skillSDesc == null)
		{
			return;
		}
		SkillInstsData.SkillCanCastCooldownRemainingTime[SkillID] = skillSDesc.CooldownTime;
		SkillInstsData.SetLastSkillCastTime(SkillID, timeSeconds);
		string[] array = skillSDesc.CooldownSkills.Split(',');
		foreach (string text in array)
		{
			if (!text.Equals("") && int.TryParse(text, out var result))
			{
				FUStSkillSDesc skillSDesc2 = BGW_GameDB.GetSkillSDesc(result, GetOwner());
				if (skillSDesc2 != null)
				{
					SkillInstsData.SkillCanCastCooldownRemainingTime[result] = skillSDesc2.CooldownTime;
				}
			}
		}
	}

	private void OnIncreaseChargeLevel(int IncreaseValue = 1)
	{
		if (ChargeSkillData.CurChargeLevelConfig.InfoList != null && ChargeSkillData.CurChargeLevelConfig.InfoList.Count >= 1 && ChargeSkillData.CurChargeLevel != ChargeSkillData.CurMaxLevel && IncreaseValue != 0)
		{
			OnTriggerEventWithChargeLevel(ChargeSkillData.CurChargeLevel, bIsEnter: false);
			ChargeSkillData.CurChargeLevel = FMath.Clamp(ChargeSkillData.CurChargeLevel + IncreaseValue, 0, ChargeSkillData.CurMaxLevel);
			OnTriggerEventWithChargeLevel(ChargeSkillData.CurChargeLevel, bIsEnter: true);
		}
	}

	private void OnDecreaseChargeLevel(int DecreaseValue = 1)
	{
		if (ChargeSkillData.CurChargeLevel >= 0 && DecreaseValue != 0)
		{
			OnTriggerEventWithChargeLevel(ChargeSkillData.CurChargeLevel, bIsEnter: false);
			ChargeSkillData.CurChargeLevel = FMath.Clamp(ChargeSkillData.CurChargeLevel - DecreaseValue, 0, ChargeSkillData.CurMaxLevel);
			if (ChargeSkillData.CurChargeLevel > 0)
			{
				OnTriggerEventWithChargeLevel(ChargeSkillData.CurChargeLevel, bIsEnter: true);
			}
		}
	}

	private void OnLanded()
	{
		if (ChargeSkillData.IsCastingChargeSkill && ChargeSkillData.ChargeSkillStage != EChargeSkillStage.End)
		{
			FUStChargeSkillSDesc chargeSkillSDesc = BGW_GameDB.GetChargeSkillSDesc(ChargeSkillData.CurrentBeginChargeSkillID, Owner);
			if (chargeSkillSDesc != null && chargeSkillSDesc.TriggerNextStageWhenOnLand == EGSYesNo.Yes)
			{
				TriggerNextChargeSkillStage(IsOverTime: true);
			}
		}
	}

	private void OnJumpOff()
	{
		if (ChargeSkillData.IsCastingChargeSkill && ChargeSkillData.ChargeSkillStage != EChargeSkillStage.End)
		{
			FUStChargeSkillSDesc chargeSkillSDesc = BGW_GameDB.GetChargeSkillSDesc(ChargeSkillData.CurrentBeginChargeSkillID, Owner);
			if (chargeSkillSDesc != null && chargeSkillSDesc.TriggerNextStageWhenOnLand == EGSYesNo.Yes)
			{
				TriggerNextChargeSkillStage(IsOverTime: true);
			}
		}
	}

	private void OnModifyCD(int SkillID, bool bAddOrMul, float Value)
	{
		if (SkillInstsData.SkillCanCastCooldownRemainingTime.TryGetValue(SkillID, out var value) && value > 0f)
		{
			float num = value;
			float num2 = (bAddOrMul ? Value : ((10000f + Value) * 0.0001f));
			float value2 = (bAddOrMul ? (num + num2) : (num * num2));
			SkillInstsData.SkillCanCastCooldownRemainingTime[SkillID] = value2;
		}
	}

	private void OnResetSkillCD()
	{
		SkillInstsData.ResetLastSkillCastTime();
		SkillInstsData.SkillCanCastCooldownRemainingTime.Clear();
		SkillInstsData.BeginCalcSkillPreCDTime = -1f;
	}

	private void OnSetNewTurnSkillID(TurnSkillType Type, int NewTurnSkillID)
	{
		SkillInstsData.SetTurnSkillID(Type, NewTurnSkillID);
	}

	private void OnSetNewMoveSkillID(TurnSkillType Type, int NewMoveSkillID)
	{
		SkillInstsData.SetMoveSkillID(Type, NewMoveSkillID);
	}

	private void OnAttackFeedback(AActor Victim, int AttackSkillID, int EffectID, int NotifyID, bool IsAtkRebounding)
	{
		if (!SimpleStateData.HasSimpleState(EBGUSimpleState.ImmueStiff) && BGU_DataUtil.GetActorType(Victim) != BGU_ActorType.Bullet && SkillInstsData.CurrentCastingSkillID != -1)
		{
			SkillInstsData.IsHitUnitDuringCastingSkill = true;
		}
	}

	private void OnSetSpAtkReboundingAM(int ObjectID, UAnimMontage AtkReboundingAM, bool IsLowRebounding = false)
	{
		if (IsLowRebounding)
		{
			if (!SkillInstsData.SweepCheckLowAtkReboundingAMMap.ContainsKey(ObjectID))
			{
				SkillInstsData.SweepCheckLowAtkReboundingAMMap.Add(ObjectID, new TStrongObjectPtr_NoCollect<UAnimMontage>(AtkReboundingAM));
			}
		}
		else if (!SkillInstsData.SweepCheckAtkReboundingAMMap.ContainsKey(ObjectID))
		{
			SkillInstsData.SweepCheckAtkReboundingAMMap.Add(ObjectID, new TStrongObjectPtr_NoCollect<UAnimMontage>(AtkReboundingAM));
		}
	}

	private void OnRemoveSpAtkReboundingAM(int ObjectID, bool IsLowRebounding = false)
	{
		if (IsLowRebounding)
		{
			if (SkillInstsData.SweepCheckLowAtkReboundingAMMap.ContainsKey(ObjectID))
			{
				SkillInstsData.SweepCheckLowAtkReboundingAMMap.Remove(ObjectID);
			}
		}
		else if (SkillInstsData.SweepCheckAtkReboundingAMMap.ContainsKey(ObjectID))
		{
			SkillInstsData.SweepCheckAtkReboundingAMMap.Remove(ObjectID);
		}
	}

	private void OnSetLastSkillKeyActionMapping(string KeyActionMapping)
	{
		SkillInstsData.LastSkillKeyActionMapping = KeyActionMapping;
	}

	private void OnSetMagicWindowSkillList(List<int> SkillBlackList, List<int> SkillWhiteList)
	{
		SkillInstsData.MagicWindowSkillBlackList = SkillBlackList;
		SkillInstsData.MagicWindowSkillWhiteList = SkillWhiteList;
	}

	private void OnNotifyBattleStateChange(bool bIsIntoBattle)
	{
		if (bIsIntoBattle)
		{
			SkillInstsData.BeginCalcSkillPreCDTime = UnrealGameplayData.GetTimeSeconds();
		}
		else
		{
			SkillInstsData.BeginCalcSkillPreCDTime = -1f;
		}
	}

	private void OnResetActorStatusPre(EResetActorReason ResetReason)
	{
		base.BUSEventCollection?.Evt_ResetSkillCD.Invoke();
	}

	private void OnResetActorStatusAfterAll(EResetActorReason ResetReason)
	{
		OnUnitTryBreakSkill("Actor重置");
	}

	private void OnReCoverLastSkillCastTime(int SkillID, float LastTime)
	{
		SkillInstsData.SetLastSkillCastTime(SkillID, LastTime);
	}

	private void OnBeginPhaseTransitionBySkill(int SkillID)
	{
		ACharacter aCharacter = GetOwner() as ACharacter;
		if (!(aCharacter == null))
		{
			base.BUSEventCollection.Evt_UnitSetSimpleState.Invoke(EBGUSimpleState.InPhaseTransition);
			base.BUSEventCollection.Evt_RelieveImmobilized.Invoke();
			FCastSkillInfo fCastSkillInfo = new FCastSkillInfo(SkillID, ECastSkillSourceType.PhaseTransition);
			fCastSkillInfo.NeedCheckSkillCanCast = false;
			fCastSkillInfo.Reason = EMontageBindReason.NormalSkill;
			FCastSkillInfo cSI = fCastSkillInfo;
			base.BUSEventCollection.Evt_UnitCastSkillTry.Invoke(cSI);
			UAnimMontage currentActiveMontage = aCharacter.Mesh.GetAnimInstance().GetCurrentActiveMontage();
			if (currentActiveMontage != null)
			{
				SkillInstsData.PhaseTransitionSkillMontage = currentActiveMontage;
			}
			else
			{
				base.BUSEventCollection.Evt_UnitSetSimpleState.Invoke(EBGUSimpleState.InPhaseTransition, IsRemove: true);
			}
		}
	}

	private void OnMontageEnd(UAnimMontage Montage, bool bInterrupted)
	{
		if (!(GetOwner() as ACharacter == null) && Montage == SkillInstsData.PhaseTransitionSkillMontage)
		{
			base.BUSEventCollection.Evt_UnitSetSimpleState.Invoke(EBGUSimpleState.InPhaseTransition, IsRemove: true);
		}
	}

	private void OnPlayMontageCallback(EMontageBindReason Reason, UAnimMontage Montage, EMontageCallbackState State)
	{
		if (SkillCastResultCheck == ESkillCastResultCheck.Pending)
		{
			switch (State)
			{
			case EMontageCallbackState.OnStarted:
				SkillCastResultCheck = ESkillCastResultCheck.Success;
				break;
			case EMontageCallbackState.OnPlayFailed:
				SkillCastResultCheck = ESkillCastResultCheck.Fail;
				break;
			}
		}
		if (Reason == EMontageBindReason.NormalSkill && (State == EMontageCallbackState.OnCompleted || State == EMontageCallbackState.OnInterrupted))
		{
			OnMontageEnd(Montage, State == EMontageCallbackState.OnInterrupted);
		}
		if (Reason != EMontageBindReason.ChargeSkill)
		{
			return;
		}
		switch (State)
		{
		case EMontageCallbackState.OnStarted:
			ChargeSkillData.ChargeSkillStage = EChargeSkillStage.End;
			break;
		case EMontageCallbackState.OnBlendOut:
			if (ChargeSkillData.ChargeSkillStage == EChargeSkillStage.End)
			{
				ResetChargeSkillInfo(END_SKILL_BLENDOUT);
			}
			break;
		}
	}
}
