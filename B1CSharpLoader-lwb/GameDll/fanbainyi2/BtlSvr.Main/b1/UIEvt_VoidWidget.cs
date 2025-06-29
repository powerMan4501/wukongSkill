using System;
using b1.UI;
using UnrealEngine.Runtime;

namespace b1;

[UDelegate]
[USharpPath("/Script/b1-Managed.UIEvt_VoidWidget__DelegateSignature")]
public class UIEvt_VoidWidget : FDelegate<UIEvt_VoidWidget.Signature>
{
	public delegate void Signature(BUI_Widget Widget);

	private static bool Invoke_IsValid;

	private static IntPtr Invoke_FunctionAddress;

	private static int Invoke_ParamsSize;

	private static bool Invoke_Widget_IsValid;

	private static int Invoke_Widget_Offset;

	private unsafe void Invoker(BUI_Widget Widget)
	{
		if (!Invoke_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1-Managed.UIEvt_VoidWidget__DelegateSignature:Invoke");
		}
		else if (IsBound)
		{
			byte* value = stackalloc byte[(int)(uint)Invoke_ParamsSize];
			IntPtr intPtr = new IntPtr(value);
			FMemory.Memzero(intPtr, Invoke_ParamsSize);
			UObjectMarshaler<BUI_Widget>.ToNative(IntPtr.Add(intPtr, Invoke_Widget_Offset), Widget);
			ProcessDelegate(intPtr);
		}
	}

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	private static void LoadNativeType()
	{
		Invoke_FunctionAddress = NativeReflection.GetFunction("/Script/b1-Managed.UIEvt_VoidWidget__DelegateSignature");
		Invoke_ParamsSize = NativeReflection.GetFunctionParamsSize(Invoke_FunctionAddress);
		Invoke_Widget_Offset = NativeReflection.GetPropertyOffset(Invoke_FunctionAddress, "Widget");
		Invoke_Widget_IsValid = NativeReflection.ValidatePropertyClass(Invoke_FunctionAddress, "Widget", Classes.FObjectProperty);
		Invoke_IsValid = Invoke_FunctionAddress != IntPtr.Zero && Invoke_Widget_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.UIEvt_VoidWidget__DelegateSignature", Invoke_IsValid);
	}

	static UIEvt_VoidWidget()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(UIEvt_VoidWidget)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UIEvt_VoidWidget));
	}
}
