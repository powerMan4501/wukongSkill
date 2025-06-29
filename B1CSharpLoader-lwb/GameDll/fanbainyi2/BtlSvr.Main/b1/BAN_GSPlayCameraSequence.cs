using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("BAN Play Camera Sequence NO USE!!!! ")]
[USharpPath("/Script/b1-Managed.BAN_GSPlayCameraSequence")]
internal class BAN_GSPlayCameraSequence : UAnimNotify_GSPlayCameraSequence
{
	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BAN_GSPlayCameraSequence");
	}

	static BAN_GSPlayCameraSequence()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAN_GSPlayCameraSequence)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAN_GSPlayCameraSequence));
	}
}
