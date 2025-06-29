using System.Collections;
using System.Collections.Generic;
using GSE.OnlineBase;
using Gssdk;
using LitJson;
using UnrealEngine.Runtime;

namespace GSE.GSSdk;

public static class GSSDKEnv
{
	private const string DEFAULT_DEV_GSSDK_HOST_URL = "http://gssdk.b1.gamesci.com.cn:9812";

	private static string[] envSdkHostList = new string[1] { "http://gssdk.b1.gamesci.com.cn:9812" };

	private static int curEnvValidHostIdx = 0;

	private static Dictionary<string, string> overrideSdkHost = new Dictionary<string, string>();

	public static readonly UserInfo UserInfo = new UserInfo
	{
		UserSession = new UserGameSession(),
		AuthInfo = new UserAuthInfo(),
		ClientSetting = new UserClientSetting(),
		DeviceInfo = new UserDevice()
	};

	public static readonly ReportUserKey UserKey = new ReportUserKey();

	public static GSSDKClient Client = null;

	private static JsonData GSSdkConfigObject = null;

	private static string ServiceSkey = "";

	private static uint ServiceSkeyExpiredTimeStamp = 0u;

	public static string[] SdkServerList => envSdkHostList;

	public static string GetGSSdkLocalBaseFileConfigValue(string Key, string DefaultValue)
	{
		if (GSSdkConfigObject == null)
		{
			return DefaultValue;
		}
		IDictionary gSSdkConfigObject = GSSdkConfigObject;
		if (gSSdkConfigObject != null && gSSdkConfigObject.Contains(Key))
		{
			return GSSdkConfigObject[Key].ToString();
		}
		return DefaultValue;
	}

	private static void UpdateUserKey()
	{
		UserKey.SessionUuid = UserInfo.UserSession.StartSessionUuid;
		UserKey.Aid = UserInfo.AuthInfo.Aid;
		UserKey.Roleid = UserInfo.AuthInfo.Roleid;
		UserKey.DeviceId = UserInfo.DeviceInfo.DeviceId;
		UserKey.DevBranch = UserInfo.ClientSetting.Branch;
		UserKey.Env = UserInfo.ClientSetting.Env;
	}

	public static void SetUserShareArchiveId(string ShareId)
	{
		UserKey.ShareArchiveUuid = ShareId;
	}

	public static void InitFromConfig(HttpRequestDelegate http_delegate, GSSdkEnvironmentContextInitCallback InitCallback)
	{
		Client = new GSSDKClient(http_delegate);
		InitUserInfo();
		InitCallback();
		UpdateUserKey();
	}

	public static void InitUserInfo()
	{
		UserInfo.AuthInfo = new UserAuthInfo
		{
			LoginChannelUid = "",
			LoginChannel = "",
			Aid = 0uL,
			Roleid = 0uL,
			LoginSubChannel = ""
		};
		UserInfo.DeviceInfo = new UserDevice
		{
			DeviceId = "0x1234567890",
			Height = 1920,
			Width = 1080,
			Mac = "0x123456789",
			MemMbTotal = 16000,
			OsVer = "win10",
			OsRawDesc = "win64"
		};
		UserInfo.ClientSetting = new UserClientSetting
		{
			Language = "zh_CN",
			Region = "cn",
			TzOffset = 2880,
			PlayMode = "none"
		};
		UserInfo.UserSession = new UserGameSession();
	}

	public static string GetServiceSKey()
	{
		if (LocalTime.GetUnixTimeStamp() < ServiceSkeyExpiredTimeStamp && ServiceSkey.Length > 0)
		{
			return ServiceSkey;
		}
		return "";
	}

	public static void SetServiceSKey(string Skey, uint SkeyExpiredTimeStamp)
	{
		ServiceSkey = Skey;
		ServiceSkeyExpiredTimeStamp = SkeyExpiredTimeStamp;
	}

	public static void SetUserAuthAid(ulong aid)
	{
		if (aid != 0L && UserInfo.AuthInfo.Aid != aid)
		{
			UserInfo.AuthInfo.Aid = aid;
			GSSDKReport.TrackUser();
		}
	}

	public static void SetUserAuthRoleId(ulong RoleId)
	{
		if (RoleId != 0L && UserInfo.AuthInfo.Aid != RoleId)
		{
			UserInfo.AuthInfo.Aid = RoleId;
			GSSDKReport.TrackUser();
		}
	}

	public static void SetUserAuthChannelVerifyInfo(string LoginChannel, string SubChannel, string LoginUserId)
	{
		bool flag = false;
		if (LoginChannel != UserInfo.AuthInfo.LoginChannel)
		{
			UserInfo.AuthInfo.LoginChannel = LoginChannel;
			flag = true;
		}
		if (UserInfo.AuthInfo.LoginSubChannel != SubChannel)
		{
			UserInfo.AuthInfo.LoginSubChannel = SubChannel;
			flag = true;
		}
		if (UserInfo.AuthInfo.LoginChannelUid != LoginUserId)
		{
			UserInfo.AuthInfo.LoginChannelUid = LoginUserId;
			flag = true;
		}
		if (flag)
		{
			LogHelper.LogInfo("gssdk set user auth channel:" + LoginChannel + " sub chnl:" + SubChannel + " uid:" + LoginUserId);
			GSSDKReport.TrackUser();
		}
	}

	public static string GetServiceUrl(string service, string meth)
	{
		string format = "{0}/{1}ServerImpl/{2}";
		if (overrideSdkHost.TryGetValue(service, out var value))
		{
			return string.Format(format, value, service, meth);
		}
		if (envSdkHostList == null || envSdkHostList.Length == 0)
		{
			LogHelper.LogError("gssdk current sdk host list is empty for service:" + service);
			return null;
		}
		if (curEnvValidHostIdx >= envSdkHostList.Length)
		{
			curEnvValidHostIdx = 0;
		}
		return string.Format(format, envSdkHostList[curEnvValidHostIdx], service, meth);
	}

	public static void SwitchNextEnvSdkHost()
	{
		curEnvValidHostIdx = (curEnvValidHostIdx + 1) % envSdkHostList.Length;
		LogHelper.LogError($"gssdk warnning:switch to next env sdk list:{curEnvValidHostIdx}/{envSdkHostList.Length}");
		GSSDKReport.MonitorAdd(MonEvtCatogray.GSSDK, "SwitchHost", 1L, $"idx={curEnvValidHostIdx}_{envSdkHostList.Length}");
	}

	public static void InitSelectGSSdkDefaultServer()
	{
		string value = "2.";
		if (StringParseHelper.SafeToLower(UserInfo.ClientSetting.Region) == "cn")
		{
			value = "1.";
		}
		List<string> list = new List<string>();
		List<string> list2 = new List<string>();
		for (int i = 0; i < envSdkHostList.Length; i++)
		{
			if (envSdkHostList[i].Contains(value))
			{
				list2.Add(envSdkHostList[i]);
			}
			else
			{
				list.Add(envSdkHostList[i]);
			}
		}
		list2.AddRange(list);
		envSdkHostList = list2.ToArray();
		curEnvValidHostIdx = 0;
	}

	public static void SetEnvServerList(string[] envServerHostList)
	{
		if (envServerHostList.Length != 0)
		{
			LogHelper.LogInfo($"gssdk set env server list:{envServerHostList}");
			envSdkHostList = envServerHostList;
		}
	}

	public static void SetServiceOverrideHost(string service, string host)
	{
		if (overrideSdkHost.ContainsKey(service))
		{
			overrideSdkHost.Remove(service);
		}
		LogHelper.LogInfo("set override service host:" + service + " " + host);
		overrideSdkHost.Add(service, host);
	}
}
