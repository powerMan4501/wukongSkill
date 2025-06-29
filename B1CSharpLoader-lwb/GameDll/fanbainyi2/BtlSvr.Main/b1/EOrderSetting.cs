using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UEnum]
[USharpPath("/Script/b1-Managed.OrderSetting")]
public enum EOrderSetting : byte
{
	Baseline,
	Top,
	Bottom
}
