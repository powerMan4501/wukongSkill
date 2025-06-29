using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

public sealed class INavPathObserverInterfaceImpl : IInterfaceImpl, INavPathObserverInterface, IInterface
{
	static INavPathObserverInterfaceImpl()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(INavPathObserverInterfaceImpl)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(INavPathObserverInterfaceImpl));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Engine.NavPathObserverInterface");
	}
}
