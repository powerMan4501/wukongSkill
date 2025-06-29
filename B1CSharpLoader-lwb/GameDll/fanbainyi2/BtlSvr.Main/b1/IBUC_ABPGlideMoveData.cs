using UnrealEngine.Engine;

namespace b1;

internal interface IBUC_ABPGlideMoveData
{
	UCurveVector MoveParamCurve { get; }

	EGlideMoveAnimState GlideMoveAnimState { get; }

	EGlideSlopeType GlideSlopeType { get; }

	float GlideDirCosValue { get; }

	bool bGlideRotationLeft { get; }

	bool bGlideRotationRight { get; }

	float GlideStartSpeedBlendAlpha { get; }

	float GlideLoopSpeedBlendAlpha { get; }

	float GlideDirAdditiveX { get; }

	float GlideDirAdditiveY { get; }

	float GlideLoopInputAdditiveX { get; }

	float GlideLoopInputAdditiveY { get; }

	bool bGlideEndSlow { get; }

	float EnterGlideTimer { get; }

	float EnterGlideGroundFriction { get; }

	void OnEnterGlideMove(IBUC_ABPCharacterData ChrData);
}
