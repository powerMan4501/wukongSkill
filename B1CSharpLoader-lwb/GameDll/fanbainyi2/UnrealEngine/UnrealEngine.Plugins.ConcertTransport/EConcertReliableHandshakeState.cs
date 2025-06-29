using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ConcertTransport;

[UEnum]
[UMetaPath("/Script/ConcertTransport.EConcertReliableHandshakeState", "ConcertTransport", UnrealModuleType.EnginePlugin)]
public enum EConcertReliableHandshakeState
{
	None,
	Negotiate,
	Success
}
