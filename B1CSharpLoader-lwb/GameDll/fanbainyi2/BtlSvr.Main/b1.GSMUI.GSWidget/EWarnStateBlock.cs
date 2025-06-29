using UnrealEngine.Runtime;

namespace b1.GSMUI.GSWidget;

[UEnum]
[BlueprintType]
[USharpPath("/Script/b1-Managed.WarnStateBlock")]
public enum EWarnStateBlock : byte
{
	[DisplayName("不阻断")]
	UnBlock,
	[DisplayName("阻断Once")]
	BlockOnce,
	[DisplayName("阻断State")]
	BlockState,
	[DisplayName("阻断所有")]
	BlockAll,
	EnumMax
}
