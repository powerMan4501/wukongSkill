using System;
using UnrealEngine.Plugins.BinkMediaPlayer;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.FOnBinkMediaPlayerMediaReachedEndWrapper")]
public class FOnBinkMediaPlayerMediaReachedEndWrapper : UILRuntimeDelegateWrapperBase
{
	private static bool callback_IsValid;

	private static IntPtr callback_FunctionAddress;

	private static int callback_ParamsSize;

	public override Delegate GetSignature()
	{
		return new FOnBinkMediaPlayerMediaReachedEnd.Signature(callback);
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.FOnBinkMediaPlayerMediaReachedEndWrapper:callback")]
	private void callback()
	{
		((FOnBinkMediaPlayerMediaReachedEnd.Signature)_action)();
	}

	[UFunctionInvoker("/Script/b1-Managed.FOnBinkMediaPlayerMediaReachedEndWrapper:callback")]
	private static void callback__Invoker(IntPtr buffer, IntPtr obj)
	{
		FOnBinkMediaPlayerMediaReachedEndWrapper fOnBinkMediaPlayerMediaReachedEndWrapper = GCHelper.Find<FOnBinkMediaPlayerMediaReachedEndWrapper>(obj);
		fOnBinkMediaPlayerMediaReachedEndWrapper.callback();
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.FOnBinkMediaPlayerMediaReachedEndWrapper");
		callback_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "callback");
		callback_ParamsSize = NativeReflection.GetFunctionParamsSize(callback_FunctionAddress);
		callback_IsValid = callback_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.FOnBinkMediaPlayerMediaReachedEndWrapper:callback", callback_IsValid);
	}

	static FOnBinkMediaPlayerMediaReachedEndWrapper()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FOnBinkMediaPlayerMediaReachedEndWrapper)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FOnBinkMediaPlayerMediaReachedEndWrapper));
	}
}
