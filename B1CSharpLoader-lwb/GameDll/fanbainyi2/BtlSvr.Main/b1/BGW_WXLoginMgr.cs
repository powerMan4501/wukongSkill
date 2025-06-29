using System;
using System.Collections;
using System.Security.Cryptography;
using System.Text;
using LitJson;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGW_WXLoginMgr")]
public class BGW_WXLoginMgr : GameInstanceSystemBaseUObj
{
	private string WXLoginName = "";

	private string WXLoginId = "";

	public string WXLoginTime = "2022-02-01 12:00:00";

	public string WXVersion = "";

	public bool WXIsGM;

	public JsonData UserJsonConfig;

	private bool IsCheckLoginName = true;

	private string Salt = "gamesci";

	private string WXLoginSDKToken = "";

	public override bool bTickEnabled => true;

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	private string CalAuthTokenMD5(string Uid, string Ts)
	{
		string s = Uid + "." + Salt + "." + Ts;
		byte[] array = MD5.Create().ComputeHash(Encoding.UTF8.GetBytes(s));
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < array.Length; i++)
		{
			stringBuilder.Append(array[i].ToString("x2"));
		}
		return stringBuilder.ToString();
	}

	private void CheckAuthByEnvironmentVariable()
	{
		if (DebugConfig.NeedLauncher && string.IsNullOrEmpty(WXLoginId))
		{
			string text = Environment.GetEnvironmentVariable("uid");
			string environmentVariable = Environment.GetEnvironmentVariable("ts");
			string environmentVariable2 = Environment.GetEnvironmentVariable("token");
			if (string.IsNullOrEmpty(text) || string.IsNullOrEmpty(environmentVariable) || string.IsNullOrEmpty(environmentVariable2))
			{
				BGW_LogUtil.LogError("Uid == null || Ts == null || Token == null");
				text = "";
			}
			else if (CalAuthTokenMD5(text, environmentVariable) != environmentVariable2)
			{
				BGW_LogUtil.LogError("OutputToken != Token");
				text = "";
			}
			if (string.IsNullOrEmpty(text))
			{
				FMessage.OpenDialog("请通过启动器启动游戏 (Pls start game with launcher)");
				UGSE_EngineFuncLib.QuitGame(this);
			}
			else
			{
				SetWXLoginId(text);
				SetWXLoginName(text);
			}
		}
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (!FGlobals.IsEditor && IsCheckLoginName)
		{
			_ = UGameplayStatics.GetCurrentLevelName(this) == "WXLogin_P";
		}
	}

	public bool IsLogin()
	{
		CheckAuthByEnvironmentVariable();
		return WXLoginId.Length > 0;
	}

	public void SetWXLoginUserConfig(JsonData JsonConfigObj)
	{
		UserJsonConfig = JsonConfigObj;
	}

	public string GetUserConfigKeyValue(string Key, string DefaultVal = "")
	{
		if (UserJsonConfig != null && ((IDictionary)UserJsonConfig).Contains((object)Key))
		{
			return UserJsonConfig[Key].ToString();
		}
		return DefaultVal;
	}

	public string GetWXLoginName()
	{
		CheckAuthByEnvironmentVariable();
		return WXLoginName;
	}

	public void SetWXLoginName(string Name)
	{
		WXLoginName = Name;
	}

	public void SetWXLoginId(string id)
	{
		WXLoginId = id;
	}

	public void SetWXLoginSDKToken(string Token)
	{
		WXLoginSDKToken = Token;
	}

	public string GetWXLoginToken()
	{
		CheckAuthByEnvironmentVariable();
		return WXLoginSDKToken;
	}

	public string GetWXLoginId()
	{
		CheckAuthByEnvironmentVariable();
		return WXLoginId;
	}

	public void WXSetLoginTime(string LoginTime)
	{
		if (!string.IsNullOrEmpty(LoginTime))
		{
			WXLoginTime = LoginTime;
		}
	}

	public void WXSetIsGM(string IsGM)
	{
		if (IsGM == "1")
		{
			WXIsGM = true;
		}
		else
		{
			WXIsGM = false;
		}
	}

	public void SetWXVersion(string Version)
	{
		if (!string.IsNullOrEmpty(Version))
		{
			WXVersion = Version;
		}
	}

	public static BGW_WXLoginMgr Get(UObject Context)
	{
		return BGWGameInstanceCS.GetObject<BGW_WXLoginMgr>(Context);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGW_WXLoginMgr");
	}

	static BGW_WXLoginMgr()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGW_WXLoginMgr)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGW_WXLoginMgr));
	}
}
