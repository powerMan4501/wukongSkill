using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.ERuntimeVirtualTextureMaterialType", "Engine", UnrealModuleType.Engine)]
public enum ERuntimeVirtualTextureMaterialType
{
	BaseColor,
	BaseColor_Normal_DEPRECATED,
	BaseColor_Normal_Roughness,
	BaseColor_Normal_Specular,
	BaseColor_Normal_Specular_YCoCg,
	BaseColor_Normal_Specular_Mask_YCoCg,
	WorldHeight,
	Count
}
