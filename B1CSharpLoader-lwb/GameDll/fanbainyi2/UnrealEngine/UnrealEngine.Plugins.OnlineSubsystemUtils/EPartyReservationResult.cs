using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.OnlineSubsystemUtils;

[UEnum]
[UMetaPath("/Script/OnlineSubsystemUtils.EPartyReservationResult", "OnlineSubsystemUtils", UnrealModuleType.EnginePlugin)]
public enum EPartyReservationResult
{
	NoResult,
	RequestPending,
	GeneralError,
	PartyLimitReached,
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
