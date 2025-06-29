using ResB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BGW_ImageQualityTemplate : BGW_GameSettingTemplateBase
{
	public override void ApplyFirstSetting(UObject WorldContext, UISettingConfigType SettingType, int DefaultValue)
	{
		if (BGW_SettingFuncUtil.GetIsEditorSetting() || BGW_SettingFuncUtil.GetIsHost() || GameDBRuntime.GetUISettingConfigDesc(SettingType) == null)
		{
			return;
		}
		UGameUserSettings gameUserSettings = UGameUserSettings.GetGameUserSettings();
		if (gameUserSettings != null)
		{
			int y = gameUserSettings.GetScreenResolution().Y;
			if (y > 0)
			{
				BGW_SettingFuncUtil.SetScreenPercentage(FMath.RoundToInt(100f * (float)DefaultValue / (float)y), NeedApply: true);
			}
		}
	}
}
