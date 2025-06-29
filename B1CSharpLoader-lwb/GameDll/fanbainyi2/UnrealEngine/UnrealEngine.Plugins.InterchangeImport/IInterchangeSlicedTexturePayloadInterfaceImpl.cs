using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.InterchangeImport;

public sealed class IInterchangeSlicedTexturePayloadInterfaceImpl : IInterfaceImpl, IInterchangeSlicedTexturePayloadInterface, IInterface
{
	static IInterchangeSlicedTexturePayloadInterfaceImpl()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(IInterchangeSlicedTexturePayloadInterfaceImpl)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(IInterchangeSlicedTexturePayloadInterfaceImpl));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/InterchangeImport.InterchangeSlicedTexturePayloadInterface");
	}
}
