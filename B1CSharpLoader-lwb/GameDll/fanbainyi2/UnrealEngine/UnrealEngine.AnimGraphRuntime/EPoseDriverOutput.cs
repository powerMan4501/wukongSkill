using UnrealEngine.Runtime;

namespace UnrealEngine.AnimGraphRuntime;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/AnimGraphRuntime.EPoseDriverOutput", "AnimGraphRuntime", UnrealModuleType.Engine)]
public enum EPoseDriverOutput : byte
{
	DrivePoses,
	DriveCurves
}
