using System.Reflection;
using ResB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BGW_GameUserSettingTemplate : BGW_GameSettingTemplateBase
{
	public override void ApplyFirstSetting(UObject WorldContext, UISettingConfigType SettingType, int DefaultValue)
	{
		if (BGW_SettingFuncUtil.GetIsEditorSetting() || BGW_SettingFuncUtil.GetIsHost())
		{
			return;
		}
		UGameUserSettings gameUserSettings = UGameUserSettings.GetGameUserSettings();
		UISettingConfigDesc uISettingConfigDesc = GameDBRuntime.GetUISettingConfigDesc(SettingType);
		if (gameUserSettings != null && uISettingConfigDesc != null && gameUserSettings != null)
		{
			MethodInfo method = typeof(UGameUserSettings).GetMethod("Set" + uISettingConfigDesc.TempelteParam);
			if (method != null)
			{
				object[] objectValueByConfigType = BGW_SettingFuncUtil.GetObjectValueByConfigType(DefaultValue, SettingType);
				if (SettingType != UISettingConfigType.QualityLevel || DefaultValue != 6)
				{
					method.Invoke(gameUserSettings, objectValueByConfigType);
				}
			}
		}
		if (SettingType == UISettingConfigType.QualityLevel)
		{
			UGSE_GSGameSettingsFuncLib.ApplyGSGameResolutionSettings(bSaveSettings: true);
		}
		UGSE_GSGameSettingsFuncLib.ApplyGSGameSettings(bSaveSettings: true);
	}
}
