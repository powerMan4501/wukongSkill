using UnrealEngine.Runtime;

namespace UnrealEngine.UMG;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/UMG.EWidgetSpace", "UMG", UnrealModuleType.Engine)]
public enum EWidgetSpace : byte
{
	World,
	Screen
}
