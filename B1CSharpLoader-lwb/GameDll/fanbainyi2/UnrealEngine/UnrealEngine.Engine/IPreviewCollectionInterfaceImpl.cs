using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

public sealed class IPreviewCollectionInterfaceImpl : IInterfaceImpl, IPreviewCollectionInterface, IInterface
{
	static IPreviewCollectionInterfaceImpl()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(IPreviewCollectionInterfaceImpl)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(IPreviewCollectionInterfaceImpl));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Engine.PreviewCollectionInterface");
	}
}
