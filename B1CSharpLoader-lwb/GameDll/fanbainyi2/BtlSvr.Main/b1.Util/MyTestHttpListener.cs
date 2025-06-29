using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1.Util;

[UClass]
[USharpPath("/Script/b1-Managed.MyTestHttpListener")]
public class MyTestHttpListener : UHttpResposeListener
{
	private string mytag = "default tag";

	private static bool IsNeedProgress_IsValid;

	private static IntPtr IsNeedProgress_FunctionAddress;

	private static int IsNeedProgress_ParamsSize;

	private static bool IsNeedProgress_ReturnValue_IsValid;

	private static int IsNeedProgress_ReturnValue_Offset;

	private static FFieldAddress IsNeedProgress_ReturnValue_PropertyAddress;

	private static bool OnReponseComplete_IsValid;

	private static IntPtr OnReponseComplete_FunctionAddress;

	private static int OnReponseComplete_ParamsSize;

	private static bool OnReponseComplete_bSuccess_IsValid;

	private static int OnReponseComplete_bSuccess_Offset;

	private static FFieldAddress OnReponseComplete_bSuccess_PropertyAddress;

	private static bool OnReponseComplete_HttpCode_IsValid;

	private static int OnReponseComplete_HttpCode_Offset;

	private static bool OnReponseComplete_content_IsValid;

	private static int OnReponseComplete_content_Offset;

	private static FFieldAddress OnReponseComplete_content_PropertyAddress;

	private static bool OnRequestProgress_IsValid;

	private static IntPtr OnRequestProgress_FunctionAddress;

	private static int OnRequestProgress_ParamsSize;

	private static bool OnRequestProgress_sentBytes_IsValid;

	private static int OnRequestProgress_sentBytes_Offset;

	private static bool OnRequestProgress_lReceivedBytes_IsValid;

	private static int OnRequestProgress_lReceivedBytes_Offset;

	private static bool OnRequestProgress_lTotalBytes_IsValid;

	private static int OnRequestProgress_lTotalBytes_Offset;

	public void SetTag(string mytag = "test")
	{
		this.mytag = mytag;
	}

	[USharpPath("/Script/b1-Managed.MyTestHttpListener:OnReponseComplete")]
	protected override void OnReponseComplete_Implementation(bool bSuccess, int HttpCode, List<byte> content)
	{
		RemoveFromRoot();
	}

	[USharpPath("/Script/b1-Managed.MyTestHttpListener:IsNeedProgress")]
	protected override bool IsNeedProgress_Implementation()
	{
		return true;
	}

	[USharpPath("/Script/b1-Managed.MyTestHttpListener:OnRequestProgress")]
	protected override void OnRequestProgress_Implementation(int sentBytes, int lReceivedBytes, int lTotalBytes)
	{
	}

	public static void TestMyHttp(UObject ctx)
	{
		BGW_LogUtil.LogError($"Http csharp get world contxt:{ctx}");
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		dictionary.Add("aaamytest", "bbbbb");
		UHttpResposeListener uHttpResposeListener = UObject.NewObject<MyTestHttpListener>(ctx);
		BGW_LogUtil.LogError($"Http csharp get listener:{uHttpResposeListener}");
		if (uHttpResposeListener != null)
		{
			uHttpResposeListener.AddToRoot();
		}
		UGSE_SDKFuncLib.HttpPostFile("http://127.0.0.1:8000/comm/uploadfile/", dictionary, "C:\\Users\\gsgame\\Downloads\\atpclient-1.log", uHttpResposeListener);
	}

	public static int HttpPostTest(UObject ctx)
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		dictionary.Add("aaamytest", "bbbbb");
		UHttpResposeListener uHttpResposeListener = UObject.NewObject<MyTestHttpListener>(ctx);
		BGW_LogUtil.LogError($"Http csharp get listener:{uHttpResposeListener}");
		if (uHttpResposeListener != null)
		{
			uHttpResposeListener.AddToRoot();
		}
		UGSE_SDKFuncLib.HttpPostFile("http://127.0.0.1:8000/comm/uploadfile/", dictionary, "C:\\Users\\gsgame\\Downloads\\atpclient-1.log", uHttpResposeListener);
		return 0;
	}

	public static int HttpDownloadTest(UObject Ctx, string url = "")
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		dictionary.Add("aaamytest", "bbbbb");
		UHttpResposeListener uHttpResposeListener = UObject.NewObject<MyTestHttpListener>(Ctx);
		BGW_LogUtil.LogError($"Http csharp get listener:{uHttpResposeListener}");
		if (uHttpResposeListener != null)
		{
			uHttpResposeListener.AddToRoot();
		}
		UGSE_SDKFuncLib.StartHttpRawDataRequest(url, "GET", dictionary, null, uHttpResposeListener, 0);
		return 0;
	}

	[UFunctionInvoker("/Script/b1-Managed.MyTestHttpListener:IsNeedProgress")]
	private static void IsNeedProgress__Invoker(IntPtr buffer, IntPtr obj)
	{
		MyTestHttpListener myTestHttpListener = GCHelper.Find<MyTestHttpListener>(obj);
		bool value = myTestHttpListener.IsNeedProgress_Implementation();
		BoolMarshaler.ToNative(IntPtr.Add(buffer, IsNeedProgress_ReturnValue_Offset), 0, IsNeedProgress_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.MyTestHttpListener:OnReponseComplete")]
	private static void OnReponseComplete__Invoker(IntPtr buffer, IntPtr obj)
	{
		MyTestHttpListener myTestHttpListener = GCHelper.Find<MyTestHttpListener>(obj);
		bool bSuccess = BoolMarshaler.FromNative(IntPtr.Add(buffer, OnReponseComplete_bSuccess_Offset), 0, OnReponseComplete_bSuccess_PropertyAddress.Address);
		int httpCode = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, OnReponseComplete_HttpCode_Offset));
		List<byte> content = new TArrayCopyMarshaler<byte>(1, OnReponseComplete_content_PropertyAddress, CachedMarshalingDelegates<byte, BlittableTypeMarshaler<byte>>.FromNative, CachedMarshalingDelegates<byte, BlittableTypeMarshaler<byte>>.ToNative).FromNative(IntPtr.Add(buffer, OnReponseComplete_content_Offset));
		myTestHttpListener.OnReponseComplete_Implementation(bSuccess, httpCode, content);
	}

	[UFunctionInvoker("/Script/b1-Managed.MyTestHttpListener:OnRequestProgress")]
	private static void OnRequestProgress__Invoker(IntPtr buffer, IntPtr obj)
	{
		MyTestHttpListener myTestHttpListener = GCHelper.Find<MyTestHttpListener>(obj);
		int sentBytes = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, OnRequestProgress_sentBytes_Offset));
		int lReceivedBytes = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, OnRequestProgress_lReceivedBytes_Offset));
		int lTotalBytes = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, OnRequestProgress_lTotalBytes_Offset));
		myTestHttpListener.OnRequestProgress_Implementation(sentBytes, lReceivedBytes, lTotalBytes);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.MyTestHttpListener");
		IsNeedProgress_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "IsNeedProgress");
		IsNeedProgress_ParamsSize = NativeReflection.GetFunctionParamsSize(IsNeedProgress_FunctionAddress);
		NativeReflection.GetPropertyRef(ref IsNeedProgress_ReturnValue_PropertyAddress, IsNeedProgress_FunctionAddress, "ReturnValue");
		IsNeedProgress_ReturnValue_Offset = NativeReflection.GetPropertyOffset(IsNeedProgress_FunctionAddress, "ReturnValue");
		IsNeedProgress_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(IsNeedProgress_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsNeedProgress_IsValid = IsNeedProgress_FunctionAddress != IntPtr.Zero && IsNeedProgress_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.MyTestHttpListener:IsNeedProgress", IsNeedProgress_IsValid);
		OnReponseComplete_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnReponseComplete");
		OnReponseComplete_ParamsSize = NativeReflection.GetFunctionParamsSize(OnReponseComplete_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnReponseComplete_bSuccess_PropertyAddress, OnReponseComplete_FunctionAddress, "bSuccess");
		OnReponseComplete_bSuccess_Offset = NativeReflection.GetPropertyOffset(OnReponseComplete_FunctionAddress, "bSuccess");
		OnReponseComplete_bSuccess_IsValid = NativeReflection.ValidatePropertyClass(OnReponseComplete_FunctionAddress, "bSuccess", Classes.FBoolProperty);
		OnReponseComplete_HttpCode_Offset = NativeReflection.GetPropertyOffset(OnReponseComplete_FunctionAddress, "HttpCode");
		OnReponseComplete_HttpCode_IsValid = NativeReflection.ValidatePropertyClass(OnReponseComplete_FunctionAddress, "HttpCode", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref OnReponseComplete_content_PropertyAddress, OnReponseComplete_FunctionAddress, "content");
		OnReponseComplete_content_Offset = NativeReflection.GetPropertyOffset(OnReponseComplete_FunctionAddress, "content");
		OnReponseComplete_content_IsValid = NativeReflection.ValidatePropertyClass(OnReponseComplete_FunctionAddress, "content", Classes.FArrayProperty);
		OnReponseComplete_IsValid = OnReponseComplete_FunctionAddress != IntPtr.Zero && OnReponseComplete_bSuccess_IsValid && OnReponseComplete_HttpCode_IsValid && OnReponseComplete_content_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.MyTestHttpListener:OnReponseComplete", OnReponseComplete_IsValid);
		OnRequestProgress_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnRequestProgress");
		OnRequestProgress_ParamsSize = NativeReflection.GetFunctionParamsSize(OnRequestProgress_FunctionAddress);
		OnRequestProgress_sentBytes_Offset = NativeReflection.GetPropertyOffset(OnRequestProgress_FunctionAddress, "sentBytes");
		OnRequestProgress_sentBytes_IsValid = NativeReflection.ValidatePropertyClass(OnRequestProgress_FunctionAddress, "sentBytes", Classes.FIntProperty);
		OnRequestProgress_lReceivedBytes_Offset = NativeReflection.GetPropertyOffset(OnRequestProgress_FunctionAddress, "lReceivedBytes");
		OnRequestProgress_lReceivedBytes_IsValid = NativeReflection.ValidatePropertyClass(OnRequestProgress_FunctionAddress, "lReceivedBytes", Classes.FIntProperty);
		OnRequestProgress_lTotalBytes_Offset = NativeReflection.GetPropertyOffset(OnRequestProgress_FunctionAddress, "lTotalBytes");
		OnRequestProgress_lTotalBytes_IsValid = NativeReflection.ValidatePropertyClass(OnRequestProgress_FunctionAddress, "lTotalBytes", Classes.FIntProperty);
		OnRequestProgress_IsValid = OnRequestProgress_FunctionAddress != IntPtr.Zero && OnRequestProgress_sentBytes_IsValid && OnRequestProgress_lReceivedBytes_IsValid && OnRequestProgress_lTotalBytes_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.MyTestHttpListener:OnRequestProgress", OnRequestProgress_IsValid);
	}

	static MyTestHttpListener()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(MyTestHttpListener)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(MyTestHttpListener));
	}
}
