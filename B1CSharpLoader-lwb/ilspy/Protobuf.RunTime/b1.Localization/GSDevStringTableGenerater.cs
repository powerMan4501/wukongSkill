using b1.Protobuf.DataAPI;
using b1.Protobuf.GSProtobufRuntimeAPI;
using BtlB1;
using BtlShare;
using ResB1;
using UnrealEngine.Runtime;

namespace b1.Localization;

internal class GSDevStringTableGenerater
{
	private static readonly FName localTable = new FName("LocalRuntimeStringKVMapDesc");

	public GSDevStringTableGenerater()
	{
		UGSE_UMGFuncLib.NewLocalStringTable(localTable, "LocalRuntimeStringKVMapDesc");
	}

	public void SetStringToLocalStringTable(string Key, string src)
	{
		UGSE_UMGFuncLib.SetLocalStringTableEntry(localTable, Key, src.Replace("\\n", "\n"));
	}

	public FName GetLocalTableName()
	{
		return localTable;
	}

	public void LocalizationalRuntimeItemDesc()
	{
		foreach (ItemDesc item in GSProtobufRuntimeAPI<TBItemDesc, ItemDesc>.Get().GetAll().List)
		{
			SetStringToLocalStringTable($"ItemDesc.{item.Id}.BriefDesc", item.BriefDesc);
			item.BriefDesc = $"ItemDesc.{item.Id}.BriefDesc";
			SetStringToLocalStringTable($"ItemDesc.{item.Id}.Desc", item.Desc);
			item.Desc = $"ItemDesc.{item.Id}.Desc";
			SetStringToLocalStringTable($"ItemDesc.{item.Id}.Name", item.Name);
			item.Name = $"ItemDesc.{item.Id}.Name";
			SetStringToLocalStringTable($"ItemDesc.{item.Id}.EffectDesc", item.EffectDesc);
			item.EffectDesc = $"ItemDesc.{item.Id}.EffectDesc";
			SetStringToLocalStringTable($"ItemDesc.{item.Id}.TypeName", item.TypeName);
			item.TypeName = $"ItemDesc.{item.Id}.TypeName";
			SetStringToLocalStringTable($"ItemDesc.{item.Id}.HudEffectDesc", item.HudEffectDesc);
			item.HudEffectDesc = $"ItemDesc.{item.Id}.HudEffectDesc";
		}
	}

	public void LocalizationalRuntimeFUStUIWordDesc()
	{
		foreach (FUStUIWordDesc value in BG_ProtobufDataAPI<FUStUIWordDesc>.Get().GetAll().Values)
		{
			SetStringToLocalStringTable($"FUStUIWordDesc.{value.ID}.Content", value.Content);
			value.Content = $"FUStUIWordDesc.{value.ID}.Content";
		}
	}

	public void LocalizationalRuntimeEquipDesc()
	{
		foreach (EquipDesc item in GSProtobufRuntimeAPI<TBEquipDesc, EquipDesc>.Get().GetAll().List)
		{
			SetStringToLocalStringTable($"EquipDesc.{item.Id}.EquipName", item.EquipName);
			item.EquipName = $"EquipDesc.{item.Id}.EquipName";
			SetStringToLocalStringTable($"EquipDesc.{item.Id}.EquipEffectDesc", item.EquipEffectDesc);
			item.EquipEffectDesc = $"EquipDesc.{item.Id}.EquipEffectDesc";
		}
	}

	public void LocalizationalRuntimeTalentSDesc()
	{
		foreach (TalentSDesc item in GSProtobufRuntimeAPI<TBTalentSDesc, TalentSDesc>.Get().GetAll().List)
		{
			SetStringToLocalStringTable($"TalentSDesc.{item.Id}.Name", item.Name);
			item.Name = $"TalentSDesc.{item.Id}.Name";
		}
	}

	public void LocalizationalRuntimeFUStSuitDesc()
	{
		foreach (FUStSuitDesc value in BG_ProtobufDataAPI<FUStSuitDesc>.Get().GetAll().Values)
		{
			for (int i = 0; i <= 2; i++)
			{
				if (i < value.SuitInfo.Count)
				{
					SetStringToLocalStringTable($"FUStSuitDesc.{value.ID}.SuitInfo__{i}.SuitEffectDesc", value.SuitInfo[i].SuitEffectDesc);
					value.SuitInfo[i].SuitEffectDesc = $"FUStSuitDesc.{value.ID}.SuitInfo__{i}.SuitEffectDesc";
				}
			}
			SetStringToLocalStringTable($"FUStSuitDesc.{value.ID}.SuitName", value.SuitName);
			value.SuitName = $"FUStSuitDesc.{value.ID}.SuitName";
			SetStringToLocalStringTable($"FUStSuitDesc.{value.ID}.RedQualityInfo.RedQualityEffectDesc", value.RedQualityInfo.RedQualityEffectDesc);
			value.RedQualityInfo.RedQualityEffectDesc = $"FUStSuitDesc.{value.ID}.RedQualityInfo.RedQualityEffectDesc";
		}
	}

	public void LocalizationalRuntimeFUStTalentDisplayDesc()
	{
		foreach (FUStTalentDisplayDesc value in BG_ProtobufDataAPI<FUStTalentDisplayDesc>.Get().GetAll().Values)
		{
			for (int i = 0; i <= 5; i++)
			{
				if (i < value.DisplayCfg.Count)
				{
					SetStringToLocalStringTable($"FUStTalentDisplayDesc.{value.ID}.DisplayCfg__{i}.Name", value.DisplayCfg[i].Name);
					value.DisplayCfg[i].Name = $"FUStTalentDisplayDesc.{value.ID}.DisplayCfg__{i}.Name";
				}
			}
			for (int j = 0; j <= 5; j++)
			{
				if (j < value.DisplayCfg.Count)
				{
					SetStringToLocalStringTable($"FUStTalentDisplayDesc.{value.ID}.DisplayCfg__{j}.EffectDesc", value.DisplayCfg[j].EffectDesc);
					value.DisplayCfg[j].EffectDesc = $"FUStTalentDisplayDesc.{value.ID}.DisplayCfg__{j}.EffectDesc";
				}
			}
			for (int k = 0; k <= 5; k++)
			{
				if (k < value.DisplayCfg.Count)
				{
					SetStringToLocalStringTable($"FUStTalentDisplayDesc.{value.ID}.DisplayCfg__{k}.NextDesc", value.DisplayCfg[k].NextDesc);
					value.DisplayCfg[k].NextDesc = $"FUStTalentDisplayDesc.{value.ID}.DisplayCfg__{k}.NextDesc";
				}
			}
			SetStringToLocalStringTable($"FUStTalentDisplayDesc.{value.ID}.InputDesc", value.InputDesc);
			value.InputDesc = $"FUStTalentDisplayDesc.{value.ID}.InputDesc";
		}
	}

	public void LocalizationalRuntimeLevelDesc()
	{
		foreach (LevelDesc item in GSProtobufRuntimeAPI<TBLevelDesc, LevelDesc>.Get().GetAll().List)
		{
			SetStringToLocalStringTable($"LevelDesc.{item.Id}.Name", item.Name);
			item.Name = $"LevelDesc.{item.Id}.Name";
			SetStringToLocalStringTable($"LevelDesc.{item.Id}.Desc", item.Desc);
			item.Desc = $"LevelDesc.{item.Id}.Desc";
			SetStringToLocalStringTable($"LevelDesc.{item.Id}.RebirthGroupName", item.RebirthGroupName);
			item.RebirthGroupName = $"LevelDesc.{item.Id}.RebirthGroupName";
		}
	}

	public void LocalizationalRuntimeFUStDialogueDesc()
	{
		foreach (FUStDialogueDesc value in BG_ProtobufDataAPI<FUStDialogueDesc>.Get().GetAll().Values)
		{
			SetStringToLocalStringTable($"FUStDialogueDesc.{value.ID}.Content", value.Content);
			value.Content = $"FUStDialogueDesc.{value.ID}.Content";
		}
	}

	public void LocalizationalRuntimeFUStRebirthPointDesc()
	{
		foreach (FUStRebirthPointDesc value in BG_ProtobufDataAPI<FUStRebirthPointDesc>.Get().GetAll().Values)
		{
			SetStringToLocalStringTable($"FUStRebirthPointDesc.{value.ID}.Name", value.Name);
			value.Name = $"FUStRebirthPointDesc.{value.ID}.Name";
		}
	}

	public void LocalizationalRuntimeUnitBattleInfoExtendDesc()
	{
		foreach (FUStUnitBattleInfoExtendDesc value in BG_ProtobufDataAPI<FUStUnitBattleInfoExtendDesc>.Get().GetAll().Values)
		{
			SetStringToLocalStringTable($"UnitBattleInfoExtendDesc.{value.ID}.UnitName", value.UnitName);
			value.UnitName = $"UnitBattleInfoExtendDesc.{value.ID}.UnitName";
		}
	}

	public void LocalizationalRuntimeCommonErrorUITipsDesc()
	{
		foreach (CommonErrorUITipsDesc item in GSProtobufRuntimeAPI<TBCommonErrorUITipsDesc, CommonErrorUITipsDesc>.Get().GetAll().List)
		{
			SetStringToLocalStringTable($"CommonErrorUITipsDesc.{item.Id}.ErrorTips", item.ErrorTips);
			item.ErrorTips = $"CommonErrorUITipsDesc.{item.Id}.ErrorTips";
		}
	}

	public void LocalizationalRuntimeLoadingTipsDesc()
	{
		foreach (LoadingTipsDesc item in GSProtobufRuntimeAPI<TBLoadingTipsDesc, LoadingTipsDesc>.Get().GetAll().List)
		{
			SetStringToLocalStringTable($"LoadingTipsDesc.{item.Id}.Title", item.Title);
			item.Title = $"LoadingTipsDesc.{item.Id}.Title";
			SetStringToLocalStringTable($"LoadingTipsDesc.{item.Id}.Content", item.Content);
			item.Content = $"LoadingTipsDesc.{item.Id}.Content";
		}
	}

	public void LocalizationalRuntimeFUStInteractionMappingDesc()
	{
		foreach (FUStInteractionMappingDesc value in BG_ProtobufDataAPI<FUStInteractionMappingDesc>.Get().GetAll().Values)
		{
			SetStringToLocalStringTable($"FUStInteractionMappingDesc.{value.ID}.InteractName", value.InteractName);
			value.InteractName = $"FUStInteractionMappingDesc.{value.ID}.InteractName";
		}
	}

	public void LocalizationalRuntimeMapAreaConfigDesc()
	{
		foreach (MapAreaConfigDesc item in GSProtobufRuntimeAPI<TBMapAreaConfigDesc, MapAreaConfigDesc>.Get().GetAll().List)
		{
			SetStringToLocalStringTable($"MapAreaConfigDesc.{item.Id}.AreaName", item.AreaName);
			item.AreaName = $"MapAreaConfigDesc.{item.Id}.AreaName";
		}
	}

	public void LocalizationalRuntimeCardDesc()
	{
		foreach (CardDesc item in GSProtobufRuntimeAPI<TBCardDesc, CardDesc>.Get().GetAll().List)
		{
			SetStringToLocalStringTable($"CardDesc.{item.Id}.UnitName", item.UnitName);
			item.UnitName = $"CardDesc.{item.Id}.UnitName";
			SetStringToLocalStringTable($"CardDesc.{item.Id}.UnitPoetry", item.UnitPoetry);
			item.UnitPoetry = $"CardDesc.{item.Id}.UnitPoetry";
			for (int i = 0; i <= 4; i++)
			{
				if (i < item.CardStory.Count)
				{
					SetStringToLocalStringTable($"CardDesc.{item.Id}.CardStory__{i}.UnitStory", item.CardStory[i].UnitStory);
					item.CardStory[i].UnitStory = $"CardDesc.{item.Id}.CardStory__{i}.UnitStory";
				}
			}
			SetStringToLocalStringTable($"CardDesc.{item.Id}.StoryBrief", item.StoryBrief);
			item.StoryBrief = $"CardDesc.{item.Id}.StoryBrief";
		}
	}

	public void LocalizationalRuntimeMeditationPointDesc()
	{
		foreach (MeditationPointDesc item in GSProtobufRuntimeAPI<TBMeditationPointDesc, MeditationPointDesc>.Get().GetAll().List)
		{
			SetStringToLocalStringTable($"MeditationPointDesc.{item.Id}.Desc", item.Desc);
			item.Desc = $"MeditationPointDesc.{item.Id}.Desc";
			SetStringToLocalStringTable($"MeditationPointDesc.{item.Id}.Name", item.Name);
			item.Name = $"MeditationPointDesc.{item.Id}.Name";
		}
	}

	public void LocalizationalRuntimeHistoricDesc()
	{
		foreach (HistoricDesc item in GSProtobufRuntimeAPI<TBHistoricDesc, HistoricDesc>.Get().GetAll().List)
		{
			SetStringToLocalStringTable($"HistoricDesc.{item.Id}.Desc", item.Desc);
			item.Desc = $"HistoricDesc.{item.Id}.Desc";
		}
	}

	public void LocalizationalRuntimeChapterDesc()
	{
		foreach (ChapterDesc item in GSProtobufRuntimeAPI<TBChapterDesc, ChapterDesc>.Get().GetAll().List)
		{
			SetStringToLocalStringTable($"ChapterDesc.{item.Id}.ChapterPreName", item.ChapterPreName);
			item.ChapterPreName = $"ChapterDesc.{item.Id}.ChapterPreName";
			SetStringToLocalStringTable($"ChapterDesc.{item.Id}.ChapterName", item.ChapterName);
			item.ChapterName = $"ChapterDesc.{item.Id}.ChapterName";
		}
	}

	public void LocalizationalRuntimeArtBookDesc()
	{
		foreach (ArtBookDesc item in GSProtobufRuntimeAPI<TBArtBookDesc, ArtBookDesc>.Get().GetAll().List)
		{
			SetStringToLocalStringTable($"ArtBookDesc.{item.Id}.Name", item.Name);
			item.Name = $"ArtBookDesc.{item.Id}.Name";
		}
	}

	public void LocalizationalRuntimeUISettingConfigDesc()
	{
		foreach (UISettingConfigDesc item in GSProtobufRuntimeAPI<TBUISettingConfigDesc, UISettingConfigDesc>.Get().GetAll().List)
		{
			SetStringToLocalStringTable($"UISettingConfigDesc.{item.Id}.ConfigName", item.ConfigName);
			item.ConfigName = $"UISettingConfigDesc.{item.Id}.ConfigName";
			SetStringToLocalStringTable($"UISettingConfigDesc.{item.Id}.ConfigDesc", item.ConfigDesc);
			item.ConfigDesc = $"UISettingConfigDesc.{item.Id}.ConfigDesc";
			for (int i = 0; i <= 1; i++)
			{
				if (i < item.SettingLockInfoEx.Count)
				{
					SetStringToLocalStringTable($"UISettingConfigDesc.{item.Id}.SettingLockInfoEx__{i}.LockDesc", item.SettingLockInfoEx[i].LockDesc);
					item.SettingLockInfoEx[i].LockDesc = $"UISettingConfigDesc.{item.Id}.SettingLockInfoEx__{i}.LockDesc";
				}
			}
		}
	}

	public void LocalizationalRuntimeEquipFaBaoAttrDesc()
	{
		foreach (EquipFaBaoAttrDesc item in GSProtobufRuntimeAPI<TBEquipFaBaoAttrDesc, EquipFaBaoAttrDesc>.Get().GetAll().List)
		{
			for (int i = 0; i <= 2; i++)
			{
				if (i < item.CarryEffectDesc.Count)
				{
					SetStringToLocalStringTable($"EquipFaBaoAttrDesc.{item.Id}.CarryEffectDesc__{i}", item.CarryEffectDesc[i]);
					item.CarryEffectDesc[i] = $"EquipFaBaoAttrDesc.{item.Id}.CarryEffectDesc__{i}";
				}
			}
		}
	}

	public void LocalizationalRuntimeSpellDesc()
	{
		foreach (SpellDesc item in GSProtobufRuntimeAPI<TBSpellDesc, SpellDesc>.Get().GetAll().List)
		{
			SetStringToLocalStringTable($"SpellDesc.{item.Id}.Name", item.Name);
			item.Name = $"SpellDesc.{item.Id}.Name";
			SetStringToLocalStringTable($"SpellDesc.{item.Id}.InputDesc", item.InputDesc);
			item.InputDesc = $"SpellDesc.{item.Id}.InputDesc";
		}
	}

	public void LocalizationalRuntimeFUStChallengeDesc()
	{
		foreach (FUStChallengeDesc value in BG_ProtobufDataAPI<FUStChallengeDesc>.Get().GetAll().Values)
		{
			SetStringToLocalStringTable($"FUStChallengeDesc.{value.ID}.ChallengeName", value.ChallengeName);
			value.ChallengeName = $"FUStChallengeDesc.{value.ID}.ChallengeName";
			SetStringToLocalStringTable($"FUStChallengeDesc.{value.ID}.ChallengeDesc", value.ChallengeDesc);
			value.ChallengeDesc = $"FUStChallengeDesc.{value.ID}.ChallengeDesc";
			SetStringToLocalStringTable($"FUStChallengeDesc.{value.ID}.EasyDesc", value.EasyDesc);
			value.EasyDesc = $"FUStChallengeDesc.{value.ID}.EasyDesc";
			SetStringToLocalStringTable($"FUStChallengeDesc.{value.ID}.NormalDesc", value.NormalDesc);
			value.NormalDesc = $"FUStChallengeDesc.{value.ID}.NormalDesc";
			SetStringToLocalStringTable($"FUStChallengeDesc.{value.ID}.HardDesc", value.HardDesc);
			value.HardDesc = $"FUStChallengeDesc.{value.ID}.HardDesc";
		}
	}

	public void LocalizationalRuntimeSceneMonsterNameplateDesc()
	{
		foreach (SceneMonsterNameplateDesc item in GSProtobufRuntimeAPI<TBSceneMonsterNameplateDesc, SceneMonsterNameplateDesc>.Get().GetAll().List)
		{
			SetStringToLocalStringTable($"SceneMonsterNameplateDesc.{item.Id}.Name", item.Name);
			item.Name = $"SceneMonsterNameplateDesc.{item.Id}.Name";
		}
	}

	public void LocalizationalRuntimeFUStGuideNodeDesc()
	{
		foreach (FUStGuideNodeDesc value in BG_ProtobufDataAPI<FUStGuideNodeDesc>.Get().GetAll().Values)
		{
			SetStringToLocalStringTable($"FUStGuideNodeDesc.{value.ID}.GuideTitle", value.GuideTitle);
			value.GuideTitle = $"FUStGuideNodeDesc.{value.ID}.GuideTitle";
			SetStringToLocalStringTable($"FUStGuideNodeDesc.{value.ID}.GuideDesc", value.GuideDesc);
			value.GuideDesc = $"FUStGuideNodeDesc.{value.ID}.GuideDesc";
			for (int i = 0; i <= 2; i++)
			{
				if (i < value.InputActionTips.Count)
				{
					SetStringToLocalStringTable($"FUStGuideNodeDesc.{value.ID}.InputActionTips__{i}.Desc", value.InputActionTips[i].Desc);
					value.InputActionTips[i].Desc = $"FUStGuideNodeDesc.{value.ID}.InputActionTips__{i}.Desc";
				}
			}
			SetStringToLocalStringTable($"FUStGuideNodeDesc.{value.ID}.InputAction", value.InputAction);
			value.InputAction = $"FUStGuideNodeDesc.{value.ID}.InputAction";
		}
	}

	public void LocalizationalRuntimeAchievementDesc()
	{
		foreach (AchievementDesc item in GSProtobufRuntimeAPI<TBAchievementDesc, AchievementDesc>.Get().GetAll().List)
		{
			SetStringToLocalStringTable($"AchievementDesc.{item.Id}.Name", item.Name);
			item.Name = $"AchievementDesc.{item.Id}.Name";
			SetStringToLocalStringTable($"AchievementDesc.{item.Id}.AchiDesc", item.AchiDesc);
			item.AchiDesc = $"AchievementDesc.{item.Id}.AchiDesc";
		}
	}

	public void LocalizationalRuntimePS5ActivityDesc()
	{
		foreach (PS5ActivityDesc item in GSProtobufRuntimeAPI<TBPS5ActivityDesc, PS5ActivityDesc>.Get().GetAll().List)
		{
			SetStringToLocalStringTable($"PS5ActivityDesc.{item.Id}.Name", item.Name);
			item.Name = $"PS5ActivityDesc.{item.Id}.Name";
			SetStringToLocalStringTable($"PS5ActivityDesc.{item.Id}.Description", item.Description);
			item.Description = $"PS5ActivityDesc.{item.Id}.Description";
		}
	}

	public void LocalizationalRuntimePS5ActivityTaskDesc()
	{
		foreach (PS5ActivityTaskDesc item in GSProtobufRuntimeAPI<TBPS5ActivityTaskDesc, PS5ActivityTaskDesc>.Get().GetAll().List)
		{
			SetStringToLocalStringTable($"PS5ActivityTaskDesc.{item.Id}.Name", item.Name);
			item.Name = $"PS5ActivityTaskDesc.{item.Id}.Name";
		}
	}

	public void LocalizationalRuntimeLinkBloodDesc()
	{
		foreach (LinkBloodDesc item in GSProtobufRuntimeAPI<TBLinkBloodDesc, LinkBloodDesc>.Get().GetAll().List)
		{
			SetStringToLocalStringTable($"LinkBloodDesc.{item.Id}.GroupName", item.GroupName);
			item.GroupName = $"LinkBloodDesc.{item.Id}.GroupName";
		}
	}

	public void LocalizationalRuntimeTakePhotoCustomSettingDesc()
	{
		foreach (TakePhotoCustomSettingDesc item in GSProtobufRuntimeAPI<TBTakePhotoCustomSettingDesc, TakePhotoCustomSettingDesc>.Get().GetAll().List)
		{
			SetStringToLocalStringTable($"TakePhotoCustomSettingDesc.{item.Id}.ConfigName", item.ConfigName);
			item.ConfigName = $"TakePhotoCustomSettingDesc.{item.Id}.ConfigName";
		}
	}

	public void LocalizationalRuntimeSoulSkillDesc()
	{
		foreach (SoulSkillDesc item in GSProtobufRuntimeAPI<TBSoulSkillDesc, SoulSkillDesc>.Get().GetAll().List)
		{
			SetStringToLocalStringTable($"SoulSkillDesc.{item.Id}.SkillName", item.SkillName);
			item.SkillName = $"SoulSkillDesc.{item.Id}.SkillName";
			for (int i = 0; i <= 2; i++)
			{
				if (i < item.UpgradeDesc.Count)
				{
					SetStringToLocalStringTable($"SoulSkillDesc.{item.Id}.UpgradeDesc__{i}", item.UpgradeDesc[i]);
					item.UpgradeDesc[i] = $"SoulSkillDesc.{item.Id}.UpgradeDesc__{i}";
				}
			}
			SetStringToLocalStringTable($"SoulSkillDesc.{item.Id}.EffectTalentDesc", item.EffectTalentDesc);
			item.EffectTalentDesc = $"SoulSkillDesc.{item.Id}.EffectTalentDesc";
		}
	}

	public void LocalizationalRuntimeEchoDesc()
	{
		foreach (EchoDesc item in GSProtobufRuntimeAPI<TBEchoDesc, EchoDesc>.Get().GetAll().List)
		{
			SetStringToLocalStringTable($"EchoDesc.{item.Id}.EchoName", item.EchoName);
			item.EchoName = $"EchoDesc.{item.Id}.EchoName";
		}
	}

	public void LocalizationalRuntimeInteractionFuncDesc()
	{
		foreach (InteractionFuncDesc item in GSProtobufRuntimeAPI<TBInteractionFuncDesc, InteractionFuncDesc>.Get().GetAll().List)
		{
			SetStringToLocalStringTable($"InteractionFuncDesc.{item.Id}.Name", item.Name);
			item.Name = $"InteractionFuncDesc.{item.Id}.Name";
			SetStringToLocalStringTable($"InteractionFuncDesc.{item.Id}.Tips", item.Tips);
			item.Tips = $"InteractionFuncDesc.{item.Id}.Tips";
		}
	}

	public void LocalizationalRuntimeFUStRebirthAreaDesc()
	{
		foreach (FUStRebirthAreaDesc value in BG_ProtobufDataAPI<FUStRebirthAreaDesc>.Get().GetAll().Values)
		{
			SetStringToLocalStringTable($"FUStRebirthAreaDesc.{value.ID}.Name", value.Name);
			value.Name = $"FUStRebirthAreaDesc.{value.ID}.Name";
		}
	}

	public void LocalizationalRuntimeHuluDesc()
	{
		foreach (HuluDesc item in GSProtobufRuntimeAPI<TBHuluDesc, HuluDesc>.Get().GetAll().List)
		{
			for (int i = 0; i <= 2; i++)
			{
				if (i < item.UpgradeDesc.Count)
				{
					SetStringToLocalStringTable($"HuluDesc.{item.Id}.UpgradeDesc__{i}", item.UpgradeDesc[i]);
					item.UpgradeDesc[i] = $"HuluDesc.{item.Id}.UpgradeDesc__{i}";
				}
			}
		}
	}

	public void LocalizationalRuntimeWineDesc()
	{
		foreach (WineDesc item in GSProtobufRuntimeAPI<TBWineDesc, WineDesc>.Get().GetAll().List)
		{
			for (int i = 0; i <= 2; i++)
			{
				if (i < item.UpgradeDesc.Count)
				{
					SetStringToLocalStringTable($"WineDesc.{item.Id}.UpgradeDesc__{i}", item.UpgradeDesc[i]);
					item.UpgradeDesc[i] = $"WineDesc.{item.Id}.UpgradeDesc__{i}";
				}
			}
		}
	}

	public void LocalizationalRuntimeFUStInteractiveUnitCommDesc()
	{
		foreach (FUStInteractiveUnitCommDesc value in BG_ProtobufDataAPI<FUStInteractiveUnitCommDesc>.Get().GetAll().Values)
		{
			SetStringToLocalStringTable($"FUStInteractiveUnitCommDesc.{value.ID}.Name", value.Name);
			value.Name = $"FUStInteractiveUnitCommDesc.{value.ID}.Name";
		}
	}

	public void LocalizationalRuntimeTransInputUITipsDesc()
	{
		foreach (TransInputUITipsDesc item in GSProtobufRuntimeAPI<TBTransInputUITipsDesc, TransInputUITipsDesc>.Get().GetAll().List)
		{
			SetStringToLocalStringTable($"TransInputUITipsDesc.{item.Id}.Title", item.Title);
			item.Title = $"TransInputUITipsDesc.{item.Id}.Title";
			SetStringToLocalStringTable($"TransInputUITipsDesc.{item.Id}.Content", item.Content);
			item.Content = $"TransInputUITipsDesc.{item.Id}.Content";
		}
	}

	public void LocalizationalRuntimeMuseumMVDesc()
	{
		foreach (MuseumMVDesc item in GSProtobufRuntimeAPI<TBMuseumMVDesc, MuseumMVDesc>.Get().GetAll().List)
		{
			SetStringToLocalStringTable($"MuseumMVDesc.{item.Id}.MvName", item.MvName);
			item.MvName = $"MuseumMVDesc.{item.Id}.MvName";
			SetStringToLocalStringTable($"MuseumMVDesc.{item.Id}.Desc", item.Desc);
			item.Desc = $"MuseumMVDesc.{item.Id}.Desc";
		}
	}

	public void LocalizationalRuntimeFUStDefeatSlowTimeConfigDesc()
	{
		foreach (FUStDefeatSlowTimeConfigDesc value in BG_ProtobufDataAPI<FUStDefeatSlowTimeConfigDesc>.Get().GetAll().Values)
		{
			SetStringToLocalStringTable($"FUStDefeatSlowTimeConfigDesc.{value.ID}.UnitDefeatedType", value.UnitDefeatedType);
			value.UnitDefeatedType = $"FUStDefeatSlowTimeConfigDesc.{value.ID}.UnitDefeatedType";
		}
	}

	public void LocalizationalRuntimeSoundTrackDesc()
	{
		foreach (SoundTrackDesc item in GSProtobufRuntimeAPI<TBSoundTrackDesc, SoundTrackDesc>.Get().GetAll().List)
		{
			SetStringToLocalStringTable($"SoundTrackDesc.{item.Id}.Name", item.Name);
			item.Name = $"SoundTrackDesc.{item.Id}.Name";
		}
	}

	public void LocalizationalRuntimeBossIterationsDesc()
	{
		foreach (BossIterationsDesc item in GSProtobufRuntimeAPI<TBBossIterationsDesc, BossIterationsDesc>.Get().GetAll().List)
		{
			SetStringToLocalStringTable($"BossIterationsDesc.{item.Id}.GroupName", item.GroupName);
			item.GroupName = $"BossIterationsDesc.{item.Id}.GroupName";
		}
	}

	public void LocalizationalRuntimeBossRushDebuffDesc()
	{
		foreach (BossRushDebuffDesc item in GSProtobufRuntimeAPI<TBBossRushDebuffDesc, BossRushDebuffDesc>.Get().GetAll().List)
		{
			SetStringToLocalStringTable($"BossRushDebuffDesc.{item.Id}.DebuffName", item.DebuffName);
			item.DebuffName = $"BossRushDebuffDesc.{item.Id}.DebuffName";
			SetStringToLocalStringTable($"BossRushDebuffDesc.{item.Id}.DebuffDesc", item.DebuffDesc);
			item.DebuffDesc = $"BossRushDebuffDesc.{item.Id}.DebuffDesc";
			SetStringToLocalStringTable($"BossRushDebuffDesc.{item.Id}.DebuffBriefDesc", item.DebuffBriefDesc);
			item.DebuffBriefDesc = $"BossRushDebuffDesc.{item.Id}.DebuffBriefDesc";
		}
	}

	public void LocalizationalRuntimeMapAtlasConfigDesc()
	{
		foreach (MapAtlasConfigDesc item in GSProtobufRuntimeAPI<TBMapAtlasConfigDesc, MapAtlasConfigDesc>.Get().GetAll().List)
		{
			SetStringToLocalStringTable($"MapAtlasConfigDesc.{item.Id}.AtlasName", item.AtlasName);
			item.AtlasName = $"MapAtlasConfigDesc.{item.Id}.AtlasName";
		}
	}

	public void LocalizationalRuntimeFUStBossRushConfigDesc()
	{
		foreach (FUStBossRushConfigDesc value in BG_ProtobufDataAPI<FUStBossRushConfigDesc>.Get().GetAll().Values)
		{
			SetStringToLocalStringTable($"FUStBossRushConfigDesc.{value.ID}.UnitDefeatType", value.UnitDefeatType);
			value.UnitDefeatType = $"FUStBossRushConfigDesc.{value.ID}.UnitDefeatType";
		}
	}

	public void GenLocalStringTable()
	{
		LocalizationalRuntimeItemDesc();
		LocalizationalRuntimeFUStUIWordDesc();
		LocalizationalRuntimeEquipDesc();
		LocalizationalRuntimeTalentSDesc();
		LocalizationalRuntimeFUStSuitDesc();
		LocalizationalRuntimeFUStTalentDisplayDesc();
		LocalizationalRuntimeLevelDesc();
		LocalizationalRuntimeFUStDialogueDesc();
		LocalizationalRuntimeFUStRebirthPointDesc();
		LocalizationalRuntimeUnitBattleInfoExtendDesc();
		LocalizationalRuntimeCommonErrorUITipsDesc();
		LocalizationalRuntimeLoadingTipsDesc();
		LocalizationalRuntimeFUStInteractionMappingDesc();
		LocalizationalRuntimeMapAreaConfigDesc();
		LocalizationalRuntimeCardDesc();
		LocalizationalRuntimeMeditationPointDesc();
		LocalizationalRuntimeHistoricDesc();
		LocalizationalRuntimeChapterDesc();
		LocalizationalRuntimeArtBookDesc();
		LocalizationalRuntimeUISettingConfigDesc();
		LocalizationalRuntimeEquipFaBaoAttrDesc();
		LocalizationalRuntimeSpellDesc();
		LocalizationalRuntimeFUStChallengeDesc();
		LocalizationalRuntimeSceneMonsterNameplateDesc();
		LocalizationalRuntimeFUStGuideNodeDesc();
		LocalizationalRuntimeAchievementDesc();
		LocalizationalRuntimePS5ActivityDesc();
		LocalizationalRuntimePS5ActivityTaskDesc();
		LocalizationalRuntimeLinkBloodDesc();
		LocalizationalRuntimeTakePhotoCustomSettingDesc();
		LocalizationalRuntimeSoulSkillDesc();
		LocalizationalRuntimeEchoDesc();
		LocalizationalRuntimeInteractionFuncDesc();
		LocalizationalRuntimeFUStRebirthAreaDesc();
		LocalizationalRuntimeHuluDesc();
		LocalizationalRuntimeWineDesc();
		LocalizationalRuntimeFUStInteractiveUnitCommDesc();
		LocalizationalRuntimeTransInputUITipsDesc();
		LocalizationalRuntimeMuseumMVDesc();
		LocalizationalRuntimeFUStDefeatSlowTimeConfigDesc();
		LocalizationalRuntimeSoundTrackDesc();
		LocalizationalRuntimeBossIterationsDesc();
		LocalizationalRuntimeBossRushDebuffDesc();
		LocalizationalRuntimeMapAtlasConfigDesc();
		LocalizationalRuntimeFUStBossRushConfigDesc();
	}
}
