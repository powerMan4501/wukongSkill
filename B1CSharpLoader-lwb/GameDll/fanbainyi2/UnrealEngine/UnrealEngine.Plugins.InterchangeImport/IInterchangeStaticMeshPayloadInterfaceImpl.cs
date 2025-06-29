using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.InterchangeImport;

public sealed class IInterchangeStaticMeshPayloadInterfaceImpl : IInterfaceImpl, IInterchangeStaticMeshPayloadInterface, IInterface
{
	static IInterchangeStaticMeshPayloadInterfaceImpl()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(IInterchangeStaticMeshPayloadInterfaceImpl)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(IInterchangeStaticMeshPayloadInterfaceImpl));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/InterchangeImport.InterchangeStaticMeshPayloadInterface");
	}
}
