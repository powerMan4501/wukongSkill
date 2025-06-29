using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.SlateCore;

public sealed class IFontProviderInterfaceImpl : IInterfaceImpl, IFontProviderInterface, IInterface
{
	static IFontProviderInterfaceImpl()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(IFontProviderInterfaceImpl)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(IFontProviderInterfaceImpl));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/SlateCore.FontProviderInterface");
	}
}
