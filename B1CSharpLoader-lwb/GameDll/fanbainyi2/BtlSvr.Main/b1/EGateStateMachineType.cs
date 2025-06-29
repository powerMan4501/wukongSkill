using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.GateStateMachineType")]
public enum EGateStateMachineType : byte
{
	[DisplayName("无")]
	[UMeta(MD.ToolTip, "功能性保留")]
	[UMeta(MDProp.DisplayPriority, 1)]
	None,
	[UMeta(MDProp.DisplayPriority, 2)]
	[UMeta(MD.ToolTip, "破碎物门状态机，用于进行破碎物的状态控制与恢复。 关:未破碎  开:已破碎")]
	[DisplayName("破碎物门状态机")]
	Destructible
}
