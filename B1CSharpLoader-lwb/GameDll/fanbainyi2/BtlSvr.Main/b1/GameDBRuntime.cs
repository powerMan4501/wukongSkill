using System;
using System.Collections.Generic;
using System.Linq;
using ArchiveB1;
using b1.Protobuf.DataAPI;
using b1.Protobuf.GSProtobufRuntimeAPI;
using BtlB1;
using BtlShare;
using CommB1;
using Google.Protobuf.Collections;
using ResB1;

namespace b1;

public static class GameDBRuntime
{
	public delegate void DelAddValidateLog(string str, string toBlame);

	public class WeaponTreeNode
	{
		public WeaponBuildDesc weaponBuildDesc;

		public List<int> nodePaths = new List<int>();

		public WeaponTreeNode parentNode;

		public List<WeaponTreeNode> childNodes = new List<WeaponTreeNode>();

		public bool IsRootWeapon => parentNode == null;
	}

	public enum IncreaseConfigId
	{
		RebuildTalentCost = 1
	}

	private static Dictionary<int, EquipPositionConfDesc> EquipPositionConfDict = new Dictionary<int, EquipPositionConfDesc>();

	private static Dictionary<int, EquipDesc> EquipDict = new Dictionary<int, EquipDesc>();

	private static Dictionary<int, List<ShopItemGroupDesc>> ShopItemGroupDict = new Dictionary<int, List<ShopItemGroupDesc>>();

	private static Dictionary<int, LevelDesc> OnlinLevelDescDict = new Dictionary<int, LevelDesc>();

	private static List<int> VersionLevelList = new List<int>();

	private static Dictionary<int, MapAreaConfigDesc> MapLevelAreaDescDict = new Dictionary<int, MapAreaConfigDesc>();

	private static Dictionary<int, MapAreaConfigDesc> MapSpriteAreaDescDict = new Dictionary<int, MapAreaConfigDesc>();

	private static Dictionary<(int, EUnitQualityType), List<NewGamePlusDesc>> NewGamePlusDict = new Dictionary<(int, EUnitQualityType), List<NewGamePlusDesc>>();

	private static Dictionary<int, Dictionary<int, TalentSDesc>> sMapTalentSUnit = new Dictionary<int, Dictionary<int, TalentSDesc>>();

	private static Dictionary<int, int> SpellOnlyTalentDict = new Dictionary<int, int>();

	private static Dictionary<ECommonErrorType, Dictionary<int, CommonErrorUITipsDesc>> sCommonErrorUITipsDict = new Dictionary<ECommonErrorType, Dictionary<int, CommonErrorUITipsDesc>>();

	private static Dictionary<int, List<RoleDataConfigDesc>> RoleDataConfigDict = new Dictionary<int, List<RoleDataConfigDesc>>();

	private static Dictionary<int, ItemRecipeDesc> AttrItemRecipeIdDict = new Dictionary<int, ItemRecipeDesc>();

	private static Dictionary<int, List<UnitDropRuleDesc>> UnitDropRuleDict = new Dictionary<int, List<UnitDropRuleDesc>>();

	public static Dictionary<int, CommDropRuleDesc> CommDropRuleDict = new Dictionary<int, CommDropRuleDesc>();

	private static Dictionary<UISettingConfigType, UISettingConfigDesc> UISettingConfigDict = new Dictionary<UISettingConfigType, UISettingConfigDesc>();

	private static Dictionary<int, List<TransInputUITipsDesc>> TransInputUITipsDict = new Dictionary<int, List<TransInputUITipsDesc>>();

	private static Dictionary<ItemType, int> ItemType2IdDict = new Dictionary<ItemType, int>();

	private static Dictionary<MoneyType, int> MoneyType2IdDict = new Dictionary<MoneyType, int>();

	private static Dictionary<int, int> ItemImageIdDict = new Dictionary<int, int>();

	private static Dictionary<int, TalentGroupDesc> TalentGroupDict = new Dictionary<int, TalentGroupDesc>();

	private static Dictionary<SpellType, List<TalentGroupDesc>> TalentCollectionDict = new Dictionary<SpellType, List<TalentGroupDesc>>();

	private static Dictionary<(SpellType, int), TalentRankDesc> TalentRankDescDict = new Dictionary<(SpellType, int), TalentRankDesc>();

	private static Dictionary<int, SpellType> TalentSpellTypeDict = new Dictionary<int, SpellType>();

	private static Dictionary<int, List<int>> LegacyTalentListDict = new Dictionary<int, List<int>>();

	private static Dictionary<int, int> LegacyPassiveTalent = new Dictionary<int, int>();

	private static Dictionary<int, List<int>> SpellAssociatedUnlockLegacyTalentDict = new Dictionary<int, List<int>>();

	private static Dictionary<int, List<int>> TalentAssociatedUnlockDefaultTalentList = new Dictionary<int, List<int>>();

	private static Dictionary<SpellType, List<TalentRankDesc>> TalentRankListDict = new Dictionary<SpellType, List<TalentRankDesc>>();

	private static List<int> AutoUnlockTalentList = new List<int>();

	private static Dictionary<LoadingTipsType, Dictionary<int, List<LoadingTipsDesc>>> LoadingTipsDescDict = new Dictionary<LoadingTipsType, Dictionary<int, List<LoadingTipsDesc>>>();

	private static Dictionary<int, Dictionary<int, List<LoadingTipsDesc>>> UnitDeathTipsDict = new Dictionary<int, Dictionary<int, List<LoadingTipsDesc>>>();

	private static Dictionary<int, LoadingTipsDesc> TriggerTypeNoneTipsDict = new Dictionary<int, LoadingTipsDesc>();

	private static Dictionary<int, LevelDesc> LevelDescDict = new Dictionary<int, LevelDesc>();

	private static Dictionary<int, List<SurpriseDesc>> ChapterSurpriseDescDict = new Dictionary<int, List<SurpriseDesc>>();

	private static Dictionary<int, PastMemoryDesc> FastPastMemoryDict = new Dictionary<int, PastMemoryDesc>();

	private static Dictionary<(int, ResourceType), List<int>> ChapterAwardDict = new Dictionary<(int, ResourceType), List<int>>();

	public static Dictionary<int, CollectionDropDesc> CollectionDropDict = new Dictionary<int, CollectionDropDesc>();

	private static Dictionary<int, int> CardIndexDict = new Dictionary<int, int>();

	private static List<CardDesc> VersionCardList = new List<CardDesc>();

	public static Dictionary<int, List<ItemOne>> LockMantraCostDict = new Dictionary<int, List<ItemOne>>();

	public static Dictionary<int, List<int>> SuitId2EquipListDict = new Dictionary<int, List<int>>();

	public static Dictionary<int, int> ArmorID2SeriesIdDict = new Dictionary<int, int>();

	public static List<SeedCollectionAwardDesc> SeedCollectionAwardList = new List<SeedCollectionAwardDesc>();

	public static Dictionary<int, List<int>> WeaponKeyItemToEquidIdDict = new Dictionary<int, List<int>>();

	public static Dictionary<int, int> WeaponIdToRootIdDict = new Dictionary<int, int>();

	public static Dictionary<(AchievementUnlockRequirement, int), List<int>> AchievementRequiredIdToAchievementIdDict = new Dictionary<(AchievementUnlockRequirement, int), List<int>>();

	public static Dictionary<(AchievementUnlockRequirement, string), List<int>> AchievementRequiredGuidToAchievementIdDitc = new Dictionary<(AchievementUnlockRequirement, string), List<int>>();

	public static Dictionary<(int, QuestStage), List<SurpriseDesc>> TaskStage2SurpriseDescDict = new Dictionary<(int, QuestStage), List<SurpriseDesc>>();

	public static List<MedicineAwardDesc> OrderedMedicineAwardList;

	private static Dictionary<int, CricketBattleUnitDesc> CricketBattleUnitDescDict = new Dictionary<int, CricketBattleUnitDesc>();

	private static Dictionary<int, CricketUnitAttrDesc> CricketUnitAttrDescDict = new Dictionary<int, CricketUnitAttrDesc>();

	private static Dictionary<int, int> WineSeriesDict = new Dictionary<int, int>();

	private static Dictionary<EUIConfigTab, Dictionary<UISettingConfigType, int>> SettingSortDict = new Dictionary<EUIConfigTab, Dictionary<UISettingConfigType, int>>();

	private static Dictionary<string, LinkBloodDesc> Unit2LinkBloodDesc = new Dictionary<string, LinkBloodDesc>();

	private static Dictionary<int, FUStGuideGroupDesc> GuideNode2Group = new Dictionary<int, FUStGuideGroupDesc>();

	private static Dictionary<int, FUStUnitBattleInfoExtendDesc> SoulSkillExtendDescDict = new Dictionary<int, FUStUnitBattleInfoExtendDesc>();

	public static readonly int TianLongGunItemId = 15017;

	private static Dictionary<(ItemQuality, EquipPosition), ArmorEnhanceConsumeDesc> ArmorEnhanceConsumeDict = new Dictionary<(ItemQuality, EquipPosition), ArmorEnhanceConsumeDesc>();

	private static Dictionary<QuestStageOne, List<NpcLocationOne>> TaskStageShowNpcLocationDict = new Dictionary<QuestStageOne, List<NpcLocationOne>>();

	private static Dictionary<QuestStageOne, List<NpcLocationOne>> TaskStageHideNpcLocationDict = new Dictionary<QuestStageOne, List<NpcLocationOne>>();

	private static Dictionary<(int, int, QuestStageOne), ShrineShowNpcConfigDesc> ShrineShowNpcConfigDescDict = new Dictionary<(int, int, QuestStageOne), ShrineShowNpcConfigDesc>();

	private static List<List<UISettingConfigDesc>> UISettingConfigDescList = new List<List<UISettingConfigDesc>>();

	private static Dictionary<ResUnlockType, List<int>> SoundTrackUnlockTypeToSoundTrackIdDict = new Dictionary<ResUnlockType, List<int>>();

	private static Dictionary<ResUnlockType, List<int>> MvUnlockTypeToMvIdDict = new Dictionary<ResUnlockType, List<int>>();

	private static Dictionary<(EBossUnlockCondition, int), List<int>> EBossUnlockConditionToRefightId = new Dictionary<(EBossUnlockCondition, int), List<int>>();

	private static Dictionary<(EBossUnlockCondition, int), List<int>> EBossUnlockConditionToContinuousFightId = new Dictionary<(EBossUnlockCondition, int), List<int>>();

	public static DelAddValidateLog OnAddValidateLog;

	private static Dictionary<EquipPosition, int> RoleDefaultEquip = new Dictionary<EquipPosition, int>();

	private static int NewGamePlusCountMax = 0;

	private static Dictionary<int, WeaponTreeNode> weaponTreeNodeDict = new Dictionary<int, WeaponTreeNode>();

	private const int FINAL_LEGACY_ID = 4096;

	public static void CheckAllBtlB1DescAutoGen()
	{
		CheckFUStUnitIntelligenceInfoDescAutoGen();
		CheckFUStTaskStageDescAutoGen();
	}

	public static Dictionary<int, FUStCBGTemplateDesc> GetTBFUStCBGTemplateDesc()
	{
		return BG_ProtobufDataAPI<FUStCBGTemplateDesc>.Get().GetAll();
	}

	public static FUStCBGTemplateDesc GetFUStCBGTemplateDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStCBGTemplateDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStShiningDesc> GetTBFUStShiningDesc()
	{
		return BG_ProtobufDataAPI<FUStShiningDesc>.Get().GetAll();
	}

	public static FUStShiningDesc GetFUStShiningDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStShiningDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStFixFunctionDesc> GetTBFUStFixFunctionDesc()
	{
		return BG_ProtobufDataAPI<FUStFixFunctionDesc>.Get().GetAll();
	}

	public static FUStFixFunctionDesc GetFUStFixFunctionDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStFixFunctionDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStEnvironmentSurfaceEffectDesc> GetTBFUStEnvironmentSurfaceEffectDesc()
	{
		return BG_ProtobufDataAPI<FUStEnvironmentSurfaceEffectDesc>.Get().GetAll();
	}

	public static FUStEnvironmentSurfaceEffectDesc GetFUStEnvironmentSurfaceEffectDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStEnvironmentSurfaceEffectDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStInteractiveUnitCommDesc> GetTBFUStInteractiveUnitCommDesc()
	{
		return BG_ProtobufDataAPI<FUStInteractiveUnitCommDesc>.Get().GetAll();
	}

	public static FUStInteractiveUnitCommDesc GetFUStInteractiveUnitCommDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStInteractiveUnitCommDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStInteractionMappingDesc> GetTBFUStInteractionMappingDesc()
	{
		return BG_ProtobufDataAPI<FUStInteractionMappingDesc>.Get().GetAll();
	}

	public static FUStInteractionMappingDesc GetFUStInteractionMappingDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStInteractionMappingDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStAiInteractionMappingDesc> GetTBFUStAiInteractionMappingDesc()
	{
		return BG_ProtobufDataAPI<FUStAiInteractionMappingDesc>.Get().GetAll();
	}

	public static FUStAiInteractionMappingDesc GetFUStAiInteractionMappingDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStAiInteractionMappingDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStOverlyingSkillSDesc> GetTBFUStOverlyingSkillSDesc()
	{
		return BG_ProtobufDataAPI<FUStOverlyingSkillSDesc>.Get().GetAll();
	}

	public static FUStOverlyingSkillSDesc GetFUStOverlyingSkillSDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStOverlyingSkillSDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStChargeSkillSDesc> GetTBFUStChargeSkillSDesc()
	{
		return BG_ProtobufDataAPI<FUStChargeSkillSDesc>.Get().GetAll();
	}

	public static FUStChargeSkillSDesc GetFUStChargeSkillSDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStChargeSkillSDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStIronBodyConfigDesc> GetTBFUStIronBodyConfigDesc()
	{
		return BG_ProtobufDataAPI<FUStIronBodyConfigDesc>.Get().GetAll();
	}

	public static FUStIronBodyConfigDesc GetFUStIronBodyConfigDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStIronBodyConfigDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStDetonateConfigDesc> GetTBFUStDetonateConfigDesc()
	{
		return BG_ProtobufDataAPI<FUStDetonateConfigDesc>.Get().GetAll();
	}

	public static FUStDetonateConfigDesc GetFUStDetonateConfigDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStDetonateConfigDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStAttachedNiagaraByHitDesc> GetTBFUStAttachedNiagaraByHitDesc()
	{
		return BG_ProtobufDataAPI<FUStAttachedNiagaraByHitDesc>.Get().GetAll();
	}

	public static FUStAttachedNiagaraByHitDesc GetFUStAttachedNiagaraByHitDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStAttachedNiagaraByHitDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStGlobalConfigDesc> GetTBFUStGlobalConfigDesc()
	{
		return BG_ProtobufDataAPI<FUStGlobalConfigDesc>.Get().GetAll();
	}

	public static FUStGlobalConfigDesc GetFUStGlobalConfigDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStGlobalConfigDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStSkillAIDesc> GetTBFUStSkillAIDesc()
	{
		return BG_ProtobufDataAPI<FUStSkillAIDesc>.Get().GetAll();
	}

	public static FUStSkillAIDesc GetFUStSkillAIDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStSkillAIDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStCCGCastSkillMappingRuleDesc> GetTBFUStCCGCastSkillMappingRuleDesc()
	{
		return BG_ProtobufDataAPI<FUStCCGCastSkillMappingRuleDesc>.Get().GetAll();
	}

	public static FUStCCGCastSkillMappingRuleDesc GetFUStCCGCastSkillMappingRuleDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStCCGCastSkillMappingRuleDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStUnitAIDesc> GetTBFUStUnitAIDesc()
	{
		return BG_ProtobufDataAPI<FUStUnitAIDesc>.Get().GetAll();
	}

	public static FUStUnitAIDesc GetFUStUnitAIDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStUnitAIDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStDropItemDesc> GetTBFUStDropItemDesc()
	{
		return BG_ProtobufDataAPI<FUStDropItemDesc>.Get().GetAll();
	}

	public static FUStDropItemDesc GetFUStDropItemDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStDropItemDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStHitVEffectDesc> GetTBFUStHitVEffectDesc()
	{
		return BG_ProtobufDataAPI<FUStHitVEffectDesc>.Get().GetAll();
	}

	public static FUStHitVEffectDesc GetFUStHitVEffectDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStHitVEffectDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStPhysicalHitBoneRuleDesc> GetTBFUStPhysicalHitBoneRuleDesc()
	{
		return BG_ProtobufDataAPI<FUStPhysicalHitBoneRuleDesc>.Get().GetAll();
	}

	public static FUStPhysicalHitBoneRuleDesc GetFUStPhysicalHitBoneRuleDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStPhysicalHitBoneRuleDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStScarInfoDesc> GetTBFUStScarInfoDesc()
	{
		return BG_ProtobufDataAPI<FUStScarInfoDesc>.Get().GetAll();
	}

	public static FUStScarInfoDesc GetFUStScarInfoDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStScarInfoDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStBeAttackedInfoDesc> GetTBFUStBeAttackedInfoDesc()
	{
		return BG_ProtobufDataAPI<FUStBeAttackedInfoDesc>.Get().GetAll();
	}

	public static FUStBeAttackedInfoDesc GetFUStBeAttackedInfoDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStBeAttackedInfoDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStBeAttackedDispInfoDesc> GetTBFUStBeAttackedDispInfoDesc()
	{
		return BG_ProtobufDataAPI<FUStBeAttackedDispInfoDesc>.Get().GetAll();
	}

	public static FUStBeAttackedDispInfoDesc GetFUStBeAttackedDispInfoDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStBeAttackedDispInfoDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStBeAttackedStiffLevelMappingDesc> GetTBFUStBeAttackedStiffLevelMappingDesc()
	{
		return BG_ProtobufDataAPI<FUStBeAttackedStiffLevelMappingDesc>.Get().GetAll();
	}

	public static FUStBeAttackedStiffLevelMappingDesc GetFUStBeAttackedStiffLevelMappingDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStBeAttackedStiffLevelMappingDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStPartRuleInfoDesc> GetTBFUStPartRuleInfoDesc()
	{
		return BG_ProtobufDataAPI<FUStPartRuleInfoDesc>.Get().GetAll();
	}

	public static FUStPartRuleInfoDesc GetFUStPartRuleInfoDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStPartRuleInfoDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStPartHitExpandDesc> GetTBFUStPartHitExpandDesc()
	{
		return BG_ProtobufDataAPI<FUStPartHitExpandDesc>.Get().GetAll();
	}

	public static FUStPartHitExpandDesc GetFUStPartHitExpandDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStPartHitExpandDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStAttackerHitFXMappingDesc> GetTBFUStAttackerHitFXMappingDesc()
	{
		return BG_ProtobufDataAPI<FUStAttackerHitFXMappingDesc>.Get().GetAll();
	}

	public static FUStAttackerHitFXMappingDesc GetFUStAttackerHitFXMappingDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStAttackerHitFXMappingDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStAttackerHitAudioEventMappingDesc> GetTBFUStAttackerHitAudioEventMappingDesc()
	{
		return BG_ProtobufDataAPI<FUStAttackerHitAudioEventMappingDesc>.Get().GetAll();
	}

	public static FUStAttackerHitAudioEventMappingDesc GetFUStAttackerHitAudioEventMappingDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStAttackerHitAudioEventMappingDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStQTEDesc> GetTBFUStQTEDesc()
	{
		return BG_ProtobufDataAPI<FUStQTEDesc>.Get().GetAll();
	}

	public static FUStQTEDesc GetFUStQTEDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStQTEDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStSettingDetailDesc> GetTBFUStSettingDetailDesc()
	{
		return BG_ProtobufDataAPI<FUStSettingDetailDesc>.Get().GetAll();
	}

	public static FUStSettingDetailDesc GetFUStSettingDetailDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStSettingDetailDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStRebirthPointDesc> GetTBFUStRebirthPointDesc()
	{
		return BG_ProtobufDataAPI<FUStRebirthPointDesc>.Get().GetAll();
	}

	public static FUStRebirthPointDesc GetFUStRebirthPointDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStRebirthPointDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStRebirthAreaDesc> GetTBFUStRebirthAreaDesc()
	{
		return BG_ProtobufDataAPI<FUStRebirthAreaDesc>.Get().GetAll();
	}

	public static FUStRebirthAreaDesc GetFUStRebirthAreaDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStRebirthAreaDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStSummonCommDesc> GetTBFUStSummonCommDesc()
	{
		return BG_ProtobufDataAPI<FUStSummonCommDesc>.Get().GetAll();
	}

	public static FUStSummonCommDesc GetFUStSummonCommDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStSummonCommDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStSummonCopySkillDesc> GetTBFUStSummonCopySkillDesc()
	{
		return BG_ProtobufDataAPI<FUStSummonCopySkillDesc>.Get().GetAll();
	}

	public static FUStSummonCopySkillDesc GetFUStSummonCopySkillDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStSummonCopySkillDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStAttrCopyConfigDesc> GetTBFUStAttrCopyConfigDesc()
	{
		return BG_ProtobufDataAPI<FUStAttrCopyConfigDesc>.Get().GetAll();
	}

	public static FUStAttrCopyConfigDesc GetFUStAttrCopyConfigDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStAttrCopyConfigDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStUnitChangeMaterialByAttrDesc> GetTBFUStUnitChangeMaterialByAttrDesc()
	{
		return BG_ProtobufDataAPI<FUStUnitChangeMaterialByAttrDesc>.Get().GetAll();
	}

	public static FUStUnitChangeMaterialByAttrDesc GetFUStUnitChangeMaterialByAttrDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStUnitChangeMaterialByAttrDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStSettingClassNameDesc> GetTBFUStSettingClassNameDesc()
	{
		return BG_ProtobufDataAPI<FUStSettingClassNameDesc>.Get().GetAll();
	}

	public static FUStSettingClassNameDesc GetFUStSettingClassNameDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStSettingClassNameDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStEQSSettingDesc> GetTBFUStEQSSettingDesc()
	{
		return BG_ProtobufDataAPI<FUStEQSSettingDesc>.Get().GetAll();
	}

	public static FUStEQSSettingDesc GetFUStEQSSettingDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStEQSSettingDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStSweepCheckDesc> GetTBFUStSweepCheckDesc()
	{
		return BG_ProtobufDataAPI<FUStSweepCheckDesc>.Get().GetAll();
	}

	public static FUStSweepCheckDesc GetFUStSweepCheckDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStSweepCheckDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStBulletCommDesc> GetTBFUStBulletCommDesc()
	{
		return BG_ProtobufDataAPI<FUStBulletCommDesc>.Get().GetAll();
	}

	public static FUStBulletCommDesc GetFUStBulletCommDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStBulletCommDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStProjectileCommDesc> GetTBFUStProjectileCommDesc()
	{
		return BG_ProtobufDataAPI<FUStProjectileCommDesc>.Get().GetAll();
	}

	public static FUStProjectileCommDesc GetFUStProjectileCommDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStProjectileCommDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStProjectileDispDesc> GetTBFUStProjectileDispDesc()
	{
		return BG_ProtobufDataAPI<FUStProjectileDispDesc>.Get().GetAll();
	}

	public static FUStProjectileDispDesc GetFUStProjectileDispDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStProjectileDispDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStProjectileMoveDesc> GetTBFUStProjectileMoveDesc()
	{
		return BG_ProtobufDataAPI<FUStProjectileMoveDesc>.Get().GetAll();
	}

	public static FUStProjectileMoveDesc GetFUStProjectileMoveDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStProjectileMoveDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStBulletExpandDesc> GetTBFUStBulletExpandDesc()
	{
		return BG_ProtobufDataAPI<FUStBulletExpandDesc>.Get().GetAll();
	}

	public static FUStBulletExpandDesc GetFUStBulletExpandDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStBulletExpandDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStBulletWindFieldExpandDesc> GetTBFUStBulletWindFieldExpandDesc()
	{
		return BG_ProtobufDataAPI<FUStBulletWindFieldExpandDesc>.Get().GetAll();
	}

	public static FUStBulletWindFieldExpandDesc GetFUStBulletWindFieldExpandDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStBulletWindFieldExpandDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStMagicFieldExpandDesc> GetTBFUStMagicFieldExpandDesc()
	{
		return BG_ProtobufDataAPI<FUStMagicFieldExpandDesc>.Get().GetAll();
	}

	public static FUStMagicFieldExpandDesc GetFUStMagicFieldExpandDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStMagicFieldExpandDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStExAnimDataDesc> GetTBFUStExAnimDataDesc()
	{
		return BG_ProtobufDataAPI<FUStExAnimDataDesc>.Get().GetAll();
	}

	public static FUStExAnimDataDesc GetFUStExAnimDataDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStExAnimDataDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStBulletSwitchDesc> GetTBFUStBulletSwitchDesc()
	{
		return BG_ProtobufDataAPI<FUStBulletSwitchDesc>.Get().GetAll();
	}

	public static FUStBulletSwitchDesc GetFUStBulletSwitchDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStBulletSwitchDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStAttrEffectDesc> GetTBFUStAttrEffectDesc()
	{
		return BG_ProtobufDataAPI<FUStAttrEffectDesc>.Get().GetAll();
	}

	public static FUStAttrEffectDesc GetFUStAttrEffectDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStAttrEffectDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStSuitDesc> GetTBFUStSuitDesc()
	{
		return BG_ProtobufDataAPI<FUStSuitDesc>.Get().GetAll();
	}

	public static FUStSuitDesc GetFUStSuitDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStSuitDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStEnvironmentSwitchDesc> GetTBFUStEnvironmentSwitchDesc()
	{
		return BG_ProtobufDataAPI<FUStEnvironmentSwitchDesc>.Get().GetAll();
	}

	public static FUStEnvironmentSwitchDesc GetFUStEnvironmentSwitchDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStEnvironmentSwitchDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStUnitCollisionHitMoveDesc> GetTBFUStUnitCollisionHitMoveDesc()
	{
		return BG_ProtobufDataAPI<FUStUnitCollisionHitMoveDesc>.Get().GetAll();
	}

	public static FUStUnitCollisionHitMoveDesc GetFUStUnitCollisionHitMoveDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStUnitCollisionHitMoveDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStUnitTransCommDesc> GetTBFUStUnitTransCommDesc()
	{
		return BG_ProtobufDataAPI<FUStUnitTransCommDesc>.Get().GetAll();
	}

	public static FUStUnitTransCommDesc GetFUStUnitTransCommDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStUnitTransCommDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStRollSkillDesc> GetTBFUStRollSkillDesc()
	{
		return BG_ProtobufDataAPI<FUStRollSkillDesc>.Get().GetAll();
	}

	public static FUStRollSkillDesc GetFUStRollSkillDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStRollSkillDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStUnitDropDesc> GetTBFUStUnitDropDesc()
	{
		return BG_ProtobufDataAPI<FUStUnitDropDesc>.Get().GetAll();
	}

	public static FUStUnitDropDesc GetFUStUnitDropDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStUnitDropDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStNianhuiNameListDesc> GetTBFUStNianhuiNameListDesc()
	{
		return BG_ProtobufDataAPI<FUStNianhuiNameListDesc>.Get().GetAll();
	}

	public static FUStNianhuiNameListDesc GetFUStNianhuiNameListDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStNianhuiNameListDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStNianhuiAwardDesc> GetTBFUStNianhuiAwardDesc()
	{
		return BG_ProtobufDataAPI<FUStNianhuiAwardDesc>.Get().GetAll();
	}

	public static FUStNianhuiAwardDesc GetFUStNianhuiAwardDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStNianhuiAwardDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStPlayerSkillCtrlDesc> GetTBFUStPlayerSkillCtrlDesc()
	{
		return BG_ProtobufDataAPI<FUStPlayerSkillCtrlDesc>.Get().GetAll();
	}

	public static FUStPlayerSkillCtrlDesc GetFUStPlayerSkillCtrlDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStPlayerSkillCtrlDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStBuffRuleDesc> GetTBFUStBuffRuleDesc()
	{
		return BG_ProtobufDataAPI<FUStBuffRuleDesc>.Get().GetAll();
	}

	public static FUStBuffRuleDesc GetFUStBuffRuleDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStBuffRuleDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStBuffGroupDesc> GetTBFUStBuffGroupDesc()
	{
		return BG_ProtobufDataAPI<FUStBuffGroupDesc>.Get().GetAll();
	}

	public static FUStBuffGroupDesc GetFUStBuffGroupDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStBuffGroupDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStTransActiveStateDesc> GetTBFUStTransActiveStateDesc()
	{
		return BG_ProtobufDataAPI<FUStTransActiveStateDesc>.Get().GetAll();
	}

	public static FUStTransActiveStateDesc GetFUStTransActiveStateDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStTransActiveStateDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStMandatoryAITaskDesc> GetTBFUStMandatoryAITaskDesc()
	{
		return BG_ProtobufDataAPI<FUStMandatoryAITaskDesc>.Get().GetAll();
	}

	public static FUStMandatoryAITaskDesc GetFUStMandatoryAITaskDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStMandatoryAITaskDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStAttackHitAudioInfoDesc> GetTBFUStAttackHitAudioInfoDesc()
	{
		return BG_ProtobufDataAPI<FUStAttackHitAudioInfoDesc>.Get().GetAll();
	}

	public static FUStAttackHitAudioInfoDesc GetFUStAttackHitAudioInfoDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStAttackHitAudioInfoDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStAudioExtendDesc> GetTBFUStAudioExtendDesc()
	{
		return BG_ProtobufDataAPI<FUStAudioExtendDesc>.Get().GetAll();
	}

	public static FUStAudioExtendDesc GetFUStAudioExtendDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStAudioExtendDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStEnemyCameraDesc> GetTBFUStEnemyCameraDesc()
	{
		return BG_ProtobufDataAPI<FUStEnemyCameraDesc>.Get().GetAll();
	}

	public static FUStEnemyCameraDesc GetFUStEnemyCameraDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStEnemyCameraDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStStraightCamDesc> GetTBFUStStraightCamDesc()
	{
		return BG_ProtobufDataAPI<FUStStraightCamDesc>.Get().GetAll();
	}

	public static FUStStraightCamDesc GetFUStStraightCamDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStStraightCamDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStDiagonalCamDesc> GetTBFUStDiagonalCamDesc()
	{
		return BG_ProtobufDataAPI<FUStDiagonalCamDesc>.Get().GetAll();
	}

	public static FUStDiagonalCamDesc GetFUStDiagonalCamDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStDiagonalCamDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStGiantLockCameraDesc> GetTBFUStGiantLockCameraDesc()
	{
		return BG_ProtobufDataAPI<FUStGiantLockCameraDesc>.Get().GetAll();
	}

	public static FUStGiantLockCameraDesc GetFUStGiantLockCameraDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStGiantLockCameraDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStPlayerCameraDesc> GetTBFUStPlayerCameraDesc()
	{
		return BG_ProtobufDataAPI<FUStPlayerCameraDesc>.Get().GetAll();
	}

	public static FUStPlayerCameraDesc GetFUStPlayerCameraDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStPlayerCameraDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStPlayerTransUnitConfDesc> GetTBFUStPlayerTransUnitConfDesc()
	{
		return BG_ProtobufDataAPI<FUStPlayerTransUnitConfDesc>.Get().GetAll();
	}

	public static FUStPlayerTransUnitConfDesc GetFUStPlayerTransUnitConfDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStPlayerTransUnitConfDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStPlayerTransAttrDesc> GetTBFUStPlayerTransAttrDesc()
	{
		return BG_ProtobufDataAPI<FUStPlayerTransAttrDesc>.Get().GetAll();
	}

	public static FUStPlayerTransAttrDesc GetFUStPlayerTransAttrDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStPlayerTransAttrDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStBeAttackedFXMapDesc> GetTBFUStBeAttackedFXMapDesc()
	{
		return BG_ProtobufDataAPI<FUStBeAttackedFXMapDesc>.Get().GetAll();
	}

	public static FUStBeAttackedFXMapDesc GetFUStBeAttackedFXMapDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStBeAttackedFXMapDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStAttackHitFXMapDesc> GetTBFUStAttackHitFXMapDesc()
	{
		return BG_ProtobufDataAPI<FUStAttackHitFXMapDesc>.Get().GetAll();
	}

	public static FUStAttackHitFXMapDesc GetFUStAttackHitFXMapDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStAttackHitFXMapDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStSkillSMappingDesc> GetTBFUStSkillSMappingDesc()
	{
		return BG_ProtobufDataAPI<FUStSkillSMappingDesc>.Get().GetAll();
	}

	public static FUStSkillSMappingDesc GetFUStSkillSMappingDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStSkillSMappingDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStPlayerCommDesc> GetTBFUStPlayerCommDesc()
	{
		return BG_ProtobufDataAPI<FUStPlayerCommDesc>.Get().GetAll();
	}

	public static FUStPlayerCommDesc GetFUStPlayerCommDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStPlayerCommDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStPlayerInputSkillMappingDesc> GetTBFUStPlayerInputSkillMappingDesc()
	{
		return BG_ProtobufDataAPI<FUStPlayerInputSkillMappingDesc>.Get().GetAll();
	}

	public static FUStPlayerInputSkillMappingDesc GetFUStPlayerInputSkillMappingDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStPlayerInputSkillMappingDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStUnitDeadOldDesc> GetTBFUStUnitDeadOldDesc()
	{
		return BG_ProtobufDataAPI<FUStUnitDeadOldDesc>.Get().GetAll();
	}

	public static FUStUnitDeadOldDesc GetFUStUnitDeadOldDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStUnitDeadOldDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStUnitDeadSwitchToPhysicDesc> GetTBFUStUnitDeadSwitchToPhysicDesc()
	{
		return BG_ProtobufDataAPI<FUStUnitDeadSwitchToPhysicDesc>.Get().GetAll();
	}

	public static FUStUnitDeadSwitchToPhysicDesc GetFUStUnitDeadSwitchToPhysicDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStUnitDeadSwitchToPhysicDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStUnitDeadDesc> GetTBFUStUnitDeadDesc()
	{
		return BG_ProtobufDataAPI<FUStUnitDeadDesc>.Get().GetAll();
	}

	public static FUStUnitDeadDesc GetFUStUnitDeadDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStUnitDeadDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStHitSceneItemPerformDesc> GetTBFUStHitSceneItemPerformDesc()
	{
		return BG_ProtobufDataAPI<FUStHitSceneItemPerformDesc>.Get().GetAll();
	}

	public static FUStHitSceneItemPerformDesc GetFUStHitSceneItemPerformDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStHitSceneItemPerformDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStUnitFootstepDesc> GetTBFUStUnitFootstepDesc()
	{
		return BG_ProtobufDataAPI<FUStUnitFootstepDesc>.Get().GetAll();
	}

	public static FUStUnitFootstepDesc GetFUStUnitFootstepDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStUnitFootstepDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStPassiveSkillDesc> GetTBFUStPassiveSkillDesc()
	{
		return BG_ProtobufDataAPI<FUStPassiveSkillDesc>.Get().GetAll();
	}

	public static FUStPassiveSkillDesc GetFUStPassiveSkillDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStPassiveSkillDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStUnitAudioBankMapDesc> GetTBFUStUnitAudioBankMapDesc()
	{
		return BG_ProtobufDataAPI<FUStUnitAudioBankMapDesc>.Get().GetAll();
	}

	public static FUStUnitAudioBankMapDesc GetFUStUnitAudioBankMapDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStUnitAudioBankMapDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStMobLevelMappingDesc> GetTBFUStMobLevelMappingDesc()
	{
		return BG_ProtobufDataAPI<FUStMobLevelMappingDesc>.Get().GetAll();
	}

	public static FUStMobLevelMappingDesc GetFUStMobLevelMappingDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStMobLevelMappingDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStEliteBuffConfigDesc> GetTBFUStEliteBuffConfigDesc()
	{
		return BG_ProtobufDataAPI<FUStEliteBuffConfigDesc>.Get().GetAll();
	}

	public static FUStEliteBuffConfigDesc GetFUStEliteBuffConfigDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStEliteBuffConfigDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStMapMobConfigDesc> GetTBFUStMapMobConfigDesc()
	{
		return BG_ProtobufDataAPI<FUStMapMobConfigDesc>.Get().GetAll();
	}

	public static FUStMapMobConfigDesc GetFUStMapMobConfigDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStMapMobConfigDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStUnitSpecialMoveDesc> GetTBFUStUnitSpecialMoveDesc()
	{
		return BG_ProtobufDataAPI<FUStUnitSpecialMoveDesc>.Get().GetAll();
	}

	public static FUStUnitSpecialMoveDesc GetFUStUnitSpecialMoveDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStUnitSpecialMoveDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStUnitTransStageDesc> GetTBFUStUnitTransStageDesc()
	{
		return BG_ProtobufDataAPI<FUStUnitTransStageDesc>.Get().GetAll();
	}

	public static FUStUnitTransStageDesc GetFUStUnitTransStageDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStUnitTransStageDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStSkillsRefCheckWhiteListDesc> GetTBFUStSkillsRefCheckWhiteListDesc()
	{
		return BG_ProtobufDataAPI<FUStSkillsRefCheckWhiteListDesc>.Get().GetAll();
	}

	public static FUStSkillsRefCheckWhiteListDesc GetFUStSkillsRefCheckWhiteListDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStSkillsRefCheckWhiteListDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStBuffTickRuleBySimpleStateDesc> GetTBFUStBuffTickRuleBySimpleStateDesc()
	{
		return BG_ProtobufDataAPI<FUStBuffTickRuleBySimpleStateDesc>.Get().GetAll();
	}

	public static FUStBuffTickRuleBySimpleStateDesc GetFUStBuffTickRuleBySimpleStateDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStBuffTickRuleBySimpleStateDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStUnitPhysicalAnimationDesc> GetTBFUStUnitPhysicalAnimationDesc()
	{
		return BG_ProtobufDataAPI<FUStUnitPhysicalAnimationDesc>.Get().GetAll();
	}

	public static FUStUnitPhysicalAnimationDesc GetFUStUnitPhysicalAnimationDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStUnitPhysicalAnimationDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStMovieSequenceDesc> GetTBFUStMovieSequenceDesc()
	{
		return BG_ProtobufDataAPI<FUStMovieSequenceDesc>.Get().GetAll();
	}

	public static FUStMovieSequenceDesc GetFUStMovieSequenceDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStMovieSequenceDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStCameraGroupDesc> GetTBFUStCameraGroupDesc()
	{
		return BG_ProtobufDataAPI<FUStCameraGroupDesc>.Get().GetAll();
	}

	public static FUStCameraGroupDesc GetFUStCameraGroupDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStCameraGroupDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStGroupAISDesc> GetTBFUStGroupAISDesc()
	{
		return BG_ProtobufDataAPI<FUStGroupAISDesc>.Get().GetAll();
	}

	public static FUStGroupAISDesc GetFUStGroupAISDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStGroupAISDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStAssociationUnitInfoSDesc> GetTBFUStAssociationUnitInfoSDesc()
	{
		return BG_ProtobufDataAPI<FUStAssociationUnitInfoSDesc>.Get().GetAll();
	}

	public static FUStAssociationUnitInfoSDesc GetFUStAssociationUnitInfoSDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStAssociationUnitInfoSDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStUnitIntelligenceInfoDesc> GetTBFUStUnitIntelligenceInfoDesc()
	{
		return BG_ProtobufDataAPI<FUStUnitIntelligenceInfoDesc>.Get().GetAll();
	}

	public static FUStUnitIntelligenceInfoDesc GetFUStUnitIntelligenceInfoDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStUnitIntelligenceInfoDesc>.Get().FindByID(ResID);
	}

	public static void CheckFUStUnitIntelligenceInfoDescAutoGen()
	{
		string toBlame = "";
		foreach (KeyValuePair<int, FUStUnitIntelligenceInfoDesc> item in GetTBFUStUnitIntelligenceInfoDesc())
		{
			if (GetFUStUnitCommDesc(item.Value.ID) == null)
			{
				int iD = item.Value.ID;
				int key = item.Key;
				AddValidateLog($"FUStUnitIntelligenceInfoDesc表 错误id:{key} ID:{iD} 未在FUStUnitCommDesc里找到对应值", toBlame);
			}
		}
	}

	public static Dictionary<int, FUStDialogueIDMappingDesc> GetTBFUStDialogueIDMappingDesc()
	{
		return BG_ProtobufDataAPI<FUStDialogueIDMappingDesc>.Get().GetAll();
	}

	public static FUStDialogueIDMappingDesc GetFUStDialogueIDMappingDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStDialogueIDMappingDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStDialogueDesc> GetTBFUStDialogueDesc()
	{
		return BG_ProtobufDataAPI<FUStDialogueDesc>.Get().GetAll();
	}

	public static FUStDialogueDesc GetFUStDialogueDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStDialogueDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStUIWordDesc> GetTBFUStUIWordDesc()
	{
		return BG_ProtobufDataAPI<FUStUIWordDesc>.Get().GetAll();
	}

	public static FUStUIWordDesc GetFUStUIWordDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStUIWordDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStTalentLvUpCfgDesc> GetTBFUStTalentLvUpCfgDesc()
	{
		return BG_ProtobufDataAPI<FUStTalentLvUpCfgDesc>.Get().GetAll();
	}

	public static FUStTalentLvUpCfgDesc GetFUStTalentLvUpCfgDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStTalentLvUpCfgDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStTalentDisplayDesc> GetTBFUStTalentDisplayDesc()
	{
		return BG_ProtobufDataAPI<FUStTalentDisplayDesc>.Get().GetAll();
	}

	public static FUStTalentDisplayDesc GetFUStTalentDisplayDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStTalentDisplayDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStAiConversationEventDesc> GetTBFUStAiConversationEventDesc()
	{
		return BG_ProtobufDataAPI<FUStAiConversationEventDesc>.Get().GetAll();
	}

	public static FUStAiConversationEventDesc GetFUStAiConversationEventDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStAiConversationEventDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStAiConversationContentDesc> GetTBFUStAiConversationContentDesc()
	{
		return BG_ProtobufDataAPI<FUStAiConversationContentDesc>.Get().GetAll();
	}

	public static FUStAiConversationContentDesc GetFUStAiConversationContentDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStAiConversationContentDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStRichTextIconDesc> GetTBFUStRichTextIconDesc()
	{
		return BG_ProtobufDataAPI<FUStRichTextIconDesc>.Get().GetAll();
	}

	public static FUStRichTextIconDesc GetFUStRichTextIconDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStRichTextIconDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStSubtitleDesc> GetTBFUStSubtitleDesc()
	{
		return BG_ProtobufDataAPI<FUStSubtitleDesc>.Get().GetAll();
	}

	public static FUStSubtitleDesc GetFUStSubtitleDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStSubtitleDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStAiConversationGroupDesc> GetTBFUStAiConversationGroupDesc()
	{
		return BG_ProtobufDataAPI<FUStAiConversationGroupDesc>.Get().GetAll();
	}

	public static FUStAiConversationGroupDesc GetFUStAiConversationGroupDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStAiConversationGroupDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStLevelCommDesc> GetTBFUStLevelCommDesc()
	{
		return BG_ProtobufDataAPI<FUStLevelCommDesc>.Get().GetAll();
	}

	public static FUStLevelCommDesc GetFUStLevelCommDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStLevelCommDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStOnlineScreenMsgConfDesc> GetTBFUStOnlineScreenMsgConfDesc()
	{
		return BG_ProtobufDataAPI<FUStOnlineScreenMsgConfDesc>.Get().GetAll();
	}

	public static FUStOnlineScreenMsgConfDesc GetFUStOnlineScreenMsgConfDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStOnlineScreenMsgConfDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStImmobilizeSkillConfigDesc> GetTBFUStImmobilizeSkillConfigDesc()
	{
		return BG_ProtobufDataAPI<FUStImmobilizeSkillConfigDesc>.Get().GetAll();
	}

	public static FUStImmobilizeSkillConfigDesc GetFUStImmobilizeSkillConfigDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStImmobilizeSkillConfigDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStSealingSpellSkillConfigDesc> GetTBFUStSealingSpellSkillConfigDesc()
	{
		return BG_ProtobufDataAPI<FUStSealingSpellSkillConfigDesc>.Get().GetAll();
	}

	public static FUStSealingSpellSkillConfigDesc GetFUStSealingSpellSkillConfigDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStSealingSpellSkillConfigDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStTransQiTianDaShengConfigDesc> GetTBFUStTransQiTianDaShengConfigDesc()
	{
		return BG_ProtobufDataAPI<FUStTransQiTianDaShengConfigDesc>.Get().GetAll();
	}

	public static FUStTransQiTianDaShengConfigDesc GetFUStTransQiTianDaShengConfigDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStTransQiTianDaShengConfigDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStAbnormalCommConfigDesc> GetTBFUStAbnormalCommConfigDesc()
	{
		return BG_ProtobufDataAPI<FUStAbnormalCommConfigDesc>.Get().GetAll();
	}

	public static FUStAbnormalCommConfigDesc GetFUStAbnormalCommConfigDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStAbnormalCommConfigDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStPhantomRushSkillConfigDesc> GetTBFUStPhantomRushSkillConfigDesc()
	{
		return BG_ProtobufDataAPI<FUStPhantomRushSkillConfigDesc>.Get().GetAll();
	}

	public static FUStPhantomRushSkillConfigDesc GetFUStPhantomRushSkillConfigDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStPhantomRushSkillConfigDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStTaskStageDesc> GetTBFUStTaskStageDesc()
	{
		return BG_ProtobufDataAPI<FUStTaskStageDesc>.Get().GetAll();
	}

	public static FUStTaskStageDesc GetFUStTaskStageDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStTaskStageDesc>.Get().FindByID(ResID);
	}

	public static void CheckFUStTaskStageDescAutoGen()
	{
		string toBlame = "";
		foreach (KeyValuePair<int, FUStTaskStageDesc> item in GetTBFUStTaskStageDesc())
		{
			for (int i = 0; i < item.Value.ActivatedShopRefreshIDList.Count; i++)
			{
				if (GetShopRefreshDesc(item.Value.ActivatedShopRefreshIDList[i]) == null)
				{
					int num = item.Value.ActivatedShopRefreshIDList[i];
					int key = item.Key;
					AddValidateLog($"FUStTaskStageDesc表 错误id:{key} ActivatedShopRefreshIDList[{i}] {num} 未在ShopRefreshDesc里找到对应值", toBlame);
				}
			}
			for (int j = 0; j < item.Value.FinishedShopRefreshIDList.Count; j++)
			{
				if (GetShopRefreshDesc(item.Value.FinishedShopRefreshIDList[j]) == null)
				{
					int num2 = item.Value.FinishedShopRefreshIDList[j];
					int key2 = item.Key;
					AddValidateLog($"FUStTaskStageDesc表 错误id:{key2} FinishedShopRefreshIDList[{j}] {num2} 未在ShopRefreshDesc里找到对应值", toBlame);
				}
			}
			for (int k = 0; k < item.Value.ActivatedDropItemList.Count; k++)
			{
				if (GetCommDropRuleDesc(item.Value.ActivatedDropItemList[k]) == null)
				{
					int num3 = item.Value.ActivatedDropItemList[k];
					int key3 = item.Key;
					AddValidateLog($"FUStTaskStageDesc表 错误id:{key3} ActivatedDropItemList[{k}] {num3} 未在CommDropRuleDesc里找到对应值", toBlame);
				}
			}
			for (int l = 0; l < item.Value.FinishedDropItemList.Count; l++)
			{
				if (GetCommDropRuleDesc(item.Value.FinishedDropItemList[l]) == null)
				{
					int num4 = item.Value.FinishedDropItemList[l];
					int key4 = item.Key;
					AddValidateLog($"FUStTaskStageDesc表 错误id:{key4} FinishedDropItemList[{l}] {num4} 未在CommDropRuleDesc里找到对应值", toBlame);
				}
			}
			for (int m = 0; m < item.Value.ActivatedInteractionFuncList.Count; m++)
			{
				if (GetInteractionFuncDesc(item.Value.ActivatedInteractionFuncList[m]) == null)
				{
					int num5 = item.Value.ActivatedInteractionFuncList[m];
					int key5 = item.Key;
					AddValidateLog($"FUStTaskStageDesc表 错误id:{key5} ActivatedInteractionFuncList[{m}] {num5} 未在InteractionFuncDesc里找到对应值", toBlame);
				}
			}
			for (int n = 0; n < item.Value.FinishedInteractionFuncList.Count; n++)
			{
				if (GetInteractionFuncDesc(item.Value.FinishedInteractionFuncList[n]) == null)
				{
					int num6 = item.Value.FinishedInteractionFuncList[n];
					int key6 = item.Key;
					AddValidateLog($"FUStTaskStageDesc表 错误id:{key6} FinishedInteractionFuncList[{n}] {num6} 未在InteractionFuncDesc里找到对应值", toBlame);
				}
			}
			for (int num7 = 0; num7 < item.Value.ActivatedAchievementIdList.Count; num7++)
			{
				if (GetAchievementDesc(item.Value.ActivatedAchievementIdList[num7]) == null)
				{
					int num8 = item.Value.ActivatedAchievementIdList[num7];
					int key7 = item.Key;
					AddValidateLog($"FUStTaskStageDesc表 错误id:{key7} ActivatedAchievementIdList[{num7}] {num8} 未在AchievementDesc里找到对应值", toBlame);
				}
			}
			for (int num9 = 0; num9 < item.Value.FinishedAchievementIdList.Count; num9++)
			{
				if (GetAchievementDesc(item.Value.FinishedAchievementIdList[num9]) == null)
				{
					int num10 = item.Value.FinishedAchievementIdList[num9];
					int key8 = item.Key;
					AddValidateLog($"FUStTaskStageDesc表 错误id:{key8} FinishedAchievementIdList[{num9}] {num10} 未在AchievementDesc里找到对应值", toBlame);
				}
			}
			for (int num11 = 0; num11 < item.Value.ActivatedNPCInfoList.Count; num11++)
			{
				if (GetCardDesc(item.Value.ActivatedNPCInfoList[num11].CardId) == null)
				{
					int cardId = item.Value.ActivatedNPCInfoList[num11].CardId;
					int key9 = item.Key;
					AddValidateLog($"FUStTaskStageDesc表 错误id:{key9} ActivatedNPCInfoList[{num11}] CardId:{cardId} 未在CardDesc里找到对应值", toBlame);
				}
			}
			for (int num12 = 0; num12 < item.Value.FinishedNPCInfoList.Count; num12++)
			{
				if (GetCardDesc(item.Value.FinishedNPCInfoList[num12].CardId) == null)
				{
					int cardId2 = item.Value.FinishedNPCInfoList[num12].CardId;
					int key10 = item.Key;
					AddValidateLog($"FUStTaskStageDesc表 错误id:{key10} FinishedNPCInfoList[{num12}] CardId:{cardId2} 未在CardDesc里找到对应值", toBlame);
				}
			}
		}
	}

	public static Dictionary<int, FUStTaskLineDesc> GetTBFUStTaskLineDesc()
	{
		return BG_ProtobufDataAPI<FUStTaskLineDesc>.Get().GetAll();
	}

	public static FUStTaskLineDesc GetFUStTaskLineDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStTaskLineDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStNPCBaseInfoDesc> GetTBFUStNPCBaseInfoDesc()
	{
		return BG_ProtobufDataAPI<FUStNPCBaseInfoDesc>.Get().GetAll();
	}

	public static FUStNPCBaseInfoDesc GetFUStNPCBaseInfoDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStNPCBaseInfoDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStSuperArmorLevelDesc> GetTBFUStSuperArmorLevelDesc()
	{
		return BG_ProtobufDataAPI<FUStSuperArmorLevelDesc>.Get().GetAll();
	}

	public static FUStSuperArmorLevelDesc GetFUStSuperArmorLevelDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStSuperArmorLevelDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStCollectionSpawnInfoDesc> GetTBFUStCollectionSpawnInfoDesc()
	{
		return BG_ProtobufDataAPI<FUStCollectionSpawnInfoDesc>.Get().GetAll();
	}

	public static FUStCollectionSpawnInfoDesc GetFUStCollectionSpawnInfoDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStCollectionSpawnInfoDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStCollectionSpawnGroupDesc> GetTBFUStCollectionSpawnGroupDesc()
	{
		return BG_ProtobufDataAPI<FUStCollectionSpawnGroupDesc>.Get().GetAll();
	}

	public static FUStCollectionSpawnGroupDesc GetFUStCollectionSpawnGroupDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStCollectionSpawnGroupDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStCollectionEventProbabilityDesc> GetTBFUStCollectionEventProbabilityDesc()
	{
		return BG_ProtobufDataAPI<FUStCollectionEventProbabilityDesc>.Get().GetAll();
	}

	public static FUStCollectionEventProbabilityDesc GetFUStCollectionEventProbabilityDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStCollectionEventProbabilityDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStCustomStateMachineDesc> GetTBFUStCustomStateMachineDesc()
	{
		return BG_ProtobufDataAPI<FUStCustomStateMachineDesc>.Get().GetAll();
	}

	public static FUStCustomStateMachineDesc GetFUStCustomStateMachineDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStCustomStateMachineDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStGuideAssetConfigDesc> GetTBFUStGuideAssetConfigDesc()
	{
		return BG_ProtobufDataAPI<FUStGuideAssetConfigDesc>.Get().GetAll();
	}

	public static FUStGuideAssetConfigDesc GetFUStGuideAssetConfigDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStGuideAssetConfigDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStPotentialEnergyConfigDesc> GetTBFUStPotentialEnergyConfigDesc()
	{
		return BG_ProtobufDataAPI<FUStPotentialEnergyConfigDesc>.Get().GetAll();
	}

	public static FUStPotentialEnergyConfigDesc GetFUStPotentialEnergyConfigDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStPotentialEnergyConfigDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStTeamRelationConfigDesc> GetTBFUStTeamRelationConfigDesc()
	{
		return BG_ProtobufDataAPI<FUStTeamRelationConfigDesc>.Get().GetAll();
	}

	public static FUStTeamRelationConfigDesc GetFUStTeamRelationConfigDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStTeamRelationConfigDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStTamerStrategyConfigDesc> GetTBFUStTamerStrategyConfigDesc()
	{
		return BG_ProtobufDataAPI<FUStTamerStrategyConfigDesc>.Get().GetAll();
	}

	public static FUStTamerStrategyConfigDesc GetFUStTamerStrategyConfigDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStTamerStrategyConfigDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStTROStrategyConfigDesc> GetTBFUStTROStrategyConfigDesc()
	{
		return BG_ProtobufDataAPI<FUStTROStrategyConfigDesc>.Get().GetAll();
	}

	public static FUStTROStrategyConfigDesc GetFUStTROStrategyConfigDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStTROStrategyConfigDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStMultiPointLockCameraConfigDesc> GetTBFUStMultiPointLockCameraConfigDesc()
	{
		return BG_ProtobufDataAPI<FUStMultiPointLockCameraConfigDesc>.Get().GetAll();
	}

	public static FUStMultiPointLockCameraConfigDesc GetFUStMultiPointLockCameraConfigDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStMultiPointLockCameraConfigDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStWeakPerformConfigDesc> GetTBFUStWeakPerformConfigDesc()
	{
		return BG_ProtobufDataAPI<FUStWeakPerformConfigDesc>.Get().GetAll();
	}

	public static FUStWeakPerformConfigDesc GetFUStWeakPerformConfigDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStWeakPerformConfigDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStFollowPartnerConfigDesc> GetTBFUStFollowPartnerConfigDesc()
	{
		return BG_ProtobufDataAPI<FUStFollowPartnerConfigDesc>.Get().GetAll();
	}

	public static FUStFollowPartnerConfigDesc GetFUStFollowPartnerConfigDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStFollowPartnerConfigDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStBossRoomConfigDesc> GetTBFUStBossRoomConfigDesc()
	{
		return BG_ProtobufDataAPI<FUStBossRoomConfigDesc>.Get().GetAll();
	}

	public static FUStBossRoomConfigDesc GetFUStBossRoomConfigDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStBossRoomConfigDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStGlobalCannotDeadExtraConfigDesc> GetTBFUStGlobalCannotDeadExtraConfigDesc()
	{
		return BG_ProtobufDataAPI<FUStGlobalCannotDeadExtraConfigDesc>.Get().GetAll();
	}

	public static FUStGlobalCannotDeadExtraConfigDesc GetFUStGlobalCannotDeadExtraConfigDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStGlobalCannotDeadExtraConfigDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStDeadSeqUnitConfigDesc> GetTBFUStDeadSeqUnitConfigDesc()
	{
		return BG_ProtobufDataAPI<FUStDeadSeqUnitConfigDesc>.Get().GetAll();
	}

	public static FUStDeadSeqUnitConfigDesc GetFUStDeadSeqUnitConfigDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStDeadSeqUnitConfigDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStAbnormalStateUIBlackListDesc> GetTBFUStAbnormalStateUIBlackListDesc()
	{
		return BG_ProtobufDataAPI<FUStAbnormalStateUIBlackListDesc>.Get().GetAll();
	}

	public static FUStAbnormalStateUIBlackListDesc GetFUStAbnormalStateUIBlackListDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStAbnormalStateUIBlackListDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStElementDmgRatioLevelDesc> GetTBFUStElementDmgRatioLevelDesc()
	{
		return BG_ProtobufDataAPI<FUStElementDmgRatioLevelDesc>.Get().GetAll();
	}

	public static FUStElementDmgRatioLevelDesc GetFUStElementDmgRatioLevelDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStElementDmgRatioLevelDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStStreamingLevelStateDesc> GetTBFUStStreamingLevelStateDesc()
	{
		return BG_ProtobufDataAPI<FUStStreamingLevelStateDesc>.Get().GetAll();
	}

	public static FUStStreamingLevelStateDesc GetFUStStreamingLevelStateDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStStreamingLevelStateDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStMapSymbolDesc> GetTBFUStMapSymbolDesc()
	{
		return BG_ProtobufDataAPI<FUStMapSymbolDesc>.Get().GetAll();
	}

	public static FUStMapSymbolDesc GetFUStMapSymbolDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStMapSymbolDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStLifeSavingHairConfigDesc> GetTBFUStLifeSavingHairConfigDesc()
	{
		return BG_ProtobufDataAPI<FUStLifeSavingHairConfigDesc>.Get().GetAll();
	}

	public static FUStLifeSavingHairConfigDesc GetFUStLifeSavingHairConfigDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStLifeSavingHairConfigDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStPigsyStoryLibraryDesc> GetTBFUStPigsyStoryLibraryDesc()
	{
		return BG_ProtobufDataAPI<FUStPigsyStoryLibraryDesc>.Get().GetAll();
	}

	public static FUStPigsyStoryLibraryDesc GetFUStPigsyStoryLibraryDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStPigsyStoryLibraryDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStPigsyStoryIAndRLibraryDesc> GetTBFUStPigsyStoryIAndRLibraryDesc()
	{
		return BG_ProtobufDataAPI<FUStPigsyStoryIAndRLibraryDesc>.Get().GetAll();
	}

	public static FUStPigsyStoryIAndRLibraryDesc GetFUStPigsyStoryIAndRLibraryDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStPigsyStoryIAndRLibraryDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStDynamicObstaclePerformanceDesc> GetTBFUStDynamicObstaclePerformanceDesc()
	{
		return BG_ProtobufDataAPI<FUStDynamicObstaclePerformanceDesc>.Get().GetAll();
	}

	public static FUStDynamicObstaclePerformanceDesc GetFUStDynamicObstaclePerformanceDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStDynamicObstaclePerformanceDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStDefeatSlowTimeConfigDesc> GetTBFUStDefeatSlowTimeConfigDesc()
	{
		return BG_ProtobufDataAPI<FUStDefeatSlowTimeConfigDesc>.Get().GetAll();
	}

	public static FUStDefeatSlowTimeConfigDesc GetFUStDefeatSlowTimeConfigDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStDefeatSlowTimeConfigDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStBuffDispGroupDesc> GetTBFUStBuffDispGroupDesc()
	{
		return BG_ProtobufDataAPI<FUStBuffDispGroupDesc>.Get().GetAll();
	}

	public static FUStBuffDispGroupDesc GetFUStBuffDispGroupDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStBuffDispGroupDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStSoulSkillMimicryDesc> GetTBFUStSoulSkillMimicryDesc()
	{
		return BG_ProtobufDataAPI<FUStSoulSkillMimicryDesc>.Get().GetAll();
	}

	public static FUStSoulSkillMimicryDesc GetFUStSoulSkillMimicryDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStSoulSkillMimicryDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStCameraConversionParamConfigDesc> GetTBFUStCameraConversionParamConfigDesc()
	{
		return BG_ProtobufDataAPI<FUStCameraConversionParamConfigDesc>.Get().GetAll();
	}

	public static FUStCameraConversionParamConfigDesc GetFUStCameraConversionParamConfigDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStCameraConversionParamConfigDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStEffectiveHitProjectileEffectDesc> GetTBFUStEffectiveHitProjectileEffectDesc()
	{
		return BG_ProtobufDataAPI<FUStEffectiveHitProjectileEffectDesc>.Get().GetAll();
	}

	public static FUStEffectiveHitProjectileEffectDesc GetFUStEffectiveHitProjectileEffectDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStEffectiveHitProjectileEffectDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStMovementOptStrategyConfigDesc> GetTBFUStMovementOptStrategyConfigDesc()
	{
		return BG_ProtobufDataAPI<FUStMovementOptStrategyConfigDesc>.Get().GetAll();
	}

	public static FUStMovementOptStrategyConfigDesc GetFUStMovementOptStrategyConfigDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStMovementOptStrategyConfigDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStLevelSequenceClearBattleItemConfigDesc> GetTBFUStLevelSequenceClearBattleItemConfigDesc()
	{
		return BG_ProtobufDataAPI<FUStLevelSequenceClearBattleItemConfigDesc>.Get().GetAll();
	}

	public static FUStLevelSequenceClearBattleItemConfigDesc GetFUStLevelSequenceClearBattleItemConfigDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStLevelSequenceClearBattleItemConfigDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStAbnormalDispVictimMapDesc> GetTBFUStAbnormalDispVictimMapDesc()
	{
		return BG_ProtobufDataAPI<FUStAbnormalDispVictimMapDesc>.Get().GetAll();
	}

	public static FUStAbnormalDispVictimMapDesc GetFUStAbnormalDispVictimMapDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStAbnormalDispVictimMapDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStAbnormalDispAttackerMapDesc> GetTBFUStAbnormalDispAttackerMapDesc()
	{
		return BG_ProtobufDataAPI<FUStAbnormalDispAttackerMapDesc>.Get().GetAll();
	}

	public static FUStAbnormalDispAttackerMapDesc GetFUStAbnormalDispAttackerMapDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStAbnormalDispAttackerMapDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStAICrowdDetourLevelConfigDesc> GetTBFUStAICrowdDetourLevelConfigDesc()
	{
		return BG_ProtobufDataAPI<FUStAICrowdDetourLevelConfigDesc>.Get().GetAll();
	}

	public static FUStAICrowdDetourLevelConfigDesc GetFUStAICrowdDetourLevelConfigDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStAICrowdDetourLevelConfigDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStSeqAudioJumpLengthDesc> GetTBFUStSeqAudioJumpLengthDesc()
	{
		return BG_ProtobufDataAPI<FUStSeqAudioJumpLengthDesc>.Get().GetAll();
	}

	public static FUStSeqAudioJumpLengthDesc GetFUStSeqAudioJumpLengthDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStSeqAudioJumpLengthDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStBossRushConfigDesc> GetTBFUStBossRushConfigDesc()
	{
		return BG_ProtobufDataAPI<FUStBossRushConfigDesc>.Get().GetAll();
	}

	public static FUStBossRushConfigDesc GetFUStBossRushConfigDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStBossRushConfigDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStBossRushAbilityLimitDesc> GetTBFUStBossRushAbilityLimitDesc()
	{
		return BG_ProtobufDataAPI<FUStBossRushAbilityLimitDesc>.Get().GetAll();
	}

	public static FUStBossRushAbilityLimitDesc GetFUStBossRushAbilityLimitDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStBossRushAbilityLimitDesc>.Get().FindByID(ResID);
	}

	public static void CheckAllBtlShareDescAutoGen()
	{
		CheckFUStUnitCommDescAutoGen();
		CheckFUStUnitBattleInfoExtendDescAutoGen();
		CheckFUStUnitPassiveSkillInfoExtendDescAutoGen();
		CheckFUStUnitEnvMaskConfigDescAutoGen();
	}

	public static Dictionary<int, FUStBuffDesc> GetTBFUStBuffDesc()
	{
		return BG_ProtobufDataAPI<FUStBuffDesc>.Get().GetAll();
	}

	public static FUStBuffDesc GetFUStBuffDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStBuffDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStBuffIconDesc> GetTBFUStBuffIconDesc()
	{
		return BG_ProtobufDataAPI<FUStBuffIconDesc>.Get().GetAll();
	}

	public static FUStBuffIconDesc GetFUStBuffIconDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStBuffIconDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStSkillSDesc> GetTBFUStSkillSDesc()
	{
		return BG_ProtobufDataAPI<FUStSkillSDesc>.Get().GetAll();
	}

	public static FUStSkillSDesc GetFUStSkillSDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStSkillSDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStSkillEffectDesc> GetTBFUStSkillEffectDesc()
	{
		return BG_ProtobufDataAPI<FUStSkillEffectDesc>.Get().GetAll();
	}

	public static FUStSkillEffectDesc GetFUStSkillEffectDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStSkillEffectDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStSkillDamageExpandDesc> GetTBFUStSkillDamageExpandDesc()
	{
		return BG_ProtobufDataAPI<FUStSkillDamageExpandDesc>.Get().GetAll();
	}

	public static FUStSkillDamageExpandDesc GetFUStSkillDamageExpandDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStSkillDamageExpandDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStBuffDispDesc> GetTBFUStBuffDispDesc()
	{
		return BG_ProtobufDataAPI<FUStBuffDispDesc>.Get().GetAll();
	}

	public static FUStBuffDispDesc GetFUStBuffDispDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStBuffDispDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStBuffLayerDispDesc> GetTBFUStBuffLayerDispDesc()
	{
		return BG_ProtobufDataAPI<FUStBuffLayerDispDesc>.Get().GetAll();
	}

	public static FUStBuffLayerDispDesc GetFUStBuffLayerDispDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStBuffLayerDispDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStUnitCommDesc> GetTBFUStUnitCommDesc()
	{
		return BG_ProtobufDataAPI<FUStUnitCommDesc>.Get().GetAll();
	}

	public static FUStUnitCommDesc GetFUStUnitCommDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStUnitCommDesc>.Get().FindByID(ResID);
	}

	public static void CheckFUStUnitCommDescAutoGen()
	{
		string toBlame = "";
		foreach (KeyValuePair<int, FUStUnitCommDesc> item in GetTBFUStUnitCommDesc())
		{
			if (GetFUStUnitBattleInfoExtendDesc(item.Value.DefaultBattleInfoExtendID) == null)
			{
				int defaultBattleInfoExtendID = item.Value.DefaultBattleInfoExtendID;
				int key = item.Key;
				AddValidateLog($"FUStUnitCommDesc表 错误id:{key} DefaultBattleInfoExtendID:{defaultBattleInfoExtendID} 未在FUStUnitBattleInfoExtendDesc里找到对应值", toBlame);
			}
		}
	}

	public static Dictionary<int, FUStUnitBattleInfoExtendDesc> GetTBFUStUnitBattleInfoExtendDesc()
	{
		return BG_ProtobufDataAPI<FUStUnitBattleInfoExtendDesc>.Get().GetAll();
	}

	public static FUStUnitBattleInfoExtendDesc GetFUStUnitBattleInfoExtendDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStUnitBattleInfoExtendDesc>.Get().FindByID(ResID);
	}

	public static void CheckFUStUnitBattleInfoExtendDescAutoGen()
	{
		string toBlame = "";
		foreach (KeyValuePair<int, FUStUnitBattleInfoExtendDesc> item in GetTBFUStUnitBattleInfoExtendDesc())
		{
			for (int i = 0; i < item.Value.DropRule.Count; i++)
			{
				if (GetCommDropRuleDesc(item.Value.DropRule[i]) == null)
				{
					int num = item.Value.DropRule[i];
					int key = item.Key;
					AddValidateLog($"FUStUnitBattleInfoExtendDesc表 错误id:{key} DropRule[{i}] {num} 未在CommDropRuleDesc里找到对应值", toBlame);
				}
			}
		}
	}

	public static Dictionary<int, FUStUnitPassiveSkillInfoExtendDesc> GetTBFUStUnitPassiveSkillInfoExtendDesc()
	{
		return BG_ProtobufDataAPI<FUStUnitPassiveSkillInfoExtendDesc>.Get().GetAll();
	}

	public static FUStUnitPassiveSkillInfoExtendDesc GetFUStUnitPassiveSkillInfoExtendDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStUnitPassiveSkillInfoExtendDesc>.Get().FindByID(ResID);
	}

	public static void CheckFUStUnitPassiveSkillInfoExtendDescAutoGen()
	{
		string toBlame = "";
		foreach (KeyValuePair<int, FUStUnitPassiveSkillInfoExtendDesc> item in GetTBFUStUnitPassiveSkillInfoExtendDesc())
		{
			if (GetFUStUnitCommDesc(item.Value.ID) == null)
			{
				int iD = item.Value.ID;
				int key = item.Key;
				AddValidateLog($"FUStUnitPassiveSkillInfoExtendDesc表 错误id:{key} ID:{iD} 未在FUStUnitCommDesc里找到对应值", toBlame);
			}
		}
	}

	public static Dictionary<int, FUStUnitEnvMaskConfigDesc> GetTBFUStUnitEnvMaskConfigDesc()
	{
		return BG_ProtobufDataAPI<FUStUnitEnvMaskConfigDesc>.Get().GetAll();
	}

	public static FUStUnitEnvMaskConfigDesc GetFUStUnitEnvMaskConfigDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStUnitEnvMaskConfigDesc>.Get().FindByID(ResID);
	}

	public static void CheckFUStUnitEnvMaskConfigDescAutoGen()
	{
		string toBlame = "";
		foreach (KeyValuePair<int, FUStUnitEnvMaskConfigDesc> item in GetTBFUStUnitEnvMaskConfigDesc())
		{
			if (GetFUStUnitCommDesc(item.Value.ID) == null)
			{
				int iD = item.Value.ID;
				int key = item.Key;
				AddValidateLog($"FUStUnitEnvMaskConfigDesc表 错误id:{key} ID:{iD} 未在FUStUnitCommDesc里找到对应值", toBlame);
			}
		}
	}

	public static Dictionary<int, FUStMagicFieldCommDesc> GetTBFUStMagicFieldCommDesc()
	{
		return BG_ProtobufDataAPI<FUStMagicFieldCommDesc>.Get().GetAll();
	}

	public static FUStMagicFieldCommDesc GetFUStMagicFieldCommDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStMagicFieldCommDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStAISkillBasicActionDesc> GetTBFUStAISkillBasicActionDesc()
	{
		return BG_ProtobufDataAPI<FUStAISkillBasicActionDesc>.Get().GetAll();
	}

	public static FUStAISkillBasicActionDesc GetFUStAISkillBasicActionDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStAISkillBasicActionDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStUnitLevelUpDesc> GetTBFUStUnitLevelUpDesc()
	{
		return BG_ProtobufDataAPI<FUStUnitLevelUpDesc>.Get().GetAll();
	}

	public static FUStUnitLevelUpDesc GetFUStUnitLevelUpDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStUnitLevelUpDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStAISkillTagsDesc> GetTBFUStAISkillTagsDesc()
	{
		return BG_ProtobufDataAPI<FUStAISkillTagsDesc>.Get().GetAll();
	}

	public static FUStAISkillTagsDesc GetFUStAISkillTagsDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStAISkillTagsDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStAIActionDesc> GetTBFUStAIActionDesc()
	{
		return BG_ProtobufDataAPI<FUStAIActionDesc>.Get().GetAll();
	}

	public static FUStAIActionDesc GetFUStAIActionDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStAIActionDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStAIThinkDesc> GetTBFUStAIThinkDesc()
	{
		return BG_ProtobufDataAPI<FUStAIThinkDesc>.Get().GetAll();
	}

	public static FUStAIThinkDesc GetFUStAIThinkDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStAIThinkDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStAIFeatureDesc> GetTBFUStAIFeatureDesc()
	{
		return BG_ProtobufDataAPI<FUStAIFeatureDesc>.Get().GetAll();
	}

	public static FUStAIFeatureDesc GetFUStAIFeatureDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStAIFeatureDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStEnhancedInputActionDesc> GetTBFUStEnhancedInputActionDesc()
	{
		return BG_ProtobufDataAPI<FUStEnhancedInputActionDesc>.Get().GetAll();
	}

	public static FUStEnhancedInputActionDesc GetFUStEnhancedInputActionDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStEnhancedInputActionDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStChallengeDesc> GetTBFUStChallengeDesc()
	{
		return BG_ProtobufDataAPI<FUStChallengeDesc>.Get().GetAll();
	}

	public static FUStChallengeDesc GetFUStChallengeDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStChallengeDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStGuideNodeDesc> GetTBFUStGuideNodeDesc()
	{
		return BG_ProtobufDataAPI<FUStGuideNodeDesc>.Get().GetAll();
	}

	public static FUStGuideNodeDesc GetFUStGuideNodeDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStGuideNodeDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStGuideGroupDesc> GetTBFUStGuideGroupDesc()
	{
		return BG_ProtobufDataAPI<FUStGuideGroupDesc>.Get().GetAll();
	}

	public static FUStGuideGroupDesc GetFUStGuideGroupDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStGuideGroupDesc>.Get().FindByID(ResID);
	}

	public static Dictionary<int, FUStAkEventMarkerDesc> GetTBFUStAkEventMarkerDesc()
	{
		return BG_ProtobufDataAPI<FUStAkEventMarkerDesc>.Get().GetAll();
	}

	public static FUStAkEventMarkerDesc GetFUStAkEventMarkerDesc(int ResID)
	{
		return BG_ProtobufDataAPI<FUStAkEventMarkerDesc>.Get().FindByID(ResID);
	}

	public static void LoadRes()
	{
		GSProtobufRuntimeAPI<TBCommLogicCfgDesc, CommLogicCfgDesc>.Get().LoadDataById();
		GSProtobufRuntimeAPI<TBPlayerLevelDesc, PlayerLevelDesc>.Get().LoadDataById();
		GSProtobufRuntimeAPI<TBItemDesc, ItemDesc>.Get().LoadDataById();
		GSProtobufRuntimeAPI<TBAttrItemDesc, AttrItemDesc>.Get().LoadDataById();
		GSProtobufRuntimeAPI<TBConsumeDesc, ConsumeDesc>.Get().LoadDataById();
		GSProtobufRuntimeAPI<TBEquipFaBaoAttrDesc, EquipFaBaoAttrDesc>.Get().LoadDataById();
		GSProtobufRuntimeAPI<TBEquipPositionConfDesc, EquipPositionConfDesc>.Get().LoadDataById();
		GSProtobufRuntimeAPI<TBEquipDesc, EquipDesc>.Get().LoadDataById();
		GSProtobufRuntimeAPI<TBEquipAttrDesc, EquipAttrDesc>.Get().LoadDataById();
		GSProtobufRuntimeAPI<TBWeaponBuildDesc, WeaponBuildDesc>.Get().LoadDataById();
		GSProtobufRuntimeAPI<TBMultiplayerDropRuleDesc, MultiplayerDropRuleDesc>.Get().LoadDataById();
		GSProtobufRuntimeAPI<TBUnitDropNumDesc, UnitDropNumDesc>.Get().LoadDataById();
		GSProtobufRuntimeAPI<TBSpellDesc, SpellDesc>.Get().LoadDataById();
		GSProtobufRuntimeAPI<TBShopItemDesc, ShopItemDesc>.Get().LoadDataById();
		GSProtobufRuntimeAPI<TBShopDesc, ShopDesc>.Get().LoadDataById();
		GSProtobufRuntimeAPI<TBShopRefreshDesc, ShopRefreshDesc>.Get().LoadDataById();
		GSProtobufRuntimeAPI<TBDestructionDropDesc, DestructionDropDesc>.Get().LoadDataById();
		GSProtobufRuntimeAPI<TBLevelDesc, LevelDesc>.Get().LoadDataById();
		GSProtobufRuntimeAPI<TBTalentSDesc, TalentSDesc>.Get().LoadDataById();
		GSProtobufRuntimeAPI<TBMapAreaConfigDesc, MapAreaConfigDesc>.Get().LoadDataById();
		GSProtobufRuntimeAPI<TBMapSpriteConfigDesc, MapSpriteConfigDesc>.Get().LoadDataById();
		GSProtobufRuntimeAPI<TBMapAtlasConfigDesc, MapAtlasConfigDesc>.Get().LoadDataById();
		GSProtobufRuntimeAPI<TBIncreaseConfigDesc, IncreaseConfigDesc>.Get().LoadDataById();
		GSProtobufRuntimeAPI<TBCommonErrorUITipsDesc, CommonErrorUITipsDesc>.Get().LoadDataById();
		GSProtobufRuntimeAPI<TBWineDesc, WineDesc>.Get().LoadDataById();
		GSProtobufRuntimeAPI<TBHuluDesc, HuluDesc>.Get().LoadDataById();
		GSProtobufRuntimeAPI<TBItemRecipeDesc, ItemRecipeDesc>.Get().LoadDataById();
		GSProtobufRuntimeAPI<TBCardDesc, CardDesc>.Get().LoadDataById();
		GSProtobufRuntimeAPI<TBAchievementDesc, AchievementDesc>.Get().LoadDataById();
		GSProtobufRuntimeAPI<TBAlchemyOutputDesc, AlchemyOutputDesc>.Get().LoadDataById();
		GSProtobufRuntimeAPI<TBMeditationPointDesc, MeditationPointDesc>.Get().LoadDataById();
		GSProtobufRuntimeAPI<TBBloodHudDesc, BloodHudDesc>.Get().LoadDataById();
		GSProtobufRuntimeAPI<TBLoadingTipsDesc, LoadingTipsDesc>.Get().LoadDataById();
		GSProtobufRuntimeAPI<TBMovieAndSubtitleDesc, MovieAndSubtitleDesc>.Get().LoadDataById();
		GSProtobufRuntimeAPI<TBInteractionFuncDesc, InteractionFuncDesc>.Get().LoadDataById();
		GSProtobufRuntimeAPI<TBTransInputUITipsDesc, TransInputUITipsDesc>.Get().LoadDataById();
		GSProtobufRuntimeAPI<TBUISettingConfigDesc, UISettingConfigDesc>.Get().LoadDataById();
		GSProtobufRuntimeAPI<TBBossReChallengeDesc, BossReChallengeDesc>.Get().LoadDataById();
		GSProtobufRuntimeAPI<TBBossIterationsDesc, BossIterationsDesc>.Get().LoadDataById();
		GSProtobufRuntimeAPI<TBBossRushDebuffDesc, BossRushDebuffDesc>.Get().LoadDataById();
		GSProtobufRuntimeAPI<TBRebirthPointPosDesc, RebirthPointPosDesc>.Get().LoadDataById();
		GSProtobufRuntimeAPI<TBUISettingDeviceConfigDesc, UISettingDeviceConfigDesc>.Get().LoadDataById();
		GSProtobufRuntimeAPI<TBSurpriseDesc, SurpriseDesc>.Get().LoadDataById();
		GSProtobufRuntimeAPI<TBChapterDesc, ChapterDesc>.Get().LoadDataById();
		GSProtobufRuntimeAPI<TBHistoricDesc, HistoricDesc>.Get().LoadDataById();
		GSProtobufRuntimeAPI<TBPastMemoryDesc, PastMemoryDesc>.Get().LoadDataById();
		GSProtobufRuntimeAPI<TBArtBookDesc, ArtBookDesc>.Get().LoadDataById();
		GSProtobufRuntimeAPI<TBSoundTrackDesc, SoundTrackDesc>.Get().LoadDataById();
		GSProtobufRuntimeAPI<TBMuseumMVDesc, MuseumMVDesc>.Get().LoadDataById();
		GSProtobufRuntimeAPI<TBArmorEnhanceDesc, ArmorEnhanceDesc>.Get().LoadDataById();
		GSProtobufRuntimeAPI<TBMantraDesc, MantraDesc>.Get().LoadDataById();
		GSProtobufRuntimeAPI<TBMantraWeightDesc, MantraWeightDesc>.Get().LoadDataById();
		GSProtobufRuntimeAPI<TBEquipSeriesDesc, EquipSeriesDesc>.Get().LoadDataById();
		GSProtobufRuntimeAPI<TBLockMantraDesc, LockMantraDesc>.Get().LoadDataById();
		GSProtobufRuntimeAPI<TBMantraBuildupDesc, MantraBuildupDesc>.Get().LoadDataById();
		GSProtobufRuntimeAPI<TBMapFragmentDesc, MapFragmentDesc>.Get().LoadDataById();
		GSProtobufRuntimeAPI<TBSceneMonsterNameplateDesc, SceneMonsterNameplateDesc>.Get().LoadDataById();
		GSProtobufRuntimeAPI<TBSoulSkillDesc, SoulSkillDesc>.Get().LoadDataById();
		GSProtobufRuntimeAPI<TBSoulSkillDropDesc, SoulSkillDropDesc>.Get().LoadDataById();
		GSProtobufRuntimeAPI<TBSeedDesc, SeedDesc>.Get().LoadDataById();
		GSProtobufRuntimeAPI<TBGMMonsterTeleportDesc, GMMonsterTeleportDesc>.Get().LoadDataById();
		GSProtobufRuntimeAPI<TBPS5ActivityDesc, PS5ActivityDesc>.Get().LoadDataById();
		GSProtobufRuntimeAPI<TBPS5ActivityTaskDesc, PS5ActivityTaskDesc>.Get().LoadDataById();
		GSProtobufRuntimeAPI<TBPlatformAchievementLiteDesc, PlatformAchievementLiteDesc>.Get().LoadDataById();
		GSProtobufRuntimeAPI<TBPlatformAchievementDesc, PlatformAchievementDesc>.Get().LoadDataById();
		GSProtobufRuntimeAPI<TBTakePhotoCustomSettingDesc, TakePhotoCustomSettingDesc>.Get().LoadDataById();
		GSProtobufRuntimeAPI<TBCricketBattleUnitDesc, CricketBattleUnitDesc>.Get().LoadDataById();
		GSProtobufRuntimeAPI<TBEchoDesc, EchoDesc>.Get().LoadDataById();
		GSProtobufRuntimeAPI<TBLinkBloodDesc, LinkBloodDesc>.Get().LoadDataById();
		GSProtobufRuntimeAPI<TBNPCInteractConversationDesc, NPCInteractConversationDesc>.Get().LoadDataById();
		GSProtobufRuntimeAPI<TBEditionAwardDesc, EditionAwardDesc>.Get().LoadDataById();
		GSProtobufRuntimeAPI<TBTeamConfigDesc, TeamConfigDesc>.Get().LoadDataById();
		GSProtobufRuntimeAPI<TBLotteryAwardDesc, LotteryAwardDesc>.Get().LoadDataById();
		GSProtobufRuntimeAPI<TBUnitDropRuleDesc, UnitDropRuleDesc>.Get().LoadData();
		GSProtobufRuntimeAPI<TBCommDropRuleDesc, CommDropRuleDesc>.Get().LoadData();
		GSProtobufRuntimeAPI<TBShopItemGroupDesc, ShopItemGroupDesc>.Get().LoadData();
		GSProtobufRuntimeAPI<TBCollectionDropDesc, CollectionDropDesc>.Get().LoadData();
		GSProtobufRuntimeAPI<TBTalentRankDesc, TalentRankDesc>.Get().LoadData();
		GSProtobufRuntimeAPI<TBRoleDataConfigDesc, RoleDataConfigDesc>.Get().LoadData();
		GSProtobufRuntimeAPI<TBNewGamePlusDesc, NewGamePlusDesc>.Get().LoadData();
		GSProtobufRuntimeAPI<TBLoadingTipsWeightDesc, LoadingTipsWeightDesc>.Get().LoadData();
		GSProtobufRuntimeAPI<TBArmorEnhanceConsumeDesc, ArmorEnhanceConsumeDesc>.Get().LoadData();
		GSProtobufRuntimeAPI<TBSeedCollectionAwardDesc, SeedCollectionAwardDesc>.Get().LoadData();
		GSProtobufRuntimeAPI<TBMedicineAwardDesc, MedicineAwardDesc>.Get().LoadData();
		GSProtobufRuntimeAPI<TBCricketUnitAttrDesc, CricketUnitAttrDesc>.Get().LoadData();
		GSProtobufRuntimeAPI<TBShrineShowNpcConfigDesc, ShrineShowNpcConfigDesc>.Get().LoadData();
	}

	public static void CheckAllResB1DescAutoGen()
	{
		CheckConsumeDescAutoGen();
		CheckEquipFaBaoAttrDescAutoGen();
		CheckEquipDescAutoGen();
		CheckWeaponBuildDescAutoGen();
		CheckCommDropRuleDescAutoGen();
		CheckShopItemDescAutoGen();
		CheckWineDescAutoGen();
		CheckHuluDescAutoGen();
		CheckItemRecipeDescAutoGen();
		CheckMeditationPointDescAutoGen();
		CheckBossReChallengeDescAutoGen();
		CheckBossIterationsDescAutoGen();
		CheckSurpriseDescAutoGen();
		CheckChapterDescAutoGen();
		CheckHistoricDescAutoGen();
		CheckPastMemoryDescAutoGen();
		CheckArtBookDescAutoGen();
		CheckMuseumMVDescAutoGen();
		CheckArmorEnhanceConsumeDescAutoGen();
		CheckEquipSeriesDescAutoGen();
		CheckLockMantraDescAutoGen();
		CheckMantraBuildupDescAutoGen();
		CheckMapFragmentDescAutoGen();
		CheckSoulSkillDescAutoGen();
		CheckSeedDescAutoGen();
		CheckSeedCollectionAwardDescAutoGen();
		CheckMedicineAwardDescAutoGen();
		CheckPS5ActivityTaskDescAutoGen();
		CheckPlatformAchievementLiteDescAutoGen();
		CheckPlatformAchievementDescAutoGen();
		CheckEditionAwardDescAutoGen();
	}

	public static TBTranslateKeyWordDesc GetTBTranslateKeyWordDesc()
	{
		return GSProtobufRuntimeAPI<TBTranslateKeyWordDesc, TranslateKeyWordDesc>.Get().GetAll();
	}

	public static TBStringKVMapDesc GetTBStringKVMapDesc()
	{
		return GSProtobufRuntimeAPI<TBStringKVMapDesc, StringKVMapDesc>.Get().GetAll();
	}

	public static StringKVMapDesc GetStringKVMapDesc(int ResId)
	{
		return GSProtobufRuntimeAPI<TBStringKVMapDesc, StringKVMapDesc>.Get().FindByID(ResId);
	}

	public static bool CheckStringKVMapListAutoGen(bool LastCheckValue, IEnumerable<int> IdList, List<string> ErrMsgs)
	{
		bool flag = true;
		foreach (int Id in IdList)
		{
			if (Id != 0 && GetStringKVMapDesc(Id) == null)
			{
				flag = false;
				string item = $"StringKVMap Id : {Id} does not exist in StringKVMapDesc";
				ErrMsgs.Add(item);
			}
		}
		return LastCheckValue && flag;
	}

	public static TBServerTranslateDesc GetTBServerTranslateDesc()
	{
		return GSProtobufRuntimeAPI<TBServerTranslateDesc, ServerTranslateDesc>.Get().GetAll();
	}

	public static TBVaildLanguageDesc GetTBVaildLanguageDesc()
	{
		return GSProtobufRuntimeAPI<TBVaildLanguageDesc, VaildLanguageDesc>.Get().GetAll();
	}

	public static TBCommLogicCfgDesc GetTBCommLogicCfgDesc()
	{
		return GSProtobufRuntimeAPI<TBCommLogicCfgDesc, CommLogicCfgDesc>.Get().GetAll();
	}

	public static CommLogicCfgDesc GetCommLogicCfgDesc(int ResId)
	{
		return GSProtobufRuntimeAPI<TBCommLogicCfgDesc, CommLogicCfgDesc>.Get().FindByID(ResId);
	}

	public static bool CheckCommLogicCfgListAutoGen(bool LastCheckValue, IEnumerable<int> IdList, List<string> ErrMsgs)
	{
		bool flag = true;
		foreach (int Id in IdList)
		{
			if (Id != 0 && GetCommLogicCfgDesc(Id) == null)
			{
				flag = false;
				string item = $"CommLogicCfg Id : {Id} does not exist in CommLogicCfgDesc";
				ErrMsgs.Add(item);
			}
		}
		return LastCheckValue && flag;
	}

	public static TBPlayerLevelDesc GetTBPlayerLevelDesc()
	{
		return GSProtobufRuntimeAPI<TBPlayerLevelDesc, PlayerLevelDesc>.Get().GetAll();
	}

	public static PlayerLevelDesc GetPlayerLevelDesc(int ResId)
	{
		return GSProtobufRuntimeAPI<TBPlayerLevelDesc, PlayerLevelDesc>.Get().FindByID(ResId);
	}

	public static bool CheckPlayerLevelListAutoGen(bool LastCheckValue, IEnumerable<int> IdList, List<string> ErrMsgs)
	{
		bool flag = true;
		foreach (int Id in IdList)
		{
			if (Id != 0 && GetPlayerLevelDesc(Id) == null)
			{
				flag = false;
				string item = $"PlayerLevel Id : {Id} does not exist in PlayerLevelDesc";
				ErrMsgs.Add(item);
			}
		}
		return LastCheckValue && flag;
	}

	public static TBItemDesc GetTBItemDesc()
	{
		return GSProtobufRuntimeAPI<TBItemDesc, ItemDesc>.Get().GetAll();
	}

	public static ItemDesc GetItemDesc(int ResId)
	{
		return GSProtobufRuntimeAPI<TBItemDesc, ItemDesc>.Get().FindByID(ResId);
	}

	public static bool CheckItemListAutoGen(bool LastCheckValue, IEnumerable<int> IdList, List<string> ErrMsgs)
	{
		bool flag = true;
		foreach (int Id in IdList)
		{
			if (Id != 0 && GetItemDesc(Id) == null)
			{
				flag = false;
				string item = $"Item Id : {Id} does not exist in ItemDesc";
				ErrMsgs.Add(item);
			}
		}
		return LastCheckValue && flag;
	}

	public static TBAttrItemDesc GetTBAttrItemDesc()
	{
		return GSProtobufRuntimeAPI<TBAttrItemDesc, AttrItemDesc>.Get().GetAll();
	}

	public static AttrItemDesc GetAttrItemDesc(int ResId)
	{
		return GSProtobufRuntimeAPI<TBAttrItemDesc, AttrItemDesc>.Get().FindByID(ResId);
	}

	public static bool CheckAttrItemListAutoGen(bool LastCheckValue, IEnumerable<int> IdList, List<string> ErrMsgs)
	{
		bool flag = true;
		foreach (int Id in IdList)
		{
			if (Id != 0 && GetAttrItemDesc(Id) == null)
			{
				flag = false;
				string item = $"AttrItem Id : {Id} does not exist in AttrItemDesc";
				ErrMsgs.Add(item);
			}
		}
		return LastCheckValue && flag;
	}

	public static TBConsumeDesc GetTBConsumeDesc()
	{
		return GSProtobufRuntimeAPI<TBConsumeDesc, ConsumeDesc>.Get().GetAll();
	}

	public static ConsumeDesc GetConsumeDesc(int ResId)
	{
		return GSProtobufRuntimeAPI<TBConsumeDesc, ConsumeDesc>.Get().FindByID(ResId);
	}

	public static bool CheckConsumeListAutoGen(bool LastCheckValue, IEnumerable<int> IdList, List<string> ErrMsgs)
	{
		bool flag = true;
		foreach (int Id in IdList)
		{
			if (Id != 0 && GetConsumeDesc(Id) == null)
			{
				flag = false;
				string item = $"Consume Id : {Id} does not exist in ConsumeDesc";
				ErrMsgs.Add(item);
			}
		}
		return LastCheckValue && flag;
	}

	public static void CheckConsumeDescAutoGen()
	{
		string toBlame = "";
		foreach (ConsumeDesc item in GetTBConsumeDesc().List)
		{
			if (GetItemDesc(item.Id) == null)
			{
				int id = item.Id;
				int id2 = item.Id;
				AddValidateLog($"ConsumeDesc表 错误id:{id2} Id:{id} 未在ItemDesc里找到对应值", toBlame);
			}
		}
	}

	public static TBEquipFaBaoAttrDesc GetTBEquipFaBaoAttrDesc()
	{
		return GSProtobufRuntimeAPI<TBEquipFaBaoAttrDesc, EquipFaBaoAttrDesc>.Get().GetAll();
	}

	public static EquipFaBaoAttrDesc GetEquipFaBaoAttrDesc(int ResId)
	{
		return GSProtobufRuntimeAPI<TBEquipFaBaoAttrDesc, EquipFaBaoAttrDesc>.Get().FindByID(ResId);
	}

	public static bool CheckEquipFaBaoAttrListAutoGen(bool LastCheckValue, IEnumerable<int> IdList, List<string> ErrMsgs)
	{
		bool flag = true;
		foreach (int Id in IdList)
		{
			if (Id != 0 && GetEquipFaBaoAttrDesc(Id) == null)
			{
				flag = false;
				string item = $"EquipFaBaoAttr Id : {Id} does not exist in EquipFaBaoAttrDesc";
				ErrMsgs.Add(item);
			}
		}
		return LastCheckValue && flag;
	}

	public static void CheckEquipFaBaoAttrDescAutoGen()
	{
		string toBlame = "";
		foreach (EquipFaBaoAttrDesc item in GetTBEquipFaBaoAttrDesc().List)
		{
			if (GetEquipDesc(item.Id) == null)
			{
				int id = item.Id;
				int id2 = item.Id;
				AddValidateLog($"EquipFaBaoAttrDesc表 错误id:{id2} Id:{id} 未在EquipDesc里找到对应值", toBlame);
			}
		}
	}

	public static TBEquipPositionConfDesc GetTBEquipPositionConfDesc()
	{
		return GSProtobufRuntimeAPI<TBEquipPositionConfDesc, EquipPositionConfDesc>.Get().GetAll();
	}

	public static EquipPositionConfDesc GetEquipPositionConfDesc(int ResId)
	{
		return GSProtobufRuntimeAPI<TBEquipPositionConfDesc, EquipPositionConfDesc>.Get().FindByID(ResId);
	}

	public static bool CheckEquipPositionConfListAutoGen(bool LastCheckValue, IEnumerable<int> IdList, List<string> ErrMsgs)
	{
		bool flag = true;
		foreach (int Id in IdList)
		{
			if (Id != 0 && GetEquipPositionConfDesc(Id) == null)
			{
				flag = false;
				string item = $"EquipPositionConf Id : {Id} does not exist in EquipPositionConfDesc";
				ErrMsgs.Add(item);
			}
		}
		return LastCheckValue && flag;
	}

	public static TBEquipDesc GetTBEquipDesc()
	{
		return GSProtobufRuntimeAPI<TBEquipDesc, EquipDesc>.Get().GetAll();
	}

	public static EquipDesc GetEquipDesc(int ResId)
	{
		return GSProtobufRuntimeAPI<TBEquipDesc, EquipDesc>.Get().FindByID(ResId);
	}

	public static bool CheckEquipListAutoGen(bool LastCheckValue, IEnumerable<int> IdList, List<string> ErrMsgs)
	{
		bool flag = true;
		foreach (int Id in IdList)
		{
			if (Id != 0 && GetEquipDesc(Id) == null)
			{
				flag = false;
				string item = $"Equip Id : {Id} does not exist in EquipDesc";
				ErrMsgs.Add(item);
			}
		}
		return LastCheckValue && flag;
	}

	public static void CheckEquipDescAutoGen()
	{
		string toBlame = "";
		foreach (EquipDesc item in GetTBEquipDesc().List)
		{
			if (GetItemDesc(item.Id) == null)
			{
				int id = item.Id;
				int id2 = item.Id;
				AddValidateLog($"EquipDesc表 错误id:{id2} Id:{id} 未在ItemDesc里找到对应值", toBlame);
			}
		}
	}

	public static TBEquipAttrDesc GetTBEquipAttrDesc()
	{
		return GSProtobufRuntimeAPI<TBEquipAttrDesc, EquipAttrDesc>.Get().GetAll();
	}

	public static EquipAttrDesc GetEquipAttrDesc(int ResId)
	{
		return GSProtobufRuntimeAPI<TBEquipAttrDesc, EquipAttrDesc>.Get().FindByID(ResId);
	}

	public static bool CheckEquipAttrListAutoGen(bool LastCheckValue, IEnumerable<int> IdList, List<string> ErrMsgs)
	{
		bool flag = true;
		foreach (int Id in IdList)
		{
			if (Id != 0 && GetEquipAttrDesc(Id) == null)
			{
				flag = false;
				string item = $"EquipAttr Id : {Id} does not exist in EquipAttrDesc";
				ErrMsgs.Add(item);
			}
		}
		return LastCheckValue && flag;
	}

	public static TBWeaponBuildDesc GetTBWeaponBuildDesc()
	{
		return GSProtobufRuntimeAPI<TBWeaponBuildDesc, WeaponBuildDesc>.Get().GetAll();
	}

	public static WeaponBuildDesc GetWeaponBuildDesc(int ResId)
	{
		return GSProtobufRuntimeAPI<TBWeaponBuildDesc, WeaponBuildDesc>.Get().FindByID(ResId);
	}

	public static bool CheckWeaponBuildListAutoGen(bool LastCheckValue, IEnumerable<int> IdList, List<string> ErrMsgs)
	{
		bool flag = true;
		foreach (int Id in IdList)
		{
			if (Id != 0 && GetWeaponBuildDesc(Id) == null)
			{
				flag = false;
				string item = $"WeaponBuild Id : {Id} does not exist in WeaponBuildDesc";
				ErrMsgs.Add(item);
			}
		}
		return LastCheckValue && flag;
	}

	public static void CheckWeaponBuildDescAutoGen()
	{
		string toBlame = "jasonwu";
		foreach (WeaponBuildDesc item in GetTBWeaponBuildDesc().List)
		{
			if (GetEquipDesc(item.Id) == null)
			{
				int id = item.Id;
				int id2 = item.Id;
				AddValidateLog($"WeaponBuildDesc表 错误id:{id2} Id:{id} 未在EquipDesc里找到对应值", toBlame);
			}
			for (int i = 0; i < item.CostItem.Count; i++)
			{
				if (GetItemDesc(item.CostItem[i].Id) == null)
				{
					int id3 = item.CostItem[i].Id;
					int id4 = item.Id;
					AddValidateLog($"WeaponBuildDesc表 错误id:{id4} CostItem[{i}] Id:{id3} 未在ItemDesc里找到对应值", toBlame);
				}
			}
			for (int j = 0; j < item.TransformItem.Count; j++)
			{
				if (GetItemDesc(item.TransformItem[j].Id) == null)
				{
					int id5 = item.TransformItem[j].Id;
					int id6 = item.Id;
					AddValidateLog($"WeaponBuildDesc表 错误id:{id6} TransformItem[{j}] Id:{id5} 未在ItemDesc里找到对应值", toBlame);
				}
			}
			for (int k = 0; k < item.KeyItemList.Count; k++)
			{
				if (GetItemDesc(item.KeyItemList[k].Id) == null)
				{
					int id7 = item.KeyItemList[k].Id;
					int id8 = item.Id;
					AddValidateLog($"WeaponBuildDesc表 错误id:{id8} KeyItemList[{k}] Id:{id7} 未在ItemDesc里找到对应值", toBlame);
				}
			}
		}
	}

	public static TBUnitDropRuleDesc GetTBUnitDropRuleDesc()
	{
		return GSProtobufRuntimeAPI<TBUnitDropRuleDesc, UnitDropRuleDesc>.Get().GetAll();
	}

	public static TBCommDropRuleDesc GetTBCommDropRuleDesc()
	{
		return GSProtobufRuntimeAPI<TBCommDropRuleDesc, CommDropRuleDesc>.Get().GetAll();
	}

	public static void CheckCommDropRuleDescAutoGen()
	{
		string toBlame = "";
		foreach (CommDropRuleDesc item in GetTBCommDropRuleDesc().List)
		{
			for (int i = 0; i < item.UniqueDropOnce.Count; i++)
			{
				if (GetItemDesc(item.UniqueDropOnce[i].Id) == null)
				{
					int id = item.UniqueDropOnce[i].Id;
					int dropId = item.DropId;
					AddValidateLog($"CommDropRuleDesc表 错误id:{dropId} UniqueDropOnce[{i}] Id:{id} 未在ItemDesc里找到对应值", toBlame);
				}
			}
			for (int j = 0; j < item.UniqueDropReplace.Count; j++)
			{
				if (GetItemDesc(item.UniqueDropReplace[j].Id) == null)
				{
					int id2 = item.UniqueDropReplace[j].Id;
					int dropId2 = item.DropId;
					AddValidateLog($"CommDropRuleDesc表 错误id:{dropId2} UniqueDropReplace[{j}] Id:{id2} 未在ItemDesc里找到对应值", toBlame);
				}
			}
			for (int k = 0; k < item.RandDrop.Count; k++)
			{
				if (GetItemDesc(item.RandDrop[k].ItemId) == null)
				{
					int itemId = item.RandDrop[k].ItemId;
					int dropId3 = item.DropId;
					AddValidateLog($"CommDropRuleDesc表 错误id:{dropId3} RandDrop[{k}] ItemId:{itemId} 未在ItemDesc里找到对应值", toBlame);
				}
			}
		}
	}

	public static TBMultiplayerDropRuleDesc GetTBMultiplayerDropRuleDesc()
	{
		return GSProtobufRuntimeAPI<TBMultiplayerDropRuleDesc, MultiplayerDropRuleDesc>.Get().GetAll();
	}

	public static MultiplayerDropRuleDesc GetMultiplayerDropRuleDesc(int ResId)
	{
		return GSProtobufRuntimeAPI<TBMultiplayerDropRuleDesc, MultiplayerDropRuleDesc>.Get().FindByID(ResId);
	}

	public static bool CheckMultiplayerDropRuleListAutoGen(bool LastCheckValue, IEnumerable<int> IdList, List<string> ErrMsgs)
	{
		bool flag = true;
		foreach (int Id in IdList)
		{
			if (Id != 0 && GetMultiplayerDropRuleDesc(Id) == null)
			{
				flag = false;
				string item = $"MultiplayerDropRule Id : {Id} does not exist in MultiplayerDropRuleDesc";
				ErrMsgs.Add(item);
			}
		}
		return LastCheckValue && flag;
	}

	public static TBUnitDropNumDesc GetTBUnitDropNumDesc()
	{
		return GSProtobufRuntimeAPI<TBUnitDropNumDesc, UnitDropNumDesc>.Get().GetAll();
	}

	public static UnitDropNumDesc GetUnitDropNumDesc(int ResId)
	{
		return GSProtobufRuntimeAPI<TBUnitDropNumDesc, UnitDropNumDesc>.Get().FindByID(ResId);
	}

	public static bool CheckUnitDropNumListAutoGen(bool LastCheckValue, IEnumerable<int> IdList, List<string> ErrMsgs)
	{
		bool flag = true;
		foreach (int Id in IdList)
		{
			if (Id != 0 && GetUnitDropNumDesc(Id) == null)
			{
				flag = false;
				string item = $"UnitDropNum Id : {Id} does not exist in UnitDropNumDesc";
				ErrMsgs.Add(item);
			}
		}
		return LastCheckValue && flag;
	}

	public static TBSpellDesc GetTBSpellDesc()
	{
		return GSProtobufRuntimeAPI<TBSpellDesc, SpellDesc>.Get().GetAll();
	}

	public static SpellDesc GetSpellDesc(int ResId)
	{
		return GSProtobufRuntimeAPI<TBSpellDesc, SpellDesc>.Get().FindByID(ResId);
	}

	public static bool CheckSpellListAutoGen(bool LastCheckValue, IEnumerable<int> IdList, List<string> ErrMsgs)
	{
		bool flag = true;
		foreach (int Id in IdList)
		{
			if (Id != 0 && GetSpellDesc(Id) == null)
			{
				flag = false;
				string item = $"Spell Id : {Id} does not exist in SpellDesc";
				ErrMsgs.Add(item);
			}
		}
		return LastCheckValue && flag;
	}

	public static TBShopItemDesc GetTBShopItemDesc()
	{
		return GSProtobufRuntimeAPI<TBShopItemDesc, ShopItemDesc>.Get().GetAll();
	}

	public static ShopItemDesc GetShopItemDesc(int ResId)
	{
		return GSProtobufRuntimeAPI<TBShopItemDesc, ShopItemDesc>.Get().FindByID(ResId);
	}

	public static bool CheckShopItemListAutoGen(bool LastCheckValue, IEnumerable<int> IdList, List<string> ErrMsgs)
	{
		bool flag = true;
		foreach (int Id in IdList)
		{
			if (Id != 0 && GetShopItemDesc(Id) == null)
			{
				flag = false;
				string item = $"ShopItem Id : {Id} does not exist in ShopItemDesc";
				ErrMsgs.Add(item);
			}
		}
		return LastCheckValue && flag;
	}

	public static void CheckShopItemDescAutoGen()
	{
		string toBlame = "";
		foreach (ShopItemDesc item in GetTBShopItemDesc().List)
		{
			if (GetItemDesc(item.ItemId) == null)
			{
				int itemId = item.ItemId;
				int id = item.Id;
				AddValidateLog($"ShopItemDesc表 错误id:{id} ItemId:{itemId} 未在ItemDesc里找到对应值", toBlame);
			}
			for (int i = 0; i < item.CostItem.Count; i++)
			{
				if (GetItemDesc(item.CostItem[i].Id) == null)
				{
					int id2 = item.CostItem[i].Id;
					int id3 = item.Id;
					AddValidateLog($"ShopItemDesc表 错误id:{id3} CostItem[{i}] Id:{id2} 未在ItemDesc里找到对应值", toBlame);
				}
			}
		}
	}

	public static TBShopDesc GetTBShopDesc()
	{
		return GSProtobufRuntimeAPI<TBShopDesc, ShopDesc>.Get().GetAll();
	}

	public static ShopDesc GetShopDesc(int ResId)
	{
		return GSProtobufRuntimeAPI<TBShopDesc, ShopDesc>.Get().FindByID(ResId);
	}

	public static bool CheckShopListAutoGen(bool LastCheckValue, IEnumerable<int> IdList, List<string> ErrMsgs)
	{
		bool flag = true;
		foreach (int Id in IdList)
		{
			if (Id != 0 && GetShopDesc(Id) == null)
			{
				flag = false;
				string item = $"Shop Id : {Id} does not exist in ShopDesc";
				ErrMsgs.Add(item);
			}
		}
		return LastCheckValue && flag;
	}

	public static TBShopItemGroupDesc GetTBShopItemGroupDesc()
	{
		return GSProtobufRuntimeAPI<TBShopItemGroupDesc, ShopItemGroupDesc>.Get().GetAll();
	}

	public static TBShopRefreshDesc GetTBShopRefreshDesc()
	{
		return GSProtobufRuntimeAPI<TBShopRefreshDesc, ShopRefreshDesc>.Get().GetAll();
	}

	public static ShopRefreshDesc GetShopRefreshDesc(int ResId)
	{
		return GSProtobufRuntimeAPI<TBShopRefreshDesc, ShopRefreshDesc>.Get().FindByID(ResId);
	}

	public static bool CheckShopRefreshListAutoGen(bool LastCheckValue, IEnumerable<int> IdList, List<string> ErrMsgs)
	{
		bool flag = true;
		foreach (int Id in IdList)
		{
			if (Id != 0 && GetShopRefreshDesc(Id) == null)
			{
				flag = false;
				string item = $"ShopRefresh Id : {Id} does not exist in ShopRefreshDesc";
				ErrMsgs.Add(item);
			}
		}
		return LastCheckValue && flag;
	}

	public static TBCollectionDropDesc GetTBCollectionDropDesc()
	{
		return GSProtobufRuntimeAPI<TBCollectionDropDesc, CollectionDropDesc>.Get().GetAll();
	}

	public static TBDestructionDropDesc GetTBDestructionDropDesc()
	{
		return GSProtobufRuntimeAPI<TBDestructionDropDesc, DestructionDropDesc>.Get().GetAll();
	}

	public static DestructionDropDesc GetDestructionDropDesc(int ResId)
	{
		return GSProtobufRuntimeAPI<TBDestructionDropDesc, DestructionDropDesc>.Get().FindByID(ResId);
	}

	public static bool CheckDestructionDropListAutoGen(bool LastCheckValue, IEnumerable<int> IdList, List<string> ErrMsgs)
	{
		bool flag = true;
		foreach (int Id in IdList)
		{
			if (Id != 0 && GetDestructionDropDesc(Id) == null)
			{
				flag = false;
				string item = $"DestructionDrop Id : {Id} does not exist in DestructionDropDesc";
				ErrMsgs.Add(item);
			}
		}
		return LastCheckValue && flag;
	}

	public static TBLevelDesc GetTBLevelDesc()
	{
		return GSProtobufRuntimeAPI<TBLevelDesc, LevelDesc>.Get().GetAll();
	}

	public static LevelDesc GetLevelDesc(int ResId)
	{
		return GSProtobufRuntimeAPI<TBLevelDesc, LevelDesc>.Get().FindByID(ResId);
	}

	public static bool CheckLevelListAutoGen(bool LastCheckValue, IEnumerable<int> IdList, List<string> ErrMsgs)
	{
		bool flag = true;
		foreach (int Id in IdList)
		{
			if (Id != 0 && GetLevelDesc(Id) == null)
			{
				flag = false;
				string item = $"Level Id : {Id} does not exist in LevelDesc";
				ErrMsgs.Add(item);
			}
		}
		return LastCheckValue && flag;
	}

	public static TBRandNameDesc GetTBRandNameDesc()
	{
		return GSProtobufRuntimeAPI<TBRandNameDesc, RandNameDesc>.Get().GetAll();
	}

	public static TBTalentRankDesc GetTBTalentRankDesc()
	{
		return GSProtobufRuntimeAPI<TBTalentRankDesc, TalentRankDesc>.Get().GetAll();
	}

	public static TBTalentSDesc GetTBTalentSDesc()
	{
		return GSProtobufRuntimeAPI<TBTalentSDesc, TalentSDesc>.Get().GetAll();
	}

	public static TalentSDesc GetTalentSDesc(int ResId)
	{
		return GSProtobufRuntimeAPI<TBTalentSDesc, TalentSDesc>.Get().FindByID(ResId);
	}

	public static bool CheckTalentSListAutoGen(bool LastCheckValue, IEnumerable<int> IdList, List<string> ErrMsgs)
	{
		bool flag = true;
		foreach (int Id in IdList)
		{
			if (Id != 0 && GetTalentSDesc(Id) == null)
			{
				flag = false;
				string item = $"TalentS Id : {Id} does not exist in TalentSDesc";
				ErrMsgs.Add(item);
			}
		}
		return LastCheckValue && flag;
	}

	public static TBRoleDataConfigDesc GetTBRoleDataConfigDesc()
	{
		return GSProtobufRuntimeAPI<TBRoleDataConfigDesc, RoleDataConfigDesc>.Get().GetAll();
	}

	public static TBMapAreaConfigDesc GetTBMapAreaConfigDesc()
	{
		return GSProtobufRuntimeAPI<TBMapAreaConfigDesc, MapAreaConfigDesc>.Get().GetAll();
	}

	public static MapAreaConfigDesc GetMapAreaConfigDesc(int ResId)
	{
		return GSProtobufRuntimeAPI<TBMapAreaConfigDesc, MapAreaConfigDesc>.Get().FindByID(ResId);
	}

	public static bool CheckMapAreaConfigListAutoGen(bool LastCheckValue, IEnumerable<int> IdList, List<string> ErrMsgs)
	{
		bool flag = true;
		foreach (int Id in IdList)
		{
			if (Id != 0 && GetMapAreaConfigDesc(Id) == null)
			{
				flag = false;
				string item = $"MapAreaConfig Id : {Id} does not exist in MapAreaConfigDesc";
				ErrMsgs.Add(item);
			}
		}
		return LastCheckValue && flag;
	}

	public static TBMapSpriteConfigDesc GetTBMapSpriteConfigDesc()
	{
		return GSProtobufRuntimeAPI<TBMapSpriteConfigDesc, MapSpriteConfigDesc>.Get().GetAll();
	}

	public static MapSpriteConfigDesc GetMapSpriteConfigDesc(int ResId)
	{
		return GSProtobufRuntimeAPI<TBMapSpriteConfigDesc, MapSpriteConfigDesc>.Get().FindByID(ResId);
	}

	public static bool CheckMapSpriteConfigListAutoGen(bool LastCheckValue, IEnumerable<int> IdList, List<string> ErrMsgs)
	{
		bool flag = true;
		foreach (int Id in IdList)
		{
			if (Id != 0 && GetMapSpriteConfigDesc(Id) == null)
			{
				flag = false;
				string item = $"MapSpriteConfig Id : {Id} does not exist in MapSpriteConfigDesc";
				ErrMsgs.Add(item);
			}
		}
		return LastCheckValue && flag;
	}

	public static TBMapAtlasConfigDesc GetTBMapAtlasConfigDesc()
	{
		return GSProtobufRuntimeAPI<TBMapAtlasConfigDesc, MapAtlasConfigDesc>.Get().GetAll();
	}

	public static MapAtlasConfigDesc GetMapAtlasConfigDesc(int ResId)
	{
		return GSProtobufRuntimeAPI<TBMapAtlasConfigDesc, MapAtlasConfigDesc>.Get().FindByID(ResId);
	}

	public static bool CheckMapAtlasConfigListAutoGen(bool LastCheckValue, IEnumerable<int> IdList, List<string> ErrMsgs)
	{
		bool flag = true;
		foreach (int Id in IdList)
		{
			if (Id != 0 && GetMapAtlasConfigDesc(Id) == null)
			{
				flag = false;
				string item = $"MapAtlasConfig Id : {Id} does not exist in MapAtlasConfigDesc";
				ErrMsgs.Add(item);
			}
		}
		return LastCheckValue && flag;
	}

	public static TBNewGamePlusDesc GetTBNewGamePlusDesc()
	{
		return GSProtobufRuntimeAPI<TBNewGamePlusDesc, NewGamePlusDesc>.Get().GetAll();
	}

	public static TBIncreaseConfigDesc GetTBIncreaseConfigDesc()
	{
		return GSProtobufRuntimeAPI<TBIncreaseConfigDesc, IncreaseConfigDesc>.Get().GetAll();
	}

	public static IncreaseConfigDesc GetIncreaseConfigDesc(int ResId)
	{
		return GSProtobufRuntimeAPI<TBIncreaseConfigDesc, IncreaseConfigDesc>.Get().FindByID(ResId);
	}

	public static bool CheckIncreaseConfigListAutoGen(bool LastCheckValue, IEnumerable<int> IdList, List<string> ErrMsgs)
	{
		bool flag = true;
		foreach (int Id in IdList)
		{
			if (Id != 0 && GetIncreaseConfigDesc(Id) == null)
			{
				flag = false;
				string item = $"IncreaseConfig Id : {Id} does not exist in IncreaseConfigDesc";
				ErrMsgs.Add(item);
			}
		}
		return LastCheckValue && flag;
	}

	public static TBCommonErrorUITipsDesc GetTBCommonErrorUITipsDesc()
	{
		return GSProtobufRuntimeAPI<TBCommonErrorUITipsDesc, CommonErrorUITipsDesc>.Get().GetAll();
	}

	public static CommonErrorUITipsDesc GetCommonErrorUITipsDesc(int ResId)
	{
		return GSProtobufRuntimeAPI<TBCommonErrorUITipsDesc, CommonErrorUITipsDesc>.Get().FindByID(ResId);
	}

	public static bool CheckCommonErrorUITipsListAutoGen(bool LastCheckValue, IEnumerable<int> IdList, List<string> ErrMsgs)
	{
		bool flag = true;
		foreach (int Id in IdList)
		{
			if (Id != 0 && GetCommonErrorUITipsDesc(Id) == null)
			{
				flag = false;
				string item = $"CommonErrorUITips Id : {Id} does not exist in CommonErrorUITipsDesc";
				ErrMsgs.Add(item);
			}
		}
		return LastCheckValue && flag;
	}

	public static TBWineDesc GetTBWineDesc()
	{
		return GSProtobufRuntimeAPI<TBWineDesc, WineDesc>.Get().GetAll();
	}

	public static WineDesc GetWineDesc(int ResId)
	{
		return GSProtobufRuntimeAPI<TBWineDesc, WineDesc>.Get().FindByID(ResId);
	}

	public static bool CheckWineListAutoGen(bool LastCheckValue, IEnumerable<int> IdList, List<string> ErrMsgs)
	{
		bool flag = true;
		foreach (int Id in IdList)
		{
			if (Id != 0 && GetWineDesc(Id) == null)
			{
				flag = false;
				string item = $"Wine Id : {Id} does not exist in WineDesc";
				ErrMsgs.Add(item);
			}
		}
		return LastCheckValue && flag;
	}

	public static void CheckWineDescAutoGen()
	{
		string toBlame = "";
		foreach (WineDesc item in GetTBWineDesc().List)
		{
			if (GetItemDesc(item.Id) == null)
			{
				int id = item.Id;
				int id2 = item.Id;
				AddValidateLog($"WineDesc表 错误id:{id2} Id:{id} 未在ItemDesc里找到对应值", toBlame);
			}
			for (int i = 0; i < item.CostItem.Count; i++)
			{
				if (GetItemDesc(item.CostItem[i].Id) == null)
				{
					int id3 = item.CostItem[i].Id;
					int id4 = item.Id;
					AddValidateLog($"WineDesc表 错误id:{id4} CostItem[{i}] Id:{id3} 未在ItemDesc里找到对应值", toBlame);
				}
			}
		}
	}

	public static TBHuluDesc GetTBHuluDesc()
	{
		return GSProtobufRuntimeAPI<TBHuluDesc, HuluDesc>.Get().GetAll();
	}

	public static HuluDesc GetHuluDesc(int ResId)
	{
		return GSProtobufRuntimeAPI<TBHuluDesc, HuluDesc>.Get().FindByID(ResId);
	}

	public static bool CheckHuluListAutoGen(bool LastCheckValue, IEnumerable<int> IdList, List<string> ErrMsgs)
	{
		bool flag = true;
		foreach (int Id in IdList)
		{
			if (Id != 0 && GetHuluDesc(Id) == null)
			{
				flag = false;
				string item = $"Hulu Id : {Id} does not exist in HuluDesc";
				ErrMsgs.Add(item);
			}
		}
		return LastCheckValue && flag;
	}

	public static void CheckHuluDescAutoGen()
	{
		string toBlame = "";
		foreach (HuluDesc item in GetTBHuluDesc().List)
		{
			if (GetItemDesc(item.Id) == null)
			{
				int id = item.Id;
				int id2 = item.Id;
				AddValidateLog($"HuluDesc表 错误id:{id2} Id:{id} 未在ItemDesc里找到对应值", toBlame);
			}
			if (GetEquipDesc(item.Id) == null)
			{
				int id3 = item.Id;
				int id4 = item.Id;
				AddValidateLog($"HuluDesc表 错误id:{id4}  Id:{id3} 未在EquipDesc里找到对应值", toBlame);
			}
			for (int i = 0; i < item.CostItem.Count; i++)
			{
				if (GetItemDesc(item.CostItem[i].Id) == null)
				{
					int id5 = item.CostItem[i].Id;
					int id6 = item.Id;
					AddValidateLog($"HuluDesc表 错误id:{id6} CostItem[{i}] Id:{id5} 未在ItemDesc里找到对应值", toBlame);
				}
			}
		}
	}

	public static TBItemRecipeDesc GetTBItemRecipeDesc()
	{
		return GSProtobufRuntimeAPI<TBItemRecipeDesc, ItemRecipeDesc>.Get().GetAll();
	}

	public static ItemRecipeDesc GetItemRecipeDesc(int ResId)
	{
		return GSProtobufRuntimeAPI<TBItemRecipeDesc, ItemRecipeDesc>.Get().FindByID(ResId);
	}

	public static bool CheckItemRecipeListAutoGen(bool LastCheckValue, IEnumerable<int> IdList, List<string> ErrMsgs)
	{
		bool flag = true;
		foreach (int Id in IdList)
		{
			if (Id != 0 && GetItemRecipeDesc(Id) == null)
			{
				flag = false;
				string item = $"ItemRecipe Id : {Id} does not exist in ItemRecipeDesc";
				ErrMsgs.Add(item);
			}
		}
		return LastCheckValue && flag;
	}

	public static void CheckItemRecipeDescAutoGen()
	{
		string toBlame = "";
		foreach (ItemRecipeDesc item in GetTBItemRecipeDesc().List)
		{
			if (GetItemDesc(item.TargetItem.Id) == null)
			{
				int id = item.TargetItem.Id;
				int id2 = item.Id;
				AddValidateLog($"ItemRecipeDesc表 错误id:{id2} Id:{id} 未在ItemDesc里找到对应值", toBlame);
			}
			for (int i = 0; i < item.MaterialList.Count; i++)
			{
				if (GetItemDesc(item.MaterialList[i].Id) == null)
				{
					int id3 = item.MaterialList[i].Id;
					int id4 = item.Id;
					AddValidateLog($"ItemRecipeDesc表 错误id:{id4} MaterialList[{i}] Id:{id3} 未在ItemDesc里找到对应值", toBlame);
				}
			}
		}
	}

	public static TBCardDesc GetTBCardDesc()
	{
		return GSProtobufRuntimeAPI<TBCardDesc, CardDesc>.Get().GetAll();
	}

	public static CardDesc GetCardDesc(int ResId)
	{
		return GSProtobufRuntimeAPI<TBCardDesc, CardDesc>.Get().FindByID(ResId);
	}

	public static bool CheckCardListAutoGen(bool LastCheckValue, IEnumerable<int> IdList, List<string> ErrMsgs)
	{
		bool flag = true;
		foreach (int Id in IdList)
		{
			if (Id != 0 && GetCardDesc(Id) == null)
			{
				flag = false;
				string item = $"Card Id : {Id} does not exist in CardDesc";
				ErrMsgs.Add(item);
			}
		}
		return LastCheckValue && flag;
	}

	public static TBAchievementDesc GetTBAchievementDesc()
	{
		return GSProtobufRuntimeAPI<TBAchievementDesc, AchievementDesc>.Get().GetAll();
	}

	public static AchievementDesc GetAchievementDesc(int ResId)
	{
		return GSProtobufRuntimeAPI<TBAchievementDesc, AchievementDesc>.Get().FindByID(ResId);
	}

	public static bool CheckAchievementListAutoGen(bool LastCheckValue, IEnumerable<int> IdList, List<string> ErrMsgs)
	{
		bool flag = true;
		foreach (int Id in IdList)
		{
			if (Id != 0 && GetAchievementDesc(Id) == null)
			{
				flag = false;
				string item = $"Achievement Id : {Id} does not exist in AchievementDesc";
				ErrMsgs.Add(item);
			}
		}
		return LastCheckValue && flag;
	}

	public static TBAlchemyOutputDesc GetTBAlchemyOutputDesc()
	{
		return GSProtobufRuntimeAPI<TBAlchemyOutputDesc, AlchemyOutputDesc>.Get().GetAll();
	}

	public static AlchemyOutputDesc GetAlchemyOutputDesc(int ResId)
	{
		return GSProtobufRuntimeAPI<TBAlchemyOutputDesc, AlchemyOutputDesc>.Get().FindByID(ResId);
	}

	public static bool CheckAlchemyOutputListAutoGen(bool LastCheckValue, IEnumerable<int> IdList, List<string> ErrMsgs)
	{
		bool flag = true;
		foreach (int Id in IdList)
		{
			if (Id != 0 && GetAlchemyOutputDesc(Id) == null)
			{
				flag = false;
				string item = $"AlchemyOutput Id : {Id} does not exist in AlchemyOutputDesc";
				ErrMsgs.Add(item);
			}
		}
		return LastCheckValue && flag;
	}

	public static TBMeditationPointDesc GetTBMeditationPointDesc()
	{
		return GSProtobufRuntimeAPI<TBMeditationPointDesc, MeditationPointDesc>.Get().GetAll();
	}

	public static MeditationPointDesc GetMeditationPointDesc(int ResId)
	{
		return GSProtobufRuntimeAPI<TBMeditationPointDesc, MeditationPointDesc>.Get().FindByID(ResId);
	}

	public static bool CheckMeditationPointListAutoGen(bool LastCheckValue, IEnumerable<int> IdList, List<string> ErrMsgs)
	{
		bool flag = true;
		foreach (int Id in IdList)
		{
			if (Id != 0 && GetMeditationPointDesc(Id) == null)
			{
				flag = false;
				string item = $"MeditationPoint Id : {Id} does not exist in MeditationPointDesc";
				ErrMsgs.Add(item);
			}
		}
		return LastCheckValue && flag;
	}

	public static void CheckMeditationPointDescAutoGen()
	{
		string toBlame = "";
		foreach (MeditationPointDesc item in GetTBMeditationPointDesc().List)
		{
			for (int i = 0; i < item.AwardList.Count; i++)
			{
				if (GetItemDesc(item.AwardList[i].Id) == null)
				{
					int id = item.AwardList[i].Id;
					int id2 = item.Id;
					AddValidateLog($"MeditationPointDesc表 错误id:{id2} AwardList[{i}] Id:{id} 未在ItemDesc里找到对应值", toBlame);
				}
			}
		}
	}

	public static TBBloodHudDesc GetTBBloodHudDesc()
	{
		return GSProtobufRuntimeAPI<TBBloodHudDesc, BloodHudDesc>.Get().GetAll();
	}

	public static BloodHudDesc GetBloodHudDesc(int ResId)
	{
		return GSProtobufRuntimeAPI<TBBloodHudDesc, BloodHudDesc>.Get().FindByID(ResId);
	}

	public static bool CheckBloodHudListAutoGen(bool LastCheckValue, IEnumerable<int> IdList, List<string> ErrMsgs)
	{
		bool flag = true;
		foreach (int Id in IdList)
		{
			if (Id != 0 && GetBloodHudDesc(Id) == null)
			{
				flag = false;
				string item = $"BloodHud Id : {Id} does not exist in BloodHudDesc";
				ErrMsgs.Add(item);
			}
		}
		return LastCheckValue && flag;
	}

	public static TBLoadingTipsDesc GetTBLoadingTipsDesc()
	{
		return GSProtobufRuntimeAPI<TBLoadingTipsDesc, LoadingTipsDesc>.Get().GetAll();
	}

	public static LoadingTipsDesc GetLoadingTipsDesc(int ResId)
	{
		return GSProtobufRuntimeAPI<TBLoadingTipsDesc, LoadingTipsDesc>.Get().FindByID(ResId);
	}

	public static bool CheckLoadingTipsListAutoGen(bool LastCheckValue, IEnumerable<int> IdList, List<string> ErrMsgs)
	{
		bool flag = true;
		foreach (int Id in IdList)
		{
			if (Id != 0 && GetLoadingTipsDesc(Id) == null)
			{
				flag = false;
				string item = $"LoadingTips Id : {Id} does not exist in LoadingTipsDesc";
				ErrMsgs.Add(item);
			}
		}
		return LastCheckValue && flag;
	}

	public static TBLoadingTipsWeightDesc GetTBLoadingTipsWeightDesc()
	{
		return GSProtobufRuntimeAPI<TBLoadingTipsWeightDesc, LoadingTipsWeightDesc>.Get().GetAll();
	}

	public static TBMovieAndSubtitleDesc GetTBMovieAndSubtitleDesc()
	{
		return GSProtobufRuntimeAPI<TBMovieAndSubtitleDesc, MovieAndSubtitleDesc>.Get().GetAll();
	}

	public static MovieAndSubtitleDesc GetMovieAndSubtitleDesc(int ResId)
	{
		return GSProtobufRuntimeAPI<TBMovieAndSubtitleDesc, MovieAndSubtitleDesc>.Get().FindByID(ResId);
	}

	public static bool CheckMovieAndSubtitleListAutoGen(bool LastCheckValue, IEnumerable<int> IdList, List<string> ErrMsgs)
	{
		bool flag = true;
		foreach (int Id in IdList)
		{
			if (Id != 0 && GetMovieAndSubtitleDesc(Id) == null)
			{
				flag = false;
				string item = $"MovieAndSubtitle Id : {Id} does not exist in MovieAndSubtitleDesc";
				ErrMsgs.Add(item);
			}
		}
		return LastCheckValue && flag;
	}

	public static TBInteractionFuncDesc GetTBInteractionFuncDesc()
	{
		return GSProtobufRuntimeAPI<TBInteractionFuncDesc, InteractionFuncDesc>.Get().GetAll();
	}

	public static InteractionFuncDesc GetInteractionFuncDesc(int ResId)
	{
		return GSProtobufRuntimeAPI<TBInteractionFuncDesc, InteractionFuncDesc>.Get().FindByID(ResId);
	}

	public static bool CheckInteractionFuncListAutoGen(bool LastCheckValue, IEnumerable<int> IdList, List<string> ErrMsgs)
	{
		bool flag = true;
		foreach (int Id in IdList)
		{
			if (Id != 0 && GetInteractionFuncDesc(Id) == null)
			{
				flag = false;
				string item = $"InteractionFunc Id : {Id} does not exist in InteractionFuncDesc";
				ErrMsgs.Add(item);
			}
		}
		return LastCheckValue && flag;
	}

	public static TBTransInputUITipsDesc GetTBTransInputUITipsDesc()
	{
		return GSProtobufRuntimeAPI<TBTransInputUITipsDesc, TransInputUITipsDesc>.Get().GetAll();
	}

	public static TransInputUITipsDesc GetTransInputUITipsDesc(int ResId)
	{
		return GSProtobufRuntimeAPI<TBTransInputUITipsDesc, TransInputUITipsDesc>.Get().FindByID(ResId);
	}

	public static bool CheckTransInputUITipsListAutoGen(bool LastCheckValue, IEnumerable<int> IdList, List<string> ErrMsgs)
	{
		bool flag = true;
		foreach (int Id in IdList)
		{
			if (Id != 0 && GetTransInputUITipsDesc(Id) == null)
			{
				flag = false;
				string item = $"TransInputUITips Id : {Id} does not exist in TransInputUITipsDesc";
				ErrMsgs.Add(item);
			}
		}
		return LastCheckValue && flag;
	}

	public static TBUISettingConfigDesc GetTBUISettingConfigDesc()
	{
		return GSProtobufRuntimeAPI<TBUISettingConfigDesc, UISettingConfigDesc>.Get().GetAll();
	}

	public static UISettingConfigDesc GetUISettingConfigDesc(int ResId)
	{
		return GSProtobufRuntimeAPI<TBUISettingConfigDesc, UISettingConfigDesc>.Get().FindByID(ResId);
	}

	public static bool CheckUISettingConfigListAutoGen(bool LastCheckValue, IEnumerable<int> IdList, List<string> ErrMsgs)
	{
		bool flag = true;
		foreach (int Id in IdList)
		{
			if (Id != 0 && GetUISettingConfigDesc(Id) == null)
			{
				flag = false;
				string item = $"UISettingConfig Id : {Id} does not exist in UISettingConfigDesc";
				ErrMsgs.Add(item);
			}
		}
		return LastCheckValue && flag;
	}

	public static TBBossReChallengeDesc GetTBBossReChallengeDesc()
	{
		return GSProtobufRuntimeAPI<TBBossReChallengeDesc, BossReChallengeDesc>.Get().GetAll();
	}

	public static BossReChallengeDesc GetBossReChallengeDesc(int ResId)
	{
		return GSProtobufRuntimeAPI<TBBossReChallengeDesc, BossReChallengeDesc>.Get().FindByID(ResId);
	}

	public static bool CheckBossReChallengeListAutoGen(bool LastCheckValue, IEnumerable<int> IdList, List<string> ErrMsgs)
	{
		bool flag = true;
		foreach (int Id in IdList)
		{
			if (Id != 0 && GetBossReChallengeDesc(Id) == null)
			{
				flag = false;
				string item = $"BossReChallenge Id : {Id} does not exist in BossReChallengeDesc";
				ErrMsgs.Add(item);
			}
		}
		return LastCheckValue && flag;
	}

	public static void CheckBossReChallengeDescAutoGen()
	{
		string toBlame = "";
		foreach (BossReChallengeDesc item in GetTBBossReChallengeDesc().List)
		{
			if (GetFUStBossRushConfigDesc(item.ConfigId) == null)
			{
				int configId = item.ConfigId;
				int id = item.Id;
				AddValidateLog($"BossReChallengeDesc表 错误id:{id} ConfigId:{configId} 未在FUStBossRushConfigDesc里找到对应值", toBlame);
			}
			if (GetLevelDesc(item.MapGroupId) == null)
			{
				int mapGroupId = item.MapGroupId;
				int id2 = item.Id;
				AddValidateLog($"BossReChallengeDesc表 错误id:{id2} MapGroupId:{mapGroupId} 未在LevelDesc里找到对应值", toBlame);
			}
		}
	}

	public static TBBossIterationsDesc GetTBBossIterationsDesc()
	{
		return GSProtobufRuntimeAPI<TBBossIterationsDesc, BossIterationsDesc>.Get().GetAll();
	}

	public static BossIterationsDesc GetBossIterationsDesc(int ResId)
	{
		return GSProtobufRuntimeAPI<TBBossIterationsDesc, BossIterationsDesc>.Get().FindByID(ResId);
	}

	public static bool CheckBossIterationsListAutoGen(bool LastCheckValue, IEnumerable<int> IdList, List<string> ErrMsgs)
	{
		bool flag = true;
		foreach (int Id in IdList)
		{
			if (Id != 0 && GetBossIterationsDesc(Id) == null)
			{
				flag = false;
				string item = $"BossIterations Id : {Id} does not exist in BossIterationsDesc";
				ErrMsgs.Add(item);
			}
		}
		return LastCheckValue && flag;
	}

	public static void CheckBossIterationsDescAutoGen()
	{
		string toBlame = "";
		foreach (BossIterationsDesc item in GetTBBossIterationsDesc().List)
		{
			for (int i = 0; i < item.BossSuccessiveInfo.Count; i++)
			{
				if (GetFUStBossRushConfigDesc(item.BossSuccessiveInfo[i]) == null)
				{
					int num = item.BossSuccessiveInfo[i];
					int id = item.Id;
					AddValidateLog($"BossIterationsDesc表 错误id:{id} BossSuccessiveInfo[{i}] {num} 未在FUStBossRushConfigDesc里找到对应值", toBlame);
				}
			}
			for (int j = 0; j < item.IterationsAward.Count; j++)
			{
				if (GetItemDesc(item.IterationsAward[j].Id) == null)
				{
					int id2 = item.IterationsAward[j].Id;
					int id3 = item.Id;
					AddValidateLog($"BossIterationsDesc表 错误id:{id3} IterationsAward[{j}] Id:{id2} 未在ItemDesc里找到对应值", toBlame);
				}
			}
		}
	}

	public static TBBossRushDebuffDesc GetTBBossRushDebuffDesc()
	{
		return GSProtobufRuntimeAPI<TBBossRushDebuffDesc, BossRushDebuffDesc>.Get().GetAll();
	}

	public static BossRushDebuffDesc GetBossRushDebuffDesc(int ResId)
	{
		return GSProtobufRuntimeAPI<TBBossRushDebuffDesc, BossRushDebuffDesc>.Get().FindByID(ResId);
	}

	public static bool CheckBossRushDebuffListAutoGen(bool LastCheckValue, IEnumerable<int> IdList, List<string> ErrMsgs)
	{
		bool flag = true;
		foreach (int Id in IdList)
		{
			if (Id != 0 && GetBossRushDebuffDesc(Id) == null)
			{
				flag = false;
				string item = $"BossRushDebuff Id : {Id} does not exist in BossRushDebuffDesc";
				ErrMsgs.Add(item);
			}
		}
		return LastCheckValue && flag;
	}

	public static TBRebirthPointPosDesc GetTBRebirthPointPosDesc()
	{
		return GSProtobufRuntimeAPI<TBRebirthPointPosDesc, RebirthPointPosDesc>.Get().GetAll();
	}

	public static RebirthPointPosDesc GetRebirthPointPosDesc(int ResId)
	{
		return GSProtobufRuntimeAPI<TBRebirthPointPosDesc, RebirthPointPosDesc>.Get().FindByID(ResId);
	}

	public static bool CheckRebirthPointPosListAutoGen(bool LastCheckValue, IEnumerable<int> IdList, List<string> ErrMsgs)
	{
		bool flag = true;
		foreach (int Id in IdList)
		{
			if (Id != 0 && GetRebirthPointPosDesc(Id) == null)
			{
				flag = false;
				string item = $"RebirthPointPos Id : {Id} does not exist in RebirthPointPosDesc";
				ErrMsgs.Add(item);
			}
		}
		return LastCheckValue && flag;
	}

	public static TBUISettingDeviceConfigDesc GetTBUISettingDeviceConfigDesc()
	{
		return GSProtobufRuntimeAPI<TBUISettingDeviceConfigDesc, UISettingDeviceConfigDesc>.Get().GetAll();
	}

	public static UISettingDeviceConfigDesc GetUISettingDeviceConfigDesc(int ResId)
	{
		return GSProtobufRuntimeAPI<TBUISettingDeviceConfigDesc, UISettingDeviceConfigDesc>.Get().FindByID(ResId);
	}

	public static bool CheckUISettingDeviceConfigListAutoGen(bool LastCheckValue, IEnumerable<int> IdList, List<string> ErrMsgs)
	{
		bool flag = true;
		foreach (int Id in IdList)
		{
			if (Id != 0 && GetUISettingDeviceConfigDesc(Id) == null)
			{
				flag = false;
				string item = $"UISettingDeviceConfig Id : {Id} does not exist in UISettingDeviceConfigDesc";
				ErrMsgs.Add(item);
			}
		}
		return LastCheckValue && flag;
	}

	public static TBSurpriseDesc GetTBSurpriseDesc()
	{
		return GSProtobufRuntimeAPI<TBSurpriseDesc, SurpriseDesc>.Get().GetAll();
	}

	public static SurpriseDesc GetSurpriseDesc(int ResId)
	{
		return GSProtobufRuntimeAPI<TBSurpriseDesc, SurpriseDesc>.Get().FindByID(ResId);
	}

	public static bool CheckSurpriseListAutoGen(bool LastCheckValue, IEnumerable<int> IdList, List<string> ErrMsgs)
	{
		bool flag = true;
		foreach (int Id in IdList)
		{
			if (Id != 0 && GetSurpriseDesc(Id) == null)
			{
				flag = false;
				string item = $"Surprise Id : {Id} does not exist in SurpriseDesc";
				ErrMsgs.Add(item);
			}
		}
		return LastCheckValue && flag;
	}

	public static void CheckSurpriseDescAutoGen()
	{
		string toBlame = "";
		foreach (SurpriseDesc item in GetTBSurpriseDesc().List)
		{
			if (GetChapterDesc(item.ChapterId) == null)
			{
				int chapterId = item.ChapterId;
				int id = item.Id;
				AddValidateLog($"SurpriseDesc表 错误id:{id} ChapterId:{chapterId} 未在ChapterDesc里找到对应值", toBlame);
			}
		}
	}

	public static TBChapterDesc GetTBChapterDesc()
	{
		return GSProtobufRuntimeAPI<TBChapterDesc, ChapterDesc>.Get().GetAll();
	}

	public static ChapterDesc GetChapterDesc(int ResId)
	{
		return GSProtobufRuntimeAPI<TBChapterDesc, ChapterDesc>.Get().FindByID(ResId);
	}

	public static bool CheckChapterListAutoGen(bool LastCheckValue, IEnumerable<int> IdList, List<string> ErrMsgs)
	{
		bool flag = true;
		foreach (int Id in IdList)
		{
			if (Id != 0 && GetChapterDesc(Id) == null)
			{
				flag = false;
				string item = $"Chapter Id : {Id} does not exist in ChapterDesc";
				ErrMsgs.Add(item);
			}
		}
		return LastCheckValue && flag;
	}

	public static void CheckChapterDescAutoGen()
	{
		string toBlame = "";
		foreach (ChapterDesc item in GetTBChapterDesc().List)
		{
			if (GetChapterDesc(item.NextChapterId) == null)
			{
				int nextChapterId = item.NextChapterId;
				int id = item.Id;
				AddValidateLog($"ChapterDesc表 错误id:{id} NextChapterId:{nextChapterId} 未在ChapterDesc里找到对应值", toBlame);
			}
			if (GetLevelDesc(item.LevelId) == null)
			{
				int levelId = item.LevelId;
				int id2 = item.Id;
				AddValidateLog($"ChapterDesc表 错误id:{id2} LevelId:{levelId} 未在LevelDesc里找到对应值", toBlame);
			}
		}
	}

	public static TBHistoricDesc GetTBHistoricDesc()
	{
		return GSProtobufRuntimeAPI<TBHistoricDesc, HistoricDesc>.Get().GetAll();
	}

	public static HistoricDesc GetHistoricDesc(int ResId)
	{
		return GSProtobufRuntimeAPI<TBHistoricDesc, HistoricDesc>.Get().FindByID(ResId);
	}

	public static bool CheckHistoricListAutoGen(bool LastCheckValue, IEnumerable<int> IdList, List<string> ErrMsgs)
	{
		bool flag = true;
		foreach (int Id in IdList)
		{
			if (Id != 0 && GetHistoricDesc(Id) == null)
			{
				flag = false;
				string item = $"Historic Id : {Id} does not exist in HistoricDesc";
				ErrMsgs.Add(item);
			}
		}
		return LastCheckValue && flag;
	}

	public static void CheckHistoricDescAutoGen()
	{
		string toBlame = "";
		foreach (HistoricDesc item in GetTBHistoricDesc().List)
		{
			if (GetItemDesc(item.Id) == null)
			{
				int id = item.Id;
				int id2 = item.Id;
				AddValidateLog($"HistoricDesc表 错误id:{id2} Id:{id} 未在ItemDesc里找到对应值", toBlame);
			}
		}
	}

	public static TBPastMemoryDesc GetTBPastMemoryDesc()
	{
		return GSProtobufRuntimeAPI<TBPastMemoryDesc, PastMemoryDesc>.Get().GetAll();
	}

	public static PastMemoryDesc GetPastMemoryDesc(int ResId)
	{
		return GSProtobufRuntimeAPI<TBPastMemoryDesc, PastMemoryDesc>.Get().FindByID(ResId);
	}

	public static bool CheckPastMemoryListAutoGen(bool LastCheckValue, IEnumerable<int> IdList, List<string> ErrMsgs)
	{
		bool flag = true;
		foreach (int Id in IdList)
		{
			if (Id != 0 && GetPastMemoryDesc(Id) == null)
			{
				flag = false;
				string item = $"PastMemory Id : {Id} does not exist in PastMemoryDesc";
				ErrMsgs.Add(item);
			}
		}
		return LastCheckValue && flag;
	}

	public static void CheckPastMemoryDescAutoGen()
	{
		string toBlame = "";
		foreach (PastMemoryDesc item in GetTBPastMemoryDesc().List)
		{
			for (int i = 0; i < item.NPCInfoList.Count; i++)
			{
				if (GetCardDesc(item.NPCInfoList[i].CardId) == null)
				{
					int cardId = item.NPCInfoList[i].CardId;
					int id = item.Id;
					AddValidateLog($"PastMemoryDesc表 错误id:{id} NPCInfoList[{i}] CardId:{cardId} 未在CardDesc里找到对应值", toBlame);
				}
			}
		}
	}

	public static TBArtBookDesc GetTBArtBookDesc()
	{
		return GSProtobufRuntimeAPI<TBArtBookDesc, ArtBookDesc>.Get().GetAll();
	}

	public static ArtBookDesc GetArtBookDesc(int ResId)
	{
		return GSProtobufRuntimeAPI<TBArtBookDesc, ArtBookDesc>.Get().FindByID(ResId);
	}

	public static bool CheckArtBookListAutoGen(bool LastCheckValue, IEnumerable<int> IdList, List<string> ErrMsgs)
	{
		bool flag = true;
		foreach (int Id in IdList)
		{
			if (Id != 0 && GetArtBookDesc(Id) == null)
			{
				flag = false;
				string item = $"ArtBook Id : {Id} does not exist in ArtBookDesc";
				ErrMsgs.Add(item);
			}
		}
		return LastCheckValue && flag;
	}

	public static void CheckArtBookDescAutoGen()
	{
		string toBlame = "";
		foreach (ArtBookDesc item in GetTBArtBookDesc().List)
		{
			if (GetLevelDesc(item.LevelId) == null)
			{
				int levelId = item.LevelId;
				int id = item.Id;
				AddValidateLog($"ArtBookDesc表 错误id:{id} LevelId:{levelId} 未在LevelDesc里找到对应值", toBlame);
			}
			if (GetChapterDesc(item.ChapterId) == null)
			{
				int chapterId = item.ChapterId;
				int id2 = item.Id;
				AddValidateLog($"ArtBookDesc表 错误id:{id2} ChapterId:{chapterId} 未在ChapterDesc里找到对应值", toBlame);
			}
		}
	}

	public static TBSoundTrackDesc GetTBSoundTrackDesc()
	{
		return GSProtobufRuntimeAPI<TBSoundTrackDesc, SoundTrackDesc>.Get().GetAll();
	}

	public static SoundTrackDesc GetSoundTrackDesc(int ResId)
	{
		return GSProtobufRuntimeAPI<TBSoundTrackDesc, SoundTrackDesc>.Get().FindByID(ResId);
	}

	public static bool CheckSoundTrackListAutoGen(bool LastCheckValue, IEnumerable<int> IdList, List<string> ErrMsgs)
	{
		bool flag = true;
		foreach (int Id in IdList)
		{
			if (Id != 0 && GetSoundTrackDesc(Id) == null)
			{
				flag = false;
				string item = $"SoundTrack Id : {Id} does not exist in SoundTrackDesc";
				ErrMsgs.Add(item);
			}
		}
		return LastCheckValue && flag;
	}

	public static TBMuseumMVDesc GetTBMuseumMVDesc()
	{
		return GSProtobufRuntimeAPI<TBMuseumMVDesc, MuseumMVDesc>.Get().GetAll();
	}

	public static MuseumMVDesc GetMuseumMVDesc(int ResId)
	{
		return GSProtobufRuntimeAPI<TBMuseumMVDesc, MuseumMVDesc>.Get().FindByID(ResId);
	}

	public static bool CheckMuseumMVListAutoGen(bool LastCheckValue, IEnumerable<int> IdList, List<string> ErrMsgs)
	{
		bool flag = true;
		foreach (int Id in IdList)
		{
			if (Id != 0 && GetMuseumMVDesc(Id) == null)
			{
				flag = false;
				string item = $"MuseumMV Id : {Id} does not exist in MuseumMVDesc";
				ErrMsgs.Add(item);
			}
		}
		return LastCheckValue && flag;
	}

	public static void CheckMuseumMVDescAutoGen()
	{
		string toBlame = "";
		foreach (MuseumMVDesc item in GetTBMuseumMVDesc().List)
		{
			if (GetChapterDesc(item.ChapterId) == null)
			{
				int chapterId = item.ChapterId;
				int id = item.Id;
				AddValidateLog($"MuseumMVDesc表 错误id:{id} ChapterId:{chapterId} 未在ChapterDesc里找到对应值", toBlame);
			}
		}
	}

	public static TBArmorEnhanceDesc GetTBArmorEnhanceDesc()
	{
		return GSProtobufRuntimeAPI<TBArmorEnhanceDesc, ArmorEnhanceDesc>.Get().GetAll();
	}

	public static ArmorEnhanceDesc GetArmorEnhanceDesc(int ResId)
	{
		return GSProtobufRuntimeAPI<TBArmorEnhanceDesc, ArmorEnhanceDesc>.Get().FindByID(ResId);
	}

	public static bool CheckArmorEnhanceListAutoGen(bool LastCheckValue, IEnumerable<int> IdList, List<string> ErrMsgs)
	{
		bool flag = true;
		foreach (int Id in IdList)
		{
			if (Id != 0 && GetArmorEnhanceDesc(Id) == null)
			{
				flag = false;
				string item = $"ArmorEnhance Id : {Id} does not exist in ArmorEnhanceDesc";
				ErrMsgs.Add(item);
			}
		}
		return LastCheckValue && flag;
	}

	public static TBArmorEnhanceConsumeDesc GetTBArmorEnhanceConsumeDesc()
	{
		return GSProtobufRuntimeAPI<TBArmorEnhanceConsumeDesc, ArmorEnhanceConsumeDesc>.Get().GetAll();
	}

	public static void CheckArmorEnhanceConsumeDescAutoGen()
	{
		string toBlame = "";
		foreach (ArmorEnhanceConsumeDesc item in GetTBArmorEnhanceConsumeDesc().List)
		{
			for (int i = 0; i < item.ItemList.Count; i++)
			{
				if (GetItemDesc(item.ItemList[i].Id) == null)
				{
					int id = item.ItemList[i].Id;
					ItemQuality targetQuality = item.TargetQuality;
					AddValidateLog($"ArmorEnhanceConsumeDesc表 错误id:{targetQuality} ItemList[{i}] Id:{id} 未在ItemDesc里找到对应值", toBlame);
				}
			}
		}
	}

	public static TBMantraDesc GetTBMantraDesc()
	{
		return GSProtobufRuntimeAPI<TBMantraDesc, MantraDesc>.Get().GetAll();
	}

	public static MantraDesc GetMantraDesc(int ResId)
	{
		return GSProtobufRuntimeAPI<TBMantraDesc, MantraDesc>.Get().FindByID(ResId);
	}

	public static bool CheckMantraListAutoGen(bool LastCheckValue, IEnumerable<int> IdList, List<string> ErrMsgs)
	{
		bool flag = true;
		foreach (int Id in IdList)
		{
			if (Id != 0 && GetMantraDesc(Id) == null)
			{
				flag = false;
				string item = $"Mantra Id : {Id} does not exist in MantraDesc";
				ErrMsgs.Add(item);
			}
		}
		return LastCheckValue && flag;
	}

	public static TBMantraWeightDesc GetTBMantraWeightDesc()
	{
		return GSProtobufRuntimeAPI<TBMantraWeightDesc, MantraWeightDesc>.Get().GetAll();
	}

	public static MantraWeightDesc GetMantraWeightDesc(int ResId)
	{
		return GSProtobufRuntimeAPI<TBMantraWeightDesc, MantraWeightDesc>.Get().FindByID(ResId);
	}

	public static bool CheckMantraWeightListAutoGen(bool LastCheckValue, IEnumerable<int> IdList, List<string> ErrMsgs)
	{
		bool flag = true;
		foreach (int Id in IdList)
		{
			if (Id != 0 && GetMantraWeightDesc(Id) == null)
			{
				flag = false;
				string item = $"MantraWeight Id : {Id} does not exist in MantraWeightDesc";
				ErrMsgs.Add(item);
			}
		}
		return LastCheckValue && flag;
	}

	public static TBEquipSeriesDesc GetTBEquipSeriesDesc()
	{
		return GSProtobufRuntimeAPI<TBEquipSeriesDesc, EquipSeriesDesc>.Get().GetAll();
	}

	public static EquipSeriesDesc GetEquipSeriesDesc(int ResId)
	{
		return GSProtobufRuntimeAPI<TBEquipSeriesDesc, EquipSeriesDesc>.Get().FindByID(ResId);
	}

	public static bool CheckEquipSeriesListAutoGen(bool LastCheckValue, IEnumerable<int> IdList, List<string> ErrMsgs)
	{
		bool flag = true;
		foreach (int Id in IdList)
		{
			if (Id != 0 && GetEquipSeriesDesc(Id) == null)
			{
				flag = false;
				string item = $"EquipSeries Id : {Id} does not exist in EquipSeriesDesc";
				ErrMsgs.Add(item);
			}
		}
		return LastCheckValue && flag;
	}

	public static void CheckEquipSeriesDescAutoGen()
	{
		string toBlame = "";
		foreach (EquipSeriesDesc item in GetTBEquipSeriesDesc().List)
		{
			for (int i = 0; i < item.EquipIdList.Count; i++)
			{
				if (GetItemDesc(item.EquipIdList[i]) == null)
				{
					int num = item.EquipIdList[i];
					int id = item.Id;
					AddValidateLog($"EquipSeriesDesc表 错误id:{id} EquipIdList[{i}] {num} 未在ItemDesc里找到对应值", toBlame);
				}
			}
		}
	}

	public static TBLockMantraDesc GetTBLockMantraDesc()
	{
		return GSProtobufRuntimeAPI<TBLockMantraDesc, LockMantraDesc>.Get().GetAll();
	}

	public static LockMantraDesc GetLockMantraDesc(int ResId)
	{
		return GSProtobufRuntimeAPI<TBLockMantraDesc, LockMantraDesc>.Get().FindByID(ResId);
	}

	public static bool CheckLockMantraListAutoGen(bool LastCheckValue, IEnumerable<int> IdList, List<string> ErrMsgs)
	{
		bool flag = true;
		foreach (int Id in IdList)
		{
			if (Id != 0 && GetLockMantraDesc(Id) == null)
			{
				flag = false;
				string item = $"LockMantra Id : {Id} does not exist in LockMantraDesc";
				ErrMsgs.Add(item);
			}
		}
		return LastCheckValue && flag;
	}

	public static void CheckLockMantraDescAutoGen()
	{
		string toBlame = "";
		foreach (LockMantraDesc item in GetTBLockMantraDesc().List)
		{
			for (int i = 0; i < item.CostItemList.Count; i++)
			{
				if (GetItemDesc(item.CostItemList[i].Id) == null)
				{
					int id = item.CostItemList[i].Id;
					int id2 = item.Id;
					AddValidateLog($"LockMantraDesc表 错误id:{id2} CostItemList[{i}] Id:{id} 未在ItemDesc里找到对应值", toBlame);
				}
			}
		}
	}

	public static TBMantraBuildupDesc GetTBMantraBuildupDesc()
	{
		return GSProtobufRuntimeAPI<TBMantraBuildupDesc, MantraBuildupDesc>.Get().GetAll();
	}

	public static MantraBuildupDesc GetMantraBuildupDesc(int ResId)
	{
		return GSProtobufRuntimeAPI<TBMantraBuildupDesc, MantraBuildupDesc>.Get().FindByID(ResId);
	}

	public static bool CheckMantraBuildupListAutoGen(bool LastCheckValue, IEnumerable<int> IdList, List<string> ErrMsgs)
	{
		bool flag = true;
		foreach (int Id in IdList)
		{
			if (Id != 0 && GetMantraBuildupDesc(Id) == null)
			{
				flag = false;
				string item = $"MantraBuildup Id : {Id} does not exist in MantraBuildupDesc";
				ErrMsgs.Add(item);
			}
		}
		return LastCheckValue && flag;
	}

	public static void CheckMantraBuildupDescAutoGen()
	{
		string toBlame = "";
		foreach (MantraBuildupDesc item in GetTBMantraBuildupDesc().List)
		{
			if (GetEquipSeriesDesc(item.Id) == null)
			{
				int id = item.Id;
				int id2 = item.Id;
				AddValidateLog($"MantraBuildupDesc表 错误id:{id2} Id:{id} 未在EquipSeriesDesc里找到对应值", toBlame);
			}
		}
	}

	public static TBMapFragmentDesc GetTBMapFragmentDesc()
	{
		return GSProtobufRuntimeAPI<TBMapFragmentDesc, MapFragmentDesc>.Get().GetAll();
	}

	public static MapFragmentDesc GetMapFragmentDesc(int ResId)
	{
		return GSProtobufRuntimeAPI<TBMapFragmentDesc, MapFragmentDesc>.Get().FindByID(ResId);
	}

	public static bool CheckMapFragmentListAutoGen(bool LastCheckValue, IEnumerable<int> IdList, List<string> ErrMsgs)
	{
		bool flag = true;
		foreach (int Id in IdList)
		{
			if (Id != 0 && GetMapFragmentDesc(Id) == null)
			{
				flag = false;
				string item = $"MapFragment Id : {Id} does not exist in MapFragmentDesc";
				ErrMsgs.Add(item);
			}
		}
		return LastCheckValue && flag;
	}

	public static void CheckMapFragmentDescAutoGen()
	{
		string toBlame = "";
		foreach (MapFragmentDesc item in GetTBMapFragmentDesc().List)
		{
			if (GetItemDesc(item.Id) == null)
			{
				int id = item.Id;
				int id2 = item.Id;
				AddValidateLog($"MapFragmentDesc表 错误id:{id2} Id:{id} 未在ItemDesc里找到对应值", toBlame);
			}
		}
	}

	public static TBSceneMonsterNameplateDesc GetTBSceneMonsterNameplateDesc()
	{
		return GSProtobufRuntimeAPI<TBSceneMonsterNameplateDesc, SceneMonsterNameplateDesc>.Get().GetAll();
	}

	public static SceneMonsterNameplateDesc GetSceneMonsterNameplateDesc(int ResId)
	{
		return GSProtobufRuntimeAPI<TBSceneMonsterNameplateDesc, SceneMonsterNameplateDesc>.Get().FindByID(ResId);
	}

	public static bool CheckSceneMonsterNameplateListAutoGen(bool LastCheckValue, IEnumerable<int> IdList, List<string> ErrMsgs)
	{
		bool flag = true;
		foreach (int Id in IdList)
		{
			if (Id != 0 && GetSceneMonsterNameplateDesc(Id) == null)
			{
				flag = false;
				string item = $"SceneMonsterNameplate Id : {Id} does not exist in SceneMonsterNameplateDesc";
				ErrMsgs.Add(item);
			}
		}
		return LastCheckValue && flag;
	}

	public static TBSoulSkillDesc GetTBSoulSkillDesc()
	{
		return GSProtobufRuntimeAPI<TBSoulSkillDesc, SoulSkillDesc>.Get().GetAll();
	}

	public static SoulSkillDesc GetSoulSkillDesc(int ResId)
	{
		return GSProtobufRuntimeAPI<TBSoulSkillDesc, SoulSkillDesc>.Get().FindByID(ResId);
	}

	public static bool CheckSoulSkillListAutoGen(bool LastCheckValue, IEnumerable<int> IdList, List<string> ErrMsgs)
	{
		bool flag = true;
		foreach (int Id in IdList)
		{
			if (Id != 0 && GetSoulSkillDesc(Id) == null)
			{
				flag = false;
				string item = $"SoulSkill Id : {Id} does not exist in SoulSkillDesc";
				ErrMsgs.Add(item);
			}
		}
		return LastCheckValue && flag;
	}

	public static void CheckSoulSkillDescAutoGen()
	{
		string toBlame = "";
		foreach (SoulSkillDesc item in GetTBSoulSkillDesc().List)
		{
			if (GetItemDesc(item.Id) == null)
			{
				int id = item.Id;
				int id2 = item.Id;
				AddValidateLog($"SoulSkillDesc表 错误id:{id2} Id:{id} 未在ItemDesc里找到对应值", toBlame);
			}
			for (int i = 0; i < item.CostItem.Count; i++)
			{
				if (GetItemDesc(item.CostItem[i].Id) == null)
				{
					int id3 = item.CostItem[i].Id;
					int id4 = item.Id;
					AddValidateLog($"SoulSkillDesc表 错误id:{id4} CostItem[{i}] Id:{id3} 未在ItemDesc里找到对应值", toBlame);
				}
			}
		}
	}

	public static TBSoulSkillDropDesc GetTBSoulSkillDropDesc()
	{
		return GSProtobufRuntimeAPI<TBSoulSkillDropDesc, SoulSkillDropDesc>.Get().GetAll();
	}

	public static SoulSkillDropDesc GetSoulSkillDropDesc(int ResId)
	{
		return GSProtobufRuntimeAPI<TBSoulSkillDropDesc, SoulSkillDropDesc>.Get().FindByID(ResId);
	}

	public static bool CheckSoulSkillDropListAutoGen(bool LastCheckValue, IEnumerable<int> IdList, List<string> ErrMsgs)
	{
		bool flag = true;
		foreach (int Id in IdList)
		{
			if (Id != 0 && GetSoulSkillDropDesc(Id) == null)
			{
				flag = false;
				string item = $"SoulSkillDrop Id : {Id} does not exist in SoulSkillDropDesc";
				ErrMsgs.Add(item);
			}
		}
		return LastCheckValue && flag;
	}

	public static TBSeedDesc GetTBSeedDesc()
	{
		return GSProtobufRuntimeAPI<TBSeedDesc, SeedDesc>.Get().GetAll();
	}

	public static SeedDesc GetSeedDesc(int ResId)
	{
		return GSProtobufRuntimeAPI<TBSeedDesc, SeedDesc>.Get().FindByID(ResId);
	}

	public static bool CheckSeedListAutoGen(bool LastCheckValue, IEnumerable<int> IdList, List<string> ErrMsgs)
	{
		bool flag = true;
		foreach (int Id in IdList)
		{
			if (Id != 0 && GetSeedDesc(Id) == null)
			{
				flag = false;
				string item = $"Seed Id : {Id} does not exist in SeedDesc";
				ErrMsgs.Add(item);
			}
		}
		return LastCheckValue && flag;
	}

	public static void CheckSeedDescAutoGen()
	{
		string toBlame = "";
		foreach (SeedDesc item in GetTBSeedDesc().List)
		{
			if (GetItemDesc(item.Id) == null)
			{
				int id = item.Id;
				int id2 = item.Id;
				AddValidateLog($"SeedDesc表 错误id:{id2} Id:{id} 未在ItemDesc里找到对应值", toBlame);
			}
			for (int i = 0; i < item.OutputList.Count; i++)
			{
				if (GetItemDesc(item.OutputList[i].OutputItemId) == null)
				{
					int outputItemId = item.OutputList[i].OutputItemId;
					int id3 = item.Id;
					AddValidateLog($"SeedDesc表 错误id:{id3} OutputList[{i}] OutputItemId:{outputItemId} 未在ItemDesc里找到对应值", toBlame);
				}
			}
		}
	}

	public static TBSeedCollectionAwardDesc GetTBSeedCollectionAwardDesc()
	{
		return GSProtobufRuntimeAPI<TBSeedCollectionAwardDesc, SeedCollectionAwardDesc>.Get().GetAll();
	}

	public static void CheckSeedCollectionAwardDescAutoGen()
	{
		string toBlame = "";
		foreach (SeedCollectionAwardDesc item in GetTBSeedCollectionAwardDesc().List)
		{
			if (GetCommDropRuleDesc(item.DropId) == null)
			{
				int dropId = item.DropId;
				int dropId2 = item.DropId;
				AddValidateLog($"SeedCollectionAwardDesc表 错误id:{dropId2} DropId:{dropId} 未在CommDropRuleDesc里找到对应值", toBlame);
			}
		}
	}

	public static TBMedicineAwardDesc GetTBMedicineAwardDesc()
	{
		return GSProtobufRuntimeAPI<TBMedicineAwardDesc, MedicineAwardDesc>.Get().GetAll();
	}

	public static void CheckMedicineAwardDescAutoGen()
	{
		string toBlame = "";
		foreach (MedicineAwardDesc item in GetTBMedicineAwardDesc().List)
		{
			if (GetCommDropRuleDesc(item.DropId) == null)
			{
				int dropId = item.DropId;
				int dropId2 = item.DropId;
				AddValidateLog($"MedicineAwardDesc表 错误id:{dropId2} DropId:{dropId} 未在CommDropRuleDesc里找到对应值", toBlame);
			}
		}
	}

	public static TBGMMonsterTeleportDesc GetTBGMMonsterTeleportDesc()
	{
		return GSProtobufRuntimeAPI<TBGMMonsterTeleportDesc, GMMonsterTeleportDesc>.Get().GetAll();
	}

	public static GMMonsterTeleportDesc GetGMMonsterTeleportDesc(int ResId)
	{
		return GSProtobufRuntimeAPI<TBGMMonsterTeleportDesc, GMMonsterTeleportDesc>.Get().FindByID(ResId);
	}

	public static bool CheckGMMonsterTeleportListAutoGen(bool LastCheckValue, IEnumerable<int> IdList, List<string> ErrMsgs)
	{
		bool flag = true;
		foreach (int Id in IdList)
		{
			if (Id != 0 && GetGMMonsterTeleportDesc(Id) == null)
			{
				flag = false;
				string item = $"GMMonsterTeleport Id : {Id} does not exist in GMMonsterTeleportDesc";
				ErrMsgs.Add(item);
			}
		}
		return LastCheckValue && flag;
	}

	public static TBPS5ActivityDesc GetTBPS5ActivityDesc()
	{
		return GSProtobufRuntimeAPI<TBPS5ActivityDesc, PS5ActivityDesc>.Get().GetAll();
	}

	public static PS5ActivityDesc GetPS5ActivityDesc(int ResId)
	{
		return GSProtobufRuntimeAPI<TBPS5ActivityDesc, PS5ActivityDesc>.Get().FindByID(ResId);
	}

	public static bool CheckPS5ActivityListAutoGen(bool LastCheckValue, IEnumerable<int> IdList, List<string> ErrMsgs)
	{
		bool flag = true;
		foreach (int Id in IdList)
		{
			if (Id != 0 && GetPS5ActivityDesc(Id) == null)
			{
				flag = false;
				string item = $"PS5Activity Id : {Id} does not exist in PS5ActivityDesc";
				ErrMsgs.Add(item);
			}
		}
		return LastCheckValue && flag;
	}

	public static TBPS5ActivityTaskDesc GetTBPS5ActivityTaskDesc()
	{
		return GSProtobufRuntimeAPI<TBPS5ActivityTaskDesc, PS5ActivityTaskDesc>.Get().GetAll();
	}

	public static PS5ActivityTaskDesc GetPS5ActivityTaskDesc(int ResId)
	{
		return GSProtobufRuntimeAPI<TBPS5ActivityTaskDesc, PS5ActivityTaskDesc>.Get().FindByID(ResId);
	}

	public static bool CheckPS5ActivityTaskListAutoGen(bool LastCheckValue, IEnumerable<int> IdList, List<string> ErrMsgs)
	{
		bool flag = true;
		foreach (int Id in IdList)
		{
			if (Id != 0 && GetPS5ActivityTaskDesc(Id) == null)
			{
				flag = false;
				string item = $"PS5ActivityTask Id : {Id} does not exist in PS5ActivityTaskDesc";
				ErrMsgs.Add(item);
			}
		}
		return LastCheckValue && flag;
	}

	public static void CheckPS5ActivityTaskDescAutoGen()
	{
		string toBlame = "";
		foreach (PS5ActivityTaskDesc item in GetTBPS5ActivityTaskDesc().List)
		{
			if (GetPS5ActivityDesc(item.ActivityId) == null)
			{
				int activityId = item.ActivityId;
				int id = item.Id;
				AddValidateLog($"PS5ActivityTaskDesc表 错误id:{id} ActivityId:{activityId} 未在PS5ActivityDesc里找到对应值", toBlame);
			}
		}
	}

	public static TBPlatformAchievementLiteDesc GetTBPlatformAchievementLiteDesc()
	{
		return GSProtobufRuntimeAPI<TBPlatformAchievementLiteDesc, PlatformAchievementLiteDesc>.Get().GetAll();
	}

	public static PlatformAchievementLiteDesc GetPlatformAchievementLiteDesc(int ResId)
	{
		return GSProtobufRuntimeAPI<TBPlatformAchievementLiteDesc, PlatformAchievementLiteDesc>.Get().FindByID(ResId);
	}

	public static bool CheckPlatformAchievementLiteListAutoGen(bool LastCheckValue, IEnumerable<int> IdList, List<string> ErrMsgs)
	{
		bool flag = true;
		foreach (int Id in IdList)
		{
			if (Id != 0 && GetPlatformAchievementLiteDesc(Id) == null)
			{
				flag = false;
				string item = $"PlatformAchievementLite Id : {Id} does not exist in PlatformAchievementLiteDesc";
				ErrMsgs.Add(item);
			}
		}
		return LastCheckValue && flag;
	}

	public static void CheckPlatformAchievementLiteDescAutoGen()
	{
		string toBlame = "";
		foreach (PlatformAchievementLiteDesc item in GetTBPlatformAchievementLiteDesc().List)
		{
			if (GetAchievementDesc(item.Id) == null)
			{
				int id = item.Id;
				int id2 = item.Id;
				AddValidateLog($"PlatformAchievementLiteDesc表 错误id:{id2} Id:{id} 未在AchievementDesc里找到对应值", toBlame);
			}
		}
	}

	public static TBPlatformAchievementDesc GetTBPlatformAchievementDesc()
	{
		return GSProtobufRuntimeAPI<TBPlatformAchievementDesc, PlatformAchievementDesc>.Get().GetAll();
	}

	public static PlatformAchievementDesc GetPlatformAchievementDesc(int ResId)
	{
		return GSProtobufRuntimeAPI<TBPlatformAchievementDesc, PlatformAchievementDesc>.Get().FindByID(ResId);
	}

	public static bool CheckPlatformAchievementListAutoGen(bool LastCheckValue, IEnumerable<int> IdList, List<string> ErrMsgs)
	{
		bool flag = true;
		foreach (int Id in IdList)
		{
			if (Id != 0 && GetPlatformAchievementDesc(Id) == null)
			{
				flag = false;
				string item = $"PlatformAchievement Id : {Id} does not exist in PlatformAchievementDesc";
				ErrMsgs.Add(item);
			}
		}
		return LastCheckValue && flag;
	}

	public static void CheckPlatformAchievementDescAutoGen()
	{
		string toBlame = "";
		foreach (PlatformAchievementDesc item in GetTBPlatformAchievementDesc().List)
		{
			if (GetAchievementDesc(item.Id) == null)
			{
				int id = item.Id;
				int id2 = item.Id;
				AddValidateLog($"PlatformAchievementDesc表 错误id:{id2} Id:{id} 未在AchievementDesc里找到对应值", toBlame);
			}
		}
	}

	public static TBTakePhotoCustomSettingDesc GetTBTakePhotoCustomSettingDesc()
	{
		return GSProtobufRuntimeAPI<TBTakePhotoCustomSettingDesc, TakePhotoCustomSettingDesc>.Get().GetAll();
	}

	public static TakePhotoCustomSettingDesc GetTakePhotoCustomSettingDesc(int ResId)
	{
		return GSProtobufRuntimeAPI<TBTakePhotoCustomSettingDesc, TakePhotoCustomSettingDesc>.Get().FindByID(ResId);
	}

	public static bool CheckTakePhotoCustomSettingListAutoGen(bool LastCheckValue, IEnumerable<int> IdList, List<string> ErrMsgs)
	{
		bool flag = true;
		foreach (int Id in IdList)
		{
			if (Id != 0 && GetTakePhotoCustomSettingDesc(Id) == null)
			{
				flag = false;
				string item = $"TakePhotoCustomSetting Id : {Id} does not exist in TakePhotoCustomSettingDesc";
				ErrMsgs.Add(item);
			}
		}
		return LastCheckValue && flag;
	}

	public static TBCricketBattleUnitDesc GetTBCricketBattleUnitDesc()
	{
		return GSProtobufRuntimeAPI<TBCricketBattleUnitDesc, CricketBattleUnitDesc>.Get().GetAll();
	}

	public static CricketBattleUnitDesc GetCricketBattleUnitDesc(int ResId)
	{
		return GSProtobufRuntimeAPI<TBCricketBattleUnitDesc, CricketBattleUnitDesc>.Get().FindByID(ResId);
	}

	public static bool CheckCricketBattleUnitListAutoGen(bool LastCheckValue, IEnumerable<int> IdList, List<string> ErrMsgs)
	{
		bool flag = true;
		foreach (int Id in IdList)
		{
			if (Id != 0 && GetCricketBattleUnitDesc(Id) == null)
			{
				flag = false;
				string item = $"CricketBattleUnit Id : {Id} does not exist in CricketBattleUnitDesc";
				ErrMsgs.Add(item);
			}
		}
		return LastCheckValue && flag;
	}

	public static TBCricketUnitAttrDesc GetTBCricketUnitAttrDesc()
	{
		return GSProtobufRuntimeAPI<TBCricketUnitAttrDesc, CricketUnitAttrDesc>.Get().GetAll();
	}

	public static TBEchoDesc GetTBEchoDesc()
	{
		return GSProtobufRuntimeAPI<TBEchoDesc, EchoDesc>.Get().GetAll();
	}

	public static EchoDesc GetEchoDesc(int ResId)
	{
		return GSProtobufRuntimeAPI<TBEchoDesc, EchoDesc>.Get().FindByID(ResId);
	}

	public static bool CheckEchoListAutoGen(bool LastCheckValue, IEnumerable<int> IdList, List<string> ErrMsgs)
	{
		bool flag = true;
		foreach (int Id in IdList)
		{
			if (Id != 0 && GetEchoDesc(Id) == null)
			{
				flag = false;
				string item = $"Echo Id : {Id} does not exist in EchoDesc";
				ErrMsgs.Add(item);
			}
		}
		return LastCheckValue && flag;
	}

	public static TBLinkBloodDesc GetTBLinkBloodDesc()
	{
		return GSProtobufRuntimeAPI<TBLinkBloodDesc, LinkBloodDesc>.Get().GetAll();
	}

	public static LinkBloodDesc GetLinkBloodDesc(int ResId)
	{
		return GSProtobufRuntimeAPI<TBLinkBloodDesc, LinkBloodDesc>.Get().FindByID(ResId);
	}

	public static bool CheckLinkBloodListAutoGen(bool LastCheckValue, IEnumerable<int> IdList, List<string> ErrMsgs)
	{
		bool flag = true;
		foreach (int Id in IdList)
		{
			if (Id != 0 && GetLinkBloodDesc(Id) == null)
			{
				flag = false;
				string item = $"LinkBlood Id : {Id} does not exist in LinkBloodDesc";
				ErrMsgs.Add(item);
			}
		}
		return LastCheckValue && flag;
	}

	public static TBNPCInteractConversationDesc GetTBNPCInteractConversationDesc()
	{
		return GSProtobufRuntimeAPI<TBNPCInteractConversationDesc, NPCInteractConversationDesc>.Get().GetAll();
	}

	public static NPCInteractConversationDesc GetNPCInteractConversationDesc(int ResId)
	{
		return GSProtobufRuntimeAPI<TBNPCInteractConversationDesc, NPCInteractConversationDesc>.Get().FindByID(ResId);
	}

	public static bool CheckNPCInteractConversationListAutoGen(bool LastCheckValue, IEnumerable<int> IdList, List<string> ErrMsgs)
	{
		bool flag = true;
		foreach (int Id in IdList)
		{
			if (Id != 0 && GetNPCInteractConversationDesc(Id) == null)
			{
				flag = false;
				string item = $"NPCInteractConversation Id : {Id} does not exist in NPCInteractConversationDesc";
				ErrMsgs.Add(item);
			}
		}
		return LastCheckValue && flag;
	}

	public static TBEditionAwardDesc GetTBEditionAwardDesc()
	{
		return GSProtobufRuntimeAPI<TBEditionAwardDesc, EditionAwardDesc>.Get().GetAll();
	}

	public static EditionAwardDesc GetEditionAwardDesc(int ResId)
	{
		return GSProtobufRuntimeAPI<TBEditionAwardDesc, EditionAwardDesc>.Get().FindByID(ResId);
	}

	public static bool CheckEditionAwardListAutoGen(bool LastCheckValue, IEnumerable<int> IdList, List<string> ErrMsgs)
	{
		bool flag = true;
		foreach (int Id in IdList)
		{
			if (Id != 0 && GetEditionAwardDesc(Id) == null)
			{
				flag = false;
				string item = $"EditionAward Id : {Id} does not exist in EditionAwardDesc";
				ErrMsgs.Add(item);
			}
		}
		return LastCheckValue && flag;
	}

	public static void CheckEditionAwardDescAutoGen()
	{
		string toBlame = "";
		foreach (EditionAwardDesc item in GetTBEditionAwardDesc().List)
		{
			for (int i = 0; i < item.AwardList.Count; i++)
			{
				if (GetItemDesc(item.AwardList[i].Id) == null)
				{
					int id = item.AwardList[i].Id;
					int id2 = item.Id;
					AddValidateLog($"EditionAwardDesc表 错误id:{id2} AwardList[{i}] Id:{id} 未在ItemDesc里找到对应值", toBlame);
				}
			}
		}
	}

	public static TBShrineShowNpcConfigDesc GetTBShrineShowNpcConfigDesc()
	{
		return GSProtobufRuntimeAPI<TBShrineShowNpcConfigDesc, ShrineShowNpcConfigDesc>.Get().GetAll();
	}

	public static TBTeamConfigDesc GetTBTeamConfigDesc()
	{
		return GSProtobufRuntimeAPI<TBTeamConfigDesc, TeamConfigDesc>.Get().GetAll();
	}

	public static TeamConfigDesc GetTeamConfigDesc(int ResId)
	{
		return GSProtobufRuntimeAPI<TBTeamConfigDesc, TeamConfigDesc>.Get().FindByID(ResId);
	}

	public static bool CheckTeamConfigListAutoGen(bool LastCheckValue, IEnumerable<int> IdList, List<string> ErrMsgs)
	{
		bool flag = true;
		foreach (int Id in IdList)
		{
			if (Id != 0 && GetTeamConfigDesc(Id) == null)
			{
				flag = false;
				string item = $"TeamConfig Id : {Id} does not exist in TeamConfigDesc";
				ErrMsgs.Add(item);
			}
		}
		return LastCheckValue && flag;
	}

	public static TBLotteryAwardDesc GetTBLotteryAwardDesc()
	{
		return GSProtobufRuntimeAPI<TBLotteryAwardDesc, LotteryAwardDesc>.Get().GetAll();
	}

	public static LotteryAwardDesc GetLotteryAwardDesc(int ResId)
	{
		return GSProtobufRuntimeAPI<TBLotteryAwardDesc, LotteryAwardDesc>.Get().FindByID(ResId);
	}

	public static bool CheckLotteryAwardListAutoGen(bool LastCheckValue, IEnumerable<int> IdList, List<string> ErrMsgs)
	{
		bool flag = true;
		foreach (int Id in IdList)
		{
			if (Id != 0 && GetLotteryAwardDesc(Id) == null)
			{
				flag = false;
				string item = $"LotteryAward Id : {Id} does not exist in LotteryAwardDesc";
				ErrMsgs.Add(item);
			}
		}
		return LastCheckValue && flag;
	}

	public static void Init(bool _IsPrintToScreen = true)
	{
		BG_ProtobufDataLoader.SetIsPrintToScreen(_IsPrintToScreen);
		LoadRes();
		BuildAllDescToDict();
		TestResLoad();
	}

	private static void BuildAllDescToDict()
	{
		BUildEquipPositionConfDict();
		BUildEquipDict();
		BuildItemDesc();
		BuildShopItemDesc();
		BuildOnlineLevelDict();
		BuildMapAreaConfigDesc();
		BuildNewGamePlusDesc();
		InitTalentSUnitMap();
		InitCommonErrorUITipsDict();
		BuildRoleDataConfigDesc();
		BuildItemRecipeDesc();
		BuildWeaponTree();
		BuildUnitDropRuleDesc();
		BuildTalentSDesc();
		BuildLoadingTipsDesc();
		BuildCommDropRuleDesc();
		BuildUISettingConfigDesc();
		BuildLevelDesc();
		BuildChapterSurpriseDesc();
		BuildFastPastMemoryDesc();
		BuildGetCollectionDropDesc();
		BuildChapterAwardDesc();
		BuildCard();
		BuildLockMantraCostDict();
		BuildSuitId2EquipListDict();
		BuildEquipId2SeriesId();
		BuildSeedCollectinoAwardList();
		BuildWeaponKeyItemToEquipIdDict();
		BuildWeaponIdToRootIdDict();
		BuildAchievementRequiredIdToAchievementIdDict();
		BuildTaskStageId2SurpriseDescDict();
		BuildOrderedMedicineDescList();
		BuildTalentRankDesc();
		BuildCricketBattleUnitDescDict();
		BuildCricketUnitAttrDescDict();
		BuildWineSeriesDict();
		BuildSettingSortDict();
		BuildHuluUpgradeTree();
		BuildSoulSkillUpgradeTree();
		BuildWineUpgradeTree();
		BuildUnitLinkBloodGroup();
		BuildGuideNode2Group();
		BuildSoulSkillDropDesc();
		BuildTransInputUITipsDict();
		BuildArmorEnhanceConsumeDict();
		BuildTaskStageRefreshNpcLocationDict();
		BuildUISettingConfigDescDict();
		BuildUnlockTypeResIdDitc();
		BuildBossRushDict();
	}

	public static void ReBuild820VersionDict()
	{
		BuildCard();
	}

	public static void CheckAllDesc()
	{
		CheckAllResB1DescAutoGen();
		CheckAllBtlB1DescAutoGen();
		CheckAllBtlShareDescAutoGen();
		CheckItemDesc();
		CheckCollectionDropDesc();
		CheckRoleDataInitDesc();
		CheckShopDesc();
		CheckTalentDesc();
		CheckConsumeDesc();
		CheckHuluDesc();
		CheckWineDesc();
		CheckItemRecipeDesc();
		CheckEquipDesc();
		CheckWeaponBuildDesc();
		CheckFastMemoryBuildDesc();
		CheckChapterDesc();
		CheckCardDesc();
		CheckCommDropRuleDesc();
		CheckLockMantraCostDesc();
		CheckMantraWeightDesc();
		CheckArmorEnhanceConsumeDesc();
		CheckEquipSeriesDesc();
		CheckArchiveErrorTips();
		CheckWeaponBuildHidenRule();
		CheckSoulSkillDropDesc();
		CheckSeedDesc();
		CheckUnitExtendDesc();
		CheckSoulSkillDesc();
		CheckAchievementDesc();
		CheckPS5ActivityTaskDesc();
		CheckLogicCommDesc();
		CheckFUStSuitDesc();
		CheckEditionAwardDesc();
		CheckNewGamePlusDesc();
		CheckNpcLocationRefresh();
		CheckBossRushDesc();
	}

	private static void TestResLoad()
	{
	}

	public static void AddValidateLog(string str, string toBlame = "null")
	{
		OnAddValidateLog?.Invoke(str, toBlame);
	}

	public static Dictionary<int, EquipPositionConfDesc> GetAllEquipPositionDesc()
	{
		return EquipPositionConfDict;
	}

	public static EquipPositionConfDesc GetEquipPositionDescByEquipPosition(EquipPosition EquipPosition)
	{
		foreach (KeyValuePair<int, EquipPositionConfDesc> item in EquipPositionConfDict)
		{
			if (item.Value.EquipPosition == EquipPosition)
			{
				return item.Value;
			}
		}
		return null;
	}

	private static void BUildEquipPositionConfDict()
	{
		EquipPositionConfDict.Clear();
		TBEquipPositionConfDesc all = GSProtobufRuntimeAPI<TBEquipPositionConfDesc, EquipPositionConfDesc>.Get().GetAll();
		if (all == null)
		{
			return;
		}
		foreach (EquipPositionConfDesc item in all.List)
		{
			if (!EquipPositionConfDict.TryGetValue(item.Id, out var _))
			{
				EquipPositionConfDict.Add(item.Id, item);
			}
		}
	}

	private static void BuildSuitId2EquipListDict()
	{
		SuitId2EquipListDict.Clear();
		foreach (EquipDesc item in GetTBEquipDesc().List)
		{
			if (SuitId2EquipListDict.TryGetValue(item.SuitId, out var value))
			{
				value.Add(item.Id);
			}
			else if (item.SuitId != 0)
			{
				SuitId2EquipListDict.Add(item.SuitId, new List<int> { item.Id });
			}
		}
	}

	public static List<int> GetWholeSuitEquipIdList(int SuitId)
	{
		if (SuitId2EquipListDict.TryGetValue(SuitId, out var value))
		{
			return value;
		}
		return null;
	}

	public static List<int> GetRedQualityEquipIdListBySuitId(int SuitId)
	{
		List<int> list = new List<int>();
		List<int> wholeSuitEquipIdList = GetWholeSuitEquipIdList(SuitId);
		if (wholeSuitEquipIdList != null)
		{
			foreach (int item in wholeSuitEquipIdList)
			{
				ItemDesc itemDesc = GetItemDesc(item);
				if (itemDesc.Quality == ItemQuality.Red)
				{
					list.Add(itemDesc.Id);
				}
			}
		}
		return list;
	}

	public static EquipPosition GetEquipPosition(int EquipId)
	{
		return GetEquipDesc(EquipId)?.EquipPosition ?? EquipPosition.EnumMax;
	}

	public static Dictionary<int, EquipDesc> GetAllEquipDesc()
	{
		return EquipDict;
	}

	private static void BUildEquipDict()
	{
		EquipDict.Clear();
		TBEquipDesc all = GSProtobufRuntimeAPI<TBEquipDesc, EquipDesc>.Get().GetAll();
		if (all == null)
		{
			return;
		}
		foreach (EquipDesc item in all.List)
		{
			if (!EquipDict.TryGetValue(item.Id, out var _))
			{
				EquipDict.Add(item.Id, item);
			}
		}
	}

	public static bool IsArmor(EquipPosition equipPosition)
	{
		if (equipPosition == EquipPosition.Foot || equipPosition == EquipPosition.Arm || equipPosition == EquipPosition.Upwear || equipPosition == EquipPosition.Head)
		{
			return true;
		}
		return false;
	}

	public static bool IsArmor(int EquipId)
	{
		return IsArmor(GetEquipPosition(EquipId));
	}

	public static int GetEquipSeries(int TargetEquipId)
	{
		EquipPosition equipPosition = GetEquipPosition(TargetEquipId);
		if (IsArmor(equipPosition))
		{
			return GetArmorSeriesId(TargetEquipId);
		}
		return equipPosition switch
		{
			EquipPosition.Weapon => GetWeaponSeriesId(TargetEquipId), 
			EquipPosition.Hulu => GetHuluSeriesId(TargetEquipId), 
			_ => 0, 
		};
	}

	public static bool IsSameSeriesEquip(int EquipIdLeft, int EquipIdRight)
	{
		int equipSeries = GetEquipSeries(EquipIdLeft);
		int equipSeries2 = GetEquipSeries(EquipIdRight);
		if (equipSeries == 0 || equipSeries2 == 0)
		{
			return false;
		}
		return equipSeries == equipSeries2;
	}

	public static void BuildItemDesc()
	{
		ItemType2IdDict.Clear();
		MoneyType2IdDict.Clear();
		ItemImageIdDict.Clear();
		TBItemDesc tBItemDesc = GetTBItemDesc();
		for (int i = 0; i < tBItemDesc.List.Count; i++)
		{
			ItemDesc itemDesc = tBItemDesc.List[i];
			if (itemDesc.ItemType == ItemType.Spirit)
			{
				MoneyType2IdDict[MoneyType.Spirit] = itemDesc.Id;
			}
			ItemType2IdDict[itemDesc.ItemType] = itemDesc.Id;
			if (itemDesc.ImageId == 0)
			{
				ItemImageIdDict[itemDesc.Id] = itemDesc.Id;
			}
			else
			{
				ItemImageIdDict[itemDesc.Id] = itemDesc.ImageId;
			}
		}
	}

	public static void CheckItemDesc()
	{
		TBItemDesc tBItemDesc = GetTBItemDesc();
		string itemToBlame = GetItemToBlame();
		for (int i = 0; i < tBItemDesc.List.Count; i++)
		{
			ItemDesc itemDesc = tBItemDesc.List[i];
			switch (itemDesc.ItemType)
			{
			case ItemType.Consume:
				if (GetConsumeDesc(itemDesc.Id) == null)
				{
					AddValidateLog(string.Format($"ItemDesc ID:{itemDesc.Id} 未在ConsumeDesc表格找到对应ID数据"), itemToBlame);
				}
				break;
			case ItemType.Equip:
				if (GetEquipDesc(itemDesc.Id) == null)
				{
					AddValidateLog(string.Format($"ItemDesc ID:{itemDesc.Id} 未在EquipDesc表格找到对应ID数据"), itemToBlame);
				}
				break;
			case ItemType.AttrItem:
				if (GetAttrItemDesc(itemDesc.Id) == null)
				{
					AddValidateLog(string.Format($"ItemDesc ID:{itemDesc.Id} 未在AttrItemDesc表格找到对应ID数据"), itemToBlame);
				}
				break;
			case ItemType.Spell:
				if (GetSpellDesc(itemDesc.Id) == null)
				{
					AddValidateLog(string.Format($"ItemDesc ID:{itemDesc.Id} 未在SpellDesc表格找到对应ID数据"), itemToBlame);
				}
				break;
			case ItemType.Recipe:
				if (GetItemRecipeDesc(itemDesc.Id) == null)
				{
					AddValidateLog(string.Format($"ItemDesc Id:{itemDesc.Id} 未在ItemRecipe表格找到对应ID数据"), itemToBlame);
				}
				break;
			case ItemType.HuluAutoUpgrade:
				if (GetHuluDesc(itemDesc.Param1) == null || GetHuluDesc(itemDesc.Param2) == null)
				{
					AddValidateLog($"ItemDesc Id:{itemDesc.Id} Param1:{itemDesc.Param1} 或者 Param2:{itemDesc.Param2} 未在HuluDesc里面找到对应值!", itemToBlame);
				}
				break;
			case ItemType.ItemTransform:
				if (GetItemDesc(itemDesc.Param1) == null || GetItemDesc(itemDesc.Param2) == null)
				{
					AddValidateLog($"ItemDesc Id:{itemDesc.Id} Param1:{itemDesc.Param1} 或者 Param2:{itemDesc.Param2} 未在ItemDesc里面找到对应值!", itemToBlame);
				}
				break;
			}
		}
	}

	public static string GetItemToBlame()
	{
		return "jiajun_charlie";
	}

	public static int GetSpiritItemId(MoneyType moneyType = MoneyType.Spirit)
	{
		return MoneyType2IdDict[moneyType];
	}

	public static ItemType GetItemTypeById(int ItemID)
	{
		return GetItemDesc(ItemID)?.ItemType ?? ItemType.None;
	}

	public static bool IsMaterialCatalyst(int ItemId)
	{
		if (GetItemTypeById(ItemId) == ItemType.Catalyst)
		{
			return true;
		}
		return false;
	}

	public static int GetItemIdByType(ItemType itemType)
	{
		if (ItemType2IdDict.TryGetValue(itemType, out var value))
		{
			return value;
		}
		return -1;
	}

	public static ItemPackageType GetItemPackageTypeById(int ItemID)
	{
		return GetItemDesc(ItemID)?.PackageType ?? ItemPackageType.None;
	}

	public static bool IsLevelItem(int ResId)
	{
		ItemDesc itemDesc = GetItemDesc(ResId);
		if (itemDesc == null)
		{
			return false;
		}
		return itemDesc.IsLevelItem == YesNoType.Yes;
	}

	public static int GetItemImageID(int ItemID)
	{
		if (ItemImageIdDict.TryGetValue(ItemID, out var value))
		{
			return value;
		}
		return ItemID;
	}

	public static bool IsItemSupportStorage(int ItemID)
	{
		return GetConsumeType(ItemID) == ConsumeType.Elixir;
	}

	public static bool IsItemSupportStorage(ItemDesc itemDesc)
	{
		if (itemDesc.ItemType == ItemType.Consume)
		{
			return GetConsumeType(itemDesc.Id) == ConsumeType.Elixir;
		}
		return false;
	}

	public static string GetAttrItemToBlame()
	{
		return "feiluo";
	}

	public static string GetConsumeToBlame()
	{
		return "feiluo";
	}

	public static ConsumeType GetConsumeType(int consumeId)
	{
		return GetConsumeDesc(consumeId)?.Type ?? ConsumeType.None;
	}

	public static bool IsConsumeNeedAutoWear(int ConsumeId)
	{
		ConsumeDesc consumeDesc = GetConsumeDesc(ConsumeId);
		if (consumeDesc != null && consumeDesc.Type != ConsumeType.WinePartner && consumeDesc.SkipAutoWear != YesNoType.Yes)
		{
			return true;
		}
		return false;
	}

	public static bool IsWindPartner(int consumeId)
	{
		ConsumeDesc consumeDesc = GetConsumeDesc(consumeId);
		if (consumeDesc != null && consumeDesc.Type == ConsumeType.WinePartner)
		{
			return true;
		}
		return false;
	}

	public static bool IsMedicinalMaterials(int ConsumeId)
	{
		ConsumeDesc consumeDesc = GetConsumeDesc(ConsumeId);
		if (consumeDesc != null && consumeDesc.IsMedicinalMaterials == YesNoType.Yes)
		{
			return true;
		}
		return false;
	}

	public static void CheckConsumeDesc()
	{
		string toBlame = "charlie";
		TBConsumeDesc tBConsumeDesc = GetTBConsumeDesc();
		for (int i = 0; i < tBConsumeDesc.List.Count; i++)
		{
			ConsumeDesc consumeDesc = tBConsumeDesc.List[i];
			if (consumeDesc.Type == ConsumeType.Wine && GetWineDesc(consumeDesc.Id) == null)
			{
				AddValidateLog(string.Format($"ConsumeDesc Id:{consumeDesc.Id} 未在 WineDesc里面找到对应ID"), toBlame);
			}
		}
	}

	public static string GetUnitDropRuleToBlame()
	{
		return "jiajun";
	}

	public static void BuildUnitDropRuleDesc()
	{
		UnitDropRuleDict.Clear();
		TBUnitDropRuleDesc tBUnitDropRuleDesc = GetTBUnitDropRuleDesc();
		for (int i = 0; i < tBUnitDropRuleDesc.List.Count; i++)
		{
			UnitDropRuleDesc unitDropRuleDesc = tBUnitDropRuleDesc.List[i];
			if (!UnitDropRuleDict.ContainsKey(unitDropRuleDesc.Id))
			{
				UnitDropRuleDict[unitDropRuleDesc.Id] = new List<UnitDropRuleDesc>();
			}
			UnitDropRuleDict[unitDropRuleDesc.Id].Add(unitDropRuleDesc);
		}
	}

	public static List<UnitDropRuleDesc> GetUnitDropRuleDescList(int ResId)
	{
		if (UnitDropRuleDict.TryGetValue(ResId, out var value))
		{
			return value;
		}
		return null;
	}

	public static void CheckCollectionDropDesc()
	{
		TBCollectionDropDesc tBCollectionDropDesc = GetTBCollectionDropDesc();
		string collectionDropToBlame = GetCollectionDropToBlame();
		for (int i = 0; i < tBCollectionDropDesc.List.Count; i++)
		{
			if (GetCommDropRuleDesc(tBCollectionDropDesc.List[i].DropId) == null)
			{
				AddValidateLog(string.Format($"CollectionDropDesc表 ID:{tBCollectionDropDesc.List[i].Id} DropId:{tBCollectionDropDesc.List[i].DropId} 未在CommDropRuleDesc表找到对应ID数据"), collectionDropToBlame);
			}
		}
	}

	public static int GetPlayerLevelMax()
	{
		TBPlayerLevelDesc tBPlayerLevelDesc = GetTBPlayerLevelDesc();
		if (tBPlayerLevelDesc.List.Count > 0)
		{
			return tBPlayerLevelDesc.List[tBPlayerLevelDesc.List.Count - 1].Id;
		}
		return 1;
	}

	public static string GetSpellToBlame()
	{
		return "charlie";
	}

	public static SpellType GetSpellType(int ResId)
	{
		return GetSpellDesc(ResId)?.Type ?? SpellType.Min;
	}

	public static bool IsSpellAutoWear(int ResId)
	{
		SpellDesc spellDesc = GetSpellDesc(ResId);
		if (spellDesc != null)
		{
			if (spellDesc.IsReal == YesNoType.No)
			{
				return false;
			}
			SpellType type = spellDesc.Type;
			if (type - 1 <= SpellType.QiShu)
			{
				return true;
			}
			return false;
		}
		return false;
	}

	public static void BuildShopItemDesc()
	{
		ShopItemGroupDict.Clear();
		TBShopItemGroupDesc tBShopItemGroupDesc = GetTBShopItemGroupDesc();
		for (int i = 0; i < tBShopItemGroupDesc.List.Count; i++)
		{
			ShopItemGroupDesc shopItemGroupDesc = tBShopItemGroupDesc.List[i];
			if (!ShopItemGroupDict.ContainsKey(shopItemGroupDesc.GroupId))
			{
				ShopItemGroupDict.Add(shopItemGroupDesc.GroupId, new List<ShopItemGroupDesc>());
			}
			ShopItemGroupDict[shopItemGroupDesc.GroupId].Add(shopItemGroupDesc);
		}
	}

	public static void CheckShopDesc()
	{
		TBShopItemDesc tBShopItemDesc = GetTBShopItemDesc();
		string shopItemToBlame = GetShopItemToBlame();
		for (int i = 0; i < tBShopItemDesc.List.Count; i++)
		{
			ShopItemDesc shopItemDesc = tBShopItemDesc.List[i];
			if (GetItemDesc(shopItemDesc.ItemId) == null)
			{
				AddValidateLog(string.Format($"ShopDesc ID:{shopItemDesc.Id} ItemId:{shopItemDesc.ItemId} 未在ItemDesc表格找到对应ID数据"), shopItemToBlame);
			}
			if (shopItemDesc.SellMoneyConfigType == NumConfigType.IncreaseCount && GetIncreaseConfigDesc(shopItemDesc.SellMoneyConfigValue) == null)
			{
				AddValidateLog($"ShopDesc ID:{shopItemDesc.Id} SellMoneyConfigValue:{shopItemDesc.SellMoneyConfigValue} 未在IncreaseConfigDesc中找到对应配置。", shopItemToBlame);
			}
		}
		TBShopRefreshDesc tBShopRefreshDesc = GetTBShopRefreshDesc();
		for (int j = 0; j < tBShopRefreshDesc.List.Count; j++)
		{
			ShopRefreshDesc shopRefreshDesc = tBShopRefreshDesc.List[j];
			if (GetShopItemListByGroup(shopRefreshDesc.GroupId) == null)
			{
				AddValidateLog($"ShopRefreshDesc GroupId:{shopRefreshDesc.GroupId} 在ShopItemGroupDesc未找到对应值", shopItemToBlame);
			}
		}
		TBShopItemGroupDesc tBShopItemGroupDesc = GetTBShopItemGroupDesc();
		for (int k = 0; k < tBShopItemGroupDesc.List.Count; k++)
		{
			ShopItemGroupDesc shopItemGroupDesc = tBShopItemGroupDesc.List[k];
			if (GetShopItemDesc(shopItemGroupDesc.GoodsId) == null)
			{
				AddValidateLog($"ShopItemGroupDesc GroupId:{shopItemGroupDesc.GroupId} GoodsId:{shopItemGroupDesc.GoodsId} 未在ShopItemDesc找到对应值", shopItemToBlame);
			}
		}
	}

	public static string GetShopItemToBlame()
	{
		return "jiajun";
	}

	public static List<ShopItemGroupDesc> GetShopItemListByGroup(int ShopGroupId)
	{
		if (ShopItemGroupDict.ContainsKey(ShopGroupId))
		{
			return ShopItemGroupDict[ShopGroupId];
		}
		return null;
	}

	public static ShopRefreshDesc GetShopRefreshDesc(int ShopId, int ShopGroupId)
	{
		TBShopRefreshDesc tBShopRefreshDesc = GetTBShopRefreshDesc();
		for (int i = 0; i < tBShopRefreshDesc.List.Count; i++)
		{
			if (tBShopRefreshDesc.List[i].ShopId == ShopId && tBShopRefreshDesc.List[i].GroupId == ShopGroupId)
			{
				return tBShopRefreshDesc.List[i];
			}
		}
		return null;
	}

	public static string GetCollectionDropToBlame()
	{
		return "cd9_jiajun";
	}

	private static int MakeCollectionDropKey(int DropId, int DropLevel)
	{
		return DropId * 100 + DropLevel;
	}

	public static void BuildGetCollectionDropDesc()
	{
		CollectionDropDict.Clear();
		foreach (CollectionDropDesc item in GetTBCollectionDropDesc().List)
		{
			CollectionDropDict[MakeCollectionDropKey(item.Id, item.DropLevel)] = item;
		}
	}

	public static CollectionDropDesc GetCollectionDropDesc(int dropId, int dropLevel = 1)
	{
		while (dropLevel >= 1)
		{
			int key = MakeCollectionDropKey(dropId, dropLevel);
			if (CollectionDropDict.ContainsKey(key))
			{
				return CollectionDropDict[key];
			}
			dropLevel--;
		}
		BGW_LogUtil.LogError($"GetCollectionDropDesc Not Exist, DropId:{dropId}, DropLevel:{dropLevel}");
		return null;
	}

	public static string GetTalentSToBlame()
	{
		return "feiluo";
	}

	private static void UpdateAssociatedTalentDict(int TalentId, RepeatedField<int> RequireIdList, Dictionary<int, List<int>> AssociatedTalentDict)
	{
		foreach (int RequireId in RequireIdList)
		{
			if (AssociatedTalentDict.TryGetValue(RequireId, out var value))
			{
				if (!value.Contains(TalentId))
				{
					value.Add(TalentId);
				}
			}
			else
			{
				value = new List<int>();
				value.Add(TalentId);
				AssociatedTalentDict.Add(RequireId, value);
			}
		}
	}

	public static void BuildTalentSDesc()
	{
		TalentGroupDict.Clear();
		TalentCollectionDict.Clear();
		TalentSpellTypeDict.Clear();
		LegacyTalentListDict.Clear();
		LegacyPassiveTalent.Clear();
		SpellOnlyTalentDict.Clear();
		SpellAssociatedUnlockLegacyTalentDict.Clear();
		TalentAssociatedUnlockDefaultTalentList.Clear();
		TBTalentSDesc tBTalentSDesc = GetTBTalentSDesc();
		for (int i = 0; i < tBTalentSDesc.List.Count; i++)
		{
			TalentSDesc talentSDesc = tBTalentSDesc.List[i];
			if (talentSDesc.Type == TalentType.Default)
			{
				UpdateAssociatedTalentDict(talentSDesc.Id, talentSDesc.RequireTalentId, TalentAssociatedUnlockDefaultTalentList);
			}
			else if (talentSDesc.Type == TalentType.Legacy)
			{
				UpdateAssociatedTalentDict(talentSDesc.Id, talentSDesc.RequireSpellId, SpellAssociatedUnlockLegacyTalentDict);
				if (LegacyTalentListDict.TryGetValue(talentSDesc.TalentGroupId, out var value))
				{
					value.Add(talentSDesc.Id);
				}
				else
				{
					LegacyTalentListDict[talentSDesc.TalentGroupId] = new List<int>();
					LegacyTalentListDict[talentSDesc.TalentGroupId].Add(talentSDesc.Id);
				}
			}
			else if (talentSDesc.Type == TalentType.LegacyPassive)
			{
				LegacyPassiveTalent[talentSDesc.TalentGroupId] = talentSDesc.Id;
			}
			if (talentSDesc.IsSpellOnly == YesNoType.Yes)
			{
				SpellOnlyTalentDict[talentSDesc.Id] = talentSDesc.TalentGroupId;
			}
			if (talentSDesc.TalentGroupId <= 0)
			{
				continue;
			}
			int talentGroupId = talentSDesc.TalentGroupId;
			if (!TalentGroupDict.ContainsKey(talentGroupId))
			{
				TalentGroupDesc talentGroupDesc = new TalentGroupDesc
				{
					GroupId = talentSDesc.TalentGroupId
				};
				TalentGroupDict[talentSDesc.TalentGroupId] = talentGroupDesc;
				if (talentSDesc.Type == TalentType.Default)
				{
					SpellType spellType = GetSpellType(talentGroupId);
					if (!TalentCollectionDict.ContainsKey(spellType))
					{
						TalentCollectionDict[spellType] = new List<TalentGroupDesc>();
					}
					TalentCollectionDict[spellType].Add(talentGroupDesc);
				}
			}
			TalentGroupDict[talentSDesc.TalentGroupId].TalentDescList.Add(talentSDesc);
			if (talentSDesc.Type == TalentType.Default)
			{
				SpellType spellType2 = GetSpellType(talentGroupId);
				TalentSpellTypeDict[talentSDesc.Id] = spellType2;
			}
		}
	}

	public static List<TalentSDesc> GetTalentDescListByGroup(int GroupId)
	{
		if (TalentGroupDict.TryGetValue(GroupId, out var value))
		{
			return value.TalentDescList;
		}
		return new List<TalentSDesc>();
	}

	public static List<TalentGroupDesc> GetTalentGroupsByCollection(SpellType SpellType)
	{
		if (TalentCollectionDict.TryGetValue(SpellType, out var value))
		{
			return value;
		}
		return null;
	}

	public static List<ItemOne> GetTalentUnlockNeedItem(TalentLevelUpCfg talentLevelUpCfg)
	{
		List<ItemOne> list = new List<ItemOne>();
		if (talentLevelUpCfg != null)
		{
			if (talentLevelUpCfg.CostItem1Id > 0 && talentLevelUpCfg.CostItem1Num > 0)
			{
				list.Add(new ItemOne
				{
					Id = talentLevelUpCfg.CostItem1Id,
					Num = talentLevelUpCfg.CostItem1Num
				});
			}
			if (talentLevelUpCfg.CostItem2Id > 0 && talentLevelUpCfg.CostItem2Num > 0)
			{
				list.Add(new ItemOne
				{
					Id = talentLevelUpCfg.CostItem2Id,
					Num = talentLevelUpCfg.CostItem2Num
				});
			}
			if (talentLevelUpCfg.CostItem3Id > 0 && talentLevelUpCfg.CostItem3Num > 0)
			{
				list.Add(new ItemOne
				{
					Id = talentLevelUpCfg.CostItem3Id,
					Num = talentLevelUpCfg.CostItem3Num
				});
			}
		}
		return list;
	}

	public static void CheckTalentDesc()
	{
		TBTalentSDesc tBTalentSDesc = GetTBTalentSDesc();
		string talentSToBlame = GetTalentSToBlame();
		foreach (TalentSDesc item in tBTalentSDesc.List)
		{
			if (item.MaxLevel != item.LevelUpCfg.Count)
			{
				AddValidateLog(string.Format($"TalentSDesc ID:{item.Id} MaxLevel:{item.MaxLevel} 跟 LevelUpCfg数量:{item.LevelUpCfg.Count}不匹配"), talentSToBlame);
			}
			foreach (int item2 in item.RequireTalentId)
			{
				if (GetTalentSDesc(item2) == null)
				{
					AddValidateLog(string.Format($"TalentSDesc ID:{item.Id} RequireTalentId:{item2} 在TalentSDesc表格里面未找到对应ID"), talentSToBlame);
				}
			}
			if (item.Type == TalentType.Default && GetSpellDesc(item.TalentGroupId) == null)
			{
				AddValidateLog($"TalentSDesc.Id:{item.Id} GroupId:{item.TalentGroupId} 未在SpellDesc里找到对应值！", "jasonwu");
			}
			if (item.Type == TalentType.Legacy)
			{
				ItemDesc itemDesc = GetItemDesc(item.TalentGroupId);
				if (itemDesc == null || itemDesc.ItemType != ItemType.Legacy)
				{
					AddValidateLog($"TalentSDesc.Id:{item.Id} GroupId:{item.TalentGroupId} 不是大圣遗物ID", "jasonwu");
				}
			}
			if (item.Type == TalentType.LegacyPassive)
			{
				ItemDesc itemDesc2 = GetItemDesc(item.TalentGroupId);
				if (itemDesc2 == null || itemDesc2.ItemType != ItemType.Legacy)
				{
					AddValidateLog($"TalentSDesc.Id:{item.Id} GroupId:{item.TalentGroupId} 不是大圣遗物ID", "jasonwu");
				}
			}
			for (int i = 1; i <= item.MaxLevel; i++)
			{
				TalentLevelUpCfg talentLevelUpCfg = GetTalentLevelUpCfg(item, i);
				if (talentLevelUpCfg == null)
				{
					AddValidateLog(string.Format($"TalentSDesc ID:[{item.Id}]未在表格里找到等级:[{i}]对应的配置"), talentSToBlame);
					continue;
				}
				foreach (ItemOne item3 in GetTalentUnlockNeedItem(talentLevelUpCfg))
				{
					if (GetItemDesc(item3.Id) == null)
					{
						AddValidateLog(string.Format($"TalentSDesc ID:{item.Id} LevelUpCfg.CostItemId:{item3.Id} 在ItemDesc表格里面未找到对应ID"), talentSToBlame);
					}
				}
			}
		}
	}

	public static TalentSDesc GetTalentSDescByUnitResIDInMapCache(int TalentID, int ResID)
	{
		if (sMapTalentSUnit.TryGetValue(ResID, out var value) && value.TryGetValue(TalentID, out var value2))
		{
			return value2;
		}
		return null;
	}

	public static Dictionary<int, TalentSDesc> GetTalentSDescDicByUnitResID(int ResID)
	{
		if (sMapTalentSUnit.TryGetValue(ResID, out var value))
		{
			return value;
		}
		return null;
	}

	public static bool IsTalentEffectiveForUnit(int TalentId, int ResId)
	{
		if (sMapTalentSUnit.TryGetValue(ResId, out var value))
		{
			return value.ContainsKey(TalentId);
		}
		return false;
	}

	public static bool IsSpellOnlyTalent(int TalentId, out int SpellId)
	{
		return SpellOnlyTalentDict.TryGetValue(TalentId, out SpellId);
	}

	public static TalentLevelUpCfg GetTalentLevelUpCfg(TalentSDesc talentSDesc, int level)
	{
		for (int i = 0; i < talentSDesc.LevelUpCfg.Count; i++)
		{
			if (talentSDesc.LevelUpCfg[i].Level == level)
			{
				return talentSDesc.LevelUpCfg[i];
			}
		}
		return null;
	}

	public static int GetTalentMaxLevel(int TalentId)
	{
		return GetTalentSDesc(TalentId)?.MaxLevel ?? 0;
	}

	public static TalentLevelUpCfg GetTalentLevelUpCfg(int talentId, int level)
	{
		TalentSDesc talentSDesc = GetTalentSDesc(talentId);
		if (talentSDesc != null)
		{
			return GetTalentLevelUpCfg(talentSDesc, level);
		}
		return null;
	}

	public static bool IsDefaultTalent(int TalentId)
	{
		TalentSDesc talentSDesc = GetTalentSDesc(TalentId);
		if (talentSDesc != null && talentSDesc.Type == TalentType.Default)
		{
			return true;
		}
		return false;
	}

	public static bool IsSuitTalent(int ResId)
	{
		TalentSDesc talentSDesc = GetTalentSDesc(ResId);
		if (talentSDesc != null && talentSDesc.Type == TalentType.Suit)
		{
			return true;
		}
		return false;
	}

	public static bool IsLegacyTalent(int ResId)
	{
		TalentSDesc talentSDesc = GetTalentSDesc(ResId);
		if (talentSDesc != null && talentSDesc.Type == TalentType.Legacy)
		{
			return true;
		}
		return false;
	}

	public static void BuildTalentRankDesc()
	{
		TalentRankDescDict.Clear();
		TalentRankListDict.Clear();
		AutoUnlockTalentList.Clear();
		TBTalentRankDesc tBTalentRankDesc = GetTBTalentRankDesc();
		for (int i = 0; i < tBTalentRankDesc.List.Count; i++)
		{
			TalentRankDesc talentRankDesc = tBTalentRankDesc.List[i];
			TalentRankDescDict.Add((talentRankDesc.SpellType, talentRankDesc.Rank), talentRankDesc);
			if (TalentRankListDict.TryGetValue(talentRankDesc.SpellType, out var value))
			{
				value.Add(talentRankDesc);
			}
			else
			{
				TalentRankListDict[talentRankDesc.SpellType] = new List<TalentRankDesc>();
				TalentRankListDict[talentRankDesc.SpellType].Add(talentRankDesc);
			}
			foreach (int item in talentRankDesc.UnlockTalent)
			{
				if (!AutoUnlockTalentList.Contains(item))
				{
					AutoUnlockTalentList.Add(item);
				}
			}
		}
	}

	public static List<TalentRankDesc> GetTalentRankListByCollection(SpellType SpellType)
	{
		if (TalentRankListDict.TryGetValue(SpellType, out var value))
		{
			return value;
		}
		return null;
	}

	public static Dictionary<SpellType, List<TalentRankDesc>> GetTalentRankDict()
	{
		return TalentRankListDict;
	}

	public static bool IsAutoUnlockTalent(int TalentId)
	{
		return AutoUnlockTalentList.Contains(TalentId);
	}

	public static SpellType GetTalentSpellType(int TalentId)
	{
		if (TalentSpellTypeDict.TryGetValue(TalentId, out var value))
		{
			return value;
		}
		return SpellType.Min;
	}

	public static TalentRankDesc GetTalentRankDesc(SpellType SpellType, int Rank)
	{
		if (TalentRankDescDict.TryGetValue((SpellType, Rank), out var value))
		{
			return value;
		}
		return null;
	}

	public static int GetTalentUnlockRequireRankPoint(TalentSDesc TalentDesc)
	{
		if (TalentDesc.Type == TalentType.Default)
		{
			TalentRankDesc talentRankDesc = GetTalentRankDesc(GetTalentSpellType(TalentDesc.Id), TalentDesc.Rank);
			if (talentRankDesc != null)
			{
				return talentRankDesc.UnlockRankPoint;
			}
		}
		return 0;
	}

	public static bool IsTalentRank(int TalentID)
	{
		foreach (List<TalentRankDesc> value in TalentRankListDict.Values)
		{
			foreach (TalentRankDesc item in value)
			{
				foreach (int item2 in item.UnlockTalent)
				{
					if (TalentID == item2)
					{
						return true;
					}
				}
			}
		}
		return false;
	}

	public static void CheckRoleDataInitDesc()
	{
		TBRoleDataConfigDesc tBRoleDataConfigDesc = GetTBRoleDataConfigDesc();
		string roleDataConfigToBlame = GetRoleDataConfigToBlame();
		for (int i = 0; i < tBRoleDataConfigDesc.List.Count; i++)
		{
			RoleDataConfigDesc roleDataConfigDesc = tBRoleDataConfigDesc.List[i];
			switch (roleDataConfigDesc.ItemType)
			{
			case RoleDataConfigItemType.AttrItem:
				if (GetAttrItemDesc(roleDataConfigDesc.ItemId) == null)
				{
					AddValidateLog(string.Format($"RoleDataConfigDesc ID:{roleDataConfigDesc.Group} ItemId:{roleDataConfigDesc.ItemId} 未在AttrItemDesc表格找到对应ID数据"), roleDataConfigToBlame);
				}
				break;
			case RoleDataConfigItemType.Equip:
				if (GetEquipDesc(roleDataConfigDesc.ItemId) == null)
				{
					AddValidateLog(string.Format($"RoleDataConfigDesc ID:{roleDataConfigDesc.Group} ItemId:{roleDataConfigDesc.ItemId} 未在EquipDesc表格找到对应ID数据"), roleDataConfigToBlame);
				}
				break;
			case RoleDataConfigItemType.Item:
				if (GetItemDesc(roleDataConfigDesc.ItemId) == null)
				{
					AddValidateLog(string.Format($"RoleDataConfigDesc ID:{roleDataConfigDesc.Group} ItemId:{roleDataConfigDesc.ItemId} 未在ItemDesc表格找到对应ID数据"), roleDataConfigToBlame);
				}
				break;
			case RoleDataConfigItemType.Spell:
				if (GetSpellDesc(roleDataConfigDesc.ItemId) == null)
				{
					AddValidateLog(string.Format($"RoleDataConfigDesc ID:{roleDataConfigDesc.Group} ItemId:{roleDataConfigDesc.ItemId} 未在SpellDesc表格找到对应ID数据"), roleDataConfigToBlame);
				}
				break;
			case RoleDataConfigItemType.Talent:
				if (GetTalentSDesc(roleDataConfigDesc.ItemId) == null)
				{
					AddValidateLog(string.Format($"RoleDataConfigDesc ID:{roleDataConfigDesc.Group} ItemId:{roleDataConfigDesc.ItemId} 未在TalentSDesc表格找到对应ID数据"), roleDataConfigToBlame);
				}
				if (GetTalentLevelUpCfg(roleDataConfigDesc.ItemId, roleDataConfigDesc.ItemNum) == null)
				{
					AddValidateLog(string.Format($"RoleDataConfigDesc ID:{roleDataConfigDesc.Group} ItemId:{roleDataConfigDesc.ItemId} ItemNum:{roleDataConfigDesc.ItemNum} 未在TalentSDesc找到天赋对应等级配置"), roleDataConfigToBlame);
				}
				break;
			}
		}
	}

	private static void BuildRoleDefaultEquip()
	{
		RoleDefaultEquip.Clear();
		foreach (RoleDataConfigDesc item in GetRoleDataConfigByType(1))
		{
			if (item.ItemType == RoleDataConfigItemType.Equip)
			{
				EquipPosition equipPosition = GetEquipPosition(item.ItemId);
				if (!RoleDefaultEquip.ContainsKey(equipPosition))
				{
					RoleDefaultEquip[equipPosition] = item.ItemId;
				}
			}
		}
	}

	public static void BuildRoleDataConfigDesc()
	{
		RoleDataConfigDict.Clear();
		TBRoleDataConfigDesc tBRoleDataConfigDesc = GetTBRoleDataConfigDesc();
		for (int i = 0; i < tBRoleDataConfigDesc.List.Count; i++)
		{
			RoleDataConfigDesc roleDataConfigDesc = tBRoleDataConfigDesc.List[i];
			if (!RoleDataConfigDict.ContainsKey(roleDataConfigDesc.Group))
			{
				RoleDataConfigDict[roleDataConfigDesc.Group] = new List<RoleDataConfigDesc>();
			}
			RoleDataConfigDict[roleDataConfigDesc.Group].Add(roleDataConfigDesc);
		}
		BuildRoleDefaultEquip();
	}

	public static List<RoleDataConfigDesc> GetRoleDataConfigByType(int configGroup)
	{
		if (RoleDataConfigDict.TryGetValue(configGroup, out var value))
		{
			return value;
		}
		return null;
	}

	public static Dictionary<int, List<RoleDataConfigDesc>> GetRoleDataConfigDict()
	{
		return RoleDataConfigDict;
	}

	public static string GetRoleDataConfigToBlame()
	{
		return "feiluo";
	}

	public static void BuildOnlineLevelDict()
	{
		OnlinLevelDescDict.Clear();
		VersionLevelList.Clear();
		foreach (LevelDesc item in GetTBLevelDesc().List)
		{
			if (item.IsOnlineLevel == YesNoType.Yes)
			{
				OnlinLevelDescDict.Add(item.Id, item);
			}
			if (item.IsVersionLevel == YesNoType.Yes)
			{
				VersionLevelList.Add(item.Id);
			}
		}
	}

	public static int GetAllLevelNum()
	{
		return GetTBLevelDesc().List.Count;
	}

	public static Dictionary<int, LevelDesc> GetAllOnlineLevelDesc()
	{
		return OnlinLevelDescDict;
	}

	public static int GetAllOnlineLevelNum()
	{
		return OnlinLevelDescDict.Count;
	}

	public static List<int> GetAllVersionLevelID()
	{
		return VersionLevelList;
	}

	public static int GetLevelAreaKey(int LevelId, int AreaId)
	{
		return LevelId * 1000 + AreaId;
	}

	public static int GetChapterAtlasKey(int ChapterId, int MapAtlasId)
	{
		return MapAtlasId;
	}

	public static int GetSpriteAreaKey(int MapSpriteId, int MapAreaId)
	{
		return MapSpriteId * 1000 + MapAreaId;
	}

	public static void BuildMapAreaConfigDesc()
	{
		MapLevelAreaDescDict.Clear();
		TBMapAreaConfigDesc tBMapAreaConfigDesc = GetTBMapAreaConfigDesc();
		for (int i = 0; i < tBMapAreaConfigDesc.List.Count; i++)
		{
			MapAreaConfigDesc mapAreaConfigDesc = tBMapAreaConfigDesc.List[i];
			MapLevelAreaDescDict[GetLevelAreaKey(mapAreaConfigDesc.LevelId, mapAreaConfigDesc.AreaId)] = mapAreaConfigDesc;
		}
		MapSpriteAreaDescDict.Clear();
		for (int j = 0; j < tBMapAreaConfigDesc.List.Count; j++)
		{
			MapAreaConfigDesc mapAreaConfigDesc2 = tBMapAreaConfigDesc.List[j];
			MapSpriteAreaDescDict[GetSpriteAreaKey(mapAreaConfigDesc2.MapSpriteId, mapAreaConfigDesc2.AreaId)] = mapAreaConfigDesc2;
		}
	}

	private static void InitTalentSUnitMap()
	{
		sMapTalentSUnit.Clear();
		foreach (TalentSDesc item in GetTBTalentSDesc().List)
		{
			if (item == null)
			{
				continue;
			}
			int id = item.Id;
			foreach (string item2 in item.UnitResIDStrs.Split(';').ToList())
			{
				if (int.TryParse(item2, out var result))
				{
					if (sMapTalentSUnit.TryGetValue(result, out var _))
					{
						sMapTalentSUnit[result].Add(id, item);
						continue;
					}
					sMapTalentSUnit.Add(result, new Dictionary<int, TalentSDesc> { { id, item } });
				}
			}
		}
	}

	private static void InitCommonErrorUITipsDict()
	{
		sCommonErrorUITipsDict.Clear();
		foreach (CommonErrorUITipsDesc item in GetTBCommonErrorUITipsDesc().List)
		{
			if (item != null)
			{
				ECommonErrorType errorType = item.ErrorType;
				int errorCode = item.ErrorCode;
				if (sCommonErrorUITipsDict.TryGetValue(errorType, out var _))
				{
					sCommonErrorUITipsDict[errorType].Add(errorCode, item);
					continue;
				}
				Dictionary<int, CommonErrorUITipsDesc> dictionary = new Dictionary<int, CommonErrorUITipsDesc>();
				dictionary.Add(errorCode, item);
				sCommonErrorUITipsDict.Add(errorType, dictionary);
			}
		}
	}

	public static int InitLoadMapAreaDataForEditorUtil()
	{
		GSProtobufRuntimeAPI<TBMapAreaConfigDesc, MapAreaConfigDesc>.Get().LoadData();
		BuildMapAreaConfigDesc();
		return 0;
	}

	public static MapAreaConfigDesc GetMapAreaConfigDesc(int LevelId, int AreaId)
	{
		int levelAreaKey = GetLevelAreaKey(LevelId, AreaId);
		if (MapLevelAreaDescDict.TryGetValue(levelAreaKey, out var value))
		{
			return value;
		}
		return null;
	}

	public static List<MapAreaConfigDesc> GetMapAreaColorList(int LevelId)
	{
		List<MapAreaConfigDesc> list = new List<MapAreaConfigDesc>();
		foreach (KeyValuePair<int, MapAreaConfigDesc> item in MapLevelAreaDescDict)
		{
			if (item.Value.LevelId == LevelId)
			{
				list.Add(item.Value);
			}
		}
		return list;
	}

	public static MapAreaConfigDesc GetMapAreaConfigDescBySpriteId(int MapSpriteId, int AreaId)
	{
		int spriteAreaKey = GetSpriteAreaKey(MapSpriteId, AreaId);
		if (MapSpriteAreaDescDict.TryGetValue(spriteAreaKey, out var value))
		{
			return value;
		}
		return null;
	}

	public static bool IsSameAtlas(int MapSpriteX, int MapSpriteY)
	{
		MapSpriteConfigDesc mapSpriteConfigDesc = GetMapSpriteConfigDesc(MapSpriteX);
		MapSpriteConfigDesc mapSpriteConfigDesc2 = GetMapSpriteConfigDesc(MapSpriteY);
		if (mapSpriteConfigDesc != null && mapSpriteConfigDesc2 != null)
		{
			int chapterAtlasKey = GetChapterAtlasKey(mapSpriteConfigDesc.ChapterId, mapSpriteConfigDesc.MapAtlasId);
			int chapterAtlasKey2 = GetChapterAtlasKey(mapSpriteConfigDesc2.ChapterId, mapSpriteConfigDesc2.MapAtlasId);
			return chapterAtlasKey == chapterAtlasKey2;
		}
		return false;
	}

	public static int PastMemoryKey(ResourceType eType, int iResourceId)
	{
		return (int)eType * 1000 + iResourceId;
	}

	public static void BuildFastPastMemoryDesc()
	{
		FastPastMemoryDict.Clear();
		TBPastMemoryDesc all = GSProtobufRuntimeAPI<TBPastMemoryDesc, PastMemoryDesc>.Get().GetAll();
		for (int i = 0; i < all.List.Count; i++)
		{
			PastMemoryDesc pastMemoryDesc = all.List[i];
			FastPastMemoryDict[PastMemoryKey(pastMemoryDesc.ResourceType, pastMemoryDesc.ResourceId)] = pastMemoryDesc;
		}
	}

	public static PastMemoryDesc FastGetPastMemoryDesc(ResourceType eType, int ResourceId)
	{
		if (FastPastMemoryDict.TryGetValue(PastMemoryKey(eType, ResourceId), out var value))
		{
			return value;
		}
		return null;
	}

	public static void CheckFastMemoryBuildDesc()
	{
		string toBlame = "jasonwu";
		TBPastMemoryDesc all = GSProtobufRuntimeAPI<TBPastMemoryDesc, PastMemoryDesc>.Get().GetAll();
		HashSet<int> hashSet = new HashSet<int>();
		foreach (PastMemoryDesc item in all.List)
		{
			int num = PastMemoryKey(item.ResourceType, item.ResourceId);
			if (hashSet.TryGetValue(num, out var _))
			{
				AddValidateLog($"PastMemoryDesc PastMemoryId {item.Id} 对应的 Resource Type {item.ResourceType}, Resource Id:{item.ResourceId} 重复出现", toBlame);
			}
			else
			{
				hashSet.Add(num);
			}
		}
	}

	public static (int, EUnitQualityType) GamePlusKey(int LevelStrength, EUnitQualityType UnitQuality)
	{
		return (LevelStrength, UnitQuality);
	}

	public static void BuildNewGamePlusDesc()
	{
		NewGamePlusDict.Clear();
		NewGamePlusCountMax = 0;
		TBNewGamePlusDesc all = GSProtobufRuntimeAPI<TBNewGamePlusDesc, NewGamePlusDesc>.Get().GetAll();
		for (int i = 0; i < all.List.Count; i++)
		{
			NewGamePlusDesc newGamePlusDesc = all.List[i];
			if (newGamePlusDesc.Count > NewGamePlusCountMax)
			{
				NewGamePlusCountMax = newGamePlusDesc.Count;
			}
			(int, EUnitQualityType) key = GamePlusKey(newGamePlusDesc.LevelStrength, newGamePlusDesc.Quality);
			if (!NewGamePlusDict.ContainsKey(key))
			{
				NewGamePlusDict[key] = new List<NewGamePlusDesc>();
			}
			NewGamePlusDict[key].Add(newGamePlusDesc);
		}
		foreach (List<NewGamePlusDesc> value in NewGamePlusDict.Values)
		{
			value.Sort((NewGamePlusDesc x, NewGamePlusDesc y) => x.Count.CompareTo(y.Count));
		}
	}

	public static void CheckNewGamePlusDesc()
	{
		for (int i = 1; i <= 8; i++)
		{
			foreach (EUnitQualityType value in Enum.GetValues(typeof(EUnitQualityType)))
			{
				if (value != EUnitQualityType.None && value != EUnitQualityType.Player && value != EUnitQualityType.PlayerSummon)
				{
					(int, EUnitQualityType) key = GamePlusKey(i, value);
					if (!NewGamePlusDict.ContainsKey(key))
					{
						AddValidateLog($"关卡强度:{i} 单位品质:{value} 未在多周目配表NewGamePlusDesc里面找到对应配置", "songjiajun");
					}
				}
			}
		}
	}

	public static NewGamePlusDesc GetNewGamePlusDesc(int LevelStrength, EUnitQualityType UnitQuality, int GameCount)
	{
		if (NewGamePlusDict.TryGetValue(GamePlusKey(LevelStrength, UnitQuality), out var value) && value != null && value.Count > 0)
		{
			for (int num = value.Count - 1; num >= 0; num--)
			{
				if (GameCount >= value[num].Count)
				{
					return value[num];
				}
			}
		}
		return null;
	}

	public static CommonErrorUITipsDesc GetCommonErrorUITipsDesc(ECommonErrorType ErrorType, int ErrorCode)
	{
		if (sCommonErrorUITipsDict.TryGetValue(ErrorType, out var value) && value.TryGetValue(ErrorCode, out var value2))
		{
			return value2;
		}
		return null;
	}

	public static void BuildHuluUpgradeTree()
	{
		CommUpgradeNode<HuluDesc>.InitBuildCommNodeTree((int ResId) => GetHuluDesc(ResId), () => GetTBHuluDesc().List.ToList(), (HuluDesc HuluDesc) => HuluDesc.Id, (HuluDesc HuluDesc) => HuluDesc.NextId);
	}

	public static CommUpgradeNode<HuluDesc> GetHuluUpgradeNode(int HuluId)
	{
		return CommUpgradeNode<HuluDesc>.GetNodeById(HuluId);
	}

	public static int GetHuluSeriesId(int HuluId)
	{
		return GetHuluDesc(HuluId)?.Series ?? 0;
	}

	public static int GetHuluNextLevelId(int HuluId)
	{
		return GetHuluDesc(HuluId)?.NextId ?? 0;
	}

	public static void CheckHuluDesc()
	{
		TBHuluDesc tBHuluDesc = GetTBHuluDesc();
		string toBlame = "charlie";
		for (int i = 0; i < tBHuluDesc.List.Count; i++)
		{
			HuluDesc huluDesc = tBHuluDesc.List[i];
			if (huluDesc.NextId > 0)
			{
				HuluDesc huluDesc2 = GetHuluDesc(huluDesc.NextId);
				if (huluDesc2 == null)
				{
					AddValidateLog(string.Format($"HuluDesc Id:{huluDesc.Id} NextId:{huluDesc.NextId} 未在HuluDesc里面找到对应的值"), toBlame);
				}
				else if (huluDesc.Series != huluDesc2.Series)
				{
					AddValidateLog(string.Format($"HuluDesc Id:{huluDesc.Id} SeriesId:{huluDesc.Series} not equal NextHuluDesc Series:{huluDesc2.Series}"), toBlame);
				}
			}
		}
	}

	public static void BuildWineUpgradeTree()
	{
		CommUpgradeNode<WineDesc>.InitBuildCommNodeTree((int ResId) => GetWineDesc(ResId), () => GetTBWineDesc().List.ToList(), (WineDesc WineDesc) => WineDesc.Id, (WineDesc WineDesc) => WineDesc.NextId);
	}

	public static CommUpgradeNode<WineDesc> GetWineUpgradeNode(int WineId)
	{
		return CommUpgradeNode<WineDesc>.GetNodeById(WineId);
	}

	public static void BuildWineSeriesDict()
	{
		WineSeriesDict.Clear();
		foreach (WineDesc item in GetTBWineDesc().List)
		{
			if (item.Series > 0)
			{
				WineSeriesDict[item.Id] = item.Series;
			}
		}
	}

	public static int GetWineSeriesId(int WineId)
	{
		if (WineSeriesDict.TryGetValue(WineId, out var value))
		{
			return value;
		}
		return 0;
	}

	public static bool IsSameSeriesWine(int LeftHuluId, int RightHuluId)
	{
		int wineSeriesId = GetWineSeriesId(LeftHuluId);
		int wineSeriesId2 = GetWineSeriesId(RightHuluId);
		if (wineSeriesId == 0 || wineSeriesId2 == 0)
		{
			return false;
		}
		return wineSeriesId == wineSeriesId2;
	}

	public static int GetWineNextId(int WineId)
	{
		return GetWineDesc(WineId)?.NextId ?? 0;
	}

	public static int GetWineUpgradeNeedItemNumTodoRemove(int WineId)
	{
		return 0;
	}

	public static void CheckWineDesc()
	{
		string toBlame = "charlie";
		TBWineDesc tBWineDesc = GetTBWineDesc();
		for (int i = 0; i < tBWineDesc.List.Count; i++)
		{
			WineDesc wineDesc = tBWineDesc.List[i];
			if (wineDesc.NextId > 0)
			{
				WineDesc wineDesc2 = GetWineDesc(wineDesc.NextId);
				if (wineDesc2 == null)
				{
					AddValidateLog($"WineDesc Id:{wineDesc.Id} NextId:{wineDesc.NextId} not in WineDesc", toBlame);
				}
				else if (wineDesc.Series != wineDesc2.Series)
				{
					AddValidateLog($"WineDesc Id:{wineDesc.Id} Series Not Equal NextWineId:{wineDesc2.Series} Series", toBlame);
				}
			}
		}
	}

	public static List<ItemOne> CalcRecipeCostItem(int RecipeId, int BatchNum)
	{
		List<ItemOne> list = new List<ItemOne>();
		ItemRecipeDesc itemRecipeDesc = GetItemRecipeDesc(RecipeId);
		if (itemRecipeDesc == null)
		{
			BGW_LogUtil.LogError($"GetItemRecipeDesc Failed, BatchRecipeId:{RecipeId}");
			return null;
		}
		foreach (ItemOne material in itemRecipeDesc.MaterialList)
		{
			list.Add(new ItemOne
			{
				Id = material.Id,
				Num = material.Num * BatchNum
			});
		}
		return list;
	}

	public static string CalcItemRecipeKey(RepeatedField<ItemOne> itemList)
	{
		List<ItemOne> list = new List<ItemOne>();
		foreach (ItemOne item in itemList)
		{
			list.Add(item);
		}
		list.Sort((ItemOne v1, ItemOne v2) => v1.Id.CompareTo(v2.Id));
		string text = "";
		for (int num = 0; num < list.Count; num++)
		{
			text += string.Format($"{list[num].Id}:{list[num].Num}:");
		}
		return text;
	}

	public static void BuildItemRecipeDesc()
	{
		AttrItemRecipeIdDict.Clear();
		TBItemRecipeDesc tBItemRecipeDesc = GetTBItemRecipeDesc();
		for (int i = 0; i < tBItemRecipeDesc.List.Count; i++)
		{
			ItemRecipeDesc itemRecipeDesc = tBItemRecipeDesc.List[i];
			if (itemRecipeDesc.IsAttrItem == YesNoType.Yes && itemRecipeDesc.TargetItem.Id > 0)
			{
				AttrItemRecipeIdDict[itemRecipeDesc.TargetItem.Id] = itemRecipeDesc;
			}
		}
	}

	public static AlchemyOutputDesc GetAlchemyOutputDescBuyQuality(int Quality)
	{
		TBAlchemyOutputDesc tBAlchemyOutputDesc = GetTBAlchemyOutputDesc();
		for (int i = 0; i < tBAlchemyOutputDesc.List.Count; i++)
		{
			AlchemyOutputDesc alchemyOutputDesc = tBAlchemyOutputDesc.List[i];
			if (Quality >= alchemyOutputDesc.QualityLowerLimit && Quality <= alchemyOutputDesc.QualityUpperLimit)
			{
				return alchemyOutputDesc;
			}
		}
		return null;
	}

	public static void CheckItemRecipeDesc()
	{
		string toBlame = "charlie";
		TBItemRecipeDesc tBItemRecipeDesc = GetTBItemRecipeDesc();
		for (int i = 0; i < tBItemRecipeDesc.List.Count; i++)
		{
			ItemRecipeDesc itemRecipeDesc = tBItemRecipeDesc.List[i];
			if (itemRecipeDesc.SuccessRate > 10000)
			{
				AddValidateLog(string.Format($"ItemRecipe Id:{itemRecipeDesc.Id} SuccressRate:{itemRecipeDesc.SuccessRate} 大于10000"), toBlame);
			}
			if (itemRecipeDesc.IsAttrItem == YesNoType.Yes && GetItemTypeById(itemRecipeDesc.TargetItem.Id) != ItemType.AttrItem)
			{
				AddValidateLog(string.Format($"ItemRecipe Id:{itemRecipeDesc.Id} TargetItemId:{itemRecipeDesc.TargetItem.Id} is not attrItem"), toBlame);
			}
			if (itemRecipeDesc.KeyItemId > 0 && itemRecipeDesc.KeyItemNum == 0)
			{
				AddValidateLog(string.Format($"ItemRecipe Id:{itemRecipeDesc.Id} KeyItem.Num 数量为0！ "), toBlame);
			}
		}
	}

	public static void CheckWeaponBuildDesc()
	{
		string toBlame = "jasonwu";
		foreach (WeaponBuildDesc item in GetTBWeaponBuildDesc().List)
		{
			if (GetEquipDesc(item.Id) == null)
			{
				AddValidateLog($"WeaponBuildDesc Id:{item.Id} 未在EquipDesc里找到对应值", toBlame);
			}
			if (item.RequireWeapon > 0 && GetEquipDesc(item.RequireWeapon) == null)
			{
				AddValidateLog($"WeaponBuildDesc Id:{item.Id} RequireWeapon:{item.RequireWeapon} 未在EquipDesc里找到对应值", toBlame);
			}
		}
	}

	public static void CheckEquipDesc()
	{
		foreach (EquipDesc item in GetTBEquipDesc().List)
		{
			if (item.EquipPosition == EquipPosition.Hulu)
			{
				if (GetHuluDesc(item.Id) == null)
				{
					AddValidateLog($"EquipDesc Poistion {item.EquipPosition} EquipId:{item.Id} 不在 HuluDesc中", "Charlie");
				}
			}
			else if (item.EquipPosition == EquipPosition.Accessory && GetItemDesc(item.Id).CarryMax <= 0)
			{
				AddValidateLog($"EquipDesc EquipId:{item.Id} 饰品没有配置持有上限", "Charlie");
			}
		}
	}

	private static void BuildWeaponTreeNode(int WeaponId)
	{
		WeaponBuildDesc weaponBuildDesc = GetWeaponBuildDesc(WeaponId);
		if (weaponBuildDesc == null)
		{
			return;
		}
		WeaponTreeNode weaponTreeNode = new WeaponTreeNode();
		weaponTreeNode.weaponBuildDesc = weaponBuildDesc;
		if (weaponBuildDesc.RequireWeapon > 0 && weaponBuildDesc.RequireWeapon != WeaponId)
		{
			WeaponTreeNode weaponTreeNode2 = GetWeaponTreeNode(weaponBuildDesc.RequireWeapon);
			if (weaponTreeNode2 != null)
			{
				weaponTreeNode.parentNode = weaponTreeNode2;
				weaponTreeNode.nodePaths.AddRange(weaponTreeNode2.nodePaths);
				weaponTreeNode2.childNodes.Add(weaponTreeNode);
			}
		}
		weaponTreeNode.nodePaths.Add(WeaponId);
		weaponTreeNodeDict[WeaponId] = weaponTreeNode;
	}

	private static void BuildWeaponTree()
	{
		weaponTreeNodeDict.Clear();
		TBEquipDesc tBEquipDesc = GetTBEquipDesc();
		for (int i = 0; i < tBEquipDesc.List.Count; i++)
		{
			if (tBEquipDesc.List[i].EquipPosition == EquipPosition.Weapon && !weaponTreeNodeDict.ContainsKey(tBEquipDesc.List[i].Id))
			{
				BuildWeaponTreeNode(tBEquipDesc.List[i].Id);
			}
		}
	}

	public static bool IsSingleNode(int WeaponId)
	{
		WeaponTreeNode weaponTreeNode = GetWeaponTreeNode(WeaponId);
		if (weaponTreeNode != null)
		{
			if (weaponTreeNode.parentNode == null)
			{
				return weaponTreeNode.childNodes.Count == 0;
			}
			return false;
		}
		return WeaponId > 0;
	}

	public static WeaponTreeNode GetWeaponTreeNode(int WeaponId)
	{
		if (GetEquipPosition(WeaponId) != EquipPosition.Weapon)
		{
			return null;
		}
		if (!weaponTreeNodeDict.ContainsKey(WeaponId))
		{
			BuildWeaponTreeNode(WeaponId);
		}
		if (!weaponTreeNodeDict.ContainsKey(WeaponId))
		{
			return null;
		}
		return weaponTreeNodeDict[WeaponId];
	}

	public static int GetRootWeaponId(int WeaponId)
	{
		int result = WeaponId;
		for (WeaponTreeNode weaponTreeNode = GetWeaponTreeNode(WeaponId); weaponTreeNode != null; weaponTreeNode = weaponTreeNode.parentNode)
		{
			result = weaponTreeNode.weaponBuildDesc.Id;
		}
		return result;
	}

	public static int FindParentWeaponId(int WeaponA, int WeaponB)
	{
		int result = 0;
		WeaponTreeNode weaponTreeNode = GetWeaponTreeNode(WeaponA);
		WeaponTreeNode weaponTreeNode2 = GetWeaponTreeNode(WeaponB);
		if (weaponTreeNode != null && weaponTreeNode2 != null)
		{
			int num = 0;
			while (num < weaponTreeNode.nodePaths.Count && num < weaponTreeNode2.nodePaths.Count && weaponTreeNode.nodePaths[num] == weaponTreeNode2.nodePaths[num])
			{
				result = weaponTreeNode.nodePaths[num++];
			}
		}
		return result;
	}

	public static bool IsWeaponInSameTree(int OriginWeaponId, int TargetWeaponId)
	{
		int value;
		bool num = WeaponIdToRootIdDict.TryGetValue(OriginWeaponId, out value);
		int value2;
		bool flag = WeaponIdToRootIdDict.TryGetValue(TargetWeaponId, out value2);
		if (!num || !flag)
		{
			return false;
		}
		return value == value2;
	}

	public static void CalcBuildWeaponCostItem(bool isFirstBuild, bool IncludeKeyItem, int targetWeaponId, out List<ItemOne> OutCostItems)
	{
		OutCostItems = new List<ItemOne>();
		WeaponBuildDesc weaponBuildDesc = GetWeaponBuildDesc(targetWeaponId);
		if (weaponBuildDesc == null)
		{
			BGW_LogUtil.LogError($"CalcBuildWeaponItemChange GetWeaponBuildDesc Failed, TargetWeaponId:{targetWeaponId}");
			return;
		}
		if (isFirstBuild)
		{
			foreach (ItemOne item in weaponBuildDesc.CostItem)
			{
				OutCostItems.Add(item.Clone());
			}
		}
		else
		{
			foreach (ItemOne item2 in weaponBuildDesc.TransformItem)
			{
				OutCostItems.Add(item2.Clone());
			}
		}
		if (!IncludeKeyItem)
		{
			return;
		}
		foreach (ItemOne keyItem in weaponBuildDesc.KeyItemList)
		{
			OutCostItems.Add(keyItem.Clone());
		}
	}

	public static void BuildLoadingTipsDesc()
	{
		LoadingTipsDescDict.Clear();
		UnitDeathTipsDict.Clear();
		TriggerTypeNoneTipsDict.Clear();
		foreach (LoadingTipsDesc item in GetTBLoadingTipsDesc().List)
		{
			if (item.TipsTriggerType == TipsTriggerType.All)
			{
				TriggerTypeNoneTipsDict.Add(item.Id, item);
			}
		}
	}

	public static List<LoadingTipsDesc> GetLoadingTipsByType(LoadingTipsType tipsType, int MapId)
	{
		if (LoadingTipsDescDict.ContainsKey(tipsType) && LoadingTipsDescDict[tipsType].ContainsKey(MapId))
		{
			return LoadingTipsDescDict[tipsType][MapId];
		}
		return null;
	}

	public static List<LoadingTipsDesc> GetLoadingTipsByDeathUnitId(int UnitId, int MapId)
	{
		List<LoadingTipsDesc> list = new List<LoadingTipsDesc>();
		if (UnitDeathTipsDict.ContainsKey(0) && UnitDeathTipsDict[MapId].ContainsKey(UnitId))
		{
			list.AddRange(UnitDeathTipsDict[0][UnitId]);
		}
		if (UnitDeathTipsDict.ContainsKey(MapId) && UnitDeathTipsDict[MapId].ContainsKey(UnitId))
		{
			list.AddRange(UnitDeathTipsDict[MapId][UnitId]);
		}
		return list;
	}

	public static List<LoadingTipsDesc> GetLoadingTipsToFillRet(int needNum)
	{
		List<LoadingTipsDesc> list = new List<LoadingTipsDesc>();
		List<int> list2 = new List<int>();
		int num = needNum;
		foreach (KeyValuePair<int, LoadingTipsDesc> item in TriggerTypeNoneTipsDict)
		{
			list2.Add(item.Key);
		}
		list2 = list2.OrderBy((int a) => Guid.NewGuid()).ToList();
		num = ((TriggerTypeNoneTipsDict.Count > num) ? num : TriggerTypeNoneTipsDict.Count);
		for (int num2 = 0; num2 < num; num2++)
		{
			list.Add(TriggerTypeNoneTipsDict[list2[num2]]);
		}
		if (list.Count == 0)
		{
			BGW_LogUtil.LogError("Trigger Type ALl Tips Don't exist");
		}
		return list;
	}

	public static int GetCommLogicCfgValue(CommCfgType commCfgType)
	{
		return GetCommLogicCfgDesc((int)commCfgType)?.Value ?? 0;
	}

	public static void BuildCommDropRuleDesc()
	{
		CommDropRuleDict.Clear();
		TBCommDropRuleDesc tBCommDropRuleDesc = GetTBCommDropRuleDesc();
		for (int i = 0; i < tBCommDropRuleDesc.List.Count; i++)
		{
			CommDropRuleDesc commDropRuleDesc = tBCommDropRuleDesc.List[i];
			CommDropRuleDict[commDropRuleDesc.DropId] = commDropRuleDesc;
		}
	}

	public static CommDropRuleDesc GetCommDropRuleDesc(int ResId)
	{
		if (CommDropRuleDict.TryGetValue(ResId, out var value))
		{
			return value;
		}
		return null;
	}

	public static void BuildUISettingConfigDesc()
	{
		UISettingConfigDict.Clear();
		TBUISettingConfigDesc tBUISettingConfigDesc = GetTBUISettingConfigDesc();
		for (int i = 0; i < tBUISettingConfigDesc.List.Count; i++)
		{
			UISettingConfigDesc uISettingConfigDesc = tBUISettingConfigDesc.List[i];
			if (!UISettingConfigDict.ContainsKey(uISettingConfigDesc.ConfigType))
			{
				UISettingConfigDict.Add(uISettingConfigDesc.ConfigType, uISettingConfigDesc);
			}
		}
	}

	public static UISettingConfigDesc GetUISettingConfigDesc(UISettingConfigType ConfigType)
	{
		if (UISettingConfigDict.TryGetValue(ConfigType, out var value))
		{
			return value;
		}
		return null;
	}

	private static void BuildUISettingConfigDescDict()
	{
		UISettingConfigDescList.Clear();
		RepeatedField<UISettingConfigDesc> list = GetTBUISettingConfigDesc().List;
		int num = 0;
		foreach (UISettingConfigDesc item in list)
		{
			if (num < item.Priority)
			{
				num = item.Priority;
			}
		}
		for (int i = 0; i <= num; i++)
		{
			UISettingConfigDescList.Add(new List<UISettingConfigDesc>());
		}
		for (int j = 0; j <= num; j++)
		{
			foreach (UISettingConfigDesc item2 in list)
			{
				if (item2.Priority == j)
				{
					UISettingConfigDescList[j].Add(item2);
				}
			}
		}
	}

	private static void BuildUnlockTypeResIdDitc()
	{
		SoundTrackUnlockTypeToSoundTrackIdDict.Clear();
		MvUnlockTypeToMvIdDict.Clear();
		foreach (SoundTrackDesc item in GetTBSoundTrackDesc().List)
		{
			if (item.UnlockCondition != ResUnlockType.None)
			{
				FillDict(item.Id, item.UnlockCondition, SoundTrackUnlockTypeToSoundTrackIdDict);
			}
		}
		foreach (MuseumMVDesc item2 in GetTBMuseumMVDesc().List)
		{
			if (item2.UnlockCondition != ResUnlockType.None)
			{
				FillDict(item2.Id, item2.UnlockCondition, MvUnlockTypeToMvIdDict);
			}
		}
		static void FillDict(int RedId, ResUnlockType ResUnlockType, Dictionary<ResUnlockType, List<int>> Dict)
		{
			if (Dict.TryGetValue(ResUnlockType, out var value))
			{
				if (!value.Contains(RedId))
				{
					value.Add(RedId);
				}
			}
			else
			{
				Dict.Add(ResUnlockType, new List<int> { RedId });
			}
		}
	}

	public static void BuildBossRushDict()
	{
		EBossUnlockConditionToRefightId.Clear();
		EBossUnlockConditionToContinuousFightId.Clear();
		foreach (BossReChallengeDesc item in GetTBBossReChallengeDesc().List)
		{
			if (item.UnlockCondition != EBossUnlockCondition.None)
			{
				UpdateBossRushDict(EBossUnlockConditionToRefightId, item.UnlockCondition, item.UnlockId, item.Id);
			}
			if (item.UnlockSuccessiveId != 0)
			{
				UpdateBossRushDict(EBossUnlockConditionToRefightId, EBossUnlockCondition.UnlockGroup, item.UnlockSuccessiveId, item.Id);
			}
		}
		foreach (BossIterationsDesc item2 in GetTBBossIterationsDesc().List)
		{
			foreach (BossUnlockConfig item3 in item2.UnlockInfo)
			{
				if (item3.UnlockCondition != EBossUnlockCondition.None)
				{
					UpdateBossRushDict(EBossUnlockConditionToContinuousFightId, item3.UnlockCondition, item3.UnlockId, item2.Id);
				}
			}
		}
		static void UpdateBossRushDict(Dictionary<(EBossUnlockCondition, int), List<int>> Dict, EBossUnlockCondition UnlockCondition, int ConditionId, int BossRushId)
		{
			if (Dict.TryGetValue((UnlockCondition, ConditionId), out var value))
			{
				value.Add(BossRushId);
			}
			else
			{
				Dict.Add((UnlockCondition, ConditionId), new List<int> { BossRushId });
			}
		}
	}

	public static bool GetRelevantBossRushIdList(EBossRushType BossRushType, EBossUnlockCondition UnlockCondition, int ConditionId, out List<int> OutBossRushIdList)
	{
		OutBossRushIdList = null;
		switch (BossRushType)
		{
		case EBossRushType.Rechallenge:
		{
			List<int> value2;
			bool result2 = EBossUnlockConditionToRefightId.TryGetValue((UnlockCondition, ConditionId), out value2);
			OutBossRushIdList = value2;
			return result2;
		}
		case EBossRushType.BossIterations:
		{
			List<int> value;
			bool result = EBossUnlockConditionToContinuousFightId.TryGetValue((UnlockCondition, ConditionId), out value);
			OutBossRushIdList = value;
			return result;
		}
		default:
			return false;
		}
	}

	public static List<int> GetSoundTrackIdListByUnlockType(ResUnlockType UnlockType)
	{
		if (SoundTrackUnlockTypeToSoundTrackIdDict.TryGetValue(UnlockType, out var value))
		{
			return value;
		}
		return null;
	}

	public static List<int> GetMvIdListByUnlockType(ResUnlockType UnlockType)
	{
		if (MvUnlockTypeToMvIdDict.TryGetValue(UnlockType, out var value))
		{
			return value;
		}
		return null;
	}

	public static List<List<UISettingConfigDesc>> GetUISettingConfigDescDict()
	{
		return UISettingConfigDescList;
	}

	public static void BuildTransInputUITipsDict()
	{
		TransInputUITipsDict.Clear();
		TBTransInputUITipsDesc tBTransInputUITipsDesc = GetTBTransInputUITipsDesc();
		for (int i = 0; i < tBTransInputUITipsDesc.List.Count; i++)
		{
			TransInputUITipsDesc transInputUITipsDesc = tBTransInputUITipsDesc.List[i];
			if (!TransInputUITipsDict.ContainsKey(transInputUITipsDesc.ResId))
			{
				TransInputUITipsDict.Add(transInputUITipsDesc.ResId, new List<TransInputUITipsDesc> { transInputUITipsDesc });
			}
			else
			{
				TransInputUITipsDict[transInputUITipsDesc.ResId].Add(transInputUITipsDesc);
			}
		}
	}

	public static List<TransInputUITipsDesc> GetTransInputUITipsDescListByResId(int ResId)
	{
		if (TransInputUITipsDict.TryGetValue(ResId, out var value))
		{
			return value;
		}
		return null;
	}

	private static void BuildLevelDesc()
	{
		LevelDescDict.Clear();
		foreach (LevelDesc item in GetTBLevelDesc().List)
		{
			if (!LevelDescDict.ContainsKey(item.Id))
			{
				LevelDescDict.Add(item.Id, item);
			}
		}
	}

	public static LevelDesc FastGetLevelDesc(int LevelID)
	{
		if (LevelDescDict.ContainsKey(LevelID))
		{
			return LevelDescDict[LevelID];
		}
		return null;
	}

	public static List<LevelDesc> GetAllLevelDesc()
	{
		return LevelDescDict.Values.ToList();
	}

	public static int GetChapterNextId(int chapterId)
	{
		return GetChapterDesc(chapterId)?.NextChapterId ?? 0;
	}

	private static void BuildChapterSurpriseDesc()
	{
		ChapterSurpriseDescDict.Clear();
		foreach (SurpriseDesc item in GetTBSurpriseDesc().List)
		{
			if (ChapterSurpriseDescDict.TryGetValue(item.ChapterId, out var value))
			{
				if (!value.Contains(item))
				{
					value.Add(item);
				}
			}
			else
			{
				value = new List<SurpriseDesc>();
				value.Add(item);
				ChapterSurpriseDescDict.Add(item.ChapterId, value);
			}
		}
	}

	private static void BuildChapterAwardDesc()
	{
		ChapterAwardDict.Clear();
		int commLogicCfgValue = GetCommLogicCfgValue(CommCfgType.DefaultChapterId);
		int commLogicCfgValue2 = GetCommLogicCfgValue(CommCfgType.LastChapterId);
		foreach (MuseumMVDesc item in GetTBMuseumMVDesc().List)
		{
			if (item.ChapterId != commLogicCfgValue && item.ChapterId != commLogicCfgValue2)
			{
				if (ChapterAwardDict.TryGetValue((item.ChapterId, ResourceType.Mv), out var value))
				{
					value.Add(item.Id);
					continue;
				}
				List<int> value2 = new List<int> { item.Id };
				ChapterAwardDict.Add((item.ChapterId, ResourceType.Mv), value2);
			}
		}
	}

	public static List<SurpriseDesc> GetSurpriseListByChapter(int ChapterID)
	{
		if (ChapterSurpriseDescDict.TryGetValue(ChapterID, out var value))
		{
			return value;
		}
		return null;
	}

	public static bool IsSurpriseInChapter(int SurpriseID, int ChapterID)
	{
		List<SurpriseDesc> surpriseListByChapter = GetSurpriseListByChapter(ChapterID);
		if (surpriseListByChapter != null)
		{
			foreach (SurpriseDesc item in surpriseListByChapter)
			{
				if (item.Id == SurpriseID)
				{
					return true;
				}
			}
		}
		return false;
	}

	public static List<int> GetChapterAward(int ChapterId, ResourceType resourceType)
	{
		ChapterAwardDict.TryGetValue((ChapterId, resourceType), out var value);
		if (value == null)
		{
			return null;
		}
		return value;
	}

	public static void CheckChapterDesc()
	{
		string toBlame = "jasonwu";
		foreach (ChapterDesc item in GetTBChapterDesc().List)
		{
			foreach (int award in item.AwardList)
			{
				if (GetCommDropRuleDesc(award) == null)
				{
					AddValidateLog($"AwardId does not exist in CommDropRuleDesc. ChapterId:{item.Id} AwardId:{award}", toBlame);
				}
			}
			LevelDesc levelDesc = GetLevelDesc(item.LevelId);
			if (levelDesc == null)
			{
				AddValidateLog($"ChapterDesc表中ChapterId:{item.Id} 这一行中LevelId：{item.LevelId} 在LevelDesc中不存在", toBlame);
			}
			else if (levelDesc.LevelChapter != item.Id)
			{
				AddValidateLog($"LevelDesc表中LevelId:{levelDesc.Id} 的LevelChapter为:{levelDesc.LevelChapter} 但ChapterDesc中章节ID:{item.Id}的LevelId为:{item.LevelId}", toBlame);
			}
		}
	}

	public static List<int> GetSpellUnlockLegacyTalentList(int SpellId)
	{
		SpellAssociatedUnlockLegacyTalentDict.TryGetValue(SpellId, out var value);
		return value;
	}

	public static List<int> GetTalentUnlockDefaultTalentList(int TalentId)
	{
		TalentAssociatedUnlockDefaultTalentList.TryGetValue(TalentId, out var value);
		return value;
	}

	public static List<int> GetLegacyTalentList(int LegacyId)
	{
		if (LegacyTalentListDict.TryGetValue(LegacyId, out var value))
		{
			return value;
		}
		return null;
	}

	public static int GetTalentOwnLegacy(int TalentId)
	{
		foreach (KeyValuePair<int, List<int>> item in LegacyTalentListDict)
		{
			int key = item.Key;
			if (item.Value.Contains(TalentId))
			{
				return key;
			}
		}
		return 0;
	}

	public static int GetLegacyPassiveTalent(int LegacyId)
	{
		if (LegacyPassiveTalent.TryGetValue(LegacyId, out var value))
		{
			return value;
		}
		return 0;
	}

	public static int GetFinalLegacyId()
	{
		return 4096;
	}

	public static bool IsFinalLegacy(int LegacyId)
	{
		return LegacyId == 4096;
	}

	public static void CheckCardDesc()
	{
		foreach (CardDesc item in GetTBCardDesc().List)
		{
			foreach (int item2 in item.CardIndexId)
			{
				FUStUnitCommDesc unitCommDesc = BGW_GameDB.GetUnitCommDesc(item2);
				FUStUnitBattleInfoExtendDesc unitBattleInfoExtendDesc = BGW_GameDB.GetUnitBattleInfoExtendDesc(item2);
				if (unitCommDesc == null && unitBattleInfoExtendDesc == null)
				{
					AddValidateLog($"CardId:{item.Id} CardName: {item.UnitName} cardDesc.CardIndexId:{item2} 在UnitCommDesc和UnitBattleInfoExtendDesc中都没找到");
				}
			}
		}
	}

	private static void BuildCard()
	{
		CardIndexDict.Clear();
		VersionCardList.Clear();
		foreach (CardDesc item in GetTBCardDesc().List)
		{
			foreach (int item2 in item.CardIndexId)
			{
				CardIndexDict[item2] = item.Id;
			}
			if (IsVersionCard(item))
			{
				VersionCardList.Add(item);
			}
		}
	}

	public static bool IsVersionCard(CardDesc Card)
	{
		return true;
	}

	public static int GetCardIdByCardIndex(int unitId, int overrideId)
	{
		if (CardIndexDict.TryGetValue(overrideId, out var value))
		{
			return value;
		}
		if (CardIndexDict.TryGetValue(unitId, out var value2))
		{
			return value2;
		}
		return 0;
	}

	public static CardStory GetCardStory(int cardId, ECollectionStage eStoryStage)
	{
		foreach (CardStory item in GetCardDesc(cardId).CardStory)
		{
			if (eStoryStage == item.CollectionStage)
			{
				return item;
			}
		}
		return null;
	}

	public static List<CardDesc> GetAllVersionCardDesc()
	{
		return VersionCardList;
	}

	public static void BuildArmorEnhanceConsumeDict()
	{
		ArmorEnhanceConsumeDict.Clear();
		foreach (ArmorEnhanceConsumeDesc item in GetTBArmorEnhanceConsumeDesc().List)
		{
			ArmorEnhanceConsumeDict[(item.TargetQuality, item.Position)] = item;
		}
	}

	public static List<ItemOne> GetArmorEnhanceCostItemList(ItemQuality ItemQuality, EquipPosition Position)
	{
		if (ArmorEnhanceConsumeDict.TryGetValue((ItemQuality, Position), out var value))
		{
			return value.ItemList.ToList();
		}
		return new List<ItemOne>();
	}

	public static int GetCurArmorMaxLevelId(int ArmorId)
	{
		EquipSeriesDesc equipSeriesDesc = GetEquipSeriesDesc(GetEquipSeries(ArmorId));
		return equipSeriesDesc?.EquipIdList[equipSeriesDesc.EquipIdList.Count - 1] ?? 0;
	}

	public static void BuildSettingSortDict()
	{
		SettingSortDict.Clear();
		foreach (UISettingConfigDesc item in GetTBUISettingConfigDesc().List)
		{
			if (!SettingSortDict.ContainsKey(item.ConfigTab))
			{
				SettingSortDict.Add(item.ConfigTab, new Dictionary<UISettingConfigType, int>());
			}
			if (!SettingSortDict[item.ConfigTab].ContainsKey(item.ConfigType))
			{
				SettingSortDict[item.ConfigTab].Add(item.ConfigType, item.SortId);
			}
			if (item.ConfigTabInfoEx.Count <= 0)
			{
				continue;
			}
			foreach (ConfigTabInfoEx item2 in item.ConfigTabInfoEx)
			{
				if (!SettingSortDict.ContainsKey(item2.ConfigTab))
				{
					SettingSortDict.Add(item2.ConfigTab, new Dictionary<UISettingConfigType, int>());
				}
				if (!SettingSortDict[item2.ConfigTab].ContainsKey(item.ConfigType))
				{
					SettingSortDict[item2.ConfigTab].Add(item.ConfigType, item2.SortId);
				}
			}
		}
	}

	public static int GetSettingSortDict(EUIConfigTab UIConfigTab, UISettingConfigType SettingConfigType)
	{
		if (SettingConfigType != UISettingConfigType.Min && SettingSortDict.TryGetValue(UIConfigTab, out var value) && value.TryGetValue(SettingConfigType, out var value2))
		{
			return value2;
		}
		return -1;
	}

	private static void BuildUnitLinkBloodGroup()
	{
		Unit2LinkBloodDesc = new Dictionary<string, LinkBloodDesc>();
		foreach (LinkBloodDesc item in GetTBLinkBloodDesc().List)
		{
			foreach (string item2 in item.Guid)
			{
				if (!Unit2LinkBloodDesc.ContainsKey(item2))
				{
					Unit2LinkBloodDesc.Add(item2, item);
				}
			}
		}
	}

	public static LinkBloodDesc GetLinkBloodDesc(string Guid)
	{
		if (Unit2LinkBloodDesc.TryGetValue(Guid, out var value))
		{
			return value;
		}
		return null;
	}

	private static QuestStage ConfigShowStage2QuestStage(int Stage)
	{
		if (Stage != 1)
		{
			return QuestStage.Activated;
		}
		return QuestStage.Finished;
	}

	public static void BuildTaskStageRefreshNpcLocationDict()
	{
		TaskStageShowNpcLocationDict.Clear();
		TaskStageHideNpcLocationDict.Clear();
		ShrineShowNpcConfigDescDict.Clear();
		foreach (ShrineShowNpcConfigDesc item3 in GetTBShrineShowNpcConfigDesc().List)
		{
			QuestStageOne item = AddQuesetStageOne(item3, TaskStageShowNpcLocationDict, ShowNpc: true);
			QuestStageOne item2 = AddQuesetStageOne(item3, TaskStageHideNpcLocationDict, ShowNpc: false);
			ShrineShowNpcConfigDescDict[(item3.NpcId, item3.RebirthPointId, item)] = item3;
			ShrineShowNpcConfigDescDict[(item3.NpcId, item3.RebirthPointId, item2)] = item3;
		}
		static QuestStageOne AddQuesetStageOne(ShrineShowNpcConfigDesc ConfigDesc, Dictionary<QuestStageOne, List<NpcLocationOne>> TargetDict, bool ShowNpc)
		{
			QuestStageOne questStageOne = CreateQuesetStageOne(ConfigDesc, ShowNpc);
			if (TargetDict.TryGetValue(questStageOne, out var value))
			{
				value.Add(new NpcLocationOne
				{
					NpcId = ConfigDesc.NpcId,
					RebirthPointId = ConfigDesc.RebirthPointId
				});
			}
			else
			{
				TargetDict.Add(questStageOne, new List<NpcLocationOne>
				{
					new NpcLocationOne
					{
						NpcId = ConfigDesc.NpcId,
						RebirthPointId = ConfigDesc.RebirthPointId
					}
				});
			}
			return questStageOne;
		}
		static QuestStageOne CreateQuesetStageOne(ShrineShowNpcConfigDesc ConfigDesc, bool ShowNpc)
		{
			return new QuestStageOne
			{
				Id = (ShowNpc ? ConfigDesc.ShowTaskStageId : ConfigDesc.HideTaskStageId),
				Stage = (ShowNpc ? ConfigShowStage2QuestStage(ConfigDesc.ShowStage) : ConfigShowStage2QuestStage(ConfigDesc.HideStage))
			};
		}
	}

	public static void GetNpcRefreshLocationByTaskstage(QuestStageOne QuestStageOne, out List<NpcLocationOne> ShowNpcList, out List<NpcLocationOne> HideNpcList)
	{
		TaskStageShowNpcLocationDict.TryGetValue(QuestStageOne, out ShowNpcList);
		TaskStageHideNpcLocationDict.TryGetValue(QuestStageOne, out HideNpcList);
	}

	public static ShrineShowNpcConfigDesc GetNpcLocatoinConfigDesc(int NpcId, int RebirthPointId, QuestStageOne QuestStageOne)
	{
		if (ShrineShowNpcConfigDescDict.TryGetValue((NpcId, RebirthPointId, QuestStageOne), out var value))
		{
			return value;
		}
		return null;
	}

	public static void CheckNpcLocationRefresh()
	{
		TBShrineShowNpcConfigDesc tBShrineShowNpcConfigDesc = GetTBShrineShowNpcConfigDesc();
		Dictionary<(int, int, QuestStageOne), ShrineShowNpcConfigDesc> tempDict = new Dictionary<(int, int, QuestStageOne), ShrineShowNpcConfigDesc>();
		foreach (ShrineShowNpcConfigDesc item in tBShrineShowNpcConfigDesc.List)
		{
			QuestStageOne questStageOne = new QuestStageOne
			{
				Id = item.ShowTaskStageId,
				Stage = ConfigShowStage2QuestStage(item.ShowStage)
			};
			CheckConfg(tempDict, questStageOne, item);
			QuestStageOne questStageOne2 = new QuestStageOne
			{
				Id = item.HideTaskStageId,
				Stage = ConfigShowStage2QuestStage(item.HideStage)
			};
			CheckConfg(tempDict, questStageOne2, item);
			if (BGW_GameDB.GetRebirthPointDesc(item.RebirthPointId) == null)
			{
				AddValidateLog($"ShrineShowNpcConfigDesc NpcId:{item.NpcId} RebirthPointId:{item.RebirthPointId} 中 RebirthPointId 在FUStRebirthPointDesc中都没找到对应值");
			}
			if (item.ShowTaskStageId != 0 && BGW_GameDB.GetTaskStageDesc(item.ShowTaskStageId) == null)
			{
				AddValidateLog($"ShrineShowNpcConfigDesc NpcId:{item.NpcId} RebirthPointId:{item.RebirthPointId} 中 ShowTaskStageId {item.ShowTaskStageId} 未在TaskStageDesc找到对应值");
			}
			if (item.HideTaskStageId != 0 && BGW_GameDB.GetTaskStageDesc(item.HideTaskStageId) == null)
			{
				AddValidateLog($"ShrineShowNpcConfigDesc NpcId:{item.NpcId} RebirthPointId:{item.RebirthPointId} 中 HideTaskStageId {item.HideTaskStageId} 未在TaskStageDesc找到对应值");
			}
			if (item.ShowTaskStageId == item.HideTaskStageId && item.ShowStage == item.HideStage)
			{
				AddValidateLog($"ShrineShowNpcConfigDesc NpcId:{item.NpcId} RebirthPointId:{item.RebirthPointId} 中 ShowTaskStageId ShowStage 和 HideTaskStageId HideStage 配置相同");
			}
		}
		static void CheckConfg(Dictionary<(int, int, QuestStageOne), ShrineShowNpcConfigDesc> TempDict, QuestStageOne QuestStageOne, ShrineShowNpcConfigDesc ConfigDesc)
		{
			if (TempDict.TryGetValue((ConfigDesc.NpcId, ConfigDesc.RebirthPointId, QuestStageOne), out var _))
			{
				AddValidateLog($"ShrineShowNpcConfigDesc NpcId:{ConfigDesc.NpcId} RebirthPointId:{ConfigDesc.RebirthPointId} TaskStageId:{ConfigDesc.ShowTaskStageId} Stage:{ConfigDesc.ShowStage} 在ShrineShowNpcConfigDesc中重复配置");
			}
			else
			{
				TempDict.Add((ConfigDesc.NpcId, ConfigDesc.RebirthPointId, QuestStageOne), ConfigDesc);
			}
		}
	}

	public static void CheckBossRushDesc()
	{
		foreach (BossReChallengeDesc item in GetTBBossReChallengeDesc().List)
		{
			switch (item.UnlockCondition)
			{
			case EBossUnlockCondition.CardDesc:
				if (GetCardDesc(item.UnlockId) == null)
				{
					AddValidateLog($"BossReChallengeDesc Id:{item.Id} Desc.UnlockId:{item.UnlockId} 在CardDesc中未找到对应值");
				}
				break;
			case EBossUnlockCondition.Item:
				if (GetItemDesc(item.UnlockId) == null)
				{
					AddValidateLog($"BossReChallengeDesc Id:{item.Id} Desc.UnlockId:{item.UnlockId} 在ItemDesc中未找到对应值");
				}
				break;
			case EBossUnlockCondition.UnlockGroup:
				if (GetBossIterationsDesc(item.UnlockId) == null)
				{
					AddValidateLog($"BossReChallengeDesc Id:{item.Id} Desc.UnlockId:{item.UnlockId} 在BossIterationsDesc中未找到对应值");
				}
				break;
			}
			if (item.UnlockSuccessiveId != 0 && GetBossIterationsDesc(item.UnlockSuccessiveId) == null)
			{
				AddValidateLog($"BossReChallengeDesc Id:{item.Id} Desc.UnlockId:{item.UnlockId} 在BossIterationsDesc中未找到对应值");
			}
		}
		foreach (BossIterationsDesc item2 in GetTBBossIterationsDesc().List)
		{
			foreach (BossUnlockConfig item3 in item2.UnlockInfo)
			{
				switch (item3.UnlockCondition)
				{
				case EBossUnlockCondition.CardDesc:
					if (GetCardDesc(item3.UnlockId) == null)
					{
						AddValidateLog($"BossIterationsDesc Id:{item2.Id} Desc.UnlockId:{item3.UnlockId} 在CardDesc中未找到对应值");
					}
					break;
				case EBossUnlockCondition.Item:
					if (GetItemDesc(item3.UnlockId) == null)
					{
						AddValidateLog($"BossIterationsDesc Id:{item2.Id} Desc.UnlockId:{item3.UnlockId} 在ItemDesc中未找到对应值");
					}
					break;
				case EBossUnlockCondition.UnlockGroup:
					if (GetBossIterationsDesc(item3.UnlockId) == null)
					{
						AddValidateLog($"BossIterationsDesc Id:{item2.Id} Desc.UnlockId:{item3.UnlockId} 在BossIterationsDesc中未找到对应值");
					}
					break;
				}
			}
		}
	}

	public static void CheckCommDropRuleDesc()
	{
		string toBlame = "songjiajun,charlie";
		HashSet<int> hashSet = new HashSet<int>();
		foreach (CommDropRuleDesc item in GetTBCommDropRuleDesc().List)
		{
			int dropId = item.DropId;
			if (hashSet.Contains(dropId))
			{
				AddValidateLog($"CommDropDesc.DropId:{dropId} 表格配置重复", "songjiajun");
			}
			hashSet.Add(dropId);
			if (item.Type == DropConfigType.Group || item.Type == DropConfigType.RandGroup)
			{
				foreach (DropLibConfig item2 in item.DropLib)
				{
					if (GetCommDropRuleDesc(item2.DropId) == null)
					{
						AddValidateLog($"CommDropRuleDesc.DropId:{item.DropId} DropLib.DropId:{item2.DropId} 未在CommDropRuleDesc找到对应配置！", toBlame);
					}
				}
			}
			if (item.RollType == DropRollType.GuaranteeDrop)
			{
				int rollNum = item.RollNum;
				int num = 30000 / (4 * item.GroupDropRate);
				if (item.GroupDropRate <= 0)
				{
					AddValidateLog($"CommDropRuleDesc.DropId:{item.DropId} GroupDropRate:{item.GroupDropRate}值非法，必须大于0", toBlame);
				}
				else if (rollNum <= num)
				{
					AddValidateLog($"CommDropRuleDesc.DropId:{item.DropId} 保底次数N:[{rollNum}]小于T:[{num}](期望掉落次数的3/4)", toBlame);
				}
			}
			LimitParam limitParam = item.LimitParam;
			if (limitParam.QuestId > 0 && BGW_GameDB.GetTaskStageDesc(limitParam.QuestId) == null)
			{
				AddValidateLog($"CommDropRuleDesc.DropId:{item.DropId} LimitParam.QuestId:{limitParam.QuestId} 未在TaskStageDesc找到对应值!", toBlame);
			}
			foreach (ItemOne item3 in item.UniqueDropOnce)
			{
				if (GetItemDesc(item3.Id) == null)
				{
					AddValidateLog($"CommDropRuleDesc.DropId:{item.DropId} UniqueDropOnce.ItemId:{item3.Id} 未在ItemDesc找到对应值!", toBlame);
				}
			}
			foreach (UniqueDropItem item4 in item.UniqueDropReplace)
			{
				if (GetItemDesc(item4.Id) == null)
				{
					AddValidateLog($"CommDropRuleDesc.DropId:{item.DropId} UniqueDropReplace.ItemId:{item4.Id} 未在ItemDesc找到对应值!", toBlame);
				}
			}
			foreach (DropItemOne item5 in item.RandDrop)
			{
				if (GetItemDesc(item5.ItemId) == null)
				{
					AddValidateLog($"CommDropRuleDesc.DropId:{item.DropId} RandDrop.ItemId:{item5.ItemId} 未在ItemDesc找到对应值!", toBlame);
				}
				else if (item5.MaxNum < item5.MinNum)
				{
					AddValidateLog($"CommDropRuleDesc.DropId:{item.DropId} RandDrop.ItemId:{item5.ItemId} 最小掉落数量MinNum:{item5.MinNum} 大于 最大掉落数量MaxNum:{item5.MaxNum} 掉落概率Rate:{item5.Rate} 配置有误，综合掉出概率为0！", toBlame);
				}
			}
			foreach (UniqueDropItem item6 in item.UniqueDropReplace)
			{
				if (item6.NumType == NumConfigType.IncreaseCount && GetIncreaseConfigDesc(item6.ConfigValue) == null)
				{
					AddValidateLog($"CommDropRuleDesc.DropId:{item.DropId} UniqueDropReplace.ConfigValue：{item6.ConfigValue} 未在IncreaseConfigDesc找到对应配置。", toBlame);
				}
			}
		}
	}

	private static void BuildLockMantraCostDict()
	{
		LockMantraCostDict.Clear();
		foreach (LockMantraDesc item in GetTBLockMantraDesc().List)
		{
			LockMantraCostDict[item.LockNum] = item.CostItemList.ToList();
		}
	}

	public static List<ItemOne> GetLockMantraCostList(int LockNum)
	{
		if (LockNum == 0)
		{
			return new List<ItemOne>();
		}
		if (LockMantraCostDict.TryGetValue(LockNum, out var value))
		{
			return value;
		}
		return null;
	}

	public static List<MantraDesc> GetMantraByQualityAndPosition(ItemQuality itemQuality, EquipPosition equipPosition)
	{
		List<MantraDesc> list = new List<MantraDesc>();
		foreach (MantraDesc item in GetTBMantraDesc().List)
		{
			if (item.Quality == itemQuality && item.Position == equipPosition)
			{
				list.Add(item);
			}
		}
		return list;
	}

	public static void CheckLockMantraCostDesc()
	{
		TBLockMantraDesc tBLockMantraDesc = GetTBLockMantraDesc();
		HashSet<int> hashSet = new HashSet<int>();
		foreach (LockMantraDesc item in tBLockMantraDesc.List)
		{
			if (hashSet.Contains(item.LockNum))
			{
				AddValidateLog($"Same LockNum Config in LockMantraDesc Id:{item.Id} LockNum:{item.LockNum}");
			}
			else
			{
				hashSet.Add(item.LockNum);
			}
		}
	}

	public static void CheckMantraWeightDesc()
	{
		TBMantraWeightDesc tBMantraWeightDesc = GetTBMantraWeightDesc();
		List<List<int>> list = new List<List<int>>();
		foreach (MantraWeightDesc item in tBMantraWeightDesc.List)
		{
			List<int> list2 = new List<int> { item.Id, item.LuckValueMin };
			if (item.LuckValueMax == 0 && item.LuckValueMin != 0)
			{
				list2.Add(int.MaxValue);
			}
			else
			{
				list2.Add(item.LuckValueMax);
			}
			list.Add(list2);
		}
		for (int i = 0; i < tBMantraWeightDesc.List.Count; i++)
		{
			for (int j = i + 1; j < tBMantraWeightDesc.List.Count; j++)
			{
				if (list[i][1] <= list[j][2] && list[i][2] >= list[j][1])
				{
					AddValidateLog($"在真言权重表MantraWeightDesc中，两行数据的幸运值区间重合 Id:{list[i][0]} Id:{list[j][0]}");
				}
			}
		}
	}

	public static void CheckArmorEnhanceConsumeDesc()
	{
		Dictionary<(ItemQuality, EquipPosition), ArmorEnhanceConsumeDesc> dictionary = new Dictionary<(ItemQuality, EquipPosition), ArmorEnhanceConsumeDesc>();
		foreach (ArmorEnhanceConsumeDesc item in GetTBArmorEnhanceConsumeDesc().List)
		{
			if (dictionary.TryGetValue((item.TargetQuality, item.Position), out var _))
			{
				AddValidateLog($"在ArmorEnhanceConsumeDesc中，重复定义TargetQuality：{item.TargetQuality} Position:{item.Position} 的升级消耗");
			}
			else
			{
				dictionary[(item.TargetQuality, item.Position)] = item;
			}
		}
		for (ItemQuality itemQuality = ItemQuality.Blue; itemQuality <= ItemQuality.Red; itemQuality++)
		{
			EquipPosition equipPosition = EquipPosition.Head;
			while ((int)equipPosition <= 8)
			{
				if (IsArmor(equipPosition) && !dictionary.TryGetValue((itemQuality, equipPosition), out var _))
				{
					AddValidateLog($"在ArmorEnhanceConsumeDesc中，缺少TargetQuality：{itemQuality} Position:{equipPosition} 的配置");
				}
				equipPosition++;
			}
		}
	}

	public static void CheckEquipSeriesDesc()
	{
		TBEquipSeriesDesc tBEquipSeriesDesc = GetTBEquipSeriesDesc();
		Dictionary<int, int> dictionary = new Dictionary<int, int>();
		foreach (EquipSeriesDesc item in tBEquipSeriesDesc.List)
		{
			foreach (int equipId in item.EquipIdList)
			{
				if (dictionary.ContainsKey(equipId))
				{
					AddValidateLog($"在EquipSeriesDesc中，SeriesId:{dictionary[equipId]} EquipId:{equipId}  出现在别的系列中:{item.Id}");
				}
				else
				{
					dictionary[equipId] = item.Id;
				}
			}
		}
	}

	private static void BFSWeaponTree(WeaponTreeNode Root)
	{
		Queue<WeaponTreeNode> queue = new Queue<WeaponTreeNode>();
		queue.Enqueue(Root);
		while (queue.Count > 0)
		{
			WeaponTreeNode weaponTreeNode = queue.Dequeue();
			if (weaponTreeNode.weaponBuildDesc.HiddenByDefault == YesNoType.No)
			{
				AddValidateLog($"WeaponBuildDesc中，Id:{weaponTreeNode.weaponBuildDesc.Id} HiddenByDefault应该被设置为Yes");
			}
			foreach (WeaponTreeNode childNode in weaponTreeNode.childNodes)
			{
				queue.Enqueue(childNode);
			}
		}
	}

	public static void CheckWeaponBuildHidenRule()
	{
		foreach (WeaponBuildDesc item in GetTBWeaponBuildDesc().List)
		{
			if (item.HiddenByDefault == YesNoType.Yes)
			{
				BFSWeaponTree(GetWeaponTreeNode(item.Id));
			}
		}
	}

	public static int GetMantraSlotNumByEquipQuality(ItemQuality ItemQuality)
	{
		return ItemQuality switch
		{
			ItemQuality.Grey => 0, 
			ItemQuality.Green => 1, 
			ItemQuality.Blue => 2, 
			ItemQuality.Purple => 3, 
			ItemQuality.Orange => 4, 
			ItemQuality.Red => 5, 
			_ => 0, 
		};
	}

	public static MantraWeightDesc GetMantraWeightDescByLuckyValue(int LuckyValue)
	{
		foreach (MantraWeightDesc item in GetTBMantraWeightDesc().List)
		{
			if (item.LuckValueMax == 0 && item.LuckValueMin <= LuckyValue)
			{
				return item;
			}
			if (item.LuckValueMin <= LuckyValue && LuckyValue <= item.LuckValueMax)
			{
				return item;
			}
		}
		return null;
	}

	public static int GetWeightByItemQuality(ItemQuality Quality, MantraWeightDesc MantraWeightDesc)
	{
		return Quality switch
		{
			ItemQuality.Grey => MantraWeightDesc.GreyMantraWeight, 
			ItemQuality.Green => MantraWeightDesc.GreenMantraWeight, 
			ItemQuality.Blue => MantraWeightDesc.BlueMantraWeight, 
			ItemQuality.Purple => MantraWeightDesc.PurpleMantraWeight, 
			ItemQuality.Orange => MantraWeightDesc.OrangeMantraWeight, 
			ItemQuality.Red => MantraWeightDesc.RedMantraWeight, 
			_ => 0, 
		};
	}

	public static List<int> GetMantrasByQualityPositionAndType(ItemQuality Quality, EquipPosition Position, List<MantraType> MantraTypes)
	{
		List<int> list = new List<int>();
		foreach (MantraDesc item in GetTBMantraDesc().List)
		{
			if (item.Quality == Quality && item.Position == Position && MantraTypes.Contains(item.Type))
			{
				list.Add(item.Id);
			}
		}
		return list;
	}

	public static ItemQuality GetMantraQualityByLuckyValue(int LuckyValue, bool CanGenRedMantra)
	{
		MantraWeightDesc MantraWeightDesc = GetMantraWeightDescByLuckyValue(LuckyValue);
		List<ItemQuality> list = new List<ItemQuality>();
		for (int i = 1; i <= 5; i++)
		{
			list.Add((ItemQuality)i);
		}
		if (CanGenRedMantra)
		{
			list.Add(ItemQuality.Red);
		}
		return RandomUtil.RangeOneByWeight(list, (ItemQuality Quality) => GetWeightByItemQuality(Quality, MantraWeightDesc));
	}

	public static List<MantraType> IntMantraTypeConfig2List(int MantraTypeConfig)
	{
		List<MantraType> list = new List<MantraType>();
		while (MantraTypeConfig > 0)
		{
			list.Add((MantraType)(MantraTypeConfig % 10));
			MantraTypeConfig /= 10;
		}
		return list;
	}

	public static void BuildEquipId2SeriesId()
	{
		ArmorID2SeriesIdDict.Clear();
		foreach (EquipSeriesDesc item in GetTBEquipSeriesDesc().List)
		{
			foreach (int equipId in item.EquipIdList)
			{
				ArmorID2SeriesIdDict[equipId] = item.Id;
			}
		}
	}

	public static void BuildSeedCollectinoAwardList()
	{
		SeedCollectionAwardList.Clear();
		foreach (SeedCollectionAwardDesc item in GetTBSeedCollectionAwardDesc().List)
		{
			SeedCollectionAwardList.Add(item);
		}
		SeedCollectionAwardList.Sort((SeedCollectionAwardDesc x, SeedCollectionAwardDesc y) => x.CollectNum.CompareTo(y.CollectNum));
	}

	public static void BuildWeaponKeyItemToEquipIdDict()
	{
		WeaponKeyItemToEquidIdDict.Clear();
		foreach (WeaponBuildDesc item in GetTBWeaponBuildDesc().List)
		{
			foreach (ItemOne keyItem in item.KeyItemList)
			{
				int id = keyItem.Id;
				if (!WeaponKeyItemToEquidIdDict.ContainsKey(id))
				{
					WeaponKeyItemToEquidIdDict.Add(id, new List<int>());
				}
				if (!WeaponKeyItemToEquidIdDict[id].Contains(item.Id))
				{
					WeaponKeyItemToEquidIdDict[id].Add(item.Id);
				}
			}
		}
	}

	public static void BuildWeaponIdToRootIdDict()
	{
		WeaponIdToRootIdDict.Clear();
		foreach (WeaponBuildDesc item in GetTBWeaponBuildDesc().List)
		{
			WeaponIdToRootIdDict.Add(item.Id, GetRootWeaponId(item.Id));
		}
	}

	public static void BuildAchievementRequiredIdToAchievementIdDict()
	{
		AchievementRequiredIdToAchievementIdDict.Clear();
		AchievementRequiredGuidToAchievementIdDitc.Clear();
		foreach (AchievementDesc item in GetTBAchievementDesc().List)
		{
			if (item.RequirementType == AchievementUnlockRequirement.ProgressKillGuid)
			{
				foreach (string item2 in item.RequirementGuid)
				{
					if (AchievementRequiredGuidToAchievementIdDitc.TryGetValue((item.RequirementType, item2), out var value))
					{
						value.Add(item.Id);
						continue;
					}
					List<int> value2 = new List<int> { item.Id };
					AchievementRequiredGuidToAchievementIdDitc.Add((item.RequirementType, item2), value2);
				}
				continue;
			}
			foreach (int item3 in item.RequirementId)
			{
				if (AchievementRequiredIdToAchievementIdDict.TryGetValue((item.RequirementType, item3), out var value3))
				{
					value3.Add(item.Id);
					continue;
				}
				List<int> value4 = new List<int> { item.Id };
				AchievementRequiredIdToAchievementIdDict.Add((item.RequirementType, item3), value4);
			}
		}
	}

	public static void BuildTaskStageId2SurpriseDescDict()
	{
		TaskStage2SurpriseDescDict.Clear();
		foreach (SurpriseDesc item in GetTBSurpriseDesc().List)
		{
			if (TaskStage2SurpriseDescDict.TryGetValue((item.TaskStageId, item.Stage), out var value))
			{
				value.Add(item);
				continue;
			}
			TaskStage2SurpriseDescDict.Add((item.TaskStageId, item.Stage), new List<SurpriseDesc> { item });
		}
	}

	public static void BuildOrderedMedicineDescList()
	{
		OrderedMedicineAwardList = (from Desc in GetTBMedicineAwardDesc().List
			orderby Desc.TaskStageId
			orderby Desc.NewGamePlusCount
			select Desc).ToList();
		for (int num = 0; num < OrderedMedicineAwardList.Count; num++)
		{
			SysLogUtil.AARON_DEBUG.LogInfo($"DropId:{OrderedMedicineAwardList[num].DropId} TaskStageId:{OrderedMedicineAwardList[num].TaskStageId} NewGamePlusCount:{OrderedMedicineAwardList[num].NewGamePlusCount}");
		}
	}

	public static List<int> GetAssociativeAchievements(AchievementUnlockRequirement RequirementType, int ConditionId)
	{
		if (AchievementRequiredIdToAchievementIdDict.TryGetValue((RequirementType, ConditionId), out var value))
		{
			return value;
		}
		return null;
	}

	public static List<int> GetAssociativeAchievements(AchievementUnlockRequirement RequirementType, string ConditionId)
	{
		if (AchievementRequiredGuidToAchievementIdDitc.TryGetValue((RequirementType, ConditionId), out var value))
		{
			return value;
		}
		return null;
	}

	public static List<int> GetKeyItemAssociateWeapon(int KeyItemId)
	{
		if (WeaponKeyItemToEquidIdDict.TryGetValue(KeyItemId, out var value))
		{
			return value;
		}
		return null;
	}

	public static List<SeedCollectionAwardDesc> GetSeedCollectionAwardList()
	{
		return SeedCollectionAwardList;
	}

	public static int GetArmorSeriesId(int EquipId)
	{
		if (ArmorID2SeriesIdDict.TryGetValue(EquipId, out var value))
		{
			return value;
		}
		return 0;
	}

	public static int GetWeaponSeriesId(int EquipId)
	{
		return GetWeaponBuildDesc(EquipId)?.SeriesId ?? 0;
	}

	public static int GetArmorNextId(int ArmorId)
	{
		if (ArmorID2SeriesIdDict.TryGetValue(ArmorId, out var value))
		{
			EquipSeriesDesc equipSeriesDesc = GetEquipSeriesDesc(value);
			for (int i = 0; i < equipSeriesDesc.EquipIdList.Count; i++)
			{
				if (equipSeriesDesc.EquipIdList[i] == ArmorId && i != equipSeriesDesc.EquipIdList.Count - 1)
				{
					return equipSeriesDesc.EquipIdList[i + 1];
				}
			}
		}
		return 0;
	}

	public static List<int> GetArmorIdList(int ArmorId)
	{
		if (ArmorID2SeriesIdDict.TryGetValue(ArmorId, out var value))
		{
			EquipSeriesDesc equipSeriesDesc = GetEquipSeriesDesc(value);
			if (equipSeriesDesc != null)
			{
				return equipSeriesDesc.EquipIdList.ToList();
			}
		}
		return new List<int>();
	}

	public static bool IsArmorEnhance(int ArmorId)
	{
		return ArmorID2SeriesIdDict.ContainsKey(ArmorId);
	}

	public static void CheckServerErrorTips()
	{
		foreach (int value in Enum.GetValues(typeof(MsgErrCode)))
		{
			if (value != 0)
			{
				CommonErrorUITipsDesc commonErrorUITipsDesc = GetCommonErrorUITipsDesc(ECommonErrorType.Server, value);
				if (commonErrorUITipsDesc == null || string.IsNullOrEmpty(commonErrorUITipsDesc.ErrorTips))
				{
					AddValidateLog($"错误码【{value}】【{(MsgErrCode)value}】没有配置对应的错误提示语", "arrondu,jiangshaowei");
				}
			}
		}
	}

	public static void CheckArchiveErrorTips()
	{
		foreach (int value in Enum.GetValues(typeof(ReadArchiveResult)))
		{
			if (value != 0)
			{
				CommonErrorUITipsDesc commonErrorUITipsDesc = GetCommonErrorUITipsDesc(ECommonErrorType.Archive, value);
				if (commonErrorUITipsDesc == null || string.IsNullOrEmpty(commonErrorUITipsDesc.ErrorTips))
				{
					AddValidateLog($"错误码【{value}】【{(ReadArchiveResult)value}】没有配置对应的错误提示语", "arrondu,jiangshaowei");
				}
			}
		}
	}

	private static void BuildGuideNode2Group()
	{
		GuideNode2Group = new Dictionary<int, FUStGuideGroupDesc>();
		foreach (FUStGuideGroupDesc value in GetTBFUStGuideGroupDesc().Values)
		{
			foreach (int item in value.GuideId)
			{
				if (!GuideNode2Group.ContainsKey(item))
				{
					GuideNode2Group.Add(item, value);
				}
			}
		}
	}

	public static FUStGuideGroupDesc GetGuideGroupDescByNodeId(int Id)
	{
		if (GuideNode2Group.TryGetValue(Id, out var value))
		{
			return value;
		}
		return null;
	}

	public static FUStGuideGroupDesc GetGuideGroupDesc(int Id)
	{
		GetTBFUStGuideGroupDesc().TryGetValue(Id, out var value);
		return value;
	}

	public static FUStGuideNodeDesc GetGuideNodeDesc(int Id)
	{
		GetTBFUStGuideNodeDesc().TryGetValue(Id, out var value);
		return value;
	}

	public static int GetAlchemyNpcCommunicationAward(List<int> FinishedTaskStageIdList, int NewGamePlusCount)
	{
		for (int num = OrderedMedicineAwardList.Count - 1; num >= 0; num--)
		{
			if (FinishedTaskStageIdList.Contains(OrderedMedicineAwardList[num].TaskStageId) && NewGamePlusCount >= OrderedMedicineAwardList[num].NewGamePlusCount)
			{
				return OrderedMedicineAwardList[num].DropId;
			}
		}
		return 0;
	}

	public static bool IsRootEquip(int EquipId)
	{
		WeaponBuildDesc weaponBuildDesc = GetWeaponBuildDesc(EquipId);
		if (weaponBuildDesc != null)
		{
			return weaponBuildDesc.RequireWeapon == 0;
		}
		return false;
	}

	private static int GetIncreaseCountFromDesc(IncreaseConfigDesc IncreaseDesc, int IncreaseCount)
	{
		if (IncreaseDesc.Count.Count <= 1)
		{
			BGW_LogUtil.LogError($"IncreaseConfigListCount Invalid, ConfigId:{IncreaseDesc.Id}, ConfigListCount:{IncreaseDesc.Count.Count}");
			return -1;
		}
		if (IncreaseCount < 1)
		{
			BGW_LogUtil.LogError($"Invalid IncreaseCount:{IncreaseCount}");
			return -1;
		}
		if (IncreaseCount > IncreaseDesc.Count.Count - 1)
		{
			IncreaseCount = IncreaseDesc.Count.Count - 1;
		}
		return IncreaseDesc.Count[IncreaseCount].Value;
	}

	public static int GetIncreaseCountBySpecifyValue(int ConfigId, int IndexValue)
	{
		IncreaseConfigDesc increaseConfigDesc = GetIncreaseConfigDesc(ConfigId);
		if (increaseConfigDesc == null)
		{
			BGW_LogUtil.LogError($"IncreaseConfig Error, ConfigId:{ConfigId}");
			return -1;
		}
		return GetIncreaseCountFromDesc(increaseConfigDesc, IndexValue);
	}

	public static int GetIncreaseCountBySpecifyValue(IncreaseConfigId ConfigId, int IndexValue)
	{
		return GetIncreaseCountBySpecifyValue((int)ConfigId, IndexValue);
	}

	public static int GetIncreaseCountByRoleData(int ConfigId, int PlayerLevel, int GameCount)
	{
		IncreaseConfigDesc increaseConfigDesc = GetIncreaseConfigDesc(ConfigId);
		if (increaseConfigDesc == null)
		{
			BGW_LogUtil.LogError($"IncreaseConfig Error, ConfigId:{ConfigId}");
			return -1;
		}
		int num = 0;
		if (increaseConfigDesc.Type == IncreaseType.Level)
		{
			num = PlayerLevel;
		}
		else
		{
			if (increaseConfigDesc.Type != IncreaseType.GameCount)
			{
				BGW_LogUtil.LogError($"Invalid ConfigId:{ConfigId} for player!");
				return -1;
			}
			num = GameCount;
		}
		return GetIncreaseCountFromDesc(increaseConfigDesc, num);
	}

	public static void CheckSoulSkillDropDesc()
	{
		string toBlame = "hasa";
		Dictionary<int, Tuple<int, int>> dictionary = new Dictionary<int, Tuple<int, int>>();
		TBSoulSkillDropDesc tBSoulSkillDropDesc = GetTBSoulSkillDropDesc();
		for (int i = 0; i < tBSoulSkillDropDesc.List.Count; i++)
		{
			SoulSkillDropDesc soulSkillDropDesc = tBSoulSkillDropDesc.List[i];
			if (GetSoulSkillDesc(soulSkillDropDesc.SoulSkillId) == null)
			{
				AddValidateLog($"SoulSkillDropDesc.Id:{soulSkillDropDesc.Id} SoulSkillId:{soulSkillDropDesc.SoulSkillId}未在SoulSkillDesc找到对应配置", toBlame);
			}
			else if (!IsRootSoulSkill(soulSkillDropDesc.SoulSkillId))
			{
				AddValidateLog($"SoulSkillDropDesc.Id:{soulSkillDropDesc.Id} 掉落精魂Id SoulSkillId:{soulSkillDropDesc.SoulSkillId}为高等级精魂ID，高等级精魂ID不能直接掉落", toBlame);
			}
			if (soulSkillDropDesc.SafeDropMaxTimes < soulSkillDropDesc.SafeDropStartTimes)
			{
				AddValidateLog($"SoulSkillDropDesc.Id:{soulSkillDropDesc.Id} 保底次数:{soulSkillDropDesc.SafeDropMaxTimes} < 保底起始次数:{soulSkillDropDesc.SafeDropStartTimes}", toBlame);
			}
			if (dictionary.TryGetValue(soulSkillDropDesc.SoulSkillId, out var value))
			{
				if (soulSkillDropDesc.SafeDropStartTimes != value.Item1)
				{
					AddValidateLog($"SoulSkillDropDesc.Id:{soulSkillDropDesc.Id} SafeDropStartTimes(保底起始次数)配置值跟其他掉落规则不一致，检查精魂ID{soulSkillDropDesc.SoulSkillId}的其他掉落规则配置值！", toBlame);
				}
				if (soulSkillDropDesc.SafeDropMaxTimes != value.Item2)
				{
					AddValidateLog($"SoulSkillDropDesc.Id:{soulSkillDropDesc.Id} SafeDropMaxTimes(保底必掉次数)配置值跟其他掉落规则不一致，检查精魂ID{soulSkillDropDesc.SoulSkillId}的其他掉落规则配置值！", toBlame);
				}
			}
			else
			{
				dictionary.Add(soulSkillDropDesc.SoulSkillId, new Tuple<int, int>(soulSkillDropDesc.SafeDropStartTimes, soulSkillDropDesc.SafeDropMaxTimes));
			}
		}
	}

	public static void CheckSurpriseDesc()
	{
		string toBlame = "jasonwu";
		Dictionary<(int, QuestStage), SurpriseDesc> dictionary = new Dictionary<(int, QuestStage), SurpriseDesc>();
		foreach (SurpriseDesc item in GetTBSurpriseDesc().List)
		{
			if (dictionary.TryGetValue((item.TaskStageId, item.Stage), out var _))
			{
				AddValidateLog($"SurpriseDesc.Id:{item.Id} TaskStageId {item.TaskStageId}, Stage {item.Stage} 对应多个彩蛋", toBlame);
			}
			else
			{
				dictionary.Add((item.TaskStageId, item.Stage), item);
			}
		}
	}

	public static void CheckSeedDesc()
	{
		string toBlame = "chrisraines";
		HashSet<int> hashSet = new HashSet<int>();
		foreach (SeedDesc item in GetTBSeedDesc().List)
		{
			for (int i = 0; i < item.OutputList.Count; i++)
			{
				if (hashSet.Contains(item.OutputList[i].OutputItemId))
				{
					AddValidateLog($"SeedDesc.Id:{item.Id} OutputSeedDesc.OutputList[{i}]ItemId {item.OutputList[i].OutputItemId} 重复出现 不允许不同种子产出相同的作物", toBlame);
				}
				else
				{
					hashSet.Add(item.OutputList[i].OutputItemId);
				}
			}
		}
	}

	public static List<SurpriseDesc> GetSurpriseDescByTaskStageInfo(int TaskStageId, QuestStage Stage)
	{
		if (TaskStage2SurpriseDescDict.TryGetValue((TaskStageId, Stage), out var value))
		{
			return value;
		}
		return null;
	}

	public static List<PS5ActivityTaskDesc> GetTaskDescListByActivityId(int ActivityId)
	{
		List<PS5ActivityTaskDesc> list = new List<PS5ActivityTaskDesc>();
		foreach (PS5ActivityTaskDesc item in GetTBPS5ActivityTaskDesc().List)
		{
			if (item.ActivityId == ActivityId)
			{
				list.Add(item);
			}
		}
		return list;
	}

	public static List<int> GetTaskIdListByActivityId(int ActivityId)
	{
		List<int> list = new List<int>();
		foreach (PS5ActivityTaskDesc item in GetTBPS5ActivityTaskDesc().List)
		{
			if (item.ActivityId == ActivityId)
			{
				list.Add(item.Id);
			}
		}
		return list;
	}

	public static PS5ActivityTaskDesc GetPS5ActivityTaskDescByTaskStageId(int TaskStageId)
	{
		foreach (PS5ActivityTaskDesc item in GetTBPS5ActivityTaskDesc().List)
		{
			if (item.TaskStageId == TaskStageId)
			{
				return item;
			}
		}
		return null;
	}

	public static PS5ActivityTaskDesc GetPS5ActivityTaskDescByExtendId(int ExtendId)
	{
		foreach (PS5ActivityTaskDesc item in GetTBPS5ActivityTaskDesc().List)
		{
			if (item.ExtendId == ExtendId)
			{
				return item;
			}
		}
		return null;
	}

	public static int GetCollectionIdByResourceTypeAndId(ResourceType Type, int ResouceId)
	{
		if (Type == ResourceType.Aiconversation)
		{
			if (GetFUStAiConversationContentDesc(ResouceId) == null)
			{
				return -1;
			}
			foreach (EchoDesc item in GetTBEchoDesc().List)
			{
				if (item.AiConversationId == ResouceId)
				{
					return item.Id;
				}
			}
		}
		return -1;
	}

	public static void CheckUnitExtendDesc()
	{
		string toBlame = "hasa";
		foreach (FUStUnitBattleInfoExtendDesc value in GetTBFUStUnitBattleInfoExtendDesc().Values)
		{
			if (value.VigourDropId > 0 && GetSoulSkillDropDesc(value.VigourDropId) == null)
			{
				AddValidateLog($"UnitBattleInfoExtendDesc.Id:{value.ID} VigourDropId:{value.VigourDropId} 未在SoulSkillDropDesc找到对应配置", toBlame);
			}
		}
	}

	private static void CheckSoulSkillId(SoulSkillDesc SoulSkillDesc, int CheckSkillId, string CheckFieldName)
	{
		if (CheckSkillId > 0 && GetSoulSkillDesc(CheckSkillId) == null)
		{
			AddValidateLog($"SoulSkillDesc.Id:{SoulSkillDesc.Id} {CheckFieldName}:{CheckSkillId} 未在SoulSkillDesc里找到对应值", "charlie");
		}
	}

	private static void CheckSoulSkillDesc()
	{
		TBSoulSkillDesc tBSoulSkillDesc = GetTBSoulSkillDesc();
		for (int i = 0; i < tBSoulSkillDesc.List.Count; i++)
		{
			SoulSkillDesc soulSkillDesc = tBSoulSkillDesc.List[i];
			CheckSoulSkillId(soulSkillDesc, soulSkillDesc.ReuseModle, "ReuseModle");
			CheckSoulSkillId(soulSkillDesc, soulSkillDesc.ReuseSkillIcon, "ReuseSkillIcon");
			CheckSoulSkillId(soulSkillDesc, soulSkillDesc.ReuseSkillVideo, "ReuseSkillVideo");
			CheckSoulSkillId(soulSkillDesc, soulSkillDesc.UpgradeNextId, "UpgradeNextId");
			if (GetCommDropRuleDesc(soulSkillDesc.ReplaceDropId) == null)
			{
				AddValidateLog($"SoulSkillDesc.ReplaceDropId:{soulSkillDesc.ReplaceDropId} 未在CommDropRuleDesc找到对应配置值", "songjiajun");
			}
			if (soulSkillDesc.AttrEffectId > 0 && GetEquipAttrDesc(soulSkillDesc.AttrEffectId) == null)
			{
				AddValidateLog($"SoulSkillDesc.AttrEffectId:{soulSkillDesc.AttrEffectId} 未在EquipAttrDesc找到对应配置值", "jeffrey");
			}
			if (soulSkillDesc.EffectTalentId > 0)
			{
				TalentSDesc talentSDesc = GetTalentSDesc(soulSkillDesc.EffectTalentId);
				if (talentSDesc == null)
				{
					AddValidateLog($"SoulSkillDesc.EffectTalentId:{soulSkillDesc.EffectTalentId}未在 TalentSDesc找到对应配置值", "jeffrey");
				}
				if (talentSDesc.Type != TalentType.Suit)
				{
					AddValidateLog($"SoulSkillDesc.EffectTalentId:{soulSkillDesc.EffectTalentId}天赋类型不符合，必须为套装天赋", "jeffrey");
				}
			}
		}
	}

	private static void CheckAchievementDesc()
	{
		string toBlame = "chrisraines";
		foreach (AchievementDesc item in GetTBAchievementDesc().List)
		{
			if (item.RequirementType == AchievementUnlockRequirement.ProgressActivateTaskStage || item.RequirementType == AchievementUnlockRequirement.ProgressFinishTaskStage)
			{
				foreach (int item2 in item.RequirementId)
				{
					if (BGW_GameDB.GetTaskStageDesc(item2) == null)
					{
						AddValidateLog($"AchievementDesc.Id:{item.Id} RequiredId {item2} 未在TaskStageDesc里找到对应值", toBlame);
					}
				}
			}
			if (item.RequirementType == AchievementUnlockRequirement.ProgressGainEquip)
			{
				foreach (int item3 in item.RequirementId)
				{
					if (GetEquipDesc(item3) == null)
					{
						AddValidateLog($"AchievementDesc.Id:{item.Id} RequiredId {item3} 未在EquipDesc里找到对应值", toBlame);
					}
				}
			}
			if (item.RequirementType == AchievementUnlockRequirement.ProgressGainAllAttritem)
			{
				foreach (int item4 in item.RequirementId)
				{
					if (GetAttrItemDesc(item4) == null)
					{
						AddValidateLog($"AchievementDesc.Id:{item.Id} RequiredId {item4} 未在AttrItemDesc里找到对应值", toBlame);
					}
				}
			}
			if (item.RequirementType == AchievementUnlockRequirement.ProgressGainWine)
			{
				foreach (int item5 in item.RequirementId)
				{
					if (GetWineDesc(item5) == null)
					{
						AddValidateLog($"AchievementDesc.Id:{item.Id} RequiredId {item5} 未在WineDesc里找到对应值", toBlame);
					}
				}
			}
			if (item.RequirementType == AchievementUnlockRequirement.ProgressGainItem)
			{
				foreach (int item6 in item.RequirementId)
				{
					if (GetItemDesc(item6) == null)
					{
						AddValidateLog($"AchievementDesc.Id:{item.Id} RequiredId {item6} 未在ItemDesc里找到对应值", toBlame);
					}
				}
			}
			if (item.RequirementType == AchievementUnlockRequirement.ProgressGainSpell)
			{
				foreach (int item7 in item.RequirementId)
				{
					if (GetSpellDesc(item7) == null)
					{
						AddValidateLog($"AchievementDesc.Id:{item.Id} RequiredId {item7} 未在SpellDesc里找到对应值", toBlame);
					}
				}
			}
			if (item.RequirementType == AchievementUnlockRequirement.ProgressGainLegacy)
			{
				foreach (int item8 in item.RequirementId)
				{
					if (GetItemDesc(item8) == null)
					{
						AddValidateLog($"AchievementDesc.Id:{item.Id} RequiredId {item8} 未在ItemDesc里找到对应值", toBlame);
					}
				}
			}
			if (item.RequirementType == AchievementUnlockRequirement.ProgressGainSoulSkill)
			{
				foreach (int item9 in item.RequirementId)
				{
					if (GetSoulSkillDesc(item9) == null)
					{
						AddValidateLog($"AchievementDesc.Id:{item.Id} RequiredId {item9} 未在SoulSkillDesc里找到对应值", toBlame);
					}
				}
			}
			if (item.RequirementType == AchievementUnlockRequirement.ProgressUnlockCard)
			{
				foreach (int item10 in item.RequirementId)
				{
					if (GetCardDesc(item10) == null)
					{
						AddValidateLog($"AchievementDesc.Id:{item.Id} RequiredId {item10} 未在CardDesc里找到对应值", toBlame);
					}
				}
			}
			if (item.RequirementType == AchievementUnlockRequirement.ProgressKillUnit)
			{
				foreach (int item11 in item.RequirementId)
				{
					if (BGW_GameDB.GetUnitBattleInfoExtendDesc(item11) == null)
					{
						AddValidateLog($"AchievementDesc.Id:{item.Id} RequiredId {item11} 未在UnitBattleInfoExtend里找到对应值", toBlame);
					}
				}
			}
			if (item.RequirementType == AchievementUnlockRequirement.ProgressEnterMap)
			{
				foreach (int item12 in item.RequirementId)
				{
					if (GetLevelDesc(item12) == null)
					{
						AddValidateLog($"AchievementDesc.Id:{item.Id} RequiredId {item12} 未在LevlDesc里找到对应值", toBlame);
					}
				}
			}
			if (item.RequirementType == AchievementUnlockRequirement.ProgressAchievementComplete)
			{
				if (item.IsProgress == YesNoType.Yes)
				{
					AddValidateLog($"AchievementDesc.Id:{item.Id} IsProgress 应该设置为No ", toBlame);
				}
				foreach (int item13 in item.RequirementId)
				{
					AchievementDesc achievementDesc = GetAchievementDesc(item13);
					if (achievementDesc == null)
					{
						AddValidateLog($"AchievementDesc.Id:{item.Id} RequiredId {item13} 未在AchievementDesc里找到对应值", toBlame);
					}
					else if (item.IsResetOnGameplus == YesNoType.Yes && achievementDesc.IsResetOnGameplus != YesNoType.Yes)
					{
						AddValidateLog($"AchievementDesc.Id:{item13} IsResetOnGameplus 应该设置为Yes ", toBlame);
					}
				}
			}
			if (item.RequirementType != AchievementUnlockRequirement.ProgressUnlockMeditation)
			{
				continue;
			}
			foreach (int item14 in item.RequirementId)
			{
				if (GetMeditationPointDesc(item14) == null)
				{
					AddValidateLog($"AchievementDesc.Id:{item.Id} RequiredId {item14} 未在MeditationPointDesc里找到对应值", toBlame);
				}
			}
		}
	}

	private static void CheckPS5ActivityTaskDesc()
	{
		string toBlame = "chrisraines";
		TBPS5ActivityTaskDesc tBPS5ActivityTaskDesc = GetTBPS5ActivityTaskDesc();
		List<int> list = new List<int>();
		foreach (PS5ActivityTaskDesc item in tBPS5ActivityTaskDesc.List)
		{
			if (list.Contains(item.ExtendId))
			{
				AddValidateLog($"PS5ActivityTaskDesc.ExtendId:{item.ExtendId} 对应了多个PS5ActivityTask", toBlame);
			}
			else if (item.ExtendId != 0)
			{
				list.Add(item.ExtendId);
			}
			if (item.ExtendId != 0 && BGW_GameDB.GetUnitBattleInfoExtendDesc(item.ExtendId) == null)
			{
				AddValidateLog($"PS5ActivityTaskDesc.Id:{item.Id} PS5AcvityTaskDesc.ResId:{item.ExtendId} 不在UnitComm表中", toBlame);
			}
		}
	}

	public static void BuildSoulSkillUpgradeTree()
	{
		CommUpgradeNode<SoulSkillDesc>.InitBuildCommNodeTree((int ResId) => GetSoulSkillDesc(ResId), () => GetTBSoulSkillDesc().List.ToList(), (SoulSkillDesc SoulSkillDesc) => SoulSkillDesc.Id, (SoulSkillDesc SoulSkillDesc) => SoulSkillDesc.UpgradeNextId);
	}

	public static int GetSoulSkillRootId(int SoulSkillId)
	{
		return CommUpgradeNode<SoulSkillDesc>.GetNodeById(SoulSkillId)?.RootId ?? (-1);
	}

	public static CommUpgradeNode<SoulSkillDesc> GetSoulSkillNode(int SoulSkillId)
	{
		return CommUpgradeNode<SoulSkillDesc>.GetNodeById(SoulSkillId);
	}

	public static bool IsRootSoulSkill(int SoulSkillId)
	{
		return GetSoulSkillNode(SoulSkillId)?.IsRootNode ?? false;
	}

	public static int GetSoulSkillReplaceDropId(int SoulSkillId)
	{
		return GetSoulSkillDesc(SoulSkillId)?.ReplaceDropId ?? (-1);
	}

	public static void BuildSoulSkillDropDesc()
	{
		SoulSkillExtendDescDict.Clear();
		foreach (FUStUnitBattleInfoExtendDesc value in BGW_GameDB.GetAllUnitBattleInfoExtendDesc().Values)
		{
			if (value.VigourDropId > 0)
			{
				SoulSkillDropDesc soulSkillDropDesc = GetSoulSkillDropDesc(value.VigourDropId);
				if (soulSkillDropDesc != null)
				{
					SoulSkillExtendDescDict[soulSkillDropDesc.SoulSkillId] = value;
				}
			}
		}
	}

	public static FUStUnitBattleInfoExtendDesc GetSoulSkillDropUnitExtendInfoDesc(int SoulSkillId)
	{
		if (SoulSkillExtendDescDict.TryGetValue(SoulSkillId, out var value))
		{
			return value;
		}
		return null;
	}

	public static void BuildCricketBattleUnitDescDict()
	{
		CricketBattleUnitDescDict.Clear();
		foreach (CricketBattleUnitDesc item in GetTBCricketBattleUnitDesc().List)
		{
			if (!CricketBattleUnitDescDict.ContainsKey(item.ExtentBattleId))
			{
				CricketBattleUnitDescDict.Add(item.ExtentBattleId, item);
			}
		}
	}

	public static void BuildCricketUnitAttrDescDict()
	{
		CricketUnitAttrDescDict.Clear();
		foreach (CricketUnitAttrDesc item in GetTBCricketUnitAttrDesc().List)
		{
			if (!CricketUnitAttrDescDict.ContainsKey(item.ExtentBattleId))
			{
				CricketUnitAttrDescDict.Add(item.ExtentBattleId, item);
			}
		}
	}

	public static CricketBattleUnitDesc GetCricketBattleUnitDescByExtendId(int ExtenId)
	{
		if (CricketBattleUnitDescDict.ContainsKey(ExtenId))
		{
			return CricketBattleUnitDescDict[ExtenId];
		}
		return null;
	}

	public static List<(int, ItemRecipeDesc)> GetRebuildAttrItemList()
	{
		List<(int, ItemRecipeDesc)> list = new List<(int, ItemRecipeDesc)>();
		foreach (KeyValuePair<int, ItemRecipeDesc> item in AttrItemRecipeIdDict)
		{
			list.Add((item.Key, item.Value));
		}
		return list;
	}

	public static int GetPropStanceUnlockTalent()
	{
		return GetCommLogicCfgDesc(4)?.Value ?? 0;
	}

	public static int GetPokeStanceUnlockTalent()
	{
		return GetCommLogicCfgDesc(5)?.Value ?? 0;
	}

	public static int GetStanceRequireTalentId(Stance stance)
	{
		return stance switch
		{
			Stance.Prop => GetPropStanceUnlockTalent(), 
			Stance.Poke => GetPokeStanceUnlockTalent(), 
			_ => 0, 
		};
	}

	public static int CheckLogicCommDesc()
	{
		foreach (CommCfgType value in Enum.GetValues(typeof(CommCfgType)))
		{
			switch (value)
			{
			case CommCfgType.XuehouBattleEndRebirthpointid:
			{
				int commLogicCfgValue30 = GetCommLogicCfgValue(CommCfgType.XuehouBattleEndRebirthpointid);
				if (BGW_GameDB.GetRebirthPointDesc(commLogicCfgValue30) == null)
				{
					AddValidateLog($"CommLogicCfgDesc.Type:{CommCfgType.XuehouBattleEndRebirthpointid} 配置土地庙ID：{commLogicCfgValue30}未在RebirthPointDesc找到对应值", "");
				}
				break;
			}
			case CommCfgType.FtxdBattleEndRebirthpointid:
			{
				int commLogicCfgValue14 = GetCommLogicCfgValue(CommCfgType.FtxdBattleEndRebirthpointid);
				if (BGW_GameDB.GetRebirthPointDesc(commLogicCfgValue14) == null)
				{
					AddValidateLog($"CommLogicCfgDesc.Type:{CommCfgType.FtxdBattleEndRebirthpointid} 配置土地庙ID：{commLogicCfgValue14}未在RebirthPointDesc找到对应值", "");
				}
				break;
			}
			case CommCfgType.GameLevelPassRebirthPointId:
			{
				int commLogicCfgValue22 = GetCommLogicCfgValue(CommCfgType.GameLevelPassRebirthPointId);
				if (BGW_GameDB.GetRebirthPointDesc(commLogicCfgValue22) == null)
				{
					AddValidateLog($"CommLogicCfgDesc.Type:{CommCfgType.GameLevelPassRebirthPointId} 配置土地庙ID：{commLogicCfgValue22}未在RebirthPointDesc找到对应值", "");
				}
				break;
			}
			case CommCfgType.PlayerDefaultResid:
			{
				int commLogicCfgValue6 = GetCommLogicCfgValue(CommCfgType.PlayerDefaultResid);
				if (BGW_GameDB.GetUnitCommDesc(commLogicCfgValue6) == null)
				{
					AddValidateLog($"CommLogicCfgDesc.Type:{CommCfgType.PlayerDefaultResid} 配置RES ID：{commLogicCfgValue6}未在UnitCommDesc找到对应值", "");
				}
				break;
			}
			case CommCfgType.XuehouDefaultResid:
			{
				int commLogicCfgValue26 = GetCommLogicCfgValue(CommCfgType.XuehouDefaultResid);
				if (BGW_GameDB.GetUnitCommDesc(commLogicCfgValue26) == null)
				{
					AddValidateLog($"CommLogicCfgDesc.Type:{CommCfgType.XuehouDefaultResid} 配置RES ID：{commLogicCfgValue26}未在UnitCommDesc找到对应值", "");
				}
				break;
			}
			case CommCfgType.PlayerDefaultBattleinfoextendid:
			{
				int commLogicCfgValue18 = GetCommLogicCfgValue(CommCfgType.PlayerDefaultBattleinfoextendid);
				if (BGW_GameDB.GetUnitBattleInfoExtendDesc(commLogicCfgValue18) == null)
				{
					AddValidateLog($"CommLogicCfgDesc.Type:{CommCfgType.PlayerDefaultBattleinfoextendid} 配置RES ID：{commLogicCfgValue18}未在UnitCommDesc找到对应值", "");
				}
				break;
			}
			case CommCfgType.OnelineDifficultBuffId:
			{
				int commLogicCfgValue10 = GetCommLogicCfgValue(CommCfgType.OnelineDifficultBuffId);
				if (BGW_GameDB.GetOriginalBuffDesc(commLogicCfgValue10) == null)
				{
					AddValidateLog($"CommLogicCfgDesc.Type:{CommCfgType.OnelineDifficultBuffId} 配置Buff ID：{commLogicCfgValue10}未在FUStBuffDesc找到对应值", "");
				}
				break;
			}
			case CommCfgType.DashenDefaultEquipConfigId:
			{
				int commLogicCfgValue2 = GetCommLogicCfgValue(CommCfgType.DashenDefaultEquipConfigId);
				if (GetRoleDataConfigByType(commLogicCfgValue2) == null)
				{
					AddValidateLog($"CommLogicCfgDesc.Type:{CommCfgType.DashenDefaultEquipConfigId} 配置ID：{commLogicCfgValue2}未在RoleDataConfigDesc找到对应值", "");
				}
				break;
			}
			case CommCfgType.PokeStance:
			{
				int commLogicCfgValue28 = GetCommLogicCfgValue(CommCfgType.PokeStance);
				if (GetTalentSDesc(commLogicCfgValue28) == null)
				{
					AddValidateLog($"CommLogicCfgDesc.Type:{CommCfgType.PokeStance} 配置天赋ID：{commLogicCfgValue28}未在TalentSDesc找到对应值", "feilo");
				}
				break;
			}
			case CommCfgType.PropStance:
			{
				int commLogicCfgValue24 = GetCommLogicCfgValue(CommCfgType.PropStance);
				if (GetTalentSDesc(commLogicCfgValue24) == null)
				{
					AddValidateLog($"CommLogicCfgDesc.Type:{CommCfgType.PropStance} 配置天赋ID：{commLogicCfgValue24}未在TalentSDesc找到对应值", "feilo");
				}
				break;
			}
			case CommCfgType.DefaultChapterId:
			{
				int commLogicCfgValue20 = GetCommLogicCfgValue(CommCfgType.DefaultChapterId);
				if (GetChapterDesc(commLogicCfgValue20) == null)
				{
					AddValidateLog($"CommLogicCfgDesc.Type:{CommCfgType.DefaultChapterId} 配置默认章节ID：{commLogicCfgValue20}未在ChapterDesc找到对应值", "jasonwu");
				}
				break;
			}
			case CommCfgType.DashenDefaultResid:
			{
				int commLogicCfgValue16 = GetCommLogicCfgValue(CommCfgType.DashenDefaultResid);
				if (BGW_GameDB.GetUnitCommDesc(commLogicCfgValue16) == null)
				{
					AddValidateLog($"CommLogicCfgDesc.Type:{CommCfgType.DashenDefaultResid} 配置大圣默认ResID：{commLogicCfgValue16}未在UnitCommDesc找到对应值", "");
				}
				break;
			}
			case CommCfgType.NewGamePlugGainLegacyId:
			{
				int commLogicCfgValue12 = GetCommLogicCfgValue(CommCfgType.NewGamePlugGainLegacyId);
				if (GetItemDesc(commLogicCfgValue12) == null)
				{
					AddValidateLog($"CommLogicCfgDesc.Type:{CommCfgType.NewGamePlugGainLegacyId} 配置多周目获得大圣之意根器ID：{commLogicCfgValue12}未在ItemDesc找到对应值", "Charlie");
				}
				break;
			}
			case CommCfgType.NewGamePlugGainSpellId:
			{
				int commLogicCfgValue8 = GetCommLogicCfgValue(CommCfgType.NewGamePlugGainSpellId);
				if (GetSpellDesc(commLogicCfgValue8) == null)
				{
					AddValidateLog($"CommLogicCfgDesc.Type:{CommCfgType.NewGamePlugGainSpellId} 配置多周目获得救命毫毛法术ID：{commLogicCfgValue8}未在SpellDesc找到对应值", "Charlie");
				}
				break;
			}
			case CommCfgType.NewGamePlugGainDashenCardId:
			{
				int commLogicCfgValue4 = GetCommLogicCfgValue(CommCfgType.NewGamePlugGainDashenCardId);
				if (GetCardDesc(commLogicCfgValue4) == null)
				{
					AddValidateLog($"CommLogicCfgDesc.Type:{CommCfgType.NewGamePlugGainDashenCardId} 配置多周目获得齐天大圣图鉴ID：{commLogicCfgValue4}未在CardDesc找到对应值", "Charlie");
				}
				break;
			}
			case CommCfgType.NewGamePlugGainBaJieCardId:
			{
				int commLogicCfgValue31 = GetCommLogicCfgValue(CommCfgType.NewGamePlugGainBaJieCardId);
				if (GetCardDesc(commLogicCfgValue31) == null)
				{
					AddValidateLog($"CommLogicCfgDesc.Type:{CommCfgType.NewGamePlugGainBaJieCardId} 配置多周目获得八戒图鉴ID：{commLogicCfgValue31}未在CardDesc找到对应值", "Charlie");
				}
				break;
			}
			case CommCfgType.YuanShouChengCardId:
			{
				int commLogicCfgValue29 = GetCommLogicCfgValue(CommCfgType.YuanShouChengCardId);
				if (GetCardDesc(commLogicCfgValue29) == null)
				{
					AddValidateLog($"CommLogicCfgDesc.Type:{CommCfgType.YuanShouChengCardId} 配置袁守诚图鉴ID：{commLogicCfgValue29}未在CardDesc找到对应值");
				}
				break;
			}
			case CommCfgType.ProloguePs5TaskId:
			{
				int commLogicCfgValue27 = GetCommLogicCfgValue(CommCfgType.ProloguePs5TaskId);
				if (GetPS5ActivityTaskDesc(commLogicCfgValue27) == null)
				{
					AddValidateLog($"CommLogicCfgDesc.Type:{CommCfgType.ProloguePs5TaskId} 配置PS5序章任务ID：{commLogicCfgValue27}未在PS5ActivityTaskDesc找到对应值", "chrisraines");
				}
				break;
			}
			case CommCfgType.ProloguePs5ActivityId:
			{
				int commLogicCfgValue25 = GetCommLogicCfgValue(CommCfgType.ProloguePs5ActivityId);
				if (GetPS5ActivityDesc(commLogicCfgValue25) == null)
				{
					AddValidateLog($"CommLogicCfgDesc.Type:{CommCfgType.ProloguePs5ActivityId} 配置PS5序章活动ID：{commLogicCfgValue25}未在PS5ActivityDesc找到对应值", "chrisraines");
				}
				break;
			}
			case CommCfgType.DashenEarsTalentId:
			{
				int commLogicCfgValue23 = GetCommLogicCfgValue(CommCfgType.DashenEarsTalentId);
				if (GetTalentSDesc(commLogicCfgValue23) == null)
				{
					AddValidateLog($"CommLogicCfgDesc.Type:{CommCfgType.DashenEarsTalentId} 配置大圣之耳天赋Id：{commLogicCfgValue23}未在TalentSDesc找到对应值", "");
				}
				break;
			}
			case CommCfgType.JinDouYunItemId:
			{
				int commLogicCfgValue21 = GetCommLogicCfgValue(CommCfgType.JinDouYunItemId);
				if (GetItemDesc(commLogicCfgValue21) == null)
				{
					AddValidateLog($"CommLogicCfgDesc.Type:{CommCfgType.JinDouYunItemId} 配置筋斗云ItemId：{commLogicCfgValue21}未在ItemDesc找到对应值", "");
				}
				break;
			}
			case CommCfgType.FtxdDefaultResid:
			{
				int commLogicCfgValue19 = GetCommLogicCfgValue(CommCfgType.FtxdDefaultResid);
				if (BGW_GameDB.GetUnitCommDesc(commLogicCfgValue19) == null)
				{
					AddValidateLog($"CommLogicCfgDesc.Type:{CommCfgType.FtxdDefaultResid} 配置法天象地默认ResId：{commLogicCfgValue19}未在UnitCommDesc找到对应值", "");
				}
				break;
			}
			case CommCfgType.LastChapterId:
			{
				int commLogicCfgValue17 = GetCommLogicCfgValue(CommCfgType.LastChapterId);
				if (GetChapterDesc(commLogicCfgValue17) == null)
				{
					AddValidateLog($"CommLogicCfgDesc.Type:{CommCfgType.LastChapterId} 配置终章章节ID：{commLogicCfgValue17}未在ChapterDesc找到对应值", "");
				}
				break;
			}
			case CommCfgType.DashenEarsLegacyId:
			{
				int commLogicCfgValue15 = GetCommLogicCfgValue(CommCfgType.DashenEarsLegacyId);
				if (GetItemDesc(commLogicCfgValue15) == null)
				{
					AddValidateLog($"CommLogicCfgDesc.Type:{CommCfgType.DashenEarsLegacyId} 大圣之耳根器ID：{commLogicCfgValue15}未在ItemDesc找到对应值", "");
				}
				break;
			}
			case CommCfgType.NewGamePlugGainInteractFuncId:
			{
				int commLogicCfgValue13 = GetCommLogicCfgValue(CommCfgType.NewGamePlugGainInteractFuncId);
				if (GetInteractionFuncDesc(commLogicCfgValue13) == null)
				{
					AddValidateLog($"CommLogicCfgDesc.Type:{CommCfgType.NewGamePlugGainInteractFuncId} 多周目获得的交互功能ID：{commLogicCfgValue13}未在InteractionFuncDesc找到对应值", "");
				}
				break;
			}
			case CommCfgType.SoukBottleItemId:
			{
				int commLogicCfgValue11 = GetCommLogicCfgValue(CommCfgType.SoukBottleItemId);
				if (GetItemDesc(commLogicCfgValue11) == null)
				{
					AddValidateLog($"CommLogicCfgDesc.Type:{CommCfgType.SoukBottleItemId} 魂瓶ItemID：{commLogicCfgValue11}未在ItemDesc找到对应值", "");
				}
				break;
			}
			case CommCfgType.OnNewGamePlusDropId:
			{
				int commLogicCfgValue9 = GetCommLogicCfgValue(CommCfgType.OnNewGamePlusDropId);
				if (GetCommDropRuleDesc(commLogicCfgValue9) == null)
				{
					AddValidateLog($"CommLogicCfgDesc.Type:{CommCfgType.OnNewGamePlusDropId} 多周目物品掉落ID：{commLogicCfgValue9}未在CommDropRuleDesc找到对应值", "");
				}
				break;
			}
			case CommCfgType.MeditationReplaceAwardDropId:
			{
				int commLogicCfgValue7 = GetCommLogicCfgValue(CommCfgType.MeditationReplaceAwardDropId);
				if (GetCommDropRuleDesc(commLogicCfgValue7) == null)
				{
					AddValidateLog($"CommLogicCfgDesc.Type:{CommCfgType.MeditationReplaceAwardDropId} 打坐点道行掉落组ID:{commLogicCfgValue7}未在CommDropRuleDesc找到对应值", "charlie");
				}
				break;
			}
			case CommCfgType.EndingBTaskstageId:
			{
				int commLogicCfgValue5 = GetCommLogicCfgValue(CommCfgType.EndingBTaskstageId);
				if (GetFUStTaskStageDesc(commLogicCfgValue5) == null)
				{
					AddValidateLog($"CommLogicCfgDesc.Type:{CommCfgType.EndingBTaskstageId} 结局B任务阶段ID:{commLogicCfgValue5}未在TaskStageDesc找到对应值");
				}
				break;
			}
			case CommCfgType.RefightFuncid:
			{
				int commLogicCfgValue3 = GetCommLogicCfgValue(CommCfgType.RefightFuncid);
				if (GetInteractionFuncDesc(commLogicCfgValue3) == null)
				{
					AddValidateLog($"CommLogicCfgDesc.Type:{CommCfgType.RefightFuncid} 再战功能ID:{commLogicCfgValue3}未在InteractionFuncDesc找到对应值", "");
				}
				break;
			}
			case CommCfgType.ContinuousFightFuncid:
			{
				int commLogicCfgValue = GetCommLogicCfgValue(CommCfgType.ContinuousFightFuncid);
				if (GetInteractionFuncDesc(commLogicCfgValue) == null)
				{
					AddValidateLog($"CommLogicCfgDesc.Type:{CommCfgType.ContinuousFightFuncid} 连战功能ID：{commLogicCfgValue}未在InteractionFuncDesc找到对应值", "");
				}
				break;
			}
			default:
				AddValidateLog($"CommLogicCfgDesc.Type:{value} 没加表格校验");
				break;
			case CommCfgType.None:
			case CommCfgType.DeathCostExp:
			case CommCfgType.WeaponTransformCost:
			case CommCfgType.MsimNumDistanceMax:
			case CommCfgType.OnelineDropDistance:
			case CommCfgType.OnelineLotteryDistance:
			case CommCfgType.TujianDistance:
			case CommCfgType.DefaultAccessoryNumLimit:
			case CommCfgType.AccessoryNumMax:
			case CommCfgType.LegacyTalentPointMax:
			case CommCfgType.AutoLockDistance:
			case CommCfgType.CameraMoveSpeedBase:
			case CommCfgType.CameraMoveSpeedCoefficiet:
			case CommCfgType.DisableArmorAutoWear:
			case CommCfgType.DefeatUISoundTime:
			case CommCfgType.GameplayCountHpFixCoefficient:
			case CommCfgType.BossrushTipsTime:
			case CommCfgType.BossrushTipsTimePro:
			case CommCfgType.BossrushTipsTimeInit:
				break;
			}
		}
		return 0;
	}

	public static void CheckFUStSuitDesc()
	{
		string toBlame = "";
		foreach (KeyValuePair<int, FUStSuitDesc> item in GetTBFUStSuitDesc())
		{
			for (int i = 0; i < item.Value.SuitInfo.Count; i++)
			{
				if (item.Value.SuitInfo[i].SuitEffectID != 0 && GetTalentSDesc(item.Value.SuitInfo[i].SuitEffectID) == null)
				{
					int suitEffectID = item.Value.SuitInfo[i].SuitEffectID;
					int key = item.Key;
					AddValidateLog($"FUStSuitDesc表 错误id:{key} SuitInfo[{i}] SuitEffectID:{suitEffectID} 未在TalentSDesc里找到对应值", toBlame);
				}
			}
			for (int j = 0; j < item.Value.SuitInfo.Count; j++)
			{
				if (item.Value.SuitInfo[j].AttrEffectID != 0 && GetEquipAttrDesc(item.Value.SuitInfo[j].AttrEffectID) == null)
				{
					int attrEffectID = item.Value.SuitInfo[j].AttrEffectID;
					int key2 = item.Key;
					AddValidateLog($"FUStSuitDesc表 错误id:{key2} SuitInfo[{j}]  AttrEffectID:{attrEffectID} 未在EquipAttrDesc里找到对应值", toBlame);
				}
			}
		}
	}

	public static int CalRequirementCount(AchievementDesc AchievementDesc)
	{
		if (AchievementDesc.RequirementHitType == RequirementHitType.AnyOne)
		{
			return 1;
		}
		if (AchievementDesc.RequirementType == AchievementUnlockRequirement.ProgressKillGuid)
		{
			return AchievementDesc.RequirementGuid.Count;
		}
		return AchievementDesc.RequirementId.Count;
	}

	public static bool IsPlatinumAchievemnt(EBGWSubsystemType SubSystemType, int AchievementId)
	{
		int num = 81081;
		int num2 = 85;
		if (AchievementId == num && (SubSystemType == EBGWSubsystemType.Steam || SubSystemType == EBGWSubsystemType.Tencent))
		{
			return true;
		}
		if (AchievementId == num2 && (SubSystemType == EBGWSubsystemType.PS5 || SubSystemType == EBGWSubsystemType.Epic))
		{
			return true;
		}
		return false;
	}

	public static CricketUnitAttrDesc GetCricketUnitAttrDescByExtendId(int ExtendId)
	{
		if (CricketUnitAttrDescDict.ContainsKey(ExtendId))
		{
			return CricketUnitAttrDescDict[ExtendId];
		}
		return null;
	}

	public static int GetNextLevelIdByChapterId(int ChapterId)
	{
		ChapterDesc chapterDesc = GetChapterDesc(ChapterId);
		if (chapterDesc == null)
		{
			return -1;
		}
		return GetChapterDesc(chapterDesc.NextChapterId)?.LevelId ?? (-1);
	}

	public static ChapterDesc GetChapterDescByLevelId(int LevelId)
	{
		foreach (LevelDesc item in GetTBLevelDesc().List)
		{
			if (item.Id == LevelId)
			{
				ChapterDesc chapterDesc = GetChapterDesc(item.LevelChapter);
				if (chapterDesc != null)
				{
					return chapterDesc;
				}
			}
		}
		return null;
	}

	public static void CheckEditionAwardDesc()
	{
		foreach (EditionAwardDesc item in GetTBEditionAwardDesc().List)
		{
			foreach (ItemOne award in item.AwardList)
			{
				if (GetItemTypeById(award.Id) != ItemType.Equip)
				{
					AddValidateLog($"版本奖励不支持道具类型:{GetItemTypeById(award.Id)}, 道具ID：{award.Id}", "charlie");
				}
			}
		}
	}

	public static void CheckLevelDesc()
	{
		foreach (LevelDesc item in GetTBLevelDesc().List)
		{
			if (item.LevelChapter != 0 && GetChapterDesc(item.LevelChapter) == null)
			{
				AddValidateLog($"LevelDesc LevelID{item.Id} 的LevelChapter {item.LevelChapter} 在ChaperDesc中不存在", "charlie");
			}
		}
	}

	public static List<ItemOne> GetEditionAwardList(EditionType editionType)
	{
		List<ItemOne> list = new List<ItemOne>();
		foreach (EditionAwardDesc item in GetTBEditionAwardDesc().List)
		{
			if (item.Type == editionType)
			{
				list.AddRange(item.AwardList);
			}
		}
		return list;
	}

	public static bool CanEnableCooperation(int BossId)
	{
		BossReChallengeDesc bossReChallengeDesc = GetBossReChallengeDesc(BossId);
		if (bossReChallengeDesc != null && bossReChallengeDesc.AllowAssociationUnitConfigId > 0)
		{
			return true;
		}
		return false;
	}
}
