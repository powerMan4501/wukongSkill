using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.OnlineSubsystemUtils;

[UEnum]
[UMetaPath("/Script/OnlineSubsystemUtils.ESpectatorClientRequestType", "OnlineSubsystemUtils", UnrealModuleType.EnginePlugin)]
public enum ESpectatorClientRequestType
{
	NonePending,
	ExistingSessionReservation,
	ReservationUpdate,
	EmptyServerReservation,
	Reconnect,
	Abandon
}
