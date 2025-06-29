using UnrealEngine.Runtime;

namespace UnrealEngine.SlateCore;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/SlateCore.ECheckBoxState", "SlateCore", UnrealModuleType.Engine)]
public enum ECheckBoxState : byte
{
	Unchecked,
	Checked,
	Undetermined
}
