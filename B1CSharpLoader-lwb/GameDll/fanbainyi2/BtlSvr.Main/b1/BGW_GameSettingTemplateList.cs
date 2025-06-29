using System.Collections.Generic;
using ResB1;

namespace b1;

public static class BGW_GameSettingTemplateList
{
	public static Dictionary<SettingFunTempelte, BGW_GameSettingTemplateBase> ConfigTypeTemplates = new Dictionary<SettingFunTempelte, BGW_GameSettingTemplateBase>();

	public static BGW_GameSettingTemplateBase GetGameSettingTemplateByType(SettingFunTempelte FunTempelte)
	{
		if (ConfigTypeTemplates.Count == 0)
		{
			InitTemplates();
		}
		if (ConfigTypeTemplates.TryGetValue(FunTempelte, out var value))
		{
			return value;
		}
		return ConfigTypeTemplates[SettingFunTempelte.ConsoleVariable];
	}

	public static void InitTemplates()
	{
		ConfigTypeTemplates.Add(SettingFunTempelte.ConsoleVariable, new BGW_GameSettingTemplateBase());
		ConfigTypeTemplates.Add(SettingFunTempelte.MainScreen, new BGW_MainDisplayTemplate());
		ConfigTypeTemplates.Add(SettingFunTempelte.ScreenMode, new BGW_ScreenModeTemplate());
		ConfigTypeTemplates.Add(SettingFunTempelte.ScreenResolution, new BGW_ScreenResolutionTemplate());
		ConfigTypeTemplates.Add(SettingFunTempelte.SuperResolutionSampling, new BGW_SuperResolutionSamplingTemplate());
		ConfigTypeTemplates.Add(SettingFunTempelte.InsertFrame, new BGW_InsertFrameTemplate());
		ConfigTypeTemplates.Add(SettingFunTempelte.MotionBlur, new BGW_MotionBlurTemplate());
		ConfigTypeTemplates.Add(SettingFunTempelte.GameUserSetting, new BGW_GameUserSettingTemplate());
		ConfigTypeTemplates.Add(SettingFunTempelte.GameUserSettingV2, new BGW_GameUserSettingTemplate());
		ConfigTypeTemplates.Add(SettingFunTempelte.ImageQuality, new BGW_ImageQualityTemplate());
		ConfigTypeTemplates.Add(SettingFunTempelte.WindowFullResolution, new BGW_WindowFullResolutionTemplate());
		ConfigTypeTemplates.Add(SettingFunTempelte.FrameRateQualityFirst, new BGW_FrameRateQualityFirstTemplate());
		ConfigTypeTemplates.Add(SettingFunTempelte.Brightness, new BGW_BrightnessTemplate());
		ConfigTypeTemplates.Add(SettingFunTempelte.Hdrbrightness, new BGW_HdrbrightnessTemplate());
		ConfigTypeTemplates.Add(SettingFunTempelte.Hdruibrightness, new BGW_HdruibrightnessTemplate());
		ConfigTypeTemplates.Add(SettingFunTempelte.Rtxlevel, new BGW_RtxlevelTemplate());
		ConfigTypeTemplates.Add(SettingFunTempelte.Rtx, new BGW_RtxTemplate());
	}
}
