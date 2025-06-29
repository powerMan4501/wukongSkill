using System;
using UnrealEngine.Runtime;

namespace b1;

public abstract class GSSdkPlatformChannelSDK
{
	protected UObject _context;

	private PlatformLoginStep _currentPlatformLoginStep;

	private DateTime _loginStartTime = DateTime.MinValue;

	private const int MaxLogingWaitTime = 60;

	public PlatformLoginStep CurrentLoginStep => _currentPlatformLoginStep;

	public virtual PlatformAccountAuthStatus PlatformChannelLoginAuthStatus
	{
		get
		{
			BGW_OnlineIdentity bGW_OnlineIdentity = BGW_OnlineIdentity.Get(_context);
			if (bGW_OnlineIdentity == null)
			{
				BGW_LogUtil.LogError("gssdk get platform online identify fail ...");
				return PlatformAccountAuthStatus.LOGIN_NOT_YET;
			}
			EBGWLoginStatus loginStatus = bGW_OnlineIdentity.GetLoginStatus();
			if (loginStatus == EBGWLoginStatus.UsingLocalProfile)
			{
				return PlatformAccountAuthStatus.LOGIN_LOCAL_ACCOUNT;
			}
			bool flag = !string.IsNullOrEmpty(GetGSSdkPlatformLoginChannelToken());
			if (!(loginStatus == EBGWLoginStatus.LoggedIn && flag))
			{
				return PlatformAccountAuthStatus.LOGIN_LOCAL_ACCOUNT;
			}
			return PlatformAccountAuthStatus.LOGIN_CHANNEL_AUTH_ACCOUNT;
		}
	}

	public GSSdkPlatformChannelSDK(UObject Context)
	{
		_context = Context;
	}

	public abstract string Name();

	public void CheckStartLogin()
	{
		_currentPlatformLoginStep = PlatformLoginStep.LOGIN_ING;
		_loginStartTime = DateTime.Now;
		if (PlatformChannelLoginAuthStatus != PlatformAccountAuthStatus.LOGIN_CHANNEL_AUTH_ACCOUNT)
		{
			PlatformLoginForAuthToken();
		}
	}

	protected virtual void PlatformLoginForAuthToken()
	{
		BGW_OnlineIdentity bGW_OnlineIdentity = BGW_OnlineIdentity.Get(_context);
		if (bGW_OnlineIdentity != null && bGW_OnlineIdentity.GetLoginStatus() != EBGWLoginStatus.LoggedIn)
		{
			bGW_OnlineIdentity.Login();
		}
	}

	public virtual int GetMaxWaitPlatformLoginSeconds()
	{
		return 60;
	}

	public void LoginStepWaitCheck()
	{
		if (_currentPlatformLoginStep == PlatformLoginStep.LOGIN_ING)
		{
			if (PlatformChannelLoginAuthStatus == PlatformAccountAuthStatus.LOGIN_CHANNEL_AUTH_ACCOUNT)
			{
				_currentPlatformLoginStep = PlatformLoginStep.LOGIN_SUCCESS;
			}
			else if ((DateTime.Now - _loginStartTime).TotalSeconds > (double)GetMaxWaitPlatformLoginSeconds())
			{
				BGW_LogUtil.LogError($"gssdk platform login wait timeout with check cond {(DateTime.Now - _loginStartTime).TotalSeconds} > {GetMaxWaitPlatformLoginSeconds()} ");
				_currentPlatformLoginStep = PlatformLoginStep.LOGIN_FAIL;
			}
		}
	}

	public virtual string GetLoginUserId()
	{
		return BGW_OnlineIdentity.Get(_context).SafeGetUniquePlayerId();
	}

	public virtual string GetLoginUserName()
	{
		return BGW_OnlineIdentity.Get(_context).SafeGetPlayerNickname();
	}

	public virtual string GetGSSdkPlatformLoginChannelToken()
	{
		return BGW_OnlineIdentity.Get(_context).GetAuthToken();
	}

	public abstract string GetGSSdkChannel();

	public virtual string GetGSSdkSubChannel()
	{
		return "";
	}
}
