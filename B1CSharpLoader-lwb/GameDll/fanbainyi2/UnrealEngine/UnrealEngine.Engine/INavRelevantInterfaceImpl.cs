using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

public sealed class INavRelevantInterfaceImpl : IInterfaceImpl, INavRelevantInterface, IInterface
{
	static INavRelevantInterfaceImpl()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(INavRelevantInterfaceImpl)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(INavRelevantInterfaceImpl));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Engine.NavRelevantInterface");
	}
}
