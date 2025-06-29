using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.SceneObjControllerType")]
public enum ESceneObjControllerType : byte
{
	Base,
	CharacterActiveState,
	TriggerState,
	ActorCallState,
	TriggerBox,
	RebirthPointActiveState,
	DynamicObstacleState
}
