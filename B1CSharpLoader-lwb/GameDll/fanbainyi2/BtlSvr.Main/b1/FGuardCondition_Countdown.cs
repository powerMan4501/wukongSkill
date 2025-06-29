using CommB1;

namespace b1;

public class FGuardCondition_Countdown : FGuardConditionBase
{
	private float CountdownTime { get; set; }

	private float CountdownTimer { get; set; }

	public override EGuardConditionType ConditionType => EGuardConditionType.Countdown;

	protected override void Start()
	{
		CountdownTimer = 0f;
	}

	protected override void Clean()
	{
		CountdownTime = 0f;
		CountdownTimer = 0f;
	}

	public override bool Initial(CalliopeCustom_TransitionCondition_Battle BattleCondition, PsmNodeInstance InPsmNodeInstance)
	{
		CountdownTime = BattleCondition.CountdownTime;
		return true;
	}

	protected override void OnTick(float DeltaTime)
	{
		if (CountdownTime > 0f)
		{
			CountdownTimer += DeltaTime;
			if (CountdownTimer >= CountdownTime)
			{
				base.QueryState = EQueryState.QuerySuccess;
			}
		}
	}
}
