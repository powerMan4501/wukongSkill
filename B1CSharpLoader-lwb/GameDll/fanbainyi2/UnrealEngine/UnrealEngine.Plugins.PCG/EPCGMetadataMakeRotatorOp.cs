using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UEnum]
[UMetaPath("/Script/PCG.EPCGMetadataMakeRotatorOp", "PCG", UnrealModuleType.EnginePlugin)]
public enum EPCGMetadataMakeRotatorOp
{
	MakeRotFromX,
	MakeRotFromY,
	MakeRotFromZ,
	MakeRotFromXY,
	MakeRotFromYX,
	MakeRotFromXZ,
	MakeRotFromZX,
	MakeRotFromYZ,
	MakeRotFromZY,
	MakeRotFromAxes,
	MakeRotFromAngles
}
