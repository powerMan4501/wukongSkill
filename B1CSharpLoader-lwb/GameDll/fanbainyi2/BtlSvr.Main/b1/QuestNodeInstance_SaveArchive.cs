namespace b1;

public class QuestNodeInstance_SaveArchive : QuestNodeInstance
{
	public override void TriggerInput(string InputPin)
	{
		base.TriggerInput(InputPin);
		TriggerFirstOutput(bFinish: true);
	}

	public override byte[] GetNodeCustomData()
	{
		return null;
	}

	public override void SetNodeCustomData(byte[] CustomData)
	{
	}

	public override void RecoverActiveState()
	{
		TriggerFirstOutput(bFinish: true);
	}
}
