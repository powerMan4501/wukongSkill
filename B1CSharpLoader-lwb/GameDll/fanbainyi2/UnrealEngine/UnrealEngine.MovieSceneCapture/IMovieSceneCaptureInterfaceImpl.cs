using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.MovieSceneCapture;

public sealed class IMovieSceneCaptureInterfaceImpl : IInterfaceImpl, IMovieSceneCaptureInterface, IInterface
{
	static IMovieSceneCaptureInterfaceImpl()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(IMovieSceneCaptureInterfaceImpl)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(IMovieSceneCaptureInterfaceImpl));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/MovieSceneCapture.MovieSceneCaptureInterface");
	}
}
