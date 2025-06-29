using UnrealEngine.Runtime;

namespace UnrealEngine.MaterialShaderQualitySettings;

[UEnum]
[UMetaPath("/Script/MaterialShaderQualitySettings.EMobileShadowQuality", "MaterialShaderQualitySettings", UnrealModuleType.Engine)]
public enum EMobileShadowQuality
{
	NoFiltering,
	PCF_1x1,
	PCF_3x3,
	PCF_5x5
}
