using UnrealEngine.Runtime;

namespace b1.GSMUI.GSWidget;

[UEnum]
[BlueprintType]
[USharpPath("/Script/b1-Managed.WarnState")]
public enum EWarnState : byte
{
	None,
	Danger,
	Safe,
	EnumMax
}
