namespace b1;

public class BUS_TickEvenPausedComp : UActorCompBaseCS
{
	private BUC_TickRateData TickRateData;

	public override void OnAttach()
	{
		TickRateData = RequireWritableData<BUC_TickRateData>();
	}

	public override void PreBeginPlay()
	{
		base.PreBeginPlay();
		TickRateData.bTickEvenWhenPaused = true;
	}
}
