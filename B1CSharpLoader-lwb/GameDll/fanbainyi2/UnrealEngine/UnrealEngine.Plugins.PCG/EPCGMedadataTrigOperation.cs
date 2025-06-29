using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UEnum]
[UMetaPath("/Script/PCG.EPCGMedadataTrigOperation", "PCG", UnrealModuleType.EnginePlugin)]
public enum EPCGMedadataTrigOperation
{
	Acos,
	Asin,
	Atan,
	Atan2,
	Cos,
	Sin,
	Tan,
	DegToRad,
	RadToDeg
}
