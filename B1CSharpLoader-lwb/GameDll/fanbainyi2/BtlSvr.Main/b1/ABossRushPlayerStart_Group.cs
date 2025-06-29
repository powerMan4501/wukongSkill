using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("BossRushPlayerStart")]
[USharpPath("/Script/b1-Managed.BossRushPlayerStart_Group")]
public class ABossRushPlayerStart_Group : ABossRushPlayerStart
{
	public override void Initialize(FObjectInitializer initializer)
	{
		base.UseType = EBossRushPlayerStartType.Group;
		base.Initialize(initializer);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BossRushPlayerStart_Group");
	}

	static ABossRushPlayerStart_Group()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(ABossRushPlayerStart_Group)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ABossRushPlayerStart_Group));
	}
}
