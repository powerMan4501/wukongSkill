using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UEnum]
[UMetaPath("/Script/PCG.PCGNormalToDensityMode", "PCG", UnrealModuleType.EnginePlugin)]
public enum EPCGNormalToDensityMode
{
	Set,
	Minimum,
	Maximum,
	Add,
	Subtract,
	Multiply,
	Divide
}
