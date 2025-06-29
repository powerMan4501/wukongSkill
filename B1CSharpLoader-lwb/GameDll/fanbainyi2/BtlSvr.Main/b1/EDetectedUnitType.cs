using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/b1-Managed.DetectedUnitType")]
public enum EDetectedUnitType : byte
{
	Self,
	Target,
	Master,
	Player,
	UseSmartUnit
}
