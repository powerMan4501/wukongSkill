using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MeshModelingTools;

[UEnum]
[UMetaPath("/Script/MeshModelingTools.EGroupEdgeInsertionMode", "MeshModelingTools", UnrealModuleType.EnginePlugin)]
public enum EGroupEdgeInsertionMode
{
	Retriangulate,
	PlaneCut
}
