using UnrealEngine.Runtime;

namespace BtlB1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.HitDestructibleStrengthType")]
public enum EHitDestructibleStrengthType : byte
{
	None,
	Light,
	Medium,
	Heavy,
	Special
}
