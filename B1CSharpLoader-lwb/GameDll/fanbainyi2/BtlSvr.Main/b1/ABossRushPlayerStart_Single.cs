using System;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("BossRushPlayerStart")]
[UClass]
[USharpPath("/Script/b1-Managed.BossRushPlayerStart_Single")]
public class ABossRushPlayerStart_Single : ABossRushPlayerStart
{
	public override void Initialize(FObjectInitializer initializer)
	{
		base.UseType = EBossRushPlayerStartType.Single;
		base.Initialize(initializer);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BossRushPlayerStart_Single");
	}

	static ABossRushPlayerStart_Single()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(ABossRushPlayerStart_Single)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ABossRushPlayerStart_Single));
	}
}
