using UnrealEngine.Runtime;

namespace UnrealEngine.InputCore;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/InputCore.EControllerHand", "InputCore", UnrealModuleType.Engine)]
public enum EControllerHand : byte
{
	Left,
	Right,
	AnyHand,
	Pad,
	ExternalCamera,
	Gun,
	HMD,
	Special_1,
	Special_2,
	Special_3,
	Special_4,
	Special_5,
	Special_6,
	Special_7,
	Special_8,
	Special_9,
	Special_10,
	Special_11,
	ControllerHand_Count
}
