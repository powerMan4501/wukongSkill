using UnrealEngine.Engine;

namespace b1;

public class BUC_ABPParkourMoveData : IBUC_ABPParkourMoveData
{
	private IBUC_ParkourMoveData ParkourMoveData;

	public EParkourProcessType CurParkourProcessType { get; set; }

	public EParkourHeightType CurParkourHeightType { get; set; }

	public bool bParkourLandCanMove { get; set; }

	public bool bParkourContinue { get; set; }

	public float StrideHeight { get; set; }

	public void Init(IBUC_ParkourMoveData InParkourMoveData)
	{
		ParkourMoveData = InParkourMoveData;
	}

	public void Update(AActor Owner, IBUC_ABPSpecialMoveData SpecialMoveData)
	{
		if (SpecialMoveData.SpecialMovementMode == ESpecialMovementMode.ParkourMove && ParkourMoveData != null)
		{
			bParkourContinue = ParkourMoveData.ConsumeContinueState();
			if (SpecialMoveData.LastSpecialMovementMode != ESpecialMovementMode.ParkourMove)
			{
				CurParkourProcessType = ParkourMoveData.ParkourProcessType;
				CurParkourHeightType = ParkourMoveData.GetCurParkourHeightType();
				bParkourLandCanMove = false;
			}
		}
	}
}
