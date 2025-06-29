using UnrealEngine.Runtime;

namespace GSDispLib;

[UEnum]
[USharpPath("/Script/b1-Managed.DispLibDBCSnapGroundRotationMode")]
public enum DispLibDBCSnapGroundRotationMode : byte
{
	[DisplayName("命中点法线投影")]
	[UMeta(MD.ToolTip, "特效的X轴对齐检测射线命中点的法线投影方向")]
	HitPointNormalProjected,
	[DisplayName("组件X轴")]
	[UMeta(MD.ToolTip, "特效的X轴对齐所属Comp的X轴")]
	CompXAxis
}
