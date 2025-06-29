using System.Collections.Generic;
using ResB1;
using UnrealEngine.Runtime;

namespace b1;

public class BGW_InsertFrameTemplate : BGW_GameSettingTemplateBase
{
	public override void ApplySettingStartGame(UObject WorldContext, int NewValue, Dictionary<UISettingConfigType, GsCvarData> ConsoleVariableDict)
	{
		foreach (KeyValuePair<UISettingConfigType, GsCvarData> item in ConsoleVariableDict)
		{
			if (item.Key == UISettingConfigType.SuperResolutionSampling)
			{
				int valueInGameThread = item.Value.GetValueInGameThread();
				BGW_SettingFuncUtil.DoInsertFrameLogic(WorldContext, valueInGameThread, NewValue);
			}
		}
	}
}
