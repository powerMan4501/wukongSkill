using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ConcertSyncCore;

[UEnum]
[UMetaPath("/Script/ConcertSyncCore.EConcertSyncConnectionEventType", "ConcertSyncCore", UnrealModuleType.EnginePlugin)]
public enum EConcertSyncConnectionEventType
{
	Connected,
	Disconnected
}
