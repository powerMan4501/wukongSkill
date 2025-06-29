using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UEnum]
[UMetaPath("/Script/PCG.EPCGMedadataBitwiseOperation", "PCG", UnrealModuleType.EnginePlugin)]
public enum EPCGMedadataBitwiseOperation
{
	And,
	Not,
	Or,
	Xor
}
