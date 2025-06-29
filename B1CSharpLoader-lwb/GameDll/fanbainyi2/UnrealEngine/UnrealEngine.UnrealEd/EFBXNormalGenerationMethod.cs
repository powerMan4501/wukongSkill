using UnrealEngine.Runtime;

namespace UnrealEngine.UnrealEd;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/UnrealEd.EFBXNormalGenerationMethod", "UnrealEd", UnrealModuleType.Engine)]
public enum EFBXNormalGenerationMethod : byte
{
	BuiltIn,
	MikkTSpace
}
