using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Concert;

[UEnum]
[UMetaPath("/Script/Concert.EConcertClientStatus", "Concert", UnrealModuleType.EnginePlugin)]
public enum EConcertClientStatus
{
	Connected,
	Disconnected,
	Updated
}
