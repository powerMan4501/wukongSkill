using System;
using UnrealEngine.Runtime;

namespace b1;

public sealed class IBUAnimHandAndFootIKActionImpl : IInterfaceImpl, IBUAnimHandAndFootIKAction, IInterface
{
	static IBUAnimHandAndFootIKActionImpl()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(IBUAnimHandAndFootIKActionImpl)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(IBUAnimHandAndFootIKActionImpl));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1.BUAnimHandAndFootIKAction");
	}
}
