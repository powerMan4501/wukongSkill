using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UEnum]
[USharpPath("/Script/b1-Managed.SkillIDSource")]
public enum ESkillIDSource : byte
{
	Custom,
	FromSceneItem
}
