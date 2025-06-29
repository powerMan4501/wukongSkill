using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EMaterialDecalResponse", "Engine", UnrealModuleType.Engine)]
public enum EMaterialDecalResponse
{
	MDR_None,
	MDR_ColorNormalRoughness,
	MDR_Color,
	MDR_ColorNormal,
	MDR_ColorRoughness,
	MDR_Normal,
	MDR_NormalRoughness,
	MDR_Roughness
}
