using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MeshPaintingToolset;

[UEnum]
[UMetaPath("/Script/MeshPaintingToolset.EMeshPaintWeightTypes", "MeshPaintingToolset", UnrealModuleType.EnginePlugin)]
public enum EMeshPaintWeightTypes
{
	AlphaLerp = 2,
	RGB,
	ARGB,
	OneMinusARGB
}
