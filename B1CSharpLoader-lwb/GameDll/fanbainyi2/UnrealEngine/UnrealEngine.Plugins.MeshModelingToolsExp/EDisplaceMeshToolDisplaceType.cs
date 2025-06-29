using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MeshModelingToolsExp;

[UEnum]
[UMetaPath("/Script/MeshModelingToolsExp.EDisplaceMeshToolDisplaceType", "MeshModelingToolsExp", UnrealModuleType.EnginePlugin)]
public enum EDisplaceMeshToolDisplaceType
{
	Constant,
	DisplacementMap,
	RandomNoise,
	PerlinNoise,
	SineWave
}
