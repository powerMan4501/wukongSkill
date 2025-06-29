using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace b1;

[UDelegate]
[UMetaPath("/Script/DownloadTookit.OnDownloadCanceled__DelegateSignature")]
public class FOnDownloadCanceled : FMulticastDelegate<FOnDownloadCanceled.Signature>
{
	public delegate void Signature(UDownloadProxy Proxy);

	private static bool OnDownloadCanceled__DelegateSignature_IsValid;

	private static IntPtr OnDownloadCanceled__DelegateSignature_FunctionAddress;

	private static int OnDownloadCanceled__DelegateSignature_ParamsSize;

	private static bool OnDownloadCanceled__DelegateSignature_Proxy_IsValid;

	private static FFieldAddress OnDownloadCanceled__DelegateSignature_Proxy_PropertyAddress;

	private static int OnDownloadCanceled__DelegateSignature_Proxy_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnDownloadCanceled()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnDownloadCanceled__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/DownloadTookit.OnDownloadCanceled__DelegateSignature");
		OnDownloadCanceled__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnDownloadCanceled__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnDownloadCanceled__DelegateSignature_Proxy_PropertyAddress, OnDownloadCanceled__DelegateSignature_FunctionAddress, "Proxy");
		OnDownloadCanceled__DelegateSignature_Proxy_Offset = NativeReflectionCached.GetPropertyOffset(OnDownloadCanceled__DelegateSignature_FunctionAddress, "Proxy");
		OnDownloadCanceled__DelegateSignature_Proxy_IsValid = NativeReflectionCached.ValidatePropertyClass(OnDownloadCanceled__DelegateSignature_FunctionAddress, "Proxy", Classes.FObjectProperty);
		OnDownloadCanceled__DelegateSignature_IsValid = OnDownloadCanceled__DelegateSignature_FunctionAddress != IntPtr.Zero && OnDownloadCanceled__DelegateSignature_Proxy_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DownloadTookit.OnDownloadCanceled__DelegateSignature", OnDownloadCanceled__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(UDownloadProxy Proxy)
	{
		if (!OnDownloadCanceled__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DownloadTookit.OnDownloadCanceled__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnDownloadCanceled__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnDownloadCanceled__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			UObjectMarshaler<UDownloadProxy>.ToNative(IntPtr.Add(intPtr, OnDownloadCanceled__DelegateSignature_Proxy_Offset), 0, OnDownloadCanceled__DelegateSignature_Proxy_PropertyAddress.Address, Proxy);
			ProcessDelegate(intPtr);
		}
	}
}
