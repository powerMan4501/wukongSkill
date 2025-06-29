using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("【无用节点！会直接以成功执行返回】ResetStalemateMoveTime")]
[USharpPath("/Script/b1-Managed.BAIT_ResetStalemateMoveTime")]
internal class BAIT_ResetStalemateMoveTime : BAIT_Base
{
	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BAIT_ResetStalemateMoveTime");
	}

	static BAIT_ResetStalemateMoveTime()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAIT_ResetStalemateMoveTime)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAIT_ResetStalemateMoveTime));
	}
}
