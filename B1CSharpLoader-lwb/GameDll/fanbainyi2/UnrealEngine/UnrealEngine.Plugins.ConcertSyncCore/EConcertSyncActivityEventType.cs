using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ConcertSyncCore;

[UEnum]
[UMetaPath("/Script/ConcertSyncCore.EConcertSyncActivityEventType", "ConcertSyncCore", UnrealModuleType.EnginePlugin)]
public enum EConcertSyncActivityEventType
{
	None,
	Connection,
	Lock,
	Transaction,
	Package
}
