using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.MovieScene;

public sealed class IMovieSceneEntityProviderImpl : IInterfaceImpl, IMovieSceneEntityProvider, IInterface
{
	static IMovieSceneEntityProviderImpl()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(IMovieSceneEntityProviderImpl)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(IMovieSceneEntityProviderImpl));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/MovieScene.MovieSceneEntityProvider");
	}
}
