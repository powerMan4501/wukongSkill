using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ConcertSyncCore;

[UEnum]
[UMetaPath("/Script/ConcertSyncCore.EConcertSyncTransactionActivitySummaryType", "ConcertSyncCore", UnrealModuleType.EnginePlugin)]
public enum EConcertSyncTransactionActivitySummaryType
{
	Added,
	Updated,
	Renamed,
	Deleted
}
