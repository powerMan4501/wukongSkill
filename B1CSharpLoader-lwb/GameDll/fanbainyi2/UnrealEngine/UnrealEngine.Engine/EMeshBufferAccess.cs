using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EMeshBufferAccess", "Engine", UnrealModuleType.Engine)]
public enum EMeshBufferAccess
{
	Default,
	ForceCPUAndGPU
}
