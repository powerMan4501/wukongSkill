using System;
using CsB1;
using ILRuntime.Runtime.Enviorment;
using ResB1;
using UnrealEngine.Engine;

namespace b1;

public class BattleToFluxDelegateUtil
{
	public static void DelegateRegister(ILRuntime.Runtime.Enviorment.AppDomain appdomain)
	{
		appdomain.DelegateManager.RegisterMethodDelegate<CSMsgRoleLoginReq, Action<MsgErrCode, CSMsgRoleLoginReq, CSMsgRoleLoginRes>, APlayerState, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<CSMsgRoleLogoutReq, Action<MsgErrCode, CSMsgRoleLogoutReq, CSMsgRoleLogoutRes>, APlayerState, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<CSMsgRoleKickReq, Action<MsgErrCode, CSMsgRoleKickReq, CSMsgRoleKickRes>, APlayerState, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<CSMsgRoleDataNotifyReq, Action<MsgErrCode, CSMsgRoleDataNotifyReq, CSMsgRoleDataNotifyRes>, APlayerState, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<CSMsgRoleRandomNameReq, Action<MsgErrCode, CSMsgRoleRandomNameReq, CSMsgRoleRandomNameRes>, APlayerState, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<CSMsgRoleChangeNameReq, Action<MsgErrCode, CSMsgRoleChangeNameReq, CSMsgRoleChangeNameRes>, APlayerState, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<CSMsgMiscCreateRoleReq, Action<MsgErrCode, CSMsgMiscCreateRoleReq, CSMsgMiscCreateRoleRes>, APlayerState, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<CSMsgMiscExecGMReq, Action<MsgErrCode, CSMsgMiscExecGMReq, CSMsgMiscExecGMRes>, APlayerState, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<CSMsgMiscHeartBeatReq, Action<MsgErrCode, CSMsgMiscHeartBeatReq, CSMsgMiscHeartBeatRes>, APlayerState, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<CSMsgMiscCheckResReq, Action<MsgErrCode, CSMsgMiscCheckResReq, CSMsgMiscCheckResRes>, APlayerState, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<CSMsgAwolMsgGetListReq, Action<MsgErrCode, CSMsgAwolMsgGetListReq, CSMsgAwolMsgGetListRes>, APlayerState, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<CSMsgAwolMsgRemoveReq, Action<MsgErrCode, CSMsgAwolMsgRemoveReq, CSMsgAwolMsgRemoveRes>, APlayerState, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<CSMsgAwolMsgUpdateReq, Action<MsgErrCode, CSMsgAwolMsgUpdateReq, CSMsgAwolMsgUpdateRes>, APlayerState, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<CSMsgAwolMsgSendReq, Action<MsgErrCode, CSMsgAwolMsgSendReq, CSMsgAwolMsgSendRes>, APlayerState, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<CSMsgAwolMsgNotifyUpdateReq, Action<MsgErrCode, CSMsgAwolMsgNotifyUpdateReq, CSMsgAwolMsgNotifyUpdateRes>, APlayerState, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<CSMsgAwolMsgNotifyRemoveReq, Action<MsgErrCode, CSMsgAwolMsgNotifyRemoveReq, CSMsgAwolMsgNotifyRemoveRes>, APlayerState, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<CSMsgAwolMsgNotifyAddReq, Action<MsgErrCode, CSMsgAwolMsgNotifyAddReq, CSMsgAwolMsgNotifyAddRes>, APlayerState, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<CSMsgBriefMsgGetReq, Action<MsgErrCode, CSMsgBriefMsgGetReq, CSMsgBriefMsgGetRes>, APlayerState, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<CSMsgRankListGetReq, Action<MsgErrCode, CSMsgRankListGetReq, CSMsgRankListGetRes>, APlayerState, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<CSMsgBagGainItemListReq, Action<MsgErrCode, CSMsgBagGainItemListReq, CSMsgBagGainItemListRes>, APlayerState, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<CSMsgBagCostItemListReq, Action<MsgErrCode, CSMsgBagCostItemListReq, CSMsgBagCostItemListRes>, APlayerState, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<CSMsgBagHuluSettingReq, Action<MsgErrCode, CSMsgBagHuluSettingReq, CSMsgBagHuluSettingRes>, APlayerState, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<CSMsgBagAlchemyReq, Action<MsgErrCode, CSMsgBagAlchemyReq, CSMsgBagAlchemyRes>, APlayerState, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<CSMsgBagWeaponBuildReq, Action<MsgErrCode, CSMsgBagWeaponBuildReq, CSMsgBagWeaponBuildRes>, APlayerState, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<CSMsgBagWeaponReBuildReq, Action<MsgErrCode, CSMsgBagWeaponReBuildReq, CSMsgBagWeaponReBuildRes>, APlayerState, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<CSMsgBagDropUnitAwardReq, Action<MsgErrCode, CSMsgBagDropUnitAwardReq, CSMsgBagDropUnitAwardRes>, APlayerState, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<CSMsgBagCommDropReq, Action<MsgErrCode, CSMsgBagCommDropReq, CSMsgBagCommDropRes>, APlayerState, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<CSMsgBagWineUpgradeReq, Action<MsgErrCode, CSMsgBagWineUpgradeReq, CSMsgBagWineUpgradeRes>, APlayerState, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<CSMsgBagWinePartnerSettingReq, Action<MsgErrCode, CSMsgBagWinePartnerSettingReq, CSMsgBagWinePartnerSettingRes>, APlayerState, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<CSMsgBagGainEditionAwardReq, Action<MsgErrCode, CSMsgBagGainEditionAwardReq, CSMsgBagGainEditionAwardRes>, APlayerState, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<CSMsgActorWearEquipReq, Action<MsgErrCode, CSMsgActorWearEquipReq, CSMsgActorWearEquipRes>, APlayerState, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<CSMsgActorUnWearEquipReq, Action<MsgErrCode, CSMsgActorUnWearEquipReq, CSMsgActorUnWearEquipRes>, APlayerState, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<CSMsgActorSetShortCutReq, Action<MsgErrCode, CSMsgActorSetShortCutReq, CSMsgActorSetShortCutRes>, APlayerState, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<CSMsgActorUnSetShortCutReq, Action<MsgErrCode, CSMsgActorUnSetShortCutReq, CSMsgActorUnSetShortCutRes>, APlayerState, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<CSMsgActorSetSpellReq, Action<MsgErrCode, CSMsgActorSetSpellReq, CSMsgActorSetSpellRes>, APlayerState, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<CSMsgActorUnSetSpellReq, Action<MsgErrCode, CSMsgActorUnSetSpellReq, CSMsgActorUnSetSpellRes>, APlayerState, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<CSMsgActorSetDefaultSpellReq, Action<MsgErrCode, CSMsgActorSetDefaultSpellReq, CSMsgActorSetDefaultSpellRes>, APlayerState, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<CSMsgActorOnPlayerDeathReq, Action<MsgErrCode, CSMsgActorOnPlayerDeathReq, CSMsgActorOnPlayerDeathRes>, APlayerState, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<CSMsgActorOnPlayerRestReq, Action<MsgErrCode, CSMsgActorOnPlayerRestReq, CSMsgActorOnPlayerRestRes>, APlayerState, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<CSMsgActorOnNewGamePlusReq, Action<MsgErrCode, CSMsgActorOnNewGamePlusReq, CSMsgActorOnNewGamePlusRes>, APlayerState, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<CSMsgActorUnLockTalentReq, Action<MsgErrCode, CSMsgActorUnLockTalentReq, CSMsgActorUnLockTalentRes>, APlayerState, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<CSMsgActorTalentLevelUpReq, Action<MsgErrCode, CSMsgActorTalentLevelUpReq, CSMsgActorTalentLevelUpRes>, APlayerState, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<CSMsgActorRebuildTalentReq, Action<MsgErrCode, CSMsgActorRebuildTalentReq, CSMsgActorRebuildTalentRes>, APlayerState, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<CSMsgActorMeditationUnlockReq, Action<MsgErrCode, CSMsgActorMeditationUnlockReq, CSMsgActorMeditationUnlockRes>, APlayerState, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<CSMsgActorOnPlayerExitReq, Action<MsgErrCode, CSMsgActorOnPlayerExitReq, CSMsgActorOnPlayerExitRes>, APlayerState, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<CSMsgActorWineSettingReq, Action<MsgErrCode, CSMsgActorWineSettingReq, CSMsgActorWineSettingRes>, APlayerState, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<CSMsgShopPayBuyItemReq, Action<MsgErrCode, CSMsgShopPayBuyItemReq, CSMsgShopPayBuyItemRes>, APlayerState, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<CSMsgShopRefreshReq, Action<MsgErrCode, CSMsgShopRefreshReq, CSMsgShopRefreshRes>, APlayerState, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<CSMsgBagSellItemReq, Action<MsgErrCode, CSMsgBagSellItemReq, CSMsgBagSellItemRes>, APlayerState, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<CSMsgShopRefreshFlagRemoveReq, Action<MsgErrCode, CSMsgShopRefreshFlagRemoveReq, CSMsgShopRefreshFlagRemoveRes>, APlayerState, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<CSMsgTaskChangeQuestStageReq, Action<MsgErrCode, CSMsgTaskChangeQuestStageReq, CSMsgTaskChangeQuestStageRes>, APlayerState, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<CSMsgCollectionInteractiveUnlockReq, Action<MsgErrCode, CSMsgCollectionInteractiveUnlockReq, CSMsgCollectionInteractiveUnlockRes>, APlayerState, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<CSMsgRedPointRemoveReq, Action<MsgErrCode, CSMsgRedPointRemoveReq, CSMsgRedPointRemoveRes>, APlayerState, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<CSMsgActorWeaponTransformFlexTypeReq, Action<MsgErrCode, CSMsgActorWeaponTransformFlexTypeReq, CSMsgActorWeaponTransformFlexTypeRes>, APlayerState, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<CSMsgActorKillUnitReq, Action<MsgErrCode, CSMsgActorKillUnitReq, CSMsgActorKillUnitRes>, APlayerState, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<CSMsgActorUnitEncounterReq, Action<MsgErrCode, CSMsgActorUnitEncounterReq, CSMsgActorUnitEncounterRes>, APlayerState, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<CSMsgAchievementUnlockReq, Action<MsgErrCode, CSMsgAchievementUnlockReq, CSMsgAchievementUnlockRes>, APlayerState, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<CSMsgChapterEnterNextReq, Action<MsgErrCode, CSMsgChapterEnterNextReq, CSMsgChapterEnterNextRes>, APlayerState, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<CSMsgChapterEnterShowReq, Action<MsgErrCode, CSMsgChapterEnterShowReq, CSMsgChapterEnterShowRes>, APlayerState, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<CSMsgChapterPreviewAwardReq, Action<MsgErrCode, CSMsgChapterPreviewAwardReq, CSMsgChapterPreviewAwardRes>, APlayerState, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<CSMsgMuseumRecordMemoriesReq, Action<MsgErrCode, CSMsgMuseumRecordMemoriesReq, CSMsgMuseumRecordMemoriesRes>, APlayerState, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<CSMsgMuseumRemoveRedpointReq, Action<MsgErrCode, CSMsgMuseumRemoveRedpointReq, CSMsgMuseumRemoveRedpointRes>, APlayerState, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<CSMsgAttrChangeNotifyReq, Action<MsgErrCode, CSMsgAttrChangeNotifyReq, CSMsgAttrChangeNotifyRes>, APlayerState, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<CSMsgRoomCreatePartyCSReq, Action<MsgErrCode, CSMsgRoomCreatePartyCSReq, CSMsgRoomCreatePartyCSRes>, APlayerState, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<CSMsgRoomJoinPartyCSReq, Action<MsgErrCode, CSMsgRoomJoinPartyCSReq, CSMsgRoomJoinPartyCSRes>, APlayerState, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<CSMsgRoomExitPartyCSReq, Action<MsgErrCode, CSMsgRoomExitPartyCSReq, CSMsgRoomExitPartyCSRes>, APlayerState, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<CSMsgRoomPartyKickMemberCSReq, Action<MsgErrCode, CSMsgRoomPartyKickMemberCSReq, CSMsgRoomPartyKickMemberCSRes>, APlayerState, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<CSMsgRoomSearchPartyCSReq, Action<MsgErrCode, CSMsgRoomSearchPartyCSReq, CSMsgRoomSearchPartyCSRes>, APlayerState, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<CSMsgRoomSearchPartyNotifyReq, Action<MsgErrCode, CSMsgRoomSearchPartyNotifyReq, CSMsgRoomSearchPartyNotifyRes>, APlayerState, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<CSMsgRoomQueryPartyInfoCSReq, Action<MsgErrCode, CSMsgRoomQueryPartyInfoCSReq, CSMsgRoomQueryPartyInfoCSRes>, APlayerState, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<CSMsgRoomPartyHeartBeatCSReq, Action<MsgErrCode, CSMsgRoomPartyHeartBeatCSReq, CSMsgRoomPartyHeartBeatCSRes>, APlayerState, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<CSMsgRoomPartyEventNotifyReq, Action<MsgErrCode, CSMsgRoomPartyEventNotifyReq, CSMsgRoomPartyEventNotifyRes>, APlayerState, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<CSMsgRoomSendPartyBattleMessageCSReq, Action<MsgErrCode, CSMsgRoomSendPartyBattleMessageCSReq, CSMsgRoomSendPartyBattleMessageCSRes>, APlayerState, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<CSMsgRoomPartyBattleMessageNotifyReq, Action<MsgErrCode, CSMsgRoomPartyBattleMessageNotifyReq, CSMsgRoomPartyBattleMessageNotifyRes>, APlayerState, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<CSMsgRoomPartyMemberUpdateCSReq, Action<MsgErrCode, CSMsgRoomPartyMemberUpdateCSReq, CSMsgRoomPartyMemberUpdateCSRes>, APlayerState, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<CSMsgRoomCreatePartyTaskCSReq, Action<MsgErrCode, CSMsgRoomCreatePartyTaskCSReq, CSMsgRoomCreatePartyTaskCSRes>, APlayerState, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<CSMsgRoomUpdatePartyTaskCSReq, Action<MsgErrCode, CSMsgRoomUpdatePartyTaskCSReq, CSMsgRoomUpdatePartyTaskCSRes>, APlayerState, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<CSMsgRoomPartyTaskFinishCSReq, Action<MsgErrCode, CSMsgRoomPartyTaskFinishCSReq, CSMsgRoomPartyTaskFinishCSRes>, APlayerState, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<CSMsgBagMultiplayerDropReq, Action<MsgErrCode, CSMsgBagMultiplayerDropReq, CSMsgBagMultiplayerDropRes>, APlayerState, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<CSMsgChapterGameCompleteReq, Action<MsgErrCode, CSMsgChapterGameCompleteReq, CSMsgChapterGameCompleteRes>, APlayerState, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<CSMsgCollectionReadCardStoryReq, Action<MsgErrCode, CSMsgCollectionReadCardStoryReq, CSMsgCollectionReadCardStoryRes>, APlayerState, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<CSMsgBagArmorUpgradeReq, Action<MsgErrCode, CSMsgBagArmorUpgradeReq, CSMsgBagArmorUpgradeRes>, APlayerState, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<CSMsgBagDropCollectionAwardReq, Action<MsgErrCode, CSMsgBagDropCollectionAwardReq, CSMsgBagDropCollectionAwardRes>, APlayerState, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<CSMsgPartyApiCreateOnlinePartyReq, Action<MsgErrCode, CSMsgPartyApiCreateOnlinePartyReq, CSMsgPartyApiCreateOnlinePartyRes>, APlayerState, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<CSMsgPartyApiSearchPartyReq, Action<MsgErrCode, CSMsgPartyApiSearchPartyReq, CSMsgPartyApiSearchPartyRes>, APlayerState, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<CSMsgPartyApiJoinPartyReq, Action<MsgErrCode, CSMsgPartyApiJoinPartyReq, CSMsgPartyApiJoinPartyRes>, APlayerState, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<CSMsgPartyApiLeaderCreateTaskReq, Action<MsgErrCode, CSMsgPartyApiLeaderCreateTaskReq, CSMsgPartyApiLeaderCreateTaskRes>, APlayerState, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<CSMsgPartyApiMemberTaskReadyReq, Action<MsgErrCode, CSMsgPartyApiMemberTaskReadyReq, CSMsgPartyApiMemberTaskReadyRes>, APlayerState, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<CSMsgPartyApiLeaderFinishTaskReq, Action<MsgErrCode, CSMsgPartyApiLeaderFinishTaskReq, CSMsgPartyApiLeaderFinishTaskRes>, APlayerState, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<CSMsgPartyApiLeaderCreateBattleReq, Action<MsgErrCode, CSMsgPartyApiLeaderCreateBattleReq, CSMsgPartyApiLeaderCreateBattleRes>, APlayerState, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<CSMsgPartyApiLeaderBattleReadyReq, Action<MsgErrCode, CSMsgPartyApiLeaderBattleReadyReq, CSMsgPartyApiLeaderBattleReadyRes>, APlayerState, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<CSMsgPartyApiMemberEnterBattleReq, Action<MsgErrCode, CSMsgPartyApiMemberEnterBattleReq, CSMsgPartyApiMemberEnterBattleRes>, APlayerState, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<CSMsgPartyApiLeaderRequestHelpReq, Action<MsgErrCode, CSMsgPartyApiLeaderRequestHelpReq, CSMsgPartyApiLeaderRequestHelpRes>, APlayerState, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<CSMsgPartyApiLeaderCancelHelpReq, Action<MsgErrCode, CSMsgPartyApiLeaderCancelHelpReq, CSMsgPartyApiLeaderCancelHelpRes>, APlayerState, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<CSMsgChapterConfirmAwardReq, Action<MsgErrCode, CSMsgChapterConfirmAwardReq, CSMsgChapterConfirmAwardRes>, APlayerState, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<CSMsgCollectionViewCardPortraitReq, Action<MsgErrCode, CSMsgCollectionViewCardPortraitReq, CSMsgCollectionViewCardPortraitRes>, APlayerState, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<CSMsgActorSetSoulSkillReq, Action<MsgErrCode, CSMsgActorSetSoulSkillReq, CSMsgActorSetSoulSkillRes>, APlayerState, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<CSMsgGardenUpdateCropOutputReq, Action<MsgErrCode, CSMsgGardenUpdateCropOutputReq, CSMsgGardenUpdateCropOutputRes>, APlayerState, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<CSMsgGardenCollectCropOutputReq, Action<MsgErrCode, CSMsgGardenCollectCropOutputReq, CSMsgGardenCollectCropOutputRes>, APlayerState, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<CSMsgGardenPlantAllSeedsReq, Action<MsgErrCode, CSMsgGardenPlantAllSeedsReq, CSMsgGardenPlantAllSeedsRes>, APlayerState, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<CSMsgBagActivateWeaponReq, Action<MsgErrCode, CSMsgBagActivateWeaponReq, CSMsgBagActivateWeaponRes>, APlayerState, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<CSMsgBagGetAlchemyNpcCommunicationAwardReq, Action<MsgErrCode, CSMsgBagGetAlchemyNpcCommunicationAwardReq, CSMsgBagGetAlchemyNpcCommunicationAwardRes>, APlayerState, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<CSMsgBagUpdateAlchemyNpcCommunicationStatusReq, Action<MsgErrCode, CSMsgBagUpdateAlchemyNpcCommunicationStatusReq, CSMsgBagUpdateAlchemyNpcCommunicationStatusRes>, APlayerState, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<CSMsgBagHuluUpgradeReq, Action<MsgErrCode, CSMsgBagHuluUpgradeReq, CSMsgBagHuluUpgradeRes>, APlayerState, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<CSMsgBagCollectDropSoulSkillReq, Action<MsgErrCode, CSMsgBagCollectDropSoulSkillReq, CSMsgBagCollectDropSoulSkillRes>, APlayerState, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<CSMsgActorWearAccessoryReq, Action<MsgErrCode, CSMsgActorWearAccessoryReq, CSMsgActorWearAccessoryRes>, APlayerState, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<CSMsgActorUnWearAccessoryReq, Action<MsgErrCode, CSMsgActorUnWearAccessoryReq, CSMsgActorUnWearAccessoryRes>, APlayerState, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<CSMsgAchievementEnterLevelReq, Action<MsgErrCode, CSMsgAchievementEnterLevelReq, CSMsgAchievementEnterLevelRes>, APlayerState, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<CSMsgBagSoulSkillUpgradeReq, Action<MsgErrCode, CSMsgBagSoulSkillUpgradeReq, CSMsgBagSoulSkillUpgradeRes>, APlayerState, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<CSMsgActorActivateLegacyTalentReq, Action<MsgErrCode, CSMsgActorActivateLegacyTalentReq, CSMsgActorActivateLegacyTalentRes>, APlayerState, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<CSMsgActorRebuildLegacyTalentReq, Action<MsgErrCode, CSMsgActorRebuildLegacyTalentReq, CSMsgActorRebuildLegacyTalentRes>, APlayerState, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<CSMsgBagRebuildAttrItemReq, Action<MsgErrCode, CSMsgBagRebuildAttrItemReq, CSMsgBagRebuildAttrItemRes>, APlayerState, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<CSMsgActivitiesResumeReq, Action<MsgErrCode, CSMsgActivitiesResumeReq, CSMsgActivitiesResumeRes>, APlayerState, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<CSMsgCollectionCollectItemReq, Action<MsgErrCode, CSMsgCollectionCollectItemReq, CSMsgCollectionCollectItemRes>, APlayerState, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<CSMsgChapterPrologueCompletedReq, Action<MsgErrCode, CSMsgChapterPrologueCompletedReq, CSMsgChapterPrologueCompletedRes>, APlayerState, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<CSMsgAttrRefreshReq, Action<MsgErrCode, CSMsgAttrRefreshReq, CSMsgAttrRefreshRes>, APlayerState, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<CSMsgMiscTestLargePackageReq, Action<MsgErrCode, CSMsgMiscTestLargePackageReq, CSMsgMiscTestLargePackageRes>, APlayerState, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<CSMsgInteractSoulBottleGainItemReq, Action<MsgErrCode, CSMsgInteractSoulBottleGainItemReq, CSMsgInteractSoulBottleGainItemRes>, APlayerState, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<CSMsgBossRushBattleStartReq, Action<MsgErrCode, CSMsgBossRushBattleStartReq, CSMsgBossRushBattleStartRes>, APlayerState, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<CSMsgBossRushBattleCompleteReq, Action<MsgErrCode, CSMsgBossRushBattleCompleteReq, CSMsgBossRushBattleCompleteRes>, APlayerState, bool>();
	}

	public static void RegisterDelegateConvertor(ILRuntime.Runtime.Enviorment.AppDomain appdomain)
	{
		appdomain.DelegateManager.RegisterDelegateConvertor<BTF_EventCollectionCS.Del_RoleLogin>((Delegate act) => (BTF_EventCollectionCS.Del_RoleLogin)delegate(CSMsgRoleLoginReq RoleLogin, Action<MsgErrCode, CSMsgRoleLoginReq, CSMsgRoleLoginRes> CallBack, APlayerState PlayerState, bool AllPlayer)
		{
			((Action<CSMsgRoleLoginReq, Action<MsgErrCode, CSMsgRoleLoginReq, CSMsgRoleLoginRes>, APlayerState, bool>)act)(RoleLogin, CallBack, PlayerState, AllPlayer);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BTF_EventCollectionCS.Del_RoleLogout>((Delegate act) => (BTF_EventCollectionCS.Del_RoleLogout)delegate(CSMsgRoleLogoutReq RoleLogout, Action<MsgErrCode, CSMsgRoleLogoutReq, CSMsgRoleLogoutRes> CallBack, APlayerState PlayerState, bool AllPlayer)
		{
			((Action<CSMsgRoleLogoutReq, Action<MsgErrCode, CSMsgRoleLogoutReq, CSMsgRoleLogoutRes>, APlayerState, bool>)act)(RoleLogout, CallBack, PlayerState, AllPlayer);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BTF_EventCollectionCS.Del_RoleKick>((Delegate act) => (BTF_EventCollectionCS.Del_RoleKick)delegate(CSMsgRoleKickReq RoleKick, Action<MsgErrCode, CSMsgRoleKickReq, CSMsgRoleKickRes> CallBack, APlayerState PlayerState, bool AllPlayer)
		{
			((Action<CSMsgRoleKickReq, Action<MsgErrCode, CSMsgRoleKickReq, CSMsgRoleKickRes>, APlayerState, bool>)act)(RoleKick, CallBack, PlayerState, AllPlayer);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BTF_EventCollectionCS.Del_RoleDataNotify>((Delegate act) => (BTF_EventCollectionCS.Del_RoleDataNotify)delegate(CSMsgRoleDataNotifyReq RoleDataNotify, Action<MsgErrCode, CSMsgRoleDataNotifyReq, CSMsgRoleDataNotifyRes> CallBack, APlayerState PlayerState, bool AllPlayer)
		{
			((Action<CSMsgRoleDataNotifyReq, Action<MsgErrCode, CSMsgRoleDataNotifyReq, CSMsgRoleDataNotifyRes>, APlayerState, bool>)act)(RoleDataNotify, CallBack, PlayerState, AllPlayer);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BTF_EventCollectionCS.Del_RoleRandomName>((Delegate act) => (BTF_EventCollectionCS.Del_RoleRandomName)delegate(CSMsgRoleRandomNameReq RoleRandomName, Action<MsgErrCode, CSMsgRoleRandomNameReq, CSMsgRoleRandomNameRes> CallBack, APlayerState PlayerState, bool AllPlayer)
		{
			((Action<CSMsgRoleRandomNameReq, Action<MsgErrCode, CSMsgRoleRandomNameReq, CSMsgRoleRandomNameRes>, APlayerState, bool>)act)(RoleRandomName, CallBack, PlayerState, AllPlayer);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BTF_EventCollectionCS.Del_RoleChangeName>((Delegate act) => (BTF_EventCollectionCS.Del_RoleChangeName)delegate(CSMsgRoleChangeNameReq RoleChangeName, Action<MsgErrCode, CSMsgRoleChangeNameReq, CSMsgRoleChangeNameRes> CallBack, APlayerState PlayerState, bool AllPlayer)
		{
			((Action<CSMsgRoleChangeNameReq, Action<MsgErrCode, CSMsgRoleChangeNameReq, CSMsgRoleChangeNameRes>, APlayerState, bool>)act)(RoleChangeName, CallBack, PlayerState, AllPlayer);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BTF_EventCollectionCS.Del_MiscCreateRole>((Delegate act) => (BTF_EventCollectionCS.Del_MiscCreateRole)delegate(CSMsgMiscCreateRoleReq MiscCreateRole, Action<MsgErrCode, CSMsgMiscCreateRoleReq, CSMsgMiscCreateRoleRes> CallBack, APlayerState PlayerState, bool AllPlayer)
		{
			((Action<CSMsgMiscCreateRoleReq, Action<MsgErrCode, CSMsgMiscCreateRoleReq, CSMsgMiscCreateRoleRes>, APlayerState, bool>)act)(MiscCreateRole, CallBack, PlayerState, AllPlayer);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BTF_EventCollectionCS.Del_MiscExecGM>((Delegate act) => (BTF_EventCollectionCS.Del_MiscExecGM)delegate(CSMsgMiscExecGMReq MiscExecGM, Action<MsgErrCode, CSMsgMiscExecGMReq, CSMsgMiscExecGMRes> CallBack, APlayerState PlayerState, bool AllPlayer)
		{
			((Action<CSMsgMiscExecGMReq, Action<MsgErrCode, CSMsgMiscExecGMReq, CSMsgMiscExecGMRes>, APlayerState, bool>)act)(MiscExecGM, CallBack, PlayerState, AllPlayer);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BTF_EventCollectionCS.Del_MiscHeartBeat>((Delegate act) => (BTF_EventCollectionCS.Del_MiscHeartBeat)delegate(CSMsgMiscHeartBeatReq MiscHeartBeat, Action<MsgErrCode, CSMsgMiscHeartBeatReq, CSMsgMiscHeartBeatRes> CallBack, APlayerState PlayerState, bool AllPlayer)
		{
			((Action<CSMsgMiscHeartBeatReq, Action<MsgErrCode, CSMsgMiscHeartBeatReq, CSMsgMiscHeartBeatRes>, APlayerState, bool>)act)(MiscHeartBeat, CallBack, PlayerState, AllPlayer);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BTF_EventCollectionCS.Del_MiscCheckRes>((Delegate act) => (BTF_EventCollectionCS.Del_MiscCheckRes)delegate(CSMsgMiscCheckResReq MiscCheckRes, Action<MsgErrCode, CSMsgMiscCheckResReq, CSMsgMiscCheckResRes> CallBack, APlayerState PlayerState, bool AllPlayer)
		{
			((Action<CSMsgMiscCheckResReq, Action<MsgErrCode, CSMsgMiscCheckResReq, CSMsgMiscCheckResRes>, APlayerState, bool>)act)(MiscCheckRes, CallBack, PlayerState, AllPlayer);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BTF_EventCollectionCS.Del_AwolMsgGetList>((Delegate act) => (BTF_EventCollectionCS.Del_AwolMsgGetList)delegate(CSMsgAwolMsgGetListReq AwolMsgGetList, Action<MsgErrCode, CSMsgAwolMsgGetListReq, CSMsgAwolMsgGetListRes> CallBack, APlayerState PlayerState, bool AllPlayer)
		{
			((Action<CSMsgAwolMsgGetListReq, Action<MsgErrCode, CSMsgAwolMsgGetListReq, CSMsgAwolMsgGetListRes>, APlayerState, bool>)act)(AwolMsgGetList, CallBack, PlayerState, AllPlayer);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BTF_EventCollectionCS.Del_AwolMsgRemove>((Delegate act) => (BTF_EventCollectionCS.Del_AwolMsgRemove)delegate(CSMsgAwolMsgRemoveReq AwolMsgRemove, Action<MsgErrCode, CSMsgAwolMsgRemoveReq, CSMsgAwolMsgRemoveRes> CallBack, APlayerState PlayerState, bool AllPlayer)
		{
			((Action<CSMsgAwolMsgRemoveReq, Action<MsgErrCode, CSMsgAwolMsgRemoveReq, CSMsgAwolMsgRemoveRes>, APlayerState, bool>)act)(AwolMsgRemove, CallBack, PlayerState, AllPlayer);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BTF_EventCollectionCS.Del_AwolMsgUpdate>((Delegate act) => (BTF_EventCollectionCS.Del_AwolMsgUpdate)delegate(CSMsgAwolMsgUpdateReq AwolMsgUpdate, Action<MsgErrCode, CSMsgAwolMsgUpdateReq, CSMsgAwolMsgUpdateRes> CallBack, APlayerState PlayerState, bool AllPlayer)
		{
			((Action<CSMsgAwolMsgUpdateReq, Action<MsgErrCode, CSMsgAwolMsgUpdateReq, CSMsgAwolMsgUpdateRes>, APlayerState, bool>)act)(AwolMsgUpdate, CallBack, PlayerState, AllPlayer);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BTF_EventCollectionCS.Del_AwolMsgSend>((Delegate act) => (BTF_EventCollectionCS.Del_AwolMsgSend)delegate(CSMsgAwolMsgSendReq AwolMsgSend, Action<MsgErrCode, CSMsgAwolMsgSendReq, CSMsgAwolMsgSendRes> CallBack, APlayerState PlayerState, bool AllPlayer)
		{
			((Action<CSMsgAwolMsgSendReq, Action<MsgErrCode, CSMsgAwolMsgSendReq, CSMsgAwolMsgSendRes>, APlayerState, bool>)act)(AwolMsgSend, CallBack, PlayerState, AllPlayer);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BTF_EventCollectionCS.Del_AwolMsgNotifyUpdate>((Delegate act) => (BTF_EventCollectionCS.Del_AwolMsgNotifyUpdate)delegate(CSMsgAwolMsgNotifyUpdateReq AwolMsgNotifyUpdate, Action<MsgErrCode, CSMsgAwolMsgNotifyUpdateReq, CSMsgAwolMsgNotifyUpdateRes> CallBack, APlayerState PlayerState, bool AllPlayer)
		{
			((Action<CSMsgAwolMsgNotifyUpdateReq, Action<MsgErrCode, CSMsgAwolMsgNotifyUpdateReq, CSMsgAwolMsgNotifyUpdateRes>, APlayerState, bool>)act)(AwolMsgNotifyUpdate, CallBack, PlayerState, AllPlayer);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BTF_EventCollectionCS.Del_AwolMsgNotifyRemove>((Delegate act) => (BTF_EventCollectionCS.Del_AwolMsgNotifyRemove)delegate(CSMsgAwolMsgNotifyRemoveReq AwolMsgNotifyRemove, Action<MsgErrCode, CSMsgAwolMsgNotifyRemoveReq, CSMsgAwolMsgNotifyRemoveRes> CallBack, APlayerState PlayerState, bool AllPlayer)
		{
			((Action<CSMsgAwolMsgNotifyRemoveReq, Action<MsgErrCode, CSMsgAwolMsgNotifyRemoveReq, CSMsgAwolMsgNotifyRemoveRes>, APlayerState, bool>)act)(AwolMsgNotifyRemove, CallBack, PlayerState, AllPlayer);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BTF_EventCollectionCS.Del_AwolMsgNotifyAdd>((Delegate act) => (BTF_EventCollectionCS.Del_AwolMsgNotifyAdd)delegate(CSMsgAwolMsgNotifyAddReq AwolMsgNotifyAdd, Action<MsgErrCode, CSMsgAwolMsgNotifyAddReq, CSMsgAwolMsgNotifyAddRes> CallBack, APlayerState PlayerState, bool AllPlayer)
		{
			((Action<CSMsgAwolMsgNotifyAddReq, Action<MsgErrCode, CSMsgAwolMsgNotifyAddReq, CSMsgAwolMsgNotifyAddRes>, APlayerState, bool>)act)(AwolMsgNotifyAdd, CallBack, PlayerState, AllPlayer);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BTF_EventCollectionCS.Del_BriefMsgGet>((Delegate act) => (BTF_EventCollectionCS.Del_BriefMsgGet)delegate(CSMsgBriefMsgGetReq BriefMsgGet, Action<MsgErrCode, CSMsgBriefMsgGetReq, CSMsgBriefMsgGetRes> CallBack, APlayerState PlayerState, bool AllPlayer)
		{
			((Action<CSMsgBriefMsgGetReq, Action<MsgErrCode, CSMsgBriefMsgGetReq, CSMsgBriefMsgGetRes>, APlayerState, bool>)act)(BriefMsgGet, CallBack, PlayerState, AllPlayer);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BTF_EventCollectionCS.Del_RankListGet>((Delegate act) => (BTF_EventCollectionCS.Del_RankListGet)delegate(CSMsgRankListGetReq RankListGet, Action<MsgErrCode, CSMsgRankListGetReq, CSMsgRankListGetRes> CallBack, APlayerState PlayerState, bool AllPlayer)
		{
			((Action<CSMsgRankListGetReq, Action<MsgErrCode, CSMsgRankListGetReq, CSMsgRankListGetRes>, APlayerState, bool>)act)(RankListGet, CallBack, PlayerState, AllPlayer);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BTF_EventCollectionCS.Del_BagGainItemList>((Delegate act) => (BTF_EventCollectionCS.Del_BagGainItemList)delegate(CSMsgBagGainItemListReq BagGainItemList, Action<MsgErrCode, CSMsgBagGainItemListReq, CSMsgBagGainItemListRes> CallBack, APlayerState PlayerState, bool AllPlayer)
		{
			((Action<CSMsgBagGainItemListReq, Action<MsgErrCode, CSMsgBagGainItemListReq, CSMsgBagGainItemListRes>, APlayerState, bool>)act)(BagGainItemList, CallBack, PlayerState, AllPlayer);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BTF_EventCollectionCS.Del_BagCostItemList>((Delegate act) => (BTF_EventCollectionCS.Del_BagCostItemList)delegate(CSMsgBagCostItemListReq BagCostItemList, Action<MsgErrCode, CSMsgBagCostItemListReq, CSMsgBagCostItemListRes> CallBack, APlayerState PlayerState, bool AllPlayer)
		{
			((Action<CSMsgBagCostItemListReq, Action<MsgErrCode, CSMsgBagCostItemListReq, CSMsgBagCostItemListRes>, APlayerState, bool>)act)(BagCostItemList, CallBack, PlayerState, AllPlayer);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BTF_EventCollectionCS.Del_BagHuluSetting>((Delegate act) => (BTF_EventCollectionCS.Del_BagHuluSetting)delegate(CSMsgBagHuluSettingReq BagHuluSetting, Action<MsgErrCode, CSMsgBagHuluSettingReq, CSMsgBagHuluSettingRes> CallBack, APlayerState PlayerState, bool AllPlayer)
		{
			((Action<CSMsgBagHuluSettingReq, Action<MsgErrCode, CSMsgBagHuluSettingReq, CSMsgBagHuluSettingRes>, APlayerState, bool>)act)(BagHuluSetting, CallBack, PlayerState, AllPlayer);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BTF_EventCollectionCS.Del_BagAlchemy>((Delegate act) => (BTF_EventCollectionCS.Del_BagAlchemy)delegate(CSMsgBagAlchemyReq BagAlchemy, Action<MsgErrCode, CSMsgBagAlchemyReq, CSMsgBagAlchemyRes> CallBack, APlayerState PlayerState, bool AllPlayer)
		{
			((Action<CSMsgBagAlchemyReq, Action<MsgErrCode, CSMsgBagAlchemyReq, CSMsgBagAlchemyRes>, APlayerState, bool>)act)(BagAlchemy, CallBack, PlayerState, AllPlayer);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BTF_EventCollectionCS.Del_BagWeaponBuild>((Delegate act) => (BTF_EventCollectionCS.Del_BagWeaponBuild)delegate(CSMsgBagWeaponBuildReq BagWeaponBuild, Action<MsgErrCode, CSMsgBagWeaponBuildReq, CSMsgBagWeaponBuildRes> CallBack, APlayerState PlayerState, bool AllPlayer)
		{
			((Action<CSMsgBagWeaponBuildReq, Action<MsgErrCode, CSMsgBagWeaponBuildReq, CSMsgBagWeaponBuildRes>, APlayerState, bool>)act)(BagWeaponBuild, CallBack, PlayerState, AllPlayer);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BTF_EventCollectionCS.Del_BagWeaponReBuild>((Delegate act) => (BTF_EventCollectionCS.Del_BagWeaponReBuild)delegate(CSMsgBagWeaponReBuildReq BagWeaponReBuild, Action<MsgErrCode, CSMsgBagWeaponReBuildReq, CSMsgBagWeaponReBuildRes> CallBack, APlayerState PlayerState, bool AllPlayer)
		{
			((Action<CSMsgBagWeaponReBuildReq, Action<MsgErrCode, CSMsgBagWeaponReBuildReq, CSMsgBagWeaponReBuildRes>, APlayerState, bool>)act)(BagWeaponReBuild, CallBack, PlayerState, AllPlayer);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BTF_EventCollectionCS.Del_BagDropUnitAward>((Delegate act) => (BTF_EventCollectionCS.Del_BagDropUnitAward)delegate(CSMsgBagDropUnitAwardReq BagDropUnitAward, Action<MsgErrCode, CSMsgBagDropUnitAwardReq, CSMsgBagDropUnitAwardRes> CallBack, APlayerState PlayerState, bool AllPlayer)
		{
			((Action<CSMsgBagDropUnitAwardReq, Action<MsgErrCode, CSMsgBagDropUnitAwardReq, CSMsgBagDropUnitAwardRes>, APlayerState, bool>)act)(BagDropUnitAward, CallBack, PlayerState, AllPlayer);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BTF_EventCollectionCS.Del_BagCommDrop>((Delegate act) => (BTF_EventCollectionCS.Del_BagCommDrop)delegate(CSMsgBagCommDropReq BagCommDrop, Action<MsgErrCode, CSMsgBagCommDropReq, CSMsgBagCommDropRes> CallBack, APlayerState PlayerState, bool AllPlayer)
		{
			((Action<CSMsgBagCommDropReq, Action<MsgErrCode, CSMsgBagCommDropReq, CSMsgBagCommDropRes>, APlayerState, bool>)act)(BagCommDrop, CallBack, PlayerState, AllPlayer);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BTF_EventCollectionCS.Del_BagWineUpgrade>((Delegate act) => (BTF_EventCollectionCS.Del_BagWineUpgrade)delegate(CSMsgBagWineUpgradeReq BagWineUpgrade, Action<MsgErrCode, CSMsgBagWineUpgradeReq, CSMsgBagWineUpgradeRes> CallBack, APlayerState PlayerState, bool AllPlayer)
		{
			((Action<CSMsgBagWineUpgradeReq, Action<MsgErrCode, CSMsgBagWineUpgradeReq, CSMsgBagWineUpgradeRes>, APlayerState, bool>)act)(BagWineUpgrade, CallBack, PlayerState, AllPlayer);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BTF_EventCollectionCS.Del_BagWinePartnerSetting>((Delegate act) => (BTF_EventCollectionCS.Del_BagWinePartnerSetting)delegate(CSMsgBagWinePartnerSettingReq BagWinePartnerSetting, Action<MsgErrCode, CSMsgBagWinePartnerSettingReq, CSMsgBagWinePartnerSettingRes> CallBack, APlayerState PlayerState, bool AllPlayer)
		{
			((Action<CSMsgBagWinePartnerSettingReq, Action<MsgErrCode, CSMsgBagWinePartnerSettingReq, CSMsgBagWinePartnerSettingRes>, APlayerState, bool>)act)(BagWinePartnerSetting, CallBack, PlayerState, AllPlayer);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BTF_EventCollectionCS.Del_BagGainEditionAward>((Delegate act) => (BTF_EventCollectionCS.Del_BagGainEditionAward)delegate(CSMsgBagGainEditionAwardReq BagGainEditionAward, Action<MsgErrCode, CSMsgBagGainEditionAwardReq, CSMsgBagGainEditionAwardRes> CallBack, APlayerState PlayerState, bool AllPlayer)
		{
			((Action<CSMsgBagGainEditionAwardReq, Action<MsgErrCode, CSMsgBagGainEditionAwardReq, CSMsgBagGainEditionAwardRes>, APlayerState, bool>)act)(BagGainEditionAward, CallBack, PlayerState, AllPlayer);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BTF_EventCollectionCS.Del_ActorWearEquip>((Delegate act) => (BTF_EventCollectionCS.Del_ActorWearEquip)delegate(CSMsgActorWearEquipReq ActorWearEquip, Action<MsgErrCode, CSMsgActorWearEquipReq, CSMsgActorWearEquipRes> CallBack, APlayerState PlayerState, bool AllPlayer)
		{
			((Action<CSMsgActorWearEquipReq, Action<MsgErrCode, CSMsgActorWearEquipReq, CSMsgActorWearEquipRes>, APlayerState, bool>)act)(ActorWearEquip, CallBack, PlayerState, AllPlayer);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BTF_EventCollectionCS.Del_ActorUnWearEquip>((Delegate act) => (BTF_EventCollectionCS.Del_ActorUnWearEquip)delegate(CSMsgActorUnWearEquipReq ActorUnWearEquip, Action<MsgErrCode, CSMsgActorUnWearEquipReq, CSMsgActorUnWearEquipRes> CallBack, APlayerState PlayerState, bool AllPlayer)
		{
			((Action<CSMsgActorUnWearEquipReq, Action<MsgErrCode, CSMsgActorUnWearEquipReq, CSMsgActorUnWearEquipRes>, APlayerState, bool>)act)(ActorUnWearEquip, CallBack, PlayerState, AllPlayer);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BTF_EventCollectionCS.Del_ActorSetShortCut>((Delegate act) => (BTF_EventCollectionCS.Del_ActorSetShortCut)delegate(CSMsgActorSetShortCutReq ActorSetShortCut, Action<MsgErrCode, CSMsgActorSetShortCutReq, CSMsgActorSetShortCutRes> CallBack, APlayerState PlayerState, bool AllPlayer)
		{
			((Action<CSMsgActorSetShortCutReq, Action<MsgErrCode, CSMsgActorSetShortCutReq, CSMsgActorSetShortCutRes>, APlayerState, bool>)act)(ActorSetShortCut, CallBack, PlayerState, AllPlayer);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BTF_EventCollectionCS.Del_ActorUnSetShortCut>((Delegate act) => (BTF_EventCollectionCS.Del_ActorUnSetShortCut)delegate(CSMsgActorUnSetShortCutReq ActorUnSetShortCut, Action<MsgErrCode, CSMsgActorUnSetShortCutReq, CSMsgActorUnSetShortCutRes> CallBack, APlayerState PlayerState, bool AllPlayer)
		{
			((Action<CSMsgActorUnSetShortCutReq, Action<MsgErrCode, CSMsgActorUnSetShortCutReq, CSMsgActorUnSetShortCutRes>, APlayerState, bool>)act)(ActorUnSetShortCut, CallBack, PlayerState, AllPlayer);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BTF_EventCollectionCS.Del_ActorSetSpell>((Delegate act) => (BTF_EventCollectionCS.Del_ActorSetSpell)delegate(CSMsgActorSetSpellReq ActorSetSpell, Action<MsgErrCode, CSMsgActorSetSpellReq, CSMsgActorSetSpellRes> CallBack, APlayerState PlayerState, bool AllPlayer)
		{
			((Action<CSMsgActorSetSpellReq, Action<MsgErrCode, CSMsgActorSetSpellReq, CSMsgActorSetSpellRes>, APlayerState, bool>)act)(ActorSetSpell, CallBack, PlayerState, AllPlayer);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BTF_EventCollectionCS.Del_ActorUnSetSpell>((Delegate act) => (BTF_EventCollectionCS.Del_ActorUnSetSpell)delegate(CSMsgActorUnSetSpellReq ActorUnSetSpell, Action<MsgErrCode, CSMsgActorUnSetSpellReq, CSMsgActorUnSetSpellRes> CallBack, APlayerState PlayerState, bool AllPlayer)
		{
			((Action<CSMsgActorUnSetSpellReq, Action<MsgErrCode, CSMsgActorUnSetSpellReq, CSMsgActorUnSetSpellRes>, APlayerState, bool>)act)(ActorUnSetSpell, CallBack, PlayerState, AllPlayer);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BTF_EventCollectionCS.Del_ActorSetDefaultSpell>((Delegate act) => (BTF_EventCollectionCS.Del_ActorSetDefaultSpell)delegate(CSMsgActorSetDefaultSpellReq ActorSetDefaultSpell, Action<MsgErrCode, CSMsgActorSetDefaultSpellReq, CSMsgActorSetDefaultSpellRes> CallBack, APlayerState PlayerState, bool AllPlayer)
		{
			((Action<CSMsgActorSetDefaultSpellReq, Action<MsgErrCode, CSMsgActorSetDefaultSpellReq, CSMsgActorSetDefaultSpellRes>, APlayerState, bool>)act)(ActorSetDefaultSpell, CallBack, PlayerState, AllPlayer);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BTF_EventCollectionCS.Del_ActorOnPlayerDeath>((Delegate act) => (BTF_EventCollectionCS.Del_ActorOnPlayerDeath)delegate(CSMsgActorOnPlayerDeathReq ActorOnPlayerDeath, Action<MsgErrCode, CSMsgActorOnPlayerDeathReq, CSMsgActorOnPlayerDeathRes> CallBack, APlayerState PlayerState, bool AllPlayer)
		{
			((Action<CSMsgActorOnPlayerDeathReq, Action<MsgErrCode, CSMsgActorOnPlayerDeathReq, CSMsgActorOnPlayerDeathRes>, APlayerState, bool>)act)(ActorOnPlayerDeath, CallBack, PlayerState, AllPlayer);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BTF_EventCollectionCS.Del_ActorOnPlayerRest>((Delegate act) => (BTF_EventCollectionCS.Del_ActorOnPlayerRest)delegate(CSMsgActorOnPlayerRestReq ActorOnPlayerRest, Action<MsgErrCode, CSMsgActorOnPlayerRestReq, CSMsgActorOnPlayerRestRes> CallBack, APlayerState PlayerState, bool AllPlayer)
		{
			((Action<CSMsgActorOnPlayerRestReq, Action<MsgErrCode, CSMsgActorOnPlayerRestReq, CSMsgActorOnPlayerRestRes>, APlayerState, bool>)act)(ActorOnPlayerRest, CallBack, PlayerState, AllPlayer);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BTF_EventCollectionCS.Del_ActorOnNewGamePlus>((Delegate act) => (BTF_EventCollectionCS.Del_ActorOnNewGamePlus)delegate(CSMsgActorOnNewGamePlusReq ActorOnNewGamePlus, Action<MsgErrCode, CSMsgActorOnNewGamePlusReq, CSMsgActorOnNewGamePlusRes> CallBack, APlayerState PlayerState, bool AllPlayer)
		{
			((Action<CSMsgActorOnNewGamePlusReq, Action<MsgErrCode, CSMsgActorOnNewGamePlusReq, CSMsgActorOnNewGamePlusRes>, APlayerState, bool>)act)(ActorOnNewGamePlus, CallBack, PlayerState, AllPlayer);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BTF_EventCollectionCS.Del_ActorUnLockTalent>((Delegate act) => (BTF_EventCollectionCS.Del_ActorUnLockTalent)delegate(CSMsgActorUnLockTalentReq ActorUnLockTalent, Action<MsgErrCode, CSMsgActorUnLockTalentReq, CSMsgActorUnLockTalentRes> CallBack, APlayerState PlayerState, bool AllPlayer)
		{
			((Action<CSMsgActorUnLockTalentReq, Action<MsgErrCode, CSMsgActorUnLockTalentReq, CSMsgActorUnLockTalentRes>, APlayerState, bool>)act)(ActorUnLockTalent, CallBack, PlayerState, AllPlayer);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BTF_EventCollectionCS.Del_ActorTalentLevelUp>((Delegate act) => (BTF_EventCollectionCS.Del_ActorTalentLevelUp)delegate(CSMsgActorTalentLevelUpReq ActorTalentLevelUp, Action<MsgErrCode, CSMsgActorTalentLevelUpReq, CSMsgActorTalentLevelUpRes> CallBack, APlayerState PlayerState, bool AllPlayer)
		{
			((Action<CSMsgActorTalentLevelUpReq, Action<MsgErrCode, CSMsgActorTalentLevelUpReq, CSMsgActorTalentLevelUpRes>, APlayerState, bool>)act)(ActorTalentLevelUp, CallBack, PlayerState, AllPlayer);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BTF_EventCollectionCS.Del_ActorRebuildTalent>((Delegate act) => (BTF_EventCollectionCS.Del_ActorRebuildTalent)delegate(CSMsgActorRebuildTalentReq ActorRebuildTalent, Action<MsgErrCode, CSMsgActorRebuildTalentReq, CSMsgActorRebuildTalentRes> CallBack, APlayerState PlayerState, bool AllPlayer)
		{
			((Action<CSMsgActorRebuildTalentReq, Action<MsgErrCode, CSMsgActorRebuildTalentReq, CSMsgActorRebuildTalentRes>, APlayerState, bool>)act)(ActorRebuildTalent, CallBack, PlayerState, AllPlayer);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BTF_EventCollectionCS.Del_ActorMeditationUnlock>((Delegate act) => (BTF_EventCollectionCS.Del_ActorMeditationUnlock)delegate(CSMsgActorMeditationUnlockReq ActorMeditationUnlock, Action<MsgErrCode, CSMsgActorMeditationUnlockReq, CSMsgActorMeditationUnlockRes> CallBack, APlayerState PlayerState, bool AllPlayer)
		{
			((Action<CSMsgActorMeditationUnlockReq, Action<MsgErrCode, CSMsgActorMeditationUnlockReq, CSMsgActorMeditationUnlockRes>, APlayerState, bool>)act)(ActorMeditationUnlock, CallBack, PlayerState, AllPlayer);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BTF_EventCollectionCS.Del_ActorOnPlayerExit>((Delegate act) => (BTF_EventCollectionCS.Del_ActorOnPlayerExit)delegate(CSMsgActorOnPlayerExitReq ActorOnPlayerExit, Action<MsgErrCode, CSMsgActorOnPlayerExitReq, CSMsgActorOnPlayerExitRes> CallBack, APlayerState PlayerState, bool AllPlayer)
		{
			((Action<CSMsgActorOnPlayerExitReq, Action<MsgErrCode, CSMsgActorOnPlayerExitReq, CSMsgActorOnPlayerExitRes>, APlayerState, bool>)act)(ActorOnPlayerExit, CallBack, PlayerState, AllPlayer);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BTF_EventCollectionCS.Del_ActorWineSetting>((Delegate act) => (BTF_EventCollectionCS.Del_ActorWineSetting)delegate(CSMsgActorWineSettingReq ActorWineSetting, Action<MsgErrCode, CSMsgActorWineSettingReq, CSMsgActorWineSettingRes> CallBack, APlayerState PlayerState, bool AllPlayer)
		{
			((Action<CSMsgActorWineSettingReq, Action<MsgErrCode, CSMsgActorWineSettingReq, CSMsgActorWineSettingRes>, APlayerState, bool>)act)(ActorWineSetting, CallBack, PlayerState, AllPlayer);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BTF_EventCollectionCS.Del_ShopPayBuyItem>((Delegate act) => (BTF_EventCollectionCS.Del_ShopPayBuyItem)delegate(CSMsgShopPayBuyItemReq ShopPayBuyItem, Action<MsgErrCode, CSMsgShopPayBuyItemReq, CSMsgShopPayBuyItemRes> CallBack, APlayerState PlayerState, bool AllPlayer)
		{
			((Action<CSMsgShopPayBuyItemReq, Action<MsgErrCode, CSMsgShopPayBuyItemReq, CSMsgShopPayBuyItemRes>, APlayerState, bool>)act)(ShopPayBuyItem, CallBack, PlayerState, AllPlayer);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BTF_EventCollectionCS.Del_ShopRefresh>((Delegate act) => (BTF_EventCollectionCS.Del_ShopRefresh)delegate(CSMsgShopRefreshReq ShopRefresh, Action<MsgErrCode, CSMsgShopRefreshReq, CSMsgShopRefreshRes> CallBack, APlayerState PlayerState, bool AllPlayer)
		{
			((Action<CSMsgShopRefreshReq, Action<MsgErrCode, CSMsgShopRefreshReq, CSMsgShopRefreshRes>, APlayerState, bool>)act)(ShopRefresh, CallBack, PlayerState, AllPlayer);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BTF_EventCollectionCS.Del_BagSellItem>((Delegate act) => (BTF_EventCollectionCS.Del_BagSellItem)delegate(CSMsgBagSellItemReq BagSellItem, Action<MsgErrCode, CSMsgBagSellItemReq, CSMsgBagSellItemRes> CallBack, APlayerState PlayerState, bool AllPlayer)
		{
			((Action<CSMsgBagSellItemReq, Action<MsgErrCode, CSMsgBagSellItemReq, CSMsgBagSellItemRes>, APlayerState, bool>)act)(BagSellItem, CallBack, PlayerState, AllPlayer);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BTF_EventCollectionCS.Del_ShopRefreshFlagRemove>((Delegate act) => (BTF_EventCollectionCS.Del_ShopRefreshFlagRemove)delegate(CSMsgShopRefreshFlagRemoveReq ShopRefreshFlagRemove, Action<MsgErrCode, CSMsgShopRefreshFlagRemoveReq, CSMsgShopRefreshFlagRemoveRes> CallBack, APlayerState PlayerState, bool AllPlayer)
		{
			((Action<CSMsgShopRefreshFlagRemoveReq, Action<MsgErrCode, CSMsgShopRefreshFlagRemoveReq, CSMsgShopRefreshFlagRemoveRes>, APlayerState, bool>)act)(ShopRefreshFlagRemove, CallBack, PlayerState, AllPlayer);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BTF_EventCollectionCS.Del_TaskChangeQuestStage>((Delegate act) => (BTF_EventCollectionCS.Del_TaskChangeQuestStage)delegate(CSMsgTaskChangeQuestStageReq TaskChangeQuestStage, Action<MsgErrCode, CSMsgTaskChangeQuestStageReq, CSMsgTaskChangeQuestStageRes> CallBack, APlayerState PlayerState, bool AllPlayer)
		{
			((Action<CSMsgTaskChangeQuestStageReq, Action<MsgErrCode, CSMsgTaskChangeQuestStageReq, CSMsgTaskChangeQuestStageRes>, APlayerState, bool>)act)(TaskChangeQuestStage, CallBack, PlayerState, AllPlayer);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BTF_EventCollectionCS.Del_CollectionInteractiveUnlock>((Delegate act) => (BTF_EventCollectionCS.Del_CollectionInteractiveUnlock)delegate(CSMsgCollectionInteractiveUnlockReq CollectionInteractiveUnlock, Action<MsgErrCode, CSMsgCollectionInteractiveUnlockReq, CSMsgCollectionInteractiveUnlockRes> CallBack, APlayerState PlayerState, bool AllPlayer)
		{
			((Action<CSMsgCollectionInteractiveUnlockReq, Action<MsgErrCode, CSMsgCollectionInteractiveUnlockReq, CSMsgCollectionInteractiveUnlockRes>, APlayerState, bool>)act)(CollectionInteractiveUnlock, CallBack, PlayerState, AllPlayer);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BTF_EventCollectionCS.Del_RedPointRemove>((Delegate act) => (BTF_EventCollectionCS.Del_RedPointRemove)delegate(CSMsgRedPointRemoveReq RedPointRemove, Action<MsgErrCode, CSMsgRedPointRemoveReq, CSMsgRedPointRemoveRes> CallBack, APlayerState PlayerState, bool AllPlayer)
		{
			((Action<CSMsgRedPointRemoveReq, Action<MsgErrCode, CSMsgRedPointRemoveReq, CSMsgRedPointRemoveRes>, APlayerState, bool>)act)(RedPointRemove, CallBack, PlayerState, AllPlayer);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BTF_EventCollectionCS.Del_ActorWeaponTransformFlexType>((Delegate act) => (BTF_EventCollectionCS.Del_ActorWeaponTransformFlexType)delegate(CSMsgActorWeaponTransformFlexTypeReq ActorWeaponTransformFlexType, Action<MsgErrCode, CSMsgActorWeaponTransformFlexTypeReq, CSMsgActorWeaponTransformFlexTypeRes> CallBack, APlayerState PlayerState, bool AllPlayer)
		{
			((Action<CSMsgActorWeaponTransformFlexTypeReq, Action<MsgErrCode, CSMsgActorWeaponTransformFlexTypeReq, CSMsgActorWeaponTransformFlexTypeRes>, APlayerState, bool>)act)(ActorWeaponTransformFlexType, CallBack, PlayerState, AllPlayer);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BTF_EventCollectionCS.Del_ActorKillUnit>((Delegate act) => (BTF_EventCollectionCS.Del_ActorKillUnit)delegate(CSMsgActorKillUnitReq ActorKillUnit, Action<MsgErrCode, CSMsgActorKillUnitReq, CSMsgActorKillUnitRes> CallBack, APlayerState PlayerState, bool AllPlayer)
		{
			((Action<CSMsgActorKillUnitReq, Action<MsgErrCode, CSMsgActorKillUnitReq, CSMsgActorKillUnitRes>, APlayerState, bool>)act)(ActorKillUnit, CallBack, PlayerState, AllPlayer);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BTF_EventCollectionCS.Del_ActorUnitEncounter>((Delegate act) => (BTF_EventCollectionCS.Del_ActorUnitEncounter)delegate(CSMsgActorUnitEncounterReq ActorUnitEncounter, Action<MsgErrCode, CSMsgActorUnitEncounterReq, CSMsgActorUnitEncounterRes> CallBack, APlayerState PlayerState, bool AllPlayer)
		{
			((Action<CSMsgActorUnitEncounterReq, Action<MsgErrCode, CSMsgActorUnitEncounterReq, CSMsgActorUnitEncounterRes>, APlayerState, bool>)act)(ActorUnitEncounter, CallBack, PlayerState, AllPlayer);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BTF_EventCollectionCS.Del_AchievementUnlock>((Delegate act) => (BTF_EventCollectionCS.Del_AchievementUnlock)delegate(CSMsgAchievementUnlockReq AchievementUnlock, Action<MsgErrCode, CSMsgAchievementUnlockReq, CSMsgAchievementUnlockRes> CallBack, APlayerState PlayerState, bool AllPlayer)
		{
			((Action<CSMsgAchievementUnlockReq, Action<MsgErrCode, CSMsgAchievementUnlockReq, CSMsgAchievementUnlockRes>, APlayerState, bool>)act)(AchievementUnlock, CallBack, PlayerState, AllPlayer);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BTF_EventCollectionCS.Del_ChapterEnterNext>((Delegate act) => (BTF_EventCollectionCS.Del_ChapterEnterNext)delegate(CSMsgChapterEnterNextReq ChapterEnterNext, Action<MsgErrCode, CSMsgChapterEnterNextReq, CSMsgChapterEnterNextRes> CallBack, APlayerState PlayerState, bool AllPlayer)
		{
			((Action<CSMsgChapterEnterNextReq, Action<MsgErrCode, CSMsgChapterEnterNextReq, CSMsgChapterEnterNextRes>, APlayerState, bool>)act)(ChapterEnterNext, CallBack, PlayerState, AllPlayer);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BTF_EventCollectionCS.Del_ChapterEnterShow>((Delegate act) => (BTF_EventCollectionCS.Del_ChapterEnterShow)delegate(CSMsgChapterEnterShowReq ChapterEnterShow, Action<MsgErrCode, CSMsgChapterEnterShowReq, CSMsgChapterEnterShowRes> CallBack, APlayerState PlayerState, bool AllPlayer)
		{
			((Action<CSMsgChapterEnterShowReq, Action<MsgErrCode, CSMsgChapterEnterShowReq, CSMsgChapterEnterShowRes>, APlayerState, bool>)act)(ChapterEnterShow, CallBack, PlayerState, AllPlayer);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BTF_EventCollectionCS.Del_ChapterPreviewAward>((Delegate act) => (BTF_EventCollectionCS.Del_ChapterPreviewAward)delegate(CSMsgChapterPreviewAwardReq ChapterPreviewAward, Action<MsgErrCode, CSMsgChapterPreviewAwardReq, CSMsgChapterPreviewAwardRes> CallBack, APlayerState PlayerState, bool AllPlayer)
		{
			((Action<CSMsgChapterPreviewAwardReq, Action<MsgErrCode, CSMsgChapterPreviewAwardReq, CSMsgChapterPreviewAwardRes>, APlayerState, bool>)act)(ChapterPreviewAward, CallBack, PlayerState, AllPlayer);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BTF_EventCollectionCS.Del_MuseumRecordMemories>((Delegate act) => (BTF_EventCollectionCS.Del_MuseumRecordMemories)delegate(CSMsgMuseumRecordMemoriesReq MuseumRecordMemories, Action<MsgErrCode, CSMsgMuseumRecordMemoriesReq, CSMsgMuseumRecordMemoriesRes> CallBack, APlayerState PlayerState, bool AllPlayer)
		{
			((Action<CSMsgMuseumRecordMemoriesReq, Action<MsgErrCode, CSMsgMuseumRecordMemoriesReq, CSMsgMuseumRecordMemoriesRes>, APlayerState, bool>)act)(MuseumRecordMemories, CallBack, PlayerState, AllPlayer);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BTF_EventCollectionCS.Del_MuseumRemoveRedpoint>((Delegate act) => (BTF_EventCollectionCS.Del_MuseumRemoveRedpoint)delegate(CSMsgMuseumRemoveRedpointReq MuseumRemoveRedpoint, Action<MsgErrCode, CSMsgMuseumRemoveRedpointReq, CSMsgMuseumRemoveRedpointRes> CallBack, APlayerState PlayerState, bool AllPlayer)
		{
			((Action<CSMsgMuseumRemoveRedpointReq, Action<MsgErrCode, CSMsgMuseumRemoveRedpointReq, CSMsgMuseumRemoveRedpointRes>, APlayerState, bool>)act)(MuseumRemoveRedpoint, CallBack, PlayerState, AllPlayer);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BTF_EventCollectionCS.Del_AttrChangeNotify>((Delegate act) => (BTF_EventCollectionCS.Del_AttrChangeNotify)delegate(CSMsgAttrChangeNotifyReq AttrChangeNotify, Action<MsgErrCode, CSMsgAttrChangeNotifyReq, CSMsgAttrChangeNotifyRes> CallBack, APlayerState PlayerState, bool AllPlayer)
		{
			((Action<CSMsgAttrChangeNotifyReq, Action<MsgErrCode, CSMsgAttrChangeNotifyReq, CSMsgAttrChangeNotifyRes>, APlayerState, bool>)act)(AttrChangeNotify, CallBack, PlayerState, AllPlayer);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BTF_EventCollectionCS.Del_RoomCreatePartyCS>((Delegate act) => (BTF_EventCollectionCS.Del_RoomCreatePartyCS)delegate(CSMsgRoomCreatePartyCSReq RoomCreatePartyCS, Action<MsgErrCode, CSMsgRoomCreatePartyCSReq, CSMsgRoomCreatePartyCSRes> CallBack, APlayerState PlayerState, bool AllPlayer)
		{
			((Action<CSMsgRoomCreatePartyCSReq, Action<MsgErrCode, CSMsgRoomCreatePartyCSReq, CSMsgRoomCreatePartyCSRes>, APlayerState, bool>)act)(RoomCreatePartyCS, CallBack, PlayerState, AllPlayer);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BTF_EventCollectionCS.Del_RoomJoinPartyCS>((Delegate act) => (BTF_EventCollectionCS.Del_RoomJoinPartyCS)delegate(CSMsgRoomJoinPartyCSReq RoomJoinPartyCS, Action<MsgErrCode, CSMsgRoomJoinPartyCSReq, CSMsgRoomJoinPartyCSRes> CallBack, APlayerState PlayerState, bool AllPlayer)
		{
			((Action<CSMsgRoomJoinPartyCSReq, Action<MsgErrCode, CSMsgRoomJoinPartyCSReq, CSMsgRoomJoinPartyCSRes>, APlayerState, bool>)act)(RoomJoinPartyCS, CallBack, PlayerState, AllPlayer);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BTF_EventCollectionCS.Del_RoomExitPartyCS>((Delegate act) => (BTF_EventCollectionCS.Del_RoomExitPartyCS)delegate(CSMsgRoomExitPartyCSReq RoomExitPartyCS, Action<MsgErrCode, CSMsgRoomExitPartyCSReq, CSMsgRoomExitPartyCSRes> CallBack, APlayerState PlayerState, bool AllPlayer)
		{
			((Action<CSMsgRoomExitPartyCSReq, Action<MsgErrCode, CSMsgRoomExitPartyCSReq, CSMsgRoomExitPartyCSRes>, APlayerState, bool>)act)(RoomExitPartyCS, CallBack, PlayerState, AllPlayer);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BTF_EventCollectionCS.Del_RoomPartyKickMemberCS>((Delegate act) => (BTF_EventCollectionCS.Del_RoomPartyKickMemberCS)delegate(CSMsgRoomPartyKickMemberCSReq RoomPartyKickMemberCS, Action<MsgErrCode, CSMsgRoomPartyKickMemberCSReq, CSMsgRoomPartyKickMemberCSRes> CallBack, APlayerState PlayerState, bool AllPlayer)
		{
			((Action<CSMsgRoomPartyKickMemberCSReq, Action<MsgErrCode, CSMsgRoomPartyKickMemberCSReq, CSMsgRoomPartyKickMemberCSRes>, APlayerState, bool>)act)(RoomPartyKickMemberCS, CallBack, PlayerState, AllPlayer);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BTF_EventCollectionCS.Del_RoomSearchPartyCS>((Delegate act) => (BTF_EventCollectionCS.Del_RoomSearchPartyCS)delegate(CSMsgRoomSearchPartyCSReq RoomSearchPartyCS, Action<MsgErrCode, CSMsgRoomSearchPartyCSReq, CSMsgRoomSearchPartyCSRes> CallBack, APlayerState PlayerState, bool AllPlayer)
		{
			((Action<CSMsgRoomSearchPartyCSReq, Action<MsgErrCode, CSMsgRoomSearchPartyCSReq, CSMsgRoomSearchPartyCSRes>, APlayerState, bool>)act)(RoomSearchPartyCS, CallBack, PlayerState, AllPlayer);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BTF_EventCollectionCS.Del_RoomSearchPartyNotify>((Delegate act) => (BTF_EventCollectionCS.Del_RoomSearchPartyNotify)delegate(CSMsgRoomSearchPartyNotifyReq RoomSearchPartyNotify, Action<MsgErrCode, CSMsgRoomSearchPartyNotifyReq, CSMsgRoomSearchPartyNotifyRes> CallBack, APlayerState PlayerState, bool AllPlayer)
		{
			((Action<CSMsgRoomSearchPartyNotifyReq, Action<MsgErrCode, CSMsgRoomSearchPartyNotifyReq, CSMsgRoomSearchPartyNotifyRes>, APlayerState, bool>)act)(RoomSearchPartyNotify, CallBack, PlayerState, AllPlayer);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BTF_EventCollectionCS.Del_RoomQueryPartyInfoCS>((Delegate act) => (BTF_EventCollectionCS.Del_RoomQueryPartyInfoCS)delegate(CSMsgRoomQueryPartyInfoCSReq RoomQueryPartyInfoCS, Action<MsgErrCode, CSMsgRoomQueryPartyInfoCSReq, CSMsgRoomQueryPartyInfoCSRes> CallBack, APlayerState PlayerState, bool AllPlayer)
		{
			((Action<CSMsgRoomQueryPartyInfoCSReq, Action<MsgErrCode, CSMsgRoomQueryPartyInfoCSReq, CSMsgRoomQueryPartyInfoCSRes>, APlayerState, bool>)act)(RoomQueryPartyInfoCS, CallBack, PlayerState, AllPlayer);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BTF_EventCollectionCS.Del_RoomPartyHeartBeatCS>((Delegate act) => (BTF_EventCollectionCS.Del_RoomPartyHeartBeatCS)delegate(CSMsgRoomPartyHeartBeatCSReq RoomPartyHeartBeatCS, Action<MsgErrCode, CSMsgRoomPartyHeartBeatCSReq, CSMsgRoomPartyHeartBeatCSRes> CallBack, APlayerState PlayerState, bool AllPlayer)
		{
			((Action<CSMsgRoomPartyHeartBeatCSReq, Action<MsgErrCode, CSMsgRoomPartyHeartBeatCSReq, CSMsgRoomPartyHeartBeatCSRes>, APlayerState, bool>)act)(RoomPartyHeartBeatCS, CallBack, PlayerState, AllPlayer);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BTF_EventCollectionCS.Del_RoomPartyEventNotify>((Delegate act) => (BTF_EventCollectionCS.Del_RoomPartyEventNotify)delegate(CSMsgRoomPartyEventNotifyReq RoomPartyEventNotify, Action<MsgErrCode, CSMsgRoomPartyEventNotifyReq, CSMsgRoomPartyEventNotifyRes> CallBack, APlayerState PlayerState, bool AllPlayer)
		{
			((Action<CSMsgRoomPartyEventNotifyReq, Action<MsgErrCode, CSMsgRoomPartyEventNotifyReq, CSMsgRoomPartyEventNotifyRes>, APlayerState, bool>)act)(RoomPartyEventNotify, CallBack, PlayerState, AllPlayer);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BTF_EventCollectionCS.Del_RoomSendPartyBattleMessageCS>((Delegate act) => (BTF_EventCollectionCS.Del_RoomSendPartyBattleMessageCS)delegate(CSMsgRoomSendPartyBattleMessageCSReq RoomSendPartyBattleMessageCS, Action<MsgErrCode, CSMsgRoomSendPartyBattleMessageCSReq, CSMsgRoomSendPartyBattleMessageCSRes> CallBack, APlayerState PlayerState, bool AllPlayer)
		{
			((Action<CSMsgRoomSendPartyBattleMessageCSReq, Action<MsgErrCode, CSMsgRoomSendPartyBattleMessageCSReq, CSMsgRoomSendPartyBattleMessageCSRes>, APlayerState, bool>)act)(RoomSendPartyBattleMessageCS, CallBack, PlayerState, AllPlayer);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BTF_EventCollectionCS.Del_RoomPartyBattleMessageNotify>((Delegate act) => (BTF_EventCollectionCS.Del_RoomPartyBattleMessageNotify)delegate(CSMsgRoomPartyBattleMessageNotifyReq RoomPartyBattleMessageNotify, Action<MsgErrCode, CSMsgRoomPartyBattleMessageNotifyReq, CSMsgRoomPartyBattleMessageNotifyRes> CallBack, APlayerState PlayerState, bool AllPlayer)
		{
			((Action<CSMsgRoomPartyBattleMessageNotifyReq, Action<MsgErrCode, CSMsgRoomPartyBattleMessageNotifyReq, CSMsgRoomPartyBattleMessageNotifyRes>, APlayerState, bool>)act)(RoomPartyBattleMessageNotify, CallBack, PlayerState, AllPlayer);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BTF_EventCollectionCS.Del_RoomPartyMemberUpdateCS>((Delegate act) => (BTF_EventCollectionCS.Del_RoomPartyMemberUpdateCS)delegate(CSMsgRoomPartyMemberUpdateCSReq RoomPartyMemberUpdateCS, Action<MsgErrCode, CSMsgRoomPartyMemberUpdateCSReq, CSMsgRoomPartyMemberUpdateCSRes> CallBack, APlayerState PlayerState, bool AllPlayer)
		{
			((Action<CSMsgRoomPartyMemberUpdateCSReq, Action<MsgErrCode, CSMsgRoomPartyMemberUpdateCSReq, CSMsgRoomPartyMemberUpdateCSRes>, APlayerState, bool>)act)(RoomPartyMemberUpdateCS, CallBack, PlayerState, AllPlayer);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BTF_EventCollectionCS.Del_RoomCreatePartyTaskCS>((Delegate act) => (BTF_EventCollectionCS.Del_RoomCreatePartyTaskCS)delegate(CSMsgRoomCreatePartyTaskCSReq RoomCreatePartyTaskCS, Action<MsgErrCode, CSMsgRoomCreatePartyTaskCSReq, CSMsgRoomCreatePartyTaskCSRes> CallBack, APlayerState PlayerState, bool AllPlayer)
		{
			((Action<CSMsgRoomCreatePartyTaskCSReq, Action<MsgErrCode, CSMsgRoomCreatePartyTaskCSReq, CSMsgRoomCreatePartyTaskCSRes>, APlayerState, bool>)act)(RoomCreatePartyTaskCS, CallBack, PlayerState, AllPlayer);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BTF_EventCollectionCS.Del_RoomUpdatePartyTaskCS>((Delegate act) => (BTF_EventCollectionCS.Del_RoomUpdatePartyTaskCS)delegate(CSMsgRoomUpdatePartyTaskCSReq RoomUpdatePartyTaskCS, Action<MsgErrCode, CSMsgRoomUpdatePartyTaskCSReq, CSMsgRoomUpdatePartyTaskCSRes> CallBack, APlayerState PlayerState, bool AllPlayer)
		{
			((Action<CSMsgRoomUpdatePartyTaskCSReq, Action<MsgErrCode, CSMsgRoomUpdatePartyTaskCSReq, CSMsgRoomUpdatePartyTaskCSRes>, APlayerState, bool>)act)(RoomUpdatePartyTaskCS, CallBack, PlayerState, AllPlayer);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BTF_EventCollectionCS.Del_RoomPartyTaskFinishCS>((Delegate act) => (BTF_EventCollectionCS.Del_RoomPartyTaskFinishCS)delegate(CSMsgRoomPartyTaskFinishCSReq RoomPartyTaskFinishCS, Action<MsgErrCode, CSMsgRoomPartyTaskFinishCSReq, CSMsgRoomPartyTaskFinishCSRes> CallBack, APlayerState PlayerState, bool AllPlayer)
		{
			((Action<CSMsgRoomPartyTaskFinishCSReq, Action<MsgErrCode, CSMsgRoomPartyTaskFinishCSReq, CSMsgRoomPartyTaskFinishCSRes>, APlayerState, bool>)act)(RoomPartyTaskFinishCS, CallBack, PlayerState, AllPlayer);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BTF_EventCollectionCS.Del_BagMultiplayerDrop>((Delegate act) => (BTF_EventCollectionCS.Del_BagMultiplayerDrop)delegate(CSMsgBagMultiplayerDropReq BagMultiplayerDrop, Action<MsgErrCode, CSMsgBagMultiplayerDropReq, CSMsgBagMultiplayerDropRes> CallBack, APlayerState PlayerState, bool AllPlayer)
		{
			((Action<CSMsgBagMultiplayerDropReq, Action<MsgErrCode, CSMsgBagMultiplayerDropReq, CSMsgBagMultiplayerDropRes>, APlayerState, bool>)act)(BagMultiplayerDrop, CallBack, PlayerState, AllPlayer);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BTF_EventCollectionCS.Del_ChapterGameComplete>((Delegate act) => (BTF_EventCollectionCS.Del_ChapterGameComplete)delegate(CSMsgChapterGameCompleteReq ChapterGameComplete, Action<MsgErrCode, CSMsgChapterGameCompleteReq, CSMsgChapterGameCompleteRes> CallBack, APlayerState PlayerState, bool AllPlayer)
		{
			((Action<CSMsgChapterGameCompleteReq, Action<MsgErrCode, CSMsgChapterGameCompleteReq, CSMsgChapterGameCompleteRes>, APlayerState, bool>)act)(ChapterGameComplete, CallBack, PlayerState, AllPlayer);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BTF_EventCollectionCS.Del_CollectionReadCardStory>((Delegate act) => (BTF_EventCollectionCS.Del_CollectionReadCardStory)delegate(CSMsgCollectionReadCardStoryReq CollectionReadCardStory, Action<MsgErrCode, CSMsgCollectionReadCardStoryReq, CSMsgCollectionReadCardStoryRes> CallBack, APlayerState PlayerState, bool AllPlayer)
		{
			((Action<CSMsgCollectionReadCardStoryReq, Action<MsgErrCode, CSMsgCollectionReadCardStoryReq, CSMsgCollectionReadCardStoryRes>, APlayerState, bool>)act)(CollectionReadCardStory, CallBack, PlayerState, AllPlayer);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BTF_EventCollectionCS.Del_BagArmorUpgrade>((Delegate act) => (BTF_EventCollectionCS.Del_BagArmorUpgrade)delegate(CSMsgBagArmorUpgradeReq BagArmorUpgrade, Action<MsgErrCode, CSMsgBagArmorUpgradeReq, CSMsgBagArmorUpgradeRes> CallBack, APlayerState PlayerState, bool AllPlayer)
		{
			((Action<CSMsgBagArmorUpgradeReq, Action<MsgErrCode, CSMsgBagArmorUpgradeReq, CSMsgBagArmorUpgradeRes>, APlayerState, bool>)act)(BagArmorUpgrade, CallBack, PlayerState, AllPlayer);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BTF_EventCollectionCS.Del_BagDropCollectionAward>((Delegate act) => (BTF_EventCollectionCS.Del_BagDropCollectionAward)delegate(CSMsgBagDropCollectionAwardReq BagDropCollectionAward, Action<MsgErrCode, CSMsgBagDropCollectionAwardReq, CSMsgBagDropCollectionAwardRes> CallBack, APlayerState PlayerState, bool AllPlayer)
		{
			((Action<CSMsgBagDropCollectionAwardReq, Action<MsgErrCode, CSMsgBagDropCollectionAwardReq, CSMsgBagDropCollectionAwardRes>, APlayerState, bool>)act)(BagDropCollectionAward, CallBack, PlayerState, AllPlayer);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BTF_EventCollectionCS.Del_PartyApiCreateOnlineParty>((Delegate act) => (BTF_EventCollectionCS.Del_PartyApiCreateOnlineParty)delegate(CSMsgPartyApiCreateOnlinePartyReq PartyApiCreateOnlineParty, Action<MsgErrCode, CSMsgPartyApiCreateOnlinePartyReq, CSMsgPartyApiCreateOnlinePartyRes> CallBack, APlayerState PlayerState, bool AllPlayer)
		{
			((Action<CSMsgPartyApiCreateOnlinePartyReq, Action<MsgErrCode, CSMsgPartyApiCreateOnlinePartyReq, CSMsgPartyApiCreateOnlinePartyRes>, APlayerState, bool>)act)(PartyApiCreateOnlineParty, CallBack, PlayerState, AllPlayer);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BTF_EventCollectionCS.Del_PartyApiSearchParty>((Delegate act) => (BTF_EventCollectionCS.Del_PartyApiSearchParty)delegate(CSMsgPartyApiSearchPartyReq PartyApiSearchParty, Action<MsgErrCode, CSMsgPartyApiSearchPartyReq, CSMsgPartyApiSearchPartyRes> CallBack, APlayerState PlayerState, bool AllPlayer)
		{
			((Action<CSMsgPartyApiSearchPartyReq, Action<MsgErrCode, CSMsgPartyApiSearchPartyReq, CSMsgPartyApiSearchPartyRes>, APlayerState, bool>)act)(PartyApiSearchParty, CallBack, PlayerState, AllPlayer);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BTF_EventCollectionCS.Del_PartyApiJoinParty>((Delegate act) => (BTF_EventCollectionCS.Del_PartyApiJoinParty)delegate(CSMsgPartyApiJoinPartyReq PartyApiJoinParty, Action<MsgErrCode, CSMsgPartyApiJoinPartyReq, CSMsgPartyApiJoinPartyRes> CallBack, APlayerState PlayerState, bool AllPlayer)
		{
			((Action<CSMsgPartyApiJoinPartyReq, Action<MsgErrCode, CSMsgPartyApiJoinPartyReq, CSMsgPartyApiJoinPartyRes>, APlayerState, bool>)act)(PartyApiJoinParty, CallBack, PlayerState, AllPlayer);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BTF_EventCollectionCS.Del_PartyApiLeaderCreateTask>((Delegate act) => (BTF_EventCollectionCS.Del_PartyApiLeaderCreateTask)delegate(CSMsgPartyApiLeaderCreateTaskReq PartyApiLeaderCreateTask, Action<MsgErrCode, CSMsgPartyApiLeaderCreateTaskReq, CSMsgPartyApiLeaderCreateTaskRes> CallBack, APlayerState PlayerState, bool AllPlayer)
		{
			((Action<CSMsgPartyApiLeaderCreateTaskReq, Action<MsgErrCode, CSMsgPartyApiLeaderCreateTaskReq, CSMsgPartyApiLeaderCreateTaskRes>, APlayerState, bool>)act)(PartyApiLeaderCreateTask, CallBack, PlayerState, AllPlayer);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BTF_EventCollectionCS.Del_PartyApiMemberTaskReady>((Delegate act) => (BTF_EventCollectionCS.Del_PartyApiMemberTaskReady)delegate(CSMsgPartyApiMemberTaskReadyReq PartyApiMemberTaskReady, Action<MsgErrCode, CSMsgPartyApiMemberTaskReadyReq, CSMsgPartyApiMemberTaskReadyRes> CallBack, APlayerState PlayerState, bool AllPlayer)
		{
			((Action<CSMsgPartyApiMemberTaskReadyReq, Action<MsgErrCode, CSMsgPartyApiMemberTaskReadyReq, CSMsgPartyApiMemberTaskReadyRes>, APlayerState, bool>)act)(PartyApiMemberTaskReady, CallBack, PlayerState, AllPlayer);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BTF_EventCollectionCS.Del_PartyApiLeaderFinishTask>((Delegate act) => (BTF_EventCollectionCS.Del_PartyApiLeaderFinishTask)delegate(CSMsgPartyApiLeaderFinishTaskReq PartyApiLeaderFinishTask, Action<MsgErrCode, CSMsgPartyApiLeaderFinishTaskReq, CSMsgPartyApiLeaderFinishTaskRes> CallBack, APlayerState PlayerState, bool AllPlayer)
		{
			((Action<CSMsgPartyApiLeaderFinishTaskReq, Action<MsgErrCode, CSMsgPartyApiLeaderFinishTaskReq, CSMsgPartyApiLeaderFinishTaskRes>, APlayerState, bool>)act)(PartyApiLeaderFinishTask, CallBack, PlayerState, AllPlayer);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BTF_EventCollectionCS.Del_PartyApiLeaderCreateBattle>((Delegate act) => (BTF_EventCollectionCS.Del_PartyApiLeaderCreateBattle)delegate(CSMsgPartyApiLeaderCreateBattleReq PartyApiLeaderCreateBattle, Action<MsgErrCode, CSMsgPartyApiLeaderCreateBattleReq, CSMsgPartyApiLeaderCreateBattleRes> CallBack, APlayerState PlayerState, bool AllPlayer)
		{
			((Action<CSMsgPartyApiLeaderCreateBattleReq, Action<MsgErrCode, CSMsgPartyApiLeaderCreateBattleReq, CSMsgPartyApiLeaderCreateBattleRes>, APlayerState, bool>)act)(PartyApiLeaderCreateBattle, CallBack, PlayerState, AllPlayer);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BTF_EventCollectionCS.Del_PartyApiLeaderBattleReady>((Delegate act) => (BTF_EventCollectionCS.Del_PartyApiLeaderBattleReady)delegate(CSMsgPartyApiLeaderBattleReadyReq PartyApiLeaderBattleReady, Action<MsgErrCode, CSMsgPartyApiLeaderBattleReadyReq, CSMsgPartyApiLeaderBattleReadyRes> CallBack, APlayerState PlayerState, bool AllPlayer)
		{
			((Action<CSMsgPartyApiLeaderBattleReadyReq, Action<MsgErrCode, CSMsgPartyApiLeaderBattleReadyReq, CSMsgPartyApiLeaderBattleReadyRes>, APlayerState, bool>)act)(PartyApiLeaderBattleReady, CallBack, PlayerState, AllPlayer);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BTF_EventCollectionCS.Del_PartyApiMemberEnterBattle>((Delegate act) => (BTF_EventCollectionCS.Del_PartyApiMemberEnterBattle)delegate(CSMsgPartyApiMemberEnterBattleReq PartyApiMemberEnterBattle, Action<MsgErrCode, CSMsgPartyApiMemberEnterBattleReq, CSMsgPartyApiMemberEnterBattleRes> CallBack, APlayerState PlayerState, bool AllPlayer)
		{
			((Action<CSMsgPartyApiMemberEnterBattleReq, Action<MsgErrCode, CSMsgPartyApiMemberEnterBattleReq, CSMsgPartyApiMemberEnterBattleRes>, APlayerState, bool>)act)(PartyApiMemberEnterBattle, CallBack, PlayerState, AllPlayer);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BTF_EventCollectionCS.Del_PartyApiLeaderRequestHelp>((Delegate act) => (BTF_EventCollectionCS.Del_PartyApiLeaderRequestHelp)delegate(CSMsgPartyApiLeaderRequestHelpReq PartyApiLeaderRequestHelp, Action<MsgErrCode, CSMsgPartyApiLeaderRequestHelpReq, CSMsgPartyApiLeaderRequestHelpRes> CallBack, APlayerState PlayerState, bool AllPlayer)
		{
			((Action<CSMsgPartyApiLeaderRequestHelpReq, Action<MsgErrCode, CSMsgPartyApiLeaderRequestHelpReq, CSMsgPartyApiLeaderRequestHelpRes>, APlayerState, bool>)act)(PartyApiLeaderRequestHelp, CallBack, PlayerState, AllPlayer);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BTF_EventCollectionCS.Del_PartyApiLeaderCancelHelp>((Delegate act) => (BTF_EventCollectionCS.Del_PartyApiLeaderCancelHelp)delegate(CSMsgPartyApiLeaderCancelHelpReq PartyApiLeaderCancelHelp, Action<MsgErrCode, CSMsgPartyApiLeaderCancelHelpReq, CSMsgPartyApiLeaderCancelHelpRes> CallBack, APlayerState PlayerState, bool AllPlayer)
		{
			((Action<CSMsgPartyApiLeaderCancelHelpReq, Action<MsgErrCode, CSMsgPartyApiLeaderCancelHelpReq, CSMsgPartyApiLeaderCancelHelpRes>, APlayerState, bool>)act)(PartyApiLeaderCancelHelp, CallBack, PlayerState, AllPlayer);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BTF_EventCollectionCS.Del_ChapterConfirmAward>((Delegate act) => (BTF_EventCollectionCS.Del_ChapterConfirmAward)delegate(CSMsgChapterConfirmAwardReq ChapterConfirmAward, Action<MsgErrCode, CSMsgChapterConfirmAwardReq, CSMsgChapterConfirmAwardRes> CallBack, APlayerState PlayerState, bool AllPlayer)
		{
			((Action<CSMsgChapterConfirmAwardReq, Action<MsgErrCode, CSMsgChapterConfirmAwardReq, CSMsgChapterConfirmAwardRes>, APlayerState, bool>)act)(ChapterConfirmAward, CallBack, PlayerState, AllPlayer);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BTF_EventCollectionCS.Del_CollectionViewCardPortrait>((Delegate act) => (BTF_EventCollectionCS.Del_CollectionViewCardPortrait)delegate(CSMsgCollectionViewCardPortraitReq CollectionViewCardPortrait, Action<MsgErrCode, CSMsgCollectionViewCardPortraitReq, CSMsgCollectionViewCardPortraitRes> CallBack, APlayerState PlayerState, bool AllPlayer)
		{
			((Action<CSMsgCollectionViewCardPortraitReq, Action<MsgErrCode, CSMsgCollectionViewCardPortraitReq, CSMsgCollectionViewCardPortraitRes>, APlayerState, bool>)act)(CollectionViewCardPortrait, CallBack, PlayerState, AllPlayer);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BTF_EventCollectionCS.Del_ActorSetSoulSkill>((Delegate act) => (BTF_EventCollectionCS.Del_ActorSetSoulSkill)delegate(CSMsgActorSetSoulSkillReq ActorSetSoulSkill, Action<MsgErrCode, CSMsgActorSetSoulSkillReq, CSMsgActorSetSoulSkillRes> CallBack, APlayerState PlayerState, bool AllPlayer)
		{
			((Action<CSMsgActorSetSoulSkillReq, Action<MsgErrCode, CSMsgActorSetSoulSkillReq, CSMsgActorSetSoulSkillRes>, APlayerState, bool>)act)(ActorSetSoulSkill, CallBack, PlayerState, AllPlayer);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BTF_EventCollectionCS.Del_GardenUpdateCropOutput>((Delegate act) => (BTF_EventCollectionCS.Del_GardenUpdateCropOutput)delegate(CSMsgGardenUpdateCropOutputReq GardenUpdateCropOutput, Action<MsgErrCode, CSMsgGardenUpdateCropOutputReq, CSMsgGardenUpdateCropOutputRes> CallBack, APlayerState PlayerState, bool AllPlayer)
		{
			((Action<CSMsgGardenUpdateCropOutputReq, Action<MsgErrCode, CSMsgGardenUpdateCropOutputReq, CSMsgGardenUpdateCropOutputRes>, APlayerState, bool>)act)(GardenUpdateCropOutput, CallBack, PlayerState, AllPlayer);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BTF_EventCollectionCS.Del_GardenCollectCropOutput>((Delegate act) => (BTF_EventCollectionCS.Del_GardenCollectCropOutput)delegate(CSMsgGardenCollectCropOutputReq GardenCollectCropOutput, Action<MsgErrCode, CSMsgGardenCollectCropOutputReq, CSMsgGardenCollectCropOutputRes> CallBack, APlayerState PlayerState, bool AllPlayer)
		{
			((Action<CSMsgGardenCollectCropOutputReq, Action<MsgErrCode, CSMsgGardenCollectCropOutputReq, CSMsgGardenCollectCropOutputRes>, APlayerState, bool>)act)(GardenCollectCropOutput, CallBack, PlayerState, AllPlayer);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BTF_EventCollectionCS.Del_GardenPlantAllSeeds>((Delegate act) => (BTF_EventCollectionCS.Del_GardenPlantAllSeeds)delegate(CSMsgGardenPlantAllSeedsReq GardenPlantAllSeeds, Action<MsgErrCode, CSMsgGardenPlantAllSeedsReq, CSMsgGardenPlantAllSeedsRes> CallBack, APlayerState PlayerState, bool AllPlayer)
		{
			((Action<CSMsgGardenPlantAllSeedsReq, Action<MsgErrCode, CSMsgGardenPlantAllSeedsReq, CSMsgGardenPlantAllSeedsRes>, APlayerState, bool>)act)(GardenPlantAllSeeds, CallBack, PlayerState, AllPlayer);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BTF_EventCollectionCS.Del_BagActivateWeapon>((Delegate act) => (BTF_EventCollectionCS.Del_BagActivateWeapon)delegate(CSMsgBagActivateWeaponReq BagActivateWeapon, Action<MsgErrCode, CSMsgBagActivateWeaponReq, CSMsgBagActivateWeaponRes> CallBack, APlayerState PlayerState, bool AllPlayer)
		{
			((Action<CSMsgBagActivateWeaponReq, Action<MsgErrCode, CSMsgBagActivateWeaponReq, CSMsgBagActivateWeaponRes>, APlayerState, bool>)act)(BagActivateWeapon, CallBack, PlayerState, AllPlayer);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BTF_EventCollectionCS.Del_BagGetAlchemyNpcCommunicationAward>((Delegate act) => (BTF_EventCollectionCS.Del_BagGetAlchemyNpcCommunicationAward)delegate(CSMsgBagGetAlchemyNpcCommunicationAwardReq BagGetAlchemyNpcCommunicationAward, Action<MsgErrCode, CSMsgBagGetAlchemyNpcCommunicationAwardReq, CSMsgBagGetAlchemyNpcCommunicationAwardRes> CallBack, APlayerState PlayerState, bool AllPlayer)
		{
			((Action<CSMsgBagGetAlchemyNpcCommunicationAwardReq, Action<MsgErrCode, CSMsgBagGetAlchemyNpcCommunicationAwardReq, CSMsgBagGetAlchemyNpcCommunicationAwardRes>, APlayerState, bool>)act)(BagGetAlchemyNpcCommunicationAward, CallBack, PlayerState, AllPlayer);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BTF_EventCollectionCS.Del_BagUpdateAlchemyNpcCommunicationStatus>((Delegate act) => (BTF_EventCollectionCS.Del_BagUpdateAlchemyNpcCommunicationStatus)delegate(CSMsgBagUpdateAlchemyNpcCommunicationStatusReq BagUpdateAlchemyNpcCommunicationStatus, Action<MsgErrCode, CSMsgBagUpdateAlchemyNpcCommunicationStatusReq, CSMsgBagUpdateAlchemyNpcCommunicationStatusRes> CallBack, APlayerState PlayerState, bool AllPlayer)
		{
			((Action<CSMsgBagUpdateAlchemyNpcCommunicationStatusReq, Action<MsgErrCode, CSMsgBagUpdateAlchemyNpcCommunicationStatusReq, CSMsgBagUpdateAlchemyNpcCommunicationStatusRes>, APlayerState, bool>)act)(BagUpdateAlchemyNpcCommunicationStatus, CallBack, PlayerState, AllPlayer);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BTF_EventCollectionCS.Del_BagHuluUpgrade>((Delegate act) => (BTF_EventCollectionCS.Del_BagHuluUpgrade)delegate(CSMsgBagHuluUpgradeReq BagHuluUpgrade, Action<MsgErrCode, CSMsgBagHuluUpgradeReq, CSMsgBagHuluUpgradeRes> CallBack, APlayerState PlayerState, bool AllPlayer)
		{
			((Action<CSMsgBagHuluUpgradeReq, Action<MsgErrCode, CSMsgBagHuluUpgradeReq, CSMsgBagHuluUpgradeRes>, APlayerState, bool>)act)(BagHuluUpgrade, CallBack, PlayerState, AllPlayer);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BTF_EventCollectionCS.Del_BagCollectDropSoulSkill>((Delegate act) => (BTF_EventCollectionCS.Del_BagCollectDropSoulSkill)delegate(CSMsgBagCollectDropSoulSkillReq BagCollectDropSoulSkill, Action<MsgErrCode, CSMsgBagCollectDropSoulSkillReq, CSMsgBagCollectDropSoulSkillRes> CallBack, APlayerState PlayerState, bool AllPlayer)
		{
			((Action<CSMsgBagCollectDropSoulSkillReq, Action<MsgErrCode, CSMsgBagCollectDropSoulSkillReq, CSMsgBagCollectDropSoulSkillRes>, APlayerState, bool>)act)(BagCollectDropSoulSkill, CallBack, PlayerState, AllPlayer);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BTF_EventCollectionCS.Del_ActorWearAccessory>((Delegate act) => (BTF_EventCollectionCS.Del_ActorWearAccessory)delegate(CSMsgActorWearAccessoryReq ActorWearAccessory, Action<MsgErrCode, CSMsgActorWearAccessoryReq, CSMsgActorWearAccessoryRes> CallBack, APlayerState PlayerState, bool AllPlayer)
		{
			((Action<CSMsgActorWearAccessoryReq, Action<MsgErrCode, CSMsgActorWearAccessoryReq, CSMsgActorWearAccessoryRes>, APlayerState, bool>)act)(ActorWearAccessory, CallBack, PlayerState, AllPlayer);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BTF_EventCollectionCS.Del_ActorUnWearAccessory>((Delegate act) => (BTF_EventCollectionCS.Del_ActorUnWearAccessory)delegate(CSMsgActorUnWearAccessoryReq ActorUnWearAccessory, Action<MsgErrCode, CSMsgActorUnWearAccessoryReq, CSMsgActorUnWearAccessoryRes> CallBack, APlayerState PlayerState, bool AllPlayer)
		{
			((Action<CSMsgActorUnWearAccessoryReq, Action<MsgErrCode, CSMsgActorUnWearAccessoryReq, CSMsgActorUnWearAccessoryRes>, APlayerState, bool>)act)(ActorUnWearAccessory, CallBack, PlayerState, AllPlayer);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BTF_EventCollectionCS.Del_AchievementEnterLevel>((Delegate act) => (BTF_EventCollectionCS.Del_AchievementEnterLevel)delegate(CSMsgAchievementEnterLevelReq AchievementEnterLevel, Action<MsgErrCode, CSMsgAchievementEnterLevelReq, CSMsgAchievementEnterLevelRes> CallBack, APlayerState PlayerState, bool AllPlayer)
		{
			((Action<CSMsgAchievementEnterLevelReq, Action<MsgErrCode, CSMsgAchievementEnterLevelReq, CSMsgAchievementEnterLevelRes>, APlayerState, bool>)act)(AchievementEnterLevel, CallBack, PlayerState, AllPlayer);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BTF_EventCollectionCS.Del_BagSoulSkillUpgrade>((Delegate act) => (BTF_EventCollectionCS.Del_BagSoulSkillUpgrade)delegate(CSMsgBagSoulSkillUpgradeReq BagSoulSkillUpgrade, Action<MsgErrCode, CSMsgBagSoulSkillUpgradeReq, CSMsgBagSoulSkillUpgradeRes> CallBack, APlayerState PlayerState, bool AllPlayer)
		{
			((Action<CSMsgBagSoulSkillUpgradeReq, Action<MsgErrCode, CSMsgBagSoulSkillUpgradeReq, CSMsgBagSoulSkillUpgradeRes>, APlayerState, bool>)act)(BagSoulSkillUpgrade, CallBack, PlayerState, AllPlayer);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BTF_EventCollectionCS.Del_ActorActivateLegacyTalent>((Delegate act) => (BTF_EventCollectionCS.Del_ActorActivateLegacyTalent)delegate(CSMsgActorActivateLegacyTalentReq ActorActivateLegacyTalent, Action<MsgErrCode, CSMsgActorActivateLegacyTalentReq, CSMsgActorActivateLegacyTalentRes> CallBack, APlayerState PlayerState, bool AllPlayer)
		{
			((Action<CSMsgActorActivateLegacyTalentReq, Action<MsgErrCode, CSMsgActorActivateLegacyTalentReq, CSMsgActorActivateLegacyTalentRes>, APlayerState, bool>)act)(ActorActivateLegacyTalent, CallBack, PlayerState, AllPlayer);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BTF_EventCollectionCS.Del_ActorRebuildLegacyTalent>((Delegate act) => (BTF_EventCollectionCS.Del_ActorRebuildLegacyTalent)delegate(CSMsgActorRebuildLegacyTalentReq ActorRebuildLegacyTalent, Action<MsgErrCode, CSMsgActorRebuildLegacyTalentReq, CSMsgActorRebuildLegacyTalentRes> CallBack, APlayerState PlayerState, bool AllPlayer)
		{
			((Action<CSMsgActorRebuildLegacyTalentReq, Action<MsgErrCode, CSMsgActorRebuildLegacyTalentReq, CSMsgActorRebuildLegacyTalentRes>, APlayerState, bool>)act)(ActorRebuildLegacyTalent, CallBack, PlayerState, AllPlayer);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BTF_EventCollectionCS.Del_BagRebuildAttrItem>((Delegate act) => (BTF_EventCollectionCS.Del_BagRebuildAttrItem)delegate(CSMsgBagRebuildAttrItemReq BagRebuildAttrItem, Action<MsgErrCode, CSMsgBagRebuildAttrItemReq, CSMsgBagRebuildAttrItemRes> CallBack, APlayerState PlayerState, bool AllPlayer)
		{
			((Action<CSMsgBagRebuildAttrItemReq, Action<MsgErrCode, CSMsgBagRebuildAttrItemReq, CSMsgBagRebuildAttrItemRes>, APlayerState, bool>)act)(BagRebuildAttrItem, CallBack, PlayerState, AllPlayer);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BTF_EventCollectionCS.Del_ActivitiesResume>((Delegate act) => (BTF_EventCollectionCS.Del_ActivitiesResume)delegate(CSMsgActivitiesResumeReq ActivitiesResume, Action<MsgErrCode, CSMsgActivitiesResumeReq, CSMsgActivitiesResumeRes> CallBack, APlayerState PlayerState, bool AllPlayer)
		{
			((Action<CSMsgActivitiesResumeReq, Action<MsgErrCode, CSMsgActivitiesResumeReq, CSMsgActivitiesResumeRes>, APlayerState, bool>)act)(ActivitiesResume, CallBack, PlayerState, AllPlayer);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BTF_EventCollectionCS.Del_CollectionCollectItem>((Delegate act) => (BTF_EventCollectionCS.Del_CollectionCollectItem)delegate(CSMsgCollectionCollectItemReq CollectionCollectItem, Action<MsgErrCode, CSMsgCollectionCollectItemReq, CSMsgCollectionCollectItemRes> CallBack, APlayerState PlayerState, bool AllPlayer)
		{
			((Action<CSMsgCollectionCollectItemReq, Action<MsgErrCode, CSMsgCollectionCollectItemReq, CSMsgCollectionCollectItemRes>, APlayerState, bool>)act)(CollectionCollectItem, CallBack, PlayerState, AllPlayer);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BTF_EventCollectionCS.Del_ChapterPrologueCompleted>((Delegate act) => (BTF_EventCollectionCS.Del_ChapterPrologueCompleted)delegate(CSMsgChapterPrologueCompletedReq ChapterPrologueCompleted, Action<MsgErrCode, CSMsgChapterPrologueCompletedReq, CSMsgChapterPrologueCompletedRes> CallBack, APlayerState PlayerState, bool AllPlayer)
		{
			((Action<CSMsgChapterPrologueCompletedReq, Action<MsgErrCode, CSMsgChapterPrologueCompletedReq, CSMsgChapterPrologueCompletedRes>, APlayerState, bool>)act)(ChapterPrologueCompleted, CallBack, PlayerState, AllPlayer);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BTF_EventCollectionCS.Del_AttrRefresh>((Delegate act) => (BTF_EventCollectionCS.Del_AttrRefresh)delegate(CSMsgAttrRefreshReq AttrRefresh, Action<MsgErrCode, CSMsgAttrRefreshReq, CSMsgAttrRefreshRes> CallBack, APlayerState PlayerState, bool AllPlayer)
		{
			((Action<CSMsgAttrRefreshReq, Action<MsgErrCode, CSMsgAttrRefreshReq, CSMsgAttrRefreshRes>, APlayerState, bool>)act)(AttrRefresh, CallBack, PlayerState, AllPlayer);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BTF_EventCollectionCS.Del_MiscTestLargePackage>((Delegate act) => (BTF_EventCollectionCS.Del_MiscTestLargePackage)delegate(CSMsgMiscTestLargePackageReq MiscTestLargePackage, Action<MsgErrCode, CSMsgMiscTestLargePackageReq, CSMsgMiscTestLargePackageRes> CallBack, APlayerState PlayerState, bool AllPlayer)
		{
			((Action<CSMsgMiscTestLargePackageReq, Action<MsgErrCode, CSMsgMiscTestLargePackageReq, CSMsgMiscTestLargePackageRes>, APlayerState, bool>)act)(MiscTestLargePackage, CallBack, PlayerState, AllPlayer);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BTF_EventCollectionCS.Del_InteractSoulBottleGainItem>((Delegate act) => (BTF_EventCollectionCS.Del_InteractSoulBottleGainItem)delegate(CSMsgInteractSoulBottleGainItemReq InteractSoulBottleGainItem, Action<MsgErrCode, CSMsgInteractSoulBottleGainItemReq, CSMsgInteractSoulBottleGainItemRes> CallBack, APlayerState PlayerState, bool AllPlayer)
		{
			((Action<CSMsgInteractSoulBottleGainItemReq, Action<MsgErrCode, CSMsgInteractSoulBottleGainItemReq, CSMsgInteractSoulBottleGainItemRes>, APlayerState, bool>)act)(InteractSoulBottleGainItem, CallBack, PlayerState, AllPlayer);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BTF_EventCollectionCS.Del_BossRushBattleStart>((Delegate act) => (BTF_EventCollectionCS.Del_BossRushBattleStart)delegate(CSMsgBossRushBattleStartReq BossRushBattleStart, Action<MsgErrCode, CSMsgBossRushBattleStartReq, CSMsgBossRushBattleStartRes> CallBack, APlayerState PlayerState, bool AllPlayer)
		{
			((Action<CSMsgBossRushBattleStartReq, Action<MsgErrCode, CSMsgBossRushBattleStartReq, CSMsgBossRushBattleStartRes>, APlayerState, bool>)act)(BossRushBattleStart, CallBack, PlayerState, AllPlayer);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<BTF_EventCollectionCS.Del_BossRushBattleComplete>((Delegate act) => (BTF_EventCollectionCS.Del_BossRushBattleComplete)delegate(CSMsgBossRushBattleCompleteReq BossRushBattleComplete, Action<MsgErrCode, CSMsgBossRushBattleCompleteReq, CSMsgBossRushBattleCompleteRes> CallBack, APlayerState PlayerState, bool AllPlayer)
		{
			((Action<CSMsgBossRushBattleCompleteReq, Action<MsgErrCode, CSMsgBossRushBattleCompleteReq, CSMsgBossRushBattleCompleteRes>, APlayerState, bool>)act)(BossRushBattleComplete, CallBack, PlayerState, AllPlayer);
		});
	}
}
