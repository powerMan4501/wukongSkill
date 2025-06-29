using System;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.FOnButtonClickedEventWrapper")]
public class FOnButtonClickedEventWrapper : UILRuntimeDelegateWrapperBase
{
	private static bool callback_IsValid;

	private static IntPtr callback_FunctionAddress;

	private static int callback_ParamsSize;

	public override Delegate GetSignature()
	{
		return new FOnButtonClickedEvent.Signature(callback);
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.FOnButtonClickedEventWrapper:callback")]
	private void callback()
	{
		((FOnButtonClickedEvent.Signature)_action)();
	}

	[UFunctionInvoker("/Script/b1-Managed.FOnButtonClickedEventWrapper:callback")]
	private static void callback__Invoker(IntPtr buffer, IntPtr obj)
	{
		FOnButtonClickedEventWrapper fOnButtonClickedEventWrapper = GCHelper.Find<FOnButtonClickedEventWrapper>(obj);
		fOnButtonClickedEventWrapper.callback();
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.FOnButtonClickedEventWrapper");
		callback_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "callback");
		callback_ParamsSize = NativeReflection.GetFunctionParamsSize(callback_FunctionAddress);
		callback_IsValid = callback_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.FOnButtonClickedEventWrapper:callback", callback_IsValid);
	}

	static FOnButtonClickedEventWrapper()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FOnButtonClickedEventWrapper)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FOnButtonClickedEventWrapper));
	}
}
