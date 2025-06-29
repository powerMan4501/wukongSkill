using UnrealEngine.Runtime;

namespace b1;

public interface IBUC_ABPSplineMoveData
{
	bool bSplineMoveForward { get; }

	bool bSplineMoveInSharpturn { get; }

	bool bSplineMoveShouldSharpturn { get; }

	float SplineMoveStopTimer { get; }

	float SharpturnAngle { get; }

	FRotator GetRotationTarget(IBUC_ABPCharacterData ChrData, IBUC_ABPHelperData HelperData, float DeltaTime);
}
