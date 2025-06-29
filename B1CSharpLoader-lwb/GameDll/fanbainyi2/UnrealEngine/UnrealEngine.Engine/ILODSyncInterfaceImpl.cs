using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

public sealed class ILODSyncInterfaceImpl : IInterfaceImpl, ILODSyncInterface, IInterface
{
	static ILODSyncInterfaceImpl()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ILODSyncInterfaceImpl)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ILODSyncInterfaceImpl));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Engine.LODSyncInterface");
	}
}
