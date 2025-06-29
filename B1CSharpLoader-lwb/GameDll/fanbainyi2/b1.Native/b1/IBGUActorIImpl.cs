using System;
using UnrealEngine.Runtime;

namespace b1;

public sealed class IBGUActorIImpl : IInterfaceImpl, IBGUActorI, IInterface
{
	static IBGUActorIImpl()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(IBGUActorIImpl)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(IBGUActorIImpl));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1.BGUActorI");
	}
}
