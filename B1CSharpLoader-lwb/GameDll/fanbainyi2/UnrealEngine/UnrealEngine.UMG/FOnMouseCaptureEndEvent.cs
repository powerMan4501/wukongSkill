using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.UMG;

[UDelegate]
[UMetaPath("/Script/UMG.OnMouseCaptureEndEvent__DelegateSignature")]
public class FOnMouseCaptureEndEvent : FMulticastDelegate<FOnMouseCaptureEndEvent.Signature>
{
	public delegate void Signature();

	private static bool OnMouseCaptureEndEvent__DelegateSignature_IsValid;

	private static IntPtr OnMouseCaptureEndEvent__DelegateSignature_FunctionAddress;

	private static int OnMouseCaptureEndEvent__DelegateSignature_ParamsSize;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnMouseCaptureEndEvent()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnMouseCaptureEndEvent__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/UMG.OnMouseCaptureEndEvent__DelegateSignature");
		OnMouseCaptureEndEvent__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnMouseCaptureEndEvent__DelegateSignature_FunctionAddress);
		OnMouseCaptureEndEvent__DelegateSignature_IsValid = OnMouseCaptureEndEvent__DelegateSignature_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UMG.OnMouseCaptureEndEvent__DelegateSignature", OnMouseCaptureEndEvent__DelegateSignature_IsValid);
	}

	private unsafe void Invoker()
	{
		if (!OnMouseCaptureEndEvent__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.OnMouseCaptureEndEvent__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnMouseCaptureEndEvent__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnMouseCaptureEndEvent__DelegateSignature_ParamsSize);
			IntPtr parameters = new IntPtr(ptr2);
			ProcessDelegate(parameters);
		}
	}
}
