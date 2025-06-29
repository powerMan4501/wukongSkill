using UnrealEngine.Runtime;

namespace BtlShare;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.SkillRotateType")]
public enum ESkillRotateType : byte
{
	None,
	MeleeRotate,
	Shooting,
	Roll,
	Qteprepare,
	Qtedoing,
	RotateToCamera,
	RotateToTargetInstantly
}
