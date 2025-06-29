namespace b1;

public class FBehaviorRightNodeInstance_CheckCurrentCastSkillId : FBehaviorRightNodeInstance
{
	public override string NodeName => B1CalliopeDef.BehaviorNode.CheckCurrentCastSkillId;

	protected override void TriggerInput(string InputPin)
	{
		string key = base.ParentInstance.ParentGraphComp.SkillInstsData.CurrentCastingSkillID.ToString();
		if (base.RightEdges.TryGetValue(key, out var value))
		{
			value.ExecuteOutput();
		}
	}
}
