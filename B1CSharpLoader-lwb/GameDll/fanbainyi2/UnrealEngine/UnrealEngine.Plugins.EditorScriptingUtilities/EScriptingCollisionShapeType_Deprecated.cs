using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.EditorScriptingUtilities;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/EditorScriptingUtilities.EScriptingCollisionShapeType_Deprecated", "EditorScriptingUtilities", UnrealModuleType.EnginePlugin)]
public enum EScriptingCollisionShapeType_Deprecated : byte
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
