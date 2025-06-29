using UnrealEngine.Runtime;

namespace b1;

internal struct FParkourLandCheckInfo
{
	public int CheckPointIndex;

	public FVector Location;

	public bool bWalkable;

	public float ZOffsetToNext;
}
