namespace b1;

public class QuestNodeInstance_Start : QuestNodeInstance
{
	public override bool IsDataValid()
	{
		if (base.Node == null || base.Node.InputEdges.Count > 0)
		{
			return false;
		}
		return true;
	}

	public override void TriggerInput(string InputPin)
	{
		base.TriggerInput(InputPin);
		if (base.Node.OutputEdges.Count == 0)
		{
			Finish();
		}
		else
		{
			TriggerFirstOutput(bFinish: true);
		}
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
		if (base.Node.OutputEdges.Count == 0)
		{
			Finish();
		}
		else
		{
			TriggerFirstOutput(bFinish: true);
		}
	}
}
