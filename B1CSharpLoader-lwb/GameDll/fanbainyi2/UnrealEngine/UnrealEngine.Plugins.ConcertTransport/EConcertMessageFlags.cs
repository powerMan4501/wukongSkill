using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ConcertTransport;

[UEnum]
[UMetaPath("/Script/ConcertTransport.EConcertMessageFlags", "ConcertTransport", UnrealModuleType.EnginePlugin)]
public enum EConcertMessageFlags
{
	None,
	ReliableOrdered,
	UniqueId
}
