using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGW_DevSecurityMgr")]
public class BGW_DevSecurityMgr : GameInstanceSystemBaseUObj
{
	private BGW_WatchDog WatchDog;

	private BGW_Watermark Watermark;

	private bool ServerConnected;

	private string UserName = "";

	private float fQuitGameCountdown = 10f;

	private bool bShouldQuitGame;

	private const float CfgRandomTimeInterval = 11f;

	private float fNeedRandomOneCountdown;

	private float LowLevelTickCheckCountdown = 1f;

	public static bool HideWatchDogWaterMark;

	public override bool bTickEnabled => true;

	public static BGW_DevSecurityMgr Get(UObject WorldContext)
	{
		return BGWGameInstanceCS.GetObject<BGW_DevSecurityMgr>(WorldContext);
	}

	public BGW_WatchDog GetWatchDog()
	{
		return WatchDog;
	}

	public BGW_Watermark GetWatermak()
	{
		return Watermark;
	}

	private void DelayTickCheckQuitGame()
	{
		if (bShouldQuitGame && fQuitGameCountdown <= 0f)
		{
			UGSE_EngineFuncLib.QuitGame(this);
		}
	}

	private void OnServerLost()
	{
		BGW_LogUtil.LogError("keep alive server is lost here todo logic security !!!");
		if (BGW_LocalDevEnvUtils.GetBuildBranch() == "b1_summer_20240511")
		{
			FMessage.OpenDialog("安全心跳服务器链接失败,请检查网络.");
		}
		else
		{
			FMessage.OpenDialog("当前版本需要在专用网运行, 未检测到专用网络环境, 请检查本地环境是否符合安全规范 ! (Not in a dedicated Netwoking environment, Pls check your device security settings .)");
		}
		UGSE_EngineFuncLib.QuitGame(this);
		bShouldQuitGame = true;
		fQuitGameCountdown = 10f;
	}

	public override void OnInit()
	{
		if (WatchDog == null)
		{
			WatchDog = new BGW_WatchDog();
			Watermark = new BGW_Watermark();
			string kAServerHost = DebugConfig.KAServerHost;
			int kAServerPort = DebugConfig.KAServerPort;
			if (B1Global.GIsGameReleasedReally_Just4DevSimulation && DebugConfig.LQALanguage)
			{
				UserName = "LQA";
				WatchDog.HostName = BGW_LocalDevEnvUtils.GetLocalHostUserName() + "@" + BGW_LocalDevEnvUtils.GetHostName();
				ServerConnected = true;
				WatchDog.SetActive(bEn: false);
			}
			else
			{
				WatchDog.InitEnv(OnServerLost, bStoreLocal: true, kAServerHost, kAServerPort, DebugConfig.KAServerUseTcp);
			}
		}
	}

	public string GetCurLevelName()
	{
		UWorld worldFromObj = UGSE_EngineFuncLib.GetWorldFromObj(this);
		if (worldFromObj != null)
		{
			return StringParseHelper.SafeToLower(worldFromObj.GetName());
		}
		return "";
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (WatchDog == null || WatchDog.ServerIgnoreHeartBeatCheck)
		{
			return;
		}
		WatchDog.UpdateTick(DeltaTime);
		LowLevelTickCheckCountdown -= DeltaTime;
		fNeedRandomOneCountdown -= DeltaTime;
		if (LowLevelTickCheckCountdown > 0f)
		{
			return;
		}
		LowLevelTickCheckCountdown = 1f;
		if (!Watermark.Inited)
		{
			Watermark.Init(this);
		}
		if (WatchDog.wxid.Length == 0)
		{
			BGW_WXLoginMgr bGW_WXLoginMgr = BGW_WXLoginMgr.Get(this);
			if (bGW_WXLoginMgr != null && bGW_WXLoginMgr.IsLogin())
			{
				WatchDog.wxid = bGW_WXLoginMgr.GetWXLoginId();
			}
		}
		string curLevelName = GetCurLevelName();
		if (curLevelName.Contains("tigerforest") || curLevelName.Contains("combat_recording_map") || HideWatchDogWaterMark || WatchDog.ServerHideWaterMark)
		{
			Watermark.HideWatermark();
			return;
		}
		if (!ServerConnected && !WatchDog.LostServer)
		{
			UserName = WatchDog.UserId;
			ServerConnected = true;
			bShouldQuitGame = false;
			fQuitGameCountdown = 10f;
		}
		if (ServerConnected && UserName.Length > 0 && fNeedRandomOneCountdown <= 0f)
		{
			fNeedRandomOneCountdown = 11f;
			string text = WatchDog.UserId;
			if (!string.IsNullOrEmpty(text))
			{
				if (text.Length >= 10)
				{
					text = text.Substring(0, 10);
				}
			}
			else
			{
				text = "";
			}
			Watermark.SetWatermark(UserName, bRandomAngle: true, WatchDog.HostName.ToUpper() + "-" + text, GSVersionUtil.GetAppVersionWithRevision(), WatchDog.UserDynamicKey, WatchDog.wxid);
		}
		if (bShouldQuitGame)
		{
			fQuitGameCountdown -= DeltaTime;
			DelayTickCheckQuitGame();
		}
	}

	public override void OnShutdown()
	{
		base.OnShutdown();
		if (WatchDog != null)
		{
			WatchDog.Close();
			WatchDog = null;
		}
		if (Watermark != null)
		{
			Watermark.Destroy();
			Watermark = null;
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGW_DevSecurityMgr");
	}

	static BGW_DevSecurityMgr()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGW_DevSecurityMgr)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGW_DevSecurityMgr));
	}
}
