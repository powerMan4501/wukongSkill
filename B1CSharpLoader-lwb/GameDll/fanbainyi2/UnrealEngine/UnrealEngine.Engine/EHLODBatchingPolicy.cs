using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EHLODBatchingPolicy", "Engine", UnrealModuleType.Engine)]
public enum EHLODBatchingPolicy
{
	None,
	MeshSection,
	Instancing
}
