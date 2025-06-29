using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/b1-Managed.MapCatFlag")]
public enum MapCatFlag : byte
{
	CAT_NONE = 0,
	CAT_N = 1,
	CAT_S = 2,
	CAT_W = 4,
	CAT_E = 8,
	CAT_NE = 9,
	CAT_NW = 5,
	CAT_NS = 3,
	CAT_WE = 12,
	CAT_SW = 6,
	CAT_SE = 10,
	CAT_NWE = 13,
	CAT_NSW = 7,
	CAT_NSE = 11,
	CAT_SWE = 14,
	CAT_NSWE = 15
}
