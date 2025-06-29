using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

public sealed class IInterface_PostProcessVolumeImpl : IInterfaceImpl, IInterface_PostProcessVolume, IInterface
{
	static IInterface_PostProcessVolumeImpl()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(IInterface_PostProcessVolumeImpl)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(IInterface_PostProcessVolumeImpl));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Engine.Interface_PostProcessVolume");
	}
}
