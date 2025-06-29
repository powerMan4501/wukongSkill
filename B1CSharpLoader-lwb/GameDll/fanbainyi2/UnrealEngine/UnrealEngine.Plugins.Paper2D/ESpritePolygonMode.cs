using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Paper2D;

[UEnum]
[UMetaPath("/Script/Paper2D.ESpritePolygonMode", "Paper2D", UnrealModuleType.EnginePlugin)]
public enum ESpritePolygonMode
{
	SourceBoundingBox,
	TightBoundingBox,
	ShrinkWrapped,
	FullyCustom,
	Diced
}
