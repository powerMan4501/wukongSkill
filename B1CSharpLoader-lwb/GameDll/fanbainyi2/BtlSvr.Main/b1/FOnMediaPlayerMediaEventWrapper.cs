using System;
using UnrealEngine.MediaAssets;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.FOnMediaPlayerMediaEventWrapper")]
public class FOnMediaPlayerMediaEventWrapper : UILRuntimeDelegateWrapperBase
{
	private static bool callback_IsValid;

	private static IntPtr callback_FunctionAddress;

	private static int callback_ParamsSize;

	public override Delegate GetSignature()
	{
		return new FOnMediaPlayerMediaEvent.Signature(callback);
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.FOnMediaPlayerMediaEventWrapper:callback")]
	private void callback()
	{
		((FOnMediaPlayerMediaEvent.Signature)_action)();
	}

	[UFunctionInvoker("/Script/b1-Managed.FOnMediaPlayerMediaEventWrapper:callback")]
	private static void callback__Invoker(IntPtr buffer, IntPtr obj)
	{
		FOnMediaPlayerMediaEventWrapper fOnMediaPlayerMediaEventWrapper = GCHelper.Find<FOnMediaPlayerMediaEventWrapper>(obj);
		fOnMediaPlayerMediaEventWrapper.callback();
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.FOnMediaPlayerMediaEventWrapper");
		callback_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "callback");
		callback_ParamsSize = NativeReflection.GetFunctionParamsSize(callback_FunctionAddress);
		callback_IsValid = callback_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.FOnMediaPlayerMediaEventWrapper:callback", callback_IsValid);
	}

	static FOnMediaPlayerMediaEventWrapper()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FOnMediaPlayerMediaEventWrapper)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FOnMediaPlayerMediaEventWrapper));
	}
}
