using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.MediaAssets;

[UDelegate]
[UMetaPath("/Script/MediaAssets.OnMediaPlayerMediaOpened__DelegateSignature")]
public class FOnMediaPlayerMediaOpened : FMulticastDelegate<FOnMediaPlayerMediaOpened.Signature>
{
	public delegate void Signature(string OpenedUrl);

	private static bool OnMediaPlayerMediaOpened__DelegateSignature_IsValid;

	private static IntPtr OnMediaPlayerMediaOpened__DelegateSignature_FunctionAddress;

	private static int OnMediaPlayerMediaOpened__DelegateSignature_ParamsSize;

	private static bool OnMediaPlayerMediaOpened__DelegateSignature_OpenedUrl_IsValid;

	private static FFieldAddress OnMediaPlayerMediaOpened__DelegateSignature_OpenedUrl_PropertyAddress;

	private static int OnMediaPlayerMediaOpened__DelegateSignature_OpenedUrl_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnMediaPlayerMediaOpened()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnMediaPlayerMediaOpened__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/MediaAssets.OnMediaPlayerMediaOpened__DelegateSignature");
		OnMediaPlayerMediaOpened__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnMediaPlayerMediaOpened__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnMediaPlayerMediaOpened__DelegateSignature_OpenedUrl_PropertyAddress, OnMediaPlayerMediaOpened__DelegateSignature_FunctionAddress, "OpenedUrl");
		OnMediaPlayerMediaOpened__DelegateSignature_OpenedUrl_Offset = NativeReflectionCached.GetPropertyOffset(OnMediaPlayerMediaOpened__DelegateSignature_FunctionAddress, "OpenedUrl");
		OnMediaPlayerMediaOpened__DelegateSignature_OpenedUrl_IsValid = NativeReflectionCached.ValidatePropertyClass(OnMediaPlayerMediaOpened__DelegateSignature_FunctionAddress, "OpenedUrl", Classes.FStrProperty);
		OnMediaPlayerMediaOpened__DelegateSignature_IsValid = OnMediaPlayerMediaOpened__DelegateSignature_FunctionAddress != IntPtr.Zero && OnMediaPlayerMediaOpened__DelegateSignature_OpenedUrl_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MediaAssets.OnMediaPlayerMediaOpened__DelegateSignature", OnMediaPlayerMediaOpened__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(string OpenedUrl)
	{
		if (!OnMediaPlayerMediaOpened__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MediaAssets.OnMediaPlayerMediaOpened__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnMediaPlayerMediaOpened__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnMediaPlayerMediaOpened__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			FStringMarshaler.ToNative(IntPtr.Add(intPtr, OnMediaPlayerMediaOpened__DelegateSignature_OpenedUrl_Offset), 0, OnMediaPlayerMediaOpened__DelegateSignature_OpenedUrl_PropertyAddress.Address, OpenedUrl);
			ProcessDelegate(intPtr);
			NativeReflection.DestroyValue_InContainer(OnMediaPlayerMediaOpened__DelegateSignature_OpenedUrl_PropertyAddress.Address, intPtr);
		}
	}
}
