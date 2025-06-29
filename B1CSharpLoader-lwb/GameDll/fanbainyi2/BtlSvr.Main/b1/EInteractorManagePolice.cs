using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.InteractorManagePolice")]
public enum EInteractorManagePolice : byte
{
	[DisplayName("与前状态保持一致")]
	SameAsPrevious,
	[DisplayName("保持可交互")]
	KeepInteractive,
	[DisplayName("保持不可交互")]
	KeepNotInteractive
}
