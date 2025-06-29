using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Synthesis;

[UDelegate]
[UMetaPath("/Script/Synthesis.OnMouseCaptureEndEventSynth2D__DelegateSignature")]
public class FOnMouseCaptureEndEventSynth2D : FMulticastDelegate<FOnMouseCaptureEndEventSynth2D.Signature>
{
	public delegate void Signature();

	private static bool OnMouseCaptureEndEventSynth2D__DelegateSignature_IsValid;

	private static IntPtr OnMouseCaptureEndEventSynth2D__DelegateSignature_FunctionAddress;

	private static int OnMouseCaptureEndEventSynth2D__DelegateSignature_ParamsSize;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnMouseCaptureEndEventSynth2D()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnMouseCaptureEndEventSynth2D__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Synthesis.OnMouseCaptureEndEventSynth2D__DelegateSignature");
		OnMouseCaptureEndEventSynth2D__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnMouseCaptureEndEventSynth2D__DelegateSignature_FunctionAddress);
		OnMouseCaptureEndEventSynth2D__DelegateSignature_IsValid = OnMouseCaptureEndEventSynth2D__DelegateSignature_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.OnMouseCaptureEndEventSynth2D__DelegateSignature", OnMouseCaptureEndEventSynth2D__DelegateSignature_IsValid);
	}

	private unsafe void Invoker()
	{
		if (!OnMouseCaptureEndEventSynth2D__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.OnMouseCaptureEndEventSynth2D__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnMouseCaptureEndEventSynth2D__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnMouseCaptureEndEventSynth2D__DelegateSignature_ParamsSize);
			IntPtr parameters = new IntPtr(ptr2);
			ProcessDelegate(parameters);
		}
	}
}
