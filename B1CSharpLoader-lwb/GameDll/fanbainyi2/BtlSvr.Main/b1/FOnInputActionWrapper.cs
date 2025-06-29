using System;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.FOnInputActionWrapper")]
public class FOnInputActionWrapper : UILRuntimeDelegateWrapperBase
{
	private static bool callback_IsValid;

	private static IntPtr callback_FunctionAddress;

	private static int callback_ParamsSize;

	public override Delegate GetSignature()
	{
		return new FOnInputAction.Signature(callback);
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.FOnInputActionWrapper:callback")]
	private void callback()
	{
		((FOnInputAction.Signature)_action)();
	}

	[UFunctionInvoker("/Script/b1-Managed.FOnInputActionWrapper:callback")]
	private static void callback__Invoker(IntPtr buffer, IntPtr obj)
	{
		FOnInputActionWrapper fOnInputActionWrapper = GCHelper.Find<FOnInputActionWrapper>(obj);
		fOnInputActionWrapper.callback();
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.FOnInputActionWrapper");
		callback_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "callback");
		callback_ParamsSize = NativeReflection.GetFunctionParamsSize(callback_FunctionAddress);
		callback_IsValid = callback_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.FOnInputActionWrapper:callback", callback_IsValid);
	}

	static FOnInputActionWrapper()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FOnInputActionWrapper)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FOnInputActionWrapper));
	}
}
