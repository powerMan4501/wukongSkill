using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.UMG;

[UDelegate]
[UMetaPath("/Script/UMG.WidgetAnimationDynamicEvent__DelegateSignature")]
public class FWidgetAnimationDynamicEvent : FDelegate<FWidgetAnimationDynamicEvent.Signature>
{
	public delegate void Signature();

	private static bool WidgetAnimationDynamicEvent__DelegateSignature_IsValid;

	private static IntPtr WidgetAnimationDynamicEvent__DelegateSignature_FunctionAddress;

	private static int WidgetAnimationDynamicEvent__DelegateSignature_ParamsSize;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FWidgetAnimationDynamicEvent()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		WidgetAnimationDynamicEvent__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/UMG.WidgetAnimationDynamicEvent__DelegateSignature");
		WidgetAnimationDynamicEvent__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(WidgetAnimationDynamicEvent__DelegateSignature_FunctionAddress);
		WidgetAnimationDynamicEvent__DelegateSignature_IsValid = WidgetAnimationDynamicEvent__DelegateSignature_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WidgetAnimationDynamicEvent__DelegateSignature", WidgetAnimationDynamicEvent__DelegateSignature_IsValid);
	}

	private unsafe void Invoker()
	{
		if (!WidgetAnimationDynamicEvent__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WidgetAnimationDynamicEvent__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(WidgetAnimationDynamicEvent__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)WidgetAnimationDynamicEvent__DelegateSignature_ParamsSize);
			IntPtr parameters = new IntPtr(ptr2);
			ProcessDelegate(parameters);
		}
	}
}
