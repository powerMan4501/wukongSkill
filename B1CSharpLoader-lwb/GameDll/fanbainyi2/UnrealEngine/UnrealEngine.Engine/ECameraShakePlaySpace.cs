using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.ECameraShakePlaySpace", "Engine", UnrealModuleType.Engine)]
public enum ECameraShakePlaySpace
{
	CameraLocal,
	World,
	UserDefined
}
