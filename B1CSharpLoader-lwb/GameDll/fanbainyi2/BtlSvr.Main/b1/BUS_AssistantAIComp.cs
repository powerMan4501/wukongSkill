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

public class BUS_AssistantAIComp : UActorCompBaseCS
{
	private static string FOLLOW_PARTNER_BT_PATH = "BehaviorTree'/Game/00Main/Design/AI/BTs/NPC/NPC_ZhuBaJie01B/BT_npc_zhubajie_01b_new.BT_npc_zhubajie_01b_new'";

	private readonly int NeverIntoBattleBuffID = 456;

	private b1.BUC_FollowPartnerData FollowPartnerData;

	private IBUC_GuidData GuidData;

	private IBUC_FsmData FsmData;

	private IBUC_UnitStateData UnitStateData;

	private IBUC_BattleStateData BattleStateData;

	private IBGC_AssociationUnitData AssociationUnitData;

	private IBGC_FollowPartnerMgrData FollowPartnerMgrData;

	private IBGC_UnrealGameplayData UnrealGameplayData;

	public override void OnAttach()
	{
		FollowPartnerData = RequireWritableData<b1.BUC_FollowPartnerData>();
		GuidData = RequireReadOnlyData<IBUC_GuidData, BUC_GuidData>();
		FsmData = RequireReadOnlyData<IBUC_FsmData, BUC_FsmData>();
		UnitStateData = RequireReadOnlyData<IBUC_UnitStateData, BUC_UnitStateData>();
		BattleStateData = RequireReadOnlyData<IBUC_BattleStateData, BUC_BattleStateData>();
		AssociationUnitData = RequireReadOnlyGameStateData<IBGC_AssociationUnitData, BGC_AssociationUnitData>();
		FollowPartnerMgrData = RequireReadOnlyGameStateData<IBGC_FollowPartnerMgrData, BGC_FollowPartnerMgrData>();
		UnrealGameplayData = RequireReadOnlyGameStateData<IBGC_UnrealGameplayData, BGC_UnrealGameplayData>();
		base.BUSEventCollection.Evt_NotifyAssociationUnitActive += new Del_NotifyAssociationUnitActive(OnActiveAssociationUnit);
		base.BUSEventCollection.Evt_PlayMontageCallback += new Del_PlayMontageCallback(OnIdleDispMontageEnd);
		base.BUSEventCollection.Evt_BreakIdleDisp += new Del_Void(OnBreakIdleDisp);
		base.BUSEventCollection.Evt_UpdateFollowPartnerIdleDisp += new Del_Void_Float(OnUpdateFollowPartnerIdleDisp);
		base.BUSEventCollection.Evt_TriggerAiConversationForWeakInteract += new Del_TriggerAiConversationForWeakInteract(OnTriggerAiConversationForWeakInteract);
		base.BUSEventCollection.Evt_NotifyBattleStateChange += new Del_NotifyBattleStateChange(OnBattleStateChanged);
		base.BGSEventCollection.Evt_BGS_OnLocalPlayerCostDmg += new Del_Void(OnLocalPlayerCostDmg);
	}

	public override void OnBeginPlay()
	{
		FollowPartnerData.IsAssociationUnit = InitForAssociationUnit();
		if (!FollowPartnerData.IsAssociationUnit)
		{
			FollowPartnerData.IsFollowPartnerUnit = InitForFollowPartner();
		}
		if (FollowPartnerData.IsAssociationUnit)
		{
			base.BUSEventCollection.Evt_SwitchFsmSolver.Invoke(EFsmSolverType.FriendlyBattleNpc);
		}
		else if (FollowPartnerData.IsFollowPartnerUnit)
		{
			base.BUSEventCollection.Evt_SwitchFsmSolver.Invoke(EFsmSolverType.AssistantPartner);
		}
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		UpdatePlyerLeisureTime();
	}

	private void TickForIdleWaiting(float DeltaTime)
	{
		if (!FollowPartnerData.CanTriggerIdleWaiting)
		{
			return;
		}
		if (UnitStateData.HasState(EBGUUnitState.Attacking))
		{
			FollowPartnerData.IdleWaitingTimer = FollowPartnerData.IdleWaitingInfo.TriggerCD;
		}
		else if (BGUFuncLibActorTransformCS.BGUGetVelocity(Owner).Size() > 0f)
		{
			FollowPartnerData.IdleWaitingTimer = FollowPartnerData.IdleWaitingInfo.TriggerCD;
		}
		else if (!FollowPartnerData.IsInWaitingMontage && !FollowPartnerData.IsInDodgeMontage)
		{
			if (FollowPartnerData.IdleWaitingTimer > 0f)
			{
				FollowPartnerData.IdleWaitingTimer -= DeltaTime;
			}
			if (FollowPartnerData.IdleWaitingTimer <= 0f)
			{
				SolveIdleWaiting();
			}
		}
	}

	private void TickForIdleDodge(float DeltaTime)
	{
		if (FollowPartnerData.CanTriggerIdleDodge && !FollowPartnerData.IsInDodgeMontage)
		{
			if (FollowPartnerData.IdleDodgeTimer > 0f)
			{
				FollowPartnerData.IdleDodgeTimer -= DeltaTime;
			}
			if (FollowPartnerData.IdleDodgeTimer <= 0f)
			{
				SolveIdleDodge();
			}
		}
	}

	private void TickForDebug()
	{
		if (FollowPartnerData.CanTriggerIdleWaiting || FollowPartnerData.CanTriggerIdleDodge)
		{
			string value = (FollowPartnerData.IsInDodgeMontage ? "躲闪" : (FollowPartnerData.IsInWaitingMontage ? "休闲" : "无"));
			base.BUSEventCollection.Evt_UpdateDebugUIKeyValuePair.Invoke("FollowPartnerDispInfo", "当前触发的Disp类型是", value);
			base.BUSEventCollection.Evt_UpdateDebugUIKeyValuePair.Invoke("FollowPartnerDispInfo", "当前IdleWaitingTimer", $"{FollowPartnerData.IdleWaitingTimer:F2}");
			base.BUSEventCollection.Evt_UpdateDebugUIKeyValuePair.Invoke("FollowPartnerDispInfo", "当前IdleDodgeTimer", $"{FollowPartnerData.IdleDodgeTimer:F2}");
			string value2 = string.Empty;
			if (FollowPartnerData.CurrentIdleDispMontage != null)
			{
				value2 = FollowPartnerData.CurrentIdleDispMontage.GetName();
			}
			base.BUSEventCollection.Evt_UpdateDebugUIKeyValuePair.Invoke("FollowPartnerDispInfo", "当前DispMontageName", value2);
		}
		base.BUSEventCollection.Evt_UpdateDebugUIKeyValuePair.Invoke("FollowPartnerDispInfo", "玩家战斗中摸鱼时长", $"{FollowPartnerData.PlayerBattleLeisureTime:F2}");
	}

	private bool InitForAssociationUnit()
	{
		if (AssociationUnitData.GetAssociationUnitConfigIDByGUID(GuidData.GetFinalGuid(), out var OutConfigID, out var OutAUI))
		{
			if (OutAUI.bCanActive)
			{
				OnActiveAssociationUnit(OutConfigID, OutAUI.TargetGUID, OutAUI.OnFightSkillID);
			}
			else
			{
				base.BUSEventCollection?.Evt_BuffAdd.Invoke(NeverIntoBattleBuffID, Owner, Owner, 0f, EBuffSourceType.AssociationUnit);
				DisactiveBTAndCBG();
			}
			FUStAssociationUnitInfoSDesc associationUnitInfoSDesc = BGW_GameDB.GetAssociationUnitInfoSDesc(OutConfigID);
			if (associationUnitInfoSDesc != null)
			{
				foreach (int spawnBuffID in associationUnitInfoSDesc.SpawnBuffIDList)
				{
					base.BUSEventCollection?.Evt_BuffAdd.Invoke(spawnBuffID, Owner, Owner, 0f, EBuffSourceType.AssociationUnit);
				}
			}
			return true;
		}
		return false;
	}

	private bool InitForFollowPartner()
	{
		if (FollowPartnerMgrData != null && FollowPartnerMgrData.CurrentUseFollowPartnerConfigID > 0 && FollowPartnerMgrData.FollowPartnerGUID.Equals(GuidData.GetFinalGuid()))
		{
			FUStFollowPartnerConfigDesc followPartnerConfigDesc = BGW_GameDB.GetFollowPartnerConfigDesc(FollowPartnerMgrData.CurrentUseFollowPartnerConfigID);
			if (followPartnerConfigDesc != null)
			{
				FUStAssociationUnitInfoSDesc associationUnitInfoSDesc = BGW_GameDB.GetAssociationUnitInfoSDesc(followPartnerConfigDesc.AssociationUnitInfoID);
				if (associationUnitInfoSDesc != null)
				{
					if (FollowPartnerMgrData.SeqHiddenFlag)
					{
						base.BUSEventCollection.Evt_TriggerFsmEvent.Invoke(BGW_FlowUtils.FollowPartnerAIFsmEventTag.ShowBegin);
					}
					ActiveBTAndCBG(FOLLOW_PARTNER_BT_PATH, associationUnitInfoSDesc.CBGTemplateID);
					foreach (int spawnBuffID in associationUnitInfoSDesc.SpawnBuffIDList)
					{
						base.BUSEventCollection?.Evt_BuffAdd.Invoke(spawnBuffID, Owner, Owner, 0f, EBuffSourceType.AssociationUnit);
					}
					if (FollowPartnerMgrData.FollowPartnerDisplayConfig != null)
					{
						FollowPartnerData.IdleDodgeInfo = FollowPartnerMgrData.FollowPartnerDisplayConfig.IdleDodgeInfo;
						if (FollowPartnerData.IdleDodgeInfo.CanTrigger && (FollowPartnerData.IdleDodgeInfo.ForwardDodgeMontageList.Count > 0 || FollowPartnerData.IdleDodgeInfo.BackwardDodgeMontageList.Count > 0 || FollowPartnerData.IdleDodgeInfo.LeftSideDodgeMontageList.Count > 0 || FollowPartnerData.IdleDodgeInfo.RightSideDodgeMontageList.Count > 0))
						{
							FollowPartnerData.CanTriggerIdleDodge = true;
							FollowPartnerData.IdleDodgeTimer = 0f;
						}
						FollowPartnerData.IdleWaitingInfo = FollowPartnerMgrData.FollowPartnerDisplayConfig.IdleWaitingInfo;
						if (FollowPartnerData.IdleWaitingInfo.CanTrigger && FollowPartnerData.IdleWaitingInfo.IdleRandomMontageList.Count > 0)
						{
							FollowPartnerData.CanTriggerIdleWaiting = true;
							FollowPartnerData.IdleWaitingTimer = FollowPartnerData.IdleWaitingInfo.TriggerCD;
						}
					}
					return true;
				}
			}
		}
		return false;
	}

	private void OnActiveAssociationUnit(int ConfigID, string TargetGUID, int OnFightSkillID)
	{
		base.BGWEventCollection.Evt_BGW_NotifyMarkAssociationUnitActive(ConfigID);
		if (base.BUSEventCollection != null)
		{
			base.BUSEventCollection?.Evt_BuffRemoveImmediately.Invoke(NeverIntoBattleBuffID, EBuffEffectTriggerType.None);
			FUStAssociationUnitInfoSDesc associationUnitInfoSDesc = BGW_GameDB.GetAssociationUnitInfoSDesc(ConfigID);
			if (associationUnitInfoSDesc != null)
			{
				ActiveBTAndCBG(associationUnitInfoSDesc.BTPath, associationUnitInfoSDesc.CBGTemplateID);
			}
			AActor actorByGuid = BGU_DataUtil.GetActorByGuid(Owner, TargetGUID);
			if (actorByGuid != null)
			{
				base.BUSEventCollection?.Evt_SetOnFightSkillID.Invoke(OnFightSkillID);
				base.BUSEventCollection?.Evt_AICatchTarget.Invoke(actorByGuid, ETargetSourceType.Target_AssociaAssignTarget);
			}
			base.BUSEventCollection?.Evt_AIPauseFsm.Invoke(P1: false);
		}
	}

	private void ActiveBTAndCBG(string BTPath, int CBGTemplateID)
	{
		base.BUSEventCollection?.Evt_EnableCanSetBT.Invoke(P1: true);
		base.BUSEventCollection?.Evt_EnableCanSetCBG.Invoke(P1: true);
		UBehaviorTree uBehaviorTree = BGW_PreloadAssetMgr.Get(Owner).TryGetCachedResourceObj<UBehaviorTree>(BTPath, ELoadResourceType.SyncLoadAndCache);
		if (uBehaviorTree != null)
		{
			base.BUSEventCollection?.Evt_SetBT.Invoke(uBehaviorTree);
		}
		base.BUSEventCollection?.Evt_TryRunAssignCBGTemplateByID.Invoke(CBGTemplateID);
	}

	private void DisactiveBTAndCBG()
	{
		base.BUSEventCollection?.Evt_AIPauseFsm.Invoke(P1: true);
		base.BUSEventCollection?.Evt_StopCurrentCBG.Invoke();
		base.BUSEventCollection?.Evt_SetBT.Invoke(null);
		base.BUSEventCollection?.Evt_EnableCanSetBT.Invoke(P1: false);
		base.BUSEventCollection?.Evt_EnableCanSetCBG.Invoke(P1: false);
	}

	private UAnimMontage GetRandomIdleDispMontage(List<List<UAnimMontage>> MontageLists)
	{
		List<UAnimMontage> Montages = new List<UAnimMontage>();
		MontageLists.ForEach(delegate(List<UAnimMontage> MontageList)
		{
			Montages.AddRange(MontageList);
		});
		int randomNumberInt = UB1Util.GetRandomNumberInt(0, Montages.Count - 1);
		if (Montages.Count <= randomNumberInt)
		{
			return null;
		}
		return Montages[randomNumberInt];
	}

	private void SolveIdleDodge()
	{
		if (UnitStateData.HasState(EBGUUnitState.Attacking))
		{
			return;
		}
		APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(Owner.World);
		if (!(firstLocalPlayerController != null))
		{
			return;
		}
		APawn controlledPawn = firstLocalPlayerController.GetControlledPawn();
		if (!(controlledPawn != null))
		{
			return;
		}
		float num = BGUFuncLibActorTransformCS.BGUGetVelocity(Owner).Size();
		float num2 = BGUFuncLibActorTransformCS.BGUGetVelocity(controlledPawn).Size();
		if (Math.Abs(num - num2) < (float)FollowPartnerData.IdleDodgeInfo.VelocityDifferent)
		{
			return;
		}
		FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorLocation(controlledPawn);
		FVector fVector2 = BGUFuncLibActorTransformCS.BGUGetActorLocation(Owner);
		if (!(FVector.Dist(fVector, fVector2) <= (float)FollowPartnerData.IdleDodgeInfo.TriggerRadius))
		{
			return;
		}
		FVector2D safeNormal = new FVector2D(BGUFuncLibActorTransformCS.BGUGetActorForwardVector(Owner)).GetSafeNormal();
		FVector2D safeNormal2 = new FVector2D(fVector - fVector2).GetSafeNormal();
		float num3 = MathLib.DotProduct2D(safeNormal, safeNormal2);
		float num4 = MathLib.DegAcos(num3);
		UAnimMontage uAnimMontage = null;
		uAnimMontage = (((double)Math.Abs(num4) < 0.01 || (double)Math.Abs(num4 - 180f) < 0.01) ? GetRandomIdleDispMontage(new List<List<UAnimMontage>>
		{
			FollowPartnerData.IdleDodgeInfo.LeftSideDodgeMontageList,
			FollowPartnerData.IdleDodgeInfo.RightSideDodgeMontageList
		}) : (((double)Math.Abs(num3) < 0.01) ? GetRandomIdleDispMontage(new List<List<UAnimMontage>>
		{
			FollowPartnerData.IdleDodgeInfo.ForwardDodgeMontageList,
			FollowPartnerData.IdleDodgeInfo.BackwardDodgeMontageList
		}) : ((!(num4 < 90f)) ? GetRandomIdleDispMontage(new List<List<UAnimMontage>> { FollowPartnerData.IdleDodgeInfo.ForwardDodgeMontageList }) : GetRandomIdleDispMontage(new List<List<UAnimMontage>> { FollowPartnerData.IdleDodgeInfo.BackwardDodgeMontageList }))));
		if (uAnimMontage != null)
		{
			if (FollowPartnerData.IsInWaitingMontage)
			{
				StopCurrentDispMontage();
				FollowPartnerData.IsInWaitingMontage = false;
				FollowPartnerData.IdleWaitingTimer = FollowPartnerData.IdleWaitingInfo.TriggerCD;
				FollowPartnerData.CurrentIdleDispMontage = null;
			}
			FollowPartnerData.IsInDodgeMontage = true;
			base.BUSEventCollection.Evt_TriggerFsmEvent.Invoke(BGW_FlowUtils.FollowPartnerAIFsmEventTag.Dodge);
			PlayIdleDispMontage(uAnimMontage, EMontageBindReason.FollowPartnerIdleDodge);
		}
	}

	private void SolveIdleWaiting()
	{
		UAnimMontage randomIdleDispMontage = GetRandomIdleDispMontage(new List<List<UAnimMontage>> { FollowPartnerData.IdleWaitingInfo.IdleRandomMontageList });
		if (randomIdleDispMontage != null)
		{
			FollowPartnerData.IsInWaitingMontage = true;
			base.BUSEventCollection.Evt_TriggerFsmEvent.Invoke(BGW_FlowUtils.FollowPartnerAIFsmEventTag.LongTimeNoAction);
			PlayIdleDispMontage(randomIdleDispMontage, EMontageBindReason.FollowPartnerIdleWaiting);
		}
	}

	private void PlayIdleDispMontage(UAnimMontage DispMontage, EMontageBindReason Reason)
	{
		FollowPartnerData.CurrentIdleDispMontage = DispMontage;
		BGUFuncLibAnim.BGUActorTryPlayMontage(Owner, DispMontage, FName.None, Reason);
	}

	private void StopCurrentDispMontage()
	{
		BGUCharacterCS bGUCharacterCS = Owner as BGUCharacterCS;
		if (!(bGUCharacterCS != null))
		{
			return;
		}
		USkeletalMeshComponent mesh = bGUCharacterCS.Mesh;
		if (!(mesh != null))
		{
			return;
		}
		UAnimInstance animInstance = mesh.GetAnimInstance();
		if (!(animInstance != null))
		{
			return;
		}
		UAnimMontage currentActiveMontage = animInstance.GetCurrentActiveMontage();
		if (currentActiveMontage != null && currentActiveMontage == FollowPartnerData.CurrentIdleDispMontage)
		{
			if (UnitStateData.HasState(EBGUUnitState.Attacking))
			{
				base.BUSEventCollection.Evt_UnitStateTrigger.Invoke(EBUStateTrigger.SkillBreak, 0f);
			}
			bGUCharacterCS.StopAnimMontage(currentActiveMontage);
		}
	}

	private void OnUpdateFollowPartnerIdleDisp(float DeltaTime)
	{
		if (FsmData.IsInFsmState(BGW_FlowUtils.FollowPartnerAIFsmStateTag.Idle))
		{
			if (!FsmData.IsInFsmState(BGW_FlowUtils.FollowPartnerAIFsmStateTag.Dodge))
			{
				TickForIdleDodge(DeltaTime);
			}
			if (FsmData.IsInFsmState(BGW_FlowUtils.FollowPartnerAIFsmStateTag.Standby))
			{
				TickForIdleWaiting(DeltaTime);
			}
		}
		if (DebugConfig.FollowPartnerDispInfo)
		{
			TickForDebug();
		}
	}

	private void OnTriggerAiConversationForWeakInteract(string WeakAiInteractGUID, List<int> ConversationIDList)
	{
		if (FollowPartnerMgrData.WeakAiInteractConversationTimer <= 0f && FollowPartnerMgrData.FollowPartnerDisplayConfig.WeakAiInteractConversationCD > 0 && !UnitStateData.HasState(EBGUUnitState.Attacking) && !FsmData.IsInFsmState(BGW_FlowUtils.FollowPartnerAIFsmStateTag.Battle) && !FsmData.IsInFsmState(BGW_FlowUtils.FollowPartnerAIFsmStateTag.Interacting))
		{
			base.BGSEventCollection.Evt_BGS_NotifyTriggerWeakAiInteract.Invoke(WeakAiInteractGUID);
			base.BUSEventCollection?.Evt_HandleConversationByContentIDList.Invoke("援助AI::WeakInteract", ConversationIDList);
		}
	}

	private void OnIdleDispMontageEnd(EMontageBindReason Reason, UAnimMontage Montage, EMontageCallbackState State)
	{
		if (State == EMontageCallbackState.OnStarted)
		{
			return;
		}
		switch (Reason)
		{
		case EMontageBindReason.FollowPartnerIdleWaiting:
			if (FollowPartnerData.IsInWaitingMontage)
			{
				FollowPartnerData.IsInWaitingMontage = false;
				FollowPartnerData.IdleWaitingTimer = FollowPartnerData.IdleWaitingInfo.TriggerCD;
				FollowPartnerData.CurrentIdleDispMontage = null;
				base.BUSEventCollection.Evt_TriggerFsmEvent.Invoke(BGW_FlowUtils.FollowPartnerAIFsmEventTag.FreeTime);
			}
			break;
		case EMontageBindReason.FollowPartnerIdleDodge:
			if (FollowPartnerData.IsInDodgeMontage)
			{
				FollowPartnerData.IsInDodgeMontage = false;
				FollowPartnerData.IdleDodgeTimer = FollowPartnerData.IdleDodgeInfo.TriggerCD;
				FollowPartnerData.CurrentIdleDispMontage = null;
				if (FollowPartnerData.IdleDodgeInfo.CanTriggerEQSRun)
				{
					base.BUSEventCollection.Evt_InitiateAINodeAction.Invoke(EAINodeActionType.EQSRun, new AINodeAction_EQSRunParamInfo(FollowPartnerData.IdleDodgeInfo.EQSRunParamInfo));
				}
				base.BUSEventCollection.Evt_TriggerFsmEvent.Invoke(BGW_FlowUtils.FollowPartnerAIFsmEventTag.FreeTime);
			}
			break;
		}
	}

	private void OnBreakIdleDisp()
	{
		if (FollowPartnerData.IsInDodgeMontage || FollowPartnerData.IsInWaitingMontage)
		{
			StopCurrentDispMontage();
			ResetIdleDispInfo();
		}
	}

	private void ResetIdleDispInfo()
	{
		FollowPartnerData.IsInWaitingMontage = false;
		FollowPartnerData.IsInDodgeMontage = false;
		FollowPartnerData.IdleWaitingTimer = FollowPartnerData.IdleWaitingInfo.TriggerCD;
		FollowPartnerData.IdleDodgeTimer = FollowPartnerData.IdleDodgeInfo.TriggerCD;
		FollowPartnerData.CurrentIdleDispMontage = null;
	}

	private void OnBattleStateChanged(bool IsFight)
	{
		if (IsFight)
		{
			FollowPartnerData.LastPlayerCostDmgTime = UnrealGameplayData.GetTimeSeconds();
		}
	}

	private void OnLocalPlayerCostDmg()
	{
		FollowPartnerData.LastPlayerCostDmgTime = UnrealGameplayData.GetTimeSeconds();
	}

	private void UpdatePlyerLeisureTime()
	{
		if (!BattleStateData.IsUnitInBattle())
		{
			FollowPartnerData.PlayerBattleLeisureTime = -1f;
		}
		else
		{
			FollowPartnerData.PlayerBattleLeisureTime = UnrealGameplayData.GetTimeSeconds() - FollowPartnerData.LastPlayerCostDmgTime;
		}
	}
}
