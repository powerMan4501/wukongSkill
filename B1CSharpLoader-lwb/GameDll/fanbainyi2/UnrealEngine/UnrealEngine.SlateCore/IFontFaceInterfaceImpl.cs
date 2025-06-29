using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.SlateCore;

public sealed class IFontFaceInterfaceImpl : IInterfaceImpl, IFontFaceInterface, IInterface
{
	static IFontFaceInterfaceImpl()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(IFontFaceInterfaceImpl)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(IFontFaceInterfaceImpl));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/SlateCore.FontFaceInterface");
	}
}
