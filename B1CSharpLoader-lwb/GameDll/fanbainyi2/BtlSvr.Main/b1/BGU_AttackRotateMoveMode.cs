namespace b1;

public class BGU_AttackRotateMoveMode : BUC_MoveModeWithRotateBase
{
	protected override void OnUpdate(float DeltaTime)
	{
		base.OnUpdate(DeltaTime);
		if (GetIsRotateFinished())
		{
			int lastMoveIdx = GetActionRequestData().GetLastMoveIdx();
			StopMove(bShouldRestoreLastMoveMode: true);
			EvtCollection.Evt_RotateToTargetComplete.Invoke(lastMoveIdx);
		}
	}

	public override EBGUMoveMode GetMoveMode()
	{
		return EBGUMoveMode.AttackRotate;
	}
}
