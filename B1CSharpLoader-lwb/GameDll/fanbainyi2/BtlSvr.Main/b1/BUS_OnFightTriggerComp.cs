namespace b1;

public class BUS_OnFightTriggerComp : BUS_TriggerBaseComp
{
	private b1.BUC_OnFightTriggerConfigData OnFightTriggerConfigData;

	public override void OnAttach()
	{
		base.OnAttach();
		OnFightTriggerConfigData = RequireWritableData<b1.BUC_OnFightTriggerConfigData>();
	}

	public override void OnEnter_TriggeredEvent()
	{
		CastOnFightSkill();
	}

	private void CastOnFightSkill()
	{
		BUS_EventCollectionCS.Get(OnFightTriggerConfigData.TargetUnit).Evt_UnitCastSkillTry.Invoke(new FCastSkillInfo(OnFightTriggerConfigData.OnFightSkillID, ECastSkillSourceType.OnFightTrigger));
	}
}
