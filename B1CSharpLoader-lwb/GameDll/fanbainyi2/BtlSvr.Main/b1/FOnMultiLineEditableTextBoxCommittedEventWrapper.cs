using System;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;
using UnrealEngine.UMG;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.FOnMultiLineEditableTextBoxCommittedEventWrapper")]
public class FOnMultiLineEditableTextBoxCommittedEventWrapper : UILRuntimeDelegateWrapperBase
{
	private static bool callback_IsValid;

	private static IntPtr callback_FunctionAddress;

	private static int callback_ParamsSize;

	private static bool callback_Text_IsValid;

	private static int callback_Text_Offset;

	private static FFieldAddress callback_Text_PropertyAddress;

	private static bool callback_CommitMethod_IsValid;

	private static int callback_CommitMethod_Offset;

	private static FFieldAddress callback_CommitMethod_PropertyAddress;

	public override Delegate GetSignature()
	{
		return new UMultiLineEditableTextBox.FOnMultiLineEditableTextBoxCommittedEvent.Signature(callback);
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.FOnMultiLineEditableTextBoxCommittedEventWrapper:callback")]
	private void callback(FText Text, ETextCommit CommitMethod)
	{
		((UMultiLineEditableTextBox.FOnMultiLineEditableTextBoxCommittedEvent.Signature)_action)(Text, CommitMethod);
	}

	[UFunctionInvoker("/Script/b1-Managed.FOnMultiLineEditableTextBoxCommittedEventWrapper:callback")]
	private static void callback__Invoker(IntPtr buffer, IntPtr obj)
	{
		FOnMultiLineEditableTextBoxCommittedEventWrapper fOnMultiLineEditableTextBoxCommittedEventWrapper = GCHelper.Find<FOnMultiLineEditableTextBoxCommittedEventWrapper>(obj);
		FText text = FTextMarshaler.FromNative(IntPtr.Add(buffer, callback_Text_Offset));
		ETextCommit commitMethod = EnumMarshaler<ETextCommit>.FromNative(IntPtr.Add(buffer, callback_CommitMethod_Offset), 0, callback_CommitMethod_PropertyAddress.Address);
		fOnMultiLineEditableTextBoxCommittedEventWrapper.callback(text, commitMethod);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.FOnMultiLineEditableTextBoxCommittedEventWrapper");
		callback_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "callback");
		callback_ParamsSize = NativeReflection.GetFunctionParamsSize(callback_FunctionAddress);
		NativeReflection.GetPropertyRef(ref callback_Text_PropertyAddress, callback_FunctionAddress, "Text");
		callback_Text_Offset = NativeReflection.GetPropertyOffset(callback_FunctionAddress, "Text");
		callback_Text_IsValid = NativeReflection.ValidatePropertyClass(callback_FunctionAddress, "Text", Classes.FTextProperty);
		NativeReflection.GetPropertyRef(ref callback_CommitMethod_PropertyAddress, callback_FunctionAddress, "CommitMethod");
		callback_CommitMethod_Offset = NativeReflection.GetPropertyOffset(callback_FunctionAddress, "CommitMethod");
		callback_CommitMethod_IsValid = NativeReflection.ValidatePropertyClass(callback_FunctionAddress, "CommitMethod", Classes.FEnumProperty);
		callback_IsValid = callback_FunctionAddress != IntPtr.Zero && callback_Text_IsValid && callback_CommitMethod_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.FOnMultiLineEditableTextBoxCommittedEventWrapper:callback", callback_IsValid);
	}

	static FOnMultiLineEditableTextBoxCommittedEventWrapper()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FOnMultiLineEditableTextBoxCommittedEventWrapper)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FOnMultiLineEditableTextBoxCommittedEventWrapper));
	}
}
