using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[UEnum]
[UMetaPath("/Script/ControlRig.ECRSimPointIntegrateType", "ControlRig", UnrealModuleType.EnginePlugin)]
public enum ECRSimPointIntegrateType
{
	Verlet,
	SemiExplicitEuler
}
