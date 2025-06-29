using System.Text;
using LitJson;
using UnrealEngine.Runtime;

namespace b1;

public static class BGW_GSAutoTestUtil
{
	public static string GSAutoTestLogin(UObject WorldContext, string UserName, string PassWord)
	{
		BIS_AutoTestManagerV2.Get(WorldContext).WXLoginSuccess = false;
		string requestUrl = "http://gslogin.b1.gamesci.com.cn:19912/InfraGateImpl/LoginWithAcc?uname=" + UserName + "&passwd=" + PassWord;
		BGW_AsyncTaskMgr.Get(WorldContext).HttpRequestAsync(requestUrl, "GET", null, null, delegate(int httpStatus, byte[] resultBody)
		{
			JsonData jsonData = JsonMapper.ToObject(new JsonReader(Encoding.UTF8.GetString(resultBody)));
			string text = jsonData["code"].ToString();
			jsonData["msg"].ToString();
			JsonData jsonData2 = jsonData["info"];
			if (text == "0" && jsonData2 != null)
			{
				string userName = jsonData2["account"].ToString();
				string userNickName = jsonData2["username"].ToString();
				string gSSdkToken = jsonData["gssdk_token"].ToString();
				BGUFuncLibWXLogin.QywxLoginSuccessByParams(WorldContext, new BGUFuncLibWXLogin.QywxLoginParam
				{
					UserNickName = userNickName,
					UserName = userName,
					GSSdkToken = gSSdkToken
				});
				BIS_AutoTestManagerV2.Get(WorldContext).WXLoginSuccess = true;
			}
		});
		return "";
	}

	public static void GSAutoTestOpenLevelById(UObject WorldContext, int LevelId)
	{
		GameDBRuntime.FastGetLevelDesc(LevelId);
	}

	public static void GSAutoTestOpenLevelByName(UObject WorldContext, string LevelName)
	{
	}
}
