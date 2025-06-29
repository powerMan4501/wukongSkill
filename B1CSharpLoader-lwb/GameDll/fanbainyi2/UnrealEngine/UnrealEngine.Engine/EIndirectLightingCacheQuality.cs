using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EIndirectLightingCacheQuality", "Engine", UnrealModuleType.Engine)]
public enum EIndirectLightingCacheQuality
{
	ILCQ_Off,
	ILCQ_Point,
	ILCQ_Volume
}
