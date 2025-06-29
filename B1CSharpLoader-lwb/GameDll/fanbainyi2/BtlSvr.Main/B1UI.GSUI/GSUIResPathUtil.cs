using b1;
using b1.Localization;
using b1.UI;
using BtlB1;
using BtlShare;
using ResB1;
using UnrealEngine.InputCore;
using UnrealEngine.Runtime;

namespace B1UI.GSUI;

public class GSUIResPathUtil
{
	public static string GetUIRootBPFullPath()
	{
		return "WidgetBlueprint'/Game/00Main/UI/BluePrintsV3/Base/BUI_B1_Root_V2.BUI_B1_Root_V2_C'";
	}

	public static string GetUIBattleInfoFullPath()
	{
		return "WidgetBlueprint'/Game/00Main/UI/BluePrintsV3/Battle/BUI_BattleInfo.BUI_BattleInfo_C'";
	}

	public static string GetUIAdditiveMatPath()
	{
		return "/Game/GSMobileMatLib/UI/M_UIAdditive.M_UIAdditive";
	}

	public static string GetUIAlphaChannelMatPath()
	{
		return "/Game/GSMobileMatLib/UI/Instance/M_UIAlphaChannel_Inst.M_UIAlphaChannel_Inst";
	}

	public static string GetMapIconPath(int MapId)
	{
		return $"/Game/00MainHZ/UIDev/Shrine/Teleport/Tab_ShrineTeleport_Map_0{MapId}.Tab_ShrineTeleport_Map_0{MapId}";
	}

	public static string GetTitleImgPath(int RebirthPointId)
	{
		return $"/Game/00MainHZ/UI/AlwaysCook/Wallpaper/Title/IMG_title_{RebirthPointId}_b.IMG_title_{RebirthPointId}_b";
	}

	public static string GetRebirthPointImgPath(int RebirthPointId)
	{
		return $"Texture2D'/Game/00MainHZ/UI/AlwaysCook/Wallpaper/Rebirthpoint/IMG_rebirthpoint_{RebirthPointId}_b.IMG_rebirthpoint_{RebirthPointId}_b'";
	}

	public static string GetSoundtrackImgPath(int SoundtrackId)
	{
		return $"Texture2D'/Game/00MainHZ/UI/AlwaysCook/Wallpaper/Soundtrack/IMG_soundtrack_{SoundtrackId}_b.IMG_soundtrack_{SoundtrackId}_b'";
	}

	public static string GetEchoImgPath(int EchoId)
	{
		return $"Texture2D'/Game/00MainHZ/UI/AlwaysCook/Wallpaper/Echo/IMG_echo_{EchoId}_b.IMG_echo_{EchoId}_b'";
	}

	public static string GetArchivesImgBg(int MapId, int MapAreaId)
	{
		return $"Texture2D'/Game/00MainHZ/UIDev/Login/Img_Login_SSimage_{MapId}_{MapAreaId}_B.Img_Login_SSimage_{MapId}_{MapAreaId}_B'";
	}

	public static string GetArchivesImgBgCover(int MapId, int MapAreaId)
	{
		return $"Texture2D'/Game/00MainHZ/UIDev/Login/startgameload/Img_Login_SSimage_{MapId}_{MapAreaId}_B_Cover.Img_Login_SSimage_{MapId}_{MapAreaId}_B_Cover'";
	}

	public static string GetChapterImgBg(int ChapterId)
	{
		return $"Texture2D'/Game/00MainHZ/UIDev/Login/Chapter/Img_Login_Chapter_{ChapterId}_Bg.Img_Login_Chapter_{ChapterId}_Bg'";
	}

	public static string GetRebirthPointNpcImg(int NpcId)
	{
		string text = NpcId.ToString("D4");
		return "Texture2D'/Game/00MainHZ/UI/AlwaysCook/Icon/NPC/IMG_npcicon_" + text + "_t.IMG_npcicon_" + text + "_t'";
	}

	public static string GetItemQualityIconPath(ItemQuality Quality)
	{
		return $"Texture2D'/Game/00MainHZ/UIDev/Comm/IconBox/TypeA/IconBox_ItemTier_{(int)Quality}.IconBox_ItemTier_{(int)Quality}'";
	}

	public static string GetItemQualitySelectIconPath(ItemQuality Quality)
	{
		return $"Texture2D'/Game/00MainHZ/UIDev/Comm/IconBox/TypeA/IconBox_ItemTier_Select_{(int)Quality}.IconBox_ItemTier_Select_{(int)Quality}'";
	}

	public static string GetItemDropBarPath(ItemQuality Quality)
	{
		return $"Texture2D'/Game/00MainHZ/UIDev/HUD/GottenList/Img_HUDGottenListTier_{(int)Quality}.Img_HUDGottenListTier_{(int)Quality}'";
	}

	public static string GetEquipStoryFoldPath(ItemQuality EquipQuality)
	{
		return $"Texture2D'/Game/00MainHZ/UIDev/Gear/Img_GearDetailTier_StoryFold_{(int)EquipQuality}.Img_GearDetailTier_StoryFold_{(int)EquipQuality}'";
	}

	public static string GetEquipStoryUnfoldPath(ItemQuality EquipQuality)
	{
		return $"Texture2D'/Game/00MainHZ/UIDev/Gear/Img_GearDetailTier_StoryUnfold_{(int)EquipQuality}.Img_GearDetailTier_StoryUnfold_{(int)EquipQuality}'";
	}

	public static string GetEquipGearDetailTierPath(ItemQuality EquipQuality)
	{
		return $"MaterialInstanceConstant'/Game/00MainHZ/UIDev/Gear/MI_UIGearDetailTier_Title_{(int)EquipQuality}.MI_UIGearDetailTier_Title_{(int)EquipQuality}'";
	}

	public static string GetItemNamePath(ItemQuality EquipQuality)
	{
		return $"Texture2D'/Game/00MainHZ/UIDev/Inventory/Bar_ItemTier_Title_{(int)EquipQuality}.Bar_ItemTier_Title_{(int)EquipQuality}'";
	}

	public static string GetEquipGearDetailCoreBoxPath(ItemQuality EquipQuality)
	{
		return $"Texture2D'/Game/00MainHZ/UIDev/Gear/V2/Img_GearDetail_CoreBox_{(int)EquipQuality}.Img_GearDetail_CoreBox_{(int)EquipQuality}'";
	}

	public static string GetEquipGearDetailFooterPath(ItemQuality EquipQuality)
	{
		return $"Texture2D'/Game/00MainHZ/UIDev/Gear/V2/Bar_GearDetail_Footer_{(int)EquipQuality}.Bar_GearDetail_Footer_{(int)EquipQuality}'";
	}

	public static string GetEquipGearDetailPropertyPath(ItemQuality EquipQuality)
	{
		return $"Texture2D'/Game/00MainHZ/UIDev/Gear/V2/Bar_GearDetail_Property_{(int)EquipQuality}.Bar_GearDetail_Property_{(int)EquipQuality}'";
	}

	public static string GetItemBgPath(ItemQuality EquipQuality)
	{
		return $"MaterialInstanceConstant'/Game/00MainHZ/UIDev/Inventory/MI_UIItemDetailTier_Bg_{(int)EquipQuality}.MI_UIItemDetailTier_Bg_{(int)EquipQuality}'";
	}

	public static string GetItemIconTPath(int ItemId)
	{
		ItemId = GameDBRuntime.GetItemImageID(ItemId);
		return $"/Game/00MainHZ/UI/AlwaysCook/Icon/Item_Icon_{ItemId}_t.Item_Icon_{ItemId}_t";
	}

	public static string GetSkillIconPath()
	{
		return "Texture2D'/Game/00MainHZ/UIDev/Comm/Resource/Icon_CommRes_SkillPoint.Icon_CommRes_SkillPoint'";
	}

	public static string GetUnkownItemIcon()
	{
		return "/Game/00MainHZ/UI/AlwaysCook/Icon/Item_Icon__g.Item_Icon__g";
	}

	public static string GetItemIconGPath(int ItemId)
	{
		ItemId = GameDBRuntime.GetItemImageID(ItemId);
		return $"/Game/00MainHZ/UI/AlwaysCook/Icon/Item_Icon_{ItemId}_g.Item_Icon_{ItemId}_g";
	}

	public static string GetItemIconGFPath(int ItemId)
	{
		ItemId = GameDBRuntime.GetItemImageID(ItemId);
		return $"/Game/00MainHZ/UI/AlwaysCook/Icon/Item_Icon_{ItemId}_g_f.Item_Icon_{ItemId}_g_f";
	}

	public static string GetItemIconSPPath(int ItemId)
	{
		ItemId = GameDBRuntime.GetItemImageID(ItemId);
		return $"/Game/00MainHZ/UI/AlwaysCook/Icon/Item_Icon_{ItemId}_sp.Item_Icon_{ItemId}_sp";
	}

	public static string GetAbilityIconGPath(int ItemId)
	{
		return $"MaterialInstanceConstant'/Game/00MainHZ/UIDev/Ability_Skill/SkillIconBox/AbilityIcon/M_UIAbility_Icon_{ItemId}_g.M_UIAbility_Icon_{ItemId}_g'";
	}

	public static string GetBianShenHPBgGPath(int SpellId)
	{
		return $"Texture2D'/Game/00MainHZ/UIDev/Ability_Skill/Img_AbilitySkill_StyleBar_{SpellId}_g.Img_AbilitySkill_StyleBar_{SpellId}_g'";
	}

	public static string GetTransIconPath(int SpellID)
	{
		return $"Texture2D'/Game/00MainHZ/UIDev/HUD/StateBar/PlayerStyle/Icon_HUDStyle_{SpellID}.Icon_HUDStyle_{SpellID}'";
	}

	public static string GetTransHPBarPath(int SpellID)
	{
		return $"Texture2D'/Game/00MainHZ/UIDev/HUD/StateBar/PlayerTransBar/PBAR_hudtransbar_{SpellID}.PBAR_hudtransbar_{SpellID}'";
	}

	public static string GetTransHPBarSpritePath(int SpellID)
	{
		return $"UPaperSprite'/Game/00MainHZ/UIDev/HUD/StateBar/PlayerTransBar/PBAR_hudtransbar_{SpellID}_Sprite.PBAR_hudtransbar_{SpellID}_Sprite'";
	}

	public static string GetSpellTalentLine(int SpellId)
	{
		return $"Texture2D'/Game/00MainHZ/UIDev/Ability_Skill/TreeBranch/Img_AbilitySkill_TreeBranch_{SpellId}_g.Img_AbilitySkill_TreeBranch_{SpellId}_g'";
	}

	public static string GetSpellTalentLineMat(int SpellId)
	{
		return $"MaterialInstanceConstant'/Game/00MainHZ/UIDev/Ability_Skill/TreeBranch/MI_AbilitySkill_Tree_{SpellId}.MI_AbilitySkill_Tree_{SpellId}'";
	}

	public static string GetSpellPosIcon(int Pos)
	{
		return $"Texture2D'/Game/00MainHZ/UIDev/Ability_Skill/Marker_FaceButton_{Pos}.Marker_FaceButton_{Pos}'";
	}

	public static string GetTalentLevelMaxBgPath(int LevelMax)
	{
		return $"Texture2D'/Game/00MainHZ/UIDev/Ability_Skill/TreeIconBox/Img_AbilitySkill_DotsBox_0{LevelMax}.Img_AbilitySkill_DotsBox_0{LevelMax}'";
	}

	public static string GetTalentIconTPath(int TalentID)
	{
		return $"Texture2D'/Game/00MainHZ/UI/AlwaysCook/Icon/Talent/icon_talent_{TalentID}_t.icon_talent_{TalentID}_t'";
	}

	public static string GetTalentItemPath(int TalentID)
	{
		TalentSDesc talentSDesc = GameDBRuntime.GetTalentSDesc(TalentID);
		if (talentSDesc == null)
		{
			BGW_LogUtil.LogError($"[GSUIResPathUtil:GetTaletItemPath]TalentDesc is null, TalentId = {TalentID}");
			return "";
		}
		int num = talentSDesc.Rank;
		if (num == 0)
		{
			num = 1;
		}
		FUStTalentDisplayDesc talentDisplayDesc = BGW_GameDB.GetTalentDisplayDesc(TalentID);
		if (talentDisplayDesc == null)
		{
			BGW_LogUtil.LogError($"[GSUIResPathUtil:GetTaletItemPath]TalentDisplayDesc is null, TalentId = {TalentID}");
			return "";
		}
		int num2 = talentDisplayDesc.TalentType;
		if (num2 == 0)
		{
			num2 = 1;
		}
		return $"WidgetBlueprint'/Game/00Main/UI/BluePrintsV3/LearnSpell/Node/BI_TalentItem_{num}_{num2}.BI_TalentItem_{num}_{num2}_C'";
	}

	public static string GetTalentItemLearnPath(bool IsRank)
	{
		if (IsRank)
		{
			return "WidgetBlueprint'/Game/00Main/UI/BluePrintsV3/LearnSpell/Node/BI_UIFXTalentCoreItem_Learned.BI_UIFXTalentCoreItem_Learned_C'";
		}
		return "WidgetBlueprint'/Game/00Main/UI/BluePrintsV3/LearnSpell/Node/BI_UIFXTalentNode_Learned.BI_UIFXTalentNode_Learned_C'";
	}

	public static string GetSpellPanelPath(SpellType TargetType)
	{
		return $"WidgetBlueprint'/Game/00Main/UI/BluePrintsV3/LearnSpell/SpellPanel_New/BI_Spell_Panel_{TargetType}.BI_Spell_Panel_{TargetType}_C'";
	}

	public static string GetRoleAttrIconPath(EBGUAttrFloat AttrType)
	{
		return $"Texture2D'/Game/00MainHZ/UIDev/Comm/Property_Marker/IMG_playerstatemarker_{(int)AttrType}_g.IMG_playerstatemarker_{(int)AttrType}_g'";
	}

	public static string GetItemTabIconPath(ItemType Type)
	{
		return $"Texture2D'/Game/00MainHZ/UIDev/Inventory/Marker_PlayerInventory_{(int)Type}.Marker_PlayerInventory_{(int)Type}'";
	}

	public static string GetRoleTabIconPath(string RoleUIType)
	{
		return "Texture2D'/Game/00MainHZ/UIDev/Comm/MenuTab/IMG_menutab_" + StringParseHelper.SafeToLower(RoleUIType.ToString()) + ".IMG_menutab_" + StringParseHelper.SafeToLower(RoleUIType.ToString()) + "'";
	}

	public static string GetInputTab(EGSInputTab Tab)
	{
		return "Texture2D'/Game/00MainHZ/UIDev/Comm/MenuTab/IMG_menutab_" + StringParseHelper.SafeToLower(Tab.ToString()) + ".IMG_menutab_" + StringParseHelper.SafeToLower(Tab.ToString()) + "'";
	}

	public static string GetShopTabIconPath(int TabId)
	{
		return $"Texture2D'/Game/00MainHZ/UIDev/Shrine/Shop/Marker_ShrineShop_{TabId}.Marker_ShrineShop_{TabId}'";
	}

	public static string GetItemPosIconPath(int ItemPos, bool IsGamepad)
	{
		if (IsGamepad)
		{
			return $"Texture2D'/Game/00MainHZ/UIDev/Inventory/Marker_ItemEquipped_Gamepad_{ItemPos}.Marker_ItemEquipped_Gamepad_{ItemPos}'";
		}
		return $"Texture2D'/Game/00MainHZ/UIDev/Inventory/Marker_ItemEquipped_{ItemPos}.Marker_ItemEquipped_{ItemPos}'";
	}

	public static string GetHuluPartnerPosIconPath()
	{
		return "Texture2D'/Game/00MainHZ/UIDev/Soaking/Marker_Soaking.Marker_Soaking'";
	}

	public static string GetPutInFurnaceIconPath()
	{
		return "Texture2D'/Game/00MainHZ/UIDev/Alchemy/Marker_Alchemy.Marker_Alchemy'";
	}

	public static string GetItemMainPosIconPath(int ItemPos, bool IsGamepad)
	{
		if (IsGamepad)
		{
			return $"Texture2D'/Game/00MainHZ/UIDev/Inventory/Marker_Equipping_Item_Gamepad_{ItemPos}.Marker_Equipping_Item_Gamepad_{ItemPos}'";
		}
		return $"Texture2D'/Game/00MainHZ/UIDev/Inventory/Marker_Equipping_Item_{ItemPos}.Marker_Equipping_Item_{ItemPos}'";
	}

	public static string GetEquipedIconPath()
	{
		return "Texture2D'/Game/00MainHZ/UIDev/Gear/Marker_GearEquipped.Marker_GearEquipped'";
	}

	public static string GetAttrCostTypeIconPath(EAttrCostType AttrCostType)
	{
		return AttrCostType switch
		{
			EAttrCostType.Mp => "Texture2D'/Game/00MainHZ/UIDev/Comm/Property_Marker/Marker_PlayerProperty_Energy.Marker_PlayerProperty_Energy'", 
			EAttrCostType.Stamina => "Texture2D'/Game/00MainHZ/UIDev/Comm/Property_Marker/Marker_PlayerProperty_Energy.Marker_PlayerProperty_Energy'", 
			_ => "", 
		};
	}

	public static string GetQualityImgPreview(UISettingConfigType SettingType, int Value)
	{
		string text = "";
		if (SettingType == UISettingConfigType.PlayerGuide || SettingType == UISettingConfigType.GamepadEffectDesc || SettingType == UISettingConfigType.KeybaordEffectDesc || SettingType == UISettingConfigType.BossBar || SettingType == UISettingConfigType.InteractionTips)
		{
			string currentCulture = GSLocalization.GetCurrentCulture();
			if (currentCulture.Contains(GSLocalization.Culture_zh_Hans) || currentCulture.Contains(GSLocalization.Culture_zh_Hans_CN))
			{
				text += "_zh-Hans";
			}
			if (currentCulture.Contains(GSLocalization.Culture_zh_Hant))
			{
				text += "_zh-Hant";
			}
			if (currentCulture.Contains(GSLocalization.Culture_ja))
			{
				text += "_ja";
			}
			if (currentCulture.Contains(GSLocalization.Culture_ko))
			{
				text += "_ko";
			}
		}
		string result = $"Texture2D'/Game/00MainHZ/UIDev/Setting/Preview/Img_Preview_{(int)SettingType}_{Value}_n{text}.Img_Preview_{(int)SettingType}_{Value}_n{text}'";
		if (SettingType == UISettingConfigType.ColorClass || SettingType == UISettingConfigType.ColorSeverity)
		{
			result = $"Texture2D'/Game/00MainHZ/UIDev/Setting/Preview/Img_Preview_{(int)SettingType}_n.Img_Preview_{(int)SettingType}_n'";
		}
		return result;
	}

	public static string GetKeyboardIconPath(EKeys Key)
	{
		return $"Texture2D'/Game/00MainHZ/UI/AlwaysCook/PressKeyIcon/KeyBoard/Icon_{Key}.Icon_{Key}'";
	}

	public static string GetKeyboardIconPath(FName Key)
	{
		return $"Texture2D'/Game/00MainHZ/UI/AlwaysCook/PressKeyIcon/KeyBoard/Icon_{Key}.Icon_{Key}'";
	}

	public static string GetItemSelectedMat(bool IsSelected)
	{
		if (IsSelected)
		{
			return "MaterialInstanceConstant'/Game/00MainHZ/UIDev/Gear/MI_UIGearIcon_Item_Select.MI_UIGearIcon_Item_Select'";
		}
		return "MaterialInstanceConstant'/Game/00MainHZ/UIDev/Gear/MI_UIGearIcon_Item.MI_UIGearIcon_Item'";
	}

	public static string GetItemSlotSelectedImg(bool IsSelected)
	{
		if (IsSelected)
		{
			return "Texture2D'/Game/00MainHZ/UIDev/Gear/IconBox_EqItem_Select.IconBox_EqItem_Select'";
		}
		return "Texture2D'/Game/00MainHZ/UIDev/Gear/IconBox_EqItem_Df.IconBox_EqItem_Df'";
	}

	public static string GetSpellTreeBgSelectedImg(bool IsSelected)
	{
		if (IsSelected)
		{
			return "MaterialInstanceConstant'/Game/00MainHZ/UIDev/Ability_Skill/MI_UIAbilitySkill_TreeBg_Ck.MI_UIAbilitySkill_TreeBg_Ck'";
		}
		return "MaterialInstanceConstant'/Game/00MainHZ/UIDev/Ability_Skill/MI_UIAbilitySkill_TreeBg_Df.MI_UIAbilitySkill_TreeBg_Df'";
	}

	public static string GetSpellTreeTitleSelectedImg(bool IsSelected)
	{
		if (IsSelected)
		{
			return "MaterialInstanceConstant'/Game/00MainHZ/UIDev/Ability_Skill/MI_UIAbilitySkill_TreeTitle_Ck.MI_UIAbilitySkill_TreeTitle_Ck'";
		}
		return "MaterialInstanceConstant'/Game/00MainHZ/UIDev/Ability_Skill/MI_UIAbilitySkill_TreeTitle_Df.MI_UIAbilitySkill_TreeTitle_Df'";
	}

	public static string GetSpellDetailBottomTextBg(bool IsNone)
	{
		if (IsNone)
		{
			return "Texture2D'/Game/00MainHZ/UIDev/Ability_Skill/Bar_AbilitySkill_Notice_Dis.Bar_AbilitySkill_Notice_Dis'";
		}
		return "Texture2D'/Game/00MainHZ/UIDev/Ability_Skill/Bar_AbilitySkill_Notice_Ck.Bar_AbilitySkill_Notice_Ck'";
	}

	public static string GetSpellDetailImgNameBg(bool IsTrans)
	{
		if (IsTrans)
		{
			return "Texture2D'/Game/00MainHZ/UIDev/Ability_Skill/Bar_AbilitySkill_DetailTrans_Title.Bar_AbilitySkill_DetailTrans_Title'";
		}
		return "Texture2D'/Game/00MainHZ/UIDev/Comm/Bar_Comm_02.Bar_Comm_02'";
	}

	public static string GetTeamPlayerHpBgImg(bool IsFallDying)
	{
		if (IsFallDying)
		{
			return "MaterialInstanceConstant'/Game/00MainHZ/UIDev/HUD/Team/MI_UIHUDTeam_ProgBar_Dying.MI_UIHUDTeam_ProgBar_Dying'";
		}
		return "MaterialInstanceConstant'/Game/00MainHZ/UIDev/HUD/Team/MI_UIHUDTeam_ProgBar_Df.MI_UIHUDTeam_ProgBar_Df'";
	}

	public static string GetSpellCdIconPath()
	{
		return "Texture2D'/Game/00MainHZ/UIDev/Comm/Property_Marker/Marker_PlayerProperty_Cd.Marker_PlayerProperty_Cd'";
	}

	public static string GetWeaponBuildMatPath(string Name)
	{
		return "MaterialInstanceConstant'/Game/00MainHZ/UIDev/Weapon/" + Name + "." + Name + "'";
	}

	public static string GetTalentItemBrightMatPath(bool IsCore)
	{
		if (IsCore)
		{
			return "MaterialInstanceConstant'/Game/00MainHZ/UIDev/Ability_Skill/TreeIconBox/MI_UIAbilitySkill_TreeIconBright_Core.MI_UIAbilitySkill_TreeIconBright_Core'";
		}
		return "MaterialInstanceConstant'/Game/00MainHZ/UIDev/Ability_Skill/TreeIconBox/MI_UIAbilitySkill_TreeIconBright_Df.MI_UIAbilitySkill_TreeIconBright_Df'";
	}

	public static string GetTalentItemSweepMatPath(bool IsCore)
	{
		if (IsCore)
		{
			return "MaterialInstanceConstant'/Game/00MainHZ/UIDev/Ability_Skill/TreeIconBox/MI_UIAbilitySkill_TreeIconSweep_Core.MI_UIAbilitySkill_TreeIconSweep_Core'";
		}
		return "MaterialInstanceConstant'/Game/00MainHZ/UIDev/Ability_Skill/TreeIconBox/MI_UIAbilitySkill_TreeIconSweep_Df.MI_UIAbilitySkill_TreeIconSweep_Df'";
	}

	public static string GetInputActionPath(string ActionName)
	{
		return "WidgetBlueprint'/Game/00Main/UI/BluePrintsV3/Comm/InputAction/" + ActionName + "." + ActionName + "_C'";
	}

	public static string GetMonsterTypeTabIconPath(MonsterType Type)
	{
		return $"Texture2D'/Game/00MainHZ/UIDev/TravelNotes/Marker_Handbook_{Type}.Marker_Handbook_{Type}'";
	}

	public static string GetTransStylePath(int ResID)
	{
		return $"WidgetBlueprint'/Game/00Main/UI/BluePrintsV3/BattleV2/Trans/BI_TransStyle_{ResID}.BI_TransStyle_{ResID}_C'";
	}

	public static string GetNamePath(int NameID)
	{
		return $"Texture2D'/Game/00MainHZ/UIDev/SequenceUI/Name/Img_Name_{NameID}_Seq.Img_Name_{NameID}_Seq'";
	}

	public static string GetNameSpritePath(int NameID)
	{
		return $"UPaperSprite'/Game/00MainHZ/UIDev/SequenceUI/Name/Img_Name_{NameID}_Seq_Sprite.Img_Name_{NameID}_Seq_Sprite'";
	}

	public static string GetNameAtlasGroupPath(int LevelID)
	{
		return $"Texture2D'/Game/00MainHZ/UIDev/SequenceUI/Name/AG_sequi_{LevelID}_name_0.AG_sequi_{LevelID}_name_0'";
	}

	public static string GetTravelNotesTabPath(ETravelNotesTabType TravelNotesTabType)
	{
		return $"MaterialInstanceConstant'/Game/00MainHZ/UIDev/TravelNotes/MI_TravelNots_Tab_{(int)TravelNotesTabType}.MI_TravelNots_Tab_{(int)TravelNotesTabType}'";
	}

	public static string GetTeleportIconPath(int GroupId)
	{
		return $"Texture2D'/Game/00MainHZ/UIDev/Shrine/Teleport/Tab_ShrineTeleport_Map_{GroupId}.Tab_ShrineTeleport_Map_{GroupId}'";
	}

	public static string GetArtbookContentPath(ArtbookType InArtbookType)
	{
		return $"WidgetBlueprint'/Game/00Main/UI/BluePrintsV3/Museum/Artbook/BI_Artbook_{InArtbookType}.BI_Artbook_{InArtbookType}_C'";
	}

	public static string GetArtbookImgPath(int ArtbookId)
	{
		return $"Texture2D'/Game/00MainHZ/UIDev/Museum/Artwork/IMG_museumartwork_{ArtbookId}_t.IMG_museumartwork_{ArtbookId}_t'";
	}

	public static string GetMeditationPointCoverPath(int MeditationPointId)
	{
		return $"Texture2D'/Game/00MainHZ/UIDev/TravelNotes/MeditationPoint/IMG_mpcover_{MeditationPointId}_cover.IMG_mpcover_{MeditationPointId}_cover'";
	}

	public static string GetMeditationPointImgPath(int MeditationPointId)
	{
		return $"Texture2D'/Game/00MainHZ/UI/AlwaysCook/Wallpaper/MeditationPoint/IMG_meditation_{MeditationPointId}_b.IMG_meditation_{MeditationPointId}_b'";
	}

	public static string GetStateIconGPath(int ItemID)
	{
		return $"/Game/00MainHZ/UIDev/HUD/StateBar/PlayerState/IMG_playerstatemarker_{ItemID}_g.IMG_playerstatemarker_{ItemID}_g";
	}

	public static string GetUnitBookIconPath(int UnitID)
	{
		return $"/Game/00MainHZ/UIDev/TravelNotes/MBookPicture/T_book_{UnitID}_t.T_book_{UnitID}_t";
	}

	public static string GetUnitBookMaskPath(int UnitID)
	{
		return $"/Game/00MainHZ/UIDev/TravelNotes/MBookPicture/T_book_{UnitID}_mask.T_book_{UnitID}_mask";
	}

	public static string GetUnitBookStrokePath(int UnitID)
	{
		return $"/Game/00MainHZ/UIDev/TravelNotes/MBookPicture/T_book_{UnitID}_stroke.T_book_{UnitID}_stroke";
	}

	public static string GetLoginBgPic(int Idx)
	{
		return $"Texture2D'/Game/00MainHZ/UIDev/Nianhui2021/Img_WebBg_D{Idx}.Img_WebBg_D{Idx}'";
	}

	public static string GetChapterScrollMIPath(int ChapterID)
	{
		return $"MaterialInstanceConstant'/Game/00MainHZ/UIDev/Chapter/MI_UIChapterScroll_{ChapterID}.MI_UIChapterScroll_{ChapterID}'";
	}

	public static string GetWeaponTreeSamplePanelPath(int WeaponTreeId)
	{
		return $"WidgetBlueprint'/Game/00Main/UI/BluePrintsV3/WeaponBuild/BI_WeaponTree_Sample_{WeaponTreeId}.BI_WeaponTree_Sample_{WeaponTreeId}_C'";
	}

	public static string GetWeaponTreePanelPath(int WeaponTreeId, bool IsPlus)
	{
		if (IsPlus)
		{
			return $"WidgetBlueprint'/Game/00Main/UI/BluePrintsV3/WeaponBuild/BI_WeeaponTree_Plus_{WeaponTreeId}.BI_WeeaponTree_Plus_{WeaponTreeId}_C'";
		}
		return $"WidgetBlueprint'/Game/00Main/UI/BluePrintsV3/WeaponBuild/BI_WeeaponTree_{WeaponTreeId}.BI_WeeaponTree_{WeaponTreeId}_C'";
	}

	public static string GetGuidePopboxIcon(int GuideID)
	{
		return $"Texture2D'/Game/00MainHZ/UI/Atlas/Guide/Pic/IMG_guidepic_{GuideID}.IMG_guidepic_{GuideID}'";
	}

	public static string GetGuidePopboxMovie(int GuideID)
	{
		return $"/Game/00Main/UI/BluePrintsV3/TravelNotes/GuideFSM/Guide_Movie_{GuideID}.Guide_Movie_{GuideID}";
	}

	public static string GetDefaultPath()
	{
		return "Texture2D'/Game/00MainHZ/UI/Atlas/Icon/Item_Icon_Default_t.Item_Icon_Default_t'";
	}

	public static string GetDefaultSeedSubmitMontagePath()
	{
		return "AnimMontage'/Game/00Main/Animation/LYS/QuestAnim/RuYi/AM_quest_shenlong_01a_paintingworld_interact_04.AM_quest_shenlong_01a_paintingworld_interact_04'";
	}

	public static string GetFirstGetMedicineMontagePath()
	{
		return "AnimMontage'/Game/00Main/Animation/HFM/Quest/HFM_HuoZhongQuLi/AM_NPC_HuYao_01_Quest_Talk_05.AM_NPC_HuYao_01_Quest_Talk_05'";
	}

	public static string GetSettingCulturePath(string Culture)
	{
		Culture = Culture.Replace("-", "_");
		return "Texture2D'/Game/00MainHZ/UIDev/Setting/LanguageImage/Img_Culture_" + Culture + ".Img_Culture_" + Culture + "'";
	}

	public static string GetFabaoBinkMoviePath(int Id)
	{
		return $"/Movies/Fabao/Fabao_Movie_{Id}.bk2";
	}

	public static string GetSoulskillBinkMoviePath(int Id)
	{
		return $"/Movies/Soulskill/Soulskill_Movie_{Id}.bk2";
	}

	public static string GetFabaoMoviePath(int Id)
	{
		return $"/Game/00MainHZ/UI/AlwaysCook/UIMovies/Fabao/Fabao_Movie_{Id}.Fabao_Movie_{Id}";
	}

	public static string GetSoulskillMoviePath(int Id)
	{
		return $"/Game/00MainHZ/UI/AlwaysCook/UIMovies/Soulskill/Soulskill_Movie_{Id}.Soulskill_Movie_{Id}";
	}

	public static string GetTalentMovieIconPath(int Id)
	{
		return $"/Game/00MainHZ/UI/Atlas/Comm/Detail/TalentPic/IMG_talentpic_{Id}.IMG_talentpic_{Id}";
	}

	public static string GetItemPreviewPath(int ItemID)
	{
		return $"/Game/00Main/Design/Blueprints/Item/ItemPreview/ItemPreview_{ItemID}.ItemPreview_{ItemID}_C";
	}

	public static string GetUnitPreviewPath(int ItemID)
	{
		return $"/Game/00Main/Design/Blueprints/TransPreview/Unit_TransPreview_{ItemID}.Unit_TransPreview_{ItemID}_C";
	}

	public static string GetBossIterationsScrollPath(int GroupId)
	{
		return $"/Game/00Main/Design/Blueprints/Manual/MonsterPreview/BP_BossRushScroll_{GroupId}.BP_BossRushScroll_{GroupId}_C";
	}

	public static string GetEquipSlotT2DA()
	{
		return "Texture2DArray'/Game/00MainHZ/UI/Atlas/Comm/Tab/T2DA_tabgear.T2DA_tabgear'";
	}

	public static string GetInputTabT2DA()
	{
		return "Texture2DArray'/Game/00MainHZ/UI/Atlas/Comm/Tab/T2DA_tabsetting.T2DA_tabsetting'";
	}

	public static string GetShopTabT2DA()
	{
		return "Texture2DArray'/Game/00MainHZ/UI/Atlas/Comm/Tab/T2DA_tabshop.T2DA_tabshop'";
	}

	public static string GetBagTabT2DA()
	{
		return "Texture2DArray'/Game/00MainHZ/UI/Atlas/Comm/Tab/T2DA_tabinventory.T2DA_tabinventory'";
	}

	public static string GetLoadTipsImagePath(int ImageId)
	{
		return $"Texture2D'/Game/00MainHZ/UIDev/Loading/LoadTips/TipsImg/Img_LoadTips_{ImageId}_B.Img_LoadTips_{ImageId}_B'";
	}

	public static string GetBossRushImagePath(int Id)
	{
		return $"Texture2D'/Game/00MainHZ/UI/AlwaysCook/Wallpaper/LoadingTipsBossRush/Img_LoadTips_{Id}_B.Img_LoadTips_{Id}_B'";
	}

	public static string GetBossRushImagePath(int GroupId, int Id)
	{
		return $"Texture2D'/Game/00MainHZ/UI/AlwaysCook/Wallpaper/LoadingTipsBossRush/Img_LoadTips_{GroupId:D2}{Id:D2}_B.Img_LoadTips_{GroupId:D2}{Id:D2}_B'";
	}

	public static string GetChapterImagePath(int ChapterId)
	{
		return $"Texture2D'/Game/00MainHZ/UI/Atlas/Chapter/IMG_chaptertitle_{ChapterId}.IMG_chaptertitle_{ChapterId}'";
	}

	public static string GetMVTitlePath(int MVId)
	{
		return $"Texture2D'/Game/00MainHZ/UI/AlwaysCook/PastMemory/MVTitle/IMG_pmtitle_{MVId}_b.IMG_pmtitle_{MVId}_b'";
	}

	public static string GetMVBGPath(int MVId)
	{
		return $"Texture2D'/Game/00MainHZ/UI/AlwaysCook/PastMemory/MVImage/IMG_pmmvbg_{MVId}_b.IMG_pmmvbg_{MVId}_b'";
	}

	public static string GetSpiritIcon()
	{
		return "Texture2D'/Game/00MainHZ/UIDev/Comm/Resource/Icon_CommRes_Money.Icon_CommRes_Money'";
	}

	public static string GetSkillPointIcon()
	{
		return "Texture2D'/Game/00MainHZ/UIDev/Comm/Resource/Icon_CommRes_SkillPoint.Icon_CommRes_SkillPoint'";
	}

	public static string GetMapSpritePath(int MapSpriteId)
	{
		return $"WidgetBlueprint'/Game/00Main/UI/BluePrintsV3/Map/MapPic/BI_MapPic_{MapSpriteId}.BI_MapPic_{MapSpriteId}_C'";
	}

	public static string GetMapSpritePicPath(int MapSpriteId)
	{
		return $"Texture2D'/Game/00MainHZ/UI/Atlas/Map/Map_Pic/img_map_{MapSpriteId}.img_map_{MapSpriteId}'";
	}

	public static string GetMapSpriteMaskPath(int MapSpriteId)
	{
		return $"Texture2D'/Game/00MainHZ/UI/Atlas/Map/Map_Pic/img_map_mask_{MapSpriteId}.img_map_mask_{MapSpriteId}'";
	}

	public static string GetMapSpriteMaskFogPath(int MapSpriteId)
	{
		return $"/Game/00MainHZ/UI/Atlas/Map/Map_Pic/T_mapfog_{MapSpriteId}.T_mapfog_{MapSpriteId}";
	}

	public static string GetMapSpriteMaskDAPath(int MapSpriteId)
	{
		return $"TexAlphaDataAsset'/Game/00MainHZ/UI/Atlas/Map/Map_Pic/img_map_mask_{MapSpriteId}_DA.img_map_mask_{MapSpriteId}_DA'";
	}

	public static string GetMapNPCMarkerPath(int NpcId)
	{
		string text = NpcId.ToString("D4");
		return "Texture2D'/Game/00MainHZ/UI/Atlas/Map/NPC/MARKER_mapnpc_" + text + "_t.MARKER_mapnpc_" + text + "_t'";
	}

	public static string GetMapRTMatPath()
	{
		return "MaterialInstanceConstant'/Game/00MainHZ/UI/Atlas/Map/Map_Pic/MI_UIMap_RT_Inst.MI_UIMap_RT_Inst'";
	}

	public static string GetBossDebuffIconPath(int DebuffID)
	{
		return $"Texture2D'/Game/00MainHZ/UI/Atlas/BossRush/Icon/ICON_bossrushdifficulty_{DebuffID}_t.ICON_bossrushdifficulty_{DebuffID}_t'";
	}
}
