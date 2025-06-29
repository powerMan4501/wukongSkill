using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.TextureFilter", "Engine", UnrealModuleType.Engine)]
public enum ETextureFilter
{
	TF_Nearest,
	TF_Bilinear,
	TF_Trilinear,
	TF_Default
}
