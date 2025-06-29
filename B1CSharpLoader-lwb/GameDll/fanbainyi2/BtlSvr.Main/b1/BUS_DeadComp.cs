using System.Collections.Generic;
using b1.BGW;
using b1.EventDelDefine;
using BtlB1;
using BtlShare;
using CsB1;
using Diana.Common;
using GSDispLib;
using ResB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUS_DeadComp : UActorCompBaseCS
{
	private readonly int PlayerTeamRuleID = 1;

	private readonly float WEAPON_DETACH_DELAY_DESTROY_TIME = 5f;

	private FName Bip = B1GlobalFNames.Bip;

	private FPhysicBlendInfoForDeath PhysicBlendInfoForDeath;

	private BUC_DeadData DeadData;

	private UBUC_ACharacterComponent CharacterComps;

	private IBUC_SimpleStateData SimpleStateData;

	private IBUC_UnitStateData UnitStateData;

	private IBUC_GuidData GuidData;

	private IBUC_AbnormalStateHandlers AbnormalStateHandlers;

	private IBUC_BeAttackData BeAttackData;

	private IBUC_AnimationSyncGuestData AnimationSyncGuestData;

	private IBUC_PropMgrData PropMgrData;

	private IBIC_DeathData GlobalVariableData;

	private IBUC_ProjectileCtrlData ProjectileCtrData;

	private IBUC_AttrContainer PlayerAttrCon;

	private IBUC_WakeUpData WakeUpData;

	private IBIC_TeleportData TeleportData;

	private IBGC_TamerData TamerData;

	private float DisplayTimer = -1f;

	private float DelayClearArmorTime;

	private float DelayDestroyActorTime;

	private bool DestroyCheck;

	private EAbnormalStateType DeadContinueAbnormalDispType;

	private int DeadContinueAbnormalAttackerDispID = -1;

	private BUC_DispLibDispBaseConfigDataAsset DissolveDispDBC;

	private List<AActor> WakeUpUnits = new List<AActor>();

	private AActor WakeUpTargetActor;

	private b1.IBUC_SummonBehaviorData SummonBehaviorData { get; set; }

	private IBIC_BossRushBattleData BossRushBattleData { get; set; }

	public override void OnAttach()
	{
		DeadData = RequireWritableData<BUC_DeadData>();
		CharacterComps = RequireWritableData<UBUC_ACharacterComponent>();
		GuidData = RequireReadOnlyData<IBUC_GuidData, BUC_GuidData>();
		SimpleStateData = RequireReadOnlyData<IBUC_SimpleStateData, BUC_SimpleStateData>();
		UnitStateData = RequireReadOnlyData<IBUC_UnitStateData, BUC_UnitStateData>();
		AbnormalStateHandlers = RequireReadOnlyData<IBUC_AbnormalStateHandlers, BUC_AbnormalStateHandlers>();
		BeAttackData = RequireReadOnlyData<IBUC_BeAttackData, BUC_BeAttackData>();
		AnimationSyncGuestData = RequireReadOnlyData<IBUC_AnimationSyncGuestData, BUC_AnimationSyncGuestData>();
		PropMgrData = RequireReadOnlyData<IBUC_PropMgrData, BUC_PropMgrData>();
		ProjectileCtrData = RequireReadOnlyData<IBUC_ProjectileCtrlData, b1.BUC_ProjectileCtrData>();
		PlayerAttrCon = RequireReadOnlyData<IBUC_AttrContainer, BUC_AttrContainer>();
		WakeUpData = RequireReadOnlyData<IBUC_WakeUpData, BUC_WakeUpData>();
		GlobalVariableData = RequireReadonlyGameInstanceData<IBIC_DeathData, BIC_DeathData>();
		SummonBehaviorData = RequireReadOnlyData<b1.IBUC_SummonBehaviorData, b1.BUC_SummonBehaviorData>();
		TeleportData = RequireReadonlyGameInstanceData<IBIC_TeleportData, BIC_TeleportData>();
		TamerData = RequireReadOnlyGameStateData<IBGC_TamerData, BGC_TamerData>();
		BossRushBattleData = RequireReadonlyGameInstanceData<IBIC_BossRushBattleData, BIC_BossRushBattleData>();
		base.BUSEventCollection.Evt_UnitDead += new Del_UnitDead(OnUnitDead);
		base.BUSEventCollection.Evt_SetDeadInfoID += new Del_SetDeadInfoID(OnSetDeadInfoID);
		base.BUSEventCollection.Evt_ResetDeadInfoID += new Del_Void(OnResetDeadInfoID);
		base.BUSEventCollection.Evt_GMUnitSuicide += new Del_Void(OnGMUnitSuicide);
		base.BUSEventCollection.Evt_ThrowUpDeadUnit += new Del_Void(OnThrowUpDeadUnit);
		base.BUSEventCollection.Evt_TriggerDeadDissolve += new Del_Void(OnTriggerDeadDissolve);
		base.BUSEventCollection.Evt_TriggerDeadBlendPhysic += new Del_Void_BoolBool(OnTriggerSwitch2Physic);
		base.BUSEventCollection.Evt_FakeDeadForSkillDamage += new Del_FakeDeadForSkillDamage(FakeDeadForSkillDamage);
		base.BUSEventCollection.Evt_PlayMontageCallback += new Del_PlayMontageCallback(OnPlayMontageCallback);
	}

	public override void PreBeginPlay()
	{
		DisplayTimer = -1f;
		DeadData.DissolveDisplayTimer = -1f;
		DelayClearArmorTime = -1f;
		DelayDestroyActorTime = -1f;
		DeadContinueAbnormalDispType = EAbnormalStateType.None;
		DissolveDispDBC = null;
		DeadData.ThrowUpMaxTime = -1f;
		DeadData.ThrowUpTimer = -1f;
		DeadData.ThrowUpCurve = null;
		DeadData.MovementModeHandleID = 0u;
		DeadData.CollisionEnabledHandleID = 0u;
		DeadData.WaitSwitchPhysicTime = -1f;
		DeadData.Cached_StiffLevel = -1;
		DeadData.Cached_EffectInstReq = default(FEffectInstReq);
		DeadData.Cached_PhysAnimImpulseScale = 1f;
		DeadData.AutoSwitchPhysicTimer = 0f;
		PhysicBlendInfoForDeath.BoneName = B1GlobalFNames.pelvis;
		PhysicBlendInfoForDeath.PhysicBlendInType = EPhysicBlendInType.Immediately;
		PhysicBlendInfoForDeath.BlendFinalValue = 1f;
		OnResetDeadInfoID();
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		DissolveDispDBC = null;
	}

	public override bool AllowTRO()
	{
		return false;
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (!DestroyCheck)
		{
			UpdateDelayDisplayTimer(DeltaTime);
		}
		if (DestroyCheck)
		{
			DestroyCheckTick();
		}
		Tick_DeadAMWaitingBeAttackedAM();
		Tick_SwitchPhysicInDeadAM(DeltaTime);
	}

	private void DestroyCheckTick()
	{
		bool flag = true;
		if (ProjectileCtrData != null)
		{
			flag = ProjectileCtrData.ProjectileList.Count <= 0;
		}
		if (flag)
		{
			base.BUSEventCollection?.Evt_TryDestroyModularActors.Invoke();
			BUS_DispLibEventCollection.Get(GetOwner())?.Evt_DispLibPreDestroy();
			base.BGSEventCollection?.Evt_BGS_PreBGUCharacterDeadDestroy.Invoke(GetOwner());
			if (UGSE_EngineFuncLib.IsStandAlone(GetOwner()?.World) || UGSE_OnlineFuncLib.InServerReal(GetOwner()))
			{
				BGU_UnrealWorldUtil.DestroyActor(Owner);
			}
			base.BGSEventCollection?.Evt_BGS_PostBGUCharacterDeadDestroy.Invoke(GetOwner());
		}
	}

	private void UpdateDelayDisplayTimer(float DeltaTime)
	{
		if (DisplayTimer >= 0f)
		{
			DisplayTimer -= DeltaTime;
			if (DisplayTimer <= 0f)
			{
				SetDelayDestroyTime();
			}
		}
		if (DeadData.DissolveDisplayTimer >= 0f)
		{
			DeadData.DissolveDisplayTimer -= DeltaTime;
			if (DeadData.DissolveDisplayTimer <= 0f)
			{
				OnTriggerDeadDissolve();
			}
		}
		if (DeadData.ThrowUpCurve != null)
		{
			DeadData.ThrowUpTimer += DeltaTime;
			UpdateThrowUp();
		}
		else
		{
			if (!(DelayDestroyActorTime >= 0f))
			{
				return;
			}
			if (DelayClearArmorTime >= 0f)
			{
				DelayClearArmorTime -= DeltaTime;
				if (DelayClearArmorTime < 0f)
				{
					DestroyWeapon();
				}
			}
			DelayDestroyActorTime -= DeltaTime;
			if (DelayDestroyActorTime < 0f)
			{
				DestroyCheck = true;
			}
		}
	}

	protected virtual void OnUnitDead(AActor Attacker, EDeadReason DeadReason, int DmgID = -1, int StiffLevel = -1, UAnimMontage BeAttackedAM = null, FEffectInstReq EffectInstReq = default(FEffectInstReq), bool bIsDotDmg = false, EAbnormalStateType AbnormalType = EAbnormalStateType.None)
	{
		if (Owner == null)
		{
			return;
		}
		BGUCharacterCS bGUCharacterCS = Owner as BGUCharacterCS;
		if (bGUCharacterCS == null || (DeadReason != EDeadReason.DeadZone && !SimpleStateData.HasSimpleState(EBGUSimpleState.NoAutoTransformBack) && CheckIsPlayerInTransState()) || UnitStateData.HasState(EBGUUnitState.Dead) || SimpleStateData.HasSimpleState(EBGUSimpleState.PendingDeathInAnimationSyncing) || (bGUCharacterCS.IsPlayerControlled() && TeleportData != null && TeleportData.IsTeleporting()) || (bGUCharacterCS.IsPlayerControlled() && UnitStateData.HasState(EBGUUnitState.InChapterClearWorkFlow)))
		{
			return;
		}
		BGW_GameLifeTimeMgr bGW_GameLifeTimeMgr = BGW_GameLifeTimeMgr.Get(bGUCharacterCS);
		if ((bGUCharacterCS.IsPlayerControlled() && bGW_GameLifeTimeMgr.IsInTravelLevel()) || (DebugConfig.CricketBattleMode && DebugConfig.CricketBattleModeType == 3 && BGW_CricketBattleMgr.DPSUnitList.Count == 0 && DeadReason != EDeadReason.OnlyDestroyUnit))
		{
			return;
		}
		BGWDataAsset_UnitDeathDispConfig nowUseUDDConfig = GetNowUseUDDConfig(Owner);
		int deadInfoID = DeadData.GetDeadInfoID();
		BGUFuncLibBeAttackedAndUnitDeathDispCS.GetActualStiffLevelInfo(StiffLevel, nowUseUDDConfig, out var IsValid, out var _);
		if (!IsValid && nowUseUDDConfig != null && nowUseUDDConfig.NormalDeadAMInfoList != null && nowUseUDDConfig.NormalDeadAMInfoList.Count > 0)
		{
			int num = StiffLevel;
			StiffLevel = nowUseUDDConfig.NormalDeadAMInfoList[0].StiffLevelID;
			if (DebugConfig.IsOpenBattleInfoTool)
			{
				string text = (IsValid ? $"<action>当前UDDC没有配置对应的挡位为：</><effect>{num}</><action>的死亡信息，尝试保底匹配UDDC里配置</><effect>第一位</><action>的挡位信息，保底挡位是：</><effect>{StiffLevel}</>" : $"<action>当前UDDC没有配置对应的挡位为：</><effect>{num}</><action>的死亡信息，尝试保底匹配UDDC里配置</><effect>第一位</><action>的挡位信息。很遗憾的是，UDDC里一个挡位信息也没有，低保失败！</>");
				BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.DeathDisp, "<character>" + Owner?.GetName() + "</>" + text);
			}
		}
		EAttackerArea attackerArea = EAttackerArea.Forward;
		if (Attacker != null)
		{
			FVector victimForwardDir = BGUFuncLibActorTransformCS.BGUGetActorForwardVector(Owner);
			FVector victimToAttackerDir = BGUFuncLibActorTransformCS.BGUGetActorLocation(Attacker) - BGUFuncLibActorTransformCS.BGUGetActorLocation(Owner);
			attackerArea = BGUFuncLibBeAttackedAndUnitDeathDispCS.GetAttackerAreaByUDDConfig(StiffLevel, nowUseUDDConfig, victimForwardDir, victimToAttackerDir);
		}
		Dictionary<EAbnormalStateType, int> inFinalStateAndAttackerAbnormalStateDispID = AbnormalStateHandlers.GetInFinalStateAndAttackerAbnormalStateDispID();
		if (DeadReason != EDeadReason.OnlyDestroyUnit)
		{
			if (CheckFallDyingState(DeadReason, Attacker, deadInfoID, StiffLevel, EffectInstReq.HitActionDir, attackerArea, nowUseUDDConfig, inFinalStateAndAttackerAbnormalStateDispID, bIsDotDmg) || SimpleStateData.HasSimpleState(EBGUSimpleState.CantBeDead) || SimpleStateData.HasSimpleState(EBGUSimpleState.CantBeDead1HP))
			{
				return;
			}
			if ((DeadReason == EDeadReason.SkillDamage || DeadReason == EDeadReason.Cut || DeadReason == EDeadReason.FlyHit || DeadReason == EDeadReason.Fracture || DeadReason == EDeadReason.FrozenFracture) && GlobalVariableData.bAllUnitCannotDead)
			{
				bool flag = false;
				List<FUStGlobalCannotDeadExtraConfigDesc> globalCannotDeadExtraConfigDescListByResID = BGW_GameDB.GetGlobalCannotDeadExtraConfigDescListByResID(GetActorResID());
				if (globalCannotDeadExtraConfigDescListByResID != null && globalCannotDeadExtraConfigDescListByResID.Count > 0)
				{
					foreach (FUStGlobalCannotDeadExtraConfigDesc item in globalCannotDeadExtraConfigDescListByResID)
					{
						if (item.CanSkipDeadReason == DeadReason)
						{
							flag = true;
							break;
						}
					}
				}
				if (TamerData.GetTamerType(GuidData.GetFinalGuid(), out var OutTamerType) && OutTamerType == ETamerType.Summoned)
				{
					flag = true;
				}
				if (!flag)
				{
					return;
				}
			}
		}
		if (Attacker != null)
		{
			BGUCharacterCS bGUCharacterCS2 = Attacker as BGUCharacterCS;
			if (bGUCharacterCS2 != null && bGUCharacterCS2.IsPlayerControlled())
			{
				base.BGSEventCollection?.Evt_BGS_PlayerKillMonster.Invoke();
			}
		}
		if (bGUCharacterCS.IsPlayerControlled() && bGUCharacterCS.IsLocallyControlled())
		{
			base.BGWEventCollection.Evt_BGW_PlayerActorDeadForLoadingTips(new FLoadingTipsPlayerDeadInfo(Attacker, bGUCharacterCS, DeadReason, EffectInstReq, DmgID));
		}
		DeadData.Attacker = Attacker;
		DeadData.bWithinOceanSea = SimpleStateData.HasSimpleState(EBGUSimpleState.WithinOceanSea);
		DeadData.bInteractCricketLoop = SimpleStateData.HasSimpleState(EBGUSimpleState.InteractCricketLoop);
		bool bImmobilizing = SimpleStateData.HasSimpleState(EBGUSimpleState.Immobilizing);
		DeadBeforeDispLogic(Attacker, DeadReason, StiffLevel);
		if (bGUCharacterCS.IsPlayerControlled() && bGUCharacterCS.IsLocallyControlled())
		{
			float num2 = 3f;
			BGW_PreloadAssetMgr bGW_PreloadAssetMgr = BGW_PreloadAssetMgr.Get(this);
			if (bGW_PreloadAssetMgr != null)
			{
				BGWDataAsset_GameConfig gameConfig = bGW_PreloadAssetMgr.GameConfig;
				if (gameConfig != null)
				{
					num2 = ((DeadReason == EDeadReason.SkillDamage) ? gameConfig.RebirthDelayTimeWithAM : gameConfig.RebirthDelayTimeWithoutAM);
					if (gameConfig.RebirthDelayTimeSP.TryGetValue(DmgID, out var value))
					{
						num2 = value;
					}
					else if (SimpleStateData.HasSimpleState(EBGUSimpleState.PendingDeathInAnimationSyncing))
					{
						num2 = gameConfig.RebirthDelayTimeWithAM;
					}
					int commLogicCfgValue = GameDBRuntime.GetCommLogicCfgValue(CommCfgType.XuehouDefaultResid);
					if (bGUCharacterCS.GetResID() == commLogicCfgValue)
					{
						num2 = gameConfig.PlotDelayTimeWithAM;
					}
				}
			}
			if (DebugConfig.IsOpenBattleInfoTool)
			{
				BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.DeathDisp, $"<character>{Owner?.GetName()}</><action>主角触发死亡，DmgID = </><effect>{DmgID}</><action>，黑屏延后时间是 = </><effect>{num2}</>");
			}
			BPS_EventCollectionCS.Get(bGUCharacterCS.GetController().PlayerState)?.Evt_BPS_SetPlayerDeathUIDelayTime.Invoke(num2);
		}
		if (base.BUSEventCollection != null)
		{
			base.BUSEventCollection.Evt_ClearCameraLock.Invoke();
			base.BUSEventCollection.Evt_UnitTriggerDead.Invoke(Attacker, DeadReason, DmgID);
		}
		if (DebugConfig.CricketBattleMode)
		{
			BGW_CricketBattleMgr.Get(bGUCharacterCS).OnBattleUnitDead(bGUCharacterCS, bGUCharacterCS.GetFinalBattleInfoExtendID());
		}
		switch (DeadReason)
		{
		case EDeadReason.SummonDead:
			DeadForSummon();
			break;
		case EDeadReason.SkillDamage:
		case EDeadReason.FallDead:
			DeadForSkillDamage(DeadReason, Attacker, deadInfoID, StiffLevel, EffectInstReq.HitActionDir, attackerArea, nowUseUDDConfig, BeAttackedAM, in EffectInstReq, inFinalStateAndAttackerAbnormalStateDispID, bIsDotDmg, AbnormalType, bTriggerWithLifeSavingHair: false, bImmobilizing);
			SetDelayDestroyTime();
			break;
		case EDeadReason.OnlyDestroyUnit:
			DestroyUnitOnly();
			DestroyCheck = true;
			break;
		case EDeadReason.PlayerTrans:
			DestroyUnitOnly();
			SetDelayDestroyTime();
			DestroyCheck = true;
			break;
		case EDeadReason.DeadZone:
			SetDelayDestroyTime();
			break;
		case EDeadReason.FrozenFracture:
			DestroyUnitOnly();
			SetDelayDestroyTime();
			break;
		case EDeadReason.Suicide:
		{
			DeadForSuicide(nowUseUDDConfig, out var bDestroyimmediately);
			if (bDestroyimmediately)
			{
				DestroyUnitOnly();
				DestroyCheck = true;
			}
			else
			{
				SetDelayDestroyTime();
			}
			break;
		}
		default:
			SetDelayDestroyTime();
			break;
		}
		string finalGuid = GuidData.GetFinalGuid();
		if (DeadReason != EDeadReason.OnlyDestroyUnit)
		{
			base.BGWEventCollection.Evt_SetActorAliveState(finalGuid, P2: false);
			base.BGWEventCollection.Evt_BGW_GroupUnitDead(GuidData.UnitFixedGuidForGroup.TagName.ToString());
		}
		base.BGSEventCollection?.Evt_BGS_UnitDead.Invoke(finalGuid, DeadReason);
		if (DeadReason != EDeadReason.OnlyDestroyUnit)
		{
			DoRoleDataLogic(DeadReason, !SimpleStateData.HasSimpleState(EBGUSimpleState.PlayerDeadNoPunish));
		}
		if (DestroyCheck)
		{
			DestroyCheckTick();
		}
	}

	private void DoRoleDataLogic(EDeadReason DeadReason, bool NeedPunish)
	{
		BGUCharacterCS bGUCharacterCS = Owner as BGUCharacterCS;
		if (bGUCharacterCS == null)
		{
			return;
		}
		string finalGuid = GuidData.GetFinalGuid();
		base.BGSEventCollection.Evt_BGS_NotifyGraph.Invoke(finalGuid, BGW_FlowUtils.CommonTag.UnitDead);
		bool flag = true;
		if (DeadReason == EDeadReason.Suicide)
		{
			FUStUnitBattleInfoExtendDesc unitBattleInfoExtendDesc = BGW_GameDB.GetUnitBattleInfoExtendDesc(GetFinalBattleInfoExtendID());
			if (unitBattleInfoExtendDesc != null && unitBattleInfoExtendDesc.CanSuicideDeadDropItem == EGSYesNo.No)
			{
				flag = false;
			}
		}
		if (flag)
		{
			base.BGSEventCollection.Evt_BGS_UnitDeadDropItem.Invoke(Owner, DeadData.Attacker, DeadReason);
		}
		BTF_EventCollectionCS bTF_EventCollectionCS = BTF_EventCollectionCS.Get(bGUCharacterCS?.PlayerState);
		if (bGUCharacterCS.IsPlayerControlled())
		{
			base.BGWEventCollection.Evt_SetAllUnitCannotDead(P1: true);
			base.BGWEventCollection.Evt_IgnoreAllOverlapEvent(P1: true);
			bTF_EventCollectionCS?.Evt_ActorOnPlayerDeathReq(new CSMsgActorOnPlayerDeathReq
			{
				IsPunish = (NeedPunish ? YesNoType.Yes : YesNoType.No)
			}, null);
		}
		else
		{
			int finalBattleInfoExtendID = GetFinalBattleInfoExtendID();
			FUStUnitBattleInfoExtendDesc unitBattleInfoExtendDesc2 = BGW_GameDB.GetUnitBattleInfoExtendDesc(finalBattleInfoExtendID);
			if (unitBattleInfoExtendDesc2 != null && (int)unitBattleInfoExtendDesc2.QualityType <= 8 && (int)unitBattleInfoExtendDesc2.QualityType >= 5 && (SummonBehaviorData == null || !SummonBehaviorData.IsServant()))
			{
				BGW_GameArchiveMgr.Get(bGUCharacterCS).MarkSaveArchive(EArchiveSaveSource.BossOrEliteDead, "Guid : " + finalGuid);
			}
			if (GlobalVariableData.UnitHasDeadSeq(finalGuid))
			{
				base.BGWEventCollection.Evt_SetAllUnitCannotDead(P1: true);
			}
			if (!B1Global.GIsBossRushMode)
			{
				FUStDefeatSlowTimeConfigDesc slowTimeConfigDescByExtendID = BGW_GameDB.GetSlowTimeConfigDescByExtendID(finalBattleInfoExtendID);
				if (slowTimeConfigDescByExtendID != null && slowTimeConfigDescByExtendID.TriggerType == EDefeatUITriggerType.Dead)
				{
					base.BGSEventCollection.Evt_BeginDefeatSlowTime.Invoke(finalBattleInfoExtendID, EDefeatUITriggerType.Dead);
				}
			}
		}
		if (!bGUCharacterCS.IsPlayerCharacterCS() && !DebugConfig.CricketBattleMode)
		{
			BTF_EventCollectionCS bTF_EventCollectionCS2 = BTF_EventCollectionCS.Get(UGameplayStatics.GetPlayerCharacter(GetOwner(), 0)?.PlayerState);
			if (bGUCharacterCS.GetTeamIDInCS() != PlayerTeamRuleID)
			{
				bTF_EventCollectionCS2?.Evt_ActorKillUnitReq(new CSMsgActorKillUnitReq
				{
					UnitId = BGU_DataUtil.GetActorResID(Owner),
					OverrideId = BGU_DataUtil.GetFinalBattleInfoExtendID(Owner),
					UnitDeadReason = DeadReason,
					Guid = BGU_DataUtil.GetActorGuid(Owner)
				}, null);
			}
		}
		base.BGWEventCollection.Evt_TaskGraphNotifyGraph(GuidData.GetFinalGuid(), BGW_FlowUtils.CommonTag.UnitDead);
	}

	private void DeadBeforeDispLogic(AActor Attacker, EDeadReason DeadReason, int StiffLevel)
	{
		if (Owner == null || base.BUSEventCollection == null)
		{
			return;
		}
		if (DeadReason != EDeadReason.OnlyDestroyUnit)
		{
			base.BUSEventCollection.Evt_StopWeaponStatusSwitch.Invoke();
			if (SimpleStateData.HasSimpleState(EBGUSimpleState.Immobilizing))
			{
				base.BUSEventCollection.Evt_DeadWhenInImmobilized.Invoke(Attacker, DeadReason);
			}
			base.BUSEventCollection.Evt_ClearAllAbnormalState.Invoke();
			base.BUSEventCollection.Evt_TriggerIntimidation.Invoke(StiffLevel, bTriggerByDead: true);
			int actorResID = GetActorResID();
			int deadInfoID = DeadData.GetDeadInfoID();
			FUStUnitDeadDesc unitDeadDesc = BGW_GameDB.GetUnitDeadDesc(actorResID, deadInfoID);
			if (unitDeadDesc != null)
			{
				foreach (int item in unitDeadDesc.DeadTriggerEffectID)
				{
					base.BUSEventCollection.Evt_TriggerSkillEffect.Invoke(item, new FEffectInstReq(Owner));
				}
			}
			if (!B1Global.GIsBossRushMode || !OwnerAsCharacterCS.IsPlayerControlled() || DeadReason == EDeadReason.PlayerTrans)
			{
				base.BUSEventCollection.Evt_BuffAllRemove.Invoke(EBuffEffectTriggerType.Dead);
			}
		}
		else
		{
			base.BUSEventCollection.Evt_StopWeaponStatusSwitch.Invoke();
			base.BUSEventCollection.Evt_BuffAllRemove.Invoke(EBuffEffectTriggerType.None);
		}
		base.BUSEventCollection.Evt_UnitStateTrigger.Invoke(EBUStateTrigger.Die, -1f);
		base.BUSEventCollection.Evt_FSMEventTrigger.Invoke(EBGUFSMEventName.FSM_EVENT_LIFE_DIE);
	}

	private void DeadForSummon()
	{
		if (SummonBehaviorData == null)
		{
			return;
		}
		DisplayTimer = 0f;
		SummonBehaviorData.GetSummonDisappearInfo(out var MontagePathList, out var DestroyDelayTime);
		if (MontagePathList.Count > 0)
		{
			int randomNumberInt = UB1Util.GetRandomNumberInt(0, MontagePathList.Count - 1);
			UAnimMontage uAnimMontage = BGW_PreloadAssetMgr.Get(Owner).TryGetCachedResourceObj<UAnimMontage>(MontagePathList[randomNumberInt], ELoadResourceType.SyncLoadAndCache);
			if (SimpleStateData.HasSimpleState(EBGUSimpleState.InAnimationSyncing) && AnimationSyncGuestData.DeathMontage != null)
			{
				uAnimMontage = AnimationSyncGuestData.DeathMontage;
			}
			if (uAnimMontage != null)
			{
				USkeletalMeshComponent mesh = CharacterComps.OwnerCharacter.Mesh;
				if (mesh != null && mesh.GetAnimInstance() != null)
				{
					DisplayTimer = uAnimMontage.GetPlayLength();
					base.BUSEventCollection.Evt_OnToggleSnapshotPose.Invoke(bEnable: false, default(FPoseSnapshot), 0f);
					BGUFuncLibAnim.BGUActorTryPlayMontage(Owner, uAnimMontage, FName.None);
					base.BUSEventCollection.Evt_SetTriggerMontage.Invoke(P1: true);
				}
			}
		}
		DisplayTimer += DestroyDelayTime;
	}

	private void FakeDeadForSkillDamage(AActor Attacker, int StiffLevel, UAnimMontage BeAttackedAM, in FEffectInstReq EffectInstReq, bool bIsDotDmg = false, EAbnormalStateType AbnormalType = EAbnormalStateType.None)
	{
		if (SimpleStateData.HasSimpleState(EBGUSimpleState.PendingDeathInAnimationSyncing))
		{
			return;
		}
		BGWDataAsset_UnitDeathDispConfig nowUseUDDConfig = GetNowUseUDDConfig(Owner);
		int deadInfoID = DeadData.GetDeadInfoID();
		BGUFuncLibBeAttackedAndUnitDeathDispCS.GetActualStiffLevelInfo(StiffLevel, nowUseUDDConfig, out var IsValid, out var _);
		if (!IsValid && nowUseUDDConfig.NormalDeadAMInfoList != null && nowUseUDDConfig.NormalDeadAMInfoList.Count > 0)
		{
			int num = StiffLevel;
			StiffLevel = nowUseUDDConfig.NormalDeadAMInfoList[0].StiffLevelID;
			if (DebugConfig.IsOpenBattleInfoTool)
			{
				string text = (IsValid ? $"<action>当前UDDC没有配置对应的挡位为：</><effect>{num}</><action>的死亡信息，尝试保底匹配UDDC里配置</><effect>第一位</><action>的挡位信息，保底挡位是：</><effect>{StiffLevel}</>" : $"<action>当前UDDC没有配置对应的挡位为：</><effect>{num}</><action>的死亡信息，尝试保底匹配UDDC里配置</><effect>第一位</><action>的挡位信息。很遗憾的是，UDDC里一个挡位信息也没有，低保失败！</>");
				BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.DeathDisp, "<character>" + Owner?.GetName() + "</>" + text);
			}
		}
		EAttackerArea attackerArea = EAttackerArea.Forward;
		if (Attacker != null)
		{
			FVector actorForwardVector = Owner.GetActorForwardVector();
			FVector victimToAttackerDir = BGUFuncLibActorTransformCS.BGUGetActorLocation(Attacker) - BGUFuncLibActorTransformCS.BGUGetActorLocation(Owner);
			attackerArea = BGUFuncLibBeAttackedAndUnitDeathDispCS.GetAttackerAreaByUDDConfig(StiffLevel, nowUseUDDConfig, actorForwardVector, victimToAttackerDir);
		}
		Dictionary<EAbnormalStateType, int> inFinalStateAndAttackerAbnormalStateDispID = AbnormalStateHandlers.GetInFinalStateAndAttackerAbnormalStateDispID();
		base.BUSEventCollection.Evt_ClearAllAbnormalState.Invoke();
		base.BUSEventCollection.Evt_ClearCameraLock.Invoke();
		base.BUSEventCollection.Evt_OnMagicallyChangeBreak.Invoke();
		base.BUSEventCollection.Evt_UnitTryBreakSkill.Invoke("角色死亡");
		DeadForSkillDamage(EDeadReason.SkillDamage, Attacker, deadInfoID, StiffLevel, EffectInstReq.HitActionDir, attackerArea, nowUseUDDConfig, BeAttackedAM, in EffectInstReq, inFinalStateAndAttackerAbnormalStateDispID, bIsDotDmg, AbnormalType, bTriggerWithLifeSavingHair: true);
	}

	private void OnPlayMontageCallback(EMontageBindReason Reason, UAnimMontage Montage, EMontageCallbackState State)
	{
		if (Reason == EMontageBindReason.LifeSavingHairPrepare && State == EMontageCallbackState.OnStarted)
		{
			base.BUSEventCollection?.Evt_OnFakeDeadAMStart.Invoke(Montage.GetPlayLength());
		}
	}

	private void DeadForSkillDamage(EDeadReason DeadReason, AActor Attacker, int NowUseDeadInfoID, int StiffLevel, EHitActionDir HitActionDir, EAttackerArea AttackerArea, BGWDataAsset_UnitDeathDispConfig NowUseUDDConfig, UAnimMontage BeAttackedAM, in FEffectInstReq EffectInstReq, Dictionary<EAbnormalStateType, int> AbnormalList, bool bIsDotDmg = false, EAbnormalStateType CastDeadDmgAbnormalType = EAbnormalStateType.None, bool bTriggerWithLifeSavingHair = false, bool bImmobilizing = false)
	{
		int actorResID = BGU_DataUtil.GetActorResID(OwnerAsCharacterCS);
		if (BGW_GameDB.GetUnitCommDesc(actorResID) == null)
		{
			return;
		}
		BUS_GSEventCollection bUSEventCollection = base.BUSEventCollection;
		bUSEventCollection.Evt_UnitTryBreakSkill.Invoke("死亡");
		OwnerAsCharacterCS.StopAnimMontage(null);
		DeadData.InDeadAM = true;
		if (!bTriggerWithLifeSavingHair)
		{
			base.BGWEventCollection.Evt_BGW_BeKilled(Owner, Attacker);
		}
		if (DeadReason == EDeadReason.SkillDamage && WakeUpData != null && !WakeUpData.HasTriggerWakeUp && WakeUpData.WakeUpLinkEnable && WakeUpData.CanTriggerWakeUpLinkWhenDead)
		{
			WakeUpTargetActor = null;
			if (Attacker is BGUCharacterCS)
			{
				WakeUpTargetActor = Attacker;
			}
			else
			{
				IBUC_MasterData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_MasterData, BUC_MasterData>(Attacker);
				if (readOnlyData != null)
				{
					WakeUpTargetActor = readOnlyData.GetMasterActor() as BGUCharacterCS;
				}
			}
			if (WakeUpTargetActor != null)
			{
				WakeUpUnits.Clear();
				if (WakeUpData.UseManualSelect)
				{
					foreach (string manualTargetGuid in WakeUpData.ManualTargetGuidList)
					{
						ABGUCharacter aBGUCharacter = BGU_DataUtil.GetActorByGuid(Owner, manualTargetGuid) as ABGUCharacter;
						if (!WakeUpUnits.Contains(aBGUCharacter) && aBGUCharacter != null)
						{
							WakeUpUnits.Add(aBGUCharacter);
						}
					}
				}
				if (WakeUpData.UseRangeSelect)
				{
					List<ABGUCharacter> list = BGUFuncLibSelectTargetsCS.SelectTargetsWithFilter(Owner, WakeUpData);
					if (list != null && list.Count > 0)
					{
						foreach (ABGUCharacter item in list)
						{
							if (!WakeUpUnits.Contains(item))
							{
								WakeUpUnits.Add(item);
							}
						}
					}
				}
				foreach (AActor wakeUpUnit in WakeUpUnits)
				{
					IBUC_BattleStateData readOnlyData2 = BGU_DataUtil.GetReadOnlyData<IBUC_BattleStateData, BUC_BattleStateData>(wakeUpUnit);
					if (readOnlyData2 != null && !readOnlyData2.IsUnitInBattle())
					{
						BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(wakeUpUnit);
						if (bUS_GSEventCollection != null)
						{
							bUS_GSEventCollection.Evt_AICatchTarget.Invoke(WakeUpTargetActor, ETargetSourceType.Target_AwakePartner);
						}
					}
				}
			}
		}
		FUStUnitDeadDesc unitDeadDesc = BGW_GameDB.GetUnitDeadDesc(actorResID, NowUseDeadInfoID);
		if (unitDeadDesc != null && unitDeadDesc.DeadSlopeThreshold > 0f)
		{
			FVector actorUpVector = OwnerAsCharacterCS.GetActorUpVector();
			FVector upVector = FVector.UpVector;
			if (FVector.DotProduct(actorUpVector, upVector) < MathLib.Cos(unitDeadDesc.DeadSlopeThreshold))
			{
				base.BUSEventCollection?.Evt_SetPhysAnimSetting.Invoke(EPhysAnimType.Death);
				return;
			}
		}
		if (!(NowUseUDDConfig != null))
		{
			return;
		}
		BGUFuncLibBeAttackedAndUnitDeathDispCS.GetActualStiffLevelInfo(StiffLevel, NowUseUDDConfig, out var IsValid, out var NormalDeadAMInfo);
		if (DebugConfig.IsOpenBattleInfoTool)
		{
			string text = (IsValid ? "<action>找到了合适的挡位信息！！</>" : "<action>没有找到合适的挡位信息，全使用默认值！！</>");
			BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.DeathDisp, "<character>" + Owner?.GetName() + "</>" + text);
		}
		bool flag = NormalDeadAMInfo.IsEnableStiffContinue;
		bool flag2 = NormalDeadAMInfo.EnableBeAttackedRotate;
		UAnimMontage uAnimMontage = null;
		if (bImmobilizing || SimpleStateData.HasSimpleState(EBGUSimpleState.Immobilizing))
		{
			uAnimMontage = NowUseUDDConfig.ImmobilizingDeadMontage;
			flag = false;
		}
		else if (DeadData.bWithinOceanSea)
		{
			uAnimMontage = NowUseUDDConfig.OceanSeaDeadMontage;
			flag = false;
		}
		else if (DeadData.bInteractCricketLoop)
		{
			uAnimMontage = NowUseUDDConfig.InteractCricketDeadMontage;
			flag = false;
		}
		else if (bIsDotDmg && (CastDeadDmgAbnormalType == EAbnormalStateType.Abnormal_Burn || CastDeadDmgAbnormalType == EAbnormalStateType.Abnormal_Poison || CastDeadDmgAbnormalType == EAbnormalStateType.Abnormal_Freeze))
		{
			switch (CastDeadDmgAbnormalType)
			{
			case EAbnormalStateType.Abnormal_Burn:
				uAnimMontage = NowUseUDDConfig.BurnStateDotDeadMontage;
				break;
			case EAbnormalStateType.Abnormal_Poison:
				uAnimMontage = NowUseUDDConfig.PoisonStateDotDeadMontage;
				break;
			case EAbnormalStateType.Abnormal_Freeze:
				uAnimMontage = NowUseUDDConfig.FreezeStateDotDeadMontage;
				break;
			}
		}
		else if (DeadReason == EDeadReason.FallDead)
		{
			uAnimMontage = NowUseUDDConfig.FallDeadMontage;
		}
		else
		{
			BGUCharacterCS bGUCharacterCS = Owner as BGUCharacterCS;
			if (bGUCharacterCS != null && bGUCharacterCS.CharacterMovement.IsFalling())
			{
				if (HitActionDir == EHitActionDir.Default)
				{
					uAnimMontage = NowUseUDDConfig.AirDeadMontage_Fall;
				}
				else
				{
					uAnimMontage = NowUseUDDConfig.AirDeadMontage_WithDirection;
					if (uAnimMontage != null)
					{
						flag2 = true;
					}
				}
				flag = false;
			}
		}
		if (IsValid)
		{
			if (flag2)
			{
				BGUFuncLibBeAttackedAndUnitDeathDispCS.RotateToTargetActor(Attacker, OwnerAsCharacterCS, AttackerArea, 0f, EHitOrientationType.None, "", in EffectInstReq);
			}
			if (uAnimMontage == null)
			{
				uAnimMontage = GetDeadMontagePathByRule(StiffLevel, AttackerArea, HitActionDir, NowUseDeadInfoID, NowUseUDDConfig, in NormalDeadAMInfo);
			}
		}
		else if (DebugConfig.IsOpenBattleInfoTool)
		{
			BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.DeathDisp, "<character>" + Owner?.GetName() + "</><effect>没有找到合适的死亡挡位信息，不触发按规则匹配普通死亡动画逻辑！！！</>");
		}
		if (SimpleStateData.HasSimpleState(EBGUSimpleState.InAnimationSyncing) && AnimationSyncGuestData.DeathMontage != null)
		{
			uAnimMontage = AnimationSyncGuestData.DeathMontage;
			flag = false;
		}
		if (!(uAnimMontage != null))
		{
			return;
		}
		DissolveDispDBC = null;
		DeadContinueAbnormalDispType = EAbnormalStateType.None;
		DeadContinueAbnormalAttackerDispID = -1;
		EUnitQualityType eUnitQualityType = EUnitQualityType.None;
		FUStUnitBattleInfoExtendDesc unitBattleInfoExtendDesc = BGW_GameDB.GetUnitBattleInfoExtendDesc(OwnerAsCharacterCS.GetFinalBattleInfoExtendID());
		if (unitBattleInfoExtendDesc != null)
		{
			eUnitQualityType = unitBattleInfoExtendDesc.QualityType;
		}
		if (eUnitQualityType != EUnitQualityType.NormalBoss && eUnitQualityType != EUnitQualityType.FinalBoss)
		{
			if (AbnormalList.ContainsKey(EAbnormalStateType.Abnormal_Burn))
			{
				DeadContinueAbnormalDispType = EAbnormalStateType.Abnormal_Burn;
				DeadContinueAbnormalAttackerDispID = AbnormalList[DeadContinueAbnormalDispType];
			}
			else if (AbnormalList.ContainsKey(EAbnormalStateType.Abnormal_Poison))
			{
				DeadContinueAbnormalDispType = EAbnormalStateType.Abnormal_Poison;
				DeadContinueAbnormalAttackerDispID = AbnormalList[DeadContinueAbnormalDispType];
			}
		}
		if (DeadContinueAbnormalDispType == EAbnormalStateType.None)
		{
			DissolveDispDBC = NowUseUDDConfig.NormalDissolveDBC;
		}
		else if (!bTriggerWithLifeSavingHair)
		{
			AbnormalStateHandlers.PlayDeadLoopFX(DeadContinueAbnormalDispType, DeadContinueAbnormalAttackerDispID, bEnd: false);
		}
		if (NowUseUDDConfig.DeathDissolvePlayType == EDeathDissolvePlayType.DeadAMBegin)
		{
			if (DissolveDispDBC != null)
			{
				if (!OwnerAsCharacterCS.IsPlayerCharacterCS())
				{
					OwnerAsCharacterCS.Mesh.SetCastHybridRayTracingShadow(bNewHybridRayTracingShadow: true);
				}
				base.BUSEventCollection.Evt_RequestSpawnFXByDispConfigDA.Invoke(DissolveDispDBC, out var _);
				DissolveDispDBC = null;
			}
		}
		else
		{
			float sequenceLength = uAnimMontage.SequenceLength;
			DeadData.DissolveDisplayTimer = sequenceLength;
		}
		if (flag && BeAttackedAM != null)
		{
			DeadData.DeadAMWaitingBeAttackedAMInfo.bInDeadAMWaitingBeAttackedAM = true;
			DeadData.DeadAMWaitingBeAttackedAMInfo.DeadAMCached = uAnimMontage;
			DeadData.DeadAMWaitingBeAttackedAMInfo.StiffLevel = StiffLevel;
			DeadData.DeadAMWaitingBeAttackedAMInfo.bTriggerWithLifeSavingHair = bTriggerWithLifeSavingHair;
			bUSEventCollection.Evt_MoveWithAnimMontageCMultiCast.Invoke(BeAttackedAM, 1f, 1f, 0f, FName.None);
			return;
		}
		EMontageBindReason reason = (bTriggerWithLifeSavingHair ? EMontageBindReason.LifeSavingHairPrepare : EMontageBindReason.Default);
		FUStBeAttackedInfoDesc beAttackedInfoDesc = BGW_GameDB.GetBeAttackedInfoDesc(BeAttackData.GetCurrentBeAttackedInfoID());
		DeadData.Cached_StiffLevel = StiffLevel;
		DeadData.Cached_EffectInstReq = EffectInstReq;
		DeadData.Cached_PhysAnimImpulseScale = 1f;
		if (beAttackedInfoDesc != null)
		{
			DeadData.Cached_PhysAnimImpulseScale = beAttackedInfoDesc.PhysAnimImpulseScale;
		}
		if (DebugConfig.IsOpenBattleInfoTool)
		{
			BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.DeathDisp_Switch2Physic, "<character>" + Owner?.GetName() + "</><action>===判断死亡自动切换物理开始===</>");
		}
		DeadData.HasBlendPhysicNotifyState = false;
		UGSE_AnimFuncLib.GetAllNotifyEvent(uAnimMontage, out var AnimNotifyEventList);
		foreach (FAnimNotifyEvent item2 in AnimNotifyEventList)
		{
			if (item2.NotifyStateClass is b1.BANS_GSBlendPhysicForDeath)
			{
				base.BUSEventCollection.Evt_PlayBeAttackedPhysAnimForDead.Invoke(DeadData.Cached_StiffLevel, DeadData.Cached_EffectInstReq, DeadData.Cached_PhysAnimImpulseScale);
				DeadData.HasBlendPhysicNotifyState = true;
				break;
			}
		}
		if (!DeadData.HasBlendPhysicNotifyState)
		{
			if (DebugConfig.IsOpenBattleInfoTool)
			{
				BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.DeathDisp_Switch2Physic, "<character>" + Owner?.GetName() + "</><action>死亡动画里不存在BANS_GSBlendPhysicForDeath，尝试触发自动切换转物理逻辑！DeadAM = " + uAnimMontage.GetPathName() + "</>");
			}
			GetIsEnableAutoSwitchPhysic(out var EnableAutoSwitchPhysic, out var EnableWeaponAutoSwitchPhysic);
			if (EnableAutoSwitchPhysic || EnableWeaponAutoSwitchPhysic)
			{
				if (DebugConfig.IsOpenBattleInfoTool)
				{
					BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.DeathDisp_Switch2Physic, $"<character>{Owner?.GetName()}</><action>标记触发自动切物理，EnableAutoSwitchPhysic = {EnableAutoSwitchPhysic}，EnableWeaponAutoSwitchPhysic = {EnableWeaponAutoSwitchPhysic}</>");
				}
				int num = 4;
				float thresholds = 0.3f;
				if (BGW_GameDB.GetGlobalConfigByAlias(B1GlobalConfigFNames.CanTriggerDeadAutoSwitch2PhysicMInQualityType, out var ConfigInfo))
				{
					num = ConfigInfo.IntValue;
				}
				if (BGW_GameDB.GetGlobalConfigByAlias(B1GlobalConfigFNames.DeadAutoSwitch2PhysicThresholds, out ConfigInfo))
				{
					thresholds = ConfigInfo.FloatValue;
				}
				if (DebugConfig.IsOpenBattleInfoTool)
				{
					BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.DeathDisp_Switch2Physic, $"<character>{Owner?.GetName()}</><action>全局表里定义最大可触发转物理效果的类型是 MinQuality = {(EUnitQualityType)num}</>");
				}
				FUStUnitBattleInfoExtendDesc unitBattleInfoExtendDesc2 = BGW_GameDB.GetUnitBattleInfoExtendDesc(GetFinalBattleInfoExtendID());
				if ((int)unitBattleInfoExtendDesc2.QualityType <= (int)(byte)num)
				{
					base.BUSEventCollection.Evt_PlayBeAttackedPhysAnimForDead.Invoke(DeadData.Cached_StiffLevel, DeadData.Cached_EffectInstReq, DeadData.Cached_PhysAnimImpulseScale);
					DeadData.AutoSwitchPhysicTimer = 0f;
					DeadData.WaitSwitchPhysicTime = BGUFuncLibBeAttackedAndUnitDeathDispCS.GetBestSwitchPhysicsPosInDeadMontage(uAnimMontage, thresholds, B1GlobalFNames.pelvis);
					if (DebugConfig.IsOpenBattleInfoTool)
					{
						BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.DeathDisp_Switch2Physic, $"<character>{Owner?.GetName()}</><action>满足条件，成功激活自动切换物理，自身Quality = {unitBattleInfoExtendDesc2.QualityType}，切换物理动画时间 = {DeadData.WaitSwitchPhysicTime}</>");
					}
				}
				else if (DebugConfig.IsOpenBattleInfoTool)
				{
					BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.DeathDisp_Switch2Physic, $"<character>{Owner?.GetName()}</><action>不满足条件，取消自动切换物理，自身Quality = {unitBattleInfoExtendDesc2.QualityType}</>");
				}
			}
			else if (DebugConfig.IsOpenBattleInfoTool)
			{
				BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.DeathDisp_Switch2Physic, "<character>" + Owner?.GetName() + "</><action>触发自动切物理失败，既没有全局打开EnableAutoSwitchPhysicInDeadAM，白名单表【UnitDeadSwitchToPhysicDesc】里也没有！</>");
			}
		}
		else if (DebugConfig.IsOpenBattleInfoTool)
		{
			BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.DeathDisp_Switch2Physic, "<character>" + Owner?.GetName() + "</><action>死亡动画里存在BANS_GSBlendPhysicForDeath，不会触发自动切换转物理逻辑！DeadAM = " + uAnimMontage.GetPathName() + "</>");
		}
		if (DebugConfig.IsOpenBattleInfoTool)
		{
			BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.DeathDisp_Switch2Physic, "<character>" + Owner?.GetName() + "</><action>===判断死亡自动切换物理结束===</>");
		}
		BGUFuncLibAnim.BGUActorTryPlayMontage(Owner, uAnimMontage, FName.None, reason);
		bUSEventCollection.Evt_SetTriggerMontage.Invoke(P1: true);
		if (beAttackedInfoDesc != null && StiffLevel >= beAttackedInfoDesc.MinHitIntoCliffLevel && uAnimMontage != null)
		{
			float num2 = 0f;
			FVector hitDir = FVector.ZeroVector;
			if (UBGUFuncLibSkill.BGUGetMontageHasRootMotion(uAnimMontage))
			{
				FTransform fTransform = UGSE_AnimFuncLib.Montage_GetBoneTransformCS(uAnimMontage, uAnimMontage.SequenceLength, B1GlobalFNames.root, FName.None, bExtractRootMotion: false);
				num2 = fTransform.GetLocation().Size2D();
				num2 *= 0.7f;
				hitDir = BGUFuncLibActorTransformCS.BGUGetActorTransform(Owner).TransformLocation(fTransform.Translation) - BGUFuncLibActorTransformCS.BGUGetActorLocation(Owner);
			}
			else if (!Attacker.IsNullOrDestroyed() && Attacker != Owner)
			{
				num2 = 300f;
				hitDir = BGUFuncLibActorTransformCS.BGUGetActorLocation(Owner) - BGUFuncLibActorTransformCS.BGUGetActorLocation(Attacker);
			}
			if (num2 != 0f)
			{
				base.BUSEventCollection.Evt_OnBeatBackStartCheck.Invoke(Attacker, hitDir, num2);
			}
		}
	}

	private void GetIsEnableAutoSwitchPhysic(out bool EnableAutoSwitchPhysic, out bool EnableWeaponAutoSwitchPhysic)
	{
		EnableAutoSwitchPhysic = false;
		EnableWeaponAutoSwitchPhysic = false;
		if (GSGameplayCVar.CVar_EnableAutoSwitchPhysicInDeadAM.GetValueInGameThread() == 1)
		{
			EnableAutoSwitchPhysic = true;
			EnableWeaponAutoSwitchPhysic = true;
			return;
		}
		FUStUnitDeadSwitchToPhysicDesc unitDeadSwitchToPhysicDesc = BGW_GameDB.GetUnitDeadSwitchToPhysicDesc(GetActorResID());
		if (unitDeadSwitchToPhysicDesc != null)
		{
			EnableAutoSwitchPhysic = unitDeadSwitchToPhysicDesc.DefaultEnableAutoSwitch == EGSYesNo.Yes;
			if (EnableAutoSwitchPhysic)
			{
				EnableWeaponAutoSwitchPhysic = true;
			}
			else
			{
				EnableWeaponAutoSwitchPhysic = unitDeadSwitchToPhysicDesc.DefaultEnableWeaponAutoSwitch == EGSYesNo.Yes;
			}
		}
	}

	private void SetDelayDestroyTime()
	{
		if (!(Owner != null) || !(Owner as BGUCharacterCS != null))
		{
			return;
		}
		int actorResID = GetActorResID();
		int deadInfoID = DeadData.GetDeadInfoID();
		bool flag = false;
		if (B1Global.GIsBossRushMode && BossRushBattleData.ModifyTableCollection.ModifyDeadDelayDestroyTime.TryGetValue(deadInfoID, out var value))
		{
			flag = true;
			DelayClearArmorTime = value;
			DelayDestroyActorTime = value;
		}
		if (!flag)
		{
			FUStUnitDeadDesc unitDeadDesc = BGW_GameDB.GetUnitDeadDesc(actorResID, deadInfoID);
			if (unitDeadDesc == null)
			{
				DelayClearArmorTime = 0f;
				DelayDestroyActorTime = 0f;
			}
			else
			{
				DelayClearArmorTime = unitDeadDesc.DelayDestroyActorTime;
				DelayDestroyActorTime = unitDeadDesc.DelayDestroyActorTime;
			}
		}
	}

	private void DestroyUnitOnly()
	{
		DestroyWeapon();
		if (Owner != null)
		{
			base.BUSEventCollection.Evt_SetCollisionResponseProperty.Invoke(EPropType.Capsule_CollisionResponseToChannels, new Dictionary<ECollisionChannel, ECollisionResponseType> { 
			{
				ECollisionChannel.ECC_Pawn,
				ECollisionResponseType.ECR_Ignore
			} });
			base.BUSEventCollection.Evt_SetBoolProperty.Invoke(EPropType.Actor_ActorHiddenInGame, Value: true);
			DelayDestroyActorTime = 0.1f;
		}
	}

	private void DeadForSuicide(BGWDataAsset_UnitDeathDispConfig NowUseUDDConfig, out bool bDestroyimmediately)
	{
		bDestroyimmediately = true;
		ACharacter aCharacter = Owner as ACharacter;
		if (aCharacter == null)
		{
			return;
		}
		BUS_GSEventCollection bUSEventCollection = base.BUSEventCollection;
		bUSEventCollection.Evt_UnitTryBreakSkill.Invoke("自杀死亡");
		aCharacter.StopAnimMontage(null);
		if (NowUseUDDConfig != null)
		{
			UAnimMontage suicideDeadMontage = NowUseUDDConfig.SuicideDeadMontage;
			if (suicideDeadMontage != null)
			{
				bDestroyimmediately = false;
				BGUFuncLibAnim.BGUActorTryPlayMontage(Owner, suicideDeadMontage, FName.None);
				bUSEventCollection.Evt_SetTriggerMontage.Invoke(P1: true);
			}
		}
	}

	private UAnimMontage GetDeadMontagePathByRule(int StiffLevel, EAttackerArea AttackerArea, EHitActionDir HitActionDir, int NowUseDeadInfoID, BGWDataAsset_UnitDeathDispConfig NowUseUDDConfig, in FNormalDeadAMInfo ValidNormalDeadAMInfo)
	{
		ACharacter aCharacter = Owner as ACharacter;
		if (aCharacter == null)
		{
			return null;
		}
		if (BGW_GameDB.GetUnitCommDesc(GetActorResID()) == null || NowUseUDDConfig == null)
		{
			return null;
		}
		UAnimMontage uAnimMontage = null;
		string unitResName = NowUseUDDConfig.UnitResName;
		string deadInfoIDStr = GetDeadInfoIDStr(NowUseDeadInfoID);
		string beAttackedAttackerAreaStr = BGUFuncLibBeAttackedAndUnitDeathDispCS.GetBeAttackedAttackerAreaStr(AttackerArea);
		string beAttackedActionDirStr = BGUFuncLibBeAttackedAndUnitDeathDispCS.GetBeAttackedActionDirStr(HitActionDir, AttackerArea);
		string text = $"AM_{unitResName}_die_dep{deadInfoIDStr}_sl{StiffLevel}_d{beAttackedAttackerAreaStr}_h{beAttackedActionDirStr}_nor";
		switch (ValidNormalDeadAMInfo.DeadEllipsisType)
		{
		case EDeadEllipsisType.NoAbnormalState:
			text = $"AM_{unitResName}_die_dep{deadInfoIDStr}_sl{StiffLevel}_d{beAttackedAttackerAreaStr}_h{beAttackedActionDirStr}";
			break;
		case EDeadEllipsisType.NoHitAction:
			text = $"AM_{unitResName}_die_dep{deadInfoIDStr}_sl{StiffLevel}_d{beAttackedAttackerAreaStr}";
			break;
		case EDeadEllipsisType.NoAttackerArea:
			text = $"AM_{unitResName}_die_dep{deadInfoIDStr}_sl{StiffLevel}_h{beAttackedActionDirStr}";
			break;
		case EDeadEllipsisType.BothNoAttackerAreaNHitAction:
			text = $"AM_{unitResName}_die_dep{deadInfoIDStr}_sl{StiffLevel}";
			break;
		case EDeadEllipsisType.NoGears:
			text = "AM_" + unitResName + "_die_dep" + deadInfoIDStr;
			break;
		case EDeadEllipsisType.NoDepot:
			text = "AM_" + unitResName + "_die";
			break;
		}
		int actorResID = GetActorResID();
		List<UAnimMontage> randomDeathDispAM = BGW_PreloadAssetMgr.Get(aCharacter).GetRandomDeathDispAM(actorResID, text);
		if (randomDeathDispAM != null && randomDeathDispAM.Count > 0)
		{
			uAnimMontage = randomDeathDispAM[UB1Util.GetRandomNumberInt(0, randomDeathDispAM.Count - 1)];
		}
		if (uAnimMontage == null)
		{
			if (DebugConfig.IsOpenBattleInfoTool)
			{
				BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.DeathDisp, "<character>" + Owner?.GetName() + "</><action>找不到死亡动画！！！麻烦确认资源是否正确。\n路径是 = </><effect>AnimMontage'" + NowUseUDDConfig.NormalDeadAMPath + "/" + text + "." + text + "'</>");
			}
			if (ValidNormalDeadAMInfo.DeadEllipsisType == EDeadEllipsisType.None)
			{
				List<UAnimMontage> list = new List<UAnimMontage>();
				string[] array = new string[6] { "f", "b", "l", "r", "u", "d" };
				List<string> list2 = new List<string> { StiffLevel.ToString() };
				if (NowUseUDDConfig.NormalDeadAMInfoList.Count > 0)
				{
					list2.Add(NowUseUDDConfig.NormalDeadAMInfoList[0].StiffLevelID.ToString());
				}
				foreach (string item in list2)
				{
					string[] array2 = array;
					foreach (string text2 in array2)
					{
						text = "AM_" + unitResName + "_die_dep" + deadInfoIDStr + "_sl" + item + "_d" + beAttackedAttackerAreaStr + "_h" + text2 + "_nor";
						randomDeathDispAM = BGW_PreloadAssetMgr.Get(aCharacter).GetRandomDeathDispAM(actorResID, text);
						foreach (UAnimMontage item2 in randomDeathDispAM)
						{
							list.Add(item2);
						}
					}
					if (list.Count > 0 || list.Count > 0)
					{
						break;
					}
				}
				if (list.Count > 0)
				{
					int randomNumberInt = UB1Util.GetRandomNumberInt(0, list.Count - 1);
					uAnimMontage = list[randomNumberInt];
					if (DebugConfig.IsOpenBattleInfoTool)
					{
						BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.DeathDisp, "<character>" + Owner?.GetName() + "</><action>找到了</><effect>" + uAnimMontage.GetPathName() + "</><action>动画作为替代!!!</>");
					}
				}
				else if (DebugConfig.IsOpenBattleInfoTool)
				{
					BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.DeathDisp, $"<character>{Owner?.GetName()}</><action>找不到任何动画作为替代, 麻烦检查一下配置, DeadInfoID = </><effect>{NowUseDeadInfoID}</><action>, StiffLevel = </><effect>{StiffLevel}</><action>, AttackerArea = </><effect>{AttackerArea}</><action>, HitDir = </><effect>{beAttackedActionDirStr}</>");
				}
			}
		}
		if (DebugConfig.IsOpenBattleInfoTool && uAnimMontage != null)
		{
			BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.DeathDisp, "<character>" + Owner?.GetName() + "</><action>找到了匹配的死亡动画!!! \n路径是：</><effect>" + uAnimMontage.GetPathName() + "</>");
		}
		return uAnimMontage;
	}

	private string GetDeadInfoIDStr(int DeadInfoID)
	{
		int num = DeadInfoID % 100;
		if (num >= 10)
		{
			return num.ToString();
		}
		return $"0{num}";
	}

	private BGWDataAsset_UnitDeathDispConfig GetNowUseUDDConfig(AActor Owner)
	{
		BGWDataAsset_UnitDeathDispConfig bGWDataAsset_UnitDeathDispConfig = null;
		int actorResID = GetActorResID();
		int deadInfoID = DeadData.GetDeadInfoID();
		FUStUnitDeadDesc unitDeadDesc = BGW_GameDB.GetUnitDeadDesc(actorResID, deadInfoID);
		if (unitDeadDesc != null)
		{
			bGWDataAsset_UnitDeathDispConfig = BGW_PreloadAssetMgr.Get(Owner).GetUDDConfig(GetActorResID(), GetFinalBattleInfoExtendID(), GuidData.GetFinalGuid(), unitDeadDesc.DeathDispConfigPath);
		}
		if (DebugConfig.IsOpenBattleInfoTool && bGWDataAsset_UnitDeathDispConfig == null)
		{
			BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.DeathDisp, $"<character>{Owner?.GetName()}</><action>找不到UDDC！！！ 麻烦确认资源是否正确！！！ResID = </><effect>{actorResID}</><action>，DeadInfoID = </><effect>{deadInfoID}</>");
		}
		return bGWDataAsset_UnitDeathDispConfig;
	}

	private bool CheckFallDyingState(EDeadReason DeadReason, AActor Attacker, int NowUseDeadInfoID, int StiffLevel, EHitActionDir HitActionDir, EAttackerArea AttackerArea, BGWDataAsset_UnitDeathDispConfig NowUseUDDConfig, Dictionary<EAbnormalStateType, int> FinalAbnormalStateInfo, bool IsDotDmg)
	{
		ABGUCharacter aBGUCharacter = Owner as ABGUCharacter;
		if (Owner == null || aBGUCharacter == null)
		{
			return false;
		}
		if (UGSE_EngineFuncLib.IsStandAlone(aBGUCharacter.World))
		{
			return false;
		}
		if (!aBGUCharacter.IsPlayerControlled())
		{
			return false;
		}
		DeadForSkillDamage(DeadReason, null, NowUseDeadInfoID, StiffLevel, HitActionDir, AttackerArea, NowUseUDDConfig, null, default(FEffectInstReq), FinalAbnormalStateInfo, IsDotDmg);
		SetDelayDestroyTime();
		base.BUSEventCollection.Evt_TriggerFallDying.Invoke(Attacker);
		return true;
	}

	private bool CheckIsPlayerInTransState()
	{
		ABGUCharacter aBGUCharacter = Owner as ABGUCharacter;
		APawn aPawn = Owner as APawn;
		if (Owner != null && aBGUCharacter.IsPlayerControlled() && aPawn != null)
		{
			APlayerState playerState = aPawn.PlayerState;
			if (playerState != null)
			{
				IBPC_TransData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBPC_TransData, BPC_TransData>(playerState);
				IBPC_PlayerTagData readOnlyData2 = BGU_DataUtil.GetReadOnlyData<IBPC_PlayerTagData, BPC_PlayerTagData>(playerState);
				if (readOnlyData != null && readOnlyData2.HasTag(EBGPPlayerTag.Transforming))
				{
					FUStPlayerTransUnitConfDesc fUStPlayerTransUnitConfDesc = BGW_GameDB.GetFUStPlayerTransUnitConfDesc((aPawn as BGUCharacterCS).GetResID());
					if (readOnlyData.IsPlotTrans())
					{
						return false;
					}
					if (fUStPlayerTransUnitConfDesc != null && fUStPlayerTransUnitConfDesc.DeadDontTransback == 0)
					{
						BPS_EventCollectionCS.Get(playerState)?.Evt_TriggerPlayerTransEnd.Invoke(EPlayerTransEndType.HpTransBack, default(PlayerTransParam));
						return true;
					}
				}
			}
		}
		return false;
	}

	private void DestroyWeapon()
	{
		if (!(Owner != null) || Owner.IsPendingKill)
		{
			return;
		}
		int num = BGUFunctionLibraryCS.BGUGetWeaponNum(Owner);
		for (int i = 0; i < num; i++)
		{
			BGUWeaponBase bGUWeaponBase = BGUFunctionLibraryCS.BGUGetWeaponByIndex(Owner, i) as BGUWeaponBase;
			if (bGUWeaponBase != null)
			{
				BGU_UnrealWorldUtil.DestroyActor(bGUWeaponBase);
			}
		}
	}

	private void OnSetDeadInfoID(int DeadID)
	{
		DeadData.SetDeadInfoID(DeadID);
	}

	private void OnResetDeadInfoID()
	{
		BGUCharacterCS bGUCharacterCS = Owner as BGUCharacterCS;
		if (!(bGUCharacterCS == null))
		{
			FUStUnitCommDesc unitCommDesc = BGW_GameDB.GetUnitCommDesc(bGUCharacterCS.GetResID());
			if (unitCommDesc != null)
			{
				DeadData.SetDeadInfoID(unitCommDesc.DeadInfoID);
			}
		}
	}

	private void OnGMUnitSuicide()
	{
		if (!UnitStateData.HasState(EBGUUnitState.Dead) && !SimpleStateData.HasSimpleState(EBGUSimpleState.PendingDeathInAnimationSyncing))
		{
			if (PlayerAttrCon != null)
			{
				float floatValue = PlayerAttrCon.GetFloatValue(EBGUAttrFloat.Hp);
				base.BUSEventCollection.Evt_IncreaseAttrFloat.Invoke(EBGUAttrFloat.Hp, 0f - floatValue);
			}
			OnUnitDead(Owner, EDeadReason.Suicide);
		}
	}

	private void Tick_SwitchPhysicInDeadAM(float DeltaTime)
	{
		GetIsEnableAutoSwitchPhysic(out var EnableAutoSwitchPhysic, out var EnableWeaponAutoSwitchPhysic);
		if ((EnableAutoSwitchPhysic || EnableWeaponAutoSwitchPhysic) && DeadData.InDeadAM && DeadData.WaitSwitchPhysicTime >= 0f && !DeadData.AlreadySwitchPhysic)
		{
			DeadData.AutoSwitchPhysicTimer += DeltaTime;
			if (DeadData.AutoSwitchPhysicTimer > DeadData.WaitSwitchPhysicTime)
			{
				OnTriggerSwitch2Physic(EnableAutoSwitchPhysic, EnableWeaponAutoSwitchPhysic);
			}
		}
	}

	private void OnTriggerSwitch2Physic(bool EnableAutoSwitchPhysic, bool EnableWeaponAutoSwitchPhysic)
	{
		if (!DeadData.AlreadySwitchPhysic)
		{
			if (DebugConfig.IsOpenBattleInfoTool)
			{
				BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.DeathDisp_Switch2Physic, $"<character>{Owner?.GetName()}</><action>触发死亡物理切换！EnableAutoSwitchPhysic = {EnableAutoSwitchPhysic}，EnableWeaponAutoSwitchPhysic = {EnableWeaponAutoSwitchPhysic}</>");
			}
			DeadData.AlreadySwitchPhysic = true;
			if (EnableAutoSwitchPhysic)
			{
				base.BUSEventCollection.Evt_ActivatePhysicBlendForDeath.Invoke(new List<FPhysicBlendInfoForDeath> { PhysicBlendInfoForDeath }, 0f, CallDissolveWhenPhysicsFinish: false);
			}
			if (EnableWeaponAutoSwitchPhysic)
			{
				base.BUSEventCollection?.Evt_DetachAllWeaponForDead.Invoke(WEAPON_DETACH_DELAY_DESTROY_TIME);
			}
		}
	}

	private void Tick_DeadAMWaitingBeAttackedAM()
	{
		if (DeadData.DeadAMWaitingBeAttackedAMInfo.bInDeadAMWaitingBeAttackedAM && SimpleStateData.HasSimpleState(EBGUSimpleState.CanBlendToDeadAM))
		{
			if (DebugConfig.IsOpenBattleInfoTool)
			{
				BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.TickDead2Physic, "<character>" + Owner.GetName() + "</><effect>死亡接续受击动画开始融入死亡动画：</><action>" + DeadData.DeadAMWaitingBeAttackedAMInfo.DeadAMCached?.GetPathName() + "</>");
			}
			DeadData.InDeadAM = true;
			BUS_GSEventCollection bUSEventCollection = base.BUSEventCollection;
			BGUFuncLibAnim.BGUActorTryPlayMontage(Reason: DeadData.DeadAMWaitingBeAttackedAMInfo.bTriggerWithLifeSavingHair ? EMontageBindReason.LifeSavingHairPrepare : EMontageBindReason.Default, Owner: Owner, Montage: DeadData.DeadAMWaitingBeAttackedAMInfo.DeadAMCached, StartSectionName: B1GlobalFNames.Dead_ing);
			bUSEventCollection?.Evt_SetTriggerMontage.Invoke(P1: true);
			DeadData.DeadAMWaitingBeAttackedAMInfo.bInDeadAMWaitingBeAttackedAM = false;
			DeadData.DeadAMWaitingBeAttackedAMInfo.bTriggerWithLifeSavingHair = false;
		}
	}

	private void OnThrowUpDeadUnit()
	{
		if (DeadData.ThrowUpTimer >= 0f)
		{
			return;
		}
		int actorResID = GetActorResID();
		int deadInfoID = DeadData.GetDeadInfoID();
		FUStUnitDeadDesc unitDeadDesc = BGW_GameDB.GetUnitDeadDesc(actorResID, deadInfoID);
		if (unitDeadDesc == null)
		{
			return;
		}
		UCurveFloat uCurveFloat = BGW_PreloadAssetMgr.Get(Owner).TryGetCachedResourceObj<UCurveFloat>(unitDeadDesc.ThrowUpCurve, ELoadResourceType.SyncLoadAndCache);
		if (!(uCurveFloat == null))
		{
			base.BUSEventCollection.Evt_SetPhysAnimSetting.Invoke(EPhysAnimType.ThrowUpDeath);
			if (DeadData.MovementModeHandleID == 0)
			{
				base.BUSEventCollection.Evt_SetEnumProperty.Invoke(EPropType.Movement_MovementMode, 5, 0u, 0u, bSetDefaultProperty: false, "OnThrowUpDeadUnit");
				DeadData.MovementModeHandleID = PropMgrData.GetLastHandleID();
			}
			else
			{
				base.BUSEventCollection.Evt_SetEnumProperty.Invoke(EPropType.Movement_MovementMode, 5, DeadData.MovementModeHandleID, 0u, bSetDefaultProperty: false, "OnThrowUpDeadUnit");
			}
			if (DeadData.CollisionEnabledHandleID == 0)
			{
				base.BUSEventCollection.Evt_SetEnumProperty.Invoke(EPropType.Capsule_CollisionEnabled, 0);
				DeadData.CollisionEnabledHandleID = PropMgrData.GetLastHandleID();
			}
			else
			{
				base.BUSEventCollection.Evt_SetEnumProperty.Invoke(EPropType.Capsule_CollisionEnabled, 0, DeadData.CollisionEnabledHandleID);
			}
			uCurveFloat.GetTimeRange(out var _, out var MaxTime);
			DeadData.ThrowUpMaxTime = MaxTime;
			DeadData.ThrowUpTimer = 0f;
			DeadData.ThrowUpCurve = uCurveFloat;
		}
	}

	private void OnTriggerDeadDissolve()
	{
		if (DebugConfig.DisableDissolveDisplay || !UnitStateData.HasState(EBGUUnitState.Dead))
		{
			return;
		}
		if (DeadContinueAbnormalDispType != EAbnormalStateType.None)
		{
			AbnormalStateHandlers.PlayDeadLoopFX(DeadContinueAbnormalDispType, DeadContinueAbnormalAttackerDispID, bEnd: true);
			AbnormalStateHandlers.PlayDeadDisapearFX(DeadContinueAbnormalDispType, DeadContinueAbnormalAttackerDispID);
			DeadContinueAbnormalDispType = EAbnormalStateType.None;
		}
		if (DissolveDispDBC != null)
		{
			if (!OwnerAsCharacterCS.IsPlayerCharacterCS())
			{
				OwnerAsCharacterCS.Mesh.SetCastHybridRayTracingShadow(bNewHybridRayTracingShadow: true);
			}
			base.BUSEventCollection.Evt_RequestSpawnFXByDispConfigDA.Invoke(DissolveDispDBC, out var _);
			DissolveDispDBC = null;
		}
	}

	private void UpdateThrowUp()
	{
		if (DeadData.ThrowUpCurve == null)
		{
			DeadData.ThrowUpMaxTime = -1f;
			DeadData.ThrowUpTimer = -1f;
			return;
		}
		float floatValue = DeadData.ThrowUpCurve.GetFloatValue(DeadData.ThrowUpTimer);
		FVector impulse = FVector.UpVector * floatValue;
		if (DeadData.Attacker != null)
		{
			FVector fVector = ((OwnerAsCharacterCS != null && OwnerAsCharacterCS.Mesh != null) ? BGUFuncLibComponentCS.BGUGetSocketLocation(OwnerAsCharacterCS.Mesh, ref Bip) : BGUFuncLibActorTransformCS.BGUGetActorLocation(OwnerAsCharacterCS));
			FVector fVector2 = BGUFuncLibActorTransformCS.BGUGetActorLocation(DeadData.Attacker) - fVector;
			fVector2.Z = 0f;
			float num = fVector2.Size();
			FVector fVector3 = -FVector.CrossProduct(fVector2.GetSafeNormal2D(), FVector.UpVector).GetSafeNormal();
			float num2 = 500f / num;
			impulse += (fVector2.GetSafeNormal() * 300.0 + fVector3 * 100.0) * num2;
		}
		OwnerAsCharacterCS?.Mesh?.AddImpulseToAllBodiesBelow(impulse, B1GlobalFNames.root, bVelChange: true, bIncludeSelf: false);
		if (DeadData.ThrowUpTimer >= DeadData.ThrowUpMaxTime)
		{
			OnThrowUpEnd();
		}
	}

	private void OnThrowUpEnd()
	{
		DeadData.ThrowUpMaxTime = -1f;
		DeadData.ThrowUpTimer = -1f;
		DeadData.ThrowUpCurve = null;
		if (OwnerAsCharacterCS != null && OwnerAsCharacterCS.Mesh != null)
		{
			FVector newLocation = BGUFuncLibComponentCS.BGUGetSocketLocation(OwnerAsCharacterCS.Mesh, ref Bip);
			BGUFuncLibActorTransformCS.BGUSetActorLocation(Owner, newLocation, bSweep: false, bTeleport: false);
		}
	}
}
