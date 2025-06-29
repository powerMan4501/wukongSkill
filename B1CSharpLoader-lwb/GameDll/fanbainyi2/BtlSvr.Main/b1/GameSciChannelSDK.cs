using UnrealEngine.Runtime;

namespace b1;

public class GameSciChannelSDK : GSSdkPlatformChannelSDK
{
	public override PlatformAccountAuthStatus PlatformChannelLoginAuthStatus
	{
		get
		{
			if (BGW_WXLoginMgr.Get(_context).GetWXLoginId().Length <= 0)
			{
				return PlatformAccountAuthStatus.LOGIN_NOT_YET;
			}
			return PlatformAccountAuthStatus.LOGIN_CHANNEL_AUTH_ACCOUNT;
		}
	}

	public GameSciChannelSDK(UObject ctx)
		: base(ctx)
	{
	}

	public override string Name()
	{
		return "gamesci";
	}

	protected override void PlatformLoginForAuthToken()
	{
	}

	public override string GetGSSdkChannel()
	{
		return "gamesci";
	}

	public override string GetGSSdkPlatformLoginChannelToken()
	{
		return BGW_WXLoginMgr.Get(_context).GetWXLoginToken();
	}

	public override int GetMaxWaitPlatformLoginSeconds()
	{
		return 108000;
	}

	public override string GetLoginUserName()
	{
		return BGW_WXLoginMgr.Get(_context).GetWXLoginName() ?? "";
	}

	public override string GetLoginUserId()
	{
		return BGW_WXLoginMgr.Get(_context).GetWXLoginId() ?? "";
	}
}
