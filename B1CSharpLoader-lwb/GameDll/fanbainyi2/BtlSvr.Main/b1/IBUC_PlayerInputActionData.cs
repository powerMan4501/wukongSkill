namespace b1;

public interface IBUC_PlayerInputActionData
{
	float AxisSkillDragY { get; }

	float AxisSkillDragX { get; }

	bool IsWithInputMoving { get; }

	bool bPressedSprinting { get; }

	float MoveWeakInputTimer { get; }

	float DeltaTime { get; }
}
