using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/b1-Managed.TileItemScene")]
public enum ETileItemScene : byte
{
	None,
	EquipItem,
	GearItem,
	RZDItem,
	ShopItem,
	ShopEquipItem,
	StrengthItem,
	StrengthRZDItem
}
