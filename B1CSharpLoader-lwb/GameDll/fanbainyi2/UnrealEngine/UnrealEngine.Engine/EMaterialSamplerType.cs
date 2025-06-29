using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Engine.EMaterialSamplerType", "Engine", UnrealModuleType.Engine)]
public enum EMaterialSamplerType : byte
{
	SAMPLERTYPE_Color,
	SAMPLERTYPE_Grayscale,
	SAMPLERTYPE_Alpha,
	SAMPLERTYPE_Normal,
	SAMPLERTYPE_Masks,
	SAMPLERTYPE_DistanceFieldFont,
	SAMPLERTYPE_LinearColor,
	SAMPLERTYPE_LinearGrayscale,
	SAMPLERTYPE_Data,
	SAMPLERTYPE_External,
	SAMPLERTYPE_VirtualColor,
	SAMPLERTYPE_VirtualGrayscale,
	SAMPLERTYPE_VirtualAlpha,
	SAMPLERTYPE_VirtualNormal,
	SAMPLERTYPE_VirtualMasks,
	SAMPLERTYPE_VirtualLinearColor,
	SAMPLERTYPE_VirtualLinearGrayscale
}
