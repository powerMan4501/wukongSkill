using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Water;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Water.EWaterBrushFalloffMode", "Water", UnrealModuleType.EnginePlugin)]
public enum EWaterBrushFalloffMode : byte
{
	Angle,
	Width
}
