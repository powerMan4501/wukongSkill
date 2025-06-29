using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MeshModelingToolsExp;

[UEnum]
[UMetaPath("/Script/MeshModelingToolsExp.EWeightScheme", "MeshModelingToolsExp", UnrealModuleType.EnginePlugin)]
public enum EWeightScheme
{
	Uniform,
	Umbrella,
	Valence,
	MeanValue,
	Cotangent,
	ClampedCotangent,
	IDTCotangent
}
