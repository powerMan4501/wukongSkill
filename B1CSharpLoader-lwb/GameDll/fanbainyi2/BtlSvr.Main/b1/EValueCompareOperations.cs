using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UEnum]
[USharpPath("/Script/b1-Managed.ValueCompareOperations")]
public enum EValueCompareOperations : byte
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
	GreaterThanOrEqualTo,
	[DisplayName("百分比小于")]
	LessThanPercentage,
	[DisplayName("百分比小于等于")]
	LessThanOrEqualToPercentage,
	[DisplayName("百分比大于")]
	GreaterThanPercentage,
	[DisplayName("百分比大于等于")]
	GreaterThanOrEqualToPercentage
}
