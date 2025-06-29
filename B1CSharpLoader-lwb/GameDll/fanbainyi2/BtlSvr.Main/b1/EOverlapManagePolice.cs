using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.OverlapManagePolice")]
public enum EOverlapManagePolice : byte
{
	[DisplayName("与前状态保持一致")]
	SameAsPrevious,
	[DisplayName("保持可触发")]
	KeepEnable,
	[DisplayName("保持不可触发")]
	KeepDisable
}
