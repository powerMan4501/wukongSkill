using UnrealEngine.Runtime;

namespace UnrealEngine.AnimGraphRuntime;

[UEnum]
[UMetaPath("/Script/AnimGraphRuntime.ESnapshotSourceMode", "AnimGraphRuntime", UnrealModuleType.Engine)]
public enum ESnapshotSourceMode
{
	NamedSnapshot,
	SnapshotPin
}
