using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.ECameraProjectionMode", "Engine", UnrealModuleType.Engine)]
public enum ECameraProjectionMode
{
	Perspective,
	Orthographic
}
