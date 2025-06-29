using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Engine.ETextureRenderTargetFormat", "Engine", UnrealModuleType.Engine)]
public enum ETextureRenderTargetFormat : byte
{
	RTF_R8,
	RTF_RG8,
	RTF_RGBA8,
	RTF_RGBA8_SRGB,
	RTF_R16f,
	RTF_RG16f,
	RTF_RGBA16f,
	RTF_R32f,
	RTF_RG32f,
	RTF_RGBA32f,
	RTF_RGB10A2
}
