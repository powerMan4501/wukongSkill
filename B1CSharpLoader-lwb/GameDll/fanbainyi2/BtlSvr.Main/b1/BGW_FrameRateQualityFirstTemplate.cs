using System.Collections.Generic;
using ResB1;
using UnrealEngine.Runtime;

namespace b1;

public class BGW_FrameRateQualityFirstTemplate : BGW_GameSettingTemplateBase
{
	public override void ApplyFirstSetting(UObject WorldContext, UISettingConfigType SettingType, int DefaultValue)
	{
		if (FPlatformProperties.GetPlatform() == EPlatform.PS5 || DebugConfig.SettingHostSimulation)
		{
			BGW_SettingFuncUtil.SetPS5FrameQualityType(WorldContext, DefaultValue, IsInit: false, UGSE_GSGameSettingsFuncLib.GetIsPS5Pro());
			return;
		}
		string text = "Invalid";
		if (text != "Invalid")
		{
			bool isXSX = false;
			if (text.Contains("Xbox Series X"))
			{
				isXSX = true;
			}
			BGW_SettingFuncUtil.SetXSXFrameQualityType(WorldContext, DefaultValue, IsInit: false, isXSX);
		}
	}

	public override void ApplySettingStartGame(UObject WorldContext, int NewValue, Dictionary<UISettingConfigType, GsCvarData> ConsoleVariableDict)
	{
		if (FPlatformProperties.GetPlatform() == EPlatform.PS5 || DebugConfig.SettingHostSimulation)
		{
			BGW_SettingFuncUtil.SetPS5FrameQualityType(WorldContext, NewValue, IsInit: true, UGSE_GSGameSettingsFuncLib.GetIsPS5Pro());
			return;
		}
		string text = "Invalid";
		if (text != "Invalid")
		{
			bool isXSX = false;
			if (text.Contains("Xbox Series X"))
			{
				isXSX = true;
			}
			BGW_SettingFuncUtil.SetXSXFrameQualityType(WorldContext, NewValue, IsInit: false, isXSX);
		}
	}
}
