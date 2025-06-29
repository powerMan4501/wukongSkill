using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.BinkMediaPlayer;

[UDelegate]
[UMetaPath("/Script/BinkMediaPlayer.OnBinkMediaPlayerMediaReachedEnd__DelegateSignature")]
public class FOnBinkMediaPlayerMediaReachedEnd : FMulticastDelegate<FOnBinkMediaPlayerMediaReachedEnd.Signature>
{
	public delegate void Signature();

	private static bool OnBinkMediaPlayerMediaReachedEnd__DelegateSignature_IsValid;

	private static IntPtr OnBinkMediaPlayerMediaReachedEnd__DelegateSignature_FunctionAddress;

	private static int OnBinkMediaPlayerMediaReachedEnd__DelegateSignature_ParamsSize;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnBinkMediaPlayerMediaReachedEnd()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnBinkMediaPlayerMediaReachedEnd__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/BinkMediaPlayer.OnBinkMediaPlayerMediaReachedEnd__DelegateSignature");
		OnBinkMediaPlayerMediaReachedEnd__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnBinkMediaPlayerMediaReachedEnd__DelegateSignature_FunctionAddress);
		OnBinkMediaPlayerMediaReachedEnd__DelegateSignature_IsValid = OnBinkMediaPlayerMediaReachedEnd__DelegateSignature_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/BinkMediaPlayer.OnBinkMediaPlayerMediaReachedEnd__DelegateSignature", OnBinkMediaPlayerMediaReachedEnd__DelegateSignature_IsValid);
	}

	private unsafe void Invoker()
	{
		if (!OnBinkMediaPlayerMediaReachedEnd__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/BinkMediaPlayer.OnBinkMediaPlayerMediaReachedEnd__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnBinkMediaPlayerMediaReachedEnd__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnBinkMediaPlayerMediaReachedEnd__DelegateSignature_ParamsSize);
			IntPtr parameters = new IntPtr(ptr2);
			ProcessDelegate(parameters);
		}
	}
}
