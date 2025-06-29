using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

public sealed class INodeMappingProviderInterfaceImpl : IInterfaceImpl, INodeMappingProviderInterface, IInterface
{
	static INodeMappingProviderInterfaceImpl()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(INodeMappingProviderInterfaceImpl)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(INodeMappingProviderInterfaceImpl));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Engine.NodeMappingProviderInterface");
	}
}
