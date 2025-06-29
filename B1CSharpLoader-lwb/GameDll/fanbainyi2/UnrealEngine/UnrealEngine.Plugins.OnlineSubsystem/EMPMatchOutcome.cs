using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.OnlineSubsystem;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/OnlineSubsystem.EMPMatchOutcome", "OnlineSubsystem", UnrealModuleType.EnginePlugin)]
public enum EMPMatchOutcome : byte
{
	None,
	Quit,
	Won,
	Lost,
	Tied,
	TimeExpired,
	First,
	Second,
	Third,
	Fourth
}
