using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("BANS Dev Line Hit")]
[USharpPath("/Script/b1-Managed.BANS_GSDevLineHit")]
internal class BANS_GSDevLineHit : UAnimNotifyState_GSDevLineHit
{
	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BANS_GSDevLineHit");
	}

	static BANS_GSDevLineHit()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BANS_GSDevLineHit)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BANS_GSDevLineHit));
	}
}
