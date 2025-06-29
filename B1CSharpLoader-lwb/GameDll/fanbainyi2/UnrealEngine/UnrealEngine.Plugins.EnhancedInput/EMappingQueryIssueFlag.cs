using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.EnhancedInput;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/EnhancedInput.EMappingQueryIssue", "EnhancedInput", UnrealModuleType.EnginePlugin)]
public enum EMappingQueryIssueFlag : byte
{
	NoIssue = 0,
	ReservedByAction = 1,
	HidesExistingMapping = 2,
	HiddenByExistingMapping = 4,
	CollisionWithMappingInSameContext = 8,
	ForcesTypePromotion = 0x10,
	ForcesTypeDemotion = 0x20
}
