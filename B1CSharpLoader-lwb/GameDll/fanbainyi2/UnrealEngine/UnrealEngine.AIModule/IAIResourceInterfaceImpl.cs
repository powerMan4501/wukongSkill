using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.AIModule;

public sealed class IAIResourceInterfaceImpl : IInterfaceImpl, IAIResourceInterface, IInterface
{
	static IAIResourceInterfaceImpl()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(IAIResourceInterfaceImpl)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(IAIResourceInterfaceImpl));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/AIModule.AIResourceInterface");
	}
}
