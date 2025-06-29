using System;
using UnrealEngine.Runtime;

namespace b1.Plugins.HoudiniEngineRuntime;

public sealed class IHoudiniAssetStateEventsImpl : IInterfaceImpl, IHoudiniAssetStateEvents, IInterface
{
	static IHoudiniAssetStateEventsImpl()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(IHoudiniAssetStateEventsImpl)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(IHoudiniAssetStateEventsImpl));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/HoudiniEngineRuntime.HoudiniAssetStateEvents");
	}
}
