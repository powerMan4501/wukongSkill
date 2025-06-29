using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("BANS Editor Helper")]
[USharpPath("/Script/b1-Managed.BANS_GSEditorHelper")]
internal class BANS_GSEditorHelper : UAnimNotifyState_GSEditorHelper
{
	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BANS_GSEditorHelper");
	}

	static BANS_GSEditorHelper()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BANS_GSEditorHelper)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BANS_GSEditorHelper));
	}
}
