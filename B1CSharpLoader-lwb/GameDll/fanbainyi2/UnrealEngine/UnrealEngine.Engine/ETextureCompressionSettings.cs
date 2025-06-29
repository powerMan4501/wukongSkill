using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.TextureCompressionSettings", "Engine", UnrealModuleType.Engine)]
public enum ETextureCompressionSettings
{
	TC_Default,
	TC_Normalmap,
	TC_Masks,
	TC_Grayscale,
	TC_Displacementmap,
	TC_VectorDisplacementmap,
	TC_HDR,
	TC_EditorIcon,
	TC_Alpha,
	TC_DistanceFieldFont,
	TC_HDR_Compressed,
	TC_BC7,
	TC_HalfFloat,
	TC_LQ,
	TC_EncodedReflectionCapture
}
