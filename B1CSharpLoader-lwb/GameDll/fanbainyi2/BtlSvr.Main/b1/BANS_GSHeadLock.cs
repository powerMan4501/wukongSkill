using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("BANS Head Lock")]
[USharpPath("/Script/b1-Managed.BANS_GSHeadLock")]
internal class BANS_GSHeadLock : UAnimNotifyState_GSHeadLock
{
	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BANS_GSHeadLock");
	}

	static BANS_GSHeadLock()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BANS_GSHeadLock)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BANS_GSHeadLock));
	}
}
