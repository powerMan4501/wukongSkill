using UnrealEngine.Runtime;

namespace UnrealEngine.Slate;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Slate.EVirtualKeyboardTrigger", "Slate", UnrealModuleType.Engine)]
public enum EVirtualKeyboardTrigger : byte
{
	OnFocusByPointer,
	OnAllFocusEvents
}
