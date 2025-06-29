namespace b1;

public class QuestNodeInstance_QuitGame : QuestNodeInstance
{
	protected override void PostCreate()
	{
	}

	public override void TriggerInput(string InputPin)
	{
		base.TriggerInput(InputPin);
		UGSE_EngineFuncLib.QuitGame(base.Owner);
		TriggerFirstOutput(bFinish: true);
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
		TriggerFirstOutput(bFinish: true);
	}
}
