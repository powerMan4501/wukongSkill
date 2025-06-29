using UnrealEngine.Runtime;

namespace BtlShare;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.ChallengeDifficulty")]
public enum EChallengeDifficulty : byte
{
	Min,
	Easy,
	Normal,
	Hard
}
