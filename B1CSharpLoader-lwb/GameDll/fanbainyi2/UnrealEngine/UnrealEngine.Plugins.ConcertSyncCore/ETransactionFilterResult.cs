using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ConcertSyncCore;

[UEnum]
[UMetaPath("/Script/ConcertSyncCore.ETransactionFilterResult", "ConcertSyncCore", UnrealModuleType.EnginePlugin)]
public enum ETransactionFilterResult
{
	IncludeObject,
	ExcludeObject,
	ExcludeTransaction,
	UseDefault
}
