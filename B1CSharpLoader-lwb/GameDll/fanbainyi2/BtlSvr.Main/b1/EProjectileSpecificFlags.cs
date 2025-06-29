using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[UMeta(MDEnum.Bitflags)]
[UMeta(MDEnum.UseEnumValuesAsMaskValuesInEditor, true)]
[USharpPath("/Script/b1-Managed.ProjectileSpecificFlags")]
public enum EProjectileSpecificFlags : byte
{
	[UMeta(MD.Hidden)]
	None = 0,
	[UMeta(MDFunc.DisplayName, "火焰类型")]
	Flame = 2,
	[UMeta(MDFunc.DisplayName, "毒类型")]
	Poison = 4,
	[UMeta(MDFunc.DisplayName, "弱安身术类型")]
	WeakGuardianCircle = 8
}
