using UnrealEngine.Runtime;

namespace UnrealEngine.AIModule;

[UEnum]
[UMetaPath("/Script/AIModule.FAIDistanceType", "AIModule", UnrealModuleType.Engine)]
public enum EFAIDistanceType
{
	Distance3D,
	Distance2D,
	DistanceZ
}
