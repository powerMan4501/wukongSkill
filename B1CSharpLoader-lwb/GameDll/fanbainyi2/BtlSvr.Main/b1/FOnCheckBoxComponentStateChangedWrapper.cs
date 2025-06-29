using System;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.FOnCheckBoxComponentStateChangedWrapper")]
public class FOnCheckBoxComponentStateChangedWrapper : UILRuntimeDelegateWrapperBase
{
	private static bool callback_IsValid;

	private static IntPtr callback_FunctionAddress;

	private static int callback_ParamsSize;

	private static bool callback_bIsChecked_IsValid;

	private static int callback_bIsChecked_Offset;

	private static FFieldAddress callback_bIsChecked_PropertyAddress;

	public override Delegate GetSignature()
	{
		return new FOnCheckBoxComponentStateChanged.Signature(callback);
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.FOnCheckBoxComponentStateChangedWrapper:callback")]
	private void callback(bool bIsChecked)
	{
		((FOnCheckBoxComponentStateChanged.Signature)_action)(bIsChecked);
	}

	[UFunctionInvoker("/Script/b1-Managed.FOnCheckBoxComponentStateChangedWrapper:callback")]
	private static void callback__Invoker(IntPtr buffer, IntPtr obj)
	{
		FOnCheckBoxComponentStateChangedWrapper fOnCheckBoxComponentStateChangedWrapper = GCHelper.Find<FOnCheckBoxComponentStateChangedWrapper>(obj);
		bool bIsChecked = BoolMarshaler.FromNative(IntPtr.Add(buffer, callback_bIsChecked_Offset), 0, callback_bIsChecked_PropertyAddress.Address);
		fOnCheckBoxComponentStateChangedWrapper.callback(bIsChecked);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.FOnCheckBoxComponentStateChangedWrapper");
		callback_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "callback");
		callback_ParamsSize = NativeReflection.GetFunctionParamsSize(callback_FunctionAddress);
		NativeReflection.GetPropertyRef(ref callback_bIsChecked_PropertyAddress, callback_FunctionAddress, "bIsChecked");
		callback_bIsChecked_Offset = NativeReflection.GetPropertyOffset(callback_FunctionAddress, "bIsChecked");
		callback_bIsChecked_IsValid = NativeReflection.ValidatePropertyClass(callback_FunctionAddress, "bIsChecked", Classes.FBoolProperty);
		callback_IsValid = callback_FunctionAddress != IntPtr.Zero && callback_bIsChecked_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.FOnCheckBoxComponentStateChangedWrapper:callback", callback_IsValid);
	}

	static FOnCheckBoxComponentStateChangedWrapper()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FOnCheckBoxComponentStateChangedWrapper)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FOnCheckBoxComponentStateChangedWrapper));
	}
}
