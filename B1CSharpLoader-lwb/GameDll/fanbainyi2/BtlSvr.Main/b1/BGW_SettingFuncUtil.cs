using System.Collections.Generic;
using b1.BGW;
using b1.Plugins.ConsoleVariableManager;
using Microsoft.Win32;
using ResB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public static class BGW_SettingFuncUtil
{
	public struct FHostQualityStruct
	{
		public int RenderingResolutionY;

		public int GameResolutionY;

		public int SystemResolutionY;

		public int Vsync;
	}

	public static readonly FName bWPOInsteadVHM = new FName("bWPOInsteadVHM");

	public static int CVARHandle_VHMEnable = -1;

	private static FIntPoint ScreenResolutionMin = new FIntPoint(1280, 720);

	public static FIntPoint LastManualScreenResolution;

	public static bool GetSettingBoolValueByType(UObject WorldContext, UISettingConfigType SettingConfigType)
	{
		return BGW_SettingMgrV2.Get(WorldContext).GetCVBoolByType(SettingConfigType);
	}

	public static int GetSettingIntValueByType(UObject WorldContext, UISettingConfigType SettingConfigType)
	{
		return BGW_SettingMgrV2.Get(WorldContext).GetCVValueleByType(SettingConfigType);
	}

	public static bool GetIsEditorSetting()
	{
		if (!DebugConfig.SettingEditorSimulation)
		{
			return FGlobals.IsEditor;
		}
		return false;
	}

	public static bool GetIsHost()
	{
		if (!DebugConfig.SettingHostSimulation && FPlatformProperties.GetPlatform() != EPlatform.PS5)
		{
			return FPlatformProperties.GetPlatform() == EPlatform.XSX;
		}
		return true;
	}

	public static bool CheckCanApply(UISettingConfigType SettingType)
	{
		if (GetIsEditorSetting())
		{
			return false;
		}
		if (GetIsHost())
		{
			UISettingConfigDesc uISettingConfigDesc = GameDBRuntime.GetUISettingConfigDesc(SettingType);
			if (uISettingConfigDesc != null && (uISettingConfigDesc.ShowType & 8) > 0)
			{
				return false;
			}
		}
		return true;
	}

	public static void SaveSettingData(UObject WorldContext, UISettingConfigType SettingType, string SettingValue)
	{
		BGW_SettingMgrV2 bGW_SettingMgrV = BGW_SettingMgrV2.Get(WorldContext);
		UISettingConfigDesc uISettingConfigDesc = GameDBRuntime.GetUISettingConfigDesc(SettingType);
		if (uISettingConfigDesc != null)
		{
			switch (uISettingConfigDesc.SaveType)
			{
			case UIConfigSaveType.Local:
				bGW_SettingMgrV.SetLocalSetteting(SettingType, SettingValue);
				break;
			case UIConfigSaveType.Cloud:
				bGW_SettingMgrV.SetCouldSetteting(SettingType, SettingValue);
				bGW_SettingMgrV.WriteSaveCloudData();
				break;
			}
		}
	}

	public static int GetDefaultValue(Dictionary<UISettingConfigType, int> SettingRecommendDict, UISettingConfigDesc SettingDesc)
	{
		int result = SettingDesc.DefaultValue;
		if (SettingRecommendDict != null && SettingRecommendDict.ContainsKey(SettingDesc.ConfigType))
		{
			result = SettingRecommendDict[SettingDesc.ConfigType];
		}
		return result;
	}

	public static int GetDefaultValue(UObject WorldContext, UISettingConfigDesc SettingDesc)
	{
		int result = SettingDesc.DefaultValue;
		if (BGW_SettingMgrV2.Get(WorldContext) != null)
		{
			Dictionary<UISettingConfigType, int> recommendDict = BGW_SettingMgrV2.GetRecommendDict();
			if (recommendDict != null && recommendDict.ContainsKey(SettingDesc.ConfigType))
			{
				result = recommendDict[SettingDesc.ConfigType];
			}
		}
		return result;
	}

	public static void DoInsertFrameLogic(UObject WorldContext, int SuperResolutionSampling, int InsertFrame)
	{
		if (InsertFrame == 0)
		{
			DoDlssLogic(WorldContext, 0);
			DoFSRLogic(WorldContext, 0);
			return;
		}
		switch (SuperResolutionSampling)
		{
		case 0:
			DoDlssLogic(WorldContext, 0);
			DoFSRLogic(WorldContext, 1);
			break;
		case 2:
			DoFSRLogic(WorldContext, 0);
			DoDlssLogic(WorldContext, 1);
			break;
		case 1:
			DoDlssLogic(WorldContext, 0);
			DoFSRLogic(WorldContext, 0);
			break;
		case 3:
			DoDlssLogic(WorldContext, 0);
			DoFSRLogic(WorldContext, 1);
			break;
		case 4:
			DoDlssLogic(WorldContext, 0);
			DoFSRLogic(WorldContext, 0);
			break;
		case 5:
			DoDlssLogic(WorldContext, 0);
			DoFSRLogic(WorldContext, 1);
			break;
		case 6:
			DoDlssLogic(WorldContext, 0);
			DoFSRLogic(WorldContext, 0);
			break;
		}
	}

	public static void DoFSRLogic(UObject WorldContext, int NewValue)
	{
		if (GetIsEditorSetting())
		{
			NewValue = 0;
		}
		BGW_SettingMgrV2 bGW_SettingMgrV = BGW_SettingMgrV2.Get(WorldContext);
		if (bGW_SettingMgrV != null)
		{
			bGW_SettingMgrV.SetFidelityFXEnableCVar(NewValue);
		}
		if (FPlatformProperties.GetPlatform() == EPlatform.Windows)
		{
			bGW_SettingMgrV.SetFSR_FinishCurrentFrame(NewValue);
		}
	}

	public static void DoDlssLogic(UObject WorldContext, int NewValue)
	{
		if (GetIsEditorSetting())
		{
			NewValue = 0;
		}
		BGW_SettingMgrV2 bGW_SettingMgrV = BGW_SettingMgrV2.Get(WorldContext);
		if (bGW_SettingMgrV != null)
		{
			bGW_SettingMgrV.SetDLSSGCVar(NewValue);
		}
	}

	public static void SetTSRState(UObject WorldContext, int NewValue)
	{
		if (!GetIsEditorSetting())
		{
			BGW_SettingMgrV2 bGW_SettingMgrV = BGW_SettingMgrV2.Get(WorldContext);
			if (bGW_SettingMgrV != null)
			{
				bGW_SettingMgrV.SetTSRCVar(NewValue);
			}
		}
	}

	public static void SetTAAState(UObject WorldContext, int NewValue)
	{
		if (!GetIsEditorSetting())
		{
			BGW_SettingMgrV2 bGW_SettingMgrV = BGW_SettingMgrV2.Get(WorldContext);
			if (bGW_SettingMgrV != null)
			{
				bGW_SettingMgrV.SetTAACVar(NewValue);
			}
		}
	}

	public static void SetDlssState(UObject WorldContext, int NewValue)
	{
		if (!GetIsEditorSetting())
		{
			BGW_SettingMgrV2 bGW_SettingMgrV = BGW_SettingMgrV2.Get(WorldContext);
			if (bGW_SettingMgrV != null)
			{
				bGW_SettingMgrV.SetDLSSEnableCVar(NewValue);
			}
		}
	}

	public static void SetFSRState(UObject WorldContext, int NewValue)
	{
		if (!GetIsEditorSetting())
		{
			BGW_SettingMgrV2 bGW_SettingMgrV = BGW_SettingMgrV2.Get(WorldContext);
			if (bGW_SettingMgrV != null)
			{
				bGW_SettingMgrV.SetFSREnableCVar(NewValue);
			}
		}
	}

	public static void SetXeSSState(UObject WorldContext, int NewValue)
	{
		if (GetIsEditorSetting())
		{
			return;
		}
		BGW_SettingMgrV2 bGW_SettingMgrV = BGW_SettingMgrV2.Get(WorldContext);
		if (bGW_SettingMgrV != null)
		{
			if (NewValue > 0)
			{
				UGameUserSettings.GetGameUserSettings().GetResolutionScaleInformationEx(out var _, out var CurrentScaleValue, out var _, out var _);
				UGSE_GSGameSettingsFuncLib.SetXeSSPercentage(CurrentScaleValue);
			}
			bGW_SettingMgrV.SetXeSSCVar(NewValue);
		}
	}

	public static void SetNXSRState(UObject WorldContext, int NewValue)
	{
		if (!GetIsEditorSetting())
		{
			BGW_SettingMgrV2 bGW_SettingMgrV = BGW_SettingMgrV2.Get(WorldContext);
			if (bGW_SettingMgrV != null)
			{
				bGW_SettingMgrV.SetNXSREnableCVar(NewValue);
			}
		}
	}

	public static void SetPSSRState(UObject WorldContext, int NewValue)
	{
		if (!GetIsEditorSetting())
		{
			BGW_SettingMgrV2 bGW_SettingMgrV = BGW_SettingMgrV2.Get(WorldContext);
			if (bGW_SettingMgrV != null)
			{
				bGW_SettingMgrV.SetPSSREnableCVar(NewValue);
			}
		}
	}

	public static void DoSuperResolutionSamplingLogic(UObject WorldContext, int NewValue)
	{
		switch (NewValue)
		{
		case 0:
			SetDlssState(WorldContext, 0);
			SetXeSSState(WorldContext, 0);
			SetTAAState(WorldContext, 0);
			SetTSRState(WorldContext, 0);
			SetNXSRState(WorldContext, 0);
			SetPSSRState(WorldContext, 0);
			SetFSRState(WorldContext, 1);
			break;
		case 1:
			SetDlssState(WorldContext, 0);
			SetFSRState(WorldContext, 0);
			SetTAAState(WorldContext, 0);
			SetTSRState(WorldContext, 0);
			SetNXSRState(WorldContext, 0);
			SetPSSRState(WorldContext, 0);
			SetXeSSState(WorldContext, 1);
			break;
		case 2:
			SetXeSSState(WorldContext, 0);
			SetFSRState(WorldContext, 0);
			SetTAAState(WorldContext, 0);
			SetTSRState(WorldContext, 0);
			SetNXSRState(WorldContext, 0);
			SetPSSRState(WorldContext, 0);
			SetDlssState(WorldContext, 1);
			break;
		case 3:
			SetXeSSState(WorldContext, 0);
			SetFSRState(WorldContext, 0);
			SetDlssState(WorldContext, 0);
			SetTAAState(WorldContext, 0);
			SetNXSRState(WorldContext, 0);
			SetPSSRState(WorldContext, 0);
			SetTSRState(WorldContext, 1);
			break;
		case 4:
			SetXeSSState(WorldContext, 0);
			SetFSRState(WorldContext, 0);
			SetDlssState(WorldContext, 0);
			SetTSRState(WorldContext, 0);
			SetNXSRState(WorldContext, 0);
			SetPSSRState(WorldContext, 0);
			SetTAAState(WorldContext, 1);
			break;
		case 5:
			SetXeSSState(WorldContext, 0);
			SetFSRState(WorldContext, 0);
			SetDlssState(WorldContext, 0);
			SetTSRState(WorldContext, 0);
			SetTAAState(WorldContext, 0);
			SetPSSRState(WorldContext, 0);
			SetNXSRState(WorldContext, 1);
			break;
		case 6:
			SetXeSSState(WorldContext, 0);
			SetFSRState(WorldContext, 0);
			SetDlssState(WorldContext, 0);
			SetTSRState(WorldContext, 0);
			SetTAAState(WorldContext, 0);
			SetNXSRState(WorldContext, 0);
			SetPSSRState(WorldContext, 1);
			break;
		}
		BGW_EventCollection.Get(WorldContext).Evt_SettingValueChanged(NewValue, NewValue, UISettingConfigType.SuperResolutionSampling);
	}

	public static int CheckInsertFrameAble(int SuperResolutionSampling)
	{
		int result = 1;
		switch (SuperResolutionSampling)
		{
		case 2:
		{
			if (!CheckGPUHardwareScheduling(out var _))
			{
				result = 0;
			}
			else if (!UGSE_SuperRSFuncLib.GetDLSSLisFeatureSupported())
			{
				result = 0;
			}
			break;
		}
		case 0:
		{
			bool flag = UGSE_GSGameSettingsFuncLib.IsLowFeatureLevelGPU();
			if (!UGSE_SuperRSFuncLib.GetIsDX12() || flag)
			{
				result = 0;
			}
			break;
		}
		}
		return result;
	}

	public static bool CheckGPUHardwareScheduling(out EGPUHardwareScheduling CheckResult)
	{
		bool flag = false;
		CheckResult = EGPUHardwareScheduling.Min;
		using (RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion"))
		{
			string text = registryKey.GetValue("ProductName") as string;
			int num = (int)registryKey.GetValue("CurrentMajorVersionNumber");
			int num2 = int.Parse(registryKey.GetValue("CurrentBuildNumber").ToString());
			if (!string.IsNullOrEmpty(text) && text.ToLower().Contains("windows"))
			{
				if (num > 10 || (num == 10 && num2 >= 22000))
				{
					_ = DebugConfig.DebugSettingLog;
					return true;
				}
				if (num != 10 || num2 >= 22000)
				{
					_ = DebugConfig.DebugSettingLog;
					CheckResult = EGPUHardwareScheduling.Version;
					return false;
				}
				if (!DebugConfig.DebugSettingLog)
				{
				}
			}
		}
		RegistryKey registryKey2 = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\GraphicsDrivers", writable: false);
		if (registryKey2 != null)
		{
			object value = registryKey2.GetValue("HwSchMode");
			if (value != null && value is int)
			{
				flag = (int)value == 2;
			}
			registryKey2.Close();
		}
		if (!flag)
		{
			CheckResult = EGPUHardwareScheduling.Scheduling;
			return false;
		}
		return true;
	}

	public static int GetSuperResolutionSamplingRealValue()
	{
		IConsoleVariable consoleVariable = IConsoleManager.Get().FindConsoleVariable("r.NGX.DLSS.Enable");
		IConsoleVariable consoleVariable2 = IConsoleManager.Get().FindConsoleVariable("r.XeSS.Enabled");
		if (consoleVariable != null && consoleVariable2 != null)
		{
			if (consoleVariable.GetInt() <= 0)
			{
				if (consoleVariable2.GetInt() > 0)
				{
					return 1;
				}
				return 0;
			}
			if (consoleVariable2.GetInt() == 0)
			{
				return 2;
			}
		}
		BGW_LogUtil.LogError("Get SuperResolutionSampling RealValue Failed");
		return 0;
	}

	public static bool GetSuperResolutionsamplingNeedForceVolatile()
	{
		bool result = false;
		int superResolutionSamplingRealValue = GetSuperResolutionSamplingRealValue();
		if (superResolutionSamplingRealValue == 0 || superResolutionSamplingRealValue == 3 || superResolutionSamplingRealValue == 5 || superResolutionSamplingRealValue == 6)
		{
			result = true;
		}
		return result;
	}

	public static void SetWindowRecommendQuality(UObject WorldContext)
	{
		BGW_SettingMgrV2 bGW_SettingMgrV = BGW_SettingMgrV2.Get(WorldContext);
		if (bGW_SettingMgrV == null || GetIsEditorSetting() || FPlatformProperties.GetPlatform() != EPlatform.Windows)
		{
			return;
		}
		TBUISettingDeviceConfigDesc tBUISettingDeviceConfigDesc = GameDBRuntime.GetTBUISettingDeviceConfigDesc();
		string rHIAdapterName = UGSE_GSGameSettingsFuncLib.GetRHIAdapterName();
		_ = DebugConfig.DebugSettingLog;
		bool flag = false;
		UISettingDeviceConfigDesc uISettingDeviceConfigDesc = null;
		foreach (UISettingDeviceConfigDesc item in tBUISettingDeviceConfigDesc.List)
		{
			if (rHIAdapterName.Contains(item.DeviceName))
			{
				flag = true;
				uISettingDeviceConfigDesc = item;
				break;
			}
		}
		if (flag)
		{
			bGW_SettingMgrV.AddSettingRecommendDict(UISettingConfigType.ViewDistance, (int)uISettingDeviceConfigDesc.ViewDistance);
			bGW_SettingMgrV.AddSettingRecommendDict(UISettingConfigType.AntiAliasing, (int)uISettingDeviceConfigDesc.AntiAliasing);
			bGW_SettingMgrV.AddSettingRecommendDict(UISettingConfigType.PostProcessing, (int)uISettingDeviceConfigDesc.PostProcessing);
			bGW_SettingMgrV.AddSettingRecommendDict(UISettingConfigType.MaterialQuality, (int)uISettingDeviceConfigDesc.MaterialQuality);
			bGW_SettingMgrV.AddSettingRecommendDict(UISettingConfigType.ShadowQuality, (int)uISettingDeviceConfigDesc.ShadowQuality);
			bGW_SettingMgrV.AddSettingRecommendDict(UISettingConfigType.FxQuality, (int)uISettingDeviceConfigDesc.FxQuality);
			bGW_SettingMgrV.AddSettingRecommendDict(UISettingConfigType.VegetationQuality, (int)uISettingDeviceConfigDesc.VegetationQuality);
			bGW_SettingMgrV.AddSettingRecommendDict(UISettingConfigType.GlobalIllumination, (int)uISettingDeviceConfigDesc.GlobalIllumination);
			bGW_SettingMgrV.AddSettingRecommendDict(UISettingConfigType.ReflectionQuality, (int)uISettingDeviceConfigDesc.ReflectionQuality);
			bGW_SettingMgrV.AddSettingRecommendDict(UISettingConfigType.TextureQuality, (int)uISettingDeviceConfigDesc.TextureQuality);
			bGW_SettingMgrV.AddSettingRecommendDict(UISettingConfigType.Rtx, (int)uISettingDeviceConfigDesc.Rtx);
			bGW_SettingMgrV.AddSettingRecommendDict(UISettingConfigType.RtxLevel, uISettingDeviceConfigDesc.RtxLevel);
			bGW_SettingMgrV.AddSettingRecommendDict(UISettingConfigType.SuperResolutionSampling, (int)uISettingDeviceConfigDesc.SuperResolutionsampling);
			bGW_SettingMgrV.AddSettingRecommendDict(UISettingConfigType.InsertFrame, (int)uISettingDeviceConfigDesc.InsertFrame);
			bGW_SettingMgrV.AddSettingRecommendDict(UISettingConfigType.ImageQuality, uISettingDeviceConfigDesc.ResolutionBaseY);
			return;
		}
		Dictionary<string, int> currentScalabilityDict = GetCurrentScalabilityDict();
		UGameUserSettings gameUserSettings = UGameUserSettings.GetGameUserSettings();
		gameUserSettings.RunHardwareBenchmark();
		bGW_SettingMgrV.AddSettingRecommendDict(UISettingConfigType.ViewDistance, gameUserSettings.GetViewDistanceQuality());
		bGW_SettingMgrV.AddSettingRecommendDict(UISettingConfigType.AntiAliasing, gameUserSettings.GetAntiAliasingQuality());
		bGW_SettingMgrV.AddSettingRecommendDict(UISettingConfigType.PostProcessing, gameUserSettings.GetPostProcessingQuality());
		bGW_SettingMgrV.AddSettingRecommendDict(UISettingConfigType.MaterialQuality, gameUserSettings.GetShadingQuality());
		bGW_SettingMgrV.AddSettingRecommendDict(UISettingConfigType.ShadowQuality, gameUserSettings.GetShadowQuality());
		bGW_SettingMgrV.AddSettingRecommendDict(UISettingConfigType.FxQuality, gameUserSettings.GetVisualEffectQuality());
		bGW_SettingMgrV.AddSettingRecommendDict(UISettingConfigType.VegetationQuality, gameUserSettings.GetFoliageQuality());
		bGW_SettingMgrV.AddSettingRecommendDict(UISettingConfigType.GlobalIllumination, gameUserSettings.GetGlobalIlluminationQuality());
		bGW_SettingMgrV.AddSettingRecommendDict(UISettingConfigType.ReflectionQuality, gameUserSettings.GetReflectionQuality());
		bGW_SettingMgrV.AddSettingRecommendDict(UISettingConfigType.TextureQuality, gameUserSettings.GetTextureQuality());
		int overallScalabilityLevel = gameUserSettings.GetOverallScalabilityLevel();
		int recommendValue = 720;
		if (overallScalabilityLevel >= 2)
		{
			recommendValue = 1080;
		}
		bGW_SettingMgrV.AddSettingRecommendDict(UISettingConfigType.ImageQuality, recommendValue);
		ResetScalabilityByDict(currentScalabilityDict);
		bGW_SettingMgrV.AddSettingRecommendDict(UISettingConfigType.Rtx, GetSettingDefaultValueInDesc(UISettingConfigType.Rtx));
		bGW_SettingMgrV.AddSettingRecommendDict(UISettingConfigType.RtxLevel, GetSettingDefaultValueInDesc(UISettingConfigType.RtxLevel));
		bGW_SettingMgrV.AddSettingRecommendDict(UISettingConfigType.SuperResolutionSampling, GetSettingDefaultValueInDesc(UISettingConfigType.SuperResolutionSampling));
		bGW_SettingMgrV.AddSettingRecommendDict(UISettingConfigType.InsertFrame, GetSettingDefaultValueInDesc(UISettingConfigType.InsertFrame));
	}

	private static int GetSettingDefaultValueInDesc(UISettingConfigType SettingConfigType)
	{
		return GameDBRuntime.GetUISettingConfigDesc(SettingConfigType)?.DefaultValue ?? 0;
	}

	public static Dictionary<string, int> GetCurrentScalabilityDict()
	{
		Dictionary<string, int> dictionary = new Dictionary<string, int>();
		UGameUserSettings gameUserSettings = UGameUserSettings.GetGameUserSettings();
		dictionary.Add("ViewDistance", gameUserSettings.GetViewDistanceQuality());
		dictionary.Add("AntiAliasing", gameUserSettings.GetAntiAliasingQuality());
		dictionary.Add("PostProcessing", gameUserSettings.GetPostProcessingQuality());
		dictionary.Add("MaterialQuality", gameUserSettings.GetShadingQuality());
		dictionary.Add("ShadowQuality", gameUserSettings.GetShadowQuality());
		dictionary.Add("TextureQuality", gameUserSettings.GetTextureQuality());
		dictionary.Add("FxQuality", gameUserSettings.GetVisualEffectQuality());
		dictionary.Add("VegetationQuality", gameUserSettings.GetFoliageQuality());
		dictionary.Add("GlobalIllumination", gameUserSettings.GetGlobalIlluminationQuality());
		dictionary.Add("ReflectionQuality", gameUserSettings.GetReflectionQuality());
		gameUserSettings.GetResolutionScaleInformationEx(out var _, out var CurrentScaleValue, out var _, out var _);
		dictionary.Add("ResolutionScale", (int)CurrentScaleValue);
		return dictionary;
	}

	public static void ResetScalabilityByDict(Dictionary<string, int> ScalabilityDict)
	{
		if (!GetIsEditorSetting())
		{
			UGameUserSettings gameUserSettings = UGameUserSettings.GetGameUserSettings();
			gameUserSettings.SetViewDistanceQuality(ScalabilityDict["ViewDistance"]);
			gameUserSettings.SetAntiAliasingQuality(ScalabilityDict["AntiAliasing"]);
			gameUserSettings.SetPostProcessingQuality(ScalabilityDict["PostProcessing"]);
			gameUserSettings.SetShadingQuality(ScalabilityDict["MaterialQuality"]);
			gameUserSettings.SetShadowQuality(ScalabilityDict["ShadowQuality"]);
			gameUserSettings.SetTextureQuality(ScalabilityDict["TextureQuality"]);
			gameUserSettings.SetVisualEffectQuality(ScalabilityDict["FxQuality"]);
			gameUserSettings.SetFoliageQuality(ScalabilityDict["VegetationQuality"]);
			gameUserSettings.SetGlobalIlluminationQuality(ScalabilityDict["GlobalIllumination"]);
			gameUserSettings.SetReflectionQuality(ScalabilityDict["ReflectionQuality"]);
			SetScreenPercentage(ScalabilityDict["ResolutionScale"], NeedApply: false);
		}
	}

	public static void SetPS5FrameQualityType(UObject WorldContext, int Type, bool IsInit, bool PS5Pro)
	{
		TBUISettingDeviceConfigDesc tBUISettingDeviceConfigDesc = GameDBRuntime.GetTBUISettingDeviceConfigDesc();
		if (tBUISettingDeviceConfigDesc != null && tBUISettingDeviceConfigDesc.List != null)
		{
			UISettingDeviceConfigDesc uISettingDeviceConfigDescByPlatform = GetUISettingDeviceConfigDescByPlatform(GetPS5DevicePlatformType(Type, PS5Pro));
			FHostQualityStruct hostQualityStruct = new FHostQualityStruct
			{
				SystemResolutionY = 2160
			};
			switch (Type)
			{
			case 1:
				hostQualityStruct.RenderingResolutionY = (PS5Pro ? 1296 : 1080);
				hostQualityStruct.GameResolutionY = (PS5Pro ? 2160 : 1620);
				hostQualityStruct.Vsync = 1;
				break;
			case 0:
				hostQualityStruct.RenderingResolutionY = (PS5Pro ? 1296 : 1080);
				hostQualityStruct.GameResolutionY = (PS5Pro ? 1296 : 1080);
				hostQualityStruct.Vsync = 1;
				break;
			case 2:
				hostQualityStruct.RenderingResolutionY = (PS5Pro ? 1296 : 1080);
				hostQualityStruct.GameResolutionY = (PS5Pro ? 2160 : 1620);
				hostQualityStruct.Vsync = 1;
				break;
			}
			SetHostQualityByDeviceConfigDesc(WorldContext, uISettingDeviceConfigDescByPlatform, IsInit, hostQualityStruct);
			SetPS5QualityLogic(Type, PS5Pro);
		}
	}

	public static void SetPS5QualityLogic(int Type, bool PS5Pro)
	{
		IConsoleVariable consoleVariable = IConsoleManager.Get().FindConsoleVariable("r.DynamicRes.OperationMode");
		IConsoleVariable consoleVariable2 = IConsoleManager.Get().FindConsoleVariable("r.DynamicRes.MinScreenPercentage");
		IConsoleVariable consoleVariable3 = IConsoleManager.Get().FindConsoleVariable("r.DynamicRes.MaxScreenPercentage");
		IConsoleVariable consoleVariable4 = IConsoleManager.Get().FindConsoleVariable("r.DynamicRes.FrameTimeBudget");
		IConsoleManager.Get().FindConsoleVariable("r.AntiAliasingMethod");
		IConsoleVariable consoleVariable5 = IConsoleManager.Get().FindConsoleVariable("r.vsync");
		IConsoleVariable consoleVariable6 = IConsoleManager.Get().FindConsoleVariable("rhi.SyncInterval");
		IConsoleVariable consoleVariable7 = IConsoleManager.Get().FindConsoleVariable("t.maxfps");
		IConsoleVariable consoleVariable8 = IConsoleManager.Get().FindConsoleVariable("rhi.EnableConsole120Fps");
		UGameUserSettings gameUserSettings = UGameUserSettings.GetGameUserSettings();
		switch (Type)
		{
		case 1:
			consoleVariable.Set(2);
			consoleVariable8.Set(1);
			consoleVariable4.Set(33);
			if (PS5Pro)
			{
				consoleVariable3.Set(60);
				consoleVariable2.Set(50);
			}
			else
			{
				consoleVariable3.Set(67);
				consoleVariable2.Set(50);
			}
			consoleVariable5.Set(1);
			consoleVariable6.Set((UGSE_SystemSettingsFuncLib.GetMaxRefreshRate() == 120) ? 4 : 2);
			consoleVariable7.Set(0);
			gameUserSettings?.SetFrameRateLimit(0f);
			break;
		case 0:
			consoleVariable.Set(0);
			consoleVariable8.Set(1);
			consoleVariable5.Set(1);
			consoleVariable6.Set((UGSE_SystemSettingsFuncLib.GetMaxRefreshRate() != 120) ? 1 : 2);
			consoleVariable7.Set(0);
			gameUserSettings?.SetFrameRateLimit(0f);
			break;
		case 2:
			consoleVariable.Set(2);
			consoleVariable8.Set(1);
			consoleVariable4.Set(25);
			if (PS5Pro)
			{
				consoleVariable3.Set(60);
				consoleVariable2.Set(50);
			}
			else
			{
				consoleVariable3.Set(67);
				consoleVariable2.Set(50);
			}
			consoleVariable5.Set(1);
			consoleVariable7.Set(45);
			gameUserSettings?.SetFrameRateLimit(45f);
			consoleVariable6.Set((UGSE_SystemSettingsFuncLib.GetMaxRefreshRate() != 120) ? 1 : 3);
			break;
		}
	}

	public static void SetXSXFrameQualityType(UObject WorldContext, int Type, bool IsInit, bool IsXSX)
	{
		TBUISettingDeviceConfigDesc tBUISettingDeviceConfigDesc = GameDBRuntime.GetTBUISettingDeviceConfigDesc();
		if (tBUISettingDeviceConfigDesc == null || tBUISettingDeviceConfigDesc.List == null)
		{
			return;
		}
		FHostQualityStruct hostQualityStruct = default(FHostQualityStruct);
		UISettingDeviceConfigDesc uISettingDeviceConfigDescByPlatform = GetUISettingDeviceConfigDescByPlatform(GetXSXDevicePlatformType(Type, IsXSX));
		if (uISettingDeviceConfigDescByPlatform != null)
		{
			switch (Type)
			{
			case 1:
				hostQualityStruct.RenderingResolutionY = 1080;
				hostQualityStruct.GameResolutionY = 2160;
				hostQualityStruct.Vsync = 1;
				break;
			case 0:
				hostQualityStruct.RenderingResolutionY = 1080;
				hostQualityStruct.GameResolutionY = 1080;
				hostQualityStruct.Vsync = 1;
				break;
			case 2:
				hostQualityStruct.RenderingResolutionY = 1080;
				hostQualityStruct.GameResolutionY = 1080;
				hostQualityStruct.Vsync = 1;
				break;
			}
			SetHostQualityByDeviceConfigDesc(WorldContext, uISettingDeviceConfigDescByPlatform, IsInit, hostQualityStruct);
		}
	}

	private static EDevicePlatformType GetXSXDevicePlatformType(int Type, bool IsXSX)
	{
		switch (Type)
		{
		case 1:
			if (IsXSX)
			{
				return EDevicePlatformType.XsxQuality;
			}
			return EDevicePlatformType.XssQuality;
		case 0:
			if (IsXSX)
			{
				return EDevicePlatformType.XsxFrame;
			}
			return EDevicePlatformType.XssFrame;
		case 2:
			if (IsXSX)
			{
				return EDevicePlatformType.XsxBalance;
			}
			return EDevicePlatformType.XssBalance;
		default:
			return EDevicePlatformType.XsxBalance;
		}
	}

	private static EDevicePlatformType GetPS5DevicePlatformType(int Type, bool IsPS5Rro)
	{
		switch (Type)
		{
		case 1:
			if (IsPS5Rro)
			{
				return EDevicePlatformType.Ps5ProQuality;
			}
			return EDevicePlatformType.Ps5Quality;
		case 0:
			if (IsPS5Rro)
			{
				return EDevicePlatformType.Ps5ProFrame;
			}
			return EDevicePlatformType.Ps5Frame;
		case 2:
			if (IsPS5Rro)
			{
				return EDevicePlatformType.Ps5ProBalance;
			}
			return EDevicePlatformType.Ps5Balance;
		default:
			return EDevicePlatformType.Ps5Balance;
		}
	}

	private static UISettingDeviceConfigDesc GetUISettingDeviceConfigDescByPlatform(EDevicePlatformType DevicePlatformType)
	{
		foreach (UISettingDeviceConfigDesc item in GameDBRuntime.GetTBUISettingDeviceConfigDesc().List)
		{
			if (item.PlatformType == DevicePlatformType)
			{
				return item;
			}
		}
		return null;
	}

	private static void SetHostQualityByDeviceConfigDesc(UObject WorldContext, UISettingDeviceConfigDesc TargetDesc, bool IsInit, FHostQualityStruct HostQualityStruct)
	{
		if (!(BGW_SettingMgrV2.Get(WorldContext) == null))
		{
			SetScreenMode(1);
			DoSuperResolutionSamplingLogic(WorldContext, (int)TargetDesc.SuperResolutionsampling);
			DoInsertFrameLogic(WorldContext, (int)TargetDesc.SuperResolutionsampling, (int)TargetDesc.InsertFrame);
			if (IsInit)
			{
				DoRTXLogic(WorldContext, (int)TargetDesc.Rtx);
			}
			else
			{
				RTXSettingSaveFile((int)TargetDesc.Rtx);
			}
			DoRTXLevelLogic(WorldContext, TargetDesc.RtxLevel);
			UGameUserSettings gameUserSettings = UGameUserSettings.GetGameUserSettings();
			gameUserSettings.SetViewDistanceQuality((int)(TargetDesc.ViewDistance - 1));
			gameUserSettings.SetAntiAliasingQuality((int)(TargetDesc.AntiAliasing - 1));
			gameUserSettings.SetPostProcessingQuality((int)(TargetDesc.PostProcessing - 1));
			gameUserSettings.SetShadowQuality((int)(TargetDesc.ShadowQuality - 1));
			gameUserSettings.SetGlobalIlluminationQuality((int)(TargetDesc.GlobalIllumination - 1));
			gameUserSettings.SetReflectionQuality((int)(TargetDesc.ReflectionQuality - 1));
			gameUserSettings.SetTextureQuality((int)(TargetDesc.TextureQuality - 1));
			gameUserSettings.SetVisualEffectQuality((int)(TargetDesc.TextureQuality - 1));
			gameUserSettings.SetFoliageQuality((int)(TargetDesc.FxQuality - 1));
			gameUserSettings.SetShadingQuality((int)(TargetDesc.MaterialQuality - 1));
			if (HostQualityStruct.GameResolutionY > 0)
			{
				SetScreenPercentage(100 * HostQualityStruct.RenderingResolutionY / HostQualityStruct.GameResolutionY, NeedApply: false);
			}
			UGSE_GSGameSettingsFuncLib.ApplyGSGameSettings(bSaveSettings: true);
			UGSE_GSGameSettingsFuncLib.ApplyGSGameResolutionSettings(bSaveSettings: true);
			gameUserSettings.SetVSyncEnabled(HostQualityStruct.Vsync > 0);
			BGW_SettingMgrV2 bGW_SettingMgrV = BGW_SettingMgrV2.Get(WorldContext);
			if (bGW_SettingMgrV != null)
			{
				float secondaryScreenPercentageCVar = 100f * (float)HostQualityStruct.GameResolutionY / (float)HostQualityStruct.SystemResolutionY;
				bGW_SettingMgrV.SetSecondaryScreenPercentageCVar(secondaryScreenPercentageCVar);
			}
		}
	}

	public static void DoRTXLogic(UObject WorldContext, int NewValue)
	{
		_ = DebugConfig.EnableRtx;
		if (!GetIsEditorSetting())
		{
			BGW_SettingMgrV2 bGW_SettingMgrV = BGW_SettingMgrV2.Get(WorldContext);
			if (bGW_SettingMgrV != null)
			{
				bGW_SettingMgrV.RTXEnableCvar(NewValue);
			}
		}
	}

	public static void RTXSettingSaveFile(int NewValue)
	{
		_ = DebugConfig.EnableRtx;
		if (!GetIsEditorSetting())
		{
			UGSE_ConfigFuncLib.SetBool(EConfigIniFileNames.GGameUserSettingsIni, "RayTracing", "r.RayTracing.EnableInGame", NewValue > 0);
		}
	}

	public static int GetRTXValue()
	{
		IConsoleVariable consoleVariable = IConsoleManager.Get().FindConsoleVariable("b.rtx.enable");
		if (consoleVariable != null)
		{
			return consoleVariable.GetInt();
		}
		return 0;
	}

	public static void DoRTXLevelLogic(UObject WorldContext, int NewValue)
	{
		BGW_SettingMgrV2 bGW_SettingMgrV = BGW_SettingMgrV2.Get(WorldContext);
		if (bGW_SettingMgrV != null)
		{
			bGW_SettingMgrV.SetConsoleVariableByType(UISettingConfigType.RtxLevel, NewValue);
		}
		UGSE_GSGameSettingsFuncLib.SetRayTracingQuality(NewValue);
	}

	public static bool IsRTXEnable()
	{
		IConsoleVariable consoleVariable = IConsoleManager.Get().FindConsoleVariable("b.rtx.enable");
		if (consoleVariable != null && consoleVariable.GetInt() == 1)
		{
			return true;
		}
		return false;
	}

	public static void DoMotionBlurAmountLogic(UObject WorldContext, int NewValue)
	{
		if (!GetIsEditorSetting())
		{
			float motionBlurCvar = 0f;
			int motionBlurMaxCvar = 30;
			if (NewValue > 0)
			{
				motionBlurCvar = ((NewValue > 1) ? 0.5f : 0.2f);
			}
			BGW_SettingMgrV2 bGW_SettingMgrV = BGW_SettingMgrV2.Get(WorldContext);
			if (bGW_SettingMgrV != null)
			{
				bGW_SettingMgrV.SetMotionBlurCvar(motionBlurCvar);
				bGW_SettingMgrV.SetMotionBlurMaxCvar(motionBlurMaxCvar);
			}
		}
	}

	public static void ApplyNonResolutionSystemSettings()
	{
		UGameUserSettings gameUserSettings = UGameUserSettings.GetGameUserSettings();
		if (gameUserSettings != null)
		{
			gameUserSettings.ApplyNonResolutionSettings();
		}
	}

	public static void ApplyResolutionSettings()
	{
		UGameUserSettings gameUserSettings = UGameUserSettings.GetGameUserSettings();
		if (gameUserSettings != null)
		{
			gameUserSettings.ApplyNonResolutionSettings();
		}
	}

	public static object[] GetObjectValueByConfigType(int NewValue, UISettingConfigType SettingType)
	{
		switch (SettingType)
		{
		case UISettingConfigType.ViewDistance:
		case UISettingConfigType.AntiAliasing:
		case UISettingConfigType.PostProcessing:
		case UISettingConfigType.ShadowQuality:
		case UISettingConfigType.TextureQuality:
		case UISettingConfigType.FxQuality:
		case UISettingConfigType.MaterialQuality:
		case UISettingConfigType.VegetationQuality:
		case UISettingConfigType.GlobalIllumination:
		case UISettingConfigType.ReflectionQuality:
			return new object[1] { FMath.Max(0, NewValue - 1) };
		case UISettingConfigType.LockFrameRate:
		{
			int num = NewValue * 30;
			if (NewValue == 3)
			{
				num = 120;
			}
			return new object[1] { num };
		}
		case UISettingConfigType.Vsync:
			return new object[1] { NewValue == 1 };
		case UISettingConfigType.ScreenMode:
			return new object[1] { (EWindowMode)NewValue };
		case UISettingConfigType.QualityLevel:
			if (NewValue != 6)
			{
				return new object[1] { FMath.Max(0, NewValue - 1) };
			}
			return new object[1] { -1 };
		default:
			return new object[1] { NewValue };
		}
	}

	public static void SetScreenPercentage(float NewValue, bool NeedApply)
	{
		if (GetIsEditorSetting())
		{
			return;
		}
		int superResolutionSamplingRealValue = GetSuperResolutionSamplingRealValue();
		NewValue = BGW_SettingMgrV2.GetSupportedScreenPercentage(NewValue, (ESuperResolutionsampling)superResolutionSamplingRealValue);
		UGameUserSettings gameUserSettings = UGameUserSettings.GetGameUserSettings();
		if (gameUserSettings != null)
		{
			NewValue = FMath.Min(NewValue, 100f);
			IConsoleVariable consoleVariable = IConsoleManager.Get().FindConsoleVariable("r.XeSS.Enabled");
			if (consoleVariable != null && consoleVariable.GetInt() > 0)
			{
				UGSE_GSGameSettingsFuncLib.SetXeSSPercentage(NewValue);
			}
			_ = DebugConfig.DebugSettingLog;
			gameUserSettings.SetResolutionScaleValueEx(NewValue);
			if (NeedApply)
			{
				UGSE_GSGameSettingsFuncLib.ApplyGSGameResolutionSettings(bSaveSettings: true);
			}
		}
	}

	public static void SaveTextureQualityValue(int NewValue)
	{
		int intValue = 512;
		switch (NewValue)
		{
		case 1:
		case 2:
			intValue = 384;
			break;
		case 3:
			intValue = 512;
			break;
		case 4:
		case 5:
			intValue = 640;
			break;
		}
		UGSE_ConfigFuncLib.SetInt(EConfigIniFileNames.GGameUserSettingsIni, "GSRenderSetting", "GSStreamingPoolSize", intValue);
	}

	public static void SetScreenMode(int Value)
	{
		if (!GetIsEditorSetting())
		{
			UGSE_SystemSettingsFuncLib.SetTargetScreenMode((EGSScreenMode)Value);
			UGSE_GSGameSettingsFuncLib.ApplyGSGameResolutionSettings(bSaveSettings: true);
		}
	}

	public static void SetScreenResolution(UObject WorldContext, FIntPoint Resolution, Dictionary<UISettingConfigType, int> SettingRecommendDict = null)
	{
		if (!GetIsEditorSetting())
		{
			if (Resolution.Y < ScreenResolutionMin.Y)
			{
				Resolution = ScreenResolutionMin;
			}
			if (UGameUserSettings.GetGameUserSettings().GetFullscreenMode() == EWindowMode.Windowed)
			{
				UGSE_SystemSettingsFuncLib.SetTargetResolution(Resolution);
			}
			else
			{
				UGSE_SystemSettingsFuncLib.SetTargetResolution(GetMainScreenResolution(WorldContext));
			}
			UGSE_GSGameSettingsFuncLib.ApplyGSGameResolutionSettings(bSaveSettings: true);
			LastManualScreenResolution = Resolution;
			UISettingConfigDesc uISettingConfigDesc = GameDBRuntime.GetUISettingConfigDesc(UISettingConfigType.ImageQuality);
			if (uISettingConfigDesc != null)
			{
				BGW_SettingMgrV2.Get(WorldContext).GetItemValueByType(uISettingConfigDesc, out var DefaultValue);
				SetScreenPercentage(FMath.RoundToInt(100f * (float)DefaultValue / (float)Resolution.Y), NeedApply: true);
			}
		}
	}

	public static FIntPoint GetMainScreenResolution(UObject WorldContext)
	{
		List<FGSMonitorInfo> allMonitorListCache = BGW_SettingMgrV2.GetAllMonitorListCache();
		int gameMainMonitorID = GetGameMainMonitorID();
		FIntPoint result = FIntPoint.ZeroValue;
		if (gameMainMonitorID >= 0 && gameMainMonitorID < allMonitorListCache.Count)
		{
			result = allMonitorListCache[gameMainMonitorID].DisplayResolution;
		}
		return result;
	}

	public static FIntPoint GetGameScreenResolution(UObject WorldContext)
	{
		return UGameUserSettings.GetGameUserSettings().GetScreenResolution();
	}

	public static FIntPoint GetMainScreenNativeResolution(UObject WorldContext)
	{
		return UGameUserSettings.GetGameUserSettings().GetDesktopResolution();
	}

	public static int GetGameMainMonitorID()
	{
		int result = 0;
		if (UGameUserSettings.GetGameUserSettings() != null)
		{
			string mainMonitorID = UGSE_GSGameSettingsFuncLib.GetMainMonitorID();
			List<FGSMonitorInfo> allMonitorListCache = BGW_SettingMgrV2.GetAllMonitorListCache();
			for (int i = 0; i < allMonitorListCache.Count; i++)
			{
				if (allMonitorListCache[i].ID == mainMonitorID)
				{
					return i;
				}
			}
		}
		return result;
	}

	public static int GetMainMonitorID()
	{
		int result = 0;
		List<FGSMonitorInfo> allMonitorListCache = BGW_SettingMgrV2.GetAllMonitorListCache();
		for (int i = 0; i < allMonitorListCache.Count; i++)
		{
			if (allMonitorListCache[i].IsPrimary)
			{
				result = i;
				break;
			}
		}
		return result;
	}

	public static bool ProcessLowFeatureLevelGPULandscape(UObject WorldContext, int curTextureQuality)
	{
		BGW_PreloadAssetMgr bGW_PreloadAssetMgr = BGW_PreloadAssetMgr.Get(WorldContext);
		if (bGW_PreloadAssetMgr == null)
		{
			return false;
		}
		UMaterialParameterCollection uMaterialParameterCollection = bGW_PreloadAssetMgr.TryGetCachedResourceObj<UMaterialParameterCollection>("MaterialParameterCollection'/Game/00Main/GlobalMat/BaseLibrary/Landscape/MPC_LandscapeGlobal.MPC_LandscapeGlobal'", ELoadResourceType.SyncLoadAndCache);
		if (uMaterialParameterCollection == null)
		{
			return false;
		}
		CVARHandle_VHMEnable = ((CVARHandle_VHMEnable == -1) ? CVarFuncLib.CreateHandle("r.VHM.Enable") : CVARHandle_VHMEnable);
		if (curTextureQuality == 0 || UGSE_GSGameSettingsFuncLib.IsLowFeatureLevelGPU())
		{
			UMaterialLibrary.SetScalarParameterValue(WorldContext, uMaterialParameterCollection, bWPOInsteadVHM, 1f);
			CVarFuncLib.SetByHandleWithPriority(CVARHandle_VHMEnable, 0f, EConsoleVariablePriority.Default, 2);
		}
		else
		{
			UMaterialLibrary.SetScalarParameterValue(WorldContext, uMaterialParameterCollection, bWPOInsteadVHM, 0f);
			CVarFuncLib.DestroyHandle(CVARHandle_VHMEnable);
			CVARHandle_VHMEnable = -1;
		}
		return true;
	}
}
