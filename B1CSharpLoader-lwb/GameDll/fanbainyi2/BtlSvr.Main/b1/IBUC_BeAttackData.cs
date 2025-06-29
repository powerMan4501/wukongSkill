using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public interface IBUC_BeAttackData
{
	string UnitBeAttackedConfigPath { get; }

	int GetCurrentBeAttackedInfoID();

	AActor GetAttacker();

	bool IsPlayedMontage();

	FVector GetAttractionLocation();

	int GetLastBeAttackedStiffLevel();

	int GetCurrentBeAttackedStiffLevel();

	string GetCurrentBeAttackedAttackerGUID();

	int GetSkillBeHitCounter(int SkillID, float CurTimeSeconds = -1f, float TimeDuration = -1f);

	int GetSkillEffectBeHitCounter(int SkillEffectID, float CurTimeSeconds = -1f, float TimeDuration = -1f);

	FVector GetLastBeAttackedHitLocation();
}
