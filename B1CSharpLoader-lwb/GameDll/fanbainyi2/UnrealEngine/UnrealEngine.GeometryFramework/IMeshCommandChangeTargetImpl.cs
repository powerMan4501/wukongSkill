using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.GeometryFramework;

public sealed class IMeshCommandChangeTargetImpl : IInterfaceImpl, IMeshCommandChangeTarget, IInterface
{
	static IMeshCommandChangeTargetImpl()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(IMeshCommandChangeTargetImpl)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(IMeshCommandChangeTargetImpl));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/GeometryFramework.MeshCommandChangeTarget");
	}
}
