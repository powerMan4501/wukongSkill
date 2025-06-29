using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

public sealed class ISMInstanceManagerProviderImpl : IInterfaceImpl, ISMInstanceManagerProvider, IInterface
{
	static ISMInstanceManagerProviderImpl()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ISMInstanceManagerProviderImpl)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ISMInstanceManagerProviderImpl));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Engine.SMInstanceManagerProvider");
	}
}
