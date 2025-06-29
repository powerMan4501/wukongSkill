using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.UMG;

[UDelegate]
[UMetaPath("/Script/UMG.OnMouseCaptureBeginEvent__DelegateSignature")]
public class FOnMouseCaptureBeginEvent : FMulticastDelegate<FOnMouseCaptureBeginEvent.Signature>
{
	public delegate void Signature();

	private static bool OnMouseCaptureBeginEvent__DelegateSignature_IsValid;

	private static IntPtr OnMouseCaptureBeginEvent__DelegateSignature_FunctionAddress;

	private static int OnMouseCaptureBeginEvent__DelegateSignature_ParamsSize;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnMouseCaptureBeginEvent()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnMouseCaptureBeginEvent__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/UMG.OnMouseCaptureBeginEvent__DelegateSignature");
		OnMouseCaptureBeginEvent__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnMouseCaptureBeginEvent__DelegateSignature_FunctionAddress);
		OnMouseCaptureBeginEvent__DelegateSignature_IsValid = OnMouseCaptureBeginEvent__DelegateSignature_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UMG.OnMouseCaptureBeginEvent__DelegateSignature", OnMouseCaptureBeginEvent__DelegateSignature_IsValid);
	}

	private unsafe void Invoker()
	{
		if (!OnMouseCaptureBeginEvent__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.OnMouseCaptureBeginEvent__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnMouseCaptureBeginEvent__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnMouseCaptureBeginEvent__DelegateSignature_ParamsSize);
			IntPtr parameters = new IntPtr(ptr2);
			ProcessDelegate(parameters);
		}
	}
}
