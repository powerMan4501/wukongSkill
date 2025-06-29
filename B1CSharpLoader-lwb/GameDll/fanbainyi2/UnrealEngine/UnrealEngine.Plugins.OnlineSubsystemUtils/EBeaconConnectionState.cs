using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.OnlineSubsystemUtils;

[UEnum]
[UMetaPath("/Script/OnlineSubsystemUtils.EBeaconConnectionState", "OnlineSubsystemUtils", UnrealModuleType.EnginePlugin)]
public enum EBeaconConnectionState
{
	Invalid,
	Closed,
	Pending,
	Open
}
