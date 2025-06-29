using UnrealEngine.Runtime;

namespace UnrealEngine.UMG;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/UMG.EVirtualKeyboardType", "UMG", UnrealModuleType.Engine)]
public enum EVirtualKeyboardType : byte
{
	Default,
	Number,
	Web,
	Email,
	Password,
	AlphaNumeric
}
