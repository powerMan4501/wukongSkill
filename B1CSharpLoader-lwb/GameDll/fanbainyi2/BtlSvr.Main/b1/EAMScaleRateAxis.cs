using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UEnum]
[USharpPath("/Script/b1-Managed.EAMScaleRateAxis")]
public enum EAMScaleRateAxis : byte
{
	[DisplayName("默认")]
	[Tooltip("各轴以X轴缩放值进行缩放")]
	AllByScaleRateAxisX,
	[Tooltip("各轴各自计算缩放值缩放")]
	[DisplayName("缩放所有轴")]
	All,
	[DisplayName("仅缩放X轴")]
	[Tooltip("仅缩放X轴")]
	AxisX,
	[Tooltip("仅缩放Y轴")]
	[DisplayName("仅缩放Y轴")]
	AxisY,
	[Tooltip("仅缩放Z轴")]
	[DisplayName("仅缩放Z轴")]
	AxisZ,
	[DisplayName("仅缩放Z轴落地")]
	[Tooltip("仅缩放Z轴，用于落地缩放")]
	AxisZLanding
}
