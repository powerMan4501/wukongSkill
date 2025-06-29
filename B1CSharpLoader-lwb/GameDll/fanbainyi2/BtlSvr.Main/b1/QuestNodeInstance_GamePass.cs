namespace b1;

public class QuestNodeInstance_GamePass : QuestNodeInstance
{
	public override void TriggerInput(string InputPin)
	{
		base.TriggerInput(InputPin);
		BGW_EventCollection.Get(base.Owner).Evt_BGW_TriggerGlobalFSMEvent(EGI_Global.GameLevelPass);
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
