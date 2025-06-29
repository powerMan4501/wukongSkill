using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EAnimSyncMethod", "Engine", UnrealModuleType.Engine)]
public enum EAnimSyncMethod
{
	DoNotSync,
	SyncGroup,
	Graph
}
