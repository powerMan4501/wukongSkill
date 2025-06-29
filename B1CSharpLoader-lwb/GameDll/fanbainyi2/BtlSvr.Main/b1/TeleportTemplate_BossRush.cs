using System;
using System.Collections.Generic;
using System.Linq;
using b1.BGW;
using b1.EventDelDefine;
using b1.GSMUI.Core;
using b1.Localization;
using b1.Plugins.AsyncLoadingScreen;
using B1UI.GSUI;
using BtlB1;
using BtlShare;
using CommB1;
using ResB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class TeleportTemplate_BossRush : TeleportTemplateBase
{
	private TeleportParam_BossRush TeleportParam => (TeleportParam_BossRush)(object)UserData;

	public override bool LevelTravelUseDefaultPlayerStart()
	{
		return false;
	}

	public override EGSLoadingScreenType GetLoadingScreenType()
	{
		return EGSLoadingScreenType.BossRush;
	}

	public override void LoadingFadeAwayPreBegin()
	{
	}

	public override int GetTargetLevelId()
	{
		return TeleportParam.LevelId;
	}

	public override FTransform ChoosePlayerTeleportTransform()
	{
		FTransform result = default(FTransform);
		IBIC_BossRushData gameInstanceReadonlyData = BGU_DataUtil.GetGameInstanceReadonlyData<IBIC_BossRushData, BIC_BossRushData>(GameInst);
		if (gameInstanceReadonlyData == null)
		{
			return result;
		}
		BGW_EventCollection.Get(GameInst).Evt_ShutdownBossRushBattle();
		BGW_EventCollection.Get(GameInst).Evt_TriggerResetAllActors(EResetActorReason.Rebirth);
		BGW_EventCollection.Get(GameInst)?.Evt_LoadBossRushBattle(gameInstanceReadonlyData.TargetId);
		return BGU_DataUtil.GetGameInstanceReadonlyData<IBIC_BossRushBattleData, BIC_BossRushBattleData>(GameInst)?.PlayerStartForGroup ?? FTransform.Default;
	}

	public override void OnBegin()
	{
		if (base.PlayerPawn != null)
		{
			IBUC_UnitStateData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_UnitStateData, BUC_UnitStateData>(base.PlayerPawn);
			if (readOnlyData != null && readOnlyData.HasState(EBGUUnitState.Dead))
			{
				BUS_EventCollectionCS.Get(base.PlayerPawn)?.Evt_RebirthTeleportFinish.Invoke(ERebirthType.RebirthPoint);
			}
		}
		BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(base.PlayerPawn);
		bGW_EventCollection.Evt_PostLoadingScreenOpen = (Del_Void)Delegate.Combine(bGW_EventCollection.Evt_PostLoadingScreenOpen, new Del_Void(PostLoadingScreenOpen));
	}

	private void PostLoadingScreenOpen()
	{
		IBIC_BossRushData BossRushData = BGU_DataUtil.GetGameInstanceReadonlyData<IBIC_BossRushData, BIC_BossRushData>(GameInst);
		if (BossRushData == null)
		{
			return;
		}
		FUStBossRushConfigDesc BossRushConfigDesc = GameDBRuntime.GetFUStBossRushConfigDesc(BossRushData.TargetId);
		if (BossRushConfigDesc == null)
		{
			return;
		}
		BossIterationsDesc BossIterationsDesc = GameDBRuntime.GetTBBossIterationsDesc().List.FirstOrDefault((BossIterationsDesc Desc) => Desc.Id == BossRushData.BossIterationsGroupId && Desc.BossSuccessiveInfo.Contains(BossRushConfigDesc.ID));
		if (BossIterationsDesc == null)
		{
			return;
		}
		FBossRushInfo BossRushInfo = new FBossRushInfo
		{
			BossName = FText.GetEmpty(),
			DifficultyTitle = FText.GetEmpty(),
			DifficultyDesc = FText.GetEmpty(),
			GroupText = FText.GetEmpty(),
			DifficultyText = FText.GetEmpty(),
			LoadingType = EBossRushLoadingType.BossIterations
		};
		if (BossRushConfigDesc.UIwordID != 0)
		{
			BossRushInfo.BossName = GSMUIUtil.GetUIWordDescFText((EUIWordID)BossRushConfigDesc.UIwordID);
		}
		else if (BossRushConfigDesc.ExtendID != 0)
		{
			FUStUnitBattleInfoExtendDesc unitBattleInfoExtendDesc = BGW_GameDB.GetUnitBattleInfoExtendDesc(BossRushConfigDesc.ExtendID);
			if (unitBattleInfoExtendDesc != null)
			{
				BossRushInfo.BossName = unitBattleInfoExtendDesc.UnitName.ToFText();
			}
		}
		int score = BossRushData.BossRushBattleData.Score;
		switch (score)
		{
		case 0:
			BossRushInfo.DifficultyTitle = GSMUIUtil.GetUIWordDescFText(EUIWordID.BOSS_ITERATIONS_DIFFICULTY_0);
			BossRushInfo.DifficultyLevel = 0;
			break;
		case 21:
			BossRushInfo.DifficultyTitle = GSMUIUtil.GetUIWordDescFText(EUIWordID.BOSS_ITERATIONS_DIFFICULTY_5);
			BossRushInfo.DifficultyLevel = 0;
			break;
		default:
			BossRushInfo.DifficultyTitle = GSMUIUtil.GetUIWordDescFText((EUIWordID)(2311 + (score - 1) / 5));
			BossRushInfo.DifficultyLevel = (score - 1) % 5 + 1;
			break;
		}
		BossRushInfo.DifficultyDesc = GSMUIUtil.GetUIWordDescFText(EUIWordID.BOSS_ITERATIONS_LOADING_DESC);
		BossRushInfo.GroupText = BossIterationsDesc.GroupName.ToFText();
		BossRushInfo.IterationsChallengeCurrentIndex = BossRushData.BossIterationsIndex;
		BossRushInfo.IterationsChallengeCount = BossIterationsDesc.BossSuccessiveInfo.Count;
		string text = GSUIResPathUtil.GetBossRushImagePath(BossIterationsDesc.Id, BossRushData.BossIterationsIndex);
		if (BossIterationsDesc.Id == 9)
		{
			ReadOnlyBossRushContinuousFightGroupList readOnlyBossRushContinuousFightGroupList = BGU_DataUtil.GetReadOnlyData<IBPC_PlayerRoleData, BPC_PlayerRoleData>(base.PlayerController)?.RoleData?.RoleCs?.BossRush?.ContinuousFight?.BossGroups;
			bool flag = false;
			if (readOnlyBossRushContinuousFightGroupList != null)
			{
				flag = readOnlyBossRushContinuousFightGroupList.Any((ReadOnlyBossRushContinuousFightGroup Group) => Group.BossGroupId == BossIterationsDesc.Id && Group.EncounterBossIndex >= 5);
			}
			BossRushInfo.IsNeedHide = !flag;
			if (BossRushData.BossIterationsIndex == 5 || BossRushData.BossIterationsIndex == 4)
			{
				string text2 = $"Img_LoadTips_{BossIterationsDesc.Id:D2}{BossRushData.BossIterationsIndex:D2}_B";
				string newValue = text2 + (flag ? "_b" : "_a");
				text = text.Replace(text2, newValue);
			}
			if (!flag && BossRushData.BossIterationsIndex == 5)
			{
				BossRushInfo.BossName = GSMUIUtil.GetUIWordDescFText(EUIWordID.NAME_EMPTY_UNKNOW);
			}
		}
		BossRushInfo.BossImage = BGW_PreloadAssetMgr.Get(base.PlayerPawn).RequestSyncLoadForUIResource<UTexture2D>(text, EUIResourceLoadType.NoCache);
		BossRushInfo.DebuffList = BossRushData.BossRushBattleData.DebuffList.ToList();
		BGW_LoadingTipsMgr.Get(GameInst).DumpWidgetMaskTexture(ref BossRushInfo);
		BGWGameInstanceCS.Get(GameInst).RegisterBossRushInfo(BossRushInfo);
	}

	public override void LoadingFadeInFinish()
	{
		BGW_EventCollection.Get(GameInst).Evt_ActiveBlackOut(IsActive: false);
		BGS_EventCollectionCS.Get(GameInst)?.Evt_SetBossRushSpawnUnitAllowable.Invoke(P1: false);
		base.LoadingFadeInFinish();
	}

	public override void LoadingFadeAwayBegin()
	{
		base.LoadingFadeAwayBegin();
		BGS_EventCollectionCS.Get(GameInst)?.Evt_SetBossRushSpawnUnitAllowable.Invoke(P1: true);
		ReCoverAttrData();
		BGW_EventCollection.Get(GameInst)?.Evt_SetGamePause?.Invoke(EPauseEvent.BossRushBegin, bPause: true);
		BGW_UIEventCollection.Get(GameInst)?.Evt_UI_ActiveBlackOut(IsActive: true, null, IsPauseWorld: false);
	}

	public override void OnEnd()
	{
		base.OnEnd();
		BGW_UIEventCollection.Get(GameInst)?.Evt_UI_ActiveBlackOut(IsActive: false, delegate
		{
			BGW_EventCollection.Get(GameInst)?.Evt_ReadyBossRushBattle_ShowUI();
			BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(GameInst);
			bGW_EventCollection.Evt_PostLoadingScreenOpen = (Del_Void)Delegate.Remove(bGW_EventCollection.Evt_PostLoadingScreenOpen, new Del_Void(PostLoadingScreenOpen));
			BGW_EventCollection.Get(GameInst)?.Evt_SetGamePause?.Invoke(EPauseEvent.BossRushBegin, bPause: false);
		}, IsPauseWorld: false);
	}

	private void ReCoverAttrData()
	{
		IBIC_BossRushData gameInstanceReadonlyData = BGU_DataUtil.GetGameInstanceReadonlyData<IBIC_BossRushData, BIC_BossRushData>(GameInst);
		if (gameInstanceReadonlyData.BossRushType != EBossRushType.BossIterations)
		{
			return;
		}
		List<ECSDataInitTemplate> dataInitTemplate = base.PlayerPawn.GetComponentByClass<BUS_BGUDataCompBase>().DataInitTemplate;
		if (dataInitTemplate == null)
		{
			return;
		}
		foreach (ECSDataInitTemplate item in dataInitTemplate)
		{
			(item as PlayerWukongAttrDataInit)?.BossRushReCoverAttrData(gameInstanceReadonlyData.BossIterationsAttrCacheDict);
			(item as PlayerWukongSkillCDInit)?.BossRushRecoverCD();
		}
	}
}
