using System.Collections.Generic;
using ResB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BGW_HdrbrightnessTemplate : BGW_GameSettingTemplateBase
{
	public override void ApplySettingStartGame(UObject WorldContext, int NewValue, Dictionary<UISettingConfigType, GsCvarData> ConsoleVariableDict)
	{
		UGameUserSettings gameUserSettings = UGameUserSettings.GetGameUserSettings();
		if (gameUserSettings != null)
		{
			string name = "r.HDR.EnableHDROutput";
			IConsoleVariable consoleVariable = IConsoleManager.Get().FindConsoleVariable(name);
			bool bEnable = false;
			if (consoleVariable != null && consoleVariable.GetInt() > 0)
			{
				bEnable = true;
			}
			gameUserSettings.EnableHDRDisplayOutput(bEnable, NewValue);
		}
	}
}
