using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

public sealed class IInterface_AssetUserDataImpl : IInterfaceImpl, IInterface_AssetUserData, IInterface
{
	static IInterface_AssetUserDataImpl()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(IInterface_AssetUserDataImpl)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(IInterface_AssetUserDataImpl));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Engine.Interface_AssetUserData");
	}
}
