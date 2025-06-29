using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EPropertyAccessCopyBatch", "Engine", UnrealModuleType.Engine)]
public enum EPropertyAccessCopyBatch
{
	InternalUnbatched,
	ExternalUnbatched,
	InternalBatched,
	ExternalBatched,
	Count
}
