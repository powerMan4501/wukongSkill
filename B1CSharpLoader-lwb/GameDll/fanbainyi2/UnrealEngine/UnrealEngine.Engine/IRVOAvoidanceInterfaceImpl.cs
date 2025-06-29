using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

public sealed class IRVOAvoidanceInterfaceImpl : IInterfaceImpl, IRVOAvoidanceInterface, IInterface
{
	static IRVOAvoidanceInterfaceImpl()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(IRVOAvoidanceInterfaceImpl)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(IRVOAvoidanceInterfaceImpl));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Engine.RVOAvoidanceInterface");
	}
}
