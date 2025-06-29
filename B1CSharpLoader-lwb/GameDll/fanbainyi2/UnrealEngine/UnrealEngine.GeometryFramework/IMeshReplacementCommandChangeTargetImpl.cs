using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.GeometryFramework;

public sealed class IMeshReplacementCommandChangeTargetImpl : IInterfaceImpl, IMeshReplacementCommandChangeTarget, IInterface
{
	static IMeshReplacementCommandChangeTargetImpl()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(IMeshReplacementCommandChangeTargetImpl)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(IMeshReplacementCommandChangeTargetImpl));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/GeometryFramework.MeshReplacementCommandChangeTarget");
	}
}
