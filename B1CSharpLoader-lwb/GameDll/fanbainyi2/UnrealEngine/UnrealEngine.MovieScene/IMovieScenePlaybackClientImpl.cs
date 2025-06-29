using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.MovieScene;

public sealed class IMovieScenePlaybackClientImpl : IInterfaceImpl, IMovieScenePlaybackClient, IInterface
{
	static IMovieScenePlaybackClientImpl()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(IMovieScenePlaybackClientImpl)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(IMovieScenePlaybackClientImpl));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/MovieScene.MovieScenePlaybackClient");
	}
}
