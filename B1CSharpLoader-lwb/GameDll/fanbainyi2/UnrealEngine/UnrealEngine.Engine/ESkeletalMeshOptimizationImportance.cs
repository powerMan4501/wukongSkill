using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.SkeletalMeshOptimizationImportance", "Engine", UnrealModuleType.Engine)]
public enum ESkeletalMeshOptimizationImportance
{
	SMOI_Off,
	SMOI_Lowest,
	SMOI_Low,
	SMOI_Normal,
	SMOI_High,
	SMOI_Highest
}
