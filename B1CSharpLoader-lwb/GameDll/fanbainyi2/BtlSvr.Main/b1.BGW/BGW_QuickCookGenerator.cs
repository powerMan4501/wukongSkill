using System.Collections.Generic;
using System.Linq;
using BtlB1;
using ResB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.BGW;

public class BGW_QuickCookGenerator
{
	public static void StoreLevelActorsLoadList(ULevel Level, UWorld World)
	{
	}

	public static void GetLevelActorsLoadList(string LevelPath, ref Dictionary<string, EAssetPriority> LoadList)
	{
		UGSE_EditorFuncLib.LoadLevel(LevelPath);
		List<AActor> allLevelActors = UGSE_EditorFuncLib.GetAllLevelActors();
		LoadAllDescs();
		PreloadLevelConfig pL_Config = new PreloadLevelConfig(0);
		GetGlobalLoadList(pL_Config, ref LoadList);
		List<int> RelatedUnitResIDList = new List<int>();
		GetLevelLoadList(LevelPath, ref LoadList, ref RelatedUnitResIDList);
		foreach (AActor item in allLevelActors)
		{
			BGUCharacterCS bGUCharacterCS = item as BGUCharacterCS;
			if (bGUCharacterCS != null)
			{
				BUS_ConfigInfoComp componentByClass = bGUCharacterCS.GetComponentByClass<BUS_ConfigInfoComp>();
				GetUnitLoadList(pL_Config, componentByClass.UnitCDesc.ResID, componentByClass.UnitCDesc.OverrideID, ref LoadList);
			}
		}
	}

	private static void LoadAllDescs()
	{
		BGW_GameDB.LoadRes(ProjNames.B1.ToString());
		GameDBRuntime.LoadRes();
	}

	private static void AddToLoadList(string Path, ref Dictionary<string, EAssetPriority> LoadList)
	{
		if (!LoadList.ContainsKey(Path))
		{
			LoadList.Add(Path, EAssetPriority.Low);
		}
	}

	private static void GetGlobalLoadList(PreloadLevelConfig PL_Config, ref Dictionary<string, EAssetPriority> LoadList)
	{
		PreloadAssetHelper.GetPublicDataAssetResourceLoadList(ref LoadList);
		PreloadAssetHelper.GetLevelDescLoadList(ref LoadList);
		PreloadAssetHelper.GetInputIconMgrLoadList(ref LoadList);
		PreloadAssetHelper.LoadUnitCommResource(PL_Config, ref LoadList);
		foreach (FUStGlobalConfigDesc value in BGW_GameDB.GetAllGlobalConfigDesc().Values)
		{
			if (value.ConfigInfo.ConfigType == FUStGlobalConfigType.String)
			{
				AddToLoadList(value.ConfigInfo.ConfigValue, ref LoadList);
			}
		}
		AddToLoadList("BGWMonsterManualConfigDataAsset'/Game/00Main/Design/Config/DA_MonsterManualConfig.DA_MonsterManualConfig'", ref LoadList);
		AddToLoadList("BGWDataAsset_ObservationModeConfig'/Game/00Main/Design/Config/DA_UIObservationModeConfig.DA_UIObservationModeConfig'", ref LoadList);
		AddToLoadList("BGWDataAsset_DamageNumConfig'/Game/00Main/Design/UIConfig/DA_DamageNumConfig.DA_DamageNumConfig'", ref LoadList);
		AddToLoadList("BGWDataAsset_GameConfig'/Game/00Main/Design/UIConfig/DA_GameConfig.DA_GameConfig'", ref LoadList);
		AddToLoadList("BGWDataAsset_LevelSequenceConfig'/Game/00Main/Design/Config/DA_LevelSeqConfig.DA_LevelSeqConfig'", ref LoadList);
		AddToLoadList("BGWDataAsset_TROConfig'/Game/00Main/BPLibrary/BGW/TRO/Global_TRODataAsset_Small.Global_TRODataAsset_Small'", ref LoadList);
		AddToLoadList("BGWDataAsset_TROConfig'/Game/00Main/BPLibrary/BGW/TRO/Global_TRODataAsset_Medium.Global_TRODataAsset_Medium'", ref LoadList);
		AddToLoadList("BGWDataAsset_TROConfig'/Game/00Main/BPLibrary/BGW/TRO/Global_TRODataAsset_MediumBig.Global_TRODataAsset_MediumBig'", ref LoadList);
		AddToLoadList("BGWDataAsset_TROConfig'/Game/00Main/BPLibrary/BGW/TRO/Global_TRODataAsset_Big.Global_TRODataAsset_Big'", ref LoadList);
		AddToLoadList("BGWDataAsset_TROConfig'/Game/00Main/BPLibrary/BGW/TRO/Global_TRODataAsset_Huge.Global_TRODataAsset_Huge'", ref LoadList);
	}

	private static void GetLevelLoadList(string LevelName, ref Dictionary<string, EAssetPriority> LoadList, ref List<int> RelatedUnitResIDList)
	{
		foreach (LevelDesc item in GameDBRuntime.GetTBLevelDesc().List.ToList())
		{
			if (item.Path.Equals(LevelName))
			{
				PreloadAssetHelper.LoadLevelResource(item.Id, ref LoadList, ref RelatedUnitResIDList);
				break;
			}
		}
	}

	private static void GetPlayerLoadList(PreloadLevelConfig PL_Config, ref Dictionary<string, EAssetPriority> LoadList)
	{
		GetUnitLoadList(PL_Config, 10, 0, ref LoadList);
		LoadPlayerDescResource(PL_Config, 10, 0, IsOriginPlayer: true, ref LoadList);
		LoadPlayerEquips(ref LoadList);
		foreach (FUStPlayerTransAttrDesc value in BGW_GameDB.GetAllPlayerTransAttrDesc().Values)
		{
			int iD = value.ID;
			GetUnitLoadList(PL_Config, iD, 0, ref LoadList);
			LoadPlayerDescResource(PL_Config, iD, 0, IsOriginPlayer: false, ref LoadList);
		}
	}

	private static void LoadPlayerEquips(ref Dictionary<string, EAssetPriority> LoadList)
	{
		string[] array = new string[4] { "AS_Wukong_PreciseDodge_F_01", "AS_Wukong_PreciseDodge_B_01", "AS_Wukong_PreciseDodge_L_01", "AS_Wukong_PreciseDodge_R_01" };
		string text = "/Game/00MainHZ/Characters/Wukong/Meshes/Equip/BakeCloth/";
		string text2 = "SM_BakeCloth_";
		string[] array2;
		foreach (EquipDesc value in GameDBRuntime.GetAllEquipDesc().Values)
		{
			string skeletalMesh = value.SkeletalMesh;
			AddToLoadList(skeletalMesh, ref LoadList);
			int num = skeletalMesh.LastIndexOf('.');
			string text3 = skeletalMesh.Substring(num + 1);
			array2 = array;
			foreach (string text4 in array2)
			{
				AddToLoadList(FPackageName.ExportTextPathToObjectPath(text + text2 + text3 + "_" + text4 + "." + text2 + text3 + "_" + text4), ref LoadList);
			}
			int audioMappingId = value.AudioMappingId;
			foreach (FUStAudioExtendDesc value2 in BGW_GameDB.GetAllAudioExtendDescs().Values)
			{
				if (value2.AudioMappingID == audioMappingId)
				{
					AddToLoadList(FPackageName.ExportTextPathToObjectPath(value2.AudioPath), ref LoadList);
				}
			}
		}
		string text5 = "SK_weiba";
		array2 = array;
		foreach (string text6 in array2)
		{
			AddToLoadList(text + text2 + text5 + "_" + text6 + "." + text2 + text5 + "_" + text6, ref LoadList);
		}
	}

	private static void LoadPlayerDescResource(PreloadLevelConfig PL_Config, int ResID, int OverrideID, bool IsOriginPlayer, ref Dictionary<string, EAssetPriority> LoadList)
	{
		PreloadAssetHelper.LoadPlayerDescResource(PL_Config, null, ResID, OverrideID, IsOriginPlayer, ref LoadList);
		foreach (TalentSDesc item in GameDBRuntime.GetTBTalentSDesc().List)
		{
			if (item == null || !item.UnitResIDStrs.Contains(ResID.ToString()))
			{
				continue;
			}
			string[] array = item.AddBuffIDs.Split(',');
			for (int i = 0; i < array.Length; i++)
			{
				if (int.TryParse(array[i], out var result))
				{
					PreloadAssetHelper.GetBuffPreloadData(result, LoadList, PL_Config.IsIgnoreAllFX);
				}
			}
		}
		foreach (EquipFaBaoAttrDesc item2 in GameDBRuntime.GetTBEquipFaBaoAttrDesc().List)
		{
			if (item2 != null)
			{
				PreloadAssetHelper.LoadPlayerSkillRelatedResource(item2.CastSkillId, PL_Config.IsIgnoreAllFX, ref LoadList);
			}
		}
		foreach (SpellDesc item3 in GameDBRuntime.GetTBSpellDesc().List)
		{
			if (item3 == null)
			{
				continue;
			}
			PreloadAssetHelper.LoadPlayerSkillRelatedResource(item3.SkillId, PL_Config.IsIgnoreAllFX, ref LoadList);
			if (item3.Type == SpellType.BianShen && item3.FloatParam.Count >= 5)
			{
				FUStUnitTransCommDesc unitTransCommDesc = BGW_GameDB.GetUnitTransCommDesc((int)item3.FloatParam[4]);
				if (unitTransCommDesc != null)
				{
					AddToLoadList(unitTransCommDesc.BPPath, ref LoadList);
					PreloadAssetHelper.LoadPlayerSkillRelatedResource(unitTransCommDesc.UnitBornSkillID, PL_Config.IsIgnoreAllFX, ref LoadList);
					PreloadAssetHelper.LoadPlayerSkillRelatedResource(unitTransCommDesc.NewUnitBornSkillID, PL_Config.IsIgnoreAllFX, ref LoadList);
				}
			}
		}
	}

	private static void GetUnitLoadList(PreloadLevelConfig PL_Config, int ResID, int OverrideID, ref Dictionary<string, EAssetPriority> LoadList)
	{
		foreach (string unitBeAttackedConfigLoad in PreloadAssetHelper.GetUnitBeAttackedConfigLoadList(ResID))
		{
			AddToLoadList(unitBeAttackedConfigLoad, ref LoadList);
		}
		foreach (string unitDeathDispConfigLoad in PreloadAssetHelper.GetUnitDeathDispConfigLoadList(ResID))
		{
			AddToLoadList(unitDeathDispConfigLoad, ref LoadList);
		}
		PreloadAssetHelper.LoadUnitDescResource(PL_Config, ResID, OverrideID, ref LoadList);
	}
}
