using System;
using UnrealEngine.Runtime;

namespace b1.UI;

[UClass]
[USharpPath("/Script/b1-Managed.BUI_BattleMainCS")]
public class BUI_BattleMainCS : BUI_Widget
{
	protected override void OnUIConstruct()
	{
		base.OnUIConstruct();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUI_BattleMainCS");
	}

	static BUI_BattleMainCS()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUI_BattleMainCS)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUI_BattleMainCS));
	}
}
