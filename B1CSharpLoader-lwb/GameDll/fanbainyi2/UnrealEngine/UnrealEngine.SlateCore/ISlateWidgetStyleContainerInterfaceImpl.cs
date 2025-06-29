using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.SlateCore;

public sealed class ISlateWidgetStyleContainerInterfaceImpl : IInterfaceImpl, ISlateWidgetStyleContainerInterface, IInterface
{
	static ISlateWidgetStyleContainerInterfaceImpl()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ISlateWidgetStyleContainerInterfaceImpl)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ISlateWidgetStyleContainerInterfaceImpl));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/SlateCore.SlateWidgetStyleContainerInterface");
	}
}
