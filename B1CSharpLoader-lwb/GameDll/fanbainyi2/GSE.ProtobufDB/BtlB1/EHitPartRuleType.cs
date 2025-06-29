using UnrealEngine.Runtime;

namespace BtlB1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.HitPartRuleType")]
public enum EHitPartRuleType : byte
{
	ByPa,
	ByDir,
	ByExclude
}
