using System.Collections.Generic;

namespace b1;

internal class BUC_TriggerProcessControllerData : b1.IBUC_TriggerProcessControllerData
{
	public List<FSceneObjWithState> AttachedTriggerObjs { get; set; }

	public List<FSceneObjTriggerEvent> NeedActivateObjs { get; set; }

	public Dictionary<int, bool> MapObjIndexActiveState { get; set; }
}
