using UnrealEngine.Runtime;

namespace UnrealEngine.UnrealEd;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/UnrealEd.ELevelVisibilityDirtyMode", "UnrealEd", UnrealModuleType.Engine)]
public enum ELevelVisibilityDirtyMode : byte
{
	ModifyOnChange,
	DontModify
}
