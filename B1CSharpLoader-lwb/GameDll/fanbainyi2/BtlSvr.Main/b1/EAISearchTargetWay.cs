using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/b1-Managed.EAISearchTargetWay")]
public enum EAISearchTargetWay : byte
{
	FindTargetNearest,
	FindTargetFurthest,
	FindTargetByHatred
}
