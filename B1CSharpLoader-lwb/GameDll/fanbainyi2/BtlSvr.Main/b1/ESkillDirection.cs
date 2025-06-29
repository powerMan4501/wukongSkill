using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.SkillDirection")]
public enum ESkillDirection : byte
{
	None,
	Forward,
	Right,
	Backward,
	Left
}
