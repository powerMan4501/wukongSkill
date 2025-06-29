using UnrealEngine.Runtime;

namespace b1;

[UMeta(MDEnum.UseEnumValuesAsMaskValuesInEditor, true)]
[UMeta(MDEnum.Bitflags)]
[UEnum]
[USharpPath("/Script/b1-Managed.ProjectileDisableAbilityType")]
public enum EProjectileDisableAbilityType : byte
{
	[UMeta(MD.Hidden)]
	Default = 0,
	[UMeta(MDFunc.DisplayName, "SweepCheck")]
	SweepCheck = 2,
	[UMeta(MDFunc.DisplayName, "常驻音效")]
	Audio = 4
}
