using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MeshPaintingToolset;

[UEnum]
[UMetaPath("/Script/MeshPaintingToolset.ETexturePaintWeightTypes", "MeshPaintingToolset", UnrealModuleType.EnginePlugin)]
public enum ETexturePaintWeightTypes
{
	AlphaLerp = 2,
	RGB,
	ARGB,
	OneMinusARGB
}
