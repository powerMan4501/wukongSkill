using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.SpeedInterpMode")]
public enum ESpeedInterpMode : byte
{
	[Category("百分比")]
	ByPercentage,
	[Category("固定数值")]
	ByValue
}
