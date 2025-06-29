using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace b1;

[UDelegate]
[UMetaPath("/Script/DownloadTookit.OnDownloadResumed__DelegateSignature")]
public class FOnDownloadResumed : FMulticastDelegate<FOnDownloadResumed.Signature>
{
	public delegate void Signature(UDownloadProxy Proxy);

	private static bool OnDownloadResumed__DelegateSignature_IsValid;

	private static IntPtr OnDownloadResumed__DelegateSignature_FunctionAddress;

	private static int OnDownloadResumed__DelegateSignature_ParamsSize;

	private static bool OnDownloadResumed__DelegateSignature_Proxy_IsValid;

	private static FFieldAddress OnDownloadResumed__DelegateSignature_Proxy_PropertyAddress;

	private static int OnDownloadResumed__DelegateSignature_Proxy_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnDownloadResumed()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnDownloadResumed__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/DownloadTookit.OnDownloadResumed__DelegateSignature");
		OnDownloadResumed__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnDownloadResumed__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnDownloadResumed__DelegateSignature_Proxy_PropertyAddress, OnDownloadResumed__DelegateSignature_FunctionAddress, "Proxy");
		OnDownloadResumed__DelegateSignature_Proxy_Offset = NativeReflectionCached.GetPropertyOffset(OnDownloadResumed__DelegateSignature_FunctionAddress, "Proxy");
		OnDownloadResumed__DelegateSignature_Proxy_IsValid = NativeReflectionCached.ValidatePropertyClass(OnDownloadResumed__DelegateSignature_FunctionAddress, "Proxy", Classes.FObjectProperty);
		OnDownloadResumed__DelegateSignature_IsValid = OnDownloadResumed__DelegateSignature_FunctionAddress != IntPtr.Zero && OnDownloadResumed__DelegateSignature_Proxy_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DownloadTookit.OnDownloadResumed__DelegateSignature", OnDownloadResumed__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(UDownloadProxy Proxy)
	{
		if (!OnDownloadResumed__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DownloadTookit.OnDownloadResumed__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnDownloadResumed__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnDownloadResumed__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			UObjectMarshaler<UDownloadProxy>.ToNative(IntPtr.Add(intPtr, OnDownloadResumed__DelegateSignature_Proxy_Offset), 0, OnDownloadResumed__DelegateSignature_Proxy_PropertyAddress.Address, Proxy);
			ProcessDelegate(intPtr);
		}
	}
}
