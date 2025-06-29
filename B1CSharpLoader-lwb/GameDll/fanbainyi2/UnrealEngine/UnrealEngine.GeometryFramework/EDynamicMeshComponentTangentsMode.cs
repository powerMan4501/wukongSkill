using UnrealEngine.Runtime;

namespace UnrealEngine.GeometryFramework;

[UEnum]
[UMetaPath("/Script/GeometryFramework.EDynamicMeshComponentTangentsMode", "GeometryFramework", UnrealModuleType.Engine)]
public enum EDynamicMeshComponentTangentsMode
{
	NoTangents,
	AutoCalculated,
	ExternallyProvided
}
