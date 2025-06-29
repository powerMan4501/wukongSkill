using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.ViewportInteraction;

public sealed class IViewportInteractableInterfaceImpl : IInterfaceImpl, IViewportInteractableInterface, IInterface
{
	static IViewportInteractableInterfaceImpl()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(IViewportInteractableInterfaceImpl)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(IViewportInteractableInterfaceImpl));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/ViewportInteraction.ViewportInteractableInterface");
	}
}
