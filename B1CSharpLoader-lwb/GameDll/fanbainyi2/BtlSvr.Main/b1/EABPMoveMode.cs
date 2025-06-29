using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.EABPMoveMode")]
public enum EABPMoveMode : byte
{
	None,
	Locomotion_Simple4Dir,
	[DisplayName("Locomotion Paragon 4Dir (DEPRECATED)")]
	Locomotion_Paragon4Dir,
	[DisplayName("Locomotion Simple 8Dir (DEPRECATED)")]
	Locomotion_Simple8Dir,
	MotionMatching,
	[DisplayName("Car Move (DEPRECATED)")]
	CarMove,
	[DisplayName("Locomotion Player 8Dir (DEPRECATED)")]
	Locomotion_Player8Dir,
	SimpleFlyControl,
	PlayerLocomotion,
	ComplexFlyControl,
	MonsterLocomotion,
	AdvancedMonsterLocomotion,
	QuadrupedLocomotion,
	CloudLocomotion
}
