using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

public interface IBUC_PointSetsData
{
	Dictionary<int, List<FVector>> PointQueneMap { get; }

	Dictionary<int, List<FRotator>> PointQueneMap_Rot { get; }
}
