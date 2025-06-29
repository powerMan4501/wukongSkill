using System;
using CsB1;
using ResB1;
using UnrealEngine.Engine;

namespace b1;

public class BTF_EventCollectionCS
{
	public delegate void Del_RoleLogin(CSMsgRoleLoginReq RoleLogin, Action<MsgErrCode, CSMsgRoleLoginReq, CSMsgRoleLoginRes> CallBack, APlayerState PlayerState = null, bool AllPlayer = true);

	public delegate void Del_RoleLogout(CSMsgRoleLogoutReq RoleLogout, Action<MsgErrCode, CSMsgRoleLogoutReq, CSMsgRoleLogoutRes> CallBack, APlayerState PlayerState = null, bool AllPlayer = true);

	public delegate void Del_RoleKick(CSMsgRoleKickReq RoleKick, Action<MsgErrCode, CSMsgRoleKickReq, CSMsgRoleKickRes> CallBack, APlayerState PlayerState = null, bool AllPlayer = true);

	public delegate void Del_RoleDataNotify(CSMsgRoleDataNotifyReq RoleDataNotify, Action<MsgErrCode, CSMsgRoleDataNotifyReq, CSMsgRoleDataNotifyRes> CallBack, APlayerState PlayerState = null, bool AllPlayer = true);

	public delegate void Del_RoleRandomName(CSMsgRoleRandomNameReq RoleRandomName, Action<MsgErrCode, CSMsgRoleRandomNameReq, CSMsgRoleRandomNameRes> CallBack, APlayerState PlayerState = null, bool AllPlayer = true);

	public delegate void Del_RoleChangeName(CSMsgRoleChangeNameReq RoleChangeName, Action<MsgErrCode, CSMsgRoleChangeNameReq, CSMsgRoleChangeNameRes> CallBack, APlayerState PlayerState = null, bool AllPlayer = true);

	public delegate void Del_MiscCreateRole(CSMsgMiscCreateRoleReq MiscCreateRole, Action<MsgErrCode, CSMsgMiscCreateRoleReq, CSMsgMiscCreateRoleRes> CallBack, APlayerState PlayerState = null, bool AllPlayer = true);

	public delegate void Del_MiscExecGM(CSMsgMiscExecGMReq MiscExecGM, Action<MsgErrCode, CSMsgMiscExecGMReq, CSMsgMiscExecGMRes> CallBack, APlayerState PlayerState = null, bool AllPlayer = true);

	public delegate void Del_MiscHeartBeat(CSMsgMiscHeartBeatReq MiscHeartBeat, Action<MsgErrCode, CSMsgMiscHeartBeatReq, CSMsgMiscHeartBeatRes> CallBack, APlayerState PlayerState = null, bool AllPlayer = true);

	public delegate void Del_MiscCheckRes(CSMsgMiscCheckResReq MiscCheckRes, Action<MsgErrCode, CSMsgMiscCheckResReq, CSMsgMiscCheckResRes> CallBack, APlayerState PlayerState = null, bool AllPlayer = true);

	public delegate void Del_AwolMsgGetList(CSMsgAwolMsgGetListReq AwolMsgGetList, Action<MsgErrCode, CSMsgAwolMsgGetListReq, CSMsgAwolMsgGetListRes> CallBack, APlayerState PlayerState = null, bool AllPlayer = true);

	public delegate void Del_AwolMsgRemove(CSMsgAwolMsgRemoveReq AwolMsgRemove, Action<MsgErrCode, CSMsgAwolMsgRemoveReq, CSMsgAwolMsgRemoveRes> CallBack, APlayerState PlayerState = null, bool AllPlayer = true);

	public delegate void Del_AwolMsgUpdate(CSMsgAwolMsgUpdateReq AwolMsgUpdate, Action<MsgErrCode, CSMsgAwolMsgUpdateReq, CSMsgAwolMsgUpdateRes> CallBack, APlayerState PlayerState = null, bool AllPlayer = true);

	public delegate void Del_AwolMsgSend(CSMsgAwolMsgSendReq AwolMsgSend, Action<MsgErrCode, CSMsgAwolMsgSendReq, CSMsgAwolMsgSendRes> CallBack, APlayerState PlayerState = null, bool AllPlayer = true);

	public delegate void Del_AwolMsgNotifyUpdate(CSMsgAwolMsgNotifyUpdateReq AwolMsgNotifyUpdate, Action<MsgErrCode, CSMsgAwolMsgNotifyUpdateReq, CSMsgAwolMsgNotifyUpdateRes> CallBack, APlayerState PlayerState = null, bool AllPlayer = true);

	public delegate void Del_AwolMsgNotifyRemove(CSMsgAwolMsgNotifyRemoveReq AwolMsgNotifyRemove, Action<MsgErrCode, CSMsgAwolMsgNotifyRemoveReq, CSMsgAwolMsgNotifyRemoveRes> CallBack, APlayerState PlayerState = null, bool AllPlayer = true);

	public delegate void Del_AwolMsgNotifyAdd(CSMsgAwolMsgNotifyAddReq AwolMsgNotifyAdd, Action<MsgErrCode, CSMsgAwolMsgNotifyAddReq, CSMsgAwolMsgNotifyAddRes> CallBack, APlayerState PlayerState = null, bool AllPlayer = true);

	public delegate void Del_BriefMsgGet(CSMsgBriefMsgGetReq BriefMsgGet, Action<MsgErrCode, CSMsgBriefMsgGetReq, CSMsgBriefMsgGetRes> CallBack, APlayerState PlayerState = null, bool AllPlayer = true);

	public delegate void Del_RankListGet(CSMsgRankListGetReq RankListGet, Action<MsgErrCode, CSMsgRankListGetReq, CSMsgRankListGetRes> CallBack, APlayerState PlayerState = null, bool AllPlayer = true);

	public delegate void Del_BagGainItemList(CSMsgBagGainItemListReq BagGainItemList, Action<MsgErrCode, CSMsgBagGainItemListReq, CSMsgBagGainItemListRes> CallBack, APlayerState PlayerState = null, bool AllPlayer = true);

	public delegate void Del_BagCostItemList(CSMsgBagCostItemListReq BagCostItemList, Action<MsgErrCode, CSMsgBagCostItemListReq, CSMsgBagCostItemListRes> CallBack, APlayerState PlayerState = null, bool AllPlayer = true);

	public delegate void Del_BagHuluSetting(CSMsgBagHuluSettingReq BagHuluSetting, Action<MsgErrCode, CSMsgBagHuluSettingReq, CSMsgBagHuluSettingRes> CallBack, APlayerState PlayerState = null, bool AllPlayer = true);

	public delegate void Del_BagAlchemy(CSMsgBagAlchemyReq BagAlchemy, Action<MsgErrCode, CSMsgBagAlchemyReq, CSMsgBagAlchemyRes> CallBack, APlayerState PlayerState = null, bool AllPlayer = true);

	public delegate void Del_BagWeaponBuild(CSMsgBagWeaponBuildReq BagWeaponBuild, Action<MsgErrCode, CSMsgBagWeaponBuildReq, CSMsgBagWeaponBuildRes> CallBack, APlayerState PlayerState = null, bool AllPlayer = true);

	public delegate void Del_BagWeaponReBuild(CSMsgBagWeaponReBuildReq BagWeaponReBuild, Action<MsgErrCode, CSMsgBagWeaponReBuildReq, CSMsgBagWeaponReBuildRes> CallBack, APlayerState PlayerState = null, bool AllPlayer = true);

	public delegate void Del_BagDropUnitAward(CSMsgBagDropUnitAwardReq BagDropUnitAward, Action<MsgErrCode, CSMsgBagDropUnitAwardReq, CSMsgBagDropUnitAwardRes> CallBack, APlayerState PlayerState = null, bool AllPlayer = true);

	public delegate void Del_BagCommDrop(CSMsgBagCommDropReq BagCommDrop, Action<MsgErrCode, CSMsgBagCommDropReq, CSMsgBagCommDropRes> CallBack, APlayerState PlayerState = null, bool AllPlayer = true);

	public delegate void Del_BagWineUpgrade(CSMsgBagWineUpgradeReq BagWineUpgrade, Action<MsgErrCode, CSMsgBagWineUpgradeReq, CSMsgBagWineUpgradeRes> CallBack, APlayerState PlayerState = null, bool AllPlayer = true);

	public delegate void Del_BagWinePartnerSetting(CSMsgBagWinePartnerSettingReq BagWinePartnerSetting, Action<MsgErrCode, CSMsgBagWinePartnerSettingReq, CSMsgBagWinePartnerSettingRes> CallBack, APlayerState PlayerState = null, bool AllPlayer = true);

	public delegate void Del_BagGainEditionAward(CSMsgBagGainEditionAwardReq BagGainEditionAward, Action<MsgErrCode, CSMsgBagGainEditionAwardReq, CSMsgBagGainEditionAwardRes> CallBack, APlayerState PlayerState = null, bool AllPlayer = true);

	public delegate void Del_ActorWearEquip(CSMsgActorWearEquipReq ActorWearEquip, Action<MsgErrCode, CSMsgActorWearEquipReq, CSMsgActorWearEquipRes> CallBack, APlayerState PlayerState = null, bool AllPlayer = true);

	public delegate void Del_ActorUnWearEquip(CSMsgActorUnWearEquipReq ActorUnWearEquip, Action<MsgErrCode, CSMsgActorUnWearEquipReq, CSMsgActorUnWearEquipRes> CallBack, APlayerState PlayerState = null, bool AllPlayer = true);

	public delegate void Del_ActorSetShortCut(CSMsgActorSetShortCutReq ActorSetShortCut, Action<MsgErrCode, CSMsgActorSetShortCutReq, CSMsgActorSetShortCutRes> CallBack, APlayerState PlayerState = null, bool AllPlayer = true);

	public delegate void Del_ActorUnSetShortCut(CSMsgActorUnSetShortCutReq ActorUnSetShortCut, Action<MsgErrCode, CSMsgActorUnSetShortCutReq, CSMsgActorUnSetShortCutRes> CallBack, APlayerState PlayerState = null, bool AllPlayer = true);

	public delegate void Del_ActorSetSpell(CSMsgActorSetSpellReq ActorSetSpell, Action<MsgErrCode, CSMsgActorSetSpellReq, CSMsgActorSetSpellRes> CallBack, APlayerState PlayerState = null, bool AllPlayer = true);

	public delegate void Del_ActorUnSetSpell(CSMsgActorUnSetSpellReq ActorUnSetSpell, Action<MsgErrCode, CSMsgActorUnSetSpellReq, CSMsgActorUnSetSpellRes> CallBack, APlayerState PlayerState = null, bool AllPlayer = true);

	public delegate void Del_ActorSetDefaultSpell(CSMsgActorSetDefaultSpellReq ActorSetDefaultSpell, Action<MsgErrCode, CSMsgActorSetDefaultSpellReq, CSMsgActorSetDefaultSpellRes> CallBack, APlayerState PlayerState = null, bool AllPlayer = true);

	public delegate void Del_ActorOnPlayerDeath(CSMsgActorOnPlayerDeathReq ActorOnPlayerDeath, Action<MsgErrCode, CSMsgActorOnPlayerDeathReq, CSMsgActorOnPlayerDeathRes> CallBack, APlayerState PlayerState = null, bool AllPlayer = true);

	public delegate void Del_ActorOnPlayerRest(CSMsgActorOnPlayerRestReq ActorOnPlayerRest, Action<MsgErrCode, CSMsgActorOnPlayerRestReq, CSMsgActorOnPlayerRestRes> CallBack, APlayerState PlayerState = null, bool AllPlayer = true);

	public delegate void Del_ActorOnNewGamePlus(CSMsgActorOnNewGamePlusReq ActorOnNewGamePlus, Action<MsgErrCode, CSMsgActorOnNewGamePlusReq, CSMsgActorOnNewGamePlusRes> CallBack, APlayerState PlayerState = null, bool AllPlayer = true);

	public delegate void Del_ActorUnLockTalent(CSMsgActorUnLockTalentReq ActorUnLockTalent, Action<MsgErrCode, CSMsgActorUnLockTalentReq, CSMsgActorUnLockTalentRes> CallBack, APlayerState PlayerState = null, bool AllPlayer = true);

	public delegate void Del_ActorTalentLevelUp(CSMsgActorTalentLevelUpReq ActorTalentLevelUp, Action<MsgErrCode, CSMsgActorTalentLevelUpReq, CSMsgActorTalentLevelUpRes> CallBack, APlayerState PlayerState = null, bool AllPlayer = true);

	public delegate void Del_ActorRebuildTalent(CSMsgActorRebuildTalentReq ActorRebuildTalent, Action<MsgErrCode, CSMsgActorRebuildTalentReq, CSMsgActorRebuildTalentRes> CallBack, APlayerState PlayerState = null, bool AllPlayer = true);

	public delegate void Del_ActorMeditationUnlock(CSMsgActorMeditationUnlockReq ActorMeditationUnlock, Action<MsgErrCode, CSMsgActorMeditationUnlockReq, CSMsgActorMeditationUnlockRes> CallBack, APlayerState PlayerState = null, bool AllPlayer = true);

	public delegate void Del_ActorOnPlayerExit(CSMsgActorOnPlayerExitReq ActorOnPlayerExit, Action<MsgErrCode, CSMsgActorOnPlayerExitReq, CSMsgActorOnPlayerExitRes> CallBack, APlayerState PlayerState = null, bool AllPlayer = true);

	public delegate void Del_ActorWineSetting(CSMsgActorWineSettingReq ActorWineSetting, Action<MsgErrCode, CSMsgActorWineSettingReq, CSMsgActorWineSettingRes> CallBack, APlayerState PlayerState = null, bool AllPlayer = true);

	public delegate void Del_ShopPayBuyItem(CSMsgShopPayBuyItemReq ShopPayBuyItem, Action<MsgErrCode, CSMsgShopPayBuyItemReq, CSMsgShopPayBuyItemRes> CallBack, APlayerState PlayerState = null, bool AllPlayer = true);

	public delegate void Del_ShopRefresh(CSMsgShopRefreshReq ShopRefresh, Action<MsgErrCode, CSMsgShopRefreshReq, CSMsgShopRefreshRes> CallBack, APlayerState PlayerState = null, bool AllPlayer = true);

	public delegate void Del_BagSellItem(CSMsgBagSellItemReq BagSellItem, Action<MsgErrCode, CSMsgBagSellItemReq, CSMsgBagSellItemRes> CallBack, APlayerState PlayerState = null, bool AllPlayer = true);

	public delegate void Del_ShopRefreshFlagRemove(CSMsgShopRefreshFlagRemoveReq ShopRefreshFlagRemove, Action<MsgErrCode, CSMsgShopRefreshFlagRemoveReq, CSMsgShopRefreshFlagRemoveRes> CallBack, APlayerState PlayerState = null, bool AllPlayer = true);

	public delegate void Del_TaskChangeQuestStage(CSMsgTaskChangeQuestStageReq TaskChangeQuestStage, Action<MsgErrCode, CSMsgTaskChangeQuestStageReq, CSMsgTaskChangeQuestStageRes> CallBack, APlayerState PlayerState = null, bool AllPlayer = true);

	public delegate void Del_CollectionInteractiveUnlock(CSMsgCollectionInteractiveUnlockReq CollectionInteractiveUnlock, Action<MsgErrCode, CSMsgCollectionInteractiveUnlockReq, CSMsgCollectionInteractiveUnlockRes> CallBack, APlayerState PlayerState = null, bool AllPlayer = true);

	public delegate void Del_RedPointRemove(CSMsgRedPointRemoveReq RedPointRemove, Action<MsgErrCode, CSMsgRedPointRemoveReq, CSMsgRedPointRemoveRes> CallBack, APlayerState PlayerState = null, bool AllPlayer = true);

	public delegate void Del_ActorWeaponTransformFlexType(CSMsgActorWeaponTransformFlexTypeReq ActorWeaponTransformFlexType, Action<MsgErrCode, CSMsgActorWeaponTransformFlexTypeReq, CSMsgActorWeaponTransformFlexTypeRes> CallBack, APlayerState PlayerState = null, bool AllPlayer = true);

	public delegate void Del_ActorKillUnit(CSMsgActorKillUnitReq ActorKillUnit, Action<MsgErrCode, CSMsgActorKillUnitReq, CSMsgActorKillUnitRes> CallBack, APlayerState PlayerState = null, bool AllPlayer = true);

	public delegate void Del_ActorUnitEncounter(CSMsgActorUnitEncounterReq ActorUnitEncounter, Action<MsgErrCode, CSMsgActorUnitEncounterReq, CSMsgActorUnitEncounterRes> CallBack, APlayerState PlayerState = null, bool AllPlayer = true);

	public delegate void Del_AchievementUnlock(CSMsgAchievementUnlockReq AchievementUnlock, Action<MsgErrCode, CSMsgAchievementUnlockReq, CSMsgAchievementUnlockRes> CallBack, APlayerState PlayerState = null, bool AllPlayer = true);

	public delegate void Del_ChapterEnterNext(CSMsgChapterEnterNextReq ChapterEnterNext, Action<MsgErrCode, CSMsgChapterEnterNextReq, CSMsgChapterEnterNextRes> CallBack, APlayerState PlayerState = null, bool AllPlayer = true);

	public delegate void Del_ChapterEnterShow(CSMsgChapterEnterShowReq ChapterEnterShow, Action<MsgErrCode, CSMsgChapterEnterShowReq, CSMsgChapterEnterShowRes> CallBack, APlayerState PlayerState = null, bool AllPlayer = true);

	public delegate void Del_ChapterPreviewAward(CSMsgChapterPreviewAwardReq ChapterPreviewAward, Action<MsgErrCode, CSMsgChapterPreviewAwardReq, CSMsgChapterPreviewAwardRes> CallBack, APlayerState PlayerState = null, bool AllPlayer = true);

	public delegate void Del_MuseumRecordMemories(CSMsgMuseumRecordMemoriesReq MuseumRecordMemories, Action<MsgErrCode, CSMsgMuseumRecordMemoriesReq, CSMsgMuseumRecordMemoriesRes> CallBack, APlayerState PlayerState = null, bool AllPlayer = true);

	public delegate void Del_MuseumRemoveRedpoint(CSMsgMuseumRemoveRedpointReq MuseumRemoveRedpoint, Action<MsgErrCode, CSMsgMuseumRemoveRedpointReq, CSMsgMuseumRemoveRedpointRes> CallBack, APlayerState PlayerState = null, bool AllPlayer = true);

	public delegate void Del_AttrChangeNotify(CSMsgAttrChangeNotifyReq AttrChangeNotify, Action<MsgErrCode, CSMsgAttrChangeNotifyReq, CSMsgAttrChangeNotifyRes> CallBack, APlayerState PlayerState = null, bool AllPlayer = true);

	public delegate void Del_RoomCreatePartyCS(CSMsgRoomCreatePartyCSReq RoomCreatePartyCS, Action<MsgErrCode, CSMsgRoomCreatePartyCSReq, CSMsgRoomCreatePartyCSRes> CallBack, APlayerState PlayerState = null, bool AllPlayer = true);

	public delegate void Del_RoomJoinPartyCS(CSMsgRoomJoinPartyCSReq RoomJoinPartyCS, Action<MsgErrCode, CSMsgRoomJoinPartyCSReq, CSMsgRoomJoinPartyCSRes> CallBack, APlayerState PlayerState = null, bool AllPlayer = true);

	public delegate void Del_RoomExitPartyCS(CSMsgRoomExitPartyCSReq RoomExitPartyCS, Action<MsgErrCode, CSMsgRoomExitPartyCSReq, CSMsgRoomExitPartyCSRes> CallBack, APlayerState PlayerState = null, bool AllPlayer = true);

	public delegate void Del_RoomPartyKickMemberCS(CSMsgRoomPartyKickMemberCSReq RoomPartyKickMemberCS, Action<MsgErrCode, CSMsgRoomPartyKickMemberCSReq, CSMsgRoomPartyKickMemberCSRes> CallBack, APlayerState PlayerState = null, bool AllPlayer = true);

	public delegate void Del_RoomSearchPartyCS(CSMsgRoomSearchPartyCSReq RoomSearchPartyCS, Action<MsgErrCode, CSMsgRoomSearchPartyCSReq, CSMsgRoomSearchPartyCSRes> CallBack, APlayerState PlayerState = null, bool AllPlayer = true);

	public delegate void Del_RoomSearchPartyNotify(CSMsgRoomSearchPartyNotifyReq RoomSearchPartyNotify, Action<MsgErrCode, CSMsgRoomSearchPartyNotifyReq, CSMsgRoomSearchPartyNotifyRes> CallBack, APlayerState PlayerState = null, bool AllPlayer = true);

	public delegate void Del_RoomQueryPartyInfoCS(CSMsgRoomQueryPartyInfoCSReq RoomQueryPartyInfoCS, Action<MsgErrCode, CSMsgRoomQueryPartyInfoCSReq, CSMsgRoomQueryPartyInfoCSRes> CallBack, APlayerState PlayerState = null, bool AllPlayer = true);

	public delegate void Del_RoomPartyHeartBeatCS(CSMsgRoomPartyHeartBeatCSReq RoomPartyHeartBeatCS, Action<MsgErrCode, CSMsgRoomPartyHeartBeatCSReq, CSMsgRoomPartyHeartBeatCSRes> CallBack, APlayerState PlayerState = null, bool AllPlayer = true);

	public delegate void Del_RoomPartyEventNotify(CSMsgRoomPartyEventNotifyReq RoomPartyEventNotify, Action<MsgErrCode, CSMsgRoomPartyEventNotifyReq, CSMsgRoomPartyEventNotifyRes> CallBack, APlayerState PlayerState = null, bool AllPlayer = true);

	public delegate void Del_RoomSendPartyBattleMessageCS(CSMsgRoomSendPartyBattleMessageCSReq RoomSendPartyBattleMessageCS, Action<MsgErrCode, CSMsgRoomSendPartyBattleMessageCSReq, CSMsgRoomSendPartyBattleMessageCSRes> CallBack, APlayerState PlayerState = null, bool AllPlayer = true);

	public delegate void Del_RoomPartyBattleMessageNotify(CSMsgRoomPartyBattleMessageNotifyReq RoomPartyBattleMessageNotify, Action<MsgErrCode, CSMsgRoomPartyBattleMessageNotifyReq, CSMsgRoomPartyBattleMessageNotifyRes> CallBack, APlayerState PlayerState = null, bool AllPlayer = true);

	public delegate void Del_RoomPartyMemberUpdateCS(CSMsgRoomPartyMemberUpdateCSReq RoomPartyMemberUpdateCS, Action<MsgErrCode, CSMsgRoomPartyMemberUpdateCSReq, CSMsgRoomPartyMemberUpdateCSRes> CallBack, APlayerState PlayerState = null, bool AllPlayer = true);

	public delegate void Del_RoomCreatePartyTaskCS(CSMsgRoomCreatePartyTaskCSReq RoomCreatePartyTaskCS, Action<MsgErrCode, CSMsgRoomCreatePartyTaskCSReq, CSMsgRoomCreatePartyTaskCSRes> CallBack, APlayerState PlayerState = null, bool AllPlayer = true);

	public delegate void Del_RoomUpdatePartyTaskCS(CSMsgRoomUpdatePartyTaskCSReq RoomUpdatePartyTaskCS, Action<MsgErrCode, CSMsgRoomUpdatePartyTaskCSReq, CSMsgRoomUpdatePartyTaskCSRes> CallBack, APlayerState PlayerState = null, bool AllPlayer = true);

	public delegate void Del_RoomPartyTaskFinishCS(CSMsgRoomPartyTaskFinishCSReq RoomPartyTaskFinishCS, Action<MsgErrCode, CSMsgRoomPartyTaskFinishCSReq, CSMsgRoomPartyTaskFinishCSRes> CallBack, APlayerState PlayerState = null, bool AllPlayer = true);

	public delegate void Del_BagMultiplayerDrop(CSMsgBagMultiplayerDropReq BagMultiplayerDrop, Action<MsgErrCode, CSMsgBagMultiplayerDropReq, CSMsgBagMultiplayerDropRes> CallBack, APlayerState PlayerState = null, bool AllPlayer = true);

	public delegate void Del_ChapterGameComplete(CSMsgChapterGameCompleteReq ChapterGameComplete, Action<MsgErrCode, CSMsgChapterGameCompleteReq, CSMsgChapterGameCompleteRes> CallBack, APlayerState PlayerState = null, bool AllPlayer = true);

	public delegate void Del_CollectionReadCardStory(CSMsgCollectionReadCardStoryReq CollectionReadCardStory, Action<MsgErrCode, CSMsgCollectionReadCardStoryReq, CSMsgCollectionReadCardStoryRes> CallBack, APlayerState PlayerState = null, bool AllPlayer = true);

	public delegate void Del_BagArmorUpgrade(CSMsgBagArmorUpgradeReq BagArmorUpgrade, Action<MsgErrCode, CSMsgBagArmorUpgradeReq, CSMsgBagArmorUpgradeRes> CallBack, APlayerState PlayerState = null, bool AllPlayer = true);

	public delegate void Del_BagDropCollectionAward(CSMsgBagDropCollectionAwardReq BagDropCollectionAward, Action<MsgErrCode, CSMsgBagDropCollectionAwardReq, CSMsgBagDropCollectionAwardRes> CallBack, APlayerState PlayerState = null, bool AllPlayer = true);

	public delegate void Del_PartyApiCreateOnlineParty(CSMsgPartyApiCreateOnlinePartyReq PartyApiCreateOnlineParty, Action<MsgErrCode, CSMsgPartyApiCreateOnlinePartyReq, CSMsgPartyApiCreateOnlinePartyRes> CallBack, APlayerState PlayerState = null, bool AllPlayer = true);

	public delegate void Del_PartyApiSearchParty(CSMsgPartyApiSearchPartyReq PartyApiSearchParty, Action<MsgErrCode, CSMsgPartyApiSearchPartyReq, CSMsgPartyApiSearchPartyRes> CallBack, APlayerState PlayerState = null, bool AllPlayer = true);

	public delegate void Del_PartyApiJoinParty(CSMsgPartyApiJoinPartyReq PartyApiJoinParty, Action<MsgErrCode, CSMsgPartyApiJoinPartyReq, CSMsgPartyApiJoinPartyRes> CallBack, APlayerState PlayerState = null, bool AllPlayer = true);

	public delegate void Del_PartyApiLeaderCreateTask(CSMsgPartyApiLeaderCreateTaskReq PartyApiLeaderCreateTask, Action<MsgErrCode, CSMsgPartyApiLeaderCreateTaskReq, CSMsgPartyApiLeaderCreateTaskRes> CallBack, APlayerState PlayerState = null, bool AllPlayer = true);

	public delegate void Del_PartyApiMemberTaskReady(CSMsgPartyApiMemberTaskReadyReq PartyApiMemberTaskReady, Action<MsgErrCode, CSMsgPartyApiMemberTaskReadyReq, CSMsgPartyApiMemberTaskReadyRes> CallBack, APlayerState PlayerState = null, bool AllPlayer = true);

	public delegate void Del_PartyApiLeaderFinishTask(CSMsgPartyApiLeaderFinishTaskReq PartyApiLeaderFinishTask, Action<MsgErrCode, CSMsgPartyApiLeaderFinishTaskReq, CSMsgPartyApiLeaderFinishTaskRes> CallBack, APlayerState PlayerState = null, bool AllPlayer = true);

	public delegate void Del_PartyApiLeaderCreateBattle(CSMsgPartyApiLeaderCreateBattleReq PartyApiLeaderCreateBattle, Action<MsgErrCode, CSMsgPartyApiLeaderCreateBattleReq, CSMsgPartyApiLeaderCreateBattleRes> CallBack, APlayerState PlayerState = null, bool AllPlayer = true);

	public delegate void Del_PartyApiLeaderBattleReady(CSMsgPartyApiLeaderBattleReadyReq PartyApiLeaderBattleReady, Action<MsgErrCode, CSMsgPartyApiLeaderBattleReadyReq, CSMsgPartyApiLeaderBattleReadyRes> CallBack, APlayerState PlayerState = null, bool AllPlayer = true);

	public delegate void Del_PartyApiMemberEnterBattle(CSMsgPartyApiMemberEnterBattleReq PartyApiMemberEnterBattle, Action<MsgErrCode, CSMsgPartyApiMemberEnterBattleReq, CSMsgPartyApiMemberEnterBattleRes> CallBack, APlayerState PlayerState = null, bool AllPlayer = true);

	public delegate void Del_PartyApiLeaderRequestHelp(CSMsgPartyApiLeaderRequestHelpReq PartyApiLeaderRequestHelp, Action<MsgErrCode, CSMsgPartyApiLeaderRequestHelpReq, CSMsgPartyApiLeaderRequestHelpRes> CallBack, APlayerState PlayerState = null, bool AllPlayer = true);

	public delegate void Del_PartyApiLeaderCancelHelp(CSMsgPartyApiLeaderCancelHelpReq PartyApiLeaderCancelHelp, Action<MsgErrCode, CSMsgPartyApiLeaderCancelHelpReq, CSMsgPartyApiLeaderCancelHelpRes> CallBack, APlayerState PlayerState = null, bool AllPlayer = true);

	public delegate void Del_ChapterConfirmAward(CSMsgChapterConfirmAwardReq ChapterConfirmAward, Action<MsgErrCode, CSMsgChapterConfirmAwardReq, CSMsgChapterConfirmAwardRes> CallBack, APlayerState PlayerState = null, bool AllPlayer = true);

	public delegate void Del_CollectionViewCardPortrait(CSMsgCollectionViewCardPortraitReq CollectionViewCardPortrait, Action<MsgErrCode, CSMsgCollectionViewCardPortraitReq, CSMsgCollectionViewCardPortraitRes> CallBack, APlayerState PlayerState = null, bool AllPlayer = true);

	public delegate void Del_ActorSetSoulSkill(CSMsgActorSetSoulSkillReq ActorSetSoulSkill, Action<MsgErrCode, CSMsgActorSetSoulSkillReq, CSMsgActorSetSoulSkillRes> CallBack, APlayerState PlayerState = null, bool AllPlayer = true);

	public delegate void Del_GardenUpdateCropOutput(CSMsgGardenUpdateCropOutputReq GardenUpdateCropOutput, Action<MsgErrCode, CSMsgGardenUpdateCropOutputReq, CSMsgGardenUpdateCropOutputRes> CallBack, APlayerState PlayerState = null, bool AllPlayer = true);

	public delegate void Del_GardenCollectCropOutput(CSMsgGardenCollectCropOutputReq GardenCollectCropOutput, Action<MsgErrCode, CSMsgGardenCollectCropOutputReq, CSMsgGardenCollectCropOutputRes> CallBack, APlayerState PlayerState = null, bool AllPlayer = true);

	public delegate void Del_GardenPlantAllSeeds(CSMsgGardenPlantAllSeedsReq GardenPlantAllSeeds, Action<MsgErrCode, CSMsgGardenPlantAllSeedsReq, CSMsgGardenPlantAllSeedsRes> CallBack, APlayerState PlayerState = null, bool AllPlayer = true);

	public delegate void Del_BagActivateWeapon(CSMsgBagActivateWeaponReq BagActivateWeapon, Action<MsgErrCode, CSMsgBagActivateWeaponReq, CSMsgBagActivateWeaponRes> CallBack, APlayerState PlayerState = null, bool AllPlayer = true);

	public delegate void Del_BagGetAlchemyNpcCommunicationAward(CSMsgBagGetAlchemyNpcCommunicationAwardReq BagGetAlchemyNpcCommunicationAward, Action<MsgErrCode, CSMsgBagGetAlchemyNpcCommunicationAwardReq, CSMsgBagGetAlchemyNpcCommunicationAwardRes> CallBack, APlayerState PlayerState = null, bool AllPlayer = true);

	public delegate void Del_BagUpdateAlchemyNpcCommunicationStatus(CSMsgBagUpdateAlchemyNpcCommunicationStatusReq BagUpdateAlchemyNpcCommunicationStatus, Action<MsgErrCode, CSMsgBagUpdateAlchemyNpcCommunicationStatusReq, CSMsgBagUpdateAlchemyNpcCommunicationStatusRes> CallBack, APlayerState PlayerState = null, bool AllPlayer = true);

	public delegate void Del_BagHuluUpgrade(CSMsgBagHuluUpgradeReq BagHuluUpgrade, Action<MsgErrCode, CSMsgBagHuluUpgradeReq, CSMsgBagHuluUpgradeRes> CallBack, APlayerState PlayerState = null, bool AllPlayer = true);

	public delegate void Del_BagCollectDropSoulSkill(CSMsgBagCollectDropSoulSkillReq BagCollectDropSoulSkill, Action<MsgErrCode, CSMsgBagCollectDropSoulSkillReq, CSMsgBagCollectDropSoulSkillRes> CallBack, APlayerState PlayerState = null, bool AllPlayer = true);

	public delegate void Del_ActorWearAccessory(CSMsgActorWearAccessoryReq ActorWearAccessory, Action<MsgErrCode, CSMsgActorWearAccessoryReq, CSMsgActorWearAccessoryRes> CallBack, APlayerState PlayerState = null, bool AllPlayer = true);

	public delegate void Del_ActorUnWearAccessory(CSMsgActorUnWearAccessoryReq ActorUnWearAccessory, Action<MsgErrCode, CSMsgActorUnWearAccessoryReq, CSMsgActorUnWearAccessoryRes> CallBack, APlayerState PlayerState = null, bool AllPlayer = true);

	public delegate void Del_AchievementEnterLevel(CSMsgAchievementEnterLevelReq AchievementEnterLevel, Action<MsgErrCode, CSMsgAchievementEnterLevelReq, CSMsgAchievementEnterLevelRes> CallBack, APlayerState PlayerState = null, bool AllPlayer = true);

	public delegate void Del_BagSoulSkillUpgrade(CSMsgBagSoulSkillUpgradeReq BagSoulSkillUpgrade, Action<MsgErrCode, CSMsgBagSoulSkillUpgradeReq, CSMsgBagSoulSkillUpgradeRes> CallBack, APlayerState PlayerState = null, bool AllPlayer = true);

	public delegate void Del_ActorActivateLegacyTalent(CSMsgActorActivateLegacyTalentReq ActorActivateLegacyTalent, Action<MsgErrCode, CSMsgActorActivateLegacyTalentReq, CSMsgActorActivateLegacyTalentRes> CallBack, APlayerState PlayerState = null, bool AllPlayer = true);

	public delegate void Del_ActorRebuildLegacyTalent(CSMsgActorRebuildLegacyTalentReq ActorRebuildLegacyTalent, Action<MsgErrCode, CSMsgActorRebuildLegacyTalentReq, CSMsgActorRebuildLegacyTalentRes> CallBack, APlayerState PlayerState = null, bool AllPlayer = true);

	public delegate void Del_BagRebuildAttrItem(CSMsgBagRebuildAttrItemReq BagRebuildAttrItem, Action<MsgErrCode, CSMsgBagRebuildAttrItemReq, CSMsgBagRebuildAttrItemRes> CallBack, APlayerState PlayerState = null, bool AllPlayer = true);

	public delegate void Del_ActivitiesResume(CSMsgActivitiesResumeReq ActivitiesResume, Action<MsgErrCode, CSMsgActivitiesResumeReq, CSMsgActivitiesResumeRes> CallBack, APlayerState PlayerState = null, bool AllPlayer = true);

	public delegate void Del_CollectionCollectItem(CSMsgCollectionCollectItemReq CollectionCollectItem, Action<MsgErrCode, CSMsgCollectionCollectItemReq, CSMsgCollectionCollectItemRes> CallBack, APlayerState PlayerState = null, bool AllPlayer = true);

	public delegate void Del_ChapterPrologueCompleted(CSMsgChapterPrologueCompletedReq ChapterPrologueCompleted, Action<MsgErrCode, CSMsgChapterPrologueCompletedReq, CSMsgChapterPrologueCompletedRes> CallBack, APlayerState PlayerState = null, bool AllPlayer = true);

	public delegate void Del_AttrRefresh(CSMsgAttrRefreshReq AttrRefresh, Action<MsgErrCode, CSMsgAttrRefreshReq, CSMsgAttrRefreshRes> CallBack, APlayerState PlayerState = null, bool AllPlayer = true);

	public delegate void Del_MiscTestLargePackage(CSMsgMiscTestLargePackageReq MiscTestLargePackage, Action<MsgErrCode, CSMsgMiscTestLargePackageReq, CSMsgMiscTestLargePackageRes> CallBack, APlayerState PlayerState = null, bool AllPlayer = true);

	public delegate void Del_InteractSoulBottleGainItem(CSMsgInteractSoulBottleGainItemReq InteractSoulBottleGainItem, Action<MsgErrCode, CSMsgInteractSoulBottleGainItemReq, CSMsgInteractSoulBottleGainItemRes> CallBack, APlayerState PlayerState = null, bool AllPlayer = true);

	public delegate void Del_BossRushBattleStart(CSMsgBossRushBattleStartReq BossRushBattleStart, Action<MsgErrCode, CSMsgBossRushBattleStartReq, CSMsgBossRushBattleStartRes> CallBack, APlayerState PlayerState = null, bool AllPlayer = true);

	public delegate void Del_BossRushBattleComplete(CSMsgBossRushBattleCompleteReq BossRushBattleComplete, Action<MsgErrCode, CSMsgBossRushBattleCompleteReq, CSMsgBossRushBattleCompleteRes> CallBack, APlayerState PlayerState = null, bool AllPlayer = true);

	public Del_RoleLogin Evt_RoleLoginReq = delegate
	{
	};

	public Del_RoleLogout Evt_RoleLogoutReq = delegate
	{
	};

	public Del_RoleKick Evt_RoleKickReq = delegate
	{
	};

	public Del_RoleDataNotify Evt_RoleDataNotifyReq = delegate
	{
	};

	public Del_RoleRandomName Evt_RoleRandomNameReq = delegate
	{
	};

	public Del_RoleChangeName Evt_RoleChangeNameReq = delegate
	{
	};

	public Del_MiscCreateRole Evt_MiscCreateRoleReq = delegate
	{
	};

	public Del_MiscExecGM Evt_MiscExecGMReq = delegate
	{
	};

	public Del_MiscHeartBeat Evt_MiscHeartBeatReq = delegate
	{
	};

	public Del_MiscCheckRes Evt_MiscCheckResReq = delegate
	{
	};

	public Del_AwolMsgGetList Evt_AwolMsgGetListReq = delegate
	{
	};

	public Del_AwolMsgRemove Evt_AwolMsgRemoveReq = delegate
	{
	};

	public Del_AwolMsgUpdate Evt_AwolMsgUpdateReq = delegate
	{
	};

	public Del_AwolMsgSend Evt_AwolMsgSendReq = delegate
	{
	};

	public Del_AwolMsgNotifyUpdate Evt_AwolMsgNotifyUpdateReq = delegate
	{
	};

	public Del_AwolMsgNotifyRemove Evt_AwolMsgNotifyRemoveReq = delegate
	{
	};

	public Del_AwolMsgNotifyAdd Evt_AwolMsgNotifyAddReq = delegate
	{
	};

	public Del_BriefMsgGet Evt_BriefMsgGetReq = delegate
	{
	};

	public Del_RankListGet Evt_RankListGetReq = delegate
	{
	};

	public Del_BagGainItemList Evt_BagGainItemListReq = delegate
	{
	};

	public Del_BagCostItemList Evt_BagCostItemListReq = delegate
	{
	};

	public Del_BagHuluSetting Evt_BagHuluSettingReq = delegate
	{
	};

	public Del_BagAlchemy Evt_BagAlchemyReq = delegate
	{
	};

	public Del_BagWeaponBuild Evt_BagWeaponBuildReq = delegate
	{
	};

	public Del_BagWeaponReBuild Evt_BagWeaponReBuildReq = delegate
	{
	};

	public Del_BagDropUnitAward Evt_BagDropUnitAwardReq = delegate
	{
	};

	public Del_BagCommDrop Evt_BagCommDropReq = delegate
	{
	};

	public Del_BagWineUpgrade Evt_BagWineUpgradeReq = delegate
	{
	};

	public Del_BagWinePartnerSetting Evt_BagWinePartnerSettingReq = delegate
	{
	};

	public Del_BagGainEditionAward Evt_BagGainEditionAwardReq = delegate
	{
	};

	public Del_ActorWearEquip Evt_ActorWearEquipReq = delegate
	{
	};

	public Del_ActorUnWearEquip Evt_ActorUnWearEquipReq = delegate
	{
	};

	public Del_ActorSetShortCut Evt_ActorSetShortCutReq = delegate
	{
	};

	public Del_ActorUnSetShortCut Evt_ActorUnSetShortCutReq = delegate
	{
	};

	public Del_ActorSetSpell Evt_ActorSetSpellReq = delegate
	{
	};

	public Del_ActorUnSetSpell Evt_ActorUnSetSpellReq = delegate
	{
	};

	public Del_ActorSetDefaultSpell Evt_ActorSetDefaultSpellReq = delegate
	{
	};

	public Del_ActorOnPlayerDeath Evt_ActorOnPlayerDeathReq = delegate
	{
	};

	public Del_ActorOnPlayerRest Evt_ActorOnPlayerRestReq = delegate
	{
	};

	public Del_ActorOnNewGamePlus Evt_ActorOnNewGamePlusReq = delegate
	{
	};

	public Del_ActorUnLockTalent Evt_ActorUnLockTalentReq = delegate
	{
	};

	public Del_ActorTalentLevelUp Evt_ActorTalentLevelUpReq = delegate
	{
	};

	public Del_ActorRebuildTalent Evt_ActorRebuildTalentReq = delegate
	{
	};

	public Del_ActorMeditationUnlock Evt_ActorMeditationUnlockReq = delegate
	{
	};

	public Del_ActorOnPlayerExit Evt_ActorOnPlayerExitReq = delegate
	{
	};

	public Del_ActorWineSetting Evt_ActorWineSettingReq = delegate
	{
	};

	public Del_ShopPayBuyItem Evt_ShopPayBuyItemReq = delegate
	{
	};

	public Del_ShopRefresh Evt_ShopRefreshReq = delegate
	{
	};

	public Del_BagSellItem Evt_BagSellItemReq = delegate
	{
	};

	public Del_ShopRefreshFlagRemove Evt_ShopRefreshFlagRemoveReq = delegate
	{
	};

	public Del_TaskChangeQuestStage Evt_TaskChangeQuestStageReq = delegate
	{
	};

	public Del_CollectionInteractiveUnlock Evt_CollectionInteractiveUnlockReq = delegate
	{
	};

	public Del_RedPointRemove Evt_RedPointRemoveReq = delegate
	{
	};

	public Del_ActorWeaponTransformFlexType Evt_ActorWeaponTransformFlexTypeReq = delegate
	{
	};

	public Del_ActorKillUnit Evt_ActorKillUnitReq = delegate
	{
	};

	public Del_ActorUnitEncounter Evt_ActorUnitEncounterReq = delegate
	{
	};

	public Del_AchievementUnlock Evt_AchievementUnlockReq = delegate
	{
	};

	public Del_ChapterEnterNext Evt_ChapterEnterNextReq = delegate
	{
	};

	public Del_ChapterEnterShow Evt_ChapterEnterShowReq = delegate
	{
	};

	public Del_ChapterPreviewAward Evt_ChapterPreviewAwardReq = delegate
	{
	};

	public Del_MuseumRecordMemories Evt_MuseumRecordMemoriesReq = delegate
	{
	};

	public Del_MuseumRemoveRedpoint Evt_MuseumRemoveRedpointReq = delegate
	{
	};

	public Del_AttrChangeNotify Evt_AttrChangeNotifyReq = delegate
	{
	};

	public Del_RoomCreatePartyCS Evt_RoomCreatePartyCSReq = delegate
	{
	};

	public Del_RoomJoinPartyCS Evt_RoomJoinPartyCSReq = delegate
	{
	};

	public Del_RoomExitPartyCS Evt_RoomExitPartyCSReq = delegate
	{
	};

	public Del_RoomPartyKickMemberCS Evt_RoomPartyKickMemberCSReq = delegate
	{
	};

	public Del_RoomSearchPartyCS Evt_RoomSearchPartyCSReq = delegate
	{
	};

	public Del_RoomSearchPartyNotify Evt_RoomSearchPartyNotifyReq = delegate
	{
	};

	public Del_RoomQueryPartyInfoCS Evt_RoomQueryPartyInfoCSReq = delegate
	{
	};

	public Del_RoomPartyHeartBeatCS Evt_RoomPartyHeartBeatCSReq = delegate
	{
	};

	public Del_RoomPartyEventNotify Evt_RoomPartyEventNotifyReq = delegate
	{
	};

	public Del_RoomSendPartyBattleMessageCS Evt_RoomSendPartyBattleMessageCSReq = delegate
	{
	};

	public Del_RoomPartyBattleMessageNotify Evt_RoomPartyBattleMessageNotifyReq = delegate
	{
	};

	public Del_RoomPartyMemberUpdateCS Evt_RoomPartyMemberUpdateCSReq = delegate
	{
	};

	public Del_RoomCreatePartyTaskCS Evt_RoomCreatePartyTaskCSReq = delegate
	{
	};

	public Del_RoomUpdatePartyTaskCS Evt_RoomUpdatePartyTaskCSReq = delegate
	{
	};

	public Del_RoomPartyTaskFinishCS Evt_RoomPartyTaskFinishCSReq = delegate
	{
	};

	public Del_BagMultiplayerDrop Evt_BagMultiplayerDropReq = delegate
	{
	};

	public Del_ChapterGameComplete Evt_ChapterGameCompleteReq = delegate
	{
	};

	public Del_CollectionReadCardStory Evt_CollectionReadCardStoryReq = delegate
	{
	};

	public Del_BagArmorUpgrade Evt_BagArmorUpgradeReq = delegate
	{
	};

	public Del_BagDropCollectionAward Evt_BagDropCollectionAwardReq = delegate
	{
	};

	public Del_PartyApiCreateOnlineParty Evt_PartyApiCreateOnlinePartyReq = delegate
	{
	};

	public Del_PartyApiSearchParty Evt_PartyApiSearchPartyReq = delegate
	{
	};

	public Del_PartyApiJoinParty Evt_PartyApiJoinPartyReq = delegate
	{
	};

	public Del_PartyApiLeaderCreateTask Evt_PartyApiLeaderCreateTaskReq = delegate
	{
	};

	public Del_PartyApiMemberTaskReady Evt_PartyApiMemberTaskReadyReq = delegate
	{
	};

	public Del_PartyApiLeaderFinishTask Evt_PartyApiLeaderFinishTaskReq = delegate
	{
	};

	public Del_PartyApiLeaderCreateBattle Evt_PartyApiLeaderCreateBattleReq = delegate
	{
	};

	public Del_PartyApiLeaderBattleReady Evt_PartyApiLeaderBattleReadyReq = delegate
	{
	};

	public Del_PartyApiMemberEnterBattle Evt_PartyApiMemberEnterBattleReq = delegate
	{
	};

	public Del_PartyApiLeaderRequestHelp Evt_PartyApiLeaderRequestHelpReq = delegate
	{
	};

	public Del_PartyApiLeaderCancelHelp Evt_PartyApiLeaderCancelHelpReq = delegate
	{
	};

	public Del_ChapterConfirmAward Evt_ChapterConfirmAwardReq = delegate
	{
	};

	public Del_CollectionViewCardPortrait Evt_CollectionViewCardPortraitReq = delegate
	{
	};

	public Del_ActorSetSoulSkill Evt_ActorSetSoulSkillReq = delegate
	{
	};

	public Del_GardenUpdateCropOutput Evt_GardenUpdateCropOutputReq = delegate
	{
	};

	public Del_GardenCollectCropOutput Evt_GardenCollectCropOutputReq = delegate
	{
	};

	public Del_GardenPlantAllSeeds Evt_GardenPlantAllSeedsReq = delegate
	{
	};

	public Del_BagActivateWeapon Evt_BagActivateWeaponReq = delegate
	{
	};

	public Del_BagGetAlchemyNpcCommunicationAward Evt_BagGetAlchemyNpcCommunicationAwardReq = delegate
	{
	};

	public Del_BagUpdateAlchemyNpcCommunicationStatus Evt_BagUpdateAlchemyNpcCommunicationStatusReq = delegate
	{
	};

	public Del_BagHuluUpgrade Evt_BagHuluUpgradeReq = delegate
	{
	};

	public Del_BagCollectDropSoulSkill Evt_BagCollectDropSoulSkillReq = delegate
	{
	};

	public Del_ActorWearAccessory Evt_ActorWearAccessoryReq = delegate
	{
	};

	public Del_ActorUnWearAccessory Evt_ActorUnWearAccessoryReq = delegate
	{
	};

	public Del_AchievementEnterLevel Evt_AchievementEnterLevelReq = delegate
	{
	};

	public Del_BagSoulSkillUpgrade Evt_BagSoulSkillUpgradeReq = delegate
	{
	};

	public Del_ActorActivateLegacyTalent Evt_ActorActivateLegacyTalentReq = delegate
	{
	};

	public Del_ActorRebuildLegacyTalent Evt_ActorRebuildLegacyTalentReq = delegate
	{
	};

	public Del_BagRebuildAttrItem Evt_BagRebuildAttrItemReq = delegate
	{
	};

	public Del_ActivitiesResume Evt_ActivitiesResumeReq = delegate
	{
	};

	public Del_CollectionCollectItem Evt_CollectionCollectItemReq = delegate
	{
	};

	public Del_ChapterPrologueCompleted Evt_ChapterPrologueCompletedReq = delegate
	{
	};

	public Del_AttrRefresh Evt_AttrRefreshReq = delegate
	{
	};

	public Del_MiscTestLargePackage Evt_MiscTestLargePackageReq = delegate
	{
	};

	public Del_InteractSoulBottleGainItem Evt_InteractSoulBottleGainItemReq = delegate
	{
	};

	public Del_BossRushBattleStart Evt_BossRushBattleStartReq = delegate
	{
	};

	public Del_BossRushBattleComplete Evt_BossRushBattleCompleteReq = delegate
	{
	};

	public static BTF_EventCollectionCS Get(APlayerState PlayerState)
	{
		return (PlayerState as BGP_PlayerStateCS)?.BattleToFluxSvcCollection;
	}
}
