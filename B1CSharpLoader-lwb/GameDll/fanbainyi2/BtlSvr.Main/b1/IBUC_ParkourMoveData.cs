using UnrealEngine.Runtime;

namespace b1;

public interface IBUC_ParkourMoveData
{
	bool IsPakourMoving { get; }

	float RunStrideSpeedRate { get; }

	float SprintStrideSpeedRate { get; }

	FVector ParkourMoveCurLocation { get; }

	FVector ParkourDeltaMove { get; }

	EParkourProcessType ParkourProcessType { get; }

	EParkourHeightType GetCurParkourHeightType();

	bool ConsumeContinueState();
}
