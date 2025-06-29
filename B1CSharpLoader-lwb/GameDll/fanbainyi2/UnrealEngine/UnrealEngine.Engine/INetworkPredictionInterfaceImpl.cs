using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

public sealed class INetworkPredictionInterfaceImpl : IInterfaceImpl, INetworkPredictionInterface, IInterface
{
	static INetworkPredictionInterfaceImpl()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(INetworkPredictionInterfaceImpl)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(INetworkPredictionInterfaceImpl));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Engine.NetworkPredictionInterface");
	}
}
