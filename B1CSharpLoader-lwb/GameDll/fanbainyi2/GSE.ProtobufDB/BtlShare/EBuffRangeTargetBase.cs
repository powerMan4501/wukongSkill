using UnrealEngine.Runtime;

namespace BtlShare;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.BuffRangeTargetBase")]
public enum EBuffRangeTargetBase : byte
{
	RootCaster,
	Caster,
	Owner
}
