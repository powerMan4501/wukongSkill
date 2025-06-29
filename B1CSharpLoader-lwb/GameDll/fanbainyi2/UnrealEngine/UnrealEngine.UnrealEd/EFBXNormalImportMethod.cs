using UnrealEngine.Runtime;

namespace UnrealEngine.UnrealEd;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/UnrealEd.EFBXNormalImportMethod", "UnrealEd", UnrealModuleType.Engine)]
public enum EFBXNormalImportMethod : byte
{
	FBXNIM_ComputeNormals,
	FBXNIM_ImportNormals,
	FBXNIM_ImportNormalsAndTangents
}
