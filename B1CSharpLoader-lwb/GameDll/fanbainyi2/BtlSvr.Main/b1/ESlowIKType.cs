using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.SlowIKType")]
public enum ESlowIKType : byte
{
	[UProperty]
	None,
	[DisplayName("右手武器右手挥")]
	[UProperty]
	RightHand_WithWeaponR,
	[DisplayName("右手武器左手挥")]
	[UProperty]
	LeftHand_WithWeaponR,
	[DisplayName("左手武器左手挥")]
	[UProperty]
	LeftHand_WithWeaponL,
	[UProperty]
	[DisplayName("左手武器右手挥")]
	RightHand_WithWeaponL,
	[DisplayName("右手武器双手挥")]
	[UProperty]
	DoubleHand_WithWeaponR,
	[UProperty]
	[DisplayName("左手武器双手挥")]
	DoubleHand_WithWeaponL
}
