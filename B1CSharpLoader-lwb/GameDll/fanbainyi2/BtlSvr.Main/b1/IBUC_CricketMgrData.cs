using System.Collections.Generic;

namespace b1;

internal interface IBUC_CricketMgrData
{
	List<b1.CricketMovePointConfig> MovePointConfig { get; }

	int CurPointIndex { get; }

	string CricketGuid { get; }

	int InteractMaxJumpCount { get; }

	int InteractJumpCount { get; }

	float WeakDuration { get; }
}
