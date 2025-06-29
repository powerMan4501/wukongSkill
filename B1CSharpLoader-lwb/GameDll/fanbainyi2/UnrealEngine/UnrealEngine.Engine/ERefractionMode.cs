using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.ERefractionMode", "Engine", UnrealModuleType.Engine)]
public enum ERefractionMode
{
	RM_IndexOfRefraction,
	RM_PixelNormalOffset
}
