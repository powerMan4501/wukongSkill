using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("BANS Play Camera Sequence【已废弃】")]
[USharpPath("/Script/b1-Managed.BANS_GSPlayCameraSequence")]
internal class BANS_GSPlayCameraSequence : BANS_GSBase
{
	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BANS_GSPlayCameraSequence");
	}

	static BANS_GSPlayCameraSequence()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BANS_GSPlayCameraSequence)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BANS_GSPlayCameraSequence));
	}
}
