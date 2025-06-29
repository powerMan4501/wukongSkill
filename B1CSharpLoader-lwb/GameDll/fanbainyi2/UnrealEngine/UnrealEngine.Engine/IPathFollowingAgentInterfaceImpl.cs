using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

public sealed class IPathFollowingAgentInterfaceImpl : IInterfaceImpl, IPathFollowingAgentInterface, IInterface
{
	static IPathFollowingAgentInterfaceImpl()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(IPathFollowingAgentInterfaceImpl)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(IPathFollowingAgentInterfaceImpl));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Engine.PathFollowingAgentInterface");
	}
}
