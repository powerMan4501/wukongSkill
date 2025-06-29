using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace b1;

[UDelegate]
[UMetaPath("/Script/DownloadTookit.OnDownloadComplete__DelegateSignature")]
public class FOnDownloadComplete : FMulticastDelegate<FOnDownloadComplete.Signature>
{
	public delegate void Signature(UDownloadProxy Proxy, bool bSuccess);

	private static bool OnDownloadComplete__DelegateSignature_IsValid;

	private static IntPtr OnDownloadComplete__DelegateSignature_FunctionAddress;

	private static int OnDownloadComplete__DelegateSignature_ParamsSize;

	private static bool OnDownloadComplete__DelegateSignature_Proxy_IsValid;

	private static FFieldAddress OnDownloadComplete__DelegateSignature_Proxy_PropertyAddress;

	private static int OnDownloadComplete__DelegateSignature_Proxy_Offset;

	private static bool OnDownloadComplete__DelegateSignature_bSuccess_IsValid;

	private static FFieldAddress OnDownloadComplete__DelegateSignature_bSuccess_PropertyAddress;

	private static int OnDownloadComplete__DelegateSignature_bSuccess_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnDownloadComplete()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnDownloadComplete__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/DownloadTookit.OnDownloadComplete__DelegateSignature");
		OnDownloadComplete__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnDownloadComplete__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnDownloadComplete__DelegateSignature_Proxy_PropertyAddress, OnDownloadComplete__DelegateSignature_FunctionAddress, "Proxy");
		OnDownloadComplete__DelegateSignature_Proxy_Offset = NativeReflectionCached.GetPropertyOffset(OnDownloadComplete__DelegateSignature_FunctionAddress, "Proxy");
		OnDownloadComplete__DelegateSignature_Proxy_IsValid = NativeReflectionCached.ValidatePropertyClass(OnDownloadComplete__DelegateSignature_FunctionAddress, "Proxy", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref OnDownloadComplete__DelegateSignature_bSuccess_PropertyAddress, OnDownloadComplete__DelegateSignature_FunctionAddress, "bSuccess");
		OnDownloadComplete__DelegateSignature_bSuccess_Offset = NativeReflectionCached.GetPropertyOffset(OnDownloadComplete__DelegateSignature_FunctionAddress, "bSuccess");
		OnDownloadComplete__DelegateSignature_bSuccess_IsValid = NativeReflectionCached.ValidatePropertyClass(OnDownloadComplete__DelegateSignature_FunctionAddress, "bSuccess", Classes.FBoolProperty);
		OnDownloadComplete__DelegateSignature_IsValid = OnDownloadComplete__DelegateSignature_FunctionAddress != IntPtr.Zero && OnDownloadComplete__DelegateSignature_Proxy_IsValid && OnDownloadComplete__DelegateSignature_bSuccess_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DownloadTookit.OnDownloadComplete__DelegateSignature", OnDownloadComplete__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(UDownloadProxy Proxy, bool bSuccess)
	{
		if (!OnDownloadComplete__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DownloadTookit.OnDownloadComplete__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnDownloadComplete__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnDownloadComplete__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			UObjectMarshaler<UDownloadProxy>.ToNative(IntPtr.Add(intPtr, OnDownloadComplete__DelegateSignature_Proxy_Offset), 0, OnDownloadComplete__DelegateSignature_Proxy_PropertyAddress.Address, Proxy);
			BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnDownloadComplete__DelegateSignature_bSuccess_Offset), 0, OnDownloadComplete__DelegateSignature_bSuccess_PropertyAddress.Address, bSuccess);
			ProcessDelegate(intPtr);
		}
	}
}
