using System;
using UnrealEngine.Runtime;
using UnrealEngine.Slate;
using UnrealEngine.UMG;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.FOnKeySelectedWrapper")]
public class FOnKeySelectedWrapper : UILRuntimeDelegateWrapperBase
{
	private static bool callback_IsValid;

	private static IntPtr callback_FunctionAddress;

	private static int callback_ParamsSize;

	private static bool callback_SelectedKey_IsValid;

	private static int callback_SelectedKey_Offset;

	private static FFieldAddress callback_SelectedKey_PropertyAddress;

	public override Delegate GetSignature()
	{
		return new UInputKeySelector.FOnKeySelected.Signature(callback);
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.FOnKeySelectedWrapper:callback")]
	private void callback(FInputChord SelectedKey)
	{
		((UInputKeySelector.FOnKeySelected.Signature)_action)(SelectedKey);
	}

	[UFunctionInvoker("/Script/b1-Managed.FOnKeySelectedWrapper:callback")]
	private static void callback__Invoker(IntPtr buffer, IntPtr obj)
	{
		FOnKeySelectedWrapper fOnKeySelectedWrapper = GCHelper.Find<FOnKeySelectedWrapper>(obj);
		FInputChord selectedKey = FInputChord.FromNative(IntPtr.Add(buffer, callback_SelectedKey_Offset));
		fOnKeySelectedWrapper.callback(selectedKey);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.FOnKeySelectedWrapper");
		callback_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "callback");
		callback_ParamsSize = NativeReflection.GetFunctionParamsSize(callback_FunctionAddress);
		NativeReflection.GetPropertyRef(ref callback_SelectedKey_PropertyAddress, callback_FunctionAddress, "SelectedKey");
		callback_SelectedKey_Offset = NativeReflection.GetPropertyOffset(callback_FunctionAddress, "SelectedKey");
		callback_SelectedKey_IsValid = NativeReflection.ValidatePropertyClass(callback_FunctionAddress, "SelectedKey", Classes.FStructProperty);
		callback_IsValid = callback_FunctionAddress != IntPtr.Zero && callback_SelectedKey_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.FOnKeySelectedWrapper:callback", callback_IsValid);
	}

	static FOnKeySelectedWrapper()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FOnKeySelectedWrapper)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FOnKeySelectedWrapper));
	}
}
