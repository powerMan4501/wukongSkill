using UnrealEngine.Runtime;

namespace UnrealEngine.UMG;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/UMG.ESlateVisibility", "UMG", UnrealModuleType.Engine)]
public enum ESlateVisibility : byte
{
	Visible,
	Collapsed,
	Hidden,
	HitTestInvisible,
	SelfHitTestInvisible
}
