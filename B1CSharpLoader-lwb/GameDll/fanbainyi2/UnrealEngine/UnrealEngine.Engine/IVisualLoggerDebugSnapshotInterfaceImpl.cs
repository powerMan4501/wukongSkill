using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

public sealed class IVisualLoggerDebugSnapshotInterfaceImpl : IInterfaceImpl, IVisualLoggerDebugSnapshotInterface, IInterface
{
	static IVisualLoggerDebugSnapshotInterfaceImpl()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(IVisualLoggerDebugSnapshotInterfaceImpl)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(IVisualLoggerDebugSnapshotInterfaceImpl));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Engine.VisualLoggerDebugSnapshotInterface");
	}
}
