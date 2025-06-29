using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.MovieScene;

public sealed class INodeAndChannelMappingsImpl : IInterfaceImpl, INodeAndChannelMappings, IInterface
{
	static INodeAndChannelMappingsImpl()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(INodeAndChannelMappingsImpl)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(INodeAndChannelMappingsImpl));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/MovieScene.NodeAndChannelMappings");
	}
}
