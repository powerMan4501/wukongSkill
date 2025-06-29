using UnrealEngine.Runtime;

namespace b1;

public class AIPointData : AIDataBase
{
	public FVector Point;

	public AIPointData(FVector Point)
	{
		this.Point = Point;
	}

	public override FVector GetLocation()
	{
		return Point;
	}
}
