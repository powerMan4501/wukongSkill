using GUR.Runtime;
using UnrealEngine.Engine;

namespace b1;

[NeedToUI]
public interface IBGC_OnlineChallengeData
{
	bool ChallengeIsBegin(int ChallengeId, int ChallengeLevel = 0);

	bool PlayerInChallenge(APlayerController PlayerController, out int ChallengeId);

	bool CheckPlayerInChallengeAndRemove(APlayerController PlayerController, out int ChallengeId);

	int GetChallengeLevel(int ChallenegeId);

	float GetLimitTime(int ChallenegeId);

	int GetDropIdByGuid(int ChallengeId, int CurLevel = 0);
}
