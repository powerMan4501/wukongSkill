namespace b1;

public class TaskNodeInstance_GameLevelPassFinal : QuestNodeInstance
{
	public override void TriggerInput(string InputPin)
	{
		base.TriggerInput(InputPin);
		BGW_EventCollection.Get(base.Owner).Evt_BGW_TriggerGlobalFSMEvent(EGI_Global.GameLevelPassFinal);
		TriggerFirstOutput(bFinish: true);
	}

	public override byte[] GetNodeCustomData()
	{
		return new byte[0];
	}

	public override void RecoverActiveState()
	{
	}

	public override void SetNodeCustomData(byte[] CustomData)
	{
	}
}
