using System.Collections.Generic;
using ResB1;
using UnrealEngine.Runtime;

namespace b1;

public class BGW_SuperResolutionSamplingTemplate : BGW_GameSettingTemplateBase
{
	public override void ApplySettingStartGame(UObject WorldContext, int NewValue, Dictionary<UISettingConfigType, GsCvarData> ConsoleVariableDict)
	{
		BGW_SettingFuncUtil.DoSuperResolutionSamplingLogic(WorldContext, NewValue);
	}
}
