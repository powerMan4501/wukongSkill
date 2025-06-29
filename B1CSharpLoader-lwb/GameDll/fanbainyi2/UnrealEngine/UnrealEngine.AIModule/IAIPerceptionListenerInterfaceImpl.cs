using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.AIModule;

public sealed class IAIPerceptionListenerInterfaceImpl : IInterfaceImpl, IAIPerceptionListenerInterface, IInterface
{
	static IAIPerceptionListenerInterfaceImpl()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(IAIPerceptionListenerInterfaceImpl)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(IAIPerceptionListenerInterfaceImpl));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/AIModule.AIPerceptionListenerInterface");
	}
}
