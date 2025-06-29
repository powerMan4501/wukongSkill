using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using GSE.GSSdk;
using Gssdk;
using Sentry;
using UnrealEngine.Runtime;

namespace b1;

public static class BGW_SentrySdkHelper
{
	private class SentryUserContext
	{
		public string username;

		public string email;

		public string id;

		public string ip_address;
	}

	private static IDisposable SentryInstance = null;

	public static int UploadArchiveFileSizeLimit = 4194304;

	private static byte[] UploadMemLogFileBytes = null;

	private static Random RandomGenerater = new Random();

	private static DateTime LastReportMessageTime = DateTime.MinValue;

	public static int SentryCaptureMsgIntervalMinutes = 4;

	private static Dictionary<string, string> GameRuntimeEnvContext = null;

	private static float SampleRate = 1f;

	private static string LogFilePath = null;

	private static bool IsCurrentCrashReportEnabled = false;

	public static bool SentryIsRequesting => SentryHttpHandler.IsHttpRequesting;

	public static bool IsSentryEnable
	{
		get
		{
			if (IsCurrentCrashReportEnabled && BGW_GSSdkMgr.UserPrivacyAgreeAnalyticsReport)
			{
				return SentryInstance != null;
			}
			return false;
		}
	}

	private static Dictionary<string, string> GetDeviceInfoDict()
	{
		UserDevice deviceInfo = GSSDKEnv.UserInfo.DeviceInfo;
		return new Dictionary<string, string>
		{
			{
				"DeviceId",
				deviceInfo.DeviceId.ToString()
			},
			{
				"Mac",
				deviceInfo.Mac.ToString()
			},
			{
				"Platform",
				deviceInfo.Platform.ToString()
			},
			{
				"Height",
				deviceInfo.Height.ToString()
			},
			{
				"Width",
				deviceInfo.Width.ToString()
			},
			{
				"OsVer",
				deviceInfo.OsVer.ToString()
			},
			{
				"LocalIpList",
				deviceInfo.LocalIpList.ToString()
			},
			{
				"MemMbTotal",
				deviceInfo.MemMbTotal.ToString()
			},
			{
				"MemMbFree",
				deviceInfo.MemMbFree.ToString()
			},
			{
				"CpuModel",
				deviceInfo.CpuModel.ToString()
			},
			{
				"GpuModel",
				deviceInfo.GpuModel.ToString()
			},
			{
				"CpuCores",
				deviceInfo.CpuCores.ToString()
			},
			{
				"CpuLogicThreads",
				deviceInfo.CpuLogicThreads.ToString()
			},
			{
				"InstallDirIsSsd",
				deviceInfo.InstallDirIsSsd.ToString()
			},
			{
				"GpuDriverDesc",
				deviceInfo.GpuDriverDesc.ToString()
			},
			{
				"OsName",
				deviceInfo.OsName.ToString()
			},
			{
				"OsRawDesc",
				deviceInfo.OsRawDesc.ToString()
			},
			{
				"CpuArch",
				deviceInfo.CpuArch.ToString()
			},
			{
				"PcHdId",
				deviceInfo.PcHdId.ToString()
			},
			{
				"PcMsProductid",
				deviceInfo.PcMsProductid.ToString()
			},
			{
				"PcMachineGuid",
				deviceInfo.PcMachineGuid.ToString()
			},
			{
				"PcBiosUuid",
				deviceInfo.PcBiosUuid.ToString()
			},
			{
				"NatType",
				deviceInfo.NatType.ToString()
			},
			{
				"PcDeviceId",
				deviceInfo.PcDeviceId.ToString()
			}
		};
	}

	private static Dictionary<string, string> GetUserAuthInfoDict()
	{
		UserAuthInfo authInfo = GSSDKEnv.UserInfo.AuthInfo;
		Dictionary<string, string> dictionary = new Dictionary<string, string>
		{
			{
				"LoginChannel",
				authInfo.LoginChannel.ToString()
			},
			{
				"LoginSubChannel",
				authInfo.LoginSubChannel.ToString()
			},
			{
				"Aid",
				authInfo.Aid.ToString()
			},
			{
				"Roleid",
				authInfo.Roleid.ToString()
			},
			{
				"LocalChannelSdkLoginState",
				authInfo.LocalChannelSdkLoginState.ToString()
			},
			{ "LoginChannelUserName", authInfo.LoginChannelUserName }
		};
		if (BGW_GSSdkMgr.EnableCleanUserData)
		{
			dictionary["LoginChannelUid"] = BGW_LocalDevEnvUtils.SimpleEncryptStr(authInfo.LoginChannelUid.ToString());
		}
		else
		{
			dictionary["LoginChannelUid"] = authInfo.LoginChannelUid.ToString();
		}
		return dictionary;
	}

	private static Dictionary<string, string> GetUserSettingsDict()
	{
		UserClientSetting clientSetting = GSSDKEnv.UserInfo.ClientSetting;
		return new Dictionary<string, string>
		{
			{
				"AppChannel",
				clientSetting.AppChannel.ToString()
			},
			{
				"AppVersion",
				clientSetting.AppVersion.ToString()
			},
			{
				"BuildRevision",
				clientSetting.BuildRevision.ToString()
			},
			{
				"GitCodeRevision",
				clientSetting.GitCodeRevision.ToString()
			},
			{
				"P4ProjRevision",
				clientSetting.P4ProjRevision.ToString()
			},
			{
				"P4EngineRevision",
				clientSetting.P4EngineRevision.ToString()
			},
			{
				"BuildTime",
				clientSetting.BuildTime.ToString()
			},
			{
				"PkgTag",
				clientSetting.PkgTag.ToString()
			},
			{
				"Language",
				clientSetting.Language.ToString()
			},
			{
				"Region",
				clientSetting.Region.ToString()
			},
			{
				"TzOffset",
				clientSetting.TzOffset.ToString()
			},
			{
				"PlayMode",
				clientSetting.PlayMode.ToString()
			},
			{
				"Env",
				clientSetting.Env.ToString()
			},
			{
				"Branch",
				clientSetting.Branch.ToString()
			},
			{
				"GraphicApi",
				clientSetting.GraphicApi.ToString()
			},
			{
				"VcRedist",
				clientSetting.VcRedist.ToString()
			},
			{
				"CultureDesc",
				clientSetting.CultureDesc.ToString()
			}
		};
	}

	private static Dictionary<string, string> GetUserGameSessionDict()
	{
		UserGameSession userSession = GSSDKEnv.UserInfo.UserSession;
		return new Dictionary<string, string>
		{
			{
				"StartSessionUuid",
				userSession.StartSessionUuid.ToString()
			},
			{
				"StartTimestamp",
				userSession.StartTimestamp.ToString()
			},
			{
				"LoginId",
				userSession.LoginId.ToString()
			},
			{
				"MachineId",
				userSession.MachineId.ToString()
			},
			{
				"PlatformName",
				userSession.PlatformName.ToString()
			},
			{
				"ProcessId",
				userSession.ProcessId.ToString()
			},
			{
				"SecondsSinceStart",
				userSession.SecondsSinceStart.ToString()
			},
			{
				"EngineMode",
				userSession.EngineMode.ToString()
			},
			{
				"GameName",
				userSession.GameName.ToString()
			},
			{
				"LanguageLcid",
				userSession.LanguageLcid.ToString()
			},
			{
				"RootDir",
				userSession.RootDir.ToString()
			},
			{
				"BaseDir",
				userSession.BaseDir.ToString()
			},
			{
				"BuildConfiguration",
				userSession.BuildConfiguration.ToString()
			},
			{
				"CrashGuid",
				userSession.CrashGuid.ToString()
			},
			{
				"Resolution",
				userSession.Resolution.ToString()
			}
		};
	}

	private static string GetGameArchiveFilePath(UObject WorldContext, int ArchiveId)
	{
		return GSWindowsPlatformSaveGame.GetFileFullName(GSE_SaveGameUtil.GetArchiveSlotName(SaveFileType.Archive, ArchiveId), BGW_OnlineIdentity.Get(WorldContext).SafeGetUniquePlayerId());
	}

	private static string GetShareArchiveFilePath(UObject WorldContext)
	{
		return GSWindowsPlatformSaveGame.GetFileFullName(GSE_SaveGameUtil.GetArchiveSlotName(SaveFileType.SharedArchive), BGW_OnlineIdentity.Get(WorldContext).SafeGetUniquePlayerId());
	}

	private static string GetSettingArchiveFilePath(UObject WorldContext)
	{
		return GSWindowsPlatformSaveGame.GetFileFullName(GSE_SaveGameUtil.GetArchiveSlotName(SaveFileType.UserSetting), BGW_OnlineIdentity.Get(WorldContext).SafeGetUniquePlayerId());
	}

	public static void UpdateSentryEventScopeImpl(UObject Context, Scope scope)
	{
		SentryUserContext sentryUserContext = GetSentryUserContext(Context);
		if (sentryUserContext != null)
		{
			scope.User.Email = sentryUserContext.email;
			scope.User.Id = sentryUserContext.id;
			scope.User.Username = sentryUserContext.username;
			scope.User.IpAddress = sentryUserContext.ip_address;
		}
		scope.Contexts["UserDeviceInfo"] = GetDeviceInfoDict();
		scope.Contexts["UserSdkAccountInfo"] = GetUserAuthInfoDict();
		scope.Contexts["UserClientSettings"] = GetUserSettingsDict();
		scope.Contexts["UserGameSession"] = GetUserGameSessionDict();
		scope.SetTag("game_session_id", GSSDKEnv.UserInfo.UserSession?.StartSessionUuid ?? "");
		scope.SetTag("platform", GSSDKEnv.UserInfo.DeviceInfo?.Platform ?? "");
		scope.SetTag("crash_guid", GSSDKEnv.UserInfo.UserSession?.CrashGuid ?? "");
		if (UploadMemLogFileBytes != null && UploadMemLogFileBytes.Length != 0)
		{
			scope.AddAttachment(UploadMemLogFileBytes, "mem.log");
		}
		try
		{
			if (Context != null && Context.IsValidLowLevel())
			{
				BGW_GameArchiveMgr bGW_GameArchiveMgr = BGW_GameArchiveMgr.Get(Context);
				if (bGW_GameArchiveMgr != null)
				{
					int currentArchiveId = bGW_GameArchiveMgr.CurrentArchiveId;
					string gameArchiveFilePath = GetGameArchiveFilePath(Context, currentArchiveId);
					FileInfo fileInfo = new FileInfo(gameArchiveFilePath);
					if (fileInfo.Exists && fileInfo.Length < UploadArchiveFileSizeLimit)
					{
						scope.AddAttachment(gameArchiveFilePath);
					}
				}
				string shareArchiveFilePath = GetShareArchiveFilePath(Context);
				FileInfo fileInfo2 = new FileInfo(shareArchiveFilePath);
				if (fileInfo2.Exists && fileInfo2.Length < UploadArchiveFileSizeLimit)
				{
					scope.AddAttachment(shareArchiveFilePath);
				}
				string settingArchiveFilePath = GetSettingArchiveFilePath(Context);
				FileInfo fileInfo3 = new FileInfo(settingArchiveFilePath);
				if (fileInfo3.Exists && fileInfo3.Length < UploadArchiveFileSizeLimit)
				{
					scope.AddAttachment(settingArchiveFilePath);
				}
			}
			string text = FPaths.Combine(FPaths.ProjectSavedDir, "Config", "Windows", "GameUserSettings.ini");
			FileInfo fileInfo4 = new FileInfo(text);
			if (fileInfo4.Exists && fileInfo4.Length < UploadArchiveFileSizeLimit)
			{
				scope.AddAttachment(text);
			}
		}
		catch (Exception)
		{
			BGW_LogUtil.LogError("st add ar file fail");
		}
		scope.SetTag("btype", "game-c#");
	}

	private static void SafeUpdateSentryEventScope(UObject Context, Scope scope)
	{
		if (!IsSentryEnable)
		{
			return;
		}
		try
		{
			UpdateSentryEventScopeImpl(Context, scope);
		}
		catch (Exception ex)
		{
			BGW_LogUtil.LogError("sentry capture event occur exception " + ex.Message);
		}
	}

	public static void SentrySetUploadMemoryLog(byte[] LogBytes)
	{
		UploadMemLogFileBytes = LogBytes;
	}

	private static bool RandomReportSample()
	{
		if (SampleRate < 1f && RandomGenerater.NextDouble() > (double)SampleRate)
		{
			return false;
		}
		return true;
	}

	public static void SentryCaptureMessageWithScope(UObject Context, string Msg, string UserConfig = null, Action<Scope> FillScopeCallback = null)
	{
		if (!IsSentryEnable)
		{
			return;
		}
		if (string.IsNullOrEmpty(Msg))
		{
			Msg = "None";
		}
		string text = Msg.Substring(0, Math.Min(16, Msg.Length));
		GSSDKReport.MonitorAdd(MonEvtCatogray.ERROR, "StyCapMsg", 1L, "Msg=" + text);
		if (!RandomReportSample())
		{
			GSSDKReport.MonitorAdd(MonEvtCatogray.ERROR, "StyMissMsg", 1L, "Msg=" + text);
			return;
		}
		if (LastReportMessageTime == DateTime.MinValue)
		{
			LastReportMessageTime = DateTime.Now;
		}
		else
		{
			if ((DateTime.Now - LastReportMessageTime).TotalMinutes < (double)SentryCaptureMsgIntervalMinutes)
			{
				BGW_LogUtil.LogError("st capture msg too much");
				GSSDKReport.MonitorAdd(MonEvtCatogray.ERROR, "StyCapMsgHz", 1L, "Msg=" + text);
				return;
			}
			LastReportMessageTime = DateTime.Now;
		}
		SentryHttpHandler.IsHttpRequesting = true;
		SentrySdk.CaptureMessage(Msg, delegate(Scope configureScope)
		{
			SafeUpdateSentryEventScope(Context, configureScope);
			if (!string.IsNullOrEmpty(UserConfig))
			{
				configureScope.SetExtra("UserConfig", UserConfig);
			}
			try
			{
				FillScopeCallback?.Invoke(configureScope);
			}
			catch (Exception ex)
			{
				BGW_LogUtil.LogError("fill sentry scope exception:" + ex.Message);
			}
		}, SentryLevel.Warning);
	}

	public static string GetSentryAppReleaseName()
	{
		string text = (FGlobals.IsEditor ? "Editor" : "Game");
		return $"{FApp.GetProjectName()}-{text}@{GSVersionUtil.GetAppVersionWithRevision()}+{BGW_LocalDevEnvUtils.GetBuildBranch()}-{FApp.GetBuildConfiguration()}-{FPlatformProperties.GetPlatform().ToString()}-{DebugConfig.GSSdkLoginChannel}";
	}

	public static Dictionary<string, string> GetGameRuntimeEnvContext()
	{
		if (GameRuntimeEnvContext == null)
		{
			UGSE_SDKFuncLib.GetGameRunEnvContext(out GameRuntimeEnvContext);
		}
		return GameRuntimeEnvContext;
	}

	public static void SentryCaptureException(UObject Context, Exception e, string UserConfig = null)
	{
		if (!IsSentryEnable)
		{
			BGW_LogUtil.LogError("sentry disabled");
			return;
		}
		try
		{
			GSSDKReport.MonitorAdd(MonEvtCatogray.ERROR, "StyCapExp", 1L, "Msg=" + e.Message);
			if (!RandomReportSample())
			{
				GSSDKReport.MonitorAdd(MonEvtCatogray.ERROR, "StyMissExp", 1L, "Msg=" + e.Message);
				return;
			}
			SentryHttpHandler.IsHttpRequesting = true;
			SentrySdk.CaptureException(e, delegate(Scope configureScope)
			{
				SafeUpdateSentryEventScope(Context, configureScope);
				if (UserConfig != null)
				{
					configureScope.SetExtra("UserConfig", UserConfig);
				}
				else
				{
					BGW_DebugMgr bGW_DebugMgr = BGW_DebugMgr.Get(Context);
					if (bGW_DebugMgr != null)
					{
						UserConfig = bGW_DebugMgr.GetUserConfig();
					}
					configureScope.SetExtra("UserConfig", UserConfig);
				}
			});
		}
		catch (Exception ex)
		{
			BGW_LogUtil.LogError("sentry catch exception ex:" + ex.Message + " when cap msg for e:" + e.Message);
		}
	}

	public static void SentryCaptureMessage(UObject Context, string Msg, string UserConfig = null)
	{
		if (UserConfig == null && Context != null)
		{
			BGW_DebugMgr bGW_DebugMgr = BGW_DebugMgr.Get(Context);
			if (bGW_DebugMgr != null)
			{
				UserConfig = bGW_DebugMgr.GetUserConfig();
			}
		}
		SentryCaptureMessageWithScope(Context, Msg, UserConfig);
	}

	public static void UpdateCppCrashContextWhenGameManagerInitFinish(UObject WorldContext)
	{
		UGSE_SDKFuncLib.SentryCrashReporterSetContext("UserGameSession", GetUserGameSessionDict());
		UGSE_SDKFuncLib.SentryCrashReporterSetContext("UserClientSettings", GetUserSettingsDict());
		UGSE_SDKFuncLib.SentryCrashReporterSetTag("game_session_id", GSSDKEnv.UserInfo.UserSession?.StartSessionUuid ?? "");
		UpdateCppCrashUserContextWhenSdkLoginFinish(WorldContext);
	}

	public static void UpdateCppCrashUserContextWhenSdkLoginFinish(UObject Context)
	{
		SentryUserContext sentryUserContext = GetSentryUserContext(Context);
		if (sentryUserContext != null)
		{
			UGSE_SDKFuncLib.SentryCrashReporterSetUser("username", sentryUserContext.username);
			UGSE_SDKFuncLib.SentryCrashReporterSetUser("id", sentryUserContext.id);
			UGSE_SDKFuncLib.SentryCrashReporterSetUser("ip_address", sentryUserContext.ip_address);
			UGSE_SDKFuncLib.SentryCrashReporterSetUser("email", sentryUserContext.email);
			Dictionary<string, string> userAuthInfoDict = GetUserAuthInfoDict();
			if (userAuthInfoDict != null && userAuthInfoDict.Count > 0)
			{
				UGSE_SDKFuncLib.SentryCrashReporterSetContext("UserSdkAccountInfo", userAuthInfoDict);
			}
		}
	}

	private static void InitCppCrashReporter()
	{
		try
		{
			UGSE_SDKFuncLib.SentryCrashReporterSetRoot("release", GetSentryAppReleaseName());
			UGSE_SDKFuncLib.SentryCrashReporterSetRoot("environment", GetSentryEnvironment());
			UGSE_SDKFuncLib.SentryCrashReporterSetTag("platform", GSSDKEnv.UserInfo.DeviceInfo?.Platform ?? "");
			UGSE_SDKFuncLib.SentryCrashReporterSetTag("crash_guid", GetCrashGuid());
			if (!B1Global.GIsGameReleased)
			{
				UGSE_SDKFuncLib.SentryCrashReporterSetContext("DevEnv", GetSentryDevEnvContext());
			}
			UGSE_SDKFuncLib.SentryCrashReporterSetTag("btype", "game-cpp");
		}
		catch (Exception ex)
		{
			BGW_LogUtil.LogError("init set sentry context ex:" + ex.Message);
		}
	}

	public static void SetSentrySampleRate(float SampleRate_)
	{
		if (SampleRate >= 0f && SampleRate <= 1f)
		{
			SampleRate = SampleRate_;
		}
	}

	public static Dictionary<string, string> GetSentryDevEnvContext()
	{
		try
		{
			if (B1Global.GIsGameReleased || DebugConfig.GSSdkLoginChannel != "gamesci")
			{
				return new Dictionary<string, string>();
			}
			string localIpv4ListStr = BGW_LocalDevEnvUtils.GetLocalIpv4ListStr();
			return new Dictionary<string, string>
			{
				{
					"MacAddr",
					BGW_LocalDevEnvUtils.GetMacAddress()
				},
				{
					"DevRegion",
					BGW_LocalDevEnvUtils.GetDevNetRegion()
				},
				{
					"HostName",
					BGW_LocalDevEnvUtils.GetHostName()
				},
				{
					"HostUserName",
					BGW_LocalDevEnvUtils.GetLocalHostUserName()
				},
				{
					"HostMachineName",
					BGW_LocalDevEnvUtils.GetLocalHostMachineName()
				},
				{ "IpList", localIpv4ListStr },
				{
					"EngineType",
					BED_EditorStartupCheckEngineVer.UsingBuildEngineType
				},
				{
					"EngineVersion",
					BED_EditorStartupCheckEngineVer.BuildEngineVesion
				}
			};
		}
		catch (Exception ex)
		{
			BGW_LogUtil.LogError("get sentry dev context ex:" + ex.Message);
			return new Dictionary<string, string>();
		}
	}

	private static string GetSentryUserIp()
	{
		if (!B1Global.GIsGameReleased || DebugConfig.GSSdkLoginChannel == "gamesci")
		{
			return BGW_LocalDevEnvUtils.GetLocalIpv4ListStr();
		}
		return "{{auto}}";
	}

	private static SentryUserContext GetSentryUserContext(UObject Context)
	{
		try
		{
			if (Context != null && BGW_GSSdkMgr.Get(Context) != null && GSSDKEnv.UserInfo != null && GSSDKEnv.UserInfo.AuthInfo != null)
			{
				string loginChannelUserName = GSSDKEnv.UserInfo.AuthInfo.LoginChannelUserName;
				loginChannelUserName = (string.IsNullOrEmpty(GSSDKEnv.UserInfo.AuthInfo.LoginSubChannel) ? (GSSDKEnv.UserInfo.AuthInfo.LoginChannelUserName + "@" + GSSDKEnv.UserInfo.AuthInfo.LoginChannel + ".net") : (GSSDKEnv.UserInfo.AuthInfo.LoginChannelUserName + "@" + GSSDKEnv.UserInfo.AuthInfo.LoginSubChannel + "." + GSSDKEnv.UserInfo.AuthInfo.LoginChannel + ".net"));
				return new SentryUserContext
				{
					email = loginChannelUserName,
					id = GSSDKEnv.UserInfo.AuthInfo.LoginChannelUid,
					username = GSSDKEnv.UserInfo.AuthInfo.LoginChannelUserName,
					ip_address = GetSentryUserIp()
				};
			}
		}
		catch (Exception ex)
		{
			BGW_LogUtil.LogError("get sentry user context ex:" + ex.Message);
		}
		BGW_LogUtil.LogError("sentry get user context fail");
		return null;
	}

	public static string GetLogFilePath()
	{
		if (string.IsNullOrEmpty(LogFilePath))
		{
			Dictionary<string, string> gameRuntimeEnvContext = GetGameRuntimeEnvContext();
			if (gameRuntimeEnvContext.ContainsKey("LogFilePath"))
			{
				LogFilePath = gameRuntimeEnvContext["LogFilePath"];
			}
		}
		return LogFilePath;
	}

	private static string GetSentryEnvironment()
	{
		string text = FPlatformProperties.GetPlatform().ToString();
		if (!B1Global.GIsGameReleased)
		{
			return text + "_Shipping";
		}
		return DebugConfig.GSSdkLoginChannel + "_prod";
	}

	public static string GetCrashConfigPath()
	{
		Dictionary<string, string> gameRuntimeEnvContext = GetGameRuntimeEnvContext();
		if (gameRuntimeEnvContext.ContainsKey("crashc.CrashConfigFile"))
		{
			return gameRuntimeEnvContext["crashc.CrashConfigFile"];
		}
		return "";
	}

	public static string GetCrashGuid()
	{
		Dictionary<string, string> gameRuntimeEnvContext = GetGameRuntimeEnvContext();
		if (gameRuntimeEnvContext.ContainsKey("crashc.Crash GUID"))
		{
			return gameRuntimeEnvContext["crashc.Crash GUID"];
		}
		return "";
	}

	private static string GetStrValueFromDictSafe(Dictionary<string, string> Dict, string Key)
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

	public static string SelectSentryDSN(string DSN)
	{
		if (DSN.Contains(','))
		{
			string[] array = DSN.Split(new char[1] { ',' }, StringSplitOptions.RemoveEmptyEntries);
			string text = BGW_LocalDevEnvUtils.GetUserRegion(GetStrValueFromDictSafe(GetGameRuntimeEnvContext(), "client_setting.region"));
			if (!string.IsNullOrEmpty(text))
			{
				text = StringParseHelper.SafeToLower(text);
			}
			bool flag = text == "cn";
			for (int i = 0; i < array.Length; i++)
			{
				if (flag && array[i].Contains("st1."))
				{
					return array[i];
				}
			}
			return array[0];
		}
		return DSN;
	}

	public static void SentryDestroy()
	{
		if (SentryInstance != null)
		{
			SentrySdk.Close();
			SentryInstance.Dispose();
			SentryInstance = null;
		}
	}

	public static void InitSentryCheck()
	{
		try
		{
			USharpExceptionHandler.IsSentryInitFinish = true;
			if (SentryInstance != null)
			{
				return;
			}
			InitCppCrashReporter();
			if (!DebugConfig.SentryEnable)
			{
				return;
			}
			IsCurrentCrashReportEnabled = DebugConfig.SentryEnable;
			string text = DebugConfig.SentryDSN;
			if (!text.Contains(".heishenhua."))
			{
				text = "https://d048d52b9ca8bed6e1ac9266ad5f0844@st2.heishenhua.com/2,https://c9d3756c9a7841ca7c6fa673c41ad27e@st1.heishenhua.com/2";
			}
			if (string.IsNullOrEmpty(text))
			{
				SentryInstance = null;
				BGW_LogUtil.LogError("SENTRY dsn config empty , disable sentry system .");
				return;
			}
			string SentryDSN = SelectSentryDSN(text);
			string sentryHostBackup = DebugConfig.SentryHostBackup;
			string DSNBackupReplaceMatch = "";
			string DSNBackupReplaceNew = "";
			if (sentryHostBackup.Contains(":"))
			{
				string[] array = sentryHostBackup.Split(new char[1] { ':' }, StringSplitOptions.RemoveEmptyEntries);
				if (array.Length == 2)
				{
					DSNBackupReplaceMatch = array[0];
					DSNBackupReplaceNew = array[1];
				}
			}
			SentryInstance = SentrySdk.Init(delegate(SentryOptions options)
			{
				options.Dsn = SentryDSN;
				options.Environment = GetSentryEnvironment();
				int num = 5242880;
				if (!B1Global.GIsGameReleased)
				{
					num = 62914560;
				}
				options.MaxAttachmentSize = num;
				options.Release = GetSentryAppReleaseName();
				options.Distribution = DebugConfig.GSSdkLoginChannel;
				options.Debug = DebugConfig.SentryDebug;
				if (!B1Global.GIsGameReleased)
				{
					options.SampleRate = 1f;
				}
				else if (!string.IsNullOrEmpty(DebugConfig.SentrySampleRate))
				{
					options.SampleRate = StringParseHelper.SafeFloatParse(DebugConfig.SentrySampleRate);
				}
				options.UseAsyncFileIO = true;
				options.IsInConsole = false;
				options.AutoSessionTracking = false;
				options.IsGlobalModeEnabled = true;
				options.EnableTracing = DebugConfig.SentryEnableTracing;
				options.CaptureFailedRequests = DebugConfig.SentryCaptureFailRequests;
				options.ReportAssembliesMode = ReportAssembliesMode.None;
				options.CrashedLastRun = (Func<bool>)Delegate.Combine(options.CrashedLastRun, (Func<bool>)delegate
				{
					BGW_LogUtil.LogError("sentry detect last run crash.");
					return true;
				});
				options.CacheDirectoryPath = null;
				if (DebugConfig.SentryUseLocalCacheFile)
				{
					try
					{
						string text2 = FPaths.Combine(FPaths.ProjectLogDir, "st");
						if (!Directory.Exists(text2))
						{
							Directory.CreateDirectory(text2);
						}
						options.CacheDirectoryPath = text2;
					}
					catch
					{
						BGW_LogUtil.LogError("create sentry cache dir fail");
					}
				}
				options.CreateHttpMessageHandler = () => (HttpMessageHandler)(object)new SentryHttpHandler(DSNBackupReplaceMatch, DSNBackupReplaceNew);
				options.DiagnosticLogger = new b1.SentryAdaptLogger();
			});
			if (SentryInstance == null)
			{
				BGW_LogUtil.LogError("sentry init fail");
				return;
			}
			SentrySdk.ConfigureScope(delegate(Scope scope)
			{
				scope.User.IpAddress = "{{auto}}";
				if (!B1Global.GIsGameReleased)
				{
					scope.Contexts["DevEnv"] = GetSentryDevEnvContext();
				}
				string logFilePath = GetLogFilePath();
				if (!string.IsNullOrEmpty(logFilePath))
				{
					scope.AddAttachment(logFilePath);
				}
			});
		}
		catch (Exception ex)
		{
			BGW_LogUtil.LogError("init sentry sdk helper fail:" + ex.Message);
		}
	}

	public static void DisableSentry(bool bSwitch)
	{
		IsCurrentCrashReportEnabled = bSwitch;
	}
}
