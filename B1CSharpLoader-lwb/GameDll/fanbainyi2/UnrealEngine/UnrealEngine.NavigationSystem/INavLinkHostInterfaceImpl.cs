using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.NavigationSystem;

public sealed class INavLinkHostInterfaceImpl : IInterfaceImpl, INavLinkHostInterface, IInterface
{
	static INavLinkHostInterfaceImpl()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(INavLinkHostInterfaceImpl)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(INavLinkHostInterfaceImpl));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/NavigationSystem.NavLinkHostInterface");
	}
}
