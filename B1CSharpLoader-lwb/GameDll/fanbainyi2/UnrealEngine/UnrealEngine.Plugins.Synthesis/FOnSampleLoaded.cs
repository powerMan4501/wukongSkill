using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Synthesis;

[UDelegate]
[UMetaPath("/Script/Synthesis.OnSampleLoaded__DelegateSignature")]
public class FOnSampleLoaded : FMulticastDelegate<FOnSampleLoaded.Signature>
{
	public delegate void Signature();

	private static bool OnSampleLoaded__DelegateSignature_IsValid;

	private static IntPtr OnSampleLoaded__DelegateSignature_FunctionAddress;

	private static int OnSampleLoaded__DelegateSignature_ParamsSize;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnSampleLoaded()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnSampleLoaded__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Synthesis.OnSampleLoaded__DelegateSignature");
		OnSampleLoaded__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnSampleLoaded__DelegateSignature_FunctionAddress);
		OnSampleLoaded__DelegateSignature_IsValid = OnSampleLoaded__DelegateSignature_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.OnSampleLoaded__DelegateSignature", OnSampleLoaded__DelegateSignature_IsValid);
	}

	private unsafe void Invoker()
	{
		if (!OnSampleLoaded__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.OnSampleLoaded__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnSampleLoaded__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnSampleLoaded__DelegateSignature_ParamsSize);
			IntPtr parameters = new IntPtr(ptr2);
			ProcessDelegate(parameters);
		}
	}
}
