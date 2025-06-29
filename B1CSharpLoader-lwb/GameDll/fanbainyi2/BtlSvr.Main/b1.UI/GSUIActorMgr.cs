using System;
using System.Collections.Generic;
using b1.EventDelDefine;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.UI;

public class GSUIActorMgr : GameInstanceSystemBase
{
	public class EvtClass
	{
		public Del_UnitCastSkillSuccess Evt_UnitCastSkillSuccess;

		public Del_UnitCastSkillFail Evt_UnitCastSkillFail;

		public Del_UnitTriggerDead Evt_UnitTriggerDead;

		public Del_Void Evt_Camera_SwitchHideUILockPoint;

		public Del_Void Evt_ShootUIChangeScale;

		public Del_Void_Bool Evt_ShootUIChangeColor;

		public Del_AddBuffNotify Evt_AddBuffNotify;

		public Del_Void_IntInt Evt_RemoveBuffNotify;

		public Del_Void_Actor Evt_TriggerBreakInteract;

		public Del_Void_Actor Evt_OnPlayerBreakInteract;

		public Del_Void_Actor Evt_TriggerFinishInteract;

		public Del_Void_Int Evt_SnapShotRecoverSkillCD;

		public Del_Void Evt_ToggleCloudMove;

		public Del_Void_Bool Evt_IsCtrlPlayer;

		public Del_Void_Actor Evt_TriggerFallDying;

		public Del_Void Evt_TriggerFallDyingToUI;

		public Del_Void_ActorActor Evt_TriggerBeSaving;

		public Del_Void_ActorActor Evt_TriggerBreakBeSaving;

		public Del_Void_ActorActor Evt_TriggerFinishBeSaving;

		public Del_Void_Actor Evt_PlayerCollectedV2;

		public Del_Void_Bool Evt_TriggerShowUnitPartUI;

		public Del_Void_Bool Evt_PartUIValueChange;

		public Del_Void_Float Evt_GM_SwitchHideUILockPoint;

		public Del_Void_Int Evt_SwitchWeaponPoseByType;

		public Del_Void_RepPlayerLoc Evt_RepPlayerLoc;

		public Del_Void_IntInt Evt_OnlineChallengeBeginToUI;

		public Del_Void_Int Evt_OnlineChallengeEndToUI;

		public Del_UIShowMapTips Evt_UI_ShowMapTips;

		public Del_Void_Int Evt_TaskByIDTrigger;

		public Del_Void Evt_RebornInNearestRebirthPoint;

		public Del_Void_BoolBoolInt Evt_InputSwitchHero;

		public Del_EnterInteractActiveArea Evt_EnterActiveArea;

		public Del_EnterInteractActiveArea Evt_LeaveActiveArea;

		public Del_Void_Int Evt_EnterUninteractiveArea;

		public Del_Void_Actor Evt_OpenToolNpcUI;

		public Del_Void_Bool Evt_ActiveTPSReticle;

		public Del_Void_Actor Evt_PlayerBeInteractInput;

		public Del_Void_Actor Evt_PlayerBreakInteractInput;

		public Del_Void_Actor Evt_PlayerFinishInteractInput;

		public Del_Void_StringList Evt_TriggerInputCombie;

		public Del_Void_StringList Evt_UnTriggerRealease;

		public Del_Void_Int Evt_SwitchDefaultItem;

		public Del_Void_Int Evt_SwitchDefaultSpell;

		public Del_Void_Int Evt_TriggerUseDefaultShortcutItem;

		public Del_Void_Int Evt_TriggerUseDefaultShortcutSpell;

		public Del_Void_Bool Evt_ActiveNoSeqUI;

		public Del_Void_FText Evt_TriggerInteactItemLack;

		public Del_Void Evt_SwitchWeaponPose;

		public Del_Void Evt_StartInteract;

		public Del_Void Evt_FinishMedicineTalkAnim;

		public Del_Void_Bool Evt_HoldingQTEInteract;

		public Del_Void Evt_FinishSeedSubmitAnim;

		public Del_Void_Actor Evt_EnterInteractiveArea;

		public Del_Void_Actor Evt_LeaveInteractiveArea;

		public Del_Void Evt_OnLeaveFight;

		public Del_Void_Actor Evt_OnEnterFight;

		public Del_UnitRebirth Evt_AfterUnitRebirth;

		public Del_HandleAbnormal Evt_HandleAbnormal;

		public Del_AbnormalRemoved Evt_AbnormalRemoved;

		public Del_OnTrigerAbnormalFinalEffect Evt_OnTrigerAbnormalFinalEffect;

		public Del_Void Evt_OnIncreasePELevelNotify;

		public Del_Void Evt_OnDecreasePELevelNotify;

		public Del_Void_Int Evt_OnMaxPELevelHasChangedNotify;

		public Del_Void Evt_OnPEConfigChange;

		public void RegistEvent(AActor Actor)
		{
			if (!Actor.IsNullOrDestroyed())
			{
				BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Actor);
				if (!(bUS_GSEventCollection == null))
				{
					bUS_GSEventCollection.Evt_UnitCastSkillSuccess += new Del_UnitCastSkillSuccess(OnEvt_UnitCastSkillSuccess);
					bUS_GSEventCollection.Evt_UnitCastSkillFail += new Del_UnitCastSkillFail(OnEvt_UnitCastSkillFail);
					bUS_GSEventCollection.Evt_UnitTriggerDead += new Del_UnitTriggerDead(OnEvt_UnitTriggerDead);
					bUS_GSEventCollection.Evt_Camera_SwitchHideUILockPoint += new Del_Void(OnEvt_Camera_SwitchHideUILockPoint);
					bUS_GSEventCollection.Evt_ShootUIChangeScale += new Del_Void(OnEvt_ShootUIChangeScale);
					bUS_GSEventCollection.Evt_ShootUIChangeColor += new Del_Void_Bool(OnEvt_ShootUIChangeColor);
					bUS_GSEventCollection.Evt_AddBuffNotify += new Del_AddBuffNotify(OnEvt_AddBuffNotify);
					bUS_GSEventCollection.Evt_RemoveBuffNotify += new Del_Void_IntInt(OnEvt_RemoveBuffNotify);
					bUS_GSEventCollection.Evt_TriggerBreakInteract += new Del_Void_Actor(OnEvt_TriggerBreakInteract);
					bUS_GSEventCollection.Evt_OnPlayerBreakInteract += new Del_Void_Actor(OnEvt_OnPlayerBreakInteract);
					bUS_GSEventCollection.Evt_TriggerFinishInteract += new Del_Void_Actor(OnEvt_TriggerFinishInteract);
					bUS_GSEventCollection.Evt_SnapShotRecoverSkillCD += new Del_Void_Int(OnEvt_SnapShotRecoverSkillCD);
					bUS_GSEventCollection.Evt_ToggleCloudMove += new Del_Void(OnEvt_ToggleCloudMove);
					bUS_GSEventCollection.Evt_IsCtrlPlayer += new Del_Void_Bool(OnEvt_IsCtrlPlayer);
					bUS_GSEventCollection.Evt_TriggerFallDying += new Del_Void_Actor(OnEvt_TriggerFallDying);
					bUS_GSEventCollection.Evt_TriggerFallDyingToUI += new Del_Void(OnEvt_TriggerFallDyingToUI);
					bUS_GSEventCollection.Evt_TriggerBeSaving += new Del_Void_ActorActor(OnEvt_TriggerBeSaving);
					bUS_GSEventCollection.Evt_TriggerBreakBeSaving += new Del_Void_ActorActor(OnEvt_TriggerBreakBeSaving);
					bUS_GSEventCollection.Evt_TriggerFinishBeSaving += new Del_Void_ActorActor(OnEvt_TriggerFinishBeSaving);
					bUS_GSEventCollection.Evt_PlayerCollectedV2 += new Del_Void_Actor(OnEvt_PlayerCollectedV2);
					bUS_GSEventCollection.Evt_TriggerShowUnitPartUI += new Del_Void_Bool(OnEvt_TriggerShowUnitPartUI);
					bUS_GSEventCollection.Evt_PartUIValueChange += new Del_Void_Bool(OnEvt_PartUIValueChange);
					bUS_GSEventCollection.Evt_GM_SwitchHideUILockPoint += new Del_Void_Float(OnEvt_GM_SwitchHideUILockPoint);
					bUS_GSEventCollection.Evt_SwitchWeaponPoseByType += new Del_Void_Int(OnEvt_SwitchWeaponPoseByType);
					bUS_GSEventCollection.Evt_RepPlayerLoc += new Del_Void_RepPlayerLoc(OnEvt_RepPlayerLoc);
					bUS_GSEventCollection.Evt_OnlineChallengeBeginToUI += new Del_Void_IntInt(OnEvt_OnlineChallengeBeginToUI);
					bUS_GSEventCollection.Evt_OnlineChallengeEndToUI += new Del_Void_Int(OnEvt_OnlineChallengeEndToUI);
					bUS_GSEventCollection.Evt_UI_ShowMapTips += new Del_UIShowMapTips(OnEvt_UI_ShowMapTips);
					bUS_GSEventCollection.Evt_TaskByIDTrigger += new Del_Void_Int(OnEvt_TaskByIDTrigger);
					bUS_GSEventCollection.Evt_RebornInNearestRebirthPoint += new Del_Void(OnEvt_RebornInNearestRebirthPoint);
					bUS_GSEventCollection.Evt_InputSwitchHero += new Del_Void_BoolBoolInt(OnEvt_InputSwitchHero);
					bUS_GSEventCollection.Evt_EnterActiveArea += new Del_EnterInteractActiveArea(OnEvt_EnterActiveArea);
					bUS_GSEventCollection.Evt_LeaveActiveArea += new Del_EnterInteractActiveArea(OnEvt_LeaveActiveArea);
					bUS_GSEventCollection.Evt_EnterUninteractiveArea += new Del_Void_Int(OnEvt_EnterUninteractiveArea);
					bUS_GSEventCollection.Evt_OpenToolNpcUI += new Del_Void_Actor(OnEvt_OpenToolNpcUI);
					bUS_GSEventCollection.Evt_ActiveTPSReticle += new Del_Void_Bool(OnEvt_ActiveTPSReticle);
					bUS_GSEventCollection.Evt_PlayerBeInteractInput += new Del_Void_Actor(OnEvt_PlayerBeInteractInput);
					bUS_GSEventCollection.Evt_PlayerBreakInteractInput += new Del_Void_Actor(OnEvt_PlayerBreakInteractInput);
					bUS_GSEventCollection.Evt_PlayerFinishInteractInput += new Del_Void_Actor(OnEvt_PlayerFinishInteractInput);
					bUS_GSEventCollection.Evt_TriggerInputCombie += new Del_Void_StringList(OnEvt_TriggerInputCombie);
					bUS_GSEventCollection.Evt_UnTriggerRealease += new Del_Void_StringList(OnEvt_UnTriggerRealease);
					bUS_GSEventCollection.Evt_SwitchDefaultItem += new Del_Void_Int(OnEvt_SwitchDefaultItem);
					bUS_GSEventCollection.Evt_SwitchDefaultSpell += new Del_Void_Int(OnEvt_SwitchDefaultSpell);
					bUS_GSEventCollection.Evt_TriggerUseDefaultShortcutItem += new Del_Void_Int(OnEvt_TriggerUseDefaultShortcutItem);
					bUS_GSEventCollection.Evt_TriggerUseDefaultShortcutSpell += new Del_Void_Int(OnEvt_TriggerUseDefaultShortcutSpell);
					bUS_GSEventCollection.Evt_ActiveNoSeqUI += new Del_Void_Bool(OnEvt_ActiveNoSeqUI);
					bUS_GSEventCollection.Evt_TriggerInteactItemLack += new Del_Void_FText(OnEvt_TriggerInteactItemLack);
					bUS_GSEventCollection.Evt_SwitchWeaponPose += new Del_Void(OnEvt_SwitchWeaponPose);
					bUS_GSEventCollection.Evt_StartInteract += new Del_Void(OnEvt_StartInteract);
					bUS_GSEventCollection.Evt_FinishMedicineTalkAnim += new Del_Void(OnEvt_FinishMedicineTalkAnim);
					bUS_GSEventCollection.Evt_HoldingQTEInteract += new Del_Void_Bool(OnEvt_HoldingQTEInteract);
					bUS_GSEventCollection.Evt_FinishSeedSubmitAnim += new Del_Void(OnEvt_FinishSeedSubmitAnim);
					bUS_GSEventCollection.Evt_EnterInteractiveArea += new Del_Void_Actor(OnEvt_EnterInteractiveArea);
					bUS_GSEventCollection.Evt_LeaveInteractiveArea += new Del_Void_Actor(OnEvt_LeaveInteractiveArea);
					bUS_GSEventCollection.Evt_OnLeaveFight += new Del_Void(OnEvt_OnLeaveFight);
					bUS_GSEventCollection.Evt_OnEnterFight += new Del_Void_Actor(OnEvt_OnEnterFight);
					bUS_GSEventCollection.Evt_AfterUnitRebirth += new Del_UnitRebirth(OnEvt_AfterUnitRebirth);
					bUS_GSEventCollection.Evt_HandleAbnormal += new Del_HandleAbnormal(OnEvt_HandleAbnormal);
					bUS_GSEventCollection.Evt_AbnormalRemoved += new Del_AbnormalRemoved(OnEvt_AbnormalRemoved);
					bUS_GSEventCollection.Evt_OnTrigerAbnormalFinalEffect += new Del_OnTrigerAbnormalFinalEffect(OnEvt_OnTrigerAbnormalFinalEffect);
					bUS_GSEventCollection.Evt_OnIncreasePELevelNotify += new Del_Void(OnEvt_OnIncreasePELevelNotify);
					bUS_GSEventCollection.Evt_OnDecreasePELevelNotify += new Del_Void(OnEvt_OnDecreasePELevelNotify);
					bUS_GSEventCollection.Evt_OnMaxPELevelHasChangedNotify += new Del_Void_Int(OnEvt_OnMaxPELevelHasChangedNotify);
					bUS_GSEventCollection.Evt_OnPEConfigChange += new Del_Void(OnEvt_OnPEConfigChange);
				}
			}
		}

		public void UnregistEvent(AActor Actor)
		{
			if (!Actor.IsNullOrDestroyed())
			{
				BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Actor);
				if (!(bUS_GSEventCollection == null))
				{
					bUS_GSEventCollection.Evt_UnitCastSkillSuccess -= new Del_UnitCastSkillSuccess(OnEvt_UnitCastSkillSuccess);
					bUS_GSEventCollection.Evt_UnitCastSkillFail -= new Del_UnitCastSkillFail(OnEvt_UnitCastSkillFail);
					bUS_GSEventCollection.Evt_UnitTriggerDead -= new Del_UnitTriggerDead(OnEvt_UnitTriggerDead);
					bUS_GSEventCollection.Evt_Camera_SwitchHideUILockPoint -= new Del_Void(OnEvt_Camera_SwitchHideUILockPoint);
					bUS_GSEventCollection.Evt_ShootUIChangeScale -= new Del_Void(OnEvt_ShootUIChangeScale);
					bUS_GSEventCollection.Evt_ShootUIChangeColor -= new Del_Void_Bool(OnEvt_ShootUIChangeColor);
					bUS_GSEventCollection.Evt_AddBuffNotify -= new Del_AddBuffNotify(OnEvt_AddBuffNotify);
					bUS_GSEventCollection.Evt_RemoveBuffNotify -= new Del_Void_IntInt(OnEvt_RemoveBuffNotify);
					bUS_GSEventCollection.Evt_TriggerBreakInteract -= new Del_Void_Actor(OnEvt_TriggerBreakInteract);
					bUS_GSEventCollection.Evt_OnPlayerBreakInteract -= new Del_Void_Actor(OnEvt_OnPlayerBreakInteract);
					bUS_GSEventCollection.Evt_TriggerFinishInteract -= new Del_Void_Actor(OnEvt_TriggerFinishInteract);
					bUS_GSEventCollection.Evt_SnapShotRecoverSkillCD -= new Del_Void_Int(OnEvt_SnapShotRecoverSkillCD);
					bUS_GSEventCollection.Evt_ToggleCloudMove -= new Del_Void(OnEvt_ToggleCloudMove);
					bUS_GSEventCollection.Evt_IsCtrlPlayer -= new Del_Void_Bool(OnEvt_IsCtrlPlayer);
					bUS_GSEventCollection.Evt_TriggerFallDying -= new Del_Void_Actor(OnEvt_TriggerFallDying);
					bUS_GSEventCollection.Evt_TriggerFallDyingToUI -= new Del_Void(OnEvt_TriggerFallDyingToUI);
					bUS_GSEventCollection.Evt_TriggerBeSaving -= new Del_Void_ActorActor(OnEvt_TriggerBeSaving);
					bUS_GSEventCollection.Evt_TriggerBreakBeSaving -= new Del_Void_ActorActor(OnEvt_TriggerBreakBeSaving);
					bUS_GSEventCollection.Evt_TriggerFinishBeSaving -= new Del_Void_ActorActor(OnEvt_TriggerFinishBeSaving);
					bUS_GSEventCollection.Evt_PlayerCollectedV2 -= new Del_Void_Actor(OnEvt_PlayerCollectedV2);
					bUS_GSEventCollection.Evt_TriggerShowUnitPartUI -= new Del_Void_Bool(OnEvt_TriggerShowUnitPartUI);
					bUS_GSEventCollection.Evt_PartUIValueChange -= new Del_Void_Bool(OnEvt_PartUIValueChange);
					bUS_GSEventCollection.Evt_GM_SwitchHideUILockPoint -= new Del_Void_Float(OnEvt_GM_SwitchHideUILockPoint);
					bUS_GSEventCollection.Evt_SwitchWeaponPoseByType -= new Del_Void_Int(OnEvt_SwitchWeaponPoseByType);
					bUS_GSEventCollection.Evt_RepPlayerLoc -= new Del_Void_RepPlayerLoc(OnEvt_RepPlayerLoc);
					bUS_GSEventCollection.Evt_OnlineChallengeBeginToUI -= new Del_Void_IntInt(OnEvt_OnlineChallengeBeginToUI);
					bUS_GSEventCollection.Evt_OnlineChallengeEndToUI -= new Del_Void_Int(OnEvt_OnlineChallengeEndToUI);
					bUS_GSEventCollection.Evt_UI_ShowMapTips -= new Del_UIShowMapTips(OnEvt_UI_ShowMapTips);
					bUS_GSEventCollection.Evt_TaskByIDTrigger -= new Del_Void_Int(OnEvt_TaskByIDTrigger);
					bUS_GSEventCollection.Evt_RebornInNearestRebirthPoint -= new Del_Void(OnEvt_RebornInNearestRebirthPoint);
					bUS_GSEventCollection.Evt_InputSwitchHero -= new Del_Void_BoolBoolInt(OnEvt_InputSwitchHero);
					bUS_GSEventCollection.Evt_EnterActiveArea -= new Del_EnterInteractActiveArea(OnEvt_EnterActiveArea);
					bUS_GSEventCollection.Evt_LeaveActiveArea -= new Del_EnterInteractActiveArea(OnEvt_LeaveActiveArea);
					bUS_GSEventCollection.Evt_EnterUninteractiveArea -= new Del_Void_Int(OnEvt_EnterUninteractiveArea);
					bUS_GSEventCollection.Evt_OpenToolNpcUI -= new Del_Void_Actor(OnEvt_OpenToolNpcUI);
					bUS_GSEventCollection.Evt_ActiveTPSReticle -= new Del_Void_Bool(OnEvt_ActiveTPSReticle);
					bUS_GSEventCollection.Evt_PlayerBeInteractInput -= new Del_Void_Actor(OnEvt_PlayerBeInteractInput);
					bUS_GSEventCollection.Evt_PlayerBreakInteractInput -= new Del_Void_Actor(OnEvt_PlayerBreakInteractInput);
					bUS_GSEventCollection.Evt_PlayerFinishInteractInput -= new Del_Void_Actor(OnEvt_PlayerFinishInteractInput);
					bUS_GSEventCollection.Evt_TriggerInputCombie -= new Del_Void_StringList(OnEvt_TriggerInputCombie);
					bUS_GSEventCollection.Evt_UnTriggerRealease -= new Del_Void_StringList(OnEvt_UnTriggerRealease);
					bUS_GSEventCollection.Evt_SwitchDefaultItem -= new Del_Void_Int(OnEvt_SwitchDefaultItem);
					bUS_GSEventCollection.Evt_SwitchDefaultSpell -= new Del_Void_Int(OnEvt_SwitchDefaultSpell);
					bUS_GSEventCollection.Evt_TriggerUseDefaultShortcutItem -= new Del_Void_Int(OnEvt_TriggerUseDefaultShortcutItem);
					bUS_GSEventCollection.Evt_TriggerUseDefaultShortcutSpell -= new Del_Void_Int(OnEvt_TriggerUseDefaultShortcutSpell);
					bUS_GSEventCollection.Evt_ActiveNoSeqUI -= new Del_Void_Bool(OnEvt_ActiveNoSeqUI);
					bUS_GSEventCollection.Evt_TriggerInteactItemLack -= new Del_Void_FText(OnEvt_TriggerInteactItemLack);
					bUS_GSEventCollection.Evt_SwitchWeaponPose -= new Del_Void(OnEvt_SwitchWeaponPose);
					bUS_GSEventCollection.Evt_StartInteract -= new Del_Void(OnEvt_StartInteract);
					bUS_GSEventCollection.Evt_FinishMedicineTalkAnim -= new Del_Void(OnEvt_FinishMedicineTalkAnim);
					bUS_GSEventCollection.Evt_HoldingQTEInteract -= new Del_Void_Bool(OnEvt_HoldingQTEInteract);
					bUS_GSEventCollection.Evt_FinishSeedSubmitAnim -= new Del_Void(OnEvt_FinishSeedSubmitAnim);
					bUS_GSEventCollection.Evt_EnterInteractiveArea -= new Del_Void_Actor(OnEvt_EnterInteractiveArea);
					bUS_GSEventCollection.Evt_LeaveInteractiveArea -= new Del_Void_Actor(OnEvt_LeaveInteractiveArea);
					bUS_GSEventCollection.Evt_OnLeaveFight -= new Del_Void(OnEvt_OnLeaveFight);
					bUS_GSEventCollection.Evt_OnEnterFight -= new Del_Void_Actor(OnEvt_OnEnterFight);
					bUS_GSEventCollection.Evt_AfterUnitRebirth -= new Del_UnitRebirth(OnEvt_AfterUnitRebirth);
					bUS_GSEventCollection.Evt_HandleAbnormal -= new Del_HandleAbnormal(OnEvt_HandleAbnormal);
					bUS_GSEventCollection.Evt_AbnormalRemoved -= new Del_AbnormalRemoved(OnEvt_AbnormalRemoved);
					bUS_GSEventCollection.Evt_OnTrigerAbnormalFinalEffect -= new Del_OnTrigerAbnormalFinalEffect(OnEvt_OnTrigerAbnormalFinalEffect);
					bUS_GSEventCollection.Evt_OnIncreasePELevelNotify -= new Del_Void(OnEvt_OnIncreasePELevelNotify);
					bUS_GSEventCollection.Evt_OnDecreasePELevelNotify -= new Del_Void(OnEvt_OnDecreasePELevelNotify);
					bUS_GSEventCollection.Evt_OnMaxPELevelHasChangedNotify -= new Del_Void_Int(OnEvt_OnMaxPELevelHasChangedNotify);
					bUS_GSEventCollection.Evt_OnPEConfigChange -= new Del_Void(OnEvt_OnPEConfigChange);
				}
			}
		}

		private void OnEvt_UnitCastSkillSuccess(int MappingSkillID, int OriSkillID, ECastSkillSourceType SourceType)
		{
			Evt_UnitCastSkillSuccess?.Invoke(MappingSkillID, OriSkillID, SourceType);
		}

		private void OnEvt_UnitCastSkillFail(int SkillID, ECanCastSkillResult FailReason)
		{
			Evt_UnitCastSkillFail?.Invoke(SkillID, FailReason);
		}

		private void OnEvt_UnitTriggerDead(AActor Attacker, EDeadReason DeadReason, int DmgID)
		{
			Evt_UnitTriggerDead?.Invoke(Attacker, DeadReason, DmgID);
		}

		private void OnEvt_Camera_SwitchHideUILockPoint()
		{
			Evt_Camera_SwitchHideUILockPoint?.Invoke();
		}

		private void OnEvt_ShootUIChangeScale()
		{
			Evt_ShootUIChangeScale?.Invoke();
		}

		private void OnEvt_ShootUIChangeColor(bool P1)
		{
			Evt_ShootUIChangeColor?.Invoke(P1);
		}

		private void OnEvt_AddBuffNotify(bool IsHasBuffBefore, AActor Caster, int BuffID, float BuffDuration)
		{
			Evt_AddBuffNotify?.Invoke(IsHasBuffBefore, Caster, BuffID, BuffDuration);
		}

		private void OnEvt_RemoveBuffNotify(int P1, int P2)
		{
			Evt_RemoveBuffNotify?.Invoke(P1, P2);
		}

		private void OnEvt_TriggerBreakInteract(AActor Actor)
		{
			Evt_TriggerBreakInteract?.Invoke(Actor);
		}

		private void OnEvt_OnPlayerBreakInteract(AActor Actor)
		{
			Evt_OnPlayerBreakInteract?.Invoke(Actor);
		}

		private void OnEvt_TriggerFinishInteract(AActor Actor)
		{
			Evt_TriggerFinishInteract?.Invoke(Actor);
		}

		private void OnEvt_SnapShotRecoverSkillCD(int P1)
		{
			Evt_SnapShotRecoverSkillCD?.Invoke(P1);
		}

		private void OnEvt_ToggleCloudMove()
		{
			Evt_ToggleCloudMove?.Invoke();
		}

		private void OnEvt_IsCtrlPlayer(bool P1)
		{
			Evt_IsCtrlPlayer?.Invoke(P1);
		}

		private void OnEvt_TriggerFallDying(AActor Actor)
		{
			Evt_TriggerFallDying?.Invoke(Actor);
		}

		private void OnEvt_TriggerFallDyingToUI()
		{
			Evt_TriggerFallDyingToUI?.Invoke();
		}

		private void OnEvt_TriggerBeSaving(AActor Actor1, AActor Actor2)
		{
			Evt_TriggerBeSaving?.Invoke(Actor1, Actor2);
		}

		private void OnEvt_TriggerBreakBeSaving(AActor Actor1, AActor Actor2)
		{
			Evt_TriggerBreakBeSaving?.Invoke(Actor1, Actor2);
		}

		private void OnEvt_TriggerFinishBeSaving(AActor Actor1, AActor Actor2)
		{
			Evt_TriggerFinishBeSaving?.Invoke(Actor1, Actor2);
		}

		private void OnEvt_PlayerCollectedV2(AActor Actor)
		{
			Evt_PlayerCollectedV2?.Invoke(Actor);
		}

		private void OnEvt_TriggerShowUnitPartUI(bool P1)
		{
			Evt_TriggerShowUnitPartUI?.Invoke(P1);
		}

		private void OnEvt_PartUIValueChange(bool P1)
		{
			Evt_PartUIValueChange?.Invoke(P1);
		}

		private void OnEvt_GM_SwitchHideUILockPoint(float P1)
		{
			Evt_GM_SwitchHideUILockPoint?.Invoke(P1);
		}

		private void OnEvt_SwitchWeaponPoseByType(int P1)
		{
			Evt_SwitchWeaponPoseByType?.Invoke(P1);
		}

		private void OnEvt_RepPlayerLoc(FVector FVector, string MemberId)
		{
			Evt_RepPlayerLoc?.Invoke(FVector, MemberId);
		}

		private void OnEvt_OnlineChallengeBeginToUI(int P1, int P2)
		{
			Evt_OnlineChallengeBeginToUI?.Invoke(P1, P2);
		}

		private void OnEvt_OnlineChallengeEndToUI(int P1)
		{
			Evt_OnlineChallengeEndToUI?.Invoke(P1);
		}

		private void OnEvt_UI_ShowMapTips(bool IsUIWord, int Id)
		{
			Evt_UI_ShowMapTips?.Invoke(IsUIWord, Id);
		}

		private void OnEvt_TaskByIDTrigger(int P1)
		{
			Evt_TaskByIDTrigger?.Invoke(P1);
		}

		private void OnEvt_RebornInNearestRebirthPoint()
		{
			Evt_RebornInNearestRebirthPoint?.Invoke();
		}

		private void OnEvt_InputSwitchHero(bool P1, bool P2, int P3)
		{
			Evt_InputSwitchHero?.Invoke(P1, P2, P3);
		}

		private void OnEvt_EnterActiveArea(AActor Actor, EInteractType InType)
		{
			Evt_EnterActiveArea?.Invoke(Actor, InType);
		}

		private void OnEvt_LeaveActiveArea(AActor Actor, EInteractType InType)
		{
			Evt_LeaveActiveArea?.Invoke(Actor, InType);
		}

		private void OnEvt_EnterUninteractiveArea(int P1)
		{
			Evt_EnterUninteractiveArea?.Invoke(P1);
		}

		private void OnEvt_OpenToolNpcUI(AActor Actor)
		{
			Evt_OpenToolNpcUI?.Invoke(Actor);
		}

		private void OnEvt_ActiveTPSReticle(bool P1)
		{
			Evt_ActiveTPSReticle?.Invoke(P1);
		}

		private void OnEvt_PlayerBeInteractInput(AActor Actor)
		{
			Evt_PlayerBeInteractInput?.Invoke(Actor);
		}

		private void OnEvt_PlayerBreakInteractInput(AActor Actor)
		{
			Evt_PlayerBreakInteractInput?.Invoke(Actor);
		}

		private void OnEvt_PlayerFinishInteractInput(AActor Actor)
		{
			Evt_PlayerFinishInteractInput?.Invoke(Actor);
		}

		private void OnEvt_TriggerInputCombie(List<string> P)
		{
			Evt_TriggerInputCombie?.Invoke(P);
		}

		private void OnEvt_UnTriggerRealease(List<string> P)
		{
			Evt_UnTriggerRealease?.Invoke(P);
		}

		private void OnEvt_SwitchDefaultItem(int P1)
		{
			Evt_SwitchDefaultItem?.Invoke(P1);
		}

		private void OnEvt_SwitchDefaultSpell(int P1)
		{
			Evt_SwitchDefaultSpell?.Invoke(P1);
		}

		private void OnEvt_TriggerUseDefaultShortcutItem(int P1)
		{
			Evt_TriggerUseDefaultShortcutItem?.Invoke(P1);
		}

		private void OnEvt_TriggerUseDefaultShortcutSpell(int P1)
		{
			Evt_TriggerUseDefaultShortcutSpell?.Invoke(P1);
		}

		private void OnEvt_ActiveNoSeqUI(bool P1)
		{
			Evt_ActiveNoSeqUI?.Invoke(P1);
		}

		private void OnEvt_TriggerInteactItemLack(FText P1)
		{
			Evt_TriggerInteactItemLack?.Invoke(P1);
		}

		private void OnEvt_SwitchWeaponPose()
		{
			Evt_SwitchWeaponPose?.Invoke();
		}

		private void OnEvt_StartInteract()
		{
			Evt_StartInteract?.Invoke();
		}

		private void OnEvt_FinishMedicineTalkAnim()
		{
			Evt_FinishMedicineTalkAnim?.Invoke();
		}

		private void OnEvt_HoldingQTEInteract(bool P1)
		{
			Evt_HoldingQTEInteract?.Invoke(P1);
		}

		private void OnEvt_FinishSeedSubmitAnim()
		{
			Evt_FinishSeedSubmitAnim?.Invoke();
		}

		private void OnEvt_EnterInteractiveArea(AActor Actor)
		{
			Evt_EnterInteractiveArea?.Invoke(Actor);
		}

		private void OnEvt_LeaveInteractiveArea(AActor Actor)
		{
			Evt_LeaveInteractiveArea?.Invoke(Actor);
		}

		private void OnEvt_OnLeaveFight()
		{
			Evt_OnLeaveFight?.Invoke();
		}

		private void OnEvt_OnEnterFight(AActor Actor)
		{
			Evt_OnEnterFight?.Invoke(Actor);
		}

		private void OnEvt_AfterUnitRebirth(ERebirthType RebirthType)
		{
			Evt_AfterUnitRebirth?.Invoke(RebirthType);
		}

		private void OnEvt_HandleAbnormal(EAbnormalStateType AbnormalType, AActor Attacker, EAccAbnormalValueType AccType, float IncreaseValue, int AbnormalLevel)
		{
			Evt_HandleAbnormal?.Invoke(AbnormalType, Attacker, AccType, IncreaseValue, AbnormalLevel);
		}

		private void OnEvt_AbnormalRemoved(EAbnormalStateType AbnormalType)
		{
			Evt_AbnormalRemoved?.Invoke(AbnormalType);
		}

		private void OnEvt_OnTrigerAbnormalFinalEffect(EAbnormalStateType AbnormalType, int BuffID)
		{
			Evt_OnTrigerAbnormalFinalEffect?.Invoke(AbnormalType, BuffID);
		}

		private void OnEvt_OnIncreasePELevelNotify()
		{
			Evt_OnIncreasePELevelNotify?.Invoke();
		}

		private void OnEvt_OnDecreasePELevelNotify()
		{
			Evt_OnDecreasePELevelNotify?.Invoke();
		}

		private void OnEvt_OnMaxPELevelHasChangedNotify(int P1)
		{
			Evt_OnMaxPELevelHasChangedNotify?.Invoke(P1);
		}

		private void OnEvt_OnPEConfigChange()
		{
			Evt_OnPEConfigChange?.Invoke();
		}
	}

	public class GEvtClass
	{
		public Del_Void_Int Evt_BGS_TestGameState;

		public Del_SendOnlineScreenMsg Evt_BGS_SendOnlineScreenMsg;

		public Del_ItemDropToUI Evt_OnItemDropToUI;

		public Del_Void_Int Evt_BGS_ItemFullOnline;

		public Del_Void Evt_BGS_HideLevelUI;

		public Del_Void Evt_BGS_ShowPartyRoomUI;

		public Del_Void Evt_BGS_OnlineTeleport;

		public void GRegistEvent(AActor Actor)
		{
			if (!Actor.IsNullOrDestroyed())
			{
				BGS_GSEventCollection bGS_GSEventCollection = BGS_GSEventCollection.Get(Actor);
				if (!(bGS_GSEventCollection == null))
				{
					bGS_GSEventCollection.Evt_BGS_TestGameState += new Del_Void_Int(OnGEvt_BGS_TestGameState);
					bGS_GSEventCollection.Evt_BGS_SendOnlineScreenMsg += new Del_SendOnlineScreenMsg(OnGEvt_BGS_SendOnlineScreenMsg);
					bGS_GSEventCollection.Evt_OnItemDropToUI += new Del_ItemDropToUI(OnGEvt_OnItemDropToUI);
					bGS_GSEventCollection.Evt_BGS_ItemFullOnline += new Del_Void_Int(OnGEvt_BGS_ItemFullOnline);
					bGS_GSEventCollection.Evt_BGS_HideLevelUI += new Del_Void(OnGEvt_BGS_HideLevelUI);
					bGS_GSEventCollection.Evt_BGS_ShowPartyRoomUI += new Del_Void(OnGEvt_BGS_ShowPartyRoomUI);
					bGS_GSEventCollection.Evt_BGS_OnlineTeleport += new Del_Void(OnGEvt_BGS_OnlineTeleport);
				}
			}
		}

		public void GUnregistEvent(AActor Actor)
		{
			if (!Actor.IsNullOrDestroyed())
			{
				BGS_GSEventCollection bGS_GSEventCollection = BGS_GSEventCollection.Get(Actor);
				if (!(bGS_GSEventCollection == null))
				{
					bGS_GSEventCollection.Evt_BGS_TestGameState -= new Del_Void_Int(OnGEvt_BGS_TestGameState);
					bGS_GSEventCollection.Evt_BGS_SendOnlineScreenMsg -= new Del_SendOnlineScreenMsg(OnGEvt_BGS_SendOnlineScreenMsg);
					bGS_GSEventCollection.Evt_OnItemDropToUI -= new Del_ItemDropToUI(OnGEvt_OnItemDropToUI);
					bGS_GSEventCollection.Evt_BGS_ItemFullOnline -= new Del_Void_Int(OnGEvt_BGS_ItemFullOnline);
					bGS_GSEventCollection.Evt_BGS_HideLevelUI -= new Del_Void(OnGEvt_BGS_HideLevelUI);
					bGS_GSEventCollection.Evt_BGS_ShowPartyRoomUI -= new Del_Void(OnGEvt_BGS_ShowPartyRoomUI);
					bGS_GSEventCollection.Evt_BGS_OnlineTeleport -= new Del_Void(OnGEvt_BGS_OnlineTeleport);
				}
			}
		}

		private void OnGEvt_BGS_TestGameState(int P1)
		{
			Evt_BGS_TestGameState?.Invoke(P1);
		}

		private void OnGEvt_BGS_SendOnlineScreenMsg(EScreenMsgType ScreenMsgType, string Msg, int TipsDuration)
		{
			Evt_BGS_SendOnlineScreenMsg?.Invoke(ScreenMsgType, Msg, TipsDuration);
		}

		private void OnGEvt_OnItemDropToUI(FDropItem ItemData)
		{
			Evt_OnItemDropToUI?.Invoke(ItemData);
		}

		private void OnGEvt_BGS_ItemFullOnline(int P1)
		{
			Evt_BGS_ItemFullOnline?.Invoke(P1);
		}

		private void OnGEvt_BGS_HideLevelUI()
		{
			Evt_BGS_HideLevelUI?.Invoke();
		}

		private void OnGEvt_BGS_ShowPartyRoomUI()
		{
			Evt_BGS_ShowPartyRoomUI?.Invoke();
		}

		private void OnGEvt_BGS_OnlineTeleport()
		{
			Evt_BGS_OnlineTeleport?.Invoke();
		}
	}

	public class PEvtClass
	{
		public Del_Void_Int Evt_BPS_TestPlayerState;

		public Del_ChangeAttrByEquip Evt_BPS_ChangeAttrByEquip;

		public void PRegistEvent(AActor Actor)
		{
			if (!Actor.IsNullOrDestroyed())
			{
				BPS_GSEventCollection local = BPS_GSEventCollection.GetLocal(Actor);
				if (!(local == null))
				{
					local.Evt_BPS_TestPlayerState += new Del_Void_Int(OnPEvt_BPS_TestPlayerState);
					local.Evt_BPS_ChangeAttrByEquip += new Del_ChangeAttrByEquip(OnPEvt_BPS_ChangeAttrByEquip);
				}
			}
		}

		public void PUnregistEvent(AActor Actor)
		{
			if (!Actor.IsNullOrDestroyed())
			{
				BPS_GSEventCollection local = BPS_GSEventCollection.GetLocal(Actor);
				if (!(local == null))
				{
					local.Evt_BPS_TestPlayerState -= new Del_Void_Int(OnPEvt_BPS_TestPlayerState);
					local.Evt_BPS_ChangeAttrByEquip -= new Del_ChangeAttrByEquip(OnPEvt_BPS_ChangeAttrByEquip);
				}
			}
		}

		private void OnPEvt_BPS_TestPlayerState(int P1)
		{
			Evt_BPS_TestPlayerState?.Invoke(P1);
		}

		private void OnPEvt_BPS_ChangeAttrByEquip(EBGUAttrFloat AttrId, float Value)
		{
			Evt_BPS_ChangeAttrByEquip?.Invoke(AttrId, Value);
		}
	}

	public delegate AActor Del_Actor();

	public delegate void Del_ResetActor(int TagIdx);

	protected class GSActorData
	{
		private TStrongObjectPtr<AActor> actor = new TStrongObjectPtr<AActor>();

		public Del_Actor GetActor = () => (AActor)null;

		public List<GSBattleDataDStore> BattleData = new List<GSBattleDataDStore>();

		public EvtClass ActorEvt = new EvtClass();

		public bool IsInitBattleData;

		public AActor Actor
		{
			get
			{
				return actor.Get();
			}
			set
			{
				actor.Set(value);
			}
		}

		public void Clear()
		{
			Actor = null;
			ActorEvt = new EvtClass();
			BattleData.Clear();
			IsInitBattleData = false;
		}
	}

	protected UObject WorldContext;

	protected Dictionary<int, GSActorData> ActorDataMap = new Dictionary<int, GSActorData>();

	protected Dictionary<int, GSActorData> EntityDataMap = new Dictionary<int, GSActorData>();

	protected Del_ResetActor OnResetActor;

	public virtual void Init(UObject WorldContext)
	{
		this.WorldContext = WorldContext;
		ClearData();
	}

	protected UObject GetWorldContext()
	{
		return WorldContext;
	}

	protected virtual List<GSBattleDataDStore> InitBattleData(AActor UnitActor)
	{
		return null;
	}

	public void ClearData()
	{
		foreach (KeyValuePair<int, GSActorData> item in ActorDataMap)
		{
			item.Value.Clear();
		}
		foreach (KeyValuePair<int, GSActorData> item2 in EntityDataMap)
		{
			item2.Value.Clear();
		}
		CleraEXData();
	}

	protected virtual void CleraEXData()
	{
	}

	protected void RegistGetActor(int TagIdx, Del_Actor DelGetActor)
	{
		if (!ActorDataMap.ContainsKey(TagIdx))
		{
			GSActorData gSActorData = new GSActorData();
			gSActorData.GetActor = DelGetActor;
			ActorDataMap.Add(TagIdx, gSActorData);
		}
	}

	protected void UpdateActor(int TagIdx)
	{
		if (!ActorDataMap.TryGetValue(TagIdx, out var value))
		{
			return;
		}
		AActor aActor = value.GetActor();
		if (!(aActor != value.Actor))
		{
			return;
		}
		value.ActorEvt.UnregistEvent(value.Actor);
		if (value.Actor == null && !value.IsInitBattleData)
		{
			value.BattleData = InitBattleData(aActor);
			value.IsInitBattleData = true;
		}
		else
		{
			foreach (GSBattleDataDStore battleDatum in value.BattleData)
			{
				battleDatum.ResetActor(aActor);
			}
			OnResetActor?.Invoke(TagIdx);
		}
		value.Actor = aActor;
		value.ActorEvt.RegistEvent(value.Actor);
	}

	public void BindResetActor(Del_ResetActor ResetActorCallBack)
	{
		OnResetActor = (Del_ResetActor)Delegate.Combine(OnResetActor, ResetActorCallBack);
	}

	public void UnBindResetActor(Del_ResetActor ResetActorCallBack)
	{
		OnResetActor = (Del_ResetActor)Delegate.Remove(OnResetActor, ResetActorCallBack);
	}

	public void ClearResetActor()
	{
		OnResetActor = null;
	}

	public EvtClass GetActorEvt(int TagIdx)
	{
		if (!ActorDataMap.TryGetValue(TagIdx, out var value))
		{
			return null;
		}
		return value.ActorEvt;
	}

	protected T GetBattleData<T>(int TagIdx, bool IsNeedUpdate = false) where T : class
	{
		if (IsNeedUpdate)
		{
			UpdateActor(TagIdx);
		}
		if (!ActorDataMap.TryGetValue(TagIdx, out var value))
		{
			return null;
		}
		if (value.BattleData != null)
		{
			foreach (GSBattleDataDStore battleDatum in value.BattleData)
			{
				if (battleDatum is T result)
				{
					return result;
				}
			}
		}
		return null;
	}

	protected int GetActorResId(int TagIdx, bool IsNeedUpdate = false)
	{
		if (IsNeedUpdate)
		{
			UpdateActor(TagIdx);
		}
		if (ActorDataMap.TryGetValue(TagIdx, out var value))
		{
			BGUCharacterCS bGUCharacterCS = value.Actor as BGUCharacterCS;
			if (bGUCharacterCS != null)
			{
				return bGUCharacterCS.GetResID();
			}
		}
		return -1;
	}

	public void UpdateEntityDataMap()
	{
		foreach (KeyValuePair<int, GSActorData> item in EntityDataMap)
		{
			if (item.Value.Actor.IsNullOrDestroyed())
			{
				EntityDataMap.Remove(item.Key);
				break;
			}
		}
	}

	public T GetBattleDataByActor<T>(AActor Actor) where T : class
	{
		int hashCode = ECSUtil.ToEntity(Actor).GetHashCode();
		if (!EntityDataMap.TryGetValue(hashCode, out var value))
		{
			value = new GSActorData();
			value.Actor = Actor;
			value.BattleData = InitBattleData(value.Actor);
			EntityDataMap.Add(hashCode, value);
		}
		foreach (GSBattleDataDStore battleDatum in value.BattleData)
		{
			if (battleDatum is T result)
			{
				return result;
			}
		}
		return null;
	}

	public EvtClass GetActorEvtByActor(AActor Actor)
	{
		if (!EntityDataMap.TryGetValue(ECSUtil.ToEntity(Actor).GetHashCode(), out var value))
		{
			value = new GSActorData();
			value.Actor = Actor;
			value.BattleData = InitBattleData(value.Actor);
			EntityDataMap.Add(ECSUtil.ToEntity(Actor).GetHashCode(), value);
		}
		return value.ActorEvt;
	}

	public float GetWorldTime(int TagIdx)
	{
		ActorDataMap.TryGetValue(TagIdx, out var value);
		return value.Actor.World.GetTimeSeconds();
	}

	public override void OnPostLoadMap()
	{
		ClearData();
	}
}
