using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

public sealed class INavigationDataInterfaceImpl : IInterfaceImpl, INavigationDataInterface, IInterface
{
	static INavigationDataInterfaceImpl()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(INavigationDataInterfaceImpl)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(INavigationDataInterfaceImpl));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Engine.NavigationDataInterface");
	}
}
