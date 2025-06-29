using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.BlueprintGraph;

public sealed class IK2Node_EventNodeInterfaceImpl : IInterfaceImpl, IK2Node_EventNodeInterface, IInterface
{
	static IK2Node_EventNodeInterfaceImpl()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(IK2Node_EventNodeInterfaceImpl)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(IK2Node_EventNodeInterfaceImpl));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/BlueprintGraph.K2Node_EventNodeInterface");
	}
}
