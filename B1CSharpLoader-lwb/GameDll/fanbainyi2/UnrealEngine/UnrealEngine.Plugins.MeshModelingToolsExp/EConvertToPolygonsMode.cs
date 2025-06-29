using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MeshModelingToolsExp;

[UEnum]
[UMetaPath("/Script/MeshModelingToolsExp.EConvertToPolygonsMode", "MeshModelingToolsExp", UnrealModuleType.EnginePlugin)]
public enum EConvertToPolygonsMode
{
	FaceNormalDeviation,
	FromUVIslands,
	FromNormalSeams,
	FromConnectedTris,
	FromFurthestPointSampling
}
