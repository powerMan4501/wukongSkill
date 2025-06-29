using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

public sealed class IInterface_CollisionDataProviderImpl : IInterfaceImpl, IInterface_CollisionDataProvider, IInterface
{
	static IInterface_CollisionDataProviderImpl()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(IInterface_CollisionDataProviderImpl)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(IInterface_CollisionDataProviderImpl));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Engine.Interface_CollisionDataProvider");
	}
}
