using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UEnum]
[UMetaPath("/Script/PCG.EPCGMedadataMathsOperation", "PCG", UnrealModuleType.EnginePlugin)]
public enum EPCGMedadataMathsOperation
{
	UnaryOp = 1024,
	Sign = 1025,
	Frac = 1026,
	Truncate = 1027,
	Round = 1028,
	Sqrt = 1029,
	Abs = 1030,
	Floor = 1031,
	Ceil = 1032,
	OneMinus = 1033,
	BinaryOp = 2048,
	Add = 2049,
	Subtract = 2050,
	Multiply = 2051,
	Divide = 2052,
	Max = 2053,
	Min = 2054,
	Pow = 2055,
	ClampMin = 2056,
	ClampMax = 2057,
	Modulo = 2058,
	Set = 2059,
	TernaryOp = 4096,
	Clamp = 4097,
	Lerp = 4098
}
