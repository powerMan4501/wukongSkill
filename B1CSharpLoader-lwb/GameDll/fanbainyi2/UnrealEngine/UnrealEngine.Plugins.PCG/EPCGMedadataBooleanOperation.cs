using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UEnum]
[UMetaPath("/Script/PCG.EPCGMedadataBooleanOperation", "PCG", UnrealModuleType.EnginePlugin)]
public enum EPCGMedadataBooleanOperation
{
	And,
	Not,
	Or,
	Xor
}
