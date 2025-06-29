using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Synthesis;

[UDelegate]
[UMetaPath("/Script/Synthesis.OnControllerCaptureEndEvent__DelegateSignature")]
public class FOnControllerCaptureEndEvent : FMulticastDelegate<FOnControllerCaptureEndEvent.Signature>
{
	public delegate void Signature();

	private static bool OnControllerCaptureEndEvent__DelegateSignature_IsValid;

	private static IntPtr OnControllerCaptureEndEvent__DelegateSignature_FunctionAddress;

	private static int OnControllerCaptureEndEvent__DelegateSignature_ParamsSize;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnControllerCaptureEndEvent()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnControllerCaptureEndEvent__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Synthesis.OnControllerCaptureEndEvent__DelegateSignature");
		OnControllerCaptureEndEvent__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnControllerCaptureEndEvent__DelegateSignature_FunctionAddress);
		OnControllerCaptureEndEvent__DelegateSignature_IsValid = OnControllerCaptureEndEvent__DelegateSignature_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.OnControllerCaptureEndEvent__DelegateSignature", OnControllerCaptureEndEvent__DelegateSignature_IsValid);
	}

	private unsafe void Invoker()
	{
		if (!OnControllerCaptureEndEvent__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.OnControllerCaptureEndEvent__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnControllerCaptureEndEvent__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnControllerCaptureEndEvent__DelegateSignature_ParamsSize);
			IntPtr parameters = new IntPtr(ptr2);
			ProcessDelegate(parameters);
		}
	}
}
