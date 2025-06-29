using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.ELightmapType", "Engine", UnrealModuleType.Engine)]
public enum ELightmapType
{
	Default,
	ForceSurface,
	ForceVolumetric
}
