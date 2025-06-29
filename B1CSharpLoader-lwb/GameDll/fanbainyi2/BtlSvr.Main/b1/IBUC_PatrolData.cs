using UnrealEngine.Runtime;

namespace b1;

public interface IBUC_PatrolData
{
	EPatrolType PatrolType { get; }

	bool bDisableRestartOnLeaveFight { get; }

	bool bDisableRestartOnReset { get; }

	EBGUMoveAIType FindPathMoveType { get; }

	EAIMoveSpeedType PatrolMoveSpeedType { get; }

	bool bEnablePatrolOnStart { get; }

	FVector StartLeisureLocation { get; }

	GSRandomPatrolConfig RandomPatrolConfig { get; }

	GSSplinePatrolConfig SplinePatrolConfig { get; }

	GSLeisureConfig LeisureConfig { get; }

	bool bIsPatroling { get; }

	bool bIsInLeisure { get; }

	bool HasReplaceLeisureSequenceID();
}
