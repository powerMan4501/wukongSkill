namespace b1;

public enum EGroupAIHotZoneType
{
	None = 0,
	MeleeAtkHotZone = 1,
	ShortDistanceAtkHotZone = 2,
	RangeAtkHotZone = 4,
	MiddleDistanceAtkHotZone = 8,
	LongDistanceAtkHotZone = 0x10,
	OutsideHotZone = 0x20
}
