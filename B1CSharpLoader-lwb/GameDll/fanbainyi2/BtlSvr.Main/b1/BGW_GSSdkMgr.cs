using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using b1.Localization;
using GSE.GSSdk;
using GSE.OnlineBase;
using Gssdk;
using LitJson;
using OssB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGW_GSSdkMgr")]
public class BGW_GSSdkMgr : GameInstanceSystemBaseUObj
{
	private const float LowHzTickCountdownInterval = 2f;

	private float LowHzTickCountdown;

	public readonly GSSdkLog Logger = new GSSdkLog();

	private GameSDKManager MyGameSdkMgr;

	private readonly GSSdkVersionCheck VersionChecker = new GSSdkVersionCheck();

	private const string DefaultStringConfigUndefinedValue = "!UndefinedConfigValue";

	private string _StartSessionUUID;

	private bool UseAsyncHttpProxy;

	private bool CppSentryReporterInited;

	private static UObject StaticWorldContext;

	private static bool UserPrivacyAgreeAnalyticsReport_LastValue;

	private static bool UserPrivacyAgreeAnalyticsReportOverrideEnableForDebug;

	public override bool bTickEnabled => true;

	public GameSDKManager GameSDKMgr
	{
		get
		{
			if (MyGameSdkMgr == null)
			{
				MyGameSdkMgr = new GameSDKManager(this);
			}
			return MyGameSdkMgr;
		}
	}

	public bool IsGSSdkServerLoginSuccess => GameSDKMgr.IsLoginSuccess;

	public bool IsGSSdkUserJsonConfigLoaded => GameSDKMgr.IsUserSDKJsonConfigLoaded;

	public GSSdkPlatformChannelSDK LoginPlatform
	{
		get
		{
			if (GameSDKMgr != null)
			{
				return GameSDKMgr.CurrentChannelSDK;
			}
			return null;
		}
	}

	public bool IsServerJsonConfigLoaded => VersionChecker.IsVersionServerConfigIsValid;

	public static bool EnableCleanUserData
	{
		get
		{
			if (!DebugConfig.GSSdkEnableSensDataClean)
			{
				return B1Global.GIsGameReleased;
			}
			return true;
		}
	}

	public string GameStartSessionUUID
	{
		get
		{
			if (string.IsNullOrEmpty(_StartSessionUUID))
			{
				_StartSessionUUID = Guid.NewGuid().ToString();
			}
			return _StartSessionUUID;
		}
	}

	public bool IsGSSdkUserLoginFinished { get; private set; }

	public bool IsGSSdkUserLoginSuccess { get; private set; }

	public static bool UserPrivacyAgreeAnalyticsReport
	{
		get
		{
			if (!B1Global.GIsGameReleased)
			{
				return true;
			}
			if (UB1Util.GetAgreementReaded() == 0)
			{
				return true;
			}
			if (UserPrivacyAgreeAnalyticsReportOverrideEnableForDebug)
			{
				return true;
			}
			return UB1Util.GetPrivacyAgreement() == 1;
		}
	}

	public static BGW_GSSdkMgr Get(UObject WorldContext)
	{
		return BGWGameInstanceCS.GetObject<BGW_GSSdkMgr>(WorldContext);
	}

	public JsonData GetUserJsonConfig()
	{
		return GameSDKMgr.GetUserSDKJsonConfig();
	}

	public static string GetLoginUserId(UObject WorldContext, string Default = "")
	{
		if (Get(WorldContext) != null && Get(WorldContext).LoginPlatform != null)
		{
			return Get(WorldContext).LoginPlatform.GetLoginUserId();
		}
		if (BGW_OnlineIdentity.Get(WorldContext) != null)
		{
			return BGW_OnlineIdentity.Get(WorldContext).SafeGetUniquePlayerId();
		}
		return Default;
	}

	public int GetUserGMIntFlags()
	{
		int num = 1;
		string userJsonConfigKeyValue = GetUserJsonConfigKeyValue("GMFlags");
		if (!string.IsNullOrEmpty(userJsonConfigKeyValue))
		{
			string[] array = StringParseHelper.SafeToLower(userJsonConfigKeyValue).Split(new char[1] { ',' }, StringSplitOptions.RemoveEmptyEntries);
			foreach (string text in array)
			{
				num |= GMFlag.GetValueByName(text.Trim());
			}
			if (num == 1)
			{
			}
		}
		else
		{
			if (B1Global.GIsGameReleased)
			{
				return 1;
			}
			if (GetServerExtendJsonConfigKeyValue("LimitUseGM", "true") == "false")
			{
				num = int.MaxValue;
			}
		}
		return num;
	}

	public string GetUserJsonConfigKeyValue(string Key, string DefaultVal = "")
	{
		return GameSDKMgr.GetUserSDKJsonConfigKeyValue(Key, DefaultVal);
	}

	public string GetServerExtendJsonConfigKeyValue(string Key, string DefaultVal = "", bool CheckUseUserOverride = false)
	{
		if (CheckUseUserOverride && IsGSSdkUserJsonConfigLoaded)
		{
			string userJsonConfigKeyValue = GetUserJsonConfigKeyValue(Key, "!UndefinedConfigValue");
			if (userJsonConfigKeyValue != "!UndefinedConfigValue")
			{
				return userJsonConfigKeyValue;
			}
		}
		JsonData serverExtendJsonConfig = GetServerExtendJsonConfig();
		IDictionary dictionary = serverExtendJsonConfig;
		if (dictionary != null && dictionary.Contains(Key))
		{
			return serverExtendJsonConfig[Key].ToString();
		}
		return DefaultVal;
	}

	public JsonData GetServerExtendJsonConfig()
	{
		return VersionChecker.GetVersionServerExtendJsonConfig();
	}

	public List<JsonData> GetServerLayeredJsonConfig()
	{
		return VersionChecker.GetVersionServerLayeredJsonConfig();
	}

	private void InitGSSdkMonitorContext()
	{
		GSSDKReport.MonitorClearEnv();
		GSSDKReport.MonitorEnvAdd("os", GSSDKEnv.UserInfo.DeviceInfo.Platform);
		GSSDKReport.MonitorEnvAdd("chnl", GSSDKEnv.UserInfo.AuthInfo.LoginChannel);
		GSSDKReport.MonitorEnvAdd("ver", GSSDKEnv.UserInfo.ClientSetting.AppVersion);
		GSSDKReport.MonitorEnvAdd("rev", GSSDKEnv.UserInfo.ClientSetting.BuildRevision.ToString());
		GSSDKReport.MonitorEnvAdd("env", GSSDKEnv.UserInfo.ClientSetting.Env);
		GSSDKReport.MonitorEnvAdd("cpu", GSSDKEnv.UserInfo.DeviceInfo.CpuModel);
		GSSDKReport.MonitorEnvAdd("gpu", GSSDKEnv.UserInfo.DeviceInfo.GpuModel);
		GSSDKReport.MonitorEnvAdd("mem", GSSDKEnv.UserInfo.DeviceInfo.MemMbTotal.ToString());
		GSSDKReport.MonitorEnvAdd("brch", GSSDKEnv.UserInfo.ClientSetting.Branch);
		if (!B1Global.GIsGameReleased)
		{
			GSSDKReport.MonitorEnvAdd("conf", GSSDKEnv.UserInfo.UserSession.BuildConfiguration);
			GSSDKReport.MonitorEnvAdd("mode", GSSDKEnv.UserInfo.ClientSetting.PlayMode);
			GSSDKReport.MonitorEnvAdd("uid", GSSDKEnv.UserInfo.AuthInfo.LoginChannelUid);
			GSSDKReport.MonitorEnvAdd("ip", GSSDKEnv.UserInfo.DeviceInfo.LocalIpList);
		}
	}

	private void InitGSSdkLoginChannel()
	{
		string gSSdkLoginChannel = DebugConfig.GSSdkLoginChannel;
		GameSDKMgr.SetCurrentUseSDK(gSSdkLoginChannel);
		GSSDKEnv.UserInfo.AuthInfo.Aid = 0uL;
		GSSDKEnv.UserInfo.AuthInfo.Roleid = 0uL;
		GSSDKEnv.UserInfo.AuthInfo.LoginChannel = gSSdkLoginChannel;
		GSSDKEnv.UserInfo.AuthInfo.LoginSubChannel = "";
		UpdatePlatformSdkLoginState();
	}

	public void UpdatePlatformSdkLoginState()
	{
		GSSDKEnv.UserInfo.AuthInfo.LoginChannelUid = GetLoginUserId(this, "InvalidLoginChannelUid");
		GSSDKEnv.UserInfo.AuthInfo.LoginChannelSdkExtension = "";
		GSSDKEnv.UserInfo.AuthInfo.LocalChannelSdkLoginState = (int)GameSDKMgr.CurrentChannelSDK.PlatformChannelLoginAuthStatus;
		if (EnableCleanUserData)
		{
			GSSDKEnv.UserInfo.AuthInfo.LoginChannelUserName = BGW_LocalDevEnvUtils.SimpleEncryptStr(GameSDKMgr.CurrentChannelSDK.GetLoginUserName());
		}
		else
		{
			GSSDKEnv.UserInfo.AuthInfo.LoginChannelUserName = GameSDKMgr.CurrentChannelSDK.GetLoginUserName();
		}
		GSSDKReport.TrackUser();
	}

	private void InitGSSdkEnvirontmentContext()
	{
		string text = DebugConfig.GSSdkEnvServerUrlList;
		if (!text.Contains("https://"))
		{
			text = "https://gssdk2.heishenhua.com,https://gssdk1.heishenhua.com,https://gssdk2.gamesci.com.cn,https://gssdk1.gamesci.com.cn";
		}
		if (text.Length > 0)
		{
			GSSDKEnv.SetEnvServerList(text.Split(','));
		}
		else
		{
			BGW_LogUtil.LogError("gssdk config is invalid !");
		}
		try
		{
			InitGSSdkLoginChannel();
			InitGSSdkEnvUserContext();
			InitGSSdkMonitorContext();
		}
		catch (Exception ex)
		{
			BGW_LogUtil.LogError("init gssdk env exception:" + ex.Message);
		}
		if (EnableCleanUserData)
		{
			ReportSensitiveDataCleanUserInfo(GSSDKEnv.UserInfo);
		}
		string.Join(",", GSSDKEnv.SdkServerList);
		GSSDKEnv.InitSelectGSSdkDefaultServer();
		string.Join(",", GSSDKEnv.SdkServerList);
	}

	private string GetStrValueFromDictSafe(Dictionary<string, string> Dict, string Key)
	{
		if (Dict == null || Key == null)
		{
			return string.Empty;
		}
		if (!Dict.TryGetValue(Key, out var value))
		{
			return string.Empty;
		}
		return value;
	}

	private int GetIntValueFromDictSafe(Dictionary<string, string> Dict, string Key)
	{
		string strValueFromDictSafe = GetStrValueFromDictSafe(Dict, Key);
		if (strValueFromDictSafe == string.Empty)
		{
			return 0;
		}
		if (!int.TryParse(strValueFromDictSafe, out var result))
		{
			return 0;
		}
		return result;
	}

	private long GetInt64ValueFromDictSafe(Dictionary<string, string> Dict, string Key)
	{
		string strValueFromDictSafe = GetStrValueFromDictSafe(Dict, Key);
		if (strValueFromDictSafe == string.Empty)
		{
			return 0L;
		}
		if (!long.TryParse(strValueFromDictSafe, out var result))
		{
			return 0L;
		}
		return result;
	}

	private void InitGSSdkEnvUserContext()
	{
		string macAddress = BGW_LocalDevEnvUtils.GetMacAddress();
		string platform = FPlatformProperties.GetPlatform().ToString();
		List<FIntPoint> availableResolutionsByMonitorID = UGSE_SystemSettingsFuncLib.GetAvailableResolutionsByMonitorID(BGW_SettingFuncUtil.GetMainMonitorID());
		UGSE_SDKFuncLib.GetGameRunEnvContext(out var OutContext);
		GSSDKEnv.UserInfo.DeviceInfo.Mac = macAddress;
		foreach (FIntPoint item in availableResolutionsByMonitorID)
		{
			GSSDKEnv.UserInfo.DeviceInfo.Height = item.Y;
			GSSDKEnv.UserInfo.DeviceInfo.Width = item.X;
		}
		GSSDKEnv.UserInfo.DeviceInfo.MemMbTotal = GetIntValueFromDictSafe(OutContext, "devices.physical_memory_size_mb");
		GSSDKEnv.UserInfo.DeviceInfo.MemMbFree = GetIntValueFromDictSafe(OutContext, "devices.available_memory_mb");
		GSSDKEnv.UserInfo.DeviceInfo.CpuModel = GetStrValueFromDictSafe(OutContext, "devices.cpu_description");
		GSSDKEnv.UserInfo.DeviceInfo.GpuModel = UGSE_GSGameSettingsFuncLib.GetRHIAdapterName();
		GSSDKEnv.UserInfo.DeviceInfo.CpuCores = GetIntValueFromDictSafe(OutContext, "devices.number_of_cores");
		GSSDKEnv.UserInfo.DeviceInfo.CpuLogicThreads = GetIntValueFromDictSafe(OutContext, "devices.number_of_cores_including_hyperthreads");
		GSSDKEnv.UserInfo.DeviceInfo.InstallDirIsSsd = GetIntValueFromDictSafe(OutContext, "devices.is_installed_on_ssd");
		GSSDKEnv.UserInfo.DeviceInfo.GpuDriverDesc = GetStrValueFromDictSafe(OutContext, "gpu.driver_version");
		GSSDKEnv.UserInfo.DeviceInfo.OsName = BGW_LocalDevEnvUtils.GetPcOSName();
		GSSDKEnv.UserInfo.DeviceInfo.OsRawDesc = BGW_LocalDevEnvUtils.GetPcOSRawDesc();
		GSSDKEnv.UserInfo.DeviceInfo.OsVer = GetStrValueFromDictSafe(OutContext, "devices.os_ver");
		GSSDKEnv.UserInfo.DeviceInfo.CpuArch = BGW_LocalDevEnvUtils.GetCPUArch();
		GSSDKEnv.UserInfo.DeviceInfo.LocalIpList = BGW_LocalDevEnvUtils.GetLocalIpv4ListStr();
		GSSDKEnv.UserInfo.DeviceInfo.Platform = platform;
		List<string> list = new List<string>();
		GSSDKEnv.UserInfo.DeviceInfo.PcHdId = GetStrValueFromDictSafe(OutContext, "devices.disk_seq_number");
		list.Add(GSSDKEnv.UserInfo.DeviceInfo.PcHdId);
		GSSDKEnv.UserInfo.DeviceInfo.PcMsProductid = BGW_LocalDevEnvUtils.GetPcMsProductid();
		list.Add(GSSDKEnv.UserInfo.DeviceInfo.PcMsProductid);
		GSSDKEnv.UserInfo.DeviceInfo.PcMachineGuid = BGW_LocalDevEnvUtils.GetPcMachineGuid();
		list.Add(GSSDKEnv.UserInfo.DeviceInfo.PcMachineGuid);
		GSSDKEnv.UserInfo.DeviceInfo.PcBiosUuid = BGW_LocalDevEnvUtils.GetPcUuid();
		list.Add(GSSDKEnv.UserInfo.DeviceInfo.PcBiosUuid);
		GSSDKEnv.UserInfo.DeviceInfo.NatType = GetStrValueFromDictSafe(OutContext, "devices.nat_type");
		GSSDKEnv.UserInfo.DeviceInfo.PcDeviceId = BGW_LocalDevEnvUtils.GetPcDeviceId();
		list.Add(GSSDKEnv.UserInfo.DeviceInfo.PcDeviceId);
		string deviceId = BGW_LocalDevEnvUtils.GetDeviceId(list);
		GSSDKEnv.UserInfo.DeviceInfo.DeviceId = deviceId;
		if (B1Global.GIsGameReleased)
		{
			GSSDKEnv.UserInfo.ClientSetting.AppChannel = DebugConfig.GSSdkLoginChannel;
		}
		else
		{
			GSSDKEnv.UserInfo.ClientSetting.AppChannel = "gamesci";
		}
		GSSDKEnv.UserInfo.ClientSetting.AppVersion = GSVersionUtil.GetAppVersion();
		GSSDKEnv.UserInfo.ClientSetting.BuildRevision = GSVersionUtil.GetBuildRevision();
		GSSDKEnv.UserInfo.ClientSetting.GitCodeRevision = BuildEnv.GitVersion;
		GSSDKEnv.UserInfo.ClientSetting.P4ProjRevision = (int.TryParse(BuildEnv.P4Version, out var result) ? result : 0);
		GSSDKEnv.UserInfo.ClientSetting.P4EngineRevision = (int.TryParse(BuildEnv.BuildEngineP4Ver, out var result2) ? result2 : 0);
		GSSDKEnv.UserInfo.ClientSetting.BuildTime = BuildEnv.BuildTime;
		GSSDKEnv.UserInfo.ClientSetting.PkgTag = DebugConfig.GSSdkPackageTags;
		GSSDKEnv.UserInfo.ClientSetting.Language = GSLocalization.GetCurrentCulture();
		string strValueFromDictSafe = GetStrValueFromDictSafe(OutContext, "client_setting.region");
		GSSDKEnv.UserInfo.ClientSetting.Region = BGW_LocalDevEnvUtils.GetUserRegion(strValueFromDictSafe);
		GSSDKEnv.UserInfo.ClientSetting.TzOffset = GetIntValueFromDictSafe(OutContext, "client_setting.tz_offset");
		GSSDKEnv.UserInfo.ClientSetting.Branch = BGW_LocalDevEnvUtils.GetBuildBranch();
		GSSDKEnv.UserInfo.ClientSetting.Env = DebugConfig.Environment;
		GSSDKEnv.UserInfo.ClientSetting.PlayMode = "biu";
		bool flag = true;
		try
		{
			if (FPaths.FileExists(Path.Combine(FPaths.RootDir, "b1", "Config", "DefaultGame.ini")))
			{
				flag = false;
			}
		}
		catch (Exception ex)
		{
			BGW_LogUtil.LogError("check pak fail ex:" + ex.Message);
		}
		if (flag)
		{
			GSSDKEnv.UserInfo.ClientSetting.PlayMode = "pak";
		}
		if (BGW_LocalDevEnvUtils.GetBuildBranch().Contains("b1_bench"))
		{
			GSSDKEnv.UserInfo.ClientSetting.PlayMode += "_bench";
		}
		GSSDKEnv.UserInfo.ClientSetting.GraphicApi = GetStrValueFromDictSafe(OutContext, "client_setting.graphic_api");
		GSSDKEnv.UserInfo.ClientSetting.VcRedist = BGW_LocalDevEnvUtils.GetPCVCRedistVersion();
		GSSDKEnv.UserInfo.ClientSetting.CultureDesc = GSLocalization.GetCurrentCulture();
		GSSDKEnv.UserInfo.UserSession.StartSessionUuid = GameStartSessionUUID;
		GSSDKEnv.UserInfo.UserSession.StartTimestamp = LocalTime.GetUnixTimeStamp();
		GSSDKEnv.UserInfo.UserSession.LoginId = GetStrValueFromDictSafe(OutContext, "unreal.Login Id");
		GSSDKEnv.UserInfo.UserSession.MachineId = deviceId;
		GSSDKEnv.UserInfo.UserSession.PlatformName = GetStrValueFromDictSafe(OutContext, "unreal.PlatformName");
		GSSDKEnv.UserInfo.UserSession.ProcessId = GetStrValueFromDictSafe(OutContext, "crashc.Process Id");
		GSSDKEnv.UserInfo.UserSession.SecondsSinceStart = GetIntValueFromDictSafe(OutContext, "crashc.Seconds Since Start");
		GSSDKEnv.UserInfo.UserSession.EngineMode = GetStrValueFromDictSafe(OutContext, "unreal.EngineMode");
		GSSDKEnv.UserInfo.UserSession.GameName = GetStrValueFromDictSafe(OutContext, "crashc.Game Name");
		GSSDKEnv.UserInfo.UserSession.LanguageLcid = GetStrValueFromDictSafe(OutContext, "user_session.language_lcid");
		GSSDKEnv.UserInfo.UserSession.RootDir = GetStrValueFromDictSafe(OutContext, "unreal.RootDir");
		GSSDKEnv.UserInfo.UserSession.BaseDir = GetStrValueFromDictSafe(OutContext, "unreal.BaseDir");
		GSSDKEnv.UserInfo.UserSession.BuildConfiguration = GetStrValueFromDictSafe(OutContext, "unreal.BuildConfigurationName");
		GSSDKEnv.UserInfo.UserSession.CrashGuid = GetStrValueFromDictSafe(OutContext, "crashc.Crash GUID");
		UGameUserSettings gameUserSettings = UGameUserSettings.GetGameUserSettings();
		GSSDKEnv.UserInfo.UserSession.Resolution = $"{gameUserSettings.GetScreenResolution().X}*{gameUserSettings.GetScreenResolution().Y}";
	}

	private static void ReportSensitiveDataCleanUserInfo(UserInfo Info)
	{
		Info.DeviceInfo.Mac = BGW_LocalDevEnvUtils.CalcMd5(Info.DeviceInfo.Mac);
		Info.DeviceInfo.LocalIpList = BGW_LocalDevEnvUtils.CalcMd5(Info.DeviceInfo.LocalIpList);
		Info.DeviceInfo.PcHdId = BGW_LocalDevEnvUtils.CalcMd5(Info.DeviceInfo.PcHdId);
		Info.DeviceInfo.PcMsProductid = BGW_LocalDevEnvUtils.CalcMd5(Info.DeviceInfo.PcMsProductid);
		Info.DeviceInfo.PcMachineGuid = BGW_LocalDevEnvUtils.CalcMd5(Info.DeviceInfo.PcMachineGuid);
		Info.DeviceInfo.PcBiosUuid = BGW_LocalDevEnvUtils.CalcMd5(Info.DeviceInfo.PcBiosUuid);
		Info.DeviceInfo.PcDeviceId = BGW_LocalDevEnvUtils.CalcMd5(Info.DeviceInfo.PcDeviceId);
		Info.UserSession.LoginId = BGW_LocalDevEnvUtils.CalcMd5(Info.UserSession.LoginId);
		Info.UserSession.BaseDir = BGW_LocalDevEnvUtils.SimpleEncryptStr(Info.UserSession.BaseDir);
		Info.UserSession.RootDir = BGW_LocalDevEnvUtils.SimpleEncryptStr(Info.UserSession.RootDir);
		Info.UserSession.MachineId = BGW_LocalDevEnvUtils.CalcMd5(Info.UserSession.MachineId);
	}

	private bool UnrealHttpReportEventPostProxy(string Url, string[] Headers, byte[] PostData)
	{
		if (UseAsyncHttpProxy)
		{
			return AsyncHttpReportEventPostPorxy(Url, Headers, PostData);
		}
		return NonGameSyncHttpReportEventPostPorxy(Url, Headers, PostData);
	}

	private bool AsyncHttpReportEventPostPorxy(string Url, string[] Headers, byte[] PostData)
	{
		BGW_AsyncTaskMgr bGW_AsyncTaskMgr = BGW_AsyncTaskMgr.Get(this);
		if (bGW_AsyncTaskMgr != null)
		{
			return bGW_AsyncTaskMgr.HttpRequestAsync(Url, "POST", Headers, PostData);
		}
		BGW_LogUtil.LogError("async event post proxy get task mgr fail");
		return false;
	}

	private bool NonGameSyncHttpReportEventPostPorxy(string Url, string[] Headers, byte[] PostData)
	{
		bool OutIsTimeout;
		HttpResponseMessage val = BGW_AsyncTaskMgr.NonGameThreadHttpRequestSync(out OutIsTimeout, Url, "POST", Headers, PostData);
		if (OutIsTimeout)
		{
			BGW_LogUtil.LogError("gssdk post url:" + Url + " timeout");
			return false;
		}
		if (val == null)
		{
			BGW_LogUtil.LogError("gssdk post url:" + Url + " fail");
			return false;
		}
		if (val.StatusCode == HttpStatusCode.OK)
		{
			return true;
		}
		return false;
	}

	public override void OnInit()
	{
		StaticWorldContext = this;
		GSSDKEnv.InitFromConfig(BGW_AsyncTaskMgr.Get(this).HttpRequestAsync, InitGSSdkEnvirontmentContext);
		if (DebugConfig.GSSdkReportEnable)
		{
			GSSDKReportQueue.UseUnrealHttpPostProxy = !DebugConfig.GSSdkReportUseCSharpHttp;
			UseAsyncHttpProxy = DebugConfig.GSSdkReportUseAsyncHttp;
			GSSDKReport.InitReport(UnrealHttpReportEventPostProxy, DebugConfig.GSSdkReportMergeBatchEventNum, DebugConfig.GSSdkReportMergeBatchIntervalSeconds);
		}
		if (DebugConfig.GSSdkReportDisableHttpRequest)
		{
			GSSDKReport.DisableNetReport();
		}
		GSSDKReport.DisableMonitorReport = !DebugConfig.GSSdkEnableMonitor;
		GSSDKPerf.DisablePerf = !DebugConfig.GSSdkEnablePerf;
		GSSDKReport.TrackEvent(ReportEvtType.LaunchGame, 0L);
		if (!B1Global.GIsGameReleased)
		{
			Logger.Init(this);
		}
		StartGSSdkVersionCheckAndThenLoginDir();
	}

	private void GSSdkOverrideSomeConfigOnVersionConfigSuccess()
	{
		_ = IsServerJsonConfigLoaded;
	}

	private void GSSdkOverrideSomeConfigOnUserLoginSuccess()
	{
		try
		{
			if (!IsServerJsonConfigLoaded || !IsGSSdkUserJsonConfigLoaded)
			{
				return;
			}
			if (!B1Global.GIsGameReleasedReally_Just4DevSimulation)
			{
				string ValidConfigCheck = Get(this).GetServerExtendJsonConfigKeyValue("FileMd5Check", "", CheckUseUserOverride: true);
				if (!string.IsNullOrEmpty(ValidConfigCheck) && ValidConfigCheck != "off")
				{
					Task.Run(delegate
					{
						BGW_LocalDevEnvUtils.SafeCheckProjMd5Manifest(this, ValidConfigCheck == "md5");
					});
				}
			}
			string serverExtendJsonConfigKeyValue = GetServerExtendJsonConfigKeyValue("SentrySamplePercent", "", CheckUseUserOverride: true);
			if (!string.IsNullOrEmpty(serverExtendJsonConfigKeyValue))
			{
				int result = 0;
				if (int.TryParse(serverExtendJsonConfigKeyValue, out result))
				{
					BGW_SentrySdkHelper.SetSentrySampleRate((float)result / 100f);
				}
			}
			UseAsyncHttpProxy = GetServerExtendJsonConfigKeyValue("OssReportUseAsyncHttpProxy", "false", CheckUseUserOverride: true) == "true";
			UserPrivacyAgreeAnalyticsReportOverrideEnableForDebug = GetUserJsonConfigKeyValue("DebugAgreePrivacy", "false") == "true";
			string serverExtendJsonConfigKeyValue2 = GetServerExtendJsonConfigKeyValue("SentryUploadArchiveFileSizeLimitKB", "", CheckUseUserOverride: true);
			if (!string.IsNullOrEmpty(serverExtendJsonConfigKeyValue2))
			{
				int result2 = 0;
				if (int.TryParse(serverExtendJsonConfigKeyValue2, out result2) && result2 > 0)
				{
					BGW_SentrySdkHelper.UploadArchiveFileSizeLimit = result2 * 1024;
				}
			}
		}
		catch (Exception ex)
		{
			BGW_LogUtil.LogError("fail check sconf:" + ex.Message);
		}
	}

	public void StartGSSdkVersionCheckAndThenLoginDir()
	{
		if (VersionChecker.StartVersionCheck(delegate(bool bSucces)
		{
			if (bSucces)
			{
				GameSDKMgr.Login(OnGameSDKMgrLoginFinish);
			}
			else
			{
				BGW_LogUtil.LogError("gssdk version check fail , should retry .");
			}
			ReportEventGameCrash reportEventGameCrash = BGW_DebugMgr.CheckLoadOssGameCrashContext();
			if (reportEventGameCrash != null)
			{
				EventReporter instance = EventReporter.GetInstance(this);
				if (instance != null)
				{
					instance.GameCrash(reportEventGameCrash);
					GSSDKReport.TickCheckUpdate(bSyncFlush: true);
				}
			}
			if (bSucces)
			{
				GSSdkOverrideSomeConfigOnVersionConfigSuccess();
			}
		}, 4))
		{
			IsGSSdkUserLoginFinished = false;
		}
	}

	public void StartGSSdkVersionCheckOnlyNoRetry(Action action = null)
	{
		VersionChecker.StartVersionCheck(delegate(bool bSuccess)
		{
			if (bSuccess)
			{
				action?.Invoke();
			}
		}, 0);
	}

	public void OnGameSDKMgrLoginFinish(bool bSuccess, string Msg)
	{
		IsGSSdkUserLoginFinished = true;
		IsGSSdkUserLoginSuccess = bSuccess;
		BGW_SentrySdkHelper.UpdateCppCrashUserContextWhenSdkLoginFinish(this);
		GSSdkOverrideSomeConfigOnUserLoginSuccess();
		if (BGW_CETestGameMgr.EnableCETesting)
		{
			BGW_CETestGameMgr.Get(this).OnGSSdkUserLoginFinish(bSuccess, Msg);
		}
		UpdatePlatformSdkLoginState();
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (!CppSentryReporterInited)
		{
			CppSentryReporterInited = true;
			BGW_SentrySdkHelper.UpdateCppCrashContextWhenGameManagerInitFinish(this);
			if (string.IsNullOrEmpty(GSSDKEnv.UserKey.ShareArchiveUuid))
			{
				BGW_GameArchiveMgr bGW_GameArchiveMgr = BGW_GameArchiveMgr.Get(this);
				if (bGW_GameArchiveMgr != null)
				{
					GSSDKEnv.SetUserShareArchiveId(bGW_GameArchiveMgr.SharedArchiveUid);
				}
			}
		}
		LowHzTickCountdown -= DeltaTime;
		GSSDKPerf.TickCheckUpdate(bForceSync: false, DeltaTime);
		if (LowHzTickCountdown <= 0f)
		{
			LowHzTickCountdown = 2f;
			bool userPrivacyAgreeAnalyticsReport = UserPrivacyAgreeAnalyticsReport;
			if (UserPrivacyAgreeAnalyticsReport_LastValue != userPrivacyAgreeAnalyticsReport)
			{
				UserPrivacyAgreeAnalyticsReport_LastValue = userPrivacyAgreeAnalyticsReport;
				GSSDKReport.DisableAnyReport(!userPrivacyAgreeAnalyticsReport);
				UGSE_SDKFuncLib.SetCrashReportClientEnable(userPrivacyAgreeAnalyticsReport ? 1 : 0);
			}
			GSSDKReport.TickCheckUpdate();
			GameSDKMgr.UpdateTickLowHz();
			VersionChecker.TickCheckVersionConfig();
		}
	}

	public void FlushEventReport()
	{
		GSSDKPerf.TickCheckUpdate(bForceSync: true, 0f);
		GSSDKReport.TickCheckUpdate(bSyncFlush: true);
		GSSDKReportQueue.Stop();
	}

	public static void InitGSSdkLogger()
	{
		LogHelper.SetLogWriter(delegate(GSEOnlineLogLevel lv, string msg)
		{
			switch (lv)
			{
			case GSEOnlineLogLevel.LOG_ERROR:
				BGW_LogUtil.LogError(msg);
				break;
			case GSEOnlineLogLevel.LOG_FATAL:
				BGW_LogUtil.LogError(msg);
				break;
			}
		});
		LogHelper.SetLogLevel(GSEOnlineLogLevel.LOG_INFO);
	}

	public override void OnShutdown()
	{
		base.OnShutdown();
		FlushEventReport();
		Logger.Stop();
		LogHelper.SetLogWriter(null);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGW_GSSdkMgr");
	}

	static BGW_GSSdkMgr()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGW_GSSdkMgr)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGW_GSSdkMgr));
	}
}
