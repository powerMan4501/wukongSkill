using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.FishSpikeJumpType")]
public enum FishSpikeJumpType : byte
{
	[UMeta(MD.DisplayName, "默认无限制")]
	Default,
	[UMeta(MD.DisplayName, "仅靠近")]
	OnlyCloseTo,
	[UMeta(MD.DisplayName, "仅远离")]
	OnlyFarFrom,
	[UMeta(MD.DisplayName)]
	None
}
