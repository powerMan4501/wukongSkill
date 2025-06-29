using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ConcertSyncCore;

[UEnum]
[UMetaPath("/Script/ConcertSyncCore.EConcertSyncLockEventType", "ConcertSyncCore", UnrealModuleType.EnginePlugin)]
public enum EConcertSyncLockEventType
{
	Locked,
	Unlocked
}
