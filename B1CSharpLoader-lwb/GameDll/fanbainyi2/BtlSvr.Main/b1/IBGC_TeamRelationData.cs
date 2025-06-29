using UnrealEngine.Engine;

namespace b1;

public interface IBGC_TeamRelationData
{
	bool IsEnemyTeam(int TeamID1, int TeamID2);

	bool IsEnemyTeam(AActor Actor1, AActor Actor2);

	int GetTeamDamageReductionRatio(int SelfTeam, int AttackerTeam);

	int GetTeamDamageReductionRatio(AActor SelfActor, AActor Attacker);
}
