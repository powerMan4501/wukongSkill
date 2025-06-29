using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.AppleImageUtils;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/AppleImageUtils.ETextureRotationDirection", "AppleImageUtils", UnrealModuleType.EnginePlugin)]
public enum ETextureRotationDirection : byte
{
	None,
	Left,
	Right,
	Down,
	LeftMirrored,
	RightMirrored,
	DownMirrored,
	UpMirrored
}
