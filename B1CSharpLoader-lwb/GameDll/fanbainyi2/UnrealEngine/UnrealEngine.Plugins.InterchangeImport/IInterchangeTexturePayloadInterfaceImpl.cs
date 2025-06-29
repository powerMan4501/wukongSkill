using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.InterchangeImport;

public sealed class IInterchangeTexturePayloadInterfaceImpl : IInterfaceImpl, IInterchangeTexturePayloadInterface, IInterface
{
	static IInterchangeTexturePayloadInterfaceImpl()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(IInterchangeTexturePayloadInterfaceImpl)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(IInterchangeTexturePayloadInterfaceImpl));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/InterchangeImport.InterchangeTexturePayloadInterface");
	}
}
