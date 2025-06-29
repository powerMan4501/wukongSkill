using System.Collections.Generic;

namespace b1;

internal interface IBUC_ActorInitData
{
	Dictionary<EInitDataModuleType, GSInitDataModuleBase> InitData { get; }

	bool HasInitialized { get; }

	bool bSaveInitData { get; }
}
