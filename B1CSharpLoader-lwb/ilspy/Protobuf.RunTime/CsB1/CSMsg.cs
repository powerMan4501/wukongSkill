using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsg : IMessage<CSMsg>, IMessage, IEquatable<CSMsg>, IDeepCloneable<CSMsg>
{
	private static readonly MessageParser<CSMsg> _parser = new MessageParser<CSMsg>(() => new CSMsg());

	private UnknownFieldSet _unknownFields;

	private CSMsgHead head_;

	private CSMsgRoleLogin roleLogin_;

	private CSMsgRoleLogout roleLogout_;

	private CSMsgRoleKick roleKick_;

	private CSMsgRoleDataNotify roleDataNotify_;

	private CSMsgRoleRandomName roleRandomName_;

	private CSMsgRoleChangeName roleChangeName_;

	private CSMsgMiscCreateRole miscCreateRole_;

	private CSMsgMiscExecGM miscExecGm_;

	private CSMsgMiscHeartBeat miscHeartBeat_;

	private CSMsgMiscCheckRes miscCheckRes_;

	private CSMsgAwolMsgGetList awolMsgGetList_;

	private CSMsgAwolMsgRemove awolMsgRemove_;

	private CSMsgAwolMsgUpdate awolMsgUpdate_;

	private CSMsgAwolMsgSend awolMsgSend_;

	private CSMsgAwolMsgNotifyUpdate awolMsgNotifyUpdate_;

	private CSMsgAwolMsgNotifyRemove awolMsgNotifyRemove_;

	private CSMsgAwolMsgNotifyAdd awolMsgNotifyAdd_;

	private CSMsgBriefMsgGet briefMsgGet_;

	private CSMsgRankListGet rankListGet_;

	private CSMsgBagGainItemList bagGainItemList_;

	private CSMsgBagCostItemList bagCostItemList_;

	private CSMsgBagHuluSetting bagHuluSetting_;

	private CSMsgBagAlchemy bagAlchemy_;

	private CSMsgBagWeaponBuild bagWeaponBuild_;

	private CSMsgBagWeaponReBuild bagWeaponReBuild_;

	private CSMsgBagDropUnitAward bagDropUnitAward_;

	private CSMsgBagCommDrop bagCommDrop_;

	private CSMsgBagWineUpgrade bagWineUpgrade_;

	private CSMsgBagWinePartnerSetting bagWinePartnerSetting_;

	private CSMsgBagGainEditionAward bagGainEditionAward_;

	private CSMsgActorWearEquip actorWearEquip_;

	private CSMsgActorUnWearEquip actorUnWearEquip_;

	private CSMsgActorSetShortCut actorSetShortCut_;

	private CSMsgActorUnSetShortCut actorUnSetShortCut_;

	private CSMsgActorSetSpell actorSetSpell_;

	private CSMsgActorUnSetSpell actorUnSetSpell_;

	private CSMsgActorSetDefaultSpell actorSetDefaultSpell_;

	private CSMsgActorOnPlayerDeath actorOnPlayerDeath_;

	private CSMsgActorOnPlayerRest actorOnPlayerRest_;

	private CSMsgActorOnNewGamePlus actorOnNewGamePlus_;

	private CSMsgActorUnLockTalent actorUnLockTalent_;

	private CSMsgActorTalentLevelUp actorTalentLevelUp_;

	private CSMsgActorRebuildTalent actorRebuildTalent_;

	private CSMsgActorMeditationUnlock actorMeditationUnlock_;

	private CSMsgActorOnPlayerExit actorOnPlayerExit_;

	private CSMsgActorWineSetting actorWineSetting_;

	private CSMsgShopPayBuyItem shopPayBuyItem_;

	private CSMsgShopRefresh shopRefresh_;

	private CSMsgBagSellItem bagSellItem_;

	private CSMsgShopRefreshFlagRemove shopRefreshFlagRemove_;

	private CSMsgTaskChangeQuestStage taskChangeQuestStage_;

	private CSMsgCollectionInteractiveUnlock collectionInteractiveUnlock_;

	private CSMsgRedPointRemove redPointRemove_;

	private CSMsgActorWeaponTransformFlexType actorWeaponTransformFlexType_;

	private CSMsgActorKillUnit actorKillUnit_;

	private CSMsgActorUnitEncounter actorUnitEncounter_;

	private CSMsgAchievementUnlock achievementUnlock_;

	private CSMsgChapterEnterNext chapterEnterNext_;

	private CSMsgChapterEnterShow chapterEnterShow_;

	private CSMsgChapterPreviewAward chapterPreviewAward_;

	private CSMsgMuseumRecordMemories museumRecordMemories_;

	private CSMsgMuseumRemoveRedpoint museumRemoveRedpoint_;

	private CSMsgAttrChangeNotify attrChangeNotify_;

	private CSMsgRoomCreatePartyCS roomCreatePartyCs_;

	private CSMsgRoomJoinPartyCS roomJoinPartyCs_;

	private CSMsgRoomExitPartyCS roomExitPartyCs_;

	private CSMsgRoomPartyKickMemberCS roomPartyKickMemberCs_;

	private CSMsgRoomSearchPartyCS roomSearchPartyCs_;

	private CSMsgRoomSearchPartyNotify roomSearchPartyNotify_;

	private CSMsgRoomQueryPartyInfoCS roomQueryPartyInfoCs_;

	private CSMsgRoomPartyHeartBeatCS roomPartyHeartBeatCs_;

	private CSMsgRoomPartyEventNotify roomPartyEventNotify_;

	private CSMsgRoomSendPartyBattleMessageCS roomSendPartyBattleMessageCs_;

	private CSMsgRoomPartyBattleMessageNotify roomPartyBattleMessageNotify_;

	private CSMsgRoomPartyMemberUpdateCS roomPartyMemberUpdateCs_;

	private CSMsgRoomCreatePartyTaskCS roomCreatePartyTaskCs_;

	private CSMsgRoomUpdatePartyTaskCS roomUpdatePartyTaskCs_;

	private CSMsgRoomPartyTaskFinishCS roomPartyTaskFinishCs_;

	private CSMsgBagMultiplayerDrop bagMultiplayerDrop_;

	private CSMsgChapterGameComplete chapterGameComplete_;

	private CSMsgCollectionReadCardStory collectionReadCardStory_;

	private CSMsgBagArmorUpgrade bagArmorUpgrade_;

	private CSMsgBagDropCollectionAward bagDropCollectionAward_;

	private CSMsgPartyApiCreateOnlineParty partyApiCreateOnlineParty_;

	private CSMsgPartyApiSearchParty partyApiSearchParty_;

	private CSMsgPartyApiJoinParty partyApiJoinParty_;

	private CSMsgPartyApiLeaderCreateTask partyApiLeaderCreateTask_;

	private CSMsgPartyApiMemberTaskReady partyApiMemberTaskReady_;

	private CSMsgPartyApiLeaderFinishTask partyApiLeaderFinishTask_;

	private CSMsgPartyApiLeaderCreateBattle partyApiLeaderCreateBattle_;

	private CSMsgPartyApiLeaderBattleReady partyApiLeaderBattleReady_;

	private CSMsgPartyApiMemberEnterBattle partyApiMemberEnterBattle_;

	private CSMsgPartyApiLeaderRequestHelp partyApiLeaderRequestHelp_;

	private CSMsgPartyApiLeaderCancelHelp partyApiLeaderCancelHelp_;

	private CSMsgChapterConfirmAward chapterConfirmAward_;

	private CSMsgCollectionViewCardPortrait collectionViewCardPortrait_;

	private CSMsgActorSetSoulSkill actorSetSoulSkill_;

	private CSMsgGardenUpdateCropOutput gardenUpdateCropOutput_;

	private CSMsgGardenCollectCropOutput gardenCollectCropOutput_;

	private CSMsgGardenPlantAllSeeds gardenPlantAllSeeds_;

	private CSMsgBagActivateWeapon bagActivateWeapon_;

	private CSMsgBagGetAlchemyNpcCommunicationAward bagGetAlchemyNpcCommunicationAward_;

	private CSMsgBagUpdateAlchemyNpcCommunicationStatus bagUpdateAlchemyNpcCommunicationStatus_;

	private CSMsgBagHuluUpgrade bagHuluUpgrade_;

	private CSMsgBagCollectDropSoulSkill bagCollectDropSoulSkill_;

	private CSMsgActorWearAccessory actorWearAccessory_;

	private CSMsgActorUnWearAccessory actorUnWearAccessory_;

	private CSMsgAchievementEnterLevel achievementEnterLevel_;

	private CSMsgBagSoulSkillUpgrade bagSoulSkillUpgrade_;

	private CSMsgActorActivateLegacyTalent actorActivateLegacyTalent_;

	private CSMsgActorRebuildLegacyTalent actorRebuildLegacyTalent_;

	private CSMsgBagRebuildAttrItem bagRebuildAttrItem_;

	private CSMsgActivitiesResume activitiesResume_;

	private CSMsgCollectionCollectItem collectionCollectItem_;

	private CSMsgChapterPrologueCompleted chapterPrologueCompleted_;

	private CSMsgAttrRefresh attrRefresh_;

	private CSMsgMiscTestLargePackage miscTestLargePackage_;

	private CSMsgInteractSoulBottleGainItem interactSoulBottleGainItem_;

	private CSMsgBossRushBattleStart bossRushBattleStart_;

	private CSMsgBossRushBattleComplete bossRushBattleComplete_;

	public static MessageParser<CSMsg> Parser => _parser;

	public CSMsgHead Head
	{
		get
		{
			return head_;
		}
		set
		{
			head_ = value;
		}
	}

	public CSMsgRoleLogin RoleLogin
	{
		get
		{
			return roleLogin_;
		}
		set
		{
			roleLogin_ = value;
		}
	}

	public CSMsgRoleLogout RoleLogout
	{
		get
		{
			return roleLogout_;
		}
		set
		{
			roleLogout_ = value;
		}
	}

	public CSMsgRoleKick RoleKick
	{
		get
		{
			return roleKick_;
		}
		set
		{
			roleKick_ = value;
		}
	}

	public CSMsgRoleDataNotify RoleDataNotify
	{
		get
		{
			return roleDataNotify_;
		}
		set
		{
			roleDataNotify_ = value;
		}
	}

	public CSMsgRoleRandomName RoleRandomName
	{
		get
		{
			return roleRandomName_;
		}
		set
		{
			roleRandomName_ = value;
		}
	}

	public CSMsgRoleChangeName RoleChangeName
	{
		get
		{
			return roleChangeName_;
		}
		set
		{
			roleChangeName_ = value;
		}
	}

	public CSMsgMiscCreateRole MiscCreateRole
	{
		get
		{
			return miscCreateRole_;
		}
		set
		{
			miscCreateRole_ = value;
		}
	}

	public CSMsgMiscExecGM MiscExecGm
	{
		get
		{
			return miscExecGm_;
		}
		set
		{
			miscExecGm_ = value;
		}
	}

	public CSMsgMiscHeartBeat MiscHeartBeat
	{
		get
		{
			return miscHeartBeat_;
		}
		set
		{
			miscHeartBeat_ = value;
		}
	}

	public CSMsgMiscCheckRes MiscCheckRes
	{
		get
		{
			return miscCheckRes_;
		}
		set
		{
			miscCheckRes_ = value;
		}
	}

	public CSMsgAwolMsgGetList AwolMsgGetList
	{
		get
		{
			return awolMsgGetList_;
		}
		set
		{
			awolMsgGetList_ = value;
		}
	}

	public CSMsgAwolMsgRemove AwolMsgRemove
	{
		get
		{
			return awolMsgRemove_;
		}
		set
		{
			awolMsgRemove_ = value;
		}
	}

	public CSMsgAwolMsgUpdate AwolMsgUpdate
	{
		get
		{
			return awolMsgUpdate_;
		}
		set
		{
			awolMsgUpdate_ = value;
		}
	}

	public CSMsgAwolMsgSend AwolMsgSend
	{
		get
		{
			return awolMsgSend_;
		}
		set
		{
			awolMsgSend_ = value;
		}
	}

	public CSMsgAwolMsgNotifyUpdate AwolMsgNotifyUpdate
	{
		get
		{
			return awolMsgNotifyUpdate_;
		}
		set
		{
			awolMsgNotifyUpdate_ = value;
		}
	}

	public CSMsgAwolMsgNotifyRemove AwolMsgNotifyRemove
	{
		get
		{
			return awolMsgNotifyRemove_;
		}
		set
		{
			awolMsgNotifyRemove_ = value;
		}
	}

	public CSMsgAwolMsgNotifyAdd AwolMsgNotifyAdd
	{
		get
		{
			return awolMsgNotifyAdd_;
		}
		set
		{
			awolMsgNotifyAdd_ = value;
		}
	}

	public CSMsgBriefMsgGet BriefMsgGet
	{
		get
		{
			return briefMsgGet_;
		}
		set
		{
			briefMsgGet_ = value;
		}
	}

	public CSMsgRankListGet RankListGet
	{
		get
		{
			return rankListGet_;
		}
		set
		{
			rankListGet_ = value;
		}
	}

	public CSMsgBagGainItemList BagGainItemList
	{
		get
		{
			return bagGainItemList_;
		}
		set
		{
			bagGainItemList_ = value;
		}
	}

	public CSMsgBagCostItemList BagCostItemList
	{
		get
		{
			return bagCostItemList_;
		}
		set
		{
			bagCostItemList_ = value;
		}
	}

	public CSMsgBagHuluSetting BagHuluSetting
	{
		get
		{
			return bagHuluSetting_;
		}
		set
		{
			bagHuluSetting_ = value;
		}
	}

	public CSMsgBagAlchemy BagAlchemy
	{
		get
		{
			return bagAlchemy_;
		}
		set
		{
			bagAlchemy_ = value;
		}
	}

	public CSMsgBagWeaponBuild BagWeaponBuild
	{
		get
		{
			return bagWeaponBuild_;
		}
		set
		{
			bagWeaponBuild_ = value;
		}
	}

	public CSMsgBagWeaponReBuild BagWeaponReBuild
	{
		get
		{
			return bagWeaponReBuild_;
		}
		set
		{
			bagWeaponReBuild_ = value;
		}
	}

	public CSMsgBagDropUnitAward BagDropUnitAward
	{
		get
		{
			return bagDropUnitAward_;
		}
		set
		{
			bagDropUnitAward_ = value;
		}
	}

	public CSMsgBagCommDrop BagCommDrop
	{
		get
		{
			return bagCommDrop_;
		}
		set
		{
			bagCommDrop_ = value;
		}
	}

	public CSMsgBagWineUpgrade BagWineUpgrade
	{
		get
		{
			return bagWineUpgrade_;
		}
		set
		{
			bagWineUpgrade_ = value;
		}
	}

	public CSMsgBagWinePartnerSetting BagWinePartnerSetting
	{
		get
		{
			return bagWinePartnerSetting_;
		}
		set
		{
			bagWinePartnerSetting_ = value;
		}
	}

	public CSMsgBagGainEditionAward BagGainEditionAward
	{
		get
		{
			return bagGainEditionAward_;
		}
		set
		{
			bagGainEditionAward_ = value;
		}
	}

	public CSMsgActorWearEquip ActorWearEquip
	{
		get
		{
			return actorWearEquip_;
		}
		set
		{
			actorWearEquip_ = value;
		}
	}

	public CSMsgActorUnWearEquip ActorUnWearEquip
	{
		get
		{
			return actorUnWearEquip_;
		}
		set
		{
			actorUnWearEquip_ = value;
		}
	}

	public CSMsgActorSetShortCut ActorSetShortCut
	{
		get
		{
			return actorSetShortCut_;
		}
		set
		{
			actorSetShortCut_ = value;
		}
	}

	public CSMsgActorUnSetShortCut ActorUnSetShortCut
	{
		get
		{
			return actorUnSetShortCut_;
		}
		set
		{
			actorUnSetShortCut_ = value;
		}
	}

	public CSMsgActorSetSpell ActorSetSpell
	{
		get
		{
			return actorSetSpell_;
		}
		set
		{
			actorSetSpell_ = value;
		}
	}

	public CSMsgActorUnSetSpell ActorUnSetSpell
	{
		get
		{
			return actorUnSetSpell_;
		}
		set
		{
			actorUnSetSpell_ = value;
		}
	}

	public CSMsgActorSetDefaultSpell ActorSetDefaultSpell
	{
		get
		{
			return actorSetDefaultSpell_;
		}
		set
		{
			actorSetDefaultSpell_ = value;
		}
	}

	public CSMsgActorOnPlayerDeath ActorOnPlayerDeath
	{
		get
		{
			return actorOnPlayerDeath_;
		}
		set
		{
			actorOnPlayerDeath_ = value;
		}
	}

	public CSMsgActorOnPlayerRest ActorOnPlayerRest
	{
		get
		{
			return actorOnPlayerRest_;
		}
		set
		{
			actorOnPlayerRest_ = value;
		}
	}

	public CSMsgActorOnNewGamePlus ActorOnNewGamePlus
	{
		get
		{
			return actorOnNewGamePlus_;
		}
		set
		{
			actorOnNewGamePlus_ = value;
		}
	}

	public CSMsgActorUnLockTalent ActorUnLockTalent
	{
		get
		{
			return actorUnLockTalent_;
		}
		set
		{
			actorUnLockTalent_ = value;
		}
	}

	public CSMsgActorTalentLevelUp ActorTalentLevelUp
	{
		get
		{
			return actorTalentLevelUp_;
		}
		set
		{
			actorTalentLevelUp_ = value;
		}
	}

	public CSMsgActorRebuildTalent ActorRebuildTalent
	{
		get
		{
			return actorRebuildTalent_;
		}
		set
		{
			actorRebuildTalent_ = value;
		}
	}

	public CSMsgActorMeditationUnlock ActorMeditationUnlock
	{
		get
		{
			return actorMeditationUnlock_;
		}
		set
		{
			actorMeditationUnlock_ = value;
		}
	}

	public CSMsgActorOnPlayerExit ActorOnPlayerExit
	{
		get
		{
			return actorOnPlayerExit_;
		}
		set
		{
			actorOnPlayerExit_ = value;
		}
	}

	public CSMsgActorWineSetting ActorWineSetting
	{
		get
		{
			return actorWineSetting_;
		}
		set
		{
			actorWineSetting_ = value;
		}
	}

	public CSMsgShopPayBuyItem ShopPayBuyItem
	{
		get
		{
			return shopPayBuyItem_;
		}
		set
		{
			shopPayBuyItem_ = value;
		}
	}

	public CSMsgShopRefresh ShopRefresh
	{
		get
		{
			return shopRefresh_;
		}
		set
		{
			shopRefresh_ = value;
		}
	}

	public CSMsgBagSellItem BagSellItem
	{
		get
		{
			return bagSellItem_;
		}
		set
		{
			bagSellItem_ = value;
		}
	}

	public CSMsgShopRefreshFlagRemove ShopRefreshFlagRemove
	{
		get
		{
			return shopRefreshFlagRemove_;
		}
		set
		{
			shopRefreshFlagRemove_ = value;
		}
	}

	public CSMsgTaskChangeQuestStage TaskChangeQuestStage
	{
		get
		{
			return taskChangeQuestStage_;
		}
		set
		{
			taskChangeQuestStage_ = value;
		}
	}

	public CSMsgCollectionInteractiveUnlock CollectionInteractiveUnlock
	{
		get
		{
			return collectionInteractiveUnlock_;
		}
		set
		{
			collectionInteractiveUnlock_ = value;
		}
	}

	public CSMsgRedPointRemove RedPointRemove
	{
		get
		{
			return redPointRemove_;
		}
		set
		{
			redPointRemove_ = value;
		}
	}

	public CSMsgActorWeaponTransformFlexType ActorWeaponTransformFlexType
	{
		get
		{
			return actorWeaponTransformFlexType_;
		}
		set
		{
			actorWeaponTransformFlexType_ = value;
		}
	}

	public CSMsgActorKillUnit ActorKillUnit
	{
		get
		{
			return actorKillUnit_;
		}
		set
		{
			actorKillUnit_ = value;
		}
	}

	public CSMsgActorUnitEncounter ActorUnitEncounter
	{
		get
		{
			return actorUnitEncounter_;
		}
		set
		{
			actorUnitEncounter_ = value;
		}
	}

	public CSMsgAchievementUnlock AchievementUnlock
	{
		get
		{
			return achievementUnlock_;
		}
		set
		{
			achievementUnlock_ = value;
		}
	}

	public CSMsgChapterEnterNext ChapterEnterNext
	{
		get
		{
			return chapterEnterNext_;
		}
		set
		{
			chapterEnterNext_ = value;
		}
	}

	public CSMsgChapterEnterShow ChapterEnterShow
	{
		get
		{
			return chapterEnterShow_;
		}
		set
		{
			chapterEnterShow_ = value;
		}
	}

	public CSMsgChapterPreviewAward ChapterPreviewAward
	{
		get
		{
			return chapterPreviewAward_;
		}
		set
		{
			chapterPreviewAward_ = value;
		}
	}

	public CSMsgMuseumRecordMemories MuseumRecordMemories
	{
		get
		{
			return museumRecordMemories_;
		}
		set
		{
			museumRecordMemories_ = value;
		}
	}

	public CSMsgMuseumRemoveRedpoint MuseumRemoveRedpoint
	{
		get
		{
			return museumRemoveRedpoint_;
		}
		set
		{
			museumRemoveRedpoint_ = value;
		}
	}

	public CSMsgAttrChangeNotify AttrChangeNotify
	{
		get
		{
			return attrChangeNotify_;
		}
		set
		{
			attrChangeNotify_ = value;
		}
	}

	public CSMsgRoomCreatePartyCS RoomCreatePartyCs
	{
		get
		{
			return roomCreatePartyCs_;
		}
		set
		{
			roomCreatePartyCs_ = value;
		}
	}

	public CSMsgRoomJoinPartyCS RoomJoinPartyCs
	{
		get
		{
			return roomJoinPartyCs_;
		}
		set
		{
			roomJoinPartyCs_ = value;
		}
	}

	public CSMsgRoomExitPartyCS RoomExitPartyCs
	{
		get
		{
			return roomExitPartyCs_;
		}
		set
		{
			roomExitPartyCs_ = value;
		}
	}

	public CSMsgRoomPartyKickMemberCS RoomPartyKickMemberCs
	{
		get
		{
			return roomPartyKickMemberCs_;
		}
		set
		{
			roomPartyKickMemberCs_ = value;
		}
	}

	public CSMsgRoomSearchPartyCS RoomSearchPartyCs
	{
		get
		{
			return roomSearchPartyCs_;
		}
		set
		{
			roomSearchPartyCs_ = value;
		}
	}

	public CSMsgRoomSearchPartyNotify RoomSearchPartyNotify
	{
		get
		{
			return roomSearchPartyNotify_;
		}
		set
		{
			roomSearchPartyNotify_ = value;
		}
	}

	public CSMsgRoomQueryPartyInfoCS RoomQueryPartyInfoCs
	{
		get
		{
			return roomQueryPartyInfoCs_;
		}
		set
		{
			roomQueryPartyInfoCs_ = value;
		}
	}

	public CSMsgRoomPartyHeartBeatCS RoomPartyHeartBeatCs
	{
		get
		{
			return roomPartyHeartBeatCs_;
		}
		set
		{
			roomPartyHeartBeatCs_ = value;
		}
	}

	public CSMsgRoomPartyEventNotify RoomPartyEventNotify
	{
		get
		{
			return roomPartyEventNotify_;
		}
		set
		{
			roomPartyEventNotify_ = value;
		}
	}

	public CSMsgRoomSendPartyBattleMessageCS RoomSendPartyBattleMessageCs
	{
		get
		{
			return roomSendPartyBattleMessageCs_;
		}
		set
		{
			roomSendPartyBattleMessageCs_ = value;
		}
	}

	public CSMsgRoomPartyBattleMessageNotify RoomPartyBattleMessageNotify
	{
		get
		{
			return roomPartyBattleMessageNotify_;
		}
		set
		{
			roomPartyBattleMessageNotify_ = value;
		}
	}

	public CSMsgRoomPartyMemberUpdateCS RoomPartyMemberUpdateCs
	{
		get
		{
			return roomPartyMemberUpdateCs_;
		}
		set
		{
			roomPartyMemberUpdateCs_ = value;
		}
	}

	public CSMsgRoomCreatePartyTaskCS RoomCreatePartyTaskCs
	{
		get
		{
			return roomCreatePartyTaskCs_;
		}
		set
		{
			roomCreatePartyTaskCs_ = value;
		}
	}

	public CSMsgRoomUpdatePartyTaskCS RoomUpdatePartyTaskCs
	{
		get
		{
			return roomUpdatePartyTaskCs_;
		}
		set
		{
			roomUpdatePartyTaskCs_ = value;
		}
	}

	public CSMsgRoomPartyTaskFinishCS RoomPartyTaskFinishCs
	{
		get
		{
			return roomPartyTaskFinishCs_;
		}
		set
		{
			roomPartyTaskFinishCs_ = value;
		}
	}

	public CSMsgBagMultiplayerDrop BagMultiplayerDrop
	{
		get
		{
			return bagMultiplayerDrop_;
		}
		set
		{
			bagMultiplayerDrop_ = value;
		}
	}

	public CSMsgChapterGameComplete ChapterGameComplete
	{
		get
		{
			return chapterGameComplete_;
		}
		set
		{
			chapterGameComplete_ = value;
		}
	}

	public CSMsgCollectionReadCardStory CollectionReadCardStory
	{
		get
		{
			return collectionReadCardStory_;
		}
		set
		{
			collectionReadCardStory_ = value;
		}
	}

	public CSMsgBagArmorUpgrade BagArmorUpgrade
	{
		get
		{
			return bagArmorUpgrade_;
		}
		set
		{
			bagArmorUpgrade_ = value;
		}
	}

	public CSMsgBagDropCollectionAward BagDropCollectionAward
	{
		get
		{
			return bagDropCollectionAward_;
		}
		set
		{
			bagDropCollectionAward_ = value;
		}
	}

	public CSMsgPartyApiCreateOnlineParty PartyApiCreateOnlineParty
	{
		get
		{
			return partyApiCreateOnlineParty_;
		}
		set
		{
			partyApiCreateOnlineParty_ = value;
		}
	}

	public CSMsgPartyApiSearchParty PartyApiSearchParty
	{
		get
		{
			return partyApiSearchParty_;
		}
		set
		{
			partyApiSearchParty_ = value;
		}
	}

	public CSMsgPartyApiJoinParty PartyApiJoinParty
	{
		get
		{
			return partyApiJoinParty_;
		}
		set
		{
			partyApiJoinParty_ = value;
		}
	}

	public CSMsgPartyApiLeaderCreateTask PartyApiLeaderCreateTask
	{
		get
		{
			return partyApiLeaderCreateTask_;
		}
		set
		{
			partyApiLeaderCreateTask_ = value;
		}
	}

	public CSMsgPartyApiMemberTaskReady PartyApiMemberTaskReady
	{
		get
		{
			return partyApiMemberTaskReady_;
		}
		set
		{
			partyApiMemberTaskReady_ = value;
		}
	}

	public CSMsgPartyApiLeaderFinishTask PartyApiLeaderFinishTask
	{
		get
		{
			return partyApiLeaderFinishTask_;
		}
		set
		{
			partyApiLeaderFinishTask_ = value;
		}
	}

	public CSMsgPartyApiLeaderCreateBattle PartyApiLeaderCreateBattle
	{
		get
		{
			return partyApiLeaderCreateBattle_;
		}
		set
		{
			partyApiLeaderCreateBattle_ = value;
		}
	}

	public CSMsgPartyApiLeaderBattleReady PartyApiLeaderBattleReady
	{
		get
		{
			return partyApiLeaderBattleReady_;
		}
		set
		{
			partyApiLeaderBattleReady_ = value;
		}
	}

	public CSMsgPartyApiMemberEnterBattle PartyApiMemberEnterBattle
	{
		get
		{
			return partyApiMemberEnterBattle_;
		}
		set
		{
			partyApiMemberEnterBattle_ = value;
		}
	}

	public CSMsgPartyApiLeaderRequestHelp PartyApiLeaderRequestHelp
	{
		get
		{
			return partyApiLeaderRequestHelp_;
		}
		set
		{
			partyApiLeaderRequestHelp_ = value;
		}
	}

	public CSMsgPartyApiLeaderCancelHelp PartyApiLeaderCancelHelp
	{
		get
		{
			return partyApiLeaderCancelHelp_;
		}
		set
		{
			partyApiLeaderCancelHelp_ = value;
		}
	}

	public CSMsgChapterConfirmAward ChapterConfirmAward
	{
		get
		{
			return chapterConfirmAward_;
		}
		set
		{
			chapterConfirmAward_ = value;
		}
	}

	public CSMsgCollectionViewCardPortrait CollectionViewCardPortrait
	{
		get
		{
			return collectionViewCardPortrait_;
		}
		set
		{
			collectionViewCardPortrait_ = value;
		}
	}

	public CSMsgActorSetSoulSkill ActorSetSoulSkill
	{
		get
		{
			return actorSetSoulSkill_;
		}
		set
		{
			actorSetSoulSkill_ = value;
		}
	}

	public CSMsgGardenUpdateCropOutput GardenUpdateCropOutput
	{
		get
		{
			return gardenUpdateCropOutput_;
		}
		set
		{
			gardenUpdateCropOutput_ = value;
		}
	}

	public CSMsgGardenCollectCropOutput GardenCollectCropOutput
	{
		get
		{
			return gardenCollectCropOutput_;
		}
		set
		{
			gardenCollectCropOutput_ = value;
		}
	}

	public CSMsgGardenPlantAllSeeds GardenPlantAllSeeds
	{
		get
		{
			return gardenPlantAllSeeds_;
		}
		set
		{
			gardenPlantAllSeeds_ = value;
		}
	}

	public CSMsgBagActivateWeapon BagActivateWeapon
	{
		get
		{
			return bagActivateWeapon_;
		}
		set
		{
			bagActivateWeapon_ = value;
		}
	}

	public CSMsgBagGetAlchemyNpcCommunicationAward BagGetAlchemyNpcCommunicationAward
	{
		get
		{
			return bagGetAlchemyNpcCommunicationAward_;
		}
		set
		{
			bagGetAlchemyNpcCommunicationAward_ = value;
		}
	}

	public CSMsgBagUpdateAlchemyNpcCommunicationStatus BagUpdateAlchemyNpcCommunicationStatus
	{
		get
		{
			return bagUpdateAlchemyNpcCommunicationStatus_;
		}
		set
		{
			bagUpdateAlchemyNpcCommunicationStatus_ = value;
		}
	}

	public CSMsgBagHuluUpgrade BagHuluUpgrade
	{
		get
		{
			return bagHuluUpgrade_;
		}
		set
		{
			bagHuluUpgrade_ = value;
		}
	}

	public CSMsgBagCollectDropSoulSkill BagCollectDropSoulSkill
	{
		get
		{
			return bagCollectDropSoulSkill_;
		}
		set
		{
			bagCollectDropSoulSkill_ = value;
		}
	}

	public CSMsgActorWearAccessory ActorWearAccessory
	{
		get
		{
			return actorWearAccessory_;
		}
		set
		{
			actorWearAccessory_ = value;
		}
	}

	public CSMsgActorUnWearAccessory ActorUnWearAccessory
	{
		get
		{
			return actorUnWearAccessory_;
		}
		set
		{
			actorUnWearAccessory_ = value;
		}
	}

	public CSMsgAchievementEnterLevel AchievementEnterLevel
	{
		get
		{
			return achievementEnterLevel_;
		}
		set
		{
			achievementEnterLevel_ = value;
		}
	}

	public CSMsgBagSoulSkillUpgrade BagSoulSkillUpgrade
	{
		get
		{
			return bagSoulSkillUpgrade_;
		}
		set
		{
			bagSoulSkillUpgrade_ = value;
		}
	}

	public CSMsgActorActivateLegacyTalent ActorActivateLegacyTalent
	{
		get
		{
			return actorActivateLegacyTalent_;
		}
		set
		{
			actorActivateLegacyTalent_ = value;
		}
	}

	public CSMsgActorRebuildLegacyTalent ActorRebuildLegacyTalent
	{
		get
		{
			return actorRebuildLegacyTalent_;
		}
		set
		{
			actorRebuildLegacyTalent_ = value;
		}
	}

	public CSMsgBagRebuildAttrItem BagRebuildAttrItem
	{
		get
		{
			return bagRebuildAttrItem_;
		}
		set
		{
			bagRebuildAttrItem_ = value;
		}
	}

	public CSMsgActivitiesResume ActivitiesResume
	{
		get
		{
			return activitiesResume_;
		}
		set
		{
			activitiesResume_ = value;
		}
	}

	public CSMsgCollectionCollectItem CollectionCollectItem
	{
		get
		{
			return collectionCollectItem_;
		}
		set
		{
			collectionCollectItem_ = value;
		}
	}

	public CSMsgChapterPrologueCompleted ChapterPrologueCompleted
	{
		get
		{
			return chapterPrologueCompleted_;
		}
		set
		{
			chapterPrologueCompleted_ = value;
		}
	}

	public CSMsgAttrRefresh AttrRefresh
	{
		get
		{
			return attrRefresh_;
		}
		set
		{
			attrRefresh_ = value;
		}
	}

	public CSMsgMiscTestLargePackage MiscTestLargePackage
	{
		get
		{
			return miscTestLargePackage_;
		}
		set
		{
			miscTestLargePackage_ = value;
		}
	}

	public CSMsgInteractSoulBottleGainItem InteractSoulBottleGainItem
	{
		get
		{
			return interactSoulBottleGainItem_;
		}
		set
		{
			interactSoulBottleGainItem_ = value;
		}
	}

	public CSMsgBossRushBattleStart BossRushBattleStart
	{
		get
		{
			return bossRushBattleStart_;
		}
		set
		{
			bossRushBattleStart_ = value;
		}
	}

	public CSMsgBossRushBattleComplete BossRushBattleComplete
	{
		get
		{
			return bossRushBattleComplete_;
		}
		set
		{
			bossRushBattleComplete_ = value;
		}
	}

	public CSMsg()
	{
	}

	public CSMsg(CSMsg other)
		: this()
	{
		head_ = ((other.head_ != null) ? other.head_.Clone() : null);
		roleLogin_ = ((other.roleLogin_ != null) ? other.roleLogin_.Clone() : null);
		roleLogout_ = ((other.roleLogout_ != null) ? other.roleLogout_.Clone() : null);
		roleKick_ = ((other.roleKick_ != null) ? other.roleKick_.Clone() : null);
		roleDataNotify_ = ((other.roleDataNotify_ != null) ? other.roleDataNotify_.Clone() : null);
		roleRandomName_ = ((other.roleRandomName_ != null) ? other.roleRandomName_.Clone() : null);
		roleChangeName_ = ((other.roleChangeName_ != null) ? other.roleChangeName_.Clone() : null);
		miscCreateRole_ = ((other.miscCreateRole_ != null) ? other.miscCreateRole_.Clone() : null);
		miscExecGm_ = ((other.miscExecGm_ != null) ? other.miscExecGm_.Clone() : null);
		miscHeartBeat_ = ((other.miscHeartBeat_ != null) ? other.miscHeartBeat_.Clone() : null);
		miscCheckRes_ = ((other.miscCheckRes_ != null) ? other.miscCheckRes_.Clone() : null);
		awolMsgGetList_ = ((other.awolMsgGetList_ != null) ? other.awolMsgGetList_.Clone() : null);
		awolMsgRemove_ = ((other.awolMsgRemove_ != null) ? other.awolMsgRemove_.Clone() : null);
		awolMsgUpdate_ = ((other.awolMsgUpdate_ != null) ? other.awolMsgUpdate_.Clone() : null);
		awolMsgSend_ = ((other.awolMsgSend_ != null) ? other.awolMsgSend_.Clone() : null);
		awolMsgNotifyUpdate_ = ((other.awolMsgNotifyUpdate_ != null) ? other.awolMsgNotifyUpdate_.Clone() : null);
		awolMsgNotifyRemove_ = ((other.awolMsgNotifyRemove_ != null) ? other.awolMsgNotifyRemove_.Clone() : null);
		awolMsgNotifyAdd_ = ((other.awolMsgNotifyAdd_ != null) ? other.awolMsgNotifyAdd_.Clone() : null);
		briefMsgGet_ = ((other.briefMsgGet_ != null) ? other.briefMsgGet_.Clone() : null);
		rankListGet_ = ((other.rankListGet_ != null) ? other.rankListGet_.Clone() : null);
		bagGainItemList_ = ((other.bagGainItemList_ != null) ? other.bagGainItemList_.Clone() : null);
		bagCostItemList_ = ((other.bagCostItemList_ != null) ? other.bagCostItemList_.Clone() : null);
		bagHuluSetting_ = ((other.bagHuluSetting_ != null) ? other.bagHuluSetting_.Clone() : null);
		bagAlchemy_ = ((other.bagAlchemy_ != null) ? other.bagAlchemy_.Clone() : null);
		bagWeaponBuild_ = ((other.bagWeaponBuild_ != null) ? other.bagWeaponBuild_.Clone() : null);
		bagWeaponReBuild_ = ((other.bagWeaponReBuild_ != null) ? other.bagWeaponReBuild_.Clone() : null);
		bagDropUnitAward_ = ((other.bagDropUnitAward_ != null) ? other.bagDropUnitAward_.Clone() : null);
		bagCommDrop_ = ((other.bagCommDrop_ != null) ? other.bagCommDrop_.Clone() : null);
		bagWineUpgrade_ = ((other.bagWineUpgrade_ != null) ? other.bagWineUpgrade_.Clone() : null);
		bagWinePartnerSetting_ = ((other.bagWinePartnerSetting_ != null) ? other.bagWinePartnerSetting_.Clone() : null);
		bagGainEditionAward_ = ((other.bagGainEditionAward_ != null) ? other.bagGainEditionAward_.Clone() : null);
		actorWearEquip_ = ((other.actorWearEquip_ != null) ? other.actorWearEquip_.Clone() : null);
		actorUnWearEquip_ = ((other.actorUnWearEquip_ != null) ? other.actorUnWearEquip_.Clone() : null);
		actorSetShortCut_ = ((other.actorSetShortCut_ != null) ? other.actorSetShortCut_.Clone() : null);
		actorUnSetShortCut_ = ((other.actorUnSetShortCut_ != null) ? other.actorUnSetShortCut_.Clone() : null);
		actorSetSpell_ = ((other.actorSetSpell_ != null) ? other.actorSetSpell_.Clone() : null);
		actorUnSetSpell_ = ((other.actorUnSetSpell_ != null) ? other.actorUnSetSpell_.Clone() : null);
		actorSetDefaultSpell_ = ((other.actorSetDefaultSpell_ != null) ? other.actorSetDefaultSpell_.Clone() : null);
		actorOnPlayerDeath_ = ((other.actorOnPlayerDeath_ != null) ? other.actorOnPlayerDeath_.Clone() : null);
		actorOnPlayerRest_ = ((other.actorOnPlayerRest_ != null) ? other.actorOnPlayerRest_.Clone() : null);
		actorOnNewGamePlus_ = ((other.actorOnNewGamePlus_ != null) ? other.actorOnNewGamePlus_.Clone() : null);
		actorUnLockTalent_ = ((other.actorUnLockTalent_ != null) ? other.actorUnLockTalent_.Clone() : null);
		actorTalentLevelUp_ = ((other.actorTalentLevelUp_ != null) ? other.actorTalentLevelUp_.Clone() : null);
		actorRebuildTalent_ = ((other.actorRebuildTalent_ != null) ? other.actorRebuildTalent_.Clone() : null);
		actorMeditationUnlock_ = ((other.actorMeditationUnlock_ != null) ? other.actorMeditationUnlock_.Clone() : null);
		actorOnPlayerExit_ = ((other.actorOnPlayerExit_ != null) ? other.actorOnPlayerExit_.Clone() : null);
		actorWineSetting_ = ((other.actorWineSetting_ != null) ? other.actorWineSetting_.Clone() : null);
		shopPayBuyItem_ = ((other.shopPayBuyItem_ != null) ? other.shopPayBuyItem_.Clone() : null);
		shopRefresh_ = ((other.shopRefresh_ != null) ? other.shopRefresh_.Clone() : null);
		bagSellItem_ = ((other.bagSellItem_ != null) ? other.bagSellItem_.Clone() : null);
		shopRefreshFlagRemove_ = ((other.shopRefreshFlagRemove_ != null) ? other.shopRefreshFlagRemove_.Clone() : null);
		taskChangeQuestStage_ = ((other.taskChangeQuestStage_ != null) ? other.taskChangeQuestStage_.Clone() : null);
		collectionInteractiveUnlock_ = ((other.collectionInteractiveUnlock_ != null) ? other.collectionInteractiveUnlock_.Clone() : null);
		redPointRemove_ = ((other.redPointRemove_ != null) ? other.redPointRemove_.Clone() : null);
		actorWeaponTransformFlexType_ = ((other.actorWeaponTransformFlexType_ != null) ? other.actorWeaponTransformFlexType_.Clone() : null);
		actorKillUnit_ = ((other.actorKillUnit_ != null) ? other.actorKillUnit_.Clone() : null);
		actorUnitEncounter_ = ((other.actorUnitEncounter_ != null) ? other.actorUnitEncounter_.Clone() : null);
		achievementUnlock_ = ((other.achievementUnlock_ != null) ? other.achievementUnlock_.Clone() : null);
		chapterEnterNext_ = ((other.chapterEnterNext_ != null) ? other.chapterEnterNext_.Clone() : null);
		chapterEnterShow_ = ((other.chapterEnterShow_ != null) ? other.chapterEnterShow_.Clone() : null);
		chapterPreviewAward_ = ((other.chapterPreviewAward_ != null) ? other.chapterPreviewAward_.Clone() : null);
		museumRecordMemories_ = ((other.museumRecordMemories_ != null) ? other.museumRecordMemories_.Clone() : null);
		museumRemoveRedpoint_ = ((other.museumRemoveRedpoint_ != null) ? other.museumRemoveRedpoint_.Clone() : null);
		attrChangeNotify_ = ((other.attrChangeNotify_ != null) ? other.attrChangeNotify_.Clone() : null);
		roomCreatePartyCs_ = ((other.roomCreatePartyCs_ != null) ? other.roomCreatePartyCs_.Clone() : null);
		roomJoinPartyCs_ = ((other.roomJoinPartyCs_ != null) ? other.roomJoinPartyCs_.Clone() : null);
		roomExitPartyCs_ = ((other.roomExitPartyCs_ != null) ? other.roomExitPartyCs_.Clone() : null);
		roomPartyKickMemberCs_ = ((other.roomPartyKickMemberCs_ != null) ? other.roomPartyKickMemberCs_.Clone() : null);
		roomSearchPartyCs_ = ((other.roomSearchPartyCs_ != null) ? other.roomSearchPartyCs_.Clone() : null);
		roomSearchPartyNotify_ = ((other.roomSearchPartyNotify_ != null) ? other.roomSearchPartyNotify_.Clone() : null);
		roomQueryPartyInfoCs_ = ((other.roomQueryPartyInfoCs_ != null) ? other.roomQueryPartyInfoCs_.Clone() : null);
		roomPartyHeartBeatCs_ = ((other.roomPartyHeartBeatCs_ != null) ? other.roomPartyHeartBeatCs_.Clone() : null);
		roomPartyEventNotify_ = ((other.roomPartyEventNotify_ != null) ? other.roomPartyEventNotify_.Clone() : null);
		roomSendPartyBattleMessageCs_ = ((other.roomSendPartyBattleMessageCs_ != null) ? other.roomSendPartyBattleMessageCs_.Clone() : null);
		roomPartyBattleMessageNotify_ = ((other.roomPartyBattleMessageNotify_ != null) ? other.roomPartyBattleMessageNotify_.Clone() : null);
		roomPartyMemberUpdateCs_ = ((other.roomPartyMemberUpdateCs_ != null) ? other.roomPartyMemberUpdateCs_.Clone() : null);
		roomCreatePartyTaskCs_ = ((other.roomCreatePartyTaskCs_ != null) ? other.roomCreatePartyTaskCs_.Clone() : null);
		roomUpdatePartyTaskCs_ = ((other.roomUpdatePartyTaskCs_ != null) ? other.roomUpdatePartyTaskCs_.Clone() : null);
		roomPartyTaskFinishCs_ = ((other.roomPartyTaskFinishCs_ != null) ? other.roomPartyTaskFinishCs_.Clone() : null);
		bagMultiplayerDrop_ = ((other.bagMultiplayerDrop_ != null) ? other.bagMultiplayerDrop_.Clone() : null);
		chapterGameComplete_ = ((other.chapterGameComplete_ != null) ? other.chapterGameComplete_.Clone() : null);
		collectionReadCardStory_ = ((other.collectionReadCardStory_ != null) ? other.collectionReadCardStory_.Clone() : null);
		bagArmorUpgrade_ = ((other.bagArmorUpgrade_ != null) ? other.bagArmorUpgrade_.Clone() : null);
		bagDropCollectionAward_ = ((other.bagDropCollectionAward_ != null) ? other.bagDropCollectionAward_.Clone() : null);
		partyApiCreateOnlineParty_ = ((other.partyApiCreateOnlineParty_ != null) ? other.partyApiCreateOnlineParty_.Clone() : null);
		partyApiSearchParty_ = ((other.partyApiSearchParty_ != null) ? other.partyApiSearchParty_.Clone() : null);
		partyApiJoinParty_ = ((other.partyApiJoinParty_ != null) ? other.partyApiJoinParty_.Clone() : null);
		partyApiLeaderCreateTask_ = ((other.partyApiLeaderCreateTask_ != null) ? other.partyApiLeaderCreateTask_.Clone() : null);
		partyApiMemberTaskReady_ = ((other.partyApiMemberTaskReady_ != null) ? other.partyApiMemberTaskReady_.Clone() : null);
		partyApiLeaderFinishTask_ = ((other.partyApiLeaderFinishTask_ != null) ? other.partyApiLeaderFinishTask_.Clone() : null);
		partyApiLeaderCreateBattle_ = ((other.partyApiLeaderCreateBattle_ != null) ? other.partyApiLeaderCreateBattle_.Clone() : null);
		partyApiLeaderBattleReady_ = ((other.partyApiLeaderBattleReady_ != null) ? other.partyApiLeaderBattleReady_.Clone() : null);
		partyApiMemberEnterBattle_ = ((other.partyApiMemberEnterBattle_ != null) ? other.partyApiMemberEnterBattle_.Clone() : null);
		partyApiLeaderRequestHelp_ = ((other.partyApiLeaderRequestHelp_ != null) ? other.partyApiLeaderRequestHelp_.Clone() : null);
		partyApiLeaderCancelHelp_ = ((other.partyApiLeaderCancelHelp_ != null) ? other.partyApiLeaderCancelHelp_.Clone() : null);
		chapterConfirmAward_ = ((other.chapterConfirmAward_ != null) ? other.chapterConfirmAward_.Clone() : null);
		collectionViewCardPortrait_ = ((other.collectionViewCardPortrait_ != null) ? other.collectionViewCardPortrait_.Clone() : null);
		actorSetSoulSkill_ = ((other.actorSetSoulSkill_ != null) ? other.actorSetSoulSkill_.Clone() : null);
		gardenUpdateCropOutput_ = ((other.gardenUpdateCropOutput_ != null) ? other.gardenUpdateCropOutput_.Clone() : null);
		gardenCollectCropOutput_ = ((other.gardenCollectCropOutput_ != null) ? other.gardenCollectCropOutput_.Clone() : null);
		gardenPlantAllSeeds_ = ((other.gardenPlantAllSeeds_ != null) ? other.gardenPlantAllSeeds_.Clone() : null);
		bagActivateWeapon_ = ((other.bagActivateWeapon_ != null) ? other.bagActivateWeapon_.Clone() : null);
		bagGetAlchemyNpcCommunicationAward_ = ((other.bagGetAlchemyNpcCommunicationAward_ != null) ? other.bagGetAlchemyNpcCommunicationAward_.Clone() : null);
		bagUpdateAlchemyNpcCommunicationStatus_ = ((other.bagUpdateAlchemyNpcCommunicationStatus_ != null) ? other.bagUpdateAlchemyNpcCommunicationStatus_.Clone() : null);
		bagHuluUpgrade_ = ((other.bagHuluUpgrade_ != null) ? other.bagHuluUpgrade_.Clone() : null);
		bagCollectDropSoulSkill_ = ((other.bagCollectDropSoulSkill_ != null) ? other.bagCollectDropSoulSkill_.Clone() : null);
		actorWearAccessory_ = ((other.actorWearAccessory_ != null) ? other.actorWearAccessory_.Clone() : null);
		actorUnWearAccessory_ = ((other.actorUnWearAccessory_ != null) ? other.actorUnWearAccessory_.Clone() : null);
		achievementEnterLevel_ = ((other.achievementEnterLevel_ != null) ? other.achievementEnterLevel_.Clone() : null);
		bagSoulSkillUpgrade_ = ((other.bagSoulSkillUpgrade_ != null) ? other.bagSoulSkillUpgrade_.Clone() : null);
		actorActivateLegacyTalent_ = ((other.actorActivateLegacyTalent_ != null) ? other.actorActivateLegacyTalent_.Clone() : null);
		actorRebuildLegacyTalent_ = ((other.actorRebuildLegacyTalent_ != null) ? other.actorRebuildLegacyTalent_.Clone() : null);
		bagRebuildAttrItem_ = ((other.bagRebuildAttrItem_ != null) ? other.bagRebuildAttrItem_.Clone() : null);
		activitiesResume_ = ((other.activitiesResume_ != null) ? other.activitiesResume_.Clone() : null);
		collectionCollectItem_ = ((other.collectionCollectItem_ != null) ? other.collectionCollectItem_.Clone() : null);
		chapterPrologueCompleted_ = ((other.chapterPrologueCompleted_ != null) ? other.chapterPrologueCompleted_.Clone() : null);
		attrRefresh_ = ((other.attrRefresh_ != null) ? other.attrRefresh_.Clone() : null);
		miscTestLargePackage_ = ((other.miscTestLargePackage_ != null) ? other.miscTestLargePackage_.Clone() : null);
		interactSoulBottleGainItem_ = ((other.interactSoulBottleGainItem_ != null) ? other.interactSoulBottleGainItem_.Clone() : null);
		bossRushBattleStart_ = ((other.bossRushBattleStart_ != null) ? other.bossRushBattleStart_.Clone() : null);
		bossRushBattleComplete_ = ((other.bossRushBattleComplete_ != null) ? other.bossRushBattleComplete_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsg Clone()
	{
		return new CSMsg(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsg);
	}

	public bool Equals(CSMsg other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(Head, other.Head))
		{
			return false;
		}
		if (!object.Equals(RoleLogin, other.RoleLogin))
		{
			return false;
		}
		if (!object.Equals(RoleLogout, other.RoleLogout))
		{
			return false;
		}
		if (!object.Equals(RoleKick, other.RoleKick))
		{
			return false;
		}
		if (!object.Equals(RoleDataNotify, other.RoleDataNotify))
		{
			return false;
		}
		if (!object.Equals(RoleRandomName, other.RoleRandomName))
		{
			return false;
		}
		if (!object.Equals(RoleChangeName, other.RoleChangeName))
		{
			return false;
		}
		if (!object.Equals(MiscCreateRole, other.MiscCreateRole))
		{
			return false;
		}
		if (!object.Equals(MiscExecGm, other.MiscExecGm))
		{
			return false;
		}
		if (!object.Equals(MiscHeartBeat, other.MiscHeartBeat))
		{
			return false;
		}
		if (!object.Equals(MiscCheckRes, other.MiscCheckRes))
		{
			return false;
		}
		if (!object.Equals(AwolMsgGetList, other.AwolMsgGetList))
		{
			return false;
		}
		if (!object.Equals(AwolMsgRemove, other.AwolMsgRemove))
		{
			return false;
		}
		if (!object.Equals(AwolMsgUpdate, other.AwolMsgUpdate))
		{
			return false;
		}
		if (!object.Equals(AwolMsgSend, other.AwolMsgSend))
		{
			return false;
		}
		if (!object.Equals(AwolMsgNotifyUpdate, other.AwolMsgNotifyUpdate))
		{
			return false;
		}
		if (!object.Equals(AwolMsgNotifyRemove, other.AwolMsgNotifyRemove))
		{
			return false;
		}
		if (!object.Equals(AwolMsgNotifyAdd, other.AwolMsgNotifyAdd))
		{
			return false;
		}
		if (!object.Equals(BriefMsgGet, other.BriefMsgGet))
		{
			return false;
		}
		if (!object.Equals(RankListGet, other.RankListGet))
		{
			return false;
		}
		if (!object.Equals(BagGainItemList, other.BagGainItemList))
		{
			return false;
		}
		if (!object.Equals(BagCostItemList, other.BagCostItemList))
		{
			return false;
		}
		if (!object.Equals(BagHuluSetting, other.BagHuluSetting))
		{
			return false;
		}
		if (!object.Equals(BagAlchemy, other.BagAlchemy))
		{
			return false;
		}
		if (!object.Equals(BagWeaponBuild, other.BagWeaponBuild))
		{
			return false;
		}
		if (!object.Equals(BagWeaponReBuild, other.BagWeaponReBuild))
		{
			return false;
		}
		if (!object.Equals(BagDropUnitAward, other.BagDropUnitAward))
		{
			return false;
		}
		if (!object.Equals(BagCommDrop, other.BagCommDrop))
		{
			return false;
		}
		if (!object.Equals(BagWineUpgrade, other.BagWineUpgrade))
		{
			return false;
		}
		if (!object.Equals(BagWinePartnerSetting, other.BagWinePartnerSetting))
		{
			return false;
		}
		if (!object.Equals(BagGainEditionAward, other.BagGainEditionAward))
		{
			return false;
		}
		if (!object.Equals(ActorWearEquip, other.ActorWearEquip))
		{
			return false;
		}
		if (!object.Equals(ActorUnWearEquip, other.ActorUnWearEquip))
		{
			return false;
		}
		if (!object.Equals(ActorSetShortCut, other.ActorSetShortCut))
		{
			return false;
		}
		if (!object.Equals(ActorUnSetShortCut, other.ActorUnSetShortCut))
		{
			return false;
		}
		if (!object.Equals(ActorSetSpell, other.ActorSetSpell))
		{
			return false;
		}
		if (!object.Equals(ActorUnSetSpell, other.ActorUnSetSpell))
		{
			return false;
		}
		if (!object.Equals(ActorSetDefaultSpell, other.ActorSetDefaultSpell))
		{
			return false;
		}
		if (!object.Equals(ActorOnPlayerDeath, other.ActorOnPlayerDeath))
		{
			return false;
		}
		if (!object.Equals(ActorOnPlayerRest, other.ActorOnPlayerRest))
		{
			return false;
		}
		if (!object.Equals(ActorOnNewGamePlus, other.ActorOnNewGamePlus))
		{
			return false;
		}
		if (!object.Equals(ActorUnLockTalent, other.ActorUnLockTalent))
		{
			return false;
		}
		if (!object.Equals(ActorTalentLevelUp, other.ActorTalentLevelUp))
		{
			return false;
		}
		if (!object.Equals(ActorRebuildTalent, other.ActorRebuildTalent))
		{
			return false;
		}
		if (!object.Equals(ActorMeditationUnlock, other.ActorMeditationUnlock))
		{
			return false;
		}
		if (!object.Equals(ActorOnPlayerExit, other.ActorOnPlayerExit))
		{
			return false;
		}
		if (!object.Equals(ActorWineSetting, other.ActorWineSetting))
		{
			return false;
		}
		if (!object.Equals(ShopPayBuyItem, other.ShopPayBuyItem))
		{
			return false;
		}
		if (!object.Equals(ShopRefresh, other.ShopRefresh))
		{
			return false;
		}
		if (!object.Equals(BagSellItem, other.BagSellItem))
		{
			return false;
		}
		if (!object.Equals(ShopRefreshFlagRemove, other.ShopRefreshFlagRemove))
		{
			return false;
		}
		if (!object.Equals(TaskChangeQuestStage, other.TaskChangeQuestStage))
		{
			return false;
		}
		if (!object.Equals(CollectionInteractiveUnlock, other.CollectionInteractiveUnlock))
		{
			return false;
		}
		if (!object.Equals(RedPointRemove, other.RedPointRemove))
		{
			return false;
		}
		if (!object.Equals(ActorWeaponTransformFlexType, other.ActorWeaponTransformFlexType))
		{
			return false;
		}
		if (!object.Equals(ActorKillUnit, other.ActorKillUnit))
		{
			return false;
		}
		if (!object.Equals(ActorUnitEncounter, other.ActorUnitEncounter))
		{
			return false;
		}
		if (!object.Equals(AchievementUnlock, other.AchievementUnlock))
		{
			return false;
		}
		if (!object.Equals(ChapterEnterNext, other.ChapterEnterNext))
		{
			return false;
		}
		if (!object.Equals(ChapterEnterShow, other.ChapterEnterShow))
		{
			return false;
		}
		if (!object.Equals(ChapterPreviewAward, other.ChapterPreviewAward))
		{
			return false;
		}
		if (!object.Equals(MuseumRecordMemories, other.MuseumRecordMemories))
		{
			return false;
		}
		if (!object.Equals(MuseumRemoveRedpoint, other.MuseumRemoveRedpoint))
		{
			return false;
		}
		if (!object.Equals(AttrChangeNotify, other.AttrChangeNotify))
		{
			return false;
		}
		if (!object.Equals(RoomCreatePartyCs, other.RoomCreatePartyCs))
		{
			return false;
		}
		if (!object.Equals(RoomJoinPartyCs, other.RoomJoinPartyCs))
		{
			return false;
		}
		if (!object.Equals(RoomExitPartyCs, other.RoomExitPartyCs))
		{
			return false;
		}
		if (!object.Equals(RoomPartyKickMemberCs, other.RoomPartyKickMemberCs))
		{
			return false;
		}
		if (!object.Equals(RoomSearchPartyCs, other.RoomSearchPartyCs))
		{
			return false;
		}
		if (!object.Equals(RoomSearchPartyNotify, other.RoomSearchPartyNotify))
		{
			return false;
		}
		if (!object.Equals(RoomQueryPartyInfoCs, other.RoomQueryPartyInfoCs))
		{
			return false;
		}
		if (!object.Equals(RoomPartyHeartBeatCs, other.RoomPartyHeartBeatCs))
		{
			return false;
		}
		if (!object.Equals(RoomPartyEventNotify, other.RoomPartyEventNotify))
		{
			return false;
		}
		if (!object.Equals(RoomSendPartyBattleMessageCs, other.RoomSendPartyBattleMessageCs))
		{
			return false;
		}
		if (!object.Equals(RoomPartyBattleMessageNotify, other.RoomPartyBattleMessageNotify))
		{
			return false;
		}
		if (!object.Equals(RoomPartyMemberUpdateCs, other.RoomPartyMemberUpdateCs))
		{
			return false;
		}
		if (!object.Equals(RoomCreatePartyTaskCs, other.RoomCreatePartyTaskCs))
		{
			return false;
		}
		if (!object.Equals(RoomUpdatePartyTaskCs, other.RoomUpdatePartyTaskCs))
		{
			return false;
		}
		if (!object.Equals(RoomPartyTaskFinishCs, other.RoomPartyTaskFinishCs))
		{
			return false;
		}
		if (!object.Equals(BagMultiplayerDrop, other.BagMultiplayerDrop))
		{
			return false;
		}
		if (!object.Equals(ChapterGameComplete, other.ChapterGameComplete))
		{
			return false;
		}
		if (!object.Equals(CollectionReadCardStory, other.CollectionReadCardStory))
		{
			return false;
		}
		if (!object.Equals(BagArmorUpgrade, other.BagArmorUpgrade))
		{
			return false;
		}
		if (!object.Equals(BagDropCollectionAward, other.BagDropCollectionAward))
		{
			return false;
		}
		if (!object.Equals(PartyApiCreateOnlineParty, other.PartyApiCreateOnlineParty))
		{
			return false;
		}
		if (!object.Equals(PartyApiSearchParty, other.PartyApiSearchParty))
		{
			return false;
		}
		if (!object.Equals(PartyApiJoinParty, other.PartyApiJoinParty))
		{
			return false;
		}
		if (!object.Equals(PartyApiLeaderCreateTask, other.PartyApiLeaderCreateTask))
		{
			return false;
		}
		if (!object.Equals(PartyApiMemberTaskReady, other.PartyApiMemberTaskReady))
		{
			return false;
		}
		if (!object.Equals(PartyApiLeaderFinishTask, other.PartyApiLeaderFinishTask))
		{
			return false;
		}
		if (!object.Equals(PartyApiLeaderCreateBattle, other.PartyApiLeaderCreateBattle))
		{
			return false;
		}
		if (!object.Equals(PartyApiLeaderBattleReady, other.PartyApiLeaderBattleReady))
		{
			return false;
		}
		if (!object.Equals(PartyApiMemberEnterBattle, other.PartyApiMemberEnterBattle))
		{
			return false;
		}
		if (!object.Equals(PartyApiLeaderRequestHelp, other.PartyApiLeaderRequestHelp))
		{
			return false;
		}
		if (!object.Equals(PartyApiLeaderCancelHelp, other.PartyApiLeaderCancelHelp))
		{
			return false;
		}
		if (!object.Equals(ChapterConfirmAward, other.ChapterConfirmAward))
		{
			return false;
		}
		if (!object.Equals(CollectionViewCardPortrait, other.CollectionViewCardPortrait))
		{
			return false;
		}
		if (!object.Equals(ActorSetSoulSkill, other.ActorSetSoulSkill))
		{
			return false;
		}
		if (!object.Equals(GardenUpdateCropOutput, other.GardenUpdateCropOutput))
		{
			return false;
		}
		if (!object.Equals(GardenCollectCropOutput, other.GardenCollectCropOutput))
		{
			return false;
		}
		if (!object.Equals(GardenPlantAllSeeds, other.GardenPlantAllSeeds))
		{
			return false;
		}
		if (!object.Equals(BagActivateWeapon, other.BagActivateWeapon))
		{
			return false;
		}
		if (!object.Equals(BagGetAlchemyNpcCommunicationAward, other.BagGetAlchemyNpcCommunicationAward))
		{
			return false;
		}
		if (!object.Equals(BagUpdateAlchemyNpcCommunicationStatus, other.BagUpdateAlchemyNpcCommunicationStatus))
		{
			return false;
		}
		if (!object.Equals(BagHuluUpgrade, other.BagHuluUpgrade))
		{
			return false;
		}
		if (!object.Equals(BagCollectDropSoulSkill, other.BagCollectDropSoulSkill))
		{
			return false;
		}
		if (!object.Equals(ActorWearAccessory, other.ActorWearAccessory))
		{
			return false;
		}
		if (!object.Equals(ActorUnWearAccessory, other.ActorUnWearAccessory))
		{
			return false;
		}
		if (!object.Equals(AchievementEnterLevel, other.AchievementEnterLevel))
		{
			return false;
		}
		if (!object.Equals(BagSoulSkillUpgrade, other.BagSoulSkillUpgrade))
		{
			return false;
		}
		if (!object.Equals(ActorActivateLegacyTalent, other.ActorActivateLegacyTalent))
		{
			return false;
		}
		if (!object.Equals(ActorRebuildLegacyTalent, other.ActorRebuildLegacyTalent))
		{
			return false;
		}
		if (!object.Equals(BagRebuildAttrItem, other.BagRebuildAttrItem))
		{
			return false;
		}
		if (!object.Equals(ActivitiesResume, other.ActivitiesResume))
		{
			return false;
		}
		if (!object.Equals(CollectionCollectItem, other.CollectionCollectItem))
		{
			return false;
		}
		if (!object.Equals(ChapterPrologueCompleted, other.ChapterPrologueCompleted))
		{
			return false;
		}
		if (!object.Equals(AttrRefresh, other.AttrRefresh))
		{
			return false;
		}
		if (!object.Equals(MiscTestLargePackage, other.MiscTestLargePackage))
		{
			return false;
		}
		if (!object.Equals(InteractSoulBottleGainItem, other.InteractSoulBottleGainItem))
		{
			return false;
		}
		if (!object.Equals(BossRushBattleStart, other.BossRushBattleStart))
		{
			return false;
		}
		if (!object.Equals(BossRushBattleComplete, other.BossRushBattleComplete))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (head_ != null)
		{
			num ^= Head.GetHashCode();
		}
		if (roleLogin_ != null)
		{
			num ^= RoleLogin.GetHashCode();
		}
		if (roleLogout_ != null)
		{
			num ^= RoleLogout.GetHashCode();
		}
		if (roleKick_ != null)
		{
			num ^= RoleKick.GetHashCode();
		}
		if (roleDataNotify_ != null)
		{
			num ^= RoleDataNotify.GetHashCode();
		}
		if (roleRandomName_ != null)
		{
			num ^= RoleRandomName.GetHashCode();
		}
		if (roleChangeName_ != null)
		{
			num ^= RoleChangeName.GetHashCode();
		}
		if (miscCreateRole_ != null)
		{
			num ^= MiscCreateRole.GetHashCode();
		}
		if (miscExecGm_ != null)
		{
			num ^= MiscExecGm.GetHashCode();
		}
		if (miscHeartBeat_ != null)
		{
			num ^= MiscHeartBeat.GetHashCode();
		}
		if (miscCheckRes_ != null)
		{
			num ^= MiscCheckRes.GetHashCode();
		}
		if (awolMsgGetList_ != null)
		{
			num ^= AwolMsgGetList.GetHashCode();
		}
		if (awolMsgRemove_ != null)
		{
			num ^= AwolMsgRemove.GetHashCode();
		}
		if (awolMsgUpdate_ != null)
		{
			num ^= AwolMsgUpdate.GetHashCode();
		}
		if (awolMsgSend_ != null)
		{
			num ^= AwolMsgSend.GetHashCode();
		}
		if (awolMsgNotifyUpdate_ != null)
		{
			num ^= AwolMsgNotifyUpdate.GetHashCode();
		}
		if (awolMsgNotifyRemove_ != null)
		{
			num ^= AwolMsgNotifyRemove.GetHashCode();
		}
		if (awolMsgNotifyAdd_ != null)
		{
			num ^= AwolMsgNotifyAdd.GetHashCode();
		}
		if (briefMsgGet_ != null)
		{
			num ^= BriefMsgGet.GetHashCode();
		}
		if (rankListGet_ != null)
		{
			num ^= RankListGet.GetHashCode();
		}
		if (bagGainItemList_ != null)
		{
			num ^= BagGainItemList.GetHashCode();
		}
		if (bagCostItemList_ != null)
		{
			num ^= BagCostItemList.GetHashCode();
		}
		if (bagHuluSetting_ != null)
		{
			num ^= BagHuluSetting.GetHashCode();
		}
		if (bagAlchemy_ != null)
		{
			num ^= BagAlchemy.GetHashCode();
		}
		if (bagWeaponBuild_ != null)
		{
			num ^= BagWeaponBuild.GetHashCode();
		}
		if (bagWeaponReBuild_ != null)
		{
			num ^= BagWeaponReBuild.GetHashCode();
		}
		if (bagDropUnitAward_ != null)
		{
			num ^= BagDropUnitAward.GetHashCode();
		}
		if (bagCommDrop_ != null)
		{
			num ^= BagCommDrop.GetHashCode();
		}
		if (bagWineUpgrade_ != null)
		{
			num ^= BagWineUpgrade.GetHashCode();
		}
		if (bagWinePartnerSetting_ != null)
		{
			num ^= BagWinePartnerSetting.GetHashCode();
		}
		if (bagGainEditionAward_ != null)
		{
			num ^= BagGainEditionAward.GetHashCode();
		}
		if (actorWearEquip_ != null)
		{
			num ^= ActorWearEquip.GetHashCode();
		}
		if (actorUnWearEquip_ != null)
		{
			num ^= ActorUnWearEquip.GetHashCode();
		}
		if (actorSetShortCut_ != null)
		{
			num ^= ActorSetShortCut.GetHashCode();
		}
		if (actorUnSetShortCut_ != null)
		{
			num ^= ActorUnSetShortCut.GetHashCode();
		}
		if (actorSetSpell_ != null)
		{
			num ^= ActorSetSpell.GetHashCode();
		}
		if (actorUnSetSpell_ != null)
		{
			num ^= ActorUnSetSpell.GetHashCode();
		}
		if (actorSetDefaultSpell_ != null)
		{
			num ^= ActorSetDefaultSpell.GetHashCode();
		}
		if (actorOnPlayerDeath_ != null)
		{
			num ^= ActorOnPlayerDeath.GetHashCode();
		}
		if (actorOnPlayerRest_ != null)
		{
			num ^= ActorOnPlayerRest.GetHashCode();
		}
		if (actorOnNewGamePlus_ != null)
		{
			num ^= ActorOnNewGamePlus.GetHashCode();
		}
		if (actorUnLockTalent_ != null)
		{
			num ^= ActorUnLockTalent.GetHashCode();
		}
		if (actorTalentLevelUp_ != null)
		{
			num ^= ActorTalentLevelUp.GetHashCode();
		}
		if (actorRebuildTalent_ != null)
		{
			num ^= ActorRebuildTalent.GetHashCode();
		}
		if (actorMeditationUnlock_ != null)
		{
			num ^= ActorMeditationUnlock.GetHashCode();
		}
		if (actorOnPlayerExit_ != null)
		{
			num ^= ActorOnPlayerExit.GetHashCode();
		}
		if (actorWineSetting_ != null)
		{
			num ^= ActorWineSetting.GetHashCode();
		}
		if (shopPayBuyItem_ != null)
		{
			num ^= ShopPayBuyItem.GetHashCode();
		}
		if (shopRefresh_ != null)
		{
			num ^= ShopRefresh.GetHashCode();
		}
		if (bagSellItem_ != null)
		{
			num ^= BagSellItem.GetHashCode();
		}
		if (shopRefreshFlagRemove_ != null)
		{
			num ^= ShopRefreshFlagRemove.GetHashCode();
		}
		if (taskChangeQuestStage_ != null)
		{
			num ^= TaskChangeQuestStage.GetHashCode();
		}
		if (collectionInteractiveUnlock_ != null)
		{
			num ^= CollectionInteractiveUnlock.GetHashCode();
		}
		if (redPointRemove_ != null)
		{
			num ^= RedPointRemove.GetHashCode();
		}
		if (actorWeaponTransformFlexType_ != null)
		{
			num ^= ActorWeaponTransformFlexType.GetHashCode();
		}
		if (actorKillUnit_ != null)
		{
			num ^= ActorKillUnit.GetHashCode();
		}
		if (actorUnitEncounter_ != null)
		{
			num ^= ActorUnitEncounter.GetHashCode();
		}
		if (achievementUnlock_ != null)
		{
			num ^= AchievementUnlock.GetHashCode();
		}
		if (chapterEnterNext_ != null)
		{
			num ^= ChapterEnterNext.GetHashCode();
		}
		if (chapterEnterShow_ != null)
		{
			num ^= ChapterEnterShow.GetHashCode();
		}
		if (chapterPreviewAward_ != null)
		{
			num ^= ChapterPreviewAward.GetHashCode();
		}
		if (museumRecordMemories_ != null)
		{
			num ^= MuseumRecordMemories.GetHashCode();
		}
		if (museumRemoveRedpoint_ != null)
		{
			num ^= MuseumRemoveRedpoint.GetHashCode();
		}
		if (attrChangeNotify_ != null)
		{
			num ^= AttrChangeNotify.GetHashCode();
		}
		if (roomCreatePartyCs_ != null)
		{
			num ^= RoomCreatePartyCs.GetHashCode();
		}
		if (roomJoinPartyCs_ != null)
		{
			num ^= RoomJoinPartyCs.GetHashCode();
		}
		if (roomExitPartyCs_ != null)
		{
			num ^= RoomExitPartyCs.GetHashCode();
		}
		if (roomPartyKickMemberCs_ != null)
		{
			num ^= RoomPartyKickMemberCs.GetHashCode();
		}
		if (roomSearchPartyCs_ != null)
		{
			num ^= RoomSearchPartyCs.GetHashCode();
		}
		if (roomSearchPartyNotify_ != null)
		{
			num ^= RoomSearchPartyNotify.GetHashCode();
		}
		if (roomQueryPartyInfoCs_ != null)
		{
			num ^= RoomQueryPartyInfoCs.GetHashCode();
		}
		if (roomPartyHeartBeatCs_ != null)
		{
			num ^= RoomPartyHeartBeatCs.GetHashCode();
		}
		if (roomPartyEventNotify_ != null)
		{
			num ^= RoomPartyEventNotify.GetHashCode();
		}
		if (roomSendPartyBattleMessageCs_ != null)
		{
			num ^= RoomSendPartyBattleMessageCs.GetHashCode();
		}
		if (roomPartyBattleMessageNotify_ != null)
		{
			num ^= RoomPartyBattleMessageNotify.GetHashCode();
		}
		if (roomPartyMemberUpdateCs_ != null)
		{
			num ^= RoomPartyMemberUpdateCs.GetHashCode();
		}
		if (roomCreatePartyTaskCs_ != null)
		{
			num ^= RoomCreatePartyTaskCs.GetHashCode();
		}
		if (roomUpdatePartyTaskCs_ != null)
		{
			num ^= RoomUpdatePartyTaskCs.GetHashCode();
		}
		if (roomPartyTaskFinishCs_ != null)
		{
			num ^= RoomPartyTaskFinishCs.GetHashCode();
		}
		if (bagMultiplayerDrop_ != null)
		{
			num ^= BagMultiplayerDrop.GetHashCode();
		}
		if (chapterGameComplete_ != null)
		{
			num ^= ChapterGameComplete.GetHashCode();
		}
		if (collectionReadCardStory_ != null)
		{
			num ^= CollectionReadCardStory.GetHashCode();
		}
		if (bagArmorUpgrade_ != null)
		{
			num ^= BagArmorUpgrade.GetHashCode();
		}
		if (bagDropCollectionAward_ != null)
		{
			num ^= BagDropCollectionAward.GetHashCode();
		}
		if (partyApiCreateOnlineParty_ != null)
		{
			num ^= PartyApiCreateOnlineParty.GetHashCode();
		}
		if (partyApiSearchParty_ != null)
		{
			num ^= PartyApiSearchParty.GetHashCode();
		}
		if (partyApiJoinParty_ != null)
		{
			num ^= PartyApiJoinParty.GetHashCode();
		}
		if (partyApiLeaderCreateTask_ != null)
		{
			num ^= PartyApiLeaderCreateTask.GetHashCode();
		}
		if (partyApiMemberTaskReady_ != null)
		{
			num ^= PartyApiMemberTaskReady.GetHashCode();
		}
		if (partyApiLeaderFinishTask_ != null)
		{
			num ^= PartyApiLeaderFinishTask.GetHashCode();
		}
		if (partyApiLeaderCreateBattle_ != null)
		{
			num ^= PartyApiLeaderCreateBattle.GetHashCode();
		}
		if (partyApiLeaderBattleReady_ != null)
		{
			num ^= PartyApiLeaderBattleReady.GetHashCode();
		}
		if (partyApiMemberEnterBattle_ != null)
		{
			num ^= PartyApiMemberEnterBattle.GetHashCode();
		}
		if (partyApiLeaderRequestHelp_ != null)
		{
			num ^= PartyApiLeaderRequestHelp.GetHashCode();
		}
		if (partyApiLeaderCancelHelp_ != null)
		{
			num ^= PartyApiLeaderCancelHelp.GetHashCode();
		}
		if (chapterConfirmAward_ != null)
		{
			num ^= ChapterConfirmAward.GetHashCode();
		}
		if (collectionViewCardPortrait_ != null)
		{
			num ^= CollectionViewCardPortrait.GetHashCode();
		}
		if (actorSetSoulSkill_ != null)
		{
			num ^= ActorSetSoulSkill.GetHashCode();
		}
		if (gardenUpdateCropOutput_ != null)
		{
			num ^= GardenUpdateCropOutput.GetHashCode();
		}
		if (gardenCollectCropOutput_ != null)
		{
			num ^= GardenCollectCropOutput.GetHashCode();
		}
		if (gardenPlantAllSeeds_ != null)
		{
			num ^= GardenPlantAllSeeds.GetHashCode();
		}
		if (bagActivateWeapon_ != null)
		{
			num ^= BagActivateWeapon.GetHashCode();
		}
		if (bagGetAlchemyNpcCommunicationAward_ != null)
		{
			num ^= BagGetAlchemyNpcCommunicationAward.GetHashCode();
		}
		if (bagUpdateAlchemyNpcCommunicationStatus_ != null)
		{
			num ^= BagUpdateAlchemyNpcCommunicationStatus.GetHashCode();
		}
		if (bagHuluUpgrade_ != null)
		{
			num ^= BagHuluUpgrade.GetHashCode();
		}
		if (bagCollectDropSoulSkill_ != null)
		{
			num ^= BagCollectDropSoulSkill.GetHashCode();
		}
		if (actorWearAccessory_ != null)
		{
			num ^= ActorWearAccessory.GetHashCode();
		}
		if (actorUnWearAccessory_ != null)
		{
			num ^= ActorUnWearAccessory.GetHashCode();
		}
		if (achievementEnterLevel_ != null)
		{
			num ^= AchievementEnterLevel.GetHashCode();
		}
		if (bagSoulSkillUpgrade_ != null)
		{
			num ^= BagSoulSkillUpgrade.GetHashCode();
		}
		if (actorActivateLegacyTalent_ != null)
		{
			num ^= ActorActivateLegacyTalent.GetHashCode();
		}
		if (actorRebuildLegacyTalent_ != null)
		{
			num ^= ActorRebuildLegacyTalent.GetHashCode();
		}
		if (bagRebuildAttrItem_ != null)
		{
			num ^= BagRebuildAttrItem.GetHashCode();
		}
		if (activitiesResume_ != null)
		{
			num ^= ActivitiesResume.GetHashCode();
		}
		if (collectionCollectItem_ != null)
		{
			num ^= CollectionCollectItem.GetHashCode();
		}
		if (chapterPrologueCompleted_ != null)
		{
			num ^= ChapterPrologueCompleted.GetHashCode();
		}
		if (attrRefresh_ != null)
		{
			num ^= AttrRefresh.GetHashCode();
		}
		if (miscTestLargePackage_ != null)
		{
			num ^= MiscTestLargePackage.GetHashCode();
		}
		if (interactSoulBottleGainItem_ != null)
		{
			num ^= InteractSoulBottleGainItem.GetHashCode();
		}
		if (bossRushBattleStart_ != null)
		{
			num ^= BossRushBattleStart.GetHashCode();
		}
		if (bossRushBattleComplete_ != null)
		{
			num ^= BossRushBattleComplete.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (head_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(Head);
		}
		if (roleLogin_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(RoleLogin);
		}
		if (roleLogout_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(RoleLogout);
		}
		if (roleKick_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(RoleKick);
		}
		if (roleDataNotify_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(RoleDataNotify);
		}
		if (roleRandomName_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(RoleRandomName);
		}
		if (roleChangeName_ != null)
		{
			output.WriteRawTag(58);
			output.WriteMessage(RoleChangeName);
		}
		if (miscCreateRole_ != null)
		{
			output.WriteRawTag(66);
			output.WriteMessage(MiscCreateRole);
		}
		if (miscExecGm_ != null)
		{
			output.WriteRawTag(74);
			output.WriteMessage(MiscExecGm);
		}
		if (miscHeartBeat_ != null)
		{
			output.WriteRawTag(82);
			output.WriteMessage(MiscHeartBeat);
		}
		if (miscCheckRes_ != null)
		{
			output.WriteRawTag(90);
			output.WriteMessage(MiscCheckRes);
		}
		if (awolMsgGetList_ != null)
		{
			output.WriteRawTag(98);
			output.WriteMessage(AwolMsgGetList);
		}
		if (awolMsgRemove_ != null)
		{
			output.WriteRawTag(106);
			output.WriteMessage(AwolMsgRemove);
		}
		if (awolMsgUpdate_ != null)
		{
			output.WriteRawTag(114);
			output.WriteMessage(AwolMsgUpdate);
		}
		if (awolMsgSend_ != null)
		{
			output.WriteRawTag(122);
			output.WriteMessage(AwolMsgSend);
		}
		if (awolMsgNotifyUpdate_ != null)
		{
			output.WriteRawTag(130, 1);
			output.WriteMessage(AwolMsgNotifyUpdate);
		}
		if (awolMsgNotifyRemove_ != null)
		{
			output.WriteRawTag(138, 1);
			output.WriteMessage(AwolMsgNotifyRemove);
		}
		if (awolMsgNotifyAdd_ != null)
		{
			output.WriteRawTag(146, 1);
			output.WriteMessage(AwolMsgNotifyAdd);
		}
		if (briefMsgGet_ != null)
		{
			output.WriteRawTag(154, 1);
			output.WriteMessage(BriefMsgGet);
		}
		if (rankListGet_ != null)
		{
			output.WriteRawTag(162, 1);
			output.WriteMessage(RankListGet);
		}
		if (bagGainItemList_ != null)
		{
			output.WriteRawTag(170, 1);
			output.WriteMessage(BagGainItemList);
		}
		if (bagCostItemList_ != null)
		{
			output.WriteRawTag(178, 1);
			output.WriteMessage(BagCostItemList);
		}
		if (bagHuluSetting_ != null)
		{
			output.WriteRawTag(186, 1);
			output.WriteMessage(BagHuluSetting);
		}
		if (bagAlchemy_ != null)
		{
			output.WriteRawTag(194, 1);
			output.WriteMessage(BagAlchemy);
		}
		if (bagWeaponBuild_ != null)
		{
			output.WriteRawTag(202, 1);
			output.WriteMessage(BagWeaponBuild);
		}
		if (bagWeaponReBuild_ != null)
		{
			output.WriteRawTag(210, 1);
			output.WriteMessage(BagWeaponReBuild);
		}
		if (bagDropUnitAward_ != null)
		{
			output.WriteRawTag(218, 1);
			output.WriteMessage(BagDropUnitAward);
		}
		if (bagCommDrop_ != null)
		{
			output.WriteRawTag(226, 1);
			output.WriteMessage(BagCommDrop);
		}
		if (bagWineUpgrade_ != null)
		{
			output.WriteRawTag(234, 1);
			output.WriteMessage(BagWineUpgrade);
		}
		if (bagWinePartnerSetting_ != null)
		{
			output.WriteRawTag(242, 1);
			output.WriteMessage(BagWinePartnerSetting);
		}
		if (bagGainEditionAward_ != null)
		{
			output.WriteRawTag(250, 1);
			output.WriteMessage(BagGainEditionAward);
		}
		if (actorWearEquip_ != null)
		{
			output.WriteRawTag(130, 2);
			output.WriteMessage(ActorWearEquip);
		}
		if (actorUnWearEquip_ != null)
		{
			output.WriteRawTag(138, 2);
			output.WriteMessage(ActorUnWearEquip);
		}
		if (actorSetShortCut_ != null)
		{
			output.WriteRawTag(146, 2);
			output.WriteMessage(ActorSetShortCut);
		}
		if (actorUnSetShortCut_ != null)
		{
			output.WriteRawTag(154, 2);
			output.WriteMessage(ActorUnSetShortCut);
		}
		if (actorSetSpell_ != null)
		{
			output.WriteRawTag(162, 2);
			output.WriteMessage(ActorSetSpell);
		}
		if (actorUnSetSpell_ != null)
		{
			output.WriteRawTag(170, 2);
			output.WriteMessage(ActorUnSetSpell);
		}
		if (actorSetDefaultSpell_ != null)
		{
			output.WriteRawTag(178, 2);
			output.WriteMessage(ActorSetDefaultSpell);
		}
		if (actorOnPlayerDeath_ != null)
		{
			output.WriteRawTag(186, 2);
			output.WriteMessage(ActorOnPlayerDeath);
		}
		if (actorOnPlayerRest_ != null)
		{
			output.WriteRawTag(194, 2);
			output.WriteMessage(ActorOnPlayerRest);
		}
		if (actorOnNewGamePlus_ != null)
		{
			output.WriteRawTag(202, 2);
			output.WriteMessage(ActorOnNewGamePlus);
		}
		if (actorUnLockTalent_ != null)
		{
			output.WriteRawTag(210, 2);
			output.WriteMessage(ActorUnLockTalent);
		}
		if (actorTalentLevelUp_ != null)
		{
			output.WriteRawTag(218, 2);
			output.WriteMessage(ActorTalentLevelUp);
		}
		if (actorRebuildTalent_ != null)
		{
			output.WriteRawTag(226, 2);
			output.WriteMessage(ActorRebuildTalent);
		}
		if (actorMeditationUnlock_ != null)
		{
			output.WriteRawTag(234, 2);
			output.WriteMessage(ActorMeditationUnlock);
		}
		if (actorOnPlayerExit_ != null)
		{
			output.WriteRawTag(242, 2);
			output.WriteMessage(ActorOnPlayerExit);
		}
		if (actorWineSetting_ != null)
		{
			output.WriteRawTag(250, 2);
			output.WriteMessage(ActorWineSetting);
		}
		if (shopPayBuyItem_ != null)
		{
			output.WriteRawTag(130, 3);
			output.WriteMessage(ShopPayBuyItem);
		}
		if (shopRefresh_ != null)
		{
			output.WriteRawTag(138, 3);
			output.WriteMessage(ShopRefresh);
		}
		if (bagSellItem_ != null)
		{
			output.WriteRawTag(146, 3);
			output.WriteMessage(BagSellItem);
		}
		if (shopRefreshFlagRemove_ != null)
		{
			output.WriteRawTag(154, 3);
			output.WriteMessage(ShopRefreshFlagRemove);
		}
		if (taskChangeQuestStage_ != null)
		{
			output.WriteRawTag(162, 3);
			output.WriteMessage(TaskChangeQuestStage);
		}
		if (collectionInteractiveUnlock_ != null)
		{
			output.WriteRawTag(170, 3);
			output.WriteMessage(CollectionInteractiveUnlock);
		}
		if (redPointRemove_ != null)
		{
			output.WriteRawTag(178, 3);
			output.WriteMessage(RedPointRemove);
		}
		if (actorWeaponTransformFlexType_ != null)
		{
			output.WriteRawTag(186, 3);
			output.WriteMessage(ActorWeaponTransformFlexType);
		}
		if (actorKillUnit_ != null)
		{
			output.WriteRawTag(194, 3);
			output.WriteMessage(ActorKillUnit);
		}
		if (actorUnitEncounter_ != null)
		{
			output.WriteRawTag(202, 3);
			output.WriteMessage(ActorUnitEncounter);
		}
		if (achievementUnlock_ != null)
		{
			output.WriteRawTag(210, 3);
			output.WriteMessage(AchievementUnlock);
		}
		if (chapterEnterNext_ != null)
		{
			output.WriteRawTag(218, 3);
			output.WriteMessage(ChapterEnterNext);
		}
		if (chapterEnterShow_ != null)
		{
			output.WriteRawTag(226, 3);
			output.WriteMessage(ChapterEnterShow);
		}
		if (chapterPreviewAward_ != null)
		{
			output.WriteRawTag(234, 3);
			output.WriteMessage(ChapterPreviewAward);
		}
		if (museumRecordMemories_ != null)
		{
			output.WriteRawTag(242, 3);
			output.WriteMessage(MuseumRecordMemories);
		}
		if (museumRemoveRedpoint_ != null)
		{
			output.WriteRawTag(250, 3);
			output.WriteMessage(MuseumRemoveRedpoint);
		}
		if (attrChangeNotify_ != null)
		{
			output.WriteRawTag(130, 4);
			output.WriteMessage(AttrChangeNotify);
		}
		if (roomCreatePartyCs_ != null)
		{
			output.WriteRawTag(138, 4);
			output.WriteMessage(RoomCreatePartyCs);
		}
		if (roomJoinPartyCs_ != null)
		{
			output.WriteRawTag(146, 4);
			output.WriteMessage(RoomJoinPartyCs);
		}
		if (roomExitPartyCs_ != null)
		{
			output.WriteRawTag(154, 4);
			output.WriteMessage(RoomExitPartyCs);
		}
		if (roomPartyKickMemberCs_ != null)
		{
			output.WriteRawTag(162, 4);
			output.WriteMessage(RoomPartyKickMemberCs);
		}
		if (roomSearchPartyCs_ != null)
		{
			output.WriteRawTag(170, 4);
			output.WriteMessage(RoomSearchPartyCs);
		}
		if (roomSearchPartyNotify_ != null)
		{
			output.WriteRawTag(178, 4);
			output.WriteMessage(RoomSearchPartyNotify);
		}
		if (roomQueryPartyInfoCs_ != null)
		{
			output.WriteRawTag(186, 4);
			output.WriteMessage(RoomQueryPartyInfoCs);
		}
		if (roomPartyHeartBeatCs_ != null)
		{
			output.WriteRawTag(194, 4);
			output.WriteMessage(RoomPartyHeartBeatCs);
		}
		if (roomPartyEventNotify_ != null)
		{
			output.WriteRawTag(202, 4);
			output.WriteMessage(RoomPartyEventNotify);
		}
		if (roomSendPartyBattleMessageCs_ != null)
		{
			output.WriteRawTag(210, 4);
			output.WriteMessage(RoomSendPartyBattleMessageCs);
		}
		if (roomPartyBattleMessageNotify_ != null)
		{
			output.WriteRawTag(218, 4);
			output.WriteMessage(RoomPartyBattleMessageNotify);
		}
		if (roomPartyMemberUpdateCs_ != null)
		{
			output.WriteRawTag(226, 4);
			output.WriteMessage(RoomPartyMemberUpdateCs);
		}
		if (roomCreatePartyTaskCs_ != null)
		{
			output.WriteRawTag(234, 4);
			output.WriteMessage(RoomCreatePartyTaskCs);
		}
		if (roomUpdatePartyTaskCs_ != null)
		{
			output.WriteRawTag(242, 4);
			output.WriteMessage(RoomUpdatePartyTaskCs);
		}
		if (roomPartyTaskFinishCs_ != null)
		{
			output.WriteRawTag(250, 4);
			output.WriteMessage(RoomPartyTaskFinishCs);
		}
		if (bagMultiplayerDrop_ != null)
		{
			output.WriteRawTag(130, 5);
			output.WriteMessage(BagMultiplayerDrop);
		}
		if (chapterGameComplete_ != null)
		{
			output.WriteRawTag(138, 5);
			output.WriteMessage(ChapterGameComplete);
		}
		if (collectionReadCardStory_ != null)
		{
			output.WriteRawTag(146, 5);
			output.WriteMessage(CollectionReadCardStory);
		}
		if (bagArmorUpgrade_ != null)
		{
			output.WriteRawTag(154, 5);
			output.WriteMessage(BagArmorUpgrade);
		}
		if (bagDropCollectionAward_ != null)
		{
			output.WriteRawTag(162, 5);
			output.WriteMessage(BagDropCollectionAward);
		}
		if (partyApiCreateOnlineParty_ != null)
		{
			output.WriteRawTag(170, 5);
			output.WriteMessage(PartyApiCreateOnlineParty);
		}
		if (partyApiSearchParty_ != null)
		{
			output.WriteRawTag(178, 5);
			output.WriteMessage(PartyApiSearchParty);
		}
		if (partyApiJoinParty_ != null)
		{
			output.WriteRawTag(186, 5);
			output.WriteMessage(PartyApiJoinParty);
		}
		if (partyApiLeaderCreateTask_ != null)
		{
			output.WriteRawTag(194, 5);
			output.WriteMessage(PartyApiLeaderCreateTask);
		}
		if (partyApiMemberTaskReady_ != null)
		{
			output.WriteRawTag(202, 5);
			output.WriteMessage(PartyApiMemberTaskReady);
		}
		if (partyApiLeaderFinishTask_ != null)
		{
			output.WriteRawTag(210, 5);
			output.WriteMessage(PartyApiLeaderFinishTask);
		}
		if (partyApiLeaderCreateBattle_ != null)
		{
			output.WriteRawTag(218, 5);
			output.WriteMessage(PartyApiLeaderCreateBattle);
		}
		if (partyApiLeaderBattleReady_ != null)
		{
			output.WriteRawTag(226, 5);
			output.WriteMessage(PartyApiLeaderBattleReady);
		}
		if (partyApiMemberEnterBattle_ != null)
		{
			output.WriteRawTag(234, 5);
			output.WriteMessage(PartyApiMemberEnterBattle);
		}
		if (partyApiLeaderRequestHelp_ != null)
		{
			output.WriteRawTag(242, 5);
			output.WriteMessage(PartyApiLeaderRequestHelp);
		}
		if (partyApiLeaderCancelHelp_ != null)
		{
			output.WriteRawTag(250, 5);
			output.WriteMessage(PartyApiLeaderCancelHelp);
		}
		if (chapterConfirmAward_ != null)
		{
			output.WriteRawTag(130, 6);
			output.WriteMessage(ChapterConfirmAward);
		}
		if (collectionViewCardPortrait_ != null)
		{
			output.WriteRawTag(138, 6);
			output.WriteMessage(CollectionViewCardPortrait);
		}
		if (actorSetSoulSkill_ != null)
		{
			output.WriteRawTag(146, 6);
			output.WriteMessage(ActorSetSoulSkill);
		}
		if (gardenUpdateCropOutput_ != null)
		{
			output.WriteRawTag(154, 6);
			output.WriteMessage(GardenUpdateCropOutput);
		}
		if (gardenCollectCropOutput_ != null)
		{
			output.WriteRawTag(162, 6);
			output.WriteMessage(GardenCollectCropOutput);
		}
		if (gardenPlantAllSeeds_ != null)
		{
			output.WriteRawTag(170, 6);
			output.WriteMessage(GardenPlantAllSeeds);
		}
		if (bagActivateWeapon_ != null)
		{
			output.WriteRawTag(178, 6);
			output.WriteMessage(BagActivateWeapon);
		}
		if (bagGetAlchemyNpcCommunicationAward_ != null)
		{
			output.WriteRawTag(186, 6);
			output.WriteMessage(BagGetAlchemyNpcCommunicationAward);
		}
		if (bagUpdateAlchemyNpcCommunicationStatus_ != null)
		{
			output.WriteRawTag(194, 6);
			output.WriteMessage(BagUpdateAlchemyNpcCommunicationStatus);
		}
		if (bagHuluUpgrade_ != null)
		{
			output.WriteRawTag(202, 6);
			output.WriteMessage(BagHuluUpgrade);
		}
		if (bagCollectDropSoulSkill_ != null)
		{
			output.WriteRawTag(210, 6);
			output.WriteMessage(BagCollectDropSoulSkill);
		}
		if (actorWearAccessory_ != null)
		{
			output.WriteRawTag(218, 6);
			output.WriteMessage(ActorWearAccessory);
		}
		if (actorUnWearAccessory_ != null)
		{
			output.WriteRawTag(226, 6);
			output.WriteMessage(ActorUnWearAccessory);
		}
		if (achievementEnterLevel_ != null)
		{
			output.WriteRawTag(234, 6);
			output.WriteMessage(AchievementEnterLevel);
		}
		if (bagSoulSkillUpgrade_ != null)
		{
			output.WriteRawTag(242, 6);
			output.WriteMessage(BagSoulSkillUpgrade);
		}
		if (actorActivateLegacyTalent_ != null)
		{
			output.WriteRawTag(250, 6);
			output.WriteMessage(ActorActivateLegacyTalent);
		}
		if (actorRebuildLegacyTalent_ != null)
		{
			output.WriteRawTag(130, 7);
			output.WriteMessage(ActorRebuildLegacyTalent);
		}
		if (bagRebuildAttrItem_ != null)
		{
			output.WriteRawTag(138, 7);
			output.WriteMessage(BagRebuildAttrItem);
		}
		if (activitiesResume_ != null)
		{
			output.WriteRawTag(146, 7);
			output.WriteMessage(ActivitiesResume);
		}
		if (collectionCollectItem_ != null)
		{
			output.WriteRawTag(154, 7);
			output.WriteMessage(CollectionCollectItem);
		}
		if (chapterPrologueCompleted_ != null)
		{
			output.WriteRawTag(162, 7);
			output.WriteMessage(ChapterPrologueCompleted);
		}
		if (attrRefresh_ != null)
		{
			output.WriteRawTag(170, 7);
			output.WriteMessage(AttrRefresh);
		}
		if (miscTestLargePackage_ != null)
		{
			output.WriteRawTag(178, 7);
			output.WriteMessage(MiscTestLargePackage);
		}
		if (interactSoulBottleGainItem_ != null)
		{
			output.WriteRawTag(186, 7);
			output.WriteMessage(InteractSoulBottleGainItem);
		}
		if (bossRushBattleStart_ != null)
		{
			output.WriteRawTag(194, 7);
			output.WriteMessage(BossRushBattleStart);
		}
		if (bossRushBattleComplete_ != null)
		{
			output.WriteRawTag(202, 7);
			output.WriteMessage(BossRushBattleComplete);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (head_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Head);
		}
		if (roleLogin_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(RoleLogin);
		}
		if (roleLogout_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(RoleLogout);
		}
		if (roleKick_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(RoleKick);
		}
		if (roleDataNotify_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(RoleDataNotify);
		}
		if (roleRandomName_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(RoleRandomName);
		}
		if (roleChangeName_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(RoleChangeName);
		}
		if (miscCreateRole_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(MiscCreateRole);
		}
		if (miscExecGm_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(MiscExecGm);
		}
		if (miscHeartBeat_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(MiscHeartBeat);
		}
		if (miscCheckRes_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(MiscCheckRes);
		}
		if (awolMsgGetList_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(AwolMsgGetList);
		}
		if (awolMsgRemove_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(AwolMsgRemove);
		}
		if (awolMsgUpdate_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(AwolMsgUpdate);
		}
		if (awolMsgSend_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(AwolMsgSend);
		}
		if (awolMsgNotifyUpdate_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(AwolMsgNotifyUpdate);
		}
		if (awolMsgNotifyRemove_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(AwolMsgNotifyRemove);
		}
		if (awolMsgNotifyAdd_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(AwolMsgNotifyAdd);
		}
		if (briefMsgGet_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(BriefMsgGet);
		}
		if (rankListGet_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(RankListGet);
		}
		if (bagGainItemList_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(BagGainItemList);
		}
		if (bagCostItemList_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(BagCostItemList);
		}
		if (bagHuluSetting_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(BagHuluSetting);
		}
		if (bagAlchemy_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(BagAlchemy);
		}
		if (bagWeaponBuild_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(BagWeaponBuild);
		}
		if (bagWeaponReBuild_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(BagWeaponReBuild);
		}
		if (bagDropUnitAward_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(BagDropUnitAward);
		}
		if (bagCommDrop_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(BagCommDrop);
		}
		if (bagWineUpgrade_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(BagWineUpgrade);
		}
		if (bagWinePartnerSetting_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(BagWinePartnerSetting);
		}
		if (bagGainEditionAward_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(BagGainEditionAward);
		}
		if (actorWearEquip_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(ActorWearEquip);
		}
		if (actorUnWearEquip_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(ActorUnWearEquip);
		}
		if (actorSetShortCut_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(ActorSetShortCut);
		}
		if (actorUnSetShortCut_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(ActorUnSetShortCut);
		}
		if (actorSetSpell_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(ActorSetSpell);
		}
		if (actorUnSetSpell_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(ActorUnSetSpell);
		}
		if (actorSetDefaultSpell_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(ActorSetDefaultSpell);
		}
		if (actorOnPlayerDeath_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(ActorOnPlayerDeath);
		}
		if (actorOnPlayerRest_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(ActorOnPlayerRest);
		}
		if (actorOnNewGamePlus_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(ActorOnNewGamePlus);
		}
		if (actorUnLockTalent_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(ActorUnLockTalent);
		}
		if (actorTalentLevelUp_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(ActorTalentLevelUp);
		}
		if (actorRebuildTalent_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(ActorRebuildTalent);
		}
		if (actorMeditationUnlock_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(ActorMeditationUnlock);
		}
		if (actorOnPlayerExit_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(ActorOnPlayerExit);
		}
		if (actorWineSetting_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(ActorWineSetting);
		}
		if (shopPayBuyItem_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(ShopPayBuyItem);
		}
		if (shopRefresh_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(ShopRefresh);
		}
		if (bagSellItem_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(BagSellItem);
		}
		if (shopRefreshFlagRemove_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(ShopRefreshFlagRemove);
		}
		if (taskChangeQuestStage_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(TaskChangeQuestStage);
		}
		if (collectionInteractiveUnlock_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(CollectionInteractiveUnlock);
		}
		if (redPointRemove_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(RedPointRemove);
		}
		if (actorWeaponTransformFlexType_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(ActorWeaponTransformFlexType);
		}
		if (actorKillUnit_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(ActorKillUnit);
		}
		if (actorUnitEncounter_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(ActorUnitEncounter);
		}
		if (achievementUnlock_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(AchievementUnlock);
		}
		if (chapterEnterNext_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(ChapterEnterNext);
		}
		if (chapterEnterShow_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(ChapterEnterShow);
		}
		if (chapterPreviewAward_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(ChapterPreviewAward);
		}
		if (museumRecordMemories_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(MuseumRecordMemories);
		}
		if (museumRemoveRedpoint_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(MuseumRemoveRedpoint);
		}
		if (attrChangeNotify_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(AttrChangeNotify);
		}
		if (roomCreatePartyCs_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(RoomCreatePartyCs);
		}
		if (roomJoinPartyCs_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(RoomJoinPartyCs);
		}
		if (roomExitPartyCs_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(RoomExitPartyCs);
		}
		if (roomPartyKickMemberCs_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(RoomPartyKickMemberCs);
		}
		if (roomSearchPartyCs_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(RoomSearchPartyCs);
		}
		if (roomSearchPartyNotify_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(RoomSearchPartyNotify);
		}
		if (roomQueryPartyInfoCs_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(RoomQueryPartyInfoCs);
		}
		if (roomPartyHeartBeatCs_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(RoomPartyHeartBeatCs);
		}
		if (roomPartyEventNotify_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(RoomPartyEventNotify);
		}
		if (roomSendPartyBattleMessageCs_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(RoomSendPartyBattleMessageCs);
		}
		if (roomPartyBattleMessageNotify_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(RoomPartyBattleMessageNotify);
		}
		if (roomPartyMemberUpdateCs_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(RoomPartyMemberUpdateCs);
		}
		if (roomCreatePartyTaskCs_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(RoomCreatePartyTaskCs);
		}
		if (roomUpdatePartyTaskCs_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(RoomUpdatePartyTaskCs);
		}
		if (roomPartyTaskFinishCs_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(RoomPartyTaskFinishCs);
		}
		if (bagMultiplayerDrop_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(BagMultiplayerDrop);
		}
		if (chapterGameComplete_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(ChapterGameComplete);
		}
		if (collectionReadCardStory_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(CollectionReadCardStory);
		}
		if (bagArmorUpgrade_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(BagArmorUpgrade);
		}
		if (bagDropCollectionAward_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(BagDropCollectionAward);
		}
		if (partyApiCreateOnlineParty_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(PartyApiCreateOnlineParty);
		}
		if (partyApiSearchParty_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(PartyApiSearchParty);
		}
		if (partyApiJoinParty_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(PartyApiJoinParty);
		}
		if (partyApiLeaderCreateTask_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(PartyApiLeaderCreateTask);
		}
		if (partyApiMemberTaskReady_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(PartyApiMemberTaskReady);
		}
		if (partyApiLeaderFinishTask_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(PartyApiLeaderFinishTask);
		}
		if (partyApiLeaderCreateBattle_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(PartyApiLeaderCreateBattle);
		}
		if (partyApiLeaderBattleReady_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(PartyApiLeaderBattleReady);
		}
		if (partyApiMemberEnterBattle_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(PartyApiMemberEnterBattle);
		}
		if (partyApiLeaderRequestHelp_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(PartyApiLeaderRequestHelp);
		}
		if (partyApiLeaderCancelHelp_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(PartyApiLeaderCancelHelp);
		}
		if (chapterConfirmAward_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(ChapterConfirmAward);
		}
		if (collectionViewCardPortrait_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(CollectionViewCardPortrait);
		}
		if (actorSetSoulSkill_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(ActorSetSoulSkill);
		}
		if (gardenUpdateCropOutput_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(GardenUpdateCropOutput);
		}
		if (gardenCollectCropOutput_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(GardenCollectCropOutput);
		}
		if (gardenPlantAllSeeds_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(GardenPlantAllSeeds);
		}
		if (bagActivateWeapon_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(BagActivateWeapon);
		}
		if (bagGetAlchemyNpcCommunicationAward_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(BagGetAlchemyNpcCommunicationAward);
		}
		if (bagUpdateAlchemyNpcCommunicationStatus_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(BagUpdateAlchemyNpcCommunicationStatus);
		}
		if (bagHuluUpgrade_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(BagHuluUpgrade);
		}
		if (bagCollectDropSoulSkill_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(BagCollectDropSoulSkill);
		}
		if (actorWearAccessory_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(ActorWearAccessory);
		}
		if (actorUnWearAccessory_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(ActorUnWearAccessory);
		}
		if (achievementEnterLevel_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(AchievementEnterLevel);
		}
		if (bagSoulSkillUpgrade_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(BagSoulSkillUpgrade);
		}
		if (actorActivateLegacyTalent_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(ActorActivateLegacyTalent);
		}
		if (actorRebuildLegacyTalent_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(ActorRebuildLegacyTalent);
		}
		if (bagRebuildAttrItem_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(BagRebuildAttrItem);
		}
		if (activitiesResume_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(ActivitiesResume);
		}
		if (collectionCollectItem_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(CollectionCollectItem);
		}
		if (chapterPrologueCompleted_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(ChapterPrologueCompleted);
		}
		if (attrRefresh_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(AttrRefresh);
		}
		if (miscTestLargePackage_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(MiscTestLargePackage);
		}
		if (interactSoulBottleGainItem_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(InteractSoulBottleGainItem);
		}
		if (bossRushBattleStart_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(BossRushBattleStart);
		}
		if (bossRushBattleComplete_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(BossRushBattleComplete);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CSMsg other)
	{
		if (other == null)
		{
			return;
		}
		if (other.head_ != null)
		{
			if (head_ == null)
			{
				Head = new CSMsgHead();
			}
			Head.MergeFrom(other.Head);
		}
		if (other.roleLogin_ != null)
		{
			if (roleLogin_ == null)
			{
				RoleLogin = new CSMsgRoleLogin();
			}
			RoleLogin.MergeFrom(other.RoleLogin);
		}
		if (other.roleLogout_ != null)
		{
			if (roleLogout_ == null)
			{
				RoleLogout = new CSMsgRoleLogout();
			}
			RoleLogout.MergeFrom(other.RoleLogout);
		}
		if (other.roleKick_ != null)
		{
			if (roleKick_ == null)
			{
				RoleKick = new CSMsgRoleKick();
			}
			RoleKick.MergeFrom(other.RoleKick);
		}
		if (other.roleDataNotify_ != null)
		{
			if (roleDataNotify_ == null)
			{
				RoleDataNotify = new CSMsgRoleDataNotify();
			}
			RoleDataNotify.MergeFrom(other.RoleDataNotify);
		}
		if (other.roleRandomName_ != null)
		{
			if (roleRandomName_ == null)
			{
				RoleRandomName = new CSMsgRoleRandomName();
			}
			RoleRandomName.MergeFrom(other.RoleRandomName);
		}
		if (other.roleChangeName_ != null)
		{
			if (roleChangeName_ == null)
			{
				RoleChangeName = new CSMsgRoleChangeName();
			}
			RoleChangeName.MergeFrom(other.RoleChangeName);
		}
		if (other.miscCreateRole_ != null)
		{
			if (miscCreateRole_ == null)
			{
				MiscCreateRole = new CSMsgMiscCreateRole();
			}
			MiscCreateRole.MergeFrom(other.MiscCreateRole);
		}
		if (other.miscExecGm_ != null)
		{
			if (miscExecGm_ == null)
			{
				MiscExecGm = new CSMsgMiscExecGM();
			}
			MiscExecGm.MergeFrom(other.MiscExecGm);
		}
		if (other.miscHeartBeat_ != null)
		{
			if (miscHeartBeat_ == null)
			{
				MiscHeartBeat = new CSMsgMiscHeartBeat();
			}
			MiscHeartBeat.MergeFrom(other.MiscHeartBeat);
		}
		if (other.miscCheckRes_ != null)
		{
			if (miscCheckRes_ == null)
			{
				MiscCheckRes = new CSMsgMiscCheckRes();
			}
			MiscCheckRes.MergeFrom(other.MiscCheckRes);
		}
		if (other.awolMsgGetList_ != null)
		{
			if (awolMsgGetList_ == null)
			{
				AwolMsgGetList = new CSMsgAwolMsgGetList();
			}
			AwolMsgGetList.MergeFrom(other.AwolMsgGetList);
		}
		if (other.awolMsgRemove_ != null)
		{
			if (awolMsgRemove_ == null)
			{
				AwolMsgRemove = new CSMsgAwolMsgRemove();
			}
			AwolMsgRemove.MergeFrom(other.AwolMsgRemove);
		}
		if (other.awolMsgUpdate_ != null)
		{
			if (awolMsgUpdate_ == null)
			{
				AwolMsgUpdate = new CSMsgAwolMsgUpdate();
			}
			AwolMsgUpdate.MergeFrom(other.AwolMsgUpdate);
		}
		if (other.awolMsgSend_ != null)
		{
			if (awolMsgSend_ == null)
			{
				AwolMsgSend = new CSMsgAwolMsgSend();
			}
			AwolMsgSend.MergeFrom(other.AwolMsgSend);
		}
		if (other.awolMsgNotifyUpdate_ != null)
		{
			if (awolMsgNotifyUpdate_ == null)
			{
				AwolMsgNotifyUpdate = new CSMsgAwolMsgNotifyUpdate();
			}
			AwolMsgNotifyUpdate.MergeFrom(other.AwolMsgNotifyUpdate);
		}
		if (other.awolMsgNotifyRemove_ != null)
		{
			if (awolMsgNotifyRemove_ == null)
			{
				AwolMsgNotifyRemove = new CSMsgAwolMsgNotifyRemove();
			}
			AwolMsgNotifyRemove.MergeFrom(other.AwolMsgNotifyRemove);
		}
		if (other.awolMsgNotifyAdd_ != null)
		{
			if (awolMsgNotifyAdd_ == null)
			{
				AwolMsgNotifyAdd = new CSMsgAwolMsgNotifyAdd();
			}
			AwolMsgNotifyAdd.MergeFrom(other.AwolMsgNotifyAdd);
		}
		if (other.briefMsgGet_ != null)
		{
			if (briefMsgGet_ == null)
			{
				BriefMsgGet = new CSMsgBriefMsgGet();
			}
			BriefMsgGet.MergeFrom(other.BriefMsgGet);
		}
		if (other.rankListGet_ != null)
		{
			if (rankListGet_ == null)
			{
				RankListGet = new CSMsgRankListGet();
			}
			RankListGet.MergeFrom(other.RankListGet);
		}
		if (other.bagGainItemList_ != null)
		{
			if (bagGainItemList_ == null)
			{
				BagGainItemList = new CSMsgBagGainItemList();
			}
			BagGainItemList.MergeFrom(other.BagGainItemList);
		}
		if (other.bagCostItemList_ != null)
		{
			if (bagCostItemList_ == null)
			{
				BagCostItemList = new CSMsgBagCostItemList();
			}
			BagCostItemList.MergeFrom(other.BagCostItemList);
		}
		if (other.bagHuluSetting_ != null)
		{
			if (bagHuluSetting_ == null)
			{
				BagHuluSetting = new CSMsgBagHuluSetting();
			}
			BagHuluSetting.MergeFrom(other.BagHuluSetting);
		}
		if (other.bagAlchemy_ != null)
		{
			if (bagAlchemy_ == null)
			{
				BagAlchemy = new CSMsgBagAlchemy();
			}
			BagAlchemy.MergeFrom(other.BagAlchemy);
		}
		if (other.bagWeaponBuild_ != null)
		{
			if (bagWeaponBuild_ == null)
			{
				BagWeaponBuild = new CSMsgBagWeaponBuild();
			}
			BagWeaponBuild.MergeFrom(other.BagWeaponBuild);
		}
		if (other.bagWeaponReBuild_ != null)
		{
			if (bagWeaponReBuild_ == null)
			{
				BagWeaponReBuild = new CSMsgBagWeaponReBuild();
			}
			BagWeaponReBuild.MergeFrom(other.BagWeaponReBuild);
		}
		if (other.bagDropUnitAward_ != null)
		{
			if (bagDropUnitAward_ == null)
			{
				BagDropUnitAward = new CSMsgBagDropUnitAward();
			}
			BagDropUnitAward.MergeFrom(other.BagDropUnitAward);
		}
		if (other.bagCommDrop_ != null)
		{
			if (bagCommDrop_ == null)
			{
				BagCommDrop = new CSMsgBagCommDrop();
			}
			BagCommDrop.MergeFrom(other.BagCommDrop);
		}
		if (other.bagWineUpgrade_ != null)
		{
			if (bagWineUpgrade_ == null)
			{
				BagWineUpgrade = new CSMsgBagWineUpgrade();
			}
			BagWineUpgrade.MergeFrom(other.BagWineUpgrade);
		}
		if (other.bagWinePartnerSetting_ != null)
		{
			if (bagWinePartnerSetting_ == null)
			{
				BagWinePartnerSetting = new CSMsgBagWinePartnerSetting();
			}
			BagWinePartnerSetting.MergeFrom(other.BagWinePartnerSetting);
		}
		if (other.bagGainEditionAward_ != null)
		{
			if (bagGainEditionAward_ == null)
			{
				BagGainEditionAward = new CSMsgBagGainEditionAward();
			}
			BagGainEditionAward.MergeFrom(other.BagGainEditionAward);
		}
		if (other.actorWearEquip_ != null)
		{
			if (actorWearEquip_ == null)
			{
				ActorWearEquip = new CSMsgActorWearEquip();
			}
			ActorWearEquip.MergeFrom(other.ActorWearEquip);
		}
		if (other.actorUnWearEquip_ != null)
		{
			if (actorUnWearEquip_ == null)
			{
				ActorUnWearEquip = new CSMsgActorUnWearEquip();
			}
			ActorUnWearEquip.MergeFrom(other.ActorUnWearEquip);
		}
		if (other.actorSetShortCut_ != null)
		{
			if (actorSetShortCut_ == null)
			{
				ActorSetShortCut = new CSMsgActorSetShortCut();
			}
			ActorSetShortCut.MergeFrom(other.ActorSetShortCut);
		}
		if (other.actorUnSetShortCut_ != null)
		{
			if (actorUnSetShortCut_ == null)
			{
				ActorUnSetShortCut = new CSMsgActorUnSetShortCut();
			}
			ActorUnSetShortCut.MergeFrom(other.ActorUnSetShortCut);
		}
		if (other.actorSetSpell_ != null)
		{
			if (actorSetSpell_ == null)
			{
				ActorSetSpell = new CSMsgActorSetSpell();
			}
			ActorSetSpell.MergeFrom(other.ActorSetSpell);
		}
		if (other.actorUnSetSpell_ != null)
		{
			if (actorUnSetSpell_ == null)
			{
				ActorUnSetSpell = new CSMsgActorUnSetSpell();
			}
			ActorUnSetSpell.MergeFrom(other.ActorUnSetSpell);
		}
		if (other.actorSetDefaultSpell_ != null)
		{
			if (actorSetDefaultSpell_ == null)
			{
				ActorSetDefaultSpell = new CSMsgActorSetDefaultSpell();
			}
			ActorSetDefaultSpell.MergeFrom(other.ActorSetDefaultSpell);
		}
		if (other.actorOnPlayerDeath_ != null)
		{
			if (actorOnPlayerDeath_ == null)
			{
				ActorOnPlayerDeath = new CSMsgActorOnPlayerDeath();
			}
			ActorOnPlayerDeath.MergeFrom(other.ActorOnPlayerDeath);
		}
		if (other.actorOnPlayerRest_ != null)
		{
			if (actorOnPlayerRest_ == null)
			{
				ActorOnPlayerRest = new CSMsgActorOnPlayerRest();
			}
			ActorOnPlayerRest.MergeFrom(other.ActorOnPlayerRest);
		}
		if (other.actorOnNewGamePlus_ != null)
		{
			if (actorOnNewGamePlus_ == null)
			{
				ActorOnNewGamePlus = new CSMsgActorOnNewGamePlus();
			}
			ActorOnNewGamePlus.MergeFrom(other.ActorOnNewGamePlus);
		}
		if (other.actorUnLockTalent_ != null)
		{
			if (actorUnLockTalent_ == null)
			{
				ActorUnLockTalent = new CSMsgActorUnLockTalent();
			}
			ActorUnLockTalent.MergeFrom(other.ActorUnLockTalent);
		}
		if (other.actorTalentLevelUp_ != null)
		{
			if (actorTalentLevelUp_ == null)
			{
				ActorTalentLevelUp = new CSMsgActorTalentLevelUp();
			}
			ActorTalentLevelUp.MergeFrom(other.ActorTalentLevelUp);
		}
		if (other.actorRebuildTalent_ != null)
		{
			if (actorRebuildTalent_ == null)
			{
				ActorRebuildTalent = new CSMsgActorRebuildTalent();
			}
			ActorRebuildTalent.MergeFrom(other.ActorRebuildTalent);
		}
		if (other.actorMeditationUnlock_ != null)
		{
			if (actorMeditationUnlock_ == null)
			{
				ActorMeditationUnlock = new CSMsgActorMeditationUnlock();
			}
			ActorMeditationUnlock.MergeFrom(other.ActorMeditationUnlock);
		}
		if (other.actorOnPlayerExit_ != null)
		{
			if (actorOnPlayerExit_ == null)
			{
				ActorOnPlayerExit = new CSMsgActorOnPlayerExit();
			}
			ActorOnPlayerExit.MergeFrom(other.ActorOnPlayerExit);
		}
		if (other.actorWineSetting_ != null)
		{
			if (actorWineSetting_ == null)
			{
				ActorWineSetting = new CSMsgActorWineSetting();
			}
			ActorWineSetting.MergeFrom(other.ActorWineSetting);
		}
		if (other.shopPayBuyItem_ != null)
		{
			if (shopPayBuyItem_ == null)
			{
				ShopPayBuyItem = new CSMsgShopPayBuyItem();
			}
			ShopPayBuyItem.MergeFrom(other.ShopPayBuyItem);
		}
		if (other.shopRefresh_ != null)
		{
			if (shopRefresh_ == null)
			{
				ShopRefresh = new CSMsgShopRefresh();
			}
			ShopRefresh.MergeFrom(other.ShopRefresh);
		}
		if (other.bagSellItem_ != null)
		{
			if (bagSellItem_ == null)
			{
				BagSellItem = new CSMsgBagSellItem();
			}
			BagSellItem.MergeFrom(other.BagSellItem);
		}
		if (other.shopRefreshFlagRemove_ != null)
		{
			if (shopRefreshFlagRemove_ == null)
			{
				ShopRefreshFlagRemove = new CSMsgShopRefreshFlagRemove();
			}
			ShopRefreshFlagRemove.MergeFrom(other.ShopRefreshFlagRemove);
		}
		if (other.taskChangeQuestStage_ != null)
		{
			if (taskChangeQuestStage_ == null)
			{
				TaskChangeQuestStage = new CSMsgTaskChangeQuestStage();
			}
			TaskChangeQuestStage.MergeFrom(other.TaskChangeQuestStage);
		}
		if (other.collectionInteractiveUnlock_ != null)
		{
			if (collectionInteractiveUnlock_ == null)
			{
				CollectionInteractiveUnlock = new CSMsgCollectionInteractiveUnlock();
			}
			CollectionInteractiveUnlock.MergeFrom(other.CollectionInteractiveUnlock);
		}
		if (other.redPointRemove_ != null)
		{
			if (redPointRemove_ == null)
			{
				RedPointRemove = new CSMsgRedPointRemove();
			}
			RedPointRemove.MergeFrom(other.RedPointRemove);
		}
		if (other.actorWeaponTransformFlexType_ != null)
		{
			if (actorWeaponTransformFlexType_ == null)
			{
				ActorWeaponTransformFlexType = new CSMsgActorWeaponTransformFlexType();
			}
			ActorWeaponTransformFlexType.MergeFrom(other.ActorWeaponTransformFlexType);
		}
		if (other.actorKillUnit_ != null)
		{
			if (actorKillUnit_ == null)
			{
				ActorKillUnit = new CSMsgActorKillUnit();
			}
			ActorKillUnit.MergeFrom(other.ActorKillUnit);
		}
		if (other.actorUnitEncounter_ != null)
		{
			if (actorUnitEncounter_ == null)
			{
				ActorUnitEncounter = new CSMsgActorUnitEncounter();
			}
			ActorUnitEncounter.MergeFrom(other.ActorUnitEncounter);
		}
		if (other.achievementUnlock_ != null)
		{
			if (achievementUnlock_ == null)
			{
				AchievementUnlock = new CSMsgAchievementUnlock();
			}
			AchievementUnlock.MergeFrom(other.AchievementUnlock);
		}
		if (other.chapterEnterNext_ != null)
		{
			if (chapterEnterNext_ == null)
			{
				ChapterEnterNext = new CSMsgChapterEnterNext();
			}
			ChapterEnterNext.MergeFrom(other.ChapterEnterNext);
		}
		if (other.chapterEnterShow_ != null)
		{
			if (chapterEnterShow_ == null)
			{
				ChapterEnterShow = new CSMsgChapterEnterShow();
			}
			ChapterEnterShow.MergeFrom(other.ChapterEnterShow);
		}
		if (other.chapterPreviewAward_ != null)
		{
			if (chapterPreviewAward_ == null)
			{
				ChapterPreviewAward = new CSMsgChapterPreviewAward();
			}
			ChapterPreviewAward.MergeFrom(other.ChapterPreviewAward);
		}
		if (other.museumRecordMemories_ != null)
		{
			if (museumRecordMemories_ == null)
			{
				MuseumRecordMemories = new CSMsgMuseumRecordMemories();
			}
			MuseumRecordMemories.MergeFrom(other.MuseumRecordMemories);
		}
		if (other.museumRemoveRedpoint_ != null)
		{
			if (museumRemoveRedpoint_ == null)
			{
				MuseumRemoveRedpoint = new CSMsgMuseumRemoveRedpoint();
			}
			MuseumRemoveRedpoint.MergeFrom(other.MuseumRemoveRedpoint);
		}
		if (other.attrChangeNotify_ != null)
		{
			if (attrChangeNotify_ == null)
			{
				AttrChangeNotify = new CSMsgAttrChangeNotify();
			}
			AttrChangeNotify.MergeFrom(other.AttrChangeNotify);
		}
		if (other.roomCreatePartyCs_ != null)
		{
			if (roomCreatePartyCs_ == null)
			{
				RoomCreatePartyCs = new CSMsgRoomCreatePartyCS();
			}
			RoomCreatePartyCs.MergeFrom(other.RoomCreatePartyCs);
		}
		if (other.roomJoinPartyCs_ != null)
		{
			if (roomJoinPartyCs_ == null)
			{
				RoomJoinPartyCs = new CSMsgRoomJoinPartyCS();
			}
			RoomJoinPartyCs.MergeFrom(other.RoomJoinPartyCs);
		}
		if (other.roomExitPartyCs_ != null)
		{
			if (roomExitPartyCs_ == null)
			{
				RoomExitPartyCs = new CSMsgRoomExitPartyCS();
			}
			RoomExitPartyCs.MergeFrom(other.RoomExitPartyCs);
		}
		if (other.roomPartyKickMemberCs_ != null)
		{
			if (roomPartyKickMemberCs_ == null)
			{
				RoomPartyKickMemberCs = new CSMsgRoomPartyKickMemberCS();
			}
			RoomPartyKickMemberCs.MergeFrom(other.RoomPartyKickMemberCs);
		}
		if (other.roomSearchPartyCs_ != null)
		{
			if (roomSearchPartyCs_ == null)
			{
				RoomSearchPartyCs = new CSMsgRoomSearchPartyCS();
			}
			RoomSearchPartyCs.MergeFrom(other.RoomSearchPartyCs);
		}
		if (other.roomSearchPartyNotify_ != null)
		{
			if (roomSearchPartyNotify_ == null)
			{
				RoomSearchPartyNotify = new CSMsgRoomSearchPartyNotify();
			}
			RoomSearchPartyNotify.MergeFrom(other.RoomSearchPartyNotify);
		}
		if (other.roomQueryPartyInfoCs_ != null)
		{
			if (roomQueryPartyInfoCs_ == null)
			{
				RoomQueryPartyInfoCs = new CSMsgRoomQueryPartyInfoCS();
			}
			RoomQueryPartyInfoCs.MergeFrom(other.RoomQueryPartyInfoCs);
		}
		if (other.roomPartyHeartBeatCs_ != null)
		{
			if (roomPartyHeartBeatCs_ == null)
			{
				RoomPartyHeartBeatCs = new CSMsgRoomPartyHeartBeatCS();
			}
			RoomPartyHeartBeatCs.MergeFrom(other.RoomPartyHeartBeatCs);
		}
		if (other.roomPartyEventNotify_ != null)
		{
			if (roomPartyEventNotify_ == null)
			{
				RoomPartyEventNotify = new CSMsgRoomPartyEventNotify();
			}
			RoomPartyEventNotify.MergeFrom(other.RoomPartyEventNotify);
		}
		if (other.roomSendPartyBattleMessageCs_ != null)
		{
			if (roomSendPartyBattleMessageCs_ == null)
			{
				RoomSendPartyBattleMessageCs = new CSMsgRoomSendPartyBattleMessageCS();
			}
			RoomSendPartyBattleMessageCs.MergeFrom(other.RoomSendPartyBattleMessageCs);
		}
		if (other.roomPartyBattleMessageNotify_ != null)
		{
			if (roomPartyBattleMessageNotify_ == null)
			{
				RoomPartyBattleMessageNotify = new CSMsgRoomPartyBattleMessageNotify();
			}
			RoomPartyBattleMessageNotify.MergeFrom(other.RoomPartyBattleMessageNotify);
		}
		if (other.roomPartyMemberUpdateCs_ != null)
		{
			if (roomPartyMemberUpdateCs_ == null)
			{
				RoomPartyMemberUpdateCs = new CSMsgRoomPartyMemberUpdateCS();
			}
			RoomPartyMemberUpdateCs.MergeFrom(other.RoomPartyMemberUpdateCs);
		}
		if (other.roomCreatePartyTaskCs_ != null)
		{
			if (roomCreatePartyTaskCs_ == null)
			{
				RoomCreatePartyTaskCs = new CSMsgRoomCreatePartyTaskCS();
			}
			RoomCreatePartyTaskCs.MergeFrom(other.RoomCreatePartyTaskCs);
		}
		if (other.roomUpdatePartyTaskCs_ != null)
		{
			if (roomUpdatePartyTaskCs_ == null)
			{
				RoomUpdatePartyTaskCs = new CSMsgRoomUpdatePartyTaskCS();
			}
			RoomUpdatePartyTaskCs.MergeFrom(other.RoomUpdatePartyTaskCs);
		}
		if (other.roomPartyTaskFinishCs_ != null)
		{
			if (roomPartyTaskFinishCs_ == null)
			{
				RoomPartyTaskFinishCs = new CSMsgRoomPartyTaskFinishCS();
			}
			RoomPartyTaskFinishCs.MergeFrom(other.RoomPartyTaskFinishCs);
		}
		if (other.bagMultiplayerDrop_ != null)
		{
			if (bagMultiplayerDrop_ == null)
			{
				BagMultiplayerDrop = new CSMsgBagMultiplayerDrop();
			}
			BagMultiplayerDrop.MergeFrom(other.BagMultiplayerDrop);
		}
		if (other.chapterGameComplete_ != null)
		{
			if (chapterGameComplete_ == null)
			{
				ChapterGameComplete = new CSMsgChapterGameComplete();
			}
			ChapterGameComplete.MergeFrom(other.ChapterGameComplete);
		}
		if (other.collectionReadCardStory_ != null)
		{
			if (collectionReadCardStory_ == null)
			{
				CollectionReadCardStory = new CSMsgCollectionReadCardStory();
			}
			CollectionReadCardStory.MergeFrom(other.CollectionReadCardStory);
		}
		if (other.bagArmorUpgrade_ != null)
		{
			if (bagArmorUpgrade_ == null)
			{
				BagArmorUpgrade = new CSMsgBagArmorUpgrade();
			}
			BagArmorUpgrade.MergeFrom(other.BagArmorUpgrade);
		}
		if (other.bagDropCollectionAward_ != null)
		{
			if (bagDropCollectionAward_ == null)
			{
				BagDropCollectionAward = new CSMsgBagDropCollectionAward();
			}
			BagDropCollectionAward.MergeFrom(other.BagDropCollectionAward);
		}
		if (other.partyApiCreateOnlineParty_ != null)
		{
			if (partyApiCreateOnlineParty_ == null)
			{
				PartyApiCreateOnlineParty = new CSMsgPartyApiCreateOnlineParty();
			}
			PartyApiCreateOnlineParty.MergeFrom(other.PartyApiCreateOnlineParty);
		}
		if (other.partyApiSearchParty_ != null)
		{
			if (partyApiSearchParty_ == null)
			{
				PartyApiSearchParty = new CSMsgPartyApiSearchParty();
			}
			PartyApiSearchParty.MergeFrom(other.PartyApiSearchParty);
		}
		if (other.partyApiJoinParty_ != null)
		{
			if (partyApiJoinParty_ == null)
			{
				PartyApiJoinParty = new CSMsgPartyApiJoinParty();
			}
			PartyApiJoinParty.MergeFrom(other.PartyApiJoinParty);
		}
		if (other.partyApiLeaderCreateTask_ != null)
		{
			if (partyApiLeaderCreateTask_ == null)
			{
				PartyApiLeaderCreateTask = new CSMsgPartyApiLeaderCreateTask();
			}
			PartyApiLeaderCreateTask.MergeFrom(other.PartyApiLeaderCreateTask);
		}
		if (other.partyApiMemberTaskReady_ != null)
		{
			if (partyApiMemberTaskReady_ == null)
			{
				PartyApiMemberTaskReady = new CSMsgPartyApiMemberTaskReady();
			}
			PartyApiMemberTaskReady.MergeFrom(other.PartyApiMemberTaskReady);
		}
		if (other.partyApiLeaderFinishTask_ != null)
		{
			if (partyApiLeaderFinishTask_ == null)
			{
				PartyApiLeaderFinishTask = new CSMsgPartyApiLeaderFinishTask();
			}
			PartyApiLeaderFinishTask.MergeFrom(other.PartyApiLeaderFinishTask);
		}
		if (other.partyApiLeaderCreateBattle_ != null)
		{
			if (partyApiLeaderCreateBattle_ == null)
			{
				PartyApiLeaderCreateBattle = new CSMsgPartyApiLeaderCreateBattle();
			}
			PartyApiLeaderCreateBattle.MergeFrom(other.PartyApiLeaderCreateBattle);
		}
		if (other.partyApiLeaderBattleReady_ != null)
		{
			if (partyApiLeaderBattleReady_ == null)
			{
				PartyApiLeaderBattleReady = new CSMsgPartyApiLeaderBattleReady();
			}
			PartyApiLeaderBattleReady.MergeFrom(other.PartyApiLeaderBattleReady);
		}
		if (other.partyApiMemberEnterBattle_ != null)
		{
			if (partyApiMemberEnterBattle_ == null)
			{
				PartyApiMemberEnterBattle = new CSMsgPartyApiMemberEnterBattle();
			}
			PartyApiMemberEnterBattle.MergeFrom(other.PartyApiMemberEnterBattle);
		}
		if (other.partyApiLeaderRequestHelp_ != null)
		{
			if (partyApiLeaderRequestHelp_ == null)
			{
				PartyApiLeaderRequestHelp = new CSMsgPartyApiLeaderRequestHelp();
			}
			PartyApiLeaderRequestHelp.MergeFrom(other.PartyApiLeaderRequestHelp);
		}
		if (other.partyApiLeaderCancelHelp_ != null)
		{
			if (partyApiLeaderCancelHelp_ == null)
			{
				PartyApiLeaderCancelHelp = new CSMsgPartyApiLeaderCancelHelp();
			}
			PartyApiLeaderCancelHelp.MergeFrom(other.PartyApiLeaderCancelHelp);
		}
		if (other.chapterConfirmAward_ != null)
		{
			if (chapterConfirmAward_ == null)
			{
				ChapterConfirmAward = new CSMsgChapterConfirmAward();
			}
			ChapterConfirmAward.MergeFrom(other.ChapterConfirmAward);
		}
		if (other.collectionViewCardPortrait_ != null)
		{
			if (collectionViewCardPortrait_ == null)
			{
				CollectionViewCardPortrait = new CSMsgCollectionViewCardPortrait();
			}
			CollectionViewCardPortrait.MergeFrom(other.CollectionViewCardPortrait);
		}
		if (other.actorSetSoulSkill_ != null)
		{
			if (actorSetSoulSkill_ == null)
			{
				ActorSetSoulSkill = new CSMsgActorSetSoulSkill();
			}
			ActorSetSoulSkill.MergeFrom(other.ActorSetSoulSkill);
		}
		if (other.gardenUpdateCropOutput_ != null)
		{
			if (gardenUpdateCropOutput_ == null)
			{
				GardenUpdateCropOutput = new CSMsgGardenUpdateCropOutput();
			}
			GardenUpdateCropOutput.MergeFrom(other.GardenUpdateCropOutput);
		}
		if (other.gardenCollectCropOutput_ != null)
		{
			if (gardenCollectCropOutput_ == null)
			{
				GardenCollectCropOutput = new CSMsgGardenCollectCropOutput();
			}
			GardenCollectCropOutput.MergeFrom(other.GardenCollectCropOutput);
		}
		if (other.gardenPlantAllSeeds_ != null)
		{
			if (gardenPlantAllSeeds_ == null)
			{
				GardenPlantAllSeeds = new CSMsgGardenPlantAllSeeds();
			}
			GardenPlantAllSeeds.MergeFrom(other.GardenPlantAllSeeds);
		}
		if (other.bagActivateWeapon_ != null)
		{
			if (bagActivateWeapon_ == null)
			{
				BagActivateWeapon = new CSMsgBagActivateWeapon();
			}
			BagActivateWeapon.MergeFrom(other.BagActivateWeapon);
		}
		if (other.bagGetAlchemyNpcCommunicationAward_ != null)
		{
			if (bagGetAlchemyNpcCommunicationAward_ == null)
			{
				BagGetAlchemyNpcCommunicationAward = new CSMsgBagGetAlchemyNpcCommunicationAward();
			}
			BagGetAlchemyNpcCommunicationAward.MergeFrom(other.BagGetAlchemyNpcCommunicationAward);
		}
		if (other.bagUpdateAlchemyNpcCommunicationStatus_ != null)
		{
			if (bagUpdateAlchemyNpcCommunicationStatus_ == null)
			{
				BagUpdateAlchemyNpcCommunicationStatus = new CSMsgBagUpdateAlchemyNpcCommunicationStatus();
			}
			BagUpdateAlchemyNpcCommunicationStatus.MergeFrom(other.BagUpdateAlchemyNpcCommunicationStatus);
		}
		if (other.bagHuluUpgrade_ != null)
		{
			if (bagHuluUpgrade_ == null)
			{
				BagHuluUpgrade = new CSMsgBagHuluUpgrade();
			}
			BagHuluUpgrade.MergeFrom(other.BagHuluUpgrade);
		}
		if (other.bagCollectDropSoulSkill_ != null)
		{
			if (bagCollectDropSoulSkill_ == null)
			{
				BagCollectDropSoulSkill = new CSMsgBagCollectDropSoulSkill();
			}
			BagCollectDropSoulSkill.MergeFrom(other.BagCollectDropSoulSkill);
		}
		if (other.actorWearAccessory_ != null)
		{
			if (actorWearAccessory_ == null)
			{
				ActorWearAccessory = new CSMsgActorWearAccessory();
			}
			ActorWearAccessory.MergeFrom(other.ActorWearAccessory);
		}
		if (other.actorUnWearAccessory_ != null)
		{
			if (actorUnWearAccessory_ == null)
			{
				ActorUnWearAccessory = new CSMsgActorUnWearAccessory();
			}
			ActorUnWearAccessory.MergeFrom(other.ActorUnWearAccessory);
		}
		if (other.achievementEnterLevel_ != null)
		{
			if (achievementEnterLevel_ == null)
			{
				AchievementEnterLevel = new CSMsgAchievementEnterLevel();
			}
			AchievementEnterLevel.MergeFrom(other.AchievementEnterLevel);
		}
		if (other.bagSoulSkillUpgrade_ != null)
		{
			if (bagSoulSkillUpgrade_ == null)
			{
				BagSoulSkillUpgrade = new CSMsgBagSoulSkillUpgrade();
			}
			BagSoulSkillUpgrade.MergeFrom(other.BagSoulSkillUpgrade);
		}
		if (other.actorActivateLegacyTalent_ != null)
		{
			if (actorActivateLegacyTalent_ == null)
			{
				ActorActivateLegacyTalent = new CSMsgActorActivateLegacyTalent();
			}
			ActorActivateLegacyTalent.MergeFrom(other.ActorActivateLegacyTalent);
		}
		if (other.actorRebuildLegacyTalent_ != null)
		{
			if (actorRebuildLegacyTalent_ == null)
			{
				ActorRebuildLegacyTalent = new CSMsgActorRebuildLegacyTalent();
			}
			ActorRebuildLegacyTalent.MergeFrom(other.ActorRebuildLegacyTalent);
		}
		if (other.bagRebuildAttrItem_ != null)
		{
			if (bagRebuildAttrItem_ == null)
			{
				BagRebuildAttrItem = new CSMsgBagRebuildAttrItem();
			}
			BagRebuildAttrItem.MergeFrom(other.BagRebuildAttrItem);
		}
		if (other.activitiesResume_ != null)
		{
			if (activitiesResume_ == null)
			{
				ActivitiesResume = new CSMsgActivitiesResume();
			}
			ActivitiesResume.MergeFrom(other.ActivitiesResume);
		}
		if (other.collectionCollectItem_ != null)
		{
			if (collectionCollectItem_ == null)
			{
				CollectionCollectItem = new CSMsgCollectionCollectItem();
			}
			CollectionCollectItem.MergeFrom(other.CollectionCollectItem);
		}
		if (other.chapterPrologueCompleted_ != null)
		{
			if (chapterPrologueCompleted_ == null)
			{
				ChapterPrologueCompleted = new CSMsgChapterPrologueCompleted();
			}
			ChapterPrologueCompleted.MergeFrom(other.ChapterPrologueCompleted);
		}
		if (other.attrRefresh_ != null)
		{
			if (attrRefresh_ == null)
			{
				AttrRefresh = new CSMsgAttrRefresh();
			}
			AttrRefresh.MergeFrom(other.AttrRefresh);
		}
		if (other.miscTestLargePackage_ != null)
		{
			if (miscTestLargePackage_ == null)
			{
				MiscTestLargePackage = new CSMsgMiscTestLargePackage();
			}
			MiscTestLargePackage.MergeFrom(other.MiscTestLargePackage);
		}
		if (other.interactSoulBottleGainItem_ != null)
		{
			if (interactSoulBottleGainItem_ == null)
			{
				InteractSoulBottleGainItem = new CSMsgInteractSoulBottleGainItem();
			}
			InteractSoulBottleGainItem.MergeFrom(other.InteractSoulBottleGainItem);
		}
		if (other.bossRushBattleStart_ != null)
		{
			if (bossRushBattleStart_ == null)
			{
				BossRushBattleStart = new CSMsgBossRushBattleStart();
			}
			BossRushBattleStart.MergeFrom(other.BossRushBattleStart);
		}
		if (other.bossRushBattleComplete_ != null)
		{
			if (bossRushBattleComplete_ == null)
			{
				BossRushBattleComplete = new CSMsgBossRushBattleComplete();
			}
			BossRushBattleComplete.MergeFrom(other.BossRushBattleComplete);
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
	}

	public void MergeFrom(CodedInputStream input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0)
		{
			switch (num)
			{
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
				break;
			case 10u:
				if (head_ == null)
				{
					Head = new CSMsgHead();
				}
				input.ReadMessage(Head);
				break;
			case 18u:
				if (roleLogin_ == null)
				{
					RoleLogin = new CSMsgRoleLogin();
				}
				input.ReadMessage(RoleLogin);
				break;
			case 26u:
				if (roleLogout_ == null)
				{
					RoleLogout = new CSMsgRoleLogout();
				}
				input.ReadMessage(RoleLogout);
				break;
			case 34u:
				if (roleKick_ == null)
				{
					RoleKick = new CSMsgRoleKick();
				}
				input.ReadMessage(RoleKick);
				break;
			case 42u:
				if (roleDataNotify_ == null)
				{
					RoleDataNotify = new CSMsgRoleDataNotify();
				}
				input.ReadMessage(RoleDataNotify);
				break;
			case 50u:
				if (roleRandomName_ == null)
				{
					RoleRandomName = new CSMsgRoleRandomName();
				}
				input.ReadMessage(RoleRandomName);
				break;
			case 58u:
				if (roleChangeName_ == null)
				{
					RoleChangeName = new CSMsgRoleChangeName();
				}
				input.ReadMessage(RoleChangeName);
				break;
			case 66u:
				if (miscCreateRole_ == null)
				{
					MiscCreateRole = new CSMsgMiscCreateRole();
				}
				input.ReadMessage(MiscCreateRole);
				break;
			case 74u:
				if (miscExecGm_ == null)
				{
					MiscExecGm = new CSMsgMiscExecGM();
				}
				input.ReadMessage(MiscExecGm);
				break;
			case 82u:
				if (miscHeartBeat_ == null)
				{
					MiscHeartBeat = new CSMsgMiscHeartBeat();
				}
				input.ReadMessage(MiscHeartBeat);
				break;
			case 90u:
				if (miscCheckRes_ == null)
				{
					MiscCheckRes = new CSMsgMiscCheckRes();
				}
				input.ReadMessage(MiscCheckRes);
				break;
			case 98u:
				if (awolMsgGetList_ == null)
				{
					AwolMsgGetList = new CSMsgAwolMsgGetList();
				}
				input.ReadMessage(AwolMsgGetList);
				break;
			case 106u:
				if (awolMsgRemove_ == null)
				{
					AwolMsgRemove = new CSMsgAwolMsgRemove();
				}
				input.ReadMessage(AwolMsgRemove);
				break;
			case 114u:
				if (awolMsgUpdate_ == null)
				{
					AwolMsgUpdate = new CSMsgAwolMsgUpdate();
				}
				input.ReadMessage(AwolMsgUpdate);
				break;
			case 122u:
				if (awolMsgSend_ == null)
				{
					AwolMsgSend = new CSMsgAwolMsgSend();
				}
				input.ReadMessage(AwolMsgSend);
				break;
			case 130u:
				if (awolMsgNotifyUpdate_ == null)
				{
					AwolMsgNotifyUpdate = new CSMsgAwolMsgNotifyUpdate();
				}
				input.ReadMessage(AwolMsgNotifyUpdate);
				break;
			case 138u:
				if (awolMsgNotifyRemove_ == null)
				{
					AwolMsgNotifyRemove = new CSMsgAwolMsgNotifyRemove();
				}
				input.ReadMessage(AwolMsgNotifyRemove);
				break;
			case 146u:
				if (awolMsgNotifyAdd_ == null)
				{
					AwolMsgNotifyAdd = new CSMsgAwolMsgNotifyAdd();
				}
				input.ReadMessage(AwolMsgNotifyAdd);
				break;
			case 154u:
				if (briefMsgGet_ == null)
				{
					BriefMsgGet = new CSMsgBriefMsgGet();
				}
				input.ReadMessage(BriefMsgGet);
				break;
			case 162u:
				if (rankListGet_ == null)
				{
					RankListGet = new CSMsgRankListGet();
				}
				input.ReadMessage(RankListGet);
				break;
			case 170u:
				if (bagGainItemList_ == null)
				{
					BagGainItemList = new CSMsgBagGainItemList();
				}
				input.ReadMessage(BagGainItemList);
				break;
			case 178u:
				if (bagCostItemList_ == null)
				{
					BagCostItemList = new CSMsgBagCostItemList();
				}
				input.ReadMessage(BagCostItemList);
				break;
			case 186u:
				if (bagHuluSetting_ == null)
				{
					BagHuluSetting = new CSMsgBagHuluSetting();
				}
				input.ReadMessage(BagHuluSetting);
				break;
			case 194u:
				if (bagAlchemy_ == null)
				{
					BagAlchemy = new CSMsgBagAlchemy();
				}
				input.ReadMessage(BagAlchemy);
				break;
			case 202u:
				if (bagWeaponBuild_ == null)
				{
					BagWeaponBuild = new CSMsgBagWeaponBuild();
				}
				input.ReadMessage(BagWeaponBuild);
				break;
			case 210u:
				if (bagWeaponReBuild_ == null)
				{
					BagWeaponReBuild = new CSMsgBagWeaponReBuild();
				}
				input.ReadMessage(BagWeaponReBuild);
				break;
			case 218u:
				if (bagDropUnitAward_ == null)
				{
					BagDropUnitAward = new CSMsgBagDropUnitAward();
				}
				input.ReadMessage(BagDropUnitAward);
				break;
			case 226u:
				if (bagCommDrop_ == null)
				{
					BagCommDrop = new CSMsgBagCommDrop();
				}
				input.ReadMessage(BagCommDrop);
				break;
			case 234u:
				if (bagWineUpgrade_ == null)
				{
					BagWineUpgrade = new CSMsgBagWineUpgrade();
				}
				input.ReadMessage(BagWineUpgrade);
				break;
			case 242u:
				if (bagWinePartnerSetting_ == null)
				{
					BagWinePartnerSetting = new CSMsgBagWinePartnerSetting();
				}
				input.ReadMessage(BagWinePartnerSetting);
				break;
			case 250u:
				if (bagGainEditionAward_ == null)
				{
					BagGainEditionAward = new CSMsgBagGainEditionAward();
				}
				input.ReadMessage(BagGainEditionAward);
				break;
			case 258u:
				if (actorWearEquip_ == null)
				{
					ActorWearEquip = new CSMsgActorWearEquip();
				}
				input.ReadMessage(ActorWearEquip);
				break;
			case 266u:
				if (actorUnWearEquip_ == null)
				{
					ActorUnWearEquip = new CSMsgActorUnWearEquip();
				}
				input.ReadMessage(ActorUnWearEquip);
				break;
			case 274u:
				if (actorSetShortCut_ == null)
				{
					ActorSetShortCut = new CSMsgActorSetShortCut();
				}
				input.ReadMessage(ActorSetShortCut);
				break;
			case 282u:
				if (actorUnSetShortCut_ == null)
				{
					ActorUnSetShortCut = new CSMsgActorUnSetShortCut();
				}
				input.ReadMessage(ActorUnSetShortCut);
				break;
			case 290u:
				if (actorSetSpell_ == null)
				{
					ActorSetSpell = new CSMsgActorSetSpell();
				}
				input.ReadMessage(ActorSetSpell);
				break;
			case 298u:
				if (actorUnSetSpell_ == null)
				{
					ActorUnSetSpell = new CSMsgActorUnSetSpell();
				}
				input.ReadMessage(ActorUnSetSpell);
				break;
			case 306u:
				if (actorSetDefaultSpell_ == null)
				{
					ActorSetDefaultSpell = new CSMsgActorSetDefaultSpell();
				}
				input.ReadMessage(ActorSetDefaultSpell);
				break;
			case 314u:
				if (actorOnPlayerDeath_ == null)
				{
					ActorOnPlayerDeath = new CSMsgActorOnPlayerDeath();
				}
				input.ReadMessage(ActorOnPlayerDeath);
				break;
			case 322u:
				if (actorOnPlayerRest_ == null)
				{
					ActorOnPlayerRest = new CSMsgActorOnPlayerRest();
				}
				input.ReadMessage(ActorOnPlayerRest);
				break;
			case 330u:
				if (actorOnNewGamePlus_ == null)
				{
					ActorOnNewGamePlus = new CSMsgActorOnNewGamePlus();
				}
				input.ReadMessage(ActorOnNewGamePlus);
				break;
			case 338u:
				if (actorUnLockTalent_ == null)
				{
					ActorUnLockTalent = new CSMsgActorUnLockTalent();
				}
				input.ReadMessage(ActorUnLockTalent);
				break;
			case 346u:
				if (actorTalentLevelUp_ == null)
				{
					ActorTalentLevelUp = new CSMsgActorTalentLevelUp();
				}
				input.ReadMessage(ActorTalentLevelUp);
				break;
			case 354u:
				if (actorRebuildTalent_ == null)
				{
					ActorRebuildTalent = new CSMsgActorRebuildTalent();
				}
				input.ReadMessage(ActorRebuildTalent);
				break;
			case 362u:
				if (actorMeditationUnlock_ == null)
				{
					ActorMeditationUnlock = new CSMsgActorMeditationUnlock();
				}
				input.ReadMessage(ActorMeditationUnlock);
				break;
			case 370u:
				if (actorOnPlayerExit_ == null)
				{
					ActorOnPlayerExit = new CSMsgActorOnPlayerExit();
				}
				input.ReadMessage(ActorOnPlayerExit);
				break;
			case 378u:
				if (actorWineSetting_ == null)
				{
					ActorWineSetting = new CSMsgActorWineSetting();
				}
				input.ReadMessage(ActorWineSetting);
				break;
			case 386u:
				if (shopPayBuyItem_ == null)
				{
					ShopPayBuyItem = new CSMsgShopPayBuyItem();
				}
				input.ReadMessage(ShopPayBuyItem);
				break;
			case 394u:
				if (shopRefresh_ == null)
				{
					ShopRefresh = new CSMsgShopRefresh();
				}
				input.ReadMessage(ShopRefresh);
				break;
			case 402u:
				if (bagSellItem_ == null)
				{
					BagSellItem = new CSMsgBagSellItem();
				}
				input.ReadMessage(BagSellItem);
				break;
			case 410u:
				if (shopRefreshFlagRemove_ == null)
				{
					ShopRefreshFlagRemove = new CSMsgShopRefreshFlagRemove();
				}
				input.ReadMessage(ShopRefreshFlagRemove);
				break;
			case 418u:
				if (taskChangeQuestStage_ == null)
				{
					TaskChangeQuestStage = new CSMsgTaskChangeQuestStage();
				}
				input.ReadMessage(TaskChangeQuestStage);
				break;
			case 426u:
				if (collectionInteractiveUnlock_ == null)
				{
					CollectionInteractiveUnlock = new CSMsgCollectionInteractiveUnlock();
				}
				input.ReadMessage(CollectionInteractiveUnlock);
				break;
			case 434u:
				if (redPointRemove_ == null)
				{
					RedPointRemove = new CSMsgRedPointRemove();
				}
				input.ReadMessage(RedPointRemove);
				break;
			case 442u:
				if (actorWeaponTransformFlexType_ == null)
				{
					ActorWeaponTransformFlexType = new CSMsgActorWeaponTransformFlexType();
				}
				input.ReadMessage(ActorWeaponTransformFlexType);
				break;
			case 450u:
				if (actorKillUnit_ == null)
				{
					ActorKillUnit = new CSMsgActorKillUnit();
				}
				input.ReadMessage(ActorKillUnit);
				break;
			case 458u:
				if (actorUnitEncounter_ == null)
				{
					ActorUnitEncounter = new CSMsgActorUnitEncounter();
				}
				input.ReadMessage(ActorUnitEncounter);
				break;
			case 466u:
				if (achievementUnlock_ == null)
				{
					AchievementUnlock = new CSMsgAchievementUnlock();
				}
				input.ReadMessage(AchievementUnlock);
				break;
			case 474u:
				if (chapterEnterNext_ == null)
				{
					ChapterEnterNext = new CSMsgChapterEnterNext();
				}
				input.ReadMessage(ChapterEnterNext);
				break;
			case 482u:
				if (chapterEnterShow_ == null)
				{
					ChapterEnterShow = new CSMsgChapterEnterShow();
				}
				input.ReadMessage(ChapterEnterShow);
				break;
			case 490u:
				if (chapterPreviewAward_ == null)
				{
					ChapterPreviewAward = new CSMsgChapterPreviewAward();
				}
				input.ReadMessage(ChapterPreviewAward);
				break;
			case 498u:
				if (museumRecordMemories_ == null)
				{
					MuseumRecordMemories = new CSMsgMuseumRecordMemories();
				}
				input.ReadMessage(MuseumRecordMemories);
				break;
			case 506u:
				if (museumRemoveRedpoint_ == null)
				{
					MuseumRemoveRedpoint = new CSMsgMuseumRemoveRedpoint();
				}
				input.ReadMessage(MuseumRemoveRedpoint);
				break;
			case 514u:
				if (attrChangeNotify_ == null)
				{
					AttrChangeNotify = new CSMsgAttrChangeNotify();
				}
				input.ReadMessage(AttrChangeNotify);
				break;
			case 522u:
				if (roomCreatePartyCs_ == null)
				{
					RoomCreatePartyCs = new CSMsgRoomCreatePartyCS();
				}
				input.ReadMessage(RoomCreatePartyCs);
				break;
			case 530u:
				if (roomJoinPartyCs_ == null)
				{
					RoomJoinPartyCs = new CSMsgRoomJoinPartyCS();
				}
				input.ReadMessage(RoomJoinPartyCs);
				break;
			case 538u:
				if (roomExitPartyCs_ == null)
				{
					RoomExitPartyCs = new CSMsgRoomExitPartyCS();
				}
				input.ReadMessage(RoomExitPartyCs);
				break;
			case 546u:
				if (roomPartyKickMemberCs_ == null)
				{
					RoomPartyKickMemberCs = new CSMsgRoomPartyKickMemberCS();
				}
				input.ReadMessage(RoomPartyKickMemberCs);
				break;
			case 554u:
				if (roomSearchPartyCs_ == null)
				{
					RoomSearchPartyCs = new CSMsgRoomSearchPartyCS();
				}
				input.ReadMessage(RoomSearchPartyCs);
				break;
			case 562u:
				if (roomSearchPartyNotify_ == null)
				{
					RoomSearchPartyNotify = new CSMsgRoomSearchPartyNotify();
				}
				input.ReadMessage(RoomSearchPartyNotify);
				break;
			case 570u:
				if (roomQueryPartyInfoCs_ == null)
				{
					RoomQueryPartyInfoCs = new CSMsgRoomQueryPartyInfoCS();
				}
				input.ReadMessage(RoomQueryPartyInfoCs);
				break;
			case 578u:
				if (roomPartyHeartBeatCs_ == null)
				{
					RoomPartyHeartBeatCs = new CSMsgRoomPartyHeartBeatCS();
				}
				input.ReadMessage(RoomPartyHeartBeatCs);
				break;
			case 586u:
				if (roomPartyEventNotify_ == null)
				{
					RoomPartyEventNotify = new CSMsgRoomPartyEventNotify();
				}
				input.ReadMessage(RoomPartyEventNotify);
				break;
			case 594u:
				if (roomSendPartyBattleMessageCs_ == null)
				{
					RoomSendPartyBattleMessageCs = new CSMsgRoomSendPartyBattleMessageCS();
				}
				input.ReadMessage(RoomSendPartyBattleMessageCs);
				break;
			case 602u:
				if (roomPartyBattleMessageNotify_ == null)
				{
					RoomPartyBattleMessageNotify = new CSMsgRoomPartyBattleMessageNotify();
				}
				input.ReadMessage(RoomPartyBattleMessageNotify);
				break;
			case 610u:
				if (roomPartyMemberUpdateCs_ == null)
				{
					RoomPartyMemberUpdateCs = new CSMsgRoomPartyMemberUpdateCS();
				}
				input.ReadMessage(RoomPartyMemberUpdateCs);
				break;
			case 618u:
				if (roomCreatePartyTaskCs_ == null)
				{
					RoomCreatePartyTaskCs = new CSMsgRoomCreatePartyTaskCS();
				}
				input.ReadMessage(RoomCreatePartyTaskCs);
				break;
			case 626u:
				if (roomUpdatePartyTaskCs_ == null)
				{
					RoomUpdatePartyTaskCs = new CSMsgRoomUpdatePartyTaskCS();
				}
				input.ReadMessage(RoomUpdatePartyTaskCs);
				break;
			case 634u:
				if (roomPartyTaskFinishCs_ == null)
				{
					RoomPartyTaskFinishCs = new CSMsgRoomPartyTaskFinishCS();
				}
				input.ReadMessage(RoomPartyTaskFinishCs);
				break;
			case 642u:
				if (bagMultiplayerDrop_ == null)
				{
					BagMultiplayerDrop = new CSMsgBagMultiplayerDrop();
				}
				input.ReadMessage(BagMultiplayerDrop);
				break;
			case 650u:
				if (chapterGameComplete_ == null)
				{
					ChapterGameComplete = new CSMsgChapterGameComplete();
				}
				input.ReadMessage(ChapterGameComplete);
				break;
			case 658u:
				if (collectionReadCardStory_ == null)
				{
					CollectionReadCardStory = new CSMsgCollectionReadCardStory();
				}
				input.ReadMessage(CollectionReadCardStory);
				break;
			case 666u:
				if (bagArmorUpgrade_ == null)
				{
					BagArmorUpgrade = new CSMsgBagArmorUpgrade();
				}
				input.ReadMessage(BagArmorUpgrade);
				break;
			case 674u:
				if (bagDropCollectionAward_ == null)
				{
					BagDropCollectionAward = new CSMsgBagDropCollectionAward();
				}
				input.ReadMessage(BagDropCollectionAward);
				break;
			case 682u:
				if (partyApiCreateOnlineParty_ == null)
				{
					PartyApiCreateOnlineParty = new CSMsgPartyApiCreateOnlineParty();
				}
				input.ReadMessage(PartyApiCreateOnlineParty);
				break;
			case 690u:
				if (partyApiSearchParty_ == null)
				{
					PartyApiSearchParty = new CSMsgPartyApiSearchParty();
				}
				input.ReadMessage(PartyApiSearchParty);
				break;
			case 698u:
				if (partyApiJoinParty_ == null)
				{
					PartyApiJoinParty = new CSMsgPartyApiJoinParty();
				}
				input.ReadMessage(PartyApiJoinParty);
				break;
			case 706u:
				if (partyApiLeaderCreateTask_ == null)
				{
					PartyApiLeaderCreateTask = new CSMsgPartyApiLeaderCreateTask();
				}
				input.ReadMessage(PartyApiLeaderCreateTask);
				break;
			case 714u:
				if (partyApiMemberTaskReady_ == null)
				{
					PartyApiMemberTaskReady = new CSMsgPartyApiMemberTaskReady();
				}
				input.ReadMessage(PartyApiMemberTaskReady);
				break;
			case 722u:
				if (partyApiLeaderFinishTask_ == null)
				{
					PartyApiLeaderFinishTask = new CSMsgPartyApiLeaderFinishTask();
				}
				input.ReadMessage(PartyApiLeaderFinishTask);
				break;
			case 730u:
				if (partyApiLeaderCreateBattle_ == null)
				{
					PartyApiLeaderCreateBattle = new CSMsgPartyApiLeaderCreateBattle();
				}
				input.ReadMessage(PartyApiLeaderCreateBattle);
				break;
			case 738u:
				if (partyApiLeaderBattleReady_ == null)
				{
					PartyApiLeaderBattleReady = new CSMsgPartyApiLeaderBattleReady();
				}
				input.ReadMessage(PartyApiLeaderBattleReady);
				break;
			case 746u:
				if (partyApiMemberEnterBattle_ == null)
				{
					PartyApiMemberEnterBattle = new CSMsgPartyApiMemberEnterBattle();
				}
				input.ReadMessage(PartyApiMemberEnterBattle);
				break;
			case 754u:
				if (partyApiLeaderRequestHelp_ == null)
				{
					PartyApiLeaderRequestHelp = new CSMsgPartyApiLeaderRequestHelp();
				}
				input.ReadMessage(PartyApiLeaderRequestHelp);
				break;
			case 762u:
				if (partyApiLeaderCancelHelp_ == null)
				{
					PartyApiLeaderCancelHelp = new CSMsgPartyApiLeaderCancelHelp();
				}
				input.ReadMessage(PartyApiLeaderCancelHelp);
				break;
			case 770u:
				if (chapterConfirmAward_ == null)
				{
					ChapterConfirmAward = new CSMsgChapterConfirmAward();
				}
				input.ReadMessage(ChapterConfirmAward);
				break;
			case 778u:
				if (collectionViewCardPortrait_ == null)
				{
					CollectionViewCardPortrait = new CSMsgCollectionViewCardPortrait();
				}
				input.ReadMessage(CollectionViewCardPortrait);
				break;
			case 786u:
				if (actorSetSoulSkill_ == null)
				{
					ActorSetSoulSkill = new CSMsgActorSetSoulSkill();
				}
				input.ReadMessage(ActorSetSoulSkill);
				break;
			case 794u:
				if (gardenUpdateCropOutput_ == null)
				{
					GardenUpdateCropOutput = new CSMsgGardenUpdateCropOutput();
				}
				input.ReadMessage(GardenUpdateCropOutput);
				break;
			case 802u:
				if (gardenCollectCropOutput_ == null)
				{
					GardenCollectCropOutput = new CSMsgGardenCollectCropOutput();
				}
				input.ReadMessage(GardenCollectCropOutput);
				break;
			case 810u:
				if (gardenPlantAllSeeds_ == null)
				{
					GardenPlantAllSeeds = new CSMsgGardenPlantAllSeeds();
				}
				input.ReadMessage(GardenPlantAllSeeds);
				break;
			case 818u:
				if (bagActivateWeapon_ == null)
				{
					BagActivateWeapon = new CSMsgBagActivateWeapon();
				}
				input.ReadMessage(BagActivateWeapon);
				break;
			case 826u:
				if (bagGetAlchemyNpcCommunicationAward_ == null)
				{
					BagGetAlchemyNpcCommunicationAward = new CSMsgBagGetAlchemyNpcCommunicationAward();
				}
				input.ReadMessage(BagGetAlchemyNpcCommunicationAward);
				break;
			case 834u:
				if (bagUpdateAlchemyNpcCommunicationStatus_ == null)
				{
					BagUpdateAlchemyNpcCommunicationStatus = new CSMsgBagUpdateAlchemyNpcCommunicationStatus();
				}
				input.ReadMessage(BagUpdateAlchemyNpcCommunicationStatus);
				break;
			case 842u:
				if (bagHuluUpgrade_ == null)
				{
					BagHuluUpgrade = new CSMsgBagHuluUpgrade();
				}
				input.ReadMessage(BagHuluUpgrade);
				break;
			case 850u:
				if (bagCollectDropSoulSkill_ == null)
				{
					BagCollectDropSoulSkill = new CSMsgBagCollectDropSoulSkill();
				}
				input.ReadMessage(BagCollectDropSoulSkill);
				break;
			case 858u:
				if (actorWearAccessory_ == null)
				{
					ActorWearAccessory = new CSMsgActorWearAccessory();
				}
				input.ReadMessage(ActorWearAccessory);
				break;
			case 866u:
				if (actorUnWearAccessory_ == null)
				{
					ActorUnWearAccessory = new CSMsgActorUnWearAccessory();
				}
				input.ReadMessage(ActorUnWearAccessory);
				break;
			case 874u:
				if (achievementEnterLevel_ == null)
				{
					AchievementEnterLevel = new CSMsgAchievementEnterLevel();
				}
				input.ReadMessage(AchievementEnterLevel);
				break;
			case 882u:
				if (bagSoulSkillUpgrade_ == null)
				{
					BagSoulSkillUpgrade = new CSMsgBagSoulSkillUpgrade();
				}
				input.ReadMessage(BagSoulSkillUpgrade);
				break;
			case 890u:
				if (actorActivateLegacyTalent_ == null)
				{
					ActorActivateLegacyTalent = new CSMsgActorActivateLegacyTalent();
				}
				input.ReadMessage(ActorActivateLegacyTalent);
				break;
			case 898u:
				if (actorRebuildLegacyTalent_ == null)
				{
					ActorRebuildLegacyTalent = new CSMsgActorRebuildLegacyTalent();
				}
				input.ReadMessage(ActorRebuildLegacyTalent);
				break;
			case 906u:
				if (bagRebuildAttrItem_ == null)
				{
					BagRebuildAttrItem = new CSMsgBagRebuildAttrItem();
				}
				input.ReadMessage(BagRebuildAttrItem);
				break;
			case 914u:
				if (activitiesResume_ == null)
				{
					ActivitiesResume = new CSMsgActivitiesResume();
				}
				input.ReadMessage(ActivitiesResume);
				break;
			case 922u:
				if (collectionCollectItem_ == null)
				{
					CollectionCollectItem = new CSMsgCollectionCollectItem();
				}
				input.ReadMessage(CollectionCollectItem);
				break;
			case 930u:
				if (chapterPrologueCompleted_ == null)
				{
					ChapterPrologueCompleted = new CSMsgChapterPrologueCompleted();
				}
				input.ReadMessage(ChapterPrologueCompleted);
				break;
			case 938u:
				if (attrRefresh_ == null)
				{
					AttrRefresh = new CSMsgAttrRefresh();
				}
				input.ReadMessage(AttrRefresh);
				break;
			case 946u:
				if (miscTestLargePackage_ == null)
				{
					MiscTestLargePackage = new CSMsgMiscTestLargePackage();
				}
				input.ReadMessage(MiscTestLargePackage);
				break;
			case 954u:
				if (interactSoulBottleGainItem_ == null)
				{
					InteractSoulBottleGainItem = new CSMsgInteractSoulBottleGainItem();
				}
				input.ReadMessage(InteractSoulBottleGainItem);
				break;
			case 962u:
				if (bossRushBattleStart_ == null)
				{
					BossRushBattleStart = new CSMsgBossRushBattleStart();
				}
				input.ReadMessage(BossRushBattleStart);
				break;
			case 970u:
				if (bossRushBattleComplete_ == null)
				{
					BossRushBattleComplete = new CSMsgBossRushBattleComplete();
				}
				input.ReadMessage(BossRushBattleComplete);
				break;
			}
		}
	}
}
