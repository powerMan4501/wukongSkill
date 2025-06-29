using System;
using System.Collections.Generic;
using System.Text;
using GSE.GSSdk;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.UGSSdkHttpRequestCallbackListener")]
public class UGSSdkHttpRequestCallbackListener : UHttpResposeListener
{
	private static int GlobalIdSeq;

	private int MyId;

	private DateTime CallStartTime;

	private int CallbackTimeout;

	private HttpResponseFinishNotify OnResponse;

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

	public bool IsCallbackOver { get; private set; }

	public void SetupCallback(HttpResponseFinishNotify onResponse, int Timeout = 0)
	{
		GlobalIdSeq++;
		MyId = GlobalIdSeq;
		OnResponse = onResponse;
		CallStartTime = DateTime.Now;
		CallbackTimeout = Timeout;
	}

	public void SafeHandleResponseCallback(int ErrCodeOrHttpStatusCode, byte[] Content, string ErrorMsg = "")
	{
		IsCallbackOver = true;
		if (OnResponse == null)
		{
			return;
		}
		try
		{
			if (ErrCodeOrHttpStatusCode < 0)
			{
				OnResponse?.Invoke(ErrCodeOrHttpStatusCode, Encoding.UTF8.GetBytes(ErrorMsg));
			}
			else if (Content != null && Content.Length != 0)
			{
				OnResponse?.Invoke(ErrCodeOrHttpStatusCode, Content);
			}
			else
			{
				OnResponse?.Invoke(ErrCodeOrHttpStatusCode, Encoding.UTF8.GetBytes(""));
			}
		}
		catch (Exception ex)
		{
			BGW_LogUtil.LogError($"http response id={MyId} handle fail ex:{ex.Message} content:{Content}  reason emsg:{ErrorMsg}");
		}
		OnResponse = null;
	}

	public void TimeoutCheck()
	{
		if (OnResponse != null && !IsCallbackOver)
		{
			TimeSpan timeSpan = DateTime.Now - CallStartTime;
			if (((timeSpan.TotalSeconds > (double)CallbackTimeout && CallbackTimeout > 0) || (CallbackTimeout <= 0 && timeSpan.TotalSeconds > 75.0)) && !IsCallbackOver)
			{
				SafeHandleResponseCallback(-1, new byte[0], $"HTTP Request Timeout > {CallbackTimeout}s");
			}
		}
	}

	[USharpPath("/Script/b1-Managed.UGSSdkHttpRequestCallbackListener:OnReponseComplete")]
	protected override void OnReponseComplete_Implementation(bool bSuccess, int HttpCode, List<byte> content)
	{
		if (content == null || content.Count == 0)
		{
			SafeHandleResponseCallback(HttpCode, new byte[0], $"HTTP Code:{HttpCode} But Content Is Null");
		}
		else
		{
			SafeHandleResponseCallback(HttpCode, content.ToArray(), $"HTTP Code:{HttpCode}");
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.UGSSdkHttpRequestCallbackListener:OnReponseComplete")]
	private static void OnReponseComplete__Invoker(IntPtr buffer, IntPtr obj)
	{
		UGSSdkHttpRequestCallbackListener uGSSdkHttpRequestCallbackListener = GCHelper.Find<UGSSdkHttpRequestCallbackListener>(obj);
		bool bSuccess = BoolMarshaler.FromNative(IntPtr.Add(buffer, OnReponseComplete_bSuccess_Offset), 0, OnReponseComplete_bSuccess_PropertyAddress.Address);
		int httpCode = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, OnReponseComplete_HttpCode_Offset));
		List<byte> content = new TArrayCopyMarshaler<byte>(1, OnReponseComplete_content_PropertyAddress, CachedMarshalingDelegates<byte, BlittableTypeMarshaler<byte>>.FromNative, CachedMarshalingDelegates<byte, BlittableTypeMarshaler<byte>>.ToNative).FromNative(IntPtr.Add(buffer, OnReponseComplete_content_Offset));
		uGSSdkHttpRequestCallbackListener.OnReponseComplete_Implementation(bSuccess, httpCode, content);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.UGSSdkHttpRequestCallbackListener");
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
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.UGSSdkHttpRequestCallbackListener:OnReponseComplete", OnReponseComplete_IsValid);
	}

	static UGSSdkHttpRequestCallbackListener()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(UGSSdkHttpRequestCallbackListener)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSSdkHttpRequestCallbackListener));
	}
}
