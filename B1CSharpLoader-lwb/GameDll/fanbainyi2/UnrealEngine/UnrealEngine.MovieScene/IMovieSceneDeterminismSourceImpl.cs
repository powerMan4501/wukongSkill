using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.MovieScene;

public sealed class IMovieSceneDeterminismSourceImpl : IInterfaceImpl, IMovieSceneDeterminismSource, IInterface
{
	static IMovieSceneDeterminismSourceImpl()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(IMovieSceneDeterminismSourceImpl)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(IMovieSceneDeterminismSourceImpl));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/MovieScene.MovieSceneDeterminismSource");
	}
}
