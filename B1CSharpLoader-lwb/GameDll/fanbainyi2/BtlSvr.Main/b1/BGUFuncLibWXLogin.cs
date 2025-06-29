using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using b1.GSFile;
using LitJson;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUFuncLibWXLogin")]
public class BGUFuncLibWXLogin : UBlueprintFunctionLibrary
{
	public delegate void DelQywxQuerySuccessCallBack(JsonData LoginRetData);

	public delegate void DelQywxQueryFailCallBack(int ErrCode, string Msg);

	public class QywxLoginParam
	{
		public string UserName;

		public string UserNickName;

		public string UserIcon;

		public string SdkUid;

		public string GSSdkToken;

		public string LoginTimeLimit_todo_delete;

		public string LoginVersionLimit_todo_delete;

		public string IsGM_todo_delete;
	}

	private static bool _is_summer_special_login_status_passed;

	private static string SummerMagicUserName;

	private static bool GetIpList_IsValid;

	private static IntPtr GetIpList_FunctionAddress;

	private static int GetIpList_ParamsSize;

	private static bool GetIpList_WorldCtx_IsValid;

	private static int GetIpList_WorldCtx_Offset;

	private static bool GetIpList_ReturnValue_IsValid;

	private static int GetIpList_ReturnValue_Offset;

	private static FFieldAddress GetIpList_ReturnValue_PropertyAddress;

	private static bool LoadUserInfo_IsValid;

	private static IntPtr LoadUserInfo_FunctionAddress;

	private static int LoadUserInfo_ParamsSize;

	private static bool LoadUserInfo_WorldCtx_IsValid;

	private static int LoadUserInfo_WorldCtx_Offset;

	private static bool LoadUserInfo_ReturnValue_IsValid;

	private static int LoadUserInfo_ReturnValue_Offset;

	private static FFieldAddress LoadUserInfo_ReturnValue_PropertyAddress;

	private static bool SaveUserInfo_IsValid;

	private static IntPtr SaveUserInfo_FunctionAddress;

	private static int SaveUserInfo_ParamsSize;

	private static bool SaveUserInfo_WorldCtx_IsValid;

	private static int SaveUserInfo_WorldCtx_Offset;

	private static bool SaveUserInfo_val_IsValid;

	private static int SaveUserInfo_val_Offset;

	private static FFieldAddress SaveUserInfo_val_PropertyAddress;

	private static bool SaveUserInfo_ReturnValue_IsValid;

	private static int SaveUserInfo_ReturnValue_Offset;

	private static bool ReadLoginCookie_IsValid;

	private static IntPtr ReadLoginCookie_FunctionAddress;

	private static int ReadLoginCookie_ParamsSize;

	private static bool ReadLoginCookie_WorldCtx_IsValid;

	private static int ReadLoginCookie_WorldCtx_Offset;

	private static bool ReadLoginCookie_ReturnValue_IsValid;

	private static int ReadLoginCookie_ReturnValue_Offset;

	private static FFieldAddress ReadLoginCookie_ReturnValue_PropertyAddress;

	private static bool WriteLoginCookie_IsValid;

	private static IntPtr WriteLoginCookie_FunctionAddress;

	private static int WriteLoginCookie_ParamsSize;

	private static bool WriteLoginCookie_WorldCtx_IsValid;

	private static int WriteLoginCookie_WorldCtx_Offset;

	private static bool WriteLoginCookie_val_IsValid;

	private static int WriteLoginCookie_val_Offset;

	private static FFieldAddress WriteLoginCookie_val_PropertyAddress;

	private static bool WriteLoginCookie_ReturnValue_IsValid;

	private static int WriteLoginCookie_ReturnValue_Offset;

	private static bool QywxLoginSuccess_IsValid;

	private static IntPtr QywxLoginSuccess_FunctionAddress;

	private static int QywxLoginSuccess_ParamsSize;

	private static bool QywxLoginSuccess_WorldCtx_IsValid;

	private static int QywxLoginSuccess_WorldCtx_Offset;

	private static bool QywxLoginSuccess_Params_IsValid;

	private static int QywxLoginSuccess_Params_Offset;

	private static FFieldAddress QywxLoginSuccess_Params_PropertyAddress;

	public static string QYWX_LoginBaseUrl => DebugConfig.DevGamesciLoginServerUrl;

	public static bool GetOptsAsync(UObject WorldContext, DelQywxQuerySuccessCallBack SuccessCallBack = null, DelQywxQueryFailCallBack FailCallBack = null)
	{
		if (WorldContext.IsNullOrDestroyed())
		{
			return false;
		}
		if (BGW_LocalDevEnvUtils.IsSummerMagicRunning)
		{
			JsonData loginRetData = JsonMapper.ToObject("{\"hide_btnc\":\"0\", \"hide_btnd\":\"0\"}");
			SuccessCallBack?.Invoke(loginRetData);
			return true;
		}
		string ipList = GetIpList(WorldContext);
		string requestUrl = QYWX_LoginBaseUrl + "/InfraGateImpl/GetOpts?local_ip=" + ipList;
		return BGW_AsyncTaskMgr.Get(WorldContext).HttpFetchJson(requestUrl, PostMethod: false, delegate(int ErrCode, JsonData RetData, string Msg)
		{
			if (ErrCode != 0)
			{
				FailCallBack?.Invoke(ErrCode, Msg);
			}
			else
			{
				SuccessCallBack?.Invoke(RetData);
			}
		}, null, null, 7);
	}

	public static bool GetQRInfoAsync(UObject WorldContext, bool bIsQuickMode, DelQywxQuerySuccessCallBack SuccessCallBack = null, DelQywxQueryFailCallBack FailCallBack = null)
	{
		string text = "";
		if (bIsQuickMode)
		{
			text = WebUtility.UrlEncode(ReadLoginCookie(WorldContext));
			if (text == null || text.Length <= 0)
			{
				return false;
			}
		}
		if (WorldContext.IsNullOrDestroyed())
		{
			return false;
		}
		string ipList = GetIpList(WorldContext);
		string requestUrl = QYWX_LoginBaseUrl + "/InfraGateImpl/GetQrInfo?local_ip=" + ipList + "&auth_token=" + text;
		return BGW_AsyncTaskMgr.Get(WorldContext).HttpFetchJson(requestUrl, PostMethod: false, delegate(int ErrCode, JsonData RetData, string Msg)
		{
			if (ErrCode != 0)
			{
				FailCallBack?.Invoke(ErrCode, Msg);
			}
			else if (bIsQuickMode && RetData["is_login"].ToString() == "0")
			{
				FailCallBack?.Invoke(ErrCode, RetData["msg"].ToString());
			}
			else
			{
				SuccessCallBack?.Invoke(RetData);
			}
		});
	}

	public static bool StartQueryUserLoginStatusAsync(UObject WorldContext, string QueryToken, DelQywxQuerySuccessCallBack SuccessCallBack = null, DelQywxQueryFailCallBack FailCallBack = null)
	{
		string requestUrl = QYWX_LoginBaseUrl + "/InfraGateImpl/Query?query_token=" + QueryToken;
		return BGW_AsyncTaskMgr.Get(WorldContext).HttpFetchJson(requestUrl, PostMethod: false, delegate(int ErrCode, JsonData RetData, string Msg)
		{
			if (ErrCode != 0)
			{
				FailCallBack?.Invoke(ErrCode, Msg);
			}
			else
			{
				if (RetData["code"].ToString() == "0")
				{
					JsonData jsonData = RetData["info"];
					if (jsonData != null && !string.IsNullOrEmpty(jsonData["account"].ToString()))
					{
						string text = RetData["auth_token"].ToString();
						if (text.Length > 0)
						{
							WriteLoginCookie(WorldContext, text);
						}
						SuccessCallBack?.Invoke(RetData);
						return;
					}
				}
				FailCallBack?.Invoke(int.Parse(RetData["code"].ToString()), RetData["msg"].ToString());
			}
		});
	}

	public static bool SummerSpecialLoginCheck(string UserName, string Passwd)
	{
		if (BGW_LocalDevEnvUtils.IsSummerMagicRunning && UserName == SummerMagicUserName && Passwd == "wukong89632147")
		{
			_is_summer_special_login_status_passed = true;
			return true;
		}
		return false;
	}

	public static bool SummerSpecialLoginStatusTickCheck(UObject WorldContext)
	{
		if (!_is_summer_special_login_status_passed)
		{
			return false;
		}
		QywxLoginSuccessByParams(WorldContext, new QywxLoginParam
		{
			UserNickName = SummerMagicUserName,
			UserName = SummerMagicUserName,
			SdkUid = SummerMagicUserName,
			UserIcon = "",
			GSSdkToken = ""
		});
		return true;
	}

	private static string QYWX_CalcPasswd(string Uname, string OrgPass)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(OrgPass);
		byte[] magic_key = new byte[4] { 146, 15, 94, 108 };
		Cipher.XorEncrypt(bytes, magic_key);
		return Uri.EscapeDataString(Convert.ToBase64String(bytes));
	}

	public static bool StartLoginByUserPassAsync(UObject WorldContext, string UserName, string Passwd, bool bIsQuickMode, DelQywxQuerySuccessCallBack SuccessCallBack = null, DelQywxQueryFailCallBack FailCallBack = null)
	{
		string text = "";
		string ipList = GetIpList(WorldContext);
		string text2 = QYWX_CalcPasswd(UserName, Passwd);
		if (bIsQuickMode)
		{
			text = WebUtility.UrlEncode(ReadLoginCookie(WorldContext));
			if (text == null || text.Length <= 0)
			{
				return false;
			}
		}
		string requestUrl = QYWX_LoginBaseUrl + "/InfraGateImpl/LoginAcc?uname=" + UserName + "&passwd=" + text2 + "&auth_token=" + text + "&vv=2&local_ip=" + ipList;
		return BGW_AsyncTaskMgr.Get(WorldContext).HttpFetchJson(requestUrl, PostMethod: false, delegate(int ErrCode, JsonData RetData, string Msg)
		{
			if (ErrCode != 0)
			{
				FailCallBack?.Invoke(ErrCode, Msg);
			}
			else if (RetData["code"].ToString() == "0")
			{
				SuccessCallBack?.Invoke(RetData);
			}
			else
			{
				FailCallBack?.Invoke(int.Parse(RetData["code"].ToString()), RetData["msg"].ToString());
			}
		});
	}

	public static void QywxLoginSuccessByParams(UObject WorldCtx, QywxLoginParam Params)
	{
		if (BGW_WXLoginMgr.Get(WorldCtx).GetWXLoginName() != "")
		{
			UWorld worldFromObj = UGSE_EngineFuncLib.GetWorldFromObj(WorldCtx);
			if (worldFromObj != null && !StringParseHelper.SafeToLower(worldFromObj.GetName()).Contains("wxlogin"))
			{
				FMessage.OpenDialog("已经是登录状态，请不要重复登录！", "");
				UGSE_EngineFuncLib.QuitGame(WorldCtx);
			}
		}
		string userNickName = Params.UserNickName;
		string userName = Params.UserName;
		BGW_WXLoginMgr.Get(WorldCtx).SetWXLoginName(userName + "(" + userNickName + ")");
		BGW_WXLoginMgr.Get(WorldCtx).SetWXLoginId(userName);
		BGW_WXLoginMgr.Get(WorldCtx).SetWXLoginSDKToken(Params.GSSdkToken);
		BGW_WXLoginMgr.Get(WorldCtx).WXSetLoginTime(Params.LoginTimeLimit_todo_delete);
		BGW_WXLoginMgr.Get(WorldCtx).SetWXVersion(Params.LoginVersionLimit_todo_delete);
		BGW_WXLoginMgr.Get(WorldCtx).WXSetIsGM(Params.IsGM_todo_delete);
		if (BGW_CETestGameMgr.EnableCETesting)
		{
			BGW_CETestGameMgr.Get(WorldCtx).OnLocalUserLoginFinish(bSuccess: true);
		}
		else
		{
			BGW_EventCollection.Get(WorldCtx).Evt_TriggerWXLoginSuccess();
		}
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUFuncLibWXLogin:QywxLoginSuccess")]
	public static void QywxLoginSuccess(UObject WorldCtx, List<string> Params)
	{
		QywxLoginParam qywxLoginParam = new QywxLoginParam();
		if (Params.Count >= 2)
		{
			qywxLoginParam.UserNickName = Params[1];
			qywxLoginParam.UserName = Params[0];
			if (Params.Count >= 6)
			{
				qywxLoginParam.LoginTimeLimit_todo_delete = Params[4];
				qywxLoginParam.LoginVersionLimit_todo_delete = Params[5];
			}
			if (Params.Count >= 7)
			{
				qywxLoginParam.IsGM_todo_delete = Params[6];
			}
		}
		QywxLoginSuccessByParams(WorldCtx, qywxLoginParam);
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUFuncLibWXLogin:GetIpList")]
	public static string GetIpList(UObject WorldCtx)
	{
		List<IPAddress> localIpv = BGW_LocalDevEnvUtils.GetLocalIpv4();
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < localIpv.Count; i++)
		{
			if (i > 0)
			{
				stringBuilder.Append(",");
			}
			stringBuilder.Append(localIpv[i].ToString());
		}
		return stringBuilder.ToString();
	}

	private static bool IsLocalIpv4(IPAddress ip)
	{
		byte[] addressBytes = ip.GetAddressBytes();
		if (addressBytes[0] == 10)
		{
			return true;
		}
		if (addressBytes[0] == 172 && addressBytes[1] >= 16 && addressBytes[1] <= 31)
		{
			return true;
		}
		if (addressBytes[0] == 192 && addressBytes[1] == 168)
		{
			return true;
		}
		return false;
	}

	public static string getCookieFile()
	{
		string text = GSEFileUtil.CombinePath(GSEFileUtil.ProjectPersistentDownloadDir, "cookies");
		if (!Directory.Exists(text))
		{
			Directory.CreateDirectory(text);
		}
		return GSEFileUtil.CombinePath(text, "default");
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUFuncLibWXLogin:WriteLoginCookie")]
	public static int WriteLoginCookie(UObject WorldCtx, string val)
	{
		try
		{
			byte[] bytes = Encoding.Default.GetBytes(val);
			File.WriteAllBytes(getCookieFile(), bytes);
		}
		catch (Exception)
		{
			return -1;
		}
		return 0;
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUFuncLibWXLogin:ReadLoginCookie")]
	public static string ReadLoginCookie(UObject WorldCtx)
	{
		try
		{
			string cookieFile = getCookieFile();
			if (!FPaths.FileExists(cookieFile))
			{
				return "";
			}
			byte[] bytes = File.ReadAllBytes(cookieFile);
			return Encoding.Default.GetString(bytes);
		}
		catch (Exception)
		{
		}
		return "";
	}

	public static string getHistUserInfoFile()
	{
		string text = GSEFileUtil.CombinePath(GSEFileUtil.ProjectPersistentDownloadDir, "cookies");
		if (!Directory.Exists(text))
		{
			Directory.CreateDirectory(text);
		}
		return GSEFileUtil.CombinePath(text, "users");
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BGUFuncLibWXLogin:SaveUserInfo")]
	public static int SaveUserInfo(UObject WorldCtx, string val)
	{
		try
		{
			if (val.Length <= 0)
			{
				return -2;
			}
			bool flag = false;
			List<string> list = new List<string>();
			string histUserInfoFile = getHistUserInfoFile();
			if (File.Exists(histUserInfoFile))
			{
				string[] array = File.ReadAllLines(histUserInfoFile);
				string text = val.Split(',')[0];
				for (int i = 0; i < array.Length; i++)
				{
					if (text != "" && array[i].StartsWith(text))
					{
						list.Add(val);
						flag = true;
					}
					else
					{
						list.Add(array[i]);
					}
				}
			}
			if (!flag)
			{
				list.Add(val);
			}
			File.WriteAllLines(getHistUserInfoFile(), list.ToArray());
		}
		catch (Exception)
		{
			return -1;
		}
		return 0;
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BGUFuncLibWXLogin:LoadUserInfo")]
	public static List<string> LoadUserInfo(UObject WorldCtx)
	{
		List<string> list = new List<string>();
		try
		{
			string[] collection = File.ReadAllLines(getHistUserInfoFile());
			list.AddRange(collection);
			return list;
		}
		catch (Exception)
		{
			return list;
		}
	}

	static BGUFuncLibWXLogin()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUFuncLibWXLogin)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGUFuncLibWXLogin));
		_is_summer_special_login_status_passed = false;
		SummerMagicUserName = "summer820";
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFuncLibWXLogin:GetIpList")]
	private static void GetIpList__Invoker(IntPtr buffer, IntPtr obj)
	{
		UObject worldCtx = UObjectMarshaler<UObject>.FromNative(IntPtr.Add(buffer, GetIpList_WorldCtx_Offset));
		string ipList = GetIpList(worldCtx);
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetIpList_ReturnValue_Offset), ipList);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFuncLibWXLogin:LoadUserInfo")]
	private static void LoadUserInfo__Invoker(IntPtr buffer, IntPtr obj)
	{
		TArrayCopyMarshaler<string> tArrayCopyMarshaler = new TArrayCopyMarshaler<string>(1, LoadUserInfo_ReturnValue_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative);
		UObject worldCtx = UObjectMarshaler<UObject>.FromNative(IntPtr.Add(buffer, LoadUserInfo_WorldCtx_Offset));
		List<string> value = LoadUserInfo(worldCtx);
		tArrayCopyMarshaler.ToNative(IntPtr.Add(buffer, LoadUserInfo_ReturnValue_Offset), value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFuncLibWXLogin:SaveUserInfo")]
	private static void SaveUserInfo__Invoker(IntPtr buffer, IntPtr obj)
	{
		UObject worldCtx = UObjectMarshaler<UObject>.FromNative(IntPtr.Add(buffer, SaveUserInfo_WorldCtx_Offset));
		string val = FStringMarshaler.FromNative(IntPtr.Add(buffer, SaveUserInfo_val_Offset));
		int value = SaveUserInfo(worldCtx, val);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(buffer, SaveUserInfo_ReturnValue_Offset), value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFuncLibWXLogin:ReadLoginCookie")]
	private static void ReadLoginCookie__Invoker(IntPtr buffer, IntPtr obj)
	{
		UObject worldCtx = UObjectMarshaler<UObject>.FromNative(IntPtr.Add(buffer, ReadLoginCookie_WorldCtx_Offset));
		string value = ReadLoginCookie(worldCtx);
		FStringMarshaler.ToNative(IntPtr.Add(buffer, ReadLoginCookie_ReturnValue_Offset), value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFuncLibWXLogin:WriteLoginCookie")]
	private static void WriteLoginCookie__Invoker(IntPtr buffer, IntPtr obj)
	{
		UObject worldCtx = UObjectMarshaler<UObject>.FromNative(IntPtr.Add(buffer, WriteLoginCookie_WorldCtx_Offset));
		string val = FStringMarshaler.FromNative(IntPtr.Add(buffer, WriteLoginCookie_val_Offset));
		int value = WriteLoginCookie(worldCtx, val);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(buffer, WriteLoginCookie_ReturnValue_Offset), value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFuncLibWXLogin:QywxLoginSuccess")]
	private static void QywxLoginSuccess__Invoker(IntPtr buffer, IntPtr obj)
	{
		UObject worldCtx = UObjectMarshaler<UObject>.FromNative(IntPtr.Add(buffer, QywxLoginSuccess_WorldCtx_Offset));
		List<string> list = new TArrayCopyMarshaler<string>(1, QywxLoginSuccess_Params_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(buffer, QywxLoginSuccess_Params_Offset));
		QywxLoginSuccess(worldCtx, list);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BGUFuncLibWXLogin");
		GetIpList_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetIpList");
		GetIpList_ParamsSize = NativeReflection.GetFunctionParamsSize(GetIpList_FunctionAddress);
		GetIpList_WorldCtx_Offset = NativeReflection.GetPropertyOffset(GetIpList_FunctionAddress, "WorldCtx");
		GetIpList_WorldCtx_IsValid = NativeReflection.ValidatePropertyClass(GetIpList_FunctionAddress, "WorldCtx", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref GetIpList_ReturnValue_PropertyAddress, GetIpList_FunctionAddress, "ReturnValue");
		GetIpList_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetIpList_FunctionAddress, "ReturnValue");
		GetIpList_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetIpList_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetIpList_IsValid = GetIpList_FunctionAddress != IntPtr.Zero && GetIpList_WorldCtx_IsValid && GetIpList_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFuncLibWXLogin:GetIpList", GetIpList_IsValid);
		LoadUserInfo_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "LoadUserInfo");
		LoadUserInfo_ParamsSize = NativeReflection.GetFunctionParamsSize(LoadUserInfo_FunctionAddress);
		LoadUserInfo_WorldCtx_Offset = NativeReflection.GetPropertyOffset(LoadUserInfo_FunctionAddress, "WorldCtx");
		LoadUserInfo_WorldCtx_IsValid = NativeReflection.ValidatePropertyClass(LoadUserInfo_FunctionAddress, "WorldCtx", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref LoadUserInfo_ReturnValue_PropertyAddress, LoadUserInfo_FunctionAddress, "ReturnValue");
		LoadUserInfo_ReturnValue_Offset = NativeReflection.GetPropertyOffset(LoadUserInfo_FunctionAddress, "ReturnValue");
		LoadUserInfo_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(LoadUserInfo_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		LoadUserInfo_IsValid = LoadUserInfo_FunctionAddress != IntPtr.Zero && LoadUserInfo_WorldCtx_IsValid && LoadUserInfo_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFuncLibWXLogin:LoadUserInfo", LoadUserInfo_IsValid);
		SaveUserInfo_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SaveUserInfo");
		SaveUserInfo_ParamsSize = NativeReflection.GetFunctionParamsSize(SaveUserInfo_FunctionAddress);
		SaveUserInfo_WorldCtx_Offset = NativeReflection.GetPropertyOffset(SaveUserInfo_FunctionAddress, "WorldCtx");
		SaveUserInfo_WorldCtx_IsValid = NativeReflection.ValidatePropertyClass(SaveUserInfo_FunctionAddress, "WorldCtx", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref SaveUserInfo_val_PropertyAddress, SaveUserInfo_FunctionAddress, "val");
		SaveUserInfo_val_Offset = NativeReflection.GetPropertyOffset(SaveUserInfo_FunctionAddress, "val");
		SaveUserInfo_val_IsValid = NativeReflection.ValidatePropertyClass(SaveUserInfo_FunctionAddress, "val", Classes.FStrProperty);
		SaveUserInfo_ReturnValue_Offset = NativeReflection.GetPropertyOffset(SaveUserInfo_FunctionAddress, "ReturnValue");
		SaveUserInfo_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(SaveUserInfo_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		SaveUserInfo_IsValid = SaveUserInfo_FunctionAddress != IntPtr.Zero && SaveUserInfo_WorldCtx_IsValid && SaveUserInfo_val_IsValid && SaveUserInfo_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFuncLibWXLogin:SaveUserInfo", SaveUserInfo_IsValid);
		ReadLoginCookie_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ReadLoginCookie");
		ReadLoginCookie_ParamsSize = NativeReflection.GetFunctionParamsSize(ReadLoginCookie_FunctionAddress);
		ReadLoginCookie_WorldCtx_Offset = NativeReflection.GetPropertyOffset(ReadLoginCookie_FunctionAddress, "WorldCtx");
		ReadLoginCookie_WorldCtx_IsValid = NativeReflection.ValidatePropertyClass(ReadLoginCookie_FunctionAddress, "WorldCtx", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref ReadLoginCookie_ReturnValue_PropertyAddress, ReadLoginCookie_FunctionAddress, "ReturnValue");
		ReadLoginCookie_ReturnValue_Offset = NativeReflection.GetPropertyOffset(ReadLoginCookie_FunctionAddress, "ReturnValue");
		ReadLoginCookie_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(ReadLoginCookie_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		ReadLoginCookie_IsValid = ReadLoginCookie_FunctionAddress != IntPtr.Zero && ReadLoginCookie_WorldCtx_IsValid && ReadLoginCookie_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFuncLibWXLogin:ReadLoginCookie", ReadLoginCookie_IsValid);
		WriteLoginCookie_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "WriteLoginCookie");
		WriteLoginCookie_ParamsSize = NativeReflection.GetFunctionParamsSize(WriteLoginCookie_FunctionAddress);
		WriteLoginCookie_WorldCtx_Offset = NativeReflection.GetPropertyOffset(WriteLoginCookie_FunctionAddress, "WorldCtx");
		WriteLoginCookie_WorldCtx_IsValid = NativeReflection.ValidatePropertyClass(WriteLoginCookie_FunctionAddress, "WorldCtx", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref WriteLoginCookie_val_PropertyAddress, WriteLoginCookie_FunctionAddress, "val");
		WriteLoginCookie_val_Offset = NativeReflection.GetPropertyOffset(WriteLoginCookie_FunctionAddress, "val");
		WriteLoginCookie_val_IsValid = NativeReflection.ValidatePropertyClass(WriteLoginCookie_FunctionAddress, "val", Classes.FStrProperty);
		WriteLoginCookie_ReturnValue_Offset = NativeReflection.GetPropertyOffset(WriteLoginCookie_FunctionAddress, "ReturnValue");
		WriteLoginCookie_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(WriteLoginCookie_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		WriteLoginCookie_IsValid = WriteLoginCookie_FunctionAddress != IntPtr.Zero && WriteLoginCookie_WorldCtx_IsValid && WriteLoginCookie_val_IsValid && WriteLoginCookie_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFuncLibWXLogin:WriteLoginCookie", WriteLoginCookie_IsValid);
		QywxLoginSuccess_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "QywxLoginSuccess");
		QywxLoginSuccess_ParamsSize = NativeReflection.GetFunctionParamsSize(QywxLoginSuccess_FunctionAddress);
		QywxLoginSuccess_WorldCtx_Offset = NativeReflection.GetPropertyOffset(QywxLoginSuccess_FunctionAddress, "WorldCtx");
		QywxLoginSuccess_WorldCtx_IsValid = NativeReflection.ValidatePropertyClass(QywxLoginSuccess_FunctionAddress, "WorldCtx", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref QywxLoginSuccess_Params_PropertyAddress, QywxLoginSuccess_FunctionAddress, "Params");
		QywxLoginSuccess_Params_Offset = NativeReflection.GetPropertyOffset(QywxLoginSuccess_FunctionAddress, "Params");
		QywxLoginSuccess_Params_IsValid = NativeReflection.ValidatePropertyClass(QywxLoginSuccess_FunctionAddress, "Params", Classes.FArrayProperty);
		QywxLoginSuccess_IsValid = QywxLoginSuccess_FunctionAddress != IntPtr.Zero && QywxLoginSuccess_WorldCtx_IsValid && QywxLoginSuccess_Params_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFuncLibWXLogin:QywxLoginSuccess", QywxLoginSuccess_IsValid);
	}
}
