namespace b1;

public interface IBUC_ABPParkourMoveData
{
	EParkourProcessType CurParkourProcessType { get; }

	EParkourHeightType CurParkourHeightType { get; }

	bool bParkourLandCanMove { get; }

	bool bParkourContinue { get; }

	float StrideHeight { get; }
}
