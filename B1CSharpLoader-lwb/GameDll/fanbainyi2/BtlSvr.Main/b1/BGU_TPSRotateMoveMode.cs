namespace b1;

public class BGU_TPSRotateMoveMode : BUC_MoveModeWithRotateBase
{
	protected override void OnUpdate(float DeltaTime)
	{
		base.OnUpdate(DeltaTime);
		if (GetIsRotateFinished())
		{
			int lastMoveIdx = GetActionRequestData().GetLastMoveIdx();
			EvtCollection.Evt_RotateToTargetComplete.Invoke(lastMoveIdx);
		}
		if (!BGUFunctionLibraryCS.BGUHasUnitSimpleState(OwnerCharacter, EBGUSimpleState.TPSMode))
		{
			StopMove();
		}
	}

	public override EBGUMoveMode GetMoveMode()
	{
		return EBGUMoveMode.TPSRotate;
	}
}
