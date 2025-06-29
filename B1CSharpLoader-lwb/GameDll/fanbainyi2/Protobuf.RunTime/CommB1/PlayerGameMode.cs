using UnrealEngine.Runtime;

namespace CommB1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/Protobuf-RunTime.PlayerGameMode")]
public enum PlayerGameMode : byte
{
	Console,
	Online,
	Party
}
