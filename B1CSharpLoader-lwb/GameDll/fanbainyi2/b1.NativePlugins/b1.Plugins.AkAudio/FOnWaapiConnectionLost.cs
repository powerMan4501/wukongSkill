using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.AkAudio;

[UDelegate]
[UMetaPath("/Script/AkAudio.OnWaapiConnectionLost__DelegateSignature")]
public class FOnWaapiConnectionLost : FDelegate<FOnWaapiConnectionLost.Signature>
{
	public delegate void Signature();

	private static bool OnWaapiConnectionLost__DelegateSignature_IsValid;

	private static IntPtr OnWaapiConnectionLost__DelegateSignature_FunctionAddress;

	private static int OnWaapiConnectionLost__DelegateSignature_ParamsSize;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnWaapiConnectionLost()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnWaapiConnectionLost__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/AkAudio.OnWaapiConnectionLost__DelegateSignature");
		OnWaapiConnectionLost__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnWaapiConnectionLost__DelegateSignature_FunctionAddress);
		OnWaapiConnectionLost__DelegateSignature_IsValid = OnWaapiConnectionLost__DelegateSignature_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.OnWaapiConnectionLost__DelegateSignature", OnWaapiConnectionLost__DelegateSignature_IsValid);
	}

	private unsafe void Invoker()
	{
		if (!OnWaapiConnectionLost__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.OnWaapiConnectionLost__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnWaapiConnectionLost__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnWaapiConnectionLost__DelegateSignature_ParamsSize);
			IntPtr parameters = new IntPtr(ptr2);
			ProcessDelegate(parameters);
		}
	}
}
