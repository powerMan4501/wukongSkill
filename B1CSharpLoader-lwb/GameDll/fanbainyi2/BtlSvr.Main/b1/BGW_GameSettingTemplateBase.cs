using System.Collections.Generic;
using ResB1;
using UnrealEngine.Runtime;

namespace b1;

public class BGW_GameSettingTemplateBase
{
	public virtual int GetDefaultValueAndApplySetting(UObject WorldContext, Dictionary<UISettingConfigType, int> SettingRecommendDict, UISettingConfigType SettingType)
	{
		UISettingConfigDesc uISettingConfigDesc = GameDBRuntime.GetUISettingConfigDesc(SettingType);
		if (uISettingConfigDesc != null)
		{
			int defaultValue = BGW_SettingFuncUtil.GetDefaultValue(SettingRecommendDict, uISettingConfigDesc);
			CheckAndApplyFirstSetting(WorldContext, SettingType, defaultValue);
			return defaultValue;
		}
		BGW_LogUtil.LogError($"Cant find UISettingConfigType :{SettingType}!!");
		return 0;
	}

	public void CheckAndApplyFirstSetting(UObject WorldContext, UISettingConfigType SettingType, int DefaultValue)
	{
		if (BGW_SettingFuncUtil.CheckCanApply(SettingType))
		{
			ApplyFirstSetting(WorldContext, SettingType, DefaultValue);
		}
	}

	public virtual void ApplyFirstSetting(UObject WorldContext, UISettingConfigType SettingType, int DefaultValue)
	{
	}

	public void CheckAndApplySettingStartGame(UISettingConfigType SettingConfigType, UObject WorldContext, int NewValue, Dictionary<UISettingConfigType, GsCvarData> ConsoleVariableDict)
	{
		if (BGW_SettingFuncUtil.CheckCanApply(SettingConfigType))
		{
			ApplySettingStartGame(WorldContext, NewValue, ConsoleVariableDict);
		}
	}

	public virtual void ApplySettingStartGame(UObject WorldContext, int NewValue, Dictionary<UISettingConfigType, GsCvarData> ConsoleVariableDict)
	{
	}
}
