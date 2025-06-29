using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.HairStrandsCore;

[UEnum]
[UMetaPath("/Script/HairStrandsCore.EGroomCacheAttributes", "HairStrandsCore", UnrealModuleType.EnginePlugin)]
public enum EGroomCacheAttributes
{
	None = 0,
	Position = 1,
	Width = 2,
	Color = 4,
	PositionWidth = 3,
	PositionColor = 5,
	WidthColor = 5,
	PositionWidthColor = 7
}
