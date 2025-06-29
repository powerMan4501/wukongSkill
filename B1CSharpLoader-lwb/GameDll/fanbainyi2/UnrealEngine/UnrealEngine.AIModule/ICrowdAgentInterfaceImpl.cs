using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.AIModule;

public sealed class ICrowdAgentInterfaceImpl : IInterfaceImpl, ICrowdAgentInterface, IInterface
{
	static ICrowdAgentInterfaceImpl()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ICrowdAgentInterfaceImpl)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ICrowdAgentInterfaceImpl));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/AIModule.CrowdAgentInterface");
	}
}
