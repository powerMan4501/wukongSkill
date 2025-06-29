using System;
using UnrealEngine.Runtime;

namespace b1.Plugins.HoudiniEngineRuntime;

public sealed class IHoudiniEngineCopyPropertiesInterfaceImpl : IInterfaceImpl, IHoudiniEngineCopyPropertiesInterface, IInterface
{
	static IHoudiniEngineCopyPropertiesInterfaceImpl()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(IHoudiniEngineCopyPropertiesInterfaceImpl)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(IHoudiniEngineCopyPropertiesInterfaceImpl));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/HoudiniEngineRuntime.HoudiniEngineCopyPropertiesInterface");
	}
}
