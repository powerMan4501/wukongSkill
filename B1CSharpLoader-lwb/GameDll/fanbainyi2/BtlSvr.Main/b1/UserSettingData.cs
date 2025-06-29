using System;
using System.Collections.Generic;
using System.Reflection;
using CommB1;
using Google.Protobuf.Collections;
using ResB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class UserSettingData
{
	public Dictionary<string, string> LocalSettingDict = new Dictionary<string, string>();

	public Dictionary<UISettingConfigType, string> CloudSettingDict = new Dictionary<UISettingConfigType, string>();

	private Dictionary<UISettingConfigType, GsCvarData> ConsoleVariableDict = new Dictionary<UISettingConfigType, GsCvarData>();

	private Dictionary<UISettingConfigType, int> ValueScaleDict = new Dictionary<UISettingConfigType, int>();

	public void InitCloudSettingData(UISettingArchiveData SettingArchiveData)
	{
		if (CloudSettingDict.Count > 0)
		{
			return;
		}
		foreach (SettingArchiveData archiveDatum in SettingArchiveData.ArchiveData)
		{
			string text = archiveDatum.SettingValue;
			if (SettingProtoVersionCheck.CheckFixSettingData(archiveDatum.SettingKey.ToString(), (int)SettingArchiveData.SettingpbTag, text, out var FixValue))
			{
				text = FixValue;
			}
			CloudSettingDict.Add(archiveDatum.SettingKey, text);
		}
	}

	public void InitConsoleVariableDict(UObject WorldContext, out Dictionary<UISettingConfigType, int> SettingDict)
	{
		RegisterLocalSetting();
		RegisterCloudSetting();
		InitSettingRecommendDict(WorldContext);
		SetAllDefaultSetting(WorldContext);
		CacheValueScaleDict();
		ApplySettingStartGame(WorldContext);
		SettingDict = GetDetailSettingFromTable();
	}

	private void RegisterLocalSetting()
	{
		foreach (KeyValuePair<string, string> item in LocalSettingDict)
		{
			string name = "UISetting." + item.Key;
			if (int.TryParse(item.Value, out var result))
			{
				IConsoleVariable consoleVariable = IConsoleManager.Get()?.FindConsoleVariable(name);
				if (consoleVariable == null)
				{
					consoleVariable = IConsoleManager.Get().RegisterConsoleVariable(name, result, "");
				}
				GsCvarData gsCvarData = new GsCvarData(consoleVariable);
				gsCvarData.SetInt(result);
				if (Enum.TryParse<UISettingConfigType>(item.Key, out var result2) && GSEUtil.Ensure(!ConsoleVariableDict.ContainsKey(result2)))
				{
					ConsoleVariableDict.Add(result2, gsCvarData);
				}
			}
			else
			{
				BGW_LogUtil.LogError("InitConsoleVariableDict  Fail !!! " + item.Key + " :" + item.Value);
			}
		}
	}

	private void ApplySettingStartGame(UObject WorldContext)
	{
		RepeatedField<UISettingConfigDesc> list = GameDBRuntime.GetTBUISettingConfigDesc().List;
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
			foreach (KeyValuePair<UISettingConfigType, GsCvarData> item2 in ConsoleVariableDict)
			{
				UISettingConfigDesc uISettingConfigDesc = GameDBRuntime.GetUISettingConfigDesc(item2.Key);
				if (uISettingConfigDesc != null && uISettingConfigDesc.Priority == i)
				{
					BGW_GameSettingTemplateList.GetGameSettingTemplateByType(uISettingConfigDesc.FunTempelte).CheckAndApplySettingStartGame(NewValue: CheckLegality(WorldContext, uISettingConfigDesc.ConfigType, item2.Value.GetValueInGameThread()), SettingConfigType: uISettingConfigDesc.ConfigType, WorldContext: WorldContext, ConsoleVariableDict: ConsoleVariableDict);
				}
			}
		}
	}

	private int CheckLegality(UObject WorldContext, UISettingConfigType SettingConfigType, int SaveValue)
	{
		int result = SaveValue;
		if (SettingConfigType == UISettingConfigType.ImageQuality)
		{
			if (SaveValue <= 100)
			{
				result = BGW_SettingMgrV2.GetRecommendValue(UISettingConfigType.ImageQuality);
			}
			BGW_SettingFuncUtil.SaveSettingData(WorldContext, SettingConfigType, result.ToString());
		}
		return result;
	}

	private void RegisterCloudSetting()
	{
		foreach (KeyValuePair<UISettingConfigType, string> item in CloudSettingDict)
		{
			string name = $"UISetting.{item.Key}";
			int num = int.Parse(item.Value);
			IConsoleVariable consoleVariable = IConsoleManager.Get()?.FindConsoleVariable(name);
			if (consoleVariable == null)
			{
				consoleVariable = IConsoleManager.Get().RegisterConsoleVariable(name, num, "");
			}
			GsCvarData gsCvarData = new GsCvarData(consoleVariable);
			gsCvarData.SetInt(num);
			if (!ConsoleVariableDict.ContainsKey(item.Key))
			{
				ConsoleVariableDict.Add(item.Key, gsCvarData);
			}
		}
	}

	private void InitSettingRecommendDict(UObject WorldContext)
	{
		if (!BGW_SettingFuncUtil.GetIsEditorSetting())
		{
			BGW_SettingFuncUtil.SetWindowRecommendQuality(WorldContext);
		}
	}

	private void SetAllDefaultSetting(UObject WorldContext)
	{
		foreach (List<UISettingConfigDesc> item in GameDBRuntime.GetUISettingConfigDescDict())
		{
			foreach (UISettingConfigDesc item2 in item)
			{
				if (!ConsoleVariableDict.ContainsKey(item2.ConfigType))
				{
					string name = $"UISetting.{item2.ConfigType}";
					int defaultValueAndApplySetting = BGW_GameSettingTemplateList.GetGameSettingTemplateByType(item2.FunTempelte).GetDefaultValueAndApplySetting(WorldContext, BGW_SettingMgrV2.GetRecommendDict(), item2.ConfigType);
					IConsoleVariable consoleVariable = IConsoleManager.Get()?.FindConsoleVariable(name);
					if (consoleVariable == null)
					{
						consoleVariable = IConsoleManager.Get().RegisterConsoleVariable(name, defaultValueAndApplySetting, "");
					}
					GsCvarData gsCvarData = new GsCvarData(consoleVariable);
					gsCvarData.SetInt(defaultValueAndApplySetting);
					ConsoleVariableDict.Add(item2.ConfigType, gsCvarData);
					BGW_SettingFuncUtil.SaveSettingData(WorldContext, item2.ConfigType, defaultValueAndApplySetting.ToString());
				}
			}
		}
	}

	private void CacheValueScaleDict()
	{
		foreach (UISettingConfigDesc item in GameDBRuntime.GetTBUISettingConfigDesc().List)
		{
			if (item.ValueScale > 0)
			{
				if (!ValueScaleDict.ContainsKey(item.ConfigType))
				{
					ValueScaleDict.Add(item.ConfigType, item.ValueScale);
				}
				else
				{
					ValueScaleDict[item.ConfigType] = item.ValueScale;
				}
			}
		}
	}

	private Dictionary<UISettingConfigType, int> GetDetailSettingFromTable()
	{
		Dictionary<UISettingConfigType, int> dictionary = new Dictionary<UISettingConfigType, int>();
		foreach (UISettingConfigDesc item in GameDBRuntime.GetTBUISettingConfigDesc().List)
		{
			if (item.FunTempelte != SettingFunTempelte.GameUserSettingV2 || item.ConfigTab != EUIConfigTab.Detail)
			{
				continue;
			}
			UGameUserSettings gameUserSettings = UGameUserSettings.GetGameUserSettings();
			if (gameUserSettings != null)
			{
				MethodInfo method = typeof(UGameUserSettings).GetMethod("Get" + item.TempelteParam);
				if (method != null)
				{
					object newValue = method.Invoke(gameUserSettings, null);
					dictionary.Add(item.ConfigType, BGW_SettingMgrV2.GetIntValueByConfigType(newValue, item.ConfigType));
				}
			}
		}
		return dictionary;
	}

	public int GetValueScale(UISettingConfigType ConfigType)
	{
		if (ValueScaleDict.TryGetValue(ConfigType, out var value))
		{
			return value;
		}
		return 1;
	}

	public string GetConsoleVariableByType(UISettingConfigType ConfigType)
	{
		if (!ConsoleVariableDict.ContainsKey(ConfigType))
		{
			return null;
		}
		return ConsoleVariableDict[ConfigType].GetValueInGameThread().ToString();
	}

	public void SetConsoleVariableByType(UISettingConfigType ConfigType, int Value)
	{
		if (ConsoleVariableDict.ContainsKey(ConfigType))
		{
			ConsoleVariableDict[ConfigType].SetInt(Value);
		}
	}

	public void SetCouldSetteting(UISettingConfigType ConfigType, string NewValue)
	{
		if (CloudSettingDict.ContainsKey(ConfigType))
		{
			CloudSettingDict[ConfigType] = NewValue;
		}
		else
		{
			CloudSettingDict.Add(ConfigType, NewValue);
		}
	}
}
