using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MeshPaintingToolset;

[UEnum]
[UMetaPath("/Script/MeshPaintingToolset.EMeshPaintDataColorViewMode", "MeshPaintingToolset", UnrealModuleType.EnginePlugin)]
public enum EMeshPaintDataColorViewMode
{
	Normal,
	RGB,
	Alpha,
	Red,
	Green,
	Blue
}
