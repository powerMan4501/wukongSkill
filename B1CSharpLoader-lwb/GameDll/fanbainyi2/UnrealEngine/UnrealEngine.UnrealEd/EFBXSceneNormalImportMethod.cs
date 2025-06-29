using UnrealEngine.Runtime;

namespace UnrealEngine.UnrealEd;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/UnrealEd.EFBXSceneNormalImportMethod", "UnrealEd", UnrealModuleType.Engine)]
public enum EFBXSceneNormalImportMethod : byte
{
	FBXSceneNIM_ComputeNormals,
	FBXSceneNIM_ImportNormals,
	FBXSceneNIM_ImportNormalsAndTangents
}
