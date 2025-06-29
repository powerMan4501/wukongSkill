using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

public sealed class ISMInstanceManagerImpl : IInterfaceImpl, ISMInstanceManager, IInterface
{
	static ISMInstanceManagerImpl()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ISMInstanceManagerImpl)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ISMInstanceManagerImpl));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Engine.SMInstanceManager");
	}
}
