using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.MovieScene;

public sealed class IMovieSceneCustomClockSourceImpl : IInterfaceImpl, IMovieSceneCustomClockSource, IInterface
{
	static IMovieSceneCustomClockSourceImpl()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(IMovieSceneCustomClockSourceImpl)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(IMovieSceneCustomClockSourceImpl));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/MovieScene.MovieSceneCustomClockSource");
	}
}
