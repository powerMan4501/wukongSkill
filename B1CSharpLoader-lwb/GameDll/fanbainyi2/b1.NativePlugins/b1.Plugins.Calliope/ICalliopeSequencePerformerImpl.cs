using System;
using UnrealEngine.Runtime;

namespace b1.Plugins.Calliope;

public sealed class ICalliopeSequencePerformerImpl : IInterfaceImpl, ICalliopeSequencePerformer, IInterface
{
	static ICalliopeSequencePerformerImpl()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ICalliopeSequencePerformerImpl)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ICalliopeSequencePerformerImpl));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Calliope.CalliopeSequencePerformer");
	}
}
