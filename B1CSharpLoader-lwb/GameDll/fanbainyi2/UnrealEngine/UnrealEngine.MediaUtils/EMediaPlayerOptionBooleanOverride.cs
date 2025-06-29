using UnrealEngine.Runtime;

namespace UnrealEngine.MediaUtils;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/MediaUtils.EMediaPlayerOptionBooleanOverride", "MediaUtils", UnrealModuleType.Engine)]
public enum EMediaPlayerOptionBooleanOverride : byte
{
	UseMediaPlayerSetting,
	Enabled,
	Disabled
}
