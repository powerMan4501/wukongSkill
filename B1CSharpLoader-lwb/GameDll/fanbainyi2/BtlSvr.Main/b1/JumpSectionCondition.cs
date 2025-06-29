using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/b1-Managed.JumpSectionCondition")]
internal enum JumpSectionCondition : byte
{
	SceneItemNotFound,
	FindSceneItemsWithSkillID
}
