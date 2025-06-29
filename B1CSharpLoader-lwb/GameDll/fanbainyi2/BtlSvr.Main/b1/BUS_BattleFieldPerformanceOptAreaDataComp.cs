using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_BattleFieldPerformanceOptAreaDataComp")]
public class BUS_BattleFieldPerformanceOptAreaDataComp : BUS_AreaBaseDataContainer
{
	protected override void InitOnNewInCSImpl()
	{
		base.InitOnNewInCSImpl();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUS_BattleFieldPerformanceOptAreaDataComp");
	}

	static BUS_BattleFieldPerformanceOptAreaDataComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_BattleFieldPerformanceOptAreaDataComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_BattleFieldPerformanceOptAreaDataComp));
	}
}
