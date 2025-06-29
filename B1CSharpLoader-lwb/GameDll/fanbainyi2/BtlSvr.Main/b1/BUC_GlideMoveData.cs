using UnrealEngine.Runtime;

namespace b1;

internal class BUC_GlideMoveData : IBUC_GlideMoveData
{
	public float GlideSlopeEdgeAngle { get; set; }

	public float MaxGlideSpeed { get; set; }

	public float MinGlideSpeed { get; set; }

	public float MaxSpeedAngle { get; set; }

	public float MinSpeedAngle { get; set; }

	public float MoveControlReactionSpeed { get; set; }

	public float MoveControlAddMaxSpeed { get; set; }

	public float GlideDirectionMaxHoriAngle { get; set; }

	public float GlideDirectionInputScale { get; set; }

	public float GlideSpeedInputScale { get; set; }

	public float GlideSlopeEdgeSpeed { get; set; }

	public FVector GlideDirection { get; set; }

	public FVector GlideDirectionXYPlane { get; set; }

	public int PreventGlideSkillID { get; set; }

	public bool bDisableEnterGlideMove { get; set; }
}
