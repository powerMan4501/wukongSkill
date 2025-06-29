using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.MovieScene;

public sealed class IMovieSceneEvaluationHookImpl : IInterfaceImpl, IMovieSceneEvaluationHook, IInterface
{
	static IMovieSceneEvaluationHookImpl()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(IMovieSceneEvaluationHookImpl)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(IMovieSceneEvaluationHookImpl));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/MovieScene.MovieSceneEvaluationHook");
	}
}
