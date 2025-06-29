using UnrealEngine.Runtime;

namespace BtlB1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.HitPartRecoverAttrType")]
public enum EHitPartRecoverAttrType : byte
{
	None,
	Hp,
	Mp,
	Stamina,
	Pevalue,
	TransEnergy
}
