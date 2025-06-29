using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("BANS Lock Hand And Foot")]
[USharpPath("/Script/b1-Managed.BANS_GSLockHandAndFoot")]
internal class BANS_GSLockHandAndFoot : UAnimNotifyState_GSLockHandFoot
{
	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BANS_GSLockHandAndFoot");
	}

	static BANS_GSLockHandAndFoot()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BANS_GSLockHandAndFoot)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BANS_GSLockHandAndFoot));
	}
}
