using UnrealEngine.Runtime;

namespace BtlShare;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.BuffEffectTargetSelectType")]
public enum EBuffEffectTargetSelectType : byte
{
	BuffTarget,
	BuffOwner,
	Both
}
