using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.FightBackCountType")]
public enum EFightBackCountType : byte
{
	[UMeta(MD.DisplayName, "击中计数")]
	BeHitCount,
	[UMeta(MD.DisplayName, "硬直计数")]
	StiffCount
}
