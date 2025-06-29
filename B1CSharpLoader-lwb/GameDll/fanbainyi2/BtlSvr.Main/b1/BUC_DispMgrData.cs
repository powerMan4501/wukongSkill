using System.Collections.Generic;
using b1.ECS;

namespace b1;

public class BUC_DispMgrData : IPersistentECSData
{
	public Dictionary<string, bool> OriMeshHiddenInGame = new Dictionary<string, bool>();

	public uint HiddenInGameHandleID { get; set; }
}
