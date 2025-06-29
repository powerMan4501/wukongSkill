using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UEnum]
[USharpPath("/Script/b1-Managed.ValueCompareOperationType")]
public enum EValueCompareOperationType : byte
{
	[DisplayName("等于")]
	EqualTo,
	[DisplayName("不等于")]
	NotEqualTo,
	[DisplayName("小于")]
	LessThan,
	[DisplayName("小于等于")]
	LessThanOrEqualTo,
	[DisplayName("大于")]
	GreaterThan,
	[DisplayName("大于等于")]
	GreaterThanOrEqualTo
}
