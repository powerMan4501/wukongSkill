using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.NavigationSystem;

public sealed class INavLinkCustomInterfaceImpl : IInterfaceImpl, INavLinkCustomInterface, IInterface
{
	static INavLinkCustomInterfaceImpl()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(INavLinkCustomInterfaceImpl)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(INavLinkCustomInterfaceImpl));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/NavigationSystem.NavLinkCustomInterface");
	}
}
