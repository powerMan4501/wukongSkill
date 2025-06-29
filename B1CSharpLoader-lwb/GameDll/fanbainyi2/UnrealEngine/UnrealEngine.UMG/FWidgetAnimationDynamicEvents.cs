using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.UMG;

[UDelegate]
[UMetaPath("/Script/UMG.WidgetAnimationDynamicEvents__DelegateSignature")]
public class FWidgetAnimationDynamicEvents : FMulticastDelegate<FWidgetAnimationDynamicEvents.Signature>
{
	public delegate void Signature();

	private static bool WidgetAnimationDynamicEvents__DelegateSignature_IsValid;

	private static IntPtr WidgetAnimationDynamicEvents__DelegateSignature_FunctionAddress;

	private static int WidgetAnimationDynamicEvents__DelegateSignature_ParamsSize;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FWidgetAnimationDynamicEvents()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		WidgetAnimationDynamicEvents__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/UMG.WidgetAnimationDynamicEvents__DelegateSignature");
		WidgetAnimationDynamicEvents__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(WidgetAnimationDynamicEvents__DelegateSignature_FunctionAddress);
		WidgetAnimationDynamicEvents__DelegateSignature_IsValid = WidgetAnimationDynamicEvents__DelegateSignature_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WidgetAnimationDynamicEvents__DelegateSignature", WidgetAnimationDynamicEvents__DelegateSignature_IsValid);
	}

	private unsafe void Invoker()
	{
		if (!WidgetAnimationDynamicEvents__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WidgetAnimationDynamicEvents__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(WidgetAnimationDynamicEvents__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)WidgetAnimationDynamicEvents__DelegateSignature_ParamsSize);
			IntPtr parameters = new IntPtr(ptr2);
			ProcessDelegate(parameters);
		}
	}
}
