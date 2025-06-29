using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ConcertSyncCore;

[UEnum]
[UMetaPath("/Script/ConcertSyncCore.EConcertDataStoreResultCode", "ConcertSyncCore", UnrealModuleType.EnginePlugin)]
public enum EConcertDataStoreResultCode
{
	Added,
	Fetched,
	Exchanged,
	NotFound,
	TypeMismatch,
	UnexpectedError
}
