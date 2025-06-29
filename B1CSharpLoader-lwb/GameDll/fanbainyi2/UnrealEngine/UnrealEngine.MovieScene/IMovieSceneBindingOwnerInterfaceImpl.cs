using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.MovieScene;

public sealed class IMovieSceneBindingOwnerInterfaceImpl : IInterfaceImpl, IMovieSceneBindingOwnerInterface, IInterface
{
	static IMovieSceneBindingOwnerInterfaceImpl()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(IMovieSceneBindingOwnerInterfaceImpl)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(IMovieSceneBindingOwnerInterfaceImpl));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/MovieScene.MovieSceneBindingOwnerInterface");
	}
}
