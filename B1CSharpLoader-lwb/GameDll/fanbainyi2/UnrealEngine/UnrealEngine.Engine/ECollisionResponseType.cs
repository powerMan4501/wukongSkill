using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Engine.ECollisionResponse", "Engine", UnrealModuleType.Engine)]
public enum ECollisionResponseType : byte
{
	ECR_Ignore,
	ECR_Overlap,
	ECR_Block
}
