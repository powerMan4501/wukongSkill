using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Landmass;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Landmass.EBrushFalloffMode", "Landmass", UnrealModuleType.EnginePlugin)]
public enum EBrushFalloffMode : byte
{
	Angle,
	Width
}
