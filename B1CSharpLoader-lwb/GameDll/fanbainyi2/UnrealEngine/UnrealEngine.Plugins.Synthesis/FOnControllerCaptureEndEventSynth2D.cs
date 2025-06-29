using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Synthesis;

[UDelegate]
[UMetaPath("/Script/Synthesis.OnControllerCaptureEndEventSynth2D__DelegateSignature")]
public class FOnControllerCaptureEndEventSynth2D : FMulticastDelegate<FOnControllerCaptureEndEventSynth2D.Signature>
{
	public delegate void Signature();

	private static bool OnControllerCaptureEndEventSynth2D__DelegateSignature_IsValid;

	private static IntPtr OnControllerCaptureEndEventSynth2D__DelegateSignature_FunctionAddress;

	private static int OnControllerCaptureEndEventSynth2D__DelegateSignature_ParamsSize;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnControllerCaptureEndEventSynth2D()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnControllerCaptureEndEventSynth2D__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Synthesis.OnControllerCaptureEndEventSynth2D__DelegateSignature");
		OnControllerCaptureEndEventSynth2D__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnControllerCaptureEndEventSynth2D__DelegateSignature_FunctionAddress);
		OnControllerCaptureEndEventSynth2D__DelegateSignature_IsValid = OnControllerCaptureEndEventSynth2D__DelegateSignature_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.OnControllerCaptureEndEventSynth2D__DelegateSignature", OnControllerCaptureEndEventSynth2D__DelegateSignature_IsValid);
	}

	private unsafe void Invoker()
	{
		if (!OnControllerCaptureEndEventSynth2D__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.OnControllerCaptureEndEventSynth2D__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnControllerCaptureEndEventSynth2D__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnControllerCaptureEndEventSynth2D__DelegateSignature_ParamsSize);
			IntPtr parameters = new IntPtr(ptr2);
			ProcessDelegate(parameters);
		}
	}
}
