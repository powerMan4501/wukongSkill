using UnrealEngine.Engine;

namespace b1;

public class BUC_ABPSpecialMoveData : IBUC_ABPSpecialMoveData
{
	private IBUC_UnitStateData UnitStateData;

	private IBUC_ManualSplineMoveData ManualSplineMoveData;

	public ESpecialMovementMode SpecialMovementMode { get; set; }

	public ESpecialMovementMode LastSpecialMovementMode { get; set; }

	public ESpecialMovementMode LastFrameSpecialMovementMode { get; set; }

	public void Init(IBUC_UnitStateData InUnitStateData, IBUC_ManualSplineMoveData InManualSplineMoveData)
	{
		UnitStateData = InUnitStateData;
		ManualSplineMoveData = InManualSplineMoveData;
		ESpecialMovementMode eSpecialMovementMode = (SpecialMovementMode = ESpecialMovementMode.GroundMove);
		ESpecialMovementMode lastSpecialMovementMode = (LastFrameSpecialMovementMode = eSpecialMovementMode);
		LastSpecialMovementMode = lastSpecialMovementMode;
	}

	public void Update(AActor Owner, IBUC_ActorBasicData ActorBasicData, IBUC_ABPCharacterData ChrData)
	{
		LastFrameSpecialMovementMode = SpecialMovementMode;
		if (ActorBasicData.ActorType == BGU_ActorType.CharacterPlayer)
		{
			IBUC_ParkourMoveData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_ParkourMoveData, b1.BUC_ParkourMoveData>(Owner);
			IBUC_MovementData unPersistentReadOnlyData2 = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_MovementData, BUC_MovementData>(Owner);
			if (ChrData.IsFalling)
			{
				SpecialMovementMode = ESpecialMovementMode.AirMove;
			}
			else if (unPersistentReadOnlyData2 != null && unPersistentReadOnlyData2.IsMoveModeActive(EBGUMoveMode.SplineFlyControl))
			{
				SpecialMovementMode = ESpecialMovementMode.GroundMove;
			}
			else if (ManualSplineMoveData != null && ManualSplineMoveData.IsManuaslSplineMovingWithSpecialAnimation())
			{
				SpecialMovementMode = ESpecialMovementMode.SplineMove;
			}
			else if (unPersistentReadOnlyData != null && unPersistentReadOnlyData.IsPakourMoving)
			{
				SpecialMovementMode = ESpecialMovementMode.ParkourMove;
			}
			else if (UnitStateData != null && UnitStateData.HasState(EBGUUnitState.GlideMoving))
			{
				SpecialMovementMode = ESpecialMovementMode.GlideMove;
			}
			else if (ChrData.IsFlying)
			{
				SpecialMovementMode = ESpecialMovementMode.FlyMove;
			}
			else
			{
				SpecialMovementMode = ESpecialMovementMode.GroundMove;
			}
			if (SpecialMovementMode != LastFrameSpecialMovementMode)
			{
				LastSpecialMovementMode = LastFrameSpecialMovementMode;
			}
		}
	}
}
