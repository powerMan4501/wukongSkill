using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.AIModule;

public sealed class IEQSQueryResultSourceInterfaceImpl : IInterfaceImpl, IEQSQueryResultSourceInterface, IInterface
{
	static IEQSQueryResultSourceInterfaceImpl()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(IEQSQueryResultSourceInterfaceImpl)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(IEQSQueryResultSourceInterfaceImpl));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/AIModule.EQSQueryResultSourceInterface");
	}
}
