using System.Collections.Generic;
using ResB1;
using UnrealEngine.Runtime;

namespace b1;

public class BGW_BrightnessTemplate : BGW_GameSettingTemplateBase
{
	public override void ApplySettingStartGame(UObject WorldContext, int NewValue, Dictionary<UISettingConfigType, GsCvarData> ConsoleVariableDict)
	{
		float gamma = BGW_ScreenSettingFunUtil.CalGamma((float)NewValue * 0.01f);
		UGSE_EngineFuncLib.SetDisplayGamma(WorldContext, gamma);
	}
}
