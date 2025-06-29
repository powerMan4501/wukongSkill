using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.MediaAssets;

[UDelegate]
[UMetaPath("/Script/MediaAssets.OnMediaPlayerMediaEvent__DelegateSignature")]
public class FOnMediaPlayerMediaEvent : FMulticastDelegate<FOnMediaPlayerMediaEvent.Signature>
{
	public delegate void Signature();

	private static bool OnMediaPlayerMediaEvent__DelegateSignature_IsValid;

	private static IntPtr OnMediaPlayerMediaEvent__DelegateSignature_FunctionAddress;

	private static int OnMediaPlayerMediaEvent__DelegateSignature_ParamsSize;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnMediaPlayerMediaEvent()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnMediaPlayerMediaEvent__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/MediaAssets.OnMediaPlayerMediaEvent__DelegateSignature");
		OnMediaPlayerMediaEvent__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnMediaPlayerMediaEvent__DelegateSignature_FunctionAddress);
		OnMediaPlayerMediaEvent__DelegateSignature_IsValid = OnMediaPlayerMediaEvent__DelegateSignature_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/MediaAssets.OnMediaPlayerMediaEvent__DelegateSignature", OnMediaPlayerMediaEvent__DelegateSignature_IsValid);
	}

	private unsafe void Invoker()
	{
		if (!OnMediaPlayerMediaEvent__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MediaAssets.OnMediaPlayerMediaEvent__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnMediaPlayerMediaEvent__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnMediaPlayerMediaEvent__DelegateSignature_ParamsSize);
			IntPtr parameters = new IntPtr(ptr2);
			ProcessDelegate(parameters);
		}
	}
}
