using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.OnlineSubsystemUtils;

[UEnum]
[UMetaPath("/Script/OnlineSubsystemUtils.EClientRequestType", "OnlineSubsystemUtils", UnrealModuleType.EnginePlugin)]
public enum EClientRequestType
{
	NonePending,
	ExistingSessionReservation,
	ReservationUpdate,
	EmptyServerReservation,
	Reconnect,
	Abandon,
	ReservationRemoveMembers,
	AddOrUpdateReservation
}
