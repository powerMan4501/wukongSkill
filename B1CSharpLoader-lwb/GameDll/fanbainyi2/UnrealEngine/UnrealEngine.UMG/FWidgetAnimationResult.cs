using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.UMG;

[UDelegate]
[UMetaPath("/Script/UMG.WidgetAnimationResult__DelegateSignature")]
public class FWidgetAnimationResult : FMulticastDelegate<FWidgetAnimationResult.Signature>
{
	public delegate void Signature();

	private static bool WidgetAnimationResult__DelegateSignature_IsValid;

	private static IntPtr WidgetAnimationResult__DelegateSignature_FunctionAddress;

	private static int WidgetAnimationResult__DelegateSignature_ParamsSize;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FWidgetAnimationResult()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		WidgetAnimationResult__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/UMG.WidgetAnimationResult__DelegateSignature");
		WidgetAnimationResult__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(WidgetAnimationResult__DelegateSignature_FunctionAddress);
		WidgetAnimationResult__DelegateSignature_IsValid = WidgetAnimationResult__DelegateSignature_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WidgetAnimationResult__DelegateSignature", WidgetAnimationResult__DelegateSignature_IsValid);
	}

	private unsafe void Invoker()
	{
		if (!WidgetAnimationResult__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WidgetAnimationResult__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(WidgetAnimationResult__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)WidgetAnimationResult__DelegateSignature_ParamsSize);
			IntPtr parameters = new IntPtr(ptr2);
			ProcessDelegate(parameters);
		}
	}
}
