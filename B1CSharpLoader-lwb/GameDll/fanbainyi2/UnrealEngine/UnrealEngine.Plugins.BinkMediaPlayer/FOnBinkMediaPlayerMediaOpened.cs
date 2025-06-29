using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.BinkMediaPlayer;

[UDelegate]
[UMetaPath("/Script/BinkMediaPlayer.OnBinkMediaPlayerMediaOpened__DelegateSignature")]
public class FOnBinkMediaPlayerMediaOpened : FMulticastDelegate<FOnBinkMediaPlayerMediaOpened.Signature>
{
	public delegate void Signature(string OpenedUrl);

	private static bool OnBinkMediaPlayerMediaOpened__DelegateSignature_IsValid;

	private static IntPtr OnBinkMediaPlayerMediaOpened__DelegateSignature_FunctionAddress;

	private static int OnBinkMediaPlayerMediaOpened__DelegateSignature_ParamsSize;

	private static bool OnBinkMediaPlayerMediaOpened__DelegateSignature_OpenedUrl_IsValid;

	private static FFieldAddress OnBinkMediaPlayerMediaOpened__DelegateSignature_OpenedUrl_PropertyAddress;

	private static int OnBinkMediaPlayerMediaOpened__DelegateSignature_OpenedUrl_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnBinkMediaPlayerMediaOpened()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnBinkMediaPlayerMediaOpened__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/BinkMediaPlayer.OnBinkMediaPlayerMediaOpened__DelegateSignature");
		OnBinkMediaPlayerMediaOpened__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnBinkMediaPlayerMediaOpened__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnBinkMediaPlayerMediaOpened__DelegateSignature_OpenedUrl_PropertyAddress, OnBinkMediaPlayerMediaOpened__DelegateSignature_FunctionAddress, "OpenedUrl");
		OnBinkMediaPlayerMediaOpened__DelegateSignature_OpenedUrl_Offset = NativeReflectionCached.GetPropertyOffset(OnBinkMediaPlayerMediaOpened__DelegateSignature_FunctionAddress, "OpenedUrl");
		OnBinkMediaPlayerMediaOpened__DelegateSignature_OpenedUrl_IsValid = NativeReflectionCached.ValidatePropertyClass(OnBinkMediaPlayerMediaOpened__DelegateSignature_FunctionAddress, "OpenedUrl", Classes.FStrProperty);
		OnBinkMediaPlayerMediaOpened__DelegateSignature_IsValid = OnBinkMediaPlayerMediaOpened__DelegateSignature_FunctionAddress != IntPtr.Zero && OnBinkMediaPlayerMediaOpened__DelegateSignature_OpenedUrl_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/BinkMediaPlayer.OnBinkMediaPlayerMediaOpened__DelegateSignature", OnBinkMediaPlayerMediaOpened__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(string OpenedUrl)
	{
		if (!OnBinkMediaPlayerMediaOpened__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/BinkMediaPlayer.OnBinkMediaPlayerMediaOpened__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnBinkMediaPlayerMediaOpened__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnBinkMediaPlayerMediaOpened__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			FStringMarshaler.ToNative(IntPtr.Add(intPtr, OnBinkMediaPlayerMediaOpened__DelegateSignature_OpenedUrl_Offset), 0, OnBinkMediaPlayerMediaOpened__DelegateSignature_OpenedUrl_PropertyAddress.Address, OpenedUrl);
			ProcessDelegate(intPtr);
			NativeReflection.DestroyValue_InContainer(OnBinkMediaPlayerMediaOpened__DelegateSignature_OpenedUrl_PropertyAddress.Address, intPtr);
		}
	}
}
