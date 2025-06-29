namespace b1;

public struct FCostDmgInSkill_BuffHandler
{
	private int BindSkillID;

	private bool bAlreadyTriggered;

	public void Clear()
	{
		BindSkillID = -1;
		bAlreadyTriggered = false;
	}

	public void OnSkillStart(int SkillID)
	{
		BindSkillID = SkillID;
	}

	public void OnSkillEnd()
	{
		Clear();
	}

	public bool CanTrigger(int SkillID)
	{
		if (bAlreadyTriggered)
		{
			return false;
		}
		if (BindSkillID != SkillID)
		{
			return false;
		}
		bAlreadyTriggered = true;
		return true;
	}
}
