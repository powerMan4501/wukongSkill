namespace b1;

public class TaskNodeInstance_Demo820LevelPass : QuestNodeInstance
{
	protected override void PostCreate()
	{
	}

	public override void TriggerInput(string InputPin)
	{
		base.TriggerInput(InputPin);
		BGW_820DemoPlayTimeMgr.Get(base.Owner)?.LevelPass();
		TriggerFirstOutput(bFinish: true);
	}

	public override void Shutdown()
	{
	}

	protected override void Finish()
	{
		base.Finish();
	}

	public override byte[] GetNodeCustomData()
	{
		return new byte[0];
	}

	public override void SetNodeCustomData(byte[] CustomData)
	{
	}

	public override void RecoverActiveState()
	{
	}
}
