using UnrealEngine.Runtime;

namespace GSDispLib;

[UEnum]
[USharpPath("/Script/b1-Managed.DispLibDBCWindMotorMode")]
public enum DispLibDBCWindMotorMode : byte
{
	[DisplayName("无风")]
	[UMeta(MDProp.DisplayPriority, 1)]
	[UMeta(MD.ToolTip, "完全不注入风力")]
	NoWind,
	[DisplayName("局部定向风")]
	[UMeta(MD.ToolTip, "指定速度方向，风源区域内都注入同一个方向的风，强度依然计算末端衰减")]
	[UMeta(MDProp.DisplayPriority, 2)]
	LocalDirectionalWind,
	[UMeta(MDProp.DisplayPriority, 3)]
	[UMeta(MD.ToolTip, "点风源，风向指向四面八方")]
	[DisplayName("局部全向风")]
	LocalOmniWind,
	[UMeta(MD.ToolTip, "给定旋转轴，产生绕轴旋转的风，强度正负可控制旋转方向，调整遮罩可产生锥形范围")]
	[DisplayName("局部螺旋风")]
	[UMeta(MDProp.DisplayPriority, 4)]
	LocalVortexWind,
	[UMeta(MDProp.DisplayPriority, 5)]
	[UMeta(MD.ToolTip, "全向风的反向版本")]
	[DisplayName("局部吸收风")]
	LocalAbsorbWind
}
