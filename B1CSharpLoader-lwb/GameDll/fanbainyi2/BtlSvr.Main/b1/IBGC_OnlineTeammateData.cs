using System.Collections.Generic;
using GUR.Runtime;

namespace b1;

[NeedToUI]
public interface IBGC_OnlineTeammateData
{
	Dictionary<int, TeamPlayerInfo> PlayerInfoDict { get; }

	List<PlayerMapTransformInfo> GetPlayerTranstion();
}
