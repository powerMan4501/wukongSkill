using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MeshModelingTools;

[UEnum]
[UMetaPath("/Script/MeshModelingTools.EEdgeLoopPositioningMode", "MeshModelingTools", UnrealModuleType.EnginePlugin)]
public enum EEdgeLoopPositioningMode
{
	Even,
	ProportionOffset,
	DistanceOffset
}
