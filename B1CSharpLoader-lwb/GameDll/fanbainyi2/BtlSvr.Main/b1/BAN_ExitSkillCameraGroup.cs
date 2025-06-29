using System;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("Exit Skill Camera Group（已废弃）")]
[UClass]
[USharpPath("/Script/b1-Managed.BAN_ExitSkillCameraGroup")]
internal class BAN_ExitSkillCameraGroup : BAN_GSBase
{
	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BAN_ExitSkillCameraGroup");
	}

	static BAN_ExitSkillCameraGroup()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAN_ExitSkillCameraGroup)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAN_ExitSkillCameraGroup));
	}
}
