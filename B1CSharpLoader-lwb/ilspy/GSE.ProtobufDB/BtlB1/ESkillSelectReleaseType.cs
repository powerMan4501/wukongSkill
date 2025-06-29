using UnrealEngine.Runtime;

namespace BtlB1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.SkillSelectReleaseType")]
public enum ESkillSelectReleaseType : byte
{
	None,
	StartRelease,
	StartSelectEndRelease,
	EndRelease,
	StartSelectStartRelease,
	EndSelectEndRelease
}
