using UnrealEngine.Runtime;

namespace UnrealEngine.UnrealEd;

[UEnum]
[UMetaPath("/Script/UnrealEd.EPasteTo", "UnrealEd", UnrealModuleType.Engine)]
public enum EPasteTo
{
	PT_OriginalLocation,
	PT_Here,
	PT_WorldOrigin
}
