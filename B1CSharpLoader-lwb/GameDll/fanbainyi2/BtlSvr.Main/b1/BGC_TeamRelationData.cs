using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;

namespace b1;

public class BGC_TeamRelationData : IBGC_TeamRelationData, IPersistentECSData
{
	public Dictionary<int, TeamRelationInfo> TeamHostileInfos = new Dictionary<int, TeamRelationInfo>();

	public bool IsEnemyTeam(int TeamID1, int TeamID2)
	{
		if (TeamID1 == TeamID2)
		{
			return false;
		}
		if (TeamHostileInfos.TryGetValue(TeamID1, out var value) && TeamHostileInfos.TryGetValue(TeamID2, out var value2))
		{
			if (!value.HostileTeamIDs.Contains(TeamID2))
			{
				return value2.HostileTeamIDs.Contains(TeamID1);
			}
			return true;
		}
		return true;
	}

	public bool IsEnemyTeam(AActor Actor1, AActor Actor2)
	{
		if (Actor1 is ITeamCS teamCS && Actor2 is ITeamCS teamCS2)
		{
			int teamIDInCS = teamCS.GetTeamIDInCS();
			int teamIDInCS2 = teamCS2.GetTeamIDInCS();
			if (teamIDInCS == 0 || teamIDInCS2 == 0)
			{
				return false;
			}
			return IsEnemyTeam(teamIDInCS, teamIDInCS2);
		}
		return false;
	}

	public int GetTeamDamageReductionRatio(int SelfTeam, int AttackerTeam)
	{
		if (TeamHostileInfos.TryGetValue(SelfTeam, out var value))
		{
			if (!value.TeamDamageReductionRatios.TryGetValue(AttackerTeam, out var value2))
			{
				return 0;
			}
			return value2;
		}
		return 0;
	}

	public int GetTeamDamageReductionRatio(AActor SelfActor, AActor Attacker)
	{
		BGUCharacterCS bGUCharacterCS = SelfActor as BGUCharacterCS;
		BGUCharacterCS bGUCharacterCS2 = Attacker as BGUCharacterCS;
		if (bGUCharacterCS != null && bGUCharacterCS2 != null)
		{
			int teamIDInCS = bGUCharacterCS.GetTeamIDInCS();
			int teamIDInCS2 = bGUCharacterCS2.GetTeamIDInCS();
			if (teamIDInCS == 0 || teamIDInCS2 == 0)
			{
				return 0;
			}
			return GetTeamDamageReductionRatio(teamIDInCS, teamIDInCS2);
		}
		return 0;
	}
}
