using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Landscape;

public sealed class ILandscapeSplineInterfaceImpl : IInterfaceImpl, ILandscapeSplineInterface, IInterface
{
	static ILandscapeSplineInterfaceImpl()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ILandscapeSplineInterfaceImpl)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ILandscapeSplineInterfaceImpl));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Landscape.LandscapeSplineInterface");
	}
}
