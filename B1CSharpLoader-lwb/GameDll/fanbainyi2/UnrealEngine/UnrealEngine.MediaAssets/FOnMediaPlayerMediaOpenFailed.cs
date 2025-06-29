using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.MediaAssets;

[UDelegate]
[UMetaPath("/Script/MediaAssets.OnMediaPlayerMediaOpenFailed__DelegateSignature")]
public class FOnMediaPlayerMediaOpenFailed : FMulticastDelegate<FOnMediaPlayerMediaOpenFailed.Signature>
{
	public delegate void Signature(string FailedUrl);

	private static bool OnMediaPlayerMediaOpenFailed__DelegateSignature_IsValid;

	private static IntPtr OnMediaPlayerMediaOpenFailed__DelegateSignature_FunctionAddress;

	private static int OnMediaPlayerMediaOpenFailed__DelegateSignature_ParamsSize;

	private static bool OnMediaPlayerMediaOpenFailed__DelegateSignature_FailedUrl_IsValid;

	private static FFieldAddress OnMediaPlayerMediaOpenFailed__DelegateSignature_FailedUrl_PropertyAddress;

	private static int OnMediaPlayerMediaOpenFailed__DelegateSignature_FailedUrl_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnMediaPlayerMediaOpenFailed()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnMediaPlayerMediaOpenFailed__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/MediaAssets.OnMediaPlayerMediaOpenFailed__DelegateSignature");
		OnMediaPlayerMediaOpenFailed__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnMediaPlayerMediaOpenFailed__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnMediaPlayerMediaOpenFailed__DelegateSignature_FailedUrl_PropertyAddress, OnMediaPlayerMediaOpenFailed__DelegateSignature_FunctionAddress, "FailedUrl");
		OnMediaPlayerMediaOpenFailed__DelegateSignature_FailedUrl_Offset = NativeReflectionCached.GetPropertyOffset(OnMediaPlayerMediaOpenFailed__DelegateSignature_FunctionAddress, "FailedUrl");
		OnMediaPlayerMediaOpenFailed__DelegateSignature_FailedUrl_IsValid = NativeReflectionCached.ValidatePropertyClass(OnMediaPlayerMediaOpenFailed__DelegateSignature_FunctionAddress, "FailedUrl", Classes.FStrProperty);
		OnMediaPlayerMediaOpenFailed__DelegateSignature_IsValid = OnMediaPlayerMediaOpenFailed__DelegateSignature_FunctionAddress != IntPtr.Zero && OnMediaPlayerMediaOpenFailed__DelegateSignature_FailedUrl_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MediaAssets.OnMediaPlayerMediaOpenFailed__DelegateSignature", OnMediaPlayerMediaOpenFailed__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(string FailedUrl)
	{
		if (!OnMediaPlayerMediaOpenFailed__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MediaAssets.OnMediaPlayerMediaOpenFailed__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnMediaPlayerMediaOpenFailed__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnMediaPlayerMediaOpenFailed__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			FStringMarshaler.ToNative(IntPtr.Add(intPtr, OnMediaPlayerMediaOpenFailed__DelegateSignature_FailedUrl_Offset), 0, OnMediaPlayerMediaOpenFailed__DelegateSignature_FailedUrl_PropertyAddress.Address, FailedUrl);
			ProcessDelegate(intPtr);
			NativeReflection.DestroyValue_InContainer(OnMediaPlayerMediaOpenFailed__DelegateSignature_FailedUrl_PropertyAddress.Address, intPtr);
		}
	}
}
