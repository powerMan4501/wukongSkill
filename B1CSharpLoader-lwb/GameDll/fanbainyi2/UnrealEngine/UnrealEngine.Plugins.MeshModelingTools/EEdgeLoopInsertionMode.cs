using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MeshModelingTools;

[UEnum]
[UMetaPath("/Script/MeshModelingTools.EEdgeLoopInsertionMode", "MeshModelingTools", UnrealModuleType.EnginePlugin)]
public enum EEdgeLoopInsertionMode
{
	Retriangulate,
	PlaneCut
}
