using UnrealEngine.Runtime;

namespace UnrealEngine.StaticMeshEditor;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/StaticMeshEditor.EScriptCollisionShapeType", "StaticMeshEditor", UnrealModuleType.Engine)]
public enum EScriptCollisionShapeType : byte
{
	Box,
	Sphere,
	Capsule,
	NDOP10_X,
	NDOP10_Y,
	NDOP10_Z,
	NDOP18,
	NDOP26
}
