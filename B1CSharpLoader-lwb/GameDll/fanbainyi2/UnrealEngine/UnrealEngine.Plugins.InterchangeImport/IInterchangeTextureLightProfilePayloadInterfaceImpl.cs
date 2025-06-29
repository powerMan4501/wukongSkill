using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.InterchangeImport;

public sealed class IInterchangeTextureLightProfilePayloadInterfaceImpl : IInterfaceImpl, IInterchangeTextureLightProfilePayloadInterface, IInterface
{
	static IInterchangeTextureLightProfilePayloadInterfaceImpl()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(IInterchangeTextureLightProfilePayloadInterfaceImpl)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(IInterchangeTextureLightProfilePayloadInterfaceImpl));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/InterchangeImport.InterchangeTextureLightProfilePayloadInterface");
	}
}
