using UnrealEngine.Runtime;

namespace UnrealEngine.GeometryFramework;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/GeometryFramework.EDynamicMeshAttributeChangeFlags", "GeometryFramework", UnrealModuleType.Engine)]
public enum EDynamicMeshAttributeChangeFlags : byte
{
	Unknown = 0,
	MeshTopology = 1,
	VertexPositions = 2,
	NormalsTangents = 4,
	VertexColors = 8,
	UVs = 0x10,
	TriangleGroups = 0x20
}
