using System;
using System.IO;
using CommB1;
using GSE.OnlineBase;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGW_CETestGameMgr")]
public class BGW_CETestGameMgr : GameInstanceSystemBaseUObj
{
	public class CETestUserConfig
	{
		public string Role = "";

		public int GMFlags = 1;

		public string FileMd5Check = "";

		public bool KeepArchive;

		public string MiscOptions = "";

		public override string ToString()
		{
			return $"Role: {Role} GMFlags:{GMFlags} FileMd5Check:{FileMd5Check}";
		}
	}

	public class CETestServerConfig
	{
		public string CurrentAppBuildRevision = "0";

		public bool LimitUserLogin;

		public DateTime OpenLoginBeginTime = DateTime.Parse("2018-08-20 10:00:00");

		public DateTime OpenLoginEndTime = DateTime.Parse("2030-08-20 10:00:00");

		public DateTime ArchiveMustCreateAfterTime = DateTime.Parse("2018-08-20 10:00:00");

		public bool LimitUseGM = true;

		public bool LimitConsoleUseGM = true;

		public string SendUserMessage = "";

		public string SendUserMessageRevision = "0";

		public string KickOffUserRevision = "";

		public bool ServerEnableCETesting;

		public override string ToString()
		{
			return $"ServerEnableCETesting: {ServerEnableCETesting}, CurrentAppBuildRevision: {CurrentAppBuildRevision}, LimitUserLogin: {LimitUserLogin}, OpenLoginBeginTime: {OpenLoginBeginTime}, OpenLoginEndTime: {OpenLoginEndTime}, ArchiveMustCreateAfterTime: {ArchiveMustCreateAfterTime}, LimitUseGM: {LimitUseGM}, SendUserMessage: {SendUserMessage}, SendUserMessageRevision: {SendUserMessageRevision}, KickOffUserRevision: {KickOffUserRevision}";
		}
	}

	private CETestServerConfig ServerConfig;

	private CETestUserConfig UserConfig;

	private bool bDelayCheckEnterGame;

	private uint LastCheckBiuVersionTimeStamp;

	private string KickOffRevisionFlag = "";

	private DateTime QuitGameDateTime = DateTime.MaxValue;

	private bool DelayQuitGameFlag;

	private bool IsCheckMd5File;

	public override bool bTickEnabled => true;

	public static bool EnableCETesting
	{
		get
		{
			if (DebugConfig.GSSdkEnableCETesting)
			{
				return !B1Global.GIsGameReleasedReally_Just4DevSimulation;
			}
			return false;
		}
	}

	public static BGW_CETestGameMgr Get(UObject WorldContext)
	{
		return BGWGameInstanceCS.GetObject<BGW_CETestGameMgr>(WorldContext);
	}

	public override void OnInit()
	{
	}

	public void OnLocalUserLoginFinish(bool bSuccess)
	{
	}

	private void CheckVersionConfigUpdate()
	{
		BGW_GSSdkMgr bGW_GSSdkMgr = BGW_GSSdkMgr.Get(this);
		if (!bGW_GSSdkMgr.IsServerJsonConfigLoaded)
		{
			return;
		}
		if (ServerConfig == null)
		{
			ServerConfig = new CETestServerConfig();
		}
		try
		{
			ServerConfig.CurrentAppBuildRevision = bGW_GSSdkMgr.GetServerExtendJsonConfigKeyValue("CurrentAppBuildRevision", "0");
			ServerConfig.LimitUserLogin = StringParseHelper.SafeToLower(bGW_GSSdkMgr.GetServerExtendJsonConfigKeyValue("LimitUserLogin", "false", CheckUseUserOverride: true)) == "true";
			if (DateTime.TryParse(bGW_GSSdkMgr.GetServerExtendJsonConfigKeyValue("OpenLoginBeginTime", "2018-08-20 10:00:00"), out var result))
			{
				ServerConfig.OpenLoginBeginTime = result;
			}
			if (DateTime.TryParse(bGW_GSSdkMgr.GetServerExtendJsonConfigKeyValue("OpenLoginEndTime", "2030-08-20 10:00:00"), out result))
			{
				ServerConfig.OpenLoginEndTime = result;
			}
			if (DateTime.TryParse(bGW_GSSdkMgr.GetServerExtendJsonConfigKeyValue("ArchiveMustCreateAfterTime", "2018-08-20 10:00:00"), out result))
			{
				ServerConfig.ArchiveMustCreateAfterTime = result;
			}
			ServerConfig.LimitUseGM = StringParseHelper.SafeToLower(bGW_GSSdkMgr.GetServerExtendJsonConfigKeyValue("LimitUseGM", "true")) == "true";
			ServerConfig.LimitConsoleUseGM = StringParseHelper.SafeToLower(bGW_GSSdkMgr.GetServerExtendJsonConfigKeyValue("LimitConsoleUseGM", "true")) == "true";
			ServerConfig.ServerEnableCETesting = StringParseHelper.SafeToLower(bGW_GSSdkMgr.GetServerExtendJsonConfigKeyValue("ServerEnableCETesting", "false", CheckUseUserOverride: true)) == "true";
			ServerConfig.SendUserMessage = bGW_GSSdkMgr.GetServerExtendJsonConfigKeyValue("SendUserMessage");
			ServerConfig.SendUserMessageRevision = bGW_GSSdkMgr.GetServerExtendJsonConfigKeyValue("SendUserMessageRevision");
			ServerConfig.KickOffUserRevision = bGW_GSSdkMgr.GetServerExtendJsonConfigKeyValue("KickOffUserRevision");
		}
		catch (Exception ex)
		{
			BGW_LogUtil.LogError("gssdk server config fail msg:" + ex.Message);
		}
	}

	public void OnGSSdkUserLoginFinish(bool bSuccess, string Msg)
	{
		CheckVersionConfigUpdate();
		if (bSuccess)
		{
			if (BGW_GSSdkMgr.Get(this).IsGSSdkUserJsonConfigLoaded)
			{
				UserConfig = new CETestUserConfig();
				UserConfig.Role = BGW_GSSdkMgr.Get(this).GetUserJsonConfigKeyValue("Role");
				UserConfig.GMFlags = BGW_GSSdkMgr.Get(this).GetUserGMIntFlags();
				UserConfig.FileMd5Check = BGW_GSSdkMgr.Get(this).GetUserJsonConfigKeyValue("FileMd5Check");
				UserConfig.KeepArchive = BGW_GSSdkMgr.Get(this).GetUserJsonConfigKeyValue("KeepArchive") == "true";
				UserConfig.MiscOptions = BGW_GSSdkMgr.Get(this).GetUserJsonConfigKeyValue("MiscOptions");
			}
			if (CheckUserLoginSuccessPreEnterGameMainMenu())
			{
				EnterGameMainMenu();
			}
			else
			{
				BGW_LogUtil.LogError("CheckUserLoginSuccessPreEnterGameMainMenu fail, need retry");
			}
		}
		else
		{
			FMessage.OpenDialog("CE SDK登录失败:'" + Msg + "', 影响CE相关功能 , 请尝试重新登录~", "GSSDK 登录");
		}
	}

	private bool CheckUserLoginSuccessPreEnterGameMainMenu()
	{
		if (ServerConfig == null || UserConfig == null)
		{
			BGW_LogUtil.LogError("CheckUserLoginSuccessPreEnterGameMainMenu check server config is null , wait a minute ...");
			bDelayCheckEnterGame = true;
			return false;
		}
		if (!ServerConfig.ServerEnableCETesting)
		{
			BGW_LogUtil.LogError("CheckUserLoginSuccessPreEnterGameMainMenu server disable cetesting mode skip ce check logic ...");
			return true;
		}
		DateTime now = DateTime.Now;
		if (ServerConfig.LimitUserLogin && !UserConfig.Role.Contains("QA"))
		{
			if (now < ServerConfig.OpenLoginBeginTime)
			{
				TimeSpan timeSpan = ServerConfig.OpenLoginBeginTime - now;
				FMessage.OpenDialog(string.Format("抱歉, 您来早了, 服务器开放时间是:{0}  -  {1} , 剩余等待时间: {2}h {3}m {4}s", ServerConfig.OpenLoginBeginTime.ToString("yyyy-MM-dd HH:mm:ss"), ServerConfig.OpenLoginEndTime.ToString("yyyy-MM-dd HH:mm:ss"), timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds));
				bDelayCheckEnterGame = true;
				return false;
			}
			if (now > ServerConfig.OpenLoginEndTime)
			{
				BGW_LogUtil.LogError("server is closed for cetesting");
				FMessage.OpenDialog("抱歉, 您来晚了, 服务器已经停服 , 公告开放时间是:" + ServerConfig.OpenLoginBeginTime.ToString("yyyy-MM-dd HH:mm:ss") + " - " + ServerConfig.OpenLoginEndTime.ToString("yyyy-MM-dd HH:mm:ss"));
				UGSE_EngineFuncLib.QuitGame(this);
				return false;
			}
		}
		if (!UserConfig.KeepArchive)
		{
			CheckCleanArchive(ServerConfig.ArchiveMustCreateAfterTime.AddMinutes(-3.0));
		}
		return true;
	}

	private bool HaveExpireArchive(DateTime ArchiveCreateMinTime)
	{
		foreach (ArchiveSummaryData item in BGW_GameArchiveMgr.Get(this).LoadArchiveInfoList())
		{
			DateTime localDateTime = DateTimeOffset.FromUnixTimeSeconds((long)item.CreateTime).LocalDateTime;
			if (localDateTime < ArchiveCreateMinTime)
			{
				SysLogUtil.ARCHIVE.LogInfo(string.Format("Expire ArchiveExist, ArchiveCreateTime:{0}, CreateTimeStr:{1}, ServerConfigTime:{2}", item.CreateTime, localDateTime.ToString("yyyy-MM-dd HH:mm:ss"), ArchiveCreateMinTime.ToString("yyyy-MM-dd HH:mm:ss")));
				return true;
			}
		}
		return false;
	}

	public void CheckCleanArchive(DateTime ArchiveCreateMinTime)
	{
		if (HaveExpireArchive(ArchiveCreateMinTime))
		{
			BGW_GameArchiveMgr.Get(this).GMClearAllArchive("CE Clean Archive");
		}
	}

	public void EnterGameMainMenu()
	{
		bDelayCheckEnterGame = false;
		if (DebugConfig.GSSdkLoginChannel == "gamesci")
		{
			BGW_EventCollection.Get(this).Evt_TriggerWXLoginSuccess();
		}
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	private void CheckBuiServerAdminOperation()
	{
		DateTime now = DateTime.Now;
		if (DelayQuitGameFlag)
		{
			if (now > QuitGameDateTime)
			{
				FMessage.OpenDialog("抱歉, 游戏即将关闭 。");
				UGSE_EngineFuncLib.QuitGame(this);
			}
		}
		else
		{
			if (!ServerConfig.ServerEnableCETesting)
			{
				return;
			}
			if (now > ServerConfig.OpenLoginEndTime && UserConfig != null)
			{
				BGW_LogUtil.LogError("server is closed for cetesting");
				FMessage.OpenDialog("抱歉, 服务器即将按期停服 , 公告开放时间是:" + ServerConfig.OpenLoginBeginTime.ToString("yyyy-MM-dd HH:mm:ss") + " - " + ServerConfig.OpenLoginEndTime.ToString("yyyy-MM-dd HH:mm:ss") + " , 60秒后游戏会自动关闭,请及时保存数据. 留意群内通知");
				QuitGameDateTime = DateTime.Now.AddMinutes(1.0);
				DelayQuitGameFlag = true;
			}
			if (!string.IsNullOrEmpty(ServerConfig.KickOffUserRevision))
			{
				if (string.IsNullOrEmpty(KickOffRevisionFlag))
				{
					KickOffRevisionFlag = ServerConfig.KickOffUserRevision;
				}
				else if (KickOffRevisionFlag != ServerConfig.KickOffUserRevision)
				{
					FMessage.OpenDialog("抱歉, 由于管理员操作, 服务器需要紧急停服, , 60秒后游戏会自动关闭,请及时保存数据, 留意群内通知, 可尝试重新登录~");
					QuitGameDateTime = DateTime.Now.AddMinutes(1.0);
					DelayQuitGameFlag = true;
				}
			}
			if (!string.IsNullOrEmpty(ServerConfig.SendUserMessage) && !string.IsNullOrEmpty(ServerConfig.SendUserMessageRevision))
			{
				string path = FPaths.Combine(FPaths.ProjectSavedDir, "cetest.msg.rev");
				try
				{
					string text = "";
					if (File.Exists(path))
					{
						text = File.ReadAllText(path);
					}
					if (text != ServerConfig.SendUserMessageRevision)
					{
						File.WriteAllText(path, ServerConfig.SendUserMessageRevision);
						FMessage.OpenDialog("服务器公告:" + ServerConfig.SendUserMessage);
					}
				}
				catch (Exception ex)
				{
					BGW_LogUtil.LogError("write msg rev ex:" + ex.Message);
				}
			}
			if (CheckAppBuildRevisionUpgrade(this, ServerConfig.CurrentAppBuildRevision))
			{
				FMessage.OpenDialog("检测到新的构建版本:" + ServerConfig.CurrentAppBuildRevision + ", 请关闭客户端更新P4到新的版本!");
			}
		}
	}

	private void TickCheckConditionEvery30s(bool bForceCheck = false)
	{
		uint unixTimeStamp = LocalTime.GetUnixTimeStamp();
		if (!bForceCheck && unixTimeStamp < LastCheckBiuVersionTimeStamp + 30)
		{
			return;
		}
		LastCheckBiuVersionTimeStamp = unixTimeStamp;
		BGW_GSSdkMgr.Get(this).StartGSSdkVersionCheckOnlyNoRetry(CheckVersionConfigUpdate);
		if (ServerConfig != null)
		{
			if (bDelayCheckEnterGame && CheckUserLoginSuccessPreEnterGameMainMenu())
			{
				EnterGameMainMenu();
			}
			else
			{
				CheckBuiServerAdminOperation();
			}
		}
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		TickCheckConditionEvery30s();
	}

	private bool CheckAppBuildRevisionUpgrade(UObject Context, string ServerAppBuildRevision)
	{
		if (GSVersionUtil.GetBuildRevision() <= 0)
		{
			return false;
		}
		if (string.IsNullOrEmpty(ServerAppBuildRevision))
		{
			return false;
		}
		int num = -1;
		try
		{
			num = int.Parse(ServerAppBuildRevision);
		}
		catch
		{
			BGW_LogUtil.LogError("app build revision:" + ServerAppBuildRevision + " parse fail");
			return false;
		}
		if (num <= GSVersionUtil.GetBuildRevision())
		{
			return false;
		}
		if (GSVersionUtil.GetBuildRevision() < num)
		{
			BGW_LogUtil.LogError($"gssdk ce check new verion:{num} checked local version:{GSVersionUtil.GetBuildRevision()} is too low current branch:{BGW_LocalDevEnvUtils.GetBuildBranch()}");
			return true;
		}
		if (!IsCheckMd5File)
		{
			if (!DebugConfig.IsLiteBuild)
			{
				FileMd5Checker.CheckFileMd5(Context);
			}
			IsCheckMd5File = true;
		}
		return false;
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGW_CETestGameMgr");
	}

	static BGW_CETestGameMgr()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGW_CETestGameMgr)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGW_CETestGameMgr));
	}
}
