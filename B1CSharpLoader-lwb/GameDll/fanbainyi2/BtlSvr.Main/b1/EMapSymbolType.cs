using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.MapSymbolType")]
public enum EMapSymbolType : byte
{
	[UMeta(MD.Hidden)]
	EnumMin,
	[DisplayName("玩家")]
	Player,
	[DisplayName("NPC")]
	Npc,
	[DisplayName("土地庙")]
	RebirthPoint,
	[DisplayName("目标点")]
	Pin,
	[UMeta(MD.Hidden)]
	EnumMax
}
