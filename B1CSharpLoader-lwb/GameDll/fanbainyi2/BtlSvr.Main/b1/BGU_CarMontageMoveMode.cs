namespace b1;

public class BGU_CarMontageMoveMode : BUC_MoveModeBase
{
	private float InputForward;

	private float InputRight;

	public override void MoveForward(float Value)
	{
		if (!CheckCanRun())
		{
			Value = ((!CheckCanRotate()) ? 0f : (Value * 0.0001f));
		}
		InputForward = Value * 100f;
	}

	public override void MoveRight(float Value)
	{
		if (Value != 0f)
		{
			if (!CheckCanRun())
			{
				Value = ((!CheckCanRotate()) ? 0f : (Value * 0.0001f));
			}
			InputRight = Value * 100f;
		}
	}

	protected override void OnUpdate(float DeltaTime)
	{
	}

	protected override void OnEnd()
	{
		base.OnEnd();
		InputForward = 0f;
		InputRight = 0f;
		EvtCollection.Evt_SetCarMoveInput.Invoke(0f, 0f);
	}

	public override EBGUMoveMode GetMoveMode()
	{
		return EBGUMoveMode.CarMontage;
	}
}
