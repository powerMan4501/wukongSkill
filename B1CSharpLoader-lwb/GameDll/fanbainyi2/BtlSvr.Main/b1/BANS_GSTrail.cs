using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("BANS Trail")]
[USharpPath("/Script/b1-Managed.BANS_GSTrail")]
internal class BANS_GSTrail : UAnimNotifyState_GSTrail
{
	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BANS_GSTrail");
	}

	static BANS_GSTrail()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BANS_GSTrail)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BANS_GSTrail));
	}
}
