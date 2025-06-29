using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Concert;

[UEnum]
[UMetaPath("/Script/Concert.EConcertConnectionStatus", "Concert", UnrealModuleType.EnginePlugin)]
public enum EConcertConnectionStatus
{
	Connecting,
	Connected,
	Disconnecting,
	Disconnected
}
