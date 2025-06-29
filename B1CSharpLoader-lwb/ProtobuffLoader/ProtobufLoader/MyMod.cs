using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using b1;
using b1.Localization;
using b1.Protobuf.DataAPI;
using b1.Protobuf.GSProtobufRuntimeAPI;
using BtlB1;
using BtlShare;
using CSharpModBase;
using CSharpModBase.Input;
using Google.Protobuf;
using Google.Protobuf.Collections;
using HarmonyLib;
using ResB1;

namespace ProtobufLoader;

public class MyMod : ICSharpMod
{
	private readonly Harmony harmony;

	public static Dictionary<Type, Dictionary<int, IMessage?>> RecordBackup = new Dictionary<Type, Dictionary<int, IMessage>>();

	public static bool FirstInitCalled = false;

	public string Name => MyExten.Name;

	public string Version => "1.3.2";

	private static void Log(string i, int verLevel = 0)
	{
		MyExten.Log(i, verLevel);
	}

	private static void Error(string i, int verLevel = 0)
	{
		MyExten.Error(i, verLevel);
	}

	private static void DebugLog(string i)
	{
		MyExten.DebugLog(i);
	}

	public MyMod()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		harmony = new Harmony(Name);
	}

	public void Init()
	{
		Config.LoadConfig();
		if (Config.EnableChineseConsoleLog)
		{
			MyExten.EnableCNInConsole();
		}
		Log("MyMod::Init called.");
		Utils.RegisterKeyBind((ModifierKeys)2, (Key)118, (Action)ResetAndLoadAllDataFiles);
		Utils.RegisterKeyBind((ModifierKeys)2, (Key)119, (Action)delegate
		{
			ResetAll();
		});
		Utils.RegisterKeyBind((ModifierKeys)2, (Key)120, (Action)SuperReset);
		if (MyExten.GetWorld() == null || !GSLocalization.IsInit)
		{
			Log("World Not Ready.Skip Init");
		}
		else
		{
			Utils.TryRunOnGameThread((Action)delegate
			{
				Log("try init upon load");
				ResetAndLoadAllDataFiles();
			});
		}
		harmony.PatchAll();
	}

	public void DeInit()
	{
		ResetAll();
		Log("DeInit");
		harmony.UnpatchAll((string)null);
	}

	public void SuperReset()
	{
		BGUFunctionLibraryCS.RefreshGameDB();
		Log("Super Reset Done");
	}

	public static void ResetAndLoadAllDataFiles()
	{
		FirstInitCalled = true;
		ResetAll(refreshCache: false);
		int num = 0;
		int num2 = 0;
		string[] directories = Directory.GetDirectories("CSharpLoader\\Mods\\" + MyExten.Name);
		for (int i = 0; i < directories.Length; i++)
		{
			if (LoadDataFilesInDir(directories[i]))
			{
				num++;
			}
			num2++;
		}
		if (num2 > 0)
		{
			Log($"Load {num}/{num2} Folders Successfully");
		}
		RefreshDBCache();
	}

	public static void RefreshDBCache()
	{
		Log("Refresh DBCache", 1);
		Type typeFromHandle = typeof(BGW_GameDB);
		foreach (string item in new List<string>
		{
			"InitPartRuleUnitMap", "InitsMapAttackHitFX_ID", "InitsMapBeAttackedFX_ID", "InitCameraGroupUnitMap", "InitStraightCamUnitMap", "InitGiantCamUnitMap", "InitDiagonalCamUnitMap", "InitPassiveSkillMap", "InitUnitDeadMap", "InitSoulSkillMimicryMap",
			"InitHitSceneItemPerformMap", "InitFeatureFilterMap", "InitBuffTickRuleBySimpleStateData", "InitOnlineScreenMsgConfDict", "InitInteractMappingDict", "InitAiInteractMappingDict", "InitCustomStateMachineDict", "InitGuideAssetConfigDict", "InitActionNameTriggerEventIdDict", "InitGlobalConfigDesc",
			"InitsChallengeDescDict", "InitCollectionSpawnInfoDict", "InitBossRoomDict", "InitGlobalCannotDeadExtraCacheDict", "InitBuffDispMap", "InitBuffRuleMap", "InitElementDmgRatioLevelMapping", "InitAbnormalCommConfig", "InitBeAttackedDispInfo", "InitMapSymbolDescInfo",
			"InitGlobalAlchemyList", "InitPigsyStoryIAndRLibrary", "InitDOPerformMapping", "InitDefeatSlowTimeConfig", "InitCameraConversionParamConfig", "InitPotentialEnergyMap", "InitBossDict", "InitAbnormalDispMap", "InitAICrowdDetourlevelConfigDict", "InitBeAttackedStiffLevelMapping",
			"InitDialogue_FacialAnimPreloadMap", "InitLevelSequenceClearBattleItemConfig", "InitAkMarkerDesc", "InitFacialResourceMap", "InitSeqAudioJumpMap"
		})
		{
			MethodInfo method = typeFromHandle.GetMethod(item, BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
			if (method != null)
			{
				method.Invoke(null, new object[0]);
				DebugLog("Invoke " + method.Name);
			}
			else
			{
				Error("Can't Invoke " + item);
			}
		}
		MethodInfo method2 = typeof(GameDBRuntime).GetMethod("BuildAllDescToDict", BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
		if (method2 != null)
		{
			method2.Invoke(null, new object[0]);
			DebugLog("Invoke " + method2.Name);
		}
		else
		{
			Error("Can't Invoke BuildAllDescToDict");
		}
	}

	public static bool LoadDataFilesInDir(string dir)
	{
		int num = 0;
		int num2 = 0;
		List<string> list = new List<string>();
		foreach (string item in Directory.GetFiles(dir, "*Desc*.data").ToList())
		{
			if (item.EndsWith(".bak.data"))
			{
				Log("Ignore " + item + " because end with .bak", 1);
			}
			else if (!item.EndsWith(".insert.data"))
			{
				list.Add(item);
			}
		}
		list.Sort();
		Log($"Find {list.Count} .data files.Start Load", 1);
		foreach (string item2 in list)
		{
			if (LoadDataFile(item2, isInsertMode: false))
			{
				num2++;
			}
		}
		num += list.Count;
		List<string> list2 = new List<string>();
		foreach (string item3 in Directory.GetFiles(dir, "*Desc*.insert.data").ToList())
		{
			list2.Add(item3);
		}
		list2.Sort();
		if (list2.Count > 0)
		{
			Log($"Find {list2.Count} .insert.data files.Start Load", 1);
			foreach (string item4 in list2)
			{
				if (LoadDataFile(item4, isInsertMode: true))
				{
					num2++;
				}
			}
			num += list2.Count;
		}
		if (num > 0)
		{
			Log($"Load {num2}/{num} successfully in Dir {dir}");
		}
		return num2 == num;
	}

	public static bool LoadDataFile(string filepath, bool isInsertMode)
	{
		string name = new FileInfo(filepath).Name;
		string text = name.Substring(0, name.IndexOf("Desc") + 4);
		switch (text)
		{
		case "FUStInteractiveUnitCommDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStInteractiveUnitCommDesc>(filepath, name, text, isInsertMode);
		case "FUStInteractionMappingDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStInteractionMappingDesc>(filepath, name, text, isInsertMode);
		case "FUStAiInteractionMappingDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStAiInteractionMappingDesc>(filepath, name, text, isInsertMode);
		case "FUStBuffDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStBuffDesc>(filepath, name, text, isInsertMode);
		case "FUStChargeSkillSDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStChargeSkillSDesc>(filepath, name, text, isInsertMode);
		case "FUStDropItemDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStDropItemDesc>(filepath, name, text, isInsertMode);
		case "FUStHitVEffectDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStHitVEffectDesc>(filepath, name, text, isInsertMode);
		case "FUStQTEDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStQTEDesc>(filepath, name, text, isInsertMode);
		case "FUStSummonCommDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStSummonCommDesc>(filepath, name, text, isInsertMode);
		case "FUStPhysicalHitBoneRuleDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStPhysicalHitBoneRuleDesc>(filepath, name, text, isInsertMode);
		case "FUStRebirthPointDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStRebirthPointDesc>(filepath, name, text, isInsertMode);
		case "FUStStraightCamDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStStraightCamDesc>(filepath, name, text, isInsertMode);
		case "FUStMultiPointLockCameraConfigDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStMultiPointLockCameraConfigDesc>(filepath, name, text, isInsertMode);
		case "FUStDiagonalCamDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStDiagonalCamDesc>(filepath, name, text, isInsertMode);
		case "FUStGiantLockCameraDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStGiantLockCameraDesc>(filepath, name, text, isInsertMode);
		case "FUStUnitCollisionHitMoveDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStUnitCollisionHitMoveDesc>(filepath, name, text, isInsertMode);
		case "FUStBuffDispDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStBuffDispDesc>(filepath, name, text, isInsertMode);
		case "FUStBuffLayerDispDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStBuffLayerDispDesc>(filepath, name, text, isInsertMode);
		case "FUStExAnimDataDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStExAnimDataDesc>(filepath, name, text, isInsertMode);
		case "FUStUnitCommDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStUnitCommDesc>(filepath, name, text, isInsertMode);
		case "FUStUnitBattleInfoExtendDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStUnitBattleInfoExtendDesc>(filepath, name, text, isInsertMode);
		case "FUStUnitPassiveSkillInfoExtendDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStUnitPassiveSkillInfoExtendDesc>(filepath, name, text, isInsertMode);
		case "FUStUnitEnvMaskConfigDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStUnitEnvMaskConfigDesc>(filepath, name, text, isInsertMode);
		case "FUStSkillAIDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStSkillAIDesc>(filepath, name, text, isInsertMode);
		case "FUStSkillEffectDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStSkillEffectDesc>(filepath, name, text, isInsertMode);
		case "FUStSkillSDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStSkillSDesc>(filepath, name, text, isInsertMode);
		case "FUStSkillSMappingDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStSkillSMappingDesc>(filepath, name, text, isInsertMode);
		case "FUStEnvironmentSwitchDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStEnvironmentSwitchDesc>(filepath, name, text, isInsertMode);
		case "FUStBulletSwitchDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStBulletSwitchDesc>(filepath, name, text, isInsertMode);
		case "FUStUnitAIDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStUnitAIDesc>(filepath, name, text, isInsertMode);
		case "FUStUnitTransCommDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStUnitTransCommDesc>(filepath, name, text, isInsertMode);
		case "FUStRollSkillDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStRollSkillDesc>(filepath, name, text, isInsertMode);
		case "FUStUnitDropDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStUnitDropDesc>(filepath, name, text, isInsertMode);
		case "FUStNianhuiNameListDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStNianhuiNameListDesc>(filepath, name, text, isInsertMode);
		case "FUStNianhuiAwardDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStNianhuiAwardDesc>(filepath, name, text, isInsertMode);
		case "FUStBeAttackedInfoDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStBeAttackedInfoDesc>(filepath, name, text, isInsertMode);
		case "FUStBeAttackedDispInfoDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStBeAttackedDispInfoDesc>(filepath, name, text, isInsertMode);
		case "FUStScarInfoDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStScarInfoDesc>(filepath, name, text, isInsertMode);
		case "FUStPlayerSkillCtrlDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStPlayerSkillCtrlDesc>(filepath, name, text, isInsertMode);
		case "FUStOverlyingSkillSDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStOverlyingSkillSDesc>(filepath, name, text, isInsertMode);
		case "FUStBuffGroupDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStBuffGroupDesc>(filepath, name, text, isInsertMode);
		case "FUStBuffRuleDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStBuffRuleDesc>(filepath, name, text, isInsertMode);
		case "FUStMandatoryAITaskDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStMandatoryAITaskDesc>(filepath, name, text, isInsertMode);
		case "FUStAttackHitAudioInfoDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStAttackHitAudioInfoDesc>(filepath, name, text, isInsertMode);
		case "FUStPlayerCameraDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStPlayerCameraDesc>(filepath, name, text, isInsertMode);
		case "FUStPlayerTransAttrDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStPlayerTransAttrDesc>(filepath, name, text, isInsertMode);
		case "FUStAttackHitFXMapDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStAttackHitFXMapDesc>(filepath, name, text, isInsertMode);
		case "FUStBeAttackedFXMapDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStBeAttackedFXMapDesc>(filepath, name, text, isInsertMode);
		case "FUStPlayerCommDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStPlayerCommDesc>(filepath, name, text, isInsertMode);
		case "FUStUnitDeadDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStUnitDeadDesc>(filepath, name, text, isInsertMode);
		case "FUStUnitDeadSwitchToPhysicDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStUnitDeadSwitchToPhysicDesc>(filepath, name, text, isInsertMode);
		case "FUStUnitDeadOldDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStUnitDeadOldDesc>(filepath, name, text, isInsertMode);
		case "FUStHitSceneItemPerformDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStHitSceneItemPerformDesc>(filepath, name, text, isInsertMode);
		case "FUStUnitFootstepDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStUnitFootstepDesc>(filepath, name, text, isInsertMode);
		case "FUStEQSSettingDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStEQSSettingDesc>(filepath, name, text, isInsertMode);
		case "FUStPassiveSkillDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStPassiveSkillDesc>(filepath, name, text, isInsertMode);
		case "FUStAISkillBasicActionDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStAISkillBasicActionDesc>(filepath, name, text, isInsertMode);
		case "FUStUnitAudioBankMapDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStUnitAudioBankMapDesc>(filepath, name, text, isInsertMode);
		case "FUStAISkillTagsDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStAISkillTagsDesc>(filepath, name, text, isInsertMode);
		case "FUStAIThinkDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStAIThinkDesc>(filepath, name, text, isInsertMode);
		case "FUStAIActionDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStAIActionDesc>(filepath, name, text, isInsertMode);
		case "FUStAIFeatureDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStAIFeatureDesc>(filepath, name, text, isInsertMode);
		case "FUStProjectileCommDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStProjectileCommDesc>(filepath, name, text, isInsertMode);
		case "FUStProjectileDispDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStProjectileDispDesc>(filepath, name, text, isInsertMode);
		case "FUStProjectileMoveDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStProjectileMoveDesc>(filepath, name, text, isInsertMode);
		case "FUStBulletExpandDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStBulletExpandDesc>(filepath, name, text, isInsertMode);
		case "FUStMagicFieldExpandDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStMagicFieldExpandDesc>(filepath, name, text, isInsertMode);
		case "FUStBulletWindFieldExpandDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStBulletWindFieldExpandDesc>(filepath, name, text, isInsertMode);
		case "FUStUnitSpecialMoveDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStUnitSpecialMoveDesc>(filepath, name, text, isInsertMode);
		case "FUStUnitLevelUpDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStUnitLevelUpDesc>(filepath, name, text, isInsertMode);
		case "FUStPartRuleInfoDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStPartRuleInfoDesc>(filepath, name, text, isInsertMode);
		case "FUStAttackerHitFXMappingDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStAttackerHitFXMappingDesc>(filepath, name, text, isInsertMode);
		case "FUStAttackerHitAudioEventMappingDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStAttackerHitAudioEventMappingDesc>(filepath, name, text, isInsertMode);
		case "FUStBuffTickRuleBySimpleStateDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStBuffTickRuleBySimpleStateDesc>(filepath, name, text, isInsertMode);
		case "FUStUnitPhysicalAnimationDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStUnitPhysicalAnimationDesc>(filepath, name, text, isInsertMode);
		case "FUStMovieSequenceDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStMovieSequenceDesc>(filepath, name, text, isInsertMode);
		case "FUStSuitDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStSuitDesc>(filepath, name, text, isInsertMode);
		case "FUStCameraGroupDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStCameraGroupDesc>(filepath, name, text, isInsertMode);
		case "FUStFixFunctionDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStFixFunctionDesc>(filepath, name, text, isInsertMode);
		case "FUStGroupAISDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStGroupAISDesc>(filepath, name, text, isInsertMode);
		case "FUStDialogueDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStDialogueDesc>(filepath, name, text, isInsertMode);
		case "FUStDialogueIDMappingDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStDialogueIDMappingDesc>(filepath, name, text, isInsertMode);
		case "FUStUIWordDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStUIWordDesc>(filepath, name, text, isInsertMode);
		case "FUStTalentDisplayDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStTalentDisplayDesc>(filepath, name, text, isInsertMode);
		case "FUStTalentLvUpCfgDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStTalentLvUpCfgDesc>(filepath, name, text, isInsertMode);
		case "FUStAiConversationEventDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStAiConversationEventDesc>(filepath, name, text, isInsertMode);
		case "FUStAiConversationContentDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStAiConversationContentDesc>(filepath, name, text, isInsertMode);
		case "FUStOnlineScreenMsgConfDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStOnlineScreenMsgConfDesc>(filepath, name, text, isInsertMode);
		case "FUStRichTextIconDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStRichTextIconDesc>(filepath, name, text, isInsertMode);
		case "FUStIronBodyConfigDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStIronBodyConfigDesc>(filepath, name, text, isInsertMode);
		case "FUStImmobilizeSkillConfigDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStImmobilizeSkillConfigDesc>(filepath, name, text, isInsertMode);
		case "FUStSealingSpellSkillConfigDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStSealingSpellSkillConfigDesc>(filepath, name, text, isInsertMode);
		case "FUStTransQiTianDaShengConfigDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStTransQiTianDaShengConfigDesc>(filepath, name, text, isInsertMode);
		case "FUStPhantomRushSkillConfigDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStPhantomRushSkillConfigDesc>(filepath, name, text, isInsertMode);
		case "FUStPlayerInputSkillMappingDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStPlayerInputSkillMappingDesc>(filepath, name, text, isInsertMode);
		case "FUStTaskStageDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStTaskStageDesc>(filepath, name, text, isInsertMode);
		case "FUStTaskLineDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStTaskLineDesc>(filepath, name, text, isInsertMode);
		case "FUStSuperArmorLevelDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStSuperArmorLevelDesc>(filepath, name, text, isInsertMode);
		case "FUStCollectionSpawnGroupDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStCollectionSpawnGroupDesc>(filepath, name, text, isInsertMode);
		case "FUStCollectionEventProbabilityDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStCollectionEventProbabilityDesc>(filepath, name, text, isInsertMode);
		case "FUStCustomStateMachineDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStCustomStateMachineDesc>(filepath, name, text, isInsertMode);
		case "FUStGuideAssetConfigDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStGuideAssetConfigDesc>(filepath, name, text, isInsertMode);
		case "FUStNPCBaseInfoDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStNPCBaseInfoDesc>(filepath, name, text, isInsertMode);
		case "FUStEnhancedInputActionDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStEnhancedInputActionDesc>(filepath, name, text, isInsertMode);
		case "FUStSkillDamageExpandDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStSkillDamageExpandDesc>(filepath, name, text, isInsertMode);
		case "FUStPotentialEnergyConfigDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStPotentialEnergyConfigDesc>(filepath, name, text, isInsertMode);
		case "FUStGlobalConfigDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStGlobalConfigDesc>(filepath, name, text, isInsertMode);
		case "FUStTeamRelationConfigDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStTeamRelationConfigDesc>(filepath, name, text, isInsertMode);
		case "FUStAiConversationGroupDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStAiConversationGroupDesc>(filepath, name, text, isInsertMode);
		case "FUStAssociationUnitInfoSDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStAssociationUnitInfoSDesc>(filepath, name, text, isInsertMode);
		case "FUStUnitIntelligenceInfoDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStUnitIntelligenceInfoDesc>(filepath, name, text, isInsertMode);
		case "FUStCBGTemplateDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStCBGTemplateDesc>(filepath, name, text, isInsertMode);
		case "FUStTamerStrategyConfigDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStTamerStrategyConfigDesc>(filepath, name, text, isInsertMode);
		case "FUStTROStrategyConfigDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStTROStrategyConfigDesc>(filepath, name, text, isInsertMode);
		case "FUStSummonCopySkillDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStSummonCopySkillDesc>(filepath, name, text, isInsertMode);
		case "FUStUnitChangeMaterialByAttrDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStUnitChangeMaterialByAttrDesc>(filepath, name, text, isInsertMode);
		case "FUStCCGCastSkillMappingRuleDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStCCGCastSkillMappingRuleDesc>(filepath, name, text, isInsertMode);
		case "FUStWeakPerformConfigDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStWeakPerformConfigDesc>(filepath, name, text, isInsertMode);
		case "FUStFollowPartnerConfigDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStFollowPartnerConfigDesc>(filepath, name, text, isInsertMode);
		case "FUStChallengeDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStChallengeDesc>(filepath, name, text, isInsertMode);
		case "FUStBossRoomConfigDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStBossRoomConfigDesc>(filepath, name, text, isInsertMode);
		case "FUStGlobalCannotDeadExtraConfigDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStGlobalCannotDeadExtraConfigDesc>(filepath, name, text, isInsertMode);
		case "FUStEnvironmentSurfaceEffectDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStEnvironmentSurfaceEffectDesc>(filepath, name, text, isInsertMode);
		case "FUStSweepCheckDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStSweepCheckDesc>(filepath, name, text, isInsertMode);
		case "FUStAudioExtendDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStAudioExtendDesc>(filepath, name, text, isInsertMode);
		case "FUStBuffIconDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStBuffIconDesc>(filepath, name, text, isInsertMode);
		case "FUStPartHitExpandDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStPartHitExpandDesc>(filepath, name, text, isInsertMode);
		case "FUStDetonateConfigDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStDetonateConfigDesc>(filepath, name, text, isInsertMode);
		case "FUStAttachedNiagaraByHitDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStAttachedNiagaraByHitDesc>(filepath, name, text, isInsertMode);
		case "FUStAbnormalStateUIBlackListDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStAbnormalStateUIBlackListDesc>(filepath, name, text, isInsertMode);
		case "FUStElementDmgRatioLevelDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStElementDmgRatioLevelDesc>(filepath, name, text, isInsertMode);
		case "FUStAbnormalCommConfigDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStAbnormalCommConfigDesc>(filepath, name, text, isInsertMode);
		case "FUStStreamingLevelStateDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStStreamingLevelStateDesc>(filepath, name, text, isInsertMode);
		case "FUStMapSymbolDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStMapSymbolDesc>(filepath, name, text, isInsertMode);
		case "FUStAttrCopyConfigDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStAttrCopyConfigDesc>(filepath, name, text, isInsertMode);
		case "FUStPlayerTransUnitConfDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStPlayerTransUnitConfDesc>(filepath, name, text, isInsertMode);
		case "FUStLifeSavingHairConfigDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStLifeSavingHairConfigDesc>(filepath, name, text, isInsertMode);
		case "FUStPigsyStoryLibraryDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStPigsyStoryLibraryDesc>(filepath, name, text, isInsertMode);
		case "FUStPigsyStoryIAndRLibraryDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStPigsyStoryIAndRLibraryDesc>(filepath, name, text, isInsertMode);
		case "FUStGuideGroupDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStGuideGroupDesc>(filepath, name, text, isInsertMode);
		case "FUStGuideNodeDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStGuideNodeDesc>(filepath, name, text, isInsertMode);
		case "FUStDynamicObstaclePerformanceDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStDynamicObstaclePerformanceDesc>(filepath, name, text, isInsertMode);
		case "FUStDefeatSlowTimeConfigDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStDefeatSlowTimeConfigDesc>(filepath, name, text, isInsertMode);
		case "FUStBuffDispGroupDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStBuffDispGroupDesc>(filepath, name, text, isInsertMode);
		case "FUStSoulSkillMimicryDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStSoulSkillMimicryDesc>(filepath, name, text, isInsertMode);
		case "FUStCameraConversionParamConfigDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStCameraConversionParamConfigDesc>(filepath, name, text, isInsertMode);
		case "FUStEffectiveHitProjectileEffectDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStEffectiveHitProjectileEffectDesc>(filepath, name, text, isInsertMode);
		case "FUStTransActiveStateDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStTransActiveStateDesc>(filepath, name, text, isInsertMode);
		case "FUStMovementOptStrategyConfigDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStMovementOptStrategyConfigDesc>(filepath, name, text, isInsertMode);
		case "FUStAbnormalDispAttackerMapDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStAbnormalDispAttackerMapDesc>(filepath, name, text, isInsertMode);
		case "FUStAbnormalDispVictimMapDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStAbnormalDispVictimMapDesc>(filepath, name, text, isInsertMode);
		case "FUStAICrowdDetourLevelConfigDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStAICrowdDetourLevelConfigDesc>(filepath, name, text, isInsertMode);
		case "FUStRebirthAreaDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStRebirthAreaDesc>(filepath, name, text, isInsertMode);
		case "FUStLevelSequenceClearBattleItemConfigDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStLevelSequenceClearBattleItemConfigDesc>(filepath, name, text, isInsertMode);
		case "FUStBeAttackedStiffLevelMappingDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStBeAttackedStiffLevelMappingDesc>(filepath, name, text, isInsertMode);
		case "FUStAkEventMarkerDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStAkEventMarkerDesc>(filepath, name, text, isInsertMode);
		case "FUStSeqAudioJumpLengthDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStSeqAudioJumpLengthDesc>(filepath, name, text, isInsertMode);
		case "FUStDeadSeqUnitConfigDesc":
			return MyMod.LoadNoneRuntimeDataImp<FUStDeadSeqUnitConfigDesc>(filepath, name, text, isInsertMode);
		default:
			switch (text.Length)
			{
			case 15:
				switch (text[0])
				{
				case 'A':
					if (!(text == "AchievementDesc"))
					{
						break;
					}
					return MyMod.LoadRuntimeDataImp<TBAchievementDesc, AchievementDesc>(filepath, name, isInsertMode);
				case 'E':
					if (!(text == "EquipSeriesDesc"))
					{
						break;
					}
					return MyMod.LoadRuntimeDataImp<TBEquipSeriesDesc, EquipSeriesDesc>(filepath, name, isInsertMode);
				case 'L':
					if (!(text == "LoadingTipsDesc"))
					{
						break;
					}
					return MyMod.LoadRuntimeDataImp<TBLoadingTipsDesc, LoadingTipsDesc>(filepath, name, isInsertMode);
				case 'M':
					if (!(text == "MapFragmentDesc"))
					{
						break;
					}
					return MyMod.LoadRuntimeDataImp<TBMapFragmentDesc, MapFragmentDesc>(filepath, name, isInsertMode);
				case 'N':
					if (!(text == "NewGamePlusDesc"))
					{
						break;
					}
					return MyMod.LoadRuntimeDataImp<TBNewGamePlusDesc, NewGamePlusDesc>(filepath, name, isInsertMode);
				case 'P':
					if (!(text == "PlayerLevelDesc"))
					{
						break;
					}
					return MyMod.LoadRuntimeDataImp<TBPlayerLevelDesc, PlayerLevelDesc>(filepath, name, isInsertMode);
				case 'S':
					if (!(text == "ShopRefreshDesc"))
					{
						break;
					}
					return MyMod.LoadRuntimeDataImp<TBShopRefreshDesc, ShopRefreshDesc>(filepath, name, isInsertMode);
				case 'U':
					if (!(text == "UnitDropNumDesc"))
					{
						break;
					}
					return MyMod.LoadRuntimeDataImp<TBUnitDropNumDesc, UnitDropNumDesc>(filepath, name, isInsertMode);
				case 'W':
					if (!(text == "WeaponBuildDesc"))
					{
						break;
					}
					return MyMod.LoadRuntimeDataImp<TBWeaponBuildDesc, WeaponBuildDesc>(filepath, name, isInsertMode);
				}
				break;
			case 17:
				switch (text[2])
				{
				case 'c':
					if (!(text == "AlchemyOutputDesc"))
					{
						break;
					}
					return MyMod.LoadRuntimeDataImp<TBAlchemyOutputDesc, AlchemyOutputDesc>(filepath, name, isInsertMode);
				case 'n':
					if (!(text == "MantraBuildupDesc"))
					{
						break;
					}
					return MyMod.LoadRuntimeDataImp<TBMantraBuildupDesc, MantraBuildupDesc>(filepath, name, isInsertMode);
				case 'p':
					if (!(text == "MapAreaConfigDesc"))
					{
						break;
					}
					return MyMod.LoadRuntimeDataImp<TBMapAreaConfigDesc, MapAreaConfigDesc>(filepath, name, isInsertMode);
				case 'd':
					if (!(text == "MedicineAwardDesc"))
					{
						break;
					}
					return MyMod.LoadRuntimeDataImp<TBMedicineAwardDesc, MedicineAwardDesc>(filepath, name, isInsertMode);
				case 'o':
					if (!(text == "ShopItemGroupDesc"))
					{
						break;
					}
					return MyMod.LoadRuntimeDataImp<TBShopItemGroupDesc, ShopItemGroupDesc>(filepath, name, isInsertMode);
				case 'u':
					if (!(text == "SoulSkillDropDesc"))
					{
						break;
					}
					return MyMod.LoadRuntimeDataImp<TBSoulSkillDropDesc, SoulSkillDropDesc>(filepath, name, isInsertMode);
				}
				break;
			case 23:
				switch (text[1])
				{
				case 'r':
					if (!(text == "ArmorEnhanceConsumeDesc"))
					{
						break;
					}
					return MyMod.LoadRuntimeDataImp<TBArmorEnhanceConsumeDesc, ArmorEnhanceConsumeDesc>(filepath, name, isInsertMode);
				case 'u':
					if (!(text == "MultiplayerDropRuleDesc"))
					{
						break;
					}
					return MyMod.LoadRuntimeDataImp<TBMultiplayerDropRuleDesc, MultiplayerDropRuleDesc>(filepath, name, isInsertMode);
				case 'l':
					if (!(text == "PlatformAchievementDesc"))
					{
						break;
					}
					return MyMod.LoadRuntimeDataImp<TBPlatformAchievementDesc, PlatformAchievementDesc>(filepath, name, isInsertMode);
				case 'e':
					if (!(text == "SeedCollectionAwardDesc"))
					{
						break;
					}
					return MyMod.LoadRuntimeDataImp<TBSeedCollectionAwardDesc, SeedCollectionAwardDesc>(filepath, name, isInsertMode);
				case 'h':
					if (!(text == "ShrineShowNpcConfigDesc"))
					{
						break;
					}
					return MyMod.LoadRuntimeDataImp<TBShrineShowNpcConfigDesc, ShrineShowNpcConfigDesc>(filepath, name, isInsertMode);
				}
				break;
			case 16:
				switch (text[0])
				{
				case 'A':
					if (!(text == "ArmorEnhanceDesc"))
					{
						break;
					}
					return MyMod.LoadRuntimeDataImp<TBArmorEnhanceDesc, ArmorEnhanceDesc>(filepath, name, isInsertMode);
				case 'C':
					if (!(text == "CommDropRuleDesc"))
					{
						if (!(text == "CommLogicCfgDesc"))
						{
							break;
						}
						return MyMod.LoadRuntimeDataImp<TBCommLogicCfgDesc, CommLogicCfgDesc>(filepath, name, isInsertMode);
					}
					return MyMod.LoadRuntimeDataImp<TBCommDropRuleDesc, CommDropRuleDesc>(filepath, name, isInsertMode);
				case 'E':
					if (!(text == "EditionAwardDesc"))
					{
						break;
					}
					return MyMod.LoadRuntimeDataImp<TBEditionAwardDesc, EditionAwardDesc>(filepath, name, isInsertMode);
				case 'L':
					if (!(text == "LotteryAwardDesc"))
					{
						break;
					}
					return MyMod.LoadRuntimeDataImp<TBLotteryAwardDesc, LotteryAwardDesc>(filepath, name, isInsertMode);
				case 'M':
					if (!(text == "MantraWeightDesc"))
					{
						break;
					}
					return MyMod.LoadRuntimeDataImp<TBMantraWeightDesc, MantraWeightDesc>(filepath, name, isInsertMode);
				case 'U':
					if (!(text == "UnitDropRuleDesc"))
					{
						break;
					}
					return MyMod.LoadRuntimeDataImp<TBUnitDropRuleDesc, UnitDropRuleDesc>(filepath, name, isInsertMode);
				}
				break;
			case 11:
				switch (text[1])
				{
				case 'r':
					if (!(text == "ArtBookDesc"))
					{
						break;
					}
					return MyMod.LoadRuntimeDataImp<TBArtBookDesc, ArtBookDesc>(filepath, name, isInsertMode);
				case 'h':
					if (!(text == "ChapterDesc"))
					{
						break;
					}
					return MyMod.LoadRuntimeDataImp<TBChapterDesc, ChapterDesc>(filepath, name, isInsertMode);
				case 'o':
					if (!(text == "ConsumeDesc"))
					{
						break;
					}
					return MyMod.LoadRuntimeDataImp<TBConsumeDesc, ConsumeDesc>(filepath, name, isInsertMode);
				case 'a':
					if (!(text == "TalentSDesc"))
					{
						break;
					}
					return MyMod.LoadRuntimeDataImp<TBTalentSDesc, TalentSDesc>(filepath, name, isInsertMode);
				}
				break;
			case 12:
				switch (text[0])
				{
				case 'A':
					if (!(text == "AttrItemDesc"))
					{
						break;
					}
					return MyMod.LoadRuntimeDataImp<TBAttrItemDesc, AttrItemDesc>(filepath, name, isInsertMode);
				case 'B':
					if (!(text == "BloodHudDesc"))
					{
						break;
					}
					return MyMod.LoadRuntimeDataImp<TBBloodHudDesc, BloodHudDesc>(filepath, name, isInsertMode);
				case 'H':
					if (!(text == "HistoricDesc"))
					{
						break;
					}
					return MyMod.LoadRuntimeDataImp<TBHistoricDesc, HistoricDesc>(filepath, name, isInsertMode);
				case 'M':
					if (!(text == "MuseumMVDesc"))
					{
						break;
					}
					return MyMod.LoadRuntimeDataImp<TBMuseumMVDesc, MuseumMVDesc>(filepath, name, isInsertMode);
				case 'S':
					if (!(text == "ShopItemDesc"))
					{
						if (!(text == "SurpriseDesc"))
						{
							break;
						}
						return MyMod.LoadRuntimeDataImp<TBSurpriseDesc, SurpriseDesc>(filepath, name, isInsertMode);
					}
					return MyMod.LoadRuntimeDataImp<TBShopItemDesc, ShopItemDesc>(filepath, name, isInsertMode);
				}
				break;
			case 8:
				switch (text[1])
				{
				case 'a':
					if (!(text == "CardDesc"))
					{
						break;
					}
					return MyMod.LoadRuntimeDataImp<TBCardDesc, CardDesc>(filepath, name, isInsertMode);
				case 'c':
					if (!(text == "EchoDesc"))
					{
						break;
					}
					return MyMod.LoadRuntimeDataImp<TBEchoDesc, EchoDesc>(filepath, name, isInsertMode);
				case 'u':
					if (!(text == "HuluDesc"))
					{
						break;
					}
					return MyMod.LoadRuntimeDataImp<TBHuluDesc, HuluDesc>(filepath, name, isInsertMode);
				case 't':
					if (!(text == "ItemDesc"))
					{
						break;
					}
					return MyMod.LoadRuntimeDataImp<TBItemDesc, ItemDesc>(filepath, name, isInsertMode);
				case 'e':
					if (!(text == "SeedDesc"))
					{
						break;
					}
					return MyMod.LoadRuntimeDataImp<TBSeedDesc, SeedDesc>(filepath, name, isInsertMode);
				case 'h':
					if (!(text == "ShopDesc"))
					{
						break;
					}
					return MyMod.LoadRuntimeDataImp<TBShopDesc, ShopDesc>(filepath, name, isInsertMode);
				case 'i':
					if (!(text == "WineDesc"))
					{
						break;
					}
					return MyMod.LoadRuntimeDataImp<TBWineDesc, WineDesc>(filepath, name, isInsertMode);
				}
				break;
			case 18:
				switch (text[0])
				{
				case 'C':
					if (!(text == "CollectionDropDesc"))
					{
						break;
					}
					return MyMod.LoadRuntimeDataImp<TBCollectionDropDesc, CollectionDropDesc>(filepath, name, isInsertMode);
				case 'E':
					if (!(text == "EquipFaBaoAttrDesc"))
					{
						break;
					}
					return MyMod.LoadRuntimeDataImp<TBEquipFaBaoAttrDesc, EquipFaBaoAttrDesc>(filepath, name, isInsertMode);
				case 'I':
					if (!(text == "IncreaseConfigDesc"))
					{
						break;
					}
					return MyMod.LoadRuntimeDataImp<TBIncreaseConfigDesc, IncreaseConfigDesc>(filepath, name, isInsertMode);
				case 'R':
					if (!(text == "RoleDataConfigDesc"))
					{
						break;
					}
					return MyMod.LoadRuntimeDataImp<TBRoleDataConfigDesc, RoleDataConfigDesc>(filepath, name, isInsertMode);
				}
				break;
			case 21:
				switch (text[2])
				{
				case 'm':
					if (!(text == "CommonErrorUITipsDesc"))
					{
						break;
					}
					return MyMod.LoadRuntimeDataImp<TBCommonErrorUITipsDesc, CommonErrorUITipsDesc>(filepath, name, isInsertMode);
				case 'i':
					if (!(text == "CricketBattleUnitDesc"))
					{
						break;
					}
					return MyMod.LoadRuntimeDataImp<TBCricketBattleUnitDesc, CricketBattleUnitDesc>(filepath, name, isInsertMode);
				case 'u':
					if (!(text == "EquipPositionConfDesc"))
					{
						break;
					}
					return MyMod.LoadRuntimeDataImp<TBEquipPositionConfDesc, EquipPositionConfDesc>(filepath, name, isInsertMode);
				case 'M':
					if (!(text == "GMMonsterTeleportDesc"))
					{
						break;
					}
					return MyMod.LoadRuntimeDataImp<TBGMMonsterTeleportDesc, GMMonsterTeleportDesc>(filepath, name, isInsertMode);
				case 'a':
					if (!(text == "LoadingTipsWeightDesc"))
					{
						break;
					}
					return MyMod.LoadRuntimeDataImp<TBLoadingTipsWeightDesc, LoadingTipsWeightDesc>(filepath, name, isInsertMode);
				}
				break;
			case 19:
				switch (text[0])
				{
				case 'C':
					if (!(text == "CricketUnitAttrDesc"))
					{
						break;
					}
					return MyMod.LoadRuntimeDataImp<TBCricketUnitAttrDesc, CricketUnitAttrDesc>(filepath, name, isInsertMode);
				case 'D':
					if (!(text == "DestructionDropDesc"))
					{
						break;
					}
					return MyMod.LoadRuntimeDataImp<TBDestructionDropDesc, DestructionDropDesc>(filepath, name, isInsertMode);
				case 'I':
					if (!(text == "InteractionFuncDesc"))
					{
						break;
					}
					return MyMod.LoadRuntimeDataImp<TBInteractionFuncDesc, InteractionFuncDesc>(filepath, name, isInsertMode);
				case 'M':
					if (!(text == "MeditationPointDesc"))
					{
						break;
					}
					return MyMod.LoadRuntimeDataImp<TBMeditationPointDesc, MeditationPointDesc>(filepath, name, isInsertMode);
				case 'U':
					if (!(text == "UISettingConfigDesc"))
					{
						break;
					}
					return MyMod.LoadRuntimeDataImp<TBUISettingConfigDesc, UISettingConfigDesc>(filepath, name, isInsertMode);
				}
				break;
			case 13:
				switch (text[0])
				{
				case 'E':
					if (!(text == "EquipAttrDesc"))
					{
						break;
					}
					return MyMod.LoadRuntimeDataImp<TBEquipAttrDesc, EquipAttrDesc>(filepath, name, isInsertMode);
				case 'L':
					if (!(text == "LinkBloodDesc"))
					{
						break;
					}
					return MyMod.LoadRuntimeDataImp<TBLinkBloodDesc, LinkBloodDesc>(filepath, name, isInsertMode);
				case 'S':
					if (!(text == "SoulSkillDesc"))
					{
						break;
					}
					return MyMod.LoadRuntimeDataImp<TBSoulSkillDesc, SoulSkillDesc>(filepath, name, isInsertMode);
				}
				break;
			case 9:
				switch (text[0])
				{
				case 'E':
					if (!(text == "EquipDesc"))
					{
						break;
					}
					return MyMod.LoadRuntimeDataImp<TBEquipDesc, EquipDesc>(filepath, name, isInsertMode);
				case 'L':
					if (!(text == "LevelDesc"))
					{
						break;
					}
					return MyMod.LoadRuntimeDataImp<TBLevelDesc, LevelDesc>(filepath, name, isInsertMode);
				case 'S':
					if (!(text == "SpellDesc"))
					{
						break;
					}
					return MyMod.LoadRuntimeDataImp<TBSpellDesc, SpellDesc>(filepath, name, isInsertMode);
				}
				break;
			case 14:
				switch (text[2])
				{
				case 'e':
					if (!(text == "ItemRecipeDesc"))
					{
						break;
					}
					return MyMod.LoadRuntimeDataImp<TBItemRecipeDesc, ItemRecipeDesc>(filepath, name, isInsertMode);
				case 'c':
					if (!(text == "LockMantraDesc"))
					{
						break;
					}
					return MyMod.LoadRuntimeDataImp<TBLockMantraDesc, LockMantraDesc>(filepath, name, isInsertMode);
				case 's':
					if (!(text == "PastMemoryDesc"))
					{
						break;
					}
					return MyMod.LoadRuntimeDataImp<TBPastMemoryDesc, PastMemoryDesc>(filepath, name, isInsertMode);
				case 'u':
					if (!(text == "SoundTrackDesc"))
					{
						break;
					}
					return MyMod.LoadRuntimeDataImp<TBSoundTrackDesc, SoundTrackDesc>(filepath, name, isInsertMode);
				case 'l':
					if (!(text == "TalentRankDesc"))
					{
						break;
					}
					return MyMod.LoadRuntimeDataImp<TBTalentRankDesc, TalentRankDesc>(filepath, name, isInsertMode);
				case 'a':
					if (!(text == "TeamConfigDesc"))
					{
						break;
					}
					return MyMod.LoadRuntimeDataImp<TBTeamConfigDesc, TeamConfigDesc>(filepath, name, isInsertMode);
				}
				break;
			case 20:
				switch (text[0])
				{
				case 'M':
					if (!(text == "MovieAndSubtitleDesc"))
					{
						break;
					}
					return MyMod.LoadRuntimeDataImp<TBMovieAndSubtitleDesc, MovieAndSubtitleDesc>(filepath, name, isInsertMode);
				case 'T':
					if (!(text == "TransInputUITipsDesc"))
					{
						break;
					}
					return MyMod.LoadRuntimeDataImp<TBTransInputUITipsDesc, TransInputUITipsDesc>(filepath, name, isInsertMode);
				}
				break;
			case 27:
				switch (text[0])
				{
				case 'N':
					if (!(text == "NPCInteractConversationDesc"))
					{
						break;
					}
					return MyMod.LoadRuntimeDataImp<TBNPCInteractConversationDesc, NPCInteractConversationDesc>(filepath, name, isInsertMode);
				case 'P':
					if (!(text == "PlatformAchievementLiteDesc"))
					{
						break;
					}
					return MyMod.LoadRuntimeDataImp<TBPlatformAchievementLiteDesc, PlatformAchievementLiteDesc>(filepath, name, isInsertMode);
				}
				break;
			case 25:
				switch (text[0])
				{
				case 'S':
					if (!(text == "SceneMonsterNameplateDesc"))
					{
						break;
					}
					return MyMod.LoadRuntimeDataImp<TBSceneMonsterNameplateDesc, SceneMonsterNameplateDesc>(filepath, name, isInsertMode);
				case 'U':
					if (!(text == "UISettingDeviceConfigDesc"))
					{
						break;
					}
					return MyMod.LoadRuntimeDataImp<TBUISettingDeviceConfigDesc, UISettingDeviceConfigDesc>(filepath, name, isInsertMode);
				}
				break;
			case 10:
				if (!(text == "MantraDesc"))
				{
					break;
				}
				return MyMod.LoadRuntimeDataImp<TBMantraDesc, MantraDesc>(filepath, name, isInsertMode);
			case 26:
				if (!(text == "TakePhotoCustomSettingDesc"))
				{
					break;
				}
				return MyMod.LoadRuntimeDataImp<TBTakePhotoCustomSettingDesc, TakePhotoCustomSettingDesc>(filepath, name, isInsertMode);
			}
			break;
		case null:
			break;
		}
		Error("Not Supported Table " + text);
		return false;
	}

	public static bool LoadNoneRuntimeDataImp<T>(string filepath, string filename, string typename, bool isInsertMode) where T : class, IMessage, new()
	{
		bool flag = false;
		if (typeof(T) == typeof(FUStCollectionSpawnInfoDesc))
		{
			flag = true;
		}
		try
		{
			List<byte> list = default(List<byte>);
			if (UGSE_FileFuncLib.LoadFileToArray(filepath, ref list))
			{
				Log("Start Load " + filename + " to " + typename + " Static Table");
				MemoryStream memoryStream = new MemoryStream(list.ToArray());
				string text = typeof(T).ToString();
				text.IndexOf('.');
				object obj = Activator.CreateInstance(typeof(T).Assembly.GetType(text.Insert(text.IndexOf('.') + 1, "TB"), throwOnError: true, ignoreCase: true));
				object value = obj.GetType().GetProperty("Parser").GetValue(obj);
				object obj2 = value.GetType().GetMethod("ParseFrom", new Type[1] { typeof(Stream) }).Invoke(value, new object[1] { memoryStream });
				if (!(obj2.GetType().GetProperty("List").GetValue(obj2) is IEnumerable<T> enumerable))
				{
					Error("Fail to ParseFrom file " + filepath);
					return false;
				}
				if (flag)
				{
					Error("Insert for List is Not Implemented!!");
				}
				else
				{
					BG_ProtobufDataAPI<T> obj3 = BG_ProtobufDataAPI<T>.Get("ID");
					Dictionary<int, T> fieldOrProperty = obj3.GetFieldOrProperty<Dictionary<int, T>>("_dataDict");
					string fieldOrProperty2 = obj3.GetFieldOrProperty<string>("_propertyID");
					if (fieldOrProperty == null)
					{
						Error("Can't Find _DataList " + typeof(T).Name);
						return false;
					}
					foreach (T item in enumerable)
					{
						int? num = ((object)item).GetType().GetProperty(fieldOrProperty2, BindingFlags.IgnoreCase | BindingFlags.Instance | BindingFlags.Public)?.GetValue(item) as int?;
						if (!num.HasValue)
						{
							Error("Can't find id.Ignore item ");
							continue;
						}
						if (fieldOrProperty.ContainsKey(num.Value))
						{
							if (isInsertMode)
							{
								while (fieldOrProperty.ContainsKey(num.Value))
								{
									num++;
								}
								if (fieldOrProperty2 != null)
								{
									item.SetFieldOrProperty(fieldOrProperty2, num);
								}
								RecordBackup.AddOrIgnore(typeof(T), num.Value, null);
								Log($"Insert {num.Value} in {typename}", 2);
							}
							else
							{
								if (typeof(T).GetInterfaces().Any((Type x) => x.IsGenericType && x.GetGenericTypeDefinition() == typeof(IDeepCloneable<>)))
								{
									RecordBackup.AddOrIgnore(typeof(T), num.Value, (IMessage?)(object)(fieldOrProperty[num.Value] as IDeepCloneable<T>).Clone());
								}
								else
								{
									Log("Override a record not clonable in " + typename + ".It won't be reset.", 2);
								}
								Log($"Override {num.Value} in {typename}", 2);
							}
						}
						else
						{
							RecordBackup.AddOrIgnore(typeof(T), num.Value, null);
							Log($"Add {num.Value} in {typename}", 2);
						}
						fieldOrProperty[num.Value] = item;
					}
				}
				Log(filename + " Done", 1);
				return true;
			}
			Error("Fail To Load File " + filepath);
		}
		catch (Exception ex)
		{
			MyExten.Error("Fail to LoadNoneRuntimeDataImp from " + filepath + ":" + ex.Message);
			return false;
		}
		return false;
	}

	public static bool LoadRuntimeDataImp<TB, T>(string filepath, string filename, bool isInsertMode) where TB : IMessage, IMessage<TB>, new() where T : IMessage
	{
		try
		{
			List<byte> list = default(List<byte>);
			if (UGSE_FileFuncLib.LoadFileToArray(filepath, ref list))
			{
				Log("Start Load " + filename + " to " + typeof(T).Name + " Dynamic Table", 1);
				MemoryStream memoryStream = new MemoryStream(list.ToArray());
				string name = typeof(T).Name;
				GSProtobufRuntimeAPI<TB, T> val = GSProtobufRuntimeAPI<TB, T>.Get();
				Dictionary<int, T> fieldOrProperty = val.GetFieldOrProperty<Dictionary<int, T>>("_dataDict");
				TB tBList = val.GetTBList();
				if (fieldOrProperty == null || tBList == null)
				{
					Error("Can't Find dataDict or tblist in " + typeof(TB).Name + "-" + name);
					return false;
				}
				string fieldOrProperty2 = val.GetFieldOrProperty<string>("_propertyID");
				TB val2 = new TB();
				MessageExtensions.MergeFrom((IMessage)(object)val2, (Stream)memoryStream);
				if (!(typeof(TB).GetProperty("List").GetValue(val2) is IEnumerable<T> enumerable))
				{
					Error("Fail to Parse " + filepath);
					return false;
				}
				if (fieldOrProperty2 != "")
				{
					foreach (T item in enumerable)
					{
						object obj = ((object)item/*cast due to .constrained prefix*/).GetType().GetProperty(fieldOrProperty2, BindingFlags.IgnoreCase | BindingFlags.Instance | BindingFlags.Public)?.GetValue(item);
						if (obj == null)
						{
							Error("Can't find id.Ignore item ");
							continue;
						}
						int i = Convert.ToInt32(obj);
						if (fieldOrProperty.ContainsKey(i))
						{
							if (isInsertMode)
							{
								for (; fieldOrProperty.ContainsKey(i); i++)
								{
								}
								if (fieldOrProperty2 != null)
								{
									item.SetFieldOrProperty(fieldOrProperty2, i);
								}
								Log($"Insert {i} in {name}", 2);
								RecordBackup.AddOrIgnore(typeof(T), i, null);
							}
							else
							{
								if (typeof(T).GetInterfaces().Any((Type x) => x.IsGenericType && x.GetGenericTypeDefinition() == typeof(IDeepCloneable<>)))
								{
									RecordBackup.AddOrIgnore(typeof(T), i, (IMessage?)(object)(fieldOrProperty[i] as IDeepCloneable<T>).Clone());
								}
								else
								{
									Log("Override a record not clonable in " + name + ".It won't be reset.", 2);
								}
								Log($"Override {i} in {name}", 2);
							}
						}
						else
						{
							RecordBackup.AddOrIgnore(typeof(T), i, null);
							Log($"Add {i} in {name}", 2);
						}
						fieldOrProperty[i] = item;
					}
					RepeatedField<T> fieldOrProperty3 = tBList.GetFieldOrProperty<RepeatedField<T>>("List");
					if (fieldOrProperty3 == null)
					{
						Error("Can't Find tbList.List in " + name);
						return false;
					}
					fieldOrProperty3.Clear();
					foreach (KeyValuePair<int, T> item2 in fieldOrProperty)
					{
						fieldOrProperty3.Add(item2.Value);
					}
					Log($"Rebuild {name} TBList: {fieldOrProperty3.Count}", 2);
					return true;
				}
				Error("Can't find id property name for type " + name);
				return false;
			}
			Error("Can't Load File" + filename);
		}
		catch (Exception ex)
		{
			MyExten.Error("Fail to LoadRuntimeDataImp from " + filepath + ":" + ex.Message);
			return false;
		}
		return false;
	}

	public static void ResetAll(bool refreshCache = true)
	{
		if (RecordBackup.Count == 0)
		{
			return;
		}
		int num = 0;
		foreach (KeyValuePair<Type, Dictionary<int, IMessage>> item in RecordBackup)
		{
			if (ResetTable(item.Key.Name))
			{
				num++;
			}
		}
		Log($"Reset {num}/{RecordBackup.Count} tables.");
		RecordBackup.Clear();
		if (refreshCache)
		{
			RefreshDBCache();
		}
	}

	public static bool ResetTable(string typename)
	{
		Log("Start Reset Table " + typename, 1);
		switch (typename)
		{
		case "FUStInteractiveUnitCommDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStInteractiveUnitCommDesc>();
		case "FUStInteractionMappingDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStInteractionMappingDesc>();
		case "FUStAiInteractionMappingDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStAiInteractionMappingDesc>();
		case "FUStBuffDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStBuffDesc>();
		case "FUStChargeSkillSDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStChargeSkillSDesc>();
		case "FUStDropItemDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStDropItemDesc>();
		case "FUStHitVEffectDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStHitVEffectDesc>();
		case "FUStQTEDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStQTEDesc>();
		case "FUStSummonCommDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStSummonCommDesc>();
		case "FUStPhysicalHitBoneRuleDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStPhysicalHitBoneRuleDesc>();
		case "FUStRebirthPointDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStRebirthPointDesc>();
		case "FUStStraightCamDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStStraightCamDesc>();
		case "FUStMultiPointLockCameraConfigDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStMultiPointLockCameraConfigDesc>();
		case "FUStDiagonalCamDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStDiagonalCamDesc>();
		case "FUStGiantLockCameraDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStGiantLockCameraDesc>();
		case "FUStUnitCollisionHitMoveDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStUnitCollisionHitMoveDesc>();
		case "FUStBuffDispDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStBuffDispDesc>();
		case "FUStBuffLayerDispDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStBuffLayerDispDesc>();
		case "FUStExAnimDataDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStExAnimDataDesc>();
		case "FUStUnitCommDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStUnitCommDesc>();
		case "FUStUnitBattleInfoExtendDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStUnitBattleInfoExtendDesc>();
		case "FUStUnitPassiveSkillInfoExtendDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStUnitPassiveSkillInfoExtendDesc>();
		case "FUStUnitEnvMaskConfigDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStUnitEnvMaskConfigDesc>();
		case "FUStSkillAIDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStSkillAIDesc>();
		case "FUStSkillEffectDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStSkillEffectDesc>();
		case "FUStSkillSDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStSkillSDesc>();
		case "FUStSkillSMappingDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStSkillSMappingDesc>();
		case "FUStEnvironmentSwitchDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStEnvironmentSwitchDesc>();
		case "FUStBulletSwitchDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStBulletSwitchDesc>();
		case "FUStUnitAIDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStUnitAIDesc>();
		case "FUStUnitTransCommDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStUnitTransCommDesc>();
		case "FUStRollSkillDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStRollSkillDesc>();
		case "FUStUnitDropDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStUnitDropDesc>();
		case "FUStNianhuiNameListDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStNianhuiNameListDesc>();
		case "FUStNianhuiAwardDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStNianhuiAwardDesc>();
		case "FUStBeAttackedInfoDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStBeAttackedInfoDesc>();
		case "FUStBeAttackedDispInfoDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStBeAttackedDispInfoDesc>();
		case "FUStScarInfoDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStScarInfoDesc>();
		case "FUStPlayerSkillCtrlDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStPlayerSkillCtrlDesc>();
		case "FUStOverlyingSkillSDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStOverlyingSkillSDesc>();
		case "FUStBuffGroupDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStBuffGroupDesc>();
		case "FUStBuffRuleDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStBuffRuleDesc>();
		case "FUStMandatoryAITaskDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStMandatoryAITaskDesc>();
		case "FUStAttackHitAudioInfoDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStAttackHitAudioInfoDesc>();
		case "FUStPlayerCameraDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStPlayerCameraDesc>();
		case "FUStPlayerTransAttrDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStPlayerTransAttrDesc>();
		case "FUStAttackHitFXMapDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStAttackHitFXMapDesc>();
		case "FUStBeAttackedFXMapDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStBeAttackedFXMapDesc>();
		case "FUStPlayerCommDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStPlayerCommDesc>();
		case "FUStUnitDeadDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStUnitDeadDesc>();
		case "FUStUnitDeadSwitchToPhysicDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStUnitDeadSwitchToPhysicDesc>();
		case "FUStUnitDeadOldDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStUnitDeadOldDesc>();
		case "FUStHitSceneItemPerformDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStHitSceneItemPerformDesc>();
		case "FUStUnitFootstepDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStUnitFootstepDesc>();
		case "FUStEQSSettingDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStEQSSettingDesc>();
		case "FUStPassiveSkillDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStPassiveSkillDesc>();
		case "FUStAISkillBasicActionDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStAISkillBasicActionDesc>();
		case "FUStUnitAudioBankMapDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStUnitAudioBankMapDesc>();
		case "FUStAISkillTagsDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStAISkillTagsDesc>();
		case "FUStAIThinkDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStAIThinkDesc>();
		case "FUStAIActionDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStAIActionDesc>();
		case "FUStAIFeatureDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStAIFeatureDesc>();
		case "FUStProjectileCommDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStProjectileCommDesc>();
		case "FUStProjectileDispDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStProjectileDispDesc>();
		case "FUStProjectileMoveDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStProjectileMoveDesc>();
		case "FUStBulletExpandDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStBulletExpandDesc>();
		case "FUStMagicFieldExpandDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStMagicFieldExpandDesc>();
		case "FUStBulletWindFieldExpandDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStBulletWindFieldExpandDesc>();
		case "FUStUnitSpecialMoveDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStUnitSpecialMoveDesc>();
		case "FUStUnitLevelUpDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStUnitLevelUpDesc>();
		case "FUStPartRuleInfoDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStPartRuleInfoDesc>();
		case "FUStAttackerHitFXMappingDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStAttackerHitFXMappingDesc>();
		case "FUStAttackerHitAudioEventMappingDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStAttackerHitAudioEventMappingDesc>();
		case "FUStBuffTickRuleBySimpleStateDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStBuffTickRuleBySimpleStateDesc>();
		case "FUStUnitPhysicalAnimationDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStUnitPhysicalAnimationDesc>();
		case "FUStMovieSequenceDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStMovieSequenceDesc>();
		case "FUStSuitDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStSuitDesc>();
		case "FUStCameraGroupDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStCameraGroupDesc>();
		case "FUStFixFunctionDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStFixFunctionDesc>();
		case "FUStGroupAISDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStGroupAISDesc>();
		case "FUStDialogueDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStDialogueDesc>();
		case "FUStDialogueIDMappingDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStDialogueIDMappingDesc>();
		case "FUStUIWordDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStUIWordDesc>();
		case "FUStTalentDisplayDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStTalentDisplayDesc>();
		case "FUStTalentLvUpCfgDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStTalentLvUpCfgDesc>();
		case "FUStAiConversationEventDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStAiConversationEventDesc>();
		case "FUStAiConversationContentDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStAiConversationContentDesc>();
		case "FUStOnlineScreenMsgConfDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStOnlineScreenMsgConfDesc>();
		case "FUStRichTextIconDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStRichTextIconDesc>();
		case "FUStIronBodyConfigDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStIronBodyConfigDesc>();
		case "FUStImmobilizeSkillConfigDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStImmobilizeSkillConfigDesc>();
		case "FUStSealingSpellSkillConfigDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStSealingSpellSkillConfigDesc>();
		case "FUStTransQiTianDaShengConfigDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStTransQiTianDaShengConfigDesc>();
		case "FUStPhantomRushSkillConfigDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStPhantomRushSkillConfigDesc>();
		case "FUStPlayerInputSkillMappingDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStPlayerInputSkillMappingDesc>();
		case "FUStTaskStageDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStTaskStageDesc>();
		case "FUStTaskLineDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStTaskLineDesc>();
		case "FUStSuperArmorLevelDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStSuperArmorLevelDesc>();
		case "FUStCollectionSpawnGroupDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStCollectionSpawnGroupDesc>();
		case "FUStCollectionEventProbabilityDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStCollectionEventProbabilityDesc>();
		case "FUStCustomStateMachineDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStCustomStateMachineDesc>();
		case "FUStGuideAssetConfigDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStGuideAssetConfigDesc>();
		case "FUStNPCBaseInfoDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStNPCBaseInfoDesc>();
		case "FUStEnhancedInputActionDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStEnhancedInputActionDesc>();
		case "FUStSkillDamageExpandDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStSkillDamageExpandDesc>();
		case "FUStPotentialEnergyConfigDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStPotentialEnergyConfigDesc>();
		case "FUStGlobalConfigDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStGlobalConfigDesc>();
		case "FUStTeamRelationConfigDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStTeamRelationConfigDesc>();
		case "FUStAiConversationGroupDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStAiConversationGroupDesc>();
		case "FUStAssociationUnitInfoSDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStAssociationUnitInfoSDesc>();
		case "FUStUnitIntelligenceInfoDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStUnitIntelligenceInfoDesc>();
		case "FUStCBGTemplateDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStCBGTemplateDesc>();
		case "FUStTamerStrategyConfigDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStTamerStrategyConfigDesc>();
		case "FUStTROStrategyConfigDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStTROStrategyConfigDesc>();
		case "FUStSummonCopySkillDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStSummonCopySkillDesc>();
		case "FUStUnitChangeMaterialByAttrDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStUnitChangeMaterialByAttrDesc>();
		case "FUStCCGCastSkillMappingRuleDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStCCGCastSkillMappingRuleDesc>();
		case "FUStWeakPerformConfigDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStWeakPerformConfigDesc>();
		case "FUStFollowPartnerConfigDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStFollowPartnerConfigDesc>();
		case "FUStChallengeDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStChallengeDesc>();
		case "FUStBossRoomConfigDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStBossRoomConfigDesc>();
		case "FUStGlobalCannotDeadExtraConfigDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStGlobalCannotDeadExtraConfigDesc>();
		case "FUStEnvironmentSurfaceEffectDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStEnvironmentSurfaceEffectDesc>();
		case "FUStSweepCheckDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStSweepCheckDesc>();
		case "FUStAudioExtendDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStAudioExtendDesc>();
		case "FUStBuffIconDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStBuffIconDesc>();
		case "FUStPartHitExpandDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStPartHitExpandDesc>();
		case "FUStDetonateConfigDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStDetonateConfigDesc>();
		case "FUStAttachedNiagaraByHitDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStAttachedNiagaraByHitDesc>();
		case "FUStAbnormalStateUIBlackListDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStAbnormalStateUIBlackListDesc>();
		case "FUStElementDmgRatioLevelDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStElementDmgRatioLevelDesc>();
		case "FUStAbnormalCommConfigDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStAbnormalCommConfigDesc>();
		case "FUStStreamingLevelStateDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStStreamingLevelStateDesc>();
		case "FUStMapSymbolDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStMapSymbolDesc>();
		case "FUStAttrCopyConfigDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStAttrCopyConfigDesc>();
		case "FUStPlayerTransUnitConfDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStPlayerTransUnitConfDesc>();
		case "FUStLifeSavingHairConfigDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStLifeSavingHairConfigDesc>();
		case "FUStPigsyStoryLibraryDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStPigsyStoryLibraryDesc>();
		case "FUStPigsyStoryIAndRLibraryDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStPigsyStoryIAndRLibraryDesc>();
		case "FUStGuideGroupDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStGuideGroupDesc>();
		case "FUStGuideNodeDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStGuideNodeDesc>();
		case "FUStDynamicObstaclePerformanceDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStDynamicObstaclePerformanceDesc>();
		case "FUStDefeatSlowTimeConfigDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStDefeatSlowTimeConfigDesc>();
		case "FUStBuffDispGroupDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStBuffDispGroupDesc>();
		case "FUStSoulSkillMimicryDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStSoulSkillMimicryDesc>();
		case "FUStCameraConversionParamConfigDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStCameraConversionParamConfigDesc>();
		case "FUStEffectiveHitProjectileEffectDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStEffectiveHitProjectileEffectDesc>();
		case "FUStTransActiveStateDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStTransActiveStateDesc>();
		case "FUStMovementOptStrategyConfigDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStMovementOptStrategyConfigDesc>();
		case "FUStAbnormalDispAttackerMapDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStAbnormalDispAttackerMapDesc>();
		case "FUStAbnormalDispVictimMapDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStAbnormalDispVictimMapDesc>();
		case "FUStAICrowdDetourLevelConfigDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStAICrowdDetourLevelConfigDesc>();
		case "FUStRebirthAreaDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStRebirthAreaDesc>();
		case "FUStLevelSequenceClearBattleItemConfigDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStLevelSequenceClearBattleItemConfigDesc>();
		case "FUStBeAttackedStiffLevelMappingDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStBeAttackedStiffLevelMappingDesc>();
		case "FUStAkEventMarkerDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStAkEventMarkerDesc>();
		case "FUStSeqAudioJumpLengthDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStSeqAudioJumpLengthDesc>();
		case "FUStDeadSeqUnitConfigDesc":
			return MyMod.ResetTableNonRuntimeImp<FUStDeadSeqUnitConfigDesc>();
		default:
			switch (typename.Length)
			{
			case 15:
				switch (typename[0])
				{
				case 'A':
					if (!(typename == "AchievementDesc"))
					{
						break;
					}
					return MyMod.ResetTableRuntimeImp<TBAchievementDesc, AchievementDesc>();
				case 'E':
					if (!(typename == "EquipSeriesDesc"))
					{
						break;
					}
					return MyMod.ResetTableRuntimeImp<TBEquipSeriesDesc, EquipSeriesDesc>();
				case 'L':
					if (!(typename == "LoadingTipsDesc"))
					{
						break;
					}
					return MyMod.ResetTableRuntimeImp<TBLoadingTipsDesc, LoadingTipsDesc>();
				case 'M':
					if (!(typename == "MapFragmentDesc"))
					{
						break;
					}
					return MyMod.ResetTableRuntimeImp<TBMapFragmentDesc, MapFragmentDesc>();
				case 'N':
					if (!(typename == "NewGamePlusDesc"))
					{
						break;
					}
					return MyMod.ResetTableRuntimeImp<TBNewGamePlusDesc, NewGamePlusDesc>();
				case 'P':
					if (!(typename == "PlayerLevelDesc"))
					{
						break;
					}
					return MyMod.ResetTableRuntimeImp<TBPlayerLevelDesc, PlayerLevelDesc>();
				case 'S':
					if (!(typename == "ShopRefreshDesc"))
					{
						break;
					}
					return MyMod.ResetTableRuntimeImp<TBShopRefreshDesc, ShopRefreshDesc>();
				case 'U':
					if (!(typename == "UnitDropNumDesc"))
					{
						break;
					}
					return MyMod.ResetTableRuntimeImp<TBUnitDropNumDesc, UnitDropNumDesc>();
				case 'W':
					if (!(typename == "WeaponBuildDesc"))
					{
						break;
					}
					return MyMod.ResetTableRuntimeImp<TBWeaponBuildDesc, WeaponBuildDesc>();
				}
				break;
			case 17:
				switch (typename[2])
				{
				case 'c':
					if (!(typename == "AlchemyOutputDesc"))
					{
						break;
					}
					return MyMod.ResetTableRuntimeImp<TBAlchemyOutputDesc, AlchemyOutputDesc>();
				case 'n':
					if (!(typename == "MantraBuildupDesc"))
					{
						break;
					}
					return MyMod.ResetTableRuntimeImp<TBMantraBuildupDesc, MantraBuildupDesc>();
				case 'p':
					if (!(typename == "MapAreaConfigDesc"))
					{
						break;
					}
					return MyMod.ResetTableRuntimeImp<TBMapAreaConfigDesc, MapAreaConfigDesc>();
				case 'd':
					if (!(typename == "MedicineAwardDesc"))
					{
						break;
					}
					return MyMod.ResetTableRuntimeImp<TBMedicineAwardDesc, MedicineAwardDesc>();
				case 'o':
					if (!(typename == "ShopItemGroupDesc"))
					{
						break;
					}
					return MyMod.ResetTableRuntimeImp<TBShopItemGroupDesc, ShopItemGroupDesc>();
				case 'u':
					if (!(typename == "SoulSkillDropDesc"))
					{
						break;
					}
					return MyMod.ResetTableRuntimeImp<TBSoulSkillDropDesc, SoulSkillDropDesc>();
				}
				break;
			case 23:
				switch (typename[1])
				{
				case 'r':
					if (!(typename == "ArmorEnhanceConsumeDesc"))
					{
						break;
					}
					return MyMod.ResetTableRuntimeImp<TBArmorEnhanceConsumeDesc, ArmorEnhanceConsumeDesc>();
				case 'u':
					if (!(typename == "MultiplayerDropRuleDesc"))
					{
						break;
					}
					return MyMod.ResetTableRuntimeImp<TBMultiplayerDropRuleDesc, MultiplayerDropRuleDesc>();
				case 'l':
					if (!(typename == "PlatformAchievementDesc"))
					{
						break;
					}
					return MyMod.ResetTableRuntimeImp<TBPlatformAchievementDesc, PlatformAchievementDesc>();
				case 'e':
					if (!(typename == "SeedCollectionAwardDesc"))
					{
						break;
					}
					return MyMod.ResetTableRuntimeImp<TBSeedCollectionAwardDesc, SeedCollectionAwardDesc>();
				case 'h':
					if (!(typename == "ShrineShowNpcConfigDesc"))
					{
						break;
					}
					return MyMod.ResetTableRuntimeImp<TBShrineShowNpcConfigDesc, ShrineShowNpcConfigDesc>();
				}
				break;
			case 16:
				switch (typename[0])
				{
				case 'A':
					if (!(typename == "ArmorEnhanceDesc"))
					{
						break;
					}
					return MyMod.ResetTableRuntimeImp<TBArmorEnhanceDesc, ArmorEnhanceDesc>();
				case 'C':
					if (!(typename == "CommDropRuleDesc"))
					{
						if (!(typename == "CommLogicCfgDesc"))
						{
							break;
						}
						return MyMod.ResetTableRuntimeImp<TBCommLogicCfgDesc, CommLogicCfgDesc>();
					}
					return MyMod.ResetTableRuntimeImp<TBCommDropRuleDesc, CommDropRuleDesc>();
				case 'E':
					if (!(typename == "EditionAwardDesc"))
					{
						break;
					}
					return MyMod.ResetTableRuntimeImp<TBEditionAwardDesc, EditionAwardDesc>();
				case 'L':
					if (!(typename == "LotteryAwardDesc"))
					{
						break;
					}
					return MyMod.ResetTableRuntimeImp<TBLotteryAwardDesc, LotteryAwardDesc>();
				case 'M':
					if (!(typename == "MantraWeightDesc"))
					{
						break;
					}
					return MyMod.ResetTableRuntimeImp<TBMantraWeightDesc, MantraWeightDesc>();
				case 'U':
					if (!(typename == "UnitDropRuleDesc"))
					{
						break;
					}
					return MyMod.ResetTableRuntimeImp<TBUnitDropRuleDesc, UnitDropRuleDesc>();
				}
				break;
			case 11:
				switch (typename[1])
				{
				case 'r':
					if (!(typename == "ArtBookDesc"))
					{
						break;
					}
					return MyMod.ResetTableRuntimeImp<TBArtBookDesc, ArtBookDesc>();
				case 'h':
					if (!(typename == "ChapterDesc"))
					{
						break;
					}
					return MyMod.ResetTableRuntimeImp<TBChapterDesc, ChapterDesc>();
				case 'o':
					if (!(typename == "ConsumeDesc"))
					{
						break;
					}
					return MyMod.ResetTableRuntimeImp<TBConsumeDesc, ConsumeDesc>();
				case 'a':
					if (!(typename == "TalentSDesc"))
					{
						break;
					}
					return MyMod.ResetTableRuntimeImp<TBTalentSDesc, TalentSDesc>();
				}
				break;
			case 12:
				switch (typename[0])
				{
				case 'A':
					if (!(typename == "AttrItemDesc"))
					{
						break;
					}
					return MyMod.ResetTableRuntimeImp<TBAttrItemDesc, AttrItemDesc>();
				case 'B':
					if (!(typename == "BloodHudDesc"))
					{
						break;
					}
					return MyMod.ResetTableRuntimeImp<TBBloodHudDesc, BloodHudDesc>();
				case 'H':
					if (!(typename == "HistoricDesc"))
					{
						break;
					}
					return MyMod.ResetTableRuntimeImp<TBHistoricDesc, HistoricDesc>();
				case 'M':
					if (!(typename == "MuseumMVDesc"))
					{
						break;
					}
					return MyMod.ResetTableRuntimeImp<TBMuseumMVDesc, MuseumMVDesc>();
				case 'S':
					if (!(typename == "ShopItemDesc"))
					{
						if (!(typename == "SurpriseDesc"))
						{
							break;
						}
						return MyMod.ResetTableRuntimeImp<TBSurpriseDesc, SurpriseDesc>();
					}
					return MyMod.ResetTableRuntimeImp<TBShopItemDesc, ShopItemDesc>();
				}
				break;
			case 8:
				switch (typename[1])
				{
				case 'a':
					if (!(typename == "CardDesc"))
					{
						break;
					}
					return MyMod.ResetTableRuntimeImp<TBCardDesc, CardDesc>();
				case 'c':
					if (!(typename == "EchoDesc"))
					{
						break;
					}
					return MyMod.ResetTableRuntimeImp<TBEchoDesc, EchoDesc>();
				case 'u':
					if (!(typename == "HuluDesc"))
					{
						break;
					}
					return MyMod.ResetTableRuntimeImp<TBHuluDesc, HuluDesc>();
				case 't':
					if (!(typename == "ItemDesc"))
					{
						break;
					}
					return MyMod.ResetTableRuntimeImp<TBItemDesc, ItemDesc>();
				case 'e':
					if (!(typename == "SeedDesc"))
					{
						break;
					}
					return MyMod.ResetTableRuntimeImp<TBSeedDesc, SeedDesc>();
				case 'h':
					if (!(typename == "ShopDesc"))
					{
						break;
					}
					return MyMod.ResetTableRuntimeImp<TBShopDesc, ShopDesc>();
				case 'i':
					if (!(typename == "WineDesc"))
					{
						break;
					}
					return MyMod.ResetTableRuntimeImp<TBWineDesc, WineDesc>();
				}
				break;
			case 18:
				switch (typename[0])
				{
				case 'C':
					if (!(typename == "CollectionDropDesc"))
					{
						break;
					}
					return MyMod.ResetTableRuntimeImp<TBCollectionDropDesc, CollectionDropDesc>();
				case 'E':
					if (!(typename == "EquipFaBaoAttrDesc"))
					{
						break;
					}
					return MyMod.ResetTableRuntimeImp<TBEquipFaBaoAttrDesc, EquipFaBaoAttrDesc>();
				case 'I':
					if (!(typename == "IncreaseConfigDesc"))
					{
						break;
					}
					return MyMod.ResetTableRuntimeImp<TBIncreaseConfigDesc, IncreaseConfigDesc>();
				case 'R':
					if (!(typename == "RoleDataConfigDesc"))
					{
						break;
					}
					return MyMod.ResetTableRuntimeImp<TBRoleDataConfigDesc, RoleDataConfigDesc>();
				}
				break;
			case 21:
				switch (typename[2])
				{
				case 'm':
					if (!(typename == "CommonErrorUITipsDesc"))
					{
						break;
					}
					return MyMod.ResetTableRuntimeImp<TBCommonErrorUITipsDesc, CommonErrorUITipsDesc>();
				case 'i':
					if (!(typename == "CricketBattleUnitDesc"))
					{
						break;
					}
					return MyMod.ResetTableRuntimeImp<TBCricketBattleUnitDesc, CricketBattleUnitDesc>();
				case 'u':
					if (!(typename == "EquipPositionConfDesc"))
					{
						break;
					}
					return MyMod.ResetTableRuntimeImp<TBEquipPositionConfDesc, EquipPositionConfDesc>();
				case 'M':
					if (!(typename == "GMMonsterTeleportDesc"))
					{
						break;
					}
					return MyMod.ResetTableRuntimeImp<TBGMMonsterTeleportDesc, GMMonsterTeleportDesc>();
				case 'a':
					if (!(typename == "LoadingTipsWeightDesc"))
					{
						break;
					}
					return MyMod.ResetTableRuntimeImp<TBLoadingTipsWeightDesc, LoadingTipsWeightDesc>();
				}
				break;
			case 19:
				switch (typename[0])
				{
				case 'C':
					if (!(typename == "CricketUnitAttrDesc"))
					{
						break;
					}
					return MyMod.ResetTableRuntimeImp<TBCricketUnitAttrDesc, CricketUnitAttrDesc>();
				case 'D':
					if (!(typename == "DestructionDropDesc"))
					{
						break;
					}
					return MyMod.ResetTableRuntimeImp<TBDestructionDropDesc, DestructionDropDesc>();
				case 'I':
					if (!(typename == "InteractionFuncDesc"))
					{
						break;
					}
					return MyMod.ResetTableRuntimeImp<TBInteractionFuncDesc, InteractionFuncDesc>();
				case 'M':
					if (!(typename == "MeditationPointDesc"))
					{
						break;
					}
					return MyMod.ResetTableRuntimeImp<TBMeditationPointDesc, MeditationPointDesc>();
				case 'U':
					if (!(typename == "UISettingConfigDesc"))
					{
						break;
					}
					return MyMod.ResetTableRuntimeImp<TBUISettingConfigDesc, UISettingConfigDesc>();
				}
				break;
			case 13:
				switch (typename[0])
				{
				case 'E':
					if (!(typename == "EquipAttrDesc"))
					{
						break;
					}
					return MyMod.ResetTableRuntimeImp<TBEquipAttrDesc, EquipAttrDesc>();
				case 'L':
					if (!(typename == "LinkBloodDesc"))
					{
						break;
					}
					return MyMod.ResetTableRuntimeImp<TBLinkBloodDesc, LinkBloodDesc>();
				case 'S':
					if (!(typename == "SoulSkillDesc"))
					{
						break;
					}
					return MyMod.ResetTableRuntimeImp<TBSoulSkillDesc, SoulSkillDesc>();
				}
				break;
			case 9:
				switch (typename[0])
				{
				case 'E':
					if (!(typename == "EquipDesc"))
					{
						break;
					}
					return MyMod.ResetTableRuntimeImp<TBEquipDesc, EquipDesc>();
				case 'L':
					if (!(typename == "LevelDesc"))
					{
						break;
					}
					return MyMod.ResetTableRuntimeImp<TBLevelDesc, LevelDesc>();
				case 'S':
					if (!(typename == "SpellDesc"))
					{
						break;
					}
					return MyMod.ResetTableRuntimeImp<TBSpellDesc, SpellDesc>();
				}
				break;
			case 14:
				switch (typename[2])
				{
				case 'e':
					if (!(typename == "ItemRecipeDesc"))
					{
						break;
					}
					return MyMod.ResetTableRuntimeImp<TBItemRecipeDesc, ItemRecipeDesc>();
				case 'c':
					if (!(typename == "LockMantraDesc"))
					{
						break;
					}
					return MyMod.ResetTableRuntimeImp<TBLockMantraDesc, LockMantraDesc>();
				case 's':
					if (!(typename == "PastMemoryDesc"))
					{
						break;
					}
					return MyMod.ResetTableRuntimeImp<TBPastMemoryDesc, PastMemoryDesc>();
				case 'u':
					if (!(typename == "SoundTrackDesc"))
					{
						break;
					}
					return MyMod.ResetTableRuntimeImp<TBSoundTrackDesc, SoundTrackDesc>();
				case 'l':
					if (!(typename == "TalentRankDesc"))
					{
						break;
					}
					return MyMod.ResetTableRuntimeImp<TBTalentRankDesc, TalentRankDesc>();
				case 'a':
					if (!(typename == "TeamConfigDesc"))
					{
						break;
					}
					return MyMod.ResetTableRuntimeImp<TBTeamConfigDesc, TeamConfigDesc>();
				}
				break;
			case 20:
				switch (typename[0])
				{
				case 'M':
					if (!(typename == "MovieAndSubtitleDesc"))
					{
						break;
					}
					return MyMod.ResetTableRuntimeImp<TBMovieAndSubtitleDesc, MovieAndSubtitleDesc>();
				case 'T':
					if (!(typename == "TransInputUITipsDesc"))
					{
						break;
					}
					return MyMod.ResetTableRuntimeImp<TBTransInputUITipsDesc, TransInputUITipsDesc>();
				}
				break;
			case 27:
				switch (typename[0])
				{
				case 'N':
					if (!(typename == "NPCInteractConversationDesc"))
					{
						break;
					}
					return MyMod.ResetTableRuntimeImp<TBNPCInteractConversationDesc, NPCInteractConversationDesc>();
				case 'P':
					if (!(typename == "PlatformAchievementLiteDesc"))
					{
						break;
					}
					return MyMod.ResetTableRuntimeImp<TBPlatformAchievementLiteDesc, PlatformAchievementLiteDesc>();
				}
				break;
			case 25:
				switch (typename[0])
				{
				case 'S':
					if (!(typename == "SceneMonsterNameplateDesc"))
					{
						break;
					}
					return MyMod.ResetTableRuntimeImp<TBSceneMonsterNameplateDesc, SceneMonsterNameplateDesc>();
				case 'U':
					if (!(typename == "UISettingDeviceConfigDesc"))
					{
						break;
					}
					return MyMod.ResetTableRuntimeImp<TBUISettingDeviceConfigDesc, UISettingDeviceConfigDesc>();
				}
				break;
			case 10:
				if (!(typename == "MantraDesc"))
				{
					break;
				}
				return MyMod.ResetTableRuntimeImp<TBMantraDesc, MantraDesc>();
			case 26:
				if (!(typename == "TakePhotoCustomSettingDesc"))
				{
					break;
				}
				return MyMod.ResetTableRuntimeImp<TBTakePhotoCustomSettingDesc, TakePhotoCustomSettingDesc>();
			}
			break;
		case null:
			break;
		}
		Error("Unsupported Table " + typename);
		return false;
	}

	public static bool ResetDataDictImp<T>(Dictionary<int, T>? _dataDict) where T : class, IMessage, new()
	{
		try
		{
			Type typeFromHandle = typeof(T);
			if (!RecordBackup.ContainsKey(typeFromHandle))
			{
				return false;
			}
			if (!typeof(T).GetInterfaces().Any((Type x) => x.IsGenericType && x.GetGenericTypeDefinition() == typeof(IDeepCloneable<>)))
			{
				Error("Unknown Error: " + typeof(T).Name + " is not clonable");
				return false;
			}
			if (_dataDict == null)
			{
				Error("Can't Find dataDict in " + typeFromHandle.Name);
				return false;
			}
			foreach (KeyValuePair<int, IMessage> item in RecordBackup[typeFromHandle])
			{
				int key = item.Key;
				if (_dataDict.ContainsKey(key))
				{
					if (item.Value == null)
					{
						_dataDict.Remove(key);
						Log($"Remove {key} from {typeFromHandle.Name}", 2);
					}
					else
					{
						_dataDict[key] = item.Value as T;
						Log($"Revert {key} in {typeFromHandle.Name}", 2);
					}
				}
			}
			Log("Reset " + typeFromHandle.Name + " Dict Done", 2);
			return true;
		}
		catch (Exception ex)
		{
			MyExten.Error("Fail to Reset " + typeof(T).Name + ":" + ex.Message);
			return false;
		}
	}

	public static bool ResetTableNonRuntimeImp<T>() where T : class, IMessage, new()
	{
		bool flag = false;
		if (typeof(T) == typeof(FUStCollectionSpawnInfoDesc))
		{
			flag = true;
		}
		if (flag)
		{
			Error(typeof(T).Name + " Not Supported");
			return false;
		}
		try
		{
			return ResetDataDictImp(BG_ProtobufDataAPI<T>.Get("ID").GetFieldOrProperty<Dictionary<int, T>>("_dataDict"));
		}
		catch (Exception ex)
		{
			MyExten.Error("Fail to Reset " + typeof(T).Name + ":" + ex.Message);
			return false;
		}
	}

	public static bool ResetTableRuntimeImp<TB, T>() where TB : IMessage, IMessage<TB>, new() where T : class, IMessage, new()
	{
		try
		{
			GSProtobufRuntimeAPI<TB, T> val = GSProtobufRuntimeAPI<TB, T>.Get();
			Dictionary<int, T> fieldOrProperty = val.GetFieldOrProperty<Dictionary<int, T>>("_dataDict");
			if (!ResetDataDictImp(fieldOrProperty))
			{
				return false;
			}
			Type typeFromHandle = typeof(T);
			TB tBList = val.GetTBList();
			if (tBList == null)
			{
				Error("Can't Find tbList in " + typeFromHandle.Name);
				return false;
			}
			RepeatedField<T> fieldOrProperty2 = tBList.GetFieldOrProperty<RepeatedField<T>>("List");
			if (fieldOrProperty2 == null)
			{
				Error("Can't Find tbList.List in " + typeFromHandle.Name);
				return false;
			}
			fieldOrProperty2.Clear();
			foreach (KeyValuePair<int, T> item in fieldOrProperty)
			{
				fieldOrProperty2.Add(item.Value);
			}
			Log($"Reset {typeFromHandle.Name} TBList Done: {fieldOrProperty2.Count}", 2);
			return true;
		}
		catch (Exception ex)
		{
			MyExten.Error("Fail to Reset " + typeof(T).Name + ":" + ex.Message);
			return false;
		}
	}
}
