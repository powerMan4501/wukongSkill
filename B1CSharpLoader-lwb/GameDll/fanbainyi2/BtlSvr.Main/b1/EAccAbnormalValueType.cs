using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[DisplayName("异常积累值类型")]
[USharpPath("/Script/b1-Managed.AccAbnormalValueType")]
public enum EAccAbnormalValueType : byte
{
	[DisplayName("绝对值")]
	IncreaseByValue,
	[DisplayName("万分比")]
	IncreaseByINV10000
}
