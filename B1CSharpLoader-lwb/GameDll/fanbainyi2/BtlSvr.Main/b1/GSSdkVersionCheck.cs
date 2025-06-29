using System;
using System.Collections.Generic;
using GSE.GSSdk;
using Gssdk;
using LitJson;

namespace b1;

public class GSSdkVersionCheck
{
	public delegate void Del_OnVersionCheckFinish(bool bSuccess);

	private int CheckConfigRetryCount;

	private DateTime LastStartCheckConfigTime;

	private int CheckConfigRetryMaxCount = 4;

	private const int CheckConfigTimeoutSeconds = 15;

	private VersionCheckConfigRes VersionServerCheckConfigResult;

	private static readonly JsonData EmptyJsonConfigObj = JsonMapper.ToObject("{}");

	private List<JsonData> LayeredServerJsonConfig;

	private JsonData ExtendServerJsonConfig;

	private Del_OnVersionCheckFinish OnCheckFinishCallback;

	public GSSdkVersionCheckStatus ConfigCheckStatus { get; private set; }

	public bool IsVersionServerConfigIsValid => VersionServerCheckConfigResult != null;

	public void TickCheckVersionConfig()
	{
		if (ConfigCheckStatus == GSSdkVersionCheckStatus.CHECK_ING && (DateTime.Now - LastStartCheckConfigTime).TotalSeconds > 15.0)
		{
			ConfigCheckStatus = GSSdkVersionCheckStatus.CHECK_FAIL;
			BGW_LogUtil.LogError("gssdk verison check config timeout");
		}
		if (ConfigCheckStatus == GSSdkVersionCheckStatus.CHECK_FAIL && CheckConfigRetryCount < CheckConfigRetryMaxCount)
		{
			RetryVersionCheck();
		}
	}

	public JsonData GetVersionServerExtendJsonConfig()
	{
		if (ExtendServerJsonConfig != null)
		{
			return ExtendServerJsonConfig;
		}
		return EmptyJsonConfigObj;
	}

	private void UpdsteServerConfig(VersionCheckConfigRes ConfigRsp)
	{
		if (ConfigRsp == null)
		{
			return;
		}
		List<JsonData> list = new List<JsonData>();
		JsonData extendServerJsonConfig = null;
		try
		{
			string text = $"{GSSDKEnv.UserInfo.ClientSetting.AppVersion}.{GSSDKEnv.UserInfo.ClientSetting.BuildRevision}";
			if (!string.IsNullOrEmpty(ConfigRsp.CurPkgMd5))
			{
				text = text + "." + ConfigRsp.CurPkgMd5;
			}
			for (int i = 0; i < ConfigRsp.ServerJsonConfig.Count; i++)
			{
				if (string.IsNullOrEmpty(ConfigRsp.ServerJsonConfig[i]))
				{
					BGW_LogUtil.LogError($"gssdk get server layer config idx:{i} but json is null or empty");
					continue;
				}
				string gSSdkServerConfigString = BGW_LocalDevEnvUtils.GetGSSdkServerConfigString(ConfigRsp.ServerJsonConfig[i], text);
				try
				{
					list.Add(JsonMapper.ToObject(gSSdkServerConfigString));
				}
				catch (Exception ex)
				{
					BGW_LogUtil.LogError("gssdk layer config parsing fail:" + ex.Message);
				}
			}
			if (string.IsNullOrEmpty(ConfigRsp.JsonExConfig))
			{
				extendServerJsonConfig = EmptyJsonConfigObj;
			}
			else
			{
				string gSSdkServerConfigString2 = BGW_LocalDevEnvUtils.GetGSSdkServerConfigString(ConfigRsp.JsonExConfig, text);
				try
				{
					extendServerJsonConfig = JsonMapper.ToObject(gSSdkServerConfigString2);
				}
				catch (Exception ex2)
				{
					BGW_LogUtil.LogError("gssdk ext server config parsing fail:" + ex2.Message);
				}
			}
			LayeredServerJsonConfig = list;
			ExtendServerJsonConfig = extendServerJsonConfig;
			VersionServerCheckConfigResult = ConfigRsp;
		}
		catch (Exception ex3)
		{
			BGW_LogUtil.LogError("gssdk parse server json config fail ex:" + ex3.Message);
		}
	}

	public List<JsonData> GetVersionServerLayeredJsonConfig()
	{
		return LayeredServerJsonConfig;
	}

	private void OnVersioCheckSuccess(VersionCheckConfigRes VersioCheckRet)
	{
		UpdsteServerConfig(VersioCheckRet);
		foreach (string envSdkServer in VersioCheckRet.EnvSdkServerList)
		{
			if (envSdkServer.Contains("="))
			{
				string[] array = envSdkServer.Split(new char[1] { '=' }, 2);
				if (array.Length == 2)
				{
					GSSDKEnv.SetServiceOverrideHost(array[0].Trim(), array[1].Trim());
				}
			}
		}
	}

	private VersionCheckConfigUserInfo GetCheckConfigUserInfo()
	{
		return new VersionCheckConfigUserInfo
		{
			Env = GSSDKEnv.UserInfo.ClientSetting.Env,
			Platform = GSSDKEnv.UserInfo.DeviceInfo.Platform,
			AppChannel = GSSDKEnv.UserInfo.ClientSetting.AppChannel,
			DeviceId = GSSDKEnv.UserInfo.DeviceInfo.DeviceId,
			LocalIpList = GSSDKEnv.UserInfo.DeviceInfo.LocalIpList,
			DevBranch = GSSDKEnv.UserInfo.ClientSetting.Branch,
			Language = GSSDKEnv.UserInfo.ClientSetting.Language,
			Region = GSSDKEnv.UserInfo.ClientSetting.Region,
			AppVersion = GSSDKEnv.UserInfo.ClientSetting.AppVersion,
			BuildRevision = GSSDKEnv.UserInfo.ClientSetting.BuildRevision
		};
	}

	private bool RetryVersionCheck()
	{
		LastStartCheckConfigTime = DateTime.Now;
		CheckConfigRetryCount++;
		ConfigCheckStatus = GSSdkVersionCheckStatus.CHECK_ING;
		bool num = GSSDKRpc.VersionCheckConfig(new VersionCheckConfigReq
		{
			UserKey = GSSDKEnv.UserKey,
			UserInfo = GetCheckConfigUserInfo()
		}, delegate(int code, string msg, VersionCheckConfigRes ret)
		{
			if (code == 0 && ret != null)
			{
				if (ret.Ret.Code == GssdkErrCode.Success)
				{
					ConfigCheckStatus = GSSdkVersionCheckStatus.CHECK_SUCCESS;
					OnVersioCheckSuccess(ret);
					OnCheckFinishCallback?.Invoke(bSuccess: true);
					return;
				}
				ConfigCheckStatus = GSSdkVersionCheckStatus.CHECK_FAIL;
				BGW_LogUtil.LogError("gssdk check config error status:{0}", ret.Ret.Code);
			}
			else
			{
				ConfigCheckStatus = GSSdkVersionCheckStatus.CHECK_FAIL;
				BGW_LogUtil.LogError("gssdk version check config error:{0} msg:{1}", code, msg);
			}
			OnCheckFinishCallback?.Invoke(bSuccess: false);
		});
		if (!num)
		{
			ConfigCheckStatus = GSSdkVersionCheckStatus.CHECK_FAIL;
			BGW_LogUtil.LogError("gssdk start check version config fail ");
		}
		return num;
	}

	public bool StartVersionCheck(Del_OnVersionCheckFinish OnCheckFinish = null, int MaxRetries = 3)
	{
		if (ConfigCheckStatus == GSSdkVersionCheckStatus.CHECK_ING)
		{
			BGW_LogUtil.LogError("gssdk is check version ing , but request new start checking");
			return false;
		}
		OnCheckFinishCallback = OnCheckFinish;
		CheckConfigRetryMaxCount = MaxRetries;
		return RetryVersionCheck();
	}
}
