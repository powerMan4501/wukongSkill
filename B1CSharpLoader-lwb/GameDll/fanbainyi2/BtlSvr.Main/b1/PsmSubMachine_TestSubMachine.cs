namespace b1;

public class PsmSubMachine_TestSubMachine : PsmSubMachine
{
	public class State_LifeIdle : PsmSubMachineState
	{
		public override void OnEnterAction()
		{
		}

		public override void OnExitAction()
		{
		}

		public override void OnTickAction(float InDeltaTime)
		{
		}

		public override void OnResetAction()
		{
		}
	}

	public override string NodeClass => B1CalliopeDef.ProcessMachineNode.TestSubMachine;

	protected override void InitialData(byte[] CustomDataBytes)
	{
		RegisterState(BGW_FlowUtils.NormalAIFsmStateTag.LifeTimeDead);
		RegisterState(BGW_FlowUtils.NormalAIFsmStateTag.LifeTimeReturnHome);
	}
}
