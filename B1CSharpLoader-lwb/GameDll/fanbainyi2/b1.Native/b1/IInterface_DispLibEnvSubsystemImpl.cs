using System;
using UnrealEngine.Runtime;

namespace b1;

public sealed class IInterface_DispLibEnvSubsystemImpl : IInterfaceImpl, IInterface_DispLibEnvSubsystem, IInterface
{
	static IInterface_DispLibEnvSubsystemImpl()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(IInterface_DispLibEnvSubsystemImpl)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(IInterface_DispLibEnvSubsystemImpl));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1.Interface_DispLibEnvSubsystem");
	}
}
