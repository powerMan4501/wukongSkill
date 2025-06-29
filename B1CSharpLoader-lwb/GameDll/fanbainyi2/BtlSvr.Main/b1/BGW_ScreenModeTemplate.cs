using System.Collections.Generic;
using ResB1;
using UnrealEngine.Runtime;

namespace b1;

public class BGW_ScreenModeTemplate : BGW_GameSettingTemplateBase
{
	public override void ApplyFirstSetting(UObject WorldContext, UISettingConfigType SettingType, int DefaultValue)
	{
		BGW_SettingFuncUtil.SetScreenMode(DefaultValue);
	}

	public override void ApplySettingStartGame(UObject WorldContext, int NewValue, Dictionary<UISettingConfigType, GsCvarData> ConsoleVariableDict)
	{
		if (NewValue == 0)
		{
			BGW_SettingFuncUtil.SetScreenMode(1);
		}
	}
}
