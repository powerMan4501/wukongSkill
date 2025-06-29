using System;
using System.Collections;
using System.Collections.Generic;
using GSE.GSSdk;
using Gssdk;
using LitJson;
using UnrealEngine.Runtime;

namespace b1;

public class GameSDKManager
{
	public delegate void OnLoginCallback(bool success, string msg);

	private List<GSSdkPlatformChannelSDK> _supportPlatformSDKList = new List<GSSdkPlatformChannelSDK>();

	private GSSdkPlatformChannelSDK _currentUsePlatformSDK;

	private UObject Context;

	private DateTime _loginStartTime;

	private int _loginTimeOut = 15;

	private SDKLoginStepStatus _sdkLoginStepStatus;

	private OnLoginCallback _loginCallback;

	public readonly GSSdkServerDirState ServerDirState = new GSSdkServerDirState();

	private AuthLoginRes GSSdkAuthRsp = new AuthLoginRes();

	private readonly JsonData EmptyJsonData = JsonMapper.ToObject("{}");

	private JsonData UserSDKJsonConfig;

	private int GSSdkLoginFailTimes;

	private const int GSSdkMaxLoginFailTryTimes = 3;

	public GSSdkPlatformChannelSDK CurrentChannelSDK => _currentUsePlatformSDK;

	public bool IsLoginIng
	{
		get
		{
			if (_sdkLoginStepStatus != SDKLoginStepStatus.SDK_LOGIN_STEP_PLATFORM_LOGIN)
			{
				return _sdkLoginStepStatus == SDKLoginStepStatus.SDK_LOGIN_STEP_GSSDK_LOGIN;
			}
			return true;
		}
	}

	public bool IsLoginSuccess => _sdkLoginStepStatus == SDKLoginStepStatus.SDK_LOGIN_STEP_SUCCESS;

	public string UserGameAuthToken => GSSdkAuthRsp.GameToken;

	public bool IsUserSDKJsonConfigLoaded => UserSDKJsonConfig != null;

	public GameSDKManager(UObject context)
	{
		Context = context;
		BGW_LogUtil.LogShipping($"type1:{UBGWOnlineSubsystem.GetSubsystemType()}, type2:{DebugConfig.GSSdkLoginChannel}");
		if (!B1Global.GIsGameReleasedReally_Just4DevSimulation)
		{
			AddSupportPlatformSDK(new GameSciChannelSDK(context));
		}
		FPlatformProperties.GetPlatform().ToString();
		if (UBGWOnlineSubsystem.GetSubsystemType() == EBGWSubsystemType.Steam)
		{
			AddSupportPlatformSDK(new SteamChannelSDK(context));
		}
		if (UBGWOnlineSubsystem.GetSubsystemType() == EBGWSubsystemType.Tencent)
		{
			AddSupportPlatformSDK(new WeGameChannelSDK(context));
		}
		if (UBGWOnlineSubsystem.GetSubsystemType() == EBGWSubsystemType.Epic)
		{
			AddSupportPlatformSDK(new EpicChannelSDK(context));
		}
	}

	public bool SetCurrentUseSDK(string LoginSdkPlatformName)
	{
		BGW_LogUtil.LogShipping($"Set type:{LoginSdkPlatformName}, sub type:{UBGWOnlineSubsystem.GetSubsystemType()}, config type:{DebugConfig.GSSdkLoginChannel}");
		for (int i = 0; i < _supportPlatformSDKList.Count; i++)
		{
			if (_supportPlatformSDKList[i].Name() == LoginSdkPlatformName)
			{
				_currentUsePlatformSDK = _supportPlatformSDKList[i];
				return true;
			}
		}
		throw new NotImplementedException("gssdk current platform：" + LoginSdkPlatformName + " is not registered ... GameSDKManager is not usable ...");
	}

	private bool AddSupportPlatformSDK(GSSdkPlatformChannelSDK platform)
	{
		for (int i = 0; i < _supportPlatformSDKList.Count; i++)
		{
			if (_supportPlatformSDKList[i].Name() == platform.Name())
			{
				BGW_LogUtil.LogError("gssdk register platform sdk repeat with name:" + platform.Name());
				return false;
			}
		}
		_supportPlatformSDKList.Add(platform);
		BGW_LogUtil.LogShipping("reg plt name:" + platform.Name() + ", cfg type:" + DebugConfig.GSSdkLoginChannel);
		return true;
	}

	public void SetLoginStepStatus(SDKLoginStepStatus status, string error_msg = "")
	{
		if (_sdkLoginStepStatus != status)
		{
			_sdkLoginStepStatus = status;
		}
		else
		{
			BGW_LogUtil.LogError($"gssdk set login step status set error same status:{status}");
		}
	}

	private void UpdateCheckPlatformLoginStatus()
	{
		switch (_currentUsePlatformSDK.CurrentLoginStep)
		{
		case PlatformLoginStep.LOGIN_ING:
			_currentUsePlatformSDK.LoginStepWaitCheck();
			break;
		case PlatformLoginStep.LOGIN_FAIL:
			OnFinalLoginFail("gssdk platform login fail");
			break;
		case PlatformLoginStep.LOGIN_SUCCESS:
			GSSDKEnv.SetUserAuthChannelVerifyInfo(_currentUsePlatformSDK.GetGSSdkChannel(), _currentUsePlatformSDK.GetGSSdkSubChannel(), _currentUsePlatformSDK.GetLoginUserId());
			StartGSSdkLogin();
			break;
		case PlatformLoginStep.LOGIN_INIT:
			break;
		}
	}

	private void OnFinalLoginFail(string ErrMsg)
	{
		SetLoginStepStatus(SDKLoginStepStatus.SDK_LOGIN_STEP_FAIL, ErrMsg);
		_loginCallback?.Invoke(success: false, ErrMsg);
		_loginCallback = null;
	}

	private void OnFinalLoginSuccess()
	{
		SetLoginStepStatus(SDKLoginStepStatus.SDK_LOGIN_STEP_SUCCESS, "login success");
		_loginCallback?.Invoke(success: true, "platform login success");
		_loginCallback = null;
	}

	private int GetMaxLoginWaitTimeSeconds()
	{
		return CurrentChannelSDK.GetMaxWaitPlatformLoginSeconds() + 60;
	}

	public void UpdateTickLowHz()
	{
		if (IsLoginIng)
		{
			if ((DateTime.Now - _loginStartTime).TotalSeconds > (double)GetMaxLoginWaitTimeSeconds())
			{
				OnFinalLoginFail($"gssdk login timeout > {GetMaxLoginWaitTimeSeconds()}s");
				return;
			}
			if (_sdkLoginStepStatus == SDKLoginStepStatus.SDK_LOGIN_STEP_PLATFORM_LOGIN)
			{
				UpdateCheckPlatformLoginStatus();
				return;
			}
			_ = _sdkLoginStepStatus;
			_ = 2;
		}
	}

	public void Login(OnLoginCallback CallBack)
	{
		if (IsLoginIng)
		{
			BGW_LogUtil.LogError("gssdk is login ing ...");
			return;
		}
		SetLoginStepStatus(SDKLoginStepStatus.SDK_LOGIN_STEP_PLATFORM_LOGIN);
		_currentUsePlatformSDK.CheckStartLogin();
		_loginStartTime = DateTime.Now;
		_loginCallback = CallBack;
	}

	public string GetUserSDKJsonConfigKeyValue(string Key, string DefaultVal = "")
	{
		JsonData userSDKJsonConfig = GetUserSDKJsonConfig();
		IDictionary dictionary = userSDKJsonConfig;
		if (dictionary != null && dictionary.Contains(Key))
		{
			return userSDKJsonConfig[Key].ToString();
		}
		return DefaultVal;
	}

	public JsonData GetUserSDKJsonConfig()
	{
		if (UserSDKJsonConfig == null)
		{
			return EmptyJsonData;
		}
		return UserSDKJsonConfig;
	}

	public void UpdateAuthInfo(AuthLoginRes authRsp)
	{
		GSSdkAuthRsp = authRsp;
		string gSSdkServerConfigString = BGW_LocalDevEnvUtils.GetGSSdkServerConfigString(authRsp.UserJsonConfig, authRsp.Skey);
		if (gSSdkServerConfigString.Length > 0 && gSSdkServerConfigString.StartsWith("{") && gSSdkServerConfigString.EndsWith("}"))
		{
			try
			{
				JsonData userSDKJsonConfig = JsonMapper.ToObject(gSSdkServerConfigString);
				UserSDKJsonConfig = userSDKJsonConfig;
			}
			catch (Exception ex)
			{
				BGW_LogUtil.LogError("gssdk user parse json config fail:" + gSSdkServerConfigString + " msg:" + ex.Message);
			}
		}
		else
		{
			UserSDKJsonConfig = EmptyJsonData;
		}
		GSSDKEnv.SetServiceSKey(authRsp.Skey, authRsp.SkeyExpiredTime);
		GSSDKEnv.SetUserAuthAid((ulong)authRsp.AuthResult.Aid);
	}

	public bool GSSdkAuthAndFetchServerList()
	{
		if (CurrentChannelSDK.Name() == "debug")
		{
			OnAuthLoginResponse(0, "gssdk debug success", ((DebugDevChannelSDK)CurrentChannelSDK).GetGSSdkLoginDirResponse());
			return true;
		}
		return GSSDKRpc.AuthLoginDir(new AuthLoginDirReq
		{
			UserKey = GSSDKEnv.UserKey,
			Verify = new AuthUserChannelVerify
			{
				ChannelId = _currentUsePlatformSDK.GetGSSdkChannel(),
				Token = _currentUsePlatformSDK.GetGSSdkPlatformLoginChannelToken(),
				SubChannel = _currentUsePlatformSDK.GetGSSdkSubChannel(),
				ChannelUid = _currentUsePlatformSDK.GetLoginUserId()
			}
		}, OnAuthLoginResponse);
	}

	private void OnAuthLoginResponse(int ErrCode, string msg, AuthLoginDirRes rs)
	{
		if (ErrCode == 0)
		{
			if (rs.Ret.Code == GssdkErrCode.Success)
			{
				GSSDKReport.TrackUser();
				UpdateAuthInfo(rs.Login);
				ServerDirState.UpdateServerList(rs.Dir);
			}
			OnGSSdkAuthDirStatusUpdate(rs.Ret.Code == GssdkErrCode.Success, rs.Ret.Msg);
		}
		else
		{
			BGW_LogUtil.LogError($"auth dir http code fail:{ErrCode} msg:{msg}");
			OnGSSdkAuthDirStatusUpdate(Success: false, "network fail", IsNetWorkFail: true);
		}
	}

	private void OnGSSdkAuthDirStatusUpdate(bool Success, string ErrMsg, bool IsNetWorkFail = false)
	{
		if (Success)
		{
			OnFinalLoginSuccess();
			return;
		}
		BGW_LogUtil.LogError($"gssdk auth dir login fail msg:'{ErrMsg}' is network fail:{IsNetWorkFail} try prog:{GSSdkLoginFailTimes}/{3}");
		GSSdkLoginFailTimes++;
		if (IsNetWorkFail && GSSdkLoginFailTimes < 3)
		{
			StartGSSdkLogin();
		}
		else
		{
			OnFinalLoginFail("gssdk login fail");
		}
	}

	private void StartGSSdkLogin()
	{
		SetLoginStepStatus(SDKLoginStepStatus.SDK_LOGIN_STEP_GSSDK_LOGIN);
		GSSdkAuthAndFetchServerList();
	}
}
