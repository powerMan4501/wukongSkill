using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.MovieScene;

public sealed class IMovieSceneSequenceActorImpl : IInterfaceImpl, IMovieSceneSequenceActor, IInterface
{
	static IMovieSceneSequenceActorImpl()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(IMovieSceneSequenceActorImpl)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(IMovieSceneSequenceActorImpl));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/MovieScene.MovieSceneSequenceActor");
	}
}
