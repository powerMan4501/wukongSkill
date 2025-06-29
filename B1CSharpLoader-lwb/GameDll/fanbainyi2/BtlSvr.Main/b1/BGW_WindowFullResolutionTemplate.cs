using System.Collections.Generic;
using ResB1;
using UnrealEngine.Runtime;

namespace b1;

public class BGW_WindowFullResolutionTemplate : BGW_GameSettingTemplateBase
{
	public override void ApplySettingStartGame(UObject WorldContext, int NewValue, Dictionary<UISettingConfigType, GsCvarData> ConsoleVariableDict)
	{
		if (BGW_SettingFuncUtil.GetIsEditorSetting() || FPlatformProperties.GetPlatform() != EPlatform.Windows)
		{
			return;
		}
		UISettingConfigDesc uISettingConfigDesc = GameDBRuntime.GetUISettingConfigDesc(UISettingConfigType.WindowFullImageQuality);
		if (uISettingConfigDesc != null)
		{
			BGW_SettingMgrV2 bGW_SettingMgrV = BGW_SettingMgrV2.Get(WorldContext);
			bGW_SettingMgrV.GetItemValueByType(uISettingConfigDesc, out var DefaultValue);
			if (bGW_SettingMgrV != null)
			{
				bGW_SettingMgrV.SetSecondaryScreenPercentageCVar((float)DefaultValue * 0.0001f);
			}
		}
	}
}
