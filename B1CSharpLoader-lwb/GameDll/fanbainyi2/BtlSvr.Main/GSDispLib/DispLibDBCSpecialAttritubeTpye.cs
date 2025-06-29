using UnrealEngine.Runtime;

namespace GSDispLib;

[UEnum]
[USharpPath("/Script/b1-Managed.DispLibDBCSpecialAttritubeTpye")]
public enum DispLibDBCSpecialAttritubeTpye : byte
{
	[UMeta(MDProp.DisplayPriority, 1)]
	[UMeta(MD.ToolTip, "如果Actor有简单状态 PhysicsSimulationMoveMode 则使用物理速度，否则使用 SourceOwnerComp.GetVelocity()；此时【值】表示速度平滑插值速率")]
	[DisplayName("速度")]
	Velocity
}
