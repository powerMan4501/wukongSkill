using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GameplayCameras;

[UEnum]
[UMetaPath("/Script/GameplayCameras.ECameraAnimationPlaySpace", "GameplayCameras", UnrealModuleType.EnginePlugin)]
public enum ECameraAnimationPlaySpace
{
	CameraLocal,
	World,
	UserDefined
}
