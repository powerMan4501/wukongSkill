using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

public sealed class IBlendableInterfaceImpl : IInterfaceImpl, IBlendableInterface, IInterface
{
	static IBlendableInterfaceImpl()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(IBlendableInterfaceImpl)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(IBlendableInterfaceImpl));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Engine.BlendableInterface");
	}
}
