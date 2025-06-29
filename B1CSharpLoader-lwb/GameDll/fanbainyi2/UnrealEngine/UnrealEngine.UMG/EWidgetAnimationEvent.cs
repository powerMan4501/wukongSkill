using UnrealEngine.Runtime;

namespace UnrealEngine.UMG;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/UMG.EWidgetAnimationEvent", "UMG", UnrealModuleType.Engine)]
public enum EWidgetAnimationEvent : byte
{
	Started,
	Finished
}
