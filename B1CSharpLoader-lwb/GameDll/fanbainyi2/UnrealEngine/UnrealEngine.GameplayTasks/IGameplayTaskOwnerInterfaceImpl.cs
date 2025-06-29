using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.GameplayTasks;

public sealed class IGameplayTaskOwnerInterfaceImpl : IInterfaceImpl, IGameplayTaskOwnerInterface, IInterface
{
	static IGameplayTaskOwnerInterfaceImpl()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(IGameplayTaskOwnerInterfaceImpl)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(IGameplayTaskOwnerInterfaceImpl));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/GameplayTasks.GameplayTaskOwnerInterface");
	}
}
