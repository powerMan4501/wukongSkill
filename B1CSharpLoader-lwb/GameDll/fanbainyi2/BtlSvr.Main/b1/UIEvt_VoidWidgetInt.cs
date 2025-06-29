using System;
using b1.UI;
using UnrealEngine.Runtime;

namespace b1;

[UDelegate]
[USharpPath("/Script/b1-Managed.UIEvt_VoidWidgetInt__DelegateSignature")]
public class UIEvt_VoidWidgetInt : FDelegate<UIEvt_VoidWidgetInt.Signature>
{
	public delegate void Signature(BUI_Widget Widget, int ParamInt);

	private static bool Invoke_IsValid;

	private static IntPtr Invoke_FunctionAddress;

	private static int Invoke_ParamsSize;

	private static bool Invoke_Widget_IsValid;

	private static int Invoke_Widget_Offset;

	private static bool Invoke_ParamInt_IsValid;

	private static int Invoke_ParamInt_Offset;

	private unsafe void Invoker(BUI_Widget Widget, int ParamInt)
	{
		if (!Invoke_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1-Managed.UIEvt_VoidWidgetInt__DelegateSignature:Invoke");
		}
		else if (IsBound)
		{
			byte* value = stackalloc byte[(int)(uint)Invoke_ParamsSize];
			IntPtr intPtr = new IntPtr(value);
			FMemory.Memzero(intPtr, Invoke_ParamsSize);
			UObjectMarshaler<BUI_Widget>.ToNative(IntPtr.Add(intPtr, Invoke_Widget_Offset), Widget);
			BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, Invoke_ParamInt_Offset), ParamInt);
			ProcessDelegate(intPtr);
		}
	}

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	private static void LoadNativeType()
	{
		Invoke_FunctionAddress = NativeReflection.GetFunction("/Script/b1-Managed.UIEvt_VoidWidgetInt__DelegateSignature");
		Invoke_ParamsSize = NativeReflection.GetFunctionParamsSize(Invoke_FunctionAddress);
		Invoke_Widget_Offset = NativeReflection.GetPropertyOffset(Invoke_FunctionAddress, "Widget");
		Invoke_Widget_IsValid = NativeReflection.ValidatePropertyClass(Invoke_FunctionAddress, "Widget", Classes.FObjectProperty);
		Invoke_ParamInt_Offset = NativeReflection.GetPropertyOffset(Invoke_FunctionAddress, "ParamInt");
		Invoke_ParamInt_IsValid = NativeReflection.ValidatePropertyClass(Invoke_FunctionAddress, "ParamInt", Classes.FIntProperty);
		Invoke_IsValid = Invoke_FunctionAddress != IntPtr.Zero && Invoke_Widget_IsValid && Invoke_ParamInt_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.UIEvt_VoidWidgetInt__DelegateSignature", Invoke_IsValid);
	}

	static UIEvt_VoidWidgetInt()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(UIEvt_VoidWidgetInt)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UIEvt_VoidWidgetInt));
	}
}
