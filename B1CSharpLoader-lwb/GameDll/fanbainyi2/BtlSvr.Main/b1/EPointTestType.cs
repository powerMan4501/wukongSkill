using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/b1-Managed.PointTestType")]
public enum EPointTestType : byte
{
	CheckAngle,
	SkillArea,
	Distance,
	SkillCastRange,
	CharacterBlock,
	NavPathExist,
	Visible,
	Height
}
