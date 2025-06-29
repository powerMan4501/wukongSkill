using UnrealEngine.Runtime;

namespace UnrealEngine.UMG;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/UMG.EWidgetInteractionSource", "UMG", UnrealModuleType.Engine)]
public enum EWidgetInteractionSource : byte
{
	World,
	Mouse,
	CenterScreen,
	Custom
}
