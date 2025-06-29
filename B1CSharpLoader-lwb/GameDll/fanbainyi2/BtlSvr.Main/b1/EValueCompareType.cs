using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UEnum]
[USharpPath("/Script/b1-Managed.ValueCompareType")]
public enum EValueCompareType : byte
{
	IsEqualTo,
	IsNotEqualTo,
	IsLessThan,
	IsLessThanOrEqualTo,
	IsGreaterThan,
	IsGreaterThanOrEqualTo
}
