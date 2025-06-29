using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.MovieScene;

public sealed class IMovieSceneTrackTemplateProducerImpl : IInterfaceImpl, IMovieSceneTrackTemplateProducer, IInterface
{
	static IMovieSceneTrackTemplateProducerImpl()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(IMovieSceneTrackTemplateProducerImpl)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(IMovieSceneTrackTemplateProducerImpl));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/MovieScene.MovieSceneTrackTemplateProducer");
	}
}
