using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.ETextureSizingType", "Engine", UnrealModuleType.Engine)]
public enum ETextureSizingType
{
	TextureSizingType_UseSingleTextureSize,
	TextureSizingType_UseAutomaticBiasedSizes,
	TextureSizingType_UseManualOverrideTextureSize,
	TextureSizingType_UseSimplygonAutomaticSizing,
	TextureSizingType_AutomaticFromTexelDensity,
	TextureSizingType_AutomaticFromMeshScreenSize,
	TextureSizingType_AutomaticFromMeshDrawDistance
}
