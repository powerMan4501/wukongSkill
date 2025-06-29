using UnrealEngine.Runtime;

namespace BtlShare;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.EffectRangeCenterType")]
public enum EEffectRangeCenterType : byte
{
	ActorPosition,
	HitPosition
}
