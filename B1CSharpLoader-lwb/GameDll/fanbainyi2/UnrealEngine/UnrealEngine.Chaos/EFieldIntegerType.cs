using UnrealEngine.Runtime;

namespace UnrealEngine.Chaos;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Chaos.EFieldIntegerType", "Chaos", UnrealModuleType.Engine)]
public enum EFieldIntegerType : byte
{
	Integer_DynamicState,
	Integer_ActivateDisabled,
	Integer_CollisionGroup,
	Integer_PositionAnimated,
	Integer_PositionStatic,
	Integer_TargetMax
}
