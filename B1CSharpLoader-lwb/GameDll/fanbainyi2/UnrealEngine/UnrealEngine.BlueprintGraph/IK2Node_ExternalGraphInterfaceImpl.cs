using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.BlueprintGraph;

public sealed class IK2Node_ExternalGraphInterfaceImpl : IInterfaceImpl, IK2Node_ExternalGraphInterface, IInterface
{
	static IK2Node_ExternalGraphInterfaceImpl()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(IK2Node_ExternalGraphInterfaceImpl)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(IK2Node_ExternalGraphInterfaceImpl));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/BlueprintGraph.K2Node_ExternalGraphInterface");
	}
}
