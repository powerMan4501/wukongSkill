using UnrealEngine.Runtime;

namespace UnrealEngine.InteractiveToolsFramework;

[UEnum]
[UMetaPath("/Script/InteractiveToolsFramework.ESceneSnapQueryTargetType", "InteractiveToolsFramework", UnrealModuleType.Engine)]
public enum ESceneSnapQueryTargetType
{
	None = 0,
	MeshVertex = 1,
	MeshEdge = 2,
	Grid = 4,
	All = 7
}
