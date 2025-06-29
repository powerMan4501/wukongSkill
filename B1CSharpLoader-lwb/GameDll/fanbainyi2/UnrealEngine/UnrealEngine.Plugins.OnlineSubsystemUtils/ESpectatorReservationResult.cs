using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.OnlineSubsystemUtils;

[UEnum]
[UMetaPath("/Script/OnlineSubsystemUtils.ESpectatorReservationResult", "OnlineSubsystemUtils", UnrealModuleType.EnginePlugin)]
public enum ESpectatorReservationResult
{
	NoResult,
	RequestPending,
	GeneralError,
	SpectatorLimitReached,
	IncorrectPlayerCount,
	RequestTimedOut,
	ReservationDuplicate,
	ReservationNotFound,
	ReservationAccepted,
	ReservationDenied,
	ReservationDenied_CrossPlayRestriction,
	ReservationDenied_Banned,
	ReservationRequestCanceled,
	ReservationInvalid,
	BadSessionId,
	ReservationDenied_ContainsExistingPlayers
}
