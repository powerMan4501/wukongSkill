using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using b1.BGW;
using b1.ECS;
using b1.Localization;
using b1.UI;
using BtlB1;
using BtlShare;
using CommB1;
using Google.Protobuf;
using Google.Protobuf.Collections;
using ResB1;
using UnrealEngine.AIModule;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGW_ValiDateMgr")]
public class BGW_ValiDateMgr : GameInstanceSystemBaseUObj
{
	public bool SwitchForArtDev;

	private bool Flag;

	public static Dictionary<string, List<string>> DataQueryableLog;

	public static Dictionary<string, string> ValidateLog;

	public static Dictionary<string, int> ValidateLogCount;

	private static List<string> CheckOverMontagePathNameList;

	private static string AITaskValidateLog;

	private static List<int> CheckOverAITaskList;

	private static string InvalidAnimBluePrintLog;

	private static List<string> InvalidAnimBluePrintData;

	public string FullLog = "";

	public bool bDelayWriteLogToFile;

	private const string ValidatePanelPath = "/Game/00Main/UI/BluePrints/Debug/BP_UI_DataValiDatePanel.BP_UI_DataValiDatePanel_C";

	private const string NotifyValidatePanelPath = "/Game/00Main/UI/BluePrints/Debug/BP_UI_NotifyValidatePanel.BP_UI_NotifyValidatePanel_C";

	private const string AITaskValidatePanelPath = "/Game/00Main/UI/BluePrints/Debug/BP_UI_AITaskValidatePanel.BP_UI_AITaskValidatePanel_C";

	private const float NETIMEFIXED = 0.01f;

	public static BGW_ValiDateMgr Get(UObject WorldContext)
	{
		return BGWGameInstanceCS.GetObject<BGW_ValiDateMgr>(WorldContext);
	}

	public override void OnInit()
	{
		Flag = false;
		BGWGameInstanceCS.GetObject<CSApiBattle>(this).RegisterCSEventHandler<Msg_ValidateError>(Entity.Null, On_Msg_ValidateError);
	}

	private void On_Msg_ValidateError(IntPtr Msg)
	{
		Msg_ValidateError Buffer = default(Msg_ValidateError);
		CSMessageQueue.IntPtrToStruct(Msg, ref Buffer);
		if (Buffer.Type == 2)
		{
			ShowValidateWindow($"受击配置异常！当前应该是物理受击，缺少HitPhyAnimComp组件，ResID = {Buffer.ResID}");
			return;
		}
		_ = Buffer.Type;
		_ = 1;
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (FGlobals.IsEditor && !B1Global.GIsMovieRendering)
		{
			if (!Flag)
			{
				CheckDataValid();
				InvokeValidateUI();
				InvokeAITaskValidateUI();
				InvokeDataQueryableUI();
				Flag = true;
			}
			if (CheckInvalidAnimBluePrintData())
			{
				InvokeAnimBluePrintValidateUI();
			}
		}
	}

	public override void OnShutdown()
	{
		base.OnShutdown();
		ValidateLog.Clear();
		ValidateLogCount.Clear();
		CheckOverMontagePathNameList.Clear();
		AITaskValidateLog = null;
		CheckOverAITaskList.Clear();
	}

	public void AddValidateLog(string str, string toBlame = "null")
	{
		if (!ValidateLog.ContainsKey(toBlame))
		{
			ValidateLog.Add(toBlame, "");
		}
		ValidateLog[toBlame] += str;
		ValidateLog[toBlame] += "\n";
		if (!ValidateLogCount.ContainsKey(toBlame))
		{
			ValidateLogCount.Add(toBlame, 0);
		}
		ValidateLogCount[toBlame]++;
		Flag = false;
	}

	private void InvokeDataQueryableUI()
	{
		if (DataQueryableLog == null || DataQueryableLog.Count <= 0)
		{
			return;
		}
		b1.UI.BUI_DataValidatePanel bUI_DataValidatePanel = UGSE_UMGFuncLib.CreateUserWidget(this, "/Game/00Main/UI/BluePrints/Debug/BP_UI_DataValiDatePanel.BP_UI_DataValiDatePanel_C") as b1.UI.BUI_DataValidatePanel;
		if (bUI_DataValidatePanel == null)
		{
			return;
		}
		string text = "";
		foreach (KeyValuePair<string, List<string>> item in DataQueryableLog)
		{
			string key = item.Key;
			List<string> value = item.Value;
			text = text + key + " 存在 - " + value.Count + "个风险节点\n";
		}
		string text2 = "";
		foreach (KeyValuePair<string, List<string>> item2 in DataQueryableLog)
		{
			string key2 = item2.Key;
			List<string> value2 = item2.Value;
			text2 = text2 + "====================@" + key2 + "====================\n";
			foreach (string item3 in value2)
			{
				text2 += item3;
			}
		}
		bUI_DataValidatePanel.SetValidateInfoToUI(text, text2);
		bUI_DataValidatePanel.AddToViewport(999);
	}

	private void InvokeValidateUI()
	{
		if (ValidateLog == null || ValidateLog.Count <= 0)
		{
			return;
		}
		b1.UI.BUI_DataValidatePanel bUI_DataValidatePanel = UGSE_UMGFuncLib.CreateUserWidget(this, "/Game/00Main/UI/BluePrints/Debug/BP_UI_DataValiDatePanel.BP_UI_DataValiDatePanel_C") as b1.UI.BUI_DataValidatePanel;
		if (bUI_DataValidatePanel == null)
		{
			return;
		}
		string text = "";
		foreach (KeyValuePair<string, string> item in ValidateLog)
		{
			string key = item.Key;
			_ = item.Value;
			text = ((!(key != "null")) ? (text + "====================@非特定策划 - " + ValidateLogCount[key] + "个错误====================\n") : (text + "====================@" + key + " - " + ValidateLogCount[key] + "个错误====================\n"));
		}
		FullLog = "";
		foreach (KeyValuePair<string, string> item2 in ValidateLog)
		{
			string key2 = item2.Key;
			string value = item2.Value;
			if (key2 != "null")
			{
				FullLog += "========================================\n";
				FullLog = FullLog + "====================@" + key2 + "====================\n";
				FullLog += "========================================\n";
			}
			else
			{
				FullLog += "========================================\n";
				FullLog += "====================@非特定策划====================\n";
				FullLog += "========================================\n";
			}
			FullLog += value;
		}
		try
		{
			File.WriteAllText("D:\\DataValidation.txt", FullLog);
		}
		catch (Exception)
		{
			bDelayWriteLogToFile = true;
		}
		bUI_DataValidatePanel.SetValidateInfoToUI(text, FullLog);
		bUI_DataValidatePanel.AddToViewport(999);
	}

	private void InvokeAITaskValidateUI()
	{
		if (AITaskValidateLog != null && !(AITaskValidateLog == ""))
		{
			b1.UI.BUI_DataValidatePanel bUI_DataValidatePanel = UGSE_UMGFuncLib.CreateUserWidget(this, "/Game/00Main/UI/BluePrints/Debug/BP_UI_AITaskValidatePanel.BP_UI_AITaskValidatePanel_C") as b1.UI.BUI_DataValidatePanel;
			if (!(bUI_DataValidatePanel == null))
			{
				bUI_DataValidatePanel.SetValidateInfoToUI(AITaskValidateLog);
				bUI_DataValidatePanel.AddToViewport(999);
			}
		}
	}

	private void InvokeAnimBluePrintValidateUI()
	{
		if (InvalidAnimBluePrintLog != null && !(InvalidAnimBluePrintLog == ""))
		{
			b1.UI.BUI_DataValidatePanel bUI_DataValidatePanel = UGSE_UMGFuncLib.CreateUserWidget(this, "/Game/00Main/UI/BluePrints/Debug/BP_UI_DataValiDatePanel.BP_UI_DataValiDatePanel_C") as b1.UI.BUI_DataValidatePanel;
			if (!(bUI_DataValidatePanel == null))
			{
				bUI_DataValidatePanel.SetValidateInfoToUI(InvalidAnimBluePrintLog);
				bUI_DataValidatePanel.AddToViewport(999);
			}
		}
	}

	private bool IsIgnoreValidateForDebug()
	{
		return false;
	}

	public void CheckRuntimeDesc()
	{
		if (GameDBRuntime.OnAddValidateLog == null)
		{
			GameDBRuntime.OnAddValidateLog = (GameDBRuntime.DelAddValidateLog)Delegate.Combine(GameDBRuntime.OnAddValidateLog, new GameDBRuntime.DelAddValidateLog(AddValidateLog));
		}
		GameDBRuntime.CheckAllDesc();
	}

	private void CheckDataValid()
	{
		if (!IsIgnoreValidateForDebug() && !Get(this).SwitchForArtDev)
		{
			CheckDesc();
			CheckRuntimeDesc();
			CheckOtherData();
		}
	}

	private void CheckGraphDataQueryable()
	{
		BIS_TaskManager.Get(this).CheckGraphDataQueryable(out var UnsafeNodeInfoDic);
		DataQueryableLog = UnsafeNodeInfoDic;
		BIS_StateMachineManager.Get(this).CheckGraphDataQueryable(out var UnsafeNodeInfoDic2);
		DataQueryableLog = DataQueryableLog.Concat(UnsafeNodeInfoDic2).ToDictionary((KeyValuePair<string, List<string>> kv) => kv.Key, (KeyValuePair<string, List<string>> kv) => kv.Value);
	}

	private void CheckDesc()
	{
		CheckSkillAIDesc_Desc_SkillSDesc();
		CheckSkillAIDesc_Param_TargetList();
		CheckUnitAIDesc_Desc_UnitCommDesc();
		CheckSkillsDesc_Param_TemplatePath();
		CheckBulletCommDesc_Param_BulletBPTemplatePath();
		CheckProjectileMoveDesc_ParamNum();
		CheckBuffDesc();
		CheckFUStTaskStageDesc();
		CheckFUSTCameraGroupDesc();
		CheckPassiveSkillDesc();
		CheckOutsideUseSimpleState();
		CheckSkillEffect();
		CheckShopDesc();
		CheckPlayerGuide();
		CheckRebirthPointDesc();
		CheckEquipBalanceTest();
		CheckUnitDeadDesc();
		CheckBossRushConfigDesc();
	}

	private void CheckRebirthPointDesc()
	{
		foreach (KeyValuePair<int, FUStRebirthPointDesc> item in BGW_GameDB.GetAllRebirthPointDesc())
		{
			int key = item.Key;
			FUStRebirthPointDesc value = item.Value;
			int relatedRebirthPointIdToHiddenThis = value.RelatedRebirthPointIdToHiddenThis;
			if (relatedRebirthPointIdToHiddenThis != 0)
			{
				if (value.IsZhaoHunFan == EGSYesNo.No)
				{
					AddValidateLog($"FUStRebirthPointDesc_复活配置：{key} 配置隐藏魂幡的土地庙Id大于0但这个土地庙不是魂幡", "SZ");
				}
				else if (BGW_GameDB.GetRebirthPointDesc(relatedRebirthPointIdToHiddenThis).CanTeleport == EGSYesNo.No)
				{
					AddValidateLog($"FUStRebirthPointDesc_复活配置：{key} 配置隐藏魂幡的土地庙Id为 {relatedRebirthPointIdToHiddenThis}，但是这个土地庙是不能传送", "SZ");
				}
			}
		}
	}

	private void CheckEquipBalanceTest()
	{
		new StringBuilder();
		Dictionary<int, EquipDesc> allEquipDesc = GameDBRuntime.GetAllEquipDesc();
		List<int> list = new List<int>();
		List<int> list2 = new List<int>();
		List<string> list3 = new List<string>();
		List<string> list4 = new List<string>();
		foreach (KeyValuePair<int, EquipDesc> item2 in allEquipDesc)
		{
			int id = item2.Value.Id;
			string equipName = item2.Value.EquipName;
			int equipEffectId = item2.Value.EquipEffectId;
			int suitId = item2.Value.SuitId;
			string text = item2.Value.EquipPosition.ToString();
			string item = item2.Value.SkeletalMesh.ToString();
			if (equipEffectId != 0 && suitId != 0 && text != "Weapon" && text != "Hulu" && text != "Fabao" && text != "Accessory")
			{
				list.Add(id);
				list2.Add(equipEffectId);
				list3.Add(equipName);
				list4.Add(item);
			}
		}
		for (int i = 0; i < list.Count - 1; i++)
		{
			int num = list[i];
			int num2 = list[i + 1];
			if ((num2 != num + 10 || list2[i] != list2[i + 1] || !(list4[i] == list4[i + 1])) && (num2 != num + 10 || list2[i] != list2[i + 1] - num2 / 10 % 10 * 10 || num2 + 20 >= list[i + 2]) && num2 > num + 10 && list2[i] != list2[i + 1] && list4[i] != list4[i - 1] && list2[i] == list2[i - 1])
			{
				AddValidateLog($"EquipDesc_Hot_装备表(ID: {num} 名称：{list3[i]})装备特殊效果填写错误，神品装备换了模型，却复用了非神圣的效果ID", "feiluo");
			}
		}
	}

	private void CheckFUSTCameraGroupDesc()
	{
		Dictionary<int, FUStCameraGroupDesc> allCameraGroupDesc = BGW_GameDB.GetAllCameraGroupDesc();
		Dictionary<Tuple<int, int>, int> dictionary = new Dictionary<Tuple<int, int>, int>();
		foreach (KeyValuePair<int, FUStCameraGroupDesc> item in allCameraGroupDesc)
		{
			Tuple<int, int> key = new Tuple<int, int>(item.Value.CameraGroupID, item.Value.PlayerResID);
			if (dictionary.ContainsKey(key))
			{
				AddValidateLog($"CameraGroupDesc表(ID: {item.Key})其(CameraGroupID,PlayerResID)的组合，与原有ID为{dictionary[key]}的行重复");
			}
			else
			{
				dictionary.Add(key, item.Key);
			}
		}
		Dictionary<int, FUStStraightCamDesc> allStraightCamDesc = BGW_GameDB.GetAllStraightCamDesc();
		dictionary = new Dictionary<Tuple<int, int>, int>();
		foreach (KeyValuePair<int, FUStStraightCamDesc> item2 in allStraightCamDesc)
		{
			Tuple<int, int> key2 = new Tuple<int, int>(item2.Value.CamID, item2.Value.PlayerUnitResID);
			if (dictionary.ContainsKey(key2))
			{
				AddValidateLog($"SoulLockCamDesc表(ID: {item2.Key})其(CamID,PlayerUnitResID)的组合，与原有ID为{dictionary[key2]}的行重复");
			}
			else
			{
				dictionary.Add(key2, item2.Key);
			}
		}
	}

	private void CheckUnitDeadDesc()
	{
		Dictionary<int, FUStUnitDeadDesc> allUnitDeadDesc = BGW_GameDB.GetAllUnitDeadDesc();
		new Dictionary<Tuple<int, int>, int>();
		foreach (KeyValuePair<int, FUStUnitDeadDesc> item in allUnitDeadDesc)
		{
			int key = item.Key;
			int unitResID = item.Value.UnitResID;
			if (key / 100 != unitResID)
			{
				AddValidateLog(string.Format("UnitDead表(ID: {0})，不符合要求，ResID和ID不匹配。其中ID = {0}，ResID = {1}", key, unitResID));
			}
		}
	}

	private void CheckSkillAIDesc_Desc_SkillSDesc()
	{
		foreach (KeyValuePair<int, FUStSkillAIDesc> item in BGW_GameDB.GetAllSkillAIDesc())
		{
			FUStSkillSDesc originalSkillSDesc = BGW_GameDB.GetOriginalSkillSDesc(item.Value.ID);
			string skillAIToBlame = BGW_GameDB.GetSkillAIToBlame(item.Value.ID);
			if (originalSkillSDesc == null)
			{
				AddValidateLog($"SkillAI表(ID: {item.Value.ID})ID未在SkillS表找到对应ID的数据", skillAIToBlame);
			}
			if (item.Value.NextSkillList.Count <= 0)
			{
				continue;
			}
			for (int i = 0; i < item.Value.NextSkillList.Count; i++)
			{
				int skillID = item.Value.NextSkillList[i];
				if (BGW_GameDB.GetSkillAIDesc(skillID) == null)
				{
					AddValidateLog($"SkillAI表(ID: {item.Value.ID})NextSkillList_{i}未在SkillAI表找到对应ID的数据", skillAIToBlame);
				}
				if (BGW_GameDB.GetOriginalSkillSDesc(skillID) == null)
				{
					AddValidateLog($"SkillAI表(ID: {item.Value.ID})NextSkillList_{i}未在SkillS表找到对应ID的数据", skillAIToBlame);
				}
			}
		}
	}

	private void CheckSkillEffect()
	{
		foreach (KeyValuePair<int, FUStSkillEffectDesc> item in BGW_GameDB.GetAllSkillEffectDesc())
		{
			FUStSkillEffectDesc value = item.Value;
			string skillEffectToBlame = BGW_GameDB.GetSkillEffectToBlame(value.ID);
			if (value.EffectType == EBuffAndSkillEffectType.SkillDamage)
			{
				if (value.EffectParamsInt.Count < 2)
				{
					continue;
				}
				int num = value.EffectParamsInt[2];
				if (value.EffectParamsInt.Count <= 4)
				{
					if (num > 2)
					{
						AddValidateLog($"SkillEffectDesc表(ID: {value.ID})填写了带属性的伤害表现 {num}，但参数总数填成了 {value.EffectParamsInt.Count}，所以没有给予属性伤害", skillEffectToBlame);
					}
					continue;
				}
				if (value.EffectParamsInt.Count == 5)
				{
					AddValidateLog($"SkillEffectDesc表(ID: {value.ID})只填写了属性伤害比例，没有填写属性伤害类型, 因为参数总数填成了 5", skillEffectToBlame);
					continue;
				}
				int num2 = value.EffectParamsInt[5];
				int num3 = value.EffectParamsInt[4];
				if (num2 > 0 && num2 < 5 && (num3 < 1 || num3 > 4))
				{
					AddValidateLog($"SkillEffectDesc表(ID: {value.ID})属性伤害档位填写成了 {num3}，应为1-4之间", skillEffectToBlame);
				}
				switch (num2)
				{
				case 0:
					if (num > 2)
					{
						AddValidateLog($"SkillEffectDesc表(ID: {value.ID})有属性表现 {num} 但无属性伤害", skillEffectToBlame);
					}
					break;
				case 1:
					if (num != 5)
					{
						AddValidateLog($"SkillEffectDesc表(ID: {value.ID})属性伤害 {num2} 和属性表现 {num} 不一致, 1应该对应5", skillEffectToBlame);
					}
					break;
				case 2:
					if (num != 3 && num != 4)
					{
						AddValidateLog($"SkillEffectDesc表(ID: {value.ID})属性伤害 {num2} 和属性表现 {num} 不一致，2应该对应3或4", skillEffectToBlame);
					}
					break;
				case 3:
					if (num != 7)
					{
						AddValidateLog($"SkillEffectDesc表(ID: {value.ID})属性伤害 {num2} 和属性表现 {num} 不一致，3应该对应7", skillEffectToBlame);
					}
					break;
				case 4:
					if (num != 6)
					{
						AddValidateLog($"SkillEffectDesc表(ID: {value.ID})属性伤害 {num2} 和属性表现 {num} 不一致，4应该对应6", skillEffectToBlame);
					}
					break;
				}
			}
			else if (value.EffectType == EBuffAndSkillEffectType.RemoveBuff)
			{
				List<int> list = value.EffectParamsInt.ToList();
				List<float> list2 = value.EffectParamsFloat.ToList();
				if (list2.Count < list.Count)
				{
					AddValidateLog($"SkillEffectDesc表(ID: {value.ID})，BuffLayer数量【FloatParam】为：{list.Count}；比BuffID数量【IntParam】为：{list2.Count} 少，这个效果不会触发！！！", skillEffectToBlame);
				}
			}
		}
	}

	private void CheckPlayerGuide()
	{
		Dictionary<int, FUStGuideGroupDesc> tBFUStGuideGroupDesc = GameDBRuntime.GetTBFUStGuideGroupDesc();
		foreach (int GuideGroupId in tBFUStGuideGroupDesc.Keys)
		{
			RepeatedField<int> guideId = tBFUStGuideGroupDesc[GuideGroupId].GuideId;
			if (guideId.Any((int NodeId) => NodeId / 100 != GuideGroupId))
			{
				AddValidateLog(string.Format("新手教学组表({0})和新手教学点({1})不匹配", GuideGroupId, string.Join(", ", guideId.Select((int NodeId) => NodeId))), "jasonwu");
			}
		}
	}

	private void CheckUnitAIDesc_Desc_UnitCommDesc()
	{
		foreach (KeyValuePair<int, FUStUnitAIDesc> item in BGW_GameDB.GetAllUnitAIDesc())
		{
			int num = item.Value.ID / 100;
			if (BGW_GameDB.GetUnitCommDesc(num) == null)
			{
				AddValidateLog($"UnitAI表(ID: {item.Value.ID.ToString()})ID未在UnitComm找到对应ID的数据，即不存在ResID = {num} 的单位");
			}
			else
			{
				if (BGW_GameDB.GetUnitBattleInfoExtendDesc(item.Value.ID) == null)
				{
					AddValidateLog($"UnitAI表(ID: {item.Value.ID.ToString()})ID未在UnitBattleInfoExtend表找到对应ID的数据，对应的ResID是 = {num}");
				}
				if (item.Value.PursuitRange > 30000f)
				{
					AddValidateLog($"UnitAI表(ID: {item.Value.ID.ToString()})追踪最大距离大于300m，为：{item.Value.PursuitRange}，已无意义（如果需要追踪距离不生效，填-1）");
				}
			}
			foreach (int item2 in new List<int>
			{
				item.Value.DefaultLeftBigTurnSkillID,
				item.Value.DefaultLeftSmallTurnSkillID,
				item.Value.DefaultRightBigTurnSkillID,
				item.Value.DefaultRightSmallTurnSkillID
			})
			{
				if (item2 != 0 && BGW_GameDB.GetSkillAIDesc(item2) == null)
				{
					AddValidateLog($"UnitAI表(ID: {item.Value.ID.ToString()})，对应的旋转技能(ID : {item2})在SkillS表中找不到");
				}
			}
			foreach (int item3 in new List<int>
			{
				item.Value.DefaultLeftBigMoveSkillID,
				item.Value.DefaultLeftSmallMoveSkillID,
				item.Value.DefaultRightBigMoveSkillID,
				item.Value.DefaultRightSmallMoveSkillID
			})
			{
				if (item3 != 0 && BGW_GameDB.GetSkillAIDesc(item3) == null)
				{
					AddValidateLog($"UnitAI表(ID: {item.Value.ID.ToString()})，对应的位移技能(ID : {item3})在SkillS表中找不到");
				}
			}
		}
	}

	private void CheckSkillsDesc_Param_TemplatePath()
	{
		Dictionary<int, FUStSkillSDesc> allSkillSDesc = BGW_GameDB.GetAllSkillSDesc();
		Regex regex = new Regex("'(.*?)'");
		foreach (KeyValuePair<int, FUStSkillSDesc> item in allSkillSDesc)
		{
			string skillSToBlame = BGW_GameDB.GetSkillSToBlame(item.Value.ID);
			if (item.Value.TemplatePath == null)
			{
				AddValidateLog($"SkillS表(ID: {item.Value.ID.ToString()})TemplatePath项未填数据", skillSToBlame);
				continue;
			}
			Match match = regex.Match(item.Value.TemplatePath);
			if (!UGSDataShareAPIHelper.IsAssetExist(match.Success ? match.Groups[1].Value : item.Value.TemplatePath))
			{
				AddValidateLog($"未找到SkillS表(ID: {item.Value.ID.ToString()})中TemplatePath({item.Value.TemplatePath})路径下的AM资源", skillSToBlame);
			}
		}
	}

	private void CheckSkillAIDesc_Param_TargetList()
	{
		foreach (KeyValuePair<int, FUStSkillAIDesc> item in BGW_GameDB.GetAllSkillAIDesc())
		{
			if (string.IsNullOrEmpty(item.Value.TargetResIDList))
			{
				continue;
			}
			string skillAIToBlame = BGW_GameDB.GetSkillAIToBlame(item.Value.ID);
			string[] array = item.Value.TargetResIDList.Split(',');
			for (int i = 0; i < array.Length; i++)
			{
				if (int.TryParse(array[i], out var result))
				{
					if (BGW_GameDB.GetUnitCommDesc(result) == null)
					{
						AddValidateLog($"SkillAI表(ID: {item.Value.ID.ToString()})TargetResIDList填写异常！！！填入了一个不存在ResID = {result}", skillAIToBlame);
					}
				}
				else
				{
					AddValidateLog("SkillAI表(ID: " + item.Value.ID + ")TargetResIDList填写异常！！！存在不是数字和','的字符，解析失败！！！", skillAIToBlame);
				}
			}
		}
	}

	private void CheckBulletCommDesc_Param_BulletBPTemplatePath()
	{
		foreach (KeyValuePair<int, FUStBulletCommDesc> item in BGW_GameDB.GetAllBulletCommDesc())
		{
			if (item.Value.BulletBPTemplatePath == null)
			{
				AddValidateLog($"BulletComm表(ID: {item.Value.ID.ToString()})TemplatePath项未填数据");
				continue;
			}
			string text = "_C";
			string pattern = "(" + text + ")$";
			if (!UGSDataShareAPIHelper.IsAssetExist(Regex.Replace(item.Value.BulletBPTemplatePath, pattern, "")))
			{
				AddValidateLog($"未找到BulletComm表(ID: {item.Value.ID.ToString()})中BulletBPTemplatePath({item.Value.BulletBPTemplatePath})路径下的模板资源");
			}
		}
	}

	private void CheckProjectileMoveDesc_ParamNum()
	{
		foreach (KeyValuePair<int, FUStProjectileMoveDesc> item in BGW_GameDB.GetAllProjectileMoveDesc())
		{
			if (item.Value.ProjectileMoveModeType == EBulletOrMagicFieldMoveModeType.TraceMode)
			{
				if (item.Value.ProjectileMoveModeIntParam.Count < 1)
				{
					AddValidateLog($"ProjectileMove表(ID: {item.Value.ID.ToString()})中配置了TraceMode,但是Int参数数量没有配置正确");
				}
				else if (item.Value.ProjectileMoveModeIntParam[0] == 2 && item.Value.ProjectileMoveModeStrParam.Count < 1)
				{
					AddValidateLog($"ProjectileMove表(ID: {item.Value.ID.ToString()})中配置了BackNest(归巢模式),但是Str参数数量没有配置正确");
				}
			}
		}
	}

	private void CheckBuffDesc()
	{
		foreach (KeyValuePair<int, FUStBuffDesc> item in BGW_GameDB.GetAllBuffDesc())
		{
			string buffToBlame = BGW_GameDB.GetBuffToBlame(item.Value.ID);
			RepeatedField<FUStBuffEffectAttr> buffEffects = item.Value.BuffEffects;
			for (int i = 0; i < buffEffects.Count; i++)
			{
				FUStBuffEffectAttr fUStBuffEffectAttr = buffEffects[i];
				if (fUStBuffEffectAttr.EffectType == EBuffAndSkillEffectType.SetSimpleState)
				{
					RepeatedField<int> effectParams = fUStBuffEffectAttr.EffectParams;
					for (int j = 0; j < effectParams.Count; j++)
					{
						int num = effectParams[j];
						if (!Enum.IsDefined(typeof(EBGUSimpleState), (byte)num))
						{
							AddValidateLog($"Buff表中(BuffID: {item.Value.ID})中第 {i} 项效果SetSimpleState, 其中第{j}个状态{num}未定义或者已删除, 请确认!", buffToBlame);
						}
					}
				}
				if (fUStBuffEffectAttr.EffectType != EBuffAndSkillEffectType.SkillDamage || fUStBuffEffectAttr.EffectParams.Count <= 1)
				{
					continue;
				}
				int num2 = fUStBuffEffectAttr.EffectParams[1];
				if (fUStBuffEffectAttr.EffectParams.Count <= 4)
				{
					if (num2 > 2)
					{
						AddValidateLog($"BuffDesc表(ID: {item.Value.ID})填写了带属性的伤害表现 {num2}，但参数总数不为 8，所以没有给予属性伤害", buffToBlame);
					}
					continue;
				}
				int num3 = fUStBuffEffectAttr.EffectParams[4];
				switch (num3)
				{
				case 0:
					if (num2 > 2)
					{
						AddValidateLog($"BuffDesc表(ID: {item.Value.ID})有属性表现 {num2} 但无属性伤害", buffToBlame);
					}
					break;
				case 1:
					if (num2 != 5)
					{
						AddValidateLog($"BuffDesc表(ID: {item.Value.ID})属性伤害 {num3} 和属性表现 {num2} 不一致, 1应该对应5", buffToBlame);
					}
					break;
				case 2:
					if (num2 != 3 && num2 != 4)
					{
						AddValidateLog($"BuffDesc表(ID: {item.Value.ID})属性伤害 {num3} 和属性表现 {num2} 不一致，2应该对应3或4", buffToBlame);
					}
					break;
				case 3:
					if (num2 != 7)
					{
						AddValidateLog($"BuffDesc表(ID: {item.Value.ID})属性伤害 {num3} 和属性表现 {num2} 不一致，3应该对应7", buffToBlame);
					}
					break;
				case 4:
					if (num2 != 6)
					{
						AddValidateLog($"BuffDesc表(ID: {item.Value.ID})属性伤害 {num3} 和属性表现 {num2} 不一致，4应该对应6", buffToBlame);
					}
					break;
				}
				if (fUStBuffEffectAttr.EffectParams.Count <= 7)
				{
					if (num3 > 0 && num3 < 5)
					{
						AddValidateLog($"BuffDesc表(ID: {item.Value.ID})有属性伤害 {num3}，但没有填写属性伤害比例，参数EffectParams.num填了 {fUStBuffEffectAttr.EffectParams.Count}，实际应为 8", buffToBlame);
					}
					continue;
				}
				int num4 = fUStBuffEffectAttr.EffectParams[7];
				if (num3 > 0 && num3 < 5 && (num4 < 1 || num4 > 4))
				{
					AddValidateLog($"BuffDesc表(ID: {item.Value.ID})属性伤害档位填写成了 {num4}，应为1-4之间", buffToBlame);
				}
			}
		}
	}

	private void CheckOutsideUseSimpleState()
	{
		List<EBGUSimpleState> list = new List<EBGUSimpleState>();
		list = BGUFunctionLibraryCS.GetProgramOnlySimpleStateList();
		foreach (KeyValuePair<int, FUStBuffDesc> item in BGW_GameDB.GetAllBuffDesc())
		{
			string buffToBlame = BGW_GameDB.GetBuffToBlame(item.Value.ID);
			RepeatedField<FUStBuffEffectAttr> buffEffects = item.Value.BuffEffects;
			for (int i = 0; i < buffEffects.Count; i++)
			{
				FUStBuffEffectAttr fUStBuffEffectAttr = buffEffects[i];
				if (fUStBuffEffectAttr.EffectType != EBuffAndSkillEffectType.SetSimpleState)
				{
					continue;
				}
				RepeatedField<int> effectParams = fUStBuffEffectAttr.EffectParams;
				for (int j = 0; j < effectParams.Count; j++)
				{
					int num = effectParams[j];
					if (list.Contains((EBGUSimpleState)num))
					{
						AddValidateLog($"Buff表中(BuffID: {item.Value.ID})中第 {i} 项效果SetSimpleState, 其中第{j}个状态{num}({((EBGUSimpleState)num/*cast due to .constrained prefix*/).ToString()})仅限程序内部使用, 请确认!", buffToBlame);
					}
				}
			}
		}
	}

	private void CheckSkillEffectDesc_HitBackBullet()
	{
		foreach (KeyValuePair<int, FUStSkillEffectDesc> item in BGW_GameDB.GetAllSkillEffectDesc())
		{
			if (item.Value.EffectType == EBuffAndSkillEffectType.BulletHitBack)
			{
				AddValidateLog($"SkillEffect使用了BulletHitBack (EffectID: {item.Key})");
			}
		}
	}

	private void CheckBuffDesc_SetCollision()
	{
		foreach (KeyValuePair<int, FUStBuffDesc> item in BGW_GameDB.GetAllBuffDesc())
		{
			foreach (FUStBuffEffectAttr buffEffect in item.Value.BuffEffects)
			{
				if (buffEffect.EffectType == EBuffAndSkillEffectType.SwitchCollisionProfile)
				{
					AddValidateLog($"Buff(ID:{item.Key}) 修改了Collision (修改类型为：{buffEffect.EffectType}), [{buffEffect.EffectParamsString[0]}]");
				}
				else if (buffEffect.EffectType == EBuffAndSkillEffectType.EnableCollisionChanel)
				{
					string text = $"Buff(ID:{item.Key}) 修改了Collision (修改类型为：{buffEffect.EffectType}), 修改通道编号：";
					foreach (int effectParam in buffEffect.EffectParams)
					{
						text += effectParam;
						text += ",";
					}
					AddValidateLog(text);
				}
				else if (buffEffect.EffectType == EBuffAndSkillEffectType.DisableCapsuleCollision || buffEffect.EffectType == EBuffAndSkillEffectType.DisableMeshCollision)
				{
					AddValidateLog($"Buff(ID:{item.Key}) 修改了Collision (修改类型为：{buffEffect.EffectType})]");
				}
			}
		}
	}

	private void CheckPassiveSkillDescAgainstSkillEffectDesc(int MainID, FUStPassiveSkillDesc PassiveSkillDesc, string ToBlame)
	{
		FUStSkillEffectDesc originalSkillEffectDesc = BGW_GameDB.GetOriginalSkillEffectDesc(MainID);
		if (originalSkillEffectDesc == null)
		{
			AddValidateLog($"PassiveSkill表(ID: {PassiveSkillDesc.ID.ToString()})MainID未正确索引到SkillEffect表的数据，请检查MainID是否一致", ToBlame);
		}
		else if (PassiveSkillDesc.SubID < 0 || (PassiveSkillDesc.ModifyMethod == EModifyMethod.SkillEffectFloatN && PassiveSkillDesc.SubID >= originalSkillEffectDesc.EffectParamsFloat.Count) || (PassiveSkillDesc.ModifyMethod == EModifyMethod.SkillEffectIntN && PassiveSkillDesc.SubID >= originalSkillEffectDesc.EffectParamsInt.Count))
		{
			AddValidateLog($"PassiveSkill表(ID: {PassiveSkillDesc.ID.ToString()})SubID未正确索引到SkillEffect表的数据，请检查SubID是否一致", ToBlame);
		}
	}

	private void CheckPassiveSkillDescAgainstOriginalAttrCopyDesc(int MainID, FUStPassiveSkillDesc PassiveSkillDesc, string ToBlame)
	{
		if (BGW_GameDB.GetOriginalAttrCopyDesc(MainID) == null)
		{
			AddValidateLog("PassiveSkill表(ID: " + PassiveSkillDesc.ID + ")MainID未正确索引到OriginalAttrCopy表的数据，请检查MainID是否一致", ToBlame);
		}
	}

	private void CheckPassiveSkillDescAgainstChargeSkillDesc(int MainID, FUStPassiveSkillDesc PassiveSkillDesc, string ToBlame)
	{
		if (BGW_GameDB.GetOriginalChargeSkillSDesc(MainID) == null)
		{
			AddValidateLog($"PassiveSkill表(ID: {PassiveSkillDesc.ID.ToString()})MainID未正确索引到ChargeSkillS表的数据，请检查MainID是否一致", ToBlame);
		}
	}

	private void CheckPassiveSkillDescAgainstSkillSDesc(int MainID, FUStPassiveSkillDesc PassiveSkillDesc, string ToBlame)
	{
		if (BGW_GameDB.GetOriginalSkillSDesc(MainID) == null)
		{
			AddValidateLog($"PassiveSkill表(ID: {PassiveSkillDesc.ID.ToString()})MainID未正确索引到SkillS表的数据，请检查MainID是否一致", ToBlame);
		}
	}

	private void CheckPassiveSkillDescAgainstBuffEffect(int MainID, FUStPassiveSkillDesc PassiveSkillDesc, string ToBlame)
	{
		FUStBuffDesc originalBuffDesc = BGW_GameDB.GetOriginalBuffDesc(MainID);
		if (originalBuffDesc == null)
		{
			AddValidateLog($"PassiveSkill表(ID: {PassiveSkillDesc.ID.ToString()})MainID未正确索引到Buff表的数据，请检查MainID是否一致", ToBlame);
		}
		else if (PassiveSkillDesc.SubID < 0 || PassiveSkillDesc.SubID >= originalBuffDesc.BuffEffects.Count)
		{
			AddValidateLog($"PassiveSkill表(ID: {PassiveSkillDesc.ID.ToString()})SubID未正确索引到Buff表的数据，请检查SubID是否一致", ToBlame);
		}
		else if (PassiveSkillDesc.ModifyMethod == EModifyMethod.BuffEffectFloatN)
		{
			if (PassiveSkillDesc.SubID2 < 0 || PassiveSkillDesc.SubID2 >= originalBuffDesc.BuffEffects[PassiveSkillDesc.SubID].EffectParamsFloat.Count)
			{
				AddValidateLog($"PassiveSkill表(ID: {PassiveSkillDesc.ID.ToString()})SubID2未正确索引到Buff表的数据，请检查SubID2是否一致", ToBlame);
			}
		}
		else if (PassiveSkillDesc.ModifyMethod == EModifyMethod.BuffEffectIntN && (PassiveSkillDesc.SubID2 < 0 || PassiveSkillDesc.SubID2 >= originalBuffDesc.BuffEffects[PassiveSkillDesc.SubID].EffectParams.Count))
		{
			AddValidateLog($"PassiveSkill表(ID: {PassiveSkillDesc.ID.ToString()})SubID2未正确索引到Buff表的数据，请检查SubID2是否一致", ToBlame);
		}
	}

	private void CheckPassiveSkillDescAgainstBuff(int MainID, FUStPassiveSkillDesc PassiveSkillDesc, string ToBlame)
	{
		if (BGW_GameDB.GetOriginalBuffDesc(MainID) == null)
		{
			AddValidateLog($"PassiveSkill表(ID: {PassiveSkillDesc.ID.ToString()})MainID未正确索引到Buff表的数据，请检查MainID是否一致", ToBlame);
		}
	}

	private void CheckPassiveSkillDescAgainstPlayerSkillCtrl(int MainID, FUStPassiveSkillDesc PassiveSkillDesc, string ToBlame)
	{
		if (BGW_GameDB.GetOriginalPlayerSkillCtrlDesc(MainID) == null)
		{
			AddValidateLog($"PassiveSkill表(ID: {PassiveSkillDesc.ID.ToString()})MainID未正确索引到PlayerSkillCtrl表的数据，请检查MainID是否一致", ToBlame);
		}
	}

	private void CheckPassiveSkillDescAgainstSummonComm(int MainID, FUStPassiveSkillDesc PassiveSkillDesc, string ToBlame)
	{
		if (BGW_GameDB.GetOriginalSummonCommDesc(MainID) == null)
		{
			AddValidateLog($"PassiveSkill表(ID: {PassiveSkillDesc.ID.ToString()})MainID未正确索引到SummonComm表的数据，请检查MainID是否一致", ToBlame);
		}
	}

	private void CheckPassiveSkillDescAgainstIronBodyConfigDesc(int MainID, FUStPassiveSkillDesc PassiveSkillDesc, string ToBlame)
	{
		if (BGW_GameDB.GetOriginalIronBodyConfigDesc(MainID) == null)
		{
			AddValidateLog($"PassiveSkill表(ID: {PassiveSkillDesc.ID.ToString()})MainID未正确索引到IronBodyConfig表的数据，请检查MainID是否一致", ToBlame);
		}
	}

	private void CheckPassiveSkillDescAgainstPlayerInputSkillMappingDesc(int MainID, FUStPassiveSkillDesc PassiveSkillDesc, string ToBlame)
	{
		if (BGW_GameDB.GetOriginalPlayerInputSkillMappingDesc(MainID) == null)
		{
			AddValidateLog($"PassiveSkill表(ID: {PassiveSkillDesc.ID.ToString()})MainID未正确索引到PlayerInputSkillMapping表的数据，请检查MainID是否一致", ToBlame);
		}
	}

	private void CheckPassiveSkillDesc()
	{
		Dictionary<int, FUStPassiveSkillDesc> allPassiveSkillDesc = BGW_GameDB.GetAllPassiveSkillDesc();
		string passiveSkillToBlame = BGW_GameDB.GetPassiveSkillToBlame();
		foreach (KeyValuePair<int, FUStPassiveSkillDesc> item in allPassiveSkillDesc)
		{
			string[] array = item.Value.MainID.Split(',');
			if (item.Value.ModifyMethod.ToString().Contains("SkillEffect"))
			{
				string[] array2 = array;
				for (int i = 0; i < array2.Length; i++)
				{
					if (int.TryParse(array2[i], out var result))
					{
						CheckPassiveSkillDescAgainstSkillEffectDesc(result, item.Value, passiveSkillToBlame);
					}
					else
					{
						BGW_LogUtil.LogError("Failed to parse MainID string with PassiveSkillID = " + item.Value.PassiveSkillID + "!");
					}
				}
			}
			else if (item.Value.ModifyMethod.ToString().Contains("PlayerCommDodgeStartSkillId") || item.Value.ModifyMethod.ToString().Contains("PlayerCommPreciseDodgeStartSkillId"))
			{
				string[] array2 = array;
				for (int i = 0; i < array2.Length; i++)
				{
					if (int.TryParse(array2[i], out var result2))
					{
						CheckPassiveSkillDescAgainstPlayerInputSkillMappingDesc(result2, item.Value, passiveSkillToBlame);
					}
					else
					{
						BGW_LogUtil.LogError("Failed to parse MainID string with PassiveSkillID = " + item.Value.PassiveSkillID + "!");
					}
				}
			}
			else if (item.Value.ModifyMethod.ToString().Contains("ChargeSkill"))
			{
				string[] array2 = array;
				for (int i = 0; i < array2.Length; i++)
				{
					if (int.TryParse(array2[i], out var result3))
					{
						CheckPassiveSkillDescAgainstChargeSkillDesc(result3, item.Value, passiveSkillToBlame);
					}
					else
					{
						BGW_LogUtil.LogError("Failed to parse MainID string with PassiveSkillID = " + item.Value.PassiveSkillID + "!");
					}
				}
			}
			else if (item.Value.ModifyMethod.ToString().Contains("SealingSpellSkillDuration"))
			{
				string[] array2 = array;
				for (int i = 0; i < array2.Length; i++)
				{
					if (int.TryParse(array2[i], out var result4))
					{
						CheckPassiveSkillDesc_SealingSpellSkillDesc(result4, item.Value, passiveSkillToBlame, item.Value.SubID, item.Value.SubID2);
					}
					else
					{
						BGW_LogUtil.LogError("Failed to parse MainID string with PassiveSkillID = " + item.Value.PassiveSkillID + "!");
					}
				}
			}
			else if (item.Value.ModifyMethod.ToString().Contains("QiTianDaShengNormalModeDuration"))
			{
				string[] array2 = array;
				for (int i = 0; i < array2.Length; i++)
				{
					if (int.TryParse(array2[i], out var result5))
					{
						CheckPassiveSkillDesc_TransQiTianDaShengConfigDesc(result5, item.Value, passiveSkillToBlame, item.Value.SubID, item.Value.SubID2);
					}
					else
					{
						BGW_LogUtil.LogError("Failed to parse MainID string with PassiveSkillID = " + item.Value.PassiveSkillID + "!");
					}
				}
			}
			else if (item.Value.ModifyMethod.ToString().Contains("Skill"))
			{
				string[] array2 = array;
				for (int i = 0; i < array2.Length; i++)
				{
					if (int.TryParse(array2[i], out var result6))
					{
						CheckPassiveSkillDescAgainstSkillSDesc(result6, item.Value, passiveSkillToBlame);
					}
					else
					{
						BGW_LogUtil.LogError("Failed to parse MainID string with PassiveSkillID = " + item.Value.PassiveSkillID + "!");
					}
				}
			}
			else if (item.Value.ModifyMethod.ToString().Contains("SummonComm"))
			{
				string[] array2 = array;
				for (int i = 0; i < array2.Length; i++)
				{
					if (int.TryParse(array2[i], out var result7))
					{
						CheckPassiveSkillDescAgainstSummonComm(result7, item.Value, passiveSkillToBlame);
					}
					else
					{
						BGW_LogUtil.LogError("Failed to parse MainID string with PassiveSkillID = " + item.Value.PassiveSkillID + "!");
					}
				}
			}
			else if (item.Value.ModifyMethod.ToString().Contains("BuffEffect"))
			{
				string[] array2 = array;
				for (int i = 0; i < array2.Length; i++)
				{
					if (int.TryParse(array2[i], out var result8))
					{
						CheckPassiveSkillDescAgainstBuffEffect(result8, item.Value, passiveSkillToBlame);
					}
					else
					{
						BGW_LogUtil.LogError("Failed to parse MainID string with PassiveSkillID = " + item.Value.PassiveSkillID + "!");
					}
				}
			}
			else if (item.Value.ModifyMethod.ToString().Contains("IronBodyBuff") || item.Value.ModifyMethod.ToString().Contains("IronBodyWindowTimeLength") || item.Value.ModifyMethod.ToString().Contains("IronBodyBeginWindowTime"))
			{
				string[] array2 = array;
				for (int i = 0; i < array2.Length; i++)
				{
					if (int.TryParse(array2[i], out var result9))
					{
						CheckPassiveSkillDescAgainstIronBodyConfigDesc(result9, item.Value, passiveSkillToBlame);
					}
					else
					{
						BGW_LogUtil.LogError("Failed to parse MainID string with PassiveSkillID = " + item.Value.PassiveSkillID + "!");
					}
				}
			}
			else if (item.Value.ModifyMethod.ToString().Contains("Buff"))
			{
				string[] array2 = array;
				for (int i = 0; i < array2.Length; i++)
				{
					if (int.TryParse(array2[i], out var result10))
					{
						CheckPassiveSkillDescAgainstBuff(result10, item.Value, passiveSkillToBlame);
					}
					else
					{
						BGW_LogUtil.LogError("Failed to parse MainID string with PassiveSkillID = " + item.Value.PassiveSkillID + "!");
					}
				}
			}
			else if (item.Value.ModifyMethod.ToString().Contains("PlayerSkillCtrl"))
			{
				string[] array2 = array;
				for (int i = 0; i < array2.Length; i++)
				{
					if (int.TryParse(array2[i], out var result11))
					{
						CheckPassiveSkillDescAgainstPlayerSkillCtrl(result11, item.Value, passiveSkillToBlame);
					}
					else
					{
						BGW_LogUtil.LogError("Failed to parse MainID string with PassiveSkillID = " + item.Value.PassiveSkillID + "!");
					}
				}
			}
			else if (item.Value.ModifyMethod.ToString().Contains("ImmobilizeDuration") || item.Value.ModifyMethod.ToString().Contains("ImmobilizeTargetCount") || item.Value.ModifyMethod.ToString().Contains("ImmobilizeRange"))
			{
				if (item.Value.BaseValue < 0f)
				{
					BGW_LogUtil.LogError($"{item.Value.ModifyMethod} value must bigger than 0");
				}
			}
			else if (item.Value.ModifyMethod.ToString().Contains("ImmobilizeEffect"))
			{
				string[] array2 = array;
				for (int i = 0; i < array2.Length; i++)
				{
					if (int.TryParse(array2[i], out var result12))
					{
						if (result12 <= 0 || result12 > 4)
						{
							BGW_LogUtil.LogError($"ImmobilizeEffect MainID mast between 1~4 {result12}!");
							continue;
						}
						int subID = item.Value.SubID;
						if (subID > 5 || subID < 0)
						{
							BGW_LogUtil.LogError($"ImmobilizeEffect SubID mast between 0~4 {subID}!");
							continue;
						}
						int subID2 = item.Value.SubID2;
						if (subID2 < 0 || subID2 > 3)
						{
							BGW_LogUtil.LogError($"ImmobilizeEffect SubID2 mast between 1~3 {subID}!");
						}
					}
					else
					{
						BGW_LogUtil.LogError("Failed to parse MainID string with PassiveSkillID = " + item.Value.PassiveSkillID + "!");
					}
				}
			}
			else if (item.Value.ModifyMethod.ToString().Contains("AttrCopyFactor"))
			{
				string[] array2 = array;
				for (int i = 0; i < array2.Length; i++)
				{
					if (int.TryParse(array2[i], out var result13))
					{
						CheckPassiveSkillDescAgainstOriginalAttrCopyDesc(result13, item.Value, passiveSkillToBlame);
					}
					else
					{
						BGW_LogUtil.LogError("Failed to parse MainID string with PassiveSkillID = " + item.Value.PassiveSkillID + "!");
					}
				}
				int subID3 = item.Value.SubID2;
				if (subID3 < 1 || subID3 > 2)
				{
					BGW_LogUtil.LogError("AttrCopyFactor SubID2 mast between 1~2 !");
				}
				bool flag = true;
				switch (item.Value.SubID)
				{
				case 30:
				case 31:
				case 32:
				case 33:
					flag = false;
					break;
				case 20:
				case 21:
				case 22:
				case 23:
					flag = false;
					break;
				case 10:
				case 11:
				case 12:
				case 13:
					flag = false;
					break;
				}
				if (flag)
				{
					BGW_LogUtil.LogError("AttrCopyFactor SubID InValid!");
				}
			}
			else
			{
				if (item.Value.ModifyMethod.ToString().Contains("PotentialEnergyConfig") || item.Value.ModifyMethod.ToString().Contains("PartRuleReduceParamsN"))
				{
					continue;
				}
				if (item.Value.ModifyMethod.ToString().Contains("ProjectileLifeTime"))
				{
					string[] array2 = array;
					for (int i = 0; i < array2.Length; i++)
					{
						if (int.TryParse(array2[i], out var result14))
						{
							CheckPassiveSkillDesc_ProjectileCommDesc(result14, item.Value, passiveSkillToBlame);
						}
						else
						{
							BGW_LogUtil.LogError("Failed to parse MainID string with PassiveSkillID = " + item.Value.PassiveSkillID + "!");
						}
					}
				}
				else if (item.Value.ModifyMethod.ToString().Contains("SupreArmorValue"))
				{
					string[] array2 = array;
					for (int i = 0; i < array2.Length; i++)
					{
						if (int.TryParse(array2[i], out var result15))
						{
							CheckPassiveSkillDesc_SuperArmorDesc(result15, item.Value, passiveSkillToBlame);
						}
						else
						{
							BGW_LogUtil.LogError("Failed to parse MainID string with PassiveSkillID = " + item.Value.PassiveSkillID + "!");
						}
					}
				}
				else if (item.Value.ModifyMethod.ToString().Contains("StaminaCostMoveFast"))
				{
					string[] array2 = array;
					for (int i = 0; i < array2.Length; i++)
					{
						if (int.TryParse(array2[i], out var result16))
						{
							CheckPassiveSkillDesc_PlayerCommDesc(result16, item.Value, passiveSkillToBlame);
						}
						else
						{
							BGW_LogUtil.LogError("Failed to parse MainID string with PassiveSkillID = " + item.Value.PassiveSkillID + "!");
						}
					}
				}
				else if (item.Value.ModifyMethod.ToString().Contains("PhantomRushDuration") || item.Value.ModifyMethod.ToString().Contains("PhantomRushSkillId") || item.Value.ModifyMethod.ToString().Contains("PhantomRushBeginAddBuffIdlist"))
				{
					string[] array2 = array;
					for (int i = 0; i < array2.Length; i++)
					{
						if (int.TryParse(array2[i], out var result17))
						{
							CheckPassiveSkillDesc_RushSkillDesc(result17, item.Value, passiveSkillToBlame);
						}
						else
						{
							BGW_LogUtil.LogError("Failed to parse MainID string with PassiveSkillID = " + item.Value.PassiveSkillID + "!");
						}
					}
				}
				else if (item.Value.ModifyMethod.ToString().Contains("PotentialEnergyProtectTime") || item.Value.ModifyMethod.ToString().Contains("PotentialEnergyDecreaseValue") || item.Value.ModifyMethod.ToString().Contains("PotentialEnergyLevelValue"))
				{
					string[] array2 = array;
					for (int i = 0; i < array2.Length; i++)
					{
						if (int.TryParse(array2[i], out var result18))
						{
							CheckPassiveSkillDesc_PotentialEnergyDesc(result18, item.Value, passiveSkillToBlame, item.Value.SubID, item.Value.SubID2);
						}
						else
						{
							BGW_LogUtil.LogError("Failed to parse MainID string with PassiveSkillID = " + item.Value.PassiveSkillID + "!");
						}
					}
				}
				else if (item.Value.ModifyMethod.ToString().Contains("EffectiveHitProjectileEffectPevalueSwitchRatio") || item.Value.ModifyMethod.ToString().Contains("EffectiveHitProjectileEffectCostAttrType") || item.Value.ModifyMethod.ToString().Contains("EffectiveHitProjectileEffectAttrSwitchRatio"))
				{
					string[] array2 = array;
					for (int i = 0; i < array2.Length; i++)
					{
						if (int.TryParse(array2[i], out var result19))
						{
							CheckPassiveSkillDesc_EffectiveHitProjectileEffectDesc(result19, item.Value, passiveSkillToBlame, item.Value.SubID, item.Value.SubID2);
						}
						else
						{
							BGW_LogUtil.LogError("Failed to parse MainID string with PassiveSkillID = " + item.Value.PassiveSkillID + "!");
						}
					}
				}
				else if (item.Value.ModifyMethod.ToString().Contains("PlayerComm"))
				{
					string[] array2 = array;
					for (int i = 0; i < array2.Length; i++)
					{
						if (int.TryParse(array2[i], out var result20))
						{
							CheckPassiveSkillDesc_PlayerCommDesc(result20, item.Value, passiveSkillToBlame, item.Value.SubID, item.Value.SubID2);
						}
						else
						{
							BGW_LogUtil.LogError("Failed to parse MainID string with PassiveSkillID = " + item.Value.PassiveSkillID + "!");
						}
					}
				}
				else if (item.Value.ModifyMethod.ToString().Contains("LifeSavingHairDefaultCd") || item.Value.ModifyMethod.ToString().Contains("LifeSavingHairEffectN") || item.Value.ModifyMethod.ToString().Contains("LifeSavingHairBuffN"))
				{
					string[] array2 = array;
					for (int i = 0; i < array2.Length; i++)
					{
						if (int.TryParse(array2[i], out var result21))
						{
							CheckPassiveSkillDesc_LifeSavingHairDesc(result21, item.Value, passiveSkillToBlame, item.Value.SubID, item.Value.SubID2);
						}
						else
						{
							BGW_LogUtil.LogError("Failed to parse MainID string with PassiveSkillID = " + item.Value.PassiveSkillID + "!");
						}
					}
				}
				else
				{
					AddValidateLog($"PassiveSkill表(ID: {item.Value.ID.ToString()})ModifyMethod命名异常（请以Skill/ChargeSkill/SkillEffect/Buff/PlayerSkillCtrl/Immobilize/PotentialEnergyConfig/LifeSavingHair为前缀命名）", passiveSkillToBlame);
				}
			}
		}
	}

	private void CheckPassiveSkillDesc_PotentialEnergyDesc(int MainID, FUStPassiveSkillDesc PassiveSkillDesc, string ToBlame, int SubID, int SubID2 = -1)
	{
		Dictionary<int, Dictionary<int, FUStPotentialEnergyConfigDesc>> originalPotentialEnergyResConfigDesc = BGW_GameDB.GetOriginalPotentialEnergyResConfigDesc(MainID);
		Dictionary<int, FUStPotentialEnergyConfigDesc> value;
		FUStPotentialEnergyConfigDesc value2;
		if (originalPotentialEnergyResConfigDesc == null)
		{
			AddValidateLog($"PassiveSkill表(ID: {PassiveSkillDesc.ID.ToString()})MainID未正确索引到PotentialEnergyLevel表的数据，请检查MainID是否一致", ToBlame);
		}
		else if (!originalPotentialEnergyResConfigDesc.TryGetValue(SubID, out value))
		{
			AddValidateLog($"PassiveSkill表(ID: {PassiveSkillDesc.ID.ToString()})SubID: {SubID}未正确索引到PotentialEnergyLevel表的Config数据，请检查SubID是否一致", ToBlame);
		}
		else if (SubID2 != -1 && !value.TryGetValue(SubID, out value2))
		{
			AddValidateLog($"PassiveSkill表(ID: {PassiveSkillDesc.ID.ToString()}) SubID2: {SubID2}未正确索引到PotentialEnergyLevel表的LevelID数据，请检查SubID2是否一致", ToBlame);
		}
	}

	private void CheckPassiveSkillDesc_EffectiveHitProjectileEffectDesc(int MainID, FUStPassiveSkillDesc PassiveSkillDesc, string ToBlame, int SubID, int SubID2 = -1)
	{
		if (BGW_GameDB.GetOriginalEffectiveHitProjectileEffectDesc(MainID) == null)
		{
			AddValidateLog($"PassiveSkill表(ID: {PassiveSkillDesc.ID.ToString()})MainID未正确索引到EffectiveHitProjectileEffect表的数据，请检查MainID是否一致", ToBlame);
		}
	}

	private void CheckPassiveSkillDesc_LifeSavingHairDesc(int MainID, FUStPassiveSkillDesc PassiveSkillDesc, string ToBlame, int SubID, int SubID2 = -1)
	{
		if (BGW_GameDB.GetOriginalLifeSavingHairConfigDesc(MainID) == null)
		{
			AddValidateLog($"LifeSavingHair表(ID: {PassiveSkillDesc.ID.ToString()})MainID未正确索引到LifeSavingHairConfig表的数据，请检查MainID是否一致", ToBlame);
		}
	}

	private void CheckPassiveSkillDesc_SealingSpellSkillDesc(int MainID, FUStPassiveSkillDesc PassiveSkillDesc, string ToBlame, int SubID, int SubID2 = -1)
	{
		if (BGW_GameDB.GetOriginalSealingSpellSkillConfigDesc(MainID) == null)
		{
			AddValidateLog("SealingSpellSkillConfig表(ID: " + PassiveSkillDesc.ID + ")MainID未正确索引到SealingSpellSkillConfig表的数据，请检查MainID是否一致", ToBlame);
		}
	}

	private void CheckPassiveSkillDesc_TransQiTianDaShengConfigDesc(int MainID, FUStPassiveSkillDesc PassiveSkillDesc, string ToBlame, int SubID, int SubID2 = -1)
	{
		if (BGW_GameDB.GetOriginalTransQiTianDaShengConfigDesc(MainID) == null)
		{
			AddValidateLog("TransQiTianDaShengConfig表(ID: " + PassiveSkillDesc.ID + ")MainID未正确索引到TransQiTianDaShengConfig表的数据，请检查MainID是否一致", ToBlame);
		}
	}

	private void CheckPassiveSkillDesc_PlayerCommDesc(int MainID, FUStPassiveSkillDesc PassiveSkillDesc, string ToBlame, int SubID, int SubID2 = -1)
	{
		if (BGW_GameDB.GetOriginalPlayerCommDesc(MainID) == null)
		{
			AddValidateLog($"PassiveSkill表(ID: {PassiveSkillDesc.ID.ToString()})MainID未正确索引到PlayerComm表的数据，请检查MainID是否一致", ToBlame);
		}
	}

	private void CheckPassiveSkillDesc_RushSkillDesc(int MainID, FUStPassiveSkillDesc PassiveSkillDesc, string ToBlame)
	{
		if (BGW_GameDB.GetPhantomRushSkillOrgConfigDesc(MainID) == null)
		{
			AddValidateLog($"PassiveSkill表(ID: {PassiveSkillDesc.ID.ToString()})MainID未正确索引到RushSkill表的数据，请检查MainID是否一致", ToBlame);
		}
	}

	private void CheckPassiveSkillDesc_ProjectileCommDesc(int MainID, FUStPassiveSkillDesc PassiveSkillDesc, string ToBlame)
	{
		if (BGW_GameDB.GetOriginalProjectileCommDesc(MainID) == null)
		{
			AddValidateLog($"PassiveSkill表(ID: {PassiveSkillDesc.ID.ToString()})MainID未正确索引到ProjectileComm表的数据，请检查MainID是否一致", ToBlame);
		}
	}

	private void CheckPassiveSkillDesc_PlayerCommDesc(int MainID, FUStPassiveSkillDesc PassiveSkillDesc, string ToBlame)
	{
		if (BGW_GameDB.GetOriginalPlayerCommDesc(MainID) == null)
		{
			AddValidateLog($"PassiveSkill表(ID: {PassiveSkillDesc.ID.ToString()})MainID未正确索引到PlayerCommDesc表的数据，请检查MainID是否一致", ToBlame);
		}
	}

	private void CheckPassiveSkillDesc_SuperArmorDesc(int MainID, FUStPassiveSkillDesc PassiveSkillDesc, string ToBlame)
	{
		if (BGW_GameDB.GetSuperArmorLevelDescOrgByID(MainID) == null)
		{
			AddValidateLog($"PassiveSkill表(ID: {PassiveSkillDesc.ID.ToString()})MainID未正确索引到SuperArmorLevel表的数据，请检查MainID是否一致", ToBlame);
		}
	}

	private void CheckShopDesc()
	{
		foreach (ShopItemGroupDesc item in GameDBRuntime.GetTBShopItemGroupDesc().List)
		{
			ShopItemDesc shopItemDesc = GameDBRuntime.GetShopItemDesc(item.GoodsId);
			if (shopItemDesc == null)
			{
				AddValidateLog($"ShopItemGroup表(ID: {shopItemDesc.Id}) 配置Item{item.GoodsId} 在ShopItem表中不存在", "songjiajun");
			}
		}
		foreach (ShopItemDesc item2 in GameDBRuntime.GetTBShopItemDesc().List)
		{
			ItemDesc itemDesc = GameDBRuntime.GetItemDesc(item2.ItemId);
			if (itemDesc == null)
			{
				AddValidateLog($"ShopItem表(ID: {item2.Id}) 对应Item{item2.ItemId} 在ItemDesc表中不存在", "songjiajun");
				continue;
			}
			if (itemDesc.ItemType == ItemType.Equip && GameDBRuntime.GetEquipPosition(itemDesc.Id) != EquipPosition.Accessory && item2.AppendType != ShopItemAppendType.Ignore)
			{
				AddValidateLog($"ShopItem表(ID: {item2.Id}) 对应Item{item2.ItemId}是一个装备 但AppendType不是Ignore 会导致多周目重复上架", "songjiajun");
			}
			if (itemDesc.ItemType == ItemType.Equip)
			{
				continue;
			}
			foreach (ItemOne item3 in item2.CostItem)
			{
				if (item3.Id != 1002)
				{
					AddValidateLog($"ShopItem表(ID: {item2.Id}) 对应Item{item2.ItemId}不是一个装备 但CostItem有除灵韵外的其他道具 {item3.Id}", "songjiajun");
				}
			}
		}
	}

	private void CheckBulletExpandDesc_SkillEffect_RangeSelect()
	{
		foreach (KeyValuePair<int, FUStBulletExpandDesc> item in BGW_GameDB.GetAllBulletExpandDesc())
		{
			List<int> list = new List<int>();
			list.AddRange(item.Value.LifeOverEffectID.ToList());
			list.AddRange(item.Value.HitChrEffectsforSelf.ToList());
			list.AddRange(item.Value.HitItemEffectsforSelf.ToList());
			list.AddRange(item.Value.HitEffectsforChr.ToList());
			list.AddRange(item.Value.HitProjectileEffectsforSelf.ToList());
			list.AddRange(item.Value.HitEffectsforProjectile.ToList());
			foreach (FUStDelayTriggerEffects delayTriggerEffect in item.Value.DelayTriggerEffects)
			{
				list.AddRange(delayTriggerEffect.EffectIDs.ToList());
			}
			foreach (int item2 in list)
			{
				FUStSkillEffectDesc originalSkillEffectDesc = BGW_GameDB.GetOriginalSkillEffectDesc(item2);
				if (originalSkillEffectDesc != null && originalSkillEffectDesc.Range.RangeType != ERangeType.TargetBaseObj && BulletRPCEffect.BulletRPCEffectList.Contains(originalSkillEffectDesc.EffectType))
				{
					AddValidateLog($"BulletExpand表(ID: {item.Key.ToString()})中使用了范围筛选类SkillEffect(ID:{item2.ToString()})(Type:{originalSkillEffectDesc.EffectType.ToString()}),该Effect因为网络化原因需要由Master代理无法传递子弹自身，因此范围筛选中心为Master, 请检查");
				}
			}
		}
	}

	private void CheckAMNotify()
	{
	}

	public static void CheckAllNotifiesData(AActor Actor, UAnimMontage TargetMontage, bool IsSkillMontage)
	{
		BGW_ValiDateMgr bGW_ValiDateMgr = Get(Actor.World);
		if (bGW_ValiDateMgr.SwitchForArtDev || Actor == null || TargetMontage == null)
		{
			return;
		}
		string pathName = TargetMontage.GetPathName();
		if (CheckOverMontagePathNameList.Contains(pathName))
		{
			return;
		}
		CheckOverMontagePathNameList.Add(pathName);
		float sequenceLength = TargetMontage.SequenceLength;
		List<FGSNotifyEventTimeInfo> TimeInfoList = new List<FGSNotifyEventTimeInfo>();
		List<FAnimNotifyEvent> allNotifyEventInAM = UGSE_AnimFuncLib.GetAllNotifyEventInAM(TargetMontage, out TimeInfoList);
		bool flag = false;
		bool flag2 = false;
		for (int i = 0; i < allNotifyEventInAM.Count; i++)
		{
			bool flag3 = false;
			if (i < TimeInfoList.Count && (TimeInfoList[i].TriggerTime > sequenceLength + 0.01f || TimeInfoList[i].TriggerTime < -0.01f))
			{
				flag3 = true;
			}
			if (allNotifyEventInAM[i].Notify != null)
			{
				UAnimNotify_GSBase uAnimNotify_GSBase = allNotifyEventInAM[i].Notify as UAnimNotify_GSBase;
				if (uAnimNotify_GSBase != null)
				{
					uAnimNotify_GSBase.GSValidateInputCS(Actor);
				}
			}
			else if (allNotifyEventInAM[i].NotifyStateClass != null)
			{
				if (i < TimeInfoList.Count && (TimeInfoList[i].EndTriggerTime > sequenceLength + 0.01f || TimeInfoList[i].EndTriggerTime < -0.01f))
				{
					flag3 = true;
				}
				if (allNotifyEventInAM[i].NotifyStateClass as b1.BANS_GSAttackState != null)
				{
					flag = true;
				}
				if (allNotifyEventInAM[i].NotifyStateClass as BANS_GSComboWindow != null)
				{
					flag2 = true;
				}
				UAnimNotifyState_GSBase uAnimNotifyState_GSBase = allNotifyEventInAM[i].NotifyStateClass as UAnimNotifyState_GSBase;
				if (uAnimNotifyState_GSBase != null)
				{
					uAnimNotifyState_GSBase.GSValidateInputCS(Actor);
				}
			}
			if (flag3)
			{
				string logStr = $"Mongtage（{TargetMontage.GetPathName()}）中{allNotifyEventInAM[i].NotifyName}节点越界";
				bGW_ValiDateMgr.ShowValidateWindow(logStr);
				return;
			}
		}
		if (!IsSkillMontage)
		{
			return;
		}
		BGUCharacterCS bGUCharacterCS = Actor as BGUCharacterCS;
		if (bGUCharacterCS == null)
		{
			return;
		}
		int resID = bGUCharacterCS.GetResID();
		if (resID > 1000 && resID < 10000)
		{
			if (!flag)
			{
				string logStr2 = $"Mongtage（{TargetMontage.GetPathName()}）作为怪物技能的Montage必须配置AttackState";
				bGW_ValiDateMgr.ShowValidateWindow(logStr2);
			}
			else if (!flag2)
			{
				string logStr3 = $"Mongtage（{TargetMontage.GetPathName()}）作为怪物技能的Montage必须配置ComboWindow";
				bGW_ValiDateMgr.ShowValidateWindow(logStr3);
			}
		}
	}

	public void ShowValidateWindow(string LogStr)
	{
		if (!SwitchForArtDev && LogStr != null)
		{
			b1.UI.BUI_NotifyValidatePanel bUI_NotifyValidatePanel = UGSE_UMGFuncLib.CreateUserWidget(this, "/Game/00Main/UI/BluePrints/Debug/BP_UI_NotifyValidatePanel.BP_UI_NotifyValidatePanel_C") as b1.UI.BUI_NotifyValidatePanel;
			if (!(bUI_NotifyValidatePanel == null))
			{
				bUI_NotifyValidatePanel.SetValidateInfoToUI(LogStr);
				bUI_NotifyValidatePanel.AddToViewport(999);
			}
		}
	}

	private void CheckAIData()
	{
	}

	public static void CheckAITaskNodes(AActor actor)
	{
		if (actor == null || Get(actor.World).SwitchForArtDev)
		{
			return;
		}
		BGUCharacterCS bGUCharacterCS = actor as BGUCharacterCS;
		if (bGUCharacterCS == null)
		{
			return;
		}
		int resID = bGUCharacterCS.GetResID();
		if (CheckOverAITaskList.Contains(resID))
		{
			return;
		}
		CheckOverAITaskList.Add(resID);
		BUC_AIData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_AIData>(actor);
		if (unPersistentReadOnlyData == null)
		{
			return;
		}
		UBehaviorTree currentRunBT = unPersistentReadOnlyData.GetCurrentRunBT();
		if (currentRunBT == null)
		{
			return;
		}
		FBehaviorTreeNodeData NodeData = default(FBehaviorTreeNodeData);
		NodeData.TaskNodeList = new List<UBTTaskNode>();
		UGSE_BehaviorTreeFuncLib.GetBTTaskNodes(currentRunBT, out NodeData);
		if (NodeData.TaskNodeList.Count <= 0)
		{
			return;
		}
		for (int i = 0; i < NodeData.TaskNodeList.Count; i++)
		{
			BAIT_UseSkillWithID bAIT_UseSkillWithID = NodeData.TaskNodeList[i] as BAIT_UseSkillWithID;
			if (bAIT_UseSkillWithID != null && BGW_GameDB.GetSkillSDesc(bAIT_UseSkillWithID.SkillID, actor) == null)
			{
				string pathName = currentRunBT.PathName;
				string str = $"行为树（{pathName}）下的BAIT_UseSkillWithID节点中SkillID（{bAIT_UseSkillWithID.SkillID}）未在SkillS表中找到索引";
				Get(actor.World).AddAITaskValidateLog(str);
			}
			BAIT_Combo bAIT_Combo = NodeData.TaskNodeList[i] as BAIT_Combo;
			if (!(bAIT_Combo != null))
			{
				continue;
			}
			for (int j = 0; j < bAIT_Combo.SkillArray.Count; j++)
			{
				for (int k = 0; k < bAIT_Combo.SkillArray[j].SkillID.Count; k++)
				{
					if (BGW_GameDB.GetSkillSDesc(bAIT_Combo.SkillArray[j].SkillID[k], actor) == null)
					{
						string pathName2 = currentRunBT.PathName;
						string str2 = $"行为树（{pathName2}）下的BAIT_Combo节点中Combo（{j}）中的SkillID（{bAIT_Combo.SkillArray[j].SkillID[k]}）未在SkillS表中找到索引";
						Get(actor.World).AddAITaskValidateLog(str2);
					}
				}
			}
		}
	}

	public void AddAITaskValidateLog(string str)
	{
		AITaskValidateLog += str;
		AITaskValidateLog += "\n";
	}

	public void CheckFUStTaskStageDesc()
	{
		string toBlame = "songjiajun";
		foreach (KeyValuePair<int, FUStTaskStageDesc> item in BGW_GameDB.GetAllTaskStageDesc())
		{
			FUStTaskStageDesc value = item.Value;
			if (value.ActivatedDropItemList != null && value.ActivatedDropItemList.Count > 0)
			{
				foreach (int activatedDropItem in value.ActivatedDropItemList)
				{
					if (GameDBRuntime.GetCommDropRuleDesc(activatedDropItem) == null)
					{
						AddValidateLog(string.Format($"FUStTaskStageDesc Id:{value.ID} Activated DropID:{activatedDropItem} 未在CommDropRuleDesc里找到对应值！"), toBlame);
					}
				}
			}
			if (value.FinishedDropItemList == null || value.FinishedDropItemList.Count <= 0)
			{
				continue;
			}
			foreach (int finishedDropItem in value.FinishedDropItemList)
			{
				if (GameDBRuntime.GetCommDropRuleDesc(finishedDropItem) == null)
				{
					AddValidateLog(string.Format($"FUStTaskStageDesc Id:{value.ID} Finished DropID:{finishedDropItem} 未在CommDropRuleDesc里找到对应值！"), toBlame);
				}
			}
		}
	}

	private void CheckOtherData()
	{
		CheckRichTextDesc();
	}

	private void CheckRichTextDesc()
	{
		List<Tuple<string, string>> list = new List<Tuple<string, string>>();
		GameDBResB1.DumpStringContent(list);
		GameDBBtlB1.DumpStringContent(list);
		GameDBBtlShare.DumpStringContent(list);
		foreach (Tuple<string, string> item in list)
		{
			string text = item.Item2.ToFTextRemoveRich().ToString();
			if (!text.Contains("<"))
			{
				text.Contains(">");
			}
		}
	}

	private bool CheckInvalidAnimBluePrintData()
	{
		if (InvalidAnimBluePrintData != null && InvalidAnimBluePrintData.Count > 0)
		{
			for (int i = 0; i < InvalidAnimBluePrintData.Count; i++)
			{
				InvalidAnimBluePrintLog = InvalidAnimBluePrintLog + "\n" + InvalidAnimBluePrintData[i];
			}
			InvalidAnimBluePrintData.Clear();
			return true;
		}
		return false;
	}

	public void AddInvalidAnimBluePrintData(string Msg)
	{
		if (InvalidAnimBluePrintData == null)
		{
			InvalidAnimBluePrintData = new List<string>();
		}
		InvalidAnimBluePrintData.Add(Msg);
	}

	private void CheckBossRushConfigDesc()
	{
		foreach (KeyValuePair<int, FUStBossRushConfigDesc> item in BGW_GameDB.GetAllBossRushConfigDesc())
		{
			FUStBossRushConfigDesc value = item.Value;
			if (value == null)
			{
				continue;
			}
			string graphPath = value.GraphPath;
			if (BGW_PreloadAssetMgr.RequestSyncLoadObjectInEditor<BED_BossRushAsset>(graphPath) == null)
			{
				AddValidateLog($"FUStBossRushConfigDesc Id:{value.ID} 未找到BRG: {graphPath}");
				continue;
			}
			string text = GameplayTagExtension.Convert2CalliopeDataFilePath(graphPath);
			if (!File.Exists(text))
			{
				AddValidateLog($"FUStBossRushConfigDesc Id:{value.ID} 未找到BRGData: {text}");
				continue;
			}
			FCalliopeGraph fCalliopeGraph = GameplayTagExtension.LoadGraph(graphPath);
			if (fCalliopeGraph == null)
			{
				AddValidateLog($"FUStBossRushConfigDesc Id:{value.ID} BRGData 读取失败: {text}");
				continue;
			}
			FCalliopeNode startNode = fCalliopeGraph.GetStartNode();
			if (startNode == null)
			{
				continue;
			}
			BossRushCustom_InitialV2 bossRushCustom_InitialV = new BossRushCustom_InitialV2();
			bossRushCustom_InitialV.MergeFrom(startNode.NodeData);
			FTransform fTransform = CalliopeExtension.ToFTransform(bossRushCustom_InitialV.PlayerStartForSingle);
			FTransform fTransform2 = CalliopeExtension.ToFTransform(bossRushCustom_InitialV.PlayerStartForGroup);
			if (fTransform == FTransform.Identity && fTransform2 == FTransform.Identity)
			{
				AddValidateLog($"FUStBossRushConfigDesc Id:{value.ID} 出生点配置为0点");
				continue;
			}
			foreach (BossRushCustom_GroupBattleConfigV2 groupBattleConfig in bossRushCustom_InitialV.GroupBattleConfigs)
			{
				int groupId = groupBattleConfig.GroupId;
				if (groupId > 0 && GameDBRuntime.GetBossIterationsDesc(groupId) == null)
				{
					AddValidateLog($"FUStBossRushConfigDesc Id:{value.ID} 未找到连战配置对应的连战ID:{groupId}");
				}
			}
		}
	}

	static BGW_ValiDateMgr()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGW_ValiDateMgr)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGW_ValiDateMgr));
		ValidateLog = new Dictionary<string, string>();
		ValidateLogCount = new Dictionary<string, int>();
		CheckOverMontagePathNameList = new List<string>();
		AITaskValidateLog = "";
		CheckOverAITaskList = new List<int>();
		InvalidAnimBluePrintLog = "";
		InvalidAnimBluePrintData = new List<string>();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGW_ValiDateMgr");
	}
}
