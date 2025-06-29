using UnrealEngine.Runtime;

namespace UnrealEngine.GeometryFramework;

[UEnum]
[UMetaPath("/Script/GeometryFramework.EDynamicMeshComponentRenderUpdateMode", "GeometryFramework", UnrealModuleType.Engine)]
public enum EDynamicMeshComponentRenderUpdateMode
{
	NoUpdate,
	FullUpdate,
	FastUpdate
}
