using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.BinkMediaPlayer;

[UDelegate]
[UMetaPath("/Script/BinkMediaPlayer.OnBinkMediaPlayerMediaEvent__DelegateSignature")]
public class FOnBinkMediaPlayerMediaEvent : FMulticastDelegate<FOnBinkMediaPlayerMediaEvent.Signature>
{
	public delegate void Signature();

	private static bool OnBinkMediaPlayerMediaEvent__DelegateSignature_IsValid;

	private static IntPtr OnBinkMediaPlayerMediaEvent__DelegateSignature_FunctionAddress;

	private static int OnBinkMediaPlayerMediaEvent__DelegateSignature_ParamsSize;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnBinkMediaPlayerMediaEvent()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnBinkMediaPlayerMediaEvent__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/BinkMediaPlayer.OnBinkMediaPlayerMediaEvent__DelegateSignature");
		OnBinkMediaPlayerMediaEvent__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnBinkMediaPlayerMediaEvent__DelegateSignature_FunctionAddress);
		OnBinkMediaPlayerMediaEvent__DelegateSignature_IsValid = OnBinkMediaPlayerMediaEvent__DelegateSignature_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/BinkMediaPlayer.OnBinkMediaPlayerMediaEvent__DelegateSignature", OnBinkMediaPlayerMediaEvent__DelegateSignature_IsValid);
	}

	private unsafe void Invoker()
	{
		if (!OnBinkMediaPlayerMediaEvent__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/BinkMediaPlayer.OnBinkMediaPlayerMediaEvent__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnBinkMediaPlayerMediaEvent__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnBinkMediaPlayerMediaEvent__DelegateSignature_ParamsSize);
			IntPtr parameters = new IntPtr(ptr2);
			ProcessDelegate(parameters);
		}
	}
}
