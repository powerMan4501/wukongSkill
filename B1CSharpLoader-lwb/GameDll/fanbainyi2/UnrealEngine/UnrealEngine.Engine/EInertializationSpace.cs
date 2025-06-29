using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EInertializationSpace", "Engine", UnrealModuleType.Engine)]
public enum EInertializationSpace
{
	Default,
	WorldSpace,
	WorldRotation
}
