using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.AppleImageUtils;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/AppleImageUtils.EAppleTextureType", "AppleImageUtils", UnrealModuleType.EnginePlugin)]
public enum EAppleTextureType : byte
{
	Unknown,
	Image,
	PixelBuffer,
	Surface,
	MetalTexture
}
