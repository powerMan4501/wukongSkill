using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MeshModelingTools;

[UEnum]
[UMetaPath("/Script/MeshModelingTools.ERevolvePropertiesPolygroupMode", "MeshModelingTools", UnrealModuleType.EnginePlugin)]
public enum ERevolvePropertiesPolygroupMode
{
	PerShape,
	PerFace,
	PerRevolveStep,
	PerPathSegment
}
