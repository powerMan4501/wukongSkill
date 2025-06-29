using System;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.FOnMultiLineEditableTextChangedEventWrapper")]
public class FOnMultiLineEditableTextChangedEventWrapper : UILRuntimeDelegateWrapperBase
{
	private static bool callback_IsValid;

	private static IntPtr callback_FunctionAddress;

	private static int callback_ParamsSize;

	private static bool callback_Text_IsValid;

	private static int callback_Text_Offset;

	private static FFieldAddress callback_Text_PropertyAddress;

	public override Delegate GetSignature()
	{
		return new UMultiLineEditableText.FOnMultiLineEditableTextChangedEvent.Signature(callback);
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.FOnMultiLineEditableTextChangedEventWrapper:callback")]
	private void callback(FText Text)
	{
		((UMultiLineEditableText.FOnMultiLineEditableTextChangedEvent.Signature)_action)(Text);
	}

	[UFunctionInvoker("/Script/b1-Managed.FOnMultiLineEditableTextChangedEventWrapper:callback")]
	private static void callback__Invoker(IntPtr buffer, IntPtr obj)
	{
		FOnMultiLineEditableTextChangedEventWrapper fOnMultiLineEditableTextChangedEventWrapper = GCHelper.Find<FOnMultiLineEditableTextChangedEventWrapper>(obj);
		FText text = FTextMarshaler.FromNative(IntPtr.Add(buffer, callback_Text_Offset));
		fOnMultiLineEditableTextChangedEventWrapper.callback(text);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.FOnMultiLineEditableTextChangedEventWrapper");
		callback_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "callback");
		callback_ParamsSize = NativeReflection.GetFunctionParamsSize(callback_FunctionAddress);
		NativeReflection.GetPropertyRef(ref callback_Text_PropertyAddress, callback_FunctionAddress, "Text");
		callback_Text_Offset = NativeReflection.GetPropertyOffset(callback_FunctionAddress, "Text");
		callback_Text_IsValid = NativeReflection.ValidatePropertyClass(callback_FunctionAddress, "Text", Classes.FTextProperty);
		callback_IsValid = callback_FunctionAddress != IntPtr.Zero && callback_Text_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.FOnMultiLineEditableTextChangedEventWrapper:callback", callback_IsValid);
	}

	static FOnMultiLineEditableTextChangedEventWrapper()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FOnMultiLineEditableTextChangedEventWrapper)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FOnMultiLineEditableTextChangedEventWrapper));
	}
}
