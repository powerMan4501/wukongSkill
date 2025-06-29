using UnrealEngine.Runtime;

namespace UnrealEngine.UnrealEd;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/UnrealEd.EFBXImportType", "UnrealEd", UnrealModuleType.Engine)]
public enum EFBXImportType : byte
{
	FBXIT_StaticMesh,
	FBXIT_SkeletalMesh,
	FBXIT_Animation
}
