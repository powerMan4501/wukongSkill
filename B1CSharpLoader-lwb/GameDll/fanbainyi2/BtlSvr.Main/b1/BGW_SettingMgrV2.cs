using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using ArchiveB1;
using b1.EventDelDefine;
using b1.Localization;
using b1.Plugins.ConsoleVariableManager;
using b1.Plugins.GSGameSettings;
using CommB1;
using OssB1;
using ResB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGW_SettingMgrV2")]
public class BGW_SettingMgrV2 : GameInstanceSystemBaseUObj
{
	private static Dictionary<UISettingConfigType, int> SettingRecommendDict;

	private UserSettingData UserSettingData = new UserSettingData();

	public EnhancedInputSettingData EnhancedInput = new EnhancedInputSettingData();

	public TakePhotoSystemSettingData TakePhotoSystemData = new TakePhotoSystemSettingData();

	public bool AgreementReaded;

	private UserSettingData OSSCacheUserSettingData;

	private InputSettingInfo OSSCacheInputSettingData;

	private static List<FGSMonitorInfo> AllMonitorListCache;

	private const string MotionBlur_Cvar = "r.motionblur.amount";

	private const string MotionBlurMax_Cvar = "r.MotionBlur.Max";

	private const string XeSS_Cvar = "r.XeSS.Enabled";

	private const string DLSSEnable_Cvar = "r.NGX.DLSS.Enable";

	private const string DLSSPostProcessing_Cvar = "r.PostProcessing.PostProcessingMoveDOFAfterUpscaling";

	private const string DLSSSceneColor_Cvar = "r.DOF.DLSS.SceneColor.TAA";

	private const string DeferredDistortionForTSR_Cvar = "r.TSR.DeferredDistortionForTSR";

	private const string AntiAliasingMethod_Cvar = "r.AntiAliasingMethod";

	private const string BasePassForceOutputsVelocity_Cvar = "r.BasePassForceOutputsVelocity";

	private const string FSREnable_Cvar = "r.FidelityFX.FSR3.Enabled";

	private const string FSR_FinishCurrentFrame_Cvar = "r.FinishCurrentFrame";

	private const string FSRDeferredDist_Cvar = "r.TSR.DeferredDistortionForTSR";

	private const string NXSREnable_Cvar = "r.NXSR.Enabled";

	private const string PSSREnable_Cvar = "r.SIE.PSSR.Enable";

	private const string RTXEnable_Cvar = "b.rtx.enable";

	private const string RTXEnableInGame_Cvar = "r.RayTracing.EnableInGame";

	private const string RTXLevel_Cvar = "b.rtx.quality";

	private const string DLSSGEnable_Cvar = "r.Streamline.DLSSG.Enable";

	private const string FidelityFXEnable_Cvar = "r.FidelityFX.FI.Enabled";

	private const string SecondaryScreenPercentage_Cvar = "r.SecondaryScreenPercentage.GameViewport";

	private const string EnableHDROutput_Cvar = "r.HDR.EnableHDROutput";

	private const string HDRUILevel_Cvar = "r.HDR.UI.Level";

	public static float UltraPerformanceMaxValue;

	public static float PerformanceMaxValue;

	public static float BalancedMaxValue;

	public static float QualityMaxValue;

	public static int CVARHandle_LumenProbeDownsampleFactor;

	private static int FidelityFXEnableHandle;

	private static int FSREnableCvarHandle;

	private static int FidelityFXEnableHandleDX11;

	private static int FSREnableCvarHandleDX11;

	public void GetItemValueByType(UISettingConfigDesc UISettingConfigDesc, out int DefaultValue)
	{
		DefaultValue = 0;
		UISettingConfigType configType = UISettingConfigDesc.ConfigType;
		UIConfigSaveType saveType = UISettingConfigDesc.SaveType;
		bool flag = false;
		if (saveType == UIConfigSaveType.Cloud)
		{
			foreach (KeyValuePair<UISettingConfigType, string> item in UserSettingData.CloudSettingDict)
			{
				if (item.Key == configType)
				{
					DefaultValue = int.Parse(item.Value);
					flag = true;
					break;
				}
			}
		}
		else
		{
			foreach (KeyValuePair<string, string> item2 in UserSettingData.LocalSettingDict)
			{
				if (item2.Key == configType.ToString())
				{
					DefaultValue = int.Parse(item2.Value);
					flag = true;
					break;
				}
			}
		}
		if (flag)
		{
			return;
		}
		if (configType == UISettingConfigType.MainDisplay)
		{
			List<FGSMonitorInfo> allMonitorListCache = GetAllMonitorListCache();
			for (int i = 0; i < allMonitorListCache.Count; i++)
			{
				if (allMonitorListCache[i].IsPrimary)
				{
					DefaultValue = i;
					break;
				}
			}
		}
		else
		{
			DefaultValue = BGW_SettingFuncUtil.GetDefaultValue(SettingRecommendDict, UISettingConfigDesc);
		}
	}

	public void LoadSettingData()
	{
		LoadLocalSettingData();
		LoadCloudSettingData();
		UserSettingData.InitConsoleVariableDict(this, out var SettingDict);
		foreach (KeyValuePair<UISettingConfigType, int> item in SettingDict)
		{
			SetLocalSetteting(item.Key, item.Value.ToString());
		}
		UB1Util.SetUISettingPbTag(4);
		PrintCurSettingInfo();
	}

	public void LoadLocalSettingData()
	{
		if (UB1Util.GetUISettingData(out var OutUISettingData) <= 0)
		{
			return;
		}
		int uISettingPbTag = UB1Util.GetUISettingPbTag();
		if (uISettingPbTag < 4)
		{
			foreach (string item in OutUISettingData.Keys.ToList())
			{
				if (SettingProtoVersionCheck.CheckFixSettingData(item, uISettingPbTag, OutUISettingData[item], out var FixValue))
				{
					OutUISettingData[item] = FixValue;
				}
			}
		}
		UserSettingData.LocalSettingDict = OutUISettingData;
	}

	public void LoadCloudSettingData()
	{
		UISettingArchiveData SettingData;
		ReadArchiveResult readArchiveResult = BGW_GameArchiveMgr.Get(this).LoadUserSetting(out SettingData);
		if (BGW_GameArchiveMgr.IsValidArchiveResult(readArchiveResult))
		{
			UserSettingData.InitCloudSettingData(SettingData);
			EnhancedInput = SettingData.EnhancedInput;
			TakePhotoSystemData = SettingData.TakePhotoData;
			AgreementReaded = SettingData.AgreementReaded;
		}
		else if (readArchiveResult == ReadArchiveResult.FileNotExist)
		{
			UserSettingData.InitCloudSettingData(InDefaultArchiveData());
			WriteSaveCloudData();
		}
		else
		{
			BGW_LogUtil.LogError($"LoadUserSetting Failed, Ret:{readArchiveResult}");
		}
	}

	public void ReInitData()
	{
		UserSettingData = new UserSettingData();
		UserSettingData.InitConsoleVariableDict(this, out var SettingDict);
		foreach (KeyValuePair<UISettingConfigType, int> item in SettingDict)
		{
			SetLocalSetteting(item.Key, item.Value.ToString());
		}
		BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(this);
		if (bGW_EventCollection != null)
		{
			bGW_EventCollection.Evt_ResumeInputSettingsToDefault?.Invoke();
		}
	}

	public void SetCouldSetteting(UISettingConfigType ConfigType, string NewValue)
	{
		UserSettingData.SetCouldSetteting(ConfigType, NewValue);
	}

	public void SetLocalSetteting(UISettingConfigType ConfigType, string NewValue)
	{
		if (UserSettingData.LocalSettingDict.ContainsKey(ConfigType.ToString()))
		{
			UserSettingData.LocalSettingDict[ConfigType.ToString()] = NewValue;
		}
		else
		{
			UserSettingData.LocalSettingDict.Add(ConfigType.ToString(), NewValue);
		}
		if (UObject.GetDefault<UGSGameUserSettings>() != null)
		{
			UB1Util.SetUISettingData(UserSettingData.LocalSettingDict);
		}
	}

	public void SetConsoleVariableByType(UISettingConfigType ConfigType, int Value)
	{
		UserSettingData.SetConsoleVariableByType(ConfigType, Value);
	}

	public void WriteSaveCloudData()
	{
		UISettingArchiveData uISettingArchiveData = new UISettingArchiveData();
		foreach (KeyValuePair<UISettingConfigType, string> item in UserSettingData.CloudSettingDict)
		{
			SettingArchiveData settingArchiveData = new SettingArchiveData();
			settingArchiveData.SettingKey = item.Key;
			settingArchiveData.SettingValue = item.Value;
			uISettingArchiveData.ArchiveData.Add(settingArchiveData);
		}
		uISettingArchiveData.EnhancedInput = EnhancedInput;
		uISettingArchiveData.SettingpbTag = SettingpbTag.LatestVersionTag;
		uISettingArchiveData.TakePhotoData = TakePhotoSystemData;
		uISettingArchiveData.AgreementReaded = AgreementReaded;
		BGW_EventCollection.Get(this).Evt_PostApplyInputSettingFinish();
		BGW_GameArchiveMgr.Get(this).MarkSaveSetting(uISettingArchiveData);
	}

	public UISettingArchiveData InDefaultArchiveData()
	{
		TBUISettingConfigDesc tBUISettingConfigDesc = GameDBRuntime.GetTBUISettingConfigDesc();
		UISettingArchiveData uISettingArchiveData = new UISettingArchiveData();
		foreach (UISettingConfigDesc item in tBUISettingConfigDesc.List)
		{
			if (item.SaveType == UIConfigSaveType.Cloud)
			{
				SettingArchiveData settingArchiveData = new SettingArchiveData();
				settingArchiveData.SettingKey = item.ConfigType;
				settingArchiveData.SettingValue = BGW_SettingFuncUtil.GetDefaultValue(SettingRecommendDict, item).ToString();
				uISettingArchiveData.ArchiveData.Add(settingArchiveData);
			}
		}
		uISettingArchiveData.EnhancedInput = EnhancedInput;
		uISettingArchiveData.TakePhotoData = TakePhotoSystemData;
		return uISettingArchiveData;
	}

	public int GetCVValueleByType(UISettingConfigType ConfigType)
	{
		UISettingConfigDesc uISettingConfigDesc = GameDBRuntime.GetUISettingConfigDesc(ConfigType);
		if (uISettingConfigDesc != null && uISettingConfigDesc.ConditionType == SettingBanConditionType.Awalyban)
		{
			if (ConfigType == UISettingConfigType.GoreEffects)
			{
				if (!BGW_OnlineSubsystem.IsOverseaChannel())
				{
					return 1;
				}
				return 2;
			}
			return BGW_SettingFuncUtil.GetDefaultValue(SettingRecommendDict, uISettingConfigDesc);
		}
		string consoleVariableByType = UserSettingData.GetConsoleVariableByType(ConfigType);
		if (consoleVariableByType != null && consoleVariableByType != "")
		{
			return int.Parse(consoleVariableByType) * UserSettingData.GetValueScale(ConfigType);
		}
		return 0;
	}

	public bool GetCVBoolByType(UISettingConfigType ConfigType)
	{
		UISettingConfigDesc uISettingConfigDesc = GameDBRuntime.GetUISettingConfigDesc(ConfigType);
		if (uISettingConfigDesc != null && uISettingConfigDesc.ConditionType == SettingBanConditionType.Awalyban)
		{
			return BGW_SettingFuncUtil.GetDefaultValue(SettingRecommendDict, uISettingConfigDesc) > 0;
		}
		if (UserSettingData != null)
		{
			return UserSettingData.GetConsoleVariableByType(ConfigType) == "1";
		}
		return false;
	}

	public int GetSettingLogicValue(UISettingConfigType ConfigType)
	{
		if (UserSettingData != null)
		{
			foreach (KeyValuePair<string, string> item in UserSettingData.LocalSettingDict)
			{
				if (item.Key == ConfigType.ToString())
				{
					return int.Parse(item.Value) * UserSettingData.GetValueScale(ConfigType);
				}
			}
			foreach (KeyValuePair<UISettingConfigType, string> item2 in UserSettingData.CloudSettingDict)
			{
				if (item2.Key == ConfigType)
				{
					return int.Parse(item2.Value) * UserSettingData.GetValueScale(ConfigType);
				}
			}
		}
		return 0;
	}

	public static BGW_SettingMgrV2 Get(UObject Context)
	{
		return BGWGameInstanceCS.GetObject<BGW_SettingMgrV2>(Context);
	}

	public override void OnInit()
	{
		if (DebugConfig.FSRCrashOptions > 0)
		{
			FidelityFXEnableHandle = CVarFuncLib.CreateHandle("r.FidelityFX.FI.Enabled");
			CVarFuncLib.SetByHandleWithPriority(FidelityFXEnableHandle, 0f, EConsoleVariablePriority.CLSVolume, 2);
			if (DebugConfig.FSRCrashOptions > 1)
			{
				FSREnableCvarHandle = CVarFuncLib.CreateHandle("r.FidelityFX.FSR3.Enabled");
				CVarFuncLib.SetByHandleWithPriority(FSREnableCvarHandle, 0f, EConsoleVariablePriority.CLSVolume, 2);
			}
		}
		SetDX11FSRCvarHandle();
		LoadSettingData();
		UGSE_SystemSettingsFuncLib.Init();
		BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(this);
		bGW_EventCollection.Evt_BGW_TriggerInBattleLevel = (Del_Void_Bool)Delegate.Combine(bGW_EventCollection.Evt_BGW_TriggerInBattleLevel, new Del_Void_Bool(OnTriggerInBattleLevel));
	}

	private void SetDX11FSRCvarHandle()
	{
		if (FPlatformProperties.GetPlatform() == EPlatform.Windows && !UGSE_SuperRSFuncLib.GetIsDX12())
		{
			FidelityFXEnableHandleDX11 = CVarFuncLib.CreateHandle("r.FidelityFX.FI.Enabled");
			CVarFuncLib.SetByHandleWithPriority(FidelityFXEnableHandleDX11, 0f, EConsoleVariablePriority.Default, 9);
			FSREnableCvarHandleDX11 = CVarFuncLib.CreateHandle("r.FidelityFX.FSR3.Enabled");
			CVarFuncLib.SetByHandleWithPriority(FSREnableCvarHandleDX11, 0f, EConsoleVariablePriority.Default, 9);
		}
	}

	private void OnTriggerInBattleLevel(bool InBattleLevel)
	{
		if (InBattleLevel)
		{
			OnDestroyHandle();
		}
	}

	public override void OnShutdown()
	{
		base.OnShutdown();
		OnDestroyHandle();
	}

	private void OnDestroyHandle()
	{
		if (FidelityFXEnableHandle > 0)
		{
			CVarFuncLib.DestroyHandle(FidelityFXEnableHandle);
			FidelityFXEnableHandle = -1;
		}
		if (FSREnableCvarHandle > 0)
		{
			CVarFuncLib.DestroyHandle(FSREnableCvarHandle);
			FSREnableCvarHandle = -1;
		}
	}

	public static int GetIntValueByConfigType(object NewValue, UISettingConfigType SettingType)
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
			return (int)NewValue + 1;
		case UISettingConfigType.ScreenMode:
			return (int)(EWindowMode)NewValue;
		case UISettingConfigType.Vsync:
			if (!(NewValue.ToString() == "1") && !(NewValue.ToString() == "True"))
			{
				return 0;
			}
			return 1;
		case UISettingConfigType.LockFrameRate:
		{
			int num2 = int.Parse(NewValue.ToString());
			if (num2 == 120)
			{
				return 3;
			}
			return num2 / 30;
		}
		case UISettingConfigType.QualityLevel:
		{
			int num = (int)NewValue;
			if (num == -1)
			{
				num = 5;
			}
			return num + 1;
		}
		default:
			return int.Parse(NewValue.ToString());
		}
	}

	public void SetFirstSetting()
	{
		UB1Util.SetFirstSettingFinish(NewValue: true);
	}

	public void SetAgreementReaded(bool Agree)
	{
		if (Agree)
		{
			UB1Util.SetPrivacyAgreement(1);
			BGW_SettingFuncUtil.SaveSettingData(this, UISettingConfigType.PrivacyAgreement, "1");
			SetConsoleVariableByType(UISettingConfigType.PrivacyAgreement, 1);
		}
		else
		{
			UB1Util.SetPrivacyAgreement(0);
			BGW_SettingFuncUtil.SaveSettingData(this, UISettingConfigType.PrivacyAgreement, "0");
			SetConsoleVariableByType(UISettingConfigType.PrivacyAgreement, 0);
		}
		UB1Util.SetAgreementReaded(1);
		WriteSaveCloudData();
	}

	public bool GetAgreementReaded()
	{
		return UB1Util.GetAgreementReaded() > 0;
	}

	public UserSettingData GetOSSCacheUserSettingData()
	{
		return OSSCacheUserSettingData;
	}

	public UserSettingData GetSettingDataForOSS()
	{
		return BGU_DeepCopyUtil.Copy(UserSettingData);
	}

	public OSSSettingData GetOssSettingData()
	{
		OSSSettingData oSSSettingData = new OSSSettingData();
		oSSSettingData.LocalSettingDict = BGU_DeepCopyUtil.Copy(UserSettingData.LocalSettingDict);
		oSSSettingData.CloudSettingDict = UserSettingData.CloudSettingDict;
		if (oSSSettingData.LocalSettingDict.ContainsKey("ScreenResolution"))
		{
			FIntPoint screenResolution = UGameUserSettings.GetGameUserSettings().GetScreenResolution();
			oSSSettingData.LocalSettingDict["ScreenResolution"] = $"{screenResolution.X}x{screenResolution.Y}";
		}
		return oSSSettingData;
	}

	public List<OSSSettingInfo> GetOssSettingChangeData()
	{
		UserSettingData oSSCacheUserSettingData = GetOSSCacheUserSettingData();
		List<OSSSettingInfo> list = new List<OSSSettingInfo>();
		foreach (KeyValuePair<string, string> item in UserSettingData.LocalSettingDict)
		{
			if (!oSSCacheUserSettingData.LocalSettingDict.TryGetValue(item.Key, out var value) || !(item.Value != value))
			{
				continue;
			}
			OSSSettingInfo oSSSettingInfo = new OSSSettingInfo();
			if (Enum.TryParse<UISettingConfigType>(item.Key, out var result))
			{
				UISettingConfigDesc uISettingConfigDesc = GameDBRuntime.GetUISettingConfigDesc(result);
				if (uISettingConfigDesc != null)
				{
					oSSSettingInfo.SettingId = uISettingConfigDesc.ConfigName.ToFText().ToString();
					oSSSettingInfo.Type = ESettingChangeType.Normal;
					oSSSettingInfo.OldSettingValue = value;
					oSSSettingInfo.NewSettingValue = item.Value;
					list.Add(oSSSettingInfo);
				}
			}
		}
		foreach (KeyValuePair<UISettingConfigType, string> item2 in UserSettingData.CloudSettingDict)
		{
			if (oSSCacheUserSettingData.CloudSettingDict.TryGetValue(item2.Key, out var value2) && item2.Value != value2)
			{
				OSSSettingInfo oSSSettingInfo2 = new OSSSettingInfo();
				oSSSettingInfo2.SettingId = item2.Key.ToString();
				oSSSettingInfo2.OldSettingValue = value2;
				oSSSettingInfo2.NewSettingValue = item2.Value;
				list.Add(oSSSettingInfo2);
			}
		}
		return list;
	}

	public void UpdateOSSCacheDate()
	{
		OSSCacheUserSettingData = BGU_DeepCopyUtil.Copy(UserSettingData);
		FInputSettingTracker inputSettingTracker = BGW_EnhancedInputMgrV2.Get(this).InputSettingTracker;
		InputSettingInfo inputSettingInfo = new InputSettingInfo();
		inputSettingTracker.TryDumpFullOssData(inputSettingInfo);
		OSSCacheInputSettingData = inputSettingInfo;
	}

	public InputSettingInfo GetOSSCacheInputDate()
	{
		return OSSCacheInputSettingData;
	}

	public void AddSettingRecommendDict(UISettingConfigType SettingConfig, int RecommendValue)
	{
		if (SettingRecommendDict == null)
		{
			SettingRecommendDict = new Dictionary<UISettingConfigType, int>();
		}
		if (SettingRecommendDict.ContainsKey(SettingConfig))
		{
			SettingRecommendDict[SettingConfig] = RecommendValue;
		}
		else
		{
			SettingRecommendDict.Add(SettingConfig, RecommendValue);
		}
	}

	public static int GetRecommendValue(UISettingConfigType SettingConfig)
	{
		if (!SettingRecommendDict.ContainsKey(SettingConfig))
		{
			BGW_LogUtil.LogError("SettingRecommendDict Can Find TargetSetting");
			return 0;
		}
		return SettingRecommendDict[SettingConfig];
	}

	public static Dictionary<UISettingConfigType, int> GetRecommendDict()
	{
		return SettingRecommendDict;
	}

	private void SetCvarByDebugConfig(string CvarString, int Value, EConsoleVariablePriority Priority)
	{
		if (!DebugConfig.DebugSettingCvar)
		{
			SetCvar(CvarString, Value, 2, -1, EConsoleVariablePriority.GameSettings);
			return;
		}
		IConsoleVariable consoleVariable = IConsoleManager.Get().FindConsoleVariable(CvarString);
		if (consoleVariable != null)
		{
			consoleVariable.Set(Value);
		}
	}

	private void SetCvarByDebugConfig(string CvarString, float Value, EConsoleVariablePriority Priority)
	{
		if (!DebugConfig.DebugSettingCvar)
		{
			SetCvar(CvarString, Value, 2, -1, EConsoleVariablePriority.GameSettings);
			return;
		}
		IConsoleVariable consoleVariable = IConsoleManager.Get().FindConsoleVariable(CvarString);
		if (consoleVariable != null)
		{
			consoleVariable.Set(Value);
		}
	}

	public void SetMotionBlurCvar(float Value)
	{
		_ = DebugConfig.DebugSettingLog;
		SetCvarByDebugConfig("r.motionblur.amount", Value, EConsoleVariablePriority.GameSettings);
	}

	public void SetMotionBlurMaxCvar(int Value)
	{
		_ = DebugConfig.DebugSettingLog;
		SetCvarByDebugConfig("r.MotionBlur.Max", Value, EConsoleVariablePriority.GameSettings);
	}

	public static float GetSupportedScreenPercentage(float ScreenPercentage, ESuperResolutionsampling UpscalerType)
	{
		switch (UpscalerType)
		{
		case ESuperResolutionsampling.Dlss:
			if (ScreenPercentage < UltraPerformanceMaxValue)
			{
				return 33.3f;
			}
			if (ScreenPercentage < PerformanceMaxValue)
			{
				return 50f;
			}
			if (ScreenPercentage < BalancedMaxValue)
			{
				return 58f;
			}
			if (ScreenPercentage < QualityMaxValue)
			{
				return 66.7f;
			}
			return 100f;
		case ESuperResolutionsampling.Xess:
			return FMath.Clamp(ScreenPercentage, 34f, 100f);
		default:
			return FMath.Clamp(ScreenPercentage, 50f, 100f);
		}
	}

	public void SetFSREnableCVar(int Value)
	{
		_ = DebugConfig.DebugSettingLog;
		SetCvarByDebugConfig("r.FidelityFX.FSR3.Enabled", Value, EConsoleVariablePriority.GameSettings);
		SetCvarByDebugConfig("r.TSR.DeferredDistortionForTSR", Value, EConsoleVariablePriority.GameSettings);
	}

	public void SetTSRCVar(int Value)
	{
		_ = DebugConfig.DebugSettingLog;
		SetCvarByDebugConfig("r.TSR.DeferredDistortionForTSR", Value, EConsoleVariablePriority.GameSettings);
	}

	public void SetTAACVar(int Value)
	{
		_ = DebugConfig.DebugSettingLog;
		if (Value > 0)
		{
			SetCvarByDebugConfig("r.AntiAliasingMethod", 2, EConsoleVariablePriority.GameSettings);
			SetCvarByDebugConfig("r.BasePassForceOutputsVelocity", 1, EConsoleVariablePriority.GameSettings);
			SetCvarByDebugConfig("r.TSR.DeferredDistortionForTSR", 1, EConsoleVariablePriority.GameSettings);
		}
		else
		{
			SetCvarByDebugConfig("r.AntiAliasingMethod", 4, EConsoleVariablePriority.GameSettings);
			SetCvarByDebugConfig("r.BasePassForceOutputsVelocity", 0, EConsoleVariablePriority.GameSettings);
			SetCvarByDebugConfig("r.TSR.DeferredDistortionForTSR", 0, EConsoleVariablePriority.GameSettings);
		}
	}

	public void SetNXSREnableCVar(int Value)
	{
		_ = DebugConfig.DebugSettingLog;
		SetCvarByDebugConfig("r.NXSR.Enabled", Value, EConsoleVariablePriority.GameSettings);
	}

	public void SetPSSREnableCVar(int Value)
	{
		_ = DebugConfig.DebugSettingLog;
		SetCvarByDebugConfig("r.SIE.PSSR.Enable", Value, EConsoleVariablePriority.GameSettings);
		if (Value > 0)
		{
			CVARHandle_LumenProbeDownsampleFactor = ((CVARHandle_LumenProbeDownsampleFactor == -1) ? CVarFuncLib.CreateHandle("r.Lumen.ScreenProbeGather.DownsampleFactor") : CVARHandle_LumenProbeDownsampleFactor);
			if (CVARHandle_LumenProbeDownsampleFactor > 0)
			{
				CVarFuncLib.SetByHandleWithPriority(CVARHandle_LumenProbeDownsampleFactor, 16f, EConsoleVariablePriority.SetByCode, 0);
			}
		}
		else
		{
			CVarFuncLib.DestroyHandle(CVARHandle_LumenProbeDownsampleFactor);
			CVARHandle_LumenProbeDownsampleFactor = -1;
		}
	}

	public void SetDLSSEnableCVar(int Value)
	{
		_ = DebugConfig.DebugSettingLog;
		SetCvarByDebugConfig("r.NGX.DLSS.Enable", Value, EConsoleVariablePriority.GameSettings);
		SetCvarByDebugConfig("r.PostProcessing.PostProcessingMoveDOFAfterUpscaling", 0, EConsoleVariablePriority.GameSettings);
		SetCvarByDebugConfig("r.DOF.DLSS.SceneColor.TAA", Value, EConsoleVariablePriority.GameSettings);
	}

	public void SetDLSSGCVar(int Value)
	{
		_ = DebugConfig.DebugSettingLog;
		SetCvarByDebugConfig("r.Streamline.DLSSG.Enable", Value, EConsoleVariablePriority.GameSettings);
	}

	public void SetFidelityFXEnableCVar(int Value)
	{
		_ = DebugConfig.DebugSettingLog;
		SetCvarByDebugConfig("r.FidelityFX.FI.Enabled", Value, EConsoleVariablePriority.GameSettings);
	}

	public void SetFSR_FinishCurrentFrame(int Value)
	{
		SetCvarByDebugConfig("r.FinishCurrentFrame", Value, EConsoleVariablePriority.GameSettings);
	}

	public void SetXeSSCVar(int Value)
	{
		_ = DebugConfig.DebugSettingLog;
		SetCvarByDebugConfig("r.XeSS.Enabled", Value, EConsoleVariablePriority.GameSettings);
	}

	public void RTXEnableCvar(int Value)
	{
		_ = DebugConfig.EnableRtx;
		_ = DebugConfig.DebugSettingLog;
		SetCvarByDebugConfig("b.rtx.enable", Value, EConsoleVariablePriority.GameSettings);
		SetCvarByDebugConfig("r.RayTracing.EnableInGame", Value, EConsoleVariablePriority.GameSettings);
	}

	public void SetRTXLevelCVar(int Value)
	{
		_ = DebugConfig.DebugSettingLog;
		SetCvarByDebugConfig("b.rtx.quality", Value, EConsoleVariablePriority.GameSettings);
	}

	public void SetSecondaryScreenPercentageCVar(float Value)
	{
		Value = FMath.Min(100f, Value);
		if (UGameUserSettings.GetGameUserSettings().GetFullscreenMode() == EWindowMode.Windowed)
		{
			Value = 0f;
		}
		_ = DebugConfig.DebugSettingLog;
		SetCvarByDebugConfig("r.SecondaryScreenPercentage.GameViewport", Value, EConsoleVariablePriority.GameSettings);
	}

	public void SetEnableHDROutputCvar(int Value)
	{
		if (!BGW_SettingFuncUtil.GetIsEditorSetting())
		{
			_ = DebugConfig.DebugSettingLog;
			SetCvarByDebugConfig("r.HDR.EnableHDROutput", Value, EConsoleVariablePriority.GameSettings);
		}
	}

	public void SetHDRUILevelCvar(int Value)
	{
		if (!BGW_SettingFuncUtil.GetIsEditorSetting())
		{
			_ = DebugConfig.DebugSettingLog;
			SetCvarByDebugConfig("r.HDR.UI.Level", Value, EConsoleVariablePriority.GameSettings);
		}
	}

	public static List<FGSMonitorInfo> GetAllMonitorListCache()
	{
		if (AllMonitorListCache == null)
		{
			AllMonitorListCache = UGSE_SystemSettingsFuncLib.GetAllMonitorInfo();
		}
		return AllMonitorListCache;
	}

	public void PrintCurSettingInfo()
	{
		if (!DebugConfig.DebugSettingLog)
		{
			return;
		}
		UGameUserSettings gameUserSettings = UGameUserSettings.GetGameUserSettings();
		foreach (KeyValuePair<string, string> item in UserSettingData.LocalSettingDict)
		{
			if (!Enum.TryParse<UISettingConfigType>(item.Key, out var result))
			{
				continue;
			}
			UISettingConfigDesc uISettingConfigDesc = GameDBRuntime.GetUISettingConfigDesc(result);
			if (uISettingConfigDesc != null && uISettingConfigDesc.FunTempelte == SettingFunTempelte.GameUserSetting && gameUserSettings != null && uISettingConfigDesc != null)
			{
				Type typeFromHandle = typeof(UGameUserSettings);
				MethodInfo method = typeFromHandle.GetMethod("Get" + uISettingConfigDesc.TempelteParam);
				if (uISettingConfigDesc.ConfigType == UISettingConfigType.Vsync)
				{
					method = typeFromHandle.GetMethod("Is" + uISettingConfigDesc.TempelteParam);
				}
				if (method != null)
				{
					GetIntValueByConfigType(method.Invoke(gameUserSettings, null), uISettingConfigDesc.ConfigType);
				}
			}
		}
		foreach (KeyValuePair<UISettingConfigType, string> item2 in UserSettingData.CloudSettingDict)
		{
			GameDBRuntime.GetUISettingConfigDesc(item2.Key);
		}
	}

	public Dictionary<string, object> GetUserSettingInfoDict()
	{
		return new Dictionary<string, object>
		{
			{ "LocalSettingDict", UserSettingData.LocalSettingDict },
			{ "CloudSettingDict", UserSettingData.CloudSettingDict }
		};
	}

	static BGW_SettingMgrV2()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGW_SettingMgrV2)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGW_SettingMgrV2));
		SettingRecommendDict = new Dictionary<UISettingConfigType, int>();
		UltraPerformanceMaxValue = 40f;
		PerformanceMaxValue = 55f;
		BalancedMaxValue = 62f;
		QualityMaxValue = 90f;
		CVARHandle_LumenProbeDownsampleFactor = -1;
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGW_SettingMgrV2");
	}
}
