using UnrealEngine.Runtime;

namespace UnrealEngine.UMG;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/UMG.ESlateAccessibleBehavior", "UMG", UnrealModuleType.Engine)]
public enum ESlateAccessibleBehavior : byte
{
	NotAccessible,
	Auto,
	Summary,
	Custom,
	ToolTip
}
