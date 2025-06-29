using UnrealEngine.Runtime;

namespace BtlShare;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.EffectTargetBase")]
public enum EEffectTargetBase : byte
{
	Self,
	Target,
	Master,
	RootMaster
}
