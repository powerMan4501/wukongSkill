using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Engine.EDrawDebugTrace", "Engine", UnrealModuleType.Engine)]
public enum EDrawDebugTrace : byte
{
	None,
	ForOneFrame,
	ForDuration,
	Persistent
}
