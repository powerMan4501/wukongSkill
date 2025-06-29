using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ConcertSyncCore;

[UEnum]
[UMetaPath("/Script/ConcertSyncCore.EConcertResourceLockType", "ConcertSyncCore", UnrealModuleType.EnginePlugin)]
public enum EConcertResourceLockType
{
	None,
	Lock,
	Unlock
}
