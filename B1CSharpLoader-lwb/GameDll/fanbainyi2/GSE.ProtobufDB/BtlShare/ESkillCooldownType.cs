using UnrealEngine.Runtime;

namespace BtlShare;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.SkillCooldownType")]
public enum ESkillCooldownType : byte
{
	TryToCast,
	ComboWindow,
	ChargeEnd
}
