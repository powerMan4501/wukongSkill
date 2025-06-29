using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

public sealed class IInterface_PreviewMeshProviderImpl : IInterfaceImpl, IInterface_PreviewMeshProvider, IInterface
{
	static IInterface_PreviewMeshProviderImpl()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(IInterface_PreviewMeshProviderImpl)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(IInterface_PreviewMeshProviderImpl));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Engine.Interface_PreviewMeshProvider");
	}
}
