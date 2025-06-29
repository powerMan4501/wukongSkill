using UnrealEngine.Runtime;

namespace BtlShare;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.SkillBaseTarget")]
public enum ESkillBaseTarget : byte
{
	NoneOrCurrenttarget,
	Self,
	Master,
	NearlySpecialUnitByResid,
	Player,
	SceneItem,
	EQS,
	MasterTarget
}
