using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using AOT;
using GSE.GSSdk;
using GSE.OnlineBase;
using OssB1;
using ResB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGW_DebugMgr")]
public class BGW_DebugMgr : GameInstanceSystemBaseUObj
{
	private float _updateUserConfigTimer;

	private static string OssGameCrashConextSaveFile;

	private static bool IsOssReporting;

	private static object _lock_oss_reporting;

	private static object _lock_handle_error;

	private static bool IsCrashAlready;

	public bool IsFatalExceptionHandle { get; set; }

	public override bool bTickEnabled => true;

	public static BGW_DebugMgr Get(UObject WorldContext)
	{
		return BGWGameInstanceCS.GetObject<BGW_DebugMgr>(WorldContext);
	}

	public override void OnInit()
	{
		InitUSharpExceptionHandler();
		BGW_SentrySdkHelper.InitSentryCheck();
	}

	public override void OnShutdown()
	{
		base.OnShutdown();
		UnInitUSharpExceptionHandler();
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (_updateUserConfigTimer < 0f)
		{
			UpdateUserConfigToSentry();
			_updateUserConfigTimer = DebugConfig.UpdateUserConfigInterval;
		}
		else
		{
			_updateUserConfigTimer -= DeltaTime;
		}
	}

	public void UpdateUserConfigToSentry()
	{
		UGSE_SDKFuncLib.SentryCrashReporterSetContext("附加数据", new Dictionary<string, string>
		{
			{
				"UserConfig",
				GetUserConfig()
			},
			{
				"UpdateTime",
				DateTime.Now.ToString(CultureInfo.InvariantCulture)
			}
		});
	}

	public static ReportEventGameCrash CheckLoadOssGameCrashContext()
	{
		try
		{
			if (!UGSFileHelper.FileExists(OssGameCrashConextSaveFile))
			{
				return null;
			}
			List<byte> BytesToRead = new List<byte>();
			if (!UGSFileHelper.ReadFile(OssGameCrashConextSaveFile, out BytesToRead))
			{
				BGW_LogUtil.LogError("read crash context fail");
				return null;
			}
			UGSFileHelper.DeleteFile(OssGameCrashConextSaveFile);
			GSSDKReport.MonitorAdd(MonEvtCatogray.ERROR, "LastCppCrash", 1L, null);
			if (BytesToRead != null && BytesToRead.Count > 0)
			{
				ReportEventGameCrash reportEventGameCrash = new ReportEventGameCrash();
				reportEventGameCrash.Ext = Encoding.UTF8.GetString(BytesToRead.ToArray());
				reportEventGameCrash.GameSessionId = GSSDKEnv.UserInfo.UserSession.StartSessionUuid;
				string[] array = reportEventGameCrash.Ext.Split('\n');
				if (array.Length != 0)
				{
					reportEventGameCrash.LastCrashTime = array[0];
				}
				if (array.Length > 1)
				{
					reportEventGameCrash.CrashGuid = array[1];
				}
				reportEventGameCrash.CrashType = GameCrashType.CppCrash;
				if (reportEventGameCrash != null)
				{
					reportEventGameCrash.IsLastCrash = true;
				}
				return reportEventGameCrash;
			}
			BGW_LogUtil.LogError("read crash context size invalid");
			return null;
		}
		catch (Exception ex)
		{
			BGW_LogUtil.LogError("load oss game crash context fail " + ex.Message);
			return null;
		}
	}

	public static void ReportOssGameCrashContext(GameCrashType CrashType, UObject GameContext, string ErrMsg = "")
	{
		try
		{
			lock (_lock_oss_reporting)
			{
				if (IsOssReporting)
				{
					BGW_LogUtil.LogError("reort oss game crashing got a new reporting ...");
					return;
				}
				IsOssReporting = true;
			}
			GSSDKReport.MonitorAdd(MonEvtCatogray.ERROR, "Exception", 1L, $"type={CrashType}");
			ReportEventGameCrash reportEventGameCrash = new ReportEventGameCrash();
			reportEventGameCrash.CrashType = CrashType;
			reportEventGameCrash.Timestamp = LocalTime.GetUnixTimeStampMilliSeconds();
			reportEventGameCrash.GameSessionId = "no-sdk-mgr";
			string text = "";
			StackTrace stackTrace = new StackTrace();
			for (int i = 0; i < stackTrace.FrameCount && i < 40; i++)
			{
				StackFrame frame = stackTrace.GetFrame(i);
				if (frame != null)
				{
					text += $"{frame.GetMethod()?.Name}:{frame.GetFileName()}:{frame.GetFileLineNumber()}";
					text += "\n";
				}
			}
			reportEventGameCrash.StackTrace = text;
			reportEventGameCrash.ErrorDesc = ErrMsg;
			reportEventGameCrash.LastCrashTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
			int num;
			if (GameContext != null && GameContext.IsValidLowLevel())
			{
				num = ((!GameContext.IsDestroyed) ? 1 : 0);
				if (num != 0)
				{
					BGW_DebugMgr bGW_DebugMgr = Get(GameContext);
					if (bGW_DebugMgr != null)
					{
						reportEventGameCrash.UserConfig = bGW_DebugMgr.GetUserConfig();
					}
					BGW_GSSdkMgr bGW_GSSdkMgr = BGW_GSSdkMgr.Get(GameContext);
					if (bGW_GSSdkMgr != null)
					{
						reportEventGameCrash.GameSessionId = bGW_GSSdkMgr.GameStartSessionUUID;
					}
				}
			}
			else
			{
				num = 0;
			}
			if (num != 0 && CrashType == GameCrashType.UsharpCrash)
			{
				EventReporter instance = EventReporter.GetInstance(GameContext);
				if (instance != null)
				{
					instance.GameCrash(reportEventGameCrash);
					GSSDKReport.TickCheckUpdate(bSyncFlush: true);
				}
			}
			if (CrashType == GameCrashType.CppCrash)
			{
				reportEventGameCrash.CrashGuid = GSSDKEnv.UserInfo?.UserSession?.CrashGuid ?? "";
				byte[] array = PbEncoding.Encode(reportEventGameCrash);
				if (array != null && array.Length != 0)
				{
					UGSFileHelper.WriteFile(OssGameCrashConextSaveFile, array.ToList());
				}
			}
		}
		catch (Exception ex)
		{
			BGW_LogUtil.LogError("dump save oss game crash fail :" + ex.Message);
		}
		finally
		{
			IsOssReporting = false;
		}
	}

	[MonoPInvokeCallback(typeof(Del_Void))]
	private static void OnHandleSystemError()
	{
		lock (_lock_handle_error)
		{
			if (IsCrashAlready)
			{
				return;
			}
			IsCrashAlready = true;
		}
		try
		{
			BGW_LogUtil.LogError("catche a system error in usharp");
			UObject gameContext = GCHelper.FindRef(FGlobals.GWorld)?.Managed;
			ReportOssGameCrashContext(GameCrashType.CppCrash, gameContext);
		}
		catch (Exception ex)
		{
			BGW_LogUtil.LogError("dump save system crash context fail:" + ex.Message);
		}
	}

	private void InitUSharpExceptionHandler()
	{
		foreach (EUSharpExceptionType item in Enum.GetValues(typeof(EUSharpExceptionType)).Cast<EUSharpExceptionType>())
		{
			USharpExceptionHandler.AddHandleFunc(HandleUSharpInvokeFunctionExcpetion, item, IsMustInGameThread: false);
		}
	}

	private void UnInitUSharpExceptionHandler()
	{
		foreach (EUSharpExceptionType item in Enum.GetValues(typeof(EUSharpExceptionType)).Cast<EUSharpExceptionType>())
		{
			USharpExceptionHandler.RemoveHandleFunc(HandleUSharpInvokeFunctionExcpetion, item);
		}
	}

	public void HandleUSharpInvokeFunctionExcpetion(Exception e)
	{
		HandleUSharpInvokeFunctionExcpetionImpl(e);
	}

	private void HandleUSharpInvokeFunctionExcpetionImpl(Exception e)
	{
		if (!DebugConfig.CantCloseNetConnectWithError)
		{
			UGSE_EngineFuncLib.CloseNetConnection(this);
		}
		BGW_LogUtil.LogError("****ExceptionTraceBeFSMState_GI_Loading_LoadingUIFadeIngin*****\n" + e.GetType().Name + "\n" + e.Message + "\n" + e.ToString() + "\n****ExceptionTraceEnd*****");
		if (IsFatalExceptionHandle)
		{
			BGW_LogUtil.LogError("fatail exception occured already and catch a new exception:" + e.Message);
			return;
		}
		IsFatalExceptionHandle = true;
		string userConfig = GetUserConfig();
		ReportOssGameCrashContext(GameCrashType.UsharpCrash, this, e.StackTrace + "\n\n" + userConfig);
		BGW_SentrySdkHelper.SentryCaptureException(this, e, userConfig);
		_ = new
		{
			data_blob = e.Message + "\n\n" + e.ToString() + "\n\n" + userConfig + "\n",
			json_info = new
			{
				key = "value",
				user_config = userConfig
			},
			report_cls = "CSharpException"
		};
		BGW_GSSdkMgr bGW_GSSdkMgr = BGW_GSSdkMgr.Get(this);
		if (!(bGW_GSSdkMgr != null) || !bGW_GSSdkMgr.IsValidLowLevelFast())
		{
			BGW_LogUtil.LogError("GSSdkMgr is null");
		}
	}

	public string GetCurLevelName()
	{
		UWorld worldFromObj = UGSE_EngineFuncLib.GetWorldFromObj(this);
		if (worldFromObj != null)
		{
			return worldFromObj.GetName();
		}
		return "";
	}

	public string GetUserConfig()
	{
		StringBuilder stringBuilder = new StringBuilder();
		try
		{
			UGSE_EngineFuncLib.IsEditor();
			if (!(BGW_WXLoginMgr.Get(this)?.GetWXLoginName() != ""))
			{
				GetUserNameFromP4Settings();
			}
			else
			{
				BGW_WXLoginMgr.Get(this)?.GetWXLoginName();
			}
			UGameplayStatics.GetPlatformName();
			string buildVersionForDebug = GetBuildVersionForDebug();
			string curLevelName = GetCurLevelName();
			_ = BuildEnv.GitVersion + "\t\t\t" + BuildEnv.BuildTime;
			if (FGlobals.IsEditor)
			{
				stringBuilder.AppendLine("问题由Editor上报");
				stringBuilder.AppendLine("资源版本：\t" + buildVersionForDebug);
			}
			else
			{
				stringBuilder.AppendLine("问题由Build上报");
				stringBuilder.AppendLine("游戏版本：\t" + BGW_LocalDevEnvUtils.GetBuildVersion());
				stringBuilder.AppendLine("打包时间：\t" + BGW_LocalDevEnvUtils.GetBuildTime());
			}
			APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(this);
			if (firstLocalPlayerController != null)
			{
				APawn controlledPawn = firstLocalPlayerController.GetControlledPawn();
				if (controlledPawn != null)
				{
					UBGWFunctionLibraryCS.GetMapInfoFromPlayer(controlledPawn, out var MapName, out var MapAreaId, out var MapAreaName, out var PlayerPos);
					stringBuilder.AppendLine($"地图:{curLevelName}-{MapName}\t区域:{MapAreaId}-{MapAreaName}");
					UObject outer = controlledPawn.GetOuter();
					int num = 0;
					string text = controlledPawn.World.PathName.Split('.').Last();
					if (outer != null)
					{
						foreach (LevelDesc item in GameDBRuntime.GetTBLevelDesc().List)
						{
							if (item.Path == text)
							{
								num = item.Id;
								break;
							}
						}
					}
					FRotator actorRotation = controlledPawn.GetActorRotation();
					if (num > 0)
					{
						stringBuilder.AppendLine($"b.teleportToLevelPosition {num} {(int)PlayerPos.X} {(int)PlayerPos.Y} {(int)PlayerPos.Z} {(int)actorRotation.Pitch} {(int)actorRotation.Yaw} {(int)actorRotation.Roll}");
					}
					else
					{
						stringBuilder.AppendLine($"b.teleportToLevelPositionByName {text} {(int)PlayerPos.X} {(int)PlayerPos.Y} {(int)PlayerPos.Z} {(int)actorRotation.Pitch} {(int)actorRotation.Yaw} {(int)actorRotation.Roll}");
					}
					stringBuilder.AppendLine($"(X={PlayerPos.X.ToString()},Y={PlayerPos.Y.ToString()},Z={PlayerPos.Z.ToString()})");
				}
				else
				{
					stringBuilder.AppendLine("地图和位置信息:\n\t地图:" + curLevelName + "\t无玩家");
				}
			}
		}
		catch (Exception ex)
		{
			stringBuilder.AppendLine(ex.Message + "\n" + ex.StackTrace);
		}
		return stringBuilder.ToString().Trim();
	}

	public string GetUserNameFromP4Settings()
	{
		APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(this);
		if (firstLocalPlayerController != null && firstLocalPlayerController.GetControlledPawn() != null)
		{
			string filePath = USystemLibrary.GetProjectDirectory() + "Saved/Config/WindowsEditor/SourceControlSettings.ini";
			StringBuilder stringBuilder = new StringBuilder();
			GetPrivateProfileString("PerforceSourceControl.PerforceSourceControlSettings", "UserName", "", stringBuilder, 1024, filePath);
			return stringBuilder.ToString();
		}
		return "null";
	}

	[DllImport("kernel32")]
	private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retval, int size, string filePath);

	private string GetBuildVersionForDebug()
	{
		return GSVersionUtil.GetAppVersionWithRevision();
	}

	static BGW_DebugMgr()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGW_DebugMgr)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGW_DebugMgr));
		OssGameCrashConextSaveFile = "/Temp/last_crash.save";
		IsOssReporting = false;
		_lock_oss_reporting = new object();
		_lock_handle_error = new object();
		IsCrashAlready = false;
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGW_DebugMgr");
	}
}
