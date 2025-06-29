using System.Collections.Generic;

namespace b1;

public interface IBGC_DebugTargetMgrData
{
	List<BGUDebugNiaActor> DebugNiaActorPool { get; }

	List<BGUDebugTargetInfo> DebugTargetInfos { get; }
}
