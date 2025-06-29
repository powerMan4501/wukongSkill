using System.Collections.Generic;
using BtlB1;
using UnrealEngine.AIModule;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public interface IBUC_AIData
{
	bool IsAI { get; }

	bool UseMultipointLock { get; }

	float MultipointLockMaxAngle { get; }

	float MultipointLockDistanceScoreRating { get; }

	EFsmSolverType CurrentFsmSolverType { get; }

	AIData_ComboInfo ComboInfo { get; }

	bool IsBeHitResetAIWatchTime { get; }

	EUnitAIDetourCrowdType DetourCrowdType { get; }

	float SightRange { get; }

	float VisionAngleDegrees { get; }

	int DefaultLeftSmallTurnSkillID { get; }

	int DefaultRightSmallTurnSkillID { get; }

	int DefaultLeftBigTurnSkillID { get; }

	int DefaultRightBigTurnSkillID { get; }

	int DefaultLeftSmallMoveSkillID { get; }

	int DefaultRightSmallMoveSkillID { get; }

	int DefaultLeftBigMoveSkillID { get; }

	int DefaultRightBigMoveSkillID { get; }

	int HatredTargetRandomSelectNum { get; }

	float StrongPerceptionDistance { get; }

	bool CanEffectPlayerBattleState { get; }

	int GetCurComboLength();

	int GetMaxComboNum();

	List<int> GetGroupAISkillList();

	bool GetIsMoveInValidByNav();

	float GetWatchTime();

	UBehaviorTree GetConfigBT();

	UBehaviorTree GetCurrentRunBT();

	AActor GetCurEQSTarget(AActor Owner);

	float GetLastAtkDmgTime();

	EFsmSolverType GetCurrentFsmSolverType();

	bool IsInPursuitRange(FVector CheckPos);

	FVector GetEnterBattlePosition();
}
