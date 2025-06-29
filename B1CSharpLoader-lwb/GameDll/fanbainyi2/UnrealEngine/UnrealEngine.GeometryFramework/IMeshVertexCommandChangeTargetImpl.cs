using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.GeometryFramework;

public sealed class IMeshVertexCommandChangeTargetImpl : IInterfaceImpl, IMeshVertexCommandChangeTarget, IInterface
{
	static IMeshVertexCommandChangeTargetImpl()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(IMeshVertexCommandChangeTargetImpl)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(IMeshVertexCommandChangeTargetImpl));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/GeometryFramework.MeshVertexCommandChangeTarget");
	}
}
