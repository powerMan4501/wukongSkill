using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UEnum]
[USharpPath("/Script/b1-Managed.PointBlockLocFlag")]
public enum PointBlockLocFlag : byte
{
	PBL_NONE = 0,
	PBL_N = 1,
	PBL_S = 2,
	PBL_W = 4,
	PBL_E = 8,
	PBL_NW = 5,
	PBL_NE = 9,
	PBL_SW = 6,
	PBL_SE = 10,
	PBL_NSWE = 15
}
