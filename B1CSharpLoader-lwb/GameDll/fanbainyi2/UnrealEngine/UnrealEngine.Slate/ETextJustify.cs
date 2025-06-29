using UnrealEngine.Runtime;

namespace UnrealEngine.Slate;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Slate.ETextJustify", "Slate", UnrealModuleType.Engine)]
public enum ETextJustify : byte
{
	Left,
	Center,
	Right
}
