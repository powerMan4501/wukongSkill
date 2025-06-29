using System.Collections.Generic;
using b1.ECS;

namespace b1;

public class BGC_DebugTargetMgrData : IBGC_DebugTargetMgrData, IPersistentECSData
{
	public List<BGUDebugNiaActor> DebugNiaActorPool { get; set; } = new List<BGUDebugNiaActor>();

	public List<BGUDebugTargetInfo> DebugTargetInfos { get; set; } = new List<BGUDebugTargetInfo>();
}
