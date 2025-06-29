using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.EditorFramework;

public sealed class IAssetFactoryInterfaceImpl : IInterfaceImpl, IAssetFactoryInterface, IInterface
{
	static IAssetFactoryInterfaceImpl()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(IAssetFactoryInterfaceImpl)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(IAssetFactoryInterfaceImpl));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/EditorFramework.AssetFactoryInterface");
	}
}
