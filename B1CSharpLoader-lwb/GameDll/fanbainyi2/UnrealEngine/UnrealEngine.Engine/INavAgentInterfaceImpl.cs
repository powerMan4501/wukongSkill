using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

public sealed class INavAgentInterfaceImpl : IInterfaceImpl, INavAgentInterface, IInterface
{
	static INavAgentInterfaceImpl()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(INavAgentInterfaceImpl)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(INavAgentInterfaceImpl));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Engine.NavAgentInterface");
	}
}
