using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

public sealed class ISlateTextureAtlasInterfaceImpl : IInterfaceImpl, ISlateTextureAtlasInterface, IInterface
{
	static ISlateTextureAtlasInterfaceImpl()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ISlateTextureAtlasInterfaceImpl)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ISlateTextureAtlasInterfaceImpl));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Engine.SlateTextureAtlasInterface");
	}
}
