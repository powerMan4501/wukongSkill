using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Synthesis;

[UDelegate]
[UMetaPath("/Script/Synthesis.OnControllerCaptureBeginEventSynth2D__DelegateSignature")]
public class FOnControllerCaptureBeginEventSynth2D : FMulticastDelegate<FOnControllerCaptureBeginEventSynth2D.Signature>
{
	public delegate void Signature();

	private static bool OnControllerCaptureBeginEventSynth2D__DelegateSignature_IsValid;

	private static IntPtr OnControllerCaptureBeginEventSynth2D__DelegateSignature_FunctionAddress;

	private static int OnControllerCaptureBeginEventSynth2D__DelegateSignature_ParamsSize;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnControllerCaptureBeginEventSynth2D()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnControllerCaptureBeginEventSynth2D__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Synthesis.OnControllerCaptureBeginEventSynth2D__DelegateSignature");
		OnControllerCaptureBeginEventSynth2D__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnControllerCaptureBeginEventSynth2D__DelegateSignature_FunctionAddress);
		OnControllerCaptureBeginEventSynth2D__DelegateSignature_IsValid = OnControllerCaptureBeginEventSynth2D__DelegateSignature_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.OnControllerCaptureBeginEventSynth2D__DelegateSignature", OnControllerCaptureBeginEventSynth2D__DelegateSignature_IsValid);
	}

	private unsafe void Invoker()
	{
		if (!OnControllerCaptureBeginEventSynth2D__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.OnControllerCaptureBeginEventSynth2D__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnControllerCaptureBeginEventSynth2D__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnControllerCaptureBeginEventSynth2D__DelegateSignature_ParamsSize);
			IntPtr parameters = new IntPtr(ptr2);
			ProcessDelegate(parameters);
		}
	}
}
