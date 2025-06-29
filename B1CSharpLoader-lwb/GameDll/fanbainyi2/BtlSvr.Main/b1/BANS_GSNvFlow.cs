using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("BANS Nv Flow")]
[USharpPath("/Script/b1-Managed.BANS_GSNvFlow")]
internal class BANS_GSNvFlow : UAnimNotifyState_GSNvFlow
{
	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BANS_GSNvFlow");
	}

	static BANS_GSNvFlow()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BANS_GSNvFlow)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BANS_GSNvFlow));
	}
}
