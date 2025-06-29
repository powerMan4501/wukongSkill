using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using b1.Protobuf.DataAPI;
using BaseU3;
using BtlB1;
using BtlShare;
using BtlU3;
using Google.Protobuf.Collections;
using ResB1;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.EnhancedInput;
using UnrealEngine.Runtime;

namespace b1;

public static class BGW_GameDB
{
	public struct BuffRuleInfo
	{
		public int SourceBuffID;

		public EBuffRuleType BuffRule;

		public List<int> RelationalBuffIDList;

		public List<int> ComposedBuffIDList;

		public bool ComposedKeepOldBuff;

		public bool WithTriggerRemoveEffect;

		public BuffRuleInfo(int _SourceBuffID, FUStBuffRuleDesc BuffRuleDesc)
		{
			SourceBuffID = _SourceBuffID;
			BuffRule = BuffRuleDesc.BuffRuleType;
			RelationalBuffIDList = AnalyzeBuffIDListInRule(BuffRuleDesc.BuffIDList);
			ComposedBuffIDList = AnalyzeBuffIDListInRule(BuffRuleDesc.ComposedBuffID);
			ComposedKeepOldBuff = BuffRuleDesc.ComposedKeepOldBuff == EGSYesNo.Yes;
			WithTriggerRemoveEffect = BuffRuleDesc.WithTriggerRemmoveEffect == EGSYesNo.Yes;
		}
	}

	public struct FAbnormalDispActionSingle
	{
		public EAbnormalDispModifyType ModifyType;

		public string DBCPath;

		public FAbnormalDispActionSingle(EAbnormalDispModifyType _ModifyType, string _DBCPath)
		{
			ModifyType = _ModifyType;
			DBCPath = _DBCPath;
		}
	}

	public struct FAbnormalDispSingle
	{
		public Dictionary<EAbnromalDispActionType, FAbnormalDispActionSingle> ActionMap;

		public FAbnormalDispSingle(FAbnormalDispModifyInfo ModifyInfo)
		{
			ActionMap = new Dictionary<EAbnromalDispActionType, FAbnormalDispActionSingle>();
			ActionMap.Add(EAbnromalDispActionType.AccProcess, new FAbnormalDispActionSingle(ModifyInfo.MTAccProcess, ModifyInfo.DBCAccProcess));
			ActionMap.Add(EAbnromalDispActionType.FinalBegin, new FAbnormalDispActionSingle(ModifyInfo.MTFinalBegin, ModifyInfo.DBCFinalBegin));
			ActionMap.Add(EAbnromalDispActionType.FinalLoop, new FAbnormalDispActionSingle(ModifyInfo.MTFinalLoop, ModifyInfo.DBCFinalLoop));
			ActionMap.Add(EAbnromalDispActionType.HitExt, new FAbnormalDispActionSingle(ModifyInfo.MTHitExt, ModifyInfo.DBCHitExt));
			ActionMap.Add(EAbnromalDispActionType.DeadKeep, new FAbnormalDispActionSingle(ModifyInfo.MTDeadKeep, ModifyInfo.DBCDeadKeep));
			ActionMap.Add(EAbnromalDispActionType.DeadDisappear, new FAbnormalDispActionSingle(ModifyInfo.MTDeadDisappear, ModifyInfo.DBCDeadDisappear));
		}
	}

	[UEnum]
	[USharpPath("/Script/b1-Managed.AbnromalDispActionType_FreezeExt")]
	public enum EAbnromalDispActionType_FreezeExt : byte
	{
		[DisplayName("打破")]
		Broken,
		[DisplayName("自然消散")]
		AutoRelease,
		[DisplayName("摇冰")]
		ShakeFreeze
	}

	public struct FAbnormalDispSingle_FreezeExt
	{
		public Dictionary<EAbnromalDispActionType_FreezeExt, FAbnormalDispActionSingle> ActionMap;

		public FAbnormalDispSingle_FreezeExt(FAbnormalDispModifyInfoFreezeExt ModifyInfo)
		{
			ActionMap = new Dictionary<EAbnromalDispActionType_FreezeExt, FAbnormalDispActionSingle>();
			ActionMap.Add(EAbnromalDispActionType_FreezeExt.Broken, new FAbnormalDispActionSingle(ModifyInfo.MTBroken, ModifyInfo.DBCBroken));
			ActionMap.Add(EAbnromalDispActionType_FreezeExt.AutoRelease, new FAbnormalDispActionSingle(ModifyInfo.MTAutoRelease, ModifyInfo.DBCAutoRelease));
			ActionMap.Add(EAbnromalDispActionType_FreezeExt.ShakeFreeze, new FAbnormalDispActionSingle(ModifyInfo.MTBroken, ModifyInfo.DBCShakeFreeze));
		}
	}

	private const int ProjCommUnitResID = 0;

	private static Dictionary<int, Dictionary<int, Dictionary<int, int>>> sMapPartRuleUnit;

	private static Dictionary<int, Dictionary<int, FUStStraightCamDesc>> sMapStraightCamUnit;

	private static Dictionary<int, Dictionary<string, FUStMultiPointLockCameraConfigDesc>> sMapMultiPointLockCamUnit;

	private static Dictionary<int, List<string>> sMapMultiPointLockOfUnit;

	private static Dictionary<int, Dictionary<int, FUStDiagonalCamDesc>> sMapDiagonalCamUnit;

	private static Dictionary<int, Dictionary<int, FUStGiantLockCameraDesc>> sMapGiantCamUnit;

	private static Dictionary<int, Dictionary<int, FUStCameraGroupDesc>> sMapCameraGroupGroupUnit;

	private static Dictionary<int, Dictionary<int, FUStPassiveSkillDesc>> sMapPassiveSkill;

	private static Dictionary<int, Dictionary<int, FUStUnitDeadDesc>> sMapUnitDead;

	private static Dictionary<int, Dictionary<int, FUStSoulSkillMimicryDesc>> sMapSoulSkillMimicry;

	private static Dictionary<int, Dictionary<int, Dictionary<int, FUStPotentialEnergyConfigDesc>>> sMapPotentialEnergy;

	private static Dictionary<ESceneItemSurfaceType, Dictionary<ESkillDamageType, Dictionary<int, int>>> sMapHitSceneItemPerformUnitResIDMapUnit;

	private static Dictionary<ESceneItemSurfaceType, Dictionary<int, Dictionary<int, int>>> sMapHitSceneItemPerformSkillEffectIDMapUnit;

	private static Dictionary<int, Dictionary<int, List<FUStBeAttackedDispInfoDesc>>> sMapBeAttackedDispInfo;

	private static Dictionary<int, Dictionary<int, int>> sMapBeAttackedStiffLevelMapping;

	private static Dictionary<long, int> sMapAttackHitFX_ID;

	private static Dictionary<long, int> sMapBeAttackedFX_ID;

	private static Dictionary<int, List<int>> sMapBuffTickRuleBySS_ID;

	private static Dictionary<int, List<FUStB2DUnitSpawnDesc>> sMapB2DUnitSpawnStage;

	private static Dictionary<int, List<int>> sMapBuffGroupInfo;

	private static Dictionary<int, List<FUStB2DSkillStage>> sSkillEffectMap;

	private static Dictionary<int, List<FUStB2DComboSkill>> sComboSkillMap;

	private static Dictionary<int, Dictionary<EB2DDeadReason, FUStB2DUnitDeadDispDesc>> sB2DUnitDeadDispMap;

	private static Dictionary<string, bool[,]> LevelMoveStateDict = new Dictionary<string, bool[,]>();

	private static Dictionary<int, List<FUStAIFeatureFilter>> sFeatureFilterDict;

	private static Dictionary<int, Dictionary<int, List<FUStB2DPatrolPointDesc>>> sB2DPatrolPointDesc;

	private static Dictionary<int, int> DialogueSectionToGroupDict;

	private static Dictionary<EScreenMsgType, FUStOnlineScreenMsgConfDesc> sOnlineScreenMsgConfDict;

	private static Dictionary<int, Dictionary<int, List<FUStInteractionMappingDesc>>> sMapInteractMapping;

	private static Dictionary<int, Dictionary<int, List<FUStAiInteractionMappingDesc>>> sMapAiInteractMapping;

	private static Dictionary<int, FUStCustomStateMachineDesc> sMapCustomStateMachineDescDict;

	private static Dictionary<int, FUStGuideAssetConfigDesc> sMapGuideAssetConfigDict;

	private static Dictionary<int, Dictionary<string, Dictionary<EEnhancedTriggerEvent, FUStEnhancedInputActionDesc>>> sActionNameTriggerEventDescDict;

	private static Dictionary<FName, BGUGlobalConfigInfo> sGlobalConfigInfoDict;

	private static Dictionary<string, FUStChallengeDesc> sChallengeDescDict;

	private static Dictionary<string, FUStCollectionSpawnInfoDesc> sCollectionSpawnInfoDict;

	private static Dictionary<int, Dictionary<int, List<string>>> sBossRoomCache;

	private static Dictionary<string, FUStBossRoomConfigDesc> sBossRoomDesc;

	private static Dictionary<int, List<FUStGlobalCannotDeadExtraConfigDesc>> sGlobalCannotDeadExtraCacheDict;

	private static Dictionary<string, bool> sBossCache;

	private static HashSet<int> sOnEnterLevelSequnenceWhiteListProjectileID;

	private static HashSet<int> sOnEnterLevelSequnenceWhiteListSummonID;

	private static Dictionary<string, List<FUStAkEventMarkerDesc>> sMarkerDesc;

	public static Dictionary<string, FUStMapSymbolDesc> Guid2MapSymbolDescDict = new Dictionary<string, FUStMapSymbolDesc>();

	public static Dictionary<EUnitAIDetourCrowdType, FUStAICrowdDetourLevelConfigDesc> sAICrowdDetourLevelMap = new Dictionary<EUnitAIDetourCrowdType, FUStAICrowdDetourLevelConfigDesc>();

	private static List<KeyValuePair<KeyValuePair<int, int>, KeyValuePair<AttrItemDesc, ItemRecipeDesc>>> sGlobalAlchemyList = new List<KeyValuePair<KeyValuePair<int, int>, KeyValuePair<AttrItemDesc, ItemRecipeDesc>>>();

	private static Dictionary<EBGUAttrFloat, float> sGlobalAlchemyAttrValue = new Dictionary<EBGUAttrFloat, float>();

	private static Regex BracketsReg = new Regex("{\\d+}");

	private static Regex NumReg = new Regex("\\d+");

	private const float INV100 = 0.01f;

	public static BGW_CDNGameDB.CDNRequestResult sCDNRequestResult;

	private const long sMapBeAttackedFX_IDMul_UnitResID = 1000000L;

	private const long sMapBeAttackedFX_IDMul_SkillDamageType = 100000L;

	private const long sMapBeAttackedFX_IDMul_HitItemType = 1000L;

	private const long sMapBeAttackedFX_IDMul_HitPerformType = 10L;

	private static Dictionary<long, int> sBuffDispMap;

	private static Dictionary<int, HashSet<int>> sBuff2GroupMap;

	private static Dictionary<int, HashSet<int>> sBuff2BuffDispMap;

	private const long sBuffDispMap_BuffID = 10000000000L;

	private const long sBuffDispMap_UnitResID_Caster = 100000L;

	public static Dictionary<int, Dictionary<EBuffRuleType, List<BuffRuleInfo>>> sBuffRuleMap;

	private static Dictionary<int, List<string>> FacialAnimPreloadMapping = new Dictionary<int, List<string>>();

	public static Dictionary<int, float> sElementDmgRatioMap;

	private static FUStAbnormalCommConfigDesc AbnormalCommConfigDesc;

	private static Dictionary<EPigsyStoryIAndRType, List<int>> PigsyStoryIAndRLibrary = new Dictionary<EPigsyStoryIAndRType, List<int>>();

	private static Dictionary<int, List<string>> sMapFacialResourceMap = new Dictionary<int, List<string>>();

	private static Dictionary<string, int> sMapSeqAudioLength = new Dictionary<string, int>();

	private static Dictionary<int, Dictionary<int, string>> DOPerformMapping = new Dictionary<int, Dictionary<int, string>>();

	private static Dictionary<int, int> DefeatSlowTimeSeqID2ExtendIDMap = new Dictionary<int, int>();

	private static Dictionary<int, FUStDefeatSlowTimeConfigDesc> ExtendID2SlowTimeConfigMap;

	private static Dictionary<int, FUStCameraConversionParamConfigDesc> CameraConversionParamConfigDict = new Dictionary<int, FUStCameraConversionParamConfigDesc>();

	private static Dictionary<int, Dictionary<EAbnormalStateType, FAbnormalDispSingle>> AbnormalDispAttackerMapping;

	private static Dictionary<int, Dictionary<EAbnormalStateType, FAbnormalDispSingle>> AbnormalDispVictimMapping;

	private static Dictionary<int, FAbnormalDispSingle_FreezeExt> AbnormalDispAttackerMapping_FreezeExt;

	private static Dictionary<int, FAbnormalDispSingle_FreezeExt> AbnormalDispVictimMapping_FreezeExt;

	private static Dictionary<int, Dictionary<int, float>> sMap_BossRushLimit_AttrOverride = new Dictionary<int, Dictionary<int, float>>();

	private static Dictionary<int, List<int>> sMap_BossRushLimit_Talent = new Dictionary<int, List<int>>();

	private static Dictionary<EBRLimitTargetType, Dictionary<int, List<int>>> sMap_BossRushLimit_Buff = new Dictionary<EBRLimitTargetType, Dictionary<int, List<int>>>();

	private static List<int> sMap_BossRushLimit_BattleTimeLimit = new List<int>();

	private static void LoadGamdDBFile(string ProjName)
	{
		try
		{
			GameDBRuntime.Init();
			LoadRes(ProjName);
		}
		catch (Exception ex)
		{
			BGW_LogUtil.LogError("BGW_GameDB.Init exception:" + ex.Message);
			throw ex;
		}
	}

	public static void Init(string ProjName, bool IsPrintToScreen = true)
	{
		BGW_LogUtil.IsPrintToScreen = IsPrintToScreen;
		LoadGamdDBFile(ProjName);
		InitPartRuleUnitMap();
		InitsMapAttackHitFX_ID();
		InitsMapBeAttackedFX_ID();
		InitCameraGroupUnitMap();
		InitStraightCamUnitMap();
		InitGiantCamUnitMap();
		InitDiagonalCamUnitMap();
		InitPassiveSkillMap();
		InitUnitDeadMap();
		InitSoulSkillMimicryMap();
		InitHitSceneItemPerformMap();
		InitFeatureFilterMap();
		InitBuffTickRuleBySimpleStateData();
		InitOnlineScreenMsgConfDict();
		InitInteractMappingDict();
		InitAiInteractMappingDict();
		InitCustomStateMachineDict();
		InitGuideAssetConfigDict();
		InitActionNameTriggerEventIdDict();
		InitGlobalConfigDesc();
		InitsChallengeDescDict();
		InitCollectionSpawnInfoDict();
		InitBossRoomDict();
		InitGlobalCannotDeadExtraCacheDict();
		InitBuffDispMap();
		InitBuffRuleMap();
		InitElementDmgRatioLevelMapping();
		InitAbnormalCommConfig();
		InitBeAttackedDispInfo();
		InitMapSymbolDescInfo();
		InitGlobalAlchemyList();
		InitPigsyStoryIAndRLibrary();
		InitDOPerformMapping();
		InitDefeatSlowTimeConfig();
		InitCameraConversionParamConfig();
		InitPotentialEnergyMap();
		InitBossDict();
		InitAbnormalDispMap();
		InitAICrowdDetourlevelConfigDict();
		InitBeAttackedStiffLevelMapping();
		InitDialogue_FacialAnimPreloadMap();
		InitLevelSequenceClearBattleItemConfig();
		InitAkMarkerDesc();
		InitFacialResourceMap();
		InitSeqAudioJumpMap();
		InitBossRushAbilityLimitMap();
	}

	public static void LoadRes(string ProjName)
	{
		BG_ProtobufDataLoader.Get().LoadProjectDataSettings(ProjName);
		BG_ProtobufDataAPI<FUStInteractiveUnitCommDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStInteractionMappingDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStAiInteractionMappingDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStBuffDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStChargeSkillSDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStDropItemDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStHitVEffectDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStQTEDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStSummonCommDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStPhysicalHitBoneRuleDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStRebirthPointDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStStraightCamDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStMultiPointLockCameraConfigDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStDiagonalCamDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStGiantLockCameraDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStUnitCollisionHitMoveDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStBuffDispDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStBuffLayerDispDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStExAnimDataDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStUnitCommDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStUnitBattleInfoExtendDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStUnitPassiveSkillInfoExtendDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStUnitEnvMaskConfigDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStSkillAIDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStSkillEffectDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStSkillSDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStSkillSMappingDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStEnvironmentSwitchDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStBulletSwitchDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStUnitAIDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStUnitTransCommDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStRollSkillDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStUnitDropDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStNianhuiNameListDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStNianhuiAwardDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStBeAttackedInfoDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStBeAttackedDispInfoDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStScarInfoDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStPlayerSkillCtrlDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStOverlyingSkillSDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStBuffGroupDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStBuffRuleDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStMandatoryAITaskDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStAttackHitAudioInfoDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStPlayerCameraDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStPlayerTransAttrDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStAttackHitFXMapDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStBeAttackedFXMapDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStPlayerCommDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStUnitDeadDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStUnitDeadSwitchToPhysicDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStUnitDeadOldDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStHitSceneItemPerformDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStUnitFootstepDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStEQSSettingDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStPassiveSkillDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStAISkillBasicActionDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStUnitAudioBankMapDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStAISkillTagsDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStAIThinkDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStAIActionDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStAIFeatureDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStProjectileCommDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStProjectileDispDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStProjectileMoveDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStBulletExpandDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStMagicFieldExpandDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStBulletWindFieldExpandDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStUnitSpecialMoveDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStUnitLevelUpDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStPartRuleInfoDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStAttackerHitFXMappingDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStAttackerHitAudioEventMappingDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStBuffTickRuleBySimpleStateDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStUnitPhysicalAnimationDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStMovieSequenceDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStSuitDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStCameraGroupDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStFixFunctionDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStGroupAISDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStDialogueDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStDialogueIDMappingDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStUIWordDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStTalentDisplayDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStTalentLvUpCfgDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStAiConversationEventDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStAiConversationContentDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStOnlineScreenMsgConfDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStRichTextIconDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStIronBodyConfigDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStImmobilizeSkillConfigDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStSealingSpellSkillConfigDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStTransQiTianDaShengConfigDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStPhantomRushSkillConfigDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStPlayerInputSkillMappingDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStTaskStageDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStTaskLineDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStSuperArmorLevelDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStCollectionSpawnInfoDesc>.Get().LoadData(WithOutId: true);
		BG_ProtobufDataAPI<FUStCollectionSpawnGroupDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStCollectionEventProbabilityDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStCustomStateMachineDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStGuideAssetConfigDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStNPCBaseInfoDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStEnhancedInputActionDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStSkillDamageExpandDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStPotentialEnergyConfigDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStGlobalConfigDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStTeamRelationConfigDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStAiConversationGroupDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStAssociationUnitInfoSDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStUnitIntelligenceInfoDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStCBGTemplateDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStTamerStrategyConfigDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStTROStrategyConfigDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStSummonCopySkillDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStUnitChangeMaterialByAttrDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStCCGCastSkillMappingRuleDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStWeakPerformConfigDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStFollowPartnerConfigDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStChallengeDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStBossRoomConfigDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStGlobalCannotDeadExtraConfigDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStEnvironmentSurfaceEffectDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStSweepCheckDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStAudioExtendDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStBuffIconDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStPartHitExpandDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStDetonateConfigDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStAttachedNiagaraByHitDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStAbnormalStateUIBlackListDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStElementDmgRatioLevelDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStAbnormalCommConfigDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStStreamingLevelStateDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStMapSymbolDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStAttrCopyConfigDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStPlayerTransUnitConfDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStLifeSavingHairConfigDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStPigsyStoryLibraryDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStPigsyStoryIAndRLibraryDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStGuideGroupDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStGuideNodeDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStDynamicObstaclePerformanceDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStDefeatSlowTimeConfigDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStBuffDispGroupDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStSoulSkillMimicryDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStCameraConversionParamConfigDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStEffectiveHitProjectileEffectDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStTransActiveStateDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStMovementOptStrategyConfigDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStAbnormalDispAttackerMapDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStAbnormalDispVictimMapDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStAICrowdDetourLevelConfigDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStRebirthAreaDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStLevelSequenceClearBattleItemConfigDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStBeAttackedStiffLevelMappingDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStAkEventMarkerDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStSeqAudioJumpLengthDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStDeadSeqUnitConfigDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStBossRushConfigDesc>.Get().LoadData();
		BG_ProtobufDataAPI<FUStBossRushAbilityLimitDesc>.Get().LoadData();
	}

	private static void InitsMapAttackHitFX_ID()
	{
		sMapAttackHitFX_ID = new Dictionary<long, int>();
		foreach (KeyValuePair<int, FUStAttackHitFXMapDesc> item in GetAllAttackHitFXMapDesc())
		{
			long key = (int)item.Value.HitPerformFXEventType + (int)item.Value.SkillDamageType * 100 + item.Value.FXWeight * 1000 + item.Value.UnitResID * 10000;
			if (!sMapAttackHitFX_ID.ContainsKey(key))
			{
				sMapAttackHitFX_ID.Add(key, item.Key);
			}
		}
	}

	private static void InitsMapBeAttackedFX_ID()
	{
		sMapBeAttackedFX_ID = new Dictionary<long, int>();
		foreach (KeyValuePair<int, FUStBeAttackedFXMapDesc> item in GetAllBeAttackedFXMapDesc())
		{
			long key = (long)item.Value.UnitResID * 1000000L + (long)(int)item.Value.SkillDamageType * 100000L + (long)(int)item.Value.HitItemFXType * 1000L + (long)(int)item.Value.HitPerformFXEventType * 10L + item.Value.FXWeight;
			if (!sMapBeAttackedFX_ID.ContainsKey(key))
			{
				sMapBeAttackedFX_ID.Add(key, item.Key);
			}
		}
	}

	private static void InitPartRuleUnitMap()
	{
		sMapPartRuleUnit = new Dictionary<int, Dictionary<int, Dictionary<int, int>>>();
		foreach (KeyValuePair<int, FUStPartRuleInfoDesc> item in GetAllPartRuleInfoDesc())
		{
			int key = item.Key;
			FUStPartRuleInfoDesc value = item.Value;
			int key2 = value.PartRuleID / 100;
			if (sMapPartRuleUnit.ContainsKey(key2))
			{
				if (sMapPartRuleUnit[key2].ContainsKey(value.PartRuleID))
				{
					sMapPartRuleUnit[key2][value.PartRuleID].Add(value.PartID, key);
					continue;
				}
				Dictionary<int, int> value2 = new Dictionary<int, int> { { value.PartID, key } };
				sMapPartRuleUnit[key2].Add(value.PartRuleID, value2);
			}
			else
			{
				Dictionary<int, Dictionary<int, int>> dictionary = new Dictionary<int, Dictionary<int, int>>();
				Dictionary<int, int> value3 = new Dictionary<int, int> { { value.PartID, key } };
				dictionary.Add(value.PartRuleID, value3);
				sMapPartRuleUnit.Add(key2, dictionary);
			}
		}
	}

	private static void InitCameraGroupUnitMap()
	{
		sMapCameraGroupGroupUnit = new Dictionary<int, Dictionary<int, FUStCameraGroupDesc>>();
		foreach (KeyValuePair<int, FUStCameraGroupDesc> item in GetAllCameraGroupDesc())
		{
			_ = item.Key;
			FUStCameraGroupDesc value = item.Value;
			if (sMapCameraGroupGroupUnit.TryGetValue(value.CameraGroupID, out var value2))
			{
				try
				{
					value2.Add(value.PlayerResID, value);
				}
				catch
				{
					BGW_LogUtil.LogError("InitCameraGroupUnitMap duplicate ID" + value.PlayerResID + " " + value.CameraGroupID);
				}
			}
			else
			{
				Dictionary<int, FUStCameraGroupDesc> dictionary = new Dictionary<int, FUStCameraGroupDesc>();
				dictionary.Add(value.PlayerResID, value);
				sMapCameraGroupGroupUnit.Add(value.CameraGroupID, dictionary);
			}
		}
	}

	private static void InitStraightCamUnitMap()
	{
		sMapStraightCamUnit = new Dictionary<int, Dictionary<int, FUStStraightCamDesc>>();
		foreach (KeyValuePair<int, FUStStraightCamDesc> item in GetAllStraightCamDesc())
		{
			_ = item.Key;
			FUStStraightCamDesc value = item.Value;
			if (sMapStraightCamUnit.TryGetValue(value.CamID, out var value2))
			{
				value2.ContainsKey(value.PlayerUnitResID);
				value2[value.PlayerUnitResID] = value;
			}
			else
			{
				Dictionary<int, FUStStraightCamDesc> dictionary = new Dictionary<int, FUStStraightCamDesc>();
				dictionary.Add(value.PlayerUnitResID, value);
				sMapStraightCamUnit.Add(value.CamID, dictionary);
			}
		}
		sMapMultiPointLockCamUnit = new Dictionary<int, Dictionary<string, FUStMultiPointLockCameraConfigDesc>>();
		sMapMultiPointLockOfUnit = new Dictionary<int, List<string>>();
		foreach (KeyValuePair<int, FUStMultiPointLockCameraConfigDesc> allMultiPointDesc in GetAllMultiPointDescs())
		{
			FUStMultiPointLockCameraConfigDesc value3 = allMultiPointDesc.Value;
			int lockGroupID = value3.LockGroupID;
			string lockSocket = value3.LockSocket;
			if (!sMapMultiPointLockCamUnit.ContainsKey(value3.LockGroupID))
			{
				sMapMultiPointLockCamUnit.Add(lockGroupID, new Dictionary<string, FUStMultiPointLockCameraConfigDesc>());
			}
			Dictionary<string, FUStMultiPointLockCameraConfigDesc> dictionary2 = sMapMultiPointLockCamUnit[lockGroupID];
			if (!dictionary2.ContainsKey(value3.LockSocket))
			{
				dictionary2.Add(lockSocket, value3);
			}
			int key = value3.LockGroupID / 100;
			if (!sMapMultiPointLockOfUnit.ContainsKey(key))
			{
				sMapMultiPointLockOfUnit.Add(key, new List<string>());
			}
			if (!sMapMultiPointLockOfUnit[key].Contains(lockSocket))
			{
				sMapMultiPointLockOfUnit[key].Add(lockSocket);
			}
		}
	}

	private static void InitGiantCamUnitMap()
	{
		sMapGiantCamUnit = new Dictionary<int, Dictionary<int, FUStGiantLockCameraDesc>>();
		foreach (KeyValuePair<int, FUStGiantLockCameraDesc> item in GetAllGiantCamDesc())
		{
			_ = item.Key;
			FUStGiantLockCameraDesc value = item.Value;
			if (sMapGiantCamUnit.TryGetValue(value.CamID, out var value2))
			{
				value2.ContainsKey(value.PlayerUnitResID);
				value2[value.PlayerUnitResID] = value;
			}
			else
			{
				Dictionary<int, FUStGiantLockCameraDesc> dictionary = new Dictionary<int, FUStGiantLockCameraDesc>();
				dictionary.Add(value.PlayerUnitResID, value);
				sMapGiantCamUnit.Add(value.CamID, dictionary);
			}
		}
	}

	private static void InitOnlineScreenMsgConfDict()
	{
		sOnlineScreenMsgConfDict = new Dictionary<EScreenMsgType, FUStOnlineScreenMsgConfDesc>();
		foreach (KeyValuePair<int, FUStOnlineScreenMsgConfDesc> item in GetAllOnlineScreenMsgConfDesc())
		{
			if (!sOnlineScreenMsgConfDict.ContainsKey(item.Value.ScreenMsgType))
			{
				sOnlineScreenMsgConfDict.Add(item.Value.ScreenMsgType, item.Value);
			}
		}
	}

	private static void InitDiagonalCamUnitMap()
	{
		sMapDiagonalCamUnit = new Dictionary<int, Dictionary<int, FUStDiagonalCamDesc>>();
		foreach (KeyValuePair<int, FUStDiagonalCamDesc> item in GetAllDiagonalCamDesc())
		{
			_ = item.Key;
			FUStDiagonalCamDesc value = item.Value;
			if (sMapDiagonalCamUnit.TryGetValue(value.CamID, out var value2))
			{
				if (value2.ContainsKey(value.PlayerUnitResID))
				{
					BGW_LogUtil.LogError($"DMC Lock Camera Find Repeated ID, CameraID: {value.CamID}, PlayerResID:{value.PlayerUnitResID}");
				}
				value2[value.PlayerUnitResID] = value;
			}
			else
			{
				Dictionary<int, FUStDiagonalCamDesc> dictionary = new Dictionary<int, FUStDiagonalCamDesc>();
				dictionary.Add(value.PlayerUnitResID, value);
				sMapDiagonalCamUnit.Add(value.CamID, dictionary);
			}
		}
	}

	private static void InitHitSceneItemPerformMap()
	{
		sMapHitSceneItemPerformUnitResIDMapUnit = new Dictionary<ESceneItemSurfaceType, Dictionary<ESkillDamageType, Dictionary<int, int>>>();
		Dictionary<int, FUStHitSceneItemPerformDesc> allHitSceneItemPerformDesc = GetAllHitSceneItemPerformDesc();
		foreach (KeyValuePair<int, FUStHitSceneItemPerformDesc> item in allHitSceneItemPerformDesc)
		{
			if (item.Value.SkillEffectID != 0)
			{
				continue;
			}
			_ = item.Key;
			FUStHitSceneItemPerformDesc value = item.Value;
			if (sMapHitSceneItemPerformUnitResIDMapUnit.ContainsKey(value.SceneItemSurfaceType))
			{
				if (sMapHitSceneItemPerformUnitResIDMapUnit[value.SceneItemSurfaceType].ContainsKey(value.SkillDamageType))
				{
					if (!sMapHitSceneItemPerformUnitResIDMapUnit[value.SceneItemSurfaceType][value.SkillDamageType].ContainsKey(value.UnitResID))
					{
						sMapHitSceneItemPerformUnitResIDMapUnit[value.SceneItemSurfaceType][value.SkillDamageType].Add(value.UnitResID, value.ID);
					}
				}
				else
				{
					Dictionary<int, int> dictionary = new Dictionary<int, int>();
					dictionary.Add(value.UnitResID, value.ID);
					sMapHitSceneItemPerformUnitResIDMapUnit[value.SceneItemSurfaceType].Add(value.SkillDamageType, dictionary);
				}
			}
			else
			{
				Dictionary<int, int> dictionary2 = new Dictionary<int, int>();
				dictionary2.Add(value.UnitResID, value.ID);
				Dictionary<ESkillDamageType, Dictionary<int, int>> dictionary3 = new Dictionary<ESkillDamageType, Dictionary<int, int>>();
				dictionary3.Add(value.SkillDamageType, dictionary2);
				sMapHitSceneItemPerformUnitResIDMapUnit.Add(value.SceneItemSurfaceType, dictionary3);
			}
		}
		sMapHitSceneItemPerformSkillEffectIDMapUnit = new Dictionary<ESceneItemSurfaceType, Dictionary<int, Dictionary<int, int>>>();
		foreach (KeyValuePair<int, FUStHitSceneItemPerformDesc> item2 in allHitSceneItemPerformDesc)
		{
			_ = item2.Key;
			FUStHitSceneItemPerformDesc value2 = item2.Value;
			if (value2.SkillEffectID == 0)
			{
				continue;
			}
			if (sMapHitSceneItemPerformSkillEffectIDMapUnit.ContainsKey(value2.SceneItemSurfaceType))
			{
				if (!sMapHitSceneItemPerformSkillEffectIDMapUnit[value2.SceneItemSurfaceType].ContainsKey(value2.SkillEffectID))
				{
					sMapHitSceneItemPerformSkillEffectIDMapUnit[value2.SceneItemSurfaceType].Add(value2.SkillEffectID, new Dictionary<int, int>());
				}
				if (!sMapHitSceneItemPerformSkillEffectIDMapUnit[value2.SceneItemSurfaceType][value2.SkillEffectID].ContainsKey(value2.UnitResID))
				{
					sMapHitSceneItemPerformSkillEffectIDMapUnit[value2.SceneItemSurfaceType][value2.SkillEffectID].Add(value2.UnitResID, value2.ID);
				}
			}
			else
			{
				Dictionary<int, Dictionary<int, int>> dictionary4 = new Dictionary<int, Dictionary<int, int>>();
				Dictionary<int, int> dictionary5 = new Dictionary<int, int>();
				dictionary5.Add(value2.UnitResID, value2.ID);
				dictionary4.Add(value2.SkillEffectID, dictionary5);
				sMapHitSceneItemPerformSkillEffectIDMapUnit.Add(value2.SceneItemSurfaceType, dictionary4);
			}
		}
	}

	private static void InitB2DUnitDeadDispMap()
	{
		sB2DUnitDeadDispMap = new Dictionary<int, Dictionary<EB2DDeadReason, FUStB2DUnitDeadDispDesc>>();
		foreach (KeyValuePair<int, FUStB2DUnitDeadDispDesc> item in BG_ProtobufDataAPI<FUStB2DUnitDeadDispDesc>.Get().GetAll())
		{
			if (!sB2DUnitDeadDispMap.TryGetValue(item.Value.Id / 100, out var value))
			{
				value = new Dictionary<EB2DDeadReason, FUStB2DUnitDeadDispDesc>();
				sB2DUnitDeadDispMap[item.Value.Id / 100] = value;
			}
			value[item.Value.DeadReason] = item.Value;
		}
	}

	private static void InitB2DUnitSpawnDescMap()
	{
		sMapB2DUnitSpawnStage = new Dictionary<int, List<FUStB2DUnitSpawnDesc>>();
		foreach (KeyValuePair<int, FUStB2DUnitSpawnDesc> item in BG_ProtobufDataAPI<FUStB2DUnitSpawnDesc>.Get().GetAll())
		{
			_ = item.Key;
			FUStB2DUnitSpawnDesc value = item.Value;
			if (sMapB2DUnitSpawnStage.ContainsKey(value.StageId))
			{
				sMapB2DUnitSpawnStage[value.StageId].Add(value);
				continue;
			}
			List<FUStB2DUnitSpawnDesc> list = new List<FUStB2DUnitSpawnDesc>();
			list.Add(value);
			sMapB2DUnitSpawnStage.Add(value.StageId, list);
		}
	}

	private static void InitFeatureFilterMap()
	{
		sFeatureFilterDict = new Dictionary<int, List<FUStAIFeatureFilter>>();
		foreach (KeyValuePair<int, FUStAIFeatureDesc> item in GetAllAIFeatureDesc())
		{
			sFeatureFilterDict.Add(item.Key, GetFeatureFilterList(item.Value));
		}
	}

	private static List<FUStAIFeatureFilter> GetFeatureFilterList(FUStAIFeatureDesc FeatureDesc)
	{
		List<FUStAIFeatureFilter> list = new List<FUStAIFeatureFilter>();
		foreach (FUStAIFeatureFilter featureFilter in FeatureDesc.FeatureFilters)
		{
			if (featureFilter.FilterType == EFilterType.FeatureDesc)
			{
				foreach (int filterInput in featureFilter.FilterInputs)
				{
					FUStAIFeatureDesc aIFeatureDesc = GetAIFeatureDesc(filterInput);
					list.AddRange(GetFeatureFilterList(aIFeatureDesc));
				}
			}
			else
			{
				list.Add(featureFilter);
			}
		}
		return list;
	}

	private static void InitSkillEffectMap()
	{
		sSkillEffectMap = BG_ProtobufDataAPI<FUStB2DSkillStage>.Get().InitMontageEffectData();
		sComboSkillMap = BG_ProtobufDataAPI<FUStB2DComboSkill>.Get().InitComboSkillData();
	}

	private static void InitBuffTickRuleBySimpleStateData()
	{
		Dictionary<int, FUStBuffTickRuleBySimpleStateDesc> allBuffTickRuleBySimpleStateDesc = GetAllBuffTickRuleBySimpleStateDesc();
		sMapBuffTickRuleBySS_ID = new Dictionary<int, List<int>>();
		foreach (KeyValuePair<int, FUStBuffTickRuleBySimpleStateDesc> item in allBuffTickRuleBySimpleStateDesc)
		{
			List<int> list = item.Value.BuffIDList.ToList();
			List<int> list2 = new List<int>();
			if (list == null)
			{
				continue;
			}
			for (int i = 0; i < list.Count; i++)
			{
				if (list[i] < 0)
				{
					FUStBuffGroupDesc buffGroupDesc = GetBuffGroupDesc(-list[i]);
					if (buffGroupDesc == null)
					{
						continue;
					}
					foreach (int buffID in buffGroupDesc.BuffIDList)
					{
						list2.Add(buffID);
					}
				}
				else
				{
					list2.Add(list[i]);
				}
			}
			sMapBuffTickRuleBySS_ID.Add(item.Key, list2);
		}
	}

	private static void InitPassiveSkillMap()
	{
		sMapPassiveSkill = new Dictionary<int, Dictionary<int, FUStPassiveSkillDesc>>();
		foreach (KeyValuePair<int, FUStPassiveSkillDesc> item in GetAllPassiveSkillDesc())
		{
			FUStPassiveSkillDesc value = item.Value;
			if (value != null)
			{
				int passiveSkillID = value.PassiveSkillID;
				int passiveSkillMappingIndexID = value.PassiveSkillMappingIndexID;
				if (sMapPassiveSkill.TryGetValue(passiveSkillID, out var _))
				{
					sMapPassiveSkill[passiveSkillID].Add(passiveSkillMappingIndexID, value);
					continue;
				}
				Dictionary<int, FUStPassiveSkillDesc> dictionary = new Dictionary<int, FUStPassiveSkillDesc>();
				dictionary.Add(passiveSkillMappingIndexID, value);
				sMapPassiveSkill.Add(passiveSkillID, dictionary);
			}
		}
	}

	private static void InitUnitDeadMap()
	{
		sMapUnitDead = new Dictionary<int, Dictionary<int, FUStUnitDeadDesc>>();
		foreach (KeyValuePair<int, FUStUnitDeadDesc> item in GetAllUnitDeadDesc())
		{
			int key = item.Key;
			FUStUnitDeadDesc value = item.Value;
			int unitResID = value.UnitResID;
			if (sMapUnitDead.TryGetValue(unitResID, out var value2))
			{
				if (!value2.TryGetValue(key, out var _))
				{
					sMapUnitDead[unitResID].Add(key, value);
				}
			}
			else
			{
				Dictionary<int, FUStUnitDeadDesc> dictionary = new Dictionary<int, FUStUnitDeadDesc>();
				dictionary.Add(key, value);
				sMapUnitDead.Add(unitResID, dictionary);
			}
		}
	}

	private static void InitSoulSkillMimicryMap()
	{
		sMapSoulSkillMimicry = new Dictionary<int, Dictionary<int, FUStSoulSkillMimicryDesc>>();
		foreach (KeyValuePair<int, FUStSoulSkillMimicryDesc> item in GetAllSoulSkillMimicryDesc())
		{
			FUStSoulSkillMimicryDesc value = item.Value;
			int soulSkillID = value.SoulSkillID;
			int levelID = value.LevelID;
			if (sMapSoulSkillMimicry.TryGetValue(soulSkillID, out var value2))
			{
				if (!value2.TryGetValue(levelID, out var _))
				{
					sMapSoulSkillMimicry[soulSkillID].Add(levelID, value);
				}
			}
			else
			{
				Dictionary<int, FUStSoulSkillMimicryDesc> dictionary = new Dictionary<int, FUStSoulSkillMimicryDesc>();
				dictionary.Add(levelID, value);
				sMapSoulSkillMimicry.Add(soulSkillID, dictionary);
			}
		}
	}

	public static FUStEnhancedInputActionDesc GetDescByInputActionNameAndTriggerEvent(int ResID, string ActionName, ETriggerEvent TriggerEvent)
	{
		Dictionary<string, Dictionary<EEnhancedTriggerEvent, FUStEnhancedInputActionDesc>> value = new Dictionary<string, Dictionary<EEnhancedTriggerEvent, FUStEnhancedInputActionDesc>>();
		if (!sActionNameTriggerEventDescDict.TryGetValue(ResID, out value))
		{
			sActionNameTriggerEventDescDict.TryGetValue(0, out value);
		}
		if (value != null && value.Count > 0 && value.TryGetValue(ActionName, out var value2) && value2.TryGetValue((EEnhancedTriggerEvent)TriggerEvent, out var value3))
		{
			return value3;
		}
		return null;
	}

	public static List<FUStB2DSkillStage> GetB2DSkillEffectMap(int SkillID)
	{
		if (sSkillEffectMap.ContainsKey(SkillID))
		{
			return sSkillEffectMap[SkillID];
		}
		return new List<FUStB2DSkillStage>();
	}

	public static List<FUStB2DComboSkill> GetB2DComboSkillMap(int SkillID)
	{
		if (sComboSkillMap.ContainsKey(SkillID))
		{
			return sComboSkillMap[SkillID];
		}
		return new List<FUStB2DComboSkill>();
	}

	public static bool DoesBuffBelongToAnyBuffGroup(int BuffID)
	{
		return sMapBuffGroupInfo.ContainsKey(BuffID);
	}

	public static bool DoesBuffBelongToBuffGroup(int BuffID, int BuffGroupID)
	{
		return GetBuffGroupDesc(BuffGroupID).BuffIDList.Contains(BuffID);
	}

	public static FUStHitSceneItemPerformDesc GetHitSceneItemPerformDesc(ESceneItemSurfaceType SceneItemSurfaceType, ESkillDamageType SkillDamageType, int UnitResID, int SkillEffectID)
	{
		int num = -1;
		if (SkillDamageType == ESkillDamageType.NoneEffectAtk)
		{
			SkillDamageType = ESkillDamageType.BluntAtk;
		}
		if (sMapHitSceneItemPerformSkillEffectIDMapUnit.ContainsKey(SceneItemSurfaceType) && sMapHitSceneItemPerformSkillEffectIDMapUnit[SceneItemSurfaceType].TryGetValue(SkillEffectID, out var value))
		{
			if (value.TryGetValue(UnitResID, out var value2))
			{
				num = value2;
			}
			else if (value.TryGetValue(0, out value2))
			{
				num = value2;
			}
		}
		if (num == -1 && sMapHitSceneItemPerformUnitResIDMapUnit.ContainsKey(SceneItemSurfaceType) && sMapHitSceneItemPerformUnitResIDMapUnit[SceneItemSurfaceType].ContainsKey(SkillDamageType))
		{
			if (sMapHitSceneItemPerformUnitResIDMapUnit[SceneItemSurfaceType][SkillDamageType].ContainsKey(UnitResID))
			{
				num = sMapHitSceneItemPerformUnitResIDMapUnit[SceneItemSurfaceType][SkillDamageType][UnitResID];
			}
			else if (sMapHitSceneItemPerformUnitResIDMapUnit[SceneItemSurfaceType][SkillDamageType].ContainsKey(0))
			{
				num = sMapHitSceneItemPerformUnitResIDMapUnit[SceneItemSurfaceType][SkillDamageType][0];
			}
		}
		return BG_ProtobufDataAPI<FUStHitSceneItemPerformDesc>.Get().FindByID(num);
	}

	public static List<int> GetPartRuleInfoListByRuleID(int UnitResID, int PartRuleID)
	{
		List<int> list = new List<int>();
		if (sMapPartRuleUnit.ContainsKey(UnitResID))
		{
			foreach (KeyValuePair<int, Dictionary<int, int>> item in sMapPartRuleUnit[UnitResID])
			{
				if (item.Key != PartRuleID)
				{
					continue;
				}
				foreach (KeyValuePair<int, int> item2 in item.Value)
				{
					list.Add(item2.Value);
				}
			}
		}
		return list;
	}

	public static List<int> GetPartRuleInfoListByResID(int UnitResID)
	{
		List<int> list = new List<int>();
		if (sMapPartRuleUnit.ContainsKey(UnitResID))
		{
			foreach (KeyValuePair<int, Dictionary<int, int>> item in sMapPartRuleUnit[UnitResID])
			{
				foreach (KeyValuePair<int, int> item2 in item.Value)
				{
					list.Add(item2.Value);
				}
			}
		}
		return list;
	}

	public static FUStAttackHitFXMapDesc GetAttackHitFXMapDescByResID(int ResID)
	{
		return BG_ProtobufDataAPI<FUStAttackHitFXMapDesc>.Get().FindByID(ResID);
	}

	public static FUStBeAttackedFXMapDesc GetBeAttackedFXMapDesc(bool bIsPlayer, ESkillDamageType SkillDamageType, EHitPerformFXEventType HitPerformType, EHitItemFXType HitItemType, int UnitResID, int FXWeight)
	{
		if (SkillDamageType == ESkillDamageType.NoneEffectAtk)
		{
			return null;
		}
		if (GetBeAttackedFXDescID(bIsPlayer, UnitResID, SkillDamageType, HitPerformType, HitItemType, FXWeight, out var DescID))
		{
			return GetBeAttackedFXMapDescByID(DescID);
		}
		return null;
	}

	private static bool GetBeAttackedFXDescID(bool bIsPlayer, int UnitResID, ESkillDamageType SkillDamageType, EHitPerformFXEventType hitPerformType, EHitItemFXType HitItemType, int FXWeight, out int DescID)
	{
		return GetBeAttackedFXDescID_HitItemType(bIsPlayer, UnitResID, SkillDamageType, hitPerformType, HitItemType, FXWeight, out DescID);
	}

	private static bool GetBeAttackedFXDescID_HitItemType(bool bIsPlayer, int UnitResID, ESkillDamageType SkillDamageType, EHitPerformFXEventType hitPerformType, EHitItemFXType HitItemType, int FXWeight, out int DescID)
	{
		bool beAttackedFXDescID_UnitResID = GetBeAttackedFXDescID_UnitResID((long)(int)HitItemType * 1000L, bIsPlayer, UnitResID, SkillDamageType, hitPerformType, HitItemType, FXWeight, out DescID);
		if (!beAttackedFXDescID_UnitResID)
		{
			beAttackedFXDescID_UnitResID = GetBeAttackedFXDescID_UnitResID(1000L, bIsPlayer, UnitResID, SkillDamageType, hitPerformType, HitItemType, FXWeight, out DescID);
		}
		return beAttackedFXDescID_UnitResID;
	}

	private static bool GetBeAttackedFXDescID_UnitResID(long FrontID, bool bIsPlayer, int UnitResID, ESkillDamageType SkillDamageType, EHitPerformFXEventType hitPerformType, EHitItemFXType HitItemType, int FXWeight, out int DescID)
	{
		long frontID = (long)UnitResID * 1000000L + FrontID;
		bool beAttackedFXDescID_SkillDamageType = GetBeAttackedFXDescID_SkillDamageType(frontID, SkillDamageType, hitPerformType, FXWeight, out DescID);
		if (!beAttackedFXDescID_SkillDamageType)
		{
			frontID = ((!bIsPlayer || HitItemType != EHitItemFXType.NormalBody) ? FrontID : (1000000 + FrontID));
			beAttackedFXDescID_SkillDamageType = GetBeAttackedFXDescID_SkillDamageType(frontID, SkillDamageType, hitPerformType, FXWeight, out DescID);
		}
		return beAttackedFXDescID_SkillDamageType;
	}

	private static bool GetBeAttackedFXDescID_SkillDamageType(long FrontID, ESkillDamageType SkillDamageType, EHitPerformFXEventType hitPerformType, int FXWeight, out int DescID)
	{
		bool beAttackedFXDescID_HitPerformType = GetBeAttackedFXDescID_HitPerformType(FrontID + (long)(int)SkillDamageType * 100000L, hitPerformType, FXWeight, out DescID);
		if (!beAttackedFXDescID_HitPerformType)
		{
			beAttackedFXDescID_HitPerformType = GetBeAttackedFXDescID_HitPerformType(FrontID + 100000, hitPerformType, FXWeight, out DescID);
		}
		return beAttackedFXDescID_HitPerformType;
	}

	private static bool GetBeAttackedFXDescID_HitPerformType(long FrontID, EHitPerformFXEventType hitPerformType, int FXWeight, out int DescID)
	{
		bool beAttackedFXDescID_FXWeight = GetBeAttackedFXDescID_FXWeight(FrontID + (long)(int)hitPerformType * 10L, FXWeight, out DescID);
		if (!beAttackedFXDescID_FXWeight)
		{
			beAttackedFXDescID_FXWeight = GetBeAttackedFXDescID_FXWeight(FrontID + 10, FXWeight, out DescID);
		}
		return beAttackedFXDescID_FXWeight;
	}

	private static bool GetBeAttackedFXDescID_FXWeight(long FrontID, int FXWeight, out int DescID)
	{
		long key = FrontID + FXWeight;
		bool flag = sMapBeAttackedFX_ID.TryGetValue(key, out DescID);
		if (!flag)
		{
			key = FrontID;
			flag = sMapBeAttackedFX_ID.TryGetValue(key, out DescID);
		}
		return flag;
	}

	public static FUStAttackHitFXMapDesc GetAttackHitFXMapDesc(int UnitResID, int FXWeight, ESkillDamageType SkillDamageType, EHitPerformFXEventType HitPerformType)
	{
		if (SkillDamageType == ESkillDamageType.NoneEffectAtk)
		{
			return null;
		}
		if (GetAttackHitFXDescID(UnitResID, FXWeight, SkillDamageType, HitPerformType, out var DescID))
		{
			return GetAttackHitFXMapDescByID(DescID);
		}
		return null;
	}

	private static bool GetAttackHitFXDescID(int UnitResID, int FXWeight, ESkillDamageType SkillDamageType, EHitPerformFXEventType hitPerformType, out int DescID)
	{
		return GetAttackHitFXDescID_UnitResID(UnitResID, FXWeight, SkillDamageType, hitPerformType, out DescID);
	}

	private static bool GetAttackHitFXDescID_UnitResID(int UnitResID, int FXWeight, ESkillDamageType SkillDamageType, EHitPerformFXEventType hitPerformType, out int DescID)
	{
		bool attackHitFXDescID_FXWeight = GetAttackHitFXDescID_FXWeight(UnitResID * 10000, FXWeight, SkillDamageType, hitPerformType, out DescID);
		if (!attackHitFXDescID_FXWeight)
		{
			attackHitFXDescID_FXWeight = GetAttackHitFXDescID_FXWeight(0L, FXWeight, SkillDamageType, hitPerformType, out DescID);
		}
		return attackHitFXDescID_FXWeight;
	}

	private static bool GetAttackHitFXDescID_FXWeight(long FrontID, int FXWeight, ESkillDamageType SkillDamageType, EHitPerformFXEventType hitPerformType, out int DescID)
	{
		bool attackHitFXDescID_SkillDamageType = GetAttackHitFXDescID_SkillDamageType(FrontID + FXWeight * 1000, SkillDamageType, hitPerformType, out DescID);
		if (!attackHitFXDescID_SkillDamageType)
		{
			attackHitFXDescID_SkillDamageType = GetAttackHitFXDescID_SkillDamageType(FrontID, SkillDamageType, hitPerformType, out DescID);
		}
		return attackHitFXDescID_SkillDamageType;
	}

	private static bool GetAttackHitFXDescID_SkillDamageType(long FrontID, ESkillDamageType SkillDamageType, EHitPerformFXEventType hitPerformType, out int DescID)
	{
		bool attackHitFXDescID_HitPerformType = GetAttackHitFXDescID_HitPerformType(FrontID + (int)SkillDamageType * 100, hitPerformType, out DescID);
		if (!attackHitFXDescID_HitPerformType)
		{
			attackHitFXDescID_HitPerformType = GetAttackHitFXDescID_HitPerformType(FrontID + 100, hitPerformType, out DescID);
		}
		return attackHitFXDescID_HitPerformType;
	}

	private static bool GetAttackHitFXDescID_HitPerformType(long FrontID, EHitPerformFXEventType hitPerformType, out int DescID)
	{
		long key = FrontID + (int)hitPerformType;
		bool flag = sMapAttackHitFX_ID.TryGetValue(key, out DescID);
		if (!flag)
		{
			key = FrontID + 1;
			flag = sMapAttackHitFX_ID.TryGetValue(key, out DescID);
		}
		return flag;
	}

	public static FUStHitSceneItemPerformDesc GetHitSceneItemPerformDescByID(int ID)
	{
		return BG_ProtobufDataAPI<FUStHitSceneItemPerformDesc>.Get().FindByID(ID);
	}

	public static FUStBeAttackedFXMapDesc GetBeAttackedFXMapDescByID(int ID)
	{
		return BG_ProtobufDataAPI<FUStBeAttackedFXMapDesc>.Get().FindByID(ID);
	}

	public static FUStAttackHitFXMapDesc GetAttackHitFXMapDescByID(int ID)
	{
		return BG_ProtobufDataAPI<FUStAttackHitFXMapDesc>.Get().FindByID(ID);
	}

	public static FUStB2DBuffDispDesc GetB2DBuffDispDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStB2DBuffDispDesc>.Get().FindByID(ResID);
	}

	public static FUStB2DPatrolPointDesc GetB2DPatrolPointDesc(int Id)
	{
		return BG_ProtobufDataAPI<FUStB2DPatrolPointDesc>.Get().FindByID(Id);
	}

	public static List<FUStB2DPatrolPointDesc> GetB2DPatrolPointList(int StageId, int GroupId)
	{
		if (sB2DPatrolPointDesc.TryGetValue(StageId, out var value) && value.TryGetValue(GroupId, out var value2))
		{
			return value2;
		}
		return null;
	}

	public static Dictionary<int, FUStB2DBuffDispDesc> GetALLB2DBuffDispDesc()
	{
		return BG_ProtobufDataAPI<FUStB2DBuffDispDesc>.Get().GetAll();
	}

	public static FUStB2DLevelTimeBonusDesc GetB2DLevelTimeBonusDesc(int ResId)
	{
		return BG_ProtobufDataAPI<FUStB2DLevelTimeBonusDesc>.Get().FindByID(ResId);
	}

	public static FUStB2DMultiKillEnegyDesc GetB2DMultiKillEnegyDesc(int ResId)
	{
		return BG_ProtobufDataAPI<FUStB2DMultiKillEnegyDesc>.Get().FindByID(ResId);
	}

	public static FUStB2DAutoPathDesc GetB2DAutoPathDesc(int LevelId)
	{
		Dictionary<int, FUStB2DAutoPathDesc> all = BG_ProtobufDataAPI<FUStB2DAutoPathDesc>.Get().GetAll();
		if (all != null)
		{
			foreach (KeyValuePair<int, FUStB2DAutoPathDesc> item in all)
			{
				if (item.Value.Level == LevelId)
				{
					return item.Value;
				}
			}
		}
		return null;
	}

	public static FUStB2DUnitDeadDispDesc GetB2DUnitDeadDispDescByIdAndDeadReason(int UnitId, EB2DDeadReason DeadReason)
	{
		if (sB2DUnitDeadDispMap.TryGetValue(UnitId, out var value) && value.TryGetValue(DeadReason, out var value2))
		{
			return value2;
		}
		return null;
	}

	public static FUStB2DUnitDeadDispDesc GetB2DUnitDeadDispDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStB2DUnitDeadDispDesc>.Get().FindByID(ResID);
	}

	public static FUStB2DBuffMapDesc GetB2DBuffMapDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStB2DBuffMapDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStB2DBuffMapDesc> GetAllB2DBuffMapDesc()
	{
		return BG_ProtobufDataAPI<FUStB2DBuffMapDesc>.Get().GetAll();
	}

	public static FUStB2DSkillMapDesc GetB2DSkillMapDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStB2DSkillMapDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStB2DSkillMapDesc> GetAllB2DSkillMapDesc()
	{
		return BG_ProtobufDataAPI<FUStB2DSkillMapDesc>.Get().GetAll();
	}

	public static FUStB2DUnitCommDesc GetB2DUnitCommDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStB2DUnitCommDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStB2DUnitCommDesc> GetAllB2DUnitCommDesc()
	{
		return BG_ProtobufDataAPI<FUStB2DUnitCommDesc>.Get().GetAll();
	}

	public static FUStB2DBulletCommDesc GetB2DBulletCommDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStB2DBulletCommDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStB2DBulletCommDesc> GetAllB2DBulletCommDesc()
	{
		return BG_ProtobufDataAPI<FUStB2DBulletCommDesc>.Get().GetAll();
	}

	public static FUStB2DBuffDesc GetB2DBuffDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStB2DBuffDesc>.Get().FindByID(ResID);
	}

	public static FUStB2DRelicBuffDesc GetB2DRelicBuffDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStB2DRelicBuffDesc>.Get().FindByID(ResID);
	}

	public static FUStUnitBattleInfoExtendDesc GetUnitBattleInfoExtendDesc(int BattleInfoID)
	{
		return BG_ProtobufDataAPI<FUStUnitBattleInfoExtendDesc>.Get().FindByID(BattleInfoID);
	}

	public static Dictionary<int, FUStUnitBattleInfoExtendDesc> GetAllUnitBattleInfoExtendDesc()
	{
		return BG_ProtobufDataAPI<FUStUnitBattleInfoExtendDesc>.Get().GetAll();
	}

	public static FUStUnitPassiveSkillInfoExtendDesc GetUnitPassiveSkillInfoExtendDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStUnitPassiveSkillInfoExtendDesc>.Get().FindByID(ResID);
	}

	public static FUStUnitEnvMaskConfigDesc GetUnitEnvMaskConfigDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStUnitEnvMaskConfigDesc>.Get().FindByID(ResID);
	}

	public static FUStUnitCommDesc GetUnitCommDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStUnitCommDesc>.Get().FindByID(ResID);
	}

	public static FUStUnitTransCommDesc GetUnitTransCommDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStUnitTransCommDesc>.Get().FindByID(ResID);
	}

	public static FUStSummonCommDesc GetOriginalSummonCommDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStSummonCommDesc>.Get().FindByID(ResID);
	}

	public static FUStSummonCommDesc GetSummonCommDesc(int ResID, AActor TargetActor)
	{
		if (TargetActor is BGUCharacterCS { PassiveSkillData: { } passiveSkillData } && passiveSkillData.CachedSummonCommDescs.TryGetValue(ResID, out var value))
		{
			return value;
		}
		return BG_ProtobufDataAPI<FUStSummonCommDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStSummonCommDesc> GetAllSummonCommDesc()
	{
		return BG_ProtobufDataAPI<FUStSummonCommDesc>.Get().GetAll();
	}

	public static FUStSummonCopySkillDesc GetSummonCopySkillDesc(int SkillID)
	{
		return BG_ProtobufDataAPI<FUStSummonCopySkillDesc>.Get().FindByID(SkillID);
	}

	public static FUStBulletSwitchDesc GetBulletSwitchDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStBulletSwitchDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStProjectileCommDesc> GetAllProjectileCommDesc()
	{
		return BG_ProtobufDataAPI<FUStProjectileCommDesc>.Get().GetAll();
	}

	public static FUStProjectileCommDesc GetOriginalProjectileCommDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStProjectileCommDesc>.Get().FindByID(ResID);
	}

	public static FUStProjectileCommDesc GetProjectileCommDesc(int ID, AActor Caster)
	{
		if (Caster is BGUCharacterCS { PassiveSkillData: { } passiveSkillData } && passiveSkillData.CachedProjectileCommDescs.TryGetValue(ID, out var value))
		{
			return value;
		}
		return BG_ProtobufDataAPI<FUStProjectileCommDesc>.Get().FindByID(ID);
	}

	public static FUStProjectileDispDesc GetProjectileDispDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStProjectileDispDesc>.Get().FindByID(ResID);
	}

	public static FUStProjectileMoveDesc GetProjectileMoveDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStProjectileMoveDesc>.Get().FindByID(ResID);
	}

	public static FUStBulletExpandDesc GetBulletExpandDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStBulletExpandDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStBulletExpandDesc> GetAllBulletExpandDesc()
	{
		return BG_ProtobufDataAPI<FUStBulletExpandDesc>.Get().GetAll();
	}

	public static Dictionary<int, FUStProjectileMoveDesc> GetAllProjectileMoveDesc()
	{
		return BG_ProtobufDataAPI<FUStProjectileMoveDesc>.Get().GetAll();
	}

	public static FUStMagicFieldExpandDesc GetMagicFieldExpandDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStMagicFieldExpandDesc>.Get().FindByID(ResID);
	}

	public static FUStBulletWindFieldExpandDesc GetBulletWindFieldExpandDesc(int ProjectileID)
	{
		return BG_ProtobufDataAPI<FUStBulletWindFieldExpandDesc>.Get().FindByID(ProjectileID);
	}

	public static Dictionary<int, FUStAISkillBasicActionDesc> GetAllAISkillBasicActionDesc()
	{
		return BG_ProtobufDataAPI<FUStAISkillBasicActionDesc>.Get().GetAll();
	}

	public static Dictionary<int, FUStAISkillTagsDesc> GetAllAISkillTagsDesc()
	{
		return BG_ProtobufDataAPI<FUStAISkillTagsDesc>.Get().GetAll();
	}

	public static Dictionary<int, FUStAIThinkDesc> GetAllAIThinkDesc()
	{
		return BG_ProtobufDataAPI<FUStAIThinkDesc>.Get().GetAll();
	}

	public static FUStAIThinkDesc GetAIThinkDesc(int ThinkID)
	{
		return BG_ProtobufDataAPI<FUStAIThinkDesc>.Get().FindByID(ThinkID);
	}

	public static FUStAIActionDesc GetAIActionDesc(int ActionID)
	{
		return BG_ProtobufDataAPI<FUStAIActionDesc>.Get().FindByID(ActionID);
	}

	public static Dictionary<int, FUStAIActionDesc> GetAllAIActionDesc()
	{
		return BG_ProtobufDataAPI<FUStAIActionDesc>.Get().GetAll();
	}

	public static Dictionary<int, FUStAIFeatureDesc> GetAllAIFeatureDesc()
	{
		return BG_ProtobufDataAPI<FUStAIFeatureDesc>.Get().GetAll();
	}

	public static FUStAIFeatureDesc GetAIFeatureDesc(int FeatureID)
	{
		return BG_ProtobufDataAPI<FUStAIFeatureDesc>.Get().FindByID(FeatureID);
	}

	public static List<FUStAIFeatureFilter> GetAIFeatureFilters(int FeatureID)
	{
		return sFeatureFilterDict[FeatureID];
	}

	public static FUStSkillSDesc GetOriginalSkillSDesc(int SkillID)
	{
		return BG_ProtobufDataAPI<FUStSkillSDesc>.Get().FindByID(SkillID);
	}

	public static string GetSkillSToBlame(int SkillID)
	{
		return BG_ProtobufDataAPI<FUStSkillSDesc>.Get().GetBlameByID(in SkillID);
	}

	public static FUStSkillSDesc GetSkillSDesc(int SkillID, AActor TargetActor)
	{
		if (TargetActor is BGUCharacterCS { PassiveSkillData: { } passiveSkillData } && passiveSkillData.CachedSkillSDescs.TryGetValue(SkillID, out var value))
		{
			return value;
		}
		return BG_ProtobufDataAPI<FUStSkillSDesc>.Get().FindByID(SkillID);
	}

	public static FUStSkillSMappingDesc GetSkillSMappingDesc(int SkillID)
	{
		return BG_ProtobufDataAPI<FUStSkillSMappingDesc>.Get().FindByID(SkillID);
	}

	public static FUStB2DSkillSDesc GetB2DSkillSDesc(int SkillID)
	{
		return BG_ProtobufDataAPI<FUStB2DSkillSDesc>.Get().FindByID(SkillID);
	}

	public static FUStSkillAIDesc GetSkillAIDesc(int SkillID)
	{
		return BG_ProtobufDataAPI<FUStSkillAIDesc>.Get().FindByID(SkillID);
	}

	public static string GetSkillAIToBlame(int SkillID)
	{
		return BG_ProtobufDataAPI<FUStSkillAIDesc>.Get().GetBlameByID(in SkillID);
	}

	public static FUStChargeSkillSDesc GetOriginalChargeSkillSDesc(int SkillID)
	{
		return BG_ProtobufDataAPI<FUStChargeSkillSDesc>.Get().FindByID(SkillID);
	}

	public static FUStChargeSkillSDesc GetChargeSkillSDesc(int SkillID, AActor TargetActor)
	{
		if (TargetActor is BGUCharacterCS { PassiveSkillData: { } passiveSkillData } && passiveSkillData.CachedChargeSkillSDescs.TryGetValue(SkillID, out var value))
		{
			return value;
		}
		return BG_ProtobufDataAPI<FUStChargeSkillSDesc>.Get().FindByID(SkillID);
	}

	public static FUStPlayerTransAttrDesc GetPlayerTransAttrDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStPlayerTransAttrDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStPlayerTransAttrDesc> GetAllPlayerTransAttrDesc()
	{
		return BG_ProtobufDataAPI<FUStPlayerTransAttrDesc>.Get().GetAll();
	}

	public static FUStUnitAIDesc GetUnitAIDesc(int ExtendID)
	{
		FUStUnitAIDesc fUStUnitAIDesc = BG_ProtobufDataAPI<FUStUnitAIDesc>.Get().FindByID(ExtendID);
		if (fUStUnitAIDesc == null)
		{
			fUStUnitAIDesc = BG_ProtobufDataAPI<FUStUnitAIDesc>.Get().FindByID(ExtendID / 100 * 100 + 1);
		}
		return fUStUnitAIDesc;
	}

	private static void InitAICrowdDetourlevelConfigDict()
	{
		foreach (KeyValuePair<int, FUStAICrowdDetourLevelConfigDesc> item in BG_ProtobufDataAPI<FUStAICrowdDetourLevelConfigDesc>.Get().GetAll())
		{
			if (!sAICrowdDetourLevelMap.ContainsKey(item.Value.DetourCrowdType))
			{
				sAICrowdDetourLevelMap.Add(item.Value.DetourCrowdType, item.Value);
			}
		}
	}

	public static FUStAICrowdDetourLevelConfigDesc GetUnitAICrowdDetourlevelConfigDesc(EUnitAIDetourCrowdType DetourCrowdType)
	{
		BG_ProtobufDataAPI<FUStAICrowdDetourLevelConfigDesc>.Get().GetAll();
		FUStAICrowdDetourLevelConfigDesc value = null;
		sAICrowdDetourLevelMap.TryGetValue(DetourCrowdType, out value);
		if (value == null)
		{
			sAICrowdDetourLevelMap.TryGetValue(EUnitAIDetourCrowdType.Medium, out value);
		}
		return value;
	}

	public static FUStSkillEffectDesc GetOriginalSkillEffectDesc(int SkillEffectID)
	{
		return BG_ProtobufDataAPI<FUStSkillEffectDesc>.Get().FindByID(SkillEffectID);
	}

	public static FUStSkillEffectDesc GetSkillEffectDesc(int SkillEffectID, AActor TargetActor)
	{
		if (TargetActor is BGUCharacterCS { PassiveSkillData: { } passiveSkillData } && passiveSkillData.CachedSkillEffectDescs.TryGetValue(SkillEffectID, out var value))
		{
			return value;
		}
		return BG_ProtobufDataAPI<FUStSkillEffectDesc>.Get().FindByID(SkillEffectID);
	}

	public static FUStSkillDamageExpandDesc GetOriginalSkillDamageExpandDesc(int SkillDamageEffectID)
	{
		FUStSkillEffectDesc originalSkillEffectDesc = GetOriginalSkillEffectDesc(SkillDamageEffectID);
		if (originalSkillEffectDesc != null && originalSkillEffectDesc.EffectType == EBuffAndSkillEffectType.SkillDamage)
		{
			int resID = SkillDamageEffectID;
			if (originalSkillEffectDesc.EffectParamsInt.Count > 6)
			{
				resID = originalSkillEffectDesc.EffectParamsInt[6];
			}
			return BG_ProtobufDataAPI<FUStSkillDamageExpandDesc>.Get().FindByID(resID);
		}
		return null;
	}

	public static FUStSkillDamageExpandDesc GetSkillDamageExpandDesc(int SkillDamageEffectID, AActor TargetActor, out int SkillDamageExpandID)
	{
		SkillDamageExpandID = -1;
		if (TargetActor is BGUCharacterCS bGUCharacterCS)
		{
			FUStSkillEffectDesc skillEffectDesc = GetSkillEffectDesc(SkillDamageEffectID, TargetActor);
			if (skillEffectDesc != null && skillEffectDesc.EffectType == EBuffAndSkillEffectType.SkillDamage)
			{
				SkillDamageExpandID = SkillDamageEffectID;
				if (skillEffectDesc.EffectParamsInt.Count > 6)
				{
					SkillDamageExpandID = skillEffectDesc.EffectParamsInt[6];
				}
				IBUC_PassiveSkillData passiveSkillData = bGUCharacterCS.PassiveSkillData;
				if (passiveSkillData != null && passiveSkillData.CachedSkillDamageExpandDescs.TryGetValue(SkillDamageExpandID, out var value))
				{
					return value;
				}
				return BG_ProtobufDataAPI<FUStSkillDamageExpandDesc>.Get().FindByID(SkillDamageExpandID);
			}
		}
		return null;
	}

	public static Dictionary<int, FUStSkillEffectDesc> GetAllSkillEffectDesc()
	{
		return BG_ProtobufDataAPI<FUStSkillEffectDesc>.Get().GetAll();
	}

	public static List<FUStB2DUnitSpawnDesc> GetUnitSpawnB2DDesc(int StageID)
	{
		sMapB2DUnitSpawnStage.TryGetValue(StageID, out var value);
		return value;
	}

	public static FUStB2DUnitSpawnDesc GetOneUnitSpawnB2DDesc(int Idx)
	{
		return BG_ProtobufDataAPI<FUStB2DUnitSpawnDesc>.Get().FindByID(Idx);
	}

	public static int GetUnitSpawnB2DDescStageCount()
	{
		return sMapB2DUnitSpawnStage.Count();
	}

	public static Dictionary<int, List<FUStB2DUnitSpawnDesc>> GetUnitSpawnB2DDescAll()
	{
		return sMapB2DUnitSpawnStage;
	}

	public static FUStB2DVictoryConditionsDesc GetVictoryConditionsDesc(int Idx)
	{
		return BG_ProtobufDataAPI<FUStB2DVictoryConditionsDesc>.Get().FindByID(Idx);
	}

	public static FUStB2DSkillEffectDesc GetB2DSkillEffectDesc(int SkillEffectID)
	{
		return BG_ProtobufDataAPI<FUStB2DSkillEffectDesc>.Get().FindByID(SkillEffectID);
	}

	public static Dictionary<int, FUStB2DSkillEffectDesc> GetAllB2DSkillEffectDesc()
	{
		return BG_ProtobufDataAPI<FUStB2DSkillEffectDesc>.Get().GetAll();
	}

	public static FUStB2DSummonDesc GetB2DSummonDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStB2DSummonDesc>.Get().FindByID(ResID);
	}

	public static FUStB2DSkillLevelMapDesc GetB2DSkillLevelMapDesc(int SkillID)
	{
		return BG_ProtobufDataAPI<FUStB2DSkillLevelMapDesc>.Get().FindByID(SkillID);
	}

	public static FUStBuffDesc GetOriginalBuffDesc(int BuffID)
	{
		return BG_ProtobufDataAPI<FUStBuffDesc>.Get().FindByID(BuffID);
	}

	public static string GetBuffToBlame(int BuffID)
	{
		return BG_ProtobufDataAPI<FUStBuffDesc>.Get().GetBlameByID(in BuffID);
	}

	public static string GetSkillEffectToBlame(int SkillEffectID)
	{
		return BG_ProtobufDataAPI<FUStSkillEffectDesc>.Get().GetBlameByID(in SkillEffectID);
	}

	public static Dictionary<int, FUStEnvironmentSurfaceEffectDesc> GetAllEnvironmentSurfaceEffectDesc()
	{
		return BG_ProtobufDataAPI<FUStEnvironmentSurfaceEffectDesc>.Get().GetAll();
	}

	public static FUStEnvironmentSurfaceEffectDesc GetEnvironmentSurfaceEffectDesc(int EffectID)
	{
		return BG_ProtobufDataAPI<FUStEnvironmentSurfaceEffectDesc>.Get().FindByID(EffectID);
	}

	public static Dictionary<int, FUStGlobalCannotDeadExtraConfigDesc> GetAllGlobalCannotDeadExtraConfigDesc()
	{
		return BG_ProtobufDataAPI<FUStGlobalCannotDeadExtraConfigDesc>.Get().GetAll();
	}

	public static List<FUStGlobalCannotDeadExtraConfigDesc> GetGlobalCannotDeadExtraConfigDescListByResID(int ResID)
	{
		if (!sGlobalCannotDeadExtraCacheDict.TryGetValue(ResID, out var value))
		{
			return null;
		}
		return value;
	}

	public static Dictionary<int, FUStSweepCheckDesc> GetAllSweepCheckDesc()
	{
		return BG_ProtobufDataAPI<FUStSweepCheckDesc>.Get().GetAll();
	}

	public static FUStSweepCheckDesc GetSweepCheckDesc(int ID)
	{
		return BG_ProtobufDataAPI<FUStSweepCheckDesc>.Get().FindByID(ID);
	}

	public static BuffDescRuntime GetBuffDescRuntime(int BuffID, IBUC_PassiveSkillData PassiveSkillData)
	{
		FUStBuffDesc originalBuffDesc = GetOriginalBuffDesc(BuffID);
		if (originalBuffDesc != null)
		{
			return new BuffDescRuntime(BuffID, PassiveSkillData, originalBuffDesc);
		}
		return null;
	}

	public static BuffDescRuntime GetBuffDescRuntime(int BuffID, Dictionary<string, float> ModifyData)
	{
		FUStBuffDesc originalBuffDesc = GetOriginalBuffDesc(BuffID);
		if (originalBuffDesc != null)
		{
			return new BuffDescRuntime(ModifyData, originalBuffDesc);
		}
		return null;
	}

	public static FUStBuffIconDesc GetBuffIconDesc(int ID)
	{
		return BG_ProtobufDataAPI<FUStBuffIconDesc>.Get().FindByID(ID);
	}

	public static FUStAttackHitAudioInfoDesc GetAttackHitAudioInfoDesc(int AudioID)
	{
		return BG_ProtobufDataAPI<FUStAttackHitAudioInfoDesc>.Get().FindByID(AudioID);
	}

	public static FUStPartRuleInfoDesc GetOriginalPartRuleInfoDesc(int ID)
	{
		return BG_ProtobufDataAPI<FUStPartRuleInfoDesc>.Get().FindByID(ID);
	}

	public static FUStPartRuleInfoDesc GetPartRuleInfoDesc(int ID, AActor TargetActor)
	{
		if (TargetActor is BGUCharacterCS { PassiveSkillData: { } passiveSkillData } && passiveSkillData.CachedPartRuleInfoDescs.TryGetValue(ID, out var value))
		{
			return value;
		}
		return BG_ProtobufDataAPI<FUStPartRuleInfoDesc>.Get().FindByID(ID);
	}

	public static FUStPartHitExpandDesc GetPartHitExpandDesc(int PartRuleID, int PartID)
	{
		foreach (KeyValuePair<int, FUStPartHitExpandDesc> item in BG_ProtobufDataAPI<FUStPartHitExpandDesc>.Get().GetAll())
		{
			if (PartRuleID == item.Value.PartRuleID && PartID == item.Value.PartID)
			{
				return item.Value;
			}
		}
		return null;
	}

	public static FUStBuffTickRuleBySimpleStateDesc GetBuffTickRuleBySimpleStateDesc(int ID)
	{
		return BG_ProtobufDataAPI<FUStBuffTickRuleBySimpleStateDesc>.Get().FindByID(ID);
	}

	public static List<int> GetBuffTickRuleBySimpleStateDesc(int ID, out EBuffTickRuleBySSType RuleType)
	{
		RuleType = EBuffTickRuleBySSType.None;
		FUStBuffTickRuleBySimpleStateDesc buffTickRuleBySimpleStateDesc = GetBuffTickRuleBySimpleStateDesc(ID);
		if (buffTickRuleBySimpleStateDesc == null)
		{
			return null;
		}
		RuleType = buffTickRuleBySimpleStateDesc.RuleType;
		if (!sMapBuffTickRuleBySS_ID.ContainsKey(ID))
		{
			return null;
		}
		return sMapBuffTickRuleBySS_ID[ID];
	}

	public static FUStMovieSequenceDesc GetMovieSequenceDesc(int ID)
	{
		return BG_ProtobufDataAPI<FUStMovieSequenceDesc>.Get().FindByID(ID);
	}

	public static Dictionary<int, FUStMovieSequenceDesc> GetAllMovieSequenceDesc()
	{
		return BG_ProtobufDataAPI<FUStMovieSequenceDesc>.Get().GetAll();
	}

	public static Dictionary<int, FUStBuffDesc> GetAllBuffDesc()
	{
		return BG_ProtobufDataAPI<FUStBuffDesc>.Get().GetAll();
	}

	public static Dictionary<int, FUStBuffDispDesc> GetAllBuffDispDesc()
	{
		return BG_ProtobufDataAPI<FUStBuffDispDesc>.Get().GetAll();
	}

	public static Dictionary<int, FUStBuffDispGroupDesc> GetAllBuffDispGroupDesc()
	{
		return BG_ProtobufDataAPI<FUStBuffDispGroupDesc>.Get().GetAll();
	}

	public static Dictionary<int, FUStBuffLayerDispDesc> GetAllBuffLayerDispDesc()
	{
		return BG_ProtobufDataAPI<FUStBuffLayerDispDesc>.Get().GetAll();
	}

	public static Dictionary<int, FUStPartRuleInfoDesc> GetAllPartRuleInfoDesc()
	{
		return BG_ProtobufDataAPI<FUStPartRuleInfoDesc>.Get().GetAll();
	}

	public static Dictionary<int, FUStUnitCommDesc> GetAllUnitCommDesc()
	{
		return BG_ProtobufDataAPI<FUStUnitCommDesc>.Get().GetAll();
	}

	public static Dictionary<int, FUStStraightCamDesc> GetAllStraightCamDesc()
	{
		return BG_ProtobufDataAPI<FUStStraightCamDesc>.Get().GetAll();
	}

	public static Dictionary<int, FUStGiantLockCameraDesc> GetAllGiantCamDesc()
	{
		return BG_ProtobufDataAPI<FUStGiantLockCameraDesc>.Get().GetAll();
	}

	public static Dictionary<int, FUStMultiPointLockCameraConfigDesc> GetAllMultiPointDescs()
	{
		return BG_ProtobufDataAPI<FUStMultiPointLockCameraConfigDesc>.Get().GetAll();
	}

	public static Dictionary<int, FUStDiagonalCamDesc> GetAllDiagonalCamDesc()
	{
		return BG_ProtobufDataAPI<FUStDiagonalCamDesc>.Get().GetAll();
	}

	public static Dictionary<int, FUStCameraGroupDesc> GetAllCameraGroupDesc()
	{
		return BG_ProtobufDataAPI<FUStCameraGroupDesc>.Get().GetAll();
	}

	public static Dictionary<int, FUStBeAttackedInfoDesc> GetAllBeAttackedInfoDesc()
	{
		return BG_ProtobufDataAPI<FUStBeAttackedInfoDesc>.Get().GetAll();
	}

	public static Dictionary<int, FUStBeAttackedDispInfoDesc> GetAllBeAttackedDispInfoDesc()
	{
		return BG_ProtobufDataAPI<FUStBeAttackedDispInfoDesc>.Get().GetAll();
	}

	public static Dictionary<int, FUStBeAttackedStiffLevelMappingDesc> GetAllBeAttackedStiffLevelMappingDesc()
	{
		return BG_ProtobufDataAPI<FUStBeAttackedStiffLevelMappingDesc>.Get().GetAll();
	}

	public static Dictionary<int, FUStScarInfoDesc> GetAllScarInfoDesc()
	{
		return BG_ProtobufDataAPI<FUStScarInfoDesc>.Get().GetAll();
	}

	public static Dictionary<int, FUStUnitTransCommDesc> GetAllUnitTransCommDesc()
	{
		return BG_ProtobufDataAPI<FUStUnitTransCommDesc>.Get().GetAll();
	}

	public static Dictionary<int, FUStSkillAIDesc> GetAllSkillAIDesc()
	{
		return BG_ProtobufDataAPI<FUStSkillAIDesc>.Get().GetAll();
	}

	public static Dictionary<int, FUStUnitAIDesc> GetAllUnitAIDesc()
	{
		return BG_ProtobufDataAPI<FUStUnitAIDesc>.Get().GetAll();
	}

	public static Dictionary<int, FUStSkillSDesc> GetAllSkillSDesc()
	{
		return BG_ProtobufDataAPI<FUStSkillSDesc>.Get().GetAll();
	}

	public static Dictionary<int, FUStSkillSMappingDesc> GetAllSkillSMappingDesc()
	{
		return BG_ProtobufDataAPI<FUStSkillSMappingDesc>.Get().GetAll();
	}

	public static Dictionary<int, FUStBulletCommDesc> GetAllBulletCommDesc()
	{
		return BG_ProtobufDataAPI<FUStBulletCommDesc>.Get().GetAll();
	}

	public static Dictionary<int, FUStBuffRuleDesc> GetAllBuffRuleDesc()
	{
		return BG_ProtobufDataAPI<FUStBuffRuleDesc>.Get().GetAll();
	}

	public static Dictionary<int, FUStMandatoryAITaskDesc> GetAllMandatoryAITaskDesc()
	{
		return BG_ProtobufDataAPI<FUStMandatoryAITaskDesc>.Get().GetAll();
	}

	public static Dictionary<int, FUStPlayerCameraDesc> GetAllPlayerCameraDesc()
	{
		return BG_ProtobufDataAPI<FUStPlayerCameraDesc>.Get().GetAll();
	}

	public static Dictionary<int, FUStAttackHitFXMapDesc> GetAllAttackHitFXMapDesc()
	{
		return BG_ProtobufDataAPI<FUStAttackHitFXMapDesc>.Get().GetAll();
	}

	public static Dictionary<int, FUStAudioExtendDesc> GetAllAudioExtendDescs()
	{
		return BG_ProtobufDataAPI<FUStAudioExtendDesc>.Get().GetAll();
	}

	public static Dictionary<int, FUStHitSceneItemPerformDesc> GetAllHitSceneItemPerformDesc()
	{
		return BG_ProtobufDataAPI<FUStHitSceneItemPerformDesc>.Get().GetAll();
	}

	public static Dictionary<int, FUStBeAttackedFXMapDesc> GetAllBeAttackedFXMapDesc()
	{
		return BG_ProtobufDataAPI<FUStBeAttackedFXMapDesc>.Get().GetAll();
	}

	public static Dictionary<int, FUStUnitDeadDesc> GetAllUnitDeadDesc()
	{
		return BG_ProtobufDataAPI<FUStUnitDeadDesc>.Get().GetAll();
	}

	public static Dictionary<int, FUStUnitDeadOldDesc> GetAllUnitDeadOldDesc()
	{
		return BG_ProtobufDataAPI<FUStUnitDeadOldDesc>.Get().GetAll();
	}

	public static Dictionary<int, FUStAttackHitAudioInfoDesc> GetAllAttackHitAudioInfoDesc()
	{
		return BG_ProtobufDataAPI<FUStAttackHitAudioInfoDesc>.Get().GetAll();
	}

	public static Dictionary<int, FUStBuffTickRuleBySimpleStateDesc> GetAllBuffTickRuleBySimpleStateDesc()
	{
		return BG_ProtobufDataAPI<FUStBuffTickRuleBySimpleStateDesc>.Get().GetAll();
	}

	public static Dictionary<int, FUStSoulSkillMimicryDesc> GetAllSoulSkillMimicryDesc()
	{
		return BG_ProtobufDataAPI<FUStSoulSkillMimicryDesc>.Get().GetAll();
	}

	public static Dictionary<int, FUStBossRushConfigDesc> GetAllBossRushConfigDesc()
	{
		return BG_ProtobufDataAPI<FUStBossRushConfigDesc>.Get().GetAll();
	}

	public static FUStBossRushConfigDesc GetBossRushConfigDesc(int BossRushID)
	{
		return BG_ProtobufDataAPI<FUStBossRushConfigDesc>.Get().FindByID(BossRushID);
	}

	public static FUStBuffDispDesc GetBuffDispDescByID(int ResID)
	{
		return BG_ProtobufDataAPI<FUStBuffDispDesc>.Get().FindByID(ResID);
	}

	public static FUStBuffLayerDispDesc GetBuffLayerDispDescByID(int ResID)
	{
		return BG_ProtobufDataAPI<FUStBuffLayerDispDesc>.Get().FindByID(ResID);
	}

	public static FUStExAnimDataDesc GetExAnimDataDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStExAnimDataDesc>.Get().FindByID(ResID);
	}

	public static FUStRollSkillDesc GetOriginalRollSkillDesc(int SkillID)
	{
		return BG_ProtobufDataAPI<FUStRollSkillDesc>.Get().FindByID(SkillID);
	}

	public static FUStRollSkillDesc GetRollSkillDesc(int SkillID, AActor TargetActor)
	{
		if (TargetActor is BGUCharacterCS { PassiveSkillData: { } passiveSkillData } && passiveSkillData.CachedRollDescs.TryGetValue(SkillID, out var value))
		{
			return value;
		}
		return BG_ProtobufDataAPI<FUStRollSkillDesc>.Get().FindByID(SkillID);
	}

	public static FUStPlayerCommDesc GetOriginalPlayerCommDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStPlayerCommDesc>.Get().FindByID(ResID);
	}

	public static FUStPlayerCommDesc GetPlayerCommDesc(int ResID, AActor Owner)
	{
		if (Owner is BGUCharacterCS { PassiveSkillData: { } passiveSkillData } && passiveSkillData.CachedFUStPlayerCommDescs.TryGetValue(ResID, out var value))
		{
			return value;
		}
		return GetOriginalPlayerCommDesc(ResID);
	}

	public static FUStPlayerCommDesc GetPlayerCommDesc(int ResID)
	{
		return GetOriginalPlayerCommDesc(ResID);
	}

	public static FUStPlayerCommDesc GetPlayerOrgCommDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStPlayerCommDesc>.Get().FindByID(ResID);
	}

	public static FUStPlayerInputSkillMappingDesc GetOriginalPlayerInputSkillMappingDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStPlayerInputSkillMappingDesc>.Get().FindByID(ResID);
	}

	public static FUStPlayerInputSkillMappingDesc GetPlayerInputSkillMappingDesc(int ResID, AActor Target)
	{
		if (Target is BGUCharacterCS { PassiveSkillData: { } passiveSkillData } && passiveSkillData.CachedPlayerCommSkillDescs.TryGetValue(ResID, out var value))
		{
			return value;
		}
		return BG_ProtobufDataAPI<FUStPlayerInputSkillMappingDesc>.Get().FindByID(ResID);
	}

	private static void InitPotentialEnergyMap()
	{
		sMapPotentialEnergy = new Dictionary<int, Dictionary<int, Dictionary<int, FUStPotentialEnergyConfigDesc>>>();
		foreach (KeyValuePair<int, FUStPotentialEnergyConfigDesc> item in BG_ProtobufDataAPI<FUStPotentialEnergyConfigDesc>.Get().GetAll())
		{
			_ = item.Key;
			FUStPotentialEnergyConfigDesc value = item.Value;
			int resID = value.ResID;
			Dictionary<int, FUStPotentialEnergyConfigDesc> value3;
			FUStPotentialEnergyConfigDesc value4;
			if (!sMapPotentialEnergy.TryGetValue(resID, out var value2))
			{
				value2 = new Dictionary<int, Dictionary<int, FUStPotentialEnergyConfigDesc>>();
				value3 = new Dictionary<int, FUStPotentialEnergyConfigDesc>();
				value3.Add(value.PELevelConfig.PELevel, value);
				value2.Add(value.ConfigID, value3);
				sMapPotentialEnergy.Add(resID, value2);
			}
			else if (!value2.TryGetValue(value.ConfigID, out value3))
			{
				value3 = new Dictionary<int, FUStPotentialEnergyConfigDesc>();
				value3.Add(value.PELevelConfig.PELevel, value);
				value2.Add(value.ConfigID, value3);
			}
			else if (!value3.TryGetValue(value.PELevelConfig.PELevel, out value4))
			{
				value3.Add(value.PELevelConfig.PELevel, value);
			}
		}
	}

	public static Dictionary<int, Dictionary<int, FUStPotentialEnergyConfigDesc>> GetOriginalPotentialEnergyResConfigDesc(int ResID)
	{
		if (sMapPotentialEnergy.TryGetValue(ResID, out var value))
		{
			return value;
		}
		return null;
	}

	public static Dictionary<int, FUStPotentialEnergyConfigDesc> GetOriginalPotentialEnergyConfigDesc(int ResID, int CongfigID = 0)
	{
		if (sMapPotentialEnergy.TryGetValue(ResID, out var value) && value.TryGetValue(CongfigID, out var value2))
		{
			return value2;
		}
		return null;
	}

	public static Dictionary<int, FUStPotentialEnergyConfigDesc> GetPotentialEnergyConfigDesc(int ResID, AActor Target)
	{
		int value = 0;
		if (Target is BGUCharacterCS { PassiveSkillData: var passiveSkillData })
		{
			if (passiveSkillData == null)
			{
				return GetOriginalPotentialEnergyConfigDesc(ResID);
			}
			passiveSkillData.ChachedPotentialEnergyConfigID.TryGetValue(ResID, out value);
			if (passiveSkillData.CachedPotentialEnergyConfigDescs.TryGetValue(ResID, out var value2) && value2.TryGetValue(value, out var value3))
			{
				return value3;
			}
		}
		return GetOriginalPotentialEnergyConfigDesc(ResID, value);
	}

	public static FUStUnitDeadDesc GetUnitDeadDesc(int ResID, int UnitDeadInfoID)
	{
		if (sMapUnitDead != null && sMapUnitDead.TryGetValue(ResID, out var value) && value.TryGetValue(UnitDeadInfoID, out var value2))
		{
			return value2;
		}
		return null;
	}

	public static FUStUnitDeadSwitchToPhysicDesc GetUnitDeadSwitchToPhysicDesc(int ID)
	{
		return BG_ProtobufDataAPI<FUStUnitDeadSwitchToPhysicDesc>.Get().FindByID(ID);
	}

	public static FUStUnitChangeMaterialByAttrDesc GetUnitChangeMaterialByAttrDesc(int ID)
	{
		return BG_ProtobufDataAPI<FUStUnitChangeMaterialByAttrDesc>.Get().FindByID(ID);
	}

	public static FUStCCGCastSkillMappingRuleDesc GetCCGCastSkillMappingRuleDesc(int RuleID)
	{
		return BG_ProtobufDataAPI<FUStCCGCastSkillMappingRuleDesc>.Get().FindByID(RuleID);
	}

	public static Dictionary<int, FUStUnitDeadDesc> GetUnitDeadDescDicByUnitResID(int UnitResID)
	{
		if (sMapUnitDead != null && sMapUnitDead.TryGetValue(UnitResID, out var value))
		{
			return value;
		}
		return null;
	}

	public static FUStSoulSkillMimicryDesc GetSoulSkillMimicryDesc(int SoulSkillID, int LevelID)
	{
		FUStSoulSkillMimicryDesc value = null;
		if (sMapSoulSkillMimicry != null && sMapSoulSkillMimicry.TryGetValue(SoulSkillID, out var value2))
		{
			value2.TryGetValue(LevelID, out value);
		}
		return value;
	}

	public static FUStSoulSkillMimicryDesc GetSoulSkillMimicryDescWithDefaultLevelID(int SoulSkillID, int LevelID)
	{
		FUStSoulSkillMimicryDesc value = null;
		if (sMapSoulSkillMimicry != null && sMapSoulSkillMimicry.TryGetValue(SoulSkillID, out var value2) && !value2.TryGetValue(LevelID, out value))
		{
			value2.TryGetValue(10, out value);
		}
		return value;
	}

	public static Dictionary<int, FUStSoulSkillMimicryDesc> GetSoulSkillMimicryDescListBySouldSkillID(int SoulSkillID)
	{
		Dictionary<int, FUStSoulSkillMimicryDesc> value = null;
		if (sMapSoulSkillMimicry != null)
		{
			sMapSoulSkillMimicry.TryGetValue(SoulSkillID, out value);
		}
		return value;
	}

	private static void InitBuffDispMap()
	{
		sBuffDispMap = new Dictionary<long, int>();
		sBuff2BuffDispMap = new Dictionary<int, HashSet<int>>();
		foreach (KeyValuePair<int, FUStBuffDispDesc> item in GetAllBuffDispDesc())
		{
			long buffDispMappingID = GetBuffDispMappingID(item.Value.OwnerResID, item.Value.BuffID, item.Value.CasterResID);
			sBuffDispMap.Add(buffDispMappingID, item.Value.ID);
			if (!sBuff2BuffDispMap.ContainsKey(item.Value.BuffID))
			{
				sBuff2BuffDispMap.Add(item.Value.BuffID, new HashSet<int>());
			}
			sBuff2BuffDispMap[item.Value.BuffID].Add(item.Value.ID);
		}
		sBuff2GroupMap = new Dictionary<int, HashSet<int>>();
		foreach (KeyValuePair<int, FUStBuffDispGroupDesc> item2 in GetAllBuffDispGroupDesc())
		{
			foreach (int buff in item2.Value.BuffList)
			{
				if (!sBuff2GroupMap.TryGetValue(buff, out var value))
				{
					value = new HashSet<int>();
					sBuff2GroupMap[buff] = value;
				}
				value.Add(item2.Key);
			}
		}
	}

	private static long GetBuffDispMappingID(int OwnerResID, int BuffID, int CasterResID)
	{
		return BuffID * 10000000000L + (long)CasterResID * 100000L + OwnerResID;
	}

	public static HashSet<int> GetBuffDispList_ByBuffID(int BuffID)
	{
		if (sBuff2BuffDispMap != null && sBuff2BuffDispMap.TryGetValue(BuffID, out var value))
		{
			return value;
		}
		return new HashSet<int>();
	}

	public static FUStBuffDispDesc GetBuffDispDesc(int OwnerResID, int BuffID, int CasterResID)
	{
		long buffDispMappingID = GetBuffDispMappingID(OwnerResID, BuffID, CasterResID);
		if (sBuffDispMap.TryGetValue(buffDispMappingID, out var value))
		{
			return GetBuffDispDescByID(value);
		}
		long buffDispMappingID2 = GetBuffDispMappingID(0, BuffID, CasterResID);
		if (sBuffDispMap.TryGetValue(buffDispMappingID2, out var value2))
		{
			return GetBuffDispDescByID(value2);
		}
		long buffDispMappingID3 = GetBuffDispMappingID(OwnerResID, BuffID, 0);
		if (sBuffDispMap.TryGetValue(buffDispMappingID3, out var value3))
		{
			return GetBuffDispDescByID(value3);
		}
		long buffDispMappingID4 = GetBuffDispMappingID(0, BuffID, 0);
		if (sBuffDispMap.TryGetValue(buffDispMappingID4, out var value4))
		{
			return GetBuffDispDescByID(value4);
		}
		return null;
	}

	public static List<int> GetBuffDispGroup(int BuffID)
	{
		if (sBuff2GroupMap.TryGetValue(BuffID, out var value))
		{
			return value.ToList();
		}
		return null;
	}

	public static FUStBuffLayerDispDesc GetBuffLayerDispDesc(int OwnerResID, int BuffID, int CasterResID)
	{
		FUStBuffLayerDispDesc result = null;
		int num = 0;
		foreach (KeyValuePair<int, FUStBuffLayerDispDesc> item in GetAllBuffLayerDispDesc())
		{
			if (item.Value.BuffID != BuffID)
			{
				continue;
			}
			if (item.Value.CasterResID == CasterResID && item.Value.OwnerResID == OwnerResID)
			{
				result = item.Value;
				num = 3;
				break;
			}
			if (num >= 3)
			{
				continue;
			}
			if (item.Value.CasterResID == CasterResID)
			{
				result = item.Value;
				num = 2;
			}
			if (num < 2)
			{
				if (item.Value.OwnerResID == OwnerResID)
				{
					result = item.Value;
					num = 1;
				}
				if (num < 1 && item.Value.OwnerResID == 0)
				{
					result = item.Value;
				}
			}
		}
		return result;
	}

	public static FUStBeAttackedInfoDesc GetBeAttackedInfoDesc(int BeAttackedInfoID)
	{
		return BG_ProtobufDataAPI<FUStBeAttackedInfoDesc>.Get().FindByID(BeAttackedInfoID);
	}

	public static Dictionary<int, List<FUStBeAttackedDispInfoDesc>> GetBeAttackedDispInfoDescDictByResID(int ResID)
	{
		if (sMapBeAttackedDispInfo.TryGetValue(ResID, out var value))
		{
			return value;
		}
		return null;
	}

	public static bool GetBeAttackedDispInfoDescDictByResID(int ResID, int OriginStiffLevel, out int MappingStiffLevel)
	{
		MappingStiffLevel = OriginStiffLevel;
		if (sMapBeAttackedStiffLevelMapping.TryGetValue(ResID, out var value) && value.TryGetValue(OriginStiffLevel, out MappingStiffLevel))
		{
			return true;
		}
		return false;
	}

	public static FUStScarInfoDesc GetScarInfoDesc(int ID)
	{
		return BG_ProtobufDataAPI<FUStScarInfoDesc>.Get().FindByID(ID);
	}

	public static FUStQTEDesc GetQTEDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStQTEDesc>.Get().FindByID(ResID);
	}

	public static FUStCameraGroupDesc GetCameraGroupDesc(int CameraGroupId, int PlayerUnitResID)
	{
		if (sMapCameraGroupGroupUnit != null && sMapCameraGroupGroupUnit.ContainsKey(CameraGroupId))
		{
			Dictionary<int, FUStCameraGroupDesc> dictionary = sMapCameraGroupGroupUnit[CameraGroupId];
			if (dictionary != null)
			{
				if (GetUnitCommDesc(PlayerUnitResID) != null && dictionary.ContainsKey(PlayerUnitResID))
				{
					return dictionary[PlayerUnitResID];
				}
				return null;
			}
		}
		return null;
	}

	public static FUStStraightCamDesc GetStraightCamDescDesc(int CamID, int PlayerUnitResID)
	{
		if (sMapStraightCamUnit != null && sMapStraightCamUnit.TryGetValue(CamID, out var value) && value != null && GetUnitCommDesc(PlayerUnitResID) != null && value.TryGetValue(PlayerUnitResID, out var value2))
		{
			return value2;
		}
		return null;
	}

	public static FUStGiantLockCameraDesc GetGiantCamDescDesc(int CamID, int PlayerUnitResID)
	{
		if (sMapGiantCamUnit != null && sMapGiantCamUnit.ContainsKey(CamID))
		{
			Dictionary<int, FUStGiantLockCameraDesc> dictionary = sMapGiantCamUnit[CamID];
			if (dictionary != null)
			{
				if (GetUnitCommDesc(PlayerUnitResID) != null && dictionary.ContainsKey(PlayerUnitResID))
				{
					return dictionary[PlayerUnitResID];
				}
				return dictionary.First().Value;
			}
		}
		return null;
	}

	public static FUStMultiPointLockCameraConfigDesc GetMultiPointLockCameraConfigDesc(int CameraGroupID, string LockSocketName)
	{
		if (sMapMultiPointLockCamUnit != null && sMapMultiPointLockCamUnit.TryGetValue(CameraGroupID, out var value) && value != null && value.TryGetValue(LockSocketName, out var value2))
		{
			return value2;
		}
		return null;
	}

	public static List<string> GetMultiPointLockOfUnitByCameraConfigDesc(int ResID)
	{
		if (sMapMultiPointLockOfUnit != null && sMapMultiPointLockOfUnit.TryGetValue(ResID, out var value))
		{
			return value;
		}
		return null;
	}

	public static FUStDiagonalCamDesc GetDiagonalCamDescDesc(int CamID, int PlayerUnitResID)
	{
		if (sMapDiagonalCamUnit != null && sMapDiagonalCamUnit.ContainsKey(CamID))
		{
			Dictionary<int, FUStDiagonalCamDesc> dictionary = sMapDiagonalCamUnit[CamID];
			if (dictionary != null)
			{
				if (GetUnitCommDesc(PlayerUnitResID) != null && dictionary.ContainsKey(PlayerUnitResID))
				{
					return dictionary[PlayerUnitResID];
				}
				return dictionary.First().Value;
			}
		}
		return null;
	}

	public static FUStQTEDesc FindQTEDescWithUnit(int UnitResID)
	{
		foreach (KeyValuePair<int, FUStQTEDesc> item in BG_ProtobufDataAPI<FUStQTEDesc>.Get().GetAll())
		{
			if (item.Value.TargetResID == UnitResID)
			{
				return item.Value;
			}
		}
		return null;
	}

	public static FUStQTEDesc FindQTEDescWithUnitAndSkill(int UnitResID, int FirstSkillID)
	{
		foreach (KeyValuePair<int, FUStQTEDesc> item in BG_ProtobufDataAPI<FUStQTEDesc>.Get().GetAll())
		{
			if (item.Value.TargetResID == UnitResID && item.Value.FirstSkillID == FirstSkillID)
			{
				return item.Value;
			}
		}
		return null;
	}

	public static FUStHitVEffectDesc GetHitVEffectDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStHitVEffectDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStHitVEffectDesc> GetAllHitVEffectDesc()
	{
		return BG_ProtobufDataAPI<FUStHitVEffectDesc>.Get().GetAll();
	}

	public static FUStDropItemDesc GetDropItemDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStDropItemDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStInteractiveUnitCommDesc> GetAllInteractiveUnitCommDesc()
	{
		return BG_ProtobufDataAPI<FUStInteractiveUnitCommDesc>.Get().GetAll();
	}

	public static FUStInteractiveUnitCommDesc GetInteractiveUnitCommDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStInteractiveUnitCommDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStInteractionMappingDesc> GetAllInteractionMappingDesc()
	{
		return BG_ProtobufDataAPI<FUStInteractionMappingDesc>.Get().GetAll();
	}

	public static FUStInteractionMappingDesc GetInteractionMappingDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStInteractionMappingDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStAiInteractionMappingDesc> GetAllInteractionAiMappingDesc()
	{
		return BG_ProtobufDataAPI<FUStAiInteractionMappingDesc>.Get().GetAll();
	}

	public static FUStAiInteractionMappingDesc GetInteractionAiMappingDesc(int DescID)
	{
		return BG_ProtobufDataAPI<FUStAiInteractionMappingDesc>.Get().FindByID(DescID);
	}

	public static Dictionary<int, FUStAssociationUnitInfoSDesc> GetAllAssociationUnitInfoSDesc()
	{
		return BG_ProtobufDataAPI<FUStAssociationUnitInfoSDesc>.Get().GetAll();
	}

	public static FUStAssociationUnitInfoSDesc GetAssociationUnitInfoSDesc(int ConfigID)
	{
		return BG_ProtobufDataAPI<FUStAssociationUnitInfoSDesc>.Get().FindByID(ConfigID);
	}

	public static Dictionary<int, FUStFollowPartnerConfigDesc> GetAllFollowPartnerConfigDesc()
	{
		return BG_ProtobufDataAPI<FUStFollowPartnerConfigDesc>.Get().GetAll();
	}

	public static FUStFollowPartnerConfigDesc GetFollowPartnerConfigDesc(int ConfigID)
	{
		return BG_ProtobufDataAPI<FUStFollowPartnerConfigDesc>.Get().FindByID(ConfigID);
	}

	public static Dictionary<int, FUStUnitIntelligenceInfoDesc> GetAllUnitIntelligenceInfoDesc()
	{
		return BG_ProtobufDataAPI<FUStUnitIntelligenceInfoDesc>.Get().GetAll();
	}

	public static FUStUnitIntelligenceInfoDesc GetUnitIntelligenceInfoDesc(int ConfigID)
	{
		return BG_ProtobufDataAPI<FUStUnitIntelligenceInfoDesc>.Get().FindByID(ConfigID);
	}

	private static void InitInteractMappingDict()
	{
		sMapInteractMapping = new Dictionary<int, Dictionary<int, List<FUStInteractionMappingDesc>>>();
		foreach (KeyValuePair<int, FUStInteractionMappingDesc> item in BG_ProtobufDataAPI<FUStInteractionMappingDesc>.Get().GetAll())
		{
			if (!sMapInteractMapping.ContainsKey(item.Value.OriginID))
			{
				sMapInteractMapping.Add(item.Value.OriginID, new Dictionary<int, List<FUStInteractionMappingDesc>>());
			}
			if (!sMapInteractMapping[item.Value.OriginID].ContainsKey(item.Value.GroupID))
			{
				sMapInteractMapping[item.Value.OriginID].Add(item.Value.GroupID, new List<FUStInteractionMappingDesc>());
				sMapInteractMapping[item.Value.OriginID][item.Value.GroupID].Add(item.Value);
			}
			else
			{
				sMapInteractMapping[item.Value.OriginID][item.Value.GroupID].Add(item.Value);
			}
		}
	}

	private static void InitAiInteractMappingDict()
	{
		sMapAiInteractMapping = new Dictionary<int, Dictionary<int, List<FUStAiInteractionMappingDesc>>>();
		foreach (KeyValuePair<int, FUStAiInteractionMappingDesc> item in BG_ProtobufDataAPI<FUStAiInteractionMappingDesc>.Get().GetAll())
		{
			if (!sMapAiInteractMapping.ContainsKey(item.Value.OriginID))
			{
				sMapAiInteractMapping.Add(item.Value.OriginID, new Dictionary<int, List<FUStAiInteractionMappingDesc>>());
			}
			if (!sMapAiInteractMapping[item.Value.OriginID].ContainsKey(item.Value.GroupID))
			{
				sMapAiInteractMapping[item.Value.OriginID].Add(item.Value.GroupID, new List<FUStAiInteractionMappingDesc>());
				sMapAiInteractMapping[item.Value.OriginID][item.Value.GroupID].Add(item.Value);
			}
			else
			{
				sMapAiInteractMapping[item.Value.OriginID][item.Value.GroupID].Add(item.Value);
			}
		}
	}

	private static void InitCustomStateMachineDict()
	{
		sMapCustomStateMachineDescDict = new Dictionary<int, FUStCustomStateMachineDesc>();
		foreach (KeyValuePair<int, FUStCustomStateMachineDesc> item in BG_ProtobufDataAPI<FUStCustomStateMachineDesc>.Get().GetAll())
		{
			if (!sMapCustomStateMachineDescDict.ContainsKey(item.Value.ID))
			{
				sMapCustomStateMachineDescDict.Add(item.Value.ID, item.Value);
			}
		}
	}

	private static void InitGuideAssetConfigDict()
	{
		sMapGuideAssetConfigDict = new Dictionary<int, FUStGuideAssetConfigDesc>();
		foreach (KeyValuePair<int, FUStGuideAssetConfigDesc> item in BG_ProtobufDataAPI<FUStGuideAssetConfigDesc>.Get().GetAll())
		{
			if (!sMapGuideAssetConfigDict.ContainsKey(item.Value.Id))
			{
				sMapGuideAssetConfigDict.Add(item.Value.Id, item.Value);
			}
		}
	}

	private static void InitActionNameTriggerEventIdDict()
	{
		sActionNameTriggerEventDescDict = new Dictionary<int, Dictionary<string, Dictionary<EEnhancedTriggerEvent, FUStEnhancedInputActionDesc>>>();
		foreach (KeyValuePair<int, FUStEnhancedInputActionDesc> item in GetAllEnhancedInputActionDesc())
		{
			FUStEnhancedInputActionDesc value = item.Value;
			string actionName = value.ActionName;
			int resID = value.ResID;
			EEnhancedTriggerEvent enhancedTriggerEvent = value.EnhancedTriggerEvent;
			if (sActionNameTriggerEventDescDict.TryGetValue(resID, out var value2))
			{
				if (value2.TryGetValue(actionName, out var value3))
				{
					value3.Add(enhancedTriggerEvent, value);
					continue;
				}
				value2[actionName] = new Dictionary<EEnhancedTriggerEvent, FUStEnhancedInputActionDesc> { { enhancedTriggerEvent, value } };
			}
			else
			{
				sActionNameTriggerEventDescDict[resID] = new Dictionary<string, Dictionary<EEnhancedTriggerEvent, FUStEnhancedInputActionDesc>> { 
				{
					actionName,
					new Dictionary<EEnhancedTriggerEvent, FUStEnhancedInputActionDesc> { { enhancedTriggerEvent, value } }
				} };
			}
		}
	}

	public static bool GetGlobalConfigByAlias(FName AliasName, out BGUGlobalConfigInfo ConfigInfo)
	{
		return sGlobalConfigInfoDict.TryGetValue(AliasName, out ConfigInfo);
	}

	public static BGUGlobalConfigInfo GetGlobalConfigByAliasChecked(FName AliasName)
	{
		return sGlobalConfigInfoDict[AliasName];
	}

	private static void InitGlobalConfigDesc()
	{
		sGlobalConfigInfoDict = new Dictionary<FName, BGUGlobalConfigInfo>();
		foreach (FUStGlobalConfigDesc item in GetAllGlobalConfigDesc().Values.ToList())
		{
			if (item != null)
			{
				BGUGlobalConfigInfo value = new BGUGlobalConfigInfo(item.ConfigInfo.ConfigType, item.ConfigInfo.ConfigValue);
				sGlobalConfigInfoDict.Add(new FName(item.ConfigInfo.AliasName), value);
			}
		}
	}

	private static void InitsChallengeDescDict()
	{
		sChallengeDescDict = new Dictionary<string, FUStChallengeDesc>();
		foreach (FUStChallengeDesc item in GetAllChallengeDesc().Values.ToList())
		{
			if (item != null)
			{
				sChallengeDescDict.Add(item.InteractGuid, item);
			}
		}
	}

	private static void InitCollectionSpawnInfoDict()
	{
		sCollectionSpawnInfoDict = new Dictionary<string, FUStCollectionSpawnInfoDesc>();
		foreach (FUStCollectionSpawnInfoDesc item in GetAllCollectionSpawnInfoDesc())
		{
			if (item != null && !(item.Guid == "") && !sCollectionSpawnInfoDict.ContainsKey(item.Guid))
			{
				sCollectionSpawnInfoDict.Add(item.Guid, item);
			}
		}
	}

	public static FUStBossRoomConfigDesc GetBossBossRoomConfig(string GUID)
	{
		if (sBossRoomDesc != null && sBossRoomDesc.TryGetValue(GUID, out var value))
		{
			return value;
		}
		return null;
	}

	private static void InitBossRoomDict()
	{
		sBossRoomCache = new Dictionary<int, Dictionary<int, List<string>>>();
		sBossRoomDesc = new Dictionary<string, FUStBossRoomConfigDesc>();
		foreach (FUStBossRoomConfigDesc item in GetAllBossRoomConfigDesc().Values.ToList())
		{
			if (item == null || item.IsEnable != EGSYesNo.Yes)
			{
				continue;
			}
			if (!sBossRoomCache.ContainsKey(item.LevelID))
			{
				sBossRoomCache.Add(item.LevelID, new Dictionary<int, List<string>>());
			}
			foreach (string item2 in item.BossGuid)
			{
				if (!sBossRoomDesc.ContainsKey(item2))
				{
					sBossRoomDesc.Add(item2, item);
				}
			}
			sBossRoomCache[item.LevelID].Add(item.ID, item.BossGuid.ToList());
		}
	}

	private static void InitGlobalCannotDeadExtraCacheDict()
	{
		sGlobalCannotDeadExtraCacheDict = new Dictionary<int, List<FUStGlobalCannotDeadExtraConfigDesc>>();
		foreach (FUStGlobalCannotDeadExtraConfigDesc item in GetAllGlobalCannotDeadExtraConfigDesc().Values.ToList())
		{
			if (item != null)
			{
				if (!sGlobalCannotDeadExtraCacheDict.ContainsKey(item.ResID))
				{
					sGlobalCannotDeadExtraCacheDict.Add(item.ResID, new List<FUStGlobalCannotDeadExtraConfigDesc>());
				}
				sGlobalCannotDeadExtraCacheDict[item.ResID].Add(item);
			}
		}
	}

	private static void InitBossDict()
	{
		sBossCache = new Dictionary<string, bool>();
		foreach (FUStBossRoomConfigDesc item in GetAllBossRoomConfigDesc().Values.ToList())
		{
			if (item != null)
			{
				_ = item.IsEnable;
				_ = 1;
			}
			foreach (string item2 in item.BossGuid)
			{
				if (!sBossCache.ContainsKey(item2))
				{
					sBossCache.Add(item2, value: true);
				}
			}
		}
	}

	public static Dictionary<int, List<string>> GetAllBossRoomsInLevel(int LevelID)
	{
		if (sBossRoomCache.ContainsKey(LevelID))
		{
			return sBossRoomCache[LevelID];
		}
		return null;
	}

	public static Dictionary<int, List<string>> GetAllBossRoomsInAllLevel()
	{
		Dictionary<int, List<string>> dictionary = new Dictionary<int, List<string>>();
		foreach (KeyValuePair<int, Dictionary<int, List<string>>> item in sBossRoomCache)
		{
			foreach (KeyValuePair<int, List<string>> item2 in item.Value)
			{
				dictionary.Add(item2.Key, item2.Value);
			}
		}
		return dictionary;
	}

	public static Dictionary<int, FUStGlobalConfigDesc> GetAllGlobalConfigDesc()
	{
		return BG_ProtobufDataAPI<FUStGlobalConfigDesc>.Get().GetAll();
	}

	public static Dictionary<int, FUStCustomStateMachineDesc> GetAllCustomStateMachineDescMap()
	{
		return sMapCustomStateMachineDescDict;
	}

	public static bool GetAllCustomStateMachineDesc(out List<FUStCustomStateMachineDesc> CustomStateMachineDescList)
	{
		CustomStateMachineDescList = null;
		if (sMapCustomStateMachineDescDict != null)
		{
			CustomStateMachineDescList = sMapCustomStateMachineDescDict.Values.ToList();
			return true;
		}
		return false;
	}

	public static bool GetAllGuideAssetConfigDesc(out List<FUStGuideAssetConfigDesc> GuideAssetConfigDescList)
	{
		GuideAssetConfigDescList = null;
		if (sMapGuideAssetConfigDict != null)
		{
			GuideAssetConfigDescList = sMapGuideAssetConfigDict.Values.ToList();
			return true;
		}
		return false;
	}

	public static bool GetAllTamerStrategyConfigDesc(out List<FUStTamerStrategyConfigDesc> TamerStrategyConfigDescList)
	{
		TamerStrategyConfigDescList = BG_ProtobufDataAPI<FUStTamerStrategyConfigDesc>.Get()?.GetAll().Values.ToList();
		if (TamerStrategyConfigDescList == null)
		{
			return false;
		}
		return true;
	}

	public static FUStTROStrategyConfigDesc GetTROStrategyConfigDesc(string Guid)
	{
		foreach (FUStTROStrategyConfigDesc value in BG_ProtobufDataAPI<FUStTROStrategyConfigDesc>.Get().GetAll().Values)
		{
			if (value.UnitGuid == Guid)
			{
				return value;
			}
		}
		return null;
	}

	public static FUStMovementOptStrategyConfigDesc GetMovementOptStrategyConfigDesc(string Guid)
	{
		foreach (FUStMovementOptStrategyConfigDesc value in BG_ProtobufDataAPI<FUStMovementOptStrategyConfigDesc>.Get().GetAll().Values)
		{
			if (value.UnitGuid == Guid)
			{
				return value;
			}
		}
		return null;
	}

	public static bool IsBossGuid(string Guid)
	{
		if (sBossCache.TryGetValue(Guid, out var value))
		{
			return value;
		}
		return false;
	}

	public static List<FUStInteractionMappingDesc> GetInteractionActionsByGroupID(int OriginID, int GroupID)
	{
		if (sMapInteractMapping.ContainsKey(OriginID) && sMapInteractMapping[OriginID].ContainsKey(GroupID))
		{
			return sMapInteractMapping[OriginID][GroupID];
		}
		return null;
	}

	public static List<FUStInteractionMappingDesc> GetInteractionActionsByGroupID(int GroupID)
	{
		foreach (KeyValuePair<int, Dictionary<int, List<FUStInteractionMappingDesc>>> item in sMapInteractMapping)
		{
			if (item.Value.ContainsKey(GroupID))
			{
				return item.Value[GroupID];
			}
		}
		return null;
	}

	public static List<FUStAiInteractionMappingDesc> GetAiInteractionActionsByGroupID(int OriginID, int GroupID)
	{
		if (sMapAiInteractMapping.ContainsKey(OriginID) && sMapAiInteractMapping[OriginID].ContainsKey(GroupID))
		{
			return sMapAiInteractMapping[OriginID][GroupID];
		}
		return null;
	}

	public static Dictionary<int, FUStRebirthPointDesc> GetAllRebirthPointDesc()
	{
		return BG_ProtobufDataAPI<FUStRebirthPointDesc>.Get().GetAll();
	}

	public static FUStRebirthPointDesc GetRebirthPointDesc(int RebirthPointID)
	{
		return BG_ProtobufDataAPI<FUStRebirthPointDesc>.Get().FindByID(RebirthPointID);
	}

	public static FUStRebirthAreaDesc GetRebirthAreaDesc(int Id)
	{
		return BG_ProtobufDataAPI<FUStRebirthAreaDesc>.Get().FindByID(Id);
	}

	public static FUStPhysicalHitBoneRuleDesc GetPhysicalHitBoneRuleDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStPhysicalHitBoneRuleDesc>.Get().FindByID(ResID);
	}

	public static FUStSuitDesc GetSuitDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStSuitDesc>.Get().FindByID(ResID);
	}

	public static FUStEnvironmentSwitchDesc GetEnvironmentSwitchDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStEnvironmentSwitchDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStEnvironmentSwitchDesc> GetAllEnvironmentSwitchDesc()
	{
		return BG_ProtobufDataAPI<FUStEnvironmentSwitchDesc>.Get().GetAll();
	}

	public static FUStUnitCollisionHitMoveDesc GetUnitCollisionHitMoveDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStUnitCollisionHitMoveDesc>.Get().FindByID(ResID);
	}

	public static FUStUnitDropDesc GetUnitDropDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStUnitDropDesc>.Get().FindByID(ResID);
	}

	public static FUStNianhuiNameListDesc GetNianhuiNameListDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStNianhuiNameListDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStNianhuiNameListDesc> GetAllNianhuiNameListDesc()
	{
		return BG_ProtobufDataAPI<FUStNianhuiNameListDesc>.Get().GetAll();
	}

	public static FUStNianhuiAwardDesc GetNianhuiAwardDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStNianhuiAwardDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStNianhuiAwardDesc> GetAllNianhuiAwardDesc()
	{
		return BG_ProtobufDataAPI<FUStNianhuiAwardDesc>.Get().GetAll();
	}

	public static FUStPlayerSkillCtrlDesc GetOriginalPlayerSkillCtrlDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStPlayerSkillCtrlDesc>.Get().FindByID(ResID);
	}

	public static FUStPlayerSkillCtrlDesc GetPlayerSkillCtrlDesc(int ResID, AActor TargetActor)
	{
		if (TargetActor is BGUCharacterCS { PassiveSkillData: { } passiveSkillData } && passiveSkillData.CachedPlayerSkillCtrlDescs.TryGetValue(ResID, out var value))
		{
			return value;
		}
		return BG_ProtobufDataAPI<FUStPlayerSkillCtrlDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStPlayerSkillCtrlDesc> GetAllPlayerSkillCtrlDesc()
	{
		return BG_ProtobufDataAPI<FUStPlayerSkillCtrlDesc>.Get().GetAll();
	}

	public static FUStOverlyingSkillSDesc GetOverlyingSkillSDesc(int SkillID)
	{
		return BG_ProtobufDataAPI<FUStOverlyingSkillSDesc>.Get().FindByID(SkillID);
	}

	public static FUStBuffGroupDesc GetBuffGroupDesc(int BuffGroupID)
	{
		return BG_ProtobufDataAPI<FUStBuffGroupDesc>.Get().FindByID(BuffGroupID);
	}

	public static FUStBuffDispGroupDesc GetBuffDispGroupDesc(int BuffGroupID)
	{
		return BG_ProtobufDataAPI<FUStBuffDispGroupDesc>.Get().FindByID(BuffGroupID);
	}

	public static Dictionary<int, FUStBuffGroupDesc> GetAllBuffGroupDesc()
	{
		return BG_ProtobufDataAPI<FUStBuffGroupDesc>.Get().GetAll();
	}

	public static int GetActualLevelNumericalStrength(this FUStUnitBattleInfoExtendDesc UnitBattleInfoExtendDesc)
	{
		if (B1Global.GOverrideLevelNumericalStrength <= 0)
		{
			return UnitBattleInfoExtendDesc.LevelNumericalStrength;
		}
		return B1Global.GOverrideLevelNumericalStrength;
	}

	public static FUStUnitLevelUpDesc GetUnitLevelUpDesc(int ResID, int BattleInfoExtendID)
	{
		FUStUnitCommDesc unitCommDesc = GetUnitCommDesc(ResID);
		if (unitCommDesc == null)
		{
			return null;
		}
		FUStUnitBattleInfoExtendDesc unitBattleInfoExtendDesc = GetUnitBattleInfoExtendDesc(BattleInfoExtendID);
		if (unitBattleInfoExtendDesc == null)
		{
			return null;
		}
		int resID = (int)unitBattleInfoExtendDesc.QualityType * 100000 + unitCommDesc.DefaultTenacity * 1000 + GetActualLevelNumericalStrength(unitBattleInfoExtendDesc);
		FUStUnitLevelUpDesc fUStUnitLevelUpDesc = BG_ProtobufDataAPI<FUStUnitLevelUpDesc>.Get().FindByID(resID);
		if (fUStUnitLevelUpDesc == null)
		{
			BGW_LogUtil.LogError($"未在LevelUp表中找到ResID：{ResID}对应的数据,尝试匹配关卡数值强度为1的数据映射，请检查UnitComm表和UnitBattleInfoExtendDesc表和LevelUp表");
			resID = (int)unitBattleInfoExtendDesc.QualityType * 100000 + unitCommDesc.DefaultTenacity * 1000 + 1;
			fUStUnitLevelUpDesc = BG_ProtobufDataAPI<FUStUnitLevelUpDesc>.Get().FindByID(resID);
			if (fUStUnitLevelUpDesc == null)
			{
				BGW_LogUtil.LogError($"未在LevelUp表中找到ResID：{ResID}对应的数据，请检查UnitComm表和UnitBattleInfoExtendDesc表和LevelUp表");
			}
		}
		return fUStUnitLevelUpDesc;
	}

	public static void InitBuffRuleMap()
	{
		sBuffRuleMap = new Dictionary<int, Dictionary<EBuffRuleType, List<BuffRuleInfo>>>();
		foreach (KeyValuePair<int, FUStBuffRuleDesc> item4 in GetAllBuffRuleDesc())
		{
			List<int> list = new List<int>();
			if (item4.Value.BuffID > 0)
			{
				list.Add(item4.Value.BuffID);
			}
			else
			{
				list = AnalyzeBuffIDInRule(item4.Value.BuffID);
			}
			foreach (int item5 in list)
			{
				if (sBuffRuleMap.ContainsKey(item5))
				{
					if (sBuffRuleMap[item5].ContainsKey(item4.Value.BuffRuleType))
					{
						BuffRuleInfo item = new BuffRuleInfo(item5, item4.Value);
						sBuffRuleMap[item5][item4.Value.BuffRuleType].Add(item);
						continue;
					}
					BuffRuleInfo item2 = new BuffRuleInfo(item5, item4.Value);
					List<BuffRuleInfo> list2 = new List<BuffRuleInfo>();
					list2.Add(item2);
					sBuffRuleMap[item5].Add(item4.Value.BuffRuleType, list2);
				}
				else
				{
					Dictionary<EBuffRuleType, List<BuffRuleInfo>> dictionary = new Dictionary<EBuffRuleType, List<BuffRuleInfo>>();
					BuffRuleInfo item3 = new BuffRuleInfo(item5, item4.Value);
					List<BuffRuleInfo> list3 = new List<BuffRuleInfo>();
					list3.Add(item3);
					dictionary.Add(item4.Value.BuffRuleType, list3);
					sBuffRuleMap.Add(item5, dictionary);
				}
			}
		}
	}

	public static Dictionary<EBuffRuleType, List<BuffRuleInfo>> GetBuffRuleDic(int BuffOriID)
	{
		if (sBuffRuleMap.TryGetValue(BuffOriID, out var value))
		{
			return value;
		}
		return null;
	}

	private static List<int> AnalyzeBuffIDListInRule(RepeatedField<int> BuffIDList)
	{
		List<int> list = new List<int>();
		if (BuffIDList == null)
		{
			return null;
		}
		for (int i = 0; i < BuffIDList.Count; i++)
		{
			list.AddRange(AnalyzeBuffIDInRule(BuffIDList[i]));
		}
		return list;
	}

	private static List<int> AnalyzeBuffIDInRule(int BuffID)
	{
		List<int> list = new List<int>();
		if (BuffID < 0)
		{
			FUStBuffGroupDesc buffGroupDesc = GetBuffGroupDesc(-BuffID);
			if (buffGroupDesc != null)
			{
				foreach (int buffID in buffGroupDesc.BuffIDList)
				{
					list.Add(buffID);
				}
			}
		}
		else
		{
			list.Add(BuffID);
		}
		return list;
	}

	public static void InitElementDmgRatioLevelMapping()
	{
		sElementDmgRatioMap = new Dictionary<int, float>();
		foreach (KeyValuePair<int, FUStElementDmgRatioLevelDesc> item in GetAllElementDmgRatioLevelDesc())
		{
			sElementDmgRatioMap.Add(item.Key, item.Value.Ratio);
		}
	}

	public static FUStMandatoryAITaskDesc GetMandatoryAITaskDesc(int ID)
	{
		return BG_ProtobufDataAPI<FUStMandatoryAITaskDesc>.Get().FindByID(ID);
	}

	public static FUStPlayerCameraDesc GetPlayerCameraDesc(int ResID, int CamID)
	{
		foreach (KeyValuePair<int, FUStPlayerCameraDesc> item in GetAllPlayerCameraDesc())
		{
			if (item.Value.ResID == ResID && item.Value.CamID == CamID)
			{
				return item.Value;
			}
		}
		return null;
	}

	public static List<FUStMandatoryAITaskDesc> GetMandatoryAITaskDescListByResID(int ResID)
	{
		List<FUStMandatoryAITaskDesc> list = new List<FUStMandatoryAITaskDesc>();
		foreach (KeyValuePair<int, FUStMandatoryAITaskDesc> item in GetAllMandatoryAITaskDesc())
		{
			if (item.Value.ResID == ResID)
			{
				list.Add(item.Value);
			}
		}
		return list;
	}

	public static FUStUnitFootstepDesc GetUnitFootstepDesc(int ConfigID)
	{
		return BG_ProtobufDataAPI<FUStUnitFootstepDesc>.Get().FindByID(ConfigID);
	}

	public static List<FUStUnitFootstepDesc> GetUnitFootstepDescByResID(int ResID)
	{
		List<FUStUnitFootstepDesc> list = new List<FUStUnitFootstepDesc>();
		Dictionary<int, FUStUnitFootstepDesc> all = BG_ProtobufDataAPI<FUStUnitFootstepDesc>.Get().GetAll();
		if (all != null)
		{
			foreach (KeyValuePair<int, FUStUnitFootstepDesc> item in all)
			{
				if (item.Value.UnitResID == ResID)
				{
					list.Add(item.Value);
				}
			}
		}
		return list;
	}

	public static FUStEQSSettingDesc GetEQSSettingDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStEQSSettingDesc>.Get().FindByID(ResID);
	}

	public static FUStPassiveSkillDesc GetPassiveSkillDescByMappingIndex(int PassiveSkillID, int PassiveSkillMappingIndexID)
	{
		if (sMapPassiveSkill.TryGetValue(PassiveSkillID, out var value) && value != null && value.TryGetValue(PassiveSkillMappingIndexID, out var value2))
		{
			return value2;
		}
		return null;
	}

	public static Dictionary<int, FUStPassiveSkillDesc> GetPassiveSkillDescDic(int PassiveSkillID)
	{
		Dictionary<int, FUStPassiveSkillDesc> result = new Dictionary<int, FUStPassiveSkillDesc>();
		if (sMapPassiveSkill.TryGetValue(PassiveSkillID, out var value))
		{
			result = value;
		}
		return result;
	}

	public static Dictionary<int, FUStPassiveSkillDesc> GetAllPassiveSkillDesc()
	{
		return BG_ProtobufDataAPI<FUStPassiveSkillDesc>.Get().GetAll();
	}

	public static string GetPassiveSkillToBlame()
	{
		return "feiluo";
	}

	public static FUStUnitAudioBankMapDesc GetUnitAudioBankMapDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStUnitAudioBankMapDesc>.Get().FindByID(ResID);
	}

	public static FUStEliteBuffConfigDesc GetEliteBuffConfigDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStEliteBuffConfigDesc>.Get().FindByID(ResID);
	}

	public static FUStMapMobConfigDesc GetMapMobConfigDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStMapMobConfigDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStMobLevelMappingDesc> GetAllMobLevelMappingDesc()
	{
		return BG_ProtobufDataAPI<FUStMobLevelMappingDesc>.Get().GetAll();
	}

	public static FUStB2DSpecialStateShowDesc GetFUStB2DSpecialStateShowDesc(int SpecialState)
	{
		return BG_ProtobufDataAPI<FUStB2DSpecialStateShowDesc>.Get().FindByID(SpecialState);
	}

	public static FUStB2DNPCDesc GetFUStB2DNPCDesc(int NPCId)
	{
		return BG_ProtobufDataAPI<FUStB2DNPCDesc>.Get().FindByID(NPCId);
	}

	public static FUStUnitSpecialMoveDesc GetUnitSpecialMoveDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStUnitSpecialMoveDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStEnhancedInputActionDesc> GetAllEnhancedInputActionDesc()
	{
		return BG_ProtobufDataAPI<FUStEnhancedInputActionDesc>.Get().GetAll();
	}

	public static FUStEnhancedInputActionDesc GetEnhancedInputActionDesc(int ID)
	{
		return BG_ProtobufDataAPI<FUStEnhancedInputActionDesc>.Get().FindByID(ID);
	}

	public static Dictionary<int, FUStChallengeDesc> GetAllChallengeDesc()
	{
		return BG_ProtobufDataAPI<FUStChallengeDesc>.Get().GetAll();
	}

	public static FUStChallengeDesc GetChallengeDesc(int ID)
	{
		return BG_ProtobufDataAPI<FUStChallengeDesc>.Get().FindByID(ID);
	}

	public static FUStChallengeDesc GetChallengeDescByGuid(string Guid)
	{
		if (sChallengeDescDict.TryGetValue(Guid, out var value))
		{
			return value;
		}
		return null;
	}

	public static Dictionary<int, FUStSkillsRefCheckWhiteListDesc> GetAllSkillsRefCheckWhiteListDesc()
	{
		return BG_ProtobufDataAPI<FUStSkillsRefCheckWhiteListDesc>.Get().GetAll();
	}

	public static int GetDialogueConfigIdWithSetionId(int SectionID)
	{
		if (DialogueSectionToGroupDict.TryGetValue(SectionID, out var value))
		{
			return value;
		}
		return -1;
	}

	public static FUStUnitPhysicalAnimationDesc GetUnitPhysicalAnimationDesc(int ID)
	{
		return BG_ProtobufDataAPI<FUStUnitPhysicalAnimationDesc>.Get().FindByID(ID);
	}

	public static FUStFixFunctionDesc GetFixFunctionDesc(int ID)
	{
		return BG_ProtobufDataAPI<FUStFixFunctionDesc>.Get().FindByID(ID);
	}

	public static FUStGroupAISDesc GetGroupAIDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStGroupAISDesc>.Get().FindByID(ResID);
	}

	public static FUStDialogueIDMappingDesc GetDialogueIDMappingDesc(int OldID)
	{
		return BG_ProtobufDataAPI<FUStDialogueIDMappingDesc>.Get().FindByID(OldID);
	}

	private static void InitDialogue_FacialAnimPreloadMap()
	{
		foreach (KeyValuePair<int, FUStDialogueDesc> item in GetAllDialogueDesc())
		{
			int resID = item.Value.ResID;
			if (resID > 0)
			{
				if (!FacialAnimPreloadMapping.ContainsKey(resID))
				{
					FacialAnimPreloadMapping.Add(resID, new List<string>());
				}
				FacialAnimPreloadMapping[resID].Add(item.Value.FacialAnimPath);
			}
		}
	}

	public static List<string> GetFacialAnimPreloadAssetPathList(int ResID)
	{
		if (FacialAnimPreloadMapping.TryGetValue(ResID, out var value))
		{
			return value;
		}
		return null;
	}

	public static FUStDialogueDesc GetDialogueDesc(int ID)
	{
		FUStDialogueIDMappingDesc dialogueIDMappingDesc = GetDialogueIDMappingDesc(ID);
		if (dialogueIDMappingDesc != null)
		{
			ID = dialogueIDMappingDesc.NewID;
		}
		return BG_ProtobufDataAPI<FUStDialogueDesc>.Get().FindByID(ID);
	}

	public static Dictionary<int, FUStDialogueDesc> GetAllDialogueDesc()
	{
		return BG_ProtobufDataAPI<FUStDialogueDesc>.Get().GetAll();
	}

	public static FUStUIWordDesc GetUIWordDesc(int ID)
	{
		return BG_ProtobufDataAPI<FUStUIWordDesc>.Get().FindByID(ID);
	}

	public static FUStTalentDisplayDesc GetTalentDisplayDesc(int ID)
	{
		return BG_ProtobufDataAPI<FUStTalentDisplayDesc>.Get().FindByID(ID);
	}

	public static FUStTalentLvUpCfgDesc GetTalentLvUpCfgDesc(int ID)
	{
		return BG_ProtobufDataAPI<FUStTalentLvUpCfgDesc>.Get().FindByID(ID);
	}

	public static TalentDisplayCfg GetTalentDisplayCfg(FUStTalentDisplayDesc TalentDisplayDesc, int Level)
	{
		for (int i = 0; i < TalentDisplayDesc.DisplayCfg.Count; i++)
		{
			if (TalentDisplayDesc.DisplayCfg[i].Level == Level)
			{
				return TalentDisplayDesc.DisplayCfg[i];
			}
		}
		return null;
	}

	public static string GetTalentDisplayDesc(string Desc, int Level)
	{
		return BracketsReg.Replace(Desc, delegate(Match Match)
		{
			Match match = NumReg.Match(Match.Value);
			if (match.Success && int.TryParse(match.Value, out var result))
			{
				FUStTalentLvUpCfgDesc talentLvUpCfgDesc = GetTalentLvUpCfgDesc(result);
				if (talentLvUpCfgDesc != null)
				{
					return $"{(float)FMath.Min(talentLvUpCfgDesc.Base + Level * talentLvUpCfgDesc.LvFactor, talentLvUpCfgDesc.Max) * 0.01f}";
				}
			}
			return Match.Value;
		});
	}

	public static FText GetTalentDisplayDesc(FText Desc, int Level)
	{
		return FText.FromString(GetTalentDisplayDesc(Desc.ToString(), Level));
	}

	public static FUStAiConversationEventDesc GetAiConversationEventDesc(int ID)
	{
		return BG_ProtobufDataAPI<FUStAiConversationEventDesc>.Get().FindByID(ID);
	}

	public static FUStAiConversationGroupDesc GetAiConversationGroupDesc(int ID)
	{
		return BG_ProtobufDataAPI<FUStAiConversationGroupDesc>.Get().FindByID(ID);
	}

	public static Dictionary<int, FUStAiConversationGroupDesc> GetAllAiConversationGroupDesc()
	{
		return BG_ProtobufDataAPI<FUStAiConversationGroupDesc>.Get().GetAll();
	}

	public static Dictionary<int, FUStAiConversationEventDesc> GetAllAiConversationEventDesc()
	{
		return BG_ProtobufDataAPI<FUStAiConversationEventDesc>.Get().GetAll();
	}

	public static FUStImmobilizeSkillConfigDesc GetImmobilizeSkillConfigDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStImmobilizeSkillConfigDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStImmobilizeSkillConfigDesc> GetAllImmobilizeSkillConfigDesc()
	{
		return BG_ProtobufDataAPI<FUStImmobilizeSkillConfigDesc>.Get().GetAll();
	}

	public static FUStTransQiTianDaShengConfigDesc GetOriginalTransQiTianDaShengConfigDesc(int ConfigID)
	{
		return BG_ProtobufDataAPI<FUStTransQiTianDaShengConfigDesc>.Get().FindByID(ConfigID);
	}

	public static Dictionary<int, FUStTransQiTianDaShengConfigDesc> GetAllTransQiTianDaShengConfigDesc()
	{
		return BG_ProtobufDataAPI<FUStTransQiTianDaShengConfigDesc>.Get().GetAll();
	}

	public static FUStTransQiTianDaShengConfigDesc GetTransQiTianDaShengConfigDesc(int ConfigID, AActor TargetActor)
	{
		if (TargetActor is BGUCharacterCS { PassiveSkillData: { } passiveSkillData } && passiveSkillData.CachedTransQiTianDaShengConfigDescs.TryGetValue(ConfigID, out var value))
		{
			return value;
		}
		return BG_ProtobufDataAPI<FUStTransQiTianDaShengConfigDesc>.Get().FindByID(ConfigID);
	}

	public static FUStSealingSpellSkillConfigDesc GetOriginalSealingSpellSkillConfigDesc(int ID)
	{
		return BG_ProtobufDataAPI<FUStSealingSpellSkillConfigDesc>.Get().FindByID(ID);
	}

	public static FUStSealingSpellSkillConfigDesc GetSealingSpellSkillConfigDesc(int ConfigID, AActor Caster)
	{
		if (Caster is BGUCharacterCS { PassiveSkillData: { } passiveSkillData } && passiveSkillData.CachedSealingSpellSkillConfigDescs.TryGetValue(ConfigID, out var value))
		{
			return value;
		}
		return GetOriginalSealingSpellSkillConfigDesc(ConfigID);
	}

	public static Dictionary<int, FUStSealingSpellSkillConfigDesc> GetAllSealingSpellSkillConfigDesc(AActor Caster)
	{
		if (Caster is BGUCharacterCS { PassiveSkillData: { } passiveSkillData } && passiveSkillData.CachedSealingSpellSkillConfigDescs.Count > 0)
		{
			return passiveSkillData.CachedSealingSpellSkillConfigDescs;
		}
		return BG_ProtobufDataAPI<FUStSealingSpellSkillConfigDesc>.Get().GetAll();
	}

	public static FUStPhantomRushSkillConfigDesc GetPhantomRushSkillOrgConfigDesc(int ConfigID)
	{
		return BG_ProtobufDataAPI<FUStPhantomRushSkillConfigDesc>.Get().FindByID(ConfigID);
	}

	public static FUStPhantomRushSkillConfigDesc GetPhantomRushSkillConfigDesc(int ConfigID, AActor Caster)
	{
		if (Caster is BGUCharacterCS { PassiveSkillData: { } passiveSkillData } && passiveSkillData.CachedFUStPhantomRushSkillConfigDescs.TryGetValue(ConfigID, out var value))
		{
			return value;
		}
		return GetPhantomRushSkillOrgConfigDesc(ConfigID);
	}

	public static FUStPhantomRushSkillConfigDesc GetPhantomRushSkillConfigDesc(int ConfigID)
	{
		return GetPhantomRushSkillOrgConfigDesc(ConfigID);
	}

	public static FUStIronBodyConfigDesc GetOriginalIronBodyConfigDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStIronBodyConfigDesc>.Get().FindByID(ResID);
	}

	public static FUStIronBodyConfigDesc GetIronBodyConfigDesc(int ResID, AActor TargetActor)
	{
		if (TargetActor is BGUCharacterCS { PassiveSkillData: { } passiveSkillData } && passiveSkillData.CachedIronBodyConfigDescs.TryGetValue(ResID, out var value))
		{
			return value;
		}
		return BG_ProtobufDataAPI<FUStIronBodyConfigDesc>.Get().FindByID(ResID);
	}

	public static FUStAiConversationContentDesc GetAiConversationContentDesc(int ID)
	{
		return BG_ProtobufDataAPI<FUStAiConversationContentDesc>.Get().FindByID(ID);
	}

	public static Dictionary<int, FUStAiConversationContentDesc> GetAllAiConversationContentDesc()
	{
		return BG_ProtobufDataAPI<FUStAiConversationContentDesc>.Get().GetAll();
	}

	public static FUStTaskStageDesc GetTaskStageDesc(int ID)
	{
		return BG_ProtobufDataAPI<FUStTaskStageDesc>.Get().FindByID(ID);
	}

	public static Dictionary<int, FUStTaskStageDesc> GetAllTaskStageDesc()
	{
		return BG_ProtobufDataAPI<FUStTaskStageDesc>.Get().GetAll();
	}

	public static FUStTaskLineDesc GetTaskLineDesc(int ID)
	{
		return BG_ProtobufDataAPI<FUStTaskLineDesc>.Get().FindByID(ID);
	}

	public static Dictionary<int, FUStTaskLineDesc> GetAllTaskLineDesc()
	{
		return BG_ProtobufDataAPI<FUStTaskLineDesc>.Get().GetAll();
	}

	public static FUStOnlineScreenMsgConfDesc GetOnlineScreenMsgConfDescByType(EScreenMsgType ScreenMsgType)
	{
		if (sOnlineScreenMsgConfDict != null && sOnlineScreenMsgConfDict.TryGetValue(ScreenMsgType, out var value))
		{
			return value;
		}
		return null;
	}

	public static Dictionary<int, FUStOnlineScreenMsgConfDesc> GetAllOnlineScreenMsgConfDesc()
	{
		return BG_ProtobufDataAPI<FUStOnlineScreenMsgConfDesc>.Get().GetAll();
	}

	public static FUStOnlineScreenMsgConfDesc GetOnlineScreenMsgConfDescById(int ID)
	{
		return BG_ProtobufDataAPI<FUStOnlineScreenMsgConfDesc>.Get().FindByID(ID);
	}

	public static Dictionary<int, FUStRichTextIconDesc> GetAllRichTextIconDesc()
	{
		return BG_ProtobufDataAPI<FUStRichTextIconDesc>.Get().GetAll();
	}

	public static Dictionary<int, FUStSuperArmorLevelDesc> GetAllSuperArmorLevelDesc()
	{
		return BG_ProtobufDataAPI<FUStSuperArmorLevelDesc>.Get().GetAll();
	}

	public static FUStSuperArmorLevelDesc GetSuperArmorLevelDescByID(int ID)
	{
		return BG_ProtobufDataAPI<FUStSuperArmorLevelDesc>.Get().FindByID(ID);
	}

	public static FUStSuperArmorLevelDesc GetSuperArmorLevelDescOrgByID(int ID)
	{
		return BG_ProtobufDataAPI<FUStSuperArmorLevelDesc>.Get().FindByID(ID);
	}

	public static float GetSuperArmorLevelDescFinalvalueByID(int ID, AActor Caster)
	{
		if (Caster is BGUCharacterCS { PassiveSkillData: { } passiveSkillData } && passiveSkillData.CachedFUStSuperArmorLevelDescs.TryGetValue(ID, out var value))
		{
			return value.SuperArmorValue;
		}
		return GetSuperArmorLevelDescOrgByID(ID).SuperArmorValue;
	}

	public static List<FUStCollectionSpawnInfoDesc> GetAllCollectionSpawnInfoDesc()
	{
		return BG_ProtobufDataAPI<FUStCollectionSpawnInfoDesc>.Get().GetAllList();
	}

	public static Dictionary<int, FUStBossRoomConfigDesc> GetAllBossRoomConfigDesc()
	{
		return BG_ProtobufDataAPI<FUStBossRoomConfigDesc>.Get().GetAll();
	}

	public static FUStCollectionSpawnInfoDesc GetCollectionSpawnInfoDesc(string Guid)
	{
		if (sCollectionSpawnInfoDict.TryGetValue(Guid, out var value))
		{
			return value;
		}
		return null;
	}

	public static Dictionary<int, FUStCollectionSpawnGroupDesc> GetAllCollectionSpawnGroupDesc()
	{
		return BG_ProtobufDataAPI<FUStCollectionSpawnGroupDesc>.Get().GetAll();
	}

	public static FUStCollectionSpawnGroupDesc GetCollectionSpawnGroupDescByID(int ID)
	{
		return BG_ProtobufDataAPI<FUStCollectionSpawnGroupDesc>.Get().FindByID(ID);
	}

	public static FUStCollectionEventProbabilityDesc GetCollectionEventProbabilityDescByID(int ID)
	{
		return BG_ProtobufDataAPI<FUStCollectionEventProbabilityDesc>.Get().FindByID(ID);
	}

	public static Dictionary<int, FUStAttackerHitFXMappingDesc> GetAllAttackerHitFXMappingDesc()
	{
		return BG_ProtobufDataAPI<FUStAttackerHitFXMappingDesc>.Get().GetAll();
	}

	public static Dictionary<int, FUStAttackerHitAudioEventMappingDesc> GetAllAttackerHitAudioEventMappingDesc()
	{
		return BG_ProtobufDataAPI<FUStAttackerHitAudioEventMappingDesc>.Get().GetAll();
	}

	public static Dictionary<int, FUStNPCBaseInfoDesc> GetAllNPCBaseInfoDesc()
	{
		return BG_ProtobufDataAPI<FUStNPCBaseInfoDesc>.Get().GetAll();
	}

	public static FUStNPCBaseInfoDesc GetNPCBaseInfoDesc(int ID)
	{
		return BG_ProtobufDataAPI<FUStNPCBaseInfoDesc>.Get().FindByID(ID);
	}

	public static Dictionary<int, FUStTeamRelationConfigDesc> GetAllTeamRelationConfigDesc()
	{
		return BG_ProtobufDataAPI<FUStTeamRelationConfigDesc>.Get().GetAll();
	}

	public static Dictionary<int, FUStCBGTemplateDesc> GetAllCBGTemplateDesc()
	{
		return BG_ProtobufDataAPI<FUStCBGTemplateDesc>.Get().GetAll();
	}

	public static FUStCBGTemplateDesc GetCBGTemplateDesc(int ID)
	{
		return BG_ProtobufDataAPI<FUStCBGTemplateDesc>.Get().FindByID(ID);
	}

	public static FUStWeakPerformConfigDesc GetWeakPerformConfigDesc(int ID)
	{
		return BG_ProtobufDataAPI<FUStWeakPerformConfigDesc>.Get().FindByID(ID);
	}

	public static FUStBossRoomConfigDesc GetAllBossRoomConfigDesc(int ID)
	{
		return BG_ProtobufDataAPI<FUStBossRoomConfigDesc>.Get().FindByID(ID);
	}

	public static Dictionary<int, FUStDeadSeqUnitConfigDesc> GetAllDeadSeqUnitConfigDesc()
	{
		return BG_ProtobufDataAPI<FUStDeadSeqUnitConfigDesc>.Get().GetAll();
	}

	public static FUStDetonateConfigDesc GetDetonateConfigDesc(int ID)
	{
		return BG_ProtobufDataAPI<FUStDetonateConfigDesc>.Get().FindByID(ID);
	}

	public static FUStAttachedNiagaraByHitDesc GetAttachedNiagaraByHitDesc(int ID)
	{
		return BG_ProtobufDataAPI<FUStAttachedNiagaraByHitDesc>.Get().FindByID(ID);
	}

	public static Dictionary<int, FUStAttachedNiagaraByHitDesc> GetAllAttachedNiagaraByHitDesc()
	{
		return BG_ProtobufDataAPI<FUStAttachedNiagaraByHitDesc>.Get().GetAll();
	}

	public static FUStAbnormalStateUIBlackListDesc GetAbnormalStateUIBlackListDesc(int ID)
	{
		return BG_ProtobufDataAPI<FUStAbnormalStateUIBlackListDesc>.Get().FindByID(ID);
	}

	public static Dictionary<int, FUStElementDmgRatioLevelDesc> GetAllElementDmgRatioLevelDesc()
	{
		return BG_ProtobufDataAPI<FUStElementDmgRatioLevelDesc>.Get().GetAll();
	}

	public static FUStStreamingLevelStateDesc GetStreamingLevelStateDesc(int ID)
	{
		return BG_ProtobufDataAPI<FUStStreamingLevelStateDesc>.Get().FindByID(ID);
	}

	public static Dictionary<int, FUStStreamingLevelStateDesc> GetAllStreamingLevelStateDesc()
	{
		return BG_ProtobufDataAPI<FUStStreamingLevelStateDesc>.Get().GetAll();
	}

	public static Dictionary<int, FUStMapSymbolDesc> GetAllFUStMapSymbolDesc()
	{
		return BG_ProtobufDataAPI<FUStMapSymbolDesc>.Get().GetAll();
	}

	public static FUStAttrCopyConfigDesc GetOriginalAttrCopyDesc(int ID)
	{
		return BG_ProtobufDataAPI<FUStAttrCopyConfigDesc>.Get().FindByID(ID);
	}

	public static FUStAttrCopyConfigDesc GetAttrCopyDesc(int ID, AActor Caster)
	{
		if (Caster is BGUCharacterCS { PassiveSkillData: { } passiveSkillData } && passiveSkillData.CacheAttrCopyConfigDescs.TryGetValue(ID, out var value))
		{
			return value;
		}
		return BG_ProtobufDataAPI<FUStAttrCopyConfigDesc>.Get().FindByID(ID);
	}

	public static Dictionary<int, FUStAttrCopyConfigDesc> GetAllAttrCopyDesc()
	{
		return BG_ProtobufDataAPI<FUStAttrCopyConfigDesc>.Get().GetAll();
	}

	public static float GetElementDmgRatio(int ElementDmgLevel)
	{
		if (sElementDmgRatioMap.TryGetValue(ElementDmgLevel, out var value))
		{
			return value;
		}
		return 0f;
	}

	private static void InitAbnormalCommConfig()
	{
		AbnormalCommConfigDesc = new FUStAbnormalCommConfigDesc();
		using Dictionary<int, FUStAbnormalCommConfigDesc>.Enumerator enumerator = GetAllAbnormalCommConfigDesc().GetEnumerator();
		if (enumerator.MoveNext())
		{
			AbnormalCommConfigDesc = enumerator.Current.Value;
		}
	}

	private static void InitBeAttackedDispInfo()
	{
		sMapBeAttackedDispInfo = new Dictionary<int, Dictionary<int, List<FUStBeAttackedDispInfoDesc>>>();
		foreach (KeyValuePair<int, FUStBeAttackedDispInfoDesc> item in GetAllBeAttackedDispInfoDesc())
		{
			FUStBeAttackedDispInfoDesc value = item.Value;
			if (value == null)
			{
				continue;
			}
			if (sMapBeAttackedDispInfo.TryGetValue(value.ResID, out var value2))
			{
				if (value2.TryGetValue(value.BeAttackedInfoID, out var _))
				{
					sMapBeAttackedDispInfo[value.ResID][value.BeAttackedInfoID].Add(value);
					continue;
				}
				sMapBeAttackedDispInfo[value.ResID].Add(value.BeAttackedInfoID, new List<FUStBeAttackedDispInfoDesc> { value });
			}
			else
			{
				sMapBeAttackedDispInfo.Add(value.ResID, new Dictionary<int, List<FUStBeAttackedDispInfoDesc>> { 
				{
					value.BeAttackedInfoID,
					new List<FUStBeAttackedDispInfoDesc> { value }
				} });
			}
		}
	}

	private static void InitBeAttackedStiffLevelMapping()
	{
		sMapBeAttackedStiffLevelMapping = new Dictionary<int, Dictionary<int, int>>();
		foreach (KeyValuePair<int, FUStBeAttackedStiffLevelMappingDesc> item in GetAllBeAttackedStiffLevelMappingDesc())
		{
			FUStBeAttackedStiffLevelMappingDesc value = item.Value;
			if (value != null)
			{
				int resID = value.ResID;
				int originStiffLevel = value.OriginStiffLevel;
				int mappingStiffLevel = value.MappingStiffLevel;
				if (!sMapBeAttackedStiffLevelMapping.TryGetValue(resID, out var _))
				{
					sMapBeAttackedStiffLevelMapping[resID] = new Dictionary<int, int>();
				}
				sMapBeAttackedStiffLevelMapping[resID][originStiffLevel] = mappingStiffLevel;
			}
		}
	}

	private static void InitMapSymbolDescInfo()
	{
		Guid2MapSymbolDescDict.Clear();
		foreach (KeyValuePair<int, FUStMapSymbolDesc> item in GetAllFUStMapSymbolDesc().ToList())
		{
			Guid2MapSymbolDescDict[item.Value.Guid] = item.Value;
		}
	}

	private static void InitGlobalAlchemyList()
	{
		sGlobalAlchemyList.Clear();
		sGlobalAlchemyAttrValue.Clear();
		TBItemRecipeDesc tBItemRecipeDesc = GameDBRuntime.GetTBItemRecipeDesc();
		foreach (AttrItemDesc item2 in GameDBRuntime.GetTBAttrItemDesc().List)
		{
			foreach (ItemRecipeDesc item3 in tBItemRecipeDesc.List)
			{
				if (item3.IsAttrItem == YesNoType.Yes && item2.Id == item3.TargetItem.Id)
				{
					KeyValuePair<KeyValuePair<int, int>, KeyValuePair<AttrItemDesc, ItemRecipeDesc>> item = new KeyValuePair<KeyValuePair<int, int>, KeyValuePair<AttrItemDesc, ItemRecipeDesc>>(new KeyValuePair<int, int>(item2.Id, item3.Id), new KeyValuePair<AttrItemDesc, ItemRecipeDesc>(item2, item3));
					sGlobalAlchemyList.Add(item);
					if (item2.Attrs.Count >= 1 && !sGlobalAlchemyAttrValue.ContainsKey(item2.Attrs[0].Type))
					{
						sGlobalAlchemyAttrValue.Add(item2.Attrs[0].Type, item2.Attrs[0].Value);
					}
					break;
				}
			}
		}
	}

	public static bool TryGetAlchemyAttrValue(EBGUAttrFloat AttrType, out float AttrValue)
	{
		return sGlobalAlchemyAttrValue.TryGetValue(AttrType, out AttrValue);
	}

	public static bool TryGetAlchemyInfo(int Index, out int ItemId, out int RecipeId, out AttrItemDesc OutAttrItemDesc, out ItemRecipeDesc OutItemRecipeDesc)
	{
		if (Index >= 0 && Index < sGlobalAlchemyList.Count)
		{
			KeyValuePair<KeyValuePair<int, int>, KeyValuePair<AttrItemDesc, ItemRecipeDesc>> keyValuePair = sGlobalAlchemyList[Index];
			ItemId = keyValuePair.Key.Key;
			RecipeId = keyValuePair.Key.Value;
			OutAttrItemDesc = keyValuePair.Value.Key;
			OutItemRecipeDesc = keyValuePair.Value.Value;
			return true;
		}
		ItemId = 0;
		RecipeId = 0;
		OutAttrItemDesc = null;
		OutItemRecipeDesc = null;
		return false;
	}

	public static bool TryGetAlchemyInfo(int ItemId, bool IsRecipe, out AttrItemDesc OutAttrItemDesc, out ItemRecipeDesc OutItemRecipeDesc)
	{
		foreach (KeyValuePair<KeyValuePair<int, int>, KeyValuePair<AttrItemDesc, ItemRecipeDesc>> sGlobalAlchemy in sGlobalAlchemyList)
		{
			if ((sGlobalAlchemy.Key.Key == ItemId && !IsRecipe) || (sGlobalAlchemy.Key.Value == ItemId && IsRecipe))
			{
				OutAttrItemDesc = sGlobalAlchemy.Value.Key;
				OutItemRecipeDesc = sGlobalAlchemy.Value.Value;
				return true;
			}
		}
		OutAttrItemDesc = null;
		OutItemRecipeDesc = null;
		return false;
	}

	public static FUStMapSymbolDesc GetMapSymbolDesc(string Guid)
	{
		if (Guid2MapSymbolDescDict.ContainsKey(Guid))
		{
			return Guid2MapSymbolDescDict[Guid];
		}
		return null;
	}

	public static FUStAbnormalCommConfigDesc GetAbnormalCommConfig()
	{
		return AbnormalCommConfigDesc;
	}

	private static Dictionary<int, FUStAbnormalCommConfigDesc> GetAllAbnormalCommConfigDesc()
	{
		return BG_ProtobufDataAPI<FUStAbnormalCommConfigDesc>.Get().GetAll();
	}

	public static FUStPlayerTransUnitConfDesc GetFUStPlayerTransUnitConfDesc(int ResID, int SolutionID = 0)
	{
		return BG_ProtobufDataAPI<FUStPlayerTransUnitConfDesc>.Get().FindByID(ResID * 100 + SolutionID);
	}

	public static FUStLifeSavingHairConfigDesc GetOriginalLifeSavingHairConfigDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStLifeSavingHairConfigDesc>.Get().FindByID(ResID);
	}

	public static FUStLifeSavingHairConfigDesc GetLifeSavingHairConfigDesc(int ID, AActor Caster)
	{
		if (Caster is BGUCharacterCS { PassiveSkillData: { } passiveSkillData } && passiveSkillData.CachedLifeSavingHairConfigDescs.TryGetValue(ID, out var value))
		{
			return value;
		}
		return BG_ProtobufDataAPI<FUStLifeSavingHairConfigDesc>.Get().FindByID(ID);
	}

	public static FUStPigsyStoryLibraryDesc GetPigsyStoryLibraryDesc(int ID)
	{
		return BG_ProtobufDataAPI<FUStPigsyStoryLibraryDesc>.Get().FindByID(ID);
	}

	public static Dictionary<int, FUStPigsyStoryLibraryDesc> GetAllPigsyStoryLibraryDesc()
	{
		return BG_ProtobufDataAPI<FUStPigsyStoryLibraryDesc>.Get().GetAll();
	}

	private static void InitPigsyStoryIAndRLibrary()
	{
		foreach (KeyValuePair<int, FUStPigsyStoryIAndRLibraryDesc> item in BG_ProtobufDataAPI<FUStPigsyStoryIAndRLibraryDesc>.Get().GetAll())
		{
			EPigsyStoryIAndRType iAndRType = item.Value.IAndRType;
			if (!PigsyStoryIAndRLibrary.ContainsKey(iAndRType))
			{
				PigsyStoryIAndRLibrary.Add(iAndRType, new List<int>());
			}
			foreach (int aiConversationID in item.Value.AiConversationIDs)
			{
				if (!PigsyStoryIAndRLibrary[iAndRType].Contains(aiConversationID))
				{
					PigsyStoryIAndRLibrary[iAndRType].Add(aiConversationID);
				}
			}
		}
	}

	public static List<int> GetPigsyStoryIAndRLibrary(EPigsyStoryIAndRType Type)
	{
		if (PigsyStoryIAndRLibrary.ContainsKey(Type))
		{
			return PigsyStoryIAndRLibrary[Type];
		}
		return null;
	}

	public static FUStEffectiveHitProjectileEffectDesc GetOriginalEffectiveHitProjectileEffectDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStEffectiveHitProjectileEffectDesc>.Get().FindByID(ResID);
	}

	public static FUStEffectiveHitProjectileEffectDesc GetEffectiveHitProjectileEffectDesc(int ResID, AActor Attacker)
	{
		if (Attacker is BGUCharacterCS { PassiveSkillData: { } passiveSkillData } && passiveSkillData.CachedEffectiveHitProjectileEffectDescs.TryGetValue(ResID, out var value))
		{
			return value;
		}
		return BG_ProtobufDataAPI<FUStEffectiveHitProjectileEffectDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStTransActiveStateDesc> GetAllFUStTransActiveStateDesc()
	{
		return BG_ProtobufDataAPI<FUStTransActiveStateDesc>.Get().GetAll();
	}

	public static Dictionary<int, FUStLevelSequenceClearBattleItemConfigDesc> GetAllLevelSequenceClearBattleItemConfigDesc()
	{
		return BG_ProtobufDataAPI<FUStLevelSequenceClearBattleItemConfigDesc>.Get().GetAll();
	}

	public static Dictionary<int, FUStAkEventMarkerDesc> GetAllAkEventMarkerDesc()
	{
		return BG_ProtobufDataAPI<FUStAkEventMarkerDesc>.Get().GetAll();
	}

	public static List<FUStAkEventMarkerDesc> GetAkEventMarkerDesc(string EventName)
	{
		if (sMarkerDesc.ContainsKey(EventName))
		{
			return sMarkerDesc[EventName];
		}
		return null;
	}

	public static List<AKMarkerInfo> GetAkEventCultureMarkers(FUStAkEventMarkerDesc Desc, string Culture)
	{
		if (string.IsNullOrEmpty(Culture))
		{
			Culture = "Chinese";
		}
		foreach (AKMarkerCulture item in Desc.Culture)
		{
			if (item.Name.Equals(Culture))
			{
				return item.Markers.ToList();
			}
		}
		return null;
	}

	public static void InitLevelSequenceClearBattleItemConfig()
	{
		sOnEnterLevelSequnenceWhiteListProjectileID = new HashSet<int>();
		sOnEnterLevelSequnenceWhiteListSummonID = new HashSet<int>();
		foreach (KeyValuePair<int, FUStLevelSequenceClearBattleItemConfigDesc> item in GetAllLevelSequenceClearBattleItemConfigDesc())
		{
			if (item.Value.ProjectileID > 0)
			{
				sOnEnterLevelSequnenceWhiteListProjectileID.Add(item.Value.ProjectileID);
			}
			else if (item.Value.SummonID > 0)
			{
				sOnEnterLevelSequnenceWhiteListSummonID.Add(item.Value.SummonID);
			}
		}
	}

	public static void InitAkMarkerDesc()
	{
		sMarkerDesc = new Dictionary<string, List<FUStAkEventMarkerDesc>>();
		foreach (KeyValuePair<int, FUStAkEventMarkerDesc> item in GetAllAkEventMarkerDesc())
		{
			if (!sMarkerDesc.ContainsKey(item.Value.AkEventName))
			{
				sMarkerDesc.Add(item.Value.AkEventName, new List<FUStAkEventMarkerDesc>());
			}
			sMarkerDesc[item.Value.AkEventName].Add(item.Value);
		}
	}

	public static void InitFacialResourceMap()
	{
		sMapFacialResourceMap = new Dictionary<int, List<string>>();
		foreach (KeyValuePair<int, FUStDialogueDesc> item in GetAllDialogueDesc())
		{
			int resID = item.Value.ResID;
			string facialAnimPath = item.Value.FacialAnimPath;
			if (resID > 0 && !string.IsNullOrEmpty(facialAnimPath))
			{
				if (!sMapFacialResourceMap.ContainsKey(item.Value.ResID))
				{
					sMapFacialResourceMap.Add(resID, new List<string>());
				}
				sMapFacialResourceMap[resID].Add(facialAnimPath);
			}
		}
	}

	public static List<string> GetUnitFacialAnimList(int ResID)
	{
		if (sMapFacialResourceMap.TryGetValue(ResID, out var value))
		{
			return value;
		}
		return null;
	}

	private static void InitSeqAudioJumpMap()
	{
		foreach (KeyValuePair<int, FUStSeqAudioJumpLengthDesc> item in GetAllSeqAudioJumpLengthDesc())
		{
			string eventName = item.Value.EventName;
			if (!string.IsNullOrEmpty(eventName) && !sMapSeqAudioLength.ContainsKey(eventName))
			{
				sMapSeqAudioLength.Add(eventName, item.Value.JumpLength);
			}
		}
	}

	public static bool GetSeqAudioJumpLength(string EventName, out int AudioLength)
	{
		if (sMapSeqAudioLength.TryGetValue(EventName, out AudioLength))
		{
			return true;
		}
		return false;
	}

	private static Dictionary<int, FUStSeqAudioJumpLengthDesc> GetAllSeqAudioJumpLengthDesc()
	{
		return BG_ProtobufDataAPI<FUStSeqAudioJumpLengthDesc>.Get().GetAll();
	}

	public static bool IsProjectileNeedDestroyOnEnterLevelSequence(int ProjectiledID)
	{
		if (sOnEnterLevelSequnenceWhiteListProjectileID != null && sOnEnterLevelSequnenceWhiteListProjectileID.Contains(ProjectiledID))
		{
			return false;
		}
		return true;
	}

	public static bool IsSummonNeedDestroyOnEnterLevelSequence(int SummonID)
	{
		if (sOnEnterLevelSequnenceWhiteListSummonID != null && sOnEnterLevelSequnenceWhiteListSummonID.Contains(SummonID))
		{
			return false;
		}
		return true;
	}

	private static void InitDOPerformMapping()
	{
		foreach (KeyValuePair<int, FUStDynamicObstaclePerformanceDesc> item in BG_ProtobufDataAPI<FUStDynamicObstaclePerformanceDesc>.Get().GetAll())
		{
			if (!DOPerformMapping.ContainsKey(item.Value.PerformID))
			{
				Dictionary<int, string> dictionary = new Dictionary<int, string>();
				dictionary.Add(item.Value.ResID, item.Value.DAPath);
				DOPerformMapping.Add(item.Value.PerformID, dictionary);
			}
			else if (!DOPerformMapping[item.Value.PerformID].ContainsKey(item.Value.ResID))
			{
				DOPerformMapping[item.Value.PerformID].Add(item.Value.ResID, item.Value.DAPath);
			}
		}
	}

	public static string GetUnitDynamicObstaclePerformanceConfigPath(int DOPerformID, int ResID)
	{
		if (DOPerformMapping.ContainsKey(DOPerformID))
		{
			if (DOPerformMapping[DOPerformID].TryGetValue(ResID, out var value))
			{
				return value;
			}
			if (DOPerformMapping[DOPerformID].TryGetValue(0, out var value2))
			{
				return value2;
			}
		}
		return string.Empty;
	}

	public static List<string> GetUDOPPreloadPath(int DOPerformID)
	{
		if (DOPerformMapping.ContainsKey(DOPerformID))
		{
			return DOPerformMapping[DOPerformID].Values.ToList();
		}
		return null;
	}

	private static void InitDefeatSlowTimeConfig()
	{
		DefeatSlowTimeSeqID2ExtendIDMap.Clear();
		ExtendID2SlowTimeConfigMap = BG_ProtobufDataAPI<FUStDefeatSlowTimeConfigDesc>.Get().GetAll();
		foreach (KeyValuePair<int, FUStDefeatSlowTimeConfigDesc> item in ExtendID2SlowTimeConfigMap)
		{
			foreach (int seqID in item.Value.SeqIDList)
			{
				DefeatSlowTimeSeqID2ExtendIDMap[seqID] = item.Key;
			}
		}
	}

	public static FUStDefeatSlowTimeConfigDesc GetSlowTimeConfigDescBySeqID(int SeqID)
	{
		if (DefeatSlowTimeSeqID2ExtendIDMap.TryGetValue(SeqID, out var value))
		{
			return ExtendID2SlowTimeConfigMap[value];
		}
		return null;
	}

	public static FUStDefeatSlowTimeConfigDesc GetSlowTimeConfigDescByExtendID(int ExtendID)
	{
		if (ExtendID2SlowTimeConfigMap.TryGetValue(ExtendID, out var value))
		{
			return value;
		}
		return null;
	}

	public static List<FUStDefeatSlowTimeConfigDesc> GetAllDefeatSlowTimeConfigDescs()
	{
		return ExtendID2SlowTimeConfigMap.Values.ToList();
	}

	private static void InitCameraConversionParamConfig()
	{
		CameraConversionParamConfigDict = BG_ProtobufDataAPI<FUStCameraConversionParamConfigDesc>.Get().GetAll();
	}

	public static FUStCameraConversionParamConfigDesc GetCameraConversionParamConfigDesc(int ID)
	{
		if (CameraConversionParamConfigDict.TryGetValue(ID, out var value))
		{
			return value;
		}
		return null;
	}

	public static Dictionary<int, FUStAbnormalDispAttackerMapDesc> GetAllAbnormalDispAttackerMapDesc()
	{
		return BG_ProtobufDataAPI<FUStAbnormalDispAttackerMapDesc>.Get().GetAll();
	}

	public static Dictionary<int, FUStAbnormalDispVictimMapDesc> GetAllAbnormalDispVictimMapDesc()
	{
		return BG_ProtobufDataAPI<FUStAbnormalDispVictimMapDesc>.Get().GetAll();
	}

	private static void InitAbnormalDispMap()
	{
		Dictionary<int, FUStAbnormalDispAttackerMapDesc> allAbnormalDispAttackerMapDesc = GetAllAbnormalDispAttackerMapDesc();
		AbnormalDispAttackerMapping = new Dictionary<int, Dictionary<EAbnormalStateType, FAbnormalDispSingle>>();
		AbnormalDispVictimMapping = new Dictionary<int, Dictionary<EAbnormalStateType, FAbnormalDispSingle>>();
		AbnormalDispAttackerMapping_FreezeExt = new Dictionary<int, FAbnormalDispSingle_FreezeExt>();
		AbnormalDispVictimMapping_FreezeExt = new Dictionary<int, FAbnormalDispSingle_FreezeExt>();
		foreach (KeyValuePair<int, FUStAbnormalDispAttackerMapDesc> item in allAbnormalDispAttackerMapDesc)
		{
			Dictionary<EAbnormalStateType, FAbnormalDispSingle> dictionary = new Dictionary<EAbnormalStateType, FAbnormalDispSingle>();
			dictionary.Add(EAbnormalStateType.Abnormal_Freeze, new FAbnormalDispSingle(item.Value.Freeze));
			dictionary.Add(EAbnormalStateType.Abnormal_Burn, new FAbnormalDispSingle(item.Value.Burn));
			dictionary.Add(EAbnormalStateType.Abnormal_Poison, new FAbnormalDispSingle(item.Value.Poison));
			dictionary.Add(EAbnormalStateType.Abnormal_Thunder, new FAbnormalDispSingle(item.Value.Thunder));
			dictionary.Add(EAbnormalStateType.Abnormal_Yin, new FAbnormalDispSingle(item.Value.Yin));
			dictionary.Add(EAbnormalStateType.Abnormal_Yang, new FAbnormalDispSingle(item.Value.Yang));
			AbnormalDispAttackerMapping.Add(item.Key, dictionary);
			FAbnormalDispSingle_FreezeExt value = new FAbnormalDispSingle_FreezeExt(item.Value.FreezeExt);
			AbnormalDispAttackerMapping_FreezeExt.Add(item.Key, value);
		}
		foreach (KeyValuePair<int, FUStAbnormalDispVictimMapDesc> item2 in GetAllAbnormalDispVictimMapDesc())
		{
			Dictionary<EAbnormalStateType, FAbnormalDispSingle> dictionary2 = new Dictionary<EAbnormalStateType, FAbnormalDispSingle>();
			dictionary2.Add(EAbnormalStateType.Abnormal_Freeze, new FAbnormalDispSingle(item2.Value.Freeze));
			dictionary2.Add(EAbnormalStateType.Abnormal_Burn, new FAbnormalDispSingle(item2.Value.Burn));
			dictionary2.Add(EAbnormalStateType.Abnormal_Poison, new FAbnormalDispSingle(item2.Value.Poison));
			dictionary2.Add(EAbnormalStateType.Abnormal_Thunder, new FAbnormalDispSingle(item2.Value.Thunder));
			dictionary2.Add(EAbnormalStateType.Abnormal_Yin, new FAbnormalDispSingle(item2.Value.Yin));
			dictionary2.Add(EAbnormalStateType.Abnormal_Yang, new FAbnormalDispSingle(item2.Value.Yang));
			AbnormalDispVictimMapping.Add(item2.Key, dictionary2);
			FAbnormalDispSingle_FreezeExt value2 = new FAbnormalDispSingle_FreezeExt(item2.Value.FreezeExt);
			AbnormalDispVictimMapping_FreezeExt.Add(item2.Key, value2);
		}
	}

	public static bool GetAbnormalDispModifyInfo_Attacker(EAbnormalStateType AbnormalStateType, EAbnromalDispActionType ActionType, int AttackerABID, out EAbnormalDispModifyType ModifyType, out string DBCPath)
	{
		ModifyType = EAbnormalDispModifyType.None;
		DBCPath = "";
		if (AbnormalDispAttackerMapping.TryGetValue(AttackerABID, out var value))
		{
			ModifyType = value[AbnormalStateType].ActionMap[ActionType].ModifyType;
			DBCPath = value[AbnormalStateType].ActionMap[ActionType].DBCPath;
		}
		return ModifyType != EAbnormalDispModifyType.None;
	}

	public static bool GetAbnormalDispModifyInfo_Victim(EAbnormalStateType AbnormalStateType, EAbnromalDispActionType ActionType, int VictimABID, out EAbnormalDispModifyType ModifyType, out string DBCPath)
	{
		ModifyType = EAbnormalDispModifyType.None;
		DBCPath = "";
		if (AbnormalDispVictimMapping.TryGetValue(VictimABID, out var value))
		{
			ModifyType = value[AbnormalStateType].ActionMap[ActionType].ModifyType;
			DBCPath = value[AbnormalStateType].ActionMap[ActionType].DBCPath;
		}
		return ModifyType != EAbnormalDispModifyType.None;
	}

	public static bool GetAbnormalDispModifyInfo_FreezeExt_Attacker(EAbnromalDispActionType_FreezeExt ActionType, int AttackerABID, out EAbnormalDispModifyType ModifyType, out string DBCPath)
	{
		ModifyType = EAbnormalDispModifyType.None;
		DBCPath = "";
		if (AbnormalDispAttackerMapping_FreezeExt.TryGetValue(AttackerABID, out var value))
		{
			ModifyType = value.ActionMap[ActionType].ModifyType;
			DBCPath = value.ActionMap[ActionType].DBCPath;
		}
		return ModifyType != EAbnormalDispModifyType.None;
	}

	public static bool GetAbnormalDispModifyInfo_FreezeExt_Victim(EAbnromalDispActionType_FreezeExt ActionType, int VictimABID, out EAbnormalDispModifyType ModifyType, out string DBCPath)
	{
		ModifyType = EAbnormalDispModifyType.None;
		DBCPath = "";
		if (AbnormalDispVictimMapping_FreezeExt.TryGetValue(VictimABID, out var value))
		{
			ModifyType = value.ActionMap[ActionType].ModifyType;
			DBCPath = value.ActionMap[ActionType].DBCPath;
		}
		return ModifyType != EAbnormalDispModifyType.None;
	}

	public static FUStAbnormalDispAttackerMapDesc GetOriAbnormalDispModifyInfo_Attacker(int ID)
	{
		return BG_ProtobufDataAPI<FUStAbnormalDispAttackerMapDesc>.Get().FindByID(ID);
	}

	public static FUStAbnormalDispVictimMapDesc GetOriAbnormalDispModifyInfo_Victim(int ID)
	{
		return BG_ProtobufDataAPI<FUStAbnormalDispVictimMapDesc>.Get().FindByID(ID);
	}

	private static void InitBossRushAbilityLimitMap()
	{
		sMap_BossRushLimit_AttrOverride.Clear();
		sMap_BossRushLimit_Talent.Clear();
		sMap_BossRushLimit_Buff.Clear();
		sMap_BossRushLimit_BattleTimeLimit.Clear();
		foreach (KeyValuePair<int, FUStBossRushAbilityLimitDesc> item in GetAllBossRushAbilityLimitDesc())
		{
			if (item.Value.TargetType == EBRLimitTargetType.None)
			{
				continue;
			}
			switch (item.Value.LimitType)
			{
			case EBRLimitType.AttrOverride:
			{
				if (item.Value.TargetType != EBRLimitTargetType.Player)
				{
					break;
				}
				int num = FMath.Min(item.Value.ParamInts.Count, item.Value.ParamFloats.Count);
				if (num > 0)
				{
					Dictionary<int, float> dictionary = new Dictionary<int, float>();
					for (int i = 0; i < num; i++)
					{
						int key = item.Value.ParamInts[i];
						float value3 = item.Value.ParamFloats[i];
						dictionary[key] = value3;
					}
					sMap_BossRushLimit_AttrOverride.Add(item.Key, dictionary);
				}
				break;
			}
			case EBRLimitType.Talent:
			{
				if (item.Value.ParamInts.Count <= 0)
				{
					break;
				}
				if (!sMap_BossRushLimit_Talent.TryGetValue(item.Key, out var _))
				{
					sMap_BossRushLimit_Talent.Add(item.Key, new List<int>());
				}
				foreach (int paramInt in item.Value.ParamInts)
				{
					sMap_BossRushLimit_Talent[item.Key].Add(paramInt);
				}
				break;
			}
			case EBRLimitType.Buff:
			{
				if (item.Value.ParamInts.Count <= 0)
				{
					break;
				}
				if (!sMap_BossRushLimit_Buff.TryGetValue(item.Value.TargetType, out var _))
				{
					sMap_BossRushLimit_Buff.Add(item.Value.TargetType, new Dictionary<int, List<int>>());
				}
				sMap_BossRushLimit_Buff[item.Value.TargetType].Add(item.Key, new List<int>());
				foreach (int paramInt2 in item.Value.ParamInts)
				{
					sMap_BossRushLimit_Buff[item.Value.TargetType][item.Key].Add(paramInt2);
				}
				break;
			}
			case EBRLimitType.BattleTimeLimit:
				sMap_BossRushLimit_BattleTimeLimit.Add(item.Key);
				break;
			}
		}
	}

	public static Dictionary<int, FUStBossRushAbilityLimitDesc> GetAllBossRushAbilityLimitDesc()
	{
		return BG_ProtobufDataAPI<FUStBossRushAbilityLimitDesc>.Get().GetAll();
	}

	public static Dictionary<int, float> GetBossRushAttrOverrides(int ID)
	{
		if (sMap_BossRushLimit_AttrOverride.TryGetValue(ID, out var value))
		{
			return value;
		}
		return null;
	}

	public static List<int> GetBossRushTalentIDList(int ID)
	{
		if (sMap_BossRushLimit_Talent.TryGetValue(ID, out var value))
		{
			return value;
		}
		return null;
	}

	public static List<int> GetBossRushBuffIDList(int ID, EBRLimitTargetType TargetType)
	{
		if (sMap_BossRushLimit_Buff.TryGetValue(TargetType, out var value) && value.TryGetValue(ID, out var value2))
		{
			return value2;
		}
		return null;
	}

	public static bool GetBossRushBattleTimeLimitEnable(int DebuffID)
	{
		return sMap_BossRushLimit_BattleTimeLimit.Contains(DebuffID);
	}
}
