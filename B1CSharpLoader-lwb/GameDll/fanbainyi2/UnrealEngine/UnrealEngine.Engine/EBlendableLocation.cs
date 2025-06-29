using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EBlendableLocation", "Engine", UnrealModuleType.Engine)]
public enum EBlendableLocation
{
	BL_AfterTonemapping,
	BL_BeforeTonemapping,
	BL_BeforeTranslucency,
	BL_ReplacingTonemapper,
	BL_SSRInput
}
