using UnrealEngine.Runtime;

namespace UnrealEngine.UnrealEd;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/UnrealEd.EFBXSceneNormalGenerationMethod", "UnrealEd", UnrealModuleType.Engine)]
public enum EFBXSceneNormalGenerationMethod : byte
{
	BuiltIn,
	MikkTSpace
}
