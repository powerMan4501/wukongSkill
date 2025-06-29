using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.ChaosSolverEngine;

public sealed class IChaosNotifyHandlerInterfaceImpl : IInterfaceImpl, IChaosNotifyHandlerInterface, IInterface
{
	static IChaosNotifyHandlerInterfaceImpl()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(IChaosNotifyHandlerInterfaceImpl)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(IChaosNotifyHandlerInterfaceImpl));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/ChaosSolverEngine.ChaosNotifyHandlerInterface");
	}
}
