using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.InterchangeImport;

public sealed class IInterchangeBlockedTexturePayloadInterfaceImpl : IInterfaceImpl, IInterchangeBlockedTexturePayloadInterface, IInterface
{
	static IInterchangeBlockedTexturePayloadInterfaceImpl()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(IInterchangeBlockedTexturePayloadInterfaceImpl)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(IInterchangeBlockedTexturePayloadInterfaceImpl));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/InterchangeImport.InterchangeBlockedTexturePayloadInterface");
	}
}
