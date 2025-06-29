using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.ETextureChromaticAdaptationMethod", "Engine", UnrealModuleType.Engine)]
public enum ETextureChromaticAdaptationMethod
{
	TCAM_None,
	TCAM_Bradford,
	TCAM_CAT02
}
