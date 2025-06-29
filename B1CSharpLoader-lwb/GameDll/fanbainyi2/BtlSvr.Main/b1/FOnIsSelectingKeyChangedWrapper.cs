using System;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.FOnIsSelectingKeyChangedWrapper")]
public class FOnIsSelectingKeyChangedWrapper : UILRuntimeDelegateWrapperBase
{
	private static bool callback_IsValid;

	private static IntPtr callback_FunctionAddress;

	private static int callback_ParamsSize;

	public override Delegate GetSignature()
	{
		return new UInputKeySelector.FOnIsSelectingKeyChanged.Signature(callback);
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.FOnIsSelectingKeyChangedWrapper:callback")]
	private void callback()
	{
		((UInputKeySelector.FOnIsSelectingKeyChanged.Signature)_action)();
	}

	[UFunctionInvoker("/Script/b1-Managed.FOnIsSelectingKeyChangedWrapper:callback")]
	private static void callback__Invoker(IntPtr buffer, IntPtr obj)
	{
		FOnIsSelectingKeyChangedWrapper fOnIsSelectingKeyChangedWrapper = GCHelper.Find<FOnIsSelectingKeyChangedWrapper>(obj);
		fOnIsSelectingKeyChangedWrapper.callback();
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.FOnIsSelectingKeyChangedWrapper");
		callback_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "callback");
		callback_ParamsSize = NativeReflection.GetFunctionParamsSize(callback_FunctionAddress);
		callback_IsValid = callback_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.FOnIsSelectingKeyChangedWrapper:callback", callback_IsValid);
	}

	static FOnIsSelectingKeyChangedWrapper()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FOnIsSelectingKeyChangedWrapper)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FOnIsSelectingKeyChangedWrapper));
	}
}
