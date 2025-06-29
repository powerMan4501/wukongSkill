using UnrealEngine.Runtime;

namespace UnrealEngine.Slate;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Slate.EVirtualKeyboardDismissAction", "Slate", UnrealModuleType.Engine)]
public enum EVirtualKeyboardDismissAction : byte
{
	TextChangeOnDismiss,
	TextCommitOnAccept,
	TextCommitOnDismiss
}
