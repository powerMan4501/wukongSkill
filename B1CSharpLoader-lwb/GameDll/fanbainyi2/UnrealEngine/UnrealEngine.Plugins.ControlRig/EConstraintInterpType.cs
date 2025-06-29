using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/ControlRig.EConstraintInterpType", "ControlRig", UnrealModuleType.EnginePlugin)]
public enum EConstraintInterpType : byte
{
	Average,
	Shortest,
	Max
}
