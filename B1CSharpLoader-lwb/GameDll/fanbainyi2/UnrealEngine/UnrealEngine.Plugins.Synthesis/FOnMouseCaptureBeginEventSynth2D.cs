using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Synthesis;

[UDelegate]
[UMetaPath("/Script/Synthesis.OnMouseCaptureBeginEventSynth2D__DelegateSignature")]
public class FOnMouseCaptureBeginEventSynth2D : FMulticastDelegate<FOnMouseCaptureBeginEventSynth2D.Signature>
{
	public delegate void Signature();

	private static bool OnMouseCaptureBeginEventSynth2D__DelegateSignature_IsValid;

	private static IntPtr OnMouseCaptureBeginEventSynth2D__DelegateSignature_FunctionAddress;

	private static int OnMouseCaptureBeginEventSynth2D__DelegateSignature_ParamsSize;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnMouseCaptureBeginEventSynth2D()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnMouseCaptureBeginEventSynth2D__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Synthesis.OnMouseCaptureBeginEventSynth2D__DelegateSignature");
		OnMouseCaptureBeginEventSynth2D__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnMouseCaptureBeginEventSynth2D__DelegateSignature_FunctionAddress);
		OnMouseCaptureBeginEventSynth2D__DelegateSignature_IsValid = OnMouseCaptureBeginEventSynth2D__DelegateSignature_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.OnMouseCaptureBeginEventSynth2D__DelegateSignature", OnMouseCaptureBeginEventSynth2D__DelegateSignature_IsValid);
	}

	private unsafe void Invoker()
	{
		if (!OnMouseCaptureBeginEventSynth2D__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.OnMouseCaptureBeginEventSynth2D__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnMouseCaptureBeginEventSynth2D__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnMouseCaptureBeginEventSynth2D__DelegateSignature_ParamsSize);
			IntPtr parameters = new IntPtr(ptr2);
			ProcessDelegate(parameters);
		}
	}
}
