using System;
using UnrealEngine.MovieScene;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.FOnMovieSceneSequencePlayerEventWrapper")]
public class FOnMovieSceneSequencePlayerEventWrapper : UILRuntimeDelegateWrapperBase
{
	private static bool callback_IsValid;

	private static IntPtr callback_FunctionAddress;

	private static int callback_ParamsSize;

	public override Delegate GetSignature()
	{
		return new FOnMovieSceneSequencePlayerEvent.Signature(callback);
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.FOnMovieSceneSequencePlayerEventWrapper:callback")]
	private void callback()
	{
		((FOnMovieSceneSequencePlayerEvent.Signature)_action)();
	}

	[UFunctionInvoker("/Script/b1-Managed.FOnMovieSceneSequencePlayerEventWrapper:callback")]
	private static void callback__Invoker(IntPtr buffer, IntPtr obj)
	{
		FOnMovieSceneSequencePlayerEventWrapper fOnMovieSceneSequencePlayerEventWrapper = GCHelper.Find<FOnMovieSceneSequencePlayerEventWrapper>(obj);
		fOnMovieSceneSequencePlayerEventWrapper.callback();
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.FOnMovieSceneSequencePlayerEventWrapper");
		callback_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "callback");
		callback_ParamsSize = NativeReflection.GetFunctionParamsSize(callback_FunctionAddress);
		callback_IsValid = callback_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.FOnMovieSceneSequencePlayerEventWrapper:callback", callback_IsValid);
	}

	static FOnMovieSceneSequencePlayerEventWrapper()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FOnMovieSceneSequencePlayerEventWrapper)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FOnMovieSceneSequencePlayerEventWrapper));
	}
}
