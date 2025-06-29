using System.Collections.Generic;
using GUR.Runtime;
using UnrealEngine.Runtime;

namespace b1;

[NeedToUI]
public interface IBPC_RebirthPointData
{
	bool IsRebirthPointRegistered(int RebirthPointID);

	bool IsRebirthPointActived(int RebirthPointID);

	int GetActivedRebirthPoints(out List<int> ActivedRebirthPointIdList);

	int GetBlockedRebirthPoints(out List<int> BlockedRebirthPointIdList);

	int GetCurrentRebirthPointID(UObject WorldContext);
}
