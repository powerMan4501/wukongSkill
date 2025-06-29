using System.Collections.Generic;

namespace b1;

internal interface IBUC_TriggerProcessControllerData
{
	List<FSceneObjWithState> AttachedTriggerObjs { get; }

	List<FSceneObjTriggerEvent> NeedActivateObjs { get; }

	Dictionary<int, bool> MapObjIndexActiveState { get; }
}
