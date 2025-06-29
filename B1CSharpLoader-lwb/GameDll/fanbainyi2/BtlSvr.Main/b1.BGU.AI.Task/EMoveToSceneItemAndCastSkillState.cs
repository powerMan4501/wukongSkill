using UnrealEngine.Runtime;

namespace b1.BGU.AI.Task;

[UEnum]
[BlueprintType]
[USharpPath("/Script/b1-Managed.MoveToSceneItemAndCastSkillState")]
public enum EMoveToSceneItemAndCastSkillState : byte
{
	None = 0,
	RotateToSceneItem = 2,
	MoveToSceneItem = 3,
	TryCastSkill = 4,
	CastingSkill = 5,
	EnumMax = 6
}
