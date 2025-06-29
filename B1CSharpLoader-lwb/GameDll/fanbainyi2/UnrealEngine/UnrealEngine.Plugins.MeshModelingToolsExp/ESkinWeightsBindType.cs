using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MeshModelingToolsExp;

[UEnum]
[UMetaPath("/Script/MeshModelingToolsExp.ESkinWeightsBindType", "MeshModelingToolsExp", UnrealModuleType.EnginePlugin)]
public enum ESkinWeightsBindType
{
	DirectDistance = 0,
	GeodesicVoxel = 3
}
