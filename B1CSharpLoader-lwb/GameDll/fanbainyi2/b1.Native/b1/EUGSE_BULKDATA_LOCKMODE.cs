using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[UMetaPath("/Script/UnrealExtent.UGSE_BULKDATA_LOCKMODE", "UnrealExtent", UnrealModuleType.Game)]
public enum EUGSE_BULKDATA_LOCKMODE
{
	LOCK_READ_ONLY = 1,
	LOCK_READ_WRITE
}
