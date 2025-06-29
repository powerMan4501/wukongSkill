using System;
using Gssdk;
using UnrealEngine.Runtime;

namespace b1;

public class DebugDevChannelSDK : GSSdkPlatformChannelSDK
{
	private string TempUserId = "temp";

	private UObject WorldContext;

	public static string DevDefaultGameServerAddr = "tcp://192.168.2.60:5400";

	public override PlatformAccountAuthStatus PlatformChannelLoginAuthStatus => PlatformAccountAuthStatus.LOGIN_CHANNEL_AUTH_ACCOUNT;

	private string GetDebugUserBaseName()
	{
		string text = "";
		if (WorldContext != null && !WorldContext.IsNullOrDestroyed())
		{
			BGW_WXLoginMgr bGW_WXLoginMgr = BGW_WXLoginMgr.Get(WorldContext);
			if (bGW_WXLoginMgr != null)
			{
				text = bGW_WXLoginMgr.GetWXLoginId();
			}
		}
		if (string.IsNullOrEmpty(text))
		{
			text = BGW_LocalDevEnvUtils.GetLocalP4UserName();
			if (string.IsNullOrEmpty(text))
			{
				text = BGW_LocalDevEnvUtils.GetLocalIpv4ListStr();
			}
		}
		return text;
	}

	public DebugDevChannelSDK(UObject Context)
		: base(Context)
	{
		WorldContext = Context;
		TempUserId = GetDebugUserBaseName() + "." + DateTime.Now.ToString("MMdd.HHmmss");
	}

	public override string Name()
	{
		return "debug";
	}

	public override string GetGSSdkPlatformLoginChannelToken()
	{
		return "debug:" + TempUserId;
	}

	public static string GetDefaultConnectAddr()
	{
		if (DebugConfig.RoomServerConnectAddr.Length > 0)
		{
			return DebugConfig.RoomServerConnectAddr;
		}
		return DevDefaultGameServerAddr;
	}

	public AuthLoginDirRes GetGSSdkLoginDirResponse()
	{
		AuthLoginDirRes authLoginDirRes = new AuthLoginDirRes();
		authLoginDirRes.Ret = new GssdkRet
		{
			Code = GssdkErrCode.Success,
			Msg = ""
		};
		authLoginDirRes.Login = new AuthLoginRes
		{
			AuthResult = new UserAuthResult
			{
				ChannelUid = GetLoginUserId(),
				Aid = 1L
			}
		};
		authLoginDirRes.Dir = new DirListRes();
		ServerUnit item = new ServerUnit
		{
			ServerId = 1,
			Addr = GetDefaultConnectAddr(),
			Sort = 0
		};
		authLoginDirRes.Login.GameToken = "debug:" + TempUserId;
		authLoginDirRes.Login.UserJsonConfig = "{\"Role\":\"\", \"GMFlags\":\"\",\"TestValue\":false}";
		authLoginDirRes.Dir.ServerList.Add(item);
		return authLoginDirRes;
	}

	public override string GetLoginUserName()
	{
		return GetDebugUserBaseName();
	}

	public override string GetLoginUserId()
	{
		return TempUserId;
	}

	public override string GetGSSdkChannel()
	{
		return "debug";
	}
}
