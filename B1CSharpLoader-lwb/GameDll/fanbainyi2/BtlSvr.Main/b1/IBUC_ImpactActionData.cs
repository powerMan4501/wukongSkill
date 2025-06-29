using UnrealEngine.Engine;

namespace b1;

internal interface IBUC_ImpactActionData
{
	bool bEnableImpactAction { get; }

	float EnableImpactActionHeightDiff { get; }

	float EnableImpactActionMinSpeed { get; }

	float LeftAngleSplitLine { get; }

	float MiddleLeftAngleSplitLine { get; }

	float MiddleRightAngleSplitLine { get; }

	float RightAngleSplitLine { get; }

	UAnimMontage ForwardImpactActionAnim { get; }

	UAnimMontage LeftSideImpactActionAnim { get; }

	UAnimMontage RightSideImpactActionAnim { get; }

	UCapsuleComponent CheckCapsule { get; }
}
