using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.InterchangeImport;

public sealed class IInterchangeSkeletalMeshPayloadInterfaceImpl : IInterfaceImpl, IInterchangeSkeletalMeshPayloadInterface, IInterface
{
	static IInterchangeSkeletalMeshPayloadInterfaceImpl()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(IInterchangeSkeletalMeshPayloadInterfaceImpl)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(IInterchangeSkeletalMeshPayloadInterfaceImpl));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/InterchangeImport.InterchangeSkeletalMeshPayloadInterface");
	}
}
