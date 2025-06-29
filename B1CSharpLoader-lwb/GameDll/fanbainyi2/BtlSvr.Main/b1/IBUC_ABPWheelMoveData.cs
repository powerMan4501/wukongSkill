using UnrealEngine.Engine;

namespace b1;

internal interface IBUC_ABPWheelMoveData
{
	UCurveVector MoveParamCurve { get; }

	float MovePlayRate { get; }

	float BSRotationAdditiveX { get; }

	bool bMoveNearToTarget { get; }
}
