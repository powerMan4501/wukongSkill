using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ConcertSyncCore;

[UEnum]
[UMetaPath("/Script/ConcertSyncCore.EConcertPackageUpdateType", "ConcertSyncCore", UnrealModuleType.EnginePlugin)]
public enum EConcertPackageUpdateType
{
	Dummy,
	Added,
	Saved,
	Renamed,
	Deleted
}
