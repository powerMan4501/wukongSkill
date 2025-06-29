using UnrealEngine.Runtime;

namespace BtlShare;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.HitSlowResumeType")]
public enum EHitSlowResumeType : byte
{
	Linear,
	EaseIn,
	EaseOut,
	EnumMax
}
