namespace b1;

public class QuestNodeInstance_Finish : QuestNodeInstance
{
	public override void TriggerInput(string InputPin)
	{
		base.TriggerInput(InputPin);
		base.ParentInstance.OnGraphEnd();
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
		base.ParentInstance.OnGraphEnd();
	}
}
