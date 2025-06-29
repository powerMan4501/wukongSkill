using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Landmass;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Landmass.EBrushBlendType", "Landmass", UnrealModuleType.EnginePlugin)]
public enum EBrushBlendType : byte
{
	AlphaBlend,
	Min,
	Max,
	Additive
}
