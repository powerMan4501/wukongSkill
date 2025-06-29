namespace b1;

public class FBehaviorRightNodeInstance_ExitPhasePerformance : FBehaviorRightNodeInstance
{
	public override string NodeName => B1CalliopeDef.BehaviorNode.ExitPhasePerformance;

	protected override void TriggerInput(string InputPin)
	{
		base.BUSEventCollection.Evt_EnterOrExitPhasePerformance.Invoke(P1: false, "CBG 退出表演状态");
	}
}
