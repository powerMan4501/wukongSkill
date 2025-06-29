using System;
using UnrealEngine.Runtime;

namespace b1.Plugins.Calliope;

public sealed class IGsSmartParamObjectImpl : IInterfaceImpl, IGsSmartParamObject, IInterface
{
	static IGsSmartParamObjectImpl()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(IGsSmartParamObjectImpl)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(IGsSmartParamObjectImpl));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Calliope.GsSmartParamObject");
	}
}
