using UnrealEngine.Runtime;

namespace UnrealEngine.UnrealEd;

[UEnum]
[UMetaPath("/Script/UnrealEd.ETextureSourceColorSpace", "UnrealEd", UnrealModuleType.Engine)]
public enum ETextureSourceColorSpace
{
	Auto,
	Linear,
	SRGB
}
