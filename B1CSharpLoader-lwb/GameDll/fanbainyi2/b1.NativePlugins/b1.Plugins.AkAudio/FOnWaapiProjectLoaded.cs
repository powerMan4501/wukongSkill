using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.AkAudio;

[UDelegate]
[UMetaPath("/Script/AkAudio.OnWaapiProjectLoaded__DelegateSignature")]
public class FOnWaapiProjectLoaded : FDelegate<FOnWaapiProjectLoaded.Signature>
{
	public delegate void Signature();

	private static bool OnWaapiProjectLoaded__DelegateSignature_IsValid;

	private static IntPtr OnWaapiProjectLoaded__DelegateSignature_FunctionAddress;

	private static int OnWaapiProjectLoaded__DelegateSignature_ParamsSize;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnWaapiProjectLoaded()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnWaapiProjectLoaded__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/AkAudio.OnWaapiProjectLoaded__DelegateSignature");
		OnWaapiProjectLoaded__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnWaapiProjectLoaded__DelegateSignature_FunctionAddress);
		OnWaapiProjectLoaded__DelegateSignature_IsValid = OnWaapiProjectLoaded__DelegateSignature_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.OnWaapiProjectLoaded__DelegateSignature", OnWaapiProjectLoaded__DelegateSignature_IsValid);
	}

	private unsafe void Invoker()
	{
		if (!OnWaapiProjectLoaded__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.OnWaapiProjectLoaded__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnWaapiProjectLoaded__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnWaapiProjectLoaded__DelegateSignature_ParamsSize);
			IntPtr parameters = new IntPtr(ptr2);
			ProcessDelegate(parameters);
		}
	}
}
