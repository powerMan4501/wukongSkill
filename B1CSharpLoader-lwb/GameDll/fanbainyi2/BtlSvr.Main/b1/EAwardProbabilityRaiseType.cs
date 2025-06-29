using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/b1-Managed.AwardProbabilityRaiseType")]
public enum EAwardProbabilityRaiseType : byte
{
	[UMeta(MD.Hidden)]
	None,
	[DisplayName("提升为一级概率")]
	RaiseToFirst,
	[DisplayName("提升为二级概率")]
	RaiseToSecond,
	[DisplayName("提升为指定概率")]
	RaiseToTarget,
	[UMeta(MD.Hidden)]
	EnumMax
}
