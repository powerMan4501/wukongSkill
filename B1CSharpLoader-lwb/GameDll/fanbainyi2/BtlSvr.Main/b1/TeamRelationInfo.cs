using System.Collections.Generic;

namespace b1;

public class TeamRelationInfo
{
	public List<int> HostileTeamIDs;

	public Dictionary<int, int> TeamDamageReductionRatios;

	public TeamRelationInfo()
	{
		HostileTeamIDs = new List<int>();
		TeamDamageReductionRatios = new Dictionary<int, int>();
	}
}
