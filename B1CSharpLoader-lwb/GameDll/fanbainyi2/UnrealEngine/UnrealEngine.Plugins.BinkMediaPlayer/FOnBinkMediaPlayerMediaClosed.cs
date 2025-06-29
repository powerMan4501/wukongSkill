using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.BinkMediaPlayer;

[UDelegate]
[UMetaPath("/Script/BinkMediaPlayer.OnBinkMediaPlayerMediaClosed__DelegateSignature")]
public class FOnBinkMediaPlayerMediaClosed : FMulticastDelegate<FOnBinkMediaPlayerMediaClosed.Signature>
{
	public delegate void Signature();

	private static bool OnBinkMediaPlayerMediaClosed__DelegateSignature_IsValid;

	private static IntPtr OnBinkMediaPlayerMediaClosed__DelegateSignature_FunctionAddress;

	private static int OnBinkMediaPlayerMediaClosed__DelegateSignature_ParamsSize;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnBinkMediaPlayerMediaClosed()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnBinkMediaPlayerMediaClosed__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/BinkMediaPlayer.OnBinkMediaPlayerMediaClosed__DelegateSignature");
		OnBinkMediaPlayerMediaClosed__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnBinkMediaPlayerMediaClosed__DelegateSignature_FunctionAddress);
		OnBinkMediaPlayerMediaClosed__DelegateSignature_IsValid = OnBinkMediaPlayerMediaClosed__DelegateSignature_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/BinkMediaPlayer.OnBinkMediaPlayerMediaClosed__DelegateSignature", OnBinkMediaPlayerMediaClosed__DelegateSignature_IsValid);
	}

	private unsafe void Invoker()
	{
		if (!OnBinkMediaPlayerMediaClosed__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/BinkMediaPlayer.OnBinkMediaPlayerMediaClosed__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnBinkMediaPlayerMediaClosed__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnBinkMediaPlayerMediaClosed__DelegateSignature_ParamsSize);
			IntPtr parameters = new IntPtr(ptr2);
			ProcessDelegate(parameters);
		}
	}
}
