using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Engine.EBlendMode", "Engine", UnrealModuleType.Engine)]
public enum EBlendMode : byte
{
	BLEND_Opaque,
	BLEND_Masked,
	BLEND_Translucent,
	BLEND_Additive,
	BLEND_Modulate,
	BLEND_AlphaComposite,
	BLEND_AlphaHoldout
}
