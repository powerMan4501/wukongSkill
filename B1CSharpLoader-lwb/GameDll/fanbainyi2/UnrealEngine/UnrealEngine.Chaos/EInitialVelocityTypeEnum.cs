using UnrealEngine.Runtime;

namespace UnrealEngine.Chaos;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Chaos.EInitialVelocityTypeEnum", "Chaos", UnrealModuleType.Engine)]
public enum EInitialVelocityTypeEnum : byte
{
	Chaos_Initial_Velocity_User_Defined,
	Chaos_Initial_Velocity_None,
	Chaos_Max
}
