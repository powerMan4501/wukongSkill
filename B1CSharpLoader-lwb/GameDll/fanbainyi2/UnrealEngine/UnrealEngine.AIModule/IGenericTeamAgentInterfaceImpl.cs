using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.AIModule;

public sealed class IGenericTeamAgentInterfaceImpl : IInterfaceImpl, IGenericTeamAgentInterface, IInterface
{
	static IGenericTeamAgentInterfaceImpl()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(IGenericTeamAgentInterfaceImpl)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(IGenericTeamAgentInterfaceImpl));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/AIModule.GenericTeamAgentInterface");
	}
}
