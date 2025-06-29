using System;
using System.Collections.Generic;
using b1.Protobuf.GSProtobufRuntimeAPI;
using Google.Protobuf.Collections;
using ResB1;

namespace b1;

public class GameDBResB1
{
	public static void DumpStringContent(List<Tuple<string, string>> TableContentList)
	{
		RepeatedField<CommLogicCfgDesc> list = GSProtobufRuntimeAPI<TBCommLogicCfgDesc, CommLogicCfgDesc>.Get().GetAll().List;
		for (int i = 0; i < list.Count; i++)
		{
			_ = list[i].Id;
		}
		RepeatedField<PlayerLevelDesc> list2 = GSProtobufRuntimeAPI<TBPlayerLevelDesc, PlayerLevelDesc>.Get().GetAll().List;
		for (int j = 0; j < list2.Count; j++)
		{
			_ = list2[j].Id;
		}
		RepeatedField<ItemDesc> list3 = GSProtobufRuntimeAPI<TBItemDesc, ItemDesc>.Get().GetAll().List;
		for (int k = 0; k < list3.Count; k++)
		{
			ItemDesc itemDesc = list3[k];
			int id = itemDesc.Id;
			TableContentList.Add(new Tuple<string, string>($"ItemDesc[{id}].Name", itemDesc.Name));
			TableContentList.Add(new Tuple<string, string>($"ItemDesc[{id}].TypeName", itemDesc.TypeName));
			TableContentList.Add(new Tuple<string, string>($"ItemDesc[{id}].BriefDesc", itemDesc.BriefDesc));
			TableContentList.Add(new Tuple<string, string>($"ItemDesc[{id}].Desc", itemDesc.Desc));
			TableContentList.Add(new Tuple<string, string>($"ItemDesc[{id}].DropTemplete", itemDesc.DropTemplete));
			TableContentList.Add(new Tuple<string, string>($"ItemDesc[{id}].EffectDesc", itemDesc.EffectDesc));
			TableContentList.Add(new Tuple<string, string>($"ItemDesc[{id}].Source", itemDesc.Source));
			TableContentList.Add(new Tuple<string, string>($"ItemDesc[{id}].HudEffectDesc", itemDesc.HudEffectDesc));
		}
		RepeatedField<AttrItemDesc> list4 = GSProtobufRuntimeAPI<TBAttrItemDesc, AttrItemDesc>.Get().GetAll().List;
		for (int l = 0; l < list4.Count; l++)
		{
			_ = list4[l].Id;
		}
		RepeatedField<ConsumeDesc> list5 = GSProtobufRuntimeAPI<TBConsumeDesc, ConsumeDesc>.Get().GetAll().List;
		for (int m = 0; m < list5.Count; m++)
		{
			_ = list5[m].Id;
		}
		RepeatedField<EquipFaBaoAttrDesc> list6 = GSProtobufRuntimeAPI<TBEquipFaBaoAttrDesc, EquipFaBaoAttrDesc>.Get().GetAll().List;
		for (int n = 0; n < list6.Count; n++)
		{
			EquipFaBaoAttrDesc equipFaBaoAttrDesc = list6[n];
			int id2 = equipFaBaoAttrDesc.Id;
			TableContentList.Add(new Tuple<string, string>($"EquipFaBaoAttrDesc[{id2}].HasBuff", equipFaBaoAttrDesc.HasBuff));
			for (int num = 0; num < equipFaBaoAttrDesc.CarryEffectDesc.Count; num++)
			{
				TableContentList.Add(new Tuple<string, string>($"EquipFaBaoAttrDesc[{id2}].CarryEffectDesc[{num}]", equipFaBaoAttrDesc.CarryEffectDesc[num]));
			}
		}
		RepeatedField<EquipPositionConfDesc> list7 = GSProtobufRuntimeAPI<TBEquipPositionConfDesc, EquipPositionConfDesc>.Get().GetAll().List;
		for (int num2 = 0; num2 < list7.Count; num2++)
		{
			EquipPositionConfDesc equipPositionConfDesc = list7[num2];
			int id3 = equipPositionConfDesc.Id;
			TableContentList.Add(new Tuple<string, string>($"EquipPositionConfDesc[{id3}].SkeletalMeshComponentTag", equipPositionConfDesc.SkeletalMeshComponentTag));
		}
		RepeatedField<EquipDesc> list8 = GSProtobufRuntimeAPI<TBEquipDesc, EquipDesc>.Get().GetAll().List;
		for (int num3 = 0; num3 < list8.Count; num3++)
		{
			EquipDesc equipDesc = list8[num3];
			int id4 = equipDesc.Id;
			TableContentList.Add(new Tuple<string, string>($"EquipDesc[{id4}].EquipName", equipDesc.EquipName));
			TableContentList.Add(new Tuple<string, string>($"EquipDesc[{id4}].SkeletalMesh", equipDesc.SkeletalMesh));
			TableContentList.Add(new Tuple<string, string>($"EquipDesc[{id4}].AttachSocketName", equipDesc.AttachSocketName));
			TableContentList.Add(new Tuple<string, string>($"EquipDesc[{id4}].AnimBlueprintClass", equipDesc.AnimBlueprintClass));
			for (int num4 = 0; num4 < equipDesc.StaticMesh.Count; num4++)
			{
				TableContentList.Add(new Tuple<string, string>($"EquipDesc[{id4}].StaticMesh[{num4}]", equipDesc.StaticMesh[num4]));
			}
			TableContentList.Add(new Tuple<string, string>($"EquipDesc[{id4}].EquipEffectDesc", equipDesc.EquipEffectDesc));
		}
		RepeatedField<EquipAttrDesc> list9 = GSProtobufRuntimeAPI<TBEquipAttrDesc, EquipAttrDesc>.Get().GetAll().List;
		for (int num5 = 0; num5 < list9.Count; num5++)
		{
			_ = list9[num5].Id;
		}
		RepeatedField<WeaponBuildDesc> list10 = GSProtobufRuntimeAPI<TBWeaponBuildDesc, WeaponBuildDesc>.Get().GetAll().List;
		for (int num6 = 0; num6 < list10.Count; num6++)
		{
			_ = list10[num6].Id;
		}
		RepeatedField<UnitDropRuleDesc> list11 = GSProtobufRuntimeAPI<TBUnitDropRuleDesc, UnitDropRuleDesc>.Get().GetAll().List;
		for (int num7 = 0; num7 < list11.Count; num7++)
		{
			_ = list11[num7].Id;
		}
		RepeatedField<CommDropRuleDesc> list12 = GSProtobufRuntimeAPI<TBCommDropRuleDesc, CommDropRuleDesc>.Get().GetAll().List;
		for (int num8 = 0; num8 < list12.Count; num8++)
		{
			_ = list12[num8].DropId;
		}
		RepeatedField<MultiplayerDropRuleDesc> list13 = GSProtobufRuntimeAPI<TBMultiplayerDropRuleDesc, MultiplayerDropRuleDesc>.Get().GetAll().List;
		for (int num9 = 0; num9 < list13.Count; num9++)
		{
			_ = list13[num9].Id;
		}
		RepeatedField<UnitDropNumDesc> list14 = GSProtobufRuntimeAPI<TBUnitDropNumDesc, UnitDropNumDesc>.Get().GetAll().List;
		for (int num10 = 0; num10 < list14.Count; num10++)
		{
			_ = list14[num10].Id;
		}
		RepeatedField<SpellDesc> list15 = GSProtobufRuntimeAPI<TBSpellDesc, SpellDesc>.Get().GetAll().List;
		for (int num11 = 0; num11 < list15.Count; num11++)
		{
			SpellDesc spellDesc = list15[num11];
			int id5 = spellDesc.Id;
			TableContentList.Add(new Tuple<string, string>($"SpellDesc[{id5}].Name", spellDesc.Name));
			TableContentList.Add(new Tuple<string, string>($"SpellDesc[{id5}].InputDesc", spellDesc.InputDesc));
		}
		RepeatedField<ShopItemDesc> list16 = GSProtobufRuntimeAPI<TBShopItemDesc, ShopItemDesc>.Get().GetAll().List;
		for (int num12 = 0; num12 < list16.Count; num12++)
		{
			_ = list16[num12].Id;
		}
		RepeatedField<ShopDesc> list17 = GSProtobufRuntimeAPI<TBShopDesc, ShopDesc>.Get().GetAll().List;
		for (int num13 = 0; num13 < list17.Count; num13++)
		{
			ShopDesc shopDesc = list17[num13];
			int id6 = shopDesc.Id;
			TableContentList.Add(new Tuple<string, string>($"ShopDesc[{id6}].ConversationEnter", shopDesc.ConversationEnter));
			TableContentList.Add(new Tuple<string, string>($"ShopDesc[{id6}].ConversationBuy", shopDesc.ConversationBuy));
			TableContentList.Add(new Tuple<string, string>($"ShopDesc[{id6}].ConversationLeave", shopDesc.ConversationLeave));
			TableContentList.Add(new Tuple<string, string>($"ShopDesc[{id6}].ConversationNoConsume", shopDesc.ConversationNoConsume));
		}
		RepeatedField<ShopItemGroupDesc> list18 = GSProtobufRuntimeAPI<TBShopItemGroupDesc, ShopItemGroupDesc>.Get().GetAll().List;
		for (int num14 = 0; num14 < list18.Count; num14++)
		{
			_ = list18[num14].GroupId;
		}
		RepeatedField<ShopRefreshDesc> list19 = GSProtobufRuntimeAPI<TBShopRefreshDesc, ShopRefreshDesc>.Get().GetAll().List;
		for (int num15 = 0; num15 < list19.Count; num15++)
		{
			_ = list19[num15].Id;
		}
		RepeatedField<CollectionDropDesc> list20 = GSProtobufRuntimeAPI<TBCollectionDropDesc, CollectionDropDesc>.Get().GetAll().List;
		for (int num16 = 0; num16 < list20.Count; num16++)
		{
			CollectionDropDesc collectionDropDesc = list20[num16];
			int id7 = collectionDropDesc.Id;
			TableContentList.Add(new Tuple<string, string>($"CollectionDropDesc[{id7}].DropEfx", collectionDropDesc.DropEfx));
		}
		RepeatedField<DestructionDropDesc> list21 = GSProtobufRuntimeAPI<TBDestructionDropDesc, DestructionDropDesc>.Get().GetAll().List;
		for (int num17 = 0; num17 < list21.Count; num17++)
		{
			_ = list21[num17].Id;
		}
		RepeatedField<LevelDesc> list22 = GSProtobufRuntimeAPI<TBLevelDesc, LevelDesc>.Get().GetAll().List;
		for (int num18 = 0; num18 < list22.Count; num18++)
		{
			LevelDesc levelDesc = list22[num18];
			int id8 = levelDesc.Id;
			TableContentList.Add(new Tuple<string, string>($"LevelDesc[{id8}].Name", levelDesc.Name));
			TableContentList.Add(new Tuple<string, string>($"LevelDesc[{id8}].Path", levelDesc.Path));
			TableContentList.Add(new Tuple<string, string>($"LevelDesc[{id8}].Desc", levelDesc.Desc));
			TableContentList.Add(new Tuple<string, string>($"LevelDesc[{id8}].RebirthGroupName", levelDesc.RebirthGroupName));
			TableContentList.Add(new Tuple<string, string>($"LevelDesc[{id8}].RootQuestGraphPath", levelDesc.RootQuestGraphPath));
			TableContentList.Add(new Tuple<string, string>($"LevelDesc[{id8}].LevelGroupPatrolDataAssetPath", levelDesc.LevelGroupPatrolDataAssetPath));
			TableContentList.Add(new Tuple<string, string>($"LevelDesc[{id8}].LevelDefaultBgmConfigPath", levelDesc.LevelDefaultBgmConfigPath));
			TableContentList.Add(new Tuple<string, string>($"LevelDesc[{id8}].LevelHatredBattleConfig", levelDesc.LevelHatredBattleConfig));
			TableContentList.Add(new Tuple<string, string>($"LevelDesc[{id8}].PasslevelUrl", levelDesc.PasslevelUrl));
			TableContentList.Add(new Tuple<string, string>($"LevelDesc[{id8}].LevelUiConfigPath", levelDesc.LevelUiConfigPath));
		}
		RepeatedField<TalentRankDesc> list23 = GSProtobufRuntimeAPI<TBTalentRankDesc, TalentRankDesc>.Get().GetAll().List;
		for (int num19 = 0; num19 < list23.Count; num19++)
		{
			_ = list23[num19].SpellType;
		}
		RepeatedField<TalentSDesc> list24 = GSProtobufRuntimeAPI<TBTalentSDesc, TalentSDesc>.Get().GetAll().List;
		for (int num20 = 0; num20 < list24.Count; num20++)
		{
			TalentSDesc talentSDesc = list24[num20];
			int id9 = talentSDesc.Id;
			TableContentList.Add(new Tuple<string, string>($"TalentSDesc[{id9}].Name", talentSDesc.Name));
			TableContentList.Add(new Tuple<string, string>($"TalentSDesc[{id9}].UnitResIDStrs", talentSDesc.UnitResIDStrs));
			TableContentList.Add(new Tuple<string, string>($"TalentSDesc[{id9}].PassiveSkillIDs", talentSDesc.PassiveSkillIDs));
			TableContentList.Add(new Tuple<string, string>($"TalentSDesc[{id9}].AddBuffIDs", talentSDesc.AddBuffIDs));
		}
		RepeatedField<RoleDataConfigDesc> list25 = GSProtobufRuntimeAPI<TBRoleDataConfigDesc, RoleDataConfigDesc>.Get().GetAll().List;
		for (int num21 = 0; num21 < list25.Count; num21++)
		{
			RoleDataConfigDesc roleDataConfigDesc = list25[num21];
			int num22 = roleDataConfigDesc.Group;
			TableContentList.Add(new Tuple<string, string>($"RoleDataConfigDesc[{num22}].Desc", roleDataConfigDesc.Desc));
		}
		RepeatedField<MapAreaConfigDesc> list26 = GSProtobufRuntimeAPI<TBMapAreaConfigDesc, MapAreaConfigDesc>.Get().GetAll().List;
		for (int num23 = 0; num23 < list26.Count; num23++)
		{
			MapAreaConfigDesc mapAreaConfigDesc = list26[num23];
			int id10 = mapAreaConfigDesc.Id;
			TableContentList.Add(new Tuple<string, string>($"MapAreaConfigDesc[{id10}].AreaName", mapAreaConfigDesc.AreaName));
			TableContentList.Add(new Tuple<string, string>($"MapAreaConfigDesc[{id10}].AreaColor", mapAreaConfigDesc.AreaColor));
		}
		RepeatedField<MapSpriteConfigDesc> list27 = GSProtobufRuntimeAPI<TBMapSpriteConfigDesc, MapSpriteConfigDesc>.Get().GetAll().List;
		for (int num24 = 0; num24 < list27.Count; num24++)
		{
			_ = list27[num24].Id;
		}
		RepeatedField<MapAtlasConfigDesc> list28 = GSProtobufRuntimeAPI<TBMapAtlasConfigDesc, MapAtlasConfigDesc>.Get().GetAll().List;
		for (int num25 = 0; num25 < list28.Count; num25++)
		{
			MapAtlasConfigDesc mapAtlasConfigDesc = list28[num25];
			int id11 = mapAtlasConfigDesc.Id;
			TableContentList.Add(new Tuple<string, string>($"MapAtlasConfigDesc[{id11}].AtlasName", mapAtlasConfigDesc.AtlasName));
		}
		RepeatedField<NewGamePlusDesc> list29 = GSProtobufRuntimeAPI<TBNewGamePlusDesc, NewGamePlusDesc>.Get().GetAll().List;
		for (int num26 = 0; num26 < list29.Count; num26++)
		{
			_ = list29[num26].Quality;
		}
		RepeatedField<IncreaseConfigDesc> list30 = GSProtobufRuntimeAPI<TBIncreaseConfigDesc, IncreaseConfigDesc>.Get().GetAll().List;
		for (int num27 = 0; num27 < list30.Count; num27++)
		{
			_ = list30[num27].Id;
		}
		RepeatedField<CommonErrorUITipsDesc> list31 = GSProtobufRuntimeAPI<TBCommonErrorUITipsDesc, CommonErrorUITipsDesc>.Get().GetAll().List;
		for (int num28 = 0; num28 < list31.Count; num28++)
		{
			CommonErrorUITipsDesc commonErrorUITipsDesc = list31[num28];
			int id12 = commonErrorUITipsDesc.Id;
			TableContentList.Add(new Tuple<string, string>($"CommonErrorUITipsDesc[{id12}].ErrorTips", commonErrorUITipsDesc.ErrorTips));
		}
		RepeatedField<WineDesc> list32 = GSProtobufRuntimeAPI<TBWineDesc, WineDesc>.Get().GetAll().List;
		for (int num29 = 0; num29 < list32.Count; num29++)
		{
			WineDesc wineDesc = list32[num29];
			int id13 = wineDesc.Id;
			for (int num30 = 0; num30 < wineDesc.UpgradeDesc.Count; num30++)
			{
				TableContentList.Add(new Tuple<string, string>($"WineDesc[{id13}].UpgradeDesc[{num30}]", wineDesc.UpgradeDesc[num30]));
			}
		}
		RepeatedField<HuluDesc> list33 = GSProtobufRuntimeAPI<TBHuluDesc, HuluDesc>.Get().GetAll().List;
		for (int num31 = 0; num31 < list33.Count; num31++)
		{
			HuluDesc huluDesc = list33[num31];
			int id14 = huluDesc.Id;
			for (int num32 = 0; num32 < huluDesc.UpgradeDesc.Count; num32++)
			{
				TableContentList.Add(new Tuple<string, string>($"HuluDesc[{id14}].UpgradeDesc[{num32}]", huluDesc.UpgradeDesc[num32]));
			}
		}
		RepeatedField<ItemRecipeDesc> list34 = GSProtobufRuntimeAPI<TBItemRecipeDesc, ItemRecipeDesc>.Get().GetAll().List;
		for (int num33 = 0; num33 < list34.Count; num33++)
		{
			_ = list34[num33].Id;
		}
		RepeatedField<CardDesc> list35 = GSProtobufRuntimeAPI<TBCardDesc, CardDesc>.Get().GetAll().List;
		for (int num34 = 0; num34 < list35.Count; num34++)
		{
			CardDesc cardDesc = list35[num34];
			int id15 = cardDesc.Id;
			TableContentList.Add(new Tuple<string, string>($"CardDesc[{id15}].UnitName", cardDesc.UnitName));
			TableContentList.Add(new Tuple<string, string>($"CardDesc[{id15}].UnitPoetry", cardDesc.UnitPoetry));
			TableContentList.Add(new Tuple<string, string>($"CardDesc[{id15}].StoryBrief", cardDesc.StoryBrief));
			for (int num35 = 0; num35 < cardDesc.CardStory.Count; num35++)
			{
				TableContentList.Add(new Tuple<string, string>($"CardDesc[{id15}].CardStory[{num35}].UnitStory", cardDesc.CardStory[num35].UnitStory));
			}
		}
		RepeatedField<AchievementDesc> list36 = GSProtobufRuntimeAPI<TBAchievementDesc, AchievementDesc>.Get().GetAll().List;
		for (int num36 = 0; num36 < list36.Count; num36++)
		{
			AchievementDesc achievementDesc = list36[num36];
			int id16 = achievementDesc.Id;
			TableContentList.Add(new Tuple<string, string>($"AchievementDesc[{id16}].Name", achievementDesc.Name));
			TableContentList.Add(new Tuple<string, string>($"AchievementDesc[{id16}].AchiDesc", achievementDesc.AchiDesc));
			for (int num37 = 0; num37 < achievementDesc.RequirementGuid.Count; num37++)
			{
				TableContentList.Add(new Tuple<string, string>($"AchievementDesc[{id16}].RequirementGuid[{num37}]", achievementDesc.RequirementGuid[num37]));
			}
		}
		RepeatedField<AlchemyOutputDesc> list37 = GSProtobufRuntimeAPI<TBAlchemyOutputDesc, AlchemyOutputDesc>.Get().GetAll().List;
		for (int num38 = 0; num38 < list37.Count; num38++)
		{
			_ = list37[num38].Id;
		}
		RepeatedField<MeditationPointDesc> list38 = GSProtobufRuntimeAPI<TBMeditationPointDesc, MeditationPointDesc>.Get().GetAll().List;
		for (int num39 = 0; num39 < list38.Count; num39++)
		{
			MeditationPointDesc meditationPointDesc = list38[num39];
			int id17 = meditationPointDesc.Id;
			TableContentList.Add(new Tuple<string, string>($"MeditationPointDesc[{id17}].Name", meditationPointDesc.Name));
			TableContentList.Add(new Tuple<string, string>($"MeditationPointDesc[{id17}].SceneName", meditationPointDesc.SceneName));
			TableContentList.Add(new Tuple<string, string>($"MeditationPointDesc[{id17}].Desc", meditationPointDesc.Desc));
			TableContentList.Add(new Tuple<string, string>($"MeditationPointDesc[{id17}].AkEventPath", meditationPointDesc.AkEventPath));
		}
		RepeatedField<BloodHudDesc> list39 = GSProtobufRuntimeAPI<TBBloodHudDesc, BloodHudDesc>.Get().GetAll().List;
		for (int num40 = 0; num40 < list39.Count; num40++)
		{
			_ = list39[num40].Id;
		}
		RepeatedField<LoadingTipsDesc> list40 = GSProtobufRuntimeAPI<TBLoadingTipsDesc, LoadingTipsDesc>.Get().GetAll().List;
		for (int num41 = 0; num41 < list40.Count; num41++)
		{
			LoadingTipsDesc loadingTipsDesc = list40[num41];
			int id18 = loadingTipsDesc.Id;
			TableContentList.Add(new Tuple<string, string>($"LoadingTipsDesc[{id18}].Title", loadingTipsDesc.Title));
			TableContentList.Add(new Tuple<string, string>($"LoadingTipsDesc[{id18}].Content", loadingTipsDesc.Content));
		}
		RepeatedField<LoadingTipsWeightDesc> list41 = GSProtobufRuntimeAPI<TBLoadingTipsWeightDesc, LoadingTipsWeightDesc>.Get().GetAll().List;
		for (int num42 = 0; num42 < list41.Count; num42++)
		{
			_ = list41[num42].TipsType;
		}
		RepeatedField<MovieAndSubtitleDesc> list42 = GSProtobufRuntimeAPI<TBMovieAndSubtitleDesc, MovieAndSubtitleDesc>.Get().GetAll().List;
		for (int num43 = 0; num43 < list42.Count; num43++)
		{
			MovieAndSubtitleDesc movieAndSubtitleDesc = list42[num43];
			int id19 = movieAndSubtitleDesc.Id;
			TableContentList.Add(new Tuple<string, string>($"MovieAndSubtitleDesc[{id19}].MoviePath", movieAndSubtitleDesc.MoviePath));
			TableContentList.Add(new Tuple<string, string>($"MovieAndSubtitleDesc[{id19}].AudioVoice", movieAndSubtitleDesc.AudioVoice));
			TableContentList.Add(new Tuple<string, string>($"MovieAndSubtitleDesc[{id19}].AudioMusic", movieAndSubtitleDesc.AudioMusic));
			TableContentList.Add(new Tuple<string, string>($"MovieAndSubtitleDesc[{id19}].AudioOther", movieAndSubtitleDesc.AudioOther));
		}
		RepeatedField<InteractionFuncDesc> list43 = GSProtobufRuntimeAPI<TBInteractionFuncDesc, InteractionFuncDesc>.Get().GetAll().List;
		for (int num44 = 0; num44 < list43.Count; num44++)
		{
			InteractionFuncDesc interactionFuncDesc = list43[num44];
			int id20 = interactionFuncDesc.Id;
			TableContentList.Add(new Tuple<string, string>($"InteractionFuncDesc[{id20}].Name", interactionFuncDesc.Name));
			TableContentList.Add(new Tuple<string, string>($"InteractionFuncDesc[{id20}].Tips", interactionFuncDesc.Tips));
		}
		RepeatedField<TransInputUITipsDesc> list44 = GSProtobufRuntimeAPI<TBTransInputUITipsDesc, TransInputUITipsDesc>.Get().GetAll().List;
		for (int num45 = 0; num45 < list44.Count; num45++)
		{
			TransInputUITipsDesc transInputUITipsDesc = list44[num45];
			int id21 = transInputUITipsDesc.Id;
			TableContentList.Add(new Tuple<string, string>($"TransInputUITipsDesc[{id21}].Title", transInputUITipsDesc.Title));
			TableContentList.Add(new Tuple<string, string>($"TransInputUITipsDesc[{id21}].Content", transInputUITipsDesc.Content));
		}
		RepeatedField<UISettingConfigDesc> list45 = GSProtobufRuntimeAPI<TBUISettingConfigDesc, UISettingConfigDesc>.Get().GetAll().List;
		for (int num46 = 0; num46 < list45.Count; num46++)
		{
			UISettingConfigDesc uISettingConfigDesc = list45[num46];
			int id22 = uISettingConfigDesc.Id;
			TableContentList.Add(new Tuple<string, string>($"UISettingConfigDesc[{id22}].TempelteParam", uISettingConfigDesc.TempelteParam));
			TableContentList.Add(new Tuple<string, string>($"UISettingConfigDesc[{id22}].ConfigName", uISettingConfigDesc.ConfigName));
			TableContentList.Add(new Tuple<string, string>($"UISettingConfigDesc[{id22}].ConfigDesc", uISettingConfigDesc.ConfigDesc));
			for (int num47 = 0; num47 < uISettingConfigDesc.SettingLockInfoEx.Count; num47++)
			{
				TableContentList.Add(new Tuple<string, string>($"UISettingConfigDesc[{id22}].SettingLockInfoEx[{num47}].LockDesc", uISettingConfigDesc.SettingLockInfoEx[num47].LockDesc));
			}
		}
		RepeatedField<BossReChallengeDesc> list46 = GSProtobufRuntimeAPI<TBBossReChallengeDesc, BossReChallengeDesc>.Get().GetAll().List;
		for (int num48 = 0; num48 < list46.Count; num48++)
		{
			_ = list46[num48].Id;
		}
		RepeatedField<BossIterationsDesc> list47 = GSProtobufRuntimeAPI<TBBossIterationsDesc, BossIterationsDesc>.Get().GetAll().List;
		for (int num49 = 0; num49 < list47.Count; num49++)
		{
			BossIterationsDesc bossIterationsDesc = list47[num49];
			int id23 = bossIterationsDesc.Id;
			TableContentList.Add(new Tuple<string, string>($"BossIterationsDesc[{id23}].GroupName", bossIterationsDesc.GroupName));
		}
		RepeatedField<BossRushDebuffDesc> list48 = GSProtobufRuntimeAPI<TBBossRushDebuffDesc, BossRushDebuffDesc>.Get().GetAll().List;
		for (int num50 = 0; num50 < list48.Count; num50++)
		{
			BossRushDebuffDesc bossRushDebuffDesc = list48[num50];
			int id24 = bossRushDebuffDesc.Id;
			TableContentList.Add(new Tuple<string, string>($"BossRushDebuffDesc[{id24}].DebuffName", bossRushDebuffDesc.DebuffName));
			TableContentList.Add(new Tuple<string, string>($"BossRushDebuffDesc[{id24}].DebuffDesc", bossRushDebuffDesc.DebuffDesc));
			TableContentList.Add(new Tuple<string, string>($"BossRushDebuffDesc[{id24}].DebuffBriefDesc", bossRushDebuffDesc.DebuffBriefDesc));
		}
		RepeatedField<RebirthPointPosDesc> list49 = GSProtobufRuntimeAPI<TBRebirthPointPosDesc, RebirthPointPosDesc>.Get().GetAll().List;
		for (int num51 = 0; num51 < list49.Count; num51++)
		{
			_ = list49[num51].Id;
		}
		RepeatedField<UISettingDeviceConfigDesc> list50 = GSProtobufRuntimeAPI<TBUISettingDeviceConfigDesc, UISettingDeviceConfigDesc>.Get().GetAll().List;
		for (int num52 = 0; num52 < list50.Count; num52++)
		{
			UISettingDeviceConfigDesc uISettingDeviceConfigDesc = list50[num52];
			int id25 = uISettingDeviceConfigDesc.Id;
			TableContentList.Add(new Tuple<string, string>($"UISettingDeviceConfigDesc[{id25}].DeviceName", uISettingDeviceConfigDesc.DeviceName));
		}
		RepeatedField<SurpriseDesc> list51 = GSProtobufRuntimeAPI<TBSurpriseDesc, SurpriseDesc>.Get().GetAll().List;
		for (int num53 = 0; num53 < list51.Count; num53++)
		{
			_ = list51[num53].Id;
		}
		RepeatedField<ChapterDesc> list52 = GSProtobufRuntimeAPI<TBChapterDesc, ChapterDesc>.Get().GetAll().List;
		for (int num54 = 0; num54 < list52.Count; num54++)
		{
			ChapterDesc chapterDesc = list52[num54];
			int id26 = chapterDesc.Id;
			TableContentList.Add(new Tuple<string, string>($"ChapterDesc[{id26}].ChapterName", chapterDesc.ChapterName));
			TableContentList.Add(new Tuple<string, string>($"ChapterDesc[{id26}].ChapterPreName", chapterDesc.ChapterPreName));
		}
		RepeatedField<HistoricDesc> list53 = GSProtobufRuntimeAPI<TBHistoricDesc, HistoricDesc>.Get().GetAll().List;
		for (int num55 = 0; num55 < list53.Count; num55++)
		{
			HistoricDesc historicDesc = list53[num55];
			int id27 = historicDesc.Id;
			TableContentList.Add(new Tuple<string, string>($"HistoricDesc[{id27}].Desc", historicDesc.Desc));
		}
		RepeatedField<PastMemoryDesc> list54 = GSProtobufRuntimeAPI<TBPastMemoryDesc, PastMemoryDesc>.Get().GetAll().List;
		for (int num56 = 0; num56 < list54.Count; num56++)
		{
			PastMemoryDesc pastMemoryDesc = list54[num56];
			int id28 = pastMemoryDesc.Id;
			TableContentList.Add(new Tuple<string, string>($"PastMemoryDesc[{id28}].Title", pastMemoryDesc.Title));
			TableContentList.Add(new Tuple<string, string>($"PastMemoryDesc[{id28}].Desc", pastMemoryDesc.Desc));
		}
		RepeatedField<ArtBookDesc> list55 = GSProtobufRuntimeAPI<TBArtBookDesc, ArtBookDesc>.Get().GetAll().List;
		for (int num57 = 0; num57 < list55.Count; num57++)
		{
			ArtBookDesc artBookDesc = list55[num57];
			int id29 = artBookDesc.Id;
			TableContentList.Add(new Tuple<string, string>($"ArtBookDesc[{id29}].Name", artBookDesc.Name));
		}
		RepeatedField<SoundTrackDesc> list56 = GSProtobufRuntimeAPI<TBSoundTrackDesc, SoundTrackDesc>.Get().GetAll().List;
		for (int num58 = 0; num58 < list56.Count; num58++)
		{
			SoundTrackDesc soundTrackDesc = list56[num58];
			int id30 = soundTrackDesc.Id;
			TableContentList.Add(new Tuple<string, string>($"SoundTrackDesc[{id30}].Name", soundTrackDesc.Name));
			TableContentList.Add(new Tuple<string, string>($"SoundTrackDesc[{id30}].Lyricist", soundTrackDesc.Lyricist));
			TableContentList.Add(new Tuple<string, string>($"SoundTrackDesc[{id30}].Arranger", soundTrackDesc.Arranger));
		}
		RepeatedField<MuseumMVDesc> list57 = GSProtobufRuntimeAPI<TBMuseumMVDesc, MuseumMVDesc>.Get().GetAll().List;
		for (int num59 = 0; num59 < list57.Count; num59++)
		{
			MuseumMVDesc museumMVDesc = list57[num59];
			int id31 = museumMVDesc.Id;
			TableContentList.Add(new Tuple<string, string>($"MuseumMVDesc[{id31}].MvName", museumMVDesc.MvName));
			TableContentList.Add(new Tuple<string, string>($"MuseumMVDesc[{id31}].Desc", museumMVDesc.Desc));
		}
		RepeatedField<ArmorEnhanceDesc> list58 = GSProtobufRuntimeAPI<TBArmorEnhanceDesc, ArmorEnhanceDesc>.Get().GetAll().List;
		for (int num60 = 0; num60 < list58.Count; num60++)
		{
			_ = list58[num60].Id;
		}
		RepeatedField<ArmorEnhanceConsumeDesc> list59 = GSProtobufRuntimeAPI<TBArmorEnhanceConsumeDesc, ArmorEnhanceConsumeDesc>.Get().GetAll().List;
		for (int num61 = 0; num61 < list59.Count; num61++)
		{
			_ = list59[num61].TargetQuality;
		}
		RepeatedField<MantraDesc> list60 = GSProtobufRuntimeAPI<TBMantraDesc, MantraDesc>.Get().GetAll().List;
		for (int num62 = 0; num62 < list60.Count; num62++)
		{
			MantraDesc mantraDesc = list60[num62];
			int id32 = mantraDesc.Id;
			TableContentList.Add(new Tuple<string, string>($"MantraDesc[{id32}].Desc", mantraDesc.Desc));
		}
		RepeatedField<MantraWeightDesc> list61 = GSProtobufRuntimeAPI<TBMantraWeightDesc, MantraWeightDesc>.Get().GetAll().List;
		for (int num63 = 0; num63 < list61.Count; num63++)
		{
			_ = list61[num63].Id;
		}
		RepeatedField<EquipSeriesDesc> list62 = GSProtobufRuntimeAPI<TBEquipSeriesDesc, EquipSeriesDesc>.Get().GetAll().List;
		for (int num64 = 0; num64 < list62.Count; num64++)
		{
			_ = list62[num64].Id;
		}
		RepeatedField<LockMantraDesc> list63 = GSProtobufRuntimeAPI<TBLockMantraDesc, LockMantraDesc>.Get().GetAll().List;
		for (int num65 = 0; num65 < list63.Count; num65++)
		{
			_ = list63[num65].Id;
		}
		RepeatedField<MantraBuildupDesc> list64 = GSProtobufRuntimeAPI<TBMantraBuildupDesc, MantraBuildupDesc>.Get().GetAll().List;
		for (int num66 = 0; num66 < list64.Count; num66++)
		{
			_ = list64[num66].Id;
		}
		RepeatedField<MapFragmentDesc> list65 = GSProtobufRuntimeAPI<TBMapFragmentDesc, MapFragmentDesc>.Get().GetAll().List;
		for (int num67 = 0; num67 < list65.Count; num67++)
		{
			_ = list65[num67].Id;
		}
		RepeatedField<SceneMonsterNameplateDesc> list66 = GSProtobufRuntimeAPI<TBSceneMonsterNameplateDesc, SceneMonsterNameplateDesc>.Get().GetAll().List;
		for (int num68 = 0; num68 < list66.Count; num68++)
		{
			SceneMonsterNameplateDesc sceneMonsterNameplateDesc = list66[num68];
			int id33 = sceneMonsterNameplateDesc.Id;
			TableContentList.Add(new Tuple<string, string>($"SceneMonsterNameplateDesc[{id33}].Name", sceneMonsterNameplateDesc.Name));
		}
		RepeatedField<SoulSkillDesc> list67 = GSProtobufRuntimeAPI<TBSoulSkillDesc, SoulSkillDesc>.Get().GetAll().List;
		for (int num69 = 0; num69 < list67.Count; num69++)
		{
			SoulSkillDesc soulSkillDesc = list67[num69];
			int id34 = soulSkillDesc.Id;
			TableContentList.Add(new Tuple<string, string>($"SoulSkillDesc[{id34}].SkillName", soulSkillDesc.SkillName));
			TableContentList.Add(new Tuple<string, string>($"SoulSkillDesc[{id34}].DAPath", soulSkillDesc.DAPath));
			TableContentList.Add(new Tuple<string, string>($"SoulSkillDesc[{id34}].LeaveFXPath", soulSkillDesc.LeaveFXPath));
			TableContentList.Add(new Tuple<string, string>($"SoulSkillDesc[{id34}].ReEnterFadeOutFXPath", soulSkillDesc.ReEnterFadeOutFXPath));
			TableContentList.Add(new Tuple<string, string>($"SoulSkillDesc[{id34}].CameraPreview", soulSkillDesc.CameraPreview));
			for (int num70 = 0; num70 < soulSkillDesc.UpgradeDesc.Count; num70++)
			{
				TableContentList.Add(new Tuple<string, string>($"SoulSkillDesc[{id34}].UpgradeDesc[{num70}]", soulSkillDesc.UpgradeDesc[num70]));
			}
			TableContentList.Add(new Tuple<string, string>($"SoulSkillDesc[{id34}].MappingRandomId", soulSkillDesc.MappingRandomId));
			TableContentList.Add(new Tuple<string, string>($"SoulSkillDesc[{id34}].EffectTalentDesc", soulSkillDesc.EffectTalentDesc));
		}
		RepeatedField<SoulSkillDropDesc> list68 = GSProtobufRuntimeAPI<TBSoulSkillDropDesc, SoulSkillDropDesc>.Get().GetAll().List;
		for (int num71 = 0; num71 < list68.Count; num71++)
		{
			SoulSkillDropDesc soulSkillDropDesc = list68[num71];
			int id35 = soulSkillDropDesc.Id;
			TableContentList.Add(new Tuple<string, string>($"SoulSkillDropDesc[{id35}].BpPath", soulSkillDropDesc.BpPath));
		}
		RepeatedField<SeedDesc> list69 = GSProtobufRuntimeAPI<TBSeedDesc, SeedDesc>.Get().GetAll().List;
		for (int num72 = 0; num72 < list69.Count; num72++)
		{
			_ = list69[num72].Id;
		}
		RepeatedField<SeedCollectionAwardDesc> list70 = GSProtobufRuntimeAPI<TBSeedCollectionAwardDesc, SeedCollectionAwardDesc>.Get().GetAll().List;
		for (int num73 = 0; num73 < list70.Count; num73++)
		{
			SeedCollectionAwardDesc seedCollectionAwardDesc = list70[num73];
			int dropId = seedCollectionAwardDesc.DropId;
			TableContentList.Add(new Tuple<string, string>($"SeedCollectionAwardDesc[{dropId}].AnimMontagePath", seedCollectionAwardDesc.AnimMontagePath));
		}
		RepeatedField<MedicineAwardDesc> list71 = GSProtobufRuntimeAPI<TBMedicineAwardDesc, MedicineAwardDesc>.Get().GetAll().List;
		for (int num74 = 0; num74 < list71.Count; num74++)
		{
			_ = list71[num74].DropId;
		}
		RepeatedField<GMMonsterTeleportDesc> list72 = GSProtobufRuntimeAPI<TBGMMonsterTeleportDesc, GMMonsterTeleportDesc>.Get().GetAll().List;
		for (int num75 = 0; num75 < list72.Count; num75++)
		{
			GMMonsterTeleportDesc gMMonsterTeleportDesc = list72[num75];
			int id36 = gMMonsterTeleportDesc.Id;
			TableContentList.Add(new Tuple<string, string>($"GMMonsterTeleportDesc[{id36}].Name", gMMonsterTeleportDesc.Name));
			TableContentList.Add(new Tuple<string, string>($"GMMonsterTeleportDesc[{id36}].ArchiveName", gMMonsterTeleportDesc.ArchiveName));
		}
		RepeatedField<PS5ActivityDesc> list73 = GSProtobufRuntimeAPI<TBPS5ActivityDesc, PS5ActivityDesc>.Get().GetAll().List;
		for (int num76 = 0; num76 < list73.Count; num76++)
		{
			PS5ActivityDesc pS5ActivityDesc = list73[num76];
			int id37 = pS5ActivityDesc.Id;
			TableContentList.Add(new Tuple<string, string>($"PS5ActivityDesc[{id37}].Name", pS5ActivityDesc.Name));
			TableContentList.Add(new Tuple<string, string>($"PS5ActivityDesc[{id37}].Description", pS5ActivityDesc.Description));
		}
		RepeatedField<PS5ActivityTaskDesc> list74 = GSProtobufRuntimeAPI<TBPS5ActivityTaskDesc, PS5ActivityTaskDesc>.Get().GetAll().List;
		for (int num77 = 0; num77 < list74.Count; num77++)
		{
			PS5ActivityTaskDesc pS5ActivityTaskDesc = list74[num77];
			int id38 = pS5ActivityTaskDesc.Id;
			TableContentList.Add(new Tuple<string, string>($"PS5ActivityTaskDesc[{id38}].Name", pS5ActivityTaskDesc.Name));
		}
		RepeatedField<PlatformAchievementLiteDesc> list75 = GSProtobufRuntimeAPI<TBPlatformAchievementLiteDesc, PlatformAchievementLiteDesc>.Get().GetAll().List;
		for (int num78 = 0; num78 < list75.Count; num78++)
		{
			_ = list75[num78].Id;
		}
		RepeatedField<PlatformAchievementDesc> list76 = GSProtobufRuntimeAPI<TBPlatformAchievementDesc, PlatformAchievementDesc>.Get().GetAll().List;
		for (int num79 = 0; num79 < list76.Count; num79++)
		{
			_ = list76[num79].Id;
		}
		RepeatedField<TakePhotoCustomSettingDesc> list77 = GSProtobufRuntimeAPI<TBTakePhotoCustomSettingDesc, TakePhotoCustomSettingDesc>.Get().GetAll().List;
		for (int num80 = 0; num80 < list77.Count; num80++)
		{
			TakePhotoCustomSettingDesc takePhotoCustomSettingDesc = list77[num80];
			int id39 = takePhotoCustomSettingDesc.Id;
			TableContentList.Add(new Tuple<string, string>($"TakePhotoCustomSettingDesc[{id39}].ConfigName", takePhotoCustomSettingDesc.ConfigName));
		}
		RepeatedField<CricketBattleUnitDesc> list78 = GSProtobufRuntimeAPI<TBCricketBattleUnitDesc, CricketBattleUnitDesc>.Get().GetAll().List;
		for (int num81 = 0; num81 < list78.Count; num81++)
		{
			CricketBattleUnitDesc cricketBattleUnitDesc = list78[num81];
			int id40 = cricketBattleUnitDesc.Id;
			TableContentList.Add(new Tuple<string, string>($"CricketBattleUnitDesc[{id40}].TamerPath", cricketBattleUnitDesc.TamerPath));
			TableContentList.Add(new Tuple<string, string>($"CricketBattleUnitDesc[{id40}].ShowAMPath", cricketBattleUnitDesc.ShowAMPath));
		}
		RepeatedField<CricketUnitAttrDesc> list79 = GSProtobufRuntimeAPI<TBCricketUnitAttrDesc, CricketUnitAttrDesc>.Get().GetAll().List;
		for (int num82 = 0; num82 < list79.Count; num82++)
		{
			_ = list79[num82].ExtentBattleId;
		}
		RepeatedField<EchoDesc> list80 = GSProtobufRuntimeAPI<TBEchoDesc, EchoDesc>.Get().GetAll().List;
		for (int num83 = 0; num83 < list80.Count; num83++)
		{
			EchoDesc echoDesc = list80[num83];
			int id41 = echoDesc.Id;
			TableContentList.Add(new Tuple<string, string>($"EchoDesc[{id41}].EchoName", echoDesc.EchoName));
		}
		RepeatedField<LinkBloodDesc> list81 = GSProtobufRuntimeAPI<TBLinkBloodDesc, LinkBloodDesc>.Get().GetAll().List;
		for (int num84 = 0; num84 < list81.Count; num84++)
		{
			LinkBloodDesc linkBloodDesc = list81[num84];
			int id42 = linkBloodDesc.Id;
			for (int num85 = 0; num85 < linkBloodDesc.Guid.Count; num85++)
			{
				TableContentList.Add(new Tuple<string, string>($"LinkBloodDesc[{id42}].Guid[{num85}]", linkBloodDesc.Guid[num85]));
			}
			TableContentList.Add(new Tuple<string, string>($"LinkBloodDesc[{id42}].GroupName", linkBloodDesc.GroupName));
		}
		RepeatedField<NPCInteractConversationDesc> list82 = GSProtobufRuntimeAPI<TBNPCInteractConversationDesc, NPCInteractConversationDesc>.Get().GetAll().List;
		for (int num86 = 0; num86 < list82.Count; num86++)
		{
			_ = list82[num86].Id;
		}
		RepeatedField<EditionAwardDesc> list83 = GSProtobufRuntimeAPI<TBEditionAwardDesc, EditionAwardDesc>.Get().GetAll().List;
		for (int num87 = 0; num87 < list83.Count; num87++)
		{
			_ = list83[num87].Id;
		}
		RepeatedField<ShrineShowNpcConfigDesc> list84 = GSProtobufRuntimeAPI<TBShrineShowNpcConfigDesc, ShrineShowNpcConfigDesc>.Get().GetAll().List;
		for (int num88 = 0; num88 < list84.Count; num88++)
		{
			ShrineShowNpcConfigDesc shrineShowNpcConfigDesc = list84[num88];
			int npcId = shrineShowNpcConfigDesc.NpcId;
			TableContentList.Add(new Tuple<string, string>($"ShrineShowNpcConfigDesc[{npcId}].WolrdLocationGen", shrineShowNpcConfigDesc.WolrdLocationGen));
		}
		RepeatedField<TeamConfigDesc> list85 = GSProtobufRuntimeAPI<TBTeamConfigDesc, TeamConfigDesc>.Get().GetAll().List;
		for (int num89 = 0; num89 < list85.Count; num89++)
		{
			TeamConfigDesc teamConfigDesc = list85[num89];
			int id43 = teamConfigDesc.Id;
			TableContentList.Add(new Tuple<string, string>($"TeamConfigDesc[{id43}].LeaderName", teamConfigDesc.LeaderName));
		}
		RepeatedField<LotteryAwardDesc> list86 = GSProtobufRuntimeAPI<TBLotteryAwardDesc, LotteryAwardDesc>.Get().GetAll().List;
		for (int num90 = 0; num90 < list86.Count; num90++)
		{
			LotteryAwardDesc lotteryAwardDesc = list86[num90];
			int id44 = lotteryAwardDesc.Id;
			TableContentList.Add(new Tuple<string, string>($"LotteryAwardDesc[{id44}].AwardName", lotteryAwardDesc.AwardName));
			TableContentList.Add(new Tuple<string, string>($"LotteryAwardDesc[{id44}].AwardImage", lotteryAwardDesc.AwardImage));
		}
	}
}
