using UnrealEngine.Runtime;

namespace UnrealEngine.Renderer;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Renderer.ESparseVolumeTexturePreviewAttribute", "Renderer", UnrealModuleType.Engine)]
public enum ESparseVolumeTexturePreviewAttribute : byte
{
	ESVTPA_AttributesA_R,
	ESVTPA_AttributesA_G,
	ESVTPA_AttributesA_B,
	ESVTPA_AttributesA_A,
	ESVTPA_AttributesB_R,
	ESVTPA_AttributesB_G,
	ESVTPA_AttributesB_B,
	ESVTPA_AttributesB_A
}
