using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Rejoin;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Rejoin.ERejoinStatus", "Rejoin", UnrealModuleType.EnginePlugin)]
public enum ERejoinStatus : byte
{
	NoMatchToRejoin,
	RejoinAvailable,
	UpdatingStatus,
	NeedsRecheck,
	NoMatchToRejoin_MatchEnded
}
