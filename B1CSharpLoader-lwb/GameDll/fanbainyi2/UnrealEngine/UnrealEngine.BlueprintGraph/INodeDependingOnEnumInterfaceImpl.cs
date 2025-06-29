using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.BlueprintGraph;

public sealed class INodeDependingOnEnumInterfaceImpl : IInterfaceImpl, INodeDependingOnEnumInterface, IInterface
{
	static INodeDependingOnEnumInterfaceImpl()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(INodeDependingOnEnumInterfaceImpl)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(INodeDependingOnEnumInterfaceImpl));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/BlueprintGraph.NodeDependingOnEnumInterface");
	}
}
