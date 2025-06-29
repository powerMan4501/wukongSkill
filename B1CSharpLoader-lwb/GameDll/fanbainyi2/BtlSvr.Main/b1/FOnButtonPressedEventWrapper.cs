using System;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.FOnButtonPressedEventWrapper")]
public class FOnButtonPressedEventWrapper : UILRuntimeDelegateWrapperBase
{
	private static bool callback_IsValid;

	private static IntPtr callback_FunctionAddress;

	private static int callback_ParamsSize;

	public override Delegate GetSignature()
	{
		return new FOnButtonPressedEvent.Signature(callback);
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.FOnButtonPressedEventWrapper:callback")]
	private void callback()
	{
		((FOnButtonPressedEvent.Signature)_action)();
	}

	[UFunctionInvoker("/Script/b1-Managed.FOnButtonPressedEventWrapper:callback")]
	private static void callback__Invoker(IntPtr buffer, IntPtr obj)
	{
		FOnButtonPressedEventWrapper fOnButtonPressedEventWrapper = GCHelper.Find<FOnButtonPressedEventWrapper>(obj);
		fOnButtonPressedEventWrapper.callback();
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.FOnButtonPressedEventWrapper");
		callback_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "callback");
		callback_ParamsSize = NativeReflection.GetFunctionParamsSize(callback_FunctionAddress);
		callback_IsValid = callback_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.FOnButtonPressedEventWrapper:callback", callback_IsValid);
	}

	static FOnButtonPressedEventWrapper()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FOnButtonPressedEventWrapper)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FOnButtonPressedEventWrapper));
	}
}
