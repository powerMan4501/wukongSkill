namespace b1;

internal class BUS_StealthTriggerComp : BUS_TriggerBaseComp
{
	private b1.BUC_StealthTriggerConfigData StealthTriggerConfigData;

	public override void OnAttach()
	{
		base.OnAttach();
		StealthTriggerConfigData = RequireWritableData<b1.BUC_StealthTriggerConfigData>();
	}

	public override void OnEnter_TriggeredEvent()
	{
		SwitchStealthMode();
	}

	public override void OnEnter_UnTriggeredEvent()
	{
		SwitchStealthMode();
	}

	private void SwitchStealthMode()
	{
	}
}
