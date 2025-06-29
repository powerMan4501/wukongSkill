using UnrealEngine.Runtime;

namespace BtlB1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.HitPartReduceAttrType")]
public enum EHitPartReduceAttrType : byte
{
	None,
	Hp,
	Mp,
	Stamina
}
