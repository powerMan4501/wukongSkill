using UnrealEngine.Runtime;

namespace UnrealEngine.GeometryFramework;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/GeometryFramework.EDynamicMeshChangeType", "GeometryFramework", UnrealModuleType.Engine)]
public enum EDynamicMeshChangeType : byte
{
	GeneralEdit,
	MeshChange,
	MeshReplacementChange,
	MeshVertexChange,
	DeformationEdit,
	AttributeEdit
}
