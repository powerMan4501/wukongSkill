using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.ELevelInstanceRuntimeBehavior", "Engine", UnrealModuleType.Engine)]
public enum ELevelInstanceRuntimeBehavior
{
	None,
	Embedded_Deprecated,
	Partitioned,
	LevelStreaming
}
