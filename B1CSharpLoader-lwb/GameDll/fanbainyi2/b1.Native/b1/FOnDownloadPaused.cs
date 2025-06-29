using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace b1;

[UDelegate]
[UMetaPath("/Script/DownloadTookit.OnDownloadPaused__DelegateSignature")]
public class FOnDownloadPaused : FMulticastDelegate<FOnDownloadPaused.Signature>
{
	public delegate void Signature(UDownloadProxy Proxy);

	private static bool OnDownloadPaused__DelegateSignature_IsValid;

	private static IntPtr OnDownloadPaused__DelegateSignature_FunctionAddress;

	private static int OnDownloadPaused__DelegateSignature_ParamsSize;

	private static bool OnDownloadPaused__DelegateSignature_Proxy_IsValid;

	private static FFieldAddress OnDownloadPaused__DelegateSignature_Proxy_PropertyAddress;

	private static int OnDownloadPaused__DelegateSignature_Proxy_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnDownloadPaused()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnDownloadPaused__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/DownloadTookit.OnDownloadPaused__DelegateSignature");
		OnDownloadPaused__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnDownloadPaused__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnDownloadPaused__DelegateSignature_Proxy_PropertyAddress, OnDownloadPaused__DelegateSignature_FunctionAddress, "Proxy");
		OnDownloadPaused__DelegateSignature_Proxy_Offset = NativeReflectionCached.GetPropertyOffset(OnDownloadPaused__DelegateSignature_FunctionAddress, "Proxy");
		OnDownloadPaused__DelegateSignature_Proxy_IsValid = NativeReflectionCached.ValidatePropertyClass(OnDownloadPaused__DelegateSignature_FunctionAddress, "Proxy", Classes.FObjectProperty);
		OnDownloadPaused__DelegateSignature_IsValid = OnDownloadPaused__DelegateSignature_FunctionAddress != IntPtr.Zero && OnDownloadPaused__DelegateSignature_Proxy_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DownloadTookit.OnDownloadPaused__DelegateSignature", OnDownloadPaused__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(UDownloadProxy Proxy)
	{
		if (!OnDownloadPaused__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DownloadTookit.OnDownloadPaused__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnDownloadPaused__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnDownloadPaused__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			UObjectMarshaler<UDownloadProxy>.ToNative(IntPtr.Add(intPtr, OnDownloadPaused__DelegateSignature_Proxy_Offset), 0, OnDownloadPaused__DelegateSignature_Proxy_PropertyAddress.Address, Proxy);
			ProcessDelegate(intPtr);
		}
	}
}
