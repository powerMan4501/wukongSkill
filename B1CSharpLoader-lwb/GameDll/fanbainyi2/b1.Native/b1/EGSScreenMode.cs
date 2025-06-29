using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/UnrealExtent.EGSScreenMode", "UnrealExtent", UnrealModuleType.Game)]
public enum EGSScreenMode : byte
{
	FULL_SCREEN,
	WINDOWED_NO_BORDER,
	WINDOWED
}
