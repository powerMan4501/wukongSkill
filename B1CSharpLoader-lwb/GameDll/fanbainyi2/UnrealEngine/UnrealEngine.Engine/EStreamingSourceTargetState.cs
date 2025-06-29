using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EStreamingSourceTargetState", "Engine", UnrealModuleType.Engine)]
public enum EStreamingSourceTargetState
{
	Loaded,
	Activated
}
