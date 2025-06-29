using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EMeshApproximationUVGenerationPolicy", "Engine", UnrealModuleType.Engine)]
public enum EMeshApproximationUVGenerationPolicy
{
	PreferUVAtlas,
	PreferXAtlas,
	PreferPatchBuilder
}
