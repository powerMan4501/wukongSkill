using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.AnimGraphRuntime;

public sealed class ISequencerAnimationSupportImpl : IInterfaceImpl, ISequencerAnimationSupport, IInterface
{
	static ISequencerAnimationSupportImpl()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ISequencerAnimationSupportImpl)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ISequencerAnimationSupportImpl));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/AnimGraphRuntime.SequencerAnimationSupport");
	}
}
