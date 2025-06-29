using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EMontageNotifyTickType", "Engine", UnrealModuleType.Engine)]
public enum EMontageNotifyTickType
{
	Queued,
	BranchingPoint
}
