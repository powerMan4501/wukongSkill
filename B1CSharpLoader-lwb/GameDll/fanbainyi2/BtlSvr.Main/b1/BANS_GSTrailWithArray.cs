using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("BANS Trail With Array")]
[USharpPath("/Script/b1-Managed.BANS_GSTrailWithArray")]
internal class BANS_GSTrailWithArray : UAnimNotifyState_GSTrailWithArray
{
	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BANS_GSTrailWithArray");
	}

	static BANS_GSTrailWithArray()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BANS_GSTrailWithArray)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BANS_GSTrailWithArray));
	}
}
