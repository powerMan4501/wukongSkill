using UnrealEngine.Runtime;

namespace UnrealEngine.UMG;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/UMG.EWidgetTimingPolicy", "UMG", UnrealModuleType.Engine)]
public enum EWidgetTimingPolicy : byte
{
	RealTime,
	GameTime
}
