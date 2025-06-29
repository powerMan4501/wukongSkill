using System;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.FOnUserScrolledEventWrapper")]
public class FOnUserScrolledEventWrapper : UILRuntimeDelegateWrapperBase
{
	private static bool callback_IsValid;

	private static IntPtr callback_FunctionAddress;

	private static int callback_ParamsSize;

	private static bool callback_CurrentOffset_IsValid;

	private static int callback_CurrentOffset_Offset;

	public override Delegate GetSignature()
	{
		return new FOnUserScrolledEvent.Signature(callback);
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.FOnUserScrolledEventWrapper:callback")]
	private void callback(float CurrentOffset)
	{
		((FOnUserScrolledEvent.Signature)_action)(CurrentOffset);
	}

	[UFunctionInvoker("/Script/b1-Managed.FOnUserScrolledEventWrapper:callback")]
	private static void callback__Invoker(IntPtr buffer, IntPtr obj)
	{
		FOnUserScrolledEventWrapper fOnUserScrolledEventWrapper = GCHelper.Find<FOnUserScrolledEventWrapper>(obj);
		float currentOffset = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, callback_CurrentOffset_Offset));
		fOnUserScrolledEventWrapper.callback(currentOffset);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.FOnUserScrolledEventWrapper");
		callback_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "callback");
		callback_ParamsSize = NativeReflection.GetFunctionParamsSize(callback_FunctionAddress);
		callback_CurrentOffset_Offset = NativeReflection.GetPropertyOffset(callback_FunctionAddress, "CurrentOffset");
		callback_CurrentOffset_IsValid = NativeReflection.ValidatePropertyClass(callback_FunctionAddress, "CurrentOffset", Classes.FFloatProperty);
		callback_IsValid = callback_FunctionAddress != IntPtr.Zero && callback_CurrentOffset_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.FOnUserScrolledEventWrapper:callback", callback_IsValid);
	}

	static FOnUserScrolledEventWrapper()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FOnUserScrolledEventWrapper)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FOnUserScrolledEventWrapper));
	}
}
