using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("BANS Play Actor Sequence")]
[USharpPath("/Script/b1-Managed.BANS_GSPlayActorSequence")]
public class BANS_GSPlayActorSequence : BANS_GSBase
{
	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BANS_GSPlayActorSequence");
	}

	static BANS_GSPlayActorSequence()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BANS_GSPlayActorSequence)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BANS_GSPlayActorSequence));
	}
}
