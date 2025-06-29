namespace b1;

public interface IBUC_ABPSpecialMoveData
{
	ESpecialMovementMode SpecialMovementMode { get; }

	ESpecialMovementMode LastSpecialMovementMode { get; }

	ESpecialMovementMode LastFrameSpecialMovementMode { get; }
}
