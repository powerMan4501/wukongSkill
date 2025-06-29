using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Runtime;

namespace b1;

public class BUC_PointSetsData : IBUC_PointSetsData, IPersistentECSData
{
	public int CurID { get; set; }

	public Dictionary<int, List<FVector>> PointQueneMap { get; set; }

	public Dictionary<int, List<FRotator>> PointQueneMap_Rot { get; set; }

	public BUC_PointSetsData()
	{
		CurID = -1;
		PointQueneMap = new Dictionary<int, List<FVector>>();
		PointQueneMap_Rot = new Dictionary<int, List<FRotator>>();
	}
}
