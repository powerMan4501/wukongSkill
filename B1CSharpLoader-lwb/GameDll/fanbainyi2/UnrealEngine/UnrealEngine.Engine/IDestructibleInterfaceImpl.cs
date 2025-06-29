using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

public sealed class IDestructibleInterfaceImpl : IInterfaceImpl, IDestructibleInterface, IInterface
{
	static IDestructibleInterfaceImpl()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(IDestructibleInterfaceImpl)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(IDestructibleInterfaceImpl));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Engine.DestructibleInterface");
	}
}
