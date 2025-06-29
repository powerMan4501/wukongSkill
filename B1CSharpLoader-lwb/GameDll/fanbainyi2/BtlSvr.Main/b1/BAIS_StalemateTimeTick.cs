using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BAIS_StalemateTimeTick")]
internal class BAIS_StalemateTimeTick : BAIS_Base
{
	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BAIS_StalemateTimeTick");
	}

	static BAIS_StalemateTimeTick()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAIS_StalemateTimeTick)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAIS_StalemateTimeTick));
	}
}
