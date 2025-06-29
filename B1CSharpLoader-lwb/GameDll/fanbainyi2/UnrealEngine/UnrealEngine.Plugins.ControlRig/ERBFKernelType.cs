using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[UEnum]
[UMetaPath("/Script/ControlRig.ERBFKernelType", "ControlRig", UnrealModuleType.EnginePlugin)]
public enum ERBFKernelType
{
	Gaussian,
	Exponential,
	Linear,
	Cubic,
	Quintic
}
