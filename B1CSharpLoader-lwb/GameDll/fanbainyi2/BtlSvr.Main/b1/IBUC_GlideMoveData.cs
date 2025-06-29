using UnrealEngine.Runtime;

namespace b1;

public interface IBUC_GlideMoveData
{
	float GlideSlopeEdgeAngle { get; }

	float MaxGlideSpeed { get; }

	float MinGlideSpeed { get; }

	float MinSpeedAngle { get; }

	float MaxSpeedAngle { get; }

	float MoveControlReactionSpeed { get; }

	float MoveControlAddMaxSpeed { get; }

	float GlideDirectionMaxHoriAngle { get; }

	float GlideDirectionInputScale { get; }

	float GlideSpeedInputScale { get; }

	float GlideSlopeEdgeSpeed { get; }

	FVector GlideDirection { get; }

	FVector GlideDirectionXYPlane { get; }
}
