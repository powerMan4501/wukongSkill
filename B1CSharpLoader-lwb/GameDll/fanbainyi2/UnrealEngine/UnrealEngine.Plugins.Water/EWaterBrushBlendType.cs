using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Water;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Water.EWaterBrushBlendType", "Water", UnrealModuleType.EnginePlugin)]
public enum EWaterBrushBlendType : byte
{
	AlphaBlend,
	Min,
	Max,
	Additive
}
