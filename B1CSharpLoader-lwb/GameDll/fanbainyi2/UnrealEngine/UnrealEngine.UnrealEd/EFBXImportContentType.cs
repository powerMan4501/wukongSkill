using UnrealEngine.Runtime;

namespace UnrealEngine.UnrealEd;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/UnrealEd.EFBXImportContentType", "UnrealEd", UnrealModuleType.Engine)]
public enum EFBXImportContentType : byte
{
	FBXICT_All,
	FBXICT_Geometry,
	FBXICT_SkinningWeights
}
