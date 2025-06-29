using System;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.FOnFloatValueChangedEventWrapper")]
public class FOnFloatValueChangedEventWrapper : UILRuntimeDelegateWrapperBase
{
	private static bool callback_IsValid;

	private static IntPtr callback_FunctionAddress;

	private static int callback_ParamsSize;

	private static bool callback_Value_IsValid;

	private static int callback_Value_Offset;

	public override Delegate GetSignature()
	{
		return new FOnFloatValueChangedEvent.Signature(callback);
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.FOnFloatValueChangedEventWrapper:callback")]
	private void callback(float Value)
	{
		((FOnFloatValueChangedEvent.Signature)_action)(Value);
	}

	[UFunctionInvoker("/Script/b1-Managed.FOnFloatValueChangedEventWrapper:callback")]
	private static void callback__Invoker(IntPtr buffer, IntPtr obj)
	{
		FOnFloatValueChangedEventWrapper fOnFloatValueChangedEventWrapper = GCHelper.Find<FOnFloatValueChangedEventWrapper>(obj);
		float value = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, callback_Value_Offset));
		fOnFloatValueChangedEventWrapper.callback(value);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.FOnFloatValueChangedEventWrapper");
		callback_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "callback");
		callback_ParamsSize = NativeReflection.GetFunctionParamsSize(callback_FunctionAddress);
		callback_Value_Offset = NativeReflection.GetPropertyOffset(callback_FunctionAddress, "Value");
		callback_Value_IsValid = NativeReflection.ValidatePropertyClass(callback_FunctionAddress, "Value", Classes.FFloatProperty);
		callback_IsValid = callback_FunctionAddress != IntPtr.Zero && callback_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.FOnFloatValueChangedEventWrapper:callback", callback_IsValid);
	}

	static FOnFloatValueChangedEventWrapper()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FOnFloatValueChangedEventWrapper)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FOnFloatValueChangedEventWrapper));
	}
}
