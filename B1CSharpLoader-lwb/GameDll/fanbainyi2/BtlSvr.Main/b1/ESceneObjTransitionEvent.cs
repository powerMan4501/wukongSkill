using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.SceneObjTransitionEvent")]
public enum ESceneObjTransitionEvent : byte
{
	OnSpawn,
	Eliminate,
	OnReset,
	NextState,
	JumpToState0,
	JumpToState1,
	JumpToState2,
	JumpToState3,
	JumpToState4,
	JumpToState5,
	JumpToState6
}
