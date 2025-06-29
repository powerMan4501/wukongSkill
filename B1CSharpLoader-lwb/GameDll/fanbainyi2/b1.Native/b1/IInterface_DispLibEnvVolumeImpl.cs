using System;
using UnrealEngine.Runtime;

namespace b1;

public sealed class IInterface_DispLibEnvVolumeImpl : IInterfaceImpl, IInterface_DispLibEnvVolume, IInterface
{
	static IInterface_DispLibEnvVolumeImpl()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(IInterface_DispLibEnvVolumeImpl)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(IInterface_DispLibEnvVolumeImpl));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1.Interface_DispLibEnvVolume");
	}
}
