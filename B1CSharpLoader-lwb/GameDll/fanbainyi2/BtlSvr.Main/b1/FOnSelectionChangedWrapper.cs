using System;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;
using UnrealEngine.UMG;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.FOnSelectionChangedWrapper")]
public class FOnSelectionChangedWrapper : UILRuntimeDelegateWrapperBase
{
	private static bool callback_IsValid;

	private static IntPtr callback_FunctionAddress;

	private static int callback_ParamsSize;

	private static bool callback_SelectedItem_IsValid;

	private static int callback_SelectedItem_Offset;

	private static FFieldAddress callback_SelectedItem_PropertyAddress;

	private static bool callback_SelectionType_IsValid;

	private static int callback_SelectionType_Offset;

	private static FFieldAddress callback_SelectionType_PropertyAddress;

	public override Delegate GetSignature()
	{
		return new UComboBoxString.FOnSelectionChangedEvent.Signature(callback);
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.FOnSelectionChangedWrapper:callback")]
	private void callback(string SelectedItem, ESelectInfo SelectionType)
	{
		((UComboBoxString.FOnSelectionChangedEvent.Signature)_action)(SelectedItem, SelectionType);
	}

	[UFunctionInvoker("/Script/b1-Managed.FOnSelectionChangedWrapper:callback")]
	private static void callback__Invoker(IntPtr buffer, IntPtr obj)
	{
		FOnSelectionChangedWrapper fOnSelectionChangedWrapper = GCHelper.Find<FOnSelectionChangedWrapper>(obj);
		string selectedItem = FStringMarshaler.FromNative(IntPtr.Add(buffer, callback_SelectedItem_Offset));
		ESelectInfo selectionType = EnumMarshaler<ESelectInfo>.FromNative(IntPtr.Add(buffer, callback_SelectionType_Offset), 0, callback_SelectionType_PropertyAddress.Address);
		fOnSelectionChangedWrapper.callback(selectedItem, selectionType);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.FOnSelectionChangedWrapper");
		callback_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "callback");
		callback_ParamsSize = NativeReflection.GetFunctionParamsSize(callback_FunctionAddress);
		NativeReflection.GetPropertyRef(ref callback_SelectedItem_PropertyAddress, callback_FunctionAddress, "SelectedItem");
		callback_SelectedItem_Offset = NativeReflection.GetPropertyOffset(callback_FunctionAddress, "SelectedItem");
		callback_SelectedItem_IsValid = NativeReflection.ValidatePropertyClass(callback_FunctionAddress, "SelectedItem", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref callback_SelectionType_PropertyAddress, callback_FunctionAddress, "SelectionType");
		callback_SelectionType_Offset = NativeReflection.GetPropertyOffset(callback_FunctionAddress, "SelectionType");
		callback_SelectionType_IsValid = NativeReflection.ValidatePropertyClass(callback_FunctionAddress, "SelectionType", Classes.FEnumProperty);
		callback_IsValid = callback_FunctionAddress != IntPtr.Zero && callback_SelectedItem_IsValid && callback_SelectionType_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.FOnSelectionChangedWrapper:callback", callback_IsValid);
	}

	static FOnSelectionChangedWrapper()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FOnSelectionChangedWrapper)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FOnSelectionChangedWrapper));
	}
}
