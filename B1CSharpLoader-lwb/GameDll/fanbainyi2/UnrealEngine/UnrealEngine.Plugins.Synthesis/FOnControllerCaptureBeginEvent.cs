using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Synthesis;

[UDelegate]
[UMetaPath("/Script/Synthesis.OnControllerCaptureBeginEvent__DelegateSignature")]
public class FOnControllerCaptureBeginEvent : FMulticastDelegate<FOnControllerCaptureBeginEvent.Signature>
{
	public delegate void Signature();

	private static bool OnControllerCaptureBeginEvent__DelegateSignature_IsValid;

	private static IntPtr OnControllerCaptureBeginEvent__DelegateSignature_FunctionAddress;

	private static int OnControllerCaptureBeginEvent__DelegateSignature_ParamsSize;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnControllerCaptureBeginEvent()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnControllerCaptureBeginEvent__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Synthesis.OnControllerCaptureBeginEvent__DelegateSignature");
		OnControllerCaptureBeginEvent__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnControllerCaptureBeginEvent__DelegateSignature_FunctionAddress);
		OnControllerCaptureBeginEvent__DelegateSignature_IsValid = OnControllerCaptureBeginEvent__DelegateSignature_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.OnControllerCaptureBeginEvent__DelegateSignature", OnControllerCaptureBeginEvent__DelegateSignature_IsValid);
	}

	private unsafe void Invoker()
	{
		if (!OnControllerCaptureBeginEvent__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.OnControllerCaptureBeginEvent__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnControllerCaptureBeginEvent__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnControllerCaptureBeginEvent__DelegateSignature_ParamsSize);
			IntPtr parameters = new IntPtr(ptr2);
			ProcessDelegate(parameters);
		}
	}
}
