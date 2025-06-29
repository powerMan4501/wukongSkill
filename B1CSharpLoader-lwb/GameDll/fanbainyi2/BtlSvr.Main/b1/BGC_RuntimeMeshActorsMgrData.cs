using System.Collections.Generic;
using b1.ECS;

namespace b1;

public class BGC_RuntimeMeshActorsMgrData : IBGC_RuntimeMeshActorsMgrData, IPersistentECSData
{
	public List<BGURuntimeMeshActor> RuntimeMeshActors = new List<BGURuntimeMeshActor>();

	public List<SliceInfo> PendingSliceInfos = new List<SliceInfo>();

	public int IntervalRemain;
}
